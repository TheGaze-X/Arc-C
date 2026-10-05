using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x0200557F RID: 21887
	[Token(Token = "0x200557F")]
	public class RL05ClassicEndingStatsInfoView : RoguelikeClassicEndingStatsViewComponent<RoguelikeClassicEndingStatsInfoViewModel>
	{
		// Token: 0x0602028D RID: 131725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602028D")]
		[Address(RVA = "0x1A34E10", Offset = "0x1A33A10", VA = "0x181A34E10", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel model, UIPage page)
		{
			return null;
		}

		// Token: 0x0602028E RID: 131726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602028E")]
		[Address(RVA = "0x1A34F60", Offset = "0x1A33B60", VA = "0x181A34F60", Slot = "7")]
		protected override void Render(RoguelikeClassicEndingStatsInfoViewModel viewModel)
		{
		}

		// Token: 0x0602028F RID: 131727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602028F")]
		[Address(RVA = "0x1A35530", Offset = "0x1A34130", VA = "0x181A35530")]
		public RL05ClassicEndingStatsInfoView()
		{
		}

		// Token: 0x0402B713 RID: 177939
		[Token(Token = "0x402B713")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color NORMAL_SQUAD_ICON_COLOR;

		// Token: 0x0402B714 RID: 177940
		[Token(Token = "0x402B714")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color UPGRADABLE_SQUAD_ICON_COLOR;

		// Token: 0x0402B715 RID: 177941
		[Token(Token = "0x402B715")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _preferHeight;

		// Token: 0x0402B716 RID: 177942
		[Token(Token = "0x402B716")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageRelicIcon;

		// Token: 0x0402B717 RID: 177943
		[Token(Token = "0x402B717")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textBasicInfo;

		// Token: 0x0402B718 RID: 177944
		[Token(Token = "0x402B718")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEndInfo;

		// Token: 0x0402B719 RID: 177945
		[Token(Token = "0x402B719")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textEndDesc;

		// Token: 0x0402B71A RID: 177946
		[Token(Token = "0x402B71A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _highlightColor;

		// Token: 0x0402B71B RID: 177947
		[Token(Token = "0x402B71B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x0402B71C RID: 177948
		[Token(Token = "0x402B71C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B71D RID: 177949
		[Token(Token = "0x402B71D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005580 RID: 21888
		[Token(Token = "0x2005580")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RL05ClassicEndingStatsInfoView, RoguelikeClassicEndingStatsInfoViewModel>
		{
			// Token: 0x06020291 RID: 131729 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020291")]
			[Address(RVA = "0x1A47350", Offset = "0x1A45F50", VA = "0x181A47350")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x06020292 RID: 131730 RVA: 0x000B4DB0 File Offset: 0x000B2FB0
			[Token(Token = "0x6020292")]
			[Address(RVA = "0x1A47020", Offset = "0x1A45C20", VA = "0x181A47020", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402B71E RID: 177950
			[Token(Token = "0x402B71E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402B71F RID: 177951
			[Token(Token = "0x402B71F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
