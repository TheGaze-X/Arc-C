using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x0200021C RID: 540
	[Token(Token = "0x200021C")]
	public static class Monitor
	{
		// Token: 0x06001280 RID: 4736
		[Token(Token = "0x6001280")]
		[Address(RVA = "0x4D57370", Offset = "0x4D55F70", VA = "0x184D57370")]
		[MethodImpl(4096)]
		public static extern void Enter(object obj);

		// Token: 0x06001281 RID: 4737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x4D572E0", Offset = "0x4D55EE0", VA = "0x184D572E0")]
		public static void Enter(object obj, ref bool lockTaken)
		{
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x4D57950", Offset = "0x4D56550", VA = "0x184D57950")]
		private static void ThrowLockTakenException()
		{
		}

		// Token: 0x06001283 RID: 4739
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x4D57380", Offset = "0x4D55F80", VA = "0x184D57380")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern void Exit(object obj);

		// Token: 0x06001284 RID: 4740 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x4D579D0", Offset = "0x4D565D0", VA = "0x184D579D0")]
		public static bool TryEnter(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0000EA00 File Offset: 0x0000CC00
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x4D57B30", Offset = "0x4D56730", VA = "0x184D57B30")]
		public static bool TryEnter(object obj, int millisecondsTimeout)
		{
			return default(bool);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0000EA18 File Offset: 0x0000CC18
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x4D57390", Offset = "0x4D55F90", VA = "0x184D57390")]
		private static int MillisecondsTimeoutFromTimeSpan(System.TimeSpan timeout)
		{
			return 0;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0000EA30 File Offset: 0x0000CC30
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x4D57C00", Offset = "0x4D56800", VA = "0x184D57C00")]
		public static bool TryEnter(object obj, System.TimeSpan timeout)
		{
			return default(bool);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001288")]
		[Address(RVA = "0x4D57A50", Offset = "0x4D56650", VA = "0x184D57A50")]
		public static void TryEnter(object obj, int millisecondsTimeout, ref bool lockTaken)
		{
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0000EA48 File Offset: 0x0000CC48
		[Token(Token = "0x6001289")]
		[Address(RVA = "0x4D57DB0", Offset = "0x4D569B0", VA = "0x184D57DB0")]
		public static bool Wait(object obj, int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0000EA60 File Offset: 0x0000CC60
		[Token(Token = "0x600128A")]
		[Address(RVA = "0x4D57DB0", Offset = "0x4D569B0", VA = "0x184D57DB0")]
		public static bool Wait(object obj, int millisecondsTimeout)
		{
			return default(bool);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128B")]
		[Address(RVA = "0x4D57740", Offset = "0x4D56340", VA = "0x184D57740")]
		public static void Pulse(object obj)
		{
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128C")]
		[Address(RVA = "0x4D57670", Offset = "0x4D56270", VA = "0x184D57670")]
		public static void PulseAll(object obj)
		{
		}

		// Token: 0x0600128D RID: 4749
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x4D57490", Offset = "0x4D56090", VA = "0x184D57490")]
		[MethodImpl(4096)]
		private static extern bool Monitor_test_synchronised(object obj);

		// Token: 0x0600128E RID: 4750
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x4D57480", Offset = "0x4D56080", VA = "0x184D57480")]
		[MethodImpl(4096)]
		private static extern void Monitor_pulse(object obj);

		// Token: 0x0600128F RID: 4751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600128F")]
		[Address(RVA = "0x4D57520", Offset = "0x4D56120", VA = "0x184D57520")]
		private static void ObjPulse(object obj)
		{
		}

		// Token: 0x06001290 RID: 4752
		[Token(Token = "0x6001290")]
		[Address(RVA = "0x4D57470", Offset = "0x4D56070", VA = "0x184D57470")]
		[MethodImpl(4096)]
		private static extern void Monitor_pulse_all(object obj);

		// Token: 0x06001291 RID: 4753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001291")]
		[Address(RVA = "0x4D574B0", Offset = "0x4D560B0", VA = "0x184D574B0")]
		private static void ObjPulseAll(object obj)
		{
		}

		// Token: 0x06001292 RID: 4754
		[Token(Token = "0x6001292")]
		[Address(RVA = "0x4D574A0", Offset = "0x4D560A0", VA = "0x184D574A0")]
		[MethodImpl(4096)]
		private static extern bool Monitor_wait(object obj, int ms);

		// Token: 0x06001293 RID: 4755 RVA: 0x0000EA78 File Offset: 0x0000CC78
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x4D57590", Offset = "0x4D56190", VA = "0x184D57590")]
		private static bool ObjWait(bool exitContext, int millisecondsTimeout, object obj)
		{
			return default(bool);
		}

		// Token: 0x06001294 RID: 4756
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x4D57EE0", Offset = "0x4D56AE0", VA = "0x184D57EE0")]
		[MethodImpl(4096)]
		private static extern void try_enter_with_atomic_var(object obj, int millisecondsTimeout, ref bool lockTaken);

		// Token: 0x06001295 RID: 4757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001295")]
		[Address(RVA = "0x4D57810", Offset = "0x4D56410", VA = "0x184D57810")]
		private static void ReliableEnterTimeout(object obj, int timeout, ref bool lockTaken)
		{
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x4D578D0", Offset = "0x4D564D0", VA = "0x184D578D0")]
		private static void ReliableEnter(object obj, ref bool lockTaken)
		{
		}
	}
}
