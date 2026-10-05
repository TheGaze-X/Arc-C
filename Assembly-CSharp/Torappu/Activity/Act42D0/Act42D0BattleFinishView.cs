using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200734F RID: 29519
	[Token(Token = "0x200734F")]
	public class Act42D0BattleFinishView : ActivityBattleFinishView
	{
		// Token: 0x06029BE8 RID: 170984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BE8")]
		[Address(RVA = "0x25538C0", Offset = "0x25524C0", VA = "0x1825538C0")]
		private void _RenderRatingView()
		{
		}

		// Token: 0x06029BE9 RID: 170985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BE9")]
		[Address(RVA = "0x2554080", Offset = "0x2552C80", VA = "0x182554080")]
		private void _RenderSquadView()
		{
		}

		// Token: 0x06029BEA RID: 170986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BEA")]
		[Address(RVA = "0x2553B10", Offset = "0x2552710", VA = "0x182553B10")]
		private void _RenderRewardView()
		{
		}

		// Token: 0x06029BEB RID: 170987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BEB")]
		[Address(RVA = "0x2553020", Offset = "0x2551C20", VA = "0x182553020", Slot = "11")]
		protected override void OnInit()
		{
		}

		// Token: 0x06029BEC RID: 170988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BEC")]
		[Address(RVA = "0x25536E0", Offset = "0x25522E0", VA = "0x1825536E0")]
		private void _PlayRatingSignal()
		{
		}

		// Token: 0x06029BED RID: 170989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029BED")]
		[Address(RVA = "0x25534A0", Offset = "0x25520A0", VA = "0x1825534A0")]
		private Act42D0BattleFinishView.DisplayState _FindInitState(Act42D0BattleFinishViewModel viewModel)
		{
			return null;
		}

		// Token: 0x06029BEE RID: 170990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BEE")]
		[Address(RVA = "0x2553680", Offset = "0x2552280", VA = "0x182553680")]
		private void _JumpToActivity()
		{
		}

		// Token: 0x06029BEF RID: 170991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BEF")]
		[Address(RVA = "0x2552EA0", Offset = "0x2551AA0", VA = "0x182552EA0")]
		public void EventOnViewClick()
		{
		}

		// Token: 0x06029BF0 RID: 170992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029BF0")]
		[Address(RVA = "0x25549A0", Offset = "0x25535A0", VA = "0x1825549A0")]
		public Act42D0BattleFinishView()
		{
		}

		// Token: 0x0403BBF8 RID: 244728
		[Token(Token = "0x403BBF8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animRatingEnter;

		// Token: 0x0403BBF9 RID: 244729
		[Token(Token = "0x403BBF9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _animSquadEnter;

		// Token: 0x0403BBFA RID: 244730
		[Token(Token = "0x403BBFA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _animRewardEnter;

		// Token: 0x0403BBFB RID: 244731
		[Token(Token = "0x403BBFB")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _ratingPanel;

		// Token: 0x0403BBFC RID: 244732
		[Token(Token = "0x403BBFC")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _squadPanel;

		// Token: 0x0403BBFD RID: 244733
		[Token(Token = "0x403BBFD")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIBlurFloatPanel _rewardBlurPanel;

		// Token: 0x0403BBFE RID: 244734
		[Token(Token = "0x403BBFE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Squad Panel")]
		private RectTransform _illustContainer;

		// Token: 0x0403BBFF RID: 244735
		[Token(Token = "0x403BBFF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Squad Panel")]
		private Text _textStageName;

		// Token: 0x0403BC00 RID: 244736
		[Token(Token = "0x403BC00")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Squad Panel")]
		private Text _textPlayerName;

		// Token: 0x0403BC01 RID: 244737
		[Token(Token = "0x403BC01")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Squad Panel")]
		private Text _textFinishTime;

		// Token: 0x0403BC02 RID: 244738
		[Token(Token = "0x403BC02")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Squad Panel")]
		private RectTransform _avatarContainer;

		// Token: 0x0403BC03 RID: 244739
		[Token(Token = "0x403BC03")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Squad Panel")]
		private SimpleLayoutContent _charList;

		// Token: 0x0403BC04 RID: 244740
		[Token(Token = "0x403BC04")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Rating Panel")]
		private Text _textRatingDesc;

		// Token: 0x0403BC05 RID: 244741
		[Token(Token = "0x403BC05")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Rating Panel")]
		private GameObject[] _ratingList;

		// Token: 0x0403BC06 RID: 244742
		[Token(Token = "0x403BC06")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Reward Panel")]
		private Text _textRewardCount;

		// Token: 0x0403BC07 RID: 244743
		[Token(Token = "0x403BC07")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Reward Panel")]
		private Text _textRewardLv;

		// Token: 0x0403BC08 RID: 244744
		[Token(Token = "0x403BC08")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("Reward Panel")]
		private Text _textRewardProgress;

		// Token: 0x0403BC09 RID: 244745
		[Token(Token = "0x403BC09")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Reward Panel")]
		private Slider _rewardSlider;

		// Token: 0x0403BC0A RID: 244746
		[Token(Token = "0x403BC0A")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("Reward Panel")]
		private float _sliderTweenDuration;

		// Token: 0x0403BC0B RID: 244747
		[Token(Token = "0x403BC0B")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		[Group("Reward Panel")]
		private Image _imgItemIcon;

		// Token: 0x0403BC0C RID: 244748
		[Token(Token = "0x403BC0C")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Group("Reward Panel")]
		private Text _textRewardCaption;

		// Token: 0x0403BC0D RID: 244749
		[Token(Token = "0x403BC0D")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Image _imgDisplayIcon;

		// Token: 0x0403BC0E RID: 244750
		[Token(Token = "0x403BC0E")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Act42D0BattleFinishView.NormalBattleUI _normalBattleUI;

		// Token: 0x0403BC0F RID: 244751
		[Token(Token = "0x403BC0F")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Act42D0BattleFinishView.ChallengeBattleUI _challengeBattleUI;

		// Token: 0x0403BC10 RID: 244752
		[Token(Token = "0x403BC10")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0403BC11 RID: 244753
		[Token(Token = "0x403BC11")]
		[FieldOffset(Offset = "0x110")]
		private Act42D0BattleFinishViewModel m_viewModel;

		// Token: 0x0403BC12 RID: 244754
		[Token(Token = "0x403BC12")]
		[FieldOffset(Offset = "0x118")]
		private FadeSwitchTween m_ratingSwitchTween;

		// Token: 0x0403BC13 RID: 244755
		[Token(Token = "0x403BC13")]
		[FieldOffset(Offset = "0x120")]
		private FadeSwitchTween m_squadSwitchTween;

		// Token: 0x0403BC14 RID: 244756
		[Token(Token = "0x403BC14")]
		[FieldOffset(Offset = "0x128")]
		private Act42D0BattleFinishView.DisplayState m_displayState;

		// Token: 0x0403BC15 RID: 244757
		[Token(Token = "0x403BC15")]
		[FieldOffset(Offset = "0x130")]
		private Act42D0BattleFinishView.CharListAdapter m_adapter;

		// Token: 0x0403BC16 RID: 244758
		[Token(Token = "0x403BC16")]
		[FieldOffset(Offset = "0x138")]
		private PlayerAvatarView m_avatar;

		// Token: 0x0403BC17 RID: 244759
		[Token(Token = "0x403BC17")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__RenderRatingView;

		// Token: 0x0403BC18 RID: 244760
		[Token(Token = "0x403BC18")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderSquadView;

		// Token: 0x0403BC19 RID: 244761
		[Token(Token = "0x403BC19")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderRewardView;

		// Token: 0x0403BC1A RID: 244762
		[Token(Token = "0x403BC1A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403BC1B RID: 244763
		[Token(Token = "0x403BC1B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayRatingSignal;

		// Token: 0x0403BC1C RID: 244764
		[Token(Token = "0x403BC1C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FindInitState;

		// Token: 0x0403BC1D RID: 244765
		[Token(Token = "0x403BC1D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__JumpToActivity;

		// Token: 0x0403BC1E RID: 244766
		[Token(Token = "0x403BC1E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnViewClick;

		// Token: 0x0403BC1F RID: 244767
		[Token(Token = "0x403BC1F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007350 RID: 29520
		[Token(Token = "0x2007350")]
		[Serializable]
		private class NormalBattleUI : IHotfixable
		{
			// Token: 0x06029BF1 RID: 170993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029BF1")]
			[Address(RVA = "0x2566E40", Offset = "0x2565A40", VA = "0x182566E40")]
			public void Render(string actId, Act42D0FinishInfoModel finishInfoModel)
			{
			}

			// Token: 0x06029BF2 RID: 170994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029BF2")]
			[Address(RVA = "0x25672C0", Offset = "0x2565EC0", VA = "0x1825672C0")]
			private void _InitIfNot()
			{
			}

			// Token: 0x06029BF3 RID: 170995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029BF3")]
			[Address(RVA = "0x2567480", Offset = "0x2566080", VA = "0x182567480")]
			public NormalBattleUI()
			{
			}

			// Token: 0x0403BC20 RID: 244768
			[Token(Token = "0x403BC20")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _rootGo;

			// Token: 0x0403BC21 RID: 244769
			[Token(Token = "0x403BC21")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textStageCode;

			// Token: 0x0403BC22 RID: 244770
			[Token(Token = "0x403BC22")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textRatingDesc;

			// Token: 0x0403BC23 RID: 244771
			[Token(Token = "0x403BC23")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private UIAtlasImage _imgRating;

			// Token: 0x0403BC24 RID: 244772
			[Token(Token = "0x403BC24")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private GameObject _newRecordGo;

			// Token: 0x0403BC25 RID: 244773
			[Token(Token = "0x403BC25")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private UIAtlasObject _atlas;

			// Token: 0x0403BC26 RID: 244774
			[Token(Token = "0x403BC26")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private GameObject _noEffectPanelGo;

			// Token: 0x0403BC27 RID: 244775
			[Token(Token = "0x403BC27")]
			[FieldOffset(Offset = "0x48")]
			[SerializeField]
			private GameObject _effectPanelGo;

			// Token: 0x0403BC28 RID: 244776
			[Token(Token = "0x403BC28")]
			[FieldOffset(Offset = "0x50")]
			[SerializeField]
			private RectTransform[] _effectContainerList;

			// Token: 0x0403BC29 RID: 244777
			[Token(Token = "0x403BC29")]
			[FieldOffset(Offset = "0x58")]
			[SerializeField]
			private Act42D0BattleFinishEffectItemView _effectItemPrefab;

			// Token: 0x0403BC2A RID: 244778
			[Token(Token = "0x403BC2A")]
			private const int EFFECT_COL_COUNT = 5;

			// Token: 0x0403BC2B RID: 244779
			[Token(Token = "0x403BC2B")]
			[FieldOffset(Offset = "0x60")]
			private List<Act42D0BattleFinishEffectItemView> m_effectItemList;

			// Token: 0x0403BC2C RID: 244780
			[Token(Token = "0x403BC2C")]
			[FieldOffset(Offset = "0x68")]
			private bool m_hasInited;

			// Token: 0x0403BC2D RID: 244781
			[Token(Token = "0x403BC2D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403BC2E RID: 244782
			[Token(Token = "0x403BC2E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x0403BC2F RID: 244783
			[Token(Token = "0x403BC2F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007351 RID: 29521
		[Token(Token = "0x2007351")]
		[Serializable]
		private class ChallengeBattleUI : IHotfixable
		{
			// Token: 0x06029BF4 RID: 170996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029BF4")]
			[Address(RVA = "0x25646E0", Offset = "0x25632E0", VA = "0x1825646E0")]
			public void Render(Act42D0FinishInfoModel finishInfoModel)
			{
			}

			// Token: 0x06029BF5 RID: 170997 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029BF5")]
			[Address(RVA = "0x25649E0", Offset = "0x25635E0", VA = "0x1825649E0")]
			public ChallengeBattleUI()
			{
			}

			// Token: 0x0403BC30 RID: 244784
			[Token(Token = "0x403BC30")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private GameObject _rootGo;

			// Token: 0x0403BC31 RID: 244785
			[Token(Token = "0x403BC31")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private GameObject _normalRecordGo;

			// Token: 0x0403BC32 RID: 244786
			[Token(Token = "0x403BC32")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private GameObject _newRecordGo;

			// Token: 0x0403BC33 RID: 244787
			[Token(Token = "0x403BC33")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Text _textProgress;

			// Token: 0x0403BC34 RID: 244788
			[Token(Token = "0x403BC34")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Text _textTotal;

			// Token: 0x0403BC35 RID: 244789
			[Token(Token = "0x403BC35")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403BC36 RID: 244790
			[Token(Token = "0x403BC36")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02007352 RID: 29522
		[Token(Token = "0x2007352")]
		private class CharListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06029BF6 RID: 170998 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029BF6")]
			[Address(RVA = "0x2564D10", Offset = "0x2563910", VA = "0x182564D10")]
			public CharListAdapter(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x17006287 RID: 25223
			// (get) Token: 0x06029BF7 RID: 170999 RVA: 0x000D6620 File Offset: 0x000D4820
			[Token(Token = "0x17006287")]
			public override int count
			{
				[Token(Token = "0x6029BF7")]
				[Address(RVA = "0x2564D90", Offset = "0x2563990", VA = "0x182564D90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06029BF8 RID: 171000 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029BF8")]
			[Address(RVA = "0x2564A40", Offset = "0x2563640", VA = "0x182564A40", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403BC37 RID: 244791
			[Token(Token = "0x403BC37")]
			private const int ASSIST_COUNT = 1;

			// Token: 0x0403BC38 RID: 244792
			[Token(Token = "0x403BC38")]
			[FieldOffset(Offset = "0x20")]
			private Act42D0BattleFinishView m_closure;

			// Token: 0x0403BC39 RID: 244793
			[Token(Token = "0x403BC39")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BC3A RID: 244794
			[Token(Token = "0x403BC3A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403BC3B RID: 244795
			[Token(Token = "0x403BC3B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02007353 RID: 29523
		[Token(Token = "0x2007353")]
		private abstract class DisplayState
		{
			// Token: 0x06029BF9 RID: 171001
			[Token(Token = "0x6029BF9")]
			public abstract void HandleClick(Act42D0BattleFinishView closure, out Act42D0BattleFinishView.DisplayState nextState);

			// Token: 0x06029BFA RID: 171002 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029BFA")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			public virtual void OnEnter(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x06029BFB RID: 171003 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029BFB")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
			public virtual void OnExit(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x06029BFC RID: 171004 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029BFC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected DisplayState()
			{
			}
		}

		// Token: 0x02007354 RID: 29524
		[Token(Token = "0x2007354")]
		private abstract class DisplayStateWithAnim : Act42D0BattleFinishView.DisplayState
		{
			// Token: 0x06029BFD RID: 171005
			[Token(Token = "0x6029BFD")]
			protected abstract UIAnimationLocation _GetAnimEnter(Act42D0BattleFinishView closure);

			// Token: 0x06029BFE RID: 171006 RVA: 0x000D6638 File Offset: 0x000D4838
			[Token(Token = "0x6029BFE")]
			[Address(RVA = "0x2564F00", Offset = "0x2563B00", VA = "0x182564F00")]
			protected bool _IsAnimEnterPlaying()
			{
				return default(bool);
			}

			// Token: 0x06029BFF RID: 171007 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029BFF")]
			[Address(RVA = "0x2564E00", Offset = "0x2563A00", VA = "0x182564E00", Slot = "5")]
			public override void OnEnter(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x06029C00 RID: 171008 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C00")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
			public override void OnExit(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x06029C01 RID: 171009 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C01")]
			[Address(RVA = "0x2564E00", Offset = "0x2563A00", VA = "0x182564E00")]
			private void _PlayAnimEnter(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x06029C02 RID: 171010 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C02")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected DisplayStateWithAnim()
			{
			}

			// Token: 0x0403BC3C RID: 244796
			[Token(Token = "0x403BC3C")]
			[FieldOffset(Offset = "0x10")]
			private Tween m_animEnterTween;
		}

		// Token: 0x02007355 RID: 29525
		[Token(Token = "0x2007355")]
		private class RatingDisplayState : Act42D0BattleFinishView.DisplayStateWithAnim
		{
			// Token: 0x06029C03 RID: 171011 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C03")]
			[Address(RVA = "0x25677F0", Offset = "0x25663F0", VA = "0x1825677F0", Slot = "5")]
			public override void OnEnter(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x06029C04 RID: 171012 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C04")]
			[Address(RVA = "0x2567840", Offset = "0x2566440", VA = "0x182567840", Slot = "6")]
			public override void OnExit(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x06029C05 RID: 171013 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C05")]
			[Address(RVA = "0x2567760", Offset = "0x2566360", VA = "0x182567760", Slot = "4")]
			public override void HandleClick(Act42D0BattleFinishView closure, out Act42D0BattleFinishView.DisplayState nextState)
			{
			}

			// Token: 0x06029C06 RID: 171014 RVA: 0x000D6650 File Offset: 0x000D4850
			[Token(Token = "0x6029C06")]
			[Address(RVA = "0x2567870", Offset = "0x2566470", VA = "0x182567870", Slot = "7")]
			protected override UIAnimationLocation _GetAnimEnter(Act42D0BattleFinishView closure)
			{
				return default(UIAnimationLocation);
			}

			// Token: 0x06029C07 RID: 171015 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C07")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RatingDisplayState()
			{
			}
		}

		// Token: 0x02007356 RID: 29526
		[Token(Token = "0x2007356")]
		private class SquadDisplayState : Act42D0BattleFinishView.DisplayStateWithAnim
		{
			// Token: 0x06029C08 RID: 171016 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C08")]
			[Address(RVA = "0x2568820", Offset = "0x2567420", VA = "0x182568820", Slot = "5")]
			public override void OnEnter(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x06029C09 RID: 171017 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C09")]
			[Address(RVA = "0x2568870", Offset = "0x2567470", VA = "0x182568870", Slot = "6")]
			public override void OnExit(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x06029C0A RID: 171018 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C0A")]
			[Address(RVA = "0x2568700", Offset = "0x2567300", VA = "0x182568700", Slot = "4")]
			public override void HandleClick(Act42D0BattleFinishView closure, out Act42D0BattleFinishView.DisplayState nextState)
			{
			}

			// Token: 0x06029C0B RID: 171019 RVA: 0x000D6668 File Offset: 0x000D4868
			[Token(Token = "0x6029C0B")]
			[Address(RVA = "0x25688A0", Offset = "0x25674A0", VA = "0x1825688A0", Slot = "7")]
			protected override UIAnimationLocation _GetAnimEnter(Act42D0BattleFinishView closure)
			{
				return default(UIAnimationLocation);
			}

			// Token: 0x06029C0C RID: 171020 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C0C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SquadDisplayState()
			{
			}
		}

		// Token: 0x02007357 RID: 29527
		[Token(Token = "0x2007357")]
		private class RewardDisplayState : Act42D0BattleFinishView.DisplayStateWithAnim
		{
			// Token: 0x06029C0D RID: 171021 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C0D")]
			[Address(RVA = "0x2567930", Offset = "0x2566530", VA = "0x182567930", Slot = "5")]
			public override void OnEnter(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x06029C0E RID: 171022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C0E")]
			[Address(RVA = "0x2567970", Offset = "0x2566570", VA = "0x182567970", Slot = "6")]
			public override void OnExit(Act42D0BattleFinishView closure)
			{
			}

			// Token: 0x06029C0F RID: 171023 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C0F")]
			[Address(RVA = "0x2567890", Offset = "0x2566490", VA = "0x182567890", Slot = "4")]
			public override void HandleClick(Act42D0BattleFinishView closure, out Act42D0BattleFinishView.DisplayState nextState)
			{
			}

			// Token: 0x06029C10 RID: 171024 RVA: 0x000D6680 File Offset: 0x000D4880
			[Token(Token = "0x6029C10")]
			[Address(RVA = "0x25679A0", Offset = "0x25665A0", VA = "0x1825679A0", Slot = "7")]
			protected override UIAnimationLocation _GetAnimEnter(Act42D0BattleFinishView closure)
			{
				return default(UIAnimationLocation);
			}

			// Token: 0x06029C11 RID: 171025 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C11")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RewardDisplayState()
			{
			}
		}
	}
}
