#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://docs.descriptapi.com/openapi.yaml
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error -L -o openapi.yaml https://docs.descriptapi.com/openapi.yaml

# Auth: --security-scheme overrides per-operation-only bearerAuth with top-level security.
autosdk generate openapi.yaml \
  --namespace Descript \
  --clientClassName DescriptClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer

rm -rf ../../cli/Descript.CLI

autosdk cli-project openapi.yaml \
  --output ../../cli/Descript.CLI \
  --sdk-project ../../libs/Descript/Descript.csproj \
  --targetFramework net10.0 \
  --namespace Descript \
  --clientClassName DescriptClient \
  --package-id Descript.CLI \
  --tool-command-name descript \
  --user-secrets-id Descript.CLI \
  --api-key-env-var DESCRIPT_API_KEY \
  --base-url-env-var DESCRIPT_BASE_URL \
  --cli-credential-file \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
