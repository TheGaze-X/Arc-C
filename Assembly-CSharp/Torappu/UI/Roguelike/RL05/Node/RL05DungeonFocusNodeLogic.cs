using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05.Node
{
	// Token: 0x0200564C RID: 22092
	[Token(Token = "0x200564C")]
	public class RL05DungeonFocusNodeLogic : MonoBehaviour, IRoguelikeFocusNodePlugin, IHotfixable
	{
		// Token: 0x06020683 RID: 132739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020683")]
		[Address(RVA = "0x1A74B60", Offset = "0x1A73760", VA = "0x181A74B60", Slot = "4")]
		public void Render(RoguelikeDungeonNode node)
		{
		}

		// Token: 0x06020684 RID: 132740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020684")]
		[Address(RVA = "0x1A74CB0", Offset = "0x1A738B0", VA = "0x181A74CB0")]
		public RL05DungeonFocusNodeLogic()
		{
		}

		// Token: 0x0402BE0E RID: 179726
		[Token(Token = "0x402BE0E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _frameImg;

		// Token: 0x0402BE0F RID: 179727
		[Token(Token = "0x402BE0F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeNodeViewData _nodeViewData;

		// Token: 0x0402BE10 RID: 179728
		[Token(Token = "0x402BE10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BE11 RID: 179729
		[Token(Token = "0x402BE11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
