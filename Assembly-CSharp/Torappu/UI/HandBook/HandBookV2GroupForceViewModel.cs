using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006727 RID: 26407
	[Token(Token = "0x2006727")]
	public class HandBookV2GroupForceViewModel
	{
		// Token: 0x06025E0E RID: 155150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E0E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2GroupForceViewModel()
		{
		}

		// Token: 0x0403547A RID: 218234
		[Token(Token = "0x403547A")]
		[FieldOffset(Offset = "0x10")]
		public HandBookV2GroupPosData.ForceData forceData;

		// Token: 0x0403547B RID: 218235
		[Token(Token = "0x403547B")]
		[FieldOffset(Offset = "0x18")]
		public List<HandBookV2GroupCharViewModel> charViewModelList;

		// Token: 0x0403547C RID: 218236
		[Token(Token = "0x403547C")]
		[FieldOffset(Offset = "0x20")]
		public HandBookV2GroupForceFavorData favorData;
	}
}
