using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200529B RID: 21147
	[Token(Token = "0x200529B")]
	public class RoguelikeClassicEndingStatsView : RoguelikeClassicEndingPageView<RoguelikeClassicEndingStatsViewModel>
	{
		// Token: 0x17004929 RID: 18729
		// (get) Token: 0x0601F33B RID: 127803 RVA: 0x000B12E8 File Offset: 0x000AF4E8
		[Token(Token = "0x17004929")]
		public override ViewType viewType
		{
			[Token(Token = "0x601F33B")]
			[Address(RVA = "0x18E60B0", Offset = "0x18E4CB0", VA = "0x1818E60B0", Slot = "4")]
			get
			{
				return ViewType.NONE;
			}
		}

		// Token: 0x1700492A RID: 18730
		// (set) Token: 0x0601F33C RID: 127804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700492A")]
		public override Action onForward
		{
			[Token(Token = "0x601F33C")]
			[Address(RVA = "0x18E61D0", Offset = "0x18E4DD0", VA = "0x1818E61D0", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x1700492B RID: 18731
		// (set) Token: 0x0601F33D RID: 127805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700492B")]
		public override Action onBack
		{
			[Token(Token = "0x601F33D")]
			[Address(RVA = "0x18E6110", Offset = "0x18E4D10", VA = "0x1818E6110", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x1700492C RID: 18732
		// (set) Token: 0x0601F33E RID: 127806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700492C")]
		public override Action onConfirm
		{
			[Token(Token = "0x601F33E")]
			[Address(RVA = "0x18E6170", Offset = "0x18E4D70", VA = "0x1818E6170", Slot = "7")]
			set
			{
			}
		}

		// Token: 0x0601F33F RID: 127807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F33F")]
		[Address(RVA = "0x18E5D80", Offset = "0x18E4980", VA = "0x1818E5D80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F340 RID: 127808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F340")]
		[Address(RVA = "0x18E5B20", Offset = "0x18E4720", VA = "0x1818E5B20")]
		private IList<UIRecycleLayoutAdapter.IVirtualView> _CreateViewList(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingStatsViewModel viewModel)
		{
			return null;
		}

		// Token: 0x0601F341 RID: 127809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F341")]
		[Address(RVA = "0x18E5E50", Offset = "0x18E4A50", VA = "0x1818E5E50")]
		private void _SetupContent(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingStatsViewModel viewModel)
		{
		}

		// Token: 0x0601F342 RID: 127810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F342")]
		[Address(RVA = "0x18E5410", Offset = "0x18E4010", VA = "0x1818E5410", Slot = "8")]
		public override RoguelikeClassicEndingPageViewModel ConstructViewModel()
		{
			return null;
		}

		// Token: 0x0601F343 RID: 127811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F343")]
		[Address(RVA = "0x18E5610", Offset = "0x18E4210", VA = "0x1818E5610", Slot = "11")]
		protected override void Render(RoguelikeEndingControllerBase controller, RoguelikeClassicEndingStatsViewModel viewModel)
		{
		}

		// Token: 0x0601F344 RID: 127812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F344")]
		[Address(RVA = "0x18E5AB0", Offset = "0x18E46B0", VA = "0x1818E5AB0")]
		private void _ClearCacheTween()
		{
		}

		// Token: 0x0601F345 RID: 127813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F345")]
		[Address(RVA = "0x18E59F0", Offset = "0x18E45F0", VA = "0x1818E59F0")]
		private IEnumerator _ApplyInAnim(bool fastMode)
		{
			return null;
		}

		// Token: 0x0601F346 RID: 127814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F346")]
		[Address(RVA = "0x18E52C0", Offset = "0x18E3EC0", VA = "0x1818E52C0", Slot = "10")]
		public override void ApplyOutAnim()
		{
		}

		// Token: 0x0601F347 RID: 127815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F347")]
		[Address(RVA = "0x18E55A0", Offset = "0x18E41A0", VA = "0x1818E55A0")]
		public void OnForwardClicked()
		{
		}

		// Token: 0x0601F348 RID: 127816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F348")]
		[Address(RVA = "0x18E6040", Offset = "0x18E4C40", VA = "0x1818E6040")]
		public RoguelikeClassicEndingStatsView()
		{
		}

		// Token: 0x04029E36 RID: 171574
		[Token(Token = "0x4029E36")]
		private const string STATS_IN_ANIM = "anim_stats_in";

		// Token: 0x04029E37 RID: 171575
		[Token(Token = "0x4029E37")]
		private const string STATS_OUT_ANIM = "anim_stats_out";

		// Token: 0x04029E38 RID: 171576
		[Token(Token = "0x4029E38")]
		private const float FADE_DURATION = 0.5f;

		// Token: 0x04029E39 RID: 171577
		[Token(Token = "0x4029E39")]
		private const float SWEEP_SOUND_DELAY = 0.7f;

		// Token: 0x04029E3A RID: 171578
		[Token(Token = "0x4029E3A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x04029E3B RID: 171579
		[Token(Token = "0x4029E3B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x04029E3C RID: 171580
		[Token(Token = "0x4029E3C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04029E3D RID: 171581
		[Token(Token = "0x4029E3D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RoguelikeClassicEndingStatsViewComponentBase[] _viewComponentPrefabs;

		// Token: 0x04029E3E RID: 171582
		[Token(Token = "0x4029E3E")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeClassicEndingStatsView.Adapter m_adapter;

		// Token: 0x04029E3F RID: 171583
		[Token(Token = "0x4029E3F")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasAnimPlayed;

		// Token: 0x04029E40 RID: 171584
		[Token(Token = "0x4029E40")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_cacheTween;

		// Token: 0x04029E41 RID: 171585
		[Token(Token = "0x4029E41")]
		[FieldOffset(Offset = "0x50")]
		private FadeSwitchTween m_displayTween;

		// Token: 0x04029E42 RID: 171586
		[Token(Token = "0x4029E42")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x04029E43 RID: 171587
		[Token(Token = "0x4029E43")]
		[FieldOffset(Offset = "0x60")]
		private Action m_forwardAction;

		// Token: 0x04029E44 RID: 171588
		[Token(Token = "0x4029E44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x04029E45 RID: 171589
		[Token(Token = "0x4029E45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onForward;

		// Token: 0x04029E46 RID: 171590
		[Token(Token = "0x4029E46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onBack;

		// Token: 0x04029E47 RID: 171591
		[Token(Token = "0x4029E47")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_onConfirm;

		// Token: 0x04029E48 RID: 171592
		[Token(Token = "0x4029E48")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029E49 RID: 171593
		[Token(Token = "0x4029E49")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateViewList;

		// Token: 0x04029E4A RID: 171594
		[Token(Token = "0x4029E4A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetupContent;

		// Token: 0x04029E4B RID: 171595
		[Token(Token = "0x4029E4B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ConstructViewModel;

		// Token: 0x04029E4C RID: 171596
		[Token(Token = "0x4029E4C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029E4D RID: 171597
		[Token(Token = "0x4029E4D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ClearCacheTween;

		// Token: 0x04029E4E RID: 171598
		[Token(Token = "0x4029E4E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ApplyInAnim;

		// Token: 0x04029E4F RID: 171599
		[Token(Token = "0x4029E4F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ApplyOutAnim;

		// Token: 0x04029E50 RID: 171600
		[Token(Token = "0x4029E50")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnForwardClicked;

		// Token: 0x04029E51 RID: 171601
		[Token(Token = "0x4029E51")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200529C RID: 21148
		[Token(Token = "0x200529C")]
		private class Adapter : UIRecycleLayoutAdapter
		{
			// Token: 0x0601F34A RID: 127818 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F34A")]
			[Address(RVA = "0x18DD430", Offset = "0x18DC030", VA = "0x1818DD430", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x0601F34B RID: 127819 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F34B")]
			[Address(RVA = "0x18DD490", Offset = "0x18DC090", VA = "0x1818DD490")]
			public void NotifyRebuild()
			{
			}

			// Token: 0x0601F34C RID: 127820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F34C")]
			[Address(RVA = "0x18DD520", Offset = "0x18DC120", VA = "0x1818DD520")]
			public Adapter()
			{
			}

			// Token: 0x04029E52 RID: 171602
			[Token(Token = "0x4029E52")]
			[FieldOffset(Offset = "0x18")]
			public IList<UIRecycleLayoutAdapter.IVirtualView> views;

			// Token: 0x04029E53 RID: 171603
			[Token(Token = "0x4029E53")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x04029E54 RID: 171604
			[Token(Token = "0x4029E54")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_NotifyRebuild;

			// Token: 0x04029E55 RID: 171605
			[Token(Token = "0x4029E55")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
