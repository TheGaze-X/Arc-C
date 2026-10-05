using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Torappu.Network
{
	// Token: 0x02000236 RID: 566
	[Token(Token = "0x2000236")]
	public class NetworkRouterConfig
	{
		// Token: 0x06000D0F RID: 3343 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D0F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public NetworkRouterConfig()
		{
		}

		// Token: 0x04000D2A RID: 3370
		[Token(Token = "0x4000D2A")]
		[FieldOffset(Offset = "0x10")]
		public string sign;

		// Token: 0x04000D2B RID: 3371
		[Token(Token = "0x4000D2B")]
		[FieldOffset(Offset = "0x18")]
		public string content;

		// Token: 0x02000237 RID: 567
		[Token(Token = "0x2000237")]
		public class Content
		{
			// Token: 0x06000D10 RID: 3344 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000D10")]
			[Address(RVA = "0x557F320", Offset = "0x557DF20", VA = "0x18557F320")]
			public NetworkRouterConfig.Config GetCurrentConfig()
			{
				return null;
			}

			// Token: 0x06000D11 RID: 3345 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000D11")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Content()
			{
			}

			// Token: 0x04000D2C RID: 3372
			[Token(Token = "0x4000D2C")]
			[FieldOffset(Offset = "0x10")]
			public string configVer;

			// Token: 0x04000D2D RID: 3373
			[Token(Token = "0x4000D2D")]
			[FieldOffset(Offset = "0x18")]
			public string funcVer;

			// Token: 0x04000D2E RID: 3374
			[Token(Token = "0x4000D2E")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<string, NetworkRouterConfig.Config> configs;
		}

		// Token: 0x02000238 RID: 568
		[Token(Token = "0x2000238")]
		public class Config
		{
			// Token: 0x06000D12 RID: 3346 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Config()
			{
			}

			// Token: 0x04000D2F RID: 3375
			[Token(Token = "0x4000D2F")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty(PropertyName = "override")]
			public bool useOverride;

			// Token: 0x04000D30 RID: 3376
			[Token(Token = "0x4000D30")]
			[FieldOffset(Offset = "0x18")]
			public JObject network;
		}
	}
}
