+++
title = "Process Injection"
chapter = false
weight = 102
+++

## Process Injection in Mapples

Mapples has abstracted process injection into its own project and has the following techniques implemented:
- CreateRemoteThread
- QueueUserAPC (early bird)
- NtCreateThreadEx (via Syscalls)

As an operator, sometimes one injection technique is more desirable than another. To facilitate this, the [`get_injection_techniques`](/agents/mapples/commands/get_injection_techniques) command will list all currently loaded injection techniques the agent knows about. Similarly, [`set_injection_technique`](/agents/mapples/commands/set_injection_technique) will update the currently used injection technique throughout all post-exploitation jobs.

## Commands Leveraging Injection

All of Mapples's [fork and run commands](/agents/mapples/opsec/forkandrun/) use injection to inject into a sacrificial process; however, there are additional commands that inject into other processes. Those commands are:

- [`assembly_inject`](/agents/mapples/commands/assembly_inject/)
- [`inject`](/agents/mapples/commands/inject/)
- [`keylog_inject`](/agents/mapples/commands/keylog/)
- [`psinject`](/agents/mapples/commands/psinject/)
- [`shinject`](/agents/mapples/commands/shinject/)
- [`screenshot_inject`](/agents/mapples/commands/screenshot_inject)

{{% notice info %}}
Some injection techniques are incompatible with the aforementioned commands. For example: If QueueUserAPC is in use, the above commands will fail as it leverages the early bird version of QueueUserAPC, not the APC bombing technique. 
{{% /notice %}}