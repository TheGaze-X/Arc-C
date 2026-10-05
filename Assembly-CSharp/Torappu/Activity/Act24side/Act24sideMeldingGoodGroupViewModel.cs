using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075C2 RID: 30146
	[Token(Token = "0x20075C2")]
	public class Act24sideMeldingGoodGroupViewModel : IHotfixable
	{
		// Token: 0x170063DA RID: 25562
		// (get) Token: 0x0602A731 RID: 173873 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A732 RID: 173874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063DA")]
		public string boxId
		{
			[Token(Token = "0x602A731")]
			[Address(RVA = "0x2621340", Offset = "0x261FF40", VA = "0x182621340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A732")]
			[Address(RVA = "0x2621480", Offset = "0x2620080", VA = "0x182621480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170063DB RID: 25563
		// (get) Token: 0x0602A733 RID: 173875 RVA: 0x000D8918 File Offset: 0x000D6B18
		// (set) Token: 0x0602A734 RID: 173876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063DB")]
		public bool containUnlimitGoods
		{
			[Token(Token = "0x602A733")]
			[Address(RVA = "0x26213A0", Offset = "0x261FFA0", VA = "0x1826213A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602A734")]
			[Address(RVA = "0x2621500", Offset = "0x2620100", VA = "0x182621500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170063DC RID: 25564
		// (get) Token: 0x0602A735 RID: 173877 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602A736 RID: 173878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170063DC")]
		public Act24SideData.MeldingGachaBoxData boxData
		{
			[Token(Token = "0x602A735")]
			[Address(RVA = "0x26212E0", Offset = "0x261FEE0", VA = "0x1826212E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602A736")]
			[Address(RVA = "0x2621400", Offset = "0x2620000", VA = "0x182621400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0602A737 RID: 173879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A737")]
		[Address(RVA = "0x2620980", Offset = "0x261F580", VA = "0x182620980")]
		public void LoadData(Act24SideData.MeldingGachaBoxData gachaBoxData, List<Act24SideData.MeldingGachaBoxGoodData> goodDataList, string actId)
		{
		}

		// Token: 0x0602A738 RID: 173880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A738")]
		[Address(RVA = "0x2620F30", Offset = "0x261FB30", VA = "0x182620F30")]
		public void RefreshData(Dictionary<string, int> dicGachaGoodInfo)
		{
		}

		// Token: 0x0602A739 RID: 173881 RVA: 0x000D8930 File Offset: 0x000D6B30
		[Token(Token = "0x602A739")]
		[Address(RVA = "0x26202E0", Offset = "0x261EEE0", VA = "0x1826202E0")]
		public float GetInputPerPriceDur(int totalChangePrice)
		{
			return 0f;
		}

		// Token: 0x0602A73A RID: 173882 RVA: 0x000D8948 File Offset: 0x000D6B48
		[Token(Token = "0x602A73A")]
		[Address(RVA = "0x26206C0", Offset = "0x261F2C0", VA = "0x1826206C0")]
		public bool IsGachaBoxAllTakeOut()
		{
			return default(bool);
		}

		// Token: 0x0602A73B RID: 173883 RVA: 0x000D8960 File Offset: 0x000D6B60
		[Token(Token = "0x602A73B")]
		[Address(RVA = "0x2620850", Offset = "0x261F450", VA = "0x182620850")]
		public bool IsGachaDisplayTypeGridAllTakeOut(Act24SideData.MeldingGoodDisplayType displayType)
		{
			return default(bool);
		}

		// Token: 0x0602A73C RID: 173884 RVA: 0x000D8978 File Offset: 0x000D6B78
		[Token(Token = "0x602A73C")]
		[Address(RVA = "0x261FCC0", Offset = "0x261E8C0", VA = "0x18261FCC0")]
		public float GetGoodLayoutScrollTarget(int layoutTopSpace, float layoutSpace, int layoutDownSpace)
		{
			return 0f;
		}

		// Token: 0x0602A73D RID: 173885 RVA: 0x000D8990 File Offset: 0x000D6B90
		[Token(Token = "0x602A73D")]
		[Address(RVA = "0x261FB20", Offset = "0x261E720", VA = "0x18261FB20")]
		public int GetGachaBoxRemainCount()
		{
			return 0;
		}

		// Token: 0x0602A73E RID: 173886 RVA: 0x000D89A8 File Offset: 0x000D6BA8
		[Token(Token = "0x602A73E")]
		[Address(RVA = "0x2620530", Offset = "0x261F130", VA = "0x182620530")]
		public int GetMaxCanDrawPriceCount(bool canOver = false)
		{
			return 0;
		}

		// Token: 0x0602A73F RID: 173887 RVA: 0x000D89C0 File Offset: 0x000D6BC0
		[Token(Token = "0x602A73F")]
		[Address(RVA = "0x2621090", Offset = "0x261FC90", VA = "0x182621090")]
		private bool _IsInputsOverMaxTweenDur(int totalInputPrice)
		{
			return default(bool);
		}

		// Token: 0x0602A740 RID: 173888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A740")]
		[Address(RVA = "0x26211E0", Offset = "0x261FDE0", VA = "0x1826211E0")]
		public Act24sideMeldingGoodGroupViewModel()
		{
		}

		// Token: 0x0403D14E RID: 250190
		[Token(Token = "0x403D14E")]
		[FieldOffset(Offset = "0x28")]
		public ListDict<Act24SideData.MeldingGoodDisplayType, Act24sideMeldingGoodDisplayViewModel> goodDisplayViewModelList;

		// Token: 0x0403D14F RID: 250191
		[Token(Token = "0x403D14F")]
		[FieldOffset(Offset = "0x30")]
		public List<Act24sideMeldingGoodItemViewModel> goodItemViewModelList;

		// Token: 0x0403D150 RID: 250192
		[Token(Token = "0x403D150")]
		private const int PER_ROW_GOOD_MAX_COUNT = 5;

		// Token: 0x0403D151 RID: 250193
		[Token(Token = "0x403D151")]
		private const int PER_DISPLAY_TITLE_HEIGHT = 21;

		// Token: 0x0403D152 RID: 250194
		[Token(Token = "0x403D152")]
		private const int PER_DISPLAY_ITEM_HEIGHT = 133;

		// Token: 0x0403D153 RID: 250195
		[Token(Token = "0x403D153")]
		private const int PER_DISPLAY_ITEM_SPACE = 4;

		// Token: 0x0403D154 RID: 250196
		[Token(Token = "0x403D154")]
		[FieldOffset(Offset = "0x38")]
		private float m_inputPerPriceBestTweenDur;

		// Token: 0x0403D155 RID: 250197
		[Token(Token = "0x403D155")]
		private const float INPUT_MAX_TWEEN_DUR = 2.5f;

		// Token: 0x0403D156 RID: 250198
		[Token(Token = "0x403D156")]
		private const float INPUT_SINGLE_SEGMENT_TWEEN_DUR = 1f;

		// Token: 0x0403D157 RID: 250199
		[Token(Token = "0x403D157")]
		private const int TINY_INPUT_LIMIT_UP = 10;

		// Token: 0x0403D158 RID: 250200
		[Token(Token = "0x403D158")]
		private const float SMALL_INPUT_SINGLE_PRICE_TWEEN_DUR = 0.1f;

		// Token: 0x0403D159 RID: 250201
		[Token(Token = "0x403D159")]
		private const int SMALL_INPUT_LIMIT_UP = 5;

		// Token: 0x0403D15A RID: 250202
		[Token(Token = "0x403D15A")]
		private const float TINY_INPUT_SINGLE_PRICE_TWEEN_DUR = 0.05f;

		// Token: 0x0403D15B RID: 250203
		[Token(Token = "0x403D15B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_boxId;

		// Token: 0x0403D15C RID: 250204
		[Token(Token = "0x403D15C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_boxId;

		// Token: 0x0403D15D RID: 250205
		[Token(Token = "0x403D15D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_containUnlimitGoods;

		// Token: 0x0403D15E RID: 250206
		[Token(Token = "0x403D15E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_containUnlimitGoods;

		// Token: 0x0403D15F RID: 250207
		[Token(Token = "0x403D15F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_boxData;

		// Token: 0x0403D160 RID: 250208
		[Token(Token = "0x403D160")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_boxData;

		// Token: 0x0403D161 RID: 250209
		[Token(Token = "0x403D161")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403D162 RID: 250210
		[Token(Token = "0x403D162")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403D163 RID: 250211
		[Token(Token = "0x403D163")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetInputPerPriceDur;

		// Token: 0x0403D164 RID: 250212
		[Token(Token = "0x403D164")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsGachaBoxAllTakeOut;

		// Token: 0x0403D165 RID: 250213
		[Token(Token = "0x403D165")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsGachaDisplayTypeGridAllTakeOut;

		// Token: 0x0403D166 RID: 250214
		[Token(Token = "0x403D166")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetGoodLayoutScrollTarget;

		// Token: 0x0403D167 RID: 250215
		[Token(Token = "0x403D167")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetGachaBoxRemainCount;

		// Token: 0x0403D168 RID: 250216
		[Token(Token = "0x403D168")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetMaxCanDrawPriceCount;

		// Token: 0x0403D169 RID: 250217
		[Token(Token = "0x403D169")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__IsInputsOverMaxTweenDur;

		// Token: 0x0403D16A RID: 250218
		[Token(Token = "0x403D16A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020075C3 RID: 30147
		[Token(Token = "0x20075C3")]
		private struct DisplayHeightInfo
		{
			// Token: 0x0602A741 RID: 173889 RVA: 0x000D89D8 File Offset: 0x000D6BD8
			[Token(Token = "0x602A741")]
			[Address(RVA = "0x2633A50", Offset = "0x2632650", VA = "0x182633A50")]
			public static Act24sideMeldingGoodGroupViewModel.DisplayHeightInfo Create(Act24SideData.MeldingGoodDisplayType type, float height)
			{
				return default(Act24sideMeldingGoodGroupViewModel.DisplayHeightInfo);
			}

			// Token: 0x0403D16B RID: 250219
			[Token(Token = "0x403D16B")]
			[FieldOffset(Offset = "0x0")]
			public Act24SideData.MeldingGoodDisplayType type;

			// Token: 0x0403D16C RID: 250220
			[Token(Token = "0x403D16C")]
			[FieldOffset(Offset = "0x4")]
			public float height;
		}
	}
}
