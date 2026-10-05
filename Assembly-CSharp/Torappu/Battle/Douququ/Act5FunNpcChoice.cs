using System;
using Il2CppDummyDll;

namespace Torappu.Battle.Douququ
{
	// Token: 0x02002A4A RID: 10826
	[Token(Token = "0x2002A4A")]
	public class Act5FunNpcChoice
	{
		// Token: 0x06011F9C RID: 73628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F9C")]
		[Address(RVA = "0x9FEB40", Offset = "0x9FD740", VA = "0x1809FEB40")]
		public Act5FunNpcChoice(string npcNpcId)
		{
		}

		// Token: 0x06011F9D RID: 73629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011F9D")]
		[Address(RVA = "0x9FEB80", Offset = "0x9FD780", VA = "0x1809FEB80")]
		public Act5FunNpcChoice(string npc, float scoreRight, float scoreLeft)
		{
		}

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x06011F9E RID: 73630 RVA: 0x0006DF20 File Offset: 0x0006C120
		[Token(Token = "0x17002786")]
		public bool choiceIsRight
		{
			[Token(Token = "0x6011F9E")]
			[Address(RVA = "0x9FEBE0", Offset = "0x9FD7E0", VA = "0x1809FEBE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x040144AC RID: 83116
		[Token(Token = "0x40144AC")]
		[FieldOffset(Offset = "0x10")]
		public readonly string npcId;

		// Token: 0x040144AD RID: 83117
		[Token(Token = "0x40144AD")]
		[FieldOffset(Offset = "0x18")]
		private readonly float m_scoreRight;

		// Token: 0x040144AE RID: 83118
		[Token(Token = "0x40144AE")]
		[FieldOffset(Offset = "0x1C")]
		private readonly float m_scoreLeft;

		// Token: 0x040144AF RID: 83119
		[Token(Token = "0x40144AF")]
		[FieldOffset(Offset = "0x20")]
		private bool m_hasChosen;

		// Token: 0x040144B0 RID: 83120
		[Token(Token = "0x40144B0")]
		[FieldOffset(Offset = "0x21")]
		private bool m_choiceIsRight;

		// Token: 0x040144B1 RID: 83121
		[Token(Token = "0x40144B1")]
		[FieldOffset(Offset = "0x22")]
		public bool result;
	}
}
