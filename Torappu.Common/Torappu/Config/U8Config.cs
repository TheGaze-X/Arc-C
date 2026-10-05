using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Torappu.Network;
using XLua;

namespace Torappu.Config
{
	// Token: 0x02000252 RID: 594
	[Token(Token = "0x2000252")]
	public class U8Config : Singleton<U8Config>
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000DB4 RID: 3508 RVA: 0x00008DA4 File Offset: 0x00006FA4
		[Token(Token = "0x1700019E")]
		public U8Config.InitExtConfig extraConfig
		{
			[Token(Token = "0x6000DB4")]
			[Address(RVA = "0x55872C0", Offset = "0x5585EC0", VA = "0x1855872C0")]
			get
			{
				return default(U8Config.InitExtConfig);
			}
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x5586C60", Offset = "0x5585860", VA = "0x185586C60")]
		public void ConfirmExtraConfig(in U8Config.InitExtConfig config)
		{
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x5586CF0", Offset = "0x55858F0", VA = "0x185586CF0")]
		public string GetAppCode()
		{
			return null;
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00008DBC File Offset: 0x00006FBC
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x5586FD0", Offset = "0x5585BD0", VA = "0x185586FD0")]
		public bool IsGameUpdateV2Enabled()
		{
			return default(bool);
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00008DD4 File Offset: 0x00006FD4
		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x5587080", Offset = "0x5585C80", VA = "0x185587080")]
		public bool ShouldUseGameUpdate()
		{
			return default(bool);
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x5586DB0", Offset = "0x55859B0", VA = "0x185586DB0")]
		public string GetRuntimeChannelName()
		{
			return null;
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x5586EC0", Offset = "0x5585AC0", VA = "0x185586EC0")]
		public string GetRuntimeSubChannelName()
		{
			return null;
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00008DEC File Offset: 0x00006FEC
		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x5587120", Offset = "0x5585D20", VA = "0x185587120")]
		private bool _ValidateGameConfig()
		{
			return default(bool);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x55871F0", Offset = "0x5585DF0", VA = "0x1855871F0")]
		private U8Config()
		{
		}

		// Token: 0x04000E13 RID: 3603
		[Token(Token = "0x4000E13")]
		[FieldOffset(Offset = "0x10")]
		private U8Config.InitExtConfig m_extraConfig;

		// Token: 0x04000E14 RID: 3604
		[Token(Token = "0x4000E14")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate277 __Hotfix0_get_extraConfig;

		// Token: 0x04000E15 RID: 3605
		[Token(Token = "0x4000E15")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate278 __Hotfix0_ConfirmExtraConfig;

		// Token: 0x04000E16 RID: 3606
		[Token(Token = "0x4000E16")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate19 __Hotfix0_GetAppCode;

		// Token: 0x04000E17 RID: 3607
		[Token(Token = "0x4000E17")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate21 __Hotfix0_IsGameUpdateV2Enabled;

		// Token: 0x04000E18 RID: 3608
		[Token(Token = "0x4000E18")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate21 __Hotfix0_ShouldUseGameUpdate;

		// Token: 0x04000E19 RID: 3609
		[Token(Token = "0x4000E19")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate19 __Hotfix0_GetRuntimeChannelName;

		// Token: 0x04000E1A RID: 3610
		[Token(Token = "0x4000E1A")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate19 __Hotfix0_GetRuntimeSubChannelName;

		// Token: 0x04000E1B RID: 3611
		[Token(Token = "0x4000E1B")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate21 __Hotfix0__ValidateGameConfig;

		// Token: 0x04000E1C RID: 3612
		[Token(Token = "0x4000E1C")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000253 RID: 595
		[Token(Token = "0x2000253")]
		public struct InitExtConfig
		{
			// Token: 0x06000DBD RID: 3517 RVA: 0x00008E04 File Offset: 0x00007004
			[Token(Token = "0x6000DBD")]
			[Address(RVA = "0x4F1E20", Offset = "0x4F0A20", VA = "0x1804F1E20")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06000DBE RID: 3518 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000DBE")]
			[Address(RVA = "0x55836E0", Offset = "0x55822E0", VA = "0x1855836E0")]
			public static string GetDefaultChannel()
			{
				return null;
			}

			// Token: 0x06000DBF RID: 3519 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000DBF")]
			[Address(RVA = "0x5583710", Offset = "0x5582310", VA = "0x185583710")]
			public static string GetDefaultSubChannel()
			{
				return null;
			}

			// Token: 0x06000DC0 RID: 3520 RVA: 0x00008E1C File Offset: 0x0000701C
			[Token(Token = "0x6000DC0")]
			[Address(RVA = "0x5583740", Offset = "0x5582340", VA = "0x185583740")]
			private static bool _ConvertStrToBoolean(string str, bool defaultVal)
			{
				return default(bool);
			}

			// Token: 0x04000E1D RID: 3613
			[Token(Token = "0x4000E1D")]
			[FieldOffset(Offset = "0x0")]
			public static readonly U8Config.InitExtConfig EMPTY;

			// Token: 0x04000E1E RID: 3614
			[Token(Token = "0x4000E1E")]
			[FieldOffset(Offset = "0x0")]
			public string channel;

			// Token: 0x04000E1F RID: 3615
			[Token(Token = "0x4000E1F")]
			[FieldOffset(Offset = "0x8")]
			public string subChannel;

			// Token: 0x04000E20 RID: 3616
			[Token(Token = "0x4000E20")]
			[FieldOffset(Offset = "0x10")]
			public U8Config.InitExtConfig.NetworkOptions networkOptions;

			// Token: 0x04000E21 RID: 3617
			[Token(Token = "0x4000E21")]
			[FieldOffset(Offset = "0x18")]
			public U8Config.InitExtConfig.GameConfig gameConfig;

			// Token: 0x04000E22 RID: 3618
			[Token(Token = "0x4000E22")]
			[FieldOffset(Offset = "0x20")]
			[JsonIgnore]
			private bool m_isEmpty;

			// Token: 0x02000254 RID: 596
			[Token(Token = "0x2000254")]
			public class NetworkOptions
			{
				// Token: 0x06000DC2 RID: 3522 RVA: 0x00008E34 File Offset: 0x00007034
				[Token(Token = "0x6000DC2")]
				[Address(RVA = "0x55849B0", Offset = "0x55835B0", VA = "0x1855849B0")]
				public Networker.Configuration ToNetworkConfig()
				{
					return default(Networker.Configuration);
				}

				// Token: 0x06000DC3 RID: 3523 RVA: 0x000020FA File Offset: 0x000002FA
				[Token(Token = "0x6000DC3")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public NetworkOptions()
				{
				}

				// Token: 0x04000E23 RID: 3619
				[Token(Token = "0x4000E23")]
				[FieldOffset(Offset = "0x10")]
				public string routerUrl;

				// Token: 0x04000E24 RID: 3620
				[Token(Token = "0x4000E24")]
				[FieldOffset(Offset = "0x18")]
				public string gameServerUrl;

				// Token: 0x04000E25 RID: 3621
				[Token(Token = "0x4000E25")]
				[FieldOffset(Offset = "0x20")]
				public string sdkServerUrl;

				// Token: 0x04000E26 RID: 3622
				[Token(Token = "0x4000E26")]
				[FieldOffset(Offset = "0x28")]
				public string u8ServerUrl;

				// Token: 0x04000E27 RID: 3623
				[Token(Token = "0x4000E27")]
				[FieldOffset(Offset = "0x30")]
				public string hotUpdateUrl;

				// Token: 0x04000E28 RID: 3624
				[Token(Token = "0x4000E28")]
				[FieldOffset(Offset = "0x38")]
				public string configUrl;

				// Token: 0x04000E29 RID: 3625
				[Token(Token = "0x4000E29")]
				[FieldOffset(Offset = "0x40")]
				public string versionUrl;

				// Token: 0x04000E2A RID: 3626
				[Token(Token = "0x4000E2A")]
				[FieldOffset(Offset = "0x48")]
				public string announceUrl;

				// Token: 0x04000E2B RID: 3627
				[Token(Token = "0x4000E2B")]
				[FieldOffset(Offset = "0x50")]
				public string preAnnounceUrl;

				// Token: 0x04000E2C RID: 3628
				[Token(Token = "0x4000E2C")]
				[FieldOffset(Offset = "0x58")]
				public string serviceLicenseUrl;

				// Token: 0x04000E2D RID: 3629
				[Token(Token = "0x4000E2D")]
				[FieldOffset(Offset = "0x60")]
				public string officialUrl;

				// Token: 0x04000E2E RID: 3630
				[Token(Token = "0x4000E2E")]
				[FieldOffset(Offset = "0x68")]
				public string packageDownloadUrlAndroid;

				// Token: 0x04000E2F RID: 3631
				[Token(Token = "0x4000E2F")]
				[FieldOffset(Offset = "0x70")]
				public string packageDownloadUrlIOS;

				// Token: 0x04000E30 RID: 3632
				[Token(Token = "0x4000E30")]
				[FieldOffset(Offset = "0x78")]
				public string devsdk;
			}

			// Token: 0x02000255 RID: 597
			[Token(Token = "0x2000255")]
			public class GameConfig
			{
				// Token: 0x06000DC4 RID: 3524 RVA: 0x000020FA File Offset: 0x000002FA
				[Token(Token = "0x6000DC4")]
				[Address(RVA = "0x55817F0", Offset = "0x55803F0", VA = "0x1855817F0")]
				public GameConfig()
				{
				}

				// Token: 0x04000E31 RID: 3633
				[Token(Token = "0x4000E31")]
				[FieldOffset(Offset = "0x10")]
				public string channel;

				// Token: 0x04000E32 RID: 3634
				[Token(Token = "0x4000E32")]
				[FieldOffset(Offset = "0x18")]
				public string env;

				// Token: 0x04000E33 RID: 3635
				[Token(Token = "0x4000E33")]
				[FieldOffset(Offset = "0x20")]
				public string envAudit;

				// Token: 0x04000E34 RID: 3636
				[Token(Token = "0x4000E34")]
				[FieldOffset(Offset = "0x28")]
				public string appCode;

				// Token: 0x04000E35 RID: 3637
				[Token(Token = "0x4000E35")]
				[FieldOffset(Offset = "0x30")]
				public bool enableGameUpdateV2;

				// Token: 0x04000E36 RID: 3638
				[Token(Token = "0x4000E36")]
				[FieldOffset(Offset = "0x31")]
				public bool useGameUpdate;
			}
		}
	}
}
