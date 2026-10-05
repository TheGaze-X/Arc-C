using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006726 RID: 26406
	[Token(Token = "0x2006726")]
	public class HandBookV2GroupViewModel
	{
		// Token: 0x06025E0D RID: 155149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E0D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2GroupViewModel()
		{
		}

		// Token: 0x04035471 RID: 218225
		[Token(Token = "0x4035471")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04035472 RID: 218226
		[Token(Token = "0x4035472")]
		[FieldOffset(Offset = "0x18")]
		public HandBookV2GroupPosData posData;

		// Token: 0x04035473 RID: 218227
		[Token(Token = "0x4035473")]
		[FieldOffset(Offset = "0x20")]
		public string focusForceId;

		// Token: 0x04035474 RID: 218228
		[Token(Token = "0x4035474")]
		[FieldOffset(Offset = "0x28")]
		public string focusCharId;

		// Token: 0x04035475 RID: 218229
		[Token(Token = "0x4035475")]
		[FieldOffset(Offset = "0x30")]
		public string mainForceId;

		// Token: 0x04035476 RID: 218230
		[Token(Token = "0x4035476")]
		[FieldOffset(Offset = "0x38")]
		public bool hasEnterScale;

		// Token: 0x04035477 RID: 218231
		[Token(Token = "0x4035477")]
		[FieldOffset(Offset = "0x40")]
		public List<HandBookV2GroupColorBlockViewModel> colorBlockList;

		// Token: 0x04035478 RID: 218232
		[Token(Token = "0x4035478")]
		[FieldOffset(Offset = "0x48")]
		public List<HandBookV2GroupCharViewModel> charList;

		// Token: 0x04035479 RID: 218233
		[Token(Token = "0x4035479")]
		[FieldOffset(Offset = "0x50")]
		public List<HandBookV2GroupForceViewModel> forceViewModel;
	}
}
