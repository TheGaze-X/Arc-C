using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building
{
	// Token: 0x02001842 RID: 6210
	[Token(Token = "0x2001842")]
	public interface IDynamicAssetHandler
	{
		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06009D06 RID: 40198
		[Token(Token = "0x17001139")]
		bool isLoaded { [Token(Token = "0x6009D06")] get; }

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06009D07 RID: 40199
		[Token(Token = "0x1700113A")]
		bool isReleased { [Token(Token = "0x6009D07")] get; }

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06009D08 RID: 40200
		[Token(Token = "0x1700113B")]
		GameObject prefab { [Token(Token = "0x6009D08")] get; }
	}
}
