using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007964 RID: 31076
	[Token(Token = "0x2007964")]
	public class Act1ArcadeSettlementMilestoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602B985 RID: 178565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B985")]
		[Address(RVA = "0x2780780", Offset = "0x277F380", VA = "0x182780780")]
		public void OnRender(Act1ArcadeSettlementModel model)
		{
		}

		// Token: 0x0602B986 RID: 178566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B986")]
		[Address(RVA = "0x2780BE0", Offset = "0x277F7E0", VA = "0x182780BE0")]
		private void _ShowIcon()
		{
		}

		// Token: 0x0602B987 RID: 178567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B987")]
		[Address(RVA = "0x2780CB0", Offset = "0x277F8B0", VA = "0x182780CB0")]
		private void _ShowMilestone()
		{
		}

		// Token: 0x0602B988 RID: 178568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B988")]
		[Address(RVA = "0x2780900", Offset = "0x277F500", VA = "0x182780900")]
		private IEnumerator _PlayMilestoneAnim()
		{
			return null;
		}

		// Token: 0x0602B989 RID: 178569 RVA: 0x000DC890 File Offset: 0x000DAA90
		[Token(Token = "0x602B989")]
		[Address(RVA = "0x2780E70", Offset = "0x277FA70", VA = "0x182780E70")]
		private int _TweenScoreGetter()
		{
			return 0;
		}

		// Token: 0x0602B98A RID: 178570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B98A")]
		[Address(RVA = "0x2780ED0", Offset = "0x277FAD0", VA = "0x182780ED0")]
		private void _TweenScoreSetter(int newScore)
		{
		}

		// Token: 0x0602B98B RID: 178571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B98B")]
		[Address(RVA = "0x27809B0", Offset = "0x277F5B0", VA = "0x1827809B0")]
		private void _RefreshMilestoneShow()
		{
		}

		// Token: 0x0602B98C RID: 178572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B98C")]
		[Address(RVA = "0x2781150", Offset = "0x277FD50", VA = "0x182781150")]
		public Act1ArcadeSettlementMilestoneView()
		{
		}

		// Token: 0x0403F0F9 RID: 258297
		[Token(Token = "0x403F0F9")]
		private const float MILESTONE_TWEEN_DURATION = 1.5f;

		// Token: 0x0403F0FA RID: 258298
		[Token(Token = "0x403F0FA")]
		private const float MILESTONE_TWEEN_DELAY = 0.6f;

		// Token: 0x0403F0FB RID: 258299
		[Token(Token = "0x403F0FB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgToken;

		// Token: 0x0403F0FC RID: 258300
		[Token(Token = "0x403F0FC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textMilestoneReward;

		// Token: 0x0403F0FD RID: 258301
		[Token(Token = "0x403F0FD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textMilestoneLevel;

		// Token: 0x0403F0FE RID: 258302
		[Token(Token = "0x403F0FE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textMilestoneProgressCur;

		// Token: 0x0403F0FF RID: 258303
		[Token(Token = "0x403F0FF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textMilestoneProgressTotal;

		// Token: 0x0403F100 RID: 258304
		[Token(Token = "0x403F100")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgMilestoneProgress;

		// Token: 0x0403F101 RID: 258305
		[Token(Token = "0x403F101")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _imgMilestoneProgressFx;

		// Token: 0x0403F102 RID: 258306
		[Token(Token = "0x403F102")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelMilestoneMaxLevelFx;

		// Token: 0x0403F103 RID: 258307
		[Token(Token = "0x403F103")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private TwoStateToggle _milestoneLevelStateToggle;

		// Token: 0x0403F104 RID: 258308
		[Token(Token = "0x403F104")]
		[FieldOffset(Offset = "0x60")]
		private Act1ArcadeSettlementModel m_settlementModel;

		// Token: 0x0403F105 RID: 258309
		[Token(Token = "0x403F105")]
		[FieldOffset(Offset = "0x68")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0403F106 RID: 258310
		[Token(Token = "0x403F106")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isReachMax;

		// Token: 0x0403F107 RID: 258311
		[Token(Token = "0x403F107")]
		[FieldOffset(Offset = "0x78")]
		private TemplateActivityMileStoneItemModel m_catchedMilestoneModel;

		// Token: 0x0403F108 RID: 258312
		[Token(Token = "0x403F108")]
		[FieldOffset(Offset = "0x80")]
		private int m_tweenTargetScore;

		// Token: 0x0403F109 RID: 258313
		[Token(Token = "0x403F109")]
		[FieldOffset(Offset = "0x84")]
		private int m_catchedMilestoneScore;

		// Token: 0x0403F10A RID: 258314
		[Token(Token = "0x403F10A")]
		[FieldOffset(Offset = "0x88")]
		private int m_prefLevelScoreNum;

		// Token: 0x0403F10B RID: 258315
		[Token(Token = "0x403F10B")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_tween;

		// Token: 0x0403F10C RID: 258316
		[Token(Token = "0x403F10C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403F10D RID: 258317
		[Token(Token = "0x403F10D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ShowIcon;

		// Token: 0x0403F10E RID: 258318
		[Token(Token = "0x403F10E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowMilestone;

		// Token: 0x0403F10F RID: 258319
		[Token(Token = "0x403F10F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlayMilestoneAnim;

		// Token: 0x0403F110 RID: 258320
		[Token(Token = "0x403F110")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TweenScoreGetter;

		// Token: 0x0403F111 RID: 258321
		[Token(Token = "0x403F111")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TweenScoreSetter;

		// Token: 0x0403F112 RID: 258322
		[Token(Token = "0x403F112")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshMilestoneShow;

		// Token: 0x0403F113 RID: 258323
		[Token(Token = "0x403F113")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
