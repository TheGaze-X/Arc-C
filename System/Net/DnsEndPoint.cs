using System;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002A7 RID: 679
	[Token(Token = "0x20002A7")]
	public class DnsEndPoint : EndPoint
	{
		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000400")]
		public string Host
		{
			[Token(Token = "0x600132E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x000094C8 File Offset: 0x000076C8
		[Token(Token = "0x17000401")]
		public int Port
		{
			[Token(Token = "0x600132F")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040009EB RID: 2539
		[Token(Token = "0x40009EB")]
		[FieldOffset(Offset = "0x10")]
		private string m_Host;

		// Token: 0x040009EC RID: 2540
		[Token(Token = "0x40009EC")]
		[FieldOffset(Offset = "0x18")]
		private int m_Port;
	}
}
