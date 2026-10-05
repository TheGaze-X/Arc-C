using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	public interface IMemoable
	{
		// Token: 0x0600068B RID: 1675
		[Token(Token = "0x600068B")]
		IMemoable Copy();

		// Token: 0x0600068C RID: 1676
		[Token(Token = "0x600068C")]
		void Reset(IMemoable other);
	}
}
