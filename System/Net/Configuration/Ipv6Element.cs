using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x02000402 RID: 1026
	[Token(Token = "0x2000402")]
	public sealed class Ipv6Element : ConfigurationElement
	{
		// Token: 0x06001B66 RID: 7014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B66")]
		[Address(RVA = "0x50BCA00", Offset = "0x50BB600", VA = "0x1850BCA00")]
		public Ipv6Element()
		{
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x0000C048 File Offset: 0x0000A248
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000627")]
		public bool Enabled
		{
			[Token(Token = "0x6001B67")]
			[Address(RVA = "0x50BCA30", Offset = "0x50BB630", VA = "0x1850BCA30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B68")]
			[Address(RVA = "0x50BCA90", Offset = "0x50BB690", VA = "0x1850BCA90")]
			set
			{
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001B69 RID: 7017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000628")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B69")]
			[Address(RVA = "0x50BCA60", Offset = "0x50BB660", VA = "0x1850BCA60", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
