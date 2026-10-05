using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Action
{
	// Token: 0x02002C48 RID: 11336
	[Token(Token = "0x2002C48")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
	public class ActionInfoAttribute : Attribute
	{
		// Token: 0x0601323E RID: 78398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601323E")]
		[Address(RVA = "0xB417C0", Offset = "0xB403C0", VA = "0x180B417C0")]
		public ActionInfoAttribute()
		{
		}

		// Token: 0x040159E6 RID: 88550
		[Token(Token = "0x40159E6")]
		[FieldOffset(Offset = "0x10")]
		public string Category;

		// Token: 0x040159E7 RID: 88551
		[Token(Token = "0x40159E7")]
		[FieldOffset(Offset = "0x18")]
		public string Description;
	}
}
