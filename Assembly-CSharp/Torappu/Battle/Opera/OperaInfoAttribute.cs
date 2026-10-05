using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Opera
{
	// Token: 0x020026A0 RID: 9888
	[Token(Token = "0x20026A0")]
	[AttributeUsage(AttributeTargets.All)]
	public class OperaInfoAttribute : Attribute
	{
		// Token: 0x06010268 RID: 66152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010268")]
		[Address(RVA = "0x7ED440", Offset = "0x7EC040", VA = "0x1807ED440")]
		public OperaInfoAttribute()
		{
		}

		// Token: 0x04011FE9 RID: 73705
		[Token(Token = "0x4011FE9")]
		[FieldOffset(Offset = "0x10")]
		public string Category;

		// Token: 0x04011FEA RID: 73706
		[Token(Token = "0x4011FEA")]
		[FieldOffset(Offset = "0x18")]
		public string Description;
	}
}
