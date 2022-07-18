+++
title = "Fork and Run Commands"
chapter = false
weight = 102
+++

## What is Fork and Run?

"Fork and Run" is an agent architecture that spawns sacrificial processes in a suspended state to inject shellcode into.

## Fork and Run in Mapples

Mapples uses the fork and run architecture for a variety of jobs. These jobs will all first spawn a new process specified by the [`spawnto_x86`](/agents/mapples/commands/spawnto_x86) or [`spawnto_x64`](/agents/mapples/commands/spawnto_x64) commands. The parent process of these new processes is specified by the [`ppid`](/agents/mapples/commands/ppid/) command. Once the process is spawned, Mapples will use the currently set injection technique to inject into the remote process.

The following commands use the fork and run architecture:

- [`execute_assembly`](/agents/mapples/commands/execute_assembly/)
- [`mimikatz`](/agents/mapples/commands/mimikatz/)
- [`powerpick`](/agents/mapples/commands/powerpick/)
- [`printspoofer`](/agents/mapples/commands/printspoofer/)
- [`pth`](/agents/mapples/commands/pth/)
- [`dcsync`](/agents/mapples/commands/pth/)
- [`spawn`](/agents/mapples/commands/spawn/)
- [`execute_pe`](/agents/mapples/commands/execute_pe/)