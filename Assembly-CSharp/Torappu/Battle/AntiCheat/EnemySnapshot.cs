using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace Torappu.Battle.AntiCheat
{
	// Token: 0x02002A8B RID: 10891
	[Token(Token = "0x2002A8B")]
	public struct EnemySnapshot
	{
		// Token: 0x06012154 RID: 74068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012154")]
		[Address(RVA = "0xA209B0", Offset = "0xA1F5B0", VA = "0x180A209B0")]
		public List<object> ToList()
		{
			return null;
		}

		// Token: 0x06012155 RID: 74069 RVA: 0x0006EA90 File Offset: 0x0006CC90
		[Token(Token = "0x6012155")]
		[Address(RVA = "0xA20CB0", Offset = "0xA1F8B0", VA = "0x180A20CB0")]
		public static bool TryCreateFrom(LevelData.EnemyData data, out EnemySnapshot snapshot)
		{
			return default(bool);
		}

		// Token: 0x04014776 RID: 83830
		[Token(Token = "0x4014776")]
		[FieldOffset(Offset = "0x0")]
		public long ts;

		// Token: 0x04014777 RID: 83831
		[Token(Token = "0x4014777")]
		[FieldOffset(Offset = "0x8")]
		public EnemySnapshot.AttributesSnapshot attributes;

		// Token: 0x02002A8C RID: 10892
		[Token(Token = "0x2002A8C")]
		public struct AttributesSnapshot
		{
			// Token: 0x06012156 RID: 74070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6012156")]
			[Address(RVA = "0xA1F1E0", Offset = "0xA1DDE0", VA = "0x180A1F1E0")]
			public AttributesSnapshot(LevelData.EnemyData data)
			{
			}

			// Token: 0x04014778 RID: 83832
			[Token(Token = "0x4014778")]
			[FieldOffset(Offset = "0x0")]
			public ObscuredFloat maxHp;

			// Token: 0x04014779 RID: 83833
			[Token(Token = "0x4014779")]
			[FieldOffset(Offset = "0x18")]
			public ObscuredFloat atk;

			// Token: 0x0401477A RID: 83834
			[Token(Token = "0x401477A")]
			[FieldOffset(Offset = "0x30")]
			public ObscuredFloat def;

			// Token: 0x0401477B RID: 83835
			[Token(Token = "0x401477B")]
			[FieldOffset(Offset = "0x48")]
			public ObscuredFloat magicResistance;

			// Token: 0x0401477C RID: 83836
			[Token(Token = "0x401477C")]
			[FieldOffset(Offset = "0x60")]
			public ObscuredFloat attackSpeed;

			// Token: 0x0401477D RID: 83837
			[Token(Token = "0x401477D")]
			[FieldOffset(Offset = "0x78")]
			public ObscuredFloat baseAttackTime;

			// Token: 0x0401477E RID: 83838
			[Token(Token = "0x401477E")]
			[FieldOffset(Offset = "0x90")]
			public ObscuredFloat moveSpeed;
		}
	}
}
