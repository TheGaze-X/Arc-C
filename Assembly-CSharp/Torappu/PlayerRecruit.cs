using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A06 RID: 2566
	[Token(Token = "0x2000A06")]
	public class PlayerRecruit
	{
		// Token: 0x060066C9 RID: 26313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066C9")]
		[Address(RVA = "0x1EFC440", Offset = "0x1EFB040", VA = "0x181EFC440")]
		public PlayerRecruit()
		{
		}

		// Token: 0x04003769 RID: 14185
		[Token(Token = "0x4003769")]
		[FieldOffset(Offset = "0x10")]
		public PlayerRecruit.NormalModel normal;

		// Token: 0x02000A07 RID: 2567
		[Token(Token = "0x2000A07")]
		public class NormalModel
		{
			// Token: 0x060066CA RID: 26314 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60066CA")]
			[Address(RVA = "0x1EEC970", Offset = "0x1EEB570", VA = "0x181EEC970")]
			public NormalModel()
			{
			}

			// Token: 0x0400376A RID: 14186
			[Token(Token = "0x400376A")]
			[FieldOffset(Offset = "0x10")]
			public ListDict<string, PlayerRecruit.NormalModel.SlotModel> slots;

			// Token: 0x02000A08 RID: 2568
			[Token(Token = "0x2000A08")]
			public class SlotModel
			{
				// Token: 0x060066CB RID: 26315 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60066CB")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SlotModel()
				{
				}

				// Token: 0x0400376B RID: 14187
				[Token(Token = "0x400376B")]
				[FieldOffset(Offset = "0x10")]
				public PlayerRecruit.NormalModel.SlotModel.State state;

				// Token: 0x0400376C RID: 14188
				[Token(Token = "0x400376C")]
				[FieldOffset(Offset = "0x18")]
				public int[] tags;

				// Token: 0x0400376D RID: 14189
				[Token(Token = "0x400376D")]
				[FieldOffset(Offset = "0x20")]
				public PlayerRecruit.NormalModel.SlotModel.TagItem[] selectTags;

				// Token: 0x0400376E RID: 14190
				[Token(Token = "0x400376E")]
				[FieldOffset(Offset = "0x28")]
				public DateTime startTs;

				// Token: 0x0400376F RID: 14191
				[Token(Token = "0x400376F")]
				[FieldOffset(Offset = "0x30")]
				public DateTime maxFinishTs;

				// Token: 0x04003770 RID: 14192
				[Token(Token = "0x4003770")]
				[FieldOffset(Offset = "0x38")]
				public DateTime realFinishTs;

				// Token: 0x04003771 RID: 14193
				[Token(Token = "0x4003771")]
				[FieldOffset(Offset = "0x40")]
				public int durationInSec;

				// Token: 0x02000A09 RID: 2569
				[Token(Token = "0x2000A09")]
				public class TagItem
				{
					// Token: 0x060066CC RID: 26316 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x60066CC")]
					[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
					public TagItem()
					{
					}

					// Token: 0x04003772 RID: 14194
					[Token(Token = "0x4003772")]
					[FieldOffset(Offset = "0x10")]
					public int tagId;

					// Token: 0x04003773 RID: 14195
					[Token(Token = "0x4003773")]
					[FieldOffset(Offset = "0x14")]
					public bool pick;
				}

				// Token: 0x02000A0A RID: 2570
				[Token(Token = "0x2000A0A")]
				public enum State
				{
					// Token: 0x04003775 RID: 14197
					[Token(Token = "0x4003775")]
					LOCK,
					// Token: 0x04003776 RID: 14198
					[Token(Token = "0x4003776")]
					IDLE,
					// Token: 0x04003777 RID: 14199
					[Token(Token = "0x4003777")]
					BUSY,
					// Token: 0x04003778 RID: 14200
					[Token(Token = "0x4003778")]
					FAST_FINISH
				}
			}
		}
	}
}
