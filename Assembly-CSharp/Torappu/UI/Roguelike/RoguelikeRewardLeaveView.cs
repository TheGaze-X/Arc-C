using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053E7 RID: 21479
	[Token(Token = "0x20053E7")]
	public class RoguelikeRewardLeaveView : RoguelikeRewardItem
	{
		// Token: 0x17004A04 RID: 18948
		// (get) Token: 0x0601F9AC RID: 129452 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F9AD RID: 129453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004A04")]
		public override UIIntEvent onClickEvent
		{
			[Token(Token = "0x601F9AC")]
			[Address(RVA = "0x19410D0", Offset = "0x193FCD0", VA = "0x1819410D0", Slot = "4")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601F9AD")]
			[Address(RVA = "0x1941190", Offset = "0x193FD90", VA = "0x181941190", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004A05 RID: 18949
		// (get) Token: 0x0601F9AE RID: 129454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004A05")]
		public override RoguelikeRewardShowTypeSet showType
		{
			[Token(Token = "0x601F9AE")]
			[Address(RVA = "0x1941130", Offset = "0x193FD30", VA = "0x181941130", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F9AF RID: 129455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9AF")]
		[Address(RVA = "0x1940C00", Offset = "0x193F800", VA = "0x181940C00", Slot = "7")]
		public override void OnClick()
		{
		}

		// Token: 0x0601F9B0 RID: 129456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9B0")]
		[Address(RVA = "0x1940B90", Offset = "0x193F790", VA = "0x181940B90")]
		public void OnCancelClick()
		{
		}

		// Token: 0x0601F9B1 RID: 129457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9B1")]
		[Address(RVA = "0x1940CD0", Offset = "0x193F8D0", VA = "0x181940CD0")]
		public void OnConfirmClick()
		{
		}

		// Token: 0x0601F9B2 RID: 129458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9B2")]
		[Address(RVA = "0x1940DA0", Offset = "0x193F9A0", VA = "0x181940DA0", Slot = "8")]
		public override void Render(RoguelikeRewardItemViewModel viewModel, string topicId)
		{
		}

		// Token: 0x0601F9B3 RID: 129459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9B3")]
		[Address(RVA = "0x1940F30", Offset = "0x193FB30", VA = "0x181940F30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F9B4 RID: 129460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F9B4")]
		[Address(RVA = "0x1941030", Offset = "0x193FC30", VA = "0x181941030")]
		public RoguelikeRewardLeaveView()
		{
		}

		// Token: 0x0402A917 RID: 174359
		[Token(Token = "0x402A917")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelLeaveCheck;

		// Token: 0x0402A918 RID: 174360
		[Token(Token = "0x402A918")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _canvasLeaveCheck;

		// Token: 0x0402A919 RID: 174361
		[Token(Token = "0x402A919")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeRewardLeaveView.RoguelikeRewardLeaveSwitch m_switchTween;

		// Token: 0x0402A91A RID: 174362
		[Token(Token = "0x402A91A")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0402A91B RID: 174363
		[Token(Token = "0x402A91B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClickEvent;

		// Token: 0x0402A91C RID: 174364
		[Token(Token = "0x402A91C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClickEvent;

		// Token: 0x0402A91D RID: 174365
		[Token(Token = "0x402A91D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_showType;

		// Token: 0x0402A91E RID: 174366
		[Token(Token = "0x402A91E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402A91F RID: 174367
		[Token(Token = "0x402A91F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnCancelClick;

		// Token: 0x0402A920 RID: 174368
		[Token(Token = "0x402A920")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnConfirmClick;

		// Token: 0x0402A921 RID: 174369
		[Token(Token = "0x402A921")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A922 RID: 174370
		[Token(Token = "0x402A922")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A923 RID: 174371
		[Token(Token = "0x402A923")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020053E8 RID: 21480
		[Token(Token = "0x20053E8")]
		private class RoguelikeRewardLeaveSwitch : UISwitchTween
		{
			// Token: 0x0601F9B5 RID: 129461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F9B5")]
			[Address(RVA = "0x19407F0", Offset = "0x193F3F0", VA = "0x1819407F0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601F9B6 RID: 129462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F9B6")]
			[Address(RVA = "0x1940540", Offset = "0x193F140", VA = "0x181940540", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601F9B7 RID: 129463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F9B7")]
			[Address(RVA = "0x1940A20", Offset = "0x193F620", VA = "0x181940A20", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601F9B8 RID: 129464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F9B8")]
			[Address(RVA = "0x1940B10", Offset = "0x193F710", VA = "0x181940B10")]
			public RoguelikeRewardLeaveSwitch(RoguelikeRewardLeaveView closure)
			{
			}

			// Token: 0x0601F9BA RID: 129466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F9BA")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0402A924 RID: 174372
			[Token(Token = "0x402A924")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeRewardLeaveView m_closure;

			// Token: 0x0402A925 RID: 174373
			[Token(Token = "0x402A925")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0402A926 RID: 174374
			[Token(Token = "0x402A926")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0402A927 RID: 174375
			[Token(Token = "0x402A927")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_ResetToState;

			// Token: 0x0402A928 RID: 174376
			[Token(Token = "0x402A928")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
