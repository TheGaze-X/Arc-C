using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052A6 RID: 21158
	[Token(Token = "0x20052A6")]
	public class RoguelikeClassicEndingStatsInfoView : RoguelikeClassicEndingStatsViewComponent<RoguelikeClassicEndingStatsInfoViewModel>
	{
		// Token: 0x0601F37C RID: 127868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F37C")]
		[Address(RVA = "0x18E44C0", Offset = "0x18E30C0", VA = "0x1818E44C0", Slot = "5")]
		public override UIRecycleLayoutAdapter.IVirtualView CreateVirtualView(RoguelikeClassicEndingStatsViewComponentBase compPrefab, RoguelikeClassicEndingStatsViewComponentModel model, UIPage page)
		{
			return null;
		}

		// Token: 0x0601F37D RID: 127869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F37D")]
		[Address(RVA = "0x18E45F0", Offset = "0x18E31F0", VA = "0x1818E45F0", Slot = "7")]
		protected override void Render(RoguelikeClassicEndingStatsInfoViewModel viewModel)
		{
		}

		// Token: 0x0601F37E RID: 127870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F37E")]
		[Address(RVA = "0x18E4A90", Offset = "0x18E3690", VA = "0x1818E4A90")]
		public RoguelikeClassicEndingStatsInfoView()
		{
		}

		// Token: 0x04029E9C RID: 171676
		[Token(Token = "0x4029E9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _preferHeight;

		// Token: 0x04029E9D RID: 171677
		[Token(Token = "0x4029E9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imageRelicIcon;

		// Token: 0x04029E9E RID: 171678
		[Token(Token = "0x4029E9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textBasicInfo;

		// Token: 0x04029E9F RID: 171679
		[Token(Token = "0x4029E9F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textEndInfo;

		// Token: 0x04029EA0 RID: 171680
		[Token(Token = "0x4029EA0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textEndDesc;

		// Token: 0x04029EA1 RID: 171681
		[Token(Token = "0x4029EA1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _highlightColor;

		// Token: 0x04029EA2 RID: 171682
		[Token(Token = "0x4029EA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateVirtualView;

		// Token: 0x04029EA3 RID: 171683
		[Token(Token = "0x4029EA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029EA4 RID: 171684
		[Token(Token = "0x4029EA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052A7 RID: 21159
		[Token(Token = "0x20052A7")]
		public class VirtualView : RoguelikeClassicEndingStatsCompVirtualView<RoguelikeClassicEndingStatsInfoView, RoguelikeClassicEndingStatsInfoViewModel>
		{
			// Token: 0x0601F37F RID: 127871 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F37F")]
			[Address(RVA = "0x18F2CD0", Offset = "0x18F18D0", VA = "0x1818F2CD0")]
			public VirtualView(RoguelikeClassicEndingStatsViewComponentBase prefab, RoguelikeClassicEndingStatsViewComponentModel viewModel, UIPage page)
			{
			}

			// Token: 0x0601F380 RID: 127872 RVA: 0x000B1378 File Offset: 0x000AF578
			[Token(Token = "0x601F380")]
			[Address(RVA = "0x18F29E0", Offset = "0x18F15E0", VA = "0x1818F29E0", Slot = "13")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x04029EA5 RID: 171685
			[Token(Token = "0x4029EA5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029EA6 RID: 171686
			[Token(Token = "0x4029EA6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetPreferSize;
		}
	}
}
