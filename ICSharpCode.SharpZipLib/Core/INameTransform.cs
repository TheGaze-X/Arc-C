using System;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public interface INameTransform
	{
		// Token: 0x060000B6 RID: 182
		[Token(Token = "0x60000B6")]
		string TransformFile(string name);

		// Token: 0x060000B7 RID: 183
		[Token(Token = "0x60000B7")]
		string TransformDirectory(string name);
	}
}
