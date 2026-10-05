using System;
using Il2CppDummyDll;

namespace Torappu.Lua
{
	// Token: 0x0200160B RID: 5643
	[Token(Token = "0x200160B")]
	[Serializable]
	public class ValueFieldDefine
	{
		// Token: 0x0600800F RID: 32783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600800F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ValueFieldDefine()
		{
		}

		// Token: 0x0400817A RID: 33146
		[Token(Token = "0x400817A")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400817B RID: 33147
		[Token(Token = "0x400817B")]
		[FieldOffset(Offset = "0x18")]
		public string value;
	}
}
