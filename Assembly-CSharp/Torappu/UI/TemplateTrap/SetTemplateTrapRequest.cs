using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateTrap
{
	// Token: 0x02003D2E RID: 15662
	[Token(Token = "0x2003D2E")]
	public class SetTemplateTrapRequest
	{
		// Token: 0x0601868D RID: 99981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601868D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SetTemplateTrapRequest()
		{
		}

		// Token: 0x0401DDC2 RID: 122306
		[Token(Token = "0x401DDC2")]
		[FieldOffset(Offset = "0x10")]
		public string trapDomainId;

		// Token: 0x0401DDC3 RID: 122307
		[Token(Token = "0x401DDC3")]
		[FieldOffset(Offset = "0x18")]
		public string[] trapSquad;
	}
}
