using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x02000401 RID: 1025
	[Token(Token = "0x2000401")]
	public sealed class HttpWebRequestElement : ConfigurationElement
	{
		// Token: 0x06001B5B RID: 7003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B5B")]
		[Address(RVA = "0x50BC5D0", Offset = "0x50BB1D0", VA = "0x1850BC5D0")]
		public HttpWebRequestElement()
		{
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		// (set) Token: 0x06001B5D RID: 7005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000622")]
		public int MaximumErrorResponseLength
		{
			[Token(Token = "0x6001B5C")]
			[Address(RVA = "0x50BC600", Offset = "0x50BB200", VA = "0x1850BC600")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B5D")]
			[Address(RVA = "0x50BC6F0", Offset = "0x50BB2F0", VA = "0x1850BC6F0")]
			set
			{
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x0000C000 File Offset: 0x0000A200
		// (set) Token: 0x06001B5F RID: 7007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000623")]
		public int MaximumResponseHeadersLength
		{
			[Token(Token = "0x6001B5E")]
			[Address(RVA = "0x50BC630", Offset = "0x50BB230", VA = "0x1850BC630")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B5F")]
			[Address(RVA = "0x50BC720", Offset = "0x50BB320", VA = "0x1850BC720")]
			set
			{
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001B60 RID: 7008 RVA: 0x0000C018 File Offset: 0x0000A218
		// (set) Token: 0x06001B61 RID: 7009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000624")]
		public int MaximumUnauthorizedUploadLength
		{
			[Token(Token = "0x6001B60")]
			[Address(RVA = "0x50BC660", Offset = "0x50BB260", VA = "0x1850BC660")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001B61")]
			[Address(RVA = "0x50BC750", Offset = "0x50BB350", VA = "0x1850BC750")]
			set
			{
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001B62 RID: 7010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000625")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B62")]
			[Address(RVA = "0x50BC690", Offset = "0x50BB290", VA = "0x1850BC690", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001B63 RID: 7011 RVA: 0x0000C030 File Offset: 0x0000A230
		// (set) Token: 0x06001B64 RID: 7012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000626")]
		public bool UseUnsafeHeaderParsing
		{
			[Token(Token = "0x6001B63")]
			[Address(RVA = "0x50BC6C0", Offset = "0x50BB2C0", VA = "0x1850BC6C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B64")]
			[Address(RVA = "0x50BC780", Offset = "0x50BB380", VA = "0x1850BC780")]
			set
			{
			}
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B65")]
		[Address(RVA = "0x50BC5A0", Offset = "0x50BB1A0", VA = "0x1850BC5A0", Slot = "8")]
		protected override void PostDeserialize()
		{
		}
	}
}
