using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004A84 RID: 19076
	[Token(Token = "0x2004A84")]
	public class NetworkErrorDisplayer : IHotfixable
	{
		// Token: 0x0601CAAE RID: 117422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAAE")]
		[Address(RVA = "0x162EFA0", Offset = "0x162DBA0", VA = "0x18162EFA0")]
		public NetworkErrorDisplayer(NetworkErrorDisplayer.Options options)
		{
		}

		// Token: 0x0601CAAF RID: 117423 RVA: 0x000A9050 File Offset: 0x000A7250
		[Token(Token = "0x601CAAF")]
		[Address(RVA = "0x162DD70", Offset = "0x162C970", VA = "0x18162DD70")]
		public bool ReadyToShow()
		{
			return default(bool);
		}

		// Token: 0x0601CAB0 RID: 117424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAB0")]
		[Address(RVA = "0x162DDD0", Offset = "0x162C9D0", VA = "0x18162DDD0")]
		public void Show()
		{
		}

		// Token: 0x0601CAB1 RID: 117425 RVA: 0x000A9068 File Offset: 0x000A7268
		[Token(Token = "0x601CAB1")]
		[Address(RVA = "0x162DD10", Offset = "0x162C910", VA = "0x18162DD10")]
		public bool IsClosed()
		{
			return default(bool);
		}

		// Token: 0x0601CAB2 RID: 117426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAB2")]
		[Address(RVA = "0x162EBB0", Offset = "0x162D7B0", VA = "0x18162EBB0")]
		private void _ToState(NetworkErrorDisplayer.State target)
		{
		}

		// Token: 0x0601CAB3 RID: 117427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAB3")]
		[Address(RVA = "0x162E1A0", Offset = "0x162CDA0", VA = "0x18162E1A0")]
		private void _DoShowErrorAlert()
		{
		}

		// Token: 0x0601CAB4 RID: 117428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAB4")]
		[Address(RVA = "0x162E6E0", Offset = "0x162D2E0", VA = "0x18162E6E0")]
		private void _OnCreateAlertView(RectTransform parent)
		{
		}

		// Token: 0x0601CAB5 RID: 117429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAB5")]
		[Address(RVA = "0x162DF00", Offset = "0x162CB00", VA = "0x18162DF00")]
		private void _DoShowConfirmDialog()
		{
		}

		// Token: 0x0601CAB6 RID: 117430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAB6")]
		[Address(RVA = "0x162E420", Offset = "0x162D020", VA = "0x18162E420")]
		private void _DoShowNetCheckView()
		{
		}

		// Token: 0x0601CAB7 RID: 117431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAB7")]
		[Address(RVA = "0x162DE80", Offset = "0x162CA80", VA = "0x18162DE80")]
		private void _DoFinishWholeProcess()
		{
		}

		// Token: 0x0601CAB8 RID: 117432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAB8")]
		[Address(RVA = "0x162E560", Offset = "0x162D160", VA = "0x18162E560")]
		private void _OnAlertClosed()
		{
		}

		// Token: 0x0601CAB9 RID: 117433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CAB9")]
		[Address(RVA = "0x162E930", Offset = "0x162D530", VA = "0x18162E930")]
		private void _OnNetCheckClicked()
		{
		}

		// Token: 0x0601CABA RID: 117434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CABA")]
		[Address(RVA = "0x162E660", Offset = "0x162D260", VA = "0x18162E660")]
		private void _OnCheckConfirmPositive()
		{
		}

		// Token: 0x0601CABB RID: 117435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CABB")]
		[Address(RVA = "0x162E5E0", Offset = "0x162D1E0", VA = "0x18162E5E0")]
		private void _OnCheckConfirmNegative()
		{
		}

		// Token: 0x0601CABC RID: 117436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CABC")]
		[Address(RVA = "0x162E9A0", Offset = "0x162D5A0", VA = "0x18162E9A0")]
		private void _OnNetCheckClosed()
		{
		}

		// Token: 0x0601CABD RID: 117437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CABD")]
		[Address(RVA = "0x162EA10", Offset = "0x162D610", VA = "0x18162EA10")]
		private void _OnStateChanged(NetworkErrorDisplayer.State from, NetworkErrorDisplayer.State to)
		{
		}

		// Token: 0x040259F6 RID: 154102
		[Token(Token = "0x40259F6")]
		[FieldOffset(Offset = "0x10")]
		private NetworkErrorDisplayer.State m_state;

		// Token: 0x040259F7 RID: 154103
		[Token(Token = "0x40259F7")]
		[FieldOffset(Offset = "0x18")]
		private string m_errorMsg;

		// Token: 0x040259F8 RID: 154104
		[Token(Token = "0x40259F8")]
		[FieldOffset(Offset = "0x20")]
		private HotUpdateNetCheckView m_checkPrefab;

		// Token: 0x040259F9 RID: 154105
		[Token(Token = "0x40259F9")]
		[FieldOffset(Offset = "0x28")]
		private HotUpdateNetErrorAlert m_alertPrefab;

		// Token: 0x040259FA RID: 154106
		[Token(Token = "0x40259FA")]
		[FieldOffset(Offset = "0x30")]
		private Action m_callback;

		// Token: 0x040259FB RID: 154107
		[Token(Token = "0x40259FB")]
		[FieldOffset(Offset = "0x38")]
		private NetworkErrorDisplayer.State m_initState;

		// Token: 0x040259FC RID: 154108
		[Token(Token = "0x40259FC")]
		[FieldOffset(Offset = "0x40")]
		private UIOKDialog m_alertDialog;

		// Token: 0x040259FD RID: 154109
		[Token(Token = "0x40259FD")]
		[FieldOffset(Offset = "0x48")]
		private UIJudgeDialog m_confirmDialog;

		// Token: 0x040259FE RID: 154110
		[Token(Token = "0x40259FE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040259FF RID: 154111
		[Token(Token = "0x40259FF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ReadyToShow;

		// Token: 0x04025A00 RID: 154112
		[Token(Token = "0x4025A00")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x04025A01 RID: 154113
		[Token(Token = "0x4025A01")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsClosed;

		// Token: 0x04025A02 RID: 154114
		[Token(Token = "0x4025A02")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ToState;

		// Token: 0x04025A03 RID: 154115
		[Token(Token = "0x4025A03")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoShowErrorAlert;

		// Token: 0x04025A04 RID: 154116
		[Token(Token = "0x4025A04")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnCreateAlertView;

		// Token: 0x04025A05 RID: 154117
		[Token(Token = "0x4025A05")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoShowConfirmDialog;

		// Token: 0x04025A06 RID: 154118
		[Token(Token = "0x4025A06")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DoShowNetCheckView;

		// Token: 0x04025A07 RID: 154119
		[Token(Token = "0x4025A07")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DoFinishWholeProcess;

		// Token: 0x04025A08 RID: 154120
		[Token(Token = "0x4025A08")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnAlertClosed;

		// Token: 0x04025A09 RID: 154121
		[Token(Token = "0x4025A09")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnNetCheckClicked;

		// Token: 0x04025A0A RID: 154122
		[Token(Token = "0x4025A0A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnCheckConfirmPositive;

		// Token: 0x04025A0B RID: 154123
		[Token(Token = "0x4025A0B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__OnCheckConfirmNegative;

		// Token: 0x04025A0C RID: 154124
		[Token(Token = "0x4025A0C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__OnNetCheckClosed;

		// Token: 0x04025A0D RID: 154125
		[Token(Token = "0x4025A0D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnStateChanged;

		// Token: 0x02004A85 RID: 19077
		[Token(Token = "0x2004A85")]
		private enum State
		{
			// Token: 0x04025A0F RID: 154127
			[Token(Token = "0x4025A0F")]
			NONE,
			// Token: 0x04025A10 RID: 154128
			[Token(Token = "0x4025A10")]
			ALERT,
			// Token: 0x04025A11 RID: 154129
			[Token(Token = "0x4025A11")]
			CONFIRM,
			// Token: 0x04025A12 RID: 154130
			[Token(Token = "0x4025A12")]
			CHECK,
			// Token: 0x04025A13 RID: 154131
			[Token(Token = "0x4025A13")]
			DISPOSED
		}

		// Token: 0x02004A86 RID: 19078
		[Token(Token = "0x2004A86")]
		public struct Options
		{
			// Token: 0x04025A14 RID: 154132
			[Token(Token = "0x4025A14")]
			[FieldOffset(Offset = "0x0")]
			public string errorInfo;

			// Token: 0x04025A15 RID: 154133
			[Token(Token = "0x4025A15")]
			[FieldOffset(Offset = "0x8")]
			public HotUpdateNetCheckView checkPrefab;

			// Token: 0x04025A16 RID: 154134
			[Token(Token = "0x4025A16")]
			[FieldOffset(Offset = "0x10")]
			public HotUpdateNetErrorAlert alertPrefab;

			// Token: 0x04025A17 RID: 154135
			[Token(Token = "0x4025A17")]
			[FieldOffset(Offset = "0x18")]
			public Action callback;

			// Token: 0x04025A18 RID: 154136
			[Token(Token = "0x4025A18")]
			[FieldOffset(Offset = "0x20")]
			public bool onlyShowCheckPanel;
		}
	}
}
