using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.Dice
{
	// Token: 0x02005894 RID: 22676
	[Token(Token = "0x2005894")]
	public class RoguelikeDiceGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x060211A8 RID: 135592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60211A8")]
		[Address(RVA = "0x1B7E170", Offset = "0x1B7CD70", VA = "0x181B7E170")]
		public void RollTo(RoguelikeDiceModelType diceType, int sideNum)
		{
		}

		// Token: 0x060211A9 RID: 135593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60211A9")]
		[Address(RVA = "0x1B7E320", Offset = "0x1B7CF20", VA = "0x181B7E320")]
		public RoguelikeDiceGroup()
		{
		}

		// Token: 0x0402D12B RID: 184619
		[Token(Token = "0x402D12B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0402D12C RID: 184620
		[Token(Token = "0x402D12C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeDiceGroup.DiceItem[] _dices;

		// Token: 0x0402D12D RID: 184621
		[Token(Token = "0x402D12D")]
		private const string SIDE_TYPE = "DiceType";

		// Token: 0x0402D12E RID: 184622
		[Token(Token = "0x402D12E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RollTo;

		// Token: 0x0402D12F RID: 184623
		[Token(Token = "0x402D12F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005895 RID: 22677
		[Token(Token = "0x2005895")]
		[Serializable]
		public struct DiceItem
		{
			// Token: 0x0402D130 RID: 184624
			[Token(Token = "0x402D130")]
			[FieldOffset(Offset = "0x0")]
			public int sideCount;

			// Token: 0x0402D131 RID: 184625
			[Token(Token = "0x402D131")]
			[FieldOffset(Offset = "0x8")]
			public string animName;

			// Token: 0x0402D132 RID: 184626
			[Token(Token = "0x402D132")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeDice dice;
		}
	}
}
