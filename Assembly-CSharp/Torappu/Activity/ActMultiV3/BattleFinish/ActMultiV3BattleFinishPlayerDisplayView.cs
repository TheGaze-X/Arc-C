using System;
using System.Collections;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x02007091 RID: 28817
	[Token(Token = "0x2007091")]
	public class ActMultiV3BattleFinishPlayerDisplayView : ActMultiV3BattleFinishPhaseView
	{
		// Token: 0x170060DF RID: 24799
		// (get) Token: 0x06028F00 RID: 167680 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F01 RID: 167681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060DF")]
		public Action onReturnToHome
		{
			[Token(Token = "0x6028F00")]
			[Address(RVA = "0x244F9A0", Offset = "0x244E5A0", VA = "0x18244F9A0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028F01")]
			[Address(RVA = "0x244FBC0", Offset = "0x244E7C0", VA = "0x18244FBC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170060E0 RID: 24800
		// (get) Token: 0x06028F02 RID: 167682 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F03 RID: 167683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060E0")]
		public Action onContinueCoop
		{
			[Token(Token = "0x6028F02")]
			[Address(RVA = "0x244F940", Offset = "0x244E540", VA = "0x18244F940")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028F03")]
			[Address(RVA = "0x244FB40", Offset = "0x244E740", VA = "0x18244FB40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170060E1 RID: 24801
		// (get) Token: 0x06028F04 RID: 167684 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F05 RID: 167685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060E1")]
		public Action onReturnToRoom
		{
			[Token(Token = "0x6028F04")]
			[Address(RVA = "0x244FA60", Offset = "0x244E660", VA = "0x18244FA60")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028F05")]
			[Address(RVA = "0x244FCC0", Offset = "0x244E8C0", VA = "0x18244FCC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170060E2 RID: 24802
		// (get) Token: 0x06028F06 RID: 167686 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F07 RID: 167687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060E2")]
		public Action onReturnToMatch
		{
			[Token(Token = "0x6028F06")]
			[Address(RVA = "0x244FA00", Offset = "0x244E600", VA = "0x18244FA00")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028F07")]
			[Address(RVA = "0x244FC40", Offset = "0x244E840", VA = "0x18244FC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170060E3 RID: 24803
		// (get) Token: 0x06028F08 RID: 167688 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06028F09 RID: 167689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170060E3")]
		public Action onBtnLikeClick
		{
			[Token(Token = "0x6028F08")]
			[Address(RVA = "0x244F8E0", Offset = "0x244E4E0", VA = "0x18244F8E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6028F09")]
			[Address(RVA = "0x244FAC0", Offset = "0x244E6C0", VA = "0x18244FAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06028F0A RID: 167690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028F0A")]
		[Address(RVA = "0x244F360", Offset = "0x244DF60", VA = "0x18244F360", Slot = "5")]
		public override IEnumerator ShowCoroutine()
		{
			return null;
		}

		// Token: 0x06028F0B RID: 167691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F0B")]
		[Address(RVA = "0x244E300", Offset = "0x244CF00", VA = "0x18244E300", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06028F0C RID: 167692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F0C")]
		[Address(RVA = "0x244F5B0", Offset = "0x244E1B0", VA = "0x18244F5B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028F0D RID: 167693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F0D")]
		[Address(RVA = "0x244F410", Offset = "0x244E010", VA = "0x18244F410")]
		public void UpdateBtnRoomVisible(ActMultiV3BattleFinishViewModel viewModel)
		{
		}

		// Token: 0x06028F0E RID: 167694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F0E")]
		[Address(RVA = "0x244F070", Offset = "0x244DC70", VA = "0x18244F070")]
		public void PlayGotLikeAnimIfNeed()
		{
		}

		// Token: 0x06028F0F RID: 167695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F0F")]
		[Address(RVA = "0x244EEF0", Offset = "0x244DAF0", VA = "0x18244EEF0")]
		public void PlayGiveLikeAnimIfNeed()
		{
		}

		// Token: 0x06028F10 RID: 167696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F10")]
		[Address(RVA = "0x244F200", Offset = "0x244DE00", VA = "0x18244F200")]
		public void PlayPartnerWaveAnimIfNeed()
		{
		}

		// Token: 0x06028F11 RID: 167697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F11")]
		[Address(RVA = "0x244DFD0", Offset = "0x244CBD0", VA = "0x18244DFD0")]
		public void EventOnBtnReturnHome()
		{
		}

		// Token: 0x06028F12 RID: 167698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F12")]
		[Address(RVA = "0x244DEC0", Offset = "0x244CAC0", VA = "0x18244DEC0")]
		public void EventOnBtnLikeClick()
		{
		}

		// Token: 0x06028F13 RID: 167699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F13")]
		[Address(RVA = "0x244E1F0", Offset = "0x244CDF0", VA = "0x18244E1F0")]
		public void EventOnBtnReturnRoom()
		{
		}

		// Token: 0x06028F14 RID: 167700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F14")]
		[Address(RVA = "0x244DDB0", Offset = "0x244C9B0", VA = "0x18244DDB0")]
		public void EventOnBtnContinueCoop()
		{
		}

		// Token: 0x06028F15 RID: 167701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F15")]
		[Address(RVA = "0x244E0E0", Offset = "0x244CCE0", VA = "0x18244E0E0")]
		public void EventOnBtnReturnMatch()
		{
		}

		// Token: 0x06028F16 RID: 167702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F16")]
		[Address(RVA = "0x244F840", Offset = "0x244E440", VA = "0x18244F840")]
		public ActMultiV3BattleFinishPlayerDisplayView()
		{
		}

		// Token: 0x0403A6AC RID: 239276
		[Token(Token = "0x403A6AC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403A6AD RID: 239277
		[Token(Token = "0x403A6AD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textStageCode;

		// Token: 0x0403A6AE RID: 239278
		[Token(Token = "0x403A6AE")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ActMultiV3BattleFinishIllustView _myIllustView;

		// Token: 0x0403A6AF RID: 239279
		[Token(Token = "0x403A6AF")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActMultiV3BattleFinishIllustView _partnerIllustView;

		// Token: 0x0403A6B0 RID: 239280
		[Token(Token = "0x403A6B0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActMultiV3DifficultyIconView _diffIconPrefab;

		// Token: 0x0403A6B1 RID: 239281
		[Token(Token = "0x403A6B1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _diffIconContainer;

		// Token: 0x0403A6B2 RID: 239282
		[Token(Token = "0x403A6B2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject[] _starRatingGOList;

		// Token: 0x0403A6B3 RID: 239283
		[Token(Token = "0x403A6B3")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ActMultiV3BattleFinishResultViewBase[] _resultViewList;

		// Token: 0x0403A6B4 RID: 239284
		[Token(Token = "0x403A6B4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _reverseBgGO;

		// Token: 0x0403A6B5 RID: 239285
		[Token(Token = "0x403A6B5")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _reverseTagGO;

		// Token: 0x0403A6B6 RID: 239286
		[Token(Token = "0x403A6B6")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _newPhotoGO;

		// Token: 0x0403A6B7 RID: 239287
		[Token(Token = "0x403A6B7")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _imgModeIcon;

		// Token: 0x0403A6B8 RID: 239288
		[Token(Token = "0x403A6B8")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text _textFinishTime;

		// Token: 0x0403A6B9 RID: 239289
		[Token(Token = "0x403A6B9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private ActMultiV3ShortNameCardView _nameCardPrefab;

		// Token: 0x0403A6BA RID: 239290
		[Token(Token = "0x403A6BA")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private RectTransform _myNameCardContainer;

		// Token: 0x0403A6BB RID: 239291
		[Token(Token = "0x403A6BB")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RectTransform _partnerNameCardContainer;

		// Token: 0x0403A6BC RID: 239292
		[Token(Token = "0x403A6BC")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private GameObject _btnContinueMatchGO;

		// Token: 0x0403A6BD RID: 239293
		[Token(Token = "0x403A6BD")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private GameObject _btnContinueCoopGO;

		// Token: 0x0403A6BE RID: 239294
		[Token(Token = "0x403A6BE")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private GameObject _btnReturnRoomGO;

		// Token: 0x0403A6BF RID: 239295
		[Token(Token = "0x403A6BF")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _btnCompleteTrainingGO;

		// Token: 0x0403A6C0 RID: 239296
		[Token(Token = "0x403A6C0")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private UIAnimationLocation _animGotLike;

		// Token: 0x0403A6C1 RID: 239297
		[Token(Token = "0x403A6C1")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIAnimationLocation _animGiveLike;

		// Token: 0x0403A6C2 RID: 239298
		[Token(Token = "0x403A6C2")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private UIAnimationLocation _animWavingAnim;

		// Token: 0x0403A6C3 RID: 239299
		[Token(Token = "0x403A6C3")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private UIAnimationLocation _animPartnerLight;

		// Token: 0x0403A6C4 RID: 239300
		[Token(Token = "0x403A6C4")]
		[FieldOffset(Offset = "0x138")]
		private bool m_hasInit;

		// Token: 0x0403A6C5 RID: 239301
		[Token(Token = "0x403A6C5")]
		[FieldOffset(Offset = "0x139")]
		private bool m_cacheGotLike;

		// Token: 0x0403A6C6 RID: 239302
		[Token(Token = "0x403A6C6")]
		[FieldOffset(Offset = "0x13A")]
		private bool m_cachePartnerWaving;

		// Token: 0x0403A6C7 RID: 239303
		[Token(Token = "0x403A6C7")]
		[FieldOffset(Offset = "0x140")]
		private Tween m_enterTween;

		// Token: 0x0403A6C8 RID: 239304
		[Token(Token = "0x403A6C8")]
		[FieldOffset(Offset = "0x148")]
		private Tween m_gotLikeTween;

		// Token: 0x0403A6C9 RID: 239305
		[Token(Token = "0x403A6C9")]
		[FieldOffset(Offset = "0x150")]
		private Tween m_givenLikeTween;

		// Token: 0x0403A6CA RID: 239306
		[Token(Token = "0x403A6CA")]
		[FieldOffset(Offset = "0x158")]
		private AnimationSwitchTween m_partnerLightTween;

		// Token: 0x0403A6CB RID: 239307
		[Token(Token = "0x403A6CB")]
		[FieldOffset(Offset = "0x160")]
		private ActMultiV3DifficultyIconView m_diffIconView;

		// Token: 0x0403A6CC RID: 239308
		[Token(Token = "0x403A6CC")]
		[FieldOffset(Offset = "0x168")]
		private ActMultiV3ShortNameCardView m_selfNameCardView;

		// Token: 0x0403A6CD RID: 239309
		[Token(Token = "0x403A6CD")]
		[FieldOffset(Offset = "0x170")]
		private ActMultiV3ShortNameCardView m_partnerNameCardView;

		// Token: 0x0403A6D3 RID: 239315
		[Token(Token = "0x403A6D3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onReturnToHome;

		// Token: 0x0403A6D4 RID: 239316
		[Token(Token = "0x403A6D4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onReturnToHome;

		// Token: 0x0403A6D5 RID: 239317
		[Token(Token = "0x403A6D5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_onContinueCoop;

		// Token: 0x0403A6D6 RID: 239318
		[Token(Token = "0x403A6D6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onContinueCoop;

		// Token: 0x0403A6D7 RID: 239319
		[Token(Token = "0x403A6D7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_onReturnToRoom;

		// Token: 0x0403A6D8 RID: 239320
		[Token(Token = "0x403A6D8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_onReturnToRoom;

		// Token: 0x0403A6D9 RID: 239321
		[Token(Token = "0x403A6D9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_onReturnToMatch;

		// Token: 0x0403A6DA RID: 239322
		[Token(Token = "0x403A6DA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_onReturnToMatch;

		// Token: 0x0403A6DB RID: 239323
		[Token(Token = "0x403A6DB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_onBtnLikeClick;

		// Token: 0x0403A6DC RID: 239324
		[Token(Token = "0x403A6DC")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_onBtnLikeClick;

		// Token: 0x0403A6DD RID: 239325
		[Token(Token = "0x403A6DD")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403A6DE RID: 239326
		[Token(Token = "0x403A6DE")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403A6DF RID: 239327
		[Token(Token = "0x403A6DF")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A6E0 RID: 239328
		[Token(Token = "0x403A6E0")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdateBtnRoomVisible;

		// Token: 0x0403A6E1 RID: 239329
		[Token(Token = "0x403A6E1")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_PlayGotLikeAnimIfNeed;

		// Token: 0x0403A6E2 RID: 239330
		[Token(Token = "0x403A6E2")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_PlayGiveLikeAnimIfNeed;

		// Token: 0x0403A6E3 RID: 239331
		[Token(Token = "0x403A6E3")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_PlayPartnerWaveAnimIfNeed;

		// Token: 0x0403A6E4 RID: 239332
		[Token(Token = "0x403A6E4")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_EventOnBtnReturnHome;

		// Token: 0x0403A6E5 RID: 239333
		[Token(Token = "0x403A6E5")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EventOnBtnLikeClick;

		// Token: 0x0403A6E6 RID: 239334
		[Token(Token = "0x403A6E6")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_EventOnBtnReturnRoom;

		// Token: 0x0403A6E7 RID: 239335
		[Token(Token = "0x403A6E7")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_EventOnBtnContinueCoop;

		// Token: 0x0403A6E8 RID: 239336
		[Token(Token = "0x403A6E8")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_EventOnBtnReturnMatch;

		// Token: 0x0403A6E9 RID: 239337
		[Token(Token = "0x403A6E9")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
