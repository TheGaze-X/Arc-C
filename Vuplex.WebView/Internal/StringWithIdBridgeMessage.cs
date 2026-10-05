using System;
using Il2CppDummyDll;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000093 RID: 147
	[Token(Token = "0x2000093")]
	[Serializable]
	public class StringWithIdBridgeMessage : BridgeMessage
	{
		// Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StringWithIdBridgeMessage()
		{
		}

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x18")]
		public string id;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x20")]
		public string value;
	}
}
