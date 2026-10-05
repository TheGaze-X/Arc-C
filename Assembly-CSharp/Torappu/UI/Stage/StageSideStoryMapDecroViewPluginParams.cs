using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x02006819 RID: 26649
	[Token(Token = "0x2006819")]
	public struct StageSideStoryMapDecroViewPluginParams
	{
		// Token: 0x04035C99 RID: 220313
		[Token(Token = "0x4035C99")]
		[FieldOffset(Offset = "0x0")]
		public List<ZoneViewModel> viewModelList;

		// Token: 0x04035C9A RID: 220314
		[Token(Token = "0x4035C9A")]
		[FieldOffset(Offset = "0x8")]
		public string selectedZoneId;
	}
}
