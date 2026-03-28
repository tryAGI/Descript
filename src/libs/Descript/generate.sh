#!/usr/bin/env bash
set -euo pipefail

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://docs.descriptapi.com/openapi.yaml

# Add top-level security array
yq -i '.security = [{"bearerAuth": []}]' openapi.yaml

autosdk generate openapi.yaml \
  --namespace Descript \
  --clientClassName DescriptClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations
