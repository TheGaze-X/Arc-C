using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055BB RID: 21947
	[Token(Token = "0x20055BB")]
	public class RL05SwapCopperView : AbstractRoguelikeSwapCopperView
	{
		// Token: 0x06020381 RID: 131969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020381")]
		[Address(RVA = "0x1A5CE20", Offset = "0x1A5BA20", VA = "0x181A5CE20", Slot = "8")]
		protected override void _Render(RoguelikeSwapCopperViewModel model)
		{
		}

		// Token: 0x06020382 RID: 131970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020382")]
		[Address(RVA = "0x1A5D050", Offset = "0x1A5BC50", VA = "0x181A5D050")]
		public RL05SwapCopperView()
		{
		}

		// Token: 0x0402B95C RID: 178524
		[Token(Token = "0x402B95C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RL05SwapCopperPreviewView _previewView;

		// Token: 0x0402B95D RID: 178525
		[Token(Token = "0x402B95D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RL05SwapCopperListAdapter _listAdapter;

		// Token: 0x0402B95E RID: 178526
		[Token(Token = "0x402B95E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0402B95F RID: 178527
		[Token(Token = "0x402B95F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
