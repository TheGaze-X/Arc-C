using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200383E RID: 14398
	[Token(Token = "0x200383E")]
	public abstract class UIStateAutoPopupController : IHotfixable
	{
		// Token: 0x06016D1D RID: 93469
		[Token(Token = "0x6016D1D")]
		protected abstract bool IsStableEnvironment();

		// Token: 0x06016D1E RID: 93470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D1E")]
		[Address(RVA = "0xF52320", Offset = "0xF50F20", VA = "0x180F52320")]
		public void Init(Func<UIStateAutoPopupController.PopupItem, bool> handler)
		{
		}

		// Token: 0x06016D1F RID: 93471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D1F")]
		[Address(RVA = "0xF52240", Offset = "0xF50E40", VA = "0x180F52240")]
		public void AddEvent(int type, object param)
		{
		}

		// Token: 0x06016D20 RID: 93472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D20")]
		[Address(RVA = "0xF523F0", Offset = "0xF50FF0", VA = "0x180F523F0")]
		public void TriggerPopup()
		{
		}

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x06016D21 RID: 93473 RVA: 0x00093168 File Offset: 0x00091368
		[Token(Token = "0x17003694")]
		public bool isActive
		{
			[Token(Token = "0x6016D21")]
			[Address(RVA = "0xF52A90", Offset = "0xF51690", VA = "0x180F52A90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06016D22 RID: 93474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D22")]
		[Address(RVA = "0xF52450", Offset = "0xF51050", VA = "0x180F52450")]
		private void _TriggerImpl()
		{
		}

		// Token: 0x06016D23 RID: 93475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D23")]
		[Address(RVA = "0xF52850", Offset = "0xF51450", VA = "0x180F52850")]
		private void _TryTriggerNextPopup()
		{
		}

		// Token: 0x06016D24 RID: 93476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D24")]
		[Address(RVA = "0xF52660", Offset = "0xF51260", VA = "0x180F52660")]
		private void _TriggerPopupWithItems(Queue<UIStateAutoPopupController.PopupItem> items)
		{
		}

		// Token: 0x06016D25 RID: 93477 RVA: 0x00093180 File Offset: 0x00091380
		[Token(Token = "0x6016D25")]
		[Address(RVA = "0xF527A0", Offset = "0xF513A0", VA = "0x180F527A0")]
		private bool _TriggerPopup(UIStateAutoPopupController.PopupItem popup)
		{
			return default(bool);
		}

		// Token: 0x06016D26 RID: 93478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D26")]
		[Address(RVA = "0xF529E0", Offset = "0xF515E0", VA = "0x180F529E0")]
		protected UIStateAutoPopupController()
		{
		}

		// Token: 0x0401B84D RID: 112717
		[Token(Token = "0x401B84D")]
		[FieldOffset(Offset = "0x10")]
		private Func<UIStateAutoPopupController.PopupItem, bool> m_handlerFuc;

		// Token: 0x0401B84E RID: 112718
		[Token(Token = "0x401B84E")]
		[FieldOffset(Offset = "0x18")]
		private Queue<UIStateAutoPopupController.PopupItem> m_items;

		// Token: 0x0401B84F RID: 112719
		[Token(Token = "0x401B84F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0401B850 RID: 112720
		[Token(Token = "0x401B850")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddEvent;

		// Token: 0x0401B851 RID: 112721
		[Token(Token = "0x401B851")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TriggerPopup;

		// Token: 0x0401B852 RID: 112722
		[Token(Token = "0x401B852")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isActive;

		// Token: 0x0401B853 RID: 112723
		[Token(Token = "0x401B853")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TriggerImpl;

		// Token: 0x0401B854 RID: 112724
		[Token(Token = "0x401B854")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryTriggerNextPopup;

		// Token: 0x0401B855 RID: 112725
		[Token(Token = "0x401B855")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TriggerPopupWithItems;

		// Token: 0x0401B856 RID: 112726
		[Token(Token = "0x401B856")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TriggerPopup;

		// Token: 0x0401B857 RID: 112727
		[Token(Token = "0x401B857")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200383F RID: 14399
		[Token(Token = "0x200383F")]
		public struct PopupItem
		{
			// Token: 0x0401B858 RID: 112728
			[Token(Token = "0x401B858")]
			[FieldOffset(Offset = "0x0")]
			public int type;

			// Token: 0x0401B859 RID: 112729
			[Token(Token = "0x401B859")]
			[FieldOffset(Offset = "0x8")]
			public object param;
		}
	}
}
