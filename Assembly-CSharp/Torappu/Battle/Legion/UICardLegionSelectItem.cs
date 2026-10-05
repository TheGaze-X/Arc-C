using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.Legion
{
	// Token: 0x02002A1E RID: 10782
	[Token(Token = "0x2002A1E")]
	public class UICardLegionSelectItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06011E48 RID: 73288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E48")]
		[Address(RVA = "0x9D29B0", Offset = "0x9D15B0", VA = "0x1809D29B0")]
		public void ApplyData(UICardLegionSelectItem.CardModel itemModel)
		{
		}

		// Token: 0x06011E49 RID: 73289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E49")]
		[Address(RVA = "0x9D3880", Offset = "0x9D2480", VA = "0x1809D3880")]
		public void OnCardClick()
		{
		}

		// Token: 0x06011E4A RID: 73290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E4A")]
		[Address(RVA = "0x9D3910", Offset = "0x9D2510", VA = "0x1809D3910")]
		public void OnDetailClick()
		{
		}

		// Token: 0x06011E4B RID: 73291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E4B")]
		[Address(RVA = "0x9D3B30", Offset = "0x9D2730", VA = "0x1809D3B30")]
		private void _InitOrNot()
		{
		}

		// Token: 0x06011E4C RID: 73292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E4C")]
		[Address(RVA = "0x9D3DD0", Offset = "0x9D29D0", VA = "0x1809D3DD0")]
		private void _SetProfession(ProfessionCategory profession)
		{
		}

		// Token: 0x06011E4D RID: 73293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E4D")]
		[Address(RVA = "0x9D3F10", Offset = "0x9D2B10", VA = "0x1809D3F10")]
		private void _SetRarity(RarityRank rarity)
		{
		}

		// Token: 0x06011E4E RID: 73294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E4E")]
		[Address(RVA = "0x9D3C90", Offset = "0x9D2890", VA = "0x1809D3C90")]
		private void _SetElite(EvolvePhase elity)
		{
		}

		// Token: 0x06011E4F RID: 73295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011E4F")]
		[Address(RVA = "0x9D40B0", Offset = "0x9D2CB0", VA = "0x1809D40B0")]
		public UICardLegionSelectItem()
		{
		}

		// Token: 0x0401423D RID: 82493
		[Token(Token = "0x401423D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0401423E RID: 82494
		[Token(Token = "0x401423E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _transDownPart;

		// Token: 0x0401423F RID: 82495
		[Token(Token = "0x401423F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("DownPart")]
		private GameObject _objDownCharPart;

		// Token: 0x04014240 RID: 82496
		[Token(Token = "0x4014240")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("DownPart")]
		private UIAtlasImage _imgPortrait;

		// Token: 0x04014241 RID: 82497
		[Token(Token = "0x4014241")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("DownPart")]
		private GameObject _imgDiscardDec;

		// Token: 0x04014242 RID: 82498
		[Token(Token = "0x4014242")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("DownPart")]
		private GameObject _objDownTrapPart;

		// Token: 0x04014243 RID: 82499
		[Token(Token = "0x4014243")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("DownPart")]
		private Image _imgTrap;

		// Token: 0x04014244 RID: 82500
		[Token(Token = "0x4014244")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("SelectPart")]
		private CanvasGroup _canvasSelect;

		// Token: 0x04014245 RID: 82501
		[Token(Token = "0x4014245")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("SelectPart")]
		private GameObject _objSelectNum;

		// Token: 0x04014246 RID: 82502
		[Token(Token = "0x4014246")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("SelectPart")]
		private Text _txtSelectNum;

		// Token: 0x04014247 RID: 82503
		[Token(Token = "0x4014247")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("SelectPart")]
		private GameObject _objSelectDec;

		// Token: 0x04014248 RID: 82504
		[Token(Token = "0x4014248")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("SelectPart")]
		private GameObject _objDiscardDec;

		// Token: 0x04014249 RID: 82505
		[Token(Token = "0x4014249")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("SelectPart")]
		private GameObject _objPurpleDec;

		// Token: 0x0401424A RID: 82506
		[Token(Token = "0x401424A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("SelectPart")]
		private CanvasGroup _canvasSelectTips;

		// Token: 0x0401424B RID: 82507
		[Token(Token = "0x401424B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("SelectPart")]
		private Text _txtSelectBeyondTips;

		// Token: 0x0401424C RID: 82508
		[Token(Token = "0x401424C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("SelectPart")]
		private GameObject _objSelectPendingDec;

		// Token: 0x0401424D RID: 82509
		[Token(Token = "0x401424D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("SelectPart")]
		private GameObject _objSelectUsedDec;

		// Token: 0x0401424E RID: 82510
		[Token(Token = "0x401424E")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("InfoPart")]
		private RectTransform _transInfoPart;

		// Token: 0x0401424F RID: 82511
		[Token(Token = "0x401424F")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("InfoPart")]
		private GameObject _objCharInfoPart;

		// Token: 0x04014250 RID: 82512
		[Token(Token = "0x4014250")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("InfoPart")]
		private UIAtlasImage _imgRarity;

		// Token: 0x04014251 RID: 82513
		[Token(Token = "0x4014251")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("InfoPart")]
		private UIAtlasImage _imgElite;

		// Token: 0x04014252 RID: 82514
		[Token(Token = "0x4014252")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("InfoPart")]
		private UIAtlasImage _imgProfession;

		// Token: 0x04014253 RID: 82515
		[Token(Token = "0x4014253")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("InfoPart")]
		private Text _txtCharName;

		// Token: 0x04014254 RID: 82516
		[Token(Token = "0x4014254")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("InfoPart")]
		private GameObject _objTrapInfoPart;

		// Token: 0x04014255 RID: 82517
		[Token(Token = "0x4014255")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("InfoPart")]
		private Text _txtTrapName;

		// Token: 0x04014256 RID: 82518
		[Token(Token = "0x4014256")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private RectTransform _transClickArea;

		// Token: 0x04014257 RID: 82519
		[Token(Token = "0x4014257")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		public RectTransform rectTweenRoot;

		// Token: 0x04014258 RID: 82520
		[Token(Token = "0x4014258")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		public CanvasGroup canvasTweenRoot;

		// Token: 0x04014259 RID: 82521
		[Token(Token = "0x4014259")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Group("Config")]
		[FormerlySerializedAs("_professionSprites")]
		private UICardLegionSelectItem.ProfessionSpritePair[] _professionIcons;

		// Token: 0x0401425A RID: 82522
		[Token(Token = "0x401425A")]
		[FieldOffset(Offset = "0x100")]
		[NonSerialized]
		public Action<uint> onCardClickEvent;

		// Token: 0x0401425B RID: 82523
		[Token(Token = "0x401425B")]
		[FieldOffset(Offset = "0x108")]
		[NonSerialized]
		public Action<string, float> onShowTrapDetail;

		// Token: 0x0401425C RID: 82524
		[Token(Token = "0x401425C")]
		[FieldOffset(Offset = "0x110")]
		private UICardLegionSelectItem.CardModel m_itemModel;

		// Token: 0x0401425D RID: 82525
		[Token(Token = "0x401425D")]
		[FieldOffset(Offset = "0x118")]
		private uint m_cacheCardId;

		// Token: 0x0401425E RID: 82526
		[Token(Token = "0x401425E")]
		[FieldOffset(Offset = "0x11C")]
		private bool m_isChar;

		// Token: 0x0401425F RID: 82527
		[Token(Token = "0x401425F")]
		[FieldOffset(Offset = "0x120")]
		private UICardLegionSelectItem.CardSelectPopTween m_selectTween;

		// Token: 0x04014260 RID: 82528
		[Token(Token = "0x4014260")]
		[FieldOffset(Offset = "0x128")]
		private bool m_isInited;

		// Token: 0x04014261 RID: 82529
		[Token(Token = "0x4014261")]
		[FieldOffset(Offset = "0x129")]
		private bool m_isApplied;

		// Token: 0x04014262 RID: 82530
		[Token(Token = "0x4014262")]
		private const string SELECT_NUM_PREFIX = "0{0}";

		// Token: 0x04014263 RID: 82531
		[Token(Token = "0x4014263")]
		private const string ELITY_SPRITE_PREFIX = "elite_{0}";

		// Token: 0x04014264 RID: 82532
		[Token(Token = "0x4014264")]
		private const string RARITY_SPRITE_PREFIX = "rarity_{0}";

		// Token: 0x04014265 RID: 82533
		[Token(Token = "0x4014265")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 SELECT_CARD_CLICK_AREA_SIZE;

		// Token: 0x04014266 RID: 82534
		[Token(Token = "0x4014266")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 UNSELECT_CARD_CLICK_AREA_SIZE;

		// Token: 0x04014267 RID: 82535
		[Token(Token = "0x4014267")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04014268 RID: 82536
		[Token(Token = "0x4014268")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCardClick;

		// Token: 0x04014269 RID: 82537
		[Token(Token = "0x4014269")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetailClick;

		// Token: 0x0401426A RID: 82538
		[Token(Token = "0x401426A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitOrNot;

		// Token: 0x0401426B RID: 82539
		[Token(Token = "0x401426B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetProfession;

		// Token: 0x0401426C RID: 82540
		[Token(Token = "0x401426C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetRarity;

		// Token: 0x0401426D RID: 82541
		[Token(Token = "0x401426D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetElite;

		// Token: 0x0401426E RID: 82542
		[Token(Token = "0x401426E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002A1F RID: 10783
		[Token(Token = "0x2002A1F")]
		public class CardModel : IHotfixable
		{
			// Token: 0x17002761 RID: 10081
			// (get) Token: 0x06011E51 RID: 73297 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06011E52 RID: 73298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002761")]
			public Deck.Card card
			{
				[Token(Token = "0x6011E51")]
				[Address(RVA = "0x9C2010", Offset = "0x9C0C10", VA = "0x1809C2010")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6011E52")]
				[Address(RVA = "0x9C2350", Offset = "0x9C0F50", VA = "0x1809C2350")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17002762 RID: 10082
			// (get) Token: 0x06011E53 RID: 73299 RVA: 0x0006D7A0 File Offset: 0x0006B9A0
			// (set) Token: 0x06011E54 RID: 73300 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002762")]
			public LegionCardLibraryType cardFromType
			{
				[Token(Token = "0x6011E53")]
				[Address(RVA = "0x9C1EF0", Offset = "0x9C0AF0", VA = "0x1809C1EF0")]
				[CompilerGenerated]
				get
				{
					return LegionCardLibraryType.NULL;
				}
				[Token(Token = "0x6011E54")]
				[Address(RVA = "0x9C21F0", Offset = "0x9C0DF0", VA = "0x1809C21F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17002763 RID: 10083
			// (get) Token: 0x06011E55 RID: 73301 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06011E56 RID: 73302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002763")]
			public UICardLegionSelectItem.CardModel.SelectInfoData selectInfo
			{
				[Token(Token = "0x6011E55")]
				[Address(RVA = "0x9C2190", Offset = "0x9C0D90", VA = "0x1809C2190")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6011E56")]
				[Address(RVA = "0x9C2520", Offset = "0x9C1120", VA = "0x1809C2520")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17002764 RID: 10084
			// (get) Token: 0x06011E57 RID: 73303 RVA: 0x0006D7B8 File Offset: 0x0006B9B8
			// (set) Token: 0x06011E58 RID: 73304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002764")]
			public int inHandCardCount
			{
				[Token(Token = "0x6011E57")]
				[Address(RVA = "0x9C2070", Offset = "0x9C0C70", VA = "0x1809C2070")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6011E58")]
				[Address(RVA = "0x9C23D0", Offset = "0x9C0FD0", VA = "0x1809C23D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17002765 RID: 10085
			// (get) Token: 0x06011E59 RID: 73305 RVA: 0x0006D7D0 File Offset: 0x0006B9D0
			// (set) Token: 0x06011E5A RID: 73306 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002765")]
			public int maxCardCount
			{
				[Token(Token = "0x6011E59")]
				[Address(RVA = "0x9C2130", Offset = "0x9C0D30", VA = "0x1809C2130")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6011E5A")]
				[Address(RVA = "0x9C24B0", Offset = "0x9C10B0", VA = "0x1809C24B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17002766 RID: 10086
			// (get) Token: 0x06011E5B RID: 73307 RVA: 0x0006D7E8 File Offset: 0x0006B9E8
			// (set) Token: 0x06011E5C RID: 73308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002766")]
			public bool isChar
			{
				[Token(Token = "0x6011E5B")]
				[Address(RVA = "0x9C20D0", Offset = "0x9C0CD0", VA = "0x1809C20D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6011E5C")]
				[Address(RVA = "0x9C2440", Offset = "0x9C1040", VA = "0x1809C2440")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17002767 RID: 10087
			// (get) Token: 0x06011E5D RID: 73309 RVA: 0x0006D800 File Offset: 0x0006BA00
			// (set) Token: 0x06011E5E RID: 73310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002767")]
			public uint cardId
			{
				[Token(Token = "0x6011E5D")]
				[Address(RVA = "0x9C1F50", Offset = "0x9C0B50", VA = "0x1809C1F50")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
				[Token(Token = "0x6011E5E")]
				[Address(RVA = "0x9C2260", Offset = "0x9C0E60", VA = "0x1809C2260")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17002768 RID: 10088
			// (get) Token: 0x06011E5F RID: 73311 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06011E60 RID: 73312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17002768")]
			public string cardName
			{
				[Token(Token = "0x6011E5F")]
				[Address(RVA = "0x9C1FB0", Offset = "0x9C0BB0", VA = "0x1809C1FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6011E60")]
				[Address(RVA = "0x9C22D0", Offset = "0x9C0ED0", VA = "0x1809C22D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06011E61 RID: 73313 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011E61")]
			[Address(RVA = "0x9C1620", Offset = "0x9C0220", VA = "0x1809C1620")]
			public void InitData(Deck.Card cardInput, UICardLegionSelectItem.CardModel.SelectInfoData selectInfoData, LegionCardLibraryType from, int inHandCardNum, int maxCardNum)
			{
			}

			// Token: 0x06011E62 RID: 73314 RVA: 0x0006D818 File Offset: 0x0006BA18
			[Token(Token = "0x6011E62")]
			[Address(RVA = "0x9C19C0", Offset = "0x9C05C0", VA = "0x1809C19C0")]
			public bool IsCurSelectBeyondLimit(int selectIndex)
			{
				return default(bool);
			}

			// Token: 0x06011E63 RID: 73315 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011E63")]
			[Address(RVA = "0x9C1BF0", Offset = "0x9C07F0", VA = "0x1809C1BF0")]
			public void UpdateSelectState(bool select, int index = -1)
			{
			}

			// Token: 0x06011E64 RID: 73316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011E64")]
			[Address(RVA = "0x9C1AE0", Offset = "0x9C06E0", VA = "0x1809C1AE0")]
			public void UpdateSelectIndex(int index)
			{
			}

			// Token: 0x06011E65 RID: 73317 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011E65")]
			[Address(RVA = "0x9C1D80", Offset = "0x9C0980", VA = "0x1809C1D80")]
			public void UpdateSelectingCount(int selectingCount)
			{
			}

			// Token: 0x06011E66 RID: 73318 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011E66")]
			[Address(RVA = "0x9C1E90", Offset = "0x9C0A90", VA = "0x1809C1E90")]
			public CardModel()
			{
			}

			// Token: 0x04014277 RID: 82551
			[Token(Token = "0x4014277")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_card;

			// Token: 0x04014278 RID: 82552
			[Token(Token = "0x4014278")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_card;

			// Token: 0x04014279 RID: 82553
			[Token(Token = "0x4014279")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_cardFromType;

			// Token: 0x0401427A RID: 82554
			[Token(Token = "0x401427A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_cardFromType;

			// Token: 0x0401427B RID: 82555
			[Token(Token = "0x401427B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_selectInfo;

			// Token: 0x0401427C RID: 82556
			[Token(Token = "0x401427C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_set_selectInfo;

			// Token: 0x0401427D RID: 82557
			[Token(Token = "0x401427D")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_get_inHandCardCount;

			// Token: 0x0401427E RID: 82558
			[Token(Token = "0x401427E")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_set_inHandCardCount;

			// Token: 0x0401427F RID: 82559
			[Token(Token = "0x401427F")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_get_maxCardCount;

			// Token: 0x04014280 RID: 82560
			[Token(Token = "0x4014280")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0_set_maxCardCount;

			// Token: 0x04014281 RID: 82561
			[Token(Token = "0x4014281")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0_get_isChar;

			// Token: 0x04014282 RID: 82562
			[Token(Token = "0x4014282")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0_set_isChar;

			// Token: 0x04014283 RID: 82563
			[Token(Token = "0x4014283")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_get_cardId;

			// Token: 0x04014284 RID: 82564
			[Token(Token = "0x4014284")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0_set_cardId;

			// Token: 0x04014285 RID: 82565
			[Token(Token = "0x4014285")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_get_cardName;

			// Token: 0x04014286 RID: 82566
			[Token(Token = "0x4014286")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_set_cardName;

			// Token: 0x04014287 RID: 82567
			[Token(Token = "0x4014287")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_InitData;

			// Token: 0x04014288 RID: 82568
			[Token(Token = "0x4014288")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_IsCurSelectBeyondLimit;

			// Token: 0x04014289 RID: 82569
			[Token(Token = "0x4014289")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_UpdateSelectState;

			// Token: 0x0401428A RID: 82570
			[Token(Token = "0x401428A")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_UpdateSelectIndex;

			// Token: 0x0401428B RID: 82571
			[Token(Token = "0x401428B")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_UpdateSelectingCount;

			// Token: 0x0401428C RID: 82572
			[Token(Token = "0x401428C")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x02002A20 RID: 10784
			[Token(Token = "0x2002A20")]
			public class SelectInfoData
			{
				// Token: 0x06011E67 RID: 73319 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6011E67")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SelectInfoData()
				{
				}

				// Token: 0x0401428D RID: 82573
				[Token(Token = "0x401428D")]
				[FieldOffset(Offset = "0x10")]
				public bool isSelecting;

				// Token: 0x0401428E RID: 82574
				[Token(Token = "0x401428E")]
				[FieldOffset(Offset = "0x14")]
				public int selectIndex;

				// Token: 0x0401428F RID: 82575
				[Token(Token = "0x401428F")]
				[FieldOffset(Offset = "0x18")]
				public int curSelectingCount;

				// Token: 0x04014290 RID: 82576
				[Token(Token = "0x4014290")]
				[FieldOffset(Offset = "0x1C")]
				public bool isSingleChoose;

				// Token: 0x04014291 RID: 82577
				[Token(Token = "0x4014291")]
				[FieldOffset(Offset = "0x1D")]
				public bool putInPendingIfHandFull;

				// Token: 0x04014292 RID: 82578
				[Token(Token = "0x4014292")]
				[FieldOffset(Offset = "0x20")]
				public LegionSelectCardType selectCardMode;
			}
		}

		// Token: 0x02002A21 RID: 10785
		[Token(Token = "0x2002A21")]
		private class CardSelectPopTween : UISwitchTween
		{
			// Token: 0x06011E68 RID: 73320 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011E68")]
			[Address(RVA = "0x9C2E00", Offset = "0x9C1A00", VA = "0x1809C2E00")]
			public CardSelectPopTween(UICardLegionSelectItem closure)
			{
			}

			// Token: 0x06011E69 RID: 73321 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011E69")]
			[Address(RVA = "0x9C28D0", Offset = "0x9C14D0", VA = "0x1809C28D0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06011E6A RID: 73322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6011E6A")]
			[Address(RVA = "0x9C2640", Offset = "0x9C1240", VA = "0x1809C2640", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06011E6B RID: 73323 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011E6B")]
			[Address(RVA = "0x9C25A0", Offset = "0x9C11A0", VA = "0x1809C25A0", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x06011E6C RID: 73324 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011E6C")]
			[Address(RVA = "0x9C2B60", Offset = "0x9C1760", VA = "0x1809C2B60", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06011E6E RID: 73326 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011E6E")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x06011E6F RID: 73327 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6011E6F")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04014293 RID: 82579
			[Token(Token = "0x4014293")]
			[FieldOffset(Offset = "0x48")]
			private UICardLegionSelectItem m_closure;

			// Token: 0x04014294 RID: 82580
			[Token(Token = "0x4014294")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Vector2 SELECT_CARD_START_POS;

			// Token: 0x04014295 RID: 82581
			[Token(Token = "0x4014295")]
			[FieldOffset(Offset = "0x8")]
			private static readonly Vector2 SELECT_CARD_END_POS;

			// Token: 0x04014296 RID: 82582
			[Token(Token = "0x4014296")]
			private const float SELECT_CARD_DUR = 0.2f;

			// Token: 0x04014297 RID: 82583
			[Token(Token = "0x4014297")]
			private const float SHOW_SELECT_PART_DUR = 0.1f;

			// Token: 0x04014298 RID: 82584
			[Token(Token = "0x4014298")]
			private const float HIDE_SELECT_PART_DUR = 0.1f;

			// Token: 0x04014299 RID: 82585
			[Token(Token = "0x4014299")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401429A RID: 82586
			[Token(Token = "0x401429A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0401429B RID: 82587
			[Token(Token = "0x401429B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0401429C RID: 82588
			[Token(Token = "0x401429C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x0401429D RID: 82589
			[Token(Token = "0x401429D")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02002A22 RID: 10786
		[Token(Token = "0x2002A22")]
		[Serializable]
		private struct ProfessionSpritePair
		{
			// Token: 0x0401429E RID: 82590
			[Token(Token = "0x401429E")]
			[FieldOffset(Offset = "0x0")]
			public ProfessionCategory profession;

			// Token: 0x0401429F RID: 82591
			[Token(Token = "0x401429F")]
			[FieldOffset(Offset = "0x8")]
			public string spriteName;
		}
	}
}
