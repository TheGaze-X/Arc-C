using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000532 RID: 1330
	[Token(Token = "0x2000532")]
	public class KeyCodeEntity
	{
		// Token: 0x06004FC0 RID: 20416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public KeyCodeEntity()
		{
		}

		// Token: 0x04001455 RID: 5205
		[Token(Token = "0x4001455")]
		[FieldOffset(Offset = "0x10")]
		public KeyCodeType type;

		// Token: 0x04001456 RID: 5206
		[Token(Token = "0x4001456")]
		[FieldOffset(Offset = "0x14")]
		public int triggerKey;
	}
}
