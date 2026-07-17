# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this repo is

`Athar-Web` — the ABP Framework application for Athar (أثر), an Islamic knowledge platform. This is a product-specific repo; see the workspace-root `CLAUDE.md` for the general ABP layered-architecture conventions (dependency rules, Mapperly, DDD layering) that apply here. Solution prefix is `Athar` (`Athar.slnx`).

Confirmed stack for this repo: .NET 10 (`net10.0`), ABP 10.5.0, Angular 21.2.0 (yarn, `angular/yarn.lock`), PostgreSQL, LeptonX Lite, OpenIddict, EN+AR localization, Mapperly (no AutoMapper).

## Commands

Standard commands are in the workspace-root CLAUDE.md (`dotnet build`, `dotnet test`, `etc/scripts/initialize-solution.ps1`, etc.) — resolve `Athar.slnx` automatically.

Angular-specific, from `angular/`:
```bash
yarn symlinks:setup     # cd scripts && pwsh ./setup-symlinks.ps1
yarn symlinks:remove    # cd scripts && pwsh ./remove-symlinks.ps1
```

## Secrets gotcha

`appsettings.secrets.json` is referenced (as copy-to-output content) by three projects here: `src/Athar.DbMigrator`, `test/Athar.TestBase` (pulled transitively into all other test projects via project reference), and `test/Athar.HttpApi.Client.ConsoleTestApp`. A clean checkout fails to build (MSB3030) until each exists on disk — seed an empty `{}` where missing.

## `.cursor/rules/`

This repo has `.cursor/rules/` (framework/common, framework/data, framework/testing, framework/ui, template/app), but the content is generic, unmodified ABP template boilerplate — not customized for Athar — so treat it as a restatement of standard ABP conventions rather than a source of project-specific rules.

If ABP Studio MCP tools are connected in this session, `.cursor/rules/mcp-studio.mdc` documents the available tool set (solution structure, run profiles, monitoring, etc.).
