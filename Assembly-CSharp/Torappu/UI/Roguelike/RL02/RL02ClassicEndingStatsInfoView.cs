using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005735 RID: 22325
	[Token(Token = "0x2005735")]
	public class RL02ClassicEndingStatsInfoView : RoguelikeClassicEndingStatsViewComponent<RoguelikeClassicEndingStatsInfoViewModel>
	{
		// Token: 0x06020B86 RID: 134022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020B86")]
		[Address(RVA = "0x1B054E0", Offset = "0x1B040E0", VA = "0x181B054E0", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel model, UIPage page)
		{
			return null;
		}

		// Token: 0x06020B87 RID: 134023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B87")]
		[Address(RVA = "0x1B05630", Offset = "0x1B04230", VA = "0x181B05630", Slot = "7")]
		protected override void Render(RoguelikeClassicEndingStatsInfoViewModel viewModel)
		{
		}

		// Token: 0x06020B88 RID: 134024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B88")]
		[Address(RVA = "0x1B05D00", Offset = "0x1B04900", VA = "0x181B05D00")]
		public RL02ClassicEndingStatsInfoView()
		{
		}

		// Token: 0x0402C69E RID: 181918
		[Token(Token = "0x402C69E")]
		[FieldOffset(Offset = "0x0")]
		private static Color NORMAL_SQUAD_ICON_COLOR;

		// Token: 0x0402C69F RID: 181919
		[Token(Token = "0x402C69F")]
		[FieldOffset(Offset = "0x10")]
		private static Color UPGRADABLE_SQUAD_ICON_COLOR;

		// Token: 0x0402C6A0 RID: 181920
		[Token(Token = "0x402C6A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _preferHeight;

		// Token: 0x0402C6A1 RID: 181921
		[Token(Token = "0x402C6A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageRelicIcon;

		// Token: 0x0402C6A2 RID: 181922
		[Token(Token = "0x402C6A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textBasicInfo;

		// Token: 0x0402C6A3 RID: 181923
		[Token(Token = "0x402C6A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEndInfo;

		// Token: 0x0402C6A4 RID: 181924
		[Token(Token = "0x402C6A4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textEndDesc;

		// Token: 0x0402C6A5 RID: 181925
		[Token(Token = "0x402C6A5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _highlightColor;

		// Token: 0x0402C6A6 RID: 181926
		[Token(Token = "0x402C6A6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAtlasImage _imageUpgradeRank;

		// Token: 0x0402C6A7 RID: 181927
		[Token(Token = "0x402C6A7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAtlasObject _squadUpgradeRankAtlas;

		// Token: 0x0402C6A8 RID: 181928
		[Token(Token = "0x402C6A8")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string[] _squadUpgradeRankImageName;

		// Token: 0x0402C6A9 RID: 181929
		[Token(Token = "0x402C6A9")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x0402C6AA RID: 181930
		[Token(Token = "0x402C6AA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x0402C6AB RID: 181931
		[Token(Token = "0x402C6AB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C6AC RID: 181932
		[Token(Token = "0x402C6AC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005736 RID: 22326
		[Token(Token = "0x2005736")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RL02ClassicEndingStatsInfoView, RoguelikeClassicEndingStatsInfoViewModel>
		{
			// Token: 0x06020B8A RID: 134026 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020B8A")]
			[Address(RVA = "0x1B17D90", Offset = "0x1B16990", VA = "0x181B17D90")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x06020B8B RID: 134027 RVA: 0x000B6F58 File Offset: 0x000B5158
			[Token(Token = "0x6020B8B")]
			[Address(RVA = "0x1B17A70", Offset = "0x1B16670", VA = "0x181B17A70", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402C6AD RID: 181933
			[Token(Token = "0x402C6AD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402C6AE RID: 181934
			[Token(Token = "0x402C6AE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
