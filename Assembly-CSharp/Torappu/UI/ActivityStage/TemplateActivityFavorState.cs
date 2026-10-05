using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C9B RID: 27803
	[Token(Token = "0x2006C9B")]
	public class TemplateActivityFavorState : PopupFloatState
	{
		// Token: 0x06027A93 RID: 162451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027A93")]
		[Address(RVA = "0x22DF2C0", Offset = "0x22DDEC0", VA = "0x1822DF2C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027A94 RID: 162452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A94")]
		[Address(RVA = "0x22DF320", Offset = "0x22DDF20", VA = "0x1822DF320", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06027A95 RID: 162453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A95")]
		[Address(RVA = "0x22DF4C0", Offset = "0x22DE0C0", VA = "0x1822DF4C0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06027A96 RID: 162454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A96")]
		[Address(RVA = "0x22DF210", Offset = "0x22DDE10", VA = "0x1822DF210")]
		public void EventOnBackgroundClicked()
		{
		}

		// Token: 0x06027A97 RID: 162455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A97")]
		[Address(RVA = "0x22DF550", Offset = "0x22DE150", VA = "0x1822DF550")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x06027A98 RID: 162456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A98")]
		[Address(RVA = "0x22DF670", Offset = "0x22DE270", VA = "0x1822DF670")]
		public TemplateActivityFavorState()
		{
		}

		// Token: 0x06027A9A RID: 162458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A9A")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06027A9B RID: 162459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A9B")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0403841D RID: 230429
		[Token(Token = "0x403841D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TemplateActivityCommonFavorUpView _view;

		// Token: 0x0403841E RID: 230430
		[Token(Token = "0x403841E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403841F RID: 230431
		[Token(Token = "0x403841F")]
		[FieldOffset(Offset = "0x80")]
		private CommonTopMenu m_topMenu;

		// Token: 0x04038420 RID: 230432
		[Token(Token = "0x4038420")]
		[FieldOffset(Offset = "0x88")]
		private TemplateActCommonFavorUpStateBean m_stateBean;

		// Token: 0x04038421 RID: 230433
		[Token(Token = "0x4038421")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04038422 RID: 230434
		[Token(Token = "0x4038422")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04038423 RID: 230435
		[Token(Token = "0x4038423")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04038424 RID: 230436
		[Token(Token = "0x4038424")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackgroundClicked;

		// Token: 0x04038425 RID: 230437
		[Token(Token = "0x4038425")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x04038426 RID: 230438
		[Token(Token = "0x4038426")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
