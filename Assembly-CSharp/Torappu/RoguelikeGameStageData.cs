using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200120F RID: 4623
	[Token(Token = "0x200120F")]
	public class RoguelikeGameStageData
	{
		// Token: 0x0600700B RID: 28683 RVA: 0x00032AD8 File Offset: 0x00030CD8
		[Token(Token = "0x600700B")]
		[Address(RVA = "0x2111E50", Offset = "0x2110A50", VA = "0x182111E50")]
		public bool ShouldSerializespecialNodeId()
		{
			return default(bool);
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600700C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameStageData()
		{
		}

		// Token: 0x040063C0 RID: 25536
		[Token(Token = "0x40063C0")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040063C1 RID: 25537
		[Token(Token = "0x40063C1")]
		[FieldOffset(Offset = "0x18")]
		public string linkedStageId;

		// Token: 0x040063C2 RID: 25538
		[Token(Token = "0x40063C2")]
		[FieldOffset(Offset = "0x20")]
		public string levelId;

		// Token: 0x040063C3 RID: 25539
		[Token(Token = "0x40063C3")]
		[FieldOffset(Offset = "0x28")]
		public string[] levelReplaceIds;

		// Token: 0x040063C4 RID: 25540
		[Token(Token = "0x40063C4")]
		[FieldOffset(Offset = "0x30")]
		public string code;

		// Token: 0x040063C5 RID: 25541
		[Token(Token = "0x40063C5")]
		[FieldOffset(Offset = "0x38")]
		public string name;

		// Token: 0x040063C6 RID: 25542
		[Token(Token = "0x40063C6")]
		[FieldOffset(Offset = "0x40")]
		public string loadingPicId;

		// Token: 0x040063C7 RID: 25543
		[Token(Token = "0x40063C7")]
		[FieldOffset(Offset = "0x48")]
		public string description;

		// Token: 0x040063C8 RID: 25544
		[Token(Token = "0x40063C8")]
		[FieldOffset(Offset = "0x50")]
		public string eliteDesc;

		// Token: 0x040063C9 RID: 25545
		[Token(Token = "0x40063C9")]
		[FieldOffset(Offset = "0x58")]
		public int isBoss;

		// Token: 0x040063CA RID: 25546
		[Token(Token = "0x40063CA")]
		[FieldOffset(Offset = "0x5C")]
		public int isElite;

		// Token: 0x040063CB RID: 25547
		[Token(Token = "0x40063CB")]
		[FieldOffset(Offset = "0x60")]
		[JsonConverter(typeof(StringEnumConverter))]
		public LevelData.Difficulty difficulty;

		// Token: 0x040063CC RID: 25548
		[Token(Token = "0x40063CC")]
		[FieldOffset(Offset = "0x68")]
		public string capsulePool;

		// Token: 0x040063CD RID: 25549
		[Token(Token = "0x40063CD")]
		[FieldOffset(Offset = "0x70")]
		public float capsuleProb;

		// Token: 0x040063CE RID: 25550
		[Token(Token = "0x40063CE")]
		[FieldOffset(Offset = "0x78")]
		public List<double> vutresProb;

		// Token: 0x040063CF RID: 25551
		[Token(Token = "0x40063CF")]
		[FieldOffset(Offset = "0x80")]
		public List<double> boxProb;

		// Token: 0x040063D0 RID: 25552
		[Token(Token = "0x40063D0")]
		[FieldOffset(Offset = "0x88")]
		public string specialNodeId;

		// Token: 0x040063D1 RID: 25553
		[Token(Token = "0x40063D1")]
		[FieldOffset(Offset = "0x90")]
		public string redCapsulePool;

		// Token: 0x040063D2 RID: 25554
		[Token(Token = "0x40063D2")]
		[FieldOffset(Offset = "0x98")]
		public float redCapsuleProb;
	}
}
