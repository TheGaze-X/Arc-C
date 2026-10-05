using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001379 RID: 4985
	[Token(Token = "0x2001379")]
	[Serializable]
	public class StorylineData
	{
		// Token: 0x0600734A RID: 29514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600734A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public StorylineData()
		{
		}

		// Token: 0x04006E99 RID: 28313
		[Token(Token = "0x4006E99")]
		[FieldOffset(Offset = "0x10")]
		public string storylineId;

		// Token: 0x04006E9A RID: 28314
		[Token(Token = "0x4006E9A")]
		[FieldOffset(Offset = "0x18")]
		public StorylineType storylineType;

		// Token: 0x04006E9B RID: 28315
		[Token(Token = "0x4006E9B")]
		[FieldOffset(Offset = "0x1C")]
		public int sortId;

		// Token: 0x04006E9C RID: 28316
		[Token(Token = "0x4006E9C")]
		[FieldOffset(Offset = "0x20")]
		public string storylineName;

		// Token: 0x04006E9D RID: 28317
		[Token(Token = "0x4006E9D")]
		[FieldOffset(Offset = "0x28")]
		public string storylineIconId;

		// Token: 0x04006E9E RID: 28318
		[Token(Token = "0x4006E9E")]
		[FieldOffset(Offset = "0x30")]
		public string storylineLogoId;

		// Token: 0x04006E9F RID: 28319
		[Token(Token = "0x4006E9F")]
		[FieldOffset(Offset = "0x38")]
		public string backgroundId;

		// Token: 0x04006EA0 RID: 28320
		[Token(Token = "0x4006EA0")]
		[FieldOffset(Offset = "0x40")]
		public bool hasVideoToPlay;

		// Token: 0x04006EA1 RID: 28321
		[Token(Token = "0x4006EA1")]
		[FieldOffset(Offset = "0x48")]
		public long startTs;

		// Token: 0x04006EA2 RID: 28322
		[Token(Token = "0x4006EA2")]
		[FieldOffset(Offset = "0x50")]
		public ListDict<string, StorylineLocationData> locations;
	}
}
