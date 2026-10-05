using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000236 RID: 566
	[Token(Token = "0x2000236")]
	public static class Interlocked
	{
		// Token: 0x0600134F RID: 4943
		[Token(Token = "0x600134F")]
		[Address(RVA = "0x4ADEA40", Offset = "0x4ADD640", VA = "0x184ADEA40")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern int CompareExchange(ref int location1, int value, int comparand);

		// Token: 0x06001350 RID: 4944
		[Token(Token = "0x6001350")]
		[Address(RVA = "0x4ADEA20", Offset = "0x4ADD620", VA = "0x184ADEA20")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		internal static extern int CompareExchange(ref int location1, int value, int comparand, ref bool succeeded);

		// Token: 0x06001351 RID: 4945
		[Token(Token = "0x6001351")]
		[Address(RVA = "0x4ADEA10", Offset = "0x4ADD610", VA = "0x184ADEA10")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		private static extern void CompareExchange(ref object location1, ref object value, ref object comparand, ref object result);

		// Token: 0x06001352 RID: 4946 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001352")]
		[Address(RVA = "0x4ADEA50", Offset = "0x4ADD650", VA = "0x184ADEA50")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static object CompareExchange(ref object location1, object value, object comparand)
		{
			return null;
		}

		// Token: 0x06001353 RID: 4947
		[Token(Token = "0x6001353")]
		[Address(RVA = "0x4ADEA90", Offset = "0x4ADD690", VA = "0x184ADEA90")]
		[MethodImpl(4096)]
		public static extern float CompareExchange(ref float location1, float value, float comparand);

		// Token: 0x06001354 RID: 4948
		[Token(Token = "0x6001354")]
		[Address(RVA = "0x4ADEAB0", Offset = "0x4ADD6B0", VA = "0x184ADEAB0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern int Decrement(ref int location);

		// Token: 0x06001355 RID: 4949
		[Token(Token = "0x6001355")]
		[Address(RVA = "0x4ADEB50", Offset = "0x4ADD750", VA = "0x184ADEB50")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern int Increment(ref int location);

		// Token: 0x06001356 RID: 4950
		[Token(Token = "0x6001356")]
		[Address(RVA = "0x4ADEB40", Offset = "0x4ADD740", VA = "0x184ADEB40")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern long Increment(ref long location);

		// Token: 0x06001357 RID: 4951
		[Token(Token = "0x6001357")]
		[Address(RVA = "0x4ADEAE0", Offset = "0x4ADD6E0", VA = "0x184ADEAE0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern int Exchange(ref int location1, int value);

		// Token: 0x06001358 RID: 4952
		[Token(Token = "0x6001358")]
		[Address(RVA = "0x4ADEAC0", Offset = "0x4ADD6C0", VA = "0x184ADEAC0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		private static extern void Exchange(ref object location1, ref object value, ref object result);

		// Token: 0x06001359 RID: 4953 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001359")]
		[Address(RVA = "0x4ADEAF0", Offset = "0x4ADD6F0", VA = "0x184ADEAF0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static object Exchange(ref object location1, object value)
		{
			return null;
		}

		// Token: 0x0600135A RID: 4954
		[Token(Token = "0x600135A")]
		[Address(RVA = "0x4ADEB20", Offset = "0x4ADD720", VA = "0x184ADEB20")]
		[MethodImpl(4096)]
		public static extern float Exchange(ref float location1, float value);

		// Token: 0x0600135B RID: 4955
		[Token(Token = "0x600135B")]
		[Address(RVA = "0x4ADEA30", Offset = "0x4ADD630", VA = "0x184ADEA30")]
		[MethodImpl(4096)]
		public static extern long CompareExchange(ref long location1, long value, long comparand);

		// Token: 0x0600135C RID: 4956
		[Token(Token = "0x600135C")]
		[Address(RVA = "0x4ADEA30", Offset = "0x4ADD630", VA = "0x184ADEA30")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern System.IntPtr CompareExchange(ref System.IntPtr location1, System.IntPtr value, System.IntPtr comparand);

		// Token: 0x0600135D RID: 4957
		[Token(Token = "0x600135D")]
		[Address(RVA = "0x4ADEAA0", Offset = "0x4ADD6A0", VA = "0x184ADEAA0")]
		[MethodImpl(4096)]
		public static extern double CompareExchange(ref double location1, double value, double comparand);

		// Token: 0x0600135E RID: 4958 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600135E")]
		[System.Runtime.InteropServices.ComVisible(false)]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[Intrinsic]
		public static T CompareExchange<T>(ref T location1, T value, T comparand) where T : class
		{
			return null;
		}

		// Token: 0x0600135F RID: 4959
		[Token(Token = "0x600135F")]
		[Address(RVA = "0x4ADEAD0", Offset = "0x4ADD6D0", VA = "0x184ADEAD0")]
		[MethodImpl(4096)]
		public static extern long Exchange(ref long location1, long value);

		// Token: 0x06001360 RID: 4960
		[Token(Token = "0x6001360")]
		[Address(RVA = "0x4ADEAD0", Offset = "0x4ADD6D0", VA = "0x184ADEAD0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern System.IntPtr Exchange(ref System.IntPtr location1, System.IntPtr value);

		// Token: 0x06001361 RID: 4961
		[Token(Token = "0x6001361")]
		[Address(RVA = "0x4ADEB30", Offset = "0x4ADD730", VA = "0x184ADEB30")]
		[MethodImpl(4096)]
		public static extern double Exchange(ref double location1, double value);

		// Token: 0x06001362 RID: 4962 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6001362")]
		[Intrinsic]
		[System.Runtime.InteropServices.ComVisible(false)]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static T Exchange<T>(ref T location1, T value) where T : class
		{
			return null;
		}

		// Token: 0x06001363 RID: 4963
		[Token(Token = "0x6001363")]
		[Address(RVA = "0x4ADEB70", Offset = "0x4ADD770", VA = "0x184ADEB70")]
		[MethodImpl(4096)]
		public static extern long Read(ref long location);

		// Token: 0x06001364 RID: 4964
		[Token(Token = "0x6001364")]
		[Address(RVA = "0x4ADE9F0", Offset = "0x4ADD5F0", VA = "0x184ADE9F0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern int Add(ref int location1, int value);

		// Token: 0x06001365 RID: 4965
		[Token(Token = "0x6001365")]
		[Address(RVA = "0x4ADEA00", Offset = "0x4ADD600", VA = "0x184ADEA00")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		public static extern long Add(ref long location1, long value);

		// Token: 0x06001366 RID: 4966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001366")]
		[Address(RVA = "0x4ADEB60", Offset = "0x4ADD760", VA = "0x184ADEB60")]
		public static void MemoryBarrier()
		{
		}
	}
}
