using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B59 RID: 7001
	[Token(Token = "0x2001B59")]
	public class UIArchitectureBaseView<T> : PageComponent, IUIArchitectureBaseView, IHotfixable where T : class
	{
		// Token: 0x0600AFCD RID: 45005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFCD")]
		protected override void OnAwake()
		{
		}

		// Token: 0x0600AFCE RID: 45006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFCE")]
		public void Setup(T arg, Func<bool> onConfirm, Action onCancel)
		{
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x0600AFCF RID: 45007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D7")]
		protected T arg
		{
			[Token(Token = "0x600AFCF")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AFD0 RID: 45008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFD0")]
		protected virtual void DoSetup(T arg)
		{
		}

		// Token: 0x0600AFD1 RID: 45009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFD1")]
		public void OnCancelPressed()
		{
		}

		// Token: 0x0600AFD2 RID: 45010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFD2")]
		public void OnConfirmPressed()
		{
		}

		// Token: 0x0600AFD3 RID: 45011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFD3")]
		private void _TweenUpdate(float val)
		{
		}

		// Token: 0x0600AFD4 RID: 45012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFD4")]
		public void ShowView()
		{
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x0600AFD5 RID: 45013 RVA: 0x00043530 File Offset: 0x00041730
		[Token(Token = "0x170014D8")]
		public bool isShowing
		{
			[Token(Token = "0x600AFD5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFD6")]
		public void CloseView()
		{
		}

		// Token: 0x0600AFD7 RID: 45015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFD7")]
		public void CancelView()
		{
		}

		// Token: 0x0600AFD8 RID: 45016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFD8")]
		protected virtual void OnPlayerDataChanged(object _)
		{
		}

		// Token: 0x0600AFD9 RID: 45017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFD9")]
		public UIArchitectureBaseView()
		{
		}

		// Token: 0x0400A9EA RID: 43498
		[Token(Token = "0x400A9EA")]
		[FieldOffset(Offset = "0x0")]
		private T m_arg;

		// Token: 0x0400A9EB RID: 43499
		[Token(Token = "0x400A9EB")]
		[FieldOffset(Offset = "0x0")]
		private Func<bool> m_onConfirm;

		// Token: 0x0400A9EC RID: 43500
		[Token(Token = "0x400A9EC")]
		[FieldOffset(Offset = "0x0")]
		private Action m_onCancel;

		// Token: 0x0400A9ED RID: 43501
		[Token(Token = "0x400A9ED")]
		[FieldOffset(Offset = "0x0")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0400A9EE RID: 43502
		[Token(Token = "0x400A9EE")]
		[FieldOffset(Offset = "0x0")]
		private bool m_isShowing;

		// Token: 0x0400A9EF RID: 43503
		[Token(Token = "0x400A9EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnAwake;

		// Token: 0x0400A9F0 RID: 43504
		[Token(Token = "0x400A9F0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x0400A9F1 RID: 43505
		[Token(Token = "0x400A9F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_arg;

		// Token: 0x0400A9F2 RID: 43506
		[Token(Token = "0x400A9F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetup;

		// Token: 0x0400A9F3 RID: 43507
		[Token(Token = "0x400A9F3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnCancelPressed;

		// Token: 0x0400A9F4 RID: 43508
		[Token(Token = "0x400A9F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnConfirmPressed;

		// Token: 0x0400A9F5 RID: 43509
		[Token(Token = "0x400A9F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TweenUpdate;

		// Token: 0x0400A9F6 RID: 43510
		[Token(Token = "0x400A9F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowView;

		// Token: 0x0400A9F7 RID: 43511
		[Token(Token = "0x400A9F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isShowing;

		// Token: 0x0400A9F8 RID: 43512
		[Token(Token = "0x400A9F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CloseView;

		// Token: 0x0400A9F9 RID: 43513
		[Token(Token = "0x400A9F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CancelView;

		// Token: 0x0400A9FA RID: 43514
		[Token(Token = "0x400A9FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400A9FB RID: 43515
		[Token(Token = "0x400A9FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
