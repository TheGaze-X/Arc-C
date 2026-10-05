using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200116D RID: 4461
	[Token(Token = "0x200116D")]
	[Serializable]
	public class RoguelikeTable
	{
		// Token: 0x06006F5B RID: 28507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F5B")]
		[Address(RVA = "0x21127C0", Offset = "0x21113C0", VA = "0x1821127C0")]
		public RoguelikeTable()
		{
		}

		// Token: 0x04005F94 RID: 24468
		[Token(Token = "0x4005F94")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeConstTable constTable;

		// Token: 0x04005F95 RID: 24469
		[Token(Token = "0x4005F95")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeItemTable itemTable;

		// Token: 0x04005F96 RID: 24470
		[Token(Token = "0x4005F96")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, RoguelikeStageData> stages;

		// Token: 0x04005F97 RID: 24471
		[Token(Token = "0x4005F97")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, RoguelikeZoneData> zones;

		// Token: 0x04005F98 RID: 24472
		[Token(Token = "0x4005F98")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, RoguelikeChoiceData> choices;

		// Token: 0x04005F99 RID: 24473
		[Token(Token = "0x4005F99")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, RoguelikeChoiceSceneData> choiceScenes;

		// Token: 0x04005F9A RID: 24474
		[Token(Token = "0x4005F9A")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, RoguelikeModeData> modes;

		// Token: 0x04005F9B RID: 24475
		[Token(Token = "0x4005F9B")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, RoguelikeEndingData> endings;

		// Token: 0x04005F9C RID: 24476
		[Token(Token = "0x4005F9C")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<string, RoguelikeOutBuffData> outBuffs;
	}
}
