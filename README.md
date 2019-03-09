# SuperProcessKiller
This is an app to help people that are still on Windows 7 to kill processes that like to multiply...

This is a .NET 4.6.1 WinForms application. It uses System.Diagnostics.Process to find and kill processes. The UI displays the active processes and the user has a choice to either 'Kill' or 'Kill (Safe)'. The latter will attempt to close the program gracefully (CloseMainWindow()), whereas the standard 'Kill' option will attempt to close the program regardless of its state (Kill()). For example, if you have a context window open on a program, the 'Kill' option will close the program, whereas the 'Kill (Safe)' option will not.

This can also be used via the command line:
>SPK.exe chrome
>SPK.exe chrome s

The first example will be option 'Kill' and the second will be 'Kill (Safe)'.

The primary use case for this application is on Windows 7, where the standard Task Manager does not group processes together, making applications that have multiple instances quite frustrating to close when they stop responding. This makes the task quite painless for the user, and the user has a choice as to whether it will be painless for the application too. 
