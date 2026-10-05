using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AD7 RID: 31447
	[Token(Token = "0x2007AD7")]
	public class Act12D6GameEndState : PopupFadeState
	{
		// Token: 0x0602C09D RID: 180381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C09D")]
		[Address(RVA = "0x27EEDA0", Offset = "0x27ED9A0", VA = "0x1827EEDA0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602C09E RID: 180382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C09E")]
		[Address(RVA = "0x27EEE00", Offset = "0x27EDA00", VA = "0x1827EEE00", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602C09F RID: 180383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C09F")]
		[Address(RVA = "0x27EEF60", Offset = "0x27EDB60", VA = "0x1827EEF60", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0602C0A0 RID: 180384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0A0")]
		[Address(RVA = "0x27EED10", Offset = "0x27ED910", VA = "0x1827EED10")]
		public void EventOnNextClicked()
		{
		}

		// Token: 0x0602C0A1 RID: 180385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0A1")]
		[Address(RVA = "0x27EEC80", Offset = "0x27ED880", VA = "0x1827EEC80")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0602C0A2 RID: 180386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0A2")]
		[Address(RVA = "0x27EF700", Offset = "0x27EE300", VA = "0x1827EF700")]
		private void _AnimationEventOnPlayAudio(string soundId)
		{
		}

		// Token: 0x0602C0A3 RID: 180387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0A3")]
		[Address(RVA = "0x27EFA30", Offset = "0x27EE630", VA = "0x1827EFA30")]
		private void _AnimationEventOnShotBlurBkg()
		{
		}

		// Token: 0x0602C0A4 RID: 180388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0A4")]
		[Address(RVA = "0x27EF200", Offset = "0x27EDE00", VA = "0x1827EF200")]
		private void _AnimationEventOnEnableRewardView()
		{
		}

		// Token: 0x0602C0A5 RID: 180389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0A5")]
		[Address(RVA = "0x27EF900", Offset = "0x27EE500", VA = "0x1827EF900")]
		private void _AnimationEventOnPlayScoreObjAnim(int index)
		{
		}

		// Token: 0x0602C0A6 RID: 180390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0A6")]
		[Address(RVA = "0x27EF810", Offset = "0x27EE410", VA = "0x1827EF810")]
		private void _AnimationEventOnPlayModeFactor()
		{
		}

		// Token: 0x0602C0A7 RID: 180391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0A7")]
		[Address(RVA = "0x27EF9C0", Offset = "0x27EE5C0", VA = "0x1827EF9C0")]
		private void _AnimationEventOnPlayTotalScore()
		{
		}

		// Token: 0x0602C0A8 RID: 180392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0A8")]
		[Address(RVA = "0x27EF890", Offset = "0x27EE490", VA = "0x1827EF890")]
		private void _AnimationEventOnPlayOutbuffCount()
		{
		}

		// Token: 0x0602C0A9 RID: 180393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0A9")]
		[Address(RVA = "0x27EF7A0", Offset = "0x27EE3A0", VA = "0x1827EF7A0")]
		private void _AnimationEventOnPlayMilestoneCount()
		{
		}

		// Token: 0x0602C0AA RID: 180394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0AA")]
		[Address(RVA = "0x27EFF70", Offset = "0x27EEB70", VA = "0x1827EFF70")]
		private void _Render()
		{
		}

		// Token: 0x0602C0AB RID: 180395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C0AB")]
		[Address(RVA = "0x27F0D30", Offset = "0x27EF930", VA = "0x1827F0D30")]
		private IEnumerator _UpdateState()
		{
			return null;
		}

		// Token: 0x0602C0AC RID: 180396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C0AC")]
		[Address(RVA = "0x27F0C80", Offset = "0x27EF880", VA = "0x1827F0C80")]
		private IEnumerator _TryDismissSelf()
		{
			return null;
		}

		// Token: 0x0602C0AD RID: 180397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0AD")]
		[Address(RVA = "0x27F01F0", Offset = "0x27EEDF0", VA = "0x1827F01F0")]
		private void _Reset()
		{
		}

		// Token: 0x0602C0AE RID: 180398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0AE")]
		[Address(RVA = "0x27F0120", Offset = "0x27EED20", VA = "0x1827F0120")]
		private void _ResetAnim()
		{
		}

		// Token: 0x0602C0AF RID: 180399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0AF")]
		[Address(RVA = "0x27EFDB0", Offset = "0x27EE9B0", VA = "0x1827EFDB0")]
		private void _PlayAnim(string stateName, [Optional] Action onFinished)
		{
		}

		// Token: 0x0602C0B0 RID: 180400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0B0")]
		[Address(RVA = "0x27F0BE0", Offset = "0x27EF7E0", VA = "0x1827F0BE0")]
		private void _SkipStatsShowAnim()
		{
		}

		// Token: 0x0602C0B1 RID: 180401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0B1")]
		[Address(RVA = "0x27F0A40", Offset = "0x27EF640", VA = "0x1827F0A40")]
		private void _SkipRewardShowAnim()
		{
		}

		// Token: 0x0602C0B2 RID: 180402 RVA: 0x000DDF28 File Offset: 0x000DC128
		[Token(Token = "0x602C0B2")]
		[Address(RVA = "0x27EFBE0", Offset = "0x27EE7E0", VA = "0x1827EFBE0")]
		private bool _CanClick()
		{
			return default(bool);
		}

		// Token: 0x0602C0B3 RID: 180403 RVA: 0x000DDF40 File Offset: 0x000DC140
		[Token(Token = "0x602C0B3")]
		[Address(RVA = "0x27EFD40", Offset = "0x27EE940", VA = "0x1827EFD40")]
		private bool _HasUnprocessedCommand()
		{
			return default(bool);
		}

		// Token: 0x0602C0B4 RID: 180404 RVA: 0x000DDF58 File Offset: 0x000DC158
		[Token(Token = "0x602C0B4")]
		[Address(RVA = "0x27EFCD0", Offset = "0x27EE8D0", VA = "0x1827EFCD0")]
		private bool _ConsumeNextCommand()
		{
			return default(bool);
		}

		// Token: 0x0602C0B5 RID: 180405 RVA: 0x000DDF70 File Offset: 0x000DC170
		[Token(Token = "0x602C0B5")]
		[Address(RVA = "0x27EFC60", Offset = "0x27EE860", VA = "0x1827EFC60")]
		private bool _ConsumeBackCommand()
		{
			return default(bool);
		}

		// Token: 0x0602C0B6 RID: 180406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0B6")]
		[Address(RVA = "0x27F02A0", Offset = "0x27EEEA0", VA = "0x1827F02A0")]
		private void _SendFinishGameRequest(Action onFinished)
		{
		}

		// Token: 0x0602C0B7 RID: 180407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0B7")]
		[Address(RVA = "0x27F0520", Offset = "0x27EF120", VA = "0x1827F0520")]
		private void _ShowGainedTokens(int outBuffTokenCnt, int milestoneTokenCnt, Action onFinished)
		{
		}

		// Token: 0x0602C0B8 RID: 180408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0B8")]
		[Address(RVA = "0x27F07F0", Offset = "0x27EF3F0", VA = "0x1827F07F0")]
		private void _ShowUnlockToast()
		{
		}

		// Token: 0x0602C0B9 RID: 180409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0B9")]
		[Address(RVA = "0x27F0DE0", Offset = "0x27EF9E0", VA = "0x1827F0DE0")]
		public Act12D6GameEndState()
		{
		}

		// Token: 0x0602C0C2 RID: 180418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0C2")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602C0C3 RID: 180419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C0C3")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403FCD5 RID: 261333
		[Token(Token = "0x403FCD5")]
		private const string STATS_SHOW_ANIM = "anim_game_end_stats_show";

		// Token: 0x0403FCD6 RID: 261334
		[Token(Token = "0x403FCD6")]
		private const string STATS_HIDE_ANIM = "anim_game_end_stats_hide";

		// Token: 0x0403FCD7 RID: 261335
		[Token(Token = "0x403FCD7")]
		private const string REWARD_SHOW_ANIM = "anim_game_end_reward_show";

		// Token: 0x0403FCD8 RID: 261336
		[Token(Token = "0x403FCD8")]
		private const string REWARD_HIDE_ANIM = "anim_game_end_reward_hide";

		// Token: 0x0403FCD9 RID: 261337
		[Token(Token = "0x403FCD9")]
		private const string UNLOCK_SHOW_ANIM = "anim_game_end_unlock_show";

		// Token: 0x0403FCDA RID: 261338
		[Token(Token = "0x403FCDA")]
		private const string FACTOR_OBJ_SHOW_ANIM = "anim_game_end_factor_show";

		// Token: 0x0403FCDB RID: 261339
		[Token(Token = "0x403FCDB")]
		private const float UNLOCK_TOAST_INTERVAL = 1f;

		// Token: 0x0403FCDC RID: 261340
		[Token(Token = "0x403FCDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x0403FCDD RID: 261341
		[Token(Token = "0x403FCDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<Act12D6GameEndScoreObjView> _scoreObjViews;

		// Token: 0x0403FCDE RID: 261342
		[Token(Token = "0x403FCDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AnimationWrapper _modeFactorWrapper;

		// Token: 0x0403FCDF RID: 261343
		[Token(Token = "0x403FCDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _totalScoreObjView;

		// Token: 0x0403FCE0 RID: 261344
		[Token(Token = "0x403FCE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _outbuffTokenCountView;

		// Token: 0x0403FCE1 RID: 261345
		[Token(Token = "0x403FCE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Act12D6GameEndScoreObjView _milestoneTokenCountView;

		// Token: 0x0403FCE2 RID: 261346
		[Token(Token = "0x403FCE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Act12d6GameEndTitleView _titleView;

		// Token: 0x0403FCE3 RID: 261347
		[Token(Token = "0x403FCE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Act12D6GameEndStatsView _statsView;

		// Token: 0x0403FCE4 RID: 261348
		[Token(Token = "0x403FCE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Act12D6GameEndRewardView _rewardView;

		// Token: 0x0403FCE5 RID: 261349
		[Token(Token = "0x403FCE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Act12D6GameEndUnlockView _unlockView;

		// Token: 0x0403FCE6 RID: 261350
		[Token(Token = "0x403FCE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Image _imageBkg;

		// Token: 0x0403FCE7 RID: 261351
		[Token(Token = "0x403FCE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIFullScreenImage _imageBlurBkg;

		// Token: 0x0403FCE8 RID: 261352
		[Token(Token = "0x403FCE8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Image _imageCornerSuc;

		// Token: 0x0403FCE9 RID: 261353
		[Token(Token = "0x403FCE9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Image _imageCornerFail;

		// Token: 0x0403FCEA RID: 261354
		[Token(Token = "0x403FCEA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Act12D6GameEndStateBean m_stateBean;

		// Token: 0x0403FCEB RID: 261355
		[Token(Token = "0x403FCEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Inspect]
		[ReadOnly]
		private Act12D6GameEndState.InternalState m_state;

		// Token: 0x0403FCEC RID: 261356
		[Token(Token = "0x403FCEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Coroutine m_updateCoroutine;

		// Token: 0x0403FCED RID: 261357
		[Token(Token = "0x403FCED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool m_isNextClicked;

		// Token: 0x0403FCEE RID: 261358
		[Token(Token = "0x403FCEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		private bool m_isBackClicked;

		// Token: 0x0403FCEF RID: 261359
		[Token(Token = "0x403FCEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403FCF0 RID: 261360
		[Token(Token = "0x403FCF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403FCF1 RID: 261361
		[Token(Token = "0x403FCF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403FCF2 RID: 261362
		[Token(Token = "0x403FCF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnNextClicked;

		// Token: 0x0403FCF3 RID: 261363
		[Token(Token = "0x403FCF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x0403FCF4 RID: 261364
		[Token(Token = "0x403FCF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AnimationEventOnPlayAudio;

		// Token: 0x0403FCF5 RID: 261365
		[Token(Token = "0x403FCF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__AnimationEventOnShotBlurBkg;

		// Token: 0x0403FCF6 RID: 261366
		[Token(Token = "0x403FCF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AnimationEventOnEnableRewardView;

		// Token: 0x0403FCF7 RID: 261367
		[Token(Token = "0x403FCF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AnimationEventOnPlayScoreObjAnim;

		// Token: 0x0403FCF8 RID: 261368
		[Token(Token = "0x403FCF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__AnimationEventOnPlayModeFactor;

		// Token: 0x0403FCF9 RID: 261369
		[Token(Token = "0x403FCF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__AnimationEventOnPlayTotalScore;

		// Token: 0x0403FCFA RID: 261370
		[Token(Token = "0x403FCFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AnimationEventOnPlayOutbuffCount;

		// Token: 0x0403FCFB RID: 261371
		[Token(Token = "0x403FCFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__AnimationEventOnPlayMilestoneCount;

		// Token: 0x0403FCFC RID: 261372
		[Token(Token = "0x403FCFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0403FCFD RID: 261373
		[Token(Token = "0x403FCFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateState;

		// Token: 0x0403FCFE RID: 261374
		[Token(Token = "0x403FCFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__TryDismissSelf;

		// Token: 0x0403FCFF RID: 261375
		[Token(Token = "0x403FCFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x0403FD00 RID: 261376
		[Token(Token = "0x403FD00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ResetAnim;

		// Token: 0x0403FD01 RID: 261377
		[Token(Token = "0x403FD01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__PlayAnim;

		// Token: 0x0403FD02 RID: 261378
		[Token(Token = "0x403FD02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SkipStatsShowAnim;

		// Token: 0x0403FD03 RID: 261379
		[Token(Token = "0x403FD03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SkipRewardShowAnim;

		// Token: 0x0403FD04 RID: 261380
		[Token(Token = "0x403FD04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CanClick;

		// Token: 0x0403FD05 RID: 261381
		[Token(Token = "0x403FD05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__HasUnprocessedCommand;

		// Token: 0x0403FD06 RID: 261382
		[Token(Token = "0x403FD06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ConsumeNextCommand;

		// Token: 0x0403FD07 RID: 261383
		[Token(Token = "0x403FD07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ConsumeBackCommand;

		// Token: 0x0403FD08 RID: 261384
		[Token(Token = "0x403FD08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__SendFinishGameRequest;

		// Token: 0x0403FD09 RID: 261385
		[Token(Token = "0x403FD09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ShowGainedTokens;

		// Token: 0x0403FD0A RID: 261386
		[Token(Token = "0x403FD0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ShowUnlockToast;

		// Token: 0x0403FD0B RID: 261387
		[Token(Token = "0x403FD0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007AD8 RID: 31448
		[Token(Token = "0x2007AD8")]
		private enum InternalState
		{
			// Token: 0x0403FD0D RID: 261389
			[Token(Token = "0x403FD0D")]
			NONE,
			// Token: 0x0403FD0E RID: 261390
			[Token(Token = "0x403FD0E")]
			IDLE_WAIT,
			// Token: 0x0403FD0F RID: 261391
			[Token(Token = "0x403FD0F")]
			STATS_PLAY_SHOW_ANIM,
			// Token: 0x0403FD10 RID: 261392
			[Token(Token = "0x403FD10")]
			STATS_WAIT_SHOW_ANIM,
			// Token: 0x0403FD11 RID: 261393
			[Token(Token = "0x403FD11")]
			STATS_WAIT_INPUT,
			// Token: 0x0403FD12 RID: 261394
			[Token(Token = "0x403FD12")]
			STATS_PLAY_HIDE_ANIM,
			// Token: 0x0403FD13 RID: 261395
			[Token(Token = "0x403FD13")]
			REWARD_PLAY_SHOW_ANIM,
			// Token: 0x0403FD14 RID: 261396
			[Token(Token = "0x403FD14")]
			REWARD_WAIT_SHOW_ANIM,
			// Token: 0x0403FD15 RID: 261397
			[Token(Token = "0x403FD15")]
			REWARD_WAIT_INPUT,
			// Token: 0x0403FD16 RID: 261398
			[Token(Token = "0x403FD16")]
			REWARD_PLAY_HIDE_ANIM,
			// Token: 0x0403FD17 RID: 261399
			[Token(Token = "0x403FD17")]
			UNLOCK_PLAY_SHOW_ANIM,
			// Token: 0x0403FD18 RID: 261400
			[Token(Token = "0x403FD18")]
			UNLOCK_WAIT_INPUT,
			// Token: 0x0403FD19 RID: 261401
			[Token(Token = "0x403FD19")]
			TRY_EXIT
		}
	}
}
