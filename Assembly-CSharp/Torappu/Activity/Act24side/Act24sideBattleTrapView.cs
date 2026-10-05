using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007578 RID: 30072
	[Token(Token = "0x2007578")]
	public class Act24sideBattleTrapView : DataBinder<Act24sideBattleTrapViewProperty>
	{
		// Token: 0x0602A564 RID: 173412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A564")]
		[Address(RVA = "0x25FCA20", Offset = "0x25FB620", VA = "0x1825FCA20", Slot = "7")]
		public override void OnValueChanged(Act24sideBattleTrapViewProperty property)
		{
		}

		// Token: 0x0602A565 RID: 173413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A565")]
		[Address(RVA = "0x25FCB20", Offset = "0x25FB720", VA = "0x1825FCB20")]
		public void PlayEnterAnim()
		{
		}

		// Token: 0x0602A566 RID: 173414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A566")]
		[Address(RVA = "0x25FC980", Offset = "0x25FB580", VA = "0x1825FC980")]
		public void EventOnConfirmClick()
		{
		}

		// Token: 0x0602A567 RID: 173415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A567")]
		[Address(RVA = "0x25FCBC0", Offset = "0x25FB7C0", VA = "0x1825FCBC0")]
		public Act24sideBattleTrapView()
		{
		}

		// Token: 0x0403CE2B RID: 249387
		[Token(Token = "0x403CE2B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act24sideBattleTrapAbstractSelectView _selectView;

		// Token: 0x0403CE2C RID: 249388
		[Token(Token = "0x403CE2C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act24sideBattleTrapAbstractTrapListView _trapListView;

		// Token: 0x0403CE2D RID: 249389
		[Token(Token = "0x403CE2D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403CE2E RID: 249390
		[Token(Token = "0x403CE2E")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_finder;

		// Token: 0x0403CE2F RID: 249391
		[Token(Token = "0x403CE2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403CE30 RID: 249392
		[Token(Token = "0x403CE30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayEnterAnim;

		// Token: 0x0403CE31 RID: 249393
		[Token(Token = "0x403CE31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClick;

		// Token: 0x0403CE32 RID: 249394
		[Token(Token = "0x403CE32")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
