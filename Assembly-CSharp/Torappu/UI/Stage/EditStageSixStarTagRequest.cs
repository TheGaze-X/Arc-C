using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x02006849 RID: 26697
	[Token(Token = "0x2006849")]
	public class EditStageSixStarTagRequest
	{
		// Token: 0x06026386 RID: 156550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026386")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public EditStageSixStarTagRequest()
		{
		}

		// Token: 0x04035DFB RID: 220667
		[Token(Token = "0x4035DFB")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04035DFC RID: 220668
		[Token(Token = "0x4035DFC")]
		[FieldOffset(Offset = "0x18")]
		public List<string> selected;
	}
}
