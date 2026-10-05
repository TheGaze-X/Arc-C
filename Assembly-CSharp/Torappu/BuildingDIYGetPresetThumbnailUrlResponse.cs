using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000631 RID: 1585
	[Token(Token = "0x2000631")]
	public class BuildingDIYGetPresetThumbnailUrlResponse
	{
		// Token: 0x06006261 RID: 25185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006261")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingDIYGetPresetThumbnailUrlResponse()
		{
		}

		// Token: 0x04002DC1 RID: 11713
		[Token(Token = "0x4002DC1")]
		[FieldOffset(Offset = "0x10")]
		public List<string> url;
	}
}
