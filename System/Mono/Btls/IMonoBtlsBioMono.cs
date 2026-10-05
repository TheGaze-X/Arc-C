using System;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	internal interface IMonoBtlsBioMono
	{
		// Token: 0x0600019D RID: 413
		[Token(Token = "0x600019D")]
		int Read(byte[] buffer, int offset, int size, out bool wantMore);

		// Token: 0x0600019E RID: 414
		[Token(Token = "0x600019E")]
		bool Write(byte[] buffer, int offset, int size);

		// Token: 0x0600019F RID: 415
		[Token(Token = "0x600019F")]
		void Flush();

		// Token: 0x060001A0 RID: 416
		[Token(Token = "0x60001A0")]
		void Close();
	}
}
