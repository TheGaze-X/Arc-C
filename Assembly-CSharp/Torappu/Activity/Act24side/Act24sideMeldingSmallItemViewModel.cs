using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075CC RID: 30156
	[Token(Token = "0x20075CC")]
	public class Act24sideMeldingSmallItemViewModel : IHotfixable
	{
		// Token: 0x0602A75B RID: 173915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A75B")]
		[Address(RVA = "0x2622E60", Offset = "0x2621A60", VA = "0x182622E60")]
		public void LoadData(string actId, string id, ACT24SIDE_MELDING_SMALL_ITEM_BG_TYPE bgType, int count = 0, bool needShowCount = true, bool canClick = false)
		{
		}

		// Token: 0x0602A75C RID: 173916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A75C")]
		[Address(RVA = "0x2622FF0", Offset = "0x2621BF0", VA = "0x182622FF0")]
		public void LoadData(Act24SideData.MeldingItemData meldingData, ACT24SIDE_MELDING_SMALL_ITEM_BG_TYPE bgType, int count = 0, bool needShowCount = true, bool canClick = false)
		{
		}

		// Token: 0x0602A75D RID: 173917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A75D")]
		[Address(RVA = "0x2623170", Offset = "0x2621D70", VA = "0x182623170")]
		public void SetCount(int count)
		{
		}

		// Token: 0x0602A75E RID: 173918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A75E")]
		[Address(RVA = "0x2623200", Offset = "0x2621E00", VA = "0x182623200")]
		public Act24sideMeldingSmallItemViewModel()
		{
		}

		// Token: 0x0403D1AC RID: 250284
		[Token(Token = "0x403D1AC")]
		[FieldOffset(Offset = "0x10")]
		public Act24sideMeldingItemViewModel baseViewModel;

		// Token: 0x0403D1AD RID: 250285
		[Token(Token = "0x403D1AD")]
		[FieldOffset(Offset = "0x18")]
		public ACT24SIDE_MELDING_SMALL_ITEM_BG_TYPE bgType;

		// Token: 0x0403D1AE RID: 250286
		[Token(Token = "0x403D1AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D1AF RID: 250287
		[Token(Token = "0x403D1AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_LoadData;

		// Token: 0x0403D1B0 RID: 250288
		[Token(Token = "0x403D1B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetCount;

		// Token: 0x0403D1B1 RID: 250289
		[Token(Token = "0x403D1B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
