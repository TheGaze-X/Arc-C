using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x0200504D RID: 20557
	[Token(Token = "0x200504D")]
	public class EnemyDuelPrepareSelectModeView : DataBinder<EnemyDuelPrepareSelectModeProperty>
	{
		// Token: 0x17004724 RID: 18212
		// (get) Token: 0x0601E7A5 RID: 124837 RVA: 0x000AE8D0 File Offset: 0x000ACAD0
		[Token(Token = "0x17004724")]
		public int curBannerIdx
		{
			[Token(Token = "0x601E7A5")]
			[Address(RVA = "0x182F3C0", Offset = "0x182DFC0", VA = "0x18182F3C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0601E7A6 RID: 124838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7A6")]
		[Address(RVA = "0x182F170", Offset = "0x182DD70", VA = "0x18182F170")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E7A7 RID: 124839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7A7")]
		[Address(RVA = "0x182E850", Offset = "0x182D450", VA = "0x18182E850", Slot = "7")]
		public override void OnValueChanged(EnemyDuelPrepareSelectModeProperty property)
		{
		}

		// Token: 0x0601E7A8 RID: 124840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7A8")]
		[Address(RVA = "0x182E7B0", Offset = "0x182D3B0", VA = "0x18182E7B0")]
		public void EventOnCreateRoomClick()
		{
		}

		// Token: 0x0601E7A9 RID: 124841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E7A9")]
		[Address(RVA = "0x182F350", Offset = "0x182DF50", VA = "0x18182F350")]
		public EnemyDuelPrepareSelectModeView()
		{
		}

		// Token: 0x04028D0B RID: 167179
		[Token(Token = "0x4028D0B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _modeCardLayout;

		// Token: 0x04028D0C RID: 167180
		[Token(Token = "0x4028D0C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EnemyDuelPrepareBannerView _bannerView;

		// Token: 0x04028D0D RID: 167181
		[Token(Token = "0x4028D0D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private EnemyDuelPrepareModeDetailView _detailView;

		// Token: 0x04028D0E RID: 167182
		[Token(Token = "0x4028D0E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle[] _isRoomToggles;

		// Token: 0x04028D0F RID: 167183
		[Token(Token = "0x4028D0F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _streamerNameText;

		// Token: 0x04028D10 RID: 167184
		[Token(Token = "0x4028D10")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _streamerSubscribeText;

		// Token: 0x04028D11 RID: 167185
		[Token(Token = "0x4028D11")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _streamerAvatarImg;

		// Token: 0x04028D12 RID: 167186
		[Token(Token = "0x4028D12")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _extraRewardObj;

		// Token: 0x04028D13 RID: 167187
		[Token(Token = "0x4028D13")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ScrollRect _modeScrollRect;

		// Token: 0x04028D14 RID: 167188
		[Token(Token = "0x4028D14")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int _minModeCardCnt;

		// Token: 0x04028D15 RID: 167189
		[Token(Token = "0x4028D15")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private int _modeCardSlideThresholdCnt;

		// Token: 0x04028D16 RID: 167190
		[Token(Token = "0x4028D16")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private EnemyDuelPrepareSelectModeView.PrepareButtonView _matchPrepareBtn;

		// Token: 0x04028D17 RID: 167191
		[Token(Token = "0x4028D17")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private EnemyDuelPrepareSelectModeView.PrepareButtonView _roomPrepareBtn;

		// Token: 0x04028D18 RID: 167192
		[Token(Token = "0x4028D18")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TwoStateToggle _soloGameBtnDescToggle;

		// Token: 0x04028D19 RID: 167193
		[Token(Token = "0x4028D19")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _modeSelectInAnim;

		// Token: 0x04028D1A RID: 167194
		[Token(Token = "0x4028D1A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _defaultImg;

		// Token: 0x04028D1B RID: 167195
		[Token(Token = "0x4028D1B")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_isInited;

		// Token: 0x04028D1C RID: 167196
		[Token(Token = "0x4028D1C")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04028D1D RID: 167197
		[Token(Token = "0x4028D1D")]
		[FieldOffset(Offset = "0xB8")]
		private EnemyDuelPrepareSelectModeViewModel m_viewModel;

		// Token: 0x04028D1E RID: 167198
		[Token(Token = "0x4028D1E")]
		[FieldOffset(Offset = "0xC0")]
		private EnemyDuelPrepareSelectModeView.ModeCardAdapter m_modeCardAdapter;

		// Token: 0x04028D1F RID: 167199
		[Token(Token = "0x4028D1F")]
		[FieldOffset(Offset = "0xC8")]
		private AnimationSwitchTween m_modeSelectInSwitchTween;

		// Token: 0x04028D20 RID: 167200
		[Token(Token = "0x4028D20")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_modeBannerPicLoopTween;

		// Token: 0x04028D21 RID: 167201
		[Token(Token = "0x4028D21")]
		[FieldOffset(Offset = "0xD8")]
		private EnemyDuelPrepareSelectModeView.PrepareButtonView m_curPrepareBtn;

		// Token: 0x04028D22 RID: 167202
		[Token(Token = "0x4028D22")]
		[FieldOffset(Offset = "0xE0")]
		private int m_bannerPreviewIdx;

		// Token: 0x04028D23 RID: 167203
		[Token(Token = "0x4028D23")]
		[FieldOffset(Offset = "0xE4")]
		private int m_cacheMainSeqNum;

		// Token: 0x04028D24 RID: 167204
		[Token(Token = "0x4028D24")]
		[FieldOffset(Offset = "0xE8")]
		private int m_cacheSelectSeqNum;

		// Token: 0x04028D25 RID: 167205
		[Token(Token = "0x4028D25")]
		[FieldOffset(Offset = "0xF0")]
		private string m_cachedDefaultPicId;

		// Token: 0x04028D26 RID: 167206
		[Token(Token = "0x4028D26")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curBannerIdx;

		// Token: 0x04028D27 RID: 167207
		[Token(Token = "0x4028D27")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04028D28 RID: 167208
		[Token(Token = "0x4028D28")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028D29 RID: 167209
		[Token(Token = "0x4028D29")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCreateRoomClick;

		// Token: 0x04028D2A RID: 167210
		[Token(Token = "0x4028D2A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200504E RID: 20558
		[Token(Token = "0x200504E")]
		public class ModeCardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601E7AA RID: 124842 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E7AA")]
			[Address(RVA = "0x1836940", Offset = "0x1835540", VA = "0x181836940")]
			public ModeCardAdapter(EnemyDuelPrepareSelectModeView host)
			{
			}

			// Token: 0x17004725 RID: 18213
			// (get) Token: 0x0601E7AB RID: 124843 RVA: 0x000AE8E8 File Offset: 0x000ACAE8
			[Token(Token = "0x17004725")]
			public override int count
			{
				[Token(Token = "0x601E7AB")]
				[Address(RVA = "0x18369C0", Offset = "0x18355C0", VA = "0x1818369C0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601E7AC RID: 124844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601E7AC")]
			[Address(RVA = "0x1836770", Offset = "0x1835370", VA = "0x181836770", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04028D2B RID: 167211
			[Token(Token = "0x4028D2B")]
			[FieldOffset(Offset = "0x20")]
			private EnemyDuelPrepareSelectModeView host;

			// Token: 0x04028D2C RID: 167212
			[Token(Token = "0x4028D2C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04028D2D RID: 167213
			[Token(Token = "0x4028D2D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04028D2E RID: 167214
			[Token(Token = "0x4028D2E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x0200504F RID: 20559
		[Token(Token = "0x200504F")]
		[Serializable]
		private class PrepareButtonView : IHotfixable
		{
			// Token: 0x0601E7AD RID: 124845 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E7AD")]
			[Address(RVA = "0x1836EB0", Offset = "0x1835AB0", VA = "0x181836EB0")]
			private void _InitIfNot()
			{
			}

			// Token: 0x0601E7AE RID: 124846 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E7AE")]
			[Address(RVA = "0x1836E30", Offset = "0x1835A30", VA = "0x181836E30")]
			public void SetButtonVisible(bool v)
			{
			}

			// Token: 0x0601E7AF RID: 124847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E7AF")]
			[Address(RVA = "0x1836D60", Offset = "0x1835960", VA = "0x181836D60")]
			public void SetButtonActive(bool isActive)
			{
			}

			// Token: 0x0601E7B0 RID: 124848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E7B0")]
			[Address(RVA = "0x1836FB0", Offset = "0x1835BB0", VA = "0x181836FB0")]
			public PrepareButtonView()
			{
			}

			// Token: 0x04028D2F RID: 167215
			[Token(Token = "0x4028D2F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _container;

			// Token: 0x04028D30 RID: 167216
			[Token(Token = "0x4028D30")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private TwoStateToggle _btnToggle;

			// Token: 0x04028D31 RID: 167217
			[Token(Token = "0x4028D31")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private UIAnimationLocation _activeTween;

			// Token: 0x04028D32 RID: 167218
			[Token(Token = "0x4028D32")]
			[FieldOffset(Offset = "0x30")]
			private bool m_isInited;

			// Token: 0x04028D33 RID: 167219
			[Token(Token = "0x4028D33")]
			[FieldOffset(Offset = "0x38")]
			private AnimationSwitchTween m_switchTween;

			// Token: 0x04028D34 RID: 167220
			[Token(Token = "0x4028D34")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x04028D35 RID: 167221
			[Token(Token = "0x4028D35")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetButtonVisible;

			// Token: 0x04028D36 RID: 167222
			[Token(Token = "0x4028D36")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_SetButtonActive;

			// Token: 0x04028D37 RID: 167223
			[Token(Token = "0x4028D37")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
