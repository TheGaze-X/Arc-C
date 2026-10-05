using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A68 RID: 14952
	[Token(Token = "0x2003A68")]
	public abstract class UICompDialog<TInput> : UICompDialogMgr.DialogBase where TInput : class
	{
		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x06017A50 RID: 96848 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06017A51 RID: 96849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170038C7")]
		private protected TInput input
		{
			[Token(Token = "0x6017A50")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6017A51")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06017A52 RID: 96850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A52")]
		protected sealed override void OnSetInput(object input)
		{
		}

		// Token: 0x06017A53 RID: 96851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A53")]
		protected sealed override void OnBecomeVisible()
		{
		}

		// Token: 0x06017A54 RID: 96852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A54")]
		private void _InvokeRender()
		{
		}

		// Token: 0x06017A55 RID: 96853
		[Token(Token = "0x6017A55")]
		protected abstract void OnRender(TInput input);

		// Token: 0x06017A56 RID: 96854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A56")]
		public void OnConfirmWithHide(ValueBundle outPut)
		{
		}

		// Token: 0x06017A57 RID: 96855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A57")]
		public void OnConfirmWithHide()
		{
		}

		// Token: 0x06017A58 RID: 96856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017A58")]
		protected UICompDialog()
		{
		}

		// Token: 0x0401C88B RID: 116875
		[Token(Token = "0x401C88B")]
		[FieldOffset(Offset = "0x0")]
		private LatchUtils.InvokeWhenUnlock m_visibleLock;

		// Token: 0x0401C88C RID: 116876
		[Token(Token = "0x401C88C")]
		[FieldOffset(Offset = "0x0")]
		private Action m_renderDelegate;

		// Token: 0x0401C88E RID: 116878
		[Token(Token = "0x401C88E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_input;

		// Token: 0x0401C88F RID: 116879
		[Token(Token = "0x401C88F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_input;

		// Token: 0x0401C890 RID: 116880
		[Token(Token = "0x401C890")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnSetInput;

		// Token: 0x0401C891 RID: 116881
		[Token(Token = "0x401C891")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnBecomeVisible;

		// Token: 0x0401C892 RID: 116882
		[Token(Token = "0x401C892")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InvokeRender;

		// Token: 0x0401C893 RID: 116883
		[Token(Token = "0x401C893")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnConfirmWithHide;

		// Token: 0x0401C894 RID: 116884
		[Token(Token = "0x401C894")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix1_OnConfirmWithHide;

		// Token: 0x0401C895 RID: 116885
		[Token(Token = "0x401C895")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
