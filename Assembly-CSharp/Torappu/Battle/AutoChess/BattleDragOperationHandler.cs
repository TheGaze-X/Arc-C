using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002756 RID: 10070
	[Token(Token = "0x2002756")]
	public class BattleDragOperationHandler : AutoChessGameModeTileOperationHandlerBase
	{
		// Token: 0x170023DC RID: 9180
		// (get) Token: 0x06010672 RID: 67186 RVA: 0x00064038 File Offset: 0x00062238
		[Token(Token = "0x170023DC")]
		public override AutoChessOperationType operationType
		{
			[Token(Token = "0x6010672")]
			[Address(RVA = "0x825340", Offset = "0x823F40", VA = "0x180825340", Slot = "7")]
			get
			{
				return AutoChessOperationType.MOVE_ONLY;
			}
		}

		// Token: 0x06010673 RID: 67187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010673")]
		[Address(RVA = "0x822C90", Offset = "0x821890", VA = "0x180822C90")]
		public void ConstructOperation(AutoChessOperationType operationType, GridPosition start, GridPosition end, SharedConsts.Direction direction = SharedConsts.Direction.RIGHT)
		{
		}

		// Token: 0x06010674 RID: 67188 RVA: 0x00064050 File Offset: 0x00062250
		[Token(Token = "0x6010674")]
		[Address(RVA = "0x822B10", Offset = "0x821710", VA = "0x180822B10", Slot = "4")]
		public override bool CheckOperationValid()
		{
			return default(bool);
		}

		// Token: 0x06010675 RID: 67189 RVA: 0x00064068 File Offset: 0x00062268
		[Token(Token = "0x6010675")]
		[Address(RVA = "0x822790", Offset = "0x821390", VA = "0x180822790", Slot = "5")]
		public override bool Apply()
		{
			return default(bool);
		}

		// Token: 0x06010676 RID: 67190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010676")]
		[Address(RVA = "0x823050", Offset = "0x821C50", VA = "0x180823050", Slot = "6")]
		public override void Reset()
		{
		}

		// Token: 0x06010677 RID: 67191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010677")]
		[Address(RVA = "0x823280", Offset = "0x821E80", VA = "0x180823280")]
		private void _ApplyFlag(AutoChessDragOperationFlag flag, bool apply)
		{
		}

		// Token: 0x06010678 RID: 67192 RVA: 0x00064080 File Offset: 0x00062280
		[Token(Token = "0x6010678")]
		[Address(RVA = "0x823340", Offset = "0x821F40", VA = "0x180823340")]
		private bool _ContainsFlag(AutoChessDragOperationFlag flag)
		{
			return default(bool);
		}

		// Token: 0x06010679 RID: 67193 RVA: 0x00064098 File Offset: 0x00062298
		[Token(Token = "0x6010679")]
		[Address(RVA = "0x824990", Offset = "0x823590", VA = "0x180824990")]
		private bool _DealWithHand2HandSwap()
		{
			return default(bool);
		}

		// Token: 0x0601067A RID: 67194 RVA: 0x000640B0 File Offset: 0x000622B0
		[Token(Token = "0x601067A")]
		[Address(RVA = "0x8233E0", Offset = "0x821FE0", VA = "0x1808233E0")]
		private bool _DealWithBattle2BattleSwap()
		{
			return default(bool);
		}

		// Token: 0x0601067B RID: 67195 RVA: 0x000640C8 File Offset: 0x000622C8
		[Token(Token = "0x601067B")]
		[Address(RVA = "0x823960", Offset = "0x822560", VA = "0x180823960")]
		private bool _DealWithBattle2HandSwap()
		{
			return default(bool);
		}

		// Token: 0x0601067C RID: 67196 RVA: 0x000640E0 File Offset: 0x000622E0
		[Token(Token = "0x601067C")]
		[Address(RVA = "0x8242E0", Offset = "0x822EE0", VA = "0x1808242E0")]
		private bool _DealWithHand2BattleSwap()
		{
			return default(bool);
		}

		// Token: 0x0601067D RID: 67197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601067D")]
		[Address(RVA = "0x823F30", Offset = "0x822B30", VA = "0x180823F30")]
		private void _DealWithBattleCharacter2BattleTokenSwap()
		{
		}

		// Token: 0x0601067E RID: 67198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601067E")]
		[Address(RVA = "0x824CA0", Offset = "0x8238A0", VA = "0x180824CA0")]
		private void _DealWithHandCharacter2BattleTokenSwap()
		{
		}

		// Token: 0x0601067F RID: 67199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601067F")]
		[Address(RVA = "0x823A50", Offset = "0x822650", VA = "0x180823A50")]
		private void _DealWithBattleCharacter2BattleCharacterSwap()
		{
		}

		// Token: 0x06010680 RID: 67200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010680")]
		[Address(RVA = "0x824AD0", Offset = "0x8236D0", VA = "0x180824AD0")]
		private void _DealWithHandCharacter2BattleCharacterSwap()
		{
		}

		// Token: 0x06010681 RID: 67201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010681")]
		[Address(RVA = "0x822FF0", Offset = "0x821BF0", VA = "0x180822FF0")]
		private void DealWithToken2BattlePlaceEmpty()
		{
		}

		// Token: 0x06010682 RID: 67202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010682")]
		[Address(RVA = "0x824BE0", Offset = "0x8237E0", VA = "0x180824BE0")]
		private void _DealWithHandCharacter2BattlePlaceEmpty()
		{
		}

		// Token: 0x06010683 RID: 67203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010683")]
		[Address(RVA = "0x823E30", Offset = "0x822A30", VA = "0x180823E30")]
		private void _DealWithBattleCharacter2BattlePlaceEmpty()
		{
		}

		// Token: 0x06010684 RID: 67204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010684")]
		[Address(RVA = "0x8241C0", Offset = "0x822DC0", VA = "0x1808241C0")]
		private void _DealWithBattleToken2BattleTokenSwap()
		{
		}

		// Token: 0x06010685 RID: 67205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010685")]
		[Address(RVA = "0x824F20", Offset = "0x823B20", VA = "0x180824F20")]
		private void _DealWithHandToken2BattleTokenSwap()
		{
		}

		// Token: 0x06010686 RID: 67206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010686")]
		[Address(RVA = "0x824080", Offset = "0x822C80", VA = "0x180824080")]
		private void _DealWithBattleToken2BattleCharacterSwap()
		{
		}

		// Token: 0x06010687 RID: 67207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010687")]
		[Address(RVA = "0x824DD0", Offset = "0x8239D0", VA = "0x180824DD0")]
		private void _DealWithHandToken2BattleCharacterSwap()
		{
		}

		// Token: 0x06010688 RID: 67208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010688")]
		[Address(RVA = "0x825070", Offset = "0x823C70", VA = "0x180825070")]
		private void _MoveInstFromStart2End()
		{
		}

		// Token: 0x06010689 RID: 67209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010689")]
		[Address(RVA = "0x8230C0", Offset = "0x821CC0", VA = "0x1808230C0")]
		private void _AddInst(GridPosition pos, int instId, bool isToken, SharedConsts.Direction direction = SharedConsts.Direction.E_NUM)
		{
		}

		// Token: 0x0601068A RID: 67210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601068A")]
		[Address(RVA = "0x825120", Offset = "0x823D20", VA = "0x180825120")]
		private void _RemoveInst(GridPosition pos)
		{
		}

		// Token: 0x0601068B RID: 67211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601068B")]
		[Address(RVA = "0x825250", Offset = "0x823E50", VA = "0x180825250")]
		public BattleDragOperationHandler()
		{
		}

		// Token: 0x040125AF RID: 75183
		[Token(Token = "0x40125AF")]
		[FieldOffset(Offset = "0x10")]
		public GridPosition startPos;

		// Token: 0x040125B0 RID: 75184
		[Token(Token = "0x40125B0")]
		[FieldOffset(Offset = "0x18")]
		public GridPosition endPos;

		// Token: 0x040125B1 RID: 75185
		[Token(Token = "0x40125B1")]
		[FieldOffset(Offset = "0x20")]
		public string startChessId;

		// Token: 0x040125B2 RID: 75186
		[Token(Token = "0x40125B2")]
		[FieldOffset(Offset = "0x28")]
		public int startInstId;

		// Token: 0x040125B3 RID: 75187
		[Token(Token = "0x40125B3")]
		[FieldOffset(Offset = "0x2C")]
		public int endInstId;

		// Token: 0x040125B4 RID: 75188
		[Token(Token = "0x40125B4")]
		[FieldOffset(Offset = "0x30")]
		public SharedConsts.Direction selectedDirection;

		// Token: 0x040125B5 RID: 75189
		[Token(Token = "0x40125B5")]
		[FieldOffset(Offset = "0x38")]
		public AutoChessOperationCase currentCase;

		// Token: 0x040125B6 RID: 75190
		[Token(Token = "0x40125B6")]
		[FieldOffset(Offset = "0x40")]
		private bool m_inited;

		// Token: 0x040125B7 RID: 75191
		[Token(Token = "0x40125B7")]
		[FieldOffset(Offset = "0x44")]
		private AutoChessOperationType m_operationType;

		// Token: 0x040125B8 RID: 75192
		[Token(Token = "0x40125B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_operationType;

		// Token: 0x040125B9 RID: 75193
		[Token(Token = "0x40125B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ConstructOperation;

		// Token: 0x040125BA RID: 75194
		[Token(Token = "0x40125BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckOperationValid;

		// Token: 0x040125BB RID: 75195
		[Token(Token = "0x40125BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x040125BC RID: 75196
		[Token(Token = "0x40125BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040125BD RID: 75197
		[Token(Token = "0x40125BD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__ApplyFlag;

		// Token: 0x040125BE RID: 75198
		[Token(Token = "0x40125BE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ContainsFlag;

		// Token: 0x040125BF RID: 75199
		[Token(Token = "0x40125BF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DealWithHand2HandSwap;

		// Token: 0x040125C0 RID: 75200
		[Token(Token = "0x40125C0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__DealWithBattle2BattleSwap;

		// Token: 0x040125C1 RID: 75201
		[Token(Token = "0x40125C1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DealWithBattle2HandSwap;

		// Token: 0x040125C2 RID: 75202
		[Token(Token = "0x40125C2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DealWithHand2BattleSwap;

		// Token: 0x040125C3 RID: 75203
		[Token(Token = "0x40125C3")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DealWithBattleCharacter2BattleTokenSwap;

		// Token: 0x040125C4 RID: 75204
		[Token(Token = "0x40125C4")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DealWithHandCharacter2BattleTokenSwap;

		// Token: 0x040125C5 RID: 75205
		[Token(Token = "0x40125C5")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__DealWithBattleCharacter2BattleCharacterSwap;

		// Token: 0x040125C6 RID: 75206
		[Token(Token = "0x40125C6")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DealWithHandCharacter2BattleCharacterSwap;

		// Token: 0x040125C7 RID: 75207
		[Token(Token = "0x40125C7")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_DealWithToken2BattlePlaceEmpty;

		// Token: 0x040125C8 RID: 75208
		[Token(Token = "0x40125C8")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DealWithHandCharacter2BattlePlaceEmpty;

		// Token: 0x040125C9 RID: 75209
		[Token(Token = "0x40125C9")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__DealWithBattleCharacter2BattlePlaceEmpty;

		// Token: 0x040125CA RID: 75210
		[Token(Token = "0x40125CA")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__DealWithBattleToken2BattleTokenSwap;

		// Token: 0x040125CB RID: 75211
		[Token(Token = "0x40125CB")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DealWithHandToken2BattleTokenSwap;

		// Token: 0x040125CC RID: 75212
		[Token(Token = "0x40125CC")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__DealWithBattleToken2BattleCharacterSwap;

		// Token: 0x040125CD RID: 75213
		[Token(Token = "0x40125CD")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__DealWithHandToken2BattleCharacterSwap;

		// Token: 0x040125CE RID: 75214
		[Token(Token = "0x40125CE")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__MoveInstFromStart2End;

		// Token: 0x040125CF RID: 75215
		[Token(Token = "0x40125CF")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__AddInst;

		// Token: 0x040125D0 RID: 75216
		[Token(Token = "0x40125D0")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RemoveInst;

		// Token: 0x040125D1 RID: 75217
		[Token(Token = "0x40125D1")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
