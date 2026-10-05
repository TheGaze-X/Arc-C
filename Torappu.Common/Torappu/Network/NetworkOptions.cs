using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Network
{
	// Token: 0x02000232 RID: 562
	[Token(Token = "0x2000232")]
	[CreateAssetMenu(menuName = "Torappu/Options/NetworkOptions")]
	public class NetworkOptions : SingletonScriptableObject<NetworkOptions>
	{
		// Token: 0x06000D01 RID: 3329 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x556A9B0", Offset = "0x55695B0", VA = "0x18556A9B0")]
		public string GetActiveRouterUrl()
		{
			return null;
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x556A8F0", Offset = "0x55694F0", VA = "0x18556A8F0")]
		public string GetActiveGameConfigPlatformUrl()
		{
			return null;
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x556A950", Offset = "0x5569550", VA = "0x18556A950")]
		public string GetActiveGameUpdateV2ApiUrl()
		{
			return null;
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D04")]
		[Address(RVA = "0x556AE00", Offset = "0x5569A00", VA = "0x18556AE00")]
		private NetworkOptions.RouteConfig _FindActiveRouter()
		{
			return null;
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D05")]
		[Address(RVA = "0x556A720", Offset = "0x5569320", VA = "0x18556A720")]
		public string BuildRemoteConfigUrl()
		{
			return null;
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D06")]
		[Address(RVA = "0x556A550", Offset = "0x5569150", VA = "0x18556A550")]
		public string BuildNetworkConfigUrl()
		{
			return null;
		}

		// Token: 0x06000D07 RID: 3335 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D07")]
		[Address(RVA = "0x556A410", Offset = "0x5569010", VA = "0x18556A410")]
		public string BuildGameUpdateV2ApiUrl()
		{
			return null;
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00008624 File Offset: 0x00006824
		[Token(Token = "0x17000159")]
		public Networker.Configuration configuration
		{
			[Token(Token = "0x6000D08")]
			[Address(RVA = "0x556B3D0", Offset = "0x5569FD0", VA = "0x18556B3D0")]
			get
			{
				return default(Networker.Configuration);
			}
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x0000863C File Offset: 0x0000683C
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x556AAC0", Offset = "0x55696C0", VA = "0x18556AAC0")]
		public Networker.Configuration GetConfigByType(NetworkOptions.ServerType type)
		{
			return default(Networker.Configuration);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x556AEF0", Offset = "0x5569AF0", VA = "0x18556AEF0")]
		public NetworkOptions()
		{
		}

		// Token: 0x04000D12 RID: 3346
		[Token(Token = "0x4000D12")]
		[FieldOffset(Offset = "0x18")]
		public NetworkOptions.ServerType serverType;

		// Token: 0x04000D13 RID: 3347
		[Token(Token = "0x4000D13")]
		[FieldOffset(Offset = "0x20")]
		public List<NetworkOptions.RouteConfig> routers;

		// Token: 0x04000D14 RID: 3348
		[Token(Token = "0x4000D14")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		private NetworkOptions.RouteConfig m_cachedActiveRouter;

		// Token: 0x04000D15 RID: 3349
		[Token(Token = "0x4000D15")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		private NetworkOptions.ServerType m_cachedServerType;

		// Token: 0x04000D16 RID: 3350
		[Token(Token = "0x4000D16")]
		[FieldOffset(Offset = "0x38")]
		public Networker.Configuration DEV_SERVER;

		// Token: 0x04000D17 RID: 3351
		[Token(Token = "0x4000D17")]
		[FieldOffset(Offset = "0xA0")]
		public Networker.Configuration STORYTEST_SERVER;

		// Token: 0x04000D18 RID: 3352
		[Token(Token = "0x4000D18")]
		[FieldOffset(Offset = "0x108")]
		public Networker.Configuration STAGING_SERVER;

		// Token: 0x04000D19 RID: 3353
		[Token(Token = "0x4000D19")]
		[FieldOffset(Offset = "0x170")]
		public Networker.Configuration BUSINESS_SERVER;

		// Token: 0x04000D1A RID: 3354
		[Token(Token = "0x4000D1A")]
		[FieldOffset(Offset = "0x1D8")]
		public Networker.Configuration PRODUCTION_SERVER;

		// Token: 0x04000D1B RID: 3355
		[Token(Token = "0x4000D1B")]
		[FieldOffset(Offset = "0x240")]
		public Networker.Configuration DATA_DESIGN;

		// Token: 0x04000D1C RID: 3356
		[Token(Token = "0x4000D1C")]
		[FieldOffset(Offset = "0x2A8")]
		public Networker.Configuration MOCK_SERVER;

		// Token: 0x02000233 RID: 563
		[Token(Token = "0x2000233")]
		public enum ServerType
		{
			// Token: 0x04000D1E RID: 3358
			[Token(Token = "0x4000D1E")]
			DEV,
			// Token: 0x04000D1F RID: 3359
			[Token(Token = "0x4000D1F")]
			STAGING,
			// Token: 0x04000D20 RID: 3360
			[Token(Token = "0x4000D20")]
			BUSINESS,
			// Token: 0x04000D21 RID: 3361
			[Token(Token = "0x4000D21")]
			PRODUCTION,
			// Token: 0x04000D22 RID: 3362
			[Token(Token = "0x4000D22")]
			STORY_TEST = 7,
			// Token: 0x04000D23 RID: 3363
			[Token(Token = "0x4000D23")]
			DATA_DESIGN,
			// Token: 0x04000D24 RID: 3364
			[Token(Token = "0x4000D24")]
			MOCK_SERVER
		}

		// Token: 0x02000234 RID: 564
		[Token(Token = "0x2000234")]
		[Serializable]
		public class RouteConfig
		{
			// Token: 0x06000D0B RID: 3339 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000D0B")]
			[Address(RVA = "0x174F770", Offset = "0x174E370", VA = "0x18174F770")]
			public RouteConfig()
			{
			}

			// Token: 0x04000D25 RID: 3365
			[Token(Token = "0x4000D25")]
			[FieldOffset(Offset = "0x10")]
			public NetworkOptions.ServerType serverType;

			// Token: 0x04000D26 RID: 3366
			[Token(Token = "0x4000D26")]
			[FieldOffset(Offset = "0x14")]
			public bool enable;

			// Token: 0x04000D27 RID: 3367
			[Token(Token = "0x4000D27")]
			[FieldOffset(Offset = "0x18")]
			public string url;

			// Token: 0x04000D28 RID: 3368
			[Token(Token = "0x4000D28")]
			[FieldOffset(Offset = "0x20")]
			public string gameConfigPlatformUrl;

			// Token: 0x04000D29 RID: 3369
			[Token(Token = "0x4000D29")]
			[FieldOffset(Offset = "0x28")]
			public string gameUpdateV2ApiUrl;
		}
	}
}
