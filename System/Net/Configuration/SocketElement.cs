using System;
using System.Configuration;
using System.Net.Sockets;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x0200040C RID: 1036
	[Token(Token = "0x200040C")]
	public sealed class SocketElement : ConfigurationElement
	{
		// Token: 0x06001BC4 RID: 7108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC4")]
		[Address(RVA = "0x50C1BC0", Offset = "0x50C07C0", VA = "0x1850C1BC0")]
		public SocketElement()
		{
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001BC5 RID: 7109 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		// (set) Token: 0x06001BC6 RID: 7110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065D")]
		public bool AlwaysUseCompletionPortsForAccept
		{
			[Token(Token = "0x6001BC5")]
			[Address(RVA = "0x50C1BF0", Offset = "0x50C07F0", VA = "0x1850C1BF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BC6")]
			[Address(RVA = "0x50C1CB0", Offset = "0x50C08B0", VA = "0x1850C1CB0")]
			set
			{
			}
		}

		// Token: 0x1700065E RID: 1630
		// (get) Token: 0x06001BC7 RID: 7111 RVA: 0x0000C210 File Offset: 0x0000A410
		// (set) Token: 0x06001BC8 RID: 7112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065E")]
		public bool AlwaysUseCompletionPortsForConnect
		{
			[Token(Token = "0x6001BC7")]
			[Address(RVA = "0x50C1C20", Offset = "0x50C0820", VA = "0x1850C1C20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BC8")]
			[Address(RVA = "0x50C1CE0", Offset = "0x50C08E0", VA = "0x1850C1CE0")]
			set
			{
			}
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001BC9 RID: 7113 RVA: 0x0000C228 File Offset: 0x0000A428
		// (set) Token: 0x06001BCA RID: 7114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065F")]
		public IPProtectionLevel IPProtectionLevel
		{
			[Token(Token = "0x6001BC9")]
			[Address(RVA = "0x50C1C50", Offset = "0x50C0850", VA = "0x1850C1C50")]
			get
			{
				return (IPProtectionLevel)0;
			}
			[Token(Token = "0x6001BCA")]
			[Address(RVA = "0x50C1D10", Offset = "0x50C0910", VA = "0x1850C1D10")]
			set
			{
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001BCB RID: 7115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000660")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001BCB")]
			[Address(RVA = "0x50C1C80", Offset = "0x50C0880", VA = "0x1850C1C80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001BCC RID: 7116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x50C1B90", Offset = "0x50C0790", VA = "0x1850C1B90", Slot = "8")]
		protected override void PostDeserialize()
		{
		}
	}
}
