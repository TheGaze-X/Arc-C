using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002613 RID: 9747
	[Token(Token = "0x2002613")]
	[SelectionBase]
	public class Token : Character
	{
		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x0600FE1C RID: 65052 RVA: 0x000603F0 File Offset: 0x0005E5F0
		[Token(Token = "0x17002246")]
		protected bool isEnemySideToken
		{
			[Token(Token = "0x600FE1C")]
			[Address(RVA = "0x763360", Offset = "0x761F60", VA = "0x180763360")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x0600FE1D RID: 65053 RVA: 0x00060408 File Offset: 0x0005E608
		[Token(Token = "0x17002247")]
		public override bool hideTileOption
		{
			[Token(Token = "0x600FE1D")]
			[Address(RVA = "0x7631E0", Offset = "0x761DE0", VA = "0x1807631E0", Slot = "194")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x0600FE1E RID: 65054 RVA: 0x00060420 File Offset: 0x0005E620
		[Token(Token = "0x17002248")]
		protected override SideType initSideType
		{
			[Token(Token = "0x600FE1E")]
			[Address(RVA = "0x763300", Offset = "0x761F00", VA = "0x180763300", Slot = "193")]
			get
			{
				return SideType.NONE;
			}
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x0600FE1F RID: 65055 RVA: 0x00060438 File Offset: 0x0005E638
		[Token(Token = "0x17002249")]
		public override EntityCategory category
		{
			[Token(Token = "0x600FE1F")]
			[Address(RVA = "0x75F070", Offset = "0x75DC70", VA = "0x18075F070", Slot = "47")]
			get
			{
				return EntityCategory.NONE;
			}
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x0600FE20 RID: 65056 RVA: 0x00060450 File Offset: 0x0005E650
		[Token(Token = "0x1700224A")]
		public Deck.Card.CardPolicy cardPolicy
		{
			[Token(Token = "0x600FE20")]
			[Address(RVA = "0x763120", Offset = "0x761D20", VA = "0x180763120")]
			get
			{
				return Deck.Card.CardPolicy.DEFAULT;
			}
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x0600FE21 RID: 65057 RVA: 0x00060468 File Offset: 0x0005E668
		[Token(Token = "0x1700224B")]
		public bool isUnique
		{
			[Token(Token = "0x600FE21")]
			[Address(RVA = "0x763420", Offset = "0x762020", VA = "0x180763420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x0600FE22 RID: 65058 RVA: 0x00060480 File Offset: 0x0005E680
		[Token(Token = "0x1700224C")]
		public override bool showHpSlider
		{
			[Token(Token = "0x600FE22")]
			[Address(RVA = "0x764140", Offset = "0x762D40", VA = "0x180764140", Slot = "195")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x0600FE23 RID: 65059 RVA: 0x00060498 File Offset: 0x0005E698
		[Token(Token = "0x1700224D")]
		public override bool showSpSlider
		{
			[Token(Token = "0x600FE23")]
			[Address(RVA = "0x764330", Offset = "0x762F30", VA = "0x180764330", Slot = "196")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x0600FE24 RID: 65060 RVA: 0x000604B0 File Offset: 0x0005E6B0
		[Token(Token = "0x1700224E")]
		public bool rechargeOnlyOnce
		{
			[Token(Token = "0x600FE24")]
			[Address(RVA = "0x7638C0", Offset = "0x7624C0", VA = "0x1807638C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x0600FE25 RID: 65061 RVA: 0x000604C8 File Offset: 0x0005E6C8
		[Token(Token = "0x1700224F")]
		public bool isInfinity
		{
			[Token(Token = "0x600FE25")]
			[Address(RVA = "0x7633C0", Offset = "0x761FC0", VA = "0x1807633C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x0600FE26 RID: 65062 RVA: 0x000604E0 File Offset: 0x0005E6E0
		[Token(Token = "0x17002250")]
		public bool ignoreExcludeFromBattle
		{
			[Token(Token = "0x600FE26")]
			[Address(RVA = "0x7632A0", Offset = "0x761EA0", VA = "0x1807632A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002251 RID: 8785
		// (get) Token: 0x0600FE27 RID: 65063 RVA: 0x000604F8 File Offset: 0x0005E6F8
		[Token(Token = "0x17002251")]
		public bool notShowInDeck
		{
			[Token(Token = "0x600FE27")]
			[Address(RVA = "0x763860", Offset = "0x762460", VA = "0x180763860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002252 RID: 8786
		// (get) Token: 0x0600FE28 RID: 65064 RVA: 0x00060510 File Offset: 0x0005E710
		[Token(Token = "0x17002252")]
		public bool asRewardCardInLegionMode
		{
			[Token(Token = "0x600FE28")]
			[Address(RVA = "0x7630C0", Offset = "0x761CC0", VA = "0x1807630C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002253 RID: 8787
		// (get) Token: 0x0600FE29 RID: 65065 RVA: 0x00060528 File Offset: 0x0005E728
		[Token(Token = "0x17002253")]
		public bool alwaysShowHp
		{
			[Token(Token = "0x600FE29")]
			[Address(RVA = "0x763060", Offset = "0x761C60", VA = "0x180763060")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002254 RID: 8788
		// (get) Token: 0x0600FE2A RID: 65066 RVA: 0x00060540 File Offset: 0x0005E740
		[Token(Token = "0x17002254")]
		public bool alwaysHideHp
		{
			[Token(Token = "0x600FE2A")]
			[Address(RVA = "0x762E80", Offset = "0x761A80", VA = "0x180762E80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002255 RID: 8789
		// (get) Token: 0x0600FE2B RID: 65067 RVA: 0x00060558 File Offset: 0x0005E758
		[Token(Token = "0x17002255")]
		public bool alwaysHideSp
		{
			[Token(Token = "0x600FE2B")]
			[Address(RVA = "0x762F70", Offset = "0x761B70", VA = "0x180762F70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002256 RID: 8790
		// (get) Token: 0x0600FE2C RID: 65068 RVA: 0x00060570 File Offset: 0x0005E770
		[Token(Token = "0x17002256")]
		public override bool forceUseAllyHud
		{
			[Token(Token = "0x600FE2C")]
			[Address(RVA = "0x763180", Offset = "0x761D80", VA = "0x180763180", Slot = "198")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002257 RID: 8791
		// (get) Token: 0x0600FE2D RID: 65069 RVA: 0x00060588 File Offset: 0x0005E788
		[Token(Token = "0x17002257")]
		protected override bool allowWithdrawGainCost
		{
			[Token(Token = "0x600FE2D")]
			[Address(RVA = "0x762E20", Offset = "0x761A20", VA = "0x180762E20", Slot = "207")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002258 RID: 8792
		// (get) Token: 0x0600FE2E RID: 65070 RVA: 0x000605A0 File Offset: 0x0005E7A0
		[Token(Token = "0x17002258")]
		public bool rewriteTileOptions
		{
			[Token(Token = "0x600FE2E")]
			[Address(RVA = "0x7640E0", Offset = "0x762CE0", VA = "0x1807640E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002259 RID: 8793
		// (get) Token: 0x0600FE2F RID: 65071 RVA: 0x000605B8 File Offset: 0x0005E7B8
		[Token(Token = "0x17002259")]
		public bool ignoreBlockAnyRoutes
		{
			[Token(Token = "0x600FE2F")]
			[Address(RVA = "0x763240", Offset = "0x761E40", VA = "0x180763240")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700225A RID: 8794
		// (get) Token: 0x0600FE30 RID: 65072 RVA: 0x000605D0 File Offset: 0x0005E7D0
		[Token(Token = "0x1700225A")]
		public bool tokenCanBeOverlapDontAddTileBuff
		{
			[Token(Token = "0x600FE30")]
			[Address(RVA = "0x7646C0", Offset = "0x7632C0", VA = "0x1807646C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x0600FE31 RID: 65073 RVA: 0x000605E8 File Offset: 0x0005E7E8
		[Token(Token = "0x1700225B")]
		public Tile.Options tileOptions
		{
			[Token(Token = "0x600FE31")]
			[Address(RVA = "0x764470", Offset = "0x763070", VA = "0x180764470")]
			get
			{
				return default(Tile.Options);
			}
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x0600FE32 RID: 65074 RVA: 0x00060600 File Offset: 0x0005E800
		[Token(Token = "0x1700225C")]
		public bool keepCurrentPassableMask
		{
			[Token(Token = "0x600FE32")]
			[Address(RVA = "0x763670", Offset = "0x762270", VA = "0x180763670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x0600FE33 RID: 65075 RVA: 0x00060618 File Offset: 0x0005E818
		[Token(Token = "0x1700225D")]
		public bool keepCurrentBuildableType
		{
			[Token(Token = "0x600FE33")]
			[Address(RVA = "0x763480", Offset = "0x762080", VA = "0x180763480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700225E RID: 8798
		// (get) Token: 0x0600FE34 RID: 65076 RVA: 0x00060630 File Offset: 0x0005E830
		[Token(Token = "0x1700225E")]
		public bool rewriteTileHeightType
		{
			[Token(Token = "0x600FE34")]
			[Address(RVA = "0x763D00", Offset = "0x762900", VA = "0x180763D00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700225F RID: 8799
		// (get) Token: 0x0600FE35 RID: 65077 RVA: 0x00060648 File Offset: 0x0005E848
		[Token(Token = "0x1700225F")]
		public bool rewriteTileHeight
		{
			[Token(Token = "0x600FE35")]
			[Address(RVA = "0x763EF0", Offset = "0x762AF0", VA = "0x180763EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002260 RID: 8800
		// (get) Token: 0x0600FE36 RID: 65078 RVA: 0x00060660 File Offset: 0x0005E860
		[Token(Token = "0x17002260")]
		public float rewriteHeight
		{
			[Token(Token = "0x600FE36")]
			[Address(RVA = "0x763920", Offset = "0x762520", VA = "0x180763920")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17002261 RID: 8801
		// (get) Token: 0x0600FE37 RID: 65079 RVA: 0x00060678 File Offset: 0x0005E878
		[Token(Token = "0x17002261")]
		public bool rewriteTileAdvancedBuildMask
		{
			[Token(Token = "0x600FE37")]
			[Address(RVA = "0x763B10", Offset = "0x762710", VA = "0x180763B10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600FE38 RID: 65080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE38")]
		[Address(RVA = "0x75EF70", Offset = "0x75DB70", VA = "0x18075EF70", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600FE39 RID: 65081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE39")]
		[Address(RVA = "0x75D620", Offset = "0x75C220", VA = "0x18075D620", Slot = "29")]
		protected override void OnReset()
		{
		}

		// Token: 0x0600FE3A RID: 65082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE3A")]
		[Address(RVA = "0x762780", Offset = "0x761380", VA = "0x180762780", Slot = "182")]
		protected override void OnSwitchMode(UnitMode next, UnitMode last, bool restartFSM)
		{
		}

		// Token: 0x0600FE3B RID: 65083 RVA: 0x00060690 File Offset: 0x0005E890
		[Token(Token = "0x600FE3B")]
		[Address(RVA = "0x7623C0", Offset = "0x760FC0", VA = "0x1807623C0", Slot = "215")]
		protected override float GetTileLocateHeight()
		{
			return 0f;
		}

		// Token: 0x0600FE3C RID: 65084 RVA: 0x000606A8 File Offset: 0x0005E8A8
		[Token(Token = "0x600FE3C")]
		[Address(RVA = "0x762D00", Offset = "0x761900", VA = "0x180762D00")]
		private bool _NeedReduceSelfLocatedHeight()
		{
			return default(bool);
		}

		// Token: 0x0600FE3D RID: 65085 RVA: 0x000606C0 File Offset: 0x0005E8C0
		[Token(Token = "0x600FE3D")]
		[Address(RVA = "0x7624A0", Offset = "0x7610A0", VA = "0x1807624A0", Slot = "218")]
		public override bool OnEntityOverlapLikeOperationSucceed(SharedConsts.Direction direction, Tile targetTile, Deck.SpawnDetailsTracker spawnDetailsTracker)
		{
			return default(bool);
		}

		// Token: 0x0600FE3E RID: 65086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE3E")]
		[Address(RVA = "0x75EFE0", Offset = "0x75DBE0", VA = "0x18075EFE0", Slot = "219")]
		public virtual void SwitchCategory(EntityCategory inputCategory)
		{
		}

		// Token: 0x0600FE3F RID: 65087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE3F")]
		[Address(RVA = "0x762D80", Offset = "0x761980", VA = "0x180762D80")]
		public Token()
		{
		}

		// Token: 0x0600FE40 RID: 65088 RVA: 0x000606D8 File Offset: 0x0005E8D8
		[Token(Token = "0x600FE40")]
		[Address(RVA = "0x762CC0", Offset = "0x7618C0", VA = "0x180762CC0")]
		private bool <>xLuaBaseProxy_get_hideTileOption()
		{
			return default(bool);
		}

		// Token: 0x0600FE41 RID: 65089 RVA: 0x000606F0 File Offset: 0x0005E8F0
		[Token(Token = "0x600FE41")]
		[Address(RVA = "0x762CD0", Offset = "0x7618D0", VA = "0x180762CD0")]
		private SideType <>xLuaBaseProxy_get_initSideType()
		{
			return SideType.NONE;
		}

		// Token: 0x0600FE42 RID: 65090 RVA: 0x00060708 File Offset: 0x0005E908
		[Token(Token = "0x600FE42")]
		[Address(RVA = "0x762C50", Offset = "0x761850", VA = "0x180762C50")]
		private EntityCategory <>xLuaBaseProxy_get_category()
		{
			return EntityCategory.NONE;
		}

		// Token: 0x0600FE43 RID: 65091 RVA: 0x00060720 File Offset: 0x0005E920
		[Token(Token = "0x600FE43")]
		[Address(RVA = "0x762CE0", Offset = "0x7618E0", VA = "0x180762CE0")]
		private bool <>xLuaBaseProxy_get_showHpSlider()
		{
			return default(bool);
		}

		// Token: 0x0600FE44 RID: 65092 RVA: 0x00060738 File Offset: 0x0005E938
		[Token(Token = "0x600FE44")]
		[Address(RVA = "0x762CF0", Offset = "0x7618F0", VA = "0x180762CF0")]
		private bool <>xLuaBaseProxy_get_showSpSlider()
		{
			return default(bool);
		}

		// Token: 0x0600FE45 RID: 65093 RVA: 0x00060750 File Offset: 0x0005E950
		[Token(Token = "0x600FE45")]
		[Address(RVA = "0x762CB0", Offset = "0x7618B0", VA = "0x180762CB0")]
		private bool <>xLuaBaseProxy_get_forceUseAllyHud()
		{
			return default(bool);
		}

		// Token: 0x0600FE46 RID: 65094 RVA: 0x00060768 File Offset: 0x0005E968
		[Token(Token = "0x600FE46")]
		[Address(RVA = "0x762C40", Offset = "0x761840", VA = "0x180762C40")]
		private bool <>xLuaBaseProxy_get_allowWithdrawGainCost()
		{
			return default(bool);
		}

		// Token: 0x0600FE47 RID: 65095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE47")]
		[Address(RVA = "0x762C10", Offset = "0x761810", VA = "0x180762C10")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600FE48 RID: 65096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE48")]
		[Address(RVA = "0x762C30", Offset = "0x761830", VA = "0x180762C30")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600FE49 RID: 65097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FE49")]
		[Address(RVA = "0x72B7E0", Offset = "0x72A3E0", VA = "0x18072B7E0")]
		private void <>xLuaBaseProxy_OnSwitchMode(UnitMode P0, UnitMode P1, bool P2)
		{
		}

		// Token: 0x0600FE4A RID: 65098 RVA: 0x00060780 File Offset: 0x0005E980
		[Token(Token = "0x600FE4A")]
		[Address(RVA = "0x762C00", Offset = "0x761800", VA = "0x180762C00")]
		private float <>xLuaBaseProxy_GetTileLocateHeight()
		{
			return 0f;
		}

		// Token: 0x0600FE4B RID: 65099 RVA: 0x00060798 File Offset: 0x0005E998
		[Token(Token = "0x600FE4B")]
		[Address(RVA = "0x762C20", Offset = "0x761820", VA = "0x180762C20")]
		private bool <>xLuaBaseProxy_OnEntityOverlapLikeOperationSucceed(SharedConsts.Direction P0, Tile P1, Deck.SpawnDetailsTracker P2)
		{
			return default(bool);
		}

		// Token: 0x04011A62 RID: 72290
		[Token(Token = "0x4011A62")]
		[FieldOffset(Offset = "0x500")]
		[SerializeField]
		private SideType _sideType;

		// Token: 0x04011A63 RID: 72291
		[Token(Token = "0x4011A63")]
		[FieldOffset(Offset = "0x504")]
		[SerializeField]
		protected EntityCategory _category;

		// Token: 0x04011A64 RID: 72292
		[Token(Token = "0x4011A64")]
		[FieldOffset(Offset = "0x508")]
		[SerializeField]
		private Deck.Card.CardPolicy _cardPolicy;

		// Token: 0x04011A65 RID: 72293
		[Token(Token = "0x4011A65")]
		[FieldOffset(Offset = "0x50C")]
		[SerializeField]
		private bool _alwaysShowHp;

		// Token: 0x04011A66 RID: 72294
		[Token(Token = "0x4011A66")]
		[FieldOffset(Offset = "0x50D")]
		[SerializeField]
		private bool _alwaysHideHp;

		// Token: 0x04011A67 RID: 72295
		[Token(Token = "0x4011A67")]
		[FieldOffset(Offset = "0x50E")]
		[SerializeField]
		private bool _alwaysHideSp;

		// Token: 0x04011A68 RID: 72296
		[Token(Token = "0x4011A68")]
		[FieldOffset(Offset = "0x50F")]
		[SerializeField]
		private bool _forceUseAllyHud;

		// Token: 0x04011A69 RID: 72297
		[Token(Token = "0x4011A69")]
		[FieldOffset(Offset = "0x510")]
		[SerializeField]
		protected bool _rewriteTileOptions;

		// Token: 0x04011A6A RID: 72298
		[Token(Token = "0x4011A6A")]
		[FieldOffset(Offset = "0x511")]
		[SerializeField]
		private bool _rewriteTileHeightTypeOnMode;

		// Token: 0x04011A6B RID: 72299
		[Token(Token = "0x4011A6B")]
		[FieldOffset(Offset = "0x512")]
		[SerializeField]
		private bool _rewriteTileHeightTypeOnModeBySelf;

		// Token: 0x04011A6C RID: 72300
		[Token(Token = "0x4011A6C")]
		[FieldOffset(Offset = "0x513")]
		[SerializeField]
		private bool _ignoreBlockAnyRoutes;

		// Token: 0x04011A6D RID: 72301
		[Token(Token = "0x4011A6D")]
		[FieldOffset(Offset = "0x514")]
		[SerializeField]
		private bool _setTileGraphicDirtyWhenSwitchMode;

		// Token: 0x04011A6E RID: 72302
		[Token(Token = "0x4011A6E")]
		[FieldOffset(Offset = "0x515")]
		[SerializeField]
		private bool _hideTileOptions;

		// Token: 0x04011A6F RID: 72303
		[Token(Token = "0x4011A6F")]
		[FieldOffset(Offset = "0x516")]
		[SerializeField]
		private bool _isInfinity;

		// Token: 0x04011A70 RID: 72304
		[Token(Token = "0x4011A70")]
		[FieldOffset(Offset = "0x517")]
		[SerializeField]
		private bool _ignoreExcludeFromBattle;

		// Token: 0x04011A71 RID: 72305
		[Token(Token = "0x4011A71")]
		[FieldOffset(Offset = "0x518")]
		[SerializeField]
		private bool _notShowInDeck;

		// Token: 0x04011A72 RID: 72306
		[Token(Token = "0x4011A72")]
		[FieldOffset(Offset = "0x519")]
		[SerializeField]
		private bool _asRewardCardInLegionMode;

		// Token: 0x04011A73 RID: 72307
		[Token(Token = "0x4011A73")]
		[FieldOffset(Offset = "0x51A")]
		[SerializeField]
		private bool _rechargeOnlyOnce;

		// Token: 0x04011A74 RID: 72308
		[Token(Token = "0x4011A74")]
		[FieldOffset(Offset = "0x520")]
		[SerializeField]
		private Ability _willBuildOverlapBuffSource;

		// Token: 0x04011A75 RID: 72309
		[Token(Token = "0x4011A75")]
		[FieldOffset(Offset = "0x528")]
		[SerializeField]
		private bool _tokenCanBeOverlapDontAddTileBuff;

		// Token: 0x04011A76 RID: 72310
		[Token(Token = "0x4011A76")]
		[FieldOffset(Offset = "0x52C")]
		protected EntityCategory m_category;

		// Token: 0x04011A77 RID: 72311
		[Token(Token = "0x4011A77")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEnemySideToken;

		// Token: 0x04011A78 RID: 72312
		[Token(Token = "0x4011A78")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hideTileOption;

		// Token: 0x04011A79 RID: 72313
		[Token(Token = "0x4011A79")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_initSideType;

		// Token: 0x04011A7A RID: 72314
		[Token(Token = "0x4011A7A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_category;

		// Token: 0x04011A7B RID: 72315
		[Token(Token = "0x4011A7B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_cardPolicy;

		// Token: 0x04011A7C RID: 72316
		[Token(Token = "0x4011A7C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isUnique;

		// Token: 0x04011A7D RID: 72317
		[Token(Token = "0x4011A7D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_showHpSlider;

		// Token: 0x04011A7E RID: 72318
		[Token(Token = "0x4011A7E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_showSpSlider;

		// Token: 0x04011A7F RID: 72319
		[Token(Token = "0x4011A7F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_rechargeOnlyOnce;

		// Token: 0x04011A80 RID: 72320
		[Token(Token = "0x4011A80")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_isInfinity;

		// Token: 0x04011A81 RID: 72321
		[Token(Token = "0x4011A81")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_ignoreExcludeFromBattle;

		// Token: 0x04011A82 RID: 72322
		[Token(Token = "0x4011A82")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_notShowInDeck;

		// Token: 0x04011A83 RID: 72323
		[Token(Token = "0x4011A83")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_asRewardCardInLegionMode;

		// Token: 0x04011A84 RID: 72324
		[Token(Token = "0x4011A84")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_alwaysShowHp;

		// Token: 0x04011A85 RID: 72325
		[Token(Token = "0x4011A85")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_alwaysHideHp;

		// Token: 0x04011A86 RID: 72326
		[Token(Token = "0x4011A86")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_alwaysHideSp;

		// Token: 0x04011A87 RID: 72327
		[Token(Token = "0x4011A87")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_forceUseAllyHud;

		// Token: 0x04011A88 RID: 72328
		[Token(Token = "0x4011A88")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_allowWithdrawGainCost;

		// Token: 0x04011A89 RID: 72329
		[Token(Token = "0x4011A89")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_rewriteTileOptions;

		// Token: 0x04011A8A RID: 72330
		[Token(Token = "0x4011A8A")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_ignoreBlockAnyRoutes;

		// Token: 0x04011A8B RID: 72331
		[Token(Token = "0x4011A8B")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_tokenCanBeOverlapDontAddTileBuff;

		// Token: 0x04011A8C RID: 72332
		[Token(Token = "0x4011A8C")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_tileOptions;

		// Token: 0x04011A8D RID: 72333
		[Token(Token = "0x4011A8D")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_keepCurrentPassableMask;

		// Token: 0x04011A8E RID: 72334
		[Token(Token = "0x4011A8E")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_keepCurrentBuildableType;

		// Token: 0x04011A8F RID: 72335
		[Token(Token = "0x4011A8F")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_rewriteTileHeightType;

		// Token: 0x04011A90 RID: 72336
		[Token(Token = "0x4011A90")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_rewriteTileHeight;

		// Token: 0x04011A91 RID: 72337
		[Token(Token = "0x4011A91")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_rewriteHeight;

		// Token: 0x04011A92 RID: 72338
		[Token(Token = "0x4011A92")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_rewriteTileAdvancedBuildMask;

		// Token: 0x04011A93 RID: 72339
		[Token(Token = "0x4011A93")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04011A94 RID: 72340
		[Token(Token = "0x4011A94")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x04011A95 RID: 72341
		[Token(Token = "0x4011A95")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnSwitchMode;

		// Token: 0x04011A96 RID: 72342
		[Token(Token = "0x4011A96")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_GetTileLocateHeight;

		// Token: 0x04011A97 RID: 72343
		[Token(Token = "0x4011A97")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__NeedReduceSelfLocatedHeight;

		// Token: 0x04011A98 RID: 72344
		[Token(Token = "0x4011A98")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnEntityOverlapLikeOperationSucceed;

		// Token: 0x04011A99 RID: 72345
		[Token(Token = "0x4011A99")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_SwitchCategory;

		// Token: 0x04011A9A RID: 72346
		[Token(Token = "0x4011A9A")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
