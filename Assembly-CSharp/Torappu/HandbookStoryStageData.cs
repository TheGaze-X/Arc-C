using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001095 RID: 4245
	[Token(Token = "0x2001095")]
	public class HandbookStoryStageData
	{
		// Token: 0x06006E1F RID: 28191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E1F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandbookStoryStageData()
		{
		}

		// Token: 0x04005A8B RID: 23179
		[Token(Token = "0x4005A8B")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04005A8C RID: 23180
		[Token(Token = "0x4005A8C")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04005A8D RID: 23181
		[Token(Token = "0x4005A8D")]
		[FieldOffset(Offset = "0x20")]
		public string levelId;

		// Token: 0x04005A8E RID: 23182
		[Token(Token = "0x4005A8E")]
		[FieldOffset(Offset = "0x28")]
		public string zoneId;

		// Token: 0x04005A8F RID: 23183
		[Token(Token = "0x4005A8F")]
		[FieldOffset(Offset = "0x30")]
		public string code;

		// Token: 0x04005A90 RID: 23184
		[Token(Token = "0x4005A90")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x04005A91 RID: 23185
		[Token(Token = "0x4005A91")]
		[FieldOffset(Offset = "0x40")]
		public string loadingPicId;

		// Token: 0x04005A92 RID: 23186
		[Token(Token = "0x4005A92")]
		[FieldOffset(Offset = "0x48")]
		public string description;

		// Token: 0x04005A93 RID: 23187
		[Token(Token = "0x4005A93")]
		[FieldOffset(Offset = "0x50")]
		public List<HandbookUnlockParam> unlockParam;

		// Token: 0x04005A94 RID: 23188
		[Token(Token = "0x4005A94")]
		[FieldOffset(Offset = "0x58")]
		public List<ItemBundle> rewardItem;

		// Token: 0x04005A95 RID: 23189
		[Token(Token = "0x4005A95")]
		[FieldOffset(Offset = "0x60")]
		public long stageGetTime;
	}
}
