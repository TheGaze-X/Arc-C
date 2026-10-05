using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x02000406 RID: 1030
	[Token(Token = "0x2000406")]
	public sealed class SmtpSpecifiedPickupDirectoryElement : ConfigurationElement
	{
		// Token: 0x06001B89 RID: 7049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B89")]
		[Address(RVA = "0x50C0B90", Offset = "0x50BF790", VA = "0x1850C0B90")]
		public SmtpSpecifiedPickupDirectoryElement()
		{
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B8B RID: 7051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000639")]
		public string PickupDirectoryLocation
		{
			[Token(Token = "0x6001B8A")]
			[Address(RVA = "0x50C0BC0", Offset = "0x50BF7C0", VA = "0x1850C0BC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B8B")]
			[Address(RVA = "0x50C0C20", Offset = "0x50BF820", VA = "0x1850C0C20")]
			set
			{
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001B8C RID: 7052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063A")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B8C")]
			[Address(RVA = "0x50C0BF0", Offset = "0x50BF7F0", VA = "0x1850C0BF0", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
