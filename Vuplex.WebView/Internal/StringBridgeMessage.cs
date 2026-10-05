using System;
using Il2CppDummyDll;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	[Serializable]
	internal class StringBridgeMessage : BridgeMessage
	{
		// Token: 0x06000462 RID: 1122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x5BD1570", Offset = "0x5BD0170", VA = "0x185BD1570")]
		public static string ParseValue(string serializedMessage)
		{
			return null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StringBridgeMessage()
		{
		}

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x18")]
		public string value;
	}
}
