using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002755 RID: 10069
	[Token(Token = "0x2002755")]
	public class BattleWithdrawOperationHandler : AutoChessGameModeTileOperationHandlerBase
	{
		// Token: 0x170023DB RID: 9179
		// (get) Token: 0x0601066C RID: 67180 RVA: 0x00063FF0 File Offset: 0x000621F0
		[Token(Token = "0x170023DB")]
		public override AutoChessOperationType operationType
		{
			[Token(Token = "0x601066C")]
			[Address(RVA = "0x825610", Offset = "0x824210", VA = "0x180825610", Slot = "7")]
			get
			{
				return AutoChessOperationType.MOVE_ONLY;
			}
		}

		// Token: 0x0601066D RID: 67181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601066D")]
		[Address(RVA = "0x825490", Offset = "0x824090", VA = "0x180825490")]
		public void ConstructOperation(GridPosition pos)
		{
		}

		// Token: 0x0601066E RID: 67182 RVA: 0x00064008 File Offset: 0x00062208
		[Token(Token = "0x601066E")]
		[Address(RVA = "0x825430", Offset = "0x824030", VA = "0x180825430", Slot = "4")]
		public override bool CheckOperationValid()
		{
			return default(bool);
		}

		// Token: 0x0601066F RID: 67183 RVA: 0x00064020 File Offset: 0x00062220
		[Token(Token = "0x601066F")]
		[Address(RVA = "0x8253A0", Offset = "0x823FA0", VA = "0x1808253A0", Slot = "5")]
		public override bool Apply()
		{
			return default(bool);
		}

		// Token: 0x06010670 RID: 67184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010670")]
		[Address(RVA = "0x825510", Offset = "0x824110", VA = "0x180825510", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06010671 RID: 67185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010671")]
		[Address(RVA = "0x825570", Offset = "0x824170", VA = "0x180825570")]
		public BattleWithdrawOperationHandler()
		{
		}

		// Token: 0x040125A6 RID: 75174
		[Token(Token = "0x40125A6")]
		[FieldOffset(Offset = "0x10")]
		public bool isBattleField;

		// Token: 0x040125A7 RID: 75175
		[Token(Token = "0x40125A7")]
		[FieldOffset(Offset = "0x11")]
		public bool isToken;

		// Token: 0x040125A8 RID: 75176
		[Token(Token = "0x40125A8")]
		[FieldOffset(Offset = "0x14")]
		public GridPosition pos;

		// Token: 0x040125A9 RID: 75177
		[Token(Token = "0x40125A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_operationType;

		// Token: 0x040125AA RID: 75178
		[Token(Token = "0x40125AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConstructOperation;

		// Token: 0x040125AB RID: 75179
		[Token(Token = "0x40125AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckOperationValid;

		// Token: 0x040125AC RID: 75180
		[Token(Token = "0x40125AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x040125AD RID: 75181
		[Token(Token = "0x40125AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040125AE RID: 75182
		[Token(Token = "0x40125AE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
