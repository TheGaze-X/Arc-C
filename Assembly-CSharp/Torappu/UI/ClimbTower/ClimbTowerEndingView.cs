using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D27 RID: 23847
	[Token(Token = "0x2005D27")]
	public class ClimbTowerEndingView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005140 RID: 20800
		// (get) Token: 0x06022875 RID: 141429 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06022876 RID: 141430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005140")]
		public ClimbTowerEndingState state
		{
			[Token(Token = "0x6022875")]
			[Address(RVA = "0x1D03350", Offset = "0x1D01F50", VA = "0x181D03350")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6022876")]
			[Address(RVA = "0x1D03580", Offset = "0x1D02180", VA = "0x181D03580")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005141 RID: 20801
		// (get) Token: 0x06022877 RID: 141431 RVA: 0x000BDC48 File Offset: 0x000BBE48
		// (set) Token: 0x06022878 RID: 141432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005141")]
		public bool hasPlayedAnim
		{
			[Token(Token = "0x6022877")]
			[Address(RVA = "0x1D03290", Offset = "0x1D01E90", VA = "0x181D03290")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6022878")]
			[Address(RVA = "0x1D03490", Offset = "0x1D02090", VA = "0x181D03490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005142 RID: 20802
		// (get) Token: 0x06022879 RID: 141433 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602287A RID: 141434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005142")]
		public FadeSwitchTween blackMaskSwitch
		{
			[Token(Token = "0x6022879")]
			[Address(RVA = "0x1D03230", Offset = "0x1D01E30", VA = "0x181D03230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602287A")]
			[Address(RVA = "0x1D03410", Offset = "0x1D02010", VA = "0x181D03410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005143 RID: 20803
		// (get) Token: 0x0602287B RID: 141435 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602287C RID: 141436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005143")]
		public FadeSwitchTween uiPanelSwitchTween
		{
			[Token(Token = "0x602287B")]
			[Address(RVA = "0x1D033B0", Offset = "0x1D01FB0", VA = "0x181D033B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x602287C")]
			[Address(RVA = "0x1D03600", Offset = "0x1D02200", VA = "0x181D03600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005144 RID: 20804
		// (get) Token: 0x0602287D RID: 141437 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602287E RID: 141438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005144")]
		public UIPage page
		{
			[Token(Token = "0x602287D")]
			[Address(RVA = "0x1D032F0", Offset = "0x1D01EF0", VA = "0x181D032F0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602287E")]
			[Address(RVA = "0x1D03500", Offset = "0x1D02100", VA = "0x181D03500")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602287F RID: 141439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602287F")]
		[Address(RVA = "0x1D02AD0", Offset = "0x1D016D0", VA = "0x181D02AD0")]
		public void ShowBlackMask()
		{
		}

		// Token: 0x06022880 RID: 141440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022880")]
		[Address(RVA = "0x1D02210", Offset = "0x1D00E10", VA = "0x181D02210")]
		public void Render(ClimbTowerEndingViewModel viewModel, int rowCount)
		{
		}

		// Token: 0x06022881 RID: 141441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022881")]
		[Address(RVA = "0x1D02BF0", Offset = "0x1D017F0", VA = "0x181D02BF0")]
		public IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06022882 RID: 141442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022882")]
		[Address(RVA = "0x1D02160", Offset = "0x1D00D60", VA = "0x181D02160")]
		public IEnumerator BeforeShowTopState()
		{
			return null;
		}

		// Token: 0x06022883 RID: 141443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022883")]
		[Address(RVA = "0x1D03120", Offset = "0x1D01D20", VA = "0x181D03120")]
		private IEnumerator _PlayCharacterPopUpSound(int rowCount)
		{
			return null;
		}

		// Token: 0x06022884 RID: 141444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022884")]
		[Address(RVA = "0x1D02CA0", Offset = "0x1D018A0", VA = "0x181D02CA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022885 RID: 141445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022885")]
		[Address(RVA = "0x1D031D0", Offset = "0x1D01DD0", VA = "0x181D031D0")]
		public ClimbTowerEndingView()
		{
		}

		// Token: 0x0402F75F RID: 194399
		[Token(Token = "0x402F75F")]
		private const string FLOOR_TARGET_FORMAT = "/{0}";

		// Token: 0x0402F760 RID: 194400
		[Token(Token = "0x402F760")]
		private const string CHAR_CARD_ANIM_NAME = "climb_tower_ending";

		// Token: 0x0402F761 RID: 194401
		[Token(Token = "0x402F761")]
		public const int CHAR_CARD_NUM_PER_ROW = 9;

		// Token: 0x0402F762 RID: 194402
		[Token(Token = "0x402F762")]
		private const string ITEM_GAIN_COUNT_FORMAT = "+{0}";

		// Token: 0x0402F763 RID: 194403
		[Token(Token = "0x402F763")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Tower info")]
		private Text _textTowerName;

		// Token: 0x0402F764 RID: 194404
		[Token(Token = "0x402F764")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Tower info")]
		private Text _textTowerSubName;

		// Token: 0x0402F765 RID: 194405
		[Token(Token = "0x402F765")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Tower info")]
		private Text _textFinishTime;

		// Token: 0x0402F766 RID: 194406
		[Token(Token = "0x402F766")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Tower info")]
		private TwoStateToggle _finishToggle;

		// Token: 0x0402F767 RID: 194407
		[Token(Token = "0x402F767")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Tower info")]
		private Image _imgTowerIcon;

		// Token: 0x0402F768 RID: 194408
		[Token(Token = "0x402F768")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Tower info")]
		private Text _textFloorCurr;

		// Token: 0x0402F769 RID: 194409
		[Token(Token = "0x402F769")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Tower info")]
		private Text _textFloorTarget;

		// Token: 0x0402F76A RID: 194410
		[Token(Token = "0x402F76A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Tower info")]
		private GameObject _imgHard;

		// Token: 0x0402F76B RID: 194411
		[Token(Token = "0x402F76B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Tower info")]
		private Color _colorHard;

		// Token: 0x0402F76C RID: 194412
		[Token(Token = "0x402F76C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Tower info")]
		private Color _colorNormal;

		// Token: 0x0402F76D RID: 194413
		[Token(Token = "0x402F76D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Tower info")]
		private Color _colorTowerIconHard;

		// Token: 0x0402F76E RID: 194414
		[Token(Token = "0x402F76E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Tower info")]
		private Color _colorTowerIconNormal;

		// Token: 0x0402F76F RID: 194415
		[Token(Token = "0x402F76F")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("GodCard")]
		private GameObject _panelGodCard;

		// Token: 0x0402F770 RID: 194416
		[Token(Token = "0x402F770")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("GodCard")]
		private Image _imgMainCard;

		// Token: 0x0402F771 RID: 194417
		[Token(Token = "0x402F771")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("GodCard")]
		private GameObject[] _panelSubCardBranches;

		// Token: 0x0402F772 RID: 194418
		[Token(Token = "0x402F772")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("GodCard")]
		private Image[] _imgSubcards;

		// Token: 0x0402F773 RID: 194419
		[Token(Token = "0x402F773")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private RectTransform[] _characterCardTrans;

		// Token: 0x0402F774 RID: 194420
		[Token(Token = "0x402F774")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private RectTransform[] _curseCardAndTrapCardTrans;

		// Token: 0x0402F775 RID: 194421
		[Token(Token = "0x402F775")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _prefabCharCard;

		// Token: 0x0402F776 RID: 194422
		[Token(Token = "0x402F776")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private GameObject _prefabCurseCardAndTrapCard;

		// Token: 0x0402F777 RID: 194423
		[Token(Token = "0x402F777")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0402F778 RID: 194424
		[Token(Token = "0x402F778")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private CanvasGroup _blackMask;

		// Token: 0x0402F779 RID: 194425
		[Token(Token = "0x402F779")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private CanvasGroup _panelUI;

		// Token: 0x0402F77A RID: 194426
		[Token(Token = "0x402F77A")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_isLowerItemMax;

		// Token: 0x0402F77B RID: 194427
		[Token(Token = "0x402F77B")]
		[FieldOffset(Offset = "0xF1")]
		private bool m_isHigherItemMax;

		// Token: 0x0402F77C RID: 194428
		[Token(Token = "0x402F77C")]
		[FieldOffset(Offset = "0xF2")]
		private bool m_hasInited;

		// Token: 0x0402F77D RID: 194429
		[Token(Token = "0x402F77D")]
		[FieldOffset(Offset = "0xF4")]
		private int m_cachedCharCardRowCount;

		// Token: 0x0402F77E RID: 194430
		[Token(Token = "0x402F77E")]
		[FieldOffset(Offset = "0xF8")]
		private ClimbTowerEndingCharacterCardView[] m_characterCard;

		// Token: 0x0402F77F RID: 194431
		[Token(Token = "0x402F77F")]
		[FieldOffset(Offset = "0x100")]
		private ClimbTowerEndingTrapCardView[] m_curseCardAndTrapCard;

		// Token: 0x0402F785 RID: 194437
		[Token(Token = "0x402F785")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0402F786 RID: 194438
		[Token(Token = "0x402F786")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x0402F787 RID: 194439
		[Token(Token = "0x402F787")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_hasPlayedAnim;

		// Token: 0x0402F788 RID: 194440
		[Token(Token = "0x402F788")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_hasPlayedAnim;

		// Token: 0x0402F789 RID: 194441
		[Token(Token = "0x402F789")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_blackMaskSwitch;

		// Token: 0x0402F78A RID: 194442
		[Token(Token = "0x402F78A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_blackMaskSwitch;

		// Token: 0x0402F78B RID: 194443
		[Token(Token = "0x402F78B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_uiPanelSwitchTween;

		// Token: 0x0402F78C RID: 194444
		[Token(Token = "0x402F78C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_uiPanelSwitchTween;

		// Token: 0x0402F78D RID: 194445
		[Token(Token = "0x402F78D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402F78E RID: 194446
		[Token(Token = "0x402F78E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402F78F RID: 194447
		[Token(Token = "0x402F78F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ShowBlackMask;

		// Token: 0x0402F790 RID: 194448
		[Token(Token = "0x402F790")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F791 RID: 194449
		[Token(Token = "0x402F791")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0402F792 RID: 194450
		[Token(Token = "0x402F792")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_BeforeShowTopState;

		// Token: 0x0402F793 RID: 194451
		[Token(Token = "0x402F793")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__PlayCharacterPopUpSound;

		// Token: 0x0402F794 RID: 194452
		[Token(Token = "0x402F794")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402F795 RID: 194453
		[Token(Token = "0x402F795")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
