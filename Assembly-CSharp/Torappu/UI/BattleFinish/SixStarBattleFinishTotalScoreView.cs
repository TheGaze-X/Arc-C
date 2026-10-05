using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006221 RID: 25121
	[Token(Token = "0x2006221")]
	public class SixStarBattleFinishTotalScoreView : SixStarBattleFinishTimeTickListener
	{
		// Token: 0x060243DE RID: 148446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243DE")]
		[Address(RVA = "0x1F1C660", Offset = "0x1F1B260", VA = "0x181F1C660", Slot = "4")]
		public override void OnSetData(SixStarBattleFinishViewModel viewModel)
		{
		}

		// Token: 0x060243DF RID: 148447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243DF")]
		[Address(RVA = "0x1F1C820", Offset = "0x1F1B420", VA = "0x181F1C820", Slot = "5")]
		public override void OnTriggerTick()
		{
		}

		// Token: 0x060243E0 RID: 148448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243E0")]
		[Address(RVA = "0x1F1CA50", Offset = "0x1F1B650", VA = "0x181F1CA50")]
		private void _ResetPanelPos()
		{
		}

		// Token: 0x060243E1 RID: 148449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243E1")]
		[Address(RVA = "0x1F1CB10", Offset = "0x1F1B710", VA = "0x181F1CB10")]
		public SixStarBattleFinishTotalScoreView()
		{
		}

		// Token: 0x04032645 RID: 206405
		[Token(Token = "0x4032645")]
		private const float PANEL_TWEEN_DURATION = 0.5f;

		// Token: 0x04032646 RID: 206406
		[Token(Token = "0x4032646")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textPrefScore;

		// Token: 0x04032647 RID: 206407
		[Token(Token = "0x4032647")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCurScore;

		// Token: 0x04032648 RID: 206408
		[Token(Token = "0x4032648")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("tween")]
		private float _panelTweenTargetY;

		// Token: 0x04032649 RID: 206409
		[Token(Token = "0x4032649")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("tween")]
		private RectTransform _panelScore;

		// Token: 0x0403264A RID: 206410
		[Token(Token = "0x403264A")]
		[FieldOffset(Offset = "0x38")]
		private int m_totalScoreBeforeBattle;

		// Token: 0x0403264B RID: 206411
		[Token(Token = "0x403264B")]
		[FieldOffset(Offset = "0x3C")]
		private int m_totalScoreAfterBattle;

		// Token: 0x0403264C RID: 206412
		[Token(Token = "0x403264C")]
		[FieldOffset(Offset = "0x40")]
		private int m_curCountTotalScore;

		// Token: 0x0403264D RID: 206413
		[Token(Token = "0x403264D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSetData;

		// Token: 0x0403264E RID: 206414
		[Token(Token = "0x403264E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTriggerTick;

		// Token: 0x0403264F RID: 206415
		[Token(Token = "0x403264F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ResetPanelPos;

		// Token: 0x04032650 RID: 206416
		[Token(Token = "0x4032650")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
