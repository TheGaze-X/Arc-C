using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000188")]
	public static class GC
	{
		// Token: 0x06000E62 RID: 3682
		[Token(Token = "0x6000E62")]
		[Address(RVA = "0x4D1E4B0", Offset = "0x4D1D0B0", VA = "0x184D1E4B0")]
		[MethodImpl(4096)]
		private static extern int GetCollectionCount(int generation);

		// Token: 0x06000E63 RID: 3683
		[Token(Token = "0x6000E63")]
		[Address(RVA = "0x4D1E4C0", Offset = "0x4D1D0C0", VA = "0x184D1E4C0")]
		[MethodImpl(4096)]
		private static extern int GetMaxGeneration();

		// Token: 0x06000E64 RID: 3684
		[Token(Token = "0x6000E64")]
		[Address(RVA = "0x4D1E590", Offset = "0x4D1D190", VA = "0x184D1E590")]
		[MethodImpl(4096)]
		private static extern void InternalCollect(int generation);

		// Token: 0x06000E65 RID: 3685
		[Token(Token = "0x6000E65")]
		[Address(RVA = "0x4D1E640", Offset = "0x4D1D240", VA = "0x184D1E640")]
		[MethodImpl(4096)]
		private static extern void RecordPressure(long bytesAllocated);

		// Token: 0x06000E66 RID: 3686
		[Token(Token = "0x6000E66")]
		[Address(RVA = "0x4D1E910", Offset = "0x4D1D510", VA = "0x184D1E910")]
		[MethodImpl(4096)]
		internal static extern void register_ephemeron_array(Ephemeron[] array);

		// Token: 0x06000E67 RID: 3687
		[Token(Token = "0x6000E67")]
		[Address(RVA = "0x4D1E900", Offset = "0x4D1D500", VA = "0x184D1E900")]
		[MethodImpl(4096)]
		private static extern object get_ephemeron_tombstone();

		// Token: 0x06000E68 RID: 3688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E68")]
		[Address(RVA = "0x4D1E4D0", Offset = "0x4D1D0D0", VA = "0x184D1E4D0")]
		internal static void GetMemoryInfo(out uint highMemLoadThreshold, out ulong totalPhysicalMem, out uint lastRecordedMemLoad, out System.UIntPtr lastRecordedHeapSize, out System.UIntPtr lastRecordedFragmentation)
		{
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E69")]
		[Address(RVA = "0x4D1E220", Offset = "0x4D1CE20", VA = "0x184D1E220")]
		public static void AddMemoryPressure(long bytesAllocated)
		{
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6A")]
		[Address(RVA = "0x4D1E650", Offset = "0x4D1D250", VA = "0x184D1E650")]
		public static void RemoveMemoryPressure(long bytesAllocated)
		{
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6B")]
		[Address(RVA = "0x4D1E370", Offset = "0x4D1CF70", VA = "0x184D1E370")]
		public static void Collect()
		{
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[Token(Token = "0x6000E6C")]
		[Address(RVA = "0x4D1E3F0", Offset = "0x4D1CFF0", VA = "0x184D1E3F0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static int CollectionCount(int generation)
		{
			return 0;
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E6D")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(8)]
		public static void KeepAlive(object obj)
		{
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		[Token(Token = "0x17000134")]
		public static int MaxGeneration
		{
			[Token(Token = "0x6000E6E")]
			[Address(RVA = "0x4D1E8C0", Offset = "0x4D1D4C0", VA = "0x184D1E8C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000E6F RID: 3695
		[Token(Token = "0x6000E6F")]
		[Address(RVA = "0x4D1E840", Offset = "0x4D1D440", VA = "0x184D1E840")]
		[MethodImpl(4096)]
		public static extern void WaitForPendingFinalizers();

		// Token: 0x06000E70 RID: 3696
		[Token(Token = "0x6000E70")]
		[Address(RVA = "0x4D1E860", Offset = "0x4D1D460", VA = "0x184D1E860")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		[MethodImpl(4096)]
		private static extern void _SuppressFinalize(object o);

		// Token: 0x06000E71 RID: 3697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E71")]
		[Address(RVA = "0x4D1E7A0", Offset = "0x4D1D3A0", VA = "0x184D1E7A0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public static void SuppressFinalize(object obj)
		{
		}

		// Token: 0x06000E72 RID: 3698
		[Token(Token = "0x6000E72")]
		[Address(RVA = "0x4D1E850", Offset = "0x4D1D450", VA = "0x184D1E850")]
		[MethodImpl(4096)]
		private static extern void _ReRegisterForFinalize(object o);

		// Token: 0x06000E73 RID: 3699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x4D1E5A0", Offset = "0x4D1D1A0", VA = "0x184D1E5A0")]
		public static void ReRegisterForFinalize(object obj)
		{
		}

		// Token: 0x06000E74 RID: 3700
		[Token(Token = "0x6000E74")]
		[Address(RVA = "0x4D1E580", Offset = "0x4D1D180", VA = "0x184D1E580")]
		[MethodImpl(4096)]
		public static extern long GetTotalMemory(bool forceFullCollection);

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly object EPHEMERON_TOMBSTONE;
	}
}
