using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200672C RID: 26412
	[Token(Token = "0x200672C")]
	public class HandBookV2GroupColorBlockViewModel
	{
		// Token: 0x06025E19 RID: 155161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E19")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2GroupColorBlockViewModel()
		{
		}

		// Token: 0x04035491 RID: 218257
		[Token(Token = "0x4035491")]
		[FieldOffset(Offset = "0x10")]
		public List<HandBookV2GroupConnectViewModel> connectList;

		// Token: 0x04035492 RID: 218258
		[Token(Token = "0x4035492")]
		[FieldOffset(Offset = "0x18")]
		public HandBookV2GroupPosData.ForceData forceData;

		// Token: 0x04035493 RID: 218259
		[Token(Token = "0x4035493")]
		[FieldOffset(Offset = "0x20")]
		public HandBookV2GroupPosData.ColoringBlockData colorBlockData;

		// Token: 0x04035494 RID: 218260
		[Token(Token = "0x4035494")]
		[FieldOffset(Offset = "0x28")]
		public bool isForceAvail;
	}
}
