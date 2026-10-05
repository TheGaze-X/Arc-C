using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001420 RID: 5152
	[Token(Token = "0x2001420")]
	public class FriendMedalBoard
	{
		// Token: 0x060076E1 RID: 30433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076E1")]
		[Address(RVA = "0x241EF40", Offset = "0x241DB40", VA = "0x18241EF40")]
		public FriendMedalBoard()
		{
		}

		// Token: 0x04007449 RID: 29769
		[Token(Token = "0x4007449")]
		[FieldOffset(Offset = "0x10")]
		public NameCardMedalType type;

		// Token: 0x0400744A RID: 29770
		[Token(Token = "0x400744A")]
		[FieldOffset(Offset = "0x18")]
		public PlayerMedalCustomLayout custom;

		// Token: 0x0400744B RID: 29771
		[Token(Token = "0x400744B")]
		[FieldOffset(Offset = "0x20")]
		public FriendMedalTemplateGroupInfo template;
	}
}
