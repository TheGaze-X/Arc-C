using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007310 RID: 29456
	[Token(Token = "0x2007310")]
	public class Act42sideGunTaskPage : StateEnginePage, ICompDialogCallBack, IHotfixable
	{
		// Token: 0x17006272 RID: 25202
		// (get) Token: 0x06029A90 RID: 170640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006272")]
		public string actId
		{
			[Token(Token = "0x6029A90")]
			[Address(RVA = "0x2519540", Offset = "0x2518140", VA = "0x182519540")]
			get
			{
				return null;
			}
		}

		// Token: 0x17006273 RID: 25203
		// (get) Token: 0x06029A91 RID: 170641 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006273")]
		public UICompDialogMgr dialogMgr
		{
			[Token(Token = "0x6029A91")]
			[Address(RVA = "0x2519620", Offset = "0x2518220", VA = "0x182519620")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029A92 RID: 170642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A92")]
		[Address(RVA = "0x2518F10", Offset = "0x2517B10", VA = "0x182518F10", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x06029A93 RID: 170643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A93")]
		[Address(RVA = "0x2519090", Offset = "0x2517C90", VA = "0x182519090", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x06029A94 RID: 170644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A94")]
		[Address(RVA = "0x2518DA0", Offset = "0x25179A0", VA = "0x182518DA0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x06029A95 RID: 170645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A95")]
		[Address(RVA = "0x2518E60", Offset = "0x2517A60", VA = "0x182518E60", Slot = "29")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06029A96 RID: 170646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A96")]
		[Address(RVA = "0x25191B0", Offset = "0x2517DB0", VA = "0x1825191B0")]
		public void OpenTokenDetailDlg()
		{
		}

		// Token: 0x06029A97 RID: 170647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A97")]
		[Address(RVA = "0x2519390", Offset = "0x2517F90", VA = "0x182519390")]
		private void _OnBackImpl()
		{
		}

		// Token: 0x06029A98 RID: 170648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A98")]
		[Address(RVA = "0x25194E0", Offset = "0x25180E0", VA = "0x1825194E0")]
		public Act42sideGunTaskPage()
		{
		}

		// Token: 0x06029A9A RID: 170650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A9A")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06029A9B RID: 170651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A9B")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x06029A9C RID: 170652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029A9C")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0403B982 RID: 244098
		[Token(Token = "0x403B982")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x0403B983 RID: 244099
		[Token(Token = "0x403B983")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private RectTransform _topMenuHolder;

		// Token: 0x0403B984 RID: 244100
		[Token(Token = "0x403B984")]
		[FieldOffset(Offset = "0x100")]
		private Act42sideGunTaskPage.Params m_param;

		// Token: 0x0403B985 RID: 244101
		[Token(Token = "0x403B985")]
		[FieldOffset(Offset = "0x108")]
		private DataBundle m_savedInst;

		// Token: 0x0403B986 RID: 244102
		[Token(Token = "0x403B986")]
		[FieldOffset(Offset = "0x110")]
		private UICompDialogMgr m_diaglogMgr;

		// Token: 0x0403B987 RID: 244103
		[Token(Token = "0x403B987")]
		[FieldOffset(Offset = "0x118")]
		private int m_tokenDlgInst;

		// Token: 0x0403B988 RID: 244104
		[Token(Token = "0x403B988")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x0403B989 RID: 244105
		[Token(Token = "0x403B989")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_dialogMgr;

		// Token: 0x0403B98A RID: 244106
		[Token(Token = "0x403B98A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0403B98B RID: 244107
		[Token(Token = "0x403B98B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x0403B98C RID: 244108
		[Token(Token = "0x403B98C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0403B98D RID: 244109
		[Token(Token = "0x403B98D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0403B98E RID: 244110
		[Token(Token = "0x403B98E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OpenTokenDetailDlg;

		// Token: 0x0403B98F RID: 244111
		[Token(Token = "0x403B98F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBackImpl;

		// Token: 0x0403B990 RID: 244112
		[Token(Token = "0x403B990")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007311 RID: 29457
		[Token(Token = "0x2007311")]
		public class Params : IHotfixable
		{
			// Token: 0x06029A9D RID: 170653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029A9D")]
			[Address(RVA = "0x251BBD0", Offset = "0x251A7D0", VA = "0x18251BBD0")]
			public Params()
			{
			}

			// Token: 0x0403B991 RID: 244113
			[Token(Token = "0x403B991")]
			[FieldOffset(Offset = "0x10")]
			public string actId;

			// Token: 0x0403B992 RID: 244114
			[Token(Token = "0x403B992")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
