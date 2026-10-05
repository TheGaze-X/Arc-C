using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054C7 RID: 21703
	[Token(Token = "0x20054C7")]
	public class RoguelikeBankEntryControllerBindings : IHotfixable
	{
		// Token: 0x0601FEDF RID: 130783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEDF")]
		[Address(RVA = "0x19FFD80", Offset = "0x19FE980", VA = "0x1819FFD80")]
		private RoguelikeBankEntryControllerBindings()
		{
		}

		// Token: 0x0601FEE0 RID: 130784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEE0")]
		[Address(RVA = "0x19FFD10", Offset = "0x19FE910", VA = "0x1819FFD10")]
		public void OnOpenWithdraw()
		{
		}

		// Token: 0x0601FEE1 RID: 130785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEE1")]
		[Address(RVA = "0x19FFCA0", Offset = "0x19FE8A0", VA = "0x1819FFCA0")]
		public void OnOpenInvest()
		{
		}

		// Token: 0x0601FEE2 RID: 130786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEE2")]
		[Address(RVA = "0x19FFBC0", Offset = "0x19FE7C0", VA = "0x1819FFBC0")]
		public void OnCancel()
		{
		}

		// Token: 0x0601FEE3 RID: 130787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEE3")]
		[Address(RVA = "0x19FFC30", Offset = "0x19FE830", VA = "0x1819FFC30")]
		public void OnOpenBankReward()
		{
		}

		// Token: 0x0402B123 RID: 176419
		[Token(Token = "0x402B123")]
		[FieldOffset(Offset = "0x10")]
		private Action m_onCancel;

		// Token: 0x0402B124 RID: 176420
		[Token(Token = "0x402B124")]
		[FieldOffset(Offset = "0x18")]
		private Action m_onOpenWithdraw;

		// Token: 0x0402B125 RID: 176421
		[Token(Token = "0x402B125")]
		[FieldOffset(Offset = "0x20")]
		private Action m_onOpenInvest;

		// Token: 0x0402B126 RID: 176422
		[Token(Token = "0x402B126")]
		[FieldOffset(Offset = "0x28")]
		private Action m_onOpenBankReward;

		// Token: 0x0402B127 RID: 176423
		[Token(Token = "0x402B127")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402B128 RID: 176424
		[Token(Token = "0x402B128")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnOpenWithdraw;

		// Token: 0x0402B129 RID: 176425
		[Token(Token = "0x402B129")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnOpenInvest;

		// Token: 0x0402B12A RID: 176426
		[Token(Token = "0x402B12A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0402B12B RID: 176427
		[Token(Token = "0x402B12B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnOpenBankReward;

		// Token: 0x020054C8 RID: 21704
		[Token(Token = "0x20054C8")]
		public struct Builder
		{
			// Token: 0x0601FEE4 RID: 130788 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FEE4")]
			[Address(RVA = "0x19FF0A0", Offset = "0x19FDCA0", VA = "0x1819FF0A0")]
			public RoguelikeBankEntryControllerBindings Build()
			{
				return null;
			}

			// Token: 0x0402B12C RID: 176428
			[Token(Token = "0x402B12C")]
			[FieldOffset(Offset = "0x0")]
			public Action onCancel;

			// Token: 0x0402B12D RID: 176429
			[Token(Token = "0x402B12D")]
			[FieldOffset(Offset = "0x8")]
			public Action onOpenWithdraw;

			// Token: 0x0402B12E RID: 176430
			[Token(Token = "0x402B12E")]
			[FieldOffset(Offset = "0x10")]
			public Action onOpenInvest;

			// Token: 0x0402B12F RID: 176431
			[Token(Token = "0x402B12F")]
			[FieldOffset(Offset = "0x18")]
			public Action onOpenBankReward;
		}
	}
}
