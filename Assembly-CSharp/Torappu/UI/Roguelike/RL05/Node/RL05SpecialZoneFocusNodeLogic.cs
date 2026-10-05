using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05.Node
{
	// Token: 0x0200564E RID: 22094
	[Token(Token = "0x200564E")]
	public class RL05SpecialZoneFocusNodeLogic : MonoBehaviour, IRoguelikeFocusNodePlugin, IHotfixable
	{
		// Token: 0x06020690 RID: 132752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020690")]
		[Address(RVA = "0x1AA1A70", Offset = "0x1AA0670", VA = "0x181AA1A70", Slot = "4")]
		public void Render(RoguelikeDungeonNode node)
		{
		}

		// Token: 0x06020691 RID: 132753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020691")]
		[Address(RVA = "0x1AA1BA0", Offset = "0x1AA07A0", VA = "0x181AA1BA0")]
		public RL05SpecialZoneFocusNodeLogic()
		{
		}

		// Token: 0x0402BE23 RID: 179747
		[Token(Token = "0x402BE23")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _frameImg;

		// Token: 0x0402BE24 RID: 179748
		[Token(Token = "0x402BE24")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402BE25 RID: 179749
		[Token(Token = "0x402BE25")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
