using System;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002714 RID: 10004
	[Token(Token = "0x2002714")]
	public class PlayerCard
	{
		// Token: 0x0601046E RID: 66670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601046E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerCard()
		{
		}

		// Token: 0x040122F1 RID: 74481
		[Token(Token = "0x40122F1")]
		[FieldOffset(Offset = "0x10")]
		public string nickName;

		// Token: 0x040122F2 RID: 74482
		[Token(Token = "0x40122F2")]
		[FieldOffset(Offset = "0x18")]
		public string nickNumber;

		// Token: 0x040122F3 RID: 74483
		[Token(Token = "0x40122F3")]
		[FieldOffset(Offset = "0x20")]
		public PlayerAvatarQuery avatarQuery;

		// Token: 0x040122F4 RID: 74484
		[Token(Token = "0x40122F4")]
		[FieldOffset(Offset = "0x38")]
		public int level;

		// Token: 0x040122F5 RID: 74485
		[Token(Token = "0x40122F5")]
		[FieldOffset(Offset = "0x40")]
		public string nameCardSkin;

		// Token: 0x040122F6 RID: 74486
		[Token(Token = "0x40122F6")]
		[FieldOffset(Offset = "0x48")]
		public int nameCardSkinTmpl;
	}
}
