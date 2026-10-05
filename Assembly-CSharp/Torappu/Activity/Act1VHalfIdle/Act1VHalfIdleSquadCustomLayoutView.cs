using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077FC RID: 30716
	[Token(Token = "0x20077FC")]
	public class Act1VHalfIdleSquadCustomLayoutView : CommonSquadLayoutViewBase
	{
		// Token: 0x0602B16A RID: 176490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B16A")]
		[Address(RVA = "0x26E3DF0", Offset = "0x26E29F0", VA = "0x1826E3DF0")]
		public void EventOnMultiFormationClicked()
		{
		}

		// Token: 0x0602B16B RID: 176491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B16B")]
		[Address(RVA = "0x26E4090", Offset = "0x26E2C90", VA = "0x1826E4090", Slot = "10")]
		protected override void OnStateValueChanged(CommonSquadGroupViewModel commonSquadGroupViewModel)
		{
		}

		// Token: 0x0602B16C RID: 176492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B16C")]
		[Address(RVA = "0x26E3F20", Offset = "0x26E2B20", VA = "0x1826E3F20", Slot = "9")]
		protected override void OnCharCardClicked(CommonSquadCardViewBase.Options options)
		{
		}

		// Token: 0x0602B16D RID: 176493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B16D")]
		[Address(RVA = "0x26E41E0", Offset = "0x26E2DE0", VA = "0x1826E41E0")]
		public Act1VHalfIdleSquadCustomLayoutView()
		{
		}

		// Token: 0x0602B16E RID: 176494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B16E")]
		[Address(RVA = "0xE67E50", Offset = "0xE66A50", VA = "0x180E67E50")]
		private void <>xLuaBaseProxy_OnStateValueChanged(CommonSquadGroupViewModel P0)
		{
		}

		// Token: 0x0602B16F RID: 176495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B16F")]
		[Address(RVA = "0x26E41C0", Offset = "0x26E2DC0", VA = "0x1826E41C0")]
		private void <>xLuaBaseProxy_OnCharCardClicked(CommonSquadCardViewBase.Options P0)
		{
		}

		// Token: 0x0403E43C RID: 255036
		[Token(Token = "0x403E43C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pnlMultiFormation;

		// Token: 0x0403E43D RID: 255037
		[Token(Token = "0x403E43D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _pnlPredefinedTip;

		// Token: 0x0403E43E RID: 255038
		[Token(Token = "0x403E43E")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isPredefinedCharStage;

		// Token: 0x0403E43F RID: 255039
		[Token(Token = "0x403E43F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnMultiFormationClicked;

		// Token: 0x0403E440 RID: 255040
		[Token(Token = "0x403E440")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnStateValueChanged;

		// Token: 0x0403E441 RID: 255041
		[Token(Token = "0x403E441")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCharCardClicked;

		// Token: 0x0403E442 RID: 255042
		[Token(Token = "0x403E442")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
