using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x02000408 RID: 1032
	[Token(Token = "0x2000408")]
	public sealed class RequestCachingSection : ConfigurationSection
	{
		// Token: 0x06001B96 RID: 7062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B96")]
		[Address(RVA = "0x50BD740", Offset = "0x50BC340", VA = "0x1850BD740")]
		public RequestCachingSection()
		{
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001B97 RID: 7063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000642")]
		public FtpCachePolicyElement DefaultFtpCachePolicy
		{
			[Token(Token = "0x6001B97")]
			[Address(RVA = "0x50BD770", Offset = "0x50BC370", VA = "0x1850BD770")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001B98 RID: 7064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000643")]
		public HttpCachePolicyElement DefaultHttpCachePolicy
		{
			[Token(Token = "0x6001B98")]
			[Address(RVA = "0x50BD7A0", Offset = "0x50BC3A0", VA = "0x1850BD7A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001B99 RID: 7065 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		// (set) Token: 0x06001B9A RID: 7066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000644")]
		public RequestCacheLevel DefaultPolicyLevel
		{
			[Token(Token = "0x6001B99")]
			[Address(RVA = "0x50BD7D0", Offset = "0x50BC3D0", VA = "0x1850BD7D0")]
			get
			{
				return RequestCacheLevel.Default;
			}
			[Token(Token = "0x6001B9A")]
			[Address(RVA = "0x50BD8C0", Offset = "0x50BC4C0", VA = "0x1850BD8C0")]
			set
			{
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000645")]
		public bool DisableAllCaching
		{
			[Token(Token = "0x6001B9B")]
			[Address(RVA = "0x50BD800", Offset = "0x50BC400", VA = "0x1850BD800")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B9C")]
			[Address(RVA = "0x50BD8F0", Offset = "0x50BC4F0", VA = "0x1850BD8F0")]
			set
			{
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001B9D RID: 7069 RVA: 0x0000C108 File Offset: 0x0000A308
		// (set) Token: 0x06001B9E RID: 7070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000646")]
		public bool IsPrivateCache
		{
			[Token(Token = "0x6001B9D")]
			[Address(RVA = "0x50BD830", Offset = "0x50BC430", VA = "0x1850BD830")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001B9E")]
			[Address(RVA = "0x50BD920", Offset = "0x50BC520", VA = "0x1850BD920")]
			set
			{
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001B9F RID: 7071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000647")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B9F")]
			[Address(RVA = "0x50BD860", Offset = "0x50BC460", VA = "0x1850BD860", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0000C120 File Offset: 0x0000A320
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000648")]
		public TimeSpan UnspecifiedMaximumAge
		{
			[Token(Token = "0x6001BA0")]
			[Address(RVA = "0x50BD890", Offset = "0x50BC490", VA = "0x1850BD890")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6001BA1")]
			[Address(RVA = "0x50BD950", Offset = "0x50BC550", VA = "0x1850BD950")]
			set
			{
			}
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x50BD6E0", Offset = "0x50BC2E0", VA = "0x1850BD6E0", Slot = "5")]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x50BD710", Offset = "0x50BC310", VA = "0x1850BD710", Slot = "8")]
		protected override void PostDeserialize()
		{
		}
	}
}
