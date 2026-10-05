using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055E2 RID: 21986
	[Token(Token = "0x20055E2")]
	public class RL05MenuStashedTicketObject : RoguelikeMenuObject<RL05MenuStashedTicketViewModel>
	{
		// Token: 0x17004BA1 RID: 19361
		// (get) Token: 0x06020454 RID: 132180 RVA: 0x000B5278 File Offset: 0x000B3478
		[Token(Token = "0x17004BA1")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x6020454")]
			[Address(RVA = "0x1A67340", Offset = "0x1A65F40", VA = "0x181A67340", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020455 RID: 132181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020455")]
		[Address(RVA = "0x1A66500", Offset = "0x1A65100", VA = "0x181A66500", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x06020456 RID: 132182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020456")]
		[Address(RVA = "0x1A668B0", Offset = "0x1A654B0", VA = "0x181A668B0", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x06020457 RID: 132183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020457")]
		[Address(RVA = "0x1A66A00", Offset = "0x1A65600", VA = "0x181A66A00", Slot = "16")]
		public override void Render(RL05MenuStashedTicketViewModel viewModel)
		{
		}

		// Token: 0x06020458 RID: 132184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020458")]
		[Address(RVA = "0x1A66F20", Offset = "0x1A65B20", VA = "0x181A66F20")]
		private void _Render(bool fastMode, bool isFromAdapterChange)
		{
		}

		// Token: 0x06020459 RID: 132185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020459")]
		[Address(RVA = "0x1A67050", Offset = "0x1A65C50", VA = "0x181A67050")]
		private void _UpdateRenderers()
		{
		}

		// Token: 0x0602045A RID: 132186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602045A")]
		[Address(RVA = "0x1A66D30", Offset = "0x1A65930", VA = "0x181A66D30")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x0602045B RID: 132187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602045B")]
		[Address(RVA = "0x1A66E10", Offset = "0x1A65A10", VA = "0x181A66E10")]
		private void _RenderView(int kitCount, bool fastMode)
		{
		}

		// Token: 0x0602045C RID: 132188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602045C")]
		[Address(RVA = "0x1A66BE0", Offset = "0x1A657E0", VA = "0x181A66BE0")]
		private void _EventOnShowUseAnim(object arg)
		{
		}

		// Token: 0x0602045D RID: 132189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602045D")]
		[Address(RVA = "0x1A672B0", Offset = "0x1A65EB0", VA = "0x181A672B0")]
		public RL05MenuStashedTicketObject()
		{
		}

		// Token: 0x06020461 RID: 132193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020461")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x06020462 RID: 132194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020462")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0402BA8C RID: 178828
		[Token(Token = "0x402BA8C")]
		[FieldOffset(Offset = "0x0")]
		private static Vector2 HIDE_POS;

		// Token: 0x0402BA8D RID: 178829
		[Token(Token = "0x402BA8D")]
		[FieldOffset(Offset = "0x8")]
		private static Vector2 SHOW_POS;

		// Token: 0x0402BA8E RID: 178830
		[Token(Token = "0x402BA8E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402BA8F RID: 178831
		[Token(Token = "0x402BA8F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402BA90 RID: 178832
		[Token(Token = "0x402BA90")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelCandleHolder;

		// Token: 0x0402BA91 RID: 178833
		[Token(Token = "0x402BA91")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelStashedTicket;

		// Token: 0x0402BA92 RID: 178834
		[Token(Token = "0x402BA92")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _txtNum;

		// Token: 0x0402BA93 RID: 178835
		[Token(Token = "0x402BA93")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _noticeAnimationLocation;

		// Token: 0x0402BA94 RID: 178836
		[Token(Token = "0x402BA94")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _showAnimationLocation;

		// Token: 0x0402BA95 RID: 178837
		[Token(Token = "0x402BA95")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402BA96 RID: 178838
		[Token(Token = "0x402BA96")]
		[FieldOffset(Offset = "0x70")]
		private RoguelikeMenuViewRenderer<int> m_viewRenderer;

		// Token: 0x0402BA97 RID: 178839
		[Token(Token = "0x402BA97")]
		[FieldOffset(Offset = "0x78")]
		private RL05MenuStashedTicketViewModel m_cachedModel;

		// Token: 0x0402BA98 RID: 178840
		[Token(Token = "0x402BA98")]
		[FieldOffset(Offset = "0x80")]
		private bool m_cachedStateShow;

		// Token: 0x0402BA99 RID: 178841
		[Token(Token = "0x402BA99")]
		[FieldOffset(Offset = "0x88")]
		private AnimationSwitchTween m_showSwitchTween;

		// Token: 0x0402BA9A RID: 178842
		[Token(Token = "0x402BA9A")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_noticeTween;

		// Token: 0x0402BA9B RID: 178843
		[Token(Token = "0x402BA9B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402BA9C RID: 178844
		[Token(Token = "0x402BA9C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402BA9D RID: 178845
		[Token(Token = "0x402BA9D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402BA9E RID: 178846
		[Token(Token = "0x402BA9E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BA9F RID: 178847
		[Token(Token = "0x402BA9F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402BAA0 RID: 178848
		[Token(Token = "0x402BAA0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateRenderers;

		// Token: 0x0402BAA1 RID: 178849
		[Token(Token = "0x402BAA1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402BAA2 RID: 178850
		[Token(Token = "0x402BAA2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0402BAA3 RID: 178851
		[Token(Token = "0x402BAA3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnShowUseAnim;

		// Token: 0x0402BAA4 RID: 178852
		[Token(Token = "0x402BAA4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
