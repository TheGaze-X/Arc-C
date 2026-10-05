using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY
{
	// Token: 0x020018DE RID: 6366
	[Token(Token = "0x20018DE")]
	public interface IDIYItem : IHotfixable
	{
		// Token: 0x17001257 RID: 4695
		// (get) Token: 0x0600A07F RID: 41087
		[Token(Token = "0x17001257")]
		string id { [Token(Token = "0x600A07F")] get; }

		// Token: 0x17001258 RID: 4696
		// (get) Token: 0x0600A080 RID: 41088
		[Token(Token = "0x17001258")]
		string displayName { [Token(Token = "0x600A080")] get; }

		// Token: 0x17001259 RID: 4697
		// (get) Token: 0x0600A081 RID: 41089
		[Token(Token = "0x17001259")]
		int comfort { [Token(Token = "0x600A081")] get; }

		// Token: 0x1700125A RID: 4698
		// (get) Token: 0x0600A082 RID: 41090
		[Token(Token = "0x1700125A")]
		int rarity { [Token(Token = "0x600A082")] get; }

		// Token: 0x1700125B RID: 4699
		// (get) Token: 0x0600A083 RID: 41091
		[Token(Token = "0x1700125B")]
		string themeId { [Token(Token = "0x600A083")] get; }

		// Token: 0x1700125C RID: 4700
		// (get) Token: 0x0600A084 RID: 41092
		[Token(Token = "0x1700125C")]
		string groupId { [Token(Token = "0x600A084")] get; }

		// Token: 0x1700125D RID: 4701
		// (get) Token: 0x0600A085 RID: 41093
		[Token(Token = "0x1700125D")]
		Sprite icon { [Token(Token = "0x600A085")] get; }

		// Token: 0x1700125E RID: 4702
		// (get) Token: 0x0600A086 RID: 41094
		[Token(Token = "0x1700125E")]
		string desc { [Token(Token = "0x600A086")] get; }

		// Token: 0x1700125F RID: 4703
		// (get) Token: 0x0600A087 RID: 41095
		[Token(Token = "0x1700125F")]
		string usage { [Token(Token = "0x600A087")] get; }

		// Token: 0x17001260 RID: 4704
		// (get) Token: 0x0600A088 RID: 41096
		[Token(Token = "0x17001260")]
		BuildingData.FurnitureType furniType { [Token(Token = "0x600A088")] get; }

		// Token: 0x17001261 RID: 4705
		// (get) Token: 0x0600A089 RID: 41097
		[Token(Token = "0x17001261")]
		BuildingData.FurnitureSubType subType { [Token(Token = "0x600A089")] get; }

		// Token: 0x17001262 RID: 4706
		// (get) Token: 0x0600A08A RID: 41098
		[Token(Token = "0x17001262")]
		int quantity { [Token(Token = "0x600A08A")] get; }

		// Token: 0x17001263 RID: 4707
		// (get) Token: 0x0600A08B RID: 41099
		[Token(Token = "0x17001263")]
		int sortId { [Token(Token = "0x600A08B")] get; }

		// Token: 0x17001264 RID: 4708
		// (get) Token: 0x0600A08C RID: 41100
		[Token(Token = "0x17001264")]
		int enableRoomType { [Token(Token = "0x600A08C")] get; }
	}
}
