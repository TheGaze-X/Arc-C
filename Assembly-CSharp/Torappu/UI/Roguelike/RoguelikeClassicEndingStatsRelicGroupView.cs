using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052A8 RID: 21160
	[Token(Token = "0x20052A8")]
	public class RoguelikeClassicEndingStatsRelicGroupView : RoguelikeClassicEndingStatsViewComponent<RoguelikeClassicEndingStatsRelicGroupViewModel>
	{
		// Token: 0x17004936 RID: 18742
		// (get) Token: 0x0601F381 RID: 127873 RVA: 0x000B1390 File Offset: 0x000AF590
		[Token(Token = "0x17004936")]
		public bool showTrap
		{
			[Token(Token = "0x601F381")]
			[Address(RVA = "0x18E5200", Offset = "0x18E3E00", VA = "0x1818E5200")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601F382 RID: 127874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F382")]
		[Address(RVA = "0x18E4B00", Offset = "0x18E3700", VA = "0x1818E4B00", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel model, UIPage page)
		{
			return null;
		}

		// Token: 0x0601F383 RID: 127875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F383")]
		[Address(RVA = "0x18E4C40", Offset = "0x18E3840", VA = "0x1818E4C40", Slot = "7")]
		protected override void Render(RoguelikeClassicEndingStatsRelicGroupViewModel viewModel)
		{
		}

		// Token: 0x0601F384 RID: 127876 RVA: 0x000B13A8 File Offset: 0x000AF5A8
		[Token(Token = "0x601F384")]
		[Address(RVA = "0x18E4EB0", Offset = "0x18E3AB0", VA = "0x1818E4EB0")]
		private static float _CalcPrefabHeight(RoguelikeClassicEndingStatsRelicGroupView prefab, RoguelikeClassicEndingStatsRelicGroupViewModel viewModel)
		{
			return 0f;
		}

		// Token: 0x0601F385 RID: 127877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F385")]
		[Address(RVA = "0x18E5070", Offset = "0x18E3C70", VA = "0x1818E5070")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F386 RID: 127878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F386")]
		[Address(RVA = "0x18E5190", Offset = "0x18E3D90", VA = "0x1818E5190")]
		public RoguelikeClassicEndingStatsRelicGroupView()
		{
		}

		// Token: 0x04029EA7 RID: 171687
		[Token(Token = "0x4029EA7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textRelicNum;

		// Token: 0x04029EA8 RID: 171688
		[Token(Token = "0x4029EA8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _relicLayoutContent;

		// Token: 0x04029EA9 RID: 171689
		[Token(Token = "0x4029EA9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GridLayoutGroup _relicLayout;

		// Token: 0x04029EAA RID: 171690
		[Token(Token = "0x4029EAA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _minHeight;

		// Token: 0x04029EAB RID: 171691
		[Token(Token = "0x4029EAB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _showTrap;

		// Token: 0x04029EAC RID: 171692
		[Token(Token = "0x4029EAC")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeClassicEndingStatsRelicGroupView.EndingRelicAdapter m_adapter;

		// Token: 0x04029EAD RID: 171693
		[Token(Token = "0x4029EAD")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeClassicEndingStatsRelicGroupViewModel m_cachedModel;

		// Token: 0x04029EAE RID: 171694
		[Token(Token = "0x4029EAE")]
		[FieldOffset(Offset = "0x50")]
		private List<IRoguelikeRelicViewModel> m_wholeRelicViewModels;

		// Token: 0x04029EAF RID: 171695
		[Token(Token = "0x4029EAF")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04029EB0 RID: 171696
		[Token(Token = "0x4029EB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showTrap;

		// Token: 0x04029EB1 RID: 171697
		[Token(Token = "0x4029EB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x04029EB2 RID: 171698
		[Token(Token = "0x4029EB2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029EB3 RID: 171699
		[Token(Token = "0x4029EB3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CalcPrefabHeight;

		// Token: 0x04029EB4 RID: 171700
		[Token(Token = "0x4029EB4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029EB5 RID: 171701
		[Token(Token = "0x4029EB5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052A9 RID: 21161
		[Token(Token = "0x20052A9")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RoguelikeClassicEndingStatsRelicGroupView, RoguelikeClassicEndingStatsRelicGroupViewModel>
		{
			// Token: 0x0601F387 RID: 127879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F387")]
			[Address(RVA = "0x18F2D80", Offset = "0x18F1980", VA = "0x1818F2D80")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x0601F388 RID: 127880 RVA: 0x000B13C0 File Offset: 0x000AF5C0
			[Token(Token = "0x601F388")]
			[Address(RVA = "0x18F2C50", Offset = "0x18F1850", VA = "0x1818F2C50", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x04029EB6 RID: 171702
			[Token(Token = "0x4029EB6")]
			[FieldOffset(Offset = "0x38")]
			private float m_cachedHeight;

			// Token: 0x04029EB7 RID: 171703
			[Token(Token = "0x4029EB7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029EB8 RID: 171704
			[Token(Token = "0x4029EB8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}

		// Token: 0x020052AA RID: 21162
		[Token(Token = "0x20052AA")]
		private class EndingRelicAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601F389 RID: 127881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F389")]
			[Address(RVA = "0x18DE110", Offset = "0x18DCD10", VA = "0x1818DE110")]
			public EndingRelicAdapter(RoguelikeClassicEndingStatsRelicGroupView closure)
			{
			}

			// Token: 0x17004937 RID: 18743
			// (get) Token: 0x0601F38A RID: 127882 RVA: 0x000B13D8 File Offset: 0x000AF5D8
			[Token(Token = "0x17004937")]
			public override int count
			{
				[Token(Token = "0x601F38A")]
				[Address(RVA = "0x18DE190", Offset = "0x18DCD90", VA = "0x1818DE190", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601F38B RID: 127883 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F38B")]
			[Address(RVA = "0x18DDD90", Offset = "0x18DC990", VA = "0x1818DDD90", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04029EB9 RID: 171705
			[Token(Token = "0x4029EB9")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeClassicEndingStatsRelicGroupView m_closure;

			// Token: 0x04029EBA RID: 171706
			[Token(Token = "0x4029EBA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029EBB RID: 171707
			[Token(Token = "0x4029EBB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04029EBC RID: 171708
			[Token(Token = "0x4029EBC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
