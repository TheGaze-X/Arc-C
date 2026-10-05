using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.AVG
{
	// Token: 0x02001F07 RID: 7943
	[Token(Token = "0x2001F07")]
	[Serializable]
	public class Story
	{
		// Token: 0x1700177D RID: 6013
		// (get) Token: 0x0600C528 RID: 50472 RVA: 0x00048420 File Offset: 0x00046620
		// (set) Token: 0x0600C529 RID: 50473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700177D")]
		public Story.StoryOutPut Output
		{
			[Token(Token = "0x600C528")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return default(Story.StoryOutPut);
			}
			[Token(Token = "0x600C529")]
			[Address(RVA = "0x3435160", Offset = "0x3433D60", VA = "0x183435160")]
			set
			{
			}
		}

		// Token: 0x0600C52A RID: 50474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C52A")]
		[Address(RVA = "0x3435030", Offset = "0x3433C30", VA = "0x183435030")]
		public string TryGetStrParam(string paramName)
		{
			return null;
		}

		// Token: 0x1700177E RID: 6014
		// (get) Token: 0x0600C52B RID: 50475 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C52C RID: 50476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700177E")]
		public string OverrideId
		{
			[Token(Token = "0x600C52B")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x600C52C")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			set
			{
			}
		}

		// Token: 0x0600C52D RID: 50477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C52D")]
		[Address(RVA = "0x3435100", Offset = "0x3433D00", VA = "0x183435100")]
		public Story()
		{
		}

		// Token: 0x0400C9AF RID: 51631
		[Token(Token = "0x400C9AF")]
		public const string STORY_PARAM_GOTO_CHARINFOID = "gotoCharInfoId";

		// Token: 0x0400C9B0 RID: 51632
		[Token(Token = "0x400C9B0")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x0400C9B1 RID: 51633
		[Token(Token = "0x400C9B1")]
		[FieldOffset(Offset = "0x18")]
		public string title;

		// Token: 0x0400C9B2 RID: 51634
		[Token(Token = "0x400C9B2")]
		[FieldOffset(Offset = "0x20")]
		public string briefId;

		// Token: 0x0400C9B3 RID: 51635
		[Token(Token = "0x400C9B3")]
		[FieldOffset(Offset = "0x28")]
		public bool isTutorial;

		// Token: 0x0400C9B4 RID: 51636
		[Token(Token = "0x400C9B4")]
		[FieldOffset(Offset = "0x29")]
		public bool isSkippable;

		// Token: 0x0400C9B5 RID: 51637
		[Token(Token = "0x400C9B5")]
		[FieldOffset(Offset = "0x2A")]
		public bool isAutoable;

		// Token: 0x0400C9B6 RID: 51638
		[Token(Token = "0x400C9B6")]
		[FieldOffset(Offset = "0x2B")]
		public bool isVideoOnly;

		// Token: 0x0400C9B7 RID: 51639
		[Token(Token = "0x400C9B7")]
		[FieldOffset(Offset = "0x2C")]
		public bool denyAutoSwitchScene;

		// Token: 0x0400C9B8 RID: 51640
		[Token(Token = "0x400C9B8")]
		[FieldOffset(Offset = "0x2D")]
		public bool dontClearGameObjectPoolOnStart;

		// Token: 0x0400C9B9 RID: 51641
		[Token(Token = "0x400C9B9")]
		[FieldOffset(Offset = "0x30")]
		public AVGController.FitMode fitMode;

		// Token: 0x0400C9BA RID: 51642
		[Token(Token = "0x400C9BA")]
		[FieldOffset(Offset = "0x34")]
		public CharacterSortType characterSortType;

		// Token: 0x0400C9BB RID: 51643
		[Token(Token = "0x400C9BB")]
		[FieldOffset(Offset = "0x38")]
		public Story.StoryParam param;

		// Token: 0x0400C9BC RID: 51644
		[Token(Token = "0x400C9BC")]
		[FieldOffset(Offset = "0x50")]
		public List<Command> commands;

		// Token: 0x0400C9BD RID: 51645
		[Token(Token = "0x400C9BD")]
		[FieldOffset(Offset = "0x58")]
		private Story.StoryOutPut m_outPut;

		// Token: 0x02001F08 RID: 7944
		[Token(Token = "0x2001F08")]
		public struct StoryParam
		{
			// Token: 0x1700177F RID: 6015
			// (get) Token: 0x0600C52E RID: 50478 RVA: 0x00048438 File Offset: 0x00046638
			[Token(Token = "0x1700177F")]
			public bool isEmpty
			{
				[Token(Token = "0x600C52E")]
				[Address(RVA = "0x3434FE0", Offset = "0x3433BE0", VA = "0x183434FE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0400C9BE RID: 51646
			[Token(Token = "0x400C9BE")]
			[FieldOffset(Offset = "0x0")]
			public string overrideId;

			// Token: 0x0400C9BF RID: 51647
			[Token(Token = "0x400C9BF")]
			[FieldOffset(Offset = "0x8")]
			public string overrideBriefId;

			// Token: 0x0400C9C0 RID: 51648
			[Token(Token = "0x400C9C0")]
			[FieldOffset(Offset = "0x10")]
			public Blackboard pool;
		}

		// Token: 0x02001F09 RID: 7945
		[Token(Token = "0x2001F09")]
		public struct StoryOutPut
		{
			// Token: 0x17001780 RID: 6016
			// (get) Token: 0x0600C52F RID: 50479 RVA: 0x00048450 File Offset: 0x00046650
			[Token(Token = "0x17001780")]
			public bool IsEmpty
			{
				[Token(Token = "0x600C52F")]
				[Address(RVA = "0x3434FA0", Offset = "0x3433BA0", VA = "0x183434FA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0400C9C1 RID: 51649
			[Token(Token = "0x400C9C1")]
			[FieldOffset(Offset = "0x0")]
			public ItemBundle[] items;
		}
	}
}
