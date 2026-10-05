using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054D1 RID: 21713
	[Token(Token = "0x20054D1")]
	public class RoguelikeBankWithdrawControllerBindings : IHotfixable
	{
		// Token: 0x0601FF0A RID: 130826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF0A")]
		[Address(RVA = "0x1A00220", Offset = "0x19FEE20", VA = "0x181A00220")]
		private RoguelikeBankWithdrawControllerBindings()
		{
		}

		// Token: 0x0601FF0B RID: 130827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF0B")]
		[Address(RVA = "0x1A001B0", Offset = "0x19FEDB0", VA = "0x181A001B0")]
		public void OnWithDraw()
		{
		}

		// Token: 0x0601FF0C RID: 130828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF0C")]
		[Address(RVA = "0x1A000D0", Offset = "0x19FECD0", VA = "0x181A000D0")]
		public void OnCancel()
		{
		}

		// Token: 0x0601FF0D RID: 130829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FF0D")]
		[Address(RVA = "0x1A00140", Offset = "0x19FED40", VA = "0x181A00140")]
		public void OnOpenBankReward()
		{
		}

		// Token: 0x0402B16D RID: 176493
		[Token(Token = "0x402B16D")]
		[FieldOffset(Offset = "0x10")]
		private Action m_callWithDrawl;

		// Token: 0x0402B16E RID: 176494
		[Token(Token = "0x402B16E")]
		[FieldOffset(Offset = "0x18")]
		private Action m_callOnCancel;

		// Token: 0x0402B16F RID: 176495
		[Token(Token = "0x402B16F")]
		[FieldOffset(Offset = "0x20")]
		private Action m_onOpenBankReward;

		// Token: 0x0402B170 RID: 176496
		[Token(Token = "0x402B170")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402B171 RID: 176497
		[Token(Token = "0x402B171")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnWithDraw;

		// Token: 0x0402B172 RID: 176498
		[Token(Token = "0x402B172")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0402B173 RID: 176499
		[Token(Token = "0x402B173")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnOpenBankReward;

		// Token: 0x020054D2 RID: 21714
		[Token(Token = "0x20054D2")]
		public struct Builder
		{
			// Token: 0x0601FF0E RID: 130830 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FF0E")]
			[Address(RVA = "0x19FF240", Offset = "0x19FDE40", VA = "0x1819FF240")]
			public RoguelikeBankWithdrawControllerBindings Build()
			{
				return null;
			}

			// Token: 0x0402B174 RID: 176500
			[Token(Token = "0x402B174")]
			[FieldOffset(Offset = "0x0")]
			public Action onWithDrawl;

			// Token: 0x0402B175 RID: 176501
			[Token(Token = "0x402B175")]
			[FieldOffset(Offset = "0x8")]
			public Action onCancel;

			// Token: 0x0402B176 RID: 176502
			[Token(Token = "0x402B176")]
			[FieldOffset(Offset = "0x10")]
			public Action onOpenBankReward;
		}
	}
}
