using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054C4 RID: 21700
	[Token(Token = "0x20054C4")]
	public class RoguelikeBankConsumeWithdrawShopControllerBindings : IHotfixable
	{
		// Token: 0x0601FECE RID: 130766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FECE")]
		[Address(RVA = "0x19FFB60", Offset = "0x19FE760", VA = "0x1819FFB60")]
		private RoguelikeBankConsumeWithdrawShopControllerBindings()
		{
		}

		// Token: 0x0601FECF RID: 130767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FECF")]
		[Address(RVA = "0x19FFAF0", Offset = "0x19FE6F0", VA = "0x1819FFAF0")]
		public void OnWithDraw()
		{
		}

		// Token: 0x0601FED0 RID: 130768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FED0")]
		[Address(RVA = "0x19FFA80", Offset = "0x19FE680", VA = "0x1819FFA80")]
		public void OnCancel()
		{
		}

		// Token: 0x0601FED1 RID: 130769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FED1")]
		[Address(RVA = "0x19FF930", Offset = "0x19FE530", VA = "0x1819FF930")]
		public void IncrementCurrent()
		{
		}

		// Token: 0x0601FED2 RID: 130770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FED2")]
		[Address(RVA = "0x19FF8C0", Offset = "0x19FE4C0", VA = "0x1819FF8C0")]
		public void DecrementCurrent()
		{
		}

		// Token: 0x0601FED3 RID: 130771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FED3")]
		[Address(RVA = "0x19FF9A0", Offset = "0x19FE5A0", VA = "0x1819FF9A0")]
		public void MaxCurrent()
		{
		}

		// Token: 0x0601FED4 RID: 130772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FED4")]
		[Address(RVA = "0x19FFA10", Offset = "0x19FE610", VA = "0x1819FFA10")]
		public void MinCurrent()
		{
		}

		// Token: 0x0402B104 RID: 176388
		[Token(Token = "0x402B104")]
		[FieldOffset(Offset = "0x10")]
		private Action m_callWithDrawl;

		// Token: 0x0402B105 RID: 176389
		[Token(Token = "0x402B105")]
		[FieldOffset(Offset = "0x18")]
		private Action m_callOnCancel;

		// Token: 0x0402B106 RID: 176390
		[Token(Token = "0x402B106")]
		[FieldOffset(Offset = "0x20")]
		private Action m_incrementCurrent;

		// Token: 0x0402B107 RID: 176391
		[Token(Token = "0x402B107")]
		[FieldOffset(Offset = "0x28")]
		private Action m_decrementCurrent;

		// Token: 0x0402B108 RID: 176392
		[Token(Token = "0x402B108")]
		[FieldOffset(Offset = "0x30")]
		private Action m_maxCurrent;

		// Token: 0x0402B109 RID: 176393
		[Token(Token = "0x402B109")]
		[FieldOffset(Offset = "0x38")]
		private Action m_minCurrent;

		// Token: 0x0402B10A RID: 176394
		[Token(Token = "0x402B10A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0402B10B RID: 176395
		[Token(Token = "0x402B10B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnWithDraw;

		// Token: 0x0402B10C RID: 176396
		[Token(Token = "0x402B10C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCancel;

		// Token: 0x0402B10D RID: 176397
		[Token(Token = "0x402B10D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IncrementCurrent;

		// Token: 0x0402B10E RID: 176398
		[Token(Token = "0x402B10E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DecrementCurrent;

		// Token: 0x0402B10F RID: 176399
		[Token(Token = "0x402B10F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_MaxCurrent;

		// Token: 0x0402B110 RID: 176400
		[Token(Token = "0x402B110")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_MinCurrent;

		// Token: 0x020054C5 RID: 21701
		[Token(Token = "0x20054C5")]
		public struct Builder
		{
			// Token: 0x0601FED5 RID: 130773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FED5")]
			[Address(RVA = "0x19FEFA0", Offset = "0x19FDBA0", VA = "0x1819FEFA0")]
			public RoguelikeBankConsumeWithdrawShopControllerBindings Build()
			{
				return null;
			}

			// Token: 0x0402B111 RID: 176401
			[Token(Token = "0x402B111")]
			[FieldOffset(Offset = "0x0")]
			public Action onWithDrawl;

			// Token: 0x0402B112 RID: 176402
			[Token(Token = "0x402B112")]
			[FieldOffset(Offset = "0x8")]
			public Action onCancel;

			// Token: 0x0402B113 RID: 176403
			[Token(Token = "0x402B113")]
			[FieldOffset(Offset = "0x10")]
			public Action onIncrementCurrent;

			// Token: 0x0402B114 RID: 176404
			[Token(Token = "0x402B114")]
			[FieldOffset(Offset = "0x18")]
			public Action onDecrementCurrent;

			// Token: 0x0402B115 RID: 176405
			[Token(Token = "0x402B115")]
			[FieldOffset(Offset = "0x20")]
			public Action onMaxCurrent;

			// Token: 0x0402B116 RID: 176406
			[Token(Token = "0x402B116")]
			[FieldOffset(Offset = "0x28")]
			public Action onMinCurrent;
		}
	}
}
