using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[CallbackIdentity(210)]
	public struct AssociateWithClanResult_t
	{
		// Token: 0x04000089 RID: 137
		[Token(Token = "0x4000089")]
		public const int k_iCallback = 210;

		// Token: 0x0400008A RID: 138
		[Token(Token = "0x400008A")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;
	}
}
