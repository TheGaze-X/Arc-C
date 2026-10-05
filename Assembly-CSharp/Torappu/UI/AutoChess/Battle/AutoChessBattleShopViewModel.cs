using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006505 RID: 25861
	[Token(Token = "0x2006505")]
	public class AutoChessBattleShopViewModel : IHotfixable
	{
		// Token: 0x170057BA RID: 22458
		// (get) Token: 0x060252AB RID: 152235 RVA: 0x000C6C18 File Offset: 0x000C4E18
		// (set) Token: 0x060252AC RID: 152236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057BA")]
		public bool show
		{
			[Token(Token = "0x60252AB")]
			[Address(RVA = "0x201F3A0", Offset = "0x201DFA0", VA = "0x18201F3A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60252AC")]
			[Address(RVA = "0x201FA80", Offset = "0x201E680", VA = "0x18201FA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057BB RID: 22459
		// (get) Token: 0x060252AD RID: 152237 RVA: 0x000C6C30 File Offset: 0x000C4E30
		// (set) Token: 0x060252AE RID: 152238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057BB")]
		public bool avalid
		{
			[Token(Token = "0x60252AD")]
			[Address(RVA = "0x201EE70", Offset = "0x201DA70", VA = "0x18201EE70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60252AE")]
			[Address(RVA = "0x201F540", Offset = "0x201E140", VA = "0x18201F540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057BC RID: 22460
		// (get) Token: 0x060252AF RID: 152239 RVA: 0x000C6C48 File Offset: 0x000C4E48
		// (set) Token: 0x060252B0 RID: 152240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057BC")]
		public bool unfold
		{
			[Token(Token = "0x60252AF")]
			[Address(RVA = "0x201F400", Offset = "0x201E000", VA = "0x18201F400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60252B0")]
			[Address(RVA = "0x201FAF0", Offset = "0x201E6F0", VA = "0x18201FAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057BD RID: 22461
		// (get) Token: 0x060252B1 RID: 152241 RVA: 0x000C6C60 File Offset: 0x000C4E60
		// (set) Token: 0x060252B2 RID: 152242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057BD")]
		public AutoChessBattleShopSlot selectSlot
		{
			[Token(Token = "0x60252B1")]
			[Address(RVA = "0x201F340", Offset = "0x201DF40", VA = "0x18201F340")]
			[CompilerGenerated]
			get
			{
				return default(AutoChessBattleShopSlot);
			}
			[Token(Token = "0x60252B2")]
			[Address(RVA = "0x201FA10", Offset = "0x201E610", VA = "0x18201FA10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057BE RID: 22462
		// (get) Token: 0x060252B3 RID: 152243 RVA: 0x000C6C78 File Offset: 0x000C4E78
		// (set) Token: 0x060252B4 RID: 152244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057BE")]
		public int coinCount
		{
			[Token(Token = "0x60252B3")]
			[Address(RVA = "0x201EED0", Offset = "0x201DAD0", VA = "0x18201EED0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60252B4")]
			[Address(RVA = "0x201F5B0", Offset = "0x201E1B0", VA = "0x18201F5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057BF RID: 22463
		// (get) Token: 0x060252B5 RID: 152245 RVA: 0x000C6C90 File Offset: 0x000C4E90
		// (set) Token: 0x060252B6 RID: 152246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057BF")]
		public int level
		{
			[Token(Token = "0x60252B5")]
			[Address(RVA = "0x201F160", Offset = "0x201DD60", VA = "0x18201F160")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60252B6")]
			[Address(RVA = "0x201F7E0", Offset = "0x201E3E0", VA = "0x18201F7E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057C0 RID: 22464
		// (get) Token: 0x060252B7 RID: 152247 RVA: 0x000C6CA8 File Offset: 0x000C4EA8
		// (set) Token: 0x060252B8 RID: 152248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057C0")]
		public int maxLevel
		{
			[Token(Token = "0x60252B7")]
			[Address(RVA = "0x201F1C0", Offset = "0x201DDC0", VA = "0x18201F1C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60252B8")]
			[Address(RVA = "0x201F850", Offset = "0x201E450", VA = "0x18201F850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057C1 RID: 22465
		// (get) Token: 0x060252B9 RID: 152249 RVA: 0x000C6CC0 File Offset: 0x000C4EC0
		// (set) Token: 0x060252BA RID: 152250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057C1")]
		public AutoChessBattleShopGoodsType goodsType
		{
			[Token(Token = "0x60252B9")]
			[Address(RVA = "0x201EF90", Offset = "0x201DB90", VA = "0x18201EF90")]
			[CompilerGenerated]
			get
			{
				return AutoChessBattleShopGoodsType.NORMAL;
			}
			[Token(Token = "0x60252BA")]
			[Address(RVA = "0x201F690", Offset = "0x201E290", VA = "0x18201F690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057C2 RID: 22466
		// (get) Token: 0x060252BB RID: 152251 RVA: 0x000C6CD8 File Offset: 0x000C4ED8
		[Token(Token = "0x170057C2")]
		public bool isSpecialRecruit
		{
			[Token(Token = "0x60252BB")]
			[Address(RVA = "0x201F0B0", Offset = "0x201DCB0", VA = "0x18201F0B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170057C3 RID: 22467
		// (get) Token: 0x060252BC RID: 152252 RVA: 0x000C6CF0 File Offset: 0x000C4EF0
		// (set) Token: 0x060252BD RID: 152253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057C3")]
		public int upgradeCost
		{
			[Token(Token = "0x60252BC")]
			[Address(RVA = "0x201F4E0", Offset = "0x201E0E0", VA = "0x18201F4E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60252BD")]
			[Address(RVA = "0x201FBE0", Offset = "0x201E7E0", VA = "0x18201FBE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057C4 RID: 22468
		// (get) Token: 0x060252BE RID: 152254 RVA: 0x000C6D08 File Offset: 0x000C4F08
		// (set) Token: 0x060252BF RID: 152255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057C4")]
		public int freeRefreshCnt
		{
			[Token(Token = "0x60252BE")]
			[Address(RVA = "0x201EF30", Offset = "0x201DB30", VA = "0x18201EF30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60252BF")]
			[Address(RVA = "0x201F620", Offset = "0x201E220", VA = "0x18201F620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057C5 RID: 22469
		// (get) Token: 0x060252C0 RID: 152256 RVA: 0x000C6D20 File Offset: 0x000C4F20
		// (set) Token: 0x060252C1 RID: 152257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057C5")]
		public int refreshCost
		{
			[Token(Token = "0x60252C0")]
			[Address(RVA = "0x201F220", Offset = "0x201DE20", VA = "0x18201F220")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60252C1")]
			[Address(RVA = "0x201F8C0", Offset = "0x201E4C0", VA = "0x18201F8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057C6 RID: 22470
		// (get) Token: 0x060252C2 RID: 152258 RVA: 0x000C6D38 File Offset: 0x000C4F38
		// (set) Token: 0x060252C3 RID: 152259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057C6")]
		public bool isSpecRefresh
		{
			[Token(Token = "0x60252C2")]
			[Address(RVA = "0x201F050", Offset = "0x201DC50", VA = "0x18201F050")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60252C3")]
			[Address(RVA = "0x201F770", Offset = "0x201E370", VA = "0x18201F770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057C7 RID: 22471
		// (get) Token: 0x060252C4 RID: 152260 RVA: 0x000C6D50 File Offset: 0x000C4F50
		// (set) Token: 0x060252C5 RID: 152261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057C7")]
		public bool isFrozen
		{
			[Token(Token = "0x60252C4")]
			[Address(RVA = "0x201EFF0", Offset = "0x201DBF0", VA = "0x18201EFF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60252C5")]
			[Address(RVA = "0x201F700", Offset = "0x201E300", VA = "0x18201F700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057C8 RID: 22472
		// (get) Token: 0x060252C6 RID: 152262 RVA: 0x000C6D68 File Offset: 0x000C4F68
		// (set) Token: 0x060252C7 RID: 152263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057C8")]
		public int remainCharCnt
		{
			[Token(Token = "0x60252C6")]
			[Address(RVA = "0x201F2E0", Offset = "0x201DEE0", VA = "0x18201F2E0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60252C7")]
			[Address(RVA = "0x201F9A0", Offset = "0x201E5A0", VA = "0x18201F9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057C9 RID: 22473
		// (get) Token: 0x060252C8 RID: 152264 RVA: 0x000C6D80 File Offset: 0x000C4F80
		// (set) Token: 0x060252C9 RID: 152265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057C9")]
		public int refreshSeq
		{
			[Token(Token = "0x60252C8")]
			[Address(RVA = "0x201F280", Offset = "0x201DE80", VA = "0x18201F280")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60252C9")]
			[Address(RVA = "0x201F930", Offset = "0x201E530", VA = "0x18201F930")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170057CA RID: 22474
		// (get) Token: 0x060252CA RID: 152266 RVA: 0x000C6D98 File Offset: 0x000C4F98
		// (set) Token: 0x060252CB RID: 152267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057CA")]
		public Color upgradeCostColor
		{
			[Token(Token = "0x60252CA")]
			[Address(RVA = "0x201F460", Offset = "0x201E060", VA = "0x18201F460")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60252CB")]
			[Address(RVA = "0x201FB60", Offset = "0x201E760", VA = "0x18201FB60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060252CC RID: 152268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252CC")]
		[Address(RVA = "0x201D3A0", Offset = "0x201BFA0", VA = "0x18201D3A0")]
		public void Init(AutoChessBattleUIViewModel uiModel)
		{
		}

		// Token: 0x060252CD RID: 152269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252CD")]
		[Address(RVA = "0x201D540", Offset = "0x201C140", VA = "0x18201D540")]
		public void Update(AutoChessBattleUIViewModel uiModel)
		{
		}

		// Token: 0x060252CE RID: 152270 RVA: 0x000C6DB0 File Offset: 0x000C4FB0
		[Token(Token = "0x60252CE")]
		[Address(RVA = "0x201E1A0", Offset = "0x201CDA0", VA = "0x18201E1A0")]
		private bool _CalcShowStatus(AutoChessBattleUIViewModel uiModel, AutoChessGameStatus uiStatus)
		{
			return default(bool);
		}

		// Token: 0x060252CF RID: 152271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252CF")]
		[Address(RVA = "0x201E620", Offset = "0x201D220", VA = "0x18201E620")]
		private void _FillGoodsInSlot(AutoChessBattleUIViewModel uiModel, string modelId, int slotCnt)
		{
		}

		// Token: 0x060252D0 RID: 152272 RVA: 0x000C6DC8 File Offset: 0x000C4FC8
		[Token(Token = "0x60252D0")]
		[Address(RVA = "0x201E410", Offset = "0x201D010", VA = "0x18201E410")]
		private int _CalculateMaxLevel(ActAutoChessData actData, string modelId)
		{
			return 0;
		}

		// Token: 0x060252D1 RID: 152273 RVA: 0x000C6DE0 File Offset: 0x000C4FE0
		[Token(Token = "0x60252D1")]
		[Address(RVA = "0x201E2A0", Offset = "0x201CEA0", VA = "0x18201E2A0")]
		private int _CalcSlotCount(ActAutoChessData actData, string modelId, int shopLvl)
		{
			return 0;
		}

		// Token: 0x060252D2 RID: 152274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252D2")]
		[Address(RVA = "0x201EA60", Offset = "0x201D660", VA = "0x18201EA60")]
		private void _GeneLevelInitCostDict(ActAutoChessData actData, string modelId)
		{
		}

		// Token: 0x060252D3 RID: 152275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60252D3")]
		[Address(RVA = "0x201D310", Offset = "0x201BF10", VA = "0x18201D310")]
		public AutoChessBattleShopCardViewModel GetSlot(int slotId)
		{
			return null;
		}

		// Token: 0x060252D4 RID: 152276 RVA: 0x000C6DF8 File Offset: 0x000C4FF8
		[Token(Token = "0x60252D4")]
		[Address(RVA = "0x201D200", Offset = "0x201BE00", VA = "0x18201D200")]
		public Color CalcPriceColor(int currPrice, int srcPrice, AutoChessData comData)
		{
			return default(Color);
		}

		// Token: 0x060252D5 RID: 152277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60252D5")]
		[Address(RVA = "0x201EDA0", Offset = "0x201D9A0", VA = "0x18201EDA0")]
		public AutoChessBattleShopViewModel()
		{
		}

		// Token: 0x04034209 RID: 213513
		[Token(Token = "0x4034209")]
		[FieldOffset(Offset = "0x50")]
		public List<AutoChessBattleShopCardViewModel> slots;

		// Token: 0x0403420A RID: 213514
		[Token(Token = "0x403420A")]
		[FieldOffset(Offset = "0x58")]
		public SeqNumSource goldSeqNum;

		// Token: 0x0403420B RID: 213515
		[Token(Token = "0x403420B")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<int, int> m_LevelInitCostDict;

		// Token: 0x0403420C RID: 213516
		[Token(Token = "0x403420C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_show;

		// Token: 0x0403420D RID: 213517
		[Token(Token = "0x403420D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_show;

		// Token: 0x0403420E RID: 213518
		[Token(Token = "0x403420E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_avalid;

		// Token: 0x0403420F RID: 213519
		[Token(Token = "0x403420F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_avalid;

		// Token: 0x04034210 RID: 213520
		[Token(Token = "0x4034210")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_unfold;

		// Token: 0x04034211 RID: 213521
		[Token(Token = "0x4034211")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_unfold;

		// Token: 0x04034212 RID: 213522
		[Token(Token = "0x4034212")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectSlot;

		// Token: 0x04034213 RID: 213523
		[Token(Token = "0x4034213")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_selectSlot;

		// Token: 0x04034214 RID: 213524
		[Token(Token = "0x4034214")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_coinCount;

		// Token: 0x04034215 RID: 213525
		[Token(Token = "0x4034215")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_coinCount;

		// Token: 0x04034216 RID: 213526
		[Token(Token = "0x4034216")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x04034217 RID: 213527
		[Token(Token = "0x4034217")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_level;

		// Token: 0x04034218 RID: 213528
		[Token(Token = "0x4034218")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_maxLevel;

		// Token: 0x04034219 RID: 213529
		[Token(Token = "0x4034219")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_maxLevel;

		// Token: 0x0403421A RID: 213530
		[Token(Token = "0x403421A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_goodsType;

		// Token: 0x0403421B RID: 213531
		[Token(Token = "0x403421B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_goodsType;

		// Token: 0x0403421C RID: 213532
		[Token(Token = "0x403421C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isSpecialRecruit;

		// Token: 0x0403421D RID: 213533
		[Token(Token = "0x403421D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_upgradeCost;

		// Token: 0x0403421E RID: 213534
		[Token(Token = "0x403421E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_upgradeCost;

		// Token: 0x0403421F RID: 213535
		[Token(Token = "0x403421F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_freeRefreshCnt;

		// Token: 0x04034220 RID: 213536
		[Token(Token = "0x4034220")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_freeRefreshCnt;

		// Token: 0x04034221 RID: 213537
		[Token(Token = "0x4034221")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_refreshCost;

		// Token: 0x04034222 RID: 213538
		[Token(Token = "0x4034222")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_refreshCost;

		// Token: 0x04034223 RID: 213539
		[Token(Token = "0x4034223")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_isSpecRefresh;

		// Token: 0x04034224 RID: 213540
		[Token(Token = "0x4034224")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_isSpecRefresh;

		// Token: 0x04034225 RID: 213541
		[Token(Token = "0x4034225")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_isFrozen;

		// Token: 0x04034226 RID: 213542
		[Token(Token = "0x4034226")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_set_isFrozen;

		// Token: 0x04034227 RID: 213543
		[Token(Token = "0x4034227")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_remainCharCnt;

		// Token: 0x04034228 RID: 213544
		[Token(Token = "0x4034228")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_set_remainCharCnt;

		// Token: 0x04034229 RID: 213545
		[Token(Token = "0x4034229")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_refreshSeq;

		// Token: 0x0403422A RID: 213546
		[Token(Token = "0x403422A")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_set_refreshSeq;

		// Token: 0x0403422B RID: 213547
		[Token(Token = "0x403422B")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_upgradeCostColor;

		// Token: 0x0403422C RID: 213548
		[Token(Token = "0x403422C")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_set_upgradeCostColor;

		// Token: 0x0403422D RID: 213549
		[Token(Token = "0x403422D")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403422E RID: 213550
		[Token(Token = "0x403422E")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403422F RID: 213551
		[Token(Token = "0x403422F")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__CalcShowStatus;

		// Token: 0x04034230 RID: 213552
		[Token(Token = "0x4034230")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__FillGoodsInSlot;

		// Token: 0x04034231 RID: 213553
		[Token(Token = "0x4034231")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__CalculateMaxLevel;

		// Token: 0x04034232 RID: 213554
		[Token(Token = "0x4034232")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__CalcSlotCount;

		// Token: 0x04034233 RID: 213555
		[Token(Token = "0x4034233")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__GeneLevelInitCostDict;

		// Token: 0x04034234 RID: 213556
		[Token(Token = "0x4034234")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GetSlot;

		// Token: 0x04034235 RID: 213557
		[Token(Token = "0x4034235")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_CalcPriceColor;

		// Token: 0x04034236 RID: 213558
		[Token(Token = "0x4034236")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
