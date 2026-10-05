using System;
using Il2CppDummyDll;
using U8.SDK;

namespace XDSDK
{
	// Token: 0x020000A2 RID: 162
	[Token(Token = "0x20000A2")]
	public class U8PluginAndroid : U8Plugin
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x513DF0", Offset = "0x5129F0", VA = "0x180513DF0")]
		public U8PluginAndroid(XDSDK sdk, XDSDK.SDKOptions options)
		{
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x513C80", Offset = "0x512880", VA = "0x180513C80", Slot = "21")]
		protected override void PayImplement(ExternalPluginPayParams pluginParam, Action<XDSDK.PayResult> callback)
		{
		}
	}
}
