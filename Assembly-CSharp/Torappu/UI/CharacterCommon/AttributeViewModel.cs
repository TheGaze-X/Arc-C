using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Torappu.UI.CharacterCommon
{
	// Token: 0x02005FCC RID: 24524
	[Token(Token = "0x2005FCC")]
	public class AttributeViewModel
	{
		// Token: 0x06023762 RID: 145250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023762")]
		[Address(RVA = "0x1E13690", Offset = "0x1E12290", VA = "0x181E13690")]
		public void LoadData(CharacterData charData, string charId, EvolvePhase evolvePhaseInput, int levelInput = 1, int expInput = 0, int potentialRankInput = 0, int favorPointInput = 0, [Optional] List<CharacterData.UniqueEquipPair> equips, bool isToken = false)
		{
		}

		// Token: 0x06023763 RID: 145251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023763")]
		[Address(RVA = "0x1E13E30", Offset = "0x1E12A30", VA = "0x181E13E30")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData, [Optional] string selectedEquipId)
		{
		}

		// Token: 0x06023764 RID: 145252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023764")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AttributeViewModel()
		{
		}

		// Token: 0x040310CB RID: 200907
		[Token(Token = "0x40310CB")]
		private const int TAG_LINE_WIDTH = 5;

		// Token: 0x040310CC RID: 200908
		[Token(Token = "0x40310CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int level;

		// Token: 0x040310CD RID: 200909
		[Token(Token = "0x40310CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int maxLevel;

		// Token: 0x040310CE RID: 200910
		[Token(Token = "0x40310CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float expProgress;

		// Token: 0x040310CF RID: 200911
		[Token(Token = "0x40310CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string expDesc;

		// Token: 0x040310D0 RID: 200912
		[Token(Token = "0x40310D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string maxExpDesc;

		// Token: 0x040310D1 RID: 200913
		[Token(Token = "0x40310D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int maxHp;

		// Token: 0x040310D2 RID: 200914
		[Token(Token = "0x40310D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int atk;

		// Token: 0x040310D3 RID: 200915
		[Token(Token = "0x40310D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int def;

		// Token: 0x040310D4 RID: 200916
		[Token(Token = "0x40310D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float res;

		// Token: 0x040310D5 RID: 200917
		[Token(Token = "0x40310D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string respawnTime;

		// Token: 0x040310D6 RID: 200918
		[Token(Token = "0x40310D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int cost;

		// Token: 0x040310D7 RID: 200919
		[Token(Token = "0x40310D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public EvolvePhase evolvePhase;

		// Token: 0x040310D8 RID: 200920
		[Token(Token = "0x40310D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ProfessionCategory professionID;

		// Token: 0x040310D9 RID: 200921
		[Token(Token = "0x40310D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public int potentialRank;

		// Token: 0x040310DA RID: 200922
		[Token(Token = "0x40310DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int favorPercent;

		// Token: 0x040310DB RID: 200923
		[Token(Token = "0x40310DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int favorBattlePhase;

		// Token: 0x040310DC RID: 200924
		[Token(Token = "0x40310DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string descrption;

		// Token: 0x040310DD RID: 200925
		[Token(Token = "0x40310DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string descAdditive;

		// Token: 0x040310DE RID: 200926
		[Token(Token = "0x40310DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AttributesData favorDelta;

		// Token: 0x040310DF RID: 200927
		[Token(Token = "0x40310DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public int mainSkillLvl;

		// Token: 0x040310E0 RID: 200928
		[Token(Token = "0x40310E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string atkSpeed;

		// Token: 0x040310E1 RID: 200929
		[Token(Token = "0x40310E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string blockNum;

		// Token: 0x040310E2 RID: 200930
		[Token(Token = "0x40310E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string position;

		// Token: 0x040310E3 RID: 200931
		[Token(Token = "0x40310E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string tagsContent;

		// Token: 0x040310E4 RID: 200932
		[Token(Token = "0x40310E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public string subProfessionId;
	}
}
