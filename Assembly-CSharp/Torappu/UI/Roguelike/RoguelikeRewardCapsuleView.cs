using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053D0 RID: 21456
	[Token(Token = "0x20053D0")]
	public class RoguelikeRewardCapsuleView : RoguelikeRewardItem
	{
		// Token: 0x170049F3 RID: 18931
		// (get) Token: 0x0601F93B RID: 129339 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F93C RID: 129340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049F3")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601F93B")]
			[Address(RVA = "0x19393C0", Offset = "0x1937FC0", VA = "0x1819393C0", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601F93C")]
			[Address(RVA = "0x1939480", Offset = "0x1938080", VA = "0x181939480", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170049F4 RID: 18932
		// (get) Token: 0x0601F93D RID: 129341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049F4")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601F93D")]
			[Address(RVA = "0x1939420", Offset = "0x1938020", VA = "0x181939420", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F93E RID: 129342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F93E")]
		[Address(RVA = "0x1938D90", Offset = "0x1937990", VA = "0x181938D90", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601F93F RID: 129343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F93F")]
		[Address(RVA = "0x1938D20", Offset = "0x1937920", VA = "0x181938D20")]
		public void OnCancelClick()
		{
		}

		// Token: 0x0601F940 RID: 129344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F940")]
		[Address(RVA = "0x1938F30", Offset = "0x1937B30", VA = "0x181938F30")]
		public void OnConfirmClick()
		{
		}

		// Token: 0x0601F941 RID: 129345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F941")]
		[Address(RVA = "0x1939000", Offset = "0x1937C00", VA = "0x181939000", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601F942 RID: 129346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F942")]
		[Address(RVA = "0x1939210", Offset = "0x1937E10", VA = "0x181939210")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F943 RID: 129347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F943")]
		[Address(RVA = "0x1939320", Offset = "0x1937F20", VA = "0x181939320")]
		public RoguelikeRewardCapsuleView()
		{
		}

		// Token: 0x0402A83C RID: 174140
		[Token(Token = "0x402A83C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _capsuleBg;

		// Token: 0x0402A83D RID: 174141
		[Token(Token = "0x402A83D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelReplaceText;

		// Token: 0x0402A83E RID: 174142
		[Token(Token = "0x402A83E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelReplaceCheck;

		// Token: 0x0402A83F RID: 174143
		[Token(Token = "0x402A83F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _canvasReplaceCheck;

		// Token: 0x0402A840 RID: 174144
		[Token(Token = "0x402A840")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _objReceiptBtn;

		// Token: 0x0402A841 RID: 174145
		[Token(Token = "0x402A841")]
		[FieldOffset(Offset = "0x78")]
		private RoguelikeRewardCapsuleView.RoguelikeRewardCapsuleSwitch m_switchTween;

		// Token: 0x0402A842 RID: 174146
		[Token(Token = "0x402A842")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0402A843 RID: 174147
		[Token(Token = "0x402A843")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402A844 RID: 174148
		[Token(Token = "0x402A844")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402A845 RID: 174149
		[Token(Token = "0x402A845")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402A846 RID: 174150
		[Token(Token = "0x402A846")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A847 RID: 174151
		[Token(Token = "0x402A847")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCancelClick;

		// Token: 0x0402A848 RID: 174152
		[Token(Token = "0x402A848")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnConfirmClick;

		// Token: 0x0402A849 RID: 174153
		[Token(Token = "0x402A849")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A84A RID: 174154
		[Token(Token = "0x402A84A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A84B RID: 174155
		[Token(Token = "0x402A84B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053D1 RID: 21457
		[Token(Token = "0x20053D1")]
		private class RoguelikeRewardCapsuleSwitch : UISwitchTween
		{
			// Token: 0x0601F944 RID: 129348 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F944")]
			[Address(RVA = "0x1938980", Offset = "0x1937580", VA = "0x181938980", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601F945 RID: 129349 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F945")]
			[Address(RVA = "0x19386D0", Offset = "0x19372D0", VA = "0x1819386D0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601F946 RID: 129350 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F946")]
			[Address(RVA = "0x1938BB0", Offset = "0x19377B0", VA = "0x181938BB0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601F947 RID: 129351 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F947")]
			[Address(RVA = "0x1938CA0", Offset = "0x19378A0", VA = "0x181938CA0")]
			public RoguelikeRewardCapsuleSwitch(RoguelikeRewardCapsuleView closure)
			{
			}

			// Token: 0x0601F949 RID: 129353 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F949")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402A84C RID: 174156
			[Token(Token = "0x402A84C")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeRewardCapsuleView m_closure;

			// Token: 0x0402A84D RID: 174157
			[Token(Token = "0x402A84D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402A84E RID: 174158
			[Token(Token = "0x402A84E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402A84F RID: 174159
			[Token(Token = "0x402A84F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0402A850 RID: 174160
			[Token(Token = "0x402A850")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
