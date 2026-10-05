using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace System.Diagnostics
{
	// Token: 0x0200010D RID: 269
	[Token(Token = "0x200010D")]
	[DefaultEvent("Exited")]
	[MonitoringDescription("Provides access to local and remote processes, enabling starting and stopping of local processes.")]
	[DefaultProperty("StartInfo")]
	public class Process : Component
	{
		// Token: 0x0600069C RID: 1692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x510B7A0", Offset = "0x510A3A0", VA = "0x18510B7A0")]
		public Process()
		{
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x510B820", Offset = "0x510A420", VA = "0x18510B820")]
		private Process(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo)
		{
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x17000118")]
		[Browsable(false)]
		[MonitoringDescription("Indicates if the process component is associated with a real process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		private bool Associated
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x510B8C0", Offset = "0x510A4C0", VA = "0x18510B8C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x17000119")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The value returned from the associated process when it terminated.")]
		public int ExitCode
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x510B8D0", Offset = "0x510A4D0", VA = "0x18510B8D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x1700011A")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[MonitoringDescription("Indicates if the associated process has been terminated.")]
		public bool HasExited
		{
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x510BAF0", Offset = "0x510A6F0", VA = "0x18510BAF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x1700011B")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("Returns the native handle for this process.   The handle is only available if the process was started using this component.")]
		[Browsable(false)]
		public IntPtr Handle
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x510BA00", Offset = "0x510A600", VA = "0x18510BA00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x1700011C")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[MonitoringDescription("The unique identifier for the process.")]
		public int Id
		{
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x510BE90", Offset = "0x510AA90", VA = "0x18510BE90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011D")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[Browsable(false)]
		[MonitoringDescription("Specifies information used to start a process.")]
		public ProcessStartInfo StartInfo
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x510C340", Offset = "0x510AF40", VA = "0x18510C340")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011E")]
		[DefaultValue(null)]
		[MonitoringDescription("The object used to marshal the event handler calls issued as a result of a Process exit.")]
		[Browsable(false)]
		public ISynchronizeInvoke SynchronizingObject
		{
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x510C430", Offset = "0x510B030", VA = "0x18510C430")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011F")]
		[Browsable(false)]
		[MonitoringDescription("Standard output stream of the process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public StreamReader StandardOutput
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x510C240", Offset = "0x510AE40", VA = "0x18510C240")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000120")]
		[MonitoringDescription("Standard error stream of the process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public StreamReader StandardError
		{
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x510C140", Offset = "0x510AD40", VA = "0x18510C140")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x5109B20", Offset = "0x5108720", VA = "0x185109B20")]
		private void ReleaseProcessHandle(SafeProcessHandle handle)
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x51087F0", Offset = "0x51073F0", VA = "0x1851087F0")]
		private void CompletionCallback(object context, bool wasSignaled)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x5108B00", Offset = "0x5107700", VA = "0x185108B00", Slot = "14")]
		protected override void Dispose(bool disposing)
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x51085A0", Offset = "0x51071A0", VA = "0x1851085A0")]
		public void Close()
		{
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x5108B50", Offset = "0x5107750", VA = "0x185108B50")]
		private void EnsureState(Process.State state)
		{
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x5108E00", Offset = "0x5107A00", VA = "0x185108E00")]
		private void EnsureWatchingForExit()
		{
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x51090C0", Offset = "0x5107CC0", VA = "0x1851090C0")]
		public static Process GetCurrentProcess()
		{
			return null;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x5109610", Offset = "0x5108210", VA = "0x185109610")]
		protected void OnExited()
		{
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x51091A0", Offset = "0x5107DA0", VA = "0x1851091A0")]
		private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited)
		{
			return null;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x5109510", Offset = "0x5108110", VA = "0x185109510")]
		private SafeProcessHandle GetProcessHandle(int access)
		{
			return null;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x5109880", Offset = "0x5108480", VA = "0x185109880")]
		private SafeProcessHandle OpenProcessHandle(int access)
		{
			return null;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x5109AD0", Offset = "0x51086D0", VA = "0x185109AD0")]
		public void Refresh()
		{
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x5109B40", Offset = "0x5108740", VA = "0x185109B40")]
		private void SetProcessHandle(SafeProcessHandle processHandle)
		{
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x4E1B100", Offset = "0x4E19D00", VA = "0x184E1B100")]
		private void SetProcessId(int processId)
		{
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x510B1F0", Offset = "0x5109DF0", VA = "0x18510B1F0")]
		public bool Start()
		{
			return default(bool);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x5109520", Offset = "0x5108120", VA = "0x185109520")]
		public void Kill()
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x510B3A0", Offset = "0x5109FA0", VA = "0x18510B3A0")]
		private void StopWatchingForExit()
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x510B4D0", Offset = "0x510A0D0", VA = "0x18510B4D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x510B5E0", Offset = "0x510A1E0", VA = "0x18510B5E0")]
		public bool WaitForExit(int milliseconds)
		{
			return default(bool);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x510B790", Offset = "0x510A390", VA = "0x18510B790")]
		public void WaitForExit()
		{
		}

		// Token: 0x060006BB RID: 1723
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x5109940", Offset = "0x5108540", VA = "0x185109940")]
		[MethodImpl(4096)]
		private static extern string ProcessName_icall(IntPtr handle);

		// Token: 0x060006BC RID: 1724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x5109950", Offset = "0x5108550", VA = "0x185109950")]
		private static string ProcessName_internal(SafeProcessHandle handle)
		{
			return null;
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060006BD RID: 1725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000121")]
		[MonitoringDescription("The name of this process.")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string ProcessName
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x510BEF0", Offset = "0x510AAF0", VA = "0x18510BEF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060006BE RID: 1726
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		private static extern bool ShellExecuteEx_internal(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo);

		// Token: 0x060006BF RID: 1727
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x4ACA7A0", Offset = "0x4AC93A0", VA = "0x184ACA7A0")]
		[MethodImpl(4096)]
		private static extern bool CreateProcess_internal(ProcessStartInfo startInfo, IntPtr stdin, IntPtr stdout, IntPtr stderr, ref Process.ProcInfo procInfo);

		// Token: 0x060006C0 RID: 1728 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x510AD40", Offset = "0x5109940", VA = "0x18510AD40")]
		private bool StartWithShellExecuteEx(ProcessStartInfo startInfo)
		{
			return default(bool);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x5108810", Offset = "0x5107410", VA = "0x185108810")]
		private static void CreatePipe(out IntPtr read, out IntPtr write, bool writeDirection)
		{
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x17000122")]
		private static bool IsWindows
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x510BEB0", Offset = "0x510AAB0", VA = "0x18510BEB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x5109B80", Offset = "0x5108780", VA = "0x185109B80")]
		private bool StartWithCreateProcess(ProcessStartInfo startInfo)
		{
			return default(bool);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x5108F40", Offset = "0x5107B40", VA = "0x185108F40")]
		private static void FillUserInfo(ProcessStartInfo startInfo, ref Process.ProcInfo procInfo)
		{
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x5109A20", Offset = "0x5108620", VA = "0x185109A20")]
		private void RaiseOnExited()
		{
		}

		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		[FieldOffset(Offset = "0x28")]
		private bool haveProcessId;

		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		[FieldOffset(Offset = "0x2C")]
		private int processId;

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x30")]
		private bool haveProcessHandle;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x38")]
		private SafeProcessHandle m_processHandle;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x40")]
		private bool isRemoteMachine;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0x48")]
		private string machineName;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x50")]
		private int m_processAccess;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x58")]
		private ProcessThreadCollection threads;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x60")]
		private ProcessModuleCollection modules;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x68")]
		private bool haveWorkingSetLimits;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x69")]
		private bool havePriorityClass;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x70")]
		private ProcessStartInfo startInfo;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x78")]
		private bool watchForExit;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x79")]
		private bool watchingForExit;

		// Token: 0x0400049C RID: 1180
		[Token(Token = "0x400049C")]
		[FieldOffset(Offset = "0x80")]
		private EventHandler onExited;

		// Token: 0x0400049D RID: 1181
		[Token(Token = "0x400049D")]
		[FieldOffset(Offset = "0x88")]
		private bool exited;

		// Token: 0x0400049E RID: 1182
		[Token(Token = "0x400049E")]
		[FieldOffset(Offset = "0x8C")]
		private int exitCode;

		// Token: 0x0400049F RID: 1183
		[Token(Token = "0x400049F")]
		[FieldOffset(Offset = "0x90")]
		private bool signaled;

		// Token: 0x040004A0 RID: 1184
		[Token(Token = "0x40004A0")]
		[FieldOffset(Offset = "0x91")]
		private bool haveExitTime;

		// Token: 0x040004A1 RID: 1185
		[Token(Token = "0x40004A1")]
		[FieldOffset(Offset = "0x92")]
		private bool raisedOnExited;

		// Token: 0x040004A2 RID: 1186
		[Token(Token = "0x40004A2")]
		[FieldOffset(Offset = "0x98")]
		private RegisteredWaitHandle registeredWaitHandle;

		// Token: 0x040004A3 RID: 1187
		[Token(Token = "0x40004A3")]
		[FieldOffset(Offset = "0xA0")]
		private WaitHandle waitHandle;

		// Token: 0x040004A4 RID: 1188
		[Token(Token = "0x40004A4")]
		[FieldOffset(Offset = "0xA8")]
		private ISynchronizeInvoke synchronizingObject;

		// Token: 0x040004A5 RID: 1189
		[Token(Token = "0x40004A5")]
		[FieldOffset(Offset = "0xB0")]
		private StreamReader standardOutput;

		// Token: 0x040004A6 RID: 1190
		[Token(Token = "0x40004A6")]
		[FieldOffset(Offset = "0xB8")]
		private StreamWriter standardInput;

		// Token: 0x040004A7 RID: 1191
		[Token(Token = "0x40004A7")]
		[FieldOffset(Offset = "0xC0")]
		private StreamReader standardError;

		// Token: 0x040004A8 RID: 1192
		[Token(Token = "0x40004A8")]
		[FieldOffset(Offset = "0xC8")]
		private bool disposed;

		// Token: 0x040004A9 RID: 1193
		[Token(Token = "0x40004A9")]
		[FieldOffset(Offset = "0xCC")]
		private Process.StreamReadMode outputStreamReadMode;

		// Token: 0x040004AA RID: 1194
		[Token(Token = "0x40004AA")]
		[FieldOffset(Offset = "0xD0")]
		private Process.StreamReadMode errorStreamReadMode;

		// Token: 0x040004AB RID: 1195
		[Token(Token = "0x40004AB")]
		[FieldOffset(Offset = "0xD4")]
		private Process.StreamReadMode inputStreamReadMode;

		// Token: 0x040004AC RID: 1196
		[Token(Token = "0x40004AC")]
		[FieldOffset(Offset = "0xD8")]
		internal AsyncStreamReader output;

		// Token: 0x040004AD RID: 1197
		[Token(Token = "0x40004AD")]
		[FieldOffset(Offset = "0xE0")]
		internal AsyncStreamReader error;

		// Token: 0x040004AE RID: 1198
		[Token(Token = "0x40004AE")]
		[FieldOffset(Offset = "0xE8")]
		private string process_name;

		// Token: 0x0200010E RID: 270
		[Token(Token = "0x200010E")]
		private enum StreamReadMode
		{
			// Token: 0x040004B0 RID: 1200
			[Token(Token = "0x40004B0")]
			undefined,
			// Token: 0x040004B1 RID: 1201
			[Token(Token = "0x40004B1")]
			syncMode,
			// Token: 0x040004B2 RID: 1202
			[Token(Token = "0x40004B2")]
			asyncMode
		}

		// Token: 0x0200010F RID: 271
		[Token(Token = "0x200010F")]
		private enum State
		{
			// Token: 0x040004B4 RID: 1204
			[Token(Token = "0x40004B4")]
			HaveId = 1,
			// Token: 0x040004B5 RID: 1205
			[Token(Token = "0x40004B5")]
			IsLocal,
			// Token: 0x040004B6 RID: 1206
			[Token(Token = "0x40004B6")]
			IsNt = 4,
			// Token: 0x040004B7 RID: 1207
			[Token(Token = "0x40004B7")]
			HaveProcessInfo = 8,
			// Token: 0x040004B8 RID: 1208
			[Token(Token = "0x40004B8")]
			Exited = 16,
			// Token: 0x040004B9 RID: 1209
			[Token(Token = "0x40004B9")]
			Associated = 32,
			// Token: 0x040004BA RID: 1210
			[Token(Token = "0x40004BA")]
			IsWin2k = 64,
			// Token: 0x040004BB RID: 1211
			[Token(Token = "0x40004BB")]
			HaveNtProcessInfo = 12
		}

		// Token: 0x02000110 RID: 272
		[Token(Token = "0x2000110")]
		private struct ProcInfo
		{
			// Token: 0x040004BC RID: 1212
			[Token(Token = "0x40004BC")]
			[FieldOffset(Offset = "0x0")]
			public IntPtr process_handle;

			// Token: 0x040004BD RID: 1213
			[Token(Token = "0x40004BD")]
			[FieldOffset(Offset = "0x8")]
			public int pid;

			// Token: 0x040004BE RID: 1214
			[Token(Token = "0x40004BE")]
			[FieldOffset(Offset = "0x10")]
			public string[] envVariables;

			// Token: 0x040004BF RID: 1215
			[Token(Token = "0x40004BF")]
			[FieldOffset(Offset = "0x18")]
			public string UserName;

			// Token: 0x040004C0 RID: 1216
			[Token(Token = "0x40004C0")]
			[FieldOffset(Offset = "0x20")]
			public string Domain;

			// Token: 0x040004C1 RID: 1217
			[Token(Token = "0x40004C1")]
			[FieldOffset(Offset = "0x28")]
			public IntPtr Password;

			// Token: 0x040004C2 RID: 1218
			[Token(Token = "0x40004C2")]
			[FieldOffset(Offset = "0x30")]
			public bool LoadUserProfile;
		}
	}
}
