using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200008A RID: 138
	[Token(Token = "0x200008A")]
	[CallbackIdentity(5302)]
	public struct CreateBeaconCallback_t
	{
		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		public const int k_iCallback = 5302;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x8")]
		public PartyBeaconID_t m_ulBeaconID;
	}
}
