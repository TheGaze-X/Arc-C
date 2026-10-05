using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x0200292A RID: 10538
	[Token(Token = "0x200292A")]
	public class BasicCharBuff
	{
		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x06011793 RID: 71571 RVA: 0x0006B838 File Offset: 0x00069A38
		[Token(Token = "0x170026A8")]
		public BasicRelic.RelicType relicType
		{
			[Token(Token = "0x6011793")]
			[Address(RVA = "0x94E1F0", Offset = "0x94CDF0", VA = "0x18094E1F0")]
			get
			{
				return BasicRelic.RelicType.NONE;
			}
		}

		// Token: 0x06011794 RID: 71572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011794")]
		[Address(RVA = "0x94DEF0", Offset = "0x94CAF0", VA = "0x18094DEF0")]
		public void Init(BasicRelic relic, List<uint> charUniqueIDs)
		{
		}

		// Token: 0x06011795 RID: 71573 RVA: 0x0006B850 File Offset: 0x00069A50
		[Token(Token = "0x6011795")]
		[Address(RVA = "0x94E190", Offset = "0x94CD90", VA = "0x18094E190")]
		private bool VerifyCharUID(uint charUID)
		{
			return default(bool);
		}

		// Token: 0x06011796 RID: 71574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011796")]
		[Address(RVA = "0x94DF30", Offset = "0x94CB30", VA = "0x18094DF30")]
		public void PreprocessChar(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011797 RID: 71575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011797")]
		[Address(RVA = "0x94E100", Offset = "0x94CD00", VA = "0x18094E100")]
		public void PreprocessDeck(ref BasicRelic.RelicInOut inOut)
		{
		}

		// Token: 0x06011798 RID: 71576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011798")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BasicCharBuff()
		{
		}

		// Token: 0x040138A8 RID: 80040
		[Token(Token = "0x40138A8")]
		[FieldOffset(Offset = "0x10")]
		private List<uint> m_charUniqueIDs;

		// Token: 0x040138A9 RID: 80041
		[Token(Token = "0x40138A9")]
		[FieldOffset(Offset = "0x18")]
		private BasicRelic m_relic;
	}
}
