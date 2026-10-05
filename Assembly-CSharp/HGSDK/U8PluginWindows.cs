using System;
using Il2CppDummyDll;
using U8.SDK;

namespace HGSDK
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	public class U8PluginWindows : U8Plugin
	{
		// Token: 0x060003E1 RID: 993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x103E090", Offset = "0x103CC90", VA = "0x18103E090")]
		public U8PluginWindows(HGSDK sdk, HGSDK.SDKOptions options)
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x103E4F0", Offset = "0x103D0F0", VA = "0x18103E4F0", Slot = "21")]
		protected override void PayImplement(ExternalPluginPayParams pluginParam, Action<HGSDK.PayResult> callback)
		{
		}
	}
}
