using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055DC RID: 21980
	[Token(Token = "0x20055DC")]
	public class RL05MenuCopperListObject : RoguelikeMenuObject<RL05MenuCopperListViewModel>
	{
		// Token: 0x0602042C RID: 132140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602042C")]
		[Address(RVA = "0x1A61230", Offset = "0x1A5FE30", VA = "0x181A61230", Slot = "13")]
		public override void Init(RoguelikeMenuBar menu)
		{
		}

		// Token: 0x0602042D RID: 132141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602042D")]
		[Address(RVA = "0x1A618C0", Offset = "0x1A604C0", VA = "0x181A618C0")]
		private void _EventOnShowUseAnim(object arg)
		{
		}

		// Token: 0x17004B9F RID: 19359
		// (get) Token: 0x0602042E RID: 132142 RVA: 0x000B51D0 File Offset: 0x000B33D0
		[Token(Token = "0x17004B9F")]
		public override RoguelikeMenuType menuType
		{
			[Token(Token = "0x602042E")]
			[Address(RVA = "0x1A620F0", Offset = "0x1A60CF0", VA = "0x181A620F0", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0602042F RID: 132143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602042F")]
		[Address(RVA = "0x1A61AC0", Offset = "0x1A606C0", VA = "0x181A61AC0")]
		private void _RenderShowStatus(bool show, bool fastMode)
		{
		}

		// Token: 0x06020430 RID: 132144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020430")]
		[Address(RVA = "0x1A61560", Offset = "0x1A60160", VA = "0x181A61560", Slot = "8")]
		public override void OnMenuAdapterChanged(RoguelikeMenuAdapter adapter, bool fastMode)
		{
		}

		// Token: 0x06020431 RID: 132145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020431")]
		[Address(RVA = "0x1A616E0", Offset = "0x1A602E0", VA = "0x181A616E0", Slot = "16")]
		public override void Render(RL05MenuCopperListViewModel viewModel)
		{
		}

		// Token: 0x06020432 RID: 132146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020432")]
		[Address(RVA = "0x1A61BC0", Offset = "0x1A607C0", VA = "0x181A61BC0")]
		private void _UpdateCopperItems(RL05MenuCopperListViewModel viewModel)
		{
		}

		// Token: 0x06020433 RID: 132147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020433")]
		[Address(RVA = "0x1A614D0", Offset = "0x1A600D0", VA = "0x181A614D0", Slot = "12")]
		public override void OnClick()
		{
		}

		// Token: 0x06020434 RID: 132148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020434")]
		[Address(RVA = "0x1A61950", Offset = "0x1A60550", VA = "0x181A61950")]
		private void _RenderNewCopper()
		{
		}

		// Token: 0x06020435 RID: 132149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020435")]
		[Address(RVA = "0x1A62010", Offset = "0x1A60C10", VA = "0x181A62010")]
		public RL05MenuCopperListObject()
		{
		}

		// Token: 0x06020438 RID: 132152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020438")]
		[Address(RVA = "0x1910380", Offset = "0x190EF80", VA = "0x181910380")]
		private void <>xLuaBaseProxy_Init(RoguelikeMenuBar P0)
		{
		}

		// Token: 0x06020439 RID: 132153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020439")]
		[Address(RVA = "0x190F350", Offset = "0x190DF50", VA = "0x18190F350")]
		private void <>xLuaBaseProxy_OnMenuAdapterChanged(RoguelikeMenuAdapter P0, bool P1)
		{
		}

		// Token: 0x0602043A RID: 132154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602043A")]
		[Address(RVA = "0x1910390", Offset = "0x190EF90", VA = "0x181910390")]
		private void <>xLuaBaseProxy_OnClick()
		{
		}

		// Token: 0x0402BA45 RID: 178757
		[Token(Token = "0x402BA45")]
		private const float ANIM_NEW_COPPER_DURATION = 0.75f;

		// Token: 0x0402BA46 RID: 178758
		[Token(Token = "0x402BA46")]
		private const int MAX_VISIBLE_ITEMS = 3;

		// Token: 0x0402BA47 RID: 178759
		[Token(Token = "0x402BA47")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] STATES_NOT_SHOW;

		// Token: 0x0402BA48 RID: 178760
		[Token(Token = "0x402BA48")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _pnlContent;

		// Token: 0x0402BA49 RID: 178761
		[Token(Token = "0x402BA49")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animNewCopper;

		// Token: 0x0402BA4A RID: 178762
		[Token(Token = "0x402BA4A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _invalidRaycastBlocker;

		// Token: 0x0402BA4B RID: 178763
		[Token(Token = "0x402BA4B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _copperContainer;

		// Token: 0x0402BA4C RID: 178764
		[Token(Token = "0x402BA4C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _copperItemPrefab;

		// Token: 0x0402BA4D RID: 178765
		[Token(Token = "0x402BA4D")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_newCopperTween;

		// Token: 0x0402BA4E RID: 178766
		[Token(Token = "0x402BA4E")]
		[FieldOffset(Offset = "0x60")]
		private FadeSwitchTween m_showSwitchTween;

		// Token: 0x0402BA4F RID: 178767
		[Token(Token = "0x402BA4F")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeMenuViewRenderer<bool> m_showRenderer;

		// Token: 0x0402BA50 RID: 178768
		[Token(Token = "0x402BA50")]
		[FieldOffset(Offset = "0x70")]
		private List<RL05MenuCopperView> m_copperViews;

		// Token: 0x0402BA51 RID: 178769
		[Token(Token = "0x402BA51")]
		[FieldOffset(Offset = "0x78")]
		private RL05MenuCopperListViewModel m_cachedModel;

		// Token: 0x0402BA52 RID: 178770
		[Token(Token = "0x402BA52")]
		[FieldOffset(Offset = "0x80")]
		private bool m_cachedStateShow;

		// Token: 0x0402BA53 RID: 178771
		[Token(Token = "0x402BA53")]
		[FieldOffset(Offset = "0x84")]
		private int m_cachedCopperCount;

		// Token: 0x0402BA54 RID: 178772
		[Token(Token = "0x402BA54")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402BA55 RID: 178773
		[Token(Token = "0x402BA55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402BA56 RID: 178774
		[Token(Token = "0x402BA56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnShowUseAnim;

		// Token: 0x0402BA57 RID: 178775
		[Token(Token = "0x402BA57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_menuType;

		// Token: 0x0402BA58 RID: 178776
		[Token(Token = "0x402BA58")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderShowStatus;

		// Token: 0x0402BA59 RID: 178777
		[Token(Token = "0x402BA59")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMenuAdapterChanged;

		// Token: 0x0402BA5A RID: 178778
		[Token(Token = "0x402BA5A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BA5B RID: 178779
		[Token(Token = "0x402BA5B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateCopperItems;

		// Token: 0x0402BA5C RID: 178780
		[Token(Token = "0x402BA5C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402BA5D RID: 178781
		[Token(Token = "0x402BA5D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RenderNewCopper;

		// Token: 0x0402BA5E RID: 178782
		[Token(Token = "0x402BA5E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
