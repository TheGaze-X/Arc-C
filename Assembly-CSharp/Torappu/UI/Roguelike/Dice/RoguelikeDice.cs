using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.Dice
{
	// Token: 0x02005893 RID: 22675
	[Token(Token = "0x2005893")]
	public class RoguelikeDice : MonoBehaviour, IHotfixable
	{
		// Token: 0x060211A6 RID: 135590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60211A6")]
		[Address(RVA = "0x1B7E380", Offset = "0x1B7CF80", VA = "0x181B7E380")]
		public void Rotate(int targetSideNum)
		{
		}

		// Token: 0x060211A7 RID: 135591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60211A7")]
		[Address(RVA = "0x1B7E4D0", Offset = "0x1B7D0D0", VA = "0x181B7E4D0")]
		public RoguelikeDice()
		{
		}

		// Token: 0x0402D128 RID: 184616
		[Token(Token = "0x402D128")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Quaternion[] _sides;

		// Token: 0x0402D129 RID: 184617
		[Token(Token = "0x402D129")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Rotate;

		// Token: 0x0402D12A RID: 184618
		[Token(Token = "0x402D12A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
