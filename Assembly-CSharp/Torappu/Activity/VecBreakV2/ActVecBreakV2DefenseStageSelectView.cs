using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006E1C RID: 28188
	[Token(Token = "0x2006E1C")]
	public class ActVecBreakV2DefenseStageSelectView : DataBinder<ActVecBreakV2DefenseStageSelectProperty>
	{
		// Token: 0x06028207 RID: 164359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028207")]
		[Address(RVA = "0x236EC30", Offset = "0x236D830", VA = "0x18236EC30", Slot = "7")]
		public override void OnValueChanged(ActVecBreakV2DefenseStageSelectProperty property)
		{
		}

		// Token: 0x06028208 RID: 164360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028208")]
		[Address(RVA = "0x236EBA0", Offset = "0x236D7A0", VA = "0x18236EBA0")]
		public void EventOnOpenOverviewState()
		{
		}

		// Token: 0x06028209 RID: 164361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028209")]
		[Address(RVA = "0x236ECE0", Offset = "0x236D8E0", VA = "0x18236ECE0")]
		public ActVecBreakV2DefenseStageSelectView()
		{
		}

		// Token: 0x04038F7F RID: 233343
		[Token(Token = "0x4038F7F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActVecBreakV2DefenseStageDetailPanel _detailPanel;

		// Token: 0x04038F80 RID: 233344
		[Token(Token = "0x4038F80")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActVecBreakV2DefenseBuffListPanel _buffListPanel;

		// Token: 0x04038F81 RID: 233345
		[Token(Token = "0x4038F81")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04038F82 RID: 233346
		[Token(Token = "0x4038F82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04038F83 RID: 233347
		[Token(Token = "0x4038F83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnOpenOverviewState;

		// Token: 0x04038F84 RID: 233348
		[Token(Token = "0x4038F84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
