using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002753 RID: 10067
	[Token(Token = "0x2002753")]
	public class AutoChessOperationCase
	{
		// Token: 0x06010661 RID: 67169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010661")]
		[Address(RVA = "0x81D4F0", Offset = "0x81C0F0", VA = "0x18081D4F0")]
		public void ApplyFlag(AutoChessDragOperationFlag flag, bool apply)
		{
		}

		// Token: 0x06010662 RID: 67170 RVA: 0x00063FA8 File Offset: 0x000621A8
		[Token(Token = "0x6010662")]
		[Address(RVA = "0x81D510", Offset = "0x81C110", VA = "0x18081D510")]
		public bool ContainsFlag(AutoChessDragOperationFlag flag)
		{
			return default(bool);
		}

		// Token: 0x06010663 RID: 67171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010663")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessOperationCase()
		{
		}

		// Token: 0x0401259F RID: 75167
		[Token(Token = "0x401259F")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessDragOperationFlag operationFlag;

		// Token: 0x040125A0 RID: 75168
		[Token(Token = "0x40125A0")]
		[FieldOffset(Offset = "0x14")]
		public AutoChessItemType startType;

		// Token: 0x040125A1 RID: 75169
		[Token(Token = "0x40125A1")]
		[FieldOffset(Offset = "0x18")]
		public AutoChessItemType endType;
	}
}
