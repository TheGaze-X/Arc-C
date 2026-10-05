using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005818 RID: 22552
	[Token(Token = "0x2005818")]
	public class RL03ClassicEndingStatsInfoView : RoguelikeClassicEndingStatsViewComponent<RoguelikeClassicEndingStatsInfoViewModel>
	{
		// Token: 0x06020F4E RID: 134990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020F4E")]
		[Address(RVA = "0x1B46170", Offset = "0x1B44D70", VA = "0x181B46170", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel model, UIPage page)
		{
			return null;
		}

		// Token: 0x06020F4F RID: 134991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F4F")]
		[Address(RVA = "0x1B462C0", Offset = "0x1B44EC0", VA = "0x181B462C0", Slot = "7")]
		protected override void Render(RoguelikeClassicEndingStatsInfoViewModel viewModel)
		{
		}

		// Token: 0x06020F50 RID: 134992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F50")]
		[Address(RVA = "0x1B467D0", Offset = "0x1B453D0", VA = "0x181B467D0")]
		public RL03ClassicEndingStatsInfoView()
		{
		}

		// Token: 0x0402CCF8 RID: 183544
		[Token(Token = "0x402CCF8")]
		[FieldOffset(Offset = "0x0")]
		private static Color NORMAL_SQUAD_ICON_COLOR;

		// Token: 0x0402CCF9 RID: 183545
		[Token(Token = "0x402CCF9")]
		[FieldOffset(Offset = "0x10")]
		private static Color UPGRADABLE_SQUAD_ICON_COLOR;

		// Token: 0x0402CCFA RID: 183546
		[Token(Token = "0x402CCFA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _preferHeight;

		// Token: 0x0402CCFB RID: 183547
		[Token(Token = "0x402CCFB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageRelicIcon;

		// Token: 0x0402CCFC RID: 183548
		[Token(Token = "0x402CCFC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textBasicInfo;

		// Token: 0x0402CCFD RID: 183549
		[Token(Token = "0x402CCFD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEndInfo;

		// Token: 0x0402CCFE RID: 183550
		[Token(Token = "0x402CCFE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textEndDesc;

		// Token: 0x0402CCFF RID: 183551
		[Token(Token = "0x402CCFF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _highlightColor;

		// Token: 0x0402CD00 RID: 183552
		[Token(Token = "0x402CD00")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x0402CD01 RID: 183553
		[Token(Token = "0x402CD01")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CD02 RID: 183554
		[Token(Token = "0x402CD02")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005819 RID: 22553
		[Token(Token = "0x2005819")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RL03ClassicEndingStatsInfoView, RoguelikeClassicEndingStatsInfoViewModel>
		{
			// Token: 0x06020F52 RID: 134994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6020F52")]
			[Address(RVA = "0x1B5A6A0", Offset = "0x1B592A0", VA = "0x181B5A6A0")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x06020F53 RID: 134995 RVA: 0x000B7F30 File Offset: 0x000B6130
			[Token(Token = "0x6020F53")]
			[Address(RVA = "0x1B59C40", Offset = "0x1B58840", VA = "0x181B59C40", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x0402CD03 RID: 183555
			[Token(Token = "0x402CD03")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402CD04 RID: 183556
			[Token(Token = "0x402CD04")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
