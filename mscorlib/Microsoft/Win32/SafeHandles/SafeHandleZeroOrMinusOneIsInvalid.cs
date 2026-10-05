using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	public abstract class SafeHandleZeroOrMinusOneIsInvalid : System.Runtime.InteropServices.SafeHandle
	{
		// Token: 0x0600027E RID: 638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x4BEE580", Offset = "0x4BED180", VA = "0x184BEE580")]
		[System.Runtime.ConstrainedExecution.ReliabilityContract(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.MayFail)]
		protected SafeHandleZeroOrMinusOneIsInvalid(bool ownsHandle)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600027F RID: 639 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x1700003B")]
		public override bool IsInvalid
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0x4BEE5E0", Offset = "0x4BED1E0", VA = "0x184BEE5E0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}
	}
}
