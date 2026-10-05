using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200002D RID: 45
	[Token(Token = "0x200002D")]
	public struct SDKExtraData
	{
		// Token: 0x060000F8 RID: 248 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x2114460", Offset = "0x2113060", VA = "0x182114460")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x4A14740", Offset = "0x4A13340", VA = "0x184A14740")]
		public static SDKExtraData FromJson(string jsonStr)
		{
			return default(SDKExtraData);
		}

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SDKExtraData EMPTY;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x0")]
		public int code;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x8")]
		public Dictionary<string, object> msg;
	}
}
