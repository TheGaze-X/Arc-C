using System;
using System.Configuration;
using System.Net.Security;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x0200040B RID: 1035
	[Token(Token = "0x200040B")]
	public sealed class ServicePointManagerElement : ConfigurationElement
	{
		// Token: 0x06001BB3 RID: 7091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB3")]
		[Address(RVA = "0x50BE580", Offset = "0x50BD180", VA = "0x1850BE580")]
		public ServicePointManagerElement()
		{
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001BB4 RID: 7092 RVA: 0x0000C150 File Offset: 0x0000A350
		// (set) Token: 0x06001BB5 RID: 7093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000655")]
		public bool CheckCertificateName
		{
			[Token(Token = "0x6001BB4")]
			[Address(RVA = "0x50BE5B0", Offset = "0x50BD1B0", VA = "0x1850BE5B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BB5")]
			[Address(RVA = "0x50BE730", Offset = "0x50BD330", VA = "0x1850BE730")]
			set
			{
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x06001BB6 RID: 7094 RVA: 0x0000C168 File Offset: 0x0000A368
		// (set) Token: 0x06001BB7 RID: 7095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000656")]
		public bool CheckCertificateRevocationList
		{
			[Token(Token = "0x6001BB6")]
			[Address(RVA = "0x50BE5E0", Offset = "0x50BD1E0", VA = "0x1850BE5E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BB7")]
			[Address(RVA = "0x50BE760", Offset = "0x50BD360", VA = "0x1850BE760")]
			set
			{
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001BB8 RID: 7096 RVA: 0x0000C180 File Offset: 0x0000A380
		// (set) Token: 0x06001BB9 RID: 7097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000657")]
		public int DnsRefreshTimeout
		{
			[Token(Token = "0x6001BB8")]
			[Address(RVA = "0x50BE610", Offset = "0x50BD210", VA = "0x1850BE610")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001BB9")]
			[Address(RVA = "0x50BE790", Offset = "0x50BD390", VA = "0x1850BE790")]
			set
			{
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001BBA RID: 7098 RVA: 0x0000C198 File Offset: 0x0000A398
		// (set) Token: 0x06001BBB RID: 7099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000658")]
		public bool EnableDnsRoundRobin
		{
			[Token(Token = "0x6001BBA")]
			[Address(RVA = "0x50BE640", Offset = "0x50BD240", VA = "0x1850BE640")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BBB")]
			[Address(RVA = "0x50BE7C0", Offset = "0x50BD3C0", VA = "0x1850BE7C0")]
			set
			{
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001BBC RID: 7100 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		// (set) Token: 0x06001BBD RID: 7101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000659")]
		public EncryptionPolicy EncryptionPolicy
		{
			[Token(Token = "0x6001BBC")]
			[Address(RVA = "0x50BE670", Offset = "0x50BD270", VA = "0x1850BE670")]
			get
			{
				return EncryptionPolicy.RequireEncryption;
			}
			[Token(Token = "0x6001BBD")]
			[Address(RVA = "0x50BE7F0", Offset = "0x50BD3F0", VA = "0x1850BE7F0")]
			set
			{
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001BBE RID: 7102 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		// (set) Token: 0x06001BBF RID: 7103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065A")]
		public bool Expect100Continue
		{
			[Token(Token = "0x6001BBE")]
			[Address(RVA = "0x50BE6A0", Offset = "0x50BD2A0", VA = "0x1850BE6A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BBF")]
			[Address(RVA = "0x50BE820", Offset = "0x50BD420", VA = "0x1850BE820")]
			set
			{
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001BC0 RID: 7104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065B")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001BC0")]
			[Address(RVA = "0x50BE6D0", Offset = "0x50BD2D0", VA = "0x1850BE6D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001BC1 RID: 7105 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		// (set) Token: 0x06001BC2 RID: 7106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700065C")]
		public bool UseNagleAlgorithm
		{
			[Token(Token = "0x6001BC1")]
			[Address(RVA = "0x50BE700", Offset = "0x50BD300", VA = "0x1850BE700")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001BC2")]
			[Address(RVA = "0x50BE850", Offset = "0x50BD450", VA = "0x1850BE850")]
			set
			{
			}
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BC3")]
		[Address(RVA = "0x50BE550", Offset = "0x50BD150", VA = "0x1850BE550", Slot = "8")]
		protected override void PostDeserialize()
		{
		}
	}
}
