using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B43 RID: 27459
	[Token(Token = "0x2006B43")]
	public class ChatItemModel : ArchiveItemModel
	{
		// Token: 0x06027401 RID: 160769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027401")]
		[Address(RVA = "0x2277920", Offset = "0x2276520", VA = "0x182277920", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x06027402 RID: 160770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027402")]
		[Address(RVA = "0x22778C0", Offset = "0x22764C0", VA = "0x1822778C0", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x06027403 RID: 160771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027403")]
		[Address(RVA = "0x2277980", Offset = "0x2276580", VA = "0x182277980")]
		public ChatItemModel()
		{
		}

		// Token: 0x040378B7 RID: 227511
		[Token(Token = "0x40378B7")]
		[FieldOffset(Offset = "0x30")]
		public string chatId;

		// Token: 0x040378B8 RID: 227512
		[Token(Token = "0x40378B8")]
		[FieldOffset(Offset = "0x38")]
		public int sortId;

		// Token: 0x040378B9 RID: 227513
		[Token(Token = "0x40378B9")]
		[FieldOffset(Offset = "0x40")]
		public string name;

		// Token: 0x040378BA RID: 227514
		[Token(Token = "0x40378BA")]
		[FieldOffset(Offset = "0x48")]
		public string subName;

		// Token: 0x040378BB RID: 227515
		[Token(Token = "0x40378BB")]
		[FieldOffset(Offset = "0x50")]
		public string description;

		// Token: 0x040378BC RID: 227516
		[Token(Token = "0x40378BC")]
		[FieldOffset(Offset = "0x58")]
		public string flavorDescription;

		// Token: 0x040378BD RID: 227517
		[Token(Token = "0x40378BD")]
		[FieldOffset(Offset = "0x60")]
		public List<RoguelikeTopicMonthSquadTeamChar> chatCharList;

		// Token: 0x040378BE RID: 227518
		[Token(Token = "0x40378BE")]
		[FieldOffset(Offset = "0x68")]
		public List<ActArchiveChatItemData> unlockedItems;

		// Token: 0x040378BF RID: 227519
		[Token(Token = "0x40378BF")]
		[FieldOffset(Offset = "0x70")]
		public int chatSum;

		// Token: 0x040378C0 RID: 227520
		[Token(Token = "0x40378C0")]
		[FieldOffset(Offset = "0x78")]
		public string year;

		// Token: 0x040378C1 RID: 227521
		[Token(Token = "0x40378C1")]
		[FieldOffset(Offset = "0x80")]
		public string month;

		// Token: 0x040378C2 RID: 227522
		[Token(Token = "0x40378C2")]
		[FieldOffset(Offset = "0x88")]
		public string descIndex;

		// Token: 0x040378C3 RID: 227523
		[Token(Token = "0x40378C3")]
		[FieldOffset(Offset = "0x90")]
		public int unlockedNum;

		// Token: 0x040378C4 RID: 227524
		[Token(Token = "0x40378C4")]
		[FieldOffset(Offset = "0x98")]
		public string chatColor;

		// Token: 0x040378C5 RID: 227525
		[Token(Token = "0x40378C5")]
		[FieldOffset(Offset = "0xA0")]
		public bool canUnlock;

		// Token: 0x040378C6 RID: 227526
		[Token(Token = "0x40378C6")]
		[FieldOffset(Offset = "0xA8")]
		public long startTime;

		// Token: 0x040378C7 RID: 227527
		[Token(Token = "0x40378C7")]
		[FieldOffset(Offset = "0xB0")]
		public long endTime;

		// Token: 0x040378C8 RID: 227528
		[Token(Token = "0x40378C8")]
		[FieldOffset(Offset = "0xB8")]
		public long fullStoredTime;

		// Token: 0x040378C9 RID: 227529
		[Token(Token = "0x40378C9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x040378CA RID: 227530
		[Token(Token = "0x40378CA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x040378CB RID: 227531
		[Token(Token = "0x40378CB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
