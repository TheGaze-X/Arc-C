using System;
using Il2CppDummyDll;

namespace Vuplex.WebView.Internal
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[Serializable]
	public class BridgeMessage
	{
		// Token: 0x060003F1 RID: 1009 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x5BCB130", Offset = "0x5BC9D30", VA = "0x185BCB130")]
		public static string ParseType(string serializedMessage)
		{
			return null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BridgeMessage()
		{
		}

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x10")]
		public string type;
	}
}
