using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CC9 RID: 27849
	[Token(Token = "0x2006CC9")]
	public abstract class TemplateActivityMilestoneWithPrizeWidget : TemplateActivityMilestoneWidget
	{
		// Token: 0x06027BAF RID: 162735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BAF")]
		[Address(RVA = "0x22E43E0", Offset = "0x22E2FE0", VA = "0x1822E43E0", Slot = "4")]
		public override void Render(TemplateActivityMilestoneGroupViewModel milestoneViewModel)
		{
		}

		// Token: 0x06027BB0 RID: 162736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027BB0")]
		[Address(RVA = "0x22E4610", Offset = "0x22E3210", VA = "0x1822E4610")]
		protected TemplateActivityMilestoneWithPrizeWidget()
		{
		}

		// Token: 0x04038560 RID: 230752
		[Token(Token = "0x4038560")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _prizeContainer;

		// Token: 0x04038561 RID: 230753
		[Token(Token = "0x4038561")]
		[FieldOffset(Offset = "0x20")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04038562 RID: 230754
		[Token(Token = "0x4038562")]
		[FieldOffset(Offset = "0x30")]
		private TemplateActivityMilestoneDynPrizeWidget m_prizeWidget;

		// Token: 0x04038563 RID: 230755
		[Token(Token = "0x4038563")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038564 RID: 230756
		[Token(Token = "0x4038564")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
