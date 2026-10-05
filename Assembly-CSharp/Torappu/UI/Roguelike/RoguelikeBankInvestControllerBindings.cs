using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054CD RID: 21709
	[Token(Token = "0x20054CD")]
	public class RoguelikeBankInvestControllerBindings : IHotfixable
	{
		// Token: 0x0601FEF8 RID: 130808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEF8")]
		[Address(RVA = "0x1A00070", Offset = "0x19FEC70", VA = "0x181A00070")]
		private RoguelikeBankInvestControllerBindings()
		{
		}

		// Token: 0x0601FEF9 RID: 130809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEF9")]
		[Address(RVA = "0x19FFF90", Offset = "0x19FEB90", VA = "0x1819FFF90")]
		public void OnInvest()
		{
		}

		// Token: 0x0601FEFA RID: 130810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEFA")]
		[Address(RVA = "0x19FFF20", Offset = "0x19FEB20", VA = "0x1819FFF20")]
		public void OnCancel()
		{
		}

		// Token: 0x0601FEFB RID: 130811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FEFB")]
		[Address(RVA = "0x1A00000", Offset = "0x19FEC00", VA = "0x181A00000")]
		public void OnOpenBankReward()
		{
		}

		// Token: 0x0402B14D RID: 176461
		[Token(Token = "0x402B14D")]
		[FieldOffset(Offset = "0x10")]
		private Action m_onCancel;

		// Token: 0x0402B14E RID: 176462
		[Token(Token = "0x402B14E")]
		[FieldOffset(Offset = "0x18")]
		private Action m_onInvest;

		// Token: 0x0402B14F RID: 176463
		[Token(Token = "0x402B14F")]
		[FieldOffset(Offset = "0x20")]
		private Action m_onOpenBankReward;

		// Token: 0x0402B150 RID: 176464
		[Token(Token = "0x402B150")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402B151 RID: 176465
		[Token(Token = "0x402B151")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInvest;

		// Token: 0x0402B152 RID: 176466
		[Token(Token = "0x402B152")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0402B153 RID: 176467
		[Token(Token = "0x402B153")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnOpenBankReward;

		// Token: 0x020054CE RID: 21710
		[Token(Token = "0x20054CE")]
		public struct Builder
		{
			// Token: 0x0601FEFC RID: 130812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FEFC")]
			[Address(RVA = "0x19FEED0", Offset = "0x19FDAD0", VA = "0x1819FEED0")]
			public RoguelikeBankInvestControllerBindings Build()
			{
				return null;
			}

			// Token: 0x0402B154 RID: 176468
			[Token(Token = "0x402B154")]
			[FieldOffset(Offset = "0x0")]
			public Action onCancel;

			// Token: 0x0402B155 RID: 176469
			[Token(Token = "0x402B155")]
			[FieldOffset(Offset = "0x8")]
			public Action onInvest;

			// Token: 0x0402B156 RID: 176470
			[Token(Token = "0x402B156")]
			[FieldOffset(Offset = "0x10")]
			public Action onOpenBankReward;
		}
	}
}
