using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x0200040F RID: 1039
	[Token(Token = "0x200040F")]
	public sealed class WindowsAuthenticationElement : ConfigurationElement
	{
		// Token: 0x06001BDA RID: 7130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDA")]
		[Address(RVA = "0x50C9310", Offset = "0x50C7F10", VA = "0x1850C9310")]
		public WindowsAuthenticationElement()
		{
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001BDB RID: 7131 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		// (set) Token: 0x06001BDC RID: 7132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000667")]
		public int DefaultCredentialsHandleCacheSize
		{
			[Token(Token = "0x6001BDB")]
			[Address(RVA = "0x50C9340", Offset = "0x50C7F40", VA = "0x1850C9340")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001BDC")]
			[Address(RVA = "0x50C93A0", Offset = "0x50C7FA0", VA = "0x1850C93A0")]
			set
			{
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000668")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001BDD")]
			[Address(RVA = "0x50C9370", Offset = "0x50C7F70", VA = "0x1850C9370", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
