using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A49 RID: 10825
	[Token(Token = "0x2002A49")]
	public class Act5FunNpcSelector
	{
		// Token: 0x06011F99 RID: 73625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F99")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		public Act5FunNpcSelector(string dataNpcId, string dataEnemyId)
		{
		}

		// Token: 0x06011F9A RID: 73626 RVA: 0x0006DEF0 File Offset: 0x0006C0F0
		[Token(Token = "0x6011F9A")]
		[Address(RVA = "0x9FED00", Offset = "0x9FD900", VA = "0x1809FED00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06011F9B RID: 73627 RVA: 0x0006DF08 File Offset: 0x0006C108
		[Token(Token = "0x6011F9B")]
		[Address(RVA = "0x9FEE30", Offset = "0x9FDA30", VA = "0x1809FEE30", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x040144AA RID: 83114
		[Token(Token = "0x40144AA")]
		[FieldOffset(Offset = "0x10")]
		private readonly string npcId;

		// Token: 0x040144AB RID: 83115
		[Token(Token = "0x40144AB")]
		[FieldOffset(Offset = "0x18")]
		private readonly string enemyId;
	}
}
