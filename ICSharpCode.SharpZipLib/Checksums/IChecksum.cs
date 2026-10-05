using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Checksums
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public interface IChecksum
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000066 RID: 102
		[Token(Token = "0x1700000E")]
		long Value { [Token(Token = "0x6000066")] get; }

		// Token: 0x06000067 RID: 103
		[Token(Token = "0x6000067")]
		void Reset();

		// Token: 0x06000068 RID: 104
		[Token(Token = "0x6000068")]
		void Update(int value);

		// Token: 0x06000069 RID: 105
		[Token(Token = "0x6000069")]
		void Update(byte[] buffer);

		// Token: 0x0600006A RID: 106
		[Token(Token = "0x600006A")]
		void Update(byte[] buffer, int offset, int count);
	}
}
