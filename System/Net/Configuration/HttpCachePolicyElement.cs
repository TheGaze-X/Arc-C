using System;
using System.Configuration;
using System.Net.Cache;
using System.Xml;
using Il2CppDummyDll;

namespace System.Net.Configuration
{
	// Token: 0x020003FE RID: 1022
	[Token(Token = "0x20003FE")]
	public sealed class HttpCachePolicyElement : ConfigurationElement
	{
		// Token: 0x06001B43 RID: 6979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B43")]
		[Address(RVA = "0x50BC180", Offset = "0x50BAD80", VA = "0x1850BC180")]
		public HttpCachePolicyElement()
		{
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001B44 RID: 6980 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		// (set) Token: 0x06001B45 RID: 6981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000613")]
		public TimeSpan MaximumAge
		{
			[Token(Token = "0x6001B44")]
			[Address(RVA = "0x50BC1B0", Offset = "0x50BADB0", VA = "0x1850BC1B0")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6001B45")]
			[Address(RVA = "0x50BC2A0", Offset = "0x50BAEA0", VA = "0x1850BC2A0")]
			set
			{
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001B46 RID: 6982 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		// (set) Token: 0x06001B47 RID: 6983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000614")]
		public TimeSpan MaximumStale
		{
			[Token(Token = "0x6001B46")]
			[Address(RVA = "0x50BC1E0", Offset = "0x50BADE0", VA = "0x1850BC1E0")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6001B47")]
			[Address(RVA = "0x50BC2D0", Offset = "0x50BAED0", VA = "0x1850BC2D0")]
			set
			{
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001B48 RID: 6984 RVA: 0x0000BF10 File Offset: 0x0000A110
		// (set) Token: 0x06001B49 RID: 6985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000615")]
		public TimeSpan MinimumFresh
		{
			[Token(Token = "0x6001B48")]
			[Address(RVA = "0x50BC210", Offset = "0x50BAE10", VA = "0x1850BC210")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6001B49")]
			[Address(RVA = "0x50BC300", Offset = "0x50BAF00", VA = "0x1850BC300")]
			set
			{
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001B4A RID: 6986 RVA: 0x0000BF28 File Offset: 0x0000A128
		// (set) Token: 0x06001B4B RID: 6987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000616")]
		public HttpRequestCacheLevel PolicyLevel
		{
			[Token(Token = "0x6001B4A")]
			[Address(RVA = "0x50BC240", Offset = "0x50BAE40", VA = "0x1850BC240")]
			get
			{
				return HttpRequestCacheLevel.Default;
			}
			[Token(Token = "0x6001B4B")]
			[Address(RVA = "0x50BC330", Offset = "0x50BAF30", VA = "0x1850BC330")]
			set
			{
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001B4C RID: 6988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000617")]
		protected override ConfigurationPropertyCollection Properties
		{
			[Token(Token = "0x6001B4C")]
			[Address(RVA = "0x50BC270", Offset = "0x50BAE70", VA = "0x1850BC270", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4D")]
		[Address(RVA = "0x50BC120", Offset = "0x50BAD20", VA = "0x1850BC120", Slot = "5")]
		protected override void DeserializeElement(XmlReader reader, bool serializeCollectionKey)
		{
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B4E")]
		[Address(RVA = "0x50BC150", Offset = "0x50BAD50", VA = "0x1850BC150", Slot = "9")]
		protected override void Reset(ConfigurationElement parentElement)
		{
		}
	}
}
