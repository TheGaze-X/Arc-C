using System;
using Il2CppDummyDll;

namespace Torappu.Config
{
	// Token: 0x02000248 RID: 584
	[Token(Token = "0x2000248")]
	public interface IDynGameConfig
	{
		// Token: 0x06000D40 RID: 3392
		[Token(Token = "0x6000D40")]
		string ConfigName();

		// Token: 0x06000D41 RID: 3393
		[Token(Token = "0x6000D41")]
		bool DistinctChannel();

		// Token: 0x06000D42 RID: 3394
		[Token(Token = "0x6000D42")]
		bool DistinctPlatform();

		// Token: 0x06000D43 RID: 3395
		[Token(Token = "0x6000D43")]
		Type GetDataType();

		// Token: 0x06000D44 RID: 3396
		[Token(Token = "0x6000D44")]
		void SetData(object data);
	}
}
