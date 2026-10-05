using System;
using System.Threading;
using Il2CppDummyDll;

namespace Internal.Runtime.Augments
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	internal sealed class RuntimeThread
	{
		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		private RuntimeThread(System.Threading.Thread t)
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x4BEE200", Offset = "0x4BECE00", VA = "0x184BEE200")]
		public static RuntimeThread Create(System.Threading.ParameterizedThreadStart start, int maxStackSize)
		{
			return null;
		}

		// Token: 0x17000040 RID: 64
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000040")]
		public bool IsBackground
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x4BEE350", Offset = "0x4BECF50", VA = "0x184BEE350")]
			set
			{
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x4BEE2E0", Offset = "0x4BECEE0", VA = "0x184BEE2E0")]
		public void Start(object state)
		{
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x4BEE2B0", Offset = "0x4BECEB0", VA = "0x184BEE2B0")]
		public static void Sleep(int millisecondsTimeout)
		{
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x4BEE300", Offset = "0x4BECF00", VA = "0x184BEE300")]
		public static bool Yield()
		{
			return default(bool);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x4BEE2C0", Offset = "0x4BECEC0", VA = "0x184BEE2C0")]
		public static bool SpinWait(int iterations)
		{
			return default(bool);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40")]
		public static int GetCurrentProcessorId()
		{
			return 0;
		}

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly int OptimalMaxSpinWaitsPerSpinIteration;

		// Token: 0x0400026D RID: 621
		[Token(Token = "0x400026D")]
		[FieldOffset(Offset = "0x10")]
		private readonly System.Threading.Thread thread;
	}
}
