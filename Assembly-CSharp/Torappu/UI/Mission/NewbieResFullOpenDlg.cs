using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x0200486C RID: 18540
	[Token(Token = "0x200486C")]
	public class NewbieResFullOpenDlg : UICompDialog<NewbieResFullOpenDlg.Input>
	{
		// Token: 0x0601C000 RID: 114688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C000")]
		[Address(RVA = "0x155ED40", Offset = "0x155D940", VA = "0x18155ED40", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601C001 RID: 114689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C001")]
		[Address(RVA = "0x155EDA0", Offset = "0x155D9A0", VA = "0x18155EDA0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601C002 RID: 114690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C002")]
		[Address(RVA = "0x155EEE0", Offset = "0x155DAE0", VA = "0x18155EEE0", Slot = "18")]
		protected override void OnRender(NewbieResFullOpenDlg.Input input)
		{
		}

		// Token: 0x0601C003 RID: 114691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C003")]
		[Address(RVA = "0x155EFB0", Offset = "0x155DBB0", VA = "0x18155EFB0")]
		private void _EventOnClose()
		{
		}

		// Token: 0x0601C004 RID: 114692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C004")]
		[Address(RVA = "0x155EC50", Offset = "0x155D850", VA = "0x18155EC50")]
		public void EventOnCloseClick()
		{
		}

		// Token: 0x0601C005 RID: 114693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C005")]
		[Address(RVA = "0x155F070", Offset = "0x155DC70", VA = "0x18155F070")]
		public NewbieResFullOpenDlg()
		{
		}

		// Token: 0x0601C006 RID: 114694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C006")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0601C007 RID: 114695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C007")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04024861 RID: 149601
		[Token(Token = "0x4024861")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backRt;

		// Token: 0x04024862 RID: 149602
		[Token(Token = "0x4024862")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private NewbieResFullOpenView _view;

		// Token: 0x04024863 RID: 149603
		[Token(Token = "0x4024863")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x04024864 RID: 149604
		[Token(Token = "0x4024864")]
		[FieldOffset(Offset = "0x88")]
		private NewbieResFullOpenProp m_prop;

		// Token: 0x04024865 RID: 149605
		[Token(Token = "0x4024865")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x04024866 RID: 149606
		[Token(Token = "0x4024866")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04024867 RID: 149607
		[Token(Token = "0x4024867")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04024868 RID: 149608
		[Token(Token = "0x4024868")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnClose;

		// Token: 0x04024869 RID: 149609
		[Token(Token = "0x4024869")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnCloseClick;

		// Token: 0x0402486A RID: 149610
		[Token(Token = "0x402486A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200486D RID: 18541
		[Token(Token = "0x200486D")]
		public class Input
		{
			// Token: 0x0601C008 RID: 114696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C008")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}
		}
	}
}
