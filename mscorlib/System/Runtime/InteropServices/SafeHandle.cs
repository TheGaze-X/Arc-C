using System;
using System.Runtime.ConstrainedExecution;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000474 RID: 1140
	[Token(Token = "0x2000474")]
	[StructLayout(0)]
	public abstract class SafeHandle : System.Runtime.ConstrainedExecution.CriticalFinalizerObject, System.IDisposable
	{
		// Token: 0x06002234 RID: 8756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002234")]
		[Address(RVA = "0x4BC5420", Offset = "0x4BC4020", VA = "0x184BC5420")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		protected SafeHandle(System.IntPtr invalidHandleValue, bool ownsHandle)
		{
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002235")]
		[Address(RVA = "0x4BC5240", Offset = "0x4BC3E40", VA = "0x184BC5240", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002236")]
		[Address(RVA = "0xD980D0", Offset = "0xD96CD0", VA = "0x180D980D0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		protected void SetHandle(System.IntPtr handle)
		{
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00013BD8 File Offset: 0x00011DD8
		[Token(Token = "0x6002237")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public System.IntPtr DangerousGetHandle()
		{
			return 0;
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x00013BF0 File Offset: 0x00011DF0
		[Token(Token = "0x1700046C")]
		public bool IsClosed
		{
			[Token(Token = "0x6002238")]
			[Address(RVA = "0x4BC54B0", Offset = "0x4BC40B0", VA = "0x184BC54B0")]
			[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06002239 RID: 8761
		[Token(Token = "0x1700046D")]
		public abstract bool IsInvalid { [Token(Token = "0x6002239")] [System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)] get; }

		// Token: 0x0600223A RID: 8762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223A")]
		[Address(RVA = "0x36E2920", Offset = "0x36E1520", VA = "0x1836E2920")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public void Close()
		{
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223B")]
		[Address(RVA = "0x36E2920", Offset = "0x36E1520", VA = "0x1836E2920", Slot = "4")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public void Dispose()
		{
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223C")]
		[Address(RVA = "0x4BC5180", Offset = "0x4BC3D80", VA = "0x184BC5180", Slot = "6")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x0600223D RID: 8765
		[Token(Token = "0x600223D")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		protected abstract bool ReleaseHandle();

		// Token: 0x0600223E RID: 8766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223E")]
		[Address(RVA = "0x4BC5380", Offset = "0x4BC3F80", VA = "0x184BC5380")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public void SetHandleAsInvalid()
		{
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600223F")]
		[Address(RVA = "0x4BC5040", Offset = "0x4BC3C40", VA = "0x184BC5040")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public void DangerousAddRef(ref bool success)
		{
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002240")]
		[Address(RVA = "0x4BC5170", Offset = "0x4BC3D70", VA = "0x184BC5170")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
		public void DangerousRelease()
		{
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002241")]
		[Address(RVA = "0x4BC52C0", Offset = "0x4BC3EC0", VA = "0x184BC52C0")]
		private void InternalDispose()
		{
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002242")]
		[Address(RVA = "0x4BC5360", Offset = "0x4BC3F60", VA = "0x184BC5360")]
		private void InternalFinalize()
		{
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002243")]
		[Address(RVA = "0x4BC50D0", Offset = "0x4BC3CD0", VA = "0x184BC50D0")]
		private void DangerousReleaseInternal(bool dispose)
		{
		}

		// Token: 0x040013AA RID: 5034
		[Token(Token = "0x40013AA")]
		[FieldOffset(Offset = "0x10")]
		protected System.IntPtr handle;

		// Token: 0x040013AB RID: 5035
		[Token(Token = "0x40013AB")]
		[FieldOffset(Offset = "0x18")]
		private int _state;

		// Token: 0x040013AC RID: 5036
		[Token(Token = "0x40013AC")]
		[FieldOffset(Offset = "0x1C")]
		private bool _ownsHandle;

		// Token: 0x040013AD RID: 5037
		[Token(Token = "0x40013AD")]
		[FieldOffset(Offset = "0x1D")]
		private bool _fullyInitialized;

		// Token: 0x040013AE RID: 5038
		[Token(Token = "0x40013AE")]
		private const int RefCount_Mask = 2147483644;

		// Token: 0x040013AF RID: 5039
		[Token(Token = "0x40013AF")]
		private const int RefCount_One = 4;
	}
}
