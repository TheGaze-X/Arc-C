using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064FC RID: 25852
	[Token(Token = "0x20064FC")]
	public class AutoChessBattleShopCardViewModel : IHotfixable
	{
		// Token: 0x170057A5 RID: 22437
		// (get) Token: 0x06025252 RID: 152146 RVA: 0x000C6AB0 File Offset: 0x000C4CB0
		// (set) Token: 0x06025253 RID: 152147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057A5")]
		public bool isEmpty
		{
			[Token(Token = "0x6025252")]
			[Address(RVA = "0x2017A10", Offset = "0x2016610", VA = "0x182017A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025253")]
			[Address(RVA = "0x2018160", Offset = "0x2016D60", VA = "0x182018160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057A6 RID: 22438
		// (get) Token: 0x06025254 RID: 152148 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025255 RID: 152149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057A6")]
		public string chessId
		{
			[Token(Token = "0x6025254")]
			[Address(RVA = "0x2017770", Offset = "0x2016370", VA = "0x182017770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025255")]
			[Address(RVA = "0x2017E20", Offset = "0x2016A20", VA = "0x182017E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057A7 RID: 22439
		// (get) Token: 0x06025256 RID: 152150 RVA: 0x000C6AC8 File Offset: 0x000C4CC8
		// (set) Token: 0x06025257 RID: 152151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057A7")]
		public bool isChar
		{
			[Token(Token = "0x6025256")]
			[Address(RVA = "0x20179B0", Offset = "0x20165B0", VA = "0x1820179B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025257")]
			[Address(RVA = "0x20180F0", Offset = "0x2016CF0", VA = "0x1820180F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057A8 RID: 22440
		// (get) Token: 0x06025258 RID: 152152 RVA: 0x000C6AE0 File Offset: 0x000C4CE0
		// (set) Token: 0x06025259 RID: 152153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057A8")]
		public int price
		{
			[Token(Token = "0x6025258")]
			[Address(RVA = "0x2017C70", Offset = "0x2016870", VA = "0x182017C70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6025259")]
			[Address(RVA = "0x2018420", Offset = "0x2017020", VA = "0x182018420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057A9 RID: 22441
		// (get) Token: 0x0602525A RID: 152154 RVA: 0x000C6AF8 File Offset: 0x000C4CF8
		// (set) Token: 0x0602525B RID: 152155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057A9")]
		public bool isHandFull
		{
			[Token(Token = "0x602525A")]
			[Address(RVA = "0x2017AD0", Offset = "0x20166D0", VA = "0x182017AD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602525B")]
			[Address(RVA = "0x2018240", Offset = "0x2016E40", VA = "0x182018240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057AA RID: 22442
		// (get) Token: 0x0602525C RID: 152156 RVA: 0x000C6B10 File Offset: 0x000C4D10
		// (set) Token: 0x0602525D RID: 152157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057AA")]
		public Color priceColor
		{
			[Token(Token = "0x602525C")]
			[Address(RVA = "0x2017BF0", Offset = "0x20167F0", VA = "0x182017BF0")]
			[CompilerGenerated]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x602525D")]
			[Address(RVA = "0x20183A0", Offset = "0x2016FA0", VA = "0x1820183A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057AB RID: 22443
		// (get) Token: 0x0602525E RID: 152158 RVA: 0x000C6B28 File Offset: 0x000C4D28
		// (set) Token: 0x0602525F RID: 152159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057AB")]
		public int level
		{
			[Token(Token = "0x602525E")]
			[Address(RVA = "0x2017B30", Offset = "0x2016730", VA = "0x182017B30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602525F")]
			[Address(RVA = "0x20182B0", Offset = "0x2016EB0", VA = "0x1820182B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057AC RID: 22444
		// (get) Token: 0x06025260 RID: 152160 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025261 RID: 152161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057AC")]
		public string name
		{
			[Token(Token = "0x6025260")]
			[Address(RVA = "0x2017B90", Offset = "0x2016790", VA = "0x182017B90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025261")]
			[Address(RVA = "0x2018320", Offset = "0x2016F20", VA = "0x182018320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057AD RID: 22445
		// (get) Token: 0x06025262 RID: 152162 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025263 RID: 152163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057AD")]
		public string icon
		{
			[Token(Token = "0x6025262")]
			[Address(RVA = "0x2017950", Offset = "0x2016550", VA = "0x182017950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025263")]
			[Address(RVA = "0x2018070", Offset = "0x2016C70", VA = "0x182018070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057AE RID: 22446
		// (get) Token: 0x06025264 RID: 152164 RVA: 0x000C6B40 File Offset: 0x000C4D40
		// (set) Token: 0x06025265 RID: 152165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057AE")]
		public ProfessionCategory profession
		{
			[Token(Token = "0x6025264")]
			[Address(RVA = "0x2017CD0", Offset = "0x20168D0", VA = "0x182017CD0")]
			[CompilerGenerated]
			get
			{
				return ProfessionCategory.NONE;
			}
			[Token(Token = "0x6025265")]
			[Address(RVA = "0x2018490", Offset = "0x2017090", VA = "0x182018490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057AF RID: 22447
		// (get) Token: 0x06025266 RID: 152166 RVA: 0x000C6B58 File Offset: 0x000C4D58
		// (set) Token: 0x06025267 RID: 152167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057AF")]
		public ChessBackupCharDiff diff
		{
			[Token(Token = "0x6025266")]
			[Address(RVA = "0x2017830", Offset = "0x2016430", VA = "0x182017830")]
			[CompilerGenerated]
			get
			{
				return ChessBackupCharDiff.NONE;
			}
			[Token(Token = "0x6025267")]
			[Address(RVA = "0x2017F10", Offset = "0x2016B10", VA = "0x182017F10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057B0 RID: 22448
		// (get) Token: 0x06025268 RID: 152168 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025269 RID: 152169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057B0")]
		public string garrisonTypeIcon
		{
			[Token(Token = "0x6025268")]
			[Address(RVA = "0x2017890", Offset = "0x2016490", VA = "0x182017890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025269")]
			[Address(RVA = "0x2017F80", Offset = "0x2016B80", VA = "0x182017F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057B1 RID: 22449
		// (get) Token: 0x0602526A RID: 152170 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602526B RID: 152171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057B1")]
		public List<AutoChessBattleShopBondViewModel> bondList
		{
			[Token(Token = "0x602526A")]
			[Address(RVA = "0x20176B0", Offset = "0x20162B0", VA = "0x1820176B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602526B")]
			[Address(RVA = "0x2017D30", Offset = "0x2016930", VA = "0x182017D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057B2 RID: 22450
		// (get) Token: 0x0602526C RID: 152172 RVA: 0x000C6B70 File Offset: 0x000C4D70
		// (set) Token: 0x0602526D RID: 152173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057B2")]
		public int currCoin
		{
			[Token(Token = "0x602526C")]
			[Address(RVA = "0x20177D0", Offset = "0x20163D0", VA = "0x1820177D0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602526D")]
			[Address(RVA = "0x2017EA0", Offset = "0x2016AA0", VA = "0x182017EA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057B3 RID: 22451
		// (get) Token: 0x0602526E RID: 152174 RVA: 0x000C6B88 File Offset: 0x000C4D88
		// (set) Token: 0x0602526F RID: 152175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057B3")]
		public bool isFrozen
		{
			[Token(Token = "0x602526E")]
			[Address(RVA = "0x2017A70", Offset = "0x2016670", VA = "0x182017A70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602526F")]
			[Address(RVA = "0x20181D0", Offset = "0x2016DD0", VA = "0x1820181D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057B4 RID: 22452
		// (get) Token: 0x06025270 RID: 152176 RVA: 0x000C6BA0 File Offset: 0x000C4DA0
		// (set) Token: 0x06025271 RID: 152177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057B4")]
		public bool hasSame
		{
			[Token(Token = "0x6025270")]
			[Address(RVA = "0x20178F0", Offset = "0x20164F0", VA = "0x1820178F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025271")]
			[Address(RVA = "0x2018000", Offset = "0x2016C00", VA = "0x182018000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170057B5 RID: 22453
		// (get) Token: 0x06025272 RID: 152178 RVA: 0x000C6BB8 File Offset: 0x000C4DB8
		// (set) Token: 0x06025273 RID: 152179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057B5")]
		public bool canComb
		{
			[Token(Token = "0x6025272")]
			[Address(RVA = "0x2017710", Offset = "0x2016310", VA = "0x182017710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6025273")]
			[Address(RVA = "0x2017DB0", Offset = "0x20169B0", VA = "0x182017DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06025274 RID: 152180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025274")]
		[Address(RVA = "0x2015D70", Offset = "0x2014970", VA = "0x182015D70")]
		public void UpdateGoods(ChessGoods good, AutoChessBattleUIViewModel uiModel)
		{
		}

		// Token: 0x06025275 RID: 152181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025275")]
		[Address(RVA = "0x2016C90", Offset = "0x2015890", VA = "0x182016C90")]
		private void _LoadCharInfo(AutoChessBattleUIViewModel uiModel, ChessSquad chess)
		{
		}

		// Token: 0x06025276 RID: 152182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025276")]
		[Address(RVA = "0x20161A0", Offset = "0x2014DA0", VA = "0x1820161A0")]
		private void _LoadCharBondList(CharQuery charQuery, AutoChessBattleUIViewModel uiModel)
		{
		}

		// Token: 0x06025277 RID: 152183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025277")]
		[Address(RVA = "0x2017220", Offset = "0x2015E20", VA = "0x182017220")]
		private void _LoadEquipInfo(AutoChessBattleUIViewModel uiModel, ChessSquad chess)
		{
		}

		// Token: 0x06025278 RID: 152184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025278")]
		[Address(RVA = "0x2015AF0", Offset = "0x20146F0", VA = "0x182015AF0")]
		public void Clear()
		{
		}

		// Token: 0x06025279 RID: 152185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025279")]
		[Address(RVA = "0x2017640", Offset = "0x2016240", VA = "0x182017640")]
		public AutoChessBattleShopCardViewModel()
		{
		}

		// Token: 0x0403416D RID: 213357
		[Token(Token = "0x403416D")]
		private const int INVALID_COMB_CNT = 100;

		// Token: 0x0403416E RID: 213358
		[Token(Token = "0x403416E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEmpty;

		// Token: 0x0403416F RID: 213359
		[Token(Token = "0x403416F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isEmpty;

		// Token: 0x04034170 RID: 213360
		[Token(Token = "0x4034170")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_chessId;

		// Token: 0x04034171 RID: 213361
		[Token(Token = "0x4034171")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_chessId;

		// Token: 0x04034172 RID: 213362
		[Token(Token = "0x4034172")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isChar;

		// Token: 0x04034173 RID: 213363
		[Token(Token = "0x4034173")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_isChar;

		// Token: 0x04034174 RID: 213364
		[Token(Token = "0x4034174")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_price;

		// Token: 0x04034175 RID: 213365
		[Token(Token = "0x4034175")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_price;

		// Token: 0x04034176 RID: 213366
		[Token(Token = "0x4034176")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isHandFull;

		// Token: 0x04034177 RID: 213367
		[Token(Token = "0x4034177")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isHandFull;

		// Token: 0x04034178 RID: 213368
		[Token(Token = "0x4034178")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_priceColor;

		// Token: 0x04034179 RID: 213369
		[Token(Token = "0x4034179")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_priceColor;

		// Token: 0x0403417A RID: 213370
		[Token(Token = "0x403417A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_level;

		// Token: 0x0403417B RID: 213371
		[Token(Token = "0x403417B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_level;

		// Token: 0x0403417C RID: 213372
		[Token(Token = "0x403417C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_name;

		// Token: 0x0403417D RID: 213373
		[Token(Token = "0x403417D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_name;

		// Token: 0x0403417E RID: 213374
		[Token(Token = "0x403417E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_icon;

		// Token: 0x0403417F RID: 213375
		[Token(Token = "0x403417F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_icon;

		// Token: 0x04034180 RID: 213376
		[Token(Token = "0x4034180")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_profession;

		// Token: 0x04034181 RID: 213377
		[Token(Token = "0x4034181")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_profession;

		// Token: 0x04034182 RID: 213378
		[Token(Token = "0x4034182")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_diff;

		// Token: 0x04034183 RID: 213379
		[Token(Token = "0x4034183")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_set_diff;

		// Token: 0x04034184 RID: 213380
		[Token(Token = "0x4034184")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_garrisonTypeIcon;

		// Token: 0x04034185 RID: 213381
		[Token(Token = "0x4034185")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_set_garrisonTypeIcon;

		// Token: 0x04034186 RID: 213382
		[Token(Token = "0x4034186")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_bondList;

		// Token: 0x04034187 RID: 213383
		[Token(Token = "0x4034187")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_set_bondList;

		// Token: 0x04034188 RID: 213384
		[Token(Token = "0x4034188")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_currCoin;

		// Token: 0x04034189 RID: 213385
		[Token(Token = "0x4034189")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_currCoin;

		// Token: 0x0403418A RID: 213386
		[Token(Token = "0x403418A")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_isFrozen;

		// Token: 0x0403418B RID: 213387
		[Token(Token = "0x403418B")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_isFrozen;

		// Token: 0x0403418C RID: 213388
		[Token(Token = "0x403418C")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_hasSame;

		// Token: 0x0403418D RID: 213389
		[Token(Token = "0x403418D")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_set_hasSame;

		// Token: 0x0403418E RID: 213390
		[Token(Token = "0x403418E")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_canComb;

		// Token: 0x0403418F RID: 213391
		[Token(Token = "0x403418F")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_set_canComb;

		// Token: 0x04034190 RID: 213392
		[Token(Token = "0x4034190")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_UpdateGoods;

		// Token: 0x04034191 RID: 213393
		[Token(Token = "0x4034191")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__LoadCharInfo;

		// Token: 0x04034192 RID: 213394
		[Token(Token = "0x4034192")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__LoadCharBondList;

		// Token: 0x04034193 RID: 213395
		[Token(Token = "0x4034193")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__LoadEquipInfo;

		// Token: 0x04034194 RID: 213396
		[Token(Token = "0x4034194")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04034195 RID: 213397
		[Token(Token = "0x4034195")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
