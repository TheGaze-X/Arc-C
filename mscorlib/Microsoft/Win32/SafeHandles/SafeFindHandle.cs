using System;
using Il2CppDummyDll;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	internal class SafeFindHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x0600027A RID: 634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x4BEE4A0", Offset = "0x4BED0A0", VA = "0x184BEE4A0")]
		internal SafeFindHandle()
		{
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x4BEE450", Offset = "0x4BED050", VA = "0x184BEE450", Slot = "7")]
		protected override bool ReleaseHandle()
		{
			return default(bool);
		}
	}
}
