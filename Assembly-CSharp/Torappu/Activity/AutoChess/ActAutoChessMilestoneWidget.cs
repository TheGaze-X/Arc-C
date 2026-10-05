using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200712C RID: 28972
	[Token(Token = "0x200712C")]
	public class ActAutoChessMilestoneWidget : TemplateActivityMilestoneWidget
	{
		// Token: 0x06029248 RID: 168520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029248")]
		[Address(RVA = "0x248B9A0", Offset = "0x248A5A0", VA = "0x18248B9A0", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel milestoneViewModel)
		{
		}

		// Token: 0x06029249 RID: 168521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029249")]
		[Address(RVA = "0x248BAA0", Offset = "0x248A6A0", VA = "0x18248BAA0")]
		private void _RenderProgress(TemplateActivityMilestoneGroupViewModel milestoneViewModel)
		{
		}

		// Token: 0x0602924A RID: 168522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602924A")]
		[Address(RVA = "0x248BD30", Offset = "0x248A930", VA = "0x18248BD30")]
		public ActAutoChessMilestoneWidget()
		{
		}

		// Token: 0x0403AC18 RID: 240664
		[Token(Token = "0x403AC18")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x0403AC19 RID: 240665
		[Token(Token = "0x403AC19")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalProgress;

		// Token: 0x0403AC1A RID: 240666
		[Token(Token = "0x403AC1A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _maxProgress;

		// Token: 0x0403AC1B RID: 240667
		[Token(Token = "0x403AC1B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _progressText;

		// Token: 0x0403AC1C RID: 240668
		[Token(Token = "0x403AC1C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Slider _progressSlider;

		// Token: 0x0403AC1D RID: 240669
		[Token(Token = "0x403AC1D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<ActAutoChessMilestoneDynPrizeWidgetBase> _prizeWidgets;

		// Token: 0x0403AC1E RID: 240670
		[Token(Token = "0x403AC1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AC1F RID: 240671
		[Token(Token = "0x403AC1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderProgress;

		// Token: 0x0403AC20 RID: 240672
		[Token(Token = "0x403AC20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
