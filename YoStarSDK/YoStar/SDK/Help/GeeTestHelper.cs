using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YoStar.SDK.Help
{
	// Token: 0x0200020F RID: 527
	[Token(Token = "0x200020F")]
	public class GeeTestHelper
	{
		// Token: 0x06000DB2 RID: 3506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x5C870A0", Offset = "0x5C85CA0", VA = "0x185C870A0")]
		public static GeeTestHelper Instance()
		{
			return null;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x5C86F00", Offset = "0x5C85B00", VA = "0x185C86F00")]
		public void Auth([Optional] Action<GeeTestHelper.AuthRet> callback)
		{
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GeeTestHelper()
		{
		}

		// Token: 0x04000906 RID: 2310
		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GeeTestHelper _instance;

		// Token: 0x04000907 RID: 2311
		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly object lockObj;

		// Token: 0x02000210 RID: 528
		[Token(Token = "0x2000210")]
		public class AuthRet
		{
			// Token: 0x06000DB6 RID: 3510 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000DB6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AuthRet()
			{
			}

			// Token: 0x04000908 RID: 2312
			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int R_CODE;

			// Token: 0x04000909 RID: 2313
			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Dictionary<string, object> R_DATA;
		}
	}
}
