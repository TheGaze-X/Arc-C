using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001157 RID: 4439
	[Token(Token = "0x2001157")]
	public class RoguelikeActivitySeedModeData
	{
		// Token: 0x06006F32 RID: 28466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F32")]
		[Address(RVA = "0x2110440", Offset = "0x210F040", VA = "0x182110440")]
		public RoguelikeActivitySeedModeData()
		{
		}

		// Token: 0x04005F17 RID: 24343
		[Token(Token = "0x4005F17")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeActivitySeedModeData.RoguelikeActivityOfficialSeedData> officialSeedDataList;

		// Token: 0x04005F18 RID: 24344
		[Token(Token = "0x4005F18")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeActivitySeedModeData.RoguelikeActivitySeedModeConstData constData;

		// Token: 0x02001158 RID: 4440
		[Token(Token = "0x2001158")]
		public class RoguelikeActivityOfficialSeedData
		{
			// Token: 0x06006F33 RID: 28467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F33")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoguelikeActivityOfficialSeedData()
			{
			}

			// Token: 0x04005F19 RID: 24345
			[Token(Token = "0x4005F19")]
			[FieldOffset(Offset = "0x10")]
			public string seed;

			// Token: 0x04005F1A RID: 24346
			[Token(Token = "0x4005F1A")]
			[FieldOffset(Offset = "0x18")]
			public int sortId;

			// Token: 0x04005F1B RID: 24347
			[Token(Token = "0x4005F1B")]
			[FieldOffset(Offset = "0x20")]
			public string desc;
		}

		// Token: 0x02001159 RID: 4441
		[Token(Token = "0x2001159")]
		public class RoguelikeActivitySeedModeConstData
		{
			// Token: 0x06006F34 RID: 28468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006F34")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoguelikeActivitySeedModeConstData()
			{
			}

			// Token: 0x04005F1C RID: 24348
			[Token(Token = "0x4005F1C")]
			[FieldOffset(Offset = "0x10")]
			public string seedModeIntro;

			// Token: 0x04005F1D RID: 24349
			[Token(Token = "0x4005F1D")]
			[FieldOffset(Offset = "0x18")]
			public string emptyTextHint;

			// Token: 0x04005F1E RID: 24350
			[Token(Token = "0x4005F1E")]
			[FieldOffset(Offset = "0x20")]
			public string errorTextHint;

			// Token: 0x04005F1F RID: 24351
			[Token(Token = "0x4005F1F")]
			[FieldOffset(Offset = "0x28")]
			public string legitimateTextHint;

			// Token: 0x04005F20 RID: 24352
			[Token(Token = "0x4005F20")]
			[FieldOffset(Offset = "0x30")]
			public string seedModeConfirmReplacement;

			// Token: 0x04005F21 RID: 24353
			[Token(Token = "0x4005F21")]
			[FieldOffset(Offset = "0x38")]
			public string difficultyLevelTextHint;

			// Token: 0x04005F22 RID: 24354
			[Token(Token = "0x4005F22")]
			[FieldOffset(Offset = "0x40")]
			public string lockedDifficultyLevelTextHint;

			// Token: 0x04005F23 RID: 24355
			[Token(Token = "0x4005F23")]
			[FieldOffset(Offset = "0x48")]
			public string setDifficultyLevelTextHint;

			// Token: 0x04005F24 RID: 24356
			[Token(Token = "0x4005F24")]
			[FieldOffset(Offset = "0x50")]
			public string notEnabledTextHint;

			// Token: 0x04005F25 RID: 24357
			[Token(Token = "0x4005F25")]
			[FieldOffset(Offset = "0x58")]
			public string enabledTextHint;

			// Token: 0x04005F26 RID: 24358
			[Token(Token = "0x4005F26")]
			[FieldOffset(Offset = "0x60")]
			public string useSucceededTextHint;

			// Token: 0x04005F27 RID: 24359
			[Token(Token = "0x4005F27")]
			[FieldOffset(Offset = "0x68")]
			public string officialUseSucceededTextHint;

			// Token: 0x04005F28 RID: 24360
			[Token(Token = "0x4005F28")]
			[FieldOffset(Offset = "0x70")]
			public string seedModeLockedTextHint;
		}
	}
}
