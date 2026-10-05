using System;
using Il2CppDummyDll;

namespace Vuplex.WebView.Internal
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	[Serializable]
	internal class ConsoleBridgeMessage : BridgeMessage
	{
		// Token: 0x06000401 RID: 1025 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x5BCB430", Offset = "0x5BCA030", VA = "0x185BCB430")]
		public ConsoleMessageEventArgs ToEventArgs()
		{
			return null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x5BCB600", Offset = "0x5BCA200", VA = "0x185BCB600")]
		private ConsoleMessageLevel _parseMessageLevel(string levelString)
		{
			return ConsoleMessageLevel.Debug;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ConsoleBridgeMessage()
		{
		}

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x18")]
		public string message;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x20")]
		public string level;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x28")]
		public string source;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x30")]
		public int line;
	}
}
