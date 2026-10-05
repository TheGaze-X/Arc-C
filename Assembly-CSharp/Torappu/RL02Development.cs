using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011F3 RID: 4595
	[Token(Token = "0x20011F3")]
	public class RL02Development
	{
		// Token: 0x06006FE3 RID: 28643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FE3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL02Development()
		{
		}

		// Token: 0x040062C4 RID: 25284
		[Token(Token = "0x40062C4")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x040062C5 RID: 25285
		[Token(Token = "0x40062C5")]
		[FieldOffset(Offset = "0x18")]
		public RL02DevelopmentNodeType nodeType;

		// Token: 0x040062C6 RID: 25286
		[Token(Token = "0x40062C6")]
		[FieldOffset(Offset = "0x20")]
		public List<string> frontNodeId;

		// Token: 0x040062C7 RID: 25287
		[Token(Token = "0x40062C7")]
		[FieldOffset(Offset = "0x28")]
		public List<string> nextNodeId;

		// Token: 0x040062C8 RID: 25288
		[Token(Token = "0x40062C8")]
		[FieldOffset(Offset = "0x30")]
		public int positionP;

		// Token: 0x040062C9 RID: 25289
		[Token(Token = "0x40062C9")]
		[FieldOffset(Offset = "0x34")]
		public int positionR;

		// Token: 0x040062CA RID: 25290
		[Token(Token = "0x40062CA")]
		[FieldOffset(Offset = "0x38")]
		public int tokenCost;

		// Token: 0x040062CB RID: 25291
		[Token(Token = "0x40062CB")]
		[FieldOffset(Offset = "0x40")]
		public string buffName;

		// Token: 0x040062CC RID: 25292
		[Token(Token = "0x40062CC")]
		[FieldOffset(Offset = "0x48")]
		public string buffIconId;

		// Token: 0x040062CD RID: 25293
		[Token(Token = "0x40062CD")]
		[FieldOffset(Offset = "0x50")]
		public RL02DevelopmentEffectType effectType;

		// Token: 0x040062CE RID: 25294
		[Token(Token = "0x40062CE")]
		[FieldOffset(Offset = "0x58")]
		public string rawDesc;

		// Token: 0x040062CF RID: 25295
		[Token(Token = "0x40062CF")]
		[FieldOffset(Offset = "0x60")]
		public List<RoguelikeTopicDisplayItem> buffDisplayInfo;

		// Token: 0x040062D0 RID: 25296
		[Token(Token = "0x40062D0")]
		[FieldOffset(Offset = "0x68")]
		public string enrollId;
	}
}
