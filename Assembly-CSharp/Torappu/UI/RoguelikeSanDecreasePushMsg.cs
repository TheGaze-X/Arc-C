using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003B0F RID: 15119
	[Token(Token = "0x2003B0F")]
	public class RoguelikeSanDecreasePushMsg
	{
		// Token: 0x06017CFB RID: 97531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CFB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeSanDecreasePushMsg()
		{
		}

		// Token: 0x0401CC2E RID: 117806
		[Token(Token = "0x401CC2E")]
		[FieldOffset(Offset = "0x10")]
		public int sanBefore;

		// Token: 0x0401CC2F RID: 117807
		[Token(Token = "0x401CC2F")]
		[FieldOffset(Offset = "0x14")]
		public int sanAfter;
	}
}
