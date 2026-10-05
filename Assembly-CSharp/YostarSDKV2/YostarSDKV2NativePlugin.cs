using System;
using Il2CppDummyDll;
using U8.SDK;

namespace YostarSDKV2
{
	// Token: 0x02000092 RID: 146
	[Token(Token = "0x2000092")]
	public class YostarSDKV2NativePlugin : YostarSDKV2Plugin
	{
		// Token: 0x06000264 RID: 612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x51B7B0", Offset = "0x51A3B0", VA = "0x18051B7B0")]
		public YostarSDKV2NativePlugin(YostarSDKV2 sdk)
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x51B7C0", Offset = "0x51A3C0", VA = "0x18051B7C0", Slot = "17")]
		public override void Login(ExternalPluginLoginParams args)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x51B930", Offset = "0x51A530", VA = "0x18051B930", Slot = "18")]
		public override void Pay(ExternalPluginPayParams args)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x51B8E0", Offset = "0x51A4E0", VA = "0x18051B8E0", Slot = "19")]
		public override void Logout(ExternalPluginLogoutParams args)
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x51BCA0", Offset = "0x51A8A0", VA = "0x18051BCA0")]
		private void _OpenTempLoginDialog(ExternalPluginLoginParams args)
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x51BAB0", Offset = "0x51A6B0", VA = "0x18051BAB0")]
		private void _OpenJPLoginDialog(ExternalPluginLoginParams args)
		{
		}
	}
}
