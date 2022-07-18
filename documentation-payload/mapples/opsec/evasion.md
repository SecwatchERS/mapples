+++
title = "Evasion"
chapter = false
weight = 102
+++

## Evasion in Mapples

Mapples has several commands to modify post-exploitation parameters when performing a variety of tasks. These commands are:

- [`spawnto_x64`](/agents/mapples/commands/spawnto_x64/)
- [`spawnto_x86`](/agents/mapples/commands/spawnto_x86/)
- [`ppid`](/agents/mapples/commands/ppid/)
- [`blockdlls`](/agents/mapples/commands/blockdlls/)
- [`get_injection_techniques`](/agents/mapples/commands/get_injection_techniques/)
- [`set_injection_technique`](/agents/mapples/commands/set_injection_technique/)

### SpawnTo Commands

These commands are used to specify what process should be spawned in any [fork and run](/agents/mapples/opsec/forkandrun) tasking, such as [`execute_assembly`](/agents/mapples/commands/execute_assembly). By default, these values are set to `rundll32.exe`. 

### Parent Process ID

Sometimes it's desirable to have sacrificial jobs appear as though they were spawned under another parent process besides your own. This prevents attribution of that child process's activities to your currently executing Mapples agent. To change the parent process for all jobs that spawn new processes, issue `ppid [pid]`.

{{% notice warning %}}
Here be dragons! Changing the PPID of processes can cause agent stability issues in some scenarios. For example: You should _never_ change the parent process to a process that is outside your current desktop session.
{{% /notice %}}

### Block DLLs

This prevents non-Microsoft signed DLLs from loading into your child processes. While most EDR software is now signed by Microsoft, this can occasionally help prevent side-loading of unwanted DLLs.

### Injection Technique Management

Mapples has several post-exploitation tasks that leverage process injection. A full discussion of this can be found at the [injection documentation page](/agents/mapples/opsec/injection).