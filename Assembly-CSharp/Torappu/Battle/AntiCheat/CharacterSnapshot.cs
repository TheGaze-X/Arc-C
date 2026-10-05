using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace Torappu.Battle.AntiCheat
{
	// Token: 0x02002A89 RID: 10889
	[Token(Token = "0x2002A89")]
	public struct CharacterSnapshot
	{
		// Token: 0x06012151 RID: 74065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012151")]
		[Address(RVA = "0xA1FFB0", Offset = "0xA1EBB0", VA = "0x180A1FFB0")]
		public List<object> ToList()
		{
			return null;
		}

		// Token: 0x06012152 RID: 74066 RVA: 0x0006EA78 File Offset: 0x0006CC78
		[Token(Token = "0x6012152")]
		[Address(RVA = "0xA20350", Offset = "0xA1EF50", VA = "0x180A20350")]
		public static bool TryCreateFrom(Character character, out CharacterSnapshot snapshot)
		{
			return default(bool);
		}

		// Token: 0x04014768 RID: 83816
		[Token(Token = "0x4014768")]
		[FieldOffset(Offset = "0x0")]
		public long ts;

		// Token: 0x04014769 RID: 83817
		[Token(Token = "0x4014769")]
		[FieldOffset(Offset = "0x8")]
		public CharacterSnapshot.AttributesSnapshot attributes;

		// Token: 0x0401476A RID: 83818
		[Token(Token = "0x401476A")]
		[FieldOffset(Offset = "0xD8")]
		public BlackboardSnapshot[] talents;

		// Token: 0x0401476B RID: 83819
		[Token(Token = "0x401476B")]
		[FieldOffset(Offset = "0xE0")]
		public BlackboardSnapshot skill;

		// Token: 0x0401476C RID: 83820
		[Token(Token = "0x401476C")]
		[FieldOffset(Offset = "0xE8")]
		public BlackboardSnapshot trait;

		// Token: 0x02002A8A RID: 10890
		[Token(Token = "0x2002A8A")]
		public struct AttributesSnapshot
		{
			// Token: 0x06012153 RID: 74067 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012153")]
			[Address(RVA = "0xA1F3A0", Offset = "0xA1DFA0", VA = "0x180A1F3A0")]
			public AttributesSnapshot(Character character)
			{
			}

			// Token: 0x0401476D RID: 83821
			[Token(Token = "0x401476D")]
			[FieldOffset(Offset = "0x0")]
			public ObscuredFloat maxHp;

			// Token: 0x0401476E RID: 83822
			[Token(Token = "0x401476E")]
			[FieldOffset(Offset = "0x18")]
			public ObscuredFloat atk;

			// Token: 0x0401476F RID: 83823
			[Token(Token = "0x401476F")]
			[FieldOffset(Offset = "0x30")]
			public ObscuredFloat def;

			// Token: 0x04014770 RID: 83824
			[Token(Token = "0x4014770")]
			[FieldOffset(Offset = "0x48")]
			public ObscuredFloat magicResistance;

			// Token: 0x04014771 RID: 83825
			[Token(Token = "0x4014771")]
			[FieldOffset(Offset = "0x60")]
			public ObscuredInt cost;

			// Token: 0x04014772 RID: 83826
			[Token(Token = "0x4014772")]
			[FieldOffset(Offset = "0x74")]
			public ObscuredInt blockCnt;

			// Token: 0x04014773 RID: 83827
			[Token(Token = "0x4014773")]
			[FieldOffset(Offset = "0x88")]
			public ObscuredFloat attackSpeed;

			// Token: 0x04014774 RID: 83828
			[Token(Token = "0x4014774")]
			[FieldOffset(Offset = "0xA0")]
			public ObscuredFloat baseAttackTime;

			// Token: 0x04014775 RID: 83829
			[Token(Token = "0x4014775")]
			[FieldOffset(Offset = "0xB8")]
			public ObscuredInt respawnTime;
		}
	}
}
