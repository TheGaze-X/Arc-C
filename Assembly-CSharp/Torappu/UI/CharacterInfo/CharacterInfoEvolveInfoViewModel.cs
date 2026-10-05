using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F0D RID: 24333
	[Token(Token = "0x2005F0D")]
	public class CharacterInfoEvolveInfoViewModel : IHotfixable
	{
		// Token: 0x0602340B RID: 144395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602340B")]
		[Address(RVA = "0x1DBF380", Offset = "0x1DBDF80", VA = "0x181DBF380")]
		public void LoadData(PlayerCharacter playerChar, CharacterData charData)
		{
		}

		// Token: 0x0602340C RID: 144396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602340C")]
		[Address(RVA = "0x1DBFC20", Offset = "0x1DBE820", VA = "0x181DBFC20")]
		public CharacterInfoEvolveInfoViewModel()
		{
		}

		// Token: 0x04030941 RID: 198977
		[Token(Token = "0x4030941")]
		[FieldOffset(Offset = "0x10")]
		public string charId;

		// Token: 0x04030942 RID: 198978
		[Token(Token = "0x4030942")]
		[FieldOffset(Offset = "0x18")]
		public EvolvePhase oldEvolvePhase;

		// Token: 0x04030943 RID: 198979
		[Token(Token = "0x4030943")]
		[FieldOffset(Offset = "0x1C")]
		public EvolvePhase newEvolvePhase;

		// Token: 0x04030944 RID: 198980
		[Token(Token = "0x4030944")]
		[FieldOffset(Offset = "0x20")]
		public AttributesData oldAttributeData;

		// Token: 0x04030945 RID: 198981
		[Token(Token = "0x4030945")]
		[FieldOffset(Offset = "0x28")]
		public AttributesData newAttributeData;

		// Token: 0x04030946 RID: 198982
		[Token(Token = "0x4030946")]
		[FieldOffset(Offset = "0x30")]
		public List<CharacterInfoEvolveInfoViewModel.TalentStruct> talentStructs;

		// Token: 0x04030947 RID: 198983
		[Token(Token = "0x4030947")]
		[FieldOffset(Offset = "0x38")]
		public List<SkillData> updateSkillDatas;

		// Token: 0x04030948 RID: 198984
		[Token(Token = "0x4030948")]
		[FieldOffset(Offset = "0x40")]
		public bool hasRangeChanged;

		// Token: 0x04030949 RID: 198985
		[Token(Token = "0x4030949")]
		[FieldOffset(Offset = "0x48")]
		public AttackRangeDescModel oldRangeDescModel;

		// Token: 0x0403094A RID: 198986
		[Token(Token = "0x403094A")]
		[FieldOffset(Offset = "0x58")]
		public AttackRangeDescModel newRangeDescModel;

		// Token: 0x0403094B RID: 198987
		[Token(Token = "0x403094B")]
		[FieldOffset(Offset = "0x68")]
		public bool hasUpdateTrait;

		// Token: 0x0403094C RID: 198988
		[Token(Token = "0x403094C")]
		[FieldOffset(Offset = "0x70")]
		public string newTraitStr;

		// Token: 0x0403094D RID: 198989
		[Token(Token = "0x403094D")]
		[FieldOffset(Offset = "0x78")]
		public bool hasUnlockEquip;

		// Token: 0x0403094E RID: 198990
		[Token(Token = "0x403094E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403094F RID: 198991
		[Token(Token = "0x403094F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F0E RID: 24334
		[Token(Token = "0x2005F0E")]
		public struct TalentStruct
		{
			// Token: 0x04030950 RID: 198992
			[Token(Token = "0x4030950")]
			[FieldOffset(Offset = "0x0")]
			public bool hasOldTalent;

			// Token: 0x04030951 RID: 198993
			[Token(Token = "0x4030951")]
			[FieldOffset(Offset = "0x1")]
			public bool hasNewTalent;

			// Token: 0x04030952 RID: 198994
			[Token(Token = "0x4030952")]
			[FieldOffset(Offset = "0x8")]
			public TalentData oldTalentData;

			// Token: 0x04030953 RID: 198995
			[Token(Token = "0x4030953")]
			[FieldOffset(Offset = "0x10")]
			public TalentData newTalentData;

			// Token: 0x04030954 RID: 198996
			[Token(Token = "0x4030954")]
			[FieldOffset(Offset = "0x18")]
			public bool hasTalentChanged;
		}
	}
}
