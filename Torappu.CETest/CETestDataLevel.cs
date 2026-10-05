using System;
using Il2CppDummyDll;

namespace Torappu.CETest
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	[Serializable]
	public class CETestDataLevel
	{
		// Token: 0x06000040 RID: 64 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CETestDataLevel()
		{
		}

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x18")]
		public string description;
	}
}
