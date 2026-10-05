using System;
using Il2CppDummyDll;

namespace Mono.Net.Security
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	internal class AsyncReadRequest : AsyncReadOrWriteRequest
	{
		// Token: 0x060000CD RID: 205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x4F4D940", Offset = "0x4F4C540", VA = "0x184F4D940")]
		public AsyncReadRequest(MobileAuthenticatedStream parent, bool sync, byte[] buffer, int offset, int size)
		{
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x4F4D8C0", Offset = "0x4F4C4C0", VA = "0x184F4D8C0", Slot = "4")]
		protected override AsyncOperationStatus Run(AsyncOperationStatus status)
		{
			return AsyncOperationStatus.Initialize;
		}
	}
}
