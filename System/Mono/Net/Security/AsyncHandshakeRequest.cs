using System;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	internal class AsyncHandshakeRequest : AsyncProtocolRequest
	{
		// Token: 0x060000C6 RID: 198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x4F4D1F0", Offset = "0x4F4BDF0", VA = "0x184F4D1F0")]
		public AsyncHandshakeRequest(MobileAuthenticatedStream parent, bool sync)
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x4F4D1C0", Offset = "0x4F4BDC0", VA = "0x184F4D1C0", Slot = "4")]
		protected override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			return AsyncOperationStatus.Initialize;
		}
	}
}
