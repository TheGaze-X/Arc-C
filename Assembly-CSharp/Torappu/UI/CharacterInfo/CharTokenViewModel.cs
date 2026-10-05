using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.CharacterCommon;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F0B RID: 24331
	[Token(Token = "0x2005F0B")]
	public class CharTokenViewModel : IHotfixable
	{
		// Token: 0x06023401 RID: 144385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023401")]
		[Address(RVA = "0x1DBC370", Offset = "0x1DBAF70", VA = "0x181DBC370")]
		public static CharTokenViewModel CreateCharTokenViewModel(int hostInstId, string hostTmplId, string tokenId, string hostFocusSkillId, string hostSelectEquipId)
		{
			return null;
		}

		// Token: 0x06023402 RID: 144386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023402")]
		[Address(RVA = "0x1DBC150", Offset = "0x1DBAD50", VA = "0x181DBC150")]
		public static CharTokenViewModel CreateCharTokenViewModel(int level, int exp, int favorPoint, int potentialRank, EvolvePhase evolvePhase, string skinId, int equipLevel, int skillLevel, string hostCharId, string hostTmplId, string tokenId, string hostFocusSkillId, string hostSelectEquipId)
		{
			return null;
		}

		// Token: 0x06023403 RID: 144387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023403")]
		[Address(RVA = "0x1DBC770", Offset = "0x1DBB370", VA = "0x181DBC770")]
		public string GetFinalWrappedDesc()
		{
			return null;
		}

		// Token: 0x06023404 RID: 144388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023404")]
		[Address(RVA = "0x1DBD260", Offset = "0x1DBBE60", VA = "0x181DBD260")]
		private void _LoadData(int level, int exp, int favorPoint, int potentialRank, EvolvePhase evolvePhase, string skinId, int equipLevel, int skillLevel, string hostCharId, string tokenId, string hostFocusSkillId, string hostSelectEquipId, CharacterData tokenCharacterData)
		{
		}

		// Token: 0x06023405 RID: 144389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023405")]
		[Address(RVA = "0x1DBCC30", Offset = "0x1DBB830", VA = "0x181DBCC30")]
		private string _GetTokenAvatarId(string skinId, string tokenId)
		{
			return null;
		}

		// Token: 0x06023406 RID: 144390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023406")]
		[Address(RVA = "0x1DBCEC0", Offset = "0x1DBBAC0", VA = "0x181DBCEC0")]
		private List<CharacterTokenTalentViewModel> _GetTokenTalentModelList(EvolvePhase evolvePhase, int level, int potentialRank, string equipId, int equipLevel)
		{
			return null;
		}

		// Token: 0x06023407 RID: 144391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023407")]
		[Address(RVA = "0x1DBC8A0", Offset = "0x1DBB4A0", VA = "0x181DBC8A0")]
		private void _AddTokenShownTalent(TalentData talentData, List<CharacterTokenTalentViewModel> retList)
		{
		}

		// Token: 0x06023408 RID: 144392 RVA: 0x000C03D8 File Offset: 0x000BE5D8
		[Token(Token = "0x6023408")]
		[Address(RVA = "0x1DBCA30", Offset = "0x1DBB630", VA = "0x181DBCA30")]
		private static bool _CheckLoadTokenDataValid(string hostCharId, string hostTmplId, string tokenId, out CharacterData outTokenCharData)
		{
			return default(bool);
		}

		// Token: 0x06023409 RID: 144393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023409")]
		[Address(RVA = "0x1DBD870", Offset = "0x1DBC470", VA = "0x181DBD870")]
		private CharTokenViewModel()
		{
		}

		// Token: 0x0403092A RID: 198954
		[Token(Token = "0x403092A")]
		[FieldOffset(Offset = "0x10")]
		public AttributeViewModel attributeModel;

		// Token: 0x0403092B RID: 198955
		[Token(Token = "0x403092B")]
		[FieldOffset(Offset = "0x18")]
		public BattleInfoViewModel battleInfoModel;

		// Token: 0x0403092C RID: 198956
		[Token(Token = "0x403092C")]
		[FieldOffset(Offset = "0x20")]
		public SkillItemViewModel skillItemViewModel;

		// Token: 0x0403092D RID: 198957
		[Token(Token = "0x403092D")]
		[FieldOffset(Offset = "0x28")]
		public List<CharacterTokenTalentViewModel> talentViewModels;

		// Token: 0x0403092E RID: 198958
		[Token(Token = "0x403092E")]
		[FieldOffset(Offset = "0x30")]
		public string pos;

		// Token: 0x0403092F RID: 198959
		[Token(Token = "0x403092F")]
		[FieldOffset(Offset = "0x38")]
		public string tokenAvatarId;

		// Token: 0x04030930 RID: 198960
		[Token(Token = "0x4030930")]
		[FieldOffset(Offset = "0x40")]
		public CharacterData tokenCharData;

		// Token: 0x04030931 RID: 198961
		[Token(Token = "0x4030931")]
		[FieldOffset(Offset = "0x48")]
		public bool isTalentShow;

		// Token: 0x04030932 RID: 198962
		[Token(Token = "0x4030932")]
		[FieldOffset(Offset = "0x49")]
		public bool isSkillShow;

		// Token: 0x04030933 RID: 198963
		[Token(Token = "0x4030933")]
		[FieldOffset(Offset = "0x4A")]
		public bool isSubProfShow;

		// Token: 0x04030934 RID: 198964
		[Token(Token = "0x4030934")]
		[FieldOffset(Offset = "0x4B")]
		public bool haveDetailShow;

		// Token: 0x04030935 RID: 198965
		[Token(Token = "0x4030935")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateCharTokenViewModel;

		// Token: 0x04030936 RID: 198966
		[Token(Token = "0x4030936")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_CreateCharTokenViewModel;

		// Token: 0x04030937 RID: 198967
		[Token(Token = "0x4030937")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetFinalWrappedDesc;

		// Token: 0x04030938 RID: 198968
		[Token(Token = "0x4030938")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x04030939 RID: 198969
		[Token(Token = "0x4030939")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetTokenAvatarId;

		// Token: 0x0403093A RID: 198970
		[Token(Token = "0x403093A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetTokenTalentModelList;

		// Token: 0x0403093B RID: 198971
		[Token(Token = "0x403093B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__AddTokenShownTalent;

		// Token: 0x0403093C RID: 198972
		[Token(Token = "0x403093C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckLoadTokenDataValid;

		// Token: 0x0403093D RID: 198973
		[Token(Token = "0x403093D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
