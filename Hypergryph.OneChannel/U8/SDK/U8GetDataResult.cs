using System;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x02000070 RID: 112
	[Token(Token = "0x2000070")]
	public struct U8GetDataResult
	{
		// Token: 0x06000200 RID: 512 RVA: 0x0000269C File Offset: 0x0000089C
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2114460", Offset = "0x2113060", VA = "0x182114460")]
		public bool IsSuc()
		{
			return default(bool);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x000026B4 File Offset: 0x000008B4
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x4A21A10", Offset = "0x4A20610", VA = "0x184A21A10")]
		public static U8GetDataResult FromJson(string rawJson)
		{
			return default(U8GetDataResult);
		}

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x0")]
		public static readonly U8GetDataResult EMPTY;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x0")]
		public int code;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x8")]
		public string msg;
	}
}
