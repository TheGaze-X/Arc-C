using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace HGSDK.UI
{
	// Token: 0x020001C5 RID: 453
	[Token(Token = "0x20001C5")]
	public class SDKUnbindRetState : HGSDKPopupPage.UIState
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x17000110")]
		public override HGSDKPopupPage.PopupState myState
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1AE60D0", Offset = "0x1AE4CD0", VA = "0x181AE60D0", Slot = "13")]
			get
			{
				return HGSDKPopupPage.PopupState.DEFAULT_STATE;
			}
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1AE5A20", Offset = "0x1AE4620", VA = "0x181AE5A20", Slot = "24")]
		public override HGSDKPopupPage.UIState.FloatV2Handler GetFloatV2Handler()
		{
			return default(HGSDKPopupPage.UIState.FloatV2Handler);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1AE5B50", Offset = "0x1AE4750", VA = "0x181AE5B50", Slot = "17")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x1AE5FF0", Offset = "0x1AE4BF0", VA = "0x181AE5FF0")]
		private void _OnViewConfirmed()
		{
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1AE5C90", Offset = "0x1AE4890", VA = "0x181AE5C90")]
		private static string _GetUnbindRecoverNoticeStr(long deleteCommitTs)
		{
			return null;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1AE5960", Offset = "0x1AE4560", VA = "0x181AE5960")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x1AE6070", Offset = "0x1AE4C70", VA = "0x181AE6070")]
		public SDKUnbindRetState()
		{
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x1AE3D60", Offset = "0x1AE2960", VA = "0x181AE3D60")]
		private HGSDKPopupPage.UIState.FloatV2Handler <>xLuaBaseProxy_GetFloatV2Handler()
		{
			return default(HGSDKPopupPage.UIState.FloatV2Handler);
		}

		// Token: 0x060007C8 RID: 1992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1AE0F80", Offset = "0x1ADFB80", VA = "0x181AE0F80")]
		private void <>xLuaBaseProxy_OnEnter(int P0)
		{
		}

		// Token: 0x04000A07 RID: 2567
		[Token(Token = "0x4000A07")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _text;

		// Token: 0x04000A08 RID: 2568
		[Token(Token = "0x4000A08")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isViewConfirmed;

		// Token: 0x04000A09 RID: 2569
		[Token(Token = "0x4000A09")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_myState;

		// Token: 0x04000A0A RID: 2570
		[Token(Token = "0x4000A0A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetFloatV2Handler;

		// Token: 0x04000A0B RID: 2571
		[Token(Token = "0x4000A0B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04000A0C RID: 2572
		[Token(Token = "0x4000A0C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnViewConfirmed;

		// Token: 0x04000A0D RID: 2573
		[Token(Token = "0x4000A0D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetUnbindRecoverNoticeStr;

		// Token: 0x04000A0E RID: 2574
		[Token(Token = "0x4000A0E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x04000A0F RID: 2575
		[Token(Token = "0x4000A0F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020001C6 RID: 454
		[Token(Token = "0x20001C6")]
		public class Param
		{
			// Token: 0x060007C9 RID: 1993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x04000A10 RID: 2576
			[Token(Token = "0x4000A10")]
			[FieldOffset(Offset = "0x10")]
			public UnbindGrantResponse response;
		}
	}
}
