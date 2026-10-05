using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Linq;

namespace Torappu.I18N
{
	// Token: 0x0200023E RID: 574
	[Token(Token = "0x200023E")]
	public class PatchRule
	{
		// Token: 0x06000D20 RID: 3360 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PatchRule()
		{
		}

		// Token: 0x04000D38 RID: 3384
		[Token(Token = "0x4000D38")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000D39 RID: 3385
		[Token(Token = "0x4000D39")]
		[FieldOffset(Offset = "0x18")]
		public string field;

		// Token: 0x04000D3A RID: 3386
		[Token(Token = "0x4000D3A")]
		[FieldOffset(Offset = "0x20")]
		public JToken value;
	}
}
