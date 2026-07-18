# AGENTS.md

Guidance for AI coding assistants working in this repository. Read this before
making changes.

## What this is

`Athar-Web` — an **ABP Framework 10.5.0** layered solution (the `app` template),
scaffolded with ABP Studio. Solution file is `Athar.slnx` at the repo root; `dotnet`
commands without an explicit path resolve it.

**.NET 10** backend · **Angular 21** frontend · **PostgreSQL** · LeptonX Lite theme ·
OpenIddict auth · localization **English + Arabic**, English default.

## Rules that are always true

- **Dependency direction is one-way.** Higher layers depend on lower, never the
  reverse: `Domain.Shared` → `Domain` → `Application.Contracts` → `Application` →
  `HttpApi` → `HttpApi.Host`.
- **The Application layer never touches `DbContext`.** Go through `IRepository` or a
  repository interface.
- **Entities never leak into DTOs.** Controllers and services depend on interfaces,
  not implementations.
- **Localization means both cultures.** Every key added to
  `src/Athar.Domain.Shared/Localization/Athar/en.json` needs its `ar.json` counterpart.
  Adding only English is the common mistake.
- **Object mapping is [Mapperly](https://mapperly.riok.app), not AutoMapper.** It
  arrives via `Volo.Abp.Mapperly`, so it appears in no `.csproj` — see
  `src/Athar.Application/AtharApplicationMappers.cs`.

## Commands

```bash
# Backend
dotnet build
dotnet test
dotnet test --filter "FullyQualifiedName~BookAppService_Tests"   # single class
dotnet run --project src/Athar.HttpApi.Host                        # https://localhost:44340, Swagger at /swagger

# First-time bootstrap (build, install-libs, migrate + seed, dev cert)
pwsh etc/scripts/initialize-solution.ps1
pwsh etc/scripts/migrate-database.ps1                            # migrate + seed only

# Migrations — from src/Athar.EntityFrameworkCore
dotnet ef migrations add <Name>
dotnet run --project ../Athar.DbMigrator                           # applies AND seeds; prefer over `ef database update`

# Frontend — from angular/ (yarn; yarn.lock is the lockfile)
yarn install
yarn start                 # http://localhost:4200
yarn build:prod            # what CI and Docker run
yarn test                  # vitest
yarn lint                  # NOT a CI gate — run it locally
abp generate-proxy -t ng   # regenerate proxies after backend contract changes
```

## Gotcha: `appsettings.secrets.json`

It is gitignored, but ABP references it as a copy-to-output content file in several
projects (`DbMigrator`, `TestBase`, `ConsoleTestApp`). **A clean checkout fails to
build with MSB3030 until each referenced file exists on disk** — seed an empty `{}`
where missing. Keep real credentials out of it; use `dotnet user-secrets` or
environment variables.

## Where the detailed rules live

Full ABP guidance is **not** duplicated here. It lives in:

- **`.cursor/rules/`** — 14 `.mdc` files, notably
  `framework/common/dependency-rules.mdc` and `development-flow.mdc`
- **The `abp-claude-code` plugin** — the same material as on-demand skills, plus the
  ABP Studio MCP server. This repository is public, so it deliberately does *not* check
  in a marketplace reference; NextStage-SY members can install it by hand with
  `/plugin marketplace add NextStage-SY/abp-claude-code`. It is an internal repository
  and not reachable from outside the organisation.

Those two are the same content: ABP Studio wrote the `.mdc` files from ABP's own
upstream Claude skills. **They are not independent sources — don't reconcile them
against each other**, and prefer the plugin's copy, which tracks upstream.

## Contributing

Trunk-based on `main`, short-lived branches, PR + 1 approval + green CI, squash merge.
CI runs build and test only — no deploy. Review routing is in `.github/CODEOWNERS`.
Full policy lives in the internal Agency Handbook, `03-delivery/engineering-standards.md`.
