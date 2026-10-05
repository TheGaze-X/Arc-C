using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using UnityEngine;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E04 RID: 24068
	[Token(Token = "0x2005E04")]
	public class CharSelectBranchGroupViewModel
	{
		// Token: 0x06022E26 RID: 142886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022E26")]
		[Address(RVA = "0x1D643C0", Offset = "0x1D62FC0", VA = "0x181D643C0")]
		public Sprite GetCurrentEquipIcon()
		{
			return null;
		}

		// Token: 0x06022E27 RID: 142887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022E27")]
		[Address(RVA = "0x1D64300", Offset = "0x1D62F00", VA = "0x181D64300")]
		public CharSelectBranchItemViewModel AchieveBranchModelById(string branchId)
		{
			return null;
		}

		// Token: 0x06022E28 RID: 142888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022E28")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharSelectBranchGroupViewModel()
		{
		}

		// Token: 0x04030078 RID: 196728
		[Token(Token = "0x4030078")]
		[FieldOffset(Offset = "0x10")]
		public string featureDescBasic;

		// Token: 0x04030079 RID: 196729
		[Token(Token = "0x4030079")]
		[FieldOffset(Offset = "0x18")]
		public string rawFeatureDesc;

		// Token: 0x0403007A RID: 196730
		[Token(Token = "0x403007A")]
		[FieldOffset(Offset = "0x20")]
		public string featureDescAdditive;

		// Token: 0x0403007B RID: 196731
		[Token(Token = "0x403007B")]
		[FieldOffset(Offset = "0x28")]
		public string currentEquipId;

		// Token: 0x0403007C RID: 196732
		[Token(Token = "0x403007C")]
		[FieldOffset(Offset = "0x30")]
		public bool haveAvailEquip;

		// Token: 0x0403007D RID: 196733
		[Token(Token = "0x403007D")]
		[FieldOffset(Offset = "0x31")]
		public bool haveEquip;

		// Token: 0x0403007E RID: 196734
		[Token(Token = "0x403007E")]
		[FieldOffset(Offset = "0x38")]
		public string subProfessionInfo;

		// Token: 0x0403007F RID: 196735
		[Token(Token = "0x403007F")]
		[FieldOffset(Offset = "0x40")]
		public CharacterTalentViewModel[] talentDescs;

		// Token: 0x04030080 RID: 196736
		[Token(Token = "0x4030080")]
		[FieldOffset(Offset = "0x48")]
		public List<CharSelectBranchItemViewModel> branchModels;
	}
}
