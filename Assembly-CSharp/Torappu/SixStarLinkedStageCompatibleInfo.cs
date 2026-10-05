using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001370 RID: 4976
	[Token(Token = "0x2001370")]
	[Serializable]
	public class SixStarLinkedStageCompatibleInfo
	{
		// Token: 0x0600733B RID: 29499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600733B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SixStarLinkedStageCompatibleInfo()
		{
		}

		// Token: 0x04006E47 RID: 28231
		[Token(Token = "0x4006E47")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04006E48 RID: 28232
		[Token(Token = "0x4006E48")]
		[FieldOffset(Offset = "0x18")]
		public int apCost;

		// Token: 0x04006E49 RID: 28233
		[Token(Token = "0x4006E49")]
		[FieldOffset(Offset = "0x1C")]
		public int apFailReturn;

		// Token: 0x04006E4A RID: 28234
		[Token(Token = "0x4006E4A")]
		[FieldOffset(Offset = "0x20")]
		public SixStarStageCompatibleDropType dropType;
	}
}
