using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011FC RID: 4604
	[Token(Token = "0x20011FC")]
	public struct RoguelikeTopicDifficultyID
	{
		// Token: 0x06006FEC RID: 28652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FEC")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		public RoguelikeTopicDifficultyID(RoguelikeTopicMode m, int g)
		{
		}

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06006FED RID: 28653 RVA: 0x00032988 File Offset: 0x00030B88
		[Token(Token = "0x17000D47")]
		public bool IsEmpty
		{
			[Token(Token = "0x6006FED")]
			[Address(RVA = "0x2114460", Offset = "0x2113060", VA = "0x182114460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006FEE RID: 28654 RVA: 0x000329A0 File Offset: 0x00030BA0
		[Token(Token = "0x6006FEE")]
		[Address(RVA = "0x1DED450", Offset = "0x1DEC050", VA = "0x181DED450")]
		public static bool operator ==(RoguelikeTopicDifficultyID a, RoguelikeTopicDifficultyID b)
		{
			return default(bool);
		}

		// Token: 0x06006FEF RID: 28655 RVA: 0x000329B8 File Offset: 0x00030BB8
		[Token(Token = "0x6006FEF")]
		[Address(RVA = "0x2114490", Offset = "0x2113090", VA = "0x182114490")]
		public static bool operator !=(RoguelikeTopicDifficultyID a, RoguelikeTopicDifficultyID b)
		{
			return default(bool);
		}

		// Token: 0x06006FF0 RID: 28656 RVA: 0x000329D0 File Offset: 0x00030BD0
		[Token(Token = "0x6006FF0")]
		[Address(RVA = "0x2114510", Offset = "0x2113110", VA = "0x182114510")]
		public static bool operator <(RoguelikeTopicDifficultyID a, RoguelikeTopicDifficultyID b)
		{
			return default(bool);
		}

		// Token: 0x06006FF1 RID: 28657 RVA: 0x000329E8 File Offset: 0x00030BE8
		[Token(Token = "0x6006FF1")]
		[Address(RVA = "0x2114470", Offset = "0x2113070", VA = "0x182114470")]
		public static bool operator >(RoguelikeTopicDifficultyID a, RoguelikeTopicDifficultyID b)
		{
			return default(bool);
		}

		// Token: 0x06006FF2 RID: 28658 RVA: 0x00032A00 File Offset: 0x00030C00
		[Token(Token = "0x6006FF2")]
		[Address(RVA = "0x2114390", Offset = "0x2112F90", VA = "0x182114390", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06006FF3 RID: 28659 RVA: 0x00032A18 File Offset: 0x00030C18
		[Token(Token = "0x6006FF3")]
		[Address(RVA = "0x2114420", Offset = "0x2113020", VA = "0x182114420", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04006308 RID: 25352
		[Token(Token = "0x4006308")]
		[FieldOffset(Offset = "0x0")]
		public RoguelikeTopicMode mode;

		// Token: 0x04006309 RID: 25353
		[Token(Token = "0x4006309")]
		[FieldOffset(Offset = "0x4")]
		public int grade;

		// Token: 0x0400630A RID: 25354
		[Token(Token = "0x400630A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly RoguelikeTopicDifficultyID NONE;
	}
}
