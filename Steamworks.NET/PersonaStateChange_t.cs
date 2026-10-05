using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[CallbackIdentity(304)]
	public struct PersonaStateChange_t
	{
		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		public const int k_iCallback = 304;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x0")]
		public ulong m_ulSteamID;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x8")]
		public EPersonaChange m_nChangeFlags;
	}
}
