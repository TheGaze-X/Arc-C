using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EA0 RID: 3744
	[Token(Token = "0x2000EA0")]
	public class Act4funData
	{
		// Token: 0x06006B72 RID: 27506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B72")]
		[Address(RVA = "0x1FF6F40", Offset = "0x1FF5B40", VA = "0x181FF6F40")]
		public Act4funData()
		{
		}

		// Token: 0x04004F08 RID: 20232
		[Token(Token = "0x4004F08")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act4funPerformGroupInfo> performGroupInfoDict;

		// Token: 0x04004F09 RID: 20233
		[Token(Token = "0x4004F09")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, Act4funPerformInfo> performInfoDict;

		// Token: 0x04004F0A RID: 20234
		[Token(Token = "0x4004F0A")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act4funLiveMatInfoData> normalMatDict;

		// Token: 0x04004F0B RID: 20235
		[Token(Token = "0x4004F0B")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, Act4funSpLiveMatInfoData> spMatDict;

		// Token: 0x04004F0C RID: 20236
		[Token(Token = "0x4004F0C")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, Act4funValueEffectInfoData> valueEffectInfoDict;

		// Token: 0x04004F0D RID: 20237
		[Token(Token = "0x4004F0D")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, Act4funLiveValueInfoData> liveValueInfoDict;

		// Token: 0x04004F0E RID: 20238
		[Token(Token = "0x4004F0E")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, Act4funSuperChatInfo> superChatInfoDict;

		// Token: 0x04004F0F RID: 20239
		[Token(Token = "0x4004F0F")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, Act4funCmtGroupInfo> cmtGroupInfoDict;

		// Token: 0x04004F10 RID: 20240
		[Token(Token = "0x4004F10")]
		[FieldOffset(Offset = "0x50")]
		public List<string> cmtUsers;

		// Token: 0x04004F11 RID: 20241
		[Token(Token = "0x4004F11")]
		[FieldOffset(Offset = "0x58")]
		public Dictionary<string, Act4funEndingInfo> endingDict;

		// Token: 0x04004F12 RID: 20242
		[Token(Token = "0x4004F12")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, Act4funTokenInfoData> tokenLevelInfos;

		// Token: 0x04004F13 RID: 20243
		[Token(Token = "0x4004F13")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, Act4funMissionData> missionDatas;

		// Token: 0x04004F14 RID: 20244
		[Token(Token = "0x4004F14")]
		[FieldOffset(Offset = "0x70")]
		public Act4funConst constant;

		// Token: 0x04004F15 RID: 20245
		[Token(Token = "0x4004F15")]
		[FieldOffset(Offset = "0x78")]
		public Dictionary<string, Act4funStageExtraData> stageExtraDatas;

		// Token: 0x04004F16 RID: 20246
		[Token(Token = "0x4004F16")]
		[FieldOffset(Offset = "0x80")]
		public List<string> randomMsgText;

		// Token: 0x04004F17 RID: 20247
		[Token(Token = "0x4004F17")]
		[FieldOffset(Offset = "0x88")]
		public List<string> randomUserIconId;
	}
}
