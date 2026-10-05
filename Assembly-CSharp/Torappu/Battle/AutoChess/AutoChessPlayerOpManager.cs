using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002768 RID: 10088
	[Token(Token = "0x2002768")]
	public class AutoChessPlayerOpManager : IHotfixable
	{
		// Token: 0x170023EA RID: 9194
		// (get) Token: 0x06010713 RID: 67347 RVA: 0x00064248 File Offset: 0x00062448
		// (set) Token: 0x06010714 RID: 67348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170023EA")]
		public int opStartInstId
		{
			[Token(Token = "0x6010713")]
			[Address(RVA = "0x8364B0", Offset = "0x8350B0", VA = "0x1808364B0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6010714")]
			[Address(RVA = "0x836580", Offset = "0x835180", VA = "0x180836580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170023EB RID: 9195
		// (get) Token: 0x06010715 RID: 67349 RVA: 0x00064260 File Offset: 0x00062460
		// (set) Token: 0x06010716 RID: 67350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170023EB")]
		public int opEndInstId
		{
			[Token(Token = "0x6010715")]
			[Address(RVA = "0x836450", Offset = "0x835050", VA = "0x180836450")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6010716")]
			[Address(RVA = "0x836510", Offset = "0x835110", VA = "0x180836510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06010717 RID: 67351 RVA: 0x00064278 File Offset: 0x00062478
		[Token(Token = "0x6010717")]
		[Address(RVA = "0x836290", Offset = "0x834E90", VA = "0x180836290")]
		private bool _DoOperation(AutoChessGameModeTileOperationHandlerBase handler)
		{
			return default(bool);
		}

		// Token: 0x06010718 RID: 67352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010718")]
		[Address(RVA = "0x835E20", Offset = "0x834A20", VA = "0x180835E20")]
		public void DoOperation(BattleDragOperationHandler handler)
		{
		}

		// Token: 0x06010719 RID: 67353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010719")]
		[Address(RVA = "0x8361B0", Offset = "0x834DB0", VA = "0x1808361B0")]
		public void DoWithdraw(GridPosition position)
		{
		}

		// Token: 0x0601071A RID: 67354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601071A")]
		[Address(RVA = "0x836100", Offset = "0x834D00", VA = "0x180836100")]
		public void DoSellOrDestroy(GridPosition gridPosition)
		{
		}

		// Token: 0x0601071B RID: 67355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601071B")]
		[Address(RVA = "0x8363B0", Offset = "0x834FB0", VA = "0x1808363B0")]
		public AutoChessPlayerOpManager()
		{
		}

		// Token: 0x04012694 RID: 75412
		[Token(Token = "0x4012694")]
		[FieldOffset(Offset = "0x18")]
		private BattleWithdrawOperationHandler m_withdrawHandler;

		// Token: 0x04012695 RID: 75413
		[Token(Token = "0x4012695")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_opStartInstId;

		// Token: 0x04012696 RID: 75414
		[Token(Token = "0x4012696")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_opStartInstId;

		// Token: 0x04012697 RID: 75415
		[Token(Token = "0x4012697")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_opEndInstId;

		// Token: 0x04012698 RID: 75416
		[Token(Token = "0x4012698")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_opEndInstId;

		// Token: 0x04012699 RID: 75417
		[Token(Token = "0x4012699")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoOperation;

		// Token: 0x0401269A RID: 75418
		[Token(Token = "0x401269A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoOperation;

		// Token: 0x0401269B RID: 75419
		[Token(Token = "0x401269B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoWithdraw;

		// Token: 0x0401269C RID: 75420
		[Token(Token = "0x401269C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_DoSellOrDestroy;

		// Token: 0x0401269D RID: 75421
		[Token(Token = "0x401269D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
