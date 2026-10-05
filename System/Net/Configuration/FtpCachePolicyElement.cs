using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003FD RID: 1021
	[Token(Token = "0x20003FD")]
	public sealed class FtpCachePolicyElement : ConfigurationElement
	{
		// Token: 0x06001B3D RID: 6973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B3D")]
		[Address(RVA = "0x50BC060", Offset = "0x50BAC60", VA = "0x1850BC060")]
		public FtpCachePolicyElement()
		{
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001B3E RID: 6974 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		// (set) Token: 0x06001B3F RID: 6975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000611")]
		public RequestCacheLevel PolicyLevel
		{
			[Token(Token = "0x6001B3E")]
			[Address(RVA = "0x50BC090", Offset = "0x50BAC90", VA = "0x1850BC090")]
			get
			{
				return RequestCacheLevel.Default;
			}
			[Token(Token = "0x6001B3F")]
			[Address(RVA = "0x50BC0F0", Offset = "0x50BACF0", VA = "0x1850BC0F0")]
			set
			{
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001B40 RID: 6976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000612")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B40")]
			[Address(RVA = "0x50BC0C0", Offset = "0x50BACC0", VA = "0x1850BC0C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B41")]
		[Address(RVA = "0x50BC000", Offset = "0x50BAC00", VA = "0x1850BC000", Slot = "5")]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B42")]
		[Address(RVA = "0x50BC030", Offset = "0x50BAC30", VA = "0x1850BC030", Slot = "9")]
		protected override void Reset(ConfigurationElement parentElement)
		{
		}
	}
}
