using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	public abstract class SafeHandleMinusOneIsInvalid : System.Runtime.InteropServices.SafeHandle
	{
		// Token: 0x06000280 RID: 640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x4BEE4F0", Offset = "0x4BED0F0", VA = "0x184BEE4F0")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		protected SafeHandleMinusOneIsInvalid(bool ownsHandle)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000281 RID: 641 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x1700003C")]
		public override bool IsInvalid
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x4BEE540", Offset = "0x4BED140", VA = "0x184BEE540", Slot = "5")]
			get
			{
				return default(bool);
			}
		}
	}
}
