using System;
using Il2CppDummyDll;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000084 RID: 132
	[Token(Token = "0x2000084")]
	internal sealed class SafeLibraryHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x4BEE4A0", Offset = "0x4BED0A0", VA = "0x184BEE4A0")]
		internal SafeLibraryHandle()
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x4BEE640", Offset = "0x4BED240", VA = "0x184BEE640", Slot = "7")]
		protected override bool ReleaseHandle()
		{
			return default(bool);
		}
	}
}
