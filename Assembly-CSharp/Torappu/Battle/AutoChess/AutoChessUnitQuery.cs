using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200275B RID: 10075
	[Token(Token = "0x200275B")]
	public struct AutoChessUnitQuery
	{
		// Token: 0x170023E1 RID: 9185
		// (get) Token: 0x060106B5 RID: 67253 RVA: 0x00064128 File Offset: 0x00062328
		[Token(Token = "0x170023E1")]
		public bool isToken
		{
			[Token(Token = "0x60106B5")]
			[Address(RVA = "0x74E9D0", Offset = "0x74D5D0", VA = "0x18074E9D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060106B6 RID: 67254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60106B6")]
		[Address(RVA = "0x839510", Offset = "0x838110", VA = "0x180839510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0401260C RID: 75276
		[Token(Token = "0x401260C")]
		[FieldOffset(Offset = "0x0")]
		public int instId;

		// Token: 0x0401260D RID: 75277
		[Token(Token = "0x401260D")]
		[FieldOffset(Offset = "0x8")]
		public string chessId;

		// Token: 0x0401260E RID: 75278
		[Token(Token = "0x401260E")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessItemType chessType;
	}
}
