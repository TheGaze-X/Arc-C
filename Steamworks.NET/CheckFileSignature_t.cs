using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	[CallbackIdentity(705)]
	public struct CheckFileSignature_t
	{
		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		public const int k_iCallback = 705;

		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		[FieldOffset(Offset = "0x0")]
		public ECheckFileSignature m_eCheckFileSignature;
	}
}
