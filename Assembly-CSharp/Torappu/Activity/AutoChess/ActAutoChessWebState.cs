using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200713E RID: 28990
	[Token(Token = "0x200713E")]
	public class ActAutoChessWebState : UIWebWindowState
	{
		// Token: 0x06029272 RID: 168562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029272")]
		[Address(RVA = "0x248E170", Offset = "0x248CD70", VA = "0x18248E170", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029273 RID: 168563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029273")]
		[Address(RVA = "0x248E1D0", Offset = "0x248CDD0", VA = "0x18248E1D0", Slot = "30")]
		protected override string GetWebWindowType()
		{
			return null;
		}

		// Token: 0x06029274 RID: 168564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029274")]
		[Address(RVA = "0x248E370", Offset = "0x248CF70", VA = "0x18248E370", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06029275 RID: 168565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029275")]
		[Address(RVA = "0x248E4B0", Offset = "0x248D0B0", VA = "0x18248E4B0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06029276 RID: 168566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029276")]
		[Address(RVA = "0x248E5E0", Offset = "0x248D1E0", VA = "0x18248E5E0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06029277 RID: 168567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029277")]
		[Address(RVA = "0x248E720", Offset = "0x248D320", VA = "0x18248E720", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06029278 RID: 168568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029278")]
		[Address(RVA = "0x248E850", Offset = "0x248D450", VA = "0x18248E850")]
		private void _CleanBlurShot()
		{
		}

		// Token: 0x06029279 RID: 168569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029279")]
		[Address(RVA = "0x248E9B0", Offset = "0x248D5B0", VA = "0x18248E9B0")]
		private void _SetupBlurShot()
		{
		}

		// Token: 0x0602927A RID: 168570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602927A")]
		[Address(RVA = "0x248EA60", Offset = "0x248D660", VA = "0x18248EA60")]
		public ActAutoChessWebState()
		{
		}

		// Token: 0x0602927B RID: 168571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602927B")]
		[Address(RVA = "0x121A5A0", Offset = "0x12191A0", VA = "0x18121A5A0")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0602927C RID: 168572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602927C")]
		[Address(RVA = "0x121A5D0", Offset = "0x12191D0", VA = "0x18121A5D0")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x0602927D RID: 168573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602927D")]
		[Address(RVA = "0x121A610", Offset = "0x1219210", VA = "0x18121A610")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0602927E RID: 168574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602927E")]
		[Address(RVA = "0x121A640", Offset = "0x1219240", VA = "0x18121A640")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x0403AC6E RID: 240750
		[Token(Token = "0x403AC6E")]
		private const float FADE_DURATION = 0.23f;

		// Token: 0x0403AC6F RID: 240751
		[Token(Token = "0x403AC6F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _blurImg;

		// Token: 0x0403AC70 RID: 240752
		[Token(Token = "0x403AC70")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _rootView;

		// Token: 0x0403AC71 RID: 240753
		[Token(Token = "0x403AC71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403AC72 RID: 240754
		[Token(Token = "0x403AC72")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetWebWindowType;

		// Token: 0x0403AC73 RID: 240755
		[Token(Token = "0x403AC73")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403AC74 RID: 240756
		[Token(Token = "0x403AC74")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0403AC75 RID: 240757
		[Token(Token = "0x403AC75")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403AC76 RID: 240758
		[Token(Token = "0x403AC76")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0403AC77 RID: 240759
		[Token(Token = "0x403AC77")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CleanBlurShot;

		// Token: 0x0403AC78 RID: 240760
		[Token(Token = "0x403AC78")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetupBlurShot;

		// Token: 0x0403AC79 RID: 240761
		[Token(Token = "0x403AC79")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
