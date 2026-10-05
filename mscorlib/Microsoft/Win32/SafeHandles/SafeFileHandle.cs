using System;
using Il2CppDummyDll;

namespace Microsoft.Win32.SafeHandles
{
	// Token: 0x02000087 RID: 135
	[Token(Token = "0x2000087")]
	public sealed class SafeFileHandle : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06000278 RID: 632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x4BEE3E0", Offset = "0x4BECFE0", VA = "0x184BEE3E0")]
		public SafeFileHandle(System.IntPtr preexistingHandle, bool ownsHandle)
		{
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x4BEE370", Offset = "0x4BECF70", VA = "0x184BEE370", Slot = "7")]
		protected override bool ReleaseHandle()
		{
			return default(bool);
		}
	}
}
