using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterCommon
{
	// Token: 0x02005FCE RID: 24526
	[Token(Token = "0x2005FCE")]
	public class BattleInfoViewModel
	{
		// Token: 0x06023766 RID: 145254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023766")]
		[Address(RVA = "0x1E14160", Offset = "0x1E12D60", VA = "0x181E14160")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData)
		{
		}

		// Token: 0x06023767 RID: 145255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023767")]
		[Address(RVA = "0x1E14060", Offset = "0x1E12C60", VA = "0x181E14060")]
		public void LoadData(CharQuery charQuery, int level, EvolvePhase evolvePhase, int potential, List<CharacterData.UniqueEquipPair> pairs, bool isToken = false)
		{
		}

		// Token: 0x06023768 RID: 145256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023768")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleInfoViewModel()
		{
		}

		// Token: 0x040310E5 RID: 200933
		[Token(Token = "0x40310E5")]
		[FieldOffset(Offset = "0x10")]
		public AttackRangeDescModel attackRange;
	}
}
