using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010BA RID: 4282
	[Token(Token = "0x20010BA")]
	[Serializable]
	public class ExpItemFeature
	{
		// Token: 0x06006E53 RID: 28243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E53")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ExpItemFeature()
		{
		}

		// Token: 0x04005BA8 RID: 23464
		[Token(Token = "0x4005BA8")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005BA9 RID: 23465
		[Token(Token = "0x4005BA9")]
		[FieldOffset(Offset = "0x18")]
		public int gainExp;
	}
}
