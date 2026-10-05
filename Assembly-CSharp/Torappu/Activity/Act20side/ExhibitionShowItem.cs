using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200763E RID: 30270
	[Token(Token = "0x200763E")]
	public class ExhibitionShowItem
	{
		// Token: 0x0602A9A0 RID: 174496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9A0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ExhibitionShowItem()
		{
		}

		// Token: 0x0403D566 RID: 251238
		[Token(Token = "0x403D566")]
		[FieldOffset(Offset = "0x10")]
		public bool isNpc;

		// Token: 0x0403D567 RID: 251239
		[Token(Token = "0x403D567")]
		[FieldOffset(Offset = "0x18")]
		public string npcId;

		// Token: 0x0403D568 RID: 251240
		[Token(Token = "0x403D568")]
		[FieldOffset(Offset = "0x20")]
		public ExhibitionFriendCard businessCard;

		// Token: 0x0403D569 RID: 251241
		[Token(Token = "0x403D569")]
		[FieldOffset(Offset = "0x28")]
		public PlayerCartInfo.Cart car;

		// Token: 0x0403D56A RID: 251242
		[Token(Token = "0x403D56A")]
		[FieldOffset(Offset = "0x30")]
		public string npcName;
	}
}
