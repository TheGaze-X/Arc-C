using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200772D RID: 30509
	[Token(Token = "0x200772D")]
	public class Act1VHalfIdleDepotPage : StateEnginePage, IDialogMgrHolder
	{
		// Token: 0x1700648B RID: 25739
		// (get) Token: 0x0602ADCC RID: 175564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700648B")]
		public string actId
		{
			[Token(Token = "0x602ADCC")]
			[Address(RVA = "0x26A3FC0", Offset = "0x26A2BC0", VA = "0x1826A3FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602ADCD RID: 175565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADCD")]
		[Address(RVA = "0x26A3EA0", Offset = "0x26A2AA0", VA = "0x1826A3EA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602ADCE RID: 175566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602ADCE")]
		[Address(RVA = "0x26A39C0", Offset = "0x26A25C0", VA = "0x1826A39C0", Slot = "29")]
		public UICompDialogMgr GetDialogMgr()
		{
			return null;
		}

		// Token: 0x0602ADCF RID: 175567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADCF")]
		[Address(RVA = "0x26A3A20", Offset = "0x26A2620", VA = "0x1826A3A20", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602ADD0 RID: 175568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADD0")]
		[Address(RVA = "0x26A3B90", Offset = "0x26A2790", VA = "0x1826A3B90", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602ADD1 RID: 175569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADD1")]
		[Address(RVA = "0x26A3F60", Offset = "0x26A2B60", VA = "0x1826A3F60")]
		public Act1VHalfIdleDepotPage()
		{
		}

		// Token: 0x0602ADD2 RID: 175570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADD2")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x0602ADD3 RID: 175571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ADD3")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x0403DCB3 RID: 253107
		[Token(Token = "0x403DCB3")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0403DCB4 RID: 253108
		[Token(Token = "0x403DCB4")]
		[FieldOffset(Offset = "0xF8")]
		private Act1VHalfIdleDepotPage.Param m_param;

		// Token: 0x0403DCB5 RID: 253109
		[Token(Token = "0x403DCB5")]
		[FieldOffset(Offset = "0x100")]
		private DataBundle m_savedInst;

		// Token: 0x0403DCB6 RID: 253110
		[Token(Token = "0x403DCB6")]
		[FieldOffset(Offset = "0x108")]
		private bool m_inited;

		// Token: 0x0403DCB7 RID: 253111
		[Token(Token = "0x403DCB7")]
		[FieldOffset(Offset = "0x110")]
		private UICompDialogMgr m_dialogMgr;

		// Token: 0x0403DCB8 RID: 253112
		[Token(Token = "0x403DCB8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403DCB9 RID: 253113
		[Token(Token = "0x403DCB9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403DCBA RID: 253114
		[Token(Token = "0x403DCBA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDialogMgr;

		// Token: 0x0403DCBB RID: 253115
		[Token(Token = "0x403DCBB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403DCBC RID: 253116
		[Token(Token = "0x403DCBC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0403DCBD RID: 253117
		[Token(Token = "0x403DCBD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200772E RID: 30510
		[Token(Token = "0x200772E")]
		public class Param
		{
			// Token: 0x0602ADD4 RID: 175572 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602ADD4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x0403DCBE RID: 253118
			[Token(Token = "0x403DCBE")]
			[FieldOffset(Offset = "0x10")]
			public string actId;
		}
	}
}
