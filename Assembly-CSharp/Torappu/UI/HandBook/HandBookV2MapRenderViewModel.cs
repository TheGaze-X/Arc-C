using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200672F RID: 26415
	[Token(Token = "0x200672F")]
	public class HandBookV2MapRenderViewModel
	{
		// Token: 0x06025E29 RID: 155177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E29")]
		[Address(RVA = "0x20E2A20", Offset = "0x20E1620", VA = "0x1820E2A20")]
		public HandBookV2MapRenderViewModel()
		{
		}

		// Token: 0x040354AC RID: 218284
		[Token(Token = "0x40354AC")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, HandBookV2ForceViewModel> forceId2ForceViewModelMap;

		// Token: 0x040354AD RID: 218285
		[Token(Token = "0x40354AD")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<int, string> pointIndex2ForceIndexMap;

		// Token: 0x040354AE RID: 218286
		[Token(Token = "0x40354AE")]
		[FieldOffset(Offset = "0x20")]
		public List<HandBookV2ForceLineViewModel> forceLineList;

		// Token: 0x040354AF RID: 218287
		[Token(Token = "0x40354AF")]
		[FieldOffset(Offset = "0x28")]
		public List<HandBookV2PointLineViewModel> pointLineList;

		// Token: 0x040354B0 RID: 218288
		[Token(Token = "0x40354B0")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, string> charId2ForceIdMap;
	}
}
