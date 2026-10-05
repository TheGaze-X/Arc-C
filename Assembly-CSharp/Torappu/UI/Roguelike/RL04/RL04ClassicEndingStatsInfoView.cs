using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005699 RID: 22169
	[Token(Token = "0x2005699")]
	public class RL04ClassicEndingStatsInfoView : RoguelikeClassicEndingStatsViewComponent<RoguelikeClassicEndingStatsInfoViewModel>
	{
		// Token: 0x06020852 RID: 133202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020852")]
		[Address(RVA = "0x1AA5C70", Offset = "0x1AA4870", VA = "0x181AA5C70", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel model, UIPage page)
		{
			return null;
		}

		// Token: 0x06020853 RID: 133203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020853")]
		[Address(RVA = "0x1AA5DC0", Offset = "0x1AA49C0", VA = "0x181AA5DC0", Slot = "7")]
		protected override void Render(RoguelikeClassicEndingStatsInfoViewModel viewModel)
		{
		}

		// Token: 0x06020854 RID: 133204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020854")]
		[Address(RVA = "0x1AA6390", Offset = "0x1AA4F90", VA = "0x181AA6390")]
		public RL04ClassicEndingStatsInfoView()
		{
		}

		// Token: 0x0402C111 RID: 180497
		[Token(Token = "0x402C111")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color NORMAL_SQUAD_ICON_COLOR;

		// Token: 0x0402C112 RID: 180498
		[Token(Token = "0x402C112")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color UPGRADABLE_SQUAD_ICON_COLOR;

		// Token: 0x0402C113 RID: 180499
		[Token(Token = "0x402C113")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _preferHeight;

		// Token: 0x0402C114 RID: 180500
		[Token(Token = "0x402C114")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageRelicIcon;

		// Token: 0x0402C115 RID: 180501
		[Token(Token = "0x402C115")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textBasicInfo;

		// Token: 0x0402C116 RID: 180502
		[Token(Token = "0x402C116")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEndInfo;

		// Token: 0x0402C117 RID: 180503
		[Token(Token = "0x402C117")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textEndDesc;

		// Token: 0x0402C118 RID: 180504
		[Token(Token = "0x402C118")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _highlightColor;

		// Token: 0x0402C119 RID: 180505
		[Token(Token = "0x402C119")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x0402C11A RID: 180506
		[Token(Token = "0x402C11A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C11B RID: 180507
		[Token(Token = "0x402C11B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200569A RID: 22170
		[Token(Token = "0x200569A")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RL04ClassicEndingStatsInfoView, RoguelikeClassicEndingStatsInfoViewModel>
		{
			// Token: 0x06020856 RID: 133206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020856")]
			[Address(RVA = "0x1AB9C60", Offset = "0x1AB8860", VA = "0x181AB9C60")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x06020857 RID: 133207 RVA: 0x000B6490 File Offset: 0x000B4690
			[Token(Token = "0x6020857")]
			[Address(RVA = "0x1AB92E0", Offset = "0x1AB7EE0", VA = "0x181AB92E0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402C11C RID: 180508
			[Token(Token = "0x402C11C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C11D RID: 180509
			[Token(Token = "0x402C11D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
