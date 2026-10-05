using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003FF RID: 1023
	[Token(Token = "0x20003FF")]
	public sealed class HttpListenerElement : ConfigurationElement
	{
		// Token: 0x06001B4F RID: 6991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4F")]
		[Address(RVA = "0x50BC360", Offset = "0x50BAF60", VA = "0x1850BC360")]
		public HttpListenerElement()
		{
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001B50 RID: 6992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000618")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B50")]
			[Address(RVA = "0x50BC390", Offset = "0x50BAF90", VA = "0x1850BC390", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000619")]
		public HttpListenerTimeoutsElement Timeouts
		{
			[Token(Token = "0x6001B51")]
			[Address(RVA = "0x50BC3C0", Offset = "0x50BAFC0", VA = "0x1850BC3C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001B52 RID: 6994 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x1700061A")]
		public bool UnescapeRequestUrl
		{
			[Token(Token = "0x6001B52")]
			[Address(RVA = "0x50BC3F0", Offset = "0x50BAFF0", VA = "0x1850BC3F0")]
			get
			{
				return default(bool);
			}
		}
	}
}
