using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL01
{
	// Token: 0x020057AF RID: 22447
	[Token(Token = "0x20057AF")]
	public class RL01ClassicEndingStatsCapsuleAndTrapView : RoguelikeClassicEndingStatsViewComponent<RL01ClassicEndingStatsCapsuleAndTrapViewModel>
	{
		// Token: 0x06020D48 RID: 134472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020D48")]
		[Address(RVA = "0x1B1AEE0", Offset = "0x1B19AE0", VA = "0x181B1AEE0", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel model, UIPage page)
		{
			return null;
		}

		// Token: 0x06020D49 RID: 134473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D49")]
		[Address(RVA = "0x1B1B020", Offset = "0x1B19C20", VA = "0x181B1B020", Slot = "7")]
		protected override void Render(RL01ClassicEndingStatsCapsuleAndTrapViewModel viewModel)
		{
		}

		// Token: 0x06020D4A RID: 134474 RVA: 0x000B77E0 File Offset: 0x000B59E0
		[Token(Token = "0x6020D4A")]
		[Address(RVA = "0x1B1B320", Offset = "0x1B19F20", VA = "0x181B1B320")]
		private static float _CalcPrefabHeight(RL01ClassicEndingStatsCapsuleAndTrapView prefab, RL01ClassicEndingStatsCapsuleAndTrapViewModel viewModel)
		{
			return 0f;
		}

		// Token: 0x06020D4B RID: 134475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D4B")]
		[Address(RVA = "0x1B1B5A0", Offset = "0x1B1A1A0", VA = "0x181B1B5A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020D4C RID: 134476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020D4C")]
		[Address(RVA = "0x1B1B630", Offset = "0x1B1A230", VA = "0x181B1B630")]
		public RL01ClassicEndingStatsCapsuleAndTrapView()
		{
		}

		// Token: 0x0402C9B9 RID: 182713
		[Token(Token = "0x402C9B9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("capsule")]
		private Text _textCapsuleNum;

		// Token: 0x0402C9BA RID: 182714
		[Token(Token = "0x402C9BA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("capsule")]
		private SimpleLayoutContent _capsuleLayoutContent;

		// Token: 0x0402C9BB RID: 182715
		[Token(Token = "0x402C9BB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("capsule")]
		private GridLayoutGroup _capsuleLayout;

		// Token: 0x0402C9BC RID: 182716
		[Token(Token = "0x402C9BC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("capsule")]
		private float _capsuleMinHeight;

		// Token: 0x0402C9BD RID: 182717
		[Token(Token = "0x402C9BD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("trap")]
		private Text _textTrapNum;

		// Token: 0x0402C9BE RID: 182718
		[Token(Token = "0x402C9BE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("trap")]
		private SimpleLayoutContent _trapLayoutContent;

		// Token: 0x0402C9BF RID: 182719
		[Token(Token = "0x402C9BF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("trap")]
		private GridLayoutGroup _trapLayout;

		// Token: 0x0402C9C0 RID: 182720
		[Token(Token = "0x402C9C0")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("trap")]
		private float _trapMinHeight;

		// Token: 0x0402C9C1 RID: 182721
		[Token(Token = "0x402C9C1")]
		[FieldOffset(Offset = "0x60")]
		private RL01ClassicEndingStatsCapsuleAndTrapView.EndingCapsuleAdapter m_capsuleAdapter;

		// Token: 0x0402C9C2 RID: 182722
		[Token(Token = "0x402C9C2")]
		[FieldOffset(Offset = "0x68")]
		private RL01ClassicEndingStatsCapsuleAndTrapView.EndingTrapAdapter m_trapAdapter;

		// Token: 0x0402C9C3 RID: 182723
		[Token(Token = "0x402C9C3")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0402C9C4 RID: 182724
		[Token(Token = "0x402C9C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x0402C9C5 RID: 182725
		[Token(Token = "0x402C9C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C9C6 RID: 182726
		[Token(Token = "0x402C9C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalcPrefabHeight;

		// Token: 0x0402C9C7 RID: 182727
		[Token(Token = "0x402C9C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C9C8 RID: 182728
		[Token(Token = "0x402C9C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020057B0 RID: 22448
		[Token(Token = "0x20057B0")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RL01ClassicEndingStatsCapsuleAndTrapView, RL01ClassicEndingStatsCapsuleAndTrapViewModel>
		{
			// Token: 0x06020D4D RID: 134477 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D4D")]
			[Address(RVA = "0x1B2D360", Offset = "0x1B2BF60", VA = "0x181B2D360")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x06020D4E RID: 134478 RVA: 0x000B77F8 File Offset: 0x000B59F8
			[Token(Token = "0x6020D4E")]
			[Address(RVA = "0x1B2C9E0", Offset = "0x1B2B5E0", VA = "0x181B2C9E0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402C9C9 RID: 182729
			[Token(Token = "0x402C9C9")]
			[FieldOffset(Offset = "0x38")]
			private float m_cachedHeight;

			// Token: 0x0402C9CA RID: 182730
			[Token(Token = "0x402C9CA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C9CB RID: 182731
			[Token(Token = "0x402C9CB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}

		// Token: 0x020057B1 RID: 22449
		[Token(Token = "0x20057B1")]
		private class EndingCapsuleAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004CF7 RID: 19703
			// (get) Token: 0x06020D4F RID: 134479 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06020D50 RID: 134480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004CF7")]
			public List<RoguelikeCapsuleViewModel> groupModel
			{
				[Token(Token = "0x6020D4F")]
				[Address(RVA = "0x1B188D0", Offset = "0x1B174D0", VA = "0x181B188D0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6020D50")]
				[Address(RVA = "0x1B18930", Offset = "0x1B17530", VA = "0x181B18930")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004CF8 RID: 19704
			// (get) Token: 0x06020D51 RID: 134481 RVA: 0x000B7810 File Offset: 0x000B5A10
			[Token(Token = "0x17004CF8")]
			public override int count
			{
				[Token(Token = "0x6020D51")]
				[Address(RVA = "0x1B18810", Offset = "0x1B17410", VA = "0x181B18810", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020D52 RID: 134482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020D52")]
			[Address(RVA = "0x1B18590", Offset = "0x1B17190", VA = "0x181B18590", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06020D53 RID: 134483 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D53")]
			[Address(RVA = "0x1B187B0", Offset = "0x1B173B0", VA = "0x181B187B0")]
			public EndingCapsuleAdapter()
			{
			}

			// Token: 0x0402C9CD RID: 182733
			[Token(Token = "0x402C9CD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_groupModel;

			// Token: 0x0402C9CE RID: 182734
			[Token(Token = "0x402C9CE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_groupModel;

			// Token: 0x0402C9CF RID: 182735
			[Token(Token = "0x402C9CF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C9D0 RID: 182736
			[Token(Token = "0x402C9D0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402C9D1 RID: 182737
			[Token(Token = "0x402C9D1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020057B2 RID: 22450
		[Token(Token = "0x20057B2")]
		private class EndingTrapAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004CF9 RID: 19705
			// (get) Token: 0x06020D54 RID: 134484 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06020D55 RID: 134485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004CF9")]
			public List<RoguelikeTrapViewModel> groupModel
			{
				[Token(Token = "0x6020D54")]
				[Address(RVA = "0x1B18D10", Offset = "0x1B17910", VA = "0x181B18D10")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6020D55")]
				[Address(RVA = "0x1B18D70", Offset = "0x1B17970", VA = "0x181B18D70")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004CFA RID: 19706
			// (get) Token: 0x06020D56 RID: 134486 RVA: 0x000B7828 File Offset: 0x000B5A28
			[Token(Token = "0x17004CFA")]
			public override int count
			{
				[Token(Token = "0x6020D56")]
				[Address(RVA = "0x1B18C50", Offset = "0x1B17850", VA = "0x181B18C50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06020D57 RID: 134487 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6020D57")]
			[Address(RVA = "0x1B189B0", Offset = "0x1B175B0", VA = "0x181B189B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06020D58 RID: 134488 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020D58")]
			[Address(RVA = "0x1B18BF0", Offset = "0x1B177F0", VA = "0x181B18BF0")]
			public EndingTrapAdapter()
			{
			}

			// Token: 0x0402C9D3 RID: 182739
			[Token(Token = "0x402C9D3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_groupModel;

			// Token: 0x0402C9D4 RID: 182740
			[Token(Token = "0x402C9D4")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_groupModel;

			// Token: 0x0402C9D5 RID: 182741
			[Token(Token = "0x402C9D5")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402C9D6 RID: 182742
			[Token(Token = "0x402C9D6")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402C9D7 RID: 182743
			[Token(Token = "0x402C9D7")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
