using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000630 RID: 1584
	[Token(Token = "0x2000630")]
	public class BuildingDIYGetPresetThumbnailUrlRequest : BuildingRequest
	{
		// Token: 0x06006260 RID: 25184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006260")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingDIYGetPresetThumbnailUrlRequest()
		{
		}

		// Token: 0x04002DC0 RID: 11712
		[Token(Token = "0x4002DC0")]
		[FieldOffset(Offset = "0x10")]
		public List<int> solutionId;
	}
}
