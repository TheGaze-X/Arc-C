using System;
using Il2CppDummyDll;

namespace System.Configuration
{
	// Token: 0x02000427 RID: 1063
	[Token(Token = "0x2000427")]
	public sealed class IdnElement : ConfigurationElement
	{
		// Token: 0x06001C5F RID: 7263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C5F")]
		[Address(RVA = "0x50BC8E0", Offset = "0x50BB4E0", VA = "0x1850BC8E0")]
		public IdnElement()
		{
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0000C360 File Offset: 0x0000A560
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700068A")]
		public UriIdnScope Enabled
		{
			[Token(Token = "0x6001C60")]
			[Address(RVA = "0x50BC910", Offset = "0x50BB510", VA = "0x1850BC910")]
			get
			{
				return UriIdnScope.None;
			}
			[Token(Token = "0x6001C61")]
			[Address(RVA = "0x50BC970", Offset = "0x50BB570", VA = "0x1850BC970")]
			set
			{
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068B")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001C62")]
			[Address(RVA = "0x50BC940", Offset = "0x50BB540", VA = "0x1850BC940", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
