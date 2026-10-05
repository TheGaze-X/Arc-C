using System;
using Il2CppDummyDll;
using U8.SDK;

namespace HGSDK
{
	// Token: 0x020000E5 RID: 229
	[Token(Token = "0x20000E5")]
	public class U8PluginAndroid : U8Plugin
	{
		// Token: 0x060003B2 RID: 946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x103E090", Offset = "0x103CC90", VA = "0x18103E090")]
		public U8PluginAndroid(HGSDK sdk, HGSDK.SDKOptions options)
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x103DF20", Offset = "0x103CB20", VA = "0x18103DF20", Slot = "21")]
		protected override void PayImplement(ExternalPluginPayParams pluginParam, Action<HGSDK.PayResult> callback)
		{
		}
	}
}
