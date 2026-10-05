using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000A48 RID: 2632
	[Token(Token = "0x2000A48")]
	public class PlayerAvatar
	{
		// Token: 0x06006707 RID: 26375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006707")]
		[Address(RVA = "0x1EF10D0", Offset = "0x1EEFCD0", VA = "0x181EF10D0")]
		public PlayerAvatar()
		{
		}

		// Token: 0x04003833 RID: 14387
		[Token(Token = "0x4003833")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "avatar_icon")]
		public ListDict<string, PlayerAvatarBlock> playerAvatarIcons;
	}
}
