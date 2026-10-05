using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.BattleFinish
{
	// Token: 0x02007097 RID: 28823
	[Token(Token = "0x2007097")]
	public class ActMultiV3BattleFinishRewardView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028F2B RID: 167723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F2B")]
		[Address(RVA = "0x2450BB0", Offset = "0x244F7B0", VA = "0x182450BB0")]
		public void Render(ActMultiV3BattleFinishViewModel viewModel)
		{
		}

		// Token: 0x06028F2C RID: 167724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F2C")]
		[Address(RVA = "0x24511B0", Offset = "0x244FDB0", VA = "0x1824511B0")]
		private void _RenderMilestone(ActMultiV3BattleFinishMilestoneInfo milestoneInfo)
		{
		}

		// Token: 0x06028F2D RID: 167725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F2D")]
		[Address(RVA = "0x2451110", Offset = "0x244FD10", VA = "0x182451110")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028F2E RID: 167726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028F2E")]
		[Address(RVA = "0x2450860", Offset = "0x244F460", VA = "0x182450860")]
		public Tween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06028F2F RID: 167727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F2F")]
		[Address(RVA = "0x24515C0", Offset = "0x24501C0", VA = "0x1824515C0")]
		private void _UpdateMilestone(int milestonePoint)
		{
		}

		// Token: 0x06028F30 RID: 167728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028F30")]
		[Address(RVA = "0x2451720", Offset = "0x2450320", VA = "0x182451720")]
		public ActMultiV3BattleFinishRewardView()
		{
		}

		// Token: 0x0403A705 RID: 239365
		[Token(Token = "0x403A705")]
		private const string REWARD_DISPLAY_STR = "+{0}";

		// Token: 0x0403A706 RID: 239366
		[Token(Token = "0x403A706")]
		private const string MILESTONE_PROGRESS_MAX = "-";

		// Token: 0x0403A707 RID: 239367
		[Token(Token = "0x403A707")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgItemIcon1;

		// Token: 0x0403A708 RID: 239368
		[Token(Token = "0x403A708")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgItemIcon2;

		// Token: 0x0403A709 RID: 239369
		[Token(Token = "0x403A709")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgSeasonIcon;

		// Token: 0x0403A70A RID: 239370
		[Token(Token = "0x403A70A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgSeasonIcon2;

		// Token: 0x0403A70B RID: 239371
		[Token(Token = "0x403A70B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _rewardPanelGO;

		// Token: 0x0403A70C RID: 239372
		[Token(Token = "0x403A70C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _complexRewardGO;

		// Token: 0x0403A70D RID: 239373
		[Token(Token = "0x403A70D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _normalRewardGO;

		// Token: 0x0403A70E RID: 239374
		[Token(Token = "0x403A70E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textNormalReward1;

		// Token: 0x0403A70F RID: 239375
		[Token(Token = "0x403A70F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textNormalReward2;

		// Token: 0x0403A710 RID: 239376
		[Token(Token = "0x403A710")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textDailyReward;

		// Token: 0x0403A711 RID: 239377
		[Token(Token = "0x403A711")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textDailyProgressCurr;

		// Token: 0x0403A712 RID: 239378
		[Token(Token = "0x403A712")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textDailyProgressMax;

		// Token: 0x0403A713 RID: 239379
		[Token(Token = "0x403A713")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animDailyReward;

		// Token: 0x0403A714 RID: 239380
		[Token(Token = "0x403A714")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _textMilestoneLv;

		// Token: 0x0403A715 RID: 239381
		[Token(Token = "0x403A715")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textMilestoneProgressCurr;

		// Token: 0x0403A716 RID: 239382
		[Token(Token = "0x403A716")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textMilestoneProgressMax;

		// Token: 0x0403A717 RID: 239383
		[Token(Token = "0x403A717")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textMilestoneAdd;

		// Token: 0x0403A718 RID: 239384
		[Token(Token = "0x403A718")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Color _colorMilestoneAddNormal;

		// Token: 0x0403A719 RID: 239385
		[Token(Token = "0x403A719")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Color _colorMilestoneAddMax;

		// Token: 0x0403A71A RID: 239386
		[Token(Token = "0x403A71A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Slider _sliderMilestone;

		// Token: 0x0403A71B RID: 239387
		[Token(Token = "0x403A71B")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAnimationLocation _animMilestoneLvUp;

		// Token: 0x0403A71C RID: 239388
		[Token(Token = "0x403A71C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private float _milestoneTweenDuration;

		// Token: 0x0403A71D RID: 239389
		[Token(Token = "0x403A71D")]
		[FieldOffset(Offset = "0xE4")]
		private bool m_hasInited;

		// Token: 0x0403A71E RID: 239390
		[Token(Token = "0x403A71E")]
		[FieldOffset(Offset = "0xE8")]
		private Tween m_showTween;

		// Token: 0x0403A71F RID: 239391
		[Token(Token = "0x403A71F")]
		[FieldOffset(Offset = "0xF0")]
		private Tween m_lvUpTween;

		// Token: 0x0403A720 RID: 239392
		[Token(Token = "0x403A720")]
		[FieldOffset(Offset = "0xF8")]
		private ActMultiV3BattleFinishViewModel m_viewModel;

		// Token: 0x0403A721 RID: 239393
		[Token(Token = "0x403A721")]
		[FieldOffset(Offset = "0x100")]
		private int m_tweenMilestoneVal;

		// Token: 0x0403A722 RID: 239394
		[Token(Token = "0x403A722")]
		[FieldOffset(Offset = "0x104")]
		private int m_tweenMilestoneLv;

		// Token: 0x0403A723 RID: 239395
		[Token(Token = "0x403A723")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403A724 RID: 239396
		[Token(Token = "0x403A724")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderMilestone;

		// Token: 0x0403A725 RID: 239397
		[Token(Token = "0x403A725")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A726 RID: 239398
		[Token(Token = "0x403A726")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x0403A727 RID: 239399
		[Token(Token = "0x403A727")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateMilestone;

		// Token: 0x0403A728 RID: 239400
		[Token(Token = "0x403A728")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
