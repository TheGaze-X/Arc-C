using System;
using Il2CppDummyDll;

namespace Torappu.Test
{
	// Token: 0x02001495 RID: 5269
	[Token(Token = "0x2001495")]
	[AttributeUsage(AttributeTargets.Method)]
	public class EditorChecker : Attribute
	{
		// Token: 0x060079C2 RID: 31170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60079C2")]
		[Address(RVA = "0x2637490", Offset = "0x2636090", VA = "0x182637490")]
		public EditorChecker(string name, params string[] grps)
		{
		}

		// Token: 0x040077DE RID: 30686
		[Token(Token = "0x40077DE")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x040077DF RID: 30687
		[Token(Token = "0x40077DF")]
		[FieldOffset(Offset = "0x18")]
		public string[] groups;
	}
}
