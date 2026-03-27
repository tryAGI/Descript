# CLAUDE.md — Descript SDK

## Overview

Auto-generated C# SDK for [Descript](https://www.descript.com/) — AI-powered video and audio editing platform API (v1.2). Import media, create projects, edit with the Underlord AI agent, manage jobs, and export published projects.
OpenAPI spec downloaded from `https://docs.descriptapi.com/openapi.yaml`.

## Build & Test

```bash
dotnet build Descript.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

Bearer token auth (personal API token from Descript Settings > API Tokens):

```csharp
var client = new DescriptClient(apiKey); // DESCRIPT_API_KEY env var
```

Base URL: `https://descriptapi.com/v1`.

## Key Files

- `src/libs/Descript/openapi.yaml` — OpenAPI spec (downloaded from Descript docs, OpenAPI 3.0.0)
- `src/libs/Descript/generate.sh` — Downloads spec, adds top-level `security` array via `yq`, runs autosdk
- `src/libs/Descript/Generated/` — **Never edit** — auto-generated code (204 files)
- `src/tests/IntegrationTests/Tests.cs` — Test helper with bearer auth
- `src/tests/IntegrationTests/Examples/` — Example tests (also generate docs)

## Spec Notes

- `generate.sh` downloads spec from `https://docs.descriptapi.com/openapi.yaml`
- Spec already defines `bearerAuth` security scheme (http/bearer) — no scheme conversion needed
- `yq` adds top-level `security` array (spec only has per-operation security) for AutoSDK constructor generation
- Uses `--exclude-deprecated-operations` flag

## Sub-client Pattern

Descript API has tagged operations generating sub-clients:
- `client.ApiEndpoints.*` — Import media, agent edit, list/get/cancel jobs, check API status
- `client.EditInDescript.*` — Create import URLs for "Edit in Descript" integrations
- `client.ExportFromDescript.*` — Get published project metadata

## Agent Edit Workflow

Two-step async pattern for AI-powered editing:
1. **Submit:** `client.ApiEndpoints.AgentEditJobAsync(projectId, prompt)` — returns `JobId` and `ProjectUrl`
2. **Poll:** `client.ApiEndpoints.GetJobAsync(jobId)` — check `JobState` (`running` -> `stopped`), then inspect `Result` for agent response and changes summary

## Import Media Workflow

Similar async pattern for media import:
1. **Import:** `client.ApiEndpoints.ImportProjectMediaAsync(projectName, addMedia, addCompositions)` — returns `JobId`, `ProjectId`, `ProjectUrl`
2. **Poll:** `client.ApiEndpoints.GetJobAsync(jobId)` — check `JobState` for completion, inspect `Result` for media status and created compositions

## MEAI Integration

No MEAI interface (`IChatClient`, `IEmbeddingGenerator`, `ISpeechToTextClient`) is implemented — Descript is a media editing platform with no matching MEAI interface.
