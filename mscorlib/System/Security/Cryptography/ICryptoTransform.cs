using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace System.Security.Cryptography
{
	// Token: 0x02000306 RID: 774
	[Token(Token = "0x2000306")]
	[System.Runtime.InteropServices.ComVisible(true)]
	public interface ICryptoTransform : System.IDisposable
	{
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06001962 RID: 6498
		[Token(Token = "0x170002B1")]
		int InputBlockSize { [Token(Token = "0x6001962")] get; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06001963 RID: 6499
		[Token(Token = "0x170002B2")]
		int OutputBlockSize { [Token(Token = "0x6001963")] get; }

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001964 RID: 6500
		[Token(Token = "0x170002B3")]
		bool CanTransformMultipleBlocks { [Token(Token = "0x6001964")] get; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001965 RID: 6501
		[Token(Token = "0x170002B4")]
		bool CanReuseTransform { [Token(Token = "0x6001965")] get; }

		// Token: 0x06001966 RID: 6502
		[Token(Token = "0x6001966")]
		int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset);

		// Token: 0x06001967 RID: 6503
		[Token(Token = "0x6001967")]
		byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount);
	}
}
