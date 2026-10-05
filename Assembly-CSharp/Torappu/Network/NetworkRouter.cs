using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Network
{
	// Token: 0x02001525 RID: 5413
	[Token(Token = "0x2001525")]
	public class NetworkRouter : Singleton<NetworkRouter>
	{
		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06007C3D RID: 31805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000EC3")]
		public string networkConfigVersion
		{
			[Token(Token = "0x6007C3D")]
			[Address(RVA = "0x273D6E0", Offset = "0x273C2E0", VA = "0x18273D6E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C3E")]
		[Address(RVA = "0x273D640", Offset = "0x273C240", VA = "0x18273D640")]
		private NetworkRouter()
		{
		}

		// Token: 0x06007C3F RID: 31807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007C3F")]
		[Address(RVA = "0x273CE40", Offset = "0x273BA40", VA = "0x18273CE40")]
		public void ConfirmNetworkConfigVersion(string networkConfigVer)
		{
		}

		// Token: 0x06007C40 RID: 31808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C40")]
		[Address(RVA = "0x273CEC0", Offset = "0x273BAC0", VA = "0x18273CEC0")]
		public NetworkRouter.ConfigHandler FetchConfig()
		{
			return null;
		}

		// Token: 0x06007C41 RID: 31809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C41")]
		[Address(RVA = "0x273D390", Offset = "0x273BF90", VA = "0x18273D390")]
		private static NetworkRouterConfig.Config _GetCurrentConfig(NetworkRouterConfig.Content content)
		{
			return null;
		}

		// Token: 0x06007C42 RID: 31810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C42")]
		[Address(RVA = "0x273D470", Offset = "0x273C070", VA = "0x18273D470")]
		private WebHttpResult _SendFetchConfigService(Action<NetworkRouterConfig.Content> onSuc, Action<string> onFail)
		{
			return null;
		}

		// Token: 0x06007C43 RID: 31811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007C43")]
		[Address(RVA = "0x273D1F0", Offset = "0x273BDF0", VA = "0x18273D1F0")]
		private static NetworkRouterConfig.Content _DeserializeRouterContent(string responseText)
		{
			return null;
		}

		// Token: 0x04007C22 RID: 31778
		[Token(Token = "0x4007C22")]
		[FieldOffset(Offset = "0x10")]
		private string m_networkConfigVersion;

		// Token: 0x04007C23 RID: 31779
		[Token(Token = "0x4007C23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_networkConfigVersion;

		// Token: 0x04007C24 RID: 31780
		[Token(Token = "0x4007C24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007C25 RID: 31781
		[Token(Token = "0x4007C25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ConfirmNetworkConfigVersion;

		// Token: 0x04007C26 RID: 31782
		[Token(Token = "0x4007C26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FetchConfig;

		// Token: 0x04007C27 RID: 31783
		[Token(Token = "0x4007C27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetCurrentConfig;

		// Token: 0x04007C28 RID: 31784
		[Token(Token = "0x4007C28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SendFetchConfigService;

		// Token: 0x04007C29 RID: 31785
		[Token(Token = "0x4007C29")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DeserializeRouterContent;

		// Token: 0x02001526 RID: 5414
		[Token(Token = "0x2001526")]
		public enum ConfigStatus
		{
			// Token: 0x04007C2B RID: 31787
			[Token(Token = "0x4007C2B")]
			NONE,
			// Token: 0x04007C2C RID: 31788
			[Token(Token = "0x4007C2C")]
			SUC,
			// Token: 0x04007C2D RID: 31789
			[Token(Token = "0x4007C2D")]
			ERROR,
			// Token: 0x04007C2E RID: 31790
			[Token(Token = "0x4007C2E")]
			CLIENT_OUT_OF_DATE,
			// Token: 0x04007C2F RID: 31791
			[Token(Token = "0x4007C2F")]
			CANCEL
		}

		// Token: 0x02001527 RID: 5415
		[Token(Token = "0x2001527")]
		public struct FetchConfigResult
		{
			// Token: 0x04007C30 RID: 31792
			[Token(Token = "0x4007C30")]
			[FieldOffset(Offset = "0x0")]
			public NetworkRouterConfig.Content content;

			// Token: 0x04007C31 RID: 31793
			[Token(Token = "0x4007C31")]
			[FieldOffset(Offset = "0x8")]
			public NetworkRouterConfig.Config config;

			// Token: 0x04007C32 RID: 31794
			[Token(Token = "0x4007C32")]
			[FieldOffset(Offset = "0x10")]
			public string error;
		}

		// Token: 0x02001528 RID: 5416
		[Token(Token = "0x2001528")]
		public class ConfigHandler
		{
			// Token: 0x06007C44 RID: 31812 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C44")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			public void BindServiceHandler(WebHttpResult serviceHandler)
			{
			}

			// Token: 0x17000EC4 RID: 3780
			// (get) Token: 0x06007C45 RID: 31813 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007C46 RID: 31814 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EC4")]
			public WebHttpResult serviceHandler
			{
				[Token(Token = "0x6007C45")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6007C46")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC5 RID: 3781
			// (get) Token: 0x06007C47 RID: 31815 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007C48 RID: 31816 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EC5")]
			public Action<NetworkRouterConfig.Content, NetworkRouterConfig.Config> onSuc
			{
				[Token(Token = "0x6007C47")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6007C48")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000EC6 RID: 3782
			// (get) Token: 0x06007C49 RID: 31817 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007C4A RID: 31818 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EC6")]
			public Action<string> onError
			{
				[Token(Token = "0x6007C49")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6007C4A")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000EC7 RID: 3783
			// (get) Token: 0x06007C4B RID: 31819 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06007C4C RID: 31820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EC7")]
			public Action<NetworkRouterConfig.Content> onClientOutOfDate
			{
				[Token(Token = "0x6007C4B")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6007C4C")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000EC8 RID: 3784
			// (get) Token: 0x06007C4D RID: 31821 RVA: 0x00037458 File Offset: 0x00035658
			// (set) Token: 0x06007C4E RID: 31822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EC8")]
			public NetworkRouter.ConfigStatus status
			{
				[Token(Token = "0x6007C4D")]
				[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
				[CompilerGenerated]
				get
				{
					return NetworkRouter.ConfigStatus.NONE;
				}
				[Token(Token = "0x6007C4E")]
				[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000EC9 RID: 3785
			// (get) Token: 0x06007C4F RID: 31823 RVA: 0x00037470 File Offset: 0x00035670
			// (set) Token: 0x06007C50 RID: 31824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000EC9")]
			public NetworkRouter.FetchConfigResult result
			{
				[Token(Token = "0x6007C4F")]
				[Address(RVA = "0x2739440", Offset = "0x2738040", VA = "0x182739440")]
				[CompilerGenerated]
				get
				{
					return default(NetworkRouter.FetchConfigResult);
				}
				[Token(Token = "0x6007C50")]
				[Address(RVA = "0x2739460", Offset = "0x2738060", VA = "0x182739460")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06007C51 RID: 31825 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C51")]
			[Address(RVA = "0x2739390", Offset = "0x2737F90", VA = "0x182739390")]
			public void InvokeSuc(NetworkRouterConfig.Content content, NetworkRouterConfig.Config config)
			{
			}

			// Token: 0x06007C52 RID: 31826 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C52")]
			[Address(RVA = "0x2739300", Offset = "0x2737F00", VA = "0x182739300")]
			public void InvokeError(string error)
			{
			}

			// Token: 0x06007C53 RID: 31827 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C53")]
			[Address(RVA = "0x2739270", Offset = "0x2737E70", VA = "0x182739270")]
			public void InvokeClientOutOfDate(NetworkRouterConfig.Content content)
			{
			}

			// Token: 0x06007C54 RID: 31828 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C54")]
			[Address(RVA = "0x2739220", Offset = "0x2737E20", VA = "0x182739220")]
			public void Cancel()
			{
			}

			// Token: 0x06007C55 RID: 31829 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6007C55")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ConfigHandler()
			{
			}
		}
	}
}
