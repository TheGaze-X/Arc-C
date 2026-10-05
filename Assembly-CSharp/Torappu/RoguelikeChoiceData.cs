using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200117B RID: 4475
	[Token(Token = "0x200117B")]
	public class RoguelikeChoiceData
	{
		// Token: 0x06006F69 RID: 28521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F69")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeChoiceData()
		{
		}

		// Token: 0x04005FEE RID: 24558
		[Token(Token = "0x4005FEE")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005FEF RID: 24559
		[Token(Token = "0x4005FEF")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x04005FF0 RID: 24560
		[Token(Token = "0x4005FF0")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x04005FF1 RID: 24561
		[Token(Token = "0x4005FF1")]
		[FieldOffset(Offset = "0x28")]
		public string type;

		// Token: 0x04005FF2 RID: 24562
		[Token(Token = "0x4005FF2")]
		[FieldOffset(Offset = "0x30")]
		public string nextSceneId;

		// Token: 0x04005FF3 RID: 24563
		[Token(Token = "0x4005FF3")]
		[FieldOffset(Offset = "0x38")]
		public string icon;

		// Token: 0x04005FF4 RID: 24564
		[Token(Token = "0x4005FF4")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, object> param;
	}
}
