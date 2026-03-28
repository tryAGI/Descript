#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://docs.descriptapi.com/openapi.yaml

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -L -o openapi.yaml https://docs.descriptapi.com/openapi.yaml

# Auth: --security-scheme overrides per-operation-only bearerAuth with top-level security.
autosdk generate openapi.yaml \
  --namespace Descript \
  --clientClassName DescriptClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer
