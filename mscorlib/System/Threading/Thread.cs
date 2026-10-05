using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Security.Principal;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000224 RID: 548
	[Token(Token = "0x2000224")]
	[StructLayout(0)]
	public sealed class Thread : System.Runtime.ConstrainedExecution.CriticalFinalizerObject
	{
		// Token: 0x060012BB RID: 4795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BB")]
		[Address(RVA = "0x4AEFB50", Offset = "0x4AEE750", VA = "0x184AEFB50")]
		private static void AsyncLocalSetCurrentCulture(AsyncLocalValueChangedArgs<System.Globalization.CultureInfo> args)
		{
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BC")]
		[Address(RVA = "0x4AF09C0", Offset = "0x4AEF5C0", VA = "0x184AF09C0")]
		public Thread(ThreadStart start)
		{
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BD")]
		[Address(RVA = "0x4AF0A50", Offset = "0x4AEF650", VA = "0x184AF0A50")]
		public Thread(ParameterizedThreadStart start)
		{
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BE")]
		[Address(RVA = "0x4AF08B0", Offset = "0x4AEF4B0", VA = "0x184AF08B0")]
		public Thread(ParameterizedThreadStart start, int maxStackSize)
		{
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012BF")]
		[Address(RVA = "0x4AF0510", Offset = "0x4AEF110", VA = "0x184AF0510")]
		[MethodImpl(8)]
		public void Start()
		{
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C0")]
		[Address(RVA = "0x4AF0720", Offset = "0x4AEF320", VA = "0x184AF0720")]
		[MethodImpl(8)]
		public void Start(object parameter)
		{
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C1")]
		[Address(RVA = "0x4AF0530", Offset = "0x4AEF130", VA = "0x184AF0530")]
		private void Start(ref StackCrawlMark stackMark)
		{
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		[Token(Token = "0x60012C2")]
		[Address(RVA = "0x4AEFEF0", Offset = "0x4AEEAF0", VA = "0x184AEFEF0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		internal ExecutionContext.Reader GetExecutionContextReader()
		{
			return default(ExecutionContext.Reader);
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		// (set) Token: 0x060012C4 RID: 4804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C5")]
		internal bool ExecutionContextBelongsToCurrentScope
		{
			[Token(Token = "0x60012C3")]
			[Address(RVA = "0x23546A0", Offset = "0x23532A0", VA = "0x1823546A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60012C4")]
			[Address(RVA = "0x4AF0FC0", Offset = "0x4AEFBC0", VA = "0x184AF0FC0")]
			set
			{
			}
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60012C5")]
		[Address(RVA = "0x4AEFF50", Offset = "0x4AEEB50", VA = "0x184AEFF50")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		internal ExecutionContext GetMutableExecutionContext()
		{
			return null;
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C6")]
		[Address(RVA = "0x4AF00C0", Offset = "0x4AEECC0", VA = "0x184AF00C0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		internal void SetExecutionContext(ExecutionContext value, bool belongsToCurrentScope)
		{
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012C7")]
		[Address(RVA = "0x4AF00C0", Offset = "0x4AEECC0", VA = "0x184AF00C0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		internal void SetExecutionContext(ExecutionContext.Reader value, bool belongsToCurrentScope)
		{
		}

		// Token: 0x170001C6 RID: 454
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C6")]
		public ThreadPriority Priority
		{
			[Token(Token = "0x60012C8")]
			[Address(RVA = "0x4AF0160", Offset = "0x4AEED60", VA = "0x184AF0160")]
			set
			{
			}
		}

		// Token: 0x060012C9 RID: 4809
		[Token(Token = "0x60012C9")]
		[Address(RVA = "0x4AF0160", Offset = "0x4AEED60", VA = "0x184AF0160")]
		[MethodImpl(4096)]
		private extern void SetPriorityNative(int priority);

		// Token: 0x060012CA RID: 4810
		[Token(Token = "0x60012CA")]
		[Address(RVA = "0x4AF00A0", Offset = "0x4AEECA0", VA = "0x184AF00A0")]
		[MethodImpl(4096)]
		private extern bool JoinInternal(int millisecondsTimeout);

		// Token: 0x060012CB RID: 4811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CB")]
		[Address(RVA = "0x4AF00B0", Offset = "0x4AEECB0", VA = "0x184AF00B0")]
		public void Join()
		{
		}

		// Token: 0x060012CC RID: 4812
		[Token(Token = "0x60012CC")]
		[Address(RVA = "0x4AF03B0", Offset = "0x4AEEFB0", VA = "0x184AF03B0")]
		[MethodImpl(4096)]
		private static extern void SleepInternal(int millisecondsTimeout);

		// Token: 0x060012CD RID: 4813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012CD")]
		[Address(RVA = "0x4AF03C0", Offset = "0x4AEEFC0", VA = "0x184AF03C0")]
		public static void Sleep(int millisecondsTimeout)
		{
		}

		// Token: 0x060012CE RID: 4814
		[Token(Token = "0x60012CE")]
		[Address(RVA = "0x4AF08A0", Offset = "0x4AEF4A0", VA = "0x184AF08A0")]
		[MethodImpl(4096)]
		private static extern bool YieldInternal();

		// Token: 0x060012CF RID: 4815 RVA: 0x0000EB08 File Offset: 0x0000CD08
		[Token(Token = "0x60012CF")]
		[Address(RVA = "0x4AF08A0", Offset = "0x4AEF4A0", VA = "0x184AF08A0")]
		public static bool Yield()
		{
			return default(bool);
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D0")]
		[Address(RVA = "0x4AF0170", Offset = "0x4AEED70", VA = "0x184AF0170")]
		private void SetStartHelper(System.Delegate start, int maxStackSize)
		{
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001C7")]
		public System.Globalization.CultureInfo CurrentUICulture
		{
			[Token(Token = "0x60012D1")]
			[Address(RVA = "0x4AF0B80", Offset = "0x4AEF780", VA = "0x184AF0B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060012D2 RID: 4818 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60012D2")]
		[Address(RVA = "0x4AEFE40", Offset = "0x4AEEA40", VA = "0x184AEFE40")]
		internal System.Globalization.CultureInfo GetCurrentUICultureNoAppX()
		{
			return null;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C8")]
		public System.Globalization.CultureInfo CurrentCulture
		{
			[Token(Token = "0x60012D3")]
			[Address(RVA = "0x4AF0AF0", Offset = "0x4AEF6F0", VA = "0x184AF0AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60012D4")]
			[Address(RVA = "0x4AF0D10", Offset = "0x4AEF910", VA = "0x184AF0D10")]
			set
			{
			}
		}

		// Token: 0x060012D5 RID: 4821 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60012D5")]
		[Address(RVA = "0x4AEFD60", Offset = "0x4AEE960", VA = "0x184AEFD60")]
		private System.Globalization.CultureInfo GetCurrentCultureNoAppX()
		{
			return null;
		}

		// Token: 0x060012D6 RID: 4822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012D6")]
		[Address(RVA = "0x4AF0C60", Offset = "0x4AEF860", VA = "0x184AF0C60")]
		private static void nativeInitCultureAccessors()
		{
		}

		// Token: 0x060012D7 RID: 4823
		[Token(Token = "0x60012D7")]
		[Address(RVA = "0x4ADEB60", Offset = "0x4ADD760", VA = "0x184ADEB60")]
		[MethodImpl(4096)]
		public static extern void MemoryBarrier();

		// Token: 0x060012D8 RID: 4824
		[Token(Token = "0x60012D8")]
		[Address(RVA = "0x4AEFC70", Offset = "0x4AEE870", VA = "0x184AEFC70")]
		[MethodImpl(4096)]
		private extern void ConstructInternalThread();

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001C9")]
		private InternalThread Internal
		{
			[Token(Token = "0x60012D9")]
			[Address(RVA = "0x4AF0BC0", Offset = "0x4AEF7C0", VA = "0x184AF0BC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001CA")]
		public static System.Runtime.Remoting.Contexts.Context CurrentContext
		{
			[Token(Token = "0x60012DA")]
			[Address(RVA = "0x4AF0AE0", Offset = "0x4AEF6E0", VA = "0x184AF0AE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060012DB RID: 4827
		[Token(Token = "0x60012DB")]
		[Address(RVA = "0x4AEFE00", Offset = "0x4AEEA00", VA = "0x184AEFE00")]
		[MethodImpl(4096)]
		private static extern void GetCurrentThread_icall(ref Thread thread);

		// Token: 0x060012DC RID: 4828 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60012DC")]
		[Address(RVA = "0x4AEFE10", Offset = "0x4AEEA10", VA = "0x184AEFE10")]
		private static Thread GetCurrentThread()
		{
			return null;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060012DD RID: 4829 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170001CB")]
		public static Thread CurrentThread
		{
			[Token(Token = "0x60012DD")]
			[Address(RVA = "0x4AF0B30", Offset = "0x4AEF730", VA = "0x184AF0B30")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
			get
			{
				return null;
			}
		}

		// Token: 0x060012DE RID: 4830
		[Token(Token = "0x60012DE")]
		[Address(RVA = "0x4AEFEE0", Offset = "0x4AEEAE0", VA = "0x184AEFEE0")]
		[MethodImpl(4096)]
		public static extern int GetDomainID();

		// Token: 0x060012DF RID: 4831
		[Token(Token = "0x60012DF")]
		[Address(RVA = "0x4AF0810", Offset = "0x4AEF410", VA = "0x184AF0810")]
		[MethodImpl(4096)]
		private extern bool Thread_internal(System.MulticastDelegate start);

		// Token: 0x060012E0 RID: 4832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E0")]
		[Address(RVA = "0x4AEFD20", Offset = "0x4AEE920", VA = "0x184AEFD20", Slot = "1")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		protected override void Finalize()
		{
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060012E1 RID: 4833 RVA: 0x0000EB20 File Offset: 0x0000CD20
		[Token(Token = "0x170001CC")]
		public bool IsThreadPoolThread
		{
			[Token(Token = "0x60012E1")]
			[Address(RVA = "0x4AF0BF0", Offset = "0x4AEF7F0", VA = "0x184AF0BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x0000EB38 File Offset: 0x0000CD38
		[Token(Token = "0x170001CD")]
		internal bool IsThreadPoolThreadInternal
		{
			[Token(Token = "0x60012E2")]
			[Address(RVA = "0x4AF0BF0", Offset = "0x4AEF7F0", VA = "0x184AF0BF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001CE RID: 462
		// (set) Token: 0x060012E3 RID: 4835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CE")]
		public bool IsBackground
		{
			[Token(Token = "0x60012E3")]
			[Address(RVA = "0x4AF0FD0", Offset = "0x4AEFBD0", VA = "0x184AF0FD0")]
			set
			{
			}
		}

		// Token: 0x060012E4 RID: 4836
		[Token(Token = "0x60012E4")]
		[Address(RVA = "0x4AF0100", Offset = "0x4AEED00", VA = "0x184AF0100")]
		[MethodImpl(4096)]
		private unsafe static extern void SetName_icall(InternalThread thread, char* name, int nameLength);

		// Token: 0x060012E5 RID: 4837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E5")]
		[Address(RVA = "0x4AF0110", Offset = "0x4AEED10", VA = "0x184AF0110")]
		private static void SetName_internal(InternalThread thread, string name)
		{
		}

		// Token: 0x170001CF RID: 463
		// (set) Token: 0x060012E6 RID: 4838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001CF")]
		public string Name
		{
			[Token(Token = "0x60012E6")]
			[Address(RVA = "0x4AF10A0", Offset = "0x4AEFCA0", VA = "0x184AF10A0")]
			set
			{
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060012E7 RID: 4839 RVA: 0x0000EB50 File Offset: 0x0000CD50
		[Token(Token = "0x170001D0")]
		public ThreadState ThreadState
		{
			[Token(Token = "0x60012E7")]
			[Address(RVA = "0x4AF0C30", Offset = "0x4AEF830", VA = "0x184AF0C30")]
			get
			{
				return ThreadState.Running;
			}
		}

		// Token: 0x060012E8 RID: 4840
		[Token(Token = "0x60012E8")]
		[Address(RVA = "0x4AEF1B0", Offset = "0x4AEDDB0", VA = "0x184AEF1B0")]
		[MethodImpl(4096)]
		private static extern void SpinWait_nop();

		// Token: 0x060012E9 RID: 4841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012E9")]
		[Address(RVA = "0x4AF0460", Offset = "0x4AEF060", VA = "0x184AF0460")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static void SpinWait(int iterations)
		{
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012EA")]
		[Address(RVA = "0x4AF0490", Offset = "0x4AEF090", VA = "0x184AF0490")]
		private void StartInternal(object principal, ref StackCrawlMark stackMark)
		{
		}

		// Token: 0x060012EB RID: 4843
		[Token(Token = "0x60012EB")]
		[Address(RVA = "0x4AF03A0", Offset = "0x4AEEFA0", VA = "0x184AF03A0")]
		[MethodImpl(4096)]
		private static extern void SetState(InternalThread thread, ThreadState set);

		// Token: 0x060012EC RID: 4844
		[Token(Token = "0x60012EC")]
		[Address(RVA = "0x4AEFC60", Offset = "0x4AEE860", VA = "0x184AEFC60")]
		[MethodImpl(4096)]
		private static extern void ClrState(InternalThread thread, ThreadState clr);

		// Token: 0x060012ED RID: 4845
		[Token(Token = "0x60012ED")]
		[Address(RVA = "0x4AF0090", Offset = "0x4AEEC90", VA = "0x184AF0090")]
		[MethodImpl(4096)]
		private static extern ThreadState GetState(InternalThread thread);

		// Token: 0x060012EE RID: 4846
		[Token(Token = "0x60012EE")]
		[Address(RVA = "0x4AF0800", Offset = "0x4AEF400", VA = "0x184AF0800")]
		[MethodImpl(4096)]
		private static extern int SystemMaxStackStize();

		// Token: 0x060012EF RID: 4847 RVA: 0x0000EB68 File Offset: 0x0000CD68
		[Token(Token = "0x60012EF")]
		[Address(RVA = "0x4AEFFF0", Offset = "0x4AEEBF0", VA = "0x184AEFFF0")]
		private static int GetProcessDefaultStackSize(int maxStackSize)
		{
			return 0;
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F0")]
		[Address(RVA = "0x4AF0350", Offset = "0x4AEEF50", VA = "0x184AF0350")]
		private void SetStart(System.MulticastDelegate start, int maxStackSize)
		{
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060012F1 RID: 4849 RVA: 0x0000EB80 File Offset: 0x0000CD80
		[Token(Token = "0x170001D1")]
		public int ManagedThreadId
		{
			[Token(Token = "0x60012F1")]
			[Address(RVA = "0x4AEFF20", Offset = "0x4AEEB20", VA = "0x184AEFF20")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			get
			{
				return 0;
			}
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F2")]
		[Address(RVA = "0x4AEFBC0", Offset = "0x4AEE7C0", VA = "0x184AEFBC0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static void BeginCriticalRegion()
		{
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60012F3")]
		[Address(RVA = "0x4AEFC80", Offset = "0x4AEE880", VA = "0x184AEFC80")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static void EndCriticalRegion()
		{
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x0000EB98 File Offset: 0x0000CD98
		[Token(Token = "0x60012F4")]
		[Address(RVA = "0x4AEFF20", Offset = "0x4AEEB20", VA = "0x184AEFF20", Slot = "2")]
		[System.Runtime.InteropServices.ComVisible(false)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x0000EBB0 File Offset: 0x0000CDB0
		[Token(Token = "0x60012F5")]
		[Address(RVA = "0x4AF0820", Offset = "0x4AEF420", VA = "0x184AF0820")]
		private ThreadState ValidateThreadState()
		{
			return ThreadState.Running;
		}

		// Token: 0x04000A8C RID: 2700
		[Token(Token = "0x4000A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static LocalDataStoreMgr s_LocalDataStoreMgr;

		// Token: 0x04000A8D RID: 2701
		[Token(Token = "0x4000A8D")]
		[System.ThreadStatic]
		private static LocalDataStoreHolder s_LocalDataStore;

		// Token: 0x04000A8E RID: 2702
		[Token(Token = "0x4000A8E")]
		[System.ThreadStatic]
		internal static System.Globalization.CultureInfo m_CurrentCulture;

		// Token: 0x04000A8F RID: 2703
		[Token(Token = "0x4000A8F")]
		[System.ThreadStatic]
		internal static System.Globalization.CultureInfo m_CurrentUICulture;

		// Token: 0x04000A90 RID: 2704
		[Token(Token = "0x4000A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AsyncLocal<System.Globalization.CultureInfo> s_asyncLocalCurrentCulture;

		// Token: 0x04000A91 RID: 2705
		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static AsyncLocal<System.Globalization.CultureInfo> s_asyncLocalCurrentUICulture;

		// Token: 0x04000A92 RID: 2706
		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private InternalThread internal_thread;

		// Token: 0x04000A93 RID: 2707
		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object m_ThreadStartArg;

		// Token: 0x04000A94 RID: 2708
		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object pending_exception;

		// Token: 0x04000A95 RID: 2709
		[Token(Token = "0x4000A95")]
		[System.ThreadStatic]
		private static Thread current_thread;

		// Token: 0x04000A96 RID: 2710
		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private System.MulticastDelegate m_Delegate;

		// Token: 0x04000A97 RID: 2711
		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ExecutionContext m_ExecutionContext;

		// Token: 0x04000A98 RID: 2712
		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_ExecutionContextBelongsToOuterScope;

		// Token: 0x04000A99 RID: 2713
		[Token(Token = "0x4000A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private System.Security.Principal.IPrincipal principal;

		// Token: 0x04000A9A RID: 2714
		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int principal_version;
	}
}
