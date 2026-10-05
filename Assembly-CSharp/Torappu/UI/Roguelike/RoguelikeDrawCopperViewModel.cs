using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020051DF RID: 20959
	[Token(Token = "0x20051DF")]
	public class RoguelikeDrawCopperViewModel : IHotfixable
	{
		// Token: 0x0601EF3F RID: 126783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF3F")]
		[Address(RVA = "0x18B5CC0", Offset = "0x18B48C0", VA = "0x1818B5CC0")]
		public void LoadData(RoguelikeDrawCopperViewModel.Input input)
		{
		}

		// Token: 0x0601EF40 RID: 126784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF40")]
		[Address(RVA = "0x18B61B0", Offset = "0x18B4DB0", VA = "0x1818B61B0")]
		private void _LoadBagData(PlayerRoguelikeV2.CurrentData.Module.Copper playerCopper, RoguelikeCopperModuleData gameCopper)
		{
		}

		// Token: 0x0601EF41 RID: 126785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF41")]
		[Address(RVA = "0x18B6500", Offset = "0x18B5100", VA = "0x1818B6500")]
		private void _LoadDrawCopperData(List<string> copperList, Dictionary<string, int> hitReason, PlayerRoguelikeV2.CurrentData.Module.Copper playerCopper, RoguelikeCopperModuleData gameCopper)
		{
		}

		// Token: 0x0601EF42 RID: 126786 RVA: 0x000B0418 File Offset: 0x000AE618
		[Token(Token = "0x601EF42")]
		[Address(RVA = "0x18B6030", Offset = "0x18B4C30", VA = "0x1818B6030")]
		private static int _CompareDrawCopperItem(RoguelikePlayerCopperItemViewModel left, RoguelikePlayerCopperItemViewModel right)
		{
			return 0;
		}

		// Token: 0x0601EF43 RID: 126787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF43")]
		[Address(RVA = "0x18B6400", Offset = "0x18B5000", VA = "0x1818B6400")]
		private void _LoadDivineData(string divineEventId, RoguelikeCopperModuleData gameCopper)
		{
		}

		// Token: 0x0601EF44 RID: 126788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF44")]
		[Address(RVA = "0x18B68C0", Offset = "0x18B54C0", VA = "0x1818B68C0")]
		private void _LoadExchangeData(RoguelikeCopperModuleData gameCopper, List<PlayerRoguelikePendingEvent.CopperExchangeInfo> exchangeInfo)
		{
		}

		// Token: 0x0601EF45 RID: 126789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EF45")]
		[Address(RVA = "0x18B6BF0", Offset = "0x18B57F0", VA = "0x1818B6BF0")]
		public RoguelikeDrawCopperViewModel()
		{
		}

		// Token: 0x040298A0 RID: 170144
		[Token(Token = "0x40298A0")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, int> s_hitReasonOrderMap;

		// Token: 0x040298A1 RID: 170145
		[Token(Token = "0x40298A1")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikePlayerCopperItemViewModel> bagCopperList;

		// Token: 0x040298A2 RID: 170146
		[Token(Token = "0x40298A2")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x040298A3 RID: 170147
		[Token(Token = "0x40298A3")]
		[FieldOffset(Offset = "0x20")]
		public List<RoguelikePlayerCopperItemViewModel> drawCopperItemList;

		// Token: 0x040298A4 RID: 170148
		[Token(Token = "0x40298A4")]
		[FieldOffset(Offset = "0x28")]
		public List<RoguelikePlayerCopperItemViewModel> drawCopperItemListWithoutFreeze;

		// Token: 0x040298A5 RID: 170149
		[Token(Token = "0x40298A5")]
		[FieldOffset(Offset = "0x30")]
		public string divineEventId;

		// Token: 0x040298A6 RID: 170150
		[Token(Token = "0x40298A6")]
		[FieldOffset(Offset = "0x38")]
		public RoguelikeCopperDivineType divineType;

		// Token: 0x040298A7 RID: 170151
		[Token(Token = "0x40298A7")]
		[FieldOffset(Offset = "0x3C")]
		public RoguelikeCopperDivineResultType divineResultLevel;

		// Token: 0x040298A8 RID: 170152
		[Token(Token = "0x40298A8")]
		[FieldOffset(Offset = "0x40")]
		public string showDesc;

		// Token: 0x040298A9 RID: 170153
		[Token(Token = "0x40298A9")]
		[FieldOffset(Offset = "0x48")]
		public List<RoguelikeCopperExchangeInfoViewModel> exchangeCopperList;

		// Token: 0x040298AA RID: 170154
		[Token(Token = "0x40298AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040298AB RID: 170155
		[Token(Token = "0x40298AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadBagData;

		// Token: 0x040298AC RID: 170156
		[Token(Token = "0x40298AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadDrawCopperData;

		// Token: 0x040298AD RID: 170157
		[Token(Token = "0x40298AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CompareDrawCopperItem;

		// Token: 0x040298AE RID: 170158
		[Token(Token = "0x40298AE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadDivineData;

		// Token: 0x040298AF RID: 170159
		[Token(Token = "0x40298AF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadExchangeData;

		// Token: 0x040298B0 RID: 170160
		[Token(Token = "0x40298B0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020051E0 RID: 20960
		[Token(Token = "0x20051E0")]
		public struct Input
		{
			// Token: 0x040298B1 RID: 170161
			[Token(Token = "0x40298B1")]
			[FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x040298B2 RID: 170162
			[Token(Token = "0x40298B2")]
			[FieldOffset(Offset = "0x8")]
			public List<string> copperList;

			// Token: 0x040298B3 RID: 170163
			[Token(Token = "0x40298B3")]
			[FieldOffset(Offset = "0x10")]
			public string divineEventId;

			// Token: 0x040298B4 RID: 170164
			[Token(Token = "0x40298B4")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<string, int> hitReason;

			// Token: 0x040298B5 RID: 170165
			[Token(Token = "0x40298B5")]
			[FieldOffset(Offset = "0x20")]
			public List<PlayerRoguelikePendingEvent.CopperExchangeInfo> exchangeInfo;
		}
	}
}
