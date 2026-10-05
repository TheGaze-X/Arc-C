using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E9B RID: 3739
	[Token(Token = "0x2000E9B")]
	public class AprilFoolStageData
	{
		// Token: 0x06006B6F RID: 27503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B6F")]
		[Address(RVA = "0x1FFDE80", Offset = "0x1FFCA80", VA = "0x181FFDE80")]
		public AprilFoolStageData()
		{
		}

		// Token: 0x04004EF1 RID: 20209
		[Token(Token = "0x4004EF1")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04004EF2 RID: 20210
		[Token(Token = "0x4004EF2")]
		[FieldOffset(Offset = "0x18")]
		public string levelId;

		// Token: 0x04004EF3 RID: 20211
		[Token(Token = "0x4004EF3")]
		[FieldOffset(Offset = "0x20")]
		public string code;

		// Token: 0x04004EF4 RID: 20212
		[Token(Token = "0x4004EF4")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x04004EF5 RID: 20213
		[Token(Token = "0x4004EF5")]
		[FieldOffset(Offset = "0x30")]
		public AppearanceStyle appearanceStyle;

		// Token: 0x04004EF6 RID: 20214
		[Token(Token = "0x4004EF6")]
		[FieldOffset(Offset = "0x38")]
		public string loadingPicId;

		// Token: 0x04004EF7 RID: 20215
		[Token(Token = "0x4004EF7")]
		[FieldOffset(Offset = "0x40")]
		[JsonConverter(typeof(StringEnumConverter))]
		public LevelData.Difficulty difficulty;

		// Token: 0x04004EF8 RID: 20216
		[Token(Token = "0x4004EF8")]
		[FieldOffset(Offset = "0x48")]
		public List<StageData.ConditionDesc> unlockCondition;

		// Token: 0x04004EF9 RID: 20217
		[Token(Token = "0x4004EF9")]
		[FieldOffset(Offset = "0x50")]
		public List<ItemBundle> stageDropInfo;
	}
}
