using System;
using Il2CppDummyDll;
using U8.SDK;

namespace XDSDK
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	public class U8PluginWindows : U8Plugin
	{
		// Token: 0x0600030F RID: 783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x513DF0", Offset = "0x5129F0", VA = "0x180513DF0")]
		public U8PluginWindows(XDSDK sdk, XDSDK.SDKOptions options)
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x514250", Offset = "0x512E50", VA = "0x180514250", Slot = "21")]
		protected override void PayImplement(ExternalPluginPayParams pluginParam, Action<XDSDK.PayResult> callback)
		{
		}
	}
}
