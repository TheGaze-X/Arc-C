using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200704C RID: 28748
	[Token(Token = "0x200704C")]
	public class ActMultiV3PrepareMainPlayerInfoView : ActMultiV3PrepareMainViewBase, IPingListener
	{
		// Token: 0x06028CF7 RID: 167159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CF7")]
		[Address(RVA = "0x243AA80", Offset = "0x2439680", VA = "0x18243AA80", Slot = "7")]
		public override void OnValueChanged(ActMultiV3PrepareMainViewModelProperty property)
		{
		}

		// Token: 0x06028CF8 RID: 167160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CF8")]
		[Address(RVA = "0x243B350", Offset = "0x2439F50", VA = "0x18243B350")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028CF9 RID: 167161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CF9")]
		[Address(RVA = "0x243B700", Offset = "0x243A300", VA = "0x18243B700")]
		private void _Render(ActMultiV3PrepareMainPlayerInfoViewModel viewModel, ActMultiV3PrepareMainViewConfig config)
		{
		}

		// Token: 0x06028CFA RID: 167162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CFA")]
		[Address(RVA = "0x243B2E0", Offset = "0x2439EE0", VA = "0x18243B2E0")]
		private void Update()
		{
		}

		// Token: 0x06028CFB RID: 167163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CFB")]
		[Address(RVA = "0x243BCA0", Offset = "0x243A8A0", VA = "0x18243BCA0")]
		private void _SetActiveToGameObjects(GameObject[] objs, bool value)
		{
		}

		// Token: 0x06028CFC RID: 167164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CFC")]
		[Address(RVA = "0x243B5A0", Offset = "0x243A1A0", VA = "0x18243B5A0")]
		private void _OnBackPress()
		{
		}

		// Token: 0x06028CFD RID: 167165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CFD")]
		[Address(RVA = "0x243A8D0", Offset = "0x24394D0", VA = "0x18243A8D0")]
		public void EventOnExit()
		{
		}

		// Token: 0x06028CFE RID: 167166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CFE")]
		[Address(RVA = "0x243A720", Offset = "0x2439320", VA = "0x18243A720")]
		public void EventOnBack()
		{
		}

		// Token: 0x06028CFF RID: 167167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028CFF")]
		[Address(RVA = "0x243A690", Offset = "0x2439290", VA = "0x18243A690")]
		public void Chat()
		{
		}

		// Token: 0x06028D00 RID: 167168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D00")]
		[Address(RVA = "0x243A9F0", Offset = "0x24395F0", VA = "0x18243A9F0")]
		public void EventOnKick()
		{
		}

		// Token: 0x06028D01 RID: 167169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D01")]
		[Address(RVA = "0x243A7B0", Offset = "0x24393B0", VA = "0x18243A7B0")]
		public void EventOnCheckNameCard()
		{
		}

		// Token: 0x06028D02 RID: 167170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D02")]
		[Address(RVA = "0x243A840", Offset = "0x2439440", VA = "0x18243A840")]
		public void EventOnClickSquadEffect()
		{
		}

		// Token: 0x06028D03 RID: 167171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D03")]
		[Address(RVA = "0x243A960", Offset = "0x2439560", VA = "0x18243A960")]
		public void EventOnInviteClick()
		{
		}

		// Token: 0x06028D04 RID: 167172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D04")]
		[Address(RVA = "0x243B1B0", Offset = "0x2439DB0", VA = "0x18243B1B0", Slot = "8")]
		public void UpdatePing(int ping)
		{
		}

		// Token: 0x06028D05 RID: 167173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028D05")]
		[Address(RVA = "0x243BD70", Offset = "0x243A970", VA = "0x18243BD70")]
		public ActMultiV3PrepareMainPlayerInfoView()
		{
		}

		// Token: 0x0403A335 RID: 238389
		[Token(Token = "0x403A335")]
		private const string COUNT_DOWN_FORMAT = "{0:D2}:{1:D2}";

		// Token: 0x0403A336 RID: 238390
		[Token(Token = "0x403A336")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public ActMultiV3PrepareMainPlayerInfoView.PlayerInfoGroup _topPlayerGroup;

		// Token: 0x0403A337 RID: 238391
		[Token(Token = "0x403A337")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActMultiV3PrepareMainPlayerInfoView.PlayerInfoGroup _botPlayerGroup;

		// Token: 0x0403A338 RID: 238392
		[Token(Token = "0x403A338")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _stageCheckObjs;

		// Token: 0x0403A339 RID: 238393
		[Token(Token = "0x403A339")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject[] _charPickObjs;

		// Token: 0x0403A33A RID: 238394
		[Token(Token = "0x403A33A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TwoStateToggle _topPlayerToggle;

		// Token: 0x0403A33B RID: 238395
		[Token(Token = "0x403A33B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _lastStepBtnToggle;

		// Token: 0x0403A33C RID: 238396
		[Token(Token = "0x403A33C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _kickBtnObj;

		// Token: 0x0403A33D RID: 238397
		[Token(Token = "0x403A33D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup[] _chatCdBlockers;

		// Token: 0x0403A33E RID: 238398
		[Token(Token = "0x403A33E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject[] _chatObjs;

		// Token: 0x0403A33F RID: 238399
		[Token(Token = "0x403A33F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject[] _chatNewPoints;

		// Token: 0x0403A340 RID: 238400
		[Token(Token = "0x403A340")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _pingTxt;

		// Token: 0x0403A341 RID: 238401
		[Token(Token = "0x403A341")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _closeTxt;

		// Token: 0x0403A342 RID: 238402
		[Token(Token = "0x403A342")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _backBtnRect;

		// Token: 0x0403A343 RID: 238403
		[Token(Token = "0x403A343")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _partnerOfflineObj;

		// Token: 0x0403A344 RID: 238404
		[Token(Token = "0x403A344")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private TwoStateToggle _tinyToggle;

		// Token: 0x0403A345 RID: 238405
		[Token(Token = "0x403A345")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _fullPanelInAnim;

		// Token: 0x0403A346 RID: 238406
		[Token(Token = "0x403A346")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _tinyPanelInAnim;

		// Token: 0x0403A347 RID: 238407
		[Token(Token = "0x403A347")]
		[FieldOffset(Offset = "0xB8")]
		private bool m_isInited;

		// Token: 0x0403A348 RID: 238408
		[Token(Token = "0x403A348")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403A349 RID: 238409
		[Token(Token = "0x403A349")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isTiny;

		// Token: 0x0403A34A RID: 238410
		[Token(Token = "0x403A34A")]
		[FieldOffset(Offset = "0xD4")]
		private int m_cachedCdSeqNum;

		// Token: 0x0403A34B RID: 238411
		[Token(Token = "0x403A34B")]
		[FieldOffset(Offset = "0xD8")]
		private Tween m_cachedCdTween;

		// Token: 0x0403A34C RID: 238412
		[Token(Token = "0x403A34C")]
		[FieldOffset(Offset = "0xE0")]
		private ActMultiV3PrepareMainViewModelProperty m_cachedProp;

		// Token: 0x0403A34D RID: 238413
		[Token(Token = "0x403A34D")]
		[FieldOffset(Offset = "0xE8")]
		private CountDownTask m_countDownTask;

		// Token: 0x0403A34E RID: 238414
		[Token(Token = "0x403A34E")]
		[FieldOffset(Offset = "0xF0")]
		private long m_cachedEndTs;

		// Token: 0x0403A34F RID: 238415
		[Token(Token = "0x403A34F")]
		[FieldOffset(Offset = "0xF8")]
		private AnimationSwitchTween m_fullPanelSwitchTween;

		// Token: 0x0403A350 RID: 238416
		[Token(Token = "0x403A350")]
		[FieldOffset(Offset = "0x100")]
		private AnimationSwitchTween m_tinyPanelSwitchTween;

		// Token: 0x0403A351 RID: 238417
		[Token(Token = "0x403A351")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403A352 RID: 238418
		[Token(Token = "0x403A352")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A353 RID: 238419
		[Token(Token = "0x403A353")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403A354 RID: 238420
		[Token(Token = "0x403A354")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0403A355 RID: 238421
		[Token(Token = "0x403A355")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetActiveToGameObjects;

		// Token: 0x0403A356 RID: 238422
		[Token(Token = "0x403A356")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnBackPress;

		// Token: 0x0403A357 RID: 238423
		[Token(Token = "0x403A357")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnExit;

		// Token: 0x0403A358 RID: 238424
		[Token(Token = "0x403A358")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnBack;

		// Token: 0x0403A359 RID: 238425
		[Token(Token = "0x403A359")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Chat;

		// Token: 0x0403A35A RID: 238426
		[Token(Token = "0x403A35A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnKick;

		// Token: 0x0403A35B RID: 238427
		[Token(Token = "0x403A35B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnCheckNameCard;

		// Token: 0x0403A35C RID: 238428
		[Token(Token = "0x403A35C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnClickSquadEffect;

		// Token: 0x0403A35D RID: 238429
		[Token(Token = "0x403A35D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnInviteClick;

		// Token: 0x0403A35E RID: 238430
		[Token(Token = "0x403A35E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_UpdatePing;

		// Token: 0x0403A35F RID: 238431
		[Token(Token = "0x403A35F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200704D RID: 28749
		[Token(Token = "0x200704D")]
		[Serializable]
		public class PlayerInfoGroup : IHotfixable
		{
			// Token: 0x06028D09 RID: 167177 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028D09")]
			[Address(RVA = "0x24483C0", Offset = "0x2446FC0", VA = "0x1824483C0")]
			private void _InitIfNot()
			{
			}

			// Token: 0x06028D0A RID: 167178 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028D0A")]
			[Address(RVA = "0x2447F80", Offset = "0x2446B80", VA = "0x182447F80")]
			public void Render(ILoadAsset assetLoader, ActMultiV3PrepareMainPlayerInfoViewModel.PlayerViewModel playerViewModel)
			{
			}

			// Token: 0x06028D0B RID: 167179 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028D0B")]
			[Address(RVA = "0x2448540", Offset = "0x2447140", VA = "0x182448540")]
			public PlayerInfoGroup()
			{
			}

			// Token: 0x0403A360 RID: 238432
			[Token(Token = "0x403A360")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text _playerNameTxt;

			// Token: 0x0403A361 RID: 238433
			[Token(Token = "0x403A361")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _playerTitleTxt;

			// Token: 0x0403A362 RID: 238434
			[Token(Token = "0x403A362")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _playerLvTxt;

			// Token: 0x0403A363 RID: 238435
			[Token(Token = "0x403A363")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Image _effectImg;

			// Token: 0x0403A364 RID: 238436
			[Token(Token = "0x403A364")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Image _effectTinyImg;

			// Token: 0x0403A365 RID: 238437
			[Token(Token = "0x403A365")]
			[FieldOffset(Offset = "0x38")]
			[SerializeField]
			private Transform _avatarContainer;

			// Token: 0x0403A366 RID: 238438
			[Token(Token = "0x403A366")]
			[FieldOffset(Offset = "0x40")]
			[SerializeField]
			private UIAnimationLocation _readyAnim;

			// Token: 0x0403A367 RID: 238439
			[Token(Token = "0x403A367")]
			[FieldOffset(Offset = "0x50")]
			private bool m_isInited;

			// Token: 0x0403A368 RID: 238440
			[Token(Token = "0x403A368")]
			[FieldOffset(Offset = "0x58")]
			private AnimationSwitchTween m_readyAnimSwitchTween;

			// Token: 0x0403A369 RID: 238441
			[Token(Token = "0x403A369")]
			[FieldOffset(Offset = "0x60")]
			private PlayerAvatarView m_avatarView;

			// Token: 0x0403A36A RID: 238442
			[Token(Token = "0x403A36A")]
			[FieldOffset(Offset = "0x68")]
			private bool m_lastEmpty;

			// Token: 0x0403A36B RID: 238443
			[Token(Token = "0x403A36B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__InitIfNot;

			// Token: 0x0403A36C RID: 238444
			[Token(Token = "0x403A36C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Render;

			// Token: 0x0403A36D RID: 238445
			[Token(Token = "0x403A36D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
