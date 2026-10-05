using System;
using System.Runtime.ConstrainedExecution;
using Il2CppDummyDll;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000089 RID: 137
	[Token(Token = "0x2000089")]
	public sealed class SafeWaitHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x0600027C RID: 636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x4BEE3E0", Offset = "0x4BECFE0", VA = "0x184BEE3E0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		public SafeWaitHandle(System.IntPtr existingHandle, bool ownsHandle)
		{
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x4BEE940", Offset = "0x4BED540", VA = "0x184BEE940", Slot = "7")]
		protected override bool ReleaseHandle()
		{
			return default(bool);
		}
	}
}
