using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200559B RID: 21915
	[Token(Token = "0x200559B")]
	public class RL05FreezeCopperDialog : UICompDialog<RL05FreezeCopperDialog.Options>, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x060202F9 RID: 131833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202F9")]
		[Address(RVA = "0x1A521F0", Offset = "0x1A50DF0", VA = "0x181A521F0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x060202FA RID: 131834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202FA")]
		[Address(RVA = "0x1A52490", Offset = "0x1A51090", VA = "0x181A52490", Slot = "18")]
		protected override void OnRender(RL05FreezeCopperDialog.Options input)
		{
		}

		// Token: 0x060202FB RID: 131835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60202FB")]
		[Address(RVA = "0x1A51F80", Offset = "0x1A50B80", VA = "0x181A51F80", Slot = "14")]
		public override UISwitchTween GenerateShowTween()
		{
			return null;
		}

		// Token: 0x060202FC RID: 131836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60202FC")]
		[Address(RVA = "0x1A52080", Offset = "0x1A50C80", VA = "0x181A52080", Slot = "15")]
		protected override UIRenderTextureImage GetBlurTarget()
		{
			return null;
		}

		// Token: 0x060202FD RID: 131837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202FD")]
		[Address(RVA = "0x1A522B0", Offset = "0x1A50EB0", VA = "0x181A522B0", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x060202FE RID: 131838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202FE")]
		[Address(RVA = "0x1A52570", Offset = "0x1A51170", VA = "0x181A52570")]
		private void _EventOnCopperClicked(string instId)
		{
		}

		// Token: 0x060202FF RID: 131839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60202FF")]
		[Address(RVA = "0x1A52670", Offset = "0x1A51270", VA = "0x181A52670")]
		private void _EventOnRefreshClicked()
		{
		}

		// Token: 0x06020300 RID: 131840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020300")]
		[Address(RVA = "0x1A520E0", Offset = "0x1A50CE0", VA = "0x181A520E0", Slot = "20")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x06020301 RID: 131841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020301")]
		[Address(RVA = "0x1A51EC0", Offset = "0x1A50AC0", VA = "0x181A51EC0")]
		public void EventOnBackBtnClicked()
		{
		}

		// Token: 0x06020302 RID: 131842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020302")]
		[Address(RVA = "0x1A52900", Offset = "0x1A51500", VA = "0x181A52900")]
		private void _HandleRedrawCopperResponse(RoguelikeRedrawCopperResponse response)
		{
		}

		// Token: 0x06020303 RID: 131843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020303")]
		[Address(RVA = "0x1A52C20", Offset = "0x1A51820", VA = "0x181A52C20")]
		public RL05FreezeCopperDialog()
		{
		}

		// Token: 0x06020304 RID: 131844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020304")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06020305 RID: 131845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020305")]
		[Address(RVA = "0xE0F010", Offset = "0xE0DC10", VA = "0x180E0F010")]
		private UISwitchTween <>xLuaBaseProxy_GenerateShowTween()
		{
			return null;
		}

		// Token: 0x06020306 RID: 131846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020306")]
		[Address(RVA = "0xE613B0", Offset = "0xE5FFB0", VA = "0x180E613B0")]
		private UIRenderTextureImage <>xLuaBaseProxy_GetBlurTarget()
		{
			return null;
		}

		// Token: 0x0402B81F RID: 178207
		[Token(Token = "0x402B81F")]
		[NonSerialized]
		public const int ON_COPPER_CLICKED = 0;

		// Token: 0x0402B820 RID: 178208
		[Token(Token = "0x402B820")]
		[NonSerialized]
		public const int ON_REFRESH_CLICKED = 1;

		// Token: 0x0402B821 RID: 178209
		[Token(Token = "0x402B821")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIRenderTextureImage _blurBkg;

		// Token: 0x0402B822 RID: 178210
		[Token(Token = "0x402B822")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0402B823 RID: 178211
		[Token(Token = "0x402B823")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RL05FreezeCopperTitleView _titleView;

		// Token: 0x0402B824 RID: 178212
		[Token(Token = "0x402B824")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RL05FreezeCopperListView _listView;

		// Token: 0x0402B825 RID: 178213
		[Token(Token = "0x402B825")]
		[FieldOffset(Offset = "0x90")]
		private RL05FreezeCopperProperty m_property;

		// Token: 0x0402B826 RID: 178214
		[Token(Token = "0x402B826")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402B827 RID: 178215
		[Token(Token = "0x402B827")]
		[FieldOffset(Offset = "0xA8")]
		private int m_redrawCopperDialog;

		// Token: 0x0402B828 RID: 178216
		[Token(Token = "0x402B828")]
		[FieldOffset(Offset = "0xAC")]
		private bool m_showHideAnim;

		// Token: 0x0402B829 RID: 178217
		[Token(Token = "0x402B829")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402B82A RID: 178218
		[Token(Token = "0x402B82A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0402B82B RID: 178219
		[Token(Token = "0x402B82B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateShowTween;

		// Token: 0x0402B82C RID: 178220
		[Token(Token = "0x402B82C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetBlurTarget;

		// Token: 0x0402B82D RID: 178221
		[Token(Token = "0x402B82D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402B82E RID: 178222
		[Token(Token = "0x402B82E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EventOnCopperClicked;

		// Token: 0x0402B82F RID: 178223
		[Token(Token = "0x402B82F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EventOnRefreshClicked;

		// Token: 0x0402B830 RID: 178224
		[Token(Token = "0x402B830")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x0402B831 RID: 178225
		[Token(Token = "0x402B831")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnBackBtnClicked;

		// Token: 0x0402B832 RID: 178226
		[Token(Token = "0x402B832")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__HandleRedrawCopperResponse;

		// Token: 0x0402B833 RID: 178227
		[Token(Token = "0x402B833")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200559C RID: 21916
		[Token(Token = "0x200559C")]
		public class Options
		{
			// Token: 0x06020307 RID: 131847 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020307")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Options()
			{
			}

			// Token: 0x0402B834 RID: 178228
			[Token(Token = "0x402B834")]
			[FieldOffset(Offset = "0x10")]
			public string topicId;
		}

		// Token: 0x0200559D RID: 21917
		[Token(Token = "0x200559D")]
		private class DialogSwitchTween : DefaultDialogSwitchTween
		{
			// Token: 0x06020308 RID: 131848 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020308")]
			[Address(RVA = "0x1A494A0", Offset = "0x1A480A0", VA = "0x181A494A0")]
			public DialogSwitchTween(RL05FreezeCopperDialog closure)
			{
			}

			// Token: 0x06020309 RID: 131849 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020309")]
			[Address(RVA = "0x1A493A0", Offset = "0x1A47FA0", VA = "0x181A493A0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0602030A RID: 131850 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602030A")]
			[Address(RVA = "0x1A49490", Offset = "0x1A48090", VA = "0x181A49490")]
			private UISwitchTween.ITweenHandler <>xLuaBaseProxy_GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0402B835 RID: 178229
			[Token(Token = "0x402B835")]
			[FieldOffset(Offset = "0x58")]
			private RL05FreezeCopperDialog m_closure;

			// Token: 0x0402B836 RID: 178230
			[Token(Token = "0x402B836")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402B837 RID: 178231
			[Token(Token = "0x402B837")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;
		}
	}
}
