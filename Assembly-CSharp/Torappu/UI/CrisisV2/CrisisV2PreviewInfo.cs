using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005964 RID: 22884
	[Token(Token = "0x2005964")]
	public struct CrisisV2PreviewInfo
	{
		// Token: 0x0402D7B3 RID: 186291
		[Token(Token = "0x402D7B3")]
		[FieldOffset(Offset = "0x0")]
		public static CrisisV2PreviewInfo EMPTY_INFO;

		// Token: 0x0402D7B4 RID: 186292
		[Token(Token = "0x402D7B4")]
		[FieldOffset(Offset = "0x0")]
		public bool isEmpty;

		// Token: 0x0402D7B5 RID: 186293
		[Token(Token = "0x402D7B5")]
		[FieldOffset(Offset = "0x1")]
		public bool needShowPreview;

		// Token: 0x0402D7B6 RID: 186294
		[Token(Token = "0x402D7B6")]
		[FieldOffset(Offset = "0x8")]
		public string previewId;

		// Token: 0x0402D7B7 RID: 186295
		[Token(Token = "0x402D7B7")]
		[FieldOffset(Offset = "0x10")]
		public string previewTitle;

		// Token: 0x0402D7B8 RID: 186296
		[Token(Token = "0x402D7B8")]
		[FieldOffset(Offset = "0x18")]
		public string previewDesc;

		// Token: 0x0402D7B9 RID: 186297
		[Token(Token = "0x402D7B9")]
		[FieldOffset(Offset = "0x20")]
		public List<CrisisV2TimeLimitItemModel> rewards;

		// Token: 0x0402D7BA RID: 186298
		[Token(Token = "0x402D7BA")]
		[FieldOffset(Offset = "0x28")]
		public List<string> relatedNodeOrBagIds;

		// Token: 0x0402D7BB RID: 186299
		[Token(Token = "0x402D7BB")]
		[FieldOffset(Offset = "0x30")]
		public CrisisV2MapModel.ViewType highlightView;

		// Token: 0x0402D7BC RID: 186300
		[Token(Token = "0x402D7BC")]
		[FieldOffset(Offset = "0x34")]
		public int requiredSelectCount;
	}
}
