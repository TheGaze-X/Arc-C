using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F45 RID: 28485
	[Token(Token = "0x2006F45")]
	public class ActMultiV3TemplateMilestoneViewAdapter : DataBinder<ActMultiV3MilestoneProp>
	{
		// Token: 0x06028745 RID: 165701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028745")]
		[Address(RVA = "0x23D0BC0", Offset = "0x23CF7C0", VA = "0x1823D0BC0", Slot = "7")]
		public override void OnValueChanged(ActMultiV3MilestoneProp property)
		{
		}

		// Token: 0x06028746 RID: 165702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028746")]
		[Address(RVA = "0x23D0B40", Offset = "0x23CF740", VA = "0x1823D0B40")]
		public void FocusOnIdx(int idx)
		{
		}

		// Token: 0x06028747 RID: 165703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028747")]
		[Address(RVA = "0x23D0CE0", Offset = "0x23CF8E0", VA = "0x1823D0CE0")]
		public ActMultiV3TemplateMilestoneViewAdapter()
		{
		}

		// Token: 0x040398B2 RID: 235698
		[Token(Token = "0x40398B2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TemplateActivityMilestoneHolder _holder;

		// Token: 0x040398B3 RID: 235699
		[Token(Token = "0x40398B3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActMultiV3MilestoneWidget _widget;

		// Token: 0x040398B4 RID: 235700
		[Token(Token = "0x40398B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040398B5 RID: 235701
		[Token(Token = "0x40398B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_FocusOnIdx;

		// Token: 0x040398B6 RID: 235702
		[Token(Token = "0x40398B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
