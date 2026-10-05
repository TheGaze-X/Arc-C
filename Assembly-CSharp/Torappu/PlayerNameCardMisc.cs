using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000C02 RID: 3074
	[Token(Token = "0x2000C02")]
	[Serializable]
	public class PlayerNameCardMisc
	{
		// Token: 0x06006896 RID: 26774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006896")]
		[Address(RVA = "0x1E9AB00", Offset = "0x1E99700", VA = "0x181E9AB00")]
		public PlayerNameCardMisc()
		{
		}

		// Token: 0x04003EC1 RID: 16065
		[Token(Token = "0x4003EC1")]
		[FieldOffset(Offset = "0x10")]
		public bool showDetail;

		// Token: 0x04003EC2 RID: 16066
		[Token(Token = "0x4003EC2")]
		[FieldOffset(Offset = "0x11")]
		public bool showBirthday;
	}
}
