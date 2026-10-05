using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000F82 RID: 3970
	[Token(Token = "0x2000F82")]
	public struct BattleVoiceOption
	{
		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06006CC2 RID: 27842 RVA: 0x000319E0 File Offset: 0x0002FBE0
		[Token(Token = "0x17000D10")]
		[JsonIgnore]
		public bool isValid
		{
			[Token(Token = "0x6006CC2")]
			[Address(RVA = "0x20FF1E0", Offset = "0x20FDDE0", VA = "0x1820FF1E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04005461 RID: 21601
		[Token(Token = "0x4005461")]
		[FieldOffset(Offset = "0x0")]
		[JsonIgnore]
		public static readonly BattleVoiceOption INVALID;

		// Token: 0x04005462 RID: 21602
		[Token(Token = "0x4005462")]
		[FieldOffset(Offset = "0x0")]
		public BattleVoiceOption.BattleVoiceType voiceType;

		// Token: 0x04005463 RID: 21603
		[Token(Token = "0x4005463")]
		[FieldOffset(Offset = "0x4")]
		public int priority;

		// Token: 0x04005464 RID: 21604
		[Token(Token = "0x4005464")]
		[FieldOffset(Offset = "0x8")]
		public bool overlapIfSamePriority;

		// Token: 0x04005465 RID: 21605
		[Token(Token = "0x4005465")]
		[FieldOffset(Offset = "0xC")]
		public float cooldown;

		// Token: 0x04005466 RID: 21606
		[Token(Token = "0x4005466")]
		[FieldOffset(Offset = "0x10")]
		public float delay;

		// Token: 0x02000F83 RID: 3971
		[Token(Token = "0x2000F83")]
		public enum BattleVoiceType
		{
			// Token: 0x04005468 RID: 21608
			[Token(Token = "0x4005468")]
			BATTLE_START,
			// Token: 0x04005469 RID: 21609
			[Token(Token = "0x4005469")]
			ENCOUNTER_ENEMY,
			// Token: 0x0400546A RID: 21610
			[Token(Token = "0x400546A")]
			PLACE_CHAR,
			// Token: 0x0400546B RID: 21611
			[Token(Token = "0x400546B")]
			FOCUS_CHAR,
			// Token: 0x0400546C RID: 21612
			[Token(Token = "0x400546C")]
			SKILL_ACTIVE,
			// Token: 0x0400546D RID: 21613
			[Token(Token = "0x400546D")]
			SKILL_PASSIVE_IMP,
			// Token: 0x0400546E RID: 21614
			[Token(Token = "0x400546E")]
			SKILL_PASSIVE_NOR,
			// Token: 0x0400546F RID: 21615
			[Token(Token = "0x400546F")]
			NORMAL_ATTACK,
			// Token: 0x04005470 RID: 21616
			[Token(Token = "0x4005470")]
			E_NUM
		}
	}
}
