using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054CA RID: 21706
	[Token(Token = "0x20054CA")]
	public class RoguelikeBankFaultyControllerBindings : IHotfixable
	{
		// Token: 0x0601FEEC RID: 130796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEEC")]
		[Address(RVA = "0x19FFEC0", Offset = "0x19FEAC0", VA = "0x1819FFEC0")]
		private RoguelikeBankFaultyControllerBindings()
		{
		}

		// Token: 0x0601FEED RID: 130797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEED")]
		[Address(RVA = "0x19FFDE0", Offset = "0x19FE9E0", VA = "0x1819FFDE0")]
		public void OnCancel()
		{
		}

		// Token: 0x0601FEEE RID: 130798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEEE")]
		[Address(RVA = "0x19FFE50", Offset = "0x19FEA50", VA = "0x1819FFE50")]
		public void OnOpenBankReward()
		{
		}

		// Token: 0x0402B138 RID: 176440
		[Token(Token = "0x402B138")]
		[FieldOffset(Offset = "0x10")]
		private Action m_onCancel;

		// Token: 0x0402B139 RID: 176441
		[Token(Token = "0x402B139")]
		[FieldOffset(Offset = "0x18")]
		private Action m_onOpenBankReward;

		// Token: 0x0402B13A RID: 176442
		[Token(Token = "0x402B13A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402B13B RID: 176443
		[Token(Token = "0x402B13B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0402B13C RID: 176444
		[Token(Token = "0x402B13C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnOpenBankReward;

		// Token: 0x020054CB RID: 21707
		[Token(Token = "0x20054CB")]
		public struct Builder
		{
			// Token: 0x0601FEEF RID: 130799 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FEEF")]
			[Address(RVA = "0x19FF180", Offset = "0x19FDD80", VA = "0x1819FF180")]
			public RoguelikeBankFaultyControllerBindings Build()
			{
				return null;
			}

			// Token: 0x0402B13D RID: 176445
			[Token(Token = "0x402B13D")]
			[FieldOffset(Offset = "0x0")]
			public Action onCancel;

			// Token: 0x0402B13E RID: 176446
			[Token(Token = "0x402B13E")]
			[FieldOffset(Offset = "0x8")]
			public Action onOpenBankReward;
		}
	}
}
