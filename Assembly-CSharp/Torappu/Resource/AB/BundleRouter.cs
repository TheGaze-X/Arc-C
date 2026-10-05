using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Resource.AB
{
	// Token: 0x02001779 RID: 6009
	[Token(Token = "0x2001779")]
	public class BundleRouter : IBundleRouter
	{
		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x060097AA RID: 38826 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060097AB RID: 38827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001046")]
		public string streamingResPath
		{
			[Token(Token = "0x60097AA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60097AB")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x060097AC RID: 38828 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060097AD RID: 38829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001047")]
		public string persistentResPath
		{
			[Token(Token = "0x60097AC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60097AD")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001048 RID: 4168
		// (get) Token: 0x060097AE RID: 38830 RVA: 0x0003AED8 File Offset: 0x000390D8
		// (set) Token: 0x060097AF RID: 38831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001048")]
		public ResourceOptions.Mode mode
		{
			[Token(Token = "0x60097AE")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return ResourceOptions.Mode.DEVELOPMENT_LOCAL;
			}
			[Token(Token = "0x60097AF")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060097B0 RID: 38832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097B0")]
		[Address(RVA = "0x31240D0", Offset = "0x3122CD0", VA = "0x1831240D0")]
		public BundleRouter(bool useStreamingOnly)
		{
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097B1")]
		[Address(RVA = "0x3123350", Offset = "0x3121F50", VA = "0x183123350", Slot = "4")]
		public string GetFullPath(string path)
		{
			return null;
		}

		// Token: 0x060097B2 RID: 38834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097B2")]
		[Address(RVA = "0x3123110", Offset = "0x3121D10", VA = "0x183123110")]
		public void GetFullPathInfo(string path, out string fullPath, out bool isInteralAsset)
		{
		}

		// Token: 0x060097B3 RID: 38835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097B3")]
		[Address(RVA = "0x31234F0", Offset = "0x31220F0", VA = "0x1831234F0")]
		public string GetStreamingOnlyPath(string path)
		{
			return null;
		}

		// Token: 0x060097B4 RID: 38836 RVA: 0x0003AEF0 File Offset: 0x000390F0
		[Token(Token = "0x60097B4")]
		[Address(RVA = "0x31235E0", Offset = "0x31221E0", VA = "0x1831235E0")]
		public bool SelectAndCheckManifestPath(out string name, out string path, out bool isStreaming)
		{
			return default(bool);
		}

		// Token: 0x060097B5 RID: 38837 RVA: 0x0003AF08 File Offset: 0x00039108
		[Token(Token = "0x60097B5")]
		[Address(RVA = "0x3123BE0", Offset = "0x31227E0", VA = "0x183123BE0")]
		private bool _ValidatePersistentInitialBundles(out string manifestName, out string path)
		{
			return default(bool);
		}

		// Token: 0x060097B6 RID: 38838 RVA: 0x0003AF20 File Offset: 0x00039120
		[Token(Token = "0x60097B6")]
		[Address(RVA = "0x3123AB0", Offset = "0x31226B0", VA = "0x183123AB0")]
		private bool _TryGetStreamingManifestPath(out string name, out string path)
		{
			return default(bool);
		}

		// Token: 0x060097B7 RID: 38839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097B7")]
		[Address(RVA = "0x3123750", Offset = "0x3122350", VA = "0x183123750")]
		public static string StaticStreamingOnlyPath(string path)
		{
			return null;
		}

		// Token: 0x060097B8 RID: 38840 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097B8")]
		[Address(RVA = "0x3123400", Offset = "0x3122000", VA = "0x183123400")]
		public static string GetRuntimePlatformKey()
		{
			return null;
		}

		// Token: 0x060097B9 RID: 38841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097B9")]
		[Address(RVA = "0x3122FD0", Offset = "0x3121BD0", VA = "0x183122FD0")]
		public static string GenerateStreamingResPath()
		{
			return null;
		}

		// Token: 0x060097BA RID: 38842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097BA")]
		[Address(RVA = "0x31233F0", Offset = "0x3121FF0", VA = "0x1831233F0")]
		public static string GetPersistentRootPath()
		{
			return null;
		}

		// Token: 0x060097BB RID: 38843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097BB")]
		[Address(RVA = "0x3123550", Offset = "0x3122150", VA = "0x183123550")]
		public static string LegacyGeneratePersistentResPath()
		{
			return null;
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097BC")]
		[Address(RVA = "0x3122F60", Offset = "0x3121B60", VA = "0x183122F60")]
		public static string GeneratePersistentResPath()
		{
			return null;
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097BD")]
		[Address(RVA = "0x3122EE0", Offset = "0x3121AE0", VA = "0x183122EE0")]
		public static string GenerateCacheResPath()
		{
			return null;
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097BE")]
		[Address(RVA = "0x31230A0", Offset = "0x3121CA0", VA = "0x1831230A0")]
		public static string GetDownloadSDKWorkspace()
		{
			return null;
		}

		// Token: 0x060097BF RID: 38847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097BF")]
		[Address(RVA = "0x3123380", Offset = "0x3121F80", VA = "0x183123380")]
		public static string GetGameUpdateSDKWorkspace()
		{
			return null;
		}

		// Token: 0x060097C0 RID: 38848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60097C0")]
		[Address(RVA = "0x3123910", Offset = "0x3122510", VA = "0x183123910")]
		private void _InitPersistResInfo()
		{
		}

		// Token: 0x060097C1 RID: 38849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60097C1")]
		[Address(RVA = "0x31237B0", Offset = "0x31223B0", VA = "0x1831237B0")]
		private string _GetPersistABPath(string resPath)
		{
			return null;
		}

		// Token: 0x04008DC6 RID: 36294
		[Token(Token = "0x4008DC6")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, HotUpdateInfo.ABInfo> m_persistRefInfo;

		// Token: 0x04008DC7 RID: 36295
		[Token(Token = "0x4008DC7")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isStreamingOnly;
	}
}
