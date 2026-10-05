using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x0200040E RID: 1038
	[Token(Token = "0x200040E")]
	public sealed class WebUtilityElement : ConfigurationElement
	{
		// Token: 0x06001BD4 RID: 7124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BD4")]
		[Address(RVA = "0x50C91F0", Offset = "0x50C7DF0", VA = "0x1850C91F0")]
		public WebUtilityElement()
		{
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001BD5 RID: 7125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000664")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001BD5")]
			[Address(RVA = "0x50C9220", Offset = "0x50C7E20", VA = "0x1850C9220", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001BD6 RID: 7126 RVA: 0x0000C270 File Offset: 0x0000A470
		// (set) Token: 0x06001BD7 RID: 7127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000665")]
		public UnicodeDecodingConformance UnicodeDecodingConformance
		{
			[Token(Token = "0x6001BD6")]
			[Address(RVA = "0x50C9250", Offset = "0x50C7E50", VA = "0x1850C9250")]
			get
			{
				return UnicodeDecodingConformance.Auto;
			}
			[Token(Token = "0x6001BD7")]
			[Address(RVA = "0x50C92B0", Offset = "0x50C7EB0", VA = "0x1850C92B0")]
			set
			{
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001BD8 RID: 7128 RVA: 0x0000C288 File Offset: 0x0000A488
		// (set) Token: 0x06001BD9 RID: 7129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000666")]
		public UnicodeEncodingConformance UnicodeEncodingConformance
		{
			[Token(Token = "0x6001BD8")]
			[Address(RVA = "0x50C9280", Offset = "0x50C7E80", VA = "0x1850C9280")]
			get
			{
				return UnicodeEncodingConformance.Auto;
			}
			[Token(Token = "0x6001BD9")]
			[Address(RVA = "0x50C92E0", Offset = "0x50C7EE0", VA = "0x1850C92E0")]
			set
			{
			}
		}
	}
}
