using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F6C RID: 3948
	[Token(Token = "0x2000F6C")]
	[Serializable]
	public class AdvancedCharacterInst : CharacterInst
	{
		// Token: 0x06006C9B RID: 27803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9B")]
		[Address(RVA = "0x20FE580", Offset = "0x20FD180", VA = "0x1820FE580")]
		public AdvancedCharacterInst()
		{
		}

		// Token: 0x06006C9C RID: 27804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9C")]
		[Address(RVA = "0x20FE590", Offset = "0x20FD190", VA = "0x1820FE590")]
		public AdvancedCharacterInst(PlayerCharacter player)
		{
		}

		// Token: 0x06006C9D RID: 27805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9D")]
		[Address(RVA = "0x20FE750", Offset = "0x20FD350", VA = "0x1820FE750")]
		public AdvancedCharacterInst(CharQuery query, int level, EvolvePhase phase, int potential, List<CharacterData.UniqueEquipPair> pair)
		{
		}

		// Token: 0x040053D2 RID: 21458
		[Token(Token = "0x40053D2")]
		[FieldOffset(Offset = "0x58")]
		public CharacterData.UniqueEquipPair[] uniEquipIds;

		// Token: 0x040053D3 RID: 21459
		[Token(Token = "0x40053D3")]
		[FieldOffset(Offset = "0x60")]
		public bool showSpIllust;

		// Token: 0x040053D4 RID: 21460
		[Token(Token = "0x40053D4")]
		[FieldOffset(Offset = "0x68")]
		public CharacterData.MasterInfo[] masterInfos;
	}
}
