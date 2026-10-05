using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002754 RID: 10068
	[Token(Token = "0x2002754")]
	public abstract class AutoChessGameModeTileOperationHandlerBase : IHotfixable
	{
		// Token: 0x06010664 RID: 67172
		[Token(Token = "0x6010664")]
		public abstract bool CheckOperationValid();

		// Token: 0x06010665 RID: 67173
		[Token(Token = "0x6010665")]
		public abstract bool Apply();

		// Token: 0x06010666 RID: 67174
		[Token(Token = "0x6010666")]
		public abstract void Reset();

		// Token: 0x170023D9 RID: 9177
		// (get) Token: 0x06010667 RID: 67175
		[Token(Token = "0x170023D9")]
		public abstract AutoChessOperationType operationType { [Token(Token = "0x6010667")] get; }

		// Token: 0x170023DA RID: 9178
		// (get) Token: 0x06010668 RID: 67176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170023DA")]
		protected ChessMapInfo chessMapInfo
		{
			[Token(Token = "0x6010668")]
			[Address(RVA = "0x814710", Offset = "0x813310", VA = "0x180814710")]
			get
			{
				return null;
			}
		}

		// Token: 0x06010669 RID: 67177 RVA: 0x00063FC0 File Offset: 0x000621C0
		[Token(Token = "0x6010669")]
		[Address(RVA = "0x814460", Offset = "0x813060", VA = "0x180814460")]
		protected bool NeedGenToken(int instId)
		{
			return default(bool);
		}

		// Token: 0x0601066A RID: 67178 RVA: 0x00063FD8 File Offset: 0x000621D8
		[Token(Token = "0x601066A")]
		[Address(RVA = "0x8144E0", Offset = "0x8130E0", VA = "0x1808144E0")]
		protected bool Withdraw(GridPosition pos, GridPosition targetPosition)
		{
			return default(bool);
		}

		// Token: 0x0601066B RID: 67179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601066B")]
		[Address(RVA = "0x8146B0", Offset = "0x8132B0", VA = "0x1808146B0")]
		protected AutoChessGameModeTileOperationHandlerBase()
		{
		}

		// Token: 0x040125A2 RID: 75170
		[Token(Token = "0x40125A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_chessMapInfo;

		// Token: 0x040125A3 RID: 75171
		[Token(Token = "0x40125A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NeedGenToken;

		// Token: 0x040125A4 RID: 75172
		[Token(Token = "0x40125A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Withdraw;

		// Token: 0x040125A5 RID: 75173
		[Token(Token = "0x40125A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
