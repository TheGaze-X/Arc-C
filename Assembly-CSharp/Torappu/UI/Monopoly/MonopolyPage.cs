using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x02004825 RID: 18469
	[Token(Token = "0x2004825")]
	public class MonopolyPage : StateEnginePage, IDialogMgrHolder
	{
		// Token: 0x17004253 RID: 16979
		// (get) Token: 0x0601BEB3 RID: 114355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004253")]
		public string actId
		{
			[Token(Token = "0x601BEB3")]
			[Address(RVA = "0x155B3E0", Offset = "0x1559FE0", VA = "0x18155B3E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004254 RID: 16980
		// (get) Token: 0x0601BEB4 RID: 114356 RVA: 0x000A6A28 File Offset: 0x000A4C28
		[Token(Token = "0x17004254")]
		public bool shouldOpenBuffDialog
		{
			[Token(Token = "0x601BEB4")]
			[Address(RVA = "0x155B440", Offset = "0x155A040", VA = "0x18155B440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601BEB5 RID: 114357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEB5")]
		[Address(RVA = "0x155B260", Offset = "0x1559E60", VA = "0x18155B260", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0601BEB6 RID: 114358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BEB6")]
		[Address(RVA = "0x155B1B0", Offset = "0x1559DB0", VA = "0x18155B1B0", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0601BEB7 RID: 114359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BEB7")]
		[Address(RVA = "0x155B150", Offset = "0x1559D50", VA = "0x18155B150", Slot = "29")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x0601BEB8 RID: 114360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEB8")]
		[Address(RVA = "0x155B380", Offset = "0x1559F80", VA = "0x18155B380")]
		public MonopolyPage()
		{
		}

		// Token: 0x0601BEBA RID: 114362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BEBA")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0601BEBB RID: 114363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601BEBB")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x04024661 RID: 149089
		[Token(Token = "0x4024661")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x04024662 RID: 149090
		[Token(Token = "0x4024662")]
		[FieldOffset(Offset = "0xF8")]
		private string m_actId;

		// Token: 0x04024663 RID: 149091
		[Token(Token = "0x4024663")]
		[FieldOffset(Offset = "0x100")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x04024664 RID: 149092
		[Token(Token = "0x4024664")]
		[FieldOffset(Offset = "0x108")]
		private bool m_shouldOpenBuffDialog;

		// Token: 0x04024665 RID: 149093
		[Token(Token = "0x4024665")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x04024666 RID: 149094
		[Token(Token = "0x4024666")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_shouldOpenBuffDialog;

		// Token: 0x04024667 RID: 149095
		[Token(Token = "0x4024667")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04024668 RID: 149096
		[Token(Token = "0x4024668")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04024669 RID: 149097
		[Token(Token = "0x4024669")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x0402466A RID: 149098
		[Token(Token = "0x402466A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004826 RID: 18470
		[Token(Token = "0x2004826")]
		public class Input
		{
			// Token: 0x0601BEBC RID: 114364 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601BEBC")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0402466B RID: 149099
			[Token(Token = "0x402466B")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0402466C RID: 149100
			[Token(Token = "0x402466C")]
			[FieldOffset(Offset = "0x18")]
			public bool shouldOpenBuffDialog;
		}
	}
}
