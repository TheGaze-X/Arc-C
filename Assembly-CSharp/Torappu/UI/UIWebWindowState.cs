using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020038B9 RID: 14521
	[Token(Token = "0x20038B9")]
	public abstract class UIWebWindowState : UIPopupState
	{
		// Token: 0x06016F72 RID: 94066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F72")]
		[Address(RVA = "0xF800C0", Offset = "0xF7ECC0", VA = "0x180F800C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06016F73 RID: 94067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F73")]
		[Address(RVA = "0xF80210", Offset = "0xF7EE10", VA = "0x180F80210", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06016F74 RID: 94068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F74")]
		[Address(RVA = "0xF801A0", Offset = "0xF7EDA0", VA = "0x180F801A0", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x06016F75 RID: 94069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F75")]
		[Address(RVA = "0xF80130", Offset = "0xF7ED30", VA = "0x180F80130", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06016F76 RID: 94070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F76")]
		[Address(RVA = "0xF80060", Offset = "0xF7EC60", VA = "0x180F80060", Slot = "29")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06016F77 RID: 94071
		[Token(Token = "0x6016F77")]
		protected abstract string GetWebWindowType();

		// Token: 0x06016F78 RID: 94072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F78")]
		[Address(RVA = "0xF7FDD0", Offset = "0xF7E9D0", VA = "0x180F7FDD0", Slot = "31")]
		protected virtual Dictionary<string, string> GetQuery()
		{
			return null;
		}

		// Token: 0x06016F79 RID: 94073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F79")]
		[Address(RVA = "0xF7FD10", Offset = "0xF7E910", VA = "0x180F7FD10", Slot = "32")]
		protected virtual string GetFragment()
		{
			return null;
		}

		// Token: 0x06016F7A RID: 94074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F7A")]
		[Address(RVA = "0xF7FD70", Offset = "0xF7E970", VA = "0x180F7FD70", Slot = "33")]
		protected virtual Dictionary<string, string> GetParam()
		{
			return null;
		}

		// Token: 0x06016F7B RID: 94075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F7B")]
		[Address(RVA = "0xF803B0", Offset = "0xF7EFB0", VA = "0x180F803B0", Slot = "34")]
		protected virtual string ParserWebParam()
		{
			return null;
		}

		// Token: 0x06016F7C RID: 94076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F7C")]
		[Address(RVA = "0xF80310", Offset = "0xF7EF10", VA = "0x180F80310", Slot = "35")]
		protected virtual void OnWebOpenFailed(UIWebWindow.OpenRet ret)
		{
		}

		// Token: 0x06016F7D RID: 94077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F7D")]
		[Address(RVA = "0xF80290", Offset = "0xF7EE90", VA = "0x180F80290", Slot = "36")]
		protected virtual void OnWebMessage(UIWebScheme msg)
		{
		}

		// Token: 0x06016F7E RID: 94078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F7E")]
		[Address(RVA = "0xF80D40", Offset = "0xF7F940", VA = "0x180F80D40")]
		private void _OpenWebWindow()
		{
		}

		// Token: 0x06016F7F RID: 94079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F7F")]
		[Address(RVA = "0xF80960", Offset = "0xF7F560", VA = "0x180F80960")]
		private void _CloseWebWindowInLifecycle()
		{
		}

		// Token: 0x06016F80 RID: 94080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F80")]
		[Address(RVA = "0xF809E0", Offset = "0xF7F5E0", VA = "0x180F809E0")]
		private void _DriveStateToClose()
		{
		}

		// Token: 0x06016F81 RID: 94081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F81")]
		[Address(RVA = "0xF808B0", Offset = "0xF7F4B0", VA = "0x180F808B0")]
		private IEnumerator _CloseStateCoroutine()
		{
			return null;
		}

		// Token: 0x06016F82 RID: 94082 RVA: 0x00094278 File Offset: 0x00092478
		[Token(Token = "0x6016F82")]
		[Address(RVA = "0xF807E0", Offset = "0xF7F3E0", VA = "0x180F807E0")]
		private bool _CheckIfDestroyed()
		{
			return default(bool);
		}

		// Token: 0x06016F83 RID: 94083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F83")]
		[Address(RVA = "0xF80C20", Offset = "0xF7F820", VA = "0x180F80C20")]
		private void _OnWebOpenFailed()
		{
		}

		// Token: 0x06016F84 RID: 94084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F84")]
		[Address(RVA = "0xF80AE0", Offset = "0xF7F6E0", VA = "0x180F80AE0")]
		private void _OnWebClosed()
		{
		}

		// Token: 0x06016F85 RID: 94085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F85")]
		[Address(RVA = "0xF80CA0", Offset = "0xF7F8A0", VA = "0x180F80CA0")]
		private void _OnWebOpenRet(UIWebWindow.OpenRet ret)
		{
		}

		// Token: 0x06016F86 RID: 94086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F86")]
		[Address(RVA = "0xF80B60", Offset = "0xF7F760", VA = "0x180F80B60")]
		private void _OnWebMessage(UIWebScheme msg)
		{
		}

		// Token: 0x06016F87 RID: 94087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F87")]
		[Address(RVA = "0xF7FE30", Offset = "0xF7EA30", VA = "0x180F7FE30", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06016F88 RID: 94088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F88")]
		[Address(RVA = "0xF7FF70", Offset = "0xF7EB70", VA = "0x180F7FF70", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06016F89 RID: 94089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016F89")]
		[Address(RVA = "0xF80420", Offset = "0xF7F020", VA = "0x180F80420", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06016F8A RID: 94090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F8A")]
		[Address(RVA = "0xF80560", Offset = "0xF7F160", VA = "0x180F80560", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x06016F8B RID: 94091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F8B")]
		[Address(RVA = "0xF7FB10", Offset = "0xF7E710", VA = "0x180F7FB10", Slot = "27")]
		protected override void DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x06016F8C RID: 94092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F8C")]
		[Address(RVA = "0xF7FC10", Offset = "0xF7E810", VA = "0x180F7FC10", Slot = "28")]
		protected override void DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext context, bool isFastMode)
		{
		}

		// Token: 0x06016F8D RID: 94093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F8D")]
		[Address(RVA = "0xF80650", Offset = "0xF7F250", VA = "0x180F80650")]
		protected void ToastText(string message, UIWebWindowState.ToastLevel level = UIWebWindowState.ToastLevel.INFO)
		{
		}

		// Token: 0x06016F8E RID: 94094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F8E")]
		[Address(RVA = "0xF811A0", Offset = "0xF7FDA0", VA = "0x180F811A0")]
		protected UIWebWindowState()
		{
		}

		// Token: 0x06016F8F RID: 94095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F8F")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06016F90 RID: 94096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F90")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x06016F91 RID: 94097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F91")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x06016F92 RID: 94098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F92")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06016F93 RID: 94099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F93")]
		[Address(RVA = "0xF80770", Offset = "0xF7F370", VA = "0x180F80770")]
		private void <>xLuaBaseProxy_DealWithOtherStateBeforeTransStart(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x06016F94 RID: 94100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016F94")]
		[Address(RVA = "0xF807A0", Offset = "0xF7F3A0", VA = "0x180F807A0")]
		private void <>xLuaBaseProxy_DealWithOtherStateWenTransEnd(UIPopupState.TransactionContext P0, bool P1)
		{
		}

		// Token: 0x0401BBA1 RID: 113569
		[Token(Token = "0x401BBA1")]
		[FieldOffset(Offset = "0x60")]
		private UIWebWindow m_window;

		// Token: 0x0401BBA2 RID: 113570
		[Token(Token = "0x401BBA2")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine m_closeCoroutine;

		// Token: 0x0401BBA3 RID: 113571
		[Token(Token = "0x401BBA3")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isWebClosedByLifecycle;

		// Token: 0x0401BBA4 RID: 113572
		[Token(Token = "0x401BBA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0401BBA5 RID: 113573
		[Token(Token = "0x401BBA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0401BBA6 RID: 113574
		[Token(Token = "0x401BBA6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0401BBA7 RID: 113575
		[Token(Token = "0x401BBA7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0401BBA8 RID: 113576
		[Token(Token = "0x401BBA8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401BBA9 RID: 113577
		[Token(Token = "0x401BBA9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetQuery;

		// Token: 0x0401BBAA RID: 113578
		[Token(Token = "0x401BBAA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetFragment;

		// Token: 0x0401BBAB RID: 113579
		[Token(Token = "0x401BBAB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetParam;

		// Token: 0x0401BBAC RID: 113580
		[Token(Token = "0x401BBAC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ParserWebParam;

		// Token: 0x0401BBAD RID: 113581
		[Token(Token = "0x401BBAD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnWebOpenFailed;

		// Token: 0x0401BBAE RID: 113582
		[Token(Token = "0x401BBAE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnWebMessage;

		// Token: 0x0401BBAF RID: 113583
		[Token(Token = "0x401BBAF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OpenWebWindow;

		// Token: 0x0401BBB0 RID: 113584
		[Token(Token = "0x401BBB0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CloseWebWindowInLifecycle;

		// Token: 0x0401BBB1 RID: 113585
		[Token(Token = "0x401BBB1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DriveStateToClose;

		// Token: 0x0401BBB2 RID: 113586
		[Token(Token = "0x401BBB2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CloseStateCoroutine;

		// Token: 0x0401BBB3 RID: 113587
		[Token(Token = "0x401BBB3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CheckIfDestroyed;

		// Token: 0x0401BBB4 RID: 113588
		[Token(Token = "0x401BBB4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnWebOpenFailed;

		// Token: 0x0401BBB5 RID: 113589
		[Token(Token = "0x401BBB5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnWebClosed;

		// Token: 0x0401BBB6 RID: 113590
		[Token(Token = "0x401BBB6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnWebOpenRet;

		// Token: 0x0401BBB7 RID: 113591
		[Token(Token = "0x401BBB7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnWebMessage;

		// Token: 0x0401BBB8 RID: 113592
		[Token(Token = "0x401BBB8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0401BBB9 RID: 113593
		[Token(Token = "0x401BBB9")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x0401BBBA RID: 113594
		[Token(Token = "0x401BBBA")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0401BBBB RID: 113595
		[Token(Token = "0x401BBBB")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x0401BBBC RID: 113596
		[Token(Token = "0x401BBBC")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateBeforeTransStart;

		// Token: 0x0401BBBD RID: 113597
		[Token(Token = "0x401BBBD")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_DealWithOtherStateWenTransEnd;

		// Token: 0x0401BBBE RID: 113598
		[Token(Token = "0x401BBBE")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_ToastText;

		// Token: 0x0401BBBF RID: 113599
		[Token(Token = "0x401BBBF")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020038BA RID: 14522
		[Token(Token = "0x20038BA")]
		protected enum ToastLevel
		{
			// Token: 0x0401BBC1 RID: 113601
			[Token(Token = "0x401BBC1")]
			INFO,
			// Token: 0x0401BBC2 RID: 113602
			[Token(Token = "0x401BBC2")]
			WARN,
			// Token: 0x0401BBC3 RID: 113603
			[Token(Token = "0x401BBC3")]
			ERROR
		}
	}
}
