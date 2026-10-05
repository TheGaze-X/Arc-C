using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003728 RID: 14120
	[Token(Token = "0x2003728")]
	public class UIItemDescDialog : UICustomDialog<UIItemDescDialog.Options>, IValueMsgReceiver
	{
		// Token: 0x060166D6 RID: 91862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166D6")]
		[Address(RVA = "0xEE4A20", Offset = "0xEE3620", VA = "0x180EE4A20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060166D7 RID: 91863 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60166D7")]
		[Address(RVA = "0xEE4600", Offset = "0xEE3200", VA = "0x180EE4600", Slot = "12")]
		protected override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x060166D8 RID: 91864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166D8")]
		[Address(RVA = "0xEE48B0", Offset = "0xEE34B0", VA = "0x180EE48B0", Slot = "7")]
		protected override void OnRender(UIItemDescDialog.Options options)
		{
		}

		// Token: 0x060166D9 RID: 91865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166D9")]
		[Address(RVA = "0xEE47F0", Offset = "0xEE33F0", VA = "0x180EE47F0", Slot = "14")]
		public void OnMessage(int msg, ValueBundle param)
		{
		}

		// Token: 0x060166DA RID: 91866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166DA")]
		[Address(RVA = "0xEE4C90", Offset = "0xEE3890", VA = "0x180EE4C90")]
		private void _OnCloseFloatPanel(UIItemDescFloat.ClosePanelRequest request)
		{
		}

		// Token: 0x060166DB RID: 91867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166DB")]
		[Address(RVA = "0xEE4D40", Offset = "0xEE3940", VA = "0x180EE4D40")]
		private void _OnFloatRouteToItemDropInfo()
		{
		}

		// Token: 0x060166DC RID: 91868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60166DC")]
		[Address(RVA = "0xEE4DB0", Offset = "0xEE39B0", VA = "0x180EE4DB0")]
		public UIItemDescDialog()
		{
		}

		// Token: 0x0401AFD2 RID: 110546
		[Token(Token = "0x401AFD2")]
		public const int MSG_CLOSE = 1;

		// Token: 0x0401AFD3 RID: 110547
		[Token(Token = "0x401AFD3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _floatHolder;

		// Token: 0x0401AFD4 RID: 110548
		[Token(Token = "0x401AFD4")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _descBound;

		// Token: 0x0401AFD5 RID: 110549
		[Token(Token = "0x401AFD5")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x0401AFD6 RID: 110550
		[Token(Token = "0x401AFD6")]
		[FieldOffset(Offset = "0x68")]
		private UIItemDescViewModel m_viewModel;

		// Token: 0x0401AFD7 RID: 110551
		[Token(Token = "0x401AFD7")]
		[FieldOffset(Offset = "0x70")]
		private UIItemDescFloat m_floatInst;

		// Token: 0x0401AFD8 RID: 110552
		[Token(Token = "0x401AFD8")]
		[FieldOffset(Offset = "0x78")]
		private DefaultDialogSwitchTween m_switchTween;

		// Token: 0x0401AFD9 RID: 110553
		[Token(Token = "0x401AFD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401AFDA RID: 110554
		[Token(Token = "0x401AFDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x0401AFDB RID: 110555
		[Token(Token = "0x401AFDB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401AFDC RID: 110556
		[Token(Token = "0x401AFDC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0401AFDD RID: 110557
		[Token(Token = "0x401AFDD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCloseFloatPanel;

		// Token: 0x0401AFDE RID: 110558
		[Token(Token = "0x401AFDE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnFloatRouteToItemDropInfo;

		// Token: 0x0401AFDF RID: 110559
		[Token(Token = "0x401AFDF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003729 RID: 14121
		[Token(Token = "0x2003729")]
		public struct Options
		{
			// Token: 0x0401AFE0 RID: 110560
			[Token(Token = "0x401AFE0")]
			[FieldOffset(Offset = "0x0")]
			public GameObject itemView;

			// Token: 0x0401AFE1 RID: 110561
			[Token(Token = "0x401AFE1")]
			[FieldOffset(Offset = "0x8")]
			public UIItemViewModel itemModel;

			// Token: 0x0401AFE2 RID: 110562
			[Token(Token = "0x401AFE2")]
			[FieldOffset(Offset = "0x10")]
			public float itemViewScaling;

			// Token: 0x0401AFE3 RID: 110563
			[Token(Token = "0x401AFE3")]
			[FieldOffset(Offset = "0x14")]
			public bool enableDropRoute;
		}
	}
}
