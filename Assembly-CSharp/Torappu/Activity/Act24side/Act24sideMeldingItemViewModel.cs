using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075CA RID: 30154
	[Token(Token = "0x20075CA")]
	public class Act24sideMeldingItemViewModel : IHotfixable
	{
		// Token: 0x0602A754 RID: 173908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A754")]
		[Address(RVA = "0x26219D0", Offset = "0x26205D0", VA = "0x1826219D0")]
		public void LoadData(string actId, string id, int count = 0, bool needShowCount = true, bool canClick = true)
		{
		}

		// Token: 0x0602A755 RID: 173909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A755")]
		[Address(RVA = "0x2621810", Offset = "0x2620410", VA = "0x182621810")]
		public void LoadData(Act24SideData.MeldingItemData meldingData, int count = 0, bool needShowCount = true, bool canClick = true)
		{
		}

		// Token: 0x0602A756 RID: 173910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A756")]
		[Address(RVA = "0x26215E0", Offset = "0x26201E0", VA = "0x1826215E0")]
		public void LoadData(string actId, UIItemViewModel item, bool needShowCount = true, bool canClick = true)
		{
		}

		// Token: 0x0602A757 RID: 173911 RVA: 0x000D8A80 File Offset: 0x000D6C80
		[Token(Token = "0x602A757")]
		[Address(RVA = "0x2621570", Offset = "0x2620170", VA = "0x182621570")]
		public int GetItemCount()
		{
			return 0;
		}

		// Token: 0x0602A758 RID: 173912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A758")]
		[Address(RVA = "0x2621D50", Offset = "0x2620950", VA = "0x182621D50")]
		private void _LoadBasicInfo(string id, int count = 0)
		{
		}

		// Token: 0x0602A759 RID: 173913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A759")]
		[Address(RVA = "0x2621E40", Offset = "0x2620A40", VA = "0x182621E40")]
		private void _LoadMeldingInfo(Act24SideData.MeldingItemData meldingItemData)
		{
		}

		// Token: 0x0602A75A RID: 173914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A75A")]
		[Address(RVA = "0x2621ED0", Offset = "0x2620AD0", VA = "0x182621ED0")]
		public Act24sideMeldingItemViewModel()
		{
		}

		// Token: 0x0403D199 RID: 250265
		[Token(Token = "0x403D199")]
		[FieldOffset(Offset = "0x10")]
		public string itemId;

		// Token: 0x0403D19A RID: 250266
		[Token(Token = "0x403D19A")]
		[FieldOffset(Offset = "0x18")]
		public string itemBgId;

		// Token: 0x0403D19B RID: 250267
		[Token(Token = "0x403D19B")]
		[FieldOffset(Offset = "0x20")]
		public UIItemViewModel itemViewModel;

		// Token: 0x0403D19C RID: 250268
		[Token(Token = "0x403D19C")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;

		// Token: 0x0403D19D RID: 250269
		[Token(Token = "0x403D19D")]
		[FieldOffset(Offset = "0x2C")]
		public int price;

		// Token: 0x0403D19E RID: 250270
		[Token(Token = "0x403D19E")]
		[FieldOffset(Offset = "0x30")]
		public Act24SideData.MeldingItemRarityType rarity;

		// Token: 0x0403D19F RID: 250271
		[Token(Token = "0x403D19F")]
		[FieldOffset(Offset = "0x34")]
		public bool showCount;

		// Token: 0x0403D1A0 RID: 250272
		[Token(Token = "0x403D1A0")]
		[FieldOffset(Offset = "0x35")]
		public bool canItemClick;

		// Token: 0x0403D1A1 RID: 250273
		[Token(Token = "0x403D1A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D1A2 RID: 250274
		[Token(Token = "0x403D1A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x0403D1A3 RID: 250275
		[Token(Token = "0x403D1A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix2_LoadData;

		// Token: 0x0403D1A4 RID: 250276
		[Token(Token = "0x403D1A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetItemCount;

		// Token: 0x0403D1A5 RID: 250277
		[Token(Token = "0x403D1A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadBasicInfo;

		// Token: 0x0403D1A6 RID: 250278
		[Token(Token = "0x403D1A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadMeldingInfo;

		// Token: 0x0403D1A7 RID: 250279
		[Token(Token = "0x403D1A7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
