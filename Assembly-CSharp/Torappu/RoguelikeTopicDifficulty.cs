using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011FD RID: 4605
	[Token(Token = "0x20011FD")]
	public class RoguelikeTopicDifficulty
	{
		// Token: 0x06006FF5 RID: 28661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FF5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicDifficulty()
		{
		}

		// Token: 0x0400630B RID: 25355
		[Token(Token = "0x400630B")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicMode modeDifficulty;

		// Token: 0x0400630C RID: 25356
		[Token(Token = "0x400630C")]
		[FieldOffset(Offset = "0x14")]
		public int grade;

		// Token: 0x0400630D RID: 25357
		[Token(Token = "0x400630D")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x0400630E RID: 25358
		[Token(Token = "0x400630E")]
		[FieldOffset(Offset = "0x20")]
		public string nameImage;

		// Token: 0x0400630F RID: 25359
		[Token(Token = "0x400630F")]
		[FieldOffset(Offset = "0x28")]
		public string subName;

		// Token: 0x04006310 RID: 25360
		[Token(Token = "0x4006310")]
		[FieldOffset(Offset = "0x30")]
		public string enrollId;

		// Token: 0x04006311 RID: 25361
		[Token(Token = "0x4006311")]
		[FieldOffset(Offset = "0x38")]
		public bool haveInitialRelicIcon;

		// Token: 0x04006312 RID: 25362
		[Token(Token = "0x4006312")]
		[FieldOffset(Offset = "0x3C")]
		public float scoreFactor;

		// Token: 0x04006313 RID: 25363
		[Token(Token = "0x4006313")]
		[FieldOffset(Offset = "0x40")]
		public bool canUnlockItem;

		// Token: 0x04006314 RID: 25364
		[Token(Token = "0x4006314")]
		[FieldOffset(Offset = "0x41")]
		public bool doMonthTask;

		// Token: 0x04006315 RID: 25365
		[Token(Token = "0x4006315")]
		[FieldOffset(Offset = "0x48")]
		public string ruleDesc;

		// Token: 0x04006316 RID: 25366
		[Token(Token = "0x4006316")]
		[FieldOffset(Offset = "0x50")]
		public List<RoguelikeTopicDifficulty.RuleDescReplacement> ruleDescReplacements;

		// Token: 0x04006317 RID: 25367
		[Token(Token = "0x4006317")]
		[FieldOffset(Offset = "0x58")]
		public string failTitle;

		// Token: 0x04006318 RID: 25368
		[Token(Token = "0x4006318")]
		[FieldOffset(Offset = "0x60")]
		public string failImageId;

		// Token: 0x04006319 RID: 25369
		[Token(Token = "0x4006319")]
		[FieldOffset(Offset = "0x68")]
		public string failForceDesc;

		// Token: 0x0400631A RID: 25370
		[Token(Token = "0x400631A")]
		[FieldOffset(Offset = "0x70")]
		public int sortId;

		// Token: 0x0400631B RID: 25371
		[Token(Token = "0x400631B")]
		[FieldOffset(Offset = "0x74")]
		public int equivalentGrade;

		// Token: 0x0400631C RID: 25372
		[Token(Token = "0x400631C")]
		[FieldOffset(Offset = "0x78")]
		public string color;

		// Token: 0x0400631D RID: 25373
		[Token(Token = "0x400631D")]
		[FieldOffset(Offset = "0x80")]
		public int bpValue;

		// Token: 0x0400631E RID: 25374
		[Token(Token = "0x400631E")]
		[FieldOffset(Offset = "0x84")]
		public int bossValue;

		// Token: 0x0400631F RID: 25375
		[Token(Token = "0x400631F")]
		[FieldOffset(Offset = "0x88")]
		public string addDesc;

		// Token: 0x04006320 RID: 25376
		[Token(Token = "0x4006320")]
		[FieldOffset(Offset = "0x90")]
		public RoguelikeTopicDifficultyWarningType warningType;

		// Token: 0x04006321 RID: 25377
		[Token(Token = "0x4006321")]
		[FieldOffset(Offset = "0x98")]
		public string unlockText;

		// Token: 0x04006322 RID: 25378
		[Token(Token = "0x4006322")]
		[FieldOffset(Offset = "0xA0")]
		public string displayIconId;

		// Token: 0x04006323 RID: 25379
		[Token(Token = "0x4006323")]
		[FieldOffset(Offset = "0xA8")]
		public bool hideEndingStory;

		// Token: 0x020011FE RID: 4606
		[Token(Token = "0x20011FE")]
		public struct RuleDescReplacement
		{
			// Token: 0x04006324 RID: 25380
			[Token(Token = "0x4006324")]
			[FieldOffset(Offset = "0x0")]
			public string enrollId;

			// Token: 0x04006325 RID: 25381
			[Token(Token = "0x4006325")]
			[FieldOffset(Offset = "0x8")]
			public string ruleDesc;
		}
	}
}
