using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200263A RID: 9786
	[Token(Token = "0x200263A")]
	[Serializable]
	public class BattlePlayerData
	{
		// Token: 0x06010026 RID: 65574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010026")]
		[Address(RVA = "0x778580", Offset = "0x777180", VA = "0x180778580")]
		public void Append(BattlePlayerData other)
		{
		}

		// Token: 0x06010027 RID: 65575 RVA: 0x00061698 File Offset: 0x0005F898
		[Token(Token = "0x6010027")]
		[Address(RVA = "0x778740", Offset = "0x777340", VA = "0x180778740")]
		public bool ContainCharacters(string id)
		{
			return default(bool);
		}

		// Token: 0x06010028 RID: 65576 RVA: 0x000616B0 File Offset: 0x0005F8B0
		[Token(Token = "0x6010028")]
		[Address(RVA = "0x7787C0", Offset = "0x7773C0", VA = "0x1807787C0")]
		public bool ContainTokens(string id)
		{
			return default(bool);
		}

		// Token: 0x06010029 RID: 65577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010029")]
		[Address(RVA = "0x778840", Offset = "0x777440", VA = "0x180778840")]
		public BattlePlayerData Duplicate()
		{
			return null;
		}

		// Token: 0x0601002A RID: 65578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601002A")]
		[Address(RVA = "0x778A90", Offset = "0x777690", VA = "0x180778A90")]
		public BattlePlayerData()
		{
		}

		// Token: 0x04011CAF RID: 72879
		[Token(Token = "0x4011CAF")]
		[FieldOffset(Offset = "0x10")]
		public PlayerSide playerSide;

		// Token: 0x04011CB0 RID: 72880
		[Token(Token = "0x4011CB0")]
		[FieldOffset(Offset = "0x18")]
		public BattleCharacterData[] characters;

		// Token: 0x04011CB1 RID: 72881
		[Token(Token = "0x4011CB1")]
		[FieldOffset(Offset = "0x20")]
		public BattleCharacterData[] tokens;
	}
}
