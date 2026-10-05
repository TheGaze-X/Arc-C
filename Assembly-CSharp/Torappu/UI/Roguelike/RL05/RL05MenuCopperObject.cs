using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055DF RID: 21983
	[Token(Token = "0x20055DF")]
	public class RL05MenuCopperObject : RoguelikeMenuObject<RL05MenuCopperListViewModel>, IHotfixable
	{
		// Token: 0x17004BA0 RID: 19360
		// (get) Token: 0x06020445 RID: 132165 RVA: 0x000B5248 File Offset: 0x000B3448
		[Token(Token = "0x17004BA0")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x6020445")]
			[Address(RVA = "0x1A64580", Offset = "0x1A63180", VA = "0x181A64580", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x06020446 RID: 132166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020446")]
		[Address(RVA = "0x1A63630", Offset = "0x1A62230", VA = "0x181A63630", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x06020447 RID: 132167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020447")]
		[Address(RVA = "0x1A64000", Offset = "0x1A62C00", VA = "0x181A64000")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x06020448 RID: 132168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020448")]
		[Address(RVA = "0x1A63990", Offset = "0x1A62590", VA = "0x181A63990", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x06020449 RID: 132169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020449")]
		[Address(RVA = "0x1A63B80", Offset = "0x1A62780", VA = "0x181A63B80", Slot = "16")]
		public override void Render(RL05MenuCopperListViewModel viewModel)
		{
		}

		// Token: 0x0602044A RID: 132170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602044A")]
		[Address(RVA = "0x1A63810", Offset = "0x1A62410", VA = "0x181A63810", Slot = "12")]
		public override void OnClick()
		{
		}

		// Token: 0x0602044B RID: 132171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602044B")]
		[Address(RVA = "0x1A63D20", Offset = "0x1A62920", VA = "0x181A63D20")]
		private void _OnCopperObjectClicked()
		{
		}

		// Token: 0x0602044C RID: 132172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602044C")]
		[Address(RVA = "0x1A644F0", Offset = "0x1A630F0", VA = "0x181A644F0")]
		public RL05MenuCopperObject()
		{
		}

		// Token: 0x0602044F RID: 132175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602044F")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x06020450 RID: 132176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020450")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x06020451 RID: 132177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020451")]
		[Address(RVA = "0x1910390", Offset = "0x190EF90", VA = "0x181910390")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402BA6B RID: 178795
		[Token(Token = "0x402BA6B")]
		[FieldOffset(Offset = "0x28")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BA6C RID: 178796
		[Token(Token = "0x402BA6C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402BA6D RID: 178797
		[Token(Token = "0x402BA6D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _pnlBack;

		// Token: 0x0402BA6E RID: 178798
		[Token(Token = "0x402BA6E")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402BA6F RID: 178799
		[Token(Token = "0x402BA6F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Type[] STATES_SHOW_CAN_USE;

		// Token: 0x0402BA70 RID: 178800
		[Token(Token = "0x402BA70")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Type[] STATES_SELECTED;

		// Token: 0x0402BA71 RID: 178801
		[Token(Token = "0x402BA71")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_showSwitchTween;

		// Token: 0x0402BA72 RID: 178802
		[Token(Token = "0x402BA72")]
		[FieldOffset(Offset = "0x50")]
		private RL05MenuCopperListViewModel m_cachedModel;

		// Token: 0x0402BA73 RID: 178803
		[Token(Token = "0x402BA73")]
		[FieldOffset(Offset = "0x58")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402BA74 RID: 178804
		[Token(Token = "0x402BA74")]
		[FieldOffset(Offset = "0x60")]
		private bool m_cachedStateShow;

		// Token: 0x0402BA75 RID: 178805
		[Token(Token = "0x402BA75")]
		[FieldOffset(Offset = "0x61")]
		private bool m_cachedIsCanUse;

		// Token: 0x0402BA76 RID: 178806
		[Token(Token = "0x402BA76")]
		[FieldOffset(Offset = "0x64")]
		private RL05MenuCopperObject.RL05CopperObjectStatus m_cachedStatus;

		// Token: 0x0402BA77 RID: 178807
		[Token(Token = "0x402BA77")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402BA78 RID: 178808
		[Token(Token = "0x402BA78")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402BA79 RID: 178809
		[Token(Token = "0x402BA79")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402BA7A RID: 178810
		[Token(Token = "0x402BA7A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402BA7B RID: 178811
		[Token(Token = "0x402BA7B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BA7C RID: 178812
		[Token(Token = "0x402BA7C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402BA7D RID: 178813
		[Token(Token = "0x402BA7D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnCopperObjectClicked;

		// Token: 0x0402BA7E RID: 178814
		[Token(Token = "0x402BA7E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020055E0 RID: 21984
		[Token(Token = "0x20055E0")]
		public enum RL05CopperObjectStatus
		{
			// Token: 0x0402BA80 RID: 178816
			[Token(Token = "0x402BA80")]
			NORMAL,
			// Token: 0x0402BA81 RID: 178817
			[Token(Token = "0x402BA81")]
			SELECTED
		}
	}
}
