using System;
using System.Configuration;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x0200040A RID: 1034
	[Token(Token = "0x200040A")]
	public sealed class PerformanceCountersElement : ConfigurationElement
	{
		// Token: 0x06001BAF RID: 7087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x50BD2A0", Offset = "0x50BBEA0", VA = "0x1850BD2A0")]
		public PerformanceCountersElement()
		{
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001BB0 RID: 7088 RVA: 0x0000C138 File Offset: 0x0000A338
		// (set) Token: 0x06001BB1 RID: 7089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000653")]
		public bool Enabled
		{
			[Token(Token = "0x6001BB0")]
			[Address(RVA = "0x50BD2D0", Offset = "0x50BBED0", VA = "0x1850BD2D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BB1")]
			[Address(RVA = "0x50BD330", Offset = "0x50BBF30", VA = "0x1850BD330")]
			set
			{
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001BB2 RID: 7090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000654")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001BB2")]
			[Address(RVA = "0x50BD300", Offset = "0x50BBF00", VA = "0x1850BD300", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
