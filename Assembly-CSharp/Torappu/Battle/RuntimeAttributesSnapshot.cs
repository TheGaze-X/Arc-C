using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200240B RID: 9227
	[Token(Token = "0x200240B")]
	public struct RuntimeAttributesSnapshot
	{
		// Token: 0x0600EBDF RID: 60383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBDF")]
		[Address(RVA = "0x6230D0", Offset = "0x621CD0", VA = "0x1806230D0")]
		public void TakeSnapshot(Attributes attributes)
		{
		}

		// Token: 0x040104AB RID: 66731
		[Token(Token = "0x40104AB")]
		[FieldOffset(Offset = "0x0")]
		public ObscuredFP maxHp;

		// Token: 0x040104AC RID: 66732
		[Token(Token = "0x40104AC")]
		[FieldOffset(Offset = "0x28")]
		public ObscuredFP atk;

		// Token: 0x040104AD RID: 66733
		[Token(Token = "0x40104AD")]
		[FieldOffset(Offset = "0x50")]
		public ObscuredFP def;

		// Token: 0x040104AE RID: 66734
		[Token(Token = "0x40104AE")]
		[FieldOffset(Offset = "0x78")]
		public ObscuredFP magicResistance;

		// Token: 0x040104AF RID: 66735
		[Token(Token = "0x40104AF")]
		[FieldOffset(Offset = "0xA0")]
		public ObscuredInt cost;

		// Token: 0x040104B0 RID: 66736
		[Token(Token = "0x40104B0")]
		[FieldOffset(Offset = "0xB4")]
		public ObscuredInt blockCnt;

		// Token: 0x040104B1 RID: 66737
		[Token(Token = "0x40104B1")]
		[FieldOffset(Offset = "0xC8")]
		public ObscuredFP attackSpeed;

		// Token: 0x040104B2 RID: 66738
		[Token(Token = "0x40104B2")]
		[FieldOffset(Offset = "0xF0")]
		public ObscuredFP baseAttackTime;

		// Token: 0x040104B3 RID: 66739
		[Token(Token = "0x40104B3")]
		[FieldOffset(Offset = "0x118")]
		public ObscuredInt respawnTime;
	}
}
