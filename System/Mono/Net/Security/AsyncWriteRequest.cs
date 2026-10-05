using System;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	internal class AsyncWriteRequest : AsyncReadOrWriteRequest
	{
		// Token: 0x060000CF RID: 207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x4F4D940", Offset = "0x4F4C540", VA = "0x184F4D940")]
		public AsyncWriteRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x4F4D950", Offset = "0x4F4C550", VA = "0x184F4D950", Slot = "4")]
		protected override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			return AsyncOperationStatus.Initialize;
		}
	}
}
