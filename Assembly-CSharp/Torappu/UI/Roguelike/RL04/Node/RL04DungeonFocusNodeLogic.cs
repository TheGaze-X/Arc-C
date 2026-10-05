using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04.Node
{
	// Token: 0x02005726 RID: 22310
	[Token(Token = "0x2005726")]
	public class RL04DungeonFocusNodeLogic : MonoBehaviour, IRoguelikeFocusNodePlugin, IHotfixable
	{
		// Token: 0x06020B32 RID: 133938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B32")]
		[Address(RVA = "0x1B0F280", Offset = "0x1B0DE80", VA = "0x181B0F280", Slot = "4")]
		public void Render(RoguelikeDungeonNode node)
		{
		}

		// Token: 0x06020B33 RID: 133939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B33")]
		[Address(RVA = "0x1B0F2E0", Offset = "0x1B0DEE0", VA = "0x181B0F2E0")]
		public RL04DungeonFocusNodeLogic()
		{
		}

		// Token: 0x0402C61D RID: 181789
		[Token(Token = "0x402C61D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _backImg;

		// Token: 0x0402C61E RID: 181790
		[Token(Token = "0x402C61E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeNodeViewData _nodeViewData;

		// Token: 0x0402C61F RID: 181791
		[Token(Token = "0x402C61F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C620 RID: 181792
		[Token(Token = "0x402C620")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
