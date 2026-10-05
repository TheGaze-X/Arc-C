using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EA4 RID: 3748
	[Token(Token = "0x2000EA4")]
	public class Act4funLiveMatInfoData
	{
		// Token: 0x06006B76 RID: 27510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B76")]
		[Address(RVA = "0x1FF73B0", Offset = "0x1FF5FB0", VA = "0x181FF73B0")]
		public Act4funLiveMatInfoData()
		{
		}

		// Token: 0x04004F22 RID: 20258
		[Token(Token = "0x4004F22")]
		[FieldOffset(Offset = "0x10")]
		public string liveMatId;

		// Token: 0x04004F23 RID: 20259
		[Token(Token = "0x4004F23")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x04004F24 RID: 20260
		[Token(Token = "0x4004F24")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x04004F25 RID: 20261
		[Token(Token = "0x4004F25")]
		[FieldOffset(Offset = "0x28")]
		public string picId;

		// Token: 0x04004F26 RID: 20262
		[Token(Token = "0x4004F26")]
		[FieldOffset(Offset = "0x30")]
		public string tagTxt;

		// Token: 0x04004F27 RID: 20263
		[Token(Token = "0x4004F27")]
		[FieldOffset(Offset = "0x38")]
		public string emojiIcon;

		// Token: 0x04004F28 RID: 20264
		[Token(Token = "0x4004F28")]
		[FieldOffset(Offset = "0x40")]
		public string selectedPerformId;

		// Token: 0x04004F29 RID: 20265
		[Token(Token = "0x4004F29")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<Act4funStageAttributeType, Act4funLiveMatEffectInfo> effectInfos;
	}
}
