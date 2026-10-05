using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001179 RID: 4473
	[Token(Token = "0x2001179")]
	public class RoguelikeStageData
	{
		// Token: 0x06006F67 RID: 28519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F67")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeStageData()
		{
		}

		// Token: 0x04005FDD RID: 24541
		[Token(Token = "0x4005FDD")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04005FDE RID: 24542
		[Token(Token = "0x4005FDE")]
		[FieldOffset(Offset = "0x18")]
		public string linkedStageId;

		// Token: 0x04005FDF RID: 24543
		[Token(Token = "0x4005FDF")]
		[FieldOffset(Offset = "0x20")]
		public string levelId;

		// Token: 0x04005FE0 RID: 24544
		[Token(Token = "0x4005FE0")]
		[FieldOffset(Offset = "0x28")]
		public string code;

		// Token: 0x04005FE1 RID: 24545
		[Token(Token = "0x4005FE1")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		// Token: 0x04005FE2 RID: 24546
		[Token(Token = "0x4005FE2")]
		[FieldOffset(Offset = "0x38")]
		public string loadingPicId;

		// Token: 0x04005FE3 RID: 24547
		[Token(Token = "0x4005FE3")]
		[FieldOffset(Offset = "0x40")]
		public string description;

		// Token: 0x04005FE4 RID: 24548
		[Token(Token = "0x4005FE4")]
		[FieldOffset(Offset = "0x48")]
		public string eliteDesc;

		// Token: 0x04005FE5 RID: 24549
		[Token(Token = "0x4005FE5")]
		[FieldOffset(Offset = "0x50")]
		public int isBoss;

		// Token: 0x04005FE6 RID: 24550
		[Token(Token = "0x4005FE6")]
		[FieldOffset(Offset = "0x54")]
		public int isElite;

		// Token: 0x04005FE7 RID: 24551
		[Token(Token = "0x4005FE7")]
		[FieldOffset(Offset = "0x58")]
		[JsonConverter(typeof(StringEnumConverter))]
		public LevelData.Difficulty difficulty;
	}
}
