using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002648 RID: 9800
	[Token(Token = "0x2002648")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	public class ExtraBuildConditionInfoAttribute : Attribute
	{
		// Token: 0x06010058 RID: 65624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010058")]
		[Address(RVA = "0x77BEA0", Offset = "0x77AAA0", VA = "0x18077BEA0")]
		public ExtraBuildConditionInfoAttribute()
		{
		}

		// Token: 0x04011D11 RID: 72977
		[Token(Token = "0x4011D11")]
		[FieldOffset(Offset = "0x10")]
		public string Category;

		// Token: 0x04011D12 RID: 72978
		[Token(Token = "0x4011D12")]
		[FieldOffset(Offset = "0x18")]
		public string Description;
	}
}
