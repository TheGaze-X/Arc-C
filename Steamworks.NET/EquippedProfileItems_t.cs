using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[CallbackIdentity(351)]
	public struct EquippedProfileItems_t
	{
		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		public const int k_iCallback = 351;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x0")]
		public EResult m_eResult;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x4")]
		public CSteamID m_steamID;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xC")]
		public bool m_bHasAnimatedAvatar;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0xD")]
		public bool m_bHasAvatarFrame;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0xE")]
		public bool m_bHasProfileModifier;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0xF")]
		public bool m_bHasProfileBackground;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x10")]
		public bool m_bHasMiniProfileBackground;
	}
}
