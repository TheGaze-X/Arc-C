using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView.Internal
{
	// Token: 0x0200009B RID: 155
	[Token(Token = "0x200009B")]
	public class WebPluginFactory
	{
		// Token: 0x0600048A RID: 1162 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x5BD4ED0", Offset = "0x5BD3AD0", VA = "0x185BD4ED0", Slot = "4")]
		public virtual List<IWebPlugin> GetAllPlugins()
		{
			return null;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x5BD4F50", Offset = "0x5BD3B50", VA = "0x185BD4F50", Slot = "5")]
		public virtual IWebPlugin GetDefaultPlugin([Optional] WebPluginType[] preferredPlugins)
		{
			return null;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x5BD5100", Offset = "0x5BD3D00", VA = "0x185BD5100")]
		public static void RegisterAndroidPlugin(IWebPlugin plugin)
		{
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x5BD5010", Offset = "0x5BD3C10", VA = "0x185BD5010")]
		public static void RegisterAndroidGeckoPlugin(IWebPlugin plugin)
		{
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x5BD51F0", Offset = "0x5BD3DF0", VA = "0x185BD51F0")]
		public static void RegisterIOSPlugin(IWebPlugin plugin)
		{
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x5BD52E0", Offset = "0x5BD3EE0", VA = "0x185BD52E0")]
		public static void RegisterStandalonePlugin(IWebPlugin plugin)
		{
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x5BD53D0", Offset = "0x5BD3FD0", VA = "0x185BD53D0")]
		public static void RegisterUwpPlugin(IWebPlugin plugin)
		{
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x5BD54C0", Offset = "0x5BD40C0", VA = "0x185BD54C0")]
		public static void RegisterVisionOSPlugin(IWebPlugin plugin)
		{
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x5BD55B0", Offset = "0x5BD41B0", VA = "0x185BD55B0")]
		public static void RegisterWebGLPlugin(IWebPlugin plugin)
		{
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x5BD56A0", Offset = "0x5BD42A0", VA = "0x185BD56A0")]
		private static void _addPlugin(IWebPlugin plugin)
		{
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x5BD5730", Offset = "0x5BD4330", VA = "0x185BD5730")]
		private void _assertNotTooEarly()
		{
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x5BD57E0", Offset = "0x5BD43E0", VA = "0x185BD57E0")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
		private static void _beforeSceneLoad()
		{
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x5BD58C0", Offset = "0x5BD44C0", VA = "0x185BD58C0")]
		private IWebPlugin _choosePlugin(IWebPlugin plugin, string buildPlatform, string packageName, string storeUrlPath)
		{
			return null;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x5BD5C80", Offset = "0x5BD4880", VA = "0x185BD5C80")]
		private string _getMoreInfoText(string storeUrlPath)
		{
			return null;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x5BD5CD0", Offset = "0x5BD48D0", VA = "0x185BD5CD0")]
		private void _logMockWarningOnce(string reason)
		{
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public WebPluginFactory()
		{
		}

		// Token: 0x04000223 RID: 547
		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected static HashSet<IWebPlugin> _allPlugins;

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected static IWebPlugin _androidPlugin;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected static IWebPlugin _androidGeckoPlugin;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool _beforeSceneLoadCalled;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected static IWebPlugin _iosPlugin;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _mockWarningLogged;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected static IWebPlugin _standalonePlugin;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected static IWebPlugin _uwpPlugin;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected static IWebPlugin _visionOSPlugin;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected static IWebPlugin _webGLPlugin;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static bool IgnoreMissingPluginInEditor;
	}
}
