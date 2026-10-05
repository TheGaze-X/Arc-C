using System;
using System.Runtime.ConstrainedExecution;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x020004CA RID: 1226
	[Token(Token = "0x20004CA")]
	public static class RuntimeHelpers
	{
		// Token: 0x0600236A RID: 9066
		[Token(Token = "0x600236A")]
		[Address(RVA = "0x4BE4D20", Offset = "0x4BE3920", VA = "0x184BE4D20")]
		[MethodImpl(4096)]
		private static extern void InitializeArray(System.Array array, System.IntPtr fldHandle);

		// Token: 0x0600236B RID: 9067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236B")]
		[Address(RVA = "0x4BE4C70", Offset = "0x4BE3870", VA = "0x184BE4C70")]
		public static void InitializeArray(System.Array array, System.RuntimeFieldHandle fldHandle)
		{
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x0600236C RID: 9068
		[Token(Token = "0x1700048F")]
		public static extern int OffsetToStringData { [Token(Token = "0x600236C")] [Address(RVA = "0x4BE4E00", Offset = "0x4BE3A00", VA = "0x184BE4E00")] [MethodImpl(4096)] get; }

		// Token: 0x0600236D RID: 9069 RVA: 0x000141C0 File Offset: 0x000123C0
		[Token(Token = "0x600236D")]
		[Address(RVA = "0x4ECDC0", Offset = "0x4EB9C0", VA = "0x1804ECDC0")]
		public static int GetHashCode(object o)
		{
			return 0;
		}

		// Token: 0x0600236E RID: 9070
		[Token(Token = "0x600236E")]
		[Address(RVA = "0x4BE4D30", Offset = "0x4BE3930", VA = "0x184BE4D30")]
		[MethodImpl(4096)]
		private static extern void RunClassConstructor(System.IntPtr type);

		// Token: 0x0600236F RID: 9071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600236F")]
		[Address(RVA = "0x4BE4D40", Offset = "0x4BE3940", VA = "0x184BE4D40")]
		public static void RunClassConstructor(System.RuntimeTypeHandle type)
		{
		}

		// Token: 0x06002370 RID: 9072
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x4BB5150", Offset = "0x4BB3D50", VA = "0x184BB5150")]
		[MethodImpl(4096)]
		private static extern bool SufficientExecutionStack();

		// Token: 0x06002371 RID: 9073 RVA: 0x000141D8 File Offset: 0x000123D8
		[Token(Token = "0x6002371")]
		[Address(RVA = "0x4BB5150", Offset = "0x4BB3D50", VA = "0x184BB5150")]
		public static bool TryEnsureSufficientExecutionStack()
		{
			return default(bool);
		}

		// Token: 0x06002372 RID: 9074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002372")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public static void PrepareConstrainedRegions()
		{
		}

		// Token: 0x06002373 RID: 9075 RVA: 0x000141F0 File Offset: 0x000123F0
		[Token(Token = "0x6002373")]
		public static bool IsReferenceOrContainsReferences<T>()
		{
			return default(bool);
		}
	}
}
