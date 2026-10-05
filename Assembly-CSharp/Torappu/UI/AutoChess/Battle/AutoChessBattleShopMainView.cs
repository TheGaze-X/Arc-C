using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006500 RID: 25856
	[Token(Token = "0x2006500")]
	public class AutoChessBattleShopMainView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170057B6 RID: 22454
		// (get) Token: 0x06025282 RID: 152194 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025281 RID: 152193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170057B6")]
		public Action<int> onCardConfirm
		{
			[Token(Token = "0x6025282")]
			[Address(RVA = "0x201BB60", Offset = "0x201A760", VA = "0x18201BB60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6025281")]
			[Address(RVA = "0x201BBC0", Offset = "0x201A7C0", VA = "0x18201BBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06025283 RID: 152195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025283")]
		[Address(RVA = "0x201A770", Offset = "0x2019370", VA = "0x18201A770")]
		public void UpdateView(AutoChessBattleUIViewModel uiModel)
		{
		}

		// Token: 0x06025284 RID: 152196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025284")]
		[Address(RVA = "0x201AFE0", Offset = "0x2019BE0", VA = "0x18201AFE0")]
		private void _RaiseAVGSignalIfNeed()
		{
		}

		// Token: 0x06025285 RID: 152197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025285")]
		[Address(RVA = "0x201B0A0", Offset = "0x2019CA0", VA = "0x18201B0A0")]
		private void _RegisterTutorialGOIfNeed()
		{
		}

		// Token: 0x06025286 RID: 152198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025286")]
		[Address(RVA = "0x201B300", Offset = "0x2019F00", VA = "0x18201B300")]
		private void _RenderEnable(AutoChessBattleShopViewModel model)
		{
		}

		// Token: 0x06025287 RID: 152199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025287")]
		[Address(RVA = "0x201B500", Offset = "0x201A100", VA = "0x18201B500")]
		private void _RenderUnfoldView(AutoChessBattleShopViewModel model)
		{
		}

		// Token: 0x06025288 RID: 152200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025288")]
		[Address(RVA = "0x201B260", Offset = "0x2019E60", VA = "0x18201B260")]
		private void _RenderDisable(AutoChessBattleShopViewModel model)
		{
		}

		// Token: 0x06025289 RID: 152201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025289")]
		[Address(RVA = "0x201ACD0", Offset = "0x20198D0", VA = "0x18201ACD0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602528A RID: 152202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602528A")]
		[Address(RVA = "0x201BB00", Offset = "0x201A700", VA = "0x18201BB00")]
		public AutoChessBattleShopMainView()
		{
		}

		// Token: 0x040341A5 RID: 213413
		[Token(Token = "0x40341A5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _refreshAnim;

		// Token: 0x040341A6 RID: 213414
		[Token(Token = "0x40341A6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _refreshSpecAnim;

		// Token: 0x040341A7 RID: 213415
		[Token(Token = "0x40341A7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _enableToggle;

		// Token: 0x040341A8 RID: 213416
		[Token(Token = "0x40341A8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnCloseObj;

		// Token: 0x040341A9 RID: 213417
		[Token(Token = "0x40341A9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _foldAnim;

		// Token: 0x040341AA RID: 213418
		[Token(Token = "0x40341AA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _unfoldAnim;

		// Token: 0x040341AB RID: 213419
		[Token(Token = "0x40341AB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("CHAR_NUM")]
		private UIAnimationLocation _charUpAnim;

		// Token: 0x040341AC RID: 213420
		[Token(Token = "0x40341AC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("CHAR_NUM")]
		private UIAnimationLocation _charDnAnim;

		// Token: 0x040341AD RID: 213421
		[Token(Token = "0x40341AD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("CHAR_NUM")]
		private Text _charRemainNum;

		// Token: 0x040341AE RID: 213422
		[Token(Token = "0x40341AE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _popTips;

		// Token: 0x040341AF RID: 213423
		[Token(Token = "0x40341AF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text[] _shopLevels;

		// Token: 0x040341B0 RID: 213424
		[Token(Token = "0x40341B0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private SimpleLayoutContent _slotList;

		// Token: 0x040341B1 RID: 213425
		[Token(Token = "0x40341B1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Button _btnSwitchFold;

		// Token: 0x040341B2 RID: 213426
		[Token(Token = "0x40341B2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Button _btnRefresh;

		// Token: 0x040341B3 RID: 213427
		[Token(Token = "0x40341B3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Button _btnUpgrade;

		// Token: 0x040341B4 RID: 213428
		[Token(Token = "0x40341B4")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Text _coinNum;

		// Token: 0x040341B5 RID: 213429
		[Token(Token = "0x40341B5")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private AutoChessBattleShopCtrlBtnView _btnView;

		// Token: 0x040341B6 RID: 213430
		[Token(Token = "0x40341B6")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private AutoChessBattleShopUpgradeView _upgradeView;

		// Token: 0x040341B7 RID: 213431
		[Token(Token = "0x40341B7")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _upgradeOutside;

		// Token: 0x040341B8 RID: 213432
		[Token(Token = "0x40341B8")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _selOutside;

		// Token: 0x040341B9 RID: 213433
		[Token(Token = "0x40341B9")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Graphic _foldSpineGraphic;

		// Token: 0x040341BA RID: 213434
		[Token(Token = "0x40341BA")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Color _unavailSpineColor;

		// Token: 0x040341BB RID: 213435
		[Token(Token = "0x40341BB")]
		[FieldOffset(Offset = "0x100")]
		private UIBiAnimClipSwitchTween m_foldSwitch;

		// Token: 0x040341BC RID: 213436
		[Token(Token = "0x40341BC")]
		[FieldOffset(Offset = "0x108")]
		private UIBiAnimClipSwitchTween m_charNumSwitch;

		// Token: 0x040341BD RID: 213437
		[Token(Token = "0x40341BD")]
		[FieldOffset(Offset = "0x110")]
		private AutoChessBattleShopMainView.CardListAdapter m_cardListAdapter;

		// Token: 0x040341BE RID: 213438
		[Token(Token = "0x40341BE")]
		[FieldOffset(Offset = "0x118")]
		private int m_refreshSeq;

		// Token: 0x040341BF RID: 213439
		[Token(Token = "0x40341BF")]
		[FieldOffset(Offset = "0x120")]
		private Tween m_refreshAnim;

		// Token: 0x040341C0 RID: 213440
		[Token(Token = "0x40341C0")]
		[FieldOffset(Offset = "0x128")]
		private SeqNumSource.Checker m_goldChecker;

		// Token: 0x040341C1 RID: 213441
		[Token(Token = "0x40341C1")]
		[FieldOffset(Offset = "0x130")]
		private AutoChessBattleUIViewModel m_cachedModel;

		// Token: 0x040341C3 RID: 213443
		[Token(Token = "0x40341C3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onCardConfirm;

		// Token: 0x040341C4 RID: 213444
		[Token(Token = "0x40341C4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onCardConfirm;

		// Token: 0x040341C5 RID: 213445
		[Token(Token = "0x40341C5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x040341C6 RID: 213446
		[Token(Token = "0x40341C6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RaiseAVGSignalIfNeed;

		// Token: 0x040341C7 RID: 213447
		[Token(Token = "0x40341C7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGOIfNeed;

		// Token: 0x040341C8 RID: 213448
		[Token(Token = "0x40341C8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderEnable;

		// Token: 0x040341C9 RID: 213449
		[Token(Token = "0x40341C9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderUnfoldView;

		// Token: 0x040341CA RID: 213450
		[Token(Token = "0x40341CA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderDisable;

		// Token: 0x040341CB RID: 213451
		[Token(Token = "0x40341CB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040341CC RID: 213452
		[Token(Token = "0x40341CC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006501 RID: 25857
		[Token(Token = "0x2006501")]
		private class CardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170057B7 RID: 22455
			// (get) Token: 0x0602528B RID: 152203 RVA: 0x000C6BE8 File Offset: 0x000C4DE8
			[Token(Token = "0x170057B7")]
			public override int count
			{
				[Token(Token = "0x602528B")]
				[Address(RVA = "0x2025700", Offset = "0x2024300", VA = "0x182025700", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602528C RID: 152204 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602528C")]
			[Address(RVA = "0x20255B0", Offset = "0x20241B0", VA = "0x1820255B0")]
			public IEnumerable<AutoChessBattleShopCardView> TraverseCards()
			{
				return null;
			}

			// Token: 0x0602528D RID: 152205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602528D")]
			[Address(RVA = "0x2025350", Offset = "0x2023F50", VA = "0x182025350", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0602528E RID: 152206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602528E")]
			[Address(RVA = "0x2025660", Offset = "0x2024260", VA = "0x182025660")]
			public CardListAdapter()
			{
			}

			// Token: 0x040341CD RID: 213453
			[Token(Token = "0x40341CD")]
			[FieldOffset(Offset = "0x20")]
			public Action<int> onConfirmClick;

			// Token: 0x040341CE RID: 213454
			[Token(Token = "0x40341CE")]
			[FieldOffset(Offset = "0x28")]
			public IList<AutoChessBattleShopCardViewModel> slotList;

			// Token: 0x040341CF RID: 213455
			[Token(Token = "0x40341CF")]
			[FieldOffset(Offset = "0x30")]
			public AutoChessBattleShopSlot selectSlot;

			// Token: 0x040341D0 RID: 213456
			[Token(Token = "0x40341D0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040341D1 RID: 213457
			[Token(Token = "0x40341D1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_TraverseCards;

			// Token: 0x040341D2 RID: 213458
			[Token(Token = "0x40341D2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040341D3 RID: 213459
			[Token(Token = "0x40341D3")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
