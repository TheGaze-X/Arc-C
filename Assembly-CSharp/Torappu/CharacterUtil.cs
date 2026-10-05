using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI;
using Torappu.UI.Atlas;
using Torappu.UI.CharacterCommon;
using Torappu.UI.CharSelect;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x020013FA RID: 5114
	[Token(Token = "0x20013FA")]
	[LuaCallCSharp(GenFlag.No)]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CharacterUtil
	{
		// Token: 0x060074EE RID: 29934 RVA: 0x000340C8 File Offset: 0x000322C8
		[Token(Token = "0x60074EE")]
		[Address(RVA = "0x230C1F0", Offset = "0x230ADF0", VA = "0x18230C1F0")]
		public static CharUISkinStruct GetHighestSelectableUISkin(CharQuery charQuery, EvolvePhase evolvePhase)
		{
			return default(CharUISkinStruct);
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x000340E0 File Offset: 0x000322E0
		[Token(Token = "0x60074EF")]
		[Address(RVA = "0x230F2D0", Offset = "0x230DED0", VA = "0x18230F2D0")]
		public static CharUISkinStruct LoadCharUISkinState(int instId, [Optional] string tmplId)
		{
			return default(CharUISkinStruct);
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x000340F8 File Offset: 0x000322F8
		[Token(Token = "0x60074F0")]
		[Address(RVA = "0x230E8A0", Offset = "0x230D4A0", VA = "0x18230E8A0")]
		public static bool IsPlayerCharShowSpIllust(string skinId)
		{
			return default(bool);
		}

		// Token: 0x060074F1 RID: 29937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F1")]
		[Address(RVA = "0x230EA10", Offset = "0x230D610", VA = "0x18230EA10")]
		public static Sprite LoadCharAvatarBySkin(CharQuery query, EvolvePhase evolvePhase, string skinId, bool isSelfChar = false)
		{
			return null;
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x00034110 File Offset: 0x00032310
		[Token(Token = "0x60074F2")]
		[Address(RVA = "0x230C360", Offset = "0x230AF60", VA = "0x18230C360")]
		public static EvolvePhase GetMaxEvolvePhase(string charId)
		{
			return EvolvePhase.PHASE_0;
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F3")]
		[Address(RVA = "0x230B6D0", Offset = "0x230A2D0", VA = "0x18230B6D0")]
		public static string GetCharName(string charId)
		{
			return null;
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x00034128 File Offset: 0x00032328
		[Token(Token = "0x60074F4")]
		[Address(RVA = "0x230B810", Offset = "0x230A410", VA = "0x18230B810")]
		public static ProfessionCategory GetCharProfession(string charId)
		{
			return ProfessionCategory.NONE;
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x00034140 File Offset: 0x00032340
		[Token(Token = "0x60074F5")]
		[Address(RVA = "0x23105D0", Offset = "0x230F1D0", VA = "0x1823105D0")]
		public static bool TryGetCharName(string charId, out string name)
		{
			return default(bool);
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x00034158 File Offset: 0x00032358
		[Token(Token = "0x60074F6")]
		[Address(RVA = "0x23103C0", Offset = "0x230EFC0", VA = "0x1823103C0")]
		public static bool TryGetCharData(CharQuery query, out CharacterData result)
		{
			return default(bool);
		}

		// Token: 0x060074F7 RID: 29943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F7")]
		[Address(RVA = "0x230B5F0", Offset = "0x230A1F0", VA = "0x18230B5F0")]
		public static CharacterData GetCharDataOrNull(CharQuery query)
		{
			return null;
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074F8")]
		[Address(RVA = "0x230C0B0", Offset = "0x230ACB0", VA = "0x18230C0B0")]
		public static string GetDefaultCharTmpl(string charId)
		{
			return null;
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x00034170 File Offset: 0x00032370
		[Token(Token = "0x60074F9")]
		[Address(RVA = "0x23097D0", Offset = "0x23083D0", VA = "0x1823097D0")]
		public static bool CheckSkinTmplMatch(CharSkinData skinData)
		{
			return default(bool);
		}

		// Token: 0x060074FA RID: 29946 RVA: 0x00034188 File Offset: 0x00032388
		[Token(Token = "0x60074FA")]
		[Address(RVA = "0x23096E0", Offset = "0x23082E0", VA = "0x1823096E0")]
		public static bool CheckSkinTmplAvail(CharSkinData skinData)
		{
			return default(bool);
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x000341A0 File Offset: 0x000323A0
		[Token(Token = "0x60074FB")]
		[Address(RVA = "0x2311230", Offset = "0x230FE30", VA = "0x182311230")]
		public static bool VerifySkin(string skinId, PlayerCharacter playerChar)
		{
			return default(bool);
		}

		// Token: 0x060074FC RID: 29948 RVA: 0x000341B8 File Offset: 0x000323B8
		[Token(Token = "0x60074FC")]
		[Address(RVA = "0x230A150", Offset = "0x2308D50", VA = "0x18230A150")]
		public static bool EditorTryGetCharData(CharQuery options, CharacterDB charDB, TokenDB tokenDB, CharPatchDB charPatchDB, out CharacterData result)
		{
			return default(bool);
		}

		// Token: 0x060074FD RID: 29949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60074FD")]
		[Address(RVA = "0x230B400", Offset = "0x230A000", VA = "0x18230B400")]
		public static string GetCharAppellation(string charId)
		{
			return null;
		}

		// Token: 0x060074FE RID: 29950 RVA: 0x000341D0 File Offset: 0x000323D0
		[Token(Token = "0x60074FE")]
		[Address(RVA = "0x2309960", Offset = "0x2308560", VA = "0x182309960")]
		public static bool CheckUnlimitSkinBuyInLimitTime(string skinId)
		{
			return default(bool);
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x000341E8 File Offset: 0x000323E8
		[Token(Token = "0x60074FF")]
		[Address(RVA = "0x23095F0", Offset = "0x23081F0", VA = "0x1823095F0")]
		public static bool CheckSkinAvailable(string skinId)
		{
			return default(bool);
		}

		// Token: 0x06007500 RID: 29952 RVA: 0x00034200 File Offset: 0x00032400
		[Token(Token = "0x6007500")]
		[Address(RVA = "0x230C8E0", Offset = "0x230B4E0", VA = "0x18230C8E0")]
		public static SpriteRenderData GetPortraitSprite(CharQuery query, EvolvePhase phase)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x06007501 RID: 29953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007501")]
		[Address(RVA = "0x230CF40", Offset = "0x230BB40", VA = "0x18230CF40")]
		public static string GetSkillIdByIndex(CharQuery query, int skillIndex)
		{
			return null;
		}

		// Token: 0x06007502 RID: 29954 RVA: 0x00034218 File Offset: 0x00032418
		[Token(Token = "0x6007502")]
		[Address(RVA = "0x2310A30", Offset = "0x230F630", VA = "0x182310A30")]
		public static bool TryLoadMaxMasterLevelInfo(List<CharMasterLevelData> levelList, out CharMasterLevelData levelInfo)
		{
			return default(bool);
		}

		// Token: 0x06007503 RID: 29955 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007503")]
		[Address(RVA = "0x230CDA0", Offset = "0x230B9A0", VA = "0x18230CDA0")]
		public static string GetSkillIdByIndexInPlayerData(int charInstId, int skillIndex)
		{
			return null;
		}

		// Token: 0x06007504 RID: 29956 RVA: 0x00034230 File Offset: 0x00032430
		[Token(Token = "0x6007504")]
		[Address(RVA = "0x230A6D0", Offset = "0x23092D0", VA = "0x18230A6D0")]
		public static int FindSkillIndexByIdInPlayerData(int charInstId, string skillId)
		{
			return 0;
		}

		// Token: 0x06007505 RID: 29957 RVA: 0x00034248 File Offset: 0x00032448
		[Token(Token = "0x6007505")]
		[Address(RVA = "0x230A900", Offset = "0x2309500", VA = "0x18230A900")]
		public static int FindSkillIndexByIdInPlayerData(PlayerCharacter playerChar, string skillId)
		{
			return 0;
		}

		// Token: 0x06007506 RID: 29958 RVA: 0x00034260 File Offset: 0x00032460
		[Token(Token = "0x6007506")]
		[Address(RVA = "0x2308310", Offset = "0x2306F10", VA = "0x182308310")]
		public static bool CheckIfSpecMaxChar(SharedCharData friendCharData)
		{
			return default(bool);
		}

		// Token: 0x06007507 RID: 29959 RVA: 0x00034278 File Offset: 0x00032478
		[Token(Token = "0x6007507")]
		[Address(RVA = "0x2308430", Offset = "0x2307030", VA = "0x182308430")]
		public static bool CheckIfSpecMaxChar(PlayerCharacter charData)
		{
			return default(bool);
		}

		// Token: 0x06007508 RID: 29960 RVA: 0x00034290 File Offset: 0x00032490
		[Token(Token = "0x6007508")]
		[Address(RVA = "0x2308550", Offset = "0x2307150", VA = "0x182308550")]
		public static bool CheckIfSpecMaxChar(ICharacterCardViewModel commonCharacter)
		{
			return default(bool);
		}

		// Token: 0x06007509 RID: 29961 RVA: 0x000342A8 File Offset: 0x000324A8
		[Token(Token = "0x6007509")]
		[Address(RVA = "0x2308840", Offset = "0x2307440", VA = "0x182308840")]
		public static bool CheckIfSpecMaxChar(ICharSkillInfo skillInfo)
		{
			return default(bool);
		}

		// Token: 0x0600750A RID: 29962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600750A")]
		[Address(RVA = "0x230A380", Offset = "0x2308F80", VA = "0x18230A380")]
		public static string FindEquipIdByIdInPlayerData(int charInstId, string equipId)
		{
			return null;
		}

		// Token: 0x0600750B RID: 29963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600750B")]
		[Address(RVA = "0x230A5C0", Offset = "0x23091C0", VA = "0x18230A5C0")]
		public static string FindEquipIdByIdInPlayerData(PlayerCharacter playerChar, string equipId)
		{
			return null;
		}

		// Token: 0x0600750C RID: 29964 RVA: 0x000342C0 File Offset: 0x000324C0
		[Token(Token = "0x600750C")]
		[Address(RVA = "0x230AA20", Offset = "0x2309620", VA = "0x18230AA20")]
		public static int FindSkillIndexById(CharQuery query, string skillId)
		{
			return 0;
		}

		// Token: 0x0600750D RID: 29965 RVA: 0x000342D8 File Offset: 0x000324D8
		[Token(Token = "0x600750D")]
		[Address(RVA = "0x2307170", Offset = "0x2305D70", VA = "0x182307170")]
		public static bool CheckIfCharSkillAvailable(int charInstId, string targetTmpl, string skillId)
		{
			return default(bool);
		}

		// Token: 0x0600750E RID: 29966 RVA: 0x000342F0 File Offset: 0x000324F0
		[Token(Token = "0x600750E")]
		[Address(RVA = "0x2307390", Offset = "0x2305F90", VA = "0x182307390")]
		public static bool CheckIfCharSkillHideOnUI(SkillData skillData)
		{
			return default(bool);
		}

		// Token: 0x0600750F RID: 29967 RVA: 0x00034308 File Offset: 0x00032508
		[Token(Token = "0x600750F")]
		[Address(RVA = "0x2307660", Offset = "0x2306260", VA = "0x182307660")]
		public static bool CheckIfCharUniEquipAvailable(int charInstId, string targetTmpl, string uniequipId)
		{
			return default(bool);
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x00034320 File Offset: 0x00032520
		[Token(Token = "0x6007510")]
		[Address(RVA = "0x230CA40", Offset = "0x230B640", VA = "0x18230CA40")]
		public static SpriteRenderData GetPortraitSprite(string skinId)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x06007511 RID: 29969 RVA: 0x00034338 File Offset: 0x00032538
		[Token(Token = "0x6007511")]
		[Address(RVA = "0x230C640", Offset = "0x230B240", VA = "0x18230C640")]
		public static SpriteRenderData GetPortraitSpriteBySkin(CharQuery query, EvolvePhase evolvePhase, string skinId)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x06007512 RID: 29970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007512")]
		[Address(RVA = "0x230ECA0", Offset = "0x230D8A0", VA = "0x18230ECA0")]
		public static Sprite LoadCharAvatar(string avatarId)
		{
			return null;
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x00034350 File Offset: 0x00032550
		[Token(Token = "0x6007513")]
		[Address(RVA = "0x230F1F0", Offset = "0x230DDF0", VA = "0x18230F1F0")]
		public static SpriteRenderData LoadCharPortrait(string portraitId)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x00034368 File Offset: 0x00032568
		[Token(Token = "0x6007514")]
		[Address(RVA = "0x230EDF0", Offset = "0x230D9F0", VA = "0x18230EDF0")]
		public static SpriteRenderData LoadCharPortrait(string portraitId, ILoadAsset assetLoader)
		{
			return default(SpriteRenderData);
		}

		// Token: 0x06007515 RID: 29973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007515")]
		[Address(RVA = "0x230FD00", Offset = "0x230E900", VA = "0x18230FD00")]
		public static Sprite LoadShopSkinPortrait(string portraitId)
		{
			return null;
		}

		// Token: 0x06007516 RID: 29974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007516")]
		[Address(RVA = "0x230FC40", Offset = "0x230E840", VA = "0x18230FC40")]
		public static ProfessionSpriteHub LoadProfessionTextHub()
		{
			return null;
		}

		// Token: 0x06007517 RID: 29975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007517")]
		[Address(RVA = "0x230ABC0", Offset = "0x23097C0", VA = "0x18230ABC0")]
		public static string GenCustomSortTypeCacheKeyByPageName(string pageName)
		{
			return null;
		}

		// Token: 0x06007518 RID: 29976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007518")]
		public static void SortCharList<T>(List<T> charList, CharacterSortType sortType) where T : IBasicCharInfo
		{
		}

		// Token: 0x06007519 RID: 29977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007519")]
		[Address(RVA = "0x230B540", Offset = "0x230A140", VA = "0x18230B540")]
		public static Comparison<IComparableChar> GetCharComparison(CharacterSortType sortType)
		{
			return null;
		}

		// Token: 0x0600751A RID: 29978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600751A")]
		public static void SortEvolveCharList<T>(List<T> charList) where T : IBasicCharInfo
		{
		}

		// Token: 0x0600751B RID: 29979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600751B")]
		public static void SortLevelMaxCharList<T>(List<T> charList) where T : IBasicCharInfo
		{
		}

		// Token: 0x0600751C RID: 29980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600751C")]
		public static void SortSkillMaxCharList<T>(List<T> charList) where T : CharacterCardViewModel
		{
		}

		// Token: 0x0600751D RID: 29981 RVA: 0x00034380 File Offset: 0x00032580
		[Token(Token = "0x600751D")]
		[Address(RVA = "0x23133C0", Offset = "0x2311FC0", VA = "0x1823133C0")]
		private static int _CompareByChain(IComparableChar a, IComparableChar b, Func<IComparableChar, IComparableChar, int> targetComp, bool isInverse)
		{
			return 0;
		}

		// Token: 0x0600751E RID: 29982 RVA: 0x00034398 File Offset: 0x00032598
		[Token(Token = "0x600751E")]
		[Address(RVA = "0x230BFC0", Offset = "0x230ABC0", VA = "0x18230BFC0")]
		public static CharacterSortTypePair GetCustomCharSortTypePair(CharacterSortType sortType)
		{
			return default(CharacterSortTypePair);
		}

		// Token: 0x0600751F RID: 29983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600751F")]
		[Address(RVA = "0x230BF30", Offset = "0x230AB30", VA = "0x18230BF30")]
		public static List<CharacterSortTypePair> GetCustomCharSortTypeList()
		{
			return null;
		}

		// Token: 0x06007520 RID: 29984 RVA: 0x000343B0 File Offset: 0x000325B0
		[Token(Token = "0x6007520")]
		[Address(RVA = "0x2314070", Offset = "0x2312C70", VA = "0x182314070")]
		private static int _CompareByLevelUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007521 RID: 29985 RVA: 0x000343C8 File Offset: 0x000325C8
		[Token(Token = "0x6007521")]
		[Address(RVA = "0x2313F70", Offset = "0x2312B70", VA = "0x182313F70")]
		private static int _CompareByLevelDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007522 RID: 29986 RVA: 0x000343E0 File Offset: 0x000325E0
		[Token(Token = "0x6007522")]
		[Address(RVA = "0x2314270", Offset = "0x2312E70", VA = "0x182314270")]
		private static int _CompareByNameUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007523 RID: 29987 RVA: 0x000343F8 File Offset: 0x000325F8
		[Token(Token = "0x6007523")]
		[Address(RVA = "0x2314170", Offset = "0x2312D70", VA = "0x182314170")]
		private static int _CompareByNameDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007524 RID: 29988 RVA: 0x00034410 File Offset: 0x00032610
		[Token(Token = "0x6007524")]
		[Address(RVA = "0x2313C70", Offset = "0x2312870", VA = "0x182313C70")]
		private static int _CompareByGainTimeUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007525 RID: 29989 RVA: 0x00034428 File Offset: 0x00032628
		[Token(Token = "0x6007525")]
		[Address(RVA = "0x2313B70", Offset = "0x2312770", VA = "0x182313B70")]
		private static int _CompareByGainTimeDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007526 RID: 29990 RVA: 0x00034440 File Offset: 0x00032640
		[Token(Token = "0x6007526")]
		[Address(RVA = "0x2313A70", Offset = "0x2312670", VA = "0x182313A70")]
		private static int _CompareByFavorUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007527 RID: 29991 RVA: 0x00034458 File Offset: 0x00032658
		[Token(Token = "0x6007527")]
		[Address(RVA = "0x2313970", Offset = "0x2312570", VA = "0x182313970")]
		private static int _CompareByFavorDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007528 RID: 29992 RVA: 0x00034470 File Offset: 0x00032670
		[Token(Token = "0x6007528")]
		[Address(RVA = "0x2314470", Offset = "0x2313070", VA = "0x182314470")]
		private static int _CompareByRarityUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007529 RID: 29993 RVA: 0x00034488 File Offset: 0x00032688
		[Token(Token = "0x6007529")]
		[Address(RVA = "0x2314370", Offset = "0x2312F70", VA = "0x182314370")]
		private static int _CompareByRarityDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600752A RID: 29994 RVA: 0x000344A0 File Offset: 0x000326A0
		[Token(Token = "0x600752A")]
		[Address(RVA = "0x2313670", Offset = "0x2312270", VA = "0x182313670")]
		private static int _CompareByCostUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600752B RID: 29995 RVA: 0x000344B8 File Offset: 0x000326B8
		[Token(Token = "0x600752B")]
		[Address(RVA = "0x2313570", Offset = "0x2312170", VA = "0x182313570")]
		private static int _CompareByCostDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600752C RID: 29996 RVA: 0x000344D0 File Offset: 0x000326D0
		[Token(Token = "0x600752C")]
		[Address(RVA = "0x2313E70", Offset = "0x2312A70", VA = "0x182313E70")]
		private static int _CompareByHpUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600752D RID: 29997 RVA: 0x000344E8 File Offset: 0x000326E8
		[Token(Token = "0x600752D")]
		[Address(RVA = "0x2313D70", Offset = "0x2312970", VA = "0x182313D70")]
		private static int _CompareByHpDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600752E RID: 29998 RVA: 0x00034500 File Offset: 0x00032700
		[Token(Token = "0x600752E")]
		[Address(RVA = "0x2312FC0", Offset = "0x2311BC0", VA = "0x182312FC0")]
		private static int _CompareByAtkUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600752F RID: 29999 RVA: 0x00034518 File Offset: 0x00032718
		[Token(Token = "0x600752F")]
		[Address(RVA = "0x2312CC0", Offset = "0x23118C0", VA = "0x182312CC0")]
		private static int _CompareByAtkDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007530 RID: 30000 RVA: 0x00034530 File Offset: 0x00032730
		[Token(Token = "0x6007530")]
		[Address(RVA = "0x2313870", Offset = "0x2312470", VA = "0x182313870")]
		private static int _CompareByDefUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007531 RID: 30001 RVA: 0x00034548 File Offset: 0x00032748
		[Token(Token = "0x6007531")]
		[Address(RVA = "0x2313770", Offset = "0x2312370", VA = "0x182313770")]
		private static int _CompareByDefDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x00034560 File Offset: 0x00032760
		[Token(Token = "0x6007532")]
		[Address(RVA = "0x2314670", Offset = "0x2313270", VA = "0x182314670")]
		private static int _CompareByResUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x00034578 File Offset: 0x00032778
		[Token(Token = "0x6007533")]
		[Address(RVA = "0x2314570", Offset = "0x2313170", VA = "0x182314570")]
		private static int _CompareByResDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x00034590 File Offset: 0x00032790
		[Token(Token = "0x6007534")]
		[Address(RVA = "0x2314870", Offset = "0x2313470", VA = "0x182314870")]
		private static int _CompareByRespawnUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007535 RID: 30005 RVA: 0x000345A8 File Offset: 0x000327A8
		[Token(Token = "0x6007535")]
		[Address(RVA = "0x2314770", Offset = "0x2313370", VA = "0x182314770")]
		private static int _CompareByRespawnDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007536 RID: 30006 RVA: 0x000345C0 File Offset: 0x000327C0
		[Token(Token = "0x6007536")]
		[Address(RVA = "0x23131C0", Offset = "0x2311DC0", VA = "0x1823131C0")]
		private static int _CompareByBlockNumUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007537 RID: 30007 RVA: 0x000345D8 File Offset: 0x000327D8
		[Token(Token = "0x6007537")]
		[Address(RVA = "0x23130C0", Offset = "0x2311CC0", VA = "0x1823130C0")]
		private static int _CompareByBlockNumDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x000345F0 File Offset: 0x000327F0
		[Token(Token = "0x6007538")]
		[Address(RVA = "0x2312EC0", Offset = "0x2311AC0", VA = "0x182312EC0")]
		private static int _CompareByAtkSpeedUp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x00034608 File Offset: 0x00032808
		[Token(Token = "0x6007539")]
		[Address(RVA = "0x2312DC0", Offset = "0x23119C0", VA = "0x182312DC0")]
		private static int _CompareByAtkSpeedDown(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x00034620 File Offset: 0x00032820
		[Token(Token = "0x600753A")]
		[Address(RVA = "0x23132C0", Offset = "0x2311EC0", VA = "0x1823132C0")]
		private static int _CompareByChainDefault(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x00034638 File Offset: 0x00032838
		[Token(Token = "0x600753B")]
		[Address(RVA = "0x230CCA0", Offset = "0x230B8A0", VA = "0x18230CCA0")]
		public static int GetProfessionPerioty(ProfessionCategory prof)
		{
			return 0;
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x00034650 File Offset: 0x00032850
		[Token(Token = "0x600753C")]
		[Address(RVA = "0x2312680", Offset = "0x2311280", VA = "0x182312680")]
		private static int _CompLevel(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600753D RID: 30013 RVA: 0x00034668 File Offset: 0x00032868
		[Token(Token = "0x600753D")]
		[Address(RVA = "0x23127F0", Offset = "0x23113F0", VA = "0x1823127F0")]
		private static int _CompName(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600753E RID: 30014 RVA: 0x00034680 File Offset: 0x00032880
		[Token(Token = "0x600753E")]
		[Address(RVA = "0x23124A0", Offset = "0x23110A0", VA = "0x1823124A0")]
		private static int _CompGainTime(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x00034698 File Offset: 0x00032898
		[Token(Token = "0x600753F")]
		[Address(RVA = "0x2314970", Offset = "0x2313570", VA = "0x182314970")]
		private static int _CompareFavor(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x000346B0 File Offset: 0x000328B0
		[Token(Token = "0x6007540")]
		[Address(RVA = "0x23129E0", Offset = "0x23115E0", VA = "0x1823129E0")]
		private static int _CompRarity(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x000346C8 File Offset: 0x000328C8
		[Token(Token = "0x6007541")]
		[Address(RVA = "0x23122E0", Offset = "0x2310EE0", VA = "0x1823122E0")]
		private static int _CompCost(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x000346E0 File Offset: 0x000328E0
		[Token(Token = "0x6007542")]
		[Address(RVA = "0x23125A0", Offset = "0x23111A0", VA = "0x1823125A0")]
		private static int _CompHp(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x000346F8 File Offset: 0x000328F8
		[Token(Token = "0x6007543")]
		[Address(RVA = "0x2312090", Offset = "0x2310C90", VA = "0x182312090")]
		private static int _CompAtk(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x00034710 File Offset: 0x00032910
		[Token(Token = "0x6007544")]
		[Address(RVA = "0x23123C0", Offset = "0x2310FC0", VA = "0x1823123C0")]
		private static int _CompDef(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x00034728 File Offset: 0x00032928
		[Token(Token = "0x6007545")]
		[Address(RVA = "0x2312B00", Offset = "0x2311700", VA = "0x182312B00")]
		private static int _CompRes(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007546 RID: 30022 RVA: 0x00034740 File Offset: 0x00032940
		[Token(Token = "0x6007546")]
		[Address(RVA = "0x23128D0", Offset = "0x23114D0", VA = "0x1823128D0")]
		private static int _CompProfession(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007547 RID: 30023 RVA: 0x00034758 File Offset: 0x00032958
		[Token(Token = "0x6007547")]
		[Address(RVA = "0x2312BE0", Offset = "0x23117E0", VA = "0x182312BE0")]
		private static int _CompRespawnTime(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x00034770 File Offset: 0x00032970
		[Token(Token = "0x6007548")]
		[Address(RVA = "0x2312170", Offset = "0x2310D70", VA = "0x182312170")]
		private static int _CompBlockNum(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x00034788 File Offset: 0x00032988
		[Token(Token = "0x6007549")]
		[Address(RVA = "0x2311FB0", Offset = "0x2310BB0", VA = "0x182311FB0")]
		private static int _CompAtkSpeed(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x000347A0 File Offset: 0x000329A0
		[Token(Token = "0x600754A")]
		[Address(RVA = "0x2312250", Offset = "0x2310E50", VA = "0x182312250")]
		private static int _CompByChainDefault(IComparableChar a, IComparableChar b)
		{
			return 0;
		}

		// Token: 0x0600754B RID: 30027 RVA: 0x000347B8 File Offset: 0x000329B8
		[Token(Token = "0x600754B")]
		[Address(RVA = "0x2304D00", Offset = "0x2303900", VA = "0x182304D00")]
		public static int CalcCharacterFavorPercent(int favorPoint)
		{
			return 0;
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600754C")]
		[Address(RVA = "0x230C4F0", Offset = "0x230B0F0", VA = "0x18230C4F0")]
		public static PlayerCharacter GetPlayerInstByCharId(string charId)
		{
			return null;
		}

		// Token: 0x0600754D RID: 30029 RVA: 0x000347D0 File Offset: 0x000329D0
		[Token(Token = "0x600754D")]
		[Address(RVA = "0x23094C0", Offset = "0x23080C0", VA = "0x1823094C0")]
		public static bool CheckPlayerCharAvailable(CharQuery query)
		{
			return default(bool);
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600754E")]
		[Address(RVA = "0x230C590", Offset = "0x230B190", VA = "0x18230C590")]
		public static string GetPlayerTmplByCharId(string charId)
		{
			return null;
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x000347E8 File Offset: 0x000329E8
		[Token(Token = "0x600754F")]
		[Address(RVA = "0x230E980", Offset = "0x230D580", VA = "0x18230E980")]
		public static bool IsStandardCharacter(CharacterData data)
		{
			return default(bool);
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x00034800 File Offset: 0x00032A00
		[Token(Token = "0x6007550")]
		[Address(RVA = "0x230E2D0", Offset = "0x230CED0", VA = "0x18230E2D0")]
		public static bool IsHandbookLimitChar(string charId)
		{
			return default(bool);
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x00034818 File Offset: 0x00032A18
		[Token(Token = "0x6007551")]
		[Address(RVA = "0x230E780", Offset = "0x230D380", VA = "0x18230E780")]
		public static bool IsNotObtainableChar(string charId)
		{
			return default(bool);
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007552")]
		[Address(RVA = "0x2304B70", Offset = "0x2303770", VA = "0x182304B70")]
		public static string AchieveDefaultSkillId(int charInstId)
		{
			return null;
		}

		// Token: 0x06007553 RID: 30035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007553")]
		[Address(RVA = "0x230DD60", Offset = "0x230C960", VA = "0x18230DD60")]
		public static CharSelectSkillGroupViewModel InstCharSelectSkillGroupViewModel(string selectedSkillId, PlayerCharacter playerChar, CharacterData charData, bool skipSkillIconLoad = false)
		{
			return null;
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007554")]
		[Address(RVA = "0x230DA00", Offset = "0x230C600", VA = "0x18230DA00")]
		public static CharSelectSkillGroupViewModel InstCharSelectSkillGroupViewModelByCharacterCardViewModel(ICharacterCardViewModel characterCardViewModel, string charId, bool skipSkillIconLoad = false)
		{
			return null;
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007555")]
		[Address(RVA = "0x2315350", Offset = "0x2313F50", VA = "0x182315350")]
		private static CharSelectSkillGroupViewModel _InternalInstCharSelectSkillGroupViewModel(CharQuery charQuery, int instIdInPlayerData, int mainSkillLvl, string selectedSkillId, PlayerCharSkill[] playerSkills, CharacterData charData, bool skipSkillIconLoad = false)
		{
			return null;
		}

		// Token: 0x06007556 RID: 30038 RVA: 0x00034830 File Offset: 0x00032A30
		[Token(Token = "0x6007556")]
		[Address(RVA = "0x230E1B0", Offset = "0x230CDB0", VA = "0x18230E1B0")]
		public static bool IsEquipTmplMatch(UniEquipData equipData, CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x06007557 RID: 30039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007557")]
		[Address(RVA = "0x230D4F0", Offset = "0x230C0F0", VA = "0x18230D4F0")]
		public static CharSelectBranchGroupViewModel InstCharSelectBranchGroupViewModel(PlayerCharacter playerChar, CharacterData charData, [Optional] string equipId)
		{
			return null;
		}

		// Token: 0x06007558 RID: 30040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007558")]
		[Address(RVA = "0x230D6D0", Offset = "0x230C2D0", VA = "0x18230D6D0")]
		public static CharSelectBranchGroupViewModel InstCharSelectBranchViewModelByCharacterCardViewModel(ICharacterCardViewModel characterCardViewModel, [Optional] string equipId)
		{
			return null;
		}

		// Token: 0x06007559 RID: 30041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007559")]
		[Address(RVA = "0x2314B60", Offset = "0x2313760", VA = "0x182314B60")]
		private static CharSelectBranchGroupViewModel _InternalInstCharSelectBranchViewModel(CharQuery charQuery, int level, EvolvePhase evolvePhase, int potentialRank, string equipId, ListDict<string, PlayerCharEquipInfo> equips, CharacterData charData)
		{
			return null;
		}

		// Token: 0x0600755A RID: 30042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600755A")]
		[Address(RVA = "0x2304A30", Offset = "0x2303630", VA = "0x182304A30")]
		public static string AchieveDefaultEquipId(int charInstId)
		{
			return null;
		}

		// Token: 0x0600755B RID: 30043 RVA: 0x00034848 File Offset: 0x00032A48
		[Token(Token = "0x600755B")]
		[Address(RVA = "0x2307960", Offset = "0x2306560", VA = "0x182307960")]
		public static bool CheckIfCharUpdatedInHandBook(string charId)
		{
			return default(bool);
		}

		// Token: 0x0600755C RID: 30044 RVA: 0x00034860 File Offset: 0x00032A60
		[Token(Token = "0x600755C")]
		[Address(RVA = "0x2307570", Offset = "0x2306170", VA = "0x182307570")]
		public static bool CheckIfCharTrackPointInHandBook(string charId)
		{
			return default(bool);
		}

		// Token: 0x0600755D RID: 30045 RVA: 0x00034878 File Offset: 0x00032A78
		[Token(Token = "0x600755D")]
		[Address(RVA = "0x2305740", Offset = "0x2304340", VA = "0x182305740")]
		public static bool CheckAvailCharHaveSkillToTrain(out string charId, out int instId)
		{
			return default(bool);
		}

		// Token: 0x0600755E RID: 30046 RVA: 0x00034890 File Offset: 0x00032A90
		[Token(Token = "0x600755E")]
		[Address(RVA = "0x2311030", Offset = "0x230FC30", VA = "0x182311030")]
		public static bool TryTriggerSkillRelatedStory()
		{
			return default(bool);
		}

		// Token: 0x0600755F RID: 30047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600755F")]
		[Address(RVA = "0x2310BB0", Offset = "0x230F7B0", VA = "0x182310BB0")]
		public static void TryTriggerCharRelatedStory(Action<Story> onEquipEndCallBack)
		{
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x000348A8 File Offset: 0x00032AA8
		[Token(Token = "0x6007560")]
		[Address(RVA = "0x2310C60", Offset = "0x230F860", VA = "0x182310C60")]
		public static bool TryTriggerEquipRelatedStory(Action<Story> onEquipEndCallBack)
		{
			return default(bool);
		}

		// Token: 0x06007561 RID: 30049 RVA: 0x000348C0 File Offset: 0x00032AC0
		[Token(Token = "0x6007561")]
		[Address(RVA = "0x2306750", Offset = "0x2305350", VA = "0x182306750")]
		public static bool CheckAvailCharHaveUniEquip(out string charId, out int instId)
		{
			return default(bool);
		}

		// Token: 0x06007562 RID: 30050 RVA: 0x000348D8 File Offset: 0x00032AD8
		[Token(Token = "0x6007562")]
		[Address(RVA = "0x2305C40", Offset = "0x2304840", VA = "0x182305C40")]
		public static bool CheckAvailCharHaveUniEquipToLvlup(out string charId, out int instId)
		{
			return default(bool);
		}

		// Token: 0x06007563 RID: 30051 RVA: 0x000348F0 File Offset: 0x00032AF0
		[Token(Token = "0x6007563")]
		[Address(RVA = "0x2306E00", Offset = "0x2305A00", VA = "0x182306E00")]
		public static bool CheckCharHaveUniEquipFirstVisit(string charId)
		{
			return default(bool);
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x00034908 File Offset: 0x00032B08
		[Token(Token = "0x6007564")]
		[Address(RVA = "0x2311980", Offset = "0x2310580", VA = "0x182311980")]
		private static bool _CheckIfTrackPointInHandBookStory(string charId)
		{
			return default(bool);
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x00034920 File Offset: 0x00032B20
		[Token(Token = "0x6007565")]
		[Address(RVA = "0x230DF10", Offset = "0x230CB10", VA = "0x18230DF10")]
		public static bool IsCharLvlAndEliteFull(CharacterData charData, PlayerCharacter charInfo)
		{
			return default(bool);
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x00034938 File Offset: 0x00032B38
		[Token(Token = "0x6007566")]
		[Address(RVA = "0x23091A0", Offset = "0x2307DA0", VA = "0x1823091A0")]
		public static bool CheckIfTrackPointInHandBookStage(string charId)
		{
			return default(bool);
		}

		// Token: 0x06007567 RID: 30055 RVA: 0x00034950 File Offset: 0x00032B50
		[Token(Token = "0x6007567")]
		[Address(RVA = "0x230B930", Offset = "0x230A530", VA = "0x18230B930")]
		public static CharacterHandbookStageStatus GetCharacterHandbookStageStatus(string charId)
		{
			return CharacterHandbookStageStatus.NONE;
		}

		// Token: 0x06007568 RID: 30056 RVA: 0x00034968 File Offset: 0x00032B68
		[Token(Token = "0x6007568")]
		[Address(RVA = "0x2311840", Offset = "0x2310440", VA = "0x182311840")]
		private static bool _CheckHandBookStageUnlocked(string charId, HandbookStoryStageData stageData)
		{
			return default(bool);
		}

		// Token: 0x06007569 RID: 30057 RVA: 0x00034980 File Offset: 0x00032B80
		[Token(Token = "0x6007569")]
		[Address(RVA = "0x23116D0", Offset = "0x23102D0", VA = "0x1823116D0")]
		private static bool _CheckHandBookStagePass(string charId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x00034998 File Offset: 0x00032B98
		[Token(Token = "0x600756A")]
		[Address(RVA = "0x2314A50", Offset = "0x2313650", VA = "0x182314A50")]
		private static int _GetCharSpecializedLevelSum(CharacterCardViewModel charModel)
		{
			return 0;
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x000349B0 File Offset: 0x00032BB0
		[Token(Token = "0x600756B")]
		[Address(RVA = "0x23090C0", Offset = "0x2307CC0", VA = "0x1823090C0")]
		public static bool CheckIfTrackPointInHandBookNewVoice(string charId)
		{
			return default(bool);
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x000349C8 File Offset: 0x00032BC8
		[Token(Token = "0x600756C")]
		[Address(RVA = "0x2307C30", Offset = "0x2306830", VA = "0x182307C30")]
		public static bool CheckIfPontialImprovable(PlayerCharacter playerChar)
		{
			return default(bool);
		}

		// Token: 0x0600756D RID: 30061 RVA: 0x000349E0 File Offset: 0x00032BE0
		[Token(Token = "0x600756D")]
		[Address(RVA = "0x2308B40", Offset = "0x2307740", VA = "0x182308B40")]
		public static bool CheckIfSpecializedSkillCanImprove(int charInstId, int maxLevel)
		{
			return default(bool);
		}

		// Token: 0x0600756E RID: 30062 RVA: 0x000349F8 File Offset: 0x00032BF8
		[Token(Token = "0x600756E")]
		[Address(RVA = "0x23089B0", Offset = "0x23075B0", VA = "0x1823089B0")]
		public static bool CheckIfSpecializedSkillCanImprove(CharQuery charQuery)
		{
			return default(bool);
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x00034A10 File Offset: 0x00032C10
		[Token(Token = "0x600756F")]
		[Address(RVA = "0x2308EA0", Offset = "0x2307AA0", VA = "0x182308EA0")]
		public static bool CheckIfTmplUpdated(ISquadMemberCompInfo prev, ISquadMemberCompInfo cur)
		{
			return default(bool);
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x00034A28 File Offset: 0x00032C28
		[Token(Token = "0x6007570")]
		[Address(RVA = "0x2310740", Offset = "0x230F340", VA = "0x182310740")]
		public static bool TryGetTrait(CharacterData.TraitData[] candidates, int level, EvolvePhase phase, int potential, out CharacterData.TraitData trait)
		{
			return default(bool);
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x00034A40 File Offset: 0x00032C40
		[Token(Token = "0x6007571")]
		[Address(RVA = "0x230E3D0", Offset = "0x230CFD0", VA = "0x18230E3D0")]
		public static bool IsMutuallyExclusiveChar(string charIdA, string charIdB, bool ignoreSame = false)
		{
			return default(bool);
		}

		// Token: 0x06007572 RID: 30066 RVA: 0x00034A58 File Offset: 0x00032C58
		[Token(Token = "0x6007572")]
		[Address(RVA = "0x230E4C0", Offset = "0x230D0C0", VA = "0x18230E4C0")]
		public static bool IsMutuallyExclusiveChar(int charInstIdA, int charInstIdB, bool ignoreSame = false)
		{
			return default(bool);
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007573")]
		[Address(RVA = "0x230FB40", Offset = "0x230E740", VA = "0x18230FB40")]
		[Obsolete("This method is used for load spchar instIds, and now spchar is NOT exclusive with origin char.")]
		public static void LoadMutuallyExclusiveCharInstIds(int charInstId, ref List<int> outInstIds)
		{
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x00034A70 File Offset: 0x00032C70
		[Token(Token = "0x6007574")]
		[Address(RVA = "0x230D0C0", Offset = "0x230BCC0", VA = "0x18230D0C0")]
		public static bool HasNewCharTag(string charId)
		{
			return default(bool);
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007575")]
		[Address(RVA = "0x230FFF0", Offset = "0x230EBF0", VA = "0x18230FFF0")]
		public static void LogNewCharAchieved(string charId)
		{
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007576")]
		[Address(RVA = "0x2310200", Offset = "0x230EE00", VA = "0x182310200")]
		public static void LogNewCharAchieved(IGachaResultHolder gachaResult)
		{
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007577")]
		[Address(RVA = "0x230FF50", Offset = "0x230EB50", VA = "0x18230FF50")]
		public static void LogNewCharAchieved(GachaResult charGet)
		{
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x00034A88 File Offset: 0x00032C88
		[Token(Token = "0x6007578")]
		[Address(RVA = "0x230D140", Offset = "0x230BD40", VA = "0x18230D140")]
		[Obsolete("This method was used for check sp mission tracker, and now sp mission is banned.")]
		public static bool HasNewSpCharMission(string charId)
		{
			return default(bool);
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007579")]
		[Address(RVA = "0x2316290", Offset = "0x2314E90", VA = "0x182316290")]
		private static void _TryLogSpCharMissionNew(string charId, List<KeyValuePair<string, TrackPointCacheGroup>> traceList)
		{
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x00034AA0 File Offset: 0x00032CA0
		[Token(Token = "0x600757A")]
		[Address(RVA = "0x230D240", Offset = "0x230BE40", VA = "0x18230D240")]
		[Obsolete("This method was used for check sp mission tracker, and now sp mission is banned.")]
		public static bool HasUnconfirmedSpCharMissionReward(string charId)
		{
			return default(bool);
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x00034AB8 File Offset: 0x00032CB8
		[Token(Token = "0x600757B")]
		[Address(RVA = "0x2308140", Offset = "0x2306D40", VA = "0x182308140")]
		[Obsolete("This method was used for check sp mission tracker, and now sp mission is banned.")]
		public static bool CheckIfSpCharMissionUnlocked(string charId)
		{
			return default(bool);
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x00034AD0 File Offset: 0x00032CD0
		[Token(Token = "0x600757C")]
		[Address(RVA = "0x2307EA0", Offset = "0x2306AA0", VA = "0x182307EA0")]
		[Obsolete("This method was used for check sp mission tracker, and now sp mission is banned.")]
		public static bool CheckIfSpCharMissionAllComplete(string charId)
		{
			return default(bool);
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x00034AE8 File Offset: 0x00032CE8
		[Token(Token = "0x600757D")]
		[Address(RVA = "0x2306FB0", Offset = "0x2305BB0", VA = "0x182306FB0")]
		public static ModifiedSharedCharData CheckData(SharedCharData sharedData, EvolvePhaseAndLevel maxExolvePhaseAndLevel, bool isFriend = true)
		{
			return default(ModifiedSharedCharData);
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x00034B00 File Offset: 0x00032D00
		[Token(Token = "0x600757E")]
		[Address(RVA = "0x2315C40", Offset = "0x2314840", VA = "0x182315C40")]
		private static ModifiedSharedCharData _ModifyAttrLimitedCharDataImpl(SharedCharData sharedData, EvolvePhaseAndLevel maxExolvePhaseAndLevel, bool isFriend)
		{
			return default(ModifiedSharedCharData);
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x00034B18 File Offset: 0x00032D18
		[Token(Token = "0x600757F")]
		[Address(RVA = "0x2304E80", Offset = "0x2303A80", VA = "0x182304E80")]
		public static ModifiedSharedCharData CheckAllSkillAndEquipData(SharedCharData sharedData, EvolvePhaseAndLevel maxExolvePhaseAndLevel, bool isFriend = true)
		{
			return default(ModifiedSharedCharData);
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007580")]
		[Address(RVA = "0x2304DB0", Offset = "0x23039B0", VA = "0x182304DB0")]
		public static void ChangeSkillIndexInSharedChar(SharedCharData sharedCharData, int index)
		{
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007581")]
		[Address(RVA = "0x2309B40", Offset = "0x2308740", VA = "0x182309B40")]
		public static CharacterCardViewModel ConvertToCharacterCardViewModel(SharedCharData sharedCharacter, bool withPotential = false)
		{
			return null;
		}

		// Token: 0x06007582 RID: 30082 RVA: 0x00034B30 File Offset: 0x00032D30
		[Token(Token = "0x6007582")]
		[Address(RVA = "0x23115E0", Offset = "0x23101E0", VA = "0x1823115E0")]
		private static int _CalculateNerfFavorPoint(int originFavorPoint, EvolvePhase evolvePhase)
		{
			return 0;
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x00034B48 File Offset: 0x00032D48
		[Token(Token = "0x6007583")]
		[Address(RVA = "0x2311D90", Offset = "0x2310990", VA = "0x182311D90")]
		private static bool _CheckSkillAvalibale(CharacterData charData, int evolveState, int level, int skillIndex)
		{
			return default(bool);
		}

		// Token: 0x06007584 RID: 30084 RVA: 0x00034B60 File Offset: 0x00032D60
		[Token(Token = "0x6007584")]
		[Address(RVA = "0x2311C90", Offset = "0x2310890", VA = "0x182311C90")]
		private static bool _CheckSkillAllLevelAvaliable(CharacterData charData, int evolveState, int level, int allLevel)
		{
			return default(bool);
		}

		// Token: 0x06007585 RID: 30085 RVA: 0x00034B78 File Offset: 0x00032D78
		[Token(Token = "0x6007585")]
		[Address(RVA = "0x2311E80", Offset = "0x2310A80", VA = "0x182311E80")]
		private static bool _CheckSkillSpecializeLevelAvaliable(CharacterData charData, int evolveState, int level, int skillIndex, int skillSpecialLevel)
		{
			return default(bool);
		}

		// Token: 0x06007586 RID: 30086 RVA: 0x00034B90 File Offset: 0x00032D90
		[Token(Token = "0x6007586")]
		[Address(RVA = "0x230BD20", Offset = "0x230A920", VA = "0x18230BD20")]
		public static CharQuery GetClampedTmplIdByEvolvePhase(string charId, EvolvePhase evolvePhase)
		{
			return default(CharQuery);
		}

		// Token: 0x06007587 RID: 30087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007587")]
		[Address(RVA = "0x2315890", Offset = "0x2314490", VA = "0x182315890")]
		private static void _LoadCharUniEquipDesc(CharacterData charData, EvolvePhase evolvePhase, int level, int potentialRank, UniEquipData data, int equipLevel, bool isToken, out string basicText, out string overrideText, out bool isOverride)
		{
		}

		// Token: 0x06007588 RID: 30088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007588")]
		[Address(RVA = "0x230F870", Offset = "0x230E470", VA = "0x18230F870")]
		public static void LoadCharUniEquipDesc(CharacterData charData, EvolvePhase evolvePhase, int level, int potentialRank, UniEquipData data, int equipLevel, bool isToken, out string basicText, out string overrideText, out bool isOverride)
		{
		}

		// Token: 0x06007589 RID: 30089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007589")]
		[Address(RVA = "0x230F9D0", Offset = "0x230E5D0", VA = "0x18230F9D0")]
		public static void LoadCharUniEquipDesc(CharacterData charData, PlayerCharacter charInfo, UniEquipData data, int equipLevel, out string basicText, out string overrideText, out bool isOverride)
		{
		}

		// Token: 0x0600758A RID: 30090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600758A")]
		[Address(RVA = "0x230F720", Offset = "0x230E320", VA = "0x18230F720")]
		public static void LoadCharUniEquipDesc(CharacterData charData, EvolvePhase evolvePhase, int level, int potentialRank, UniEquipData data, int equipLevel, out string basicText, out string overrideText, out bool isOverride)
		{
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600758B")]
		[Address(RVA = "0x230ACA0", Offset = "0x23098A0", VA = "0x18230ACA0")]
		public static List<CharacterTalentViewModel> GeneCharTalentViewModelWithEquip(CharacterData charData, EvolvePhase evolvePhase, int level, int potentialRank, string equipId, int equipLevel)
		{
			return null;
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x00034BA8 File Offset: 0x00032DA8
		[Token(Token = "0x600758C")]
		[Address(RVA = "0x23074A0", Offset = "0x23060A0", VA = "0x1823074A0")]
		public static bool CheckIfCharTalentHideOnUI(TalentData talentData)
		{
			return default(bool);
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x00034BC0 File Offset: 0x00032DC0
		[Token(Token = "0x600758D")]
		[Address(RVA = "0x2307420", Offset = "0x2306020", VA = "0x182307420")]
		public static bool CheckIfCharSpecialOperator(CharacterData charData)
		{
			return default(bool);
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x00034BD8 File Offset: 0x00032DD8
		[Token(Token = "0x600758E")]
		[Address(RVA = "0x2307090", Offset = "0x2305C90", VA = "0x182307090")]
		public static bool CheckIfBattleMaster(string masterId)
		{
			return default(bool);
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600758F")]
		[Address(RVA = "0x2309DC0", Offset = "0x23089C0", VA = "0x182309DC0")]
		public static CharacterData.MasterInfo[] CreateMasterInfosFromMasterDict(Dictionary<string, int> masterDict)
		{
			return null;
		}

		// Token: 0x04007212 RID: 29202
		[Token(Token = "0x4007212")]
		private const int MAX_FAVOR_BATTLE_PHASE_FOR_ZERO_EVOLVE_PHASE = 25;

		// Token: 0x04007213 RID: 29203
		[Token(Token = "0x4007213")]
		private const string UI_LOCAL_CACHE_CHAR_SELECT_CUSTOM_SORT_TYPE_KEY = "select";

		// Token: 0x04007214 RID: 29204
		[Token(Token = "0x4007214")]
		private const string UI_LOCAL_CACHE_CHAR_REPO_CUSTOM_SORT_TYPE_KEY = "repo";

		// Token: 0x04007215 RID: 29205
		[Token(Token = "0x4007215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Func<IComparableChar, IComparableChar, int>[] COMPARE_PRIORITY;

		// Token: 0x04007216 RID: 29206
		[Token(Token = "0x4007216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly ListDict<CharacterSortType, Comparison<IComparableChar>> CHAR_COMPARISONS;

		// Token: 0x04007217 RID: 29207
		[Token(Token = "0x4007217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly Dictionary<CharacterSortType, CharacterSortTypePair> CUSTOM_CHAR_SORT_TYPE_DICT;

		// Token: 0x04007218 RID: 29208
		[Token(Token = "0x4007218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly List<CharacterSortTypePair> CUSTOM_CHAR_SORT_TYPE_LIST;

		// Token: 0x04007219 RID: 29209
		[Token(Token = "0x4007219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetHighestSelectableUISkin;

		// Token: 0x0400721A RID: 29210
		[Token(Token = "0x400721A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadCharUISkinState;

		// Token: 0x0400721B RID: 29211
		[Token(Token = "0x400721B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsPlayerCharShowSpIllust;

		// Token: 0x0400721C RID: 29212
		[Token(Token = "0x400721C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadCharAvatarBySkin;

		// Token: 0x0400721D RID: 29213
		[Token(Token = "0x400721D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetMaxEvolvePhase;

		// Token: 0x0400721E RID: 29214
		[Token(Token = "0x400721E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetCharName;

		// Token: 0x0400721F RID: 29215
		[Token(Token = "0x400721F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_GetCharProfession;

		// Token: 0x04007220 RID: 29216
		[Token(Token = "0x4007220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_TryGetCharName;

		// Token: 0x04007221 RID: 29217
		[Token(Token = "0x4007221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_TryGetCharData;

		// Token: 0x04007222 RID: 29218
		[Token(Token = "0x4007222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCharDataOrNull;

		// Token: 0x04007223 RID: 29219
		[Token(Token = "0x4007223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetDefaultCharTmpl;

		// Token: 0x04007224 RID: 29220
		[Token(Token = "0x4007224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckSkinTmplMatch;

		// Token: 0x04007225 RID: 29221
		[Token(Token = "0x4007225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CheckSkinTmplAvail;

		// Token: 0x04007226 RID: 29222
		[Token(Token = "0x4007226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_VerifySkin;

		// Token: 0x04007227 RID: 29223
		[Token(Token = "0x4007227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_EditorTryGetCharData;

		// Token: 0x04007228 RID: 29224
		[Token(Token = "0x4007228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GetCharAppellation;

		// Token: 0x04007229 RID: 29225
		[Token(Token = "0x4007229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_CheckUnlimitSkinBuyInLimitTime;

		// Token: 0x0400722A RID: 29226
		[Token(Token = "0x400722A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CheckSkinAvailable;

		// Token: 0x0400722B RID: 29227
		[Token(Token = "0x400722B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetPortraitSprite;

		// Token: 0x0400722C RID: 29228
		[Token(Token = "0x400722C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_GetSkillIdByIndex;

		// Token: 0x0400722D RID: 29229
		[Token(Token = "0x400722D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_TryLoadMaxMasterLevelInfo;

		// Token: 0x0400722E RID: 29230
		[Token(Token = "0x400722E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_GetSkillIdByIndexInPlayerData;

		// Token: 0x0400722F RID: 29231
		[Token(Token = "0x400722F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_FindSkillIndexByIdInPlayerData;

		// Token: 0x04007230 RID: 29232
		[Token(Token = "0x4007230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix1_FindSkillIndexByIdInPlayerData;

		// Token: 0x04007231 RID: 29233
		[Token(Token = "0x4007231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_CheckIfSpecMaxChar;

		// Token: 0x04007232 RID: 29234
		[Token(Token = "0x4007232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix1_CheckIfSpecMaxChar;

		// Token: 0x04007233 RID: 29235
		[Token(Token = "0x4007233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix2_CheckIfSpecMaxChar;

		// Token: 0x04007234 RID: 29236
		[Token(Token = "0x4007234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix3_CheckIfSpecMaxChar;

		// Token: 0x04007235 RID: 29237
		[Token(Token = "0x4007235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_FindEquipIdByIdInPlayerData;

		// Token: 0x04007236 RID: 29238
		[Token(Token = "0x4007236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix1_FindEquipIdByIdInPlayerData;

		// Token: 0x04007237 RID: 29239
		[Token(Token = "0x4007237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_FindSkillIndexById;

		// Token: 0x04007238 RID: 29240
		[Token(Token = "0x4007238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CheckIfCharSkillAvailable;

		// Token: 0x04007239 RID: 29241
		[Token(Token = "0x4007239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_CheckIfCharSkillHideOnUI;

		// Token: 0x0400723A RID: 29242
		[Token(Token = "0x400723A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_CheckIfCharUniEquipAvailable;

		// Token: 0x0400723B RID: 29243
		[Token(Token = "0x400723B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix1_GetPortraitSprite;

		// Token: 0x0400723C RID: 29244
		[Token(Token = "0x400723C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetPortraitSpriteBySkin;

		// Token: 0x0400723D RID: 29245
		[Token(Token = "0x400723D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_LoadCharAvatar;

		// Token: 0x0400723E RID: 29246
		[Token(Token = "0x400723E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_LoadCharPortrait;

		// Token: 0x0400723F RID: 29247
		[Token(Token = "0x400723F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix1_LoadCharPortrait;

		// Token: 0x04007240 RID: 29248
		[Token(Token = "0x4007240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_LoadShopSkinPortrait;

		// Token: 0x04007241 RID: 29249
		[Token(Token = "0x4007241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_LoadProfessionTextHub;

		// Token: 0x04007242 RID: 29250
		[Token(Token = "0x4007242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_GenCustomSortTypeCacheKeyByPageName;

		// Token: 0x04007243 RID: 29251
		[Token(Token = "0x4007243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_SortCharList;

		// Token: 0x04007244 RID: 29252
		[Token(Token = "0x4007244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_GetCharComparison;

		// Token: 0x04007245 RID: 29253
		[Token(Token = "0x4007245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_SortEvolveCharList;

		// Token: 0x04007246 RID: 29254
		[Token(Token = "0x4007246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_SortLevelMaxCharList;

		// Token: 0x04007247 RID: 29255
		[Token(Token = "0x4007247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_SortSkillMaxCharList;

		// Token: 0x04007248 RID: 29256
		[Token(Token = "0x4007248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__CompareByChain;

		// Token: 0x04007249 RID: 29257
		[Token(Token = "0x4007249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_GetCustomCharSortTypePair;

		// Token: 0x0400724A RID: 29258
		[Token(Token = "0x400724A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_GetCustomCharSortTypeList;

		// Token: 0x0400724B RID: 29259
		[Token(Token = "0x400724B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__CompareByLevelUp;

		// Token: 0x0400724C RID: 29260
		[Token(Token = "0x400724C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__CompareByLevelDown;

		// Token: 0x0400724D RID: 29261
		[Token(Token = "0x400724D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__CompareByNameUp;

		// Token: 0x0400724E RID: 29262
		[Token(Token = "0x400724E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__CompareByNameDown;

		// Token: 0x0400724F RID: 29263
		[Token(Token = "0x400724F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__CompareByGainTimeUp;

		// Token: 0x04007250 RID: 29264
		[Token(Token = "0x4007250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__CompareByGainTimeDown;

		// Token: 0x04007251 RID: 29265
		[Token(Token = "0x4007251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__CompareByFavorUp;

		// Token: 0x04007252 RID: 29266
		[Token(Token = "0x4007252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__CompareByFavorDown;

		// Token: 0x04007253 RID: 29267
		[Token(Token = "0x4007253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__CompareByRarityUp;

		// Token: 0x04007254 RID: 29268
		[Token(Token = "0x4007254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__CompareByRarityDown;

		// Token: 0x04007255 RID: 29269
		[Token(Token = "0x4007255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__CompareByCostUp;

		// Token: 0x04007256 RID: 29270
		[Token(Token = "0x4007256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__CompareByCostDown;

		// Token: 0x04007257 RID: 29271
		[Token(Token = "0x4007257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0__CompareByHpUp;

		// Token: 0x04007258 RID: 29272
		[Token(Token = "0x4007258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0__CompareByHpDown;

		// Token: 0x04007259 RID: 29273
		[Token(Token = "0x4007259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__CompareByAtkUp;

		// Token: 0x0400725A RID: 29274
		[Token(Token = "0x400725A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__CompareByAtkDown;

		// Token: 0x0400725B RID: 29275
		[Token(Token = "0x400725B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__CompareByDefUp;

		// Token: 0x0400725C RID: 29276
		[Token(Token = "0x400725C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0__CompareByDefDown;

		// Token: 0x0400725D RID: 29277
		[Token(Token = "0x400725D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0__CompareByResUp;

		// Token: 0x0400725E RID: 29278
		[Token(Token = "0x400725E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__CompareByResDown;

		// Token: 0x0400725F RID: 29279
		[Token(Token = "0x400725F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0__CompareByRespawnUp;

		// Token: 0x04007260 RID: 29280
		[Token(Token = "0x4007260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0__CompareByRespawnDown;

		// Token: 0x04007261 RID: 29281
		[Token(Token = "0x4007261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0__CompareByBlockNumUp;

		// Token: 0x04007262 RID: 29282
		[Token(Token = "0x4007262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0__CompareByBlockNumDown;

		// Token: 0x04007263 RID: 29283
		[Token(Token = "0x4007263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0__CompareByAtkSpeedUp;

		// Token: 0x04007264 RID: 29284
		[Token(Token = "0x4007264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0__CompareByAtkSpeedDown;

		// Token: 0x04007265 RID: 29285
		[Token(Token = "0x4007265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__CompareByChainDefault;

		// Token: 0x04007266 RID: 29286
		[Token(Token = "0x4007266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_GetProfessionPerioty;

		// Token: 0x04007267 RID: 29287
		[Token(Token = "0x4007267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0__CompLevel;

		// Token: 0x04007268 RID: 29288
		[Token(Token = "0x4007268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0__CompName;

		// Token: 0x04007269 RID: 29289
		[Token(Token = "0x4007269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0__CompGainTime;

		// Token: 0x0400726A RID: 29290
		[Token(Token = "0x400726A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0__CompareFavor;

		// Token: 0x0400726B RID: 29291
		[Token(Token = "0x400726B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0__CompRarity;

		// Token: 0x0400726C RID: 29292
		[Token(Token = "0x400726C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0__CompCost;

		// Token: 0x0400726D RID: 29293
		[Token(Token = "0x400726D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0__CompHp;

		// Token: 0x0400726E RID: 29294
		[Token(Token = "0x400726E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0__CompAtk;

		// Token: 0x0400726F RID: 29295
		[Token(Token = "0x400726F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0__CompDef;

		// Token: 0x04007270 RID: 29296
		[Token(Token = "0x4007270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0__CompRes;

		// Token: 0x04007271 RID: 29297
		[Token(Token = "0x4007271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0__CompProfession;

		// Token: 0x04007272 RID: 29298
		[Token(Token = "0x4007272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0__CompRespawnTime;

		// Token: 0x04007273 RID: 29299
		[Token(Token = "0x4007273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0__CompBlockNum;

		// Token: 0x04007274 RID: 29300
		[Token(Token = "0x4007274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0__CompAtkSpeed;

		// Token: 0x04007275 RID: 29301
		[Token(Token = "0x4007275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0__CompByChainDefault;

		// Token: 0x04007276 RID: 29302
		[Token(Token = "0x4007276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_CalcCharacterFavorPercent;

		// Token: 0x04007277 RID: 29303
		[Token(Token = "0x4007277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_GetPlayerInstByCharId;

		// Token: 0x04007278 RID: 29304
		[Token(Token = "0x4007278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_CheckPlayerCharAvailable;

		// Token: 0x04007279 RID: 29305
		[Token(Token = "0x4007279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_GetPlayerTmplByCharId;

		// Token: 0x0400727A RID: 29306
		[Token(Token = "0x400727A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_IsStandardCharacter;

		// Token: 0x0400727B RID: 29307
		[Token(Token = "0x400727B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_IsHandbookLimitChar;

		// Token: 0x0400727C RID: 29308
		[Token(Token = "0x400727C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_IsNotObtainableChar;

		// Token: 0x0400727D RID: 29309
		[Token(Token = "0x400727D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_AchieveDefaultSkillId;

		// Token: 0x0400727E RID: 29310
		[Token(Token = "0x400727E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_InstCharSelectSkillGroupViewModel;

		// Token: 0x0400727F RID: 29311
		[Token(Token = "0x400727F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_InstCharSelectSkillGroupViewModelByCharacterCardViewModel;

		// Token: 0x04007280 RID: 29312
		[Token(Token = "0x4007280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0__InternalInstCharSelectSkillGroupViewModel;

		// Token: 0x04007281 RID: 29313
		[Token(Token = "0x4007281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_IsEquipTmplMatch;

		// Token: 0x04007282 RID: 29314
		[Token(Token = "0x4007282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_InstCharSelectBranchGroupViewModel;

		// Token: 0x04007283 RID: 29315
		[Token(Token = "0x4007283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_InstCharSelectBranchViewModelByCharacterCardViewModel;

		// Token: 0x04007284 RID: 29316
		[Token(Token = "0x4007284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0__InternalInstCharSelectBranchViewModel;

		// Token: 0x04007285 RID: 29317
		[Token(Token = "0x4007285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_AchieveDefaultEquipId;

		// Token: 0x04007286 RID: 29318
		[Token(Token = "0x4007286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_CheckIfCharUpdatedInHandBook;

		// Token: 0x04007287 RID: 29319
		[Token(Token = "0x4007287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_CheckIfCharTrackPointInHandBook;

		// Token: 0x04007288 RID: 29320
		[Token(Token = "0x4007288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_CheckAvailCharHaveSkillToTrain;

		// Token: 0x04007289 RID: 29321
		[Token(Token = "0x4007289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_TryTriggerSkillRelatedStory;

		// Token: 0x0400728A RID: 29322
		[Token(Token = "0x400728A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_TryTriggerCharRelatedStory;

		// Token: 0x0400728B RID: 29323
		[Token(Token = "0x400728B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_TryTriggerEquipRelatedStory;

		// Token: 0x0400728C RID: 29324
		[Token(Token = "0x400728C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_CheckAvailCharHaveUniEquip;

		// Token: 0x0400728D RID: 29325
		[Token(Token = "0x400728D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_CheckAvailCharHaveUniEquipToLvlup;

		// Token: 0x0400728E RID: 29326
		[Token(Token = "0x400728E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_CheckCharHaveUniEquipFirstVisit;

		// Token: 0x0400728F RID: 29327
		[Token(Token = "0x400728F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0__CheckIfTrackPointInHandBookStory;

		// Token: 0x04007290 RID: 29328
		[Token(Token = "0x4007290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_IsCharLvlAndEliteFull;

		// Token: 0x04007291 RID: 29329
		[Token(Token = "0x4007291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_CheckIfTrackPointInHandBookStage;

		// Token: 0x04007292 RID: 29330
		[Token(Token = "0x4007292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_GetCharacterHandbookStageStatus;

		// Token: 0x04007293 RID: 29331
		[Token(Token = "0x4007293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0__CheckHandBookStageUnlocked;

		// Token: 0x04007294 RID: 29332
		[Token(Token = "0x4007294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0__CheckHandBookStagePass;

		// Token: 0x04007295 RID: 29333
		[Token(Token = "0x4007295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0__GetCharSpecializedLevelSum;

		// Token: 0x04007296 RID: 29334
		[Token(Token = "0x4007296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_CheckIfTrackPointInHandBookNewVoice;

		// Token: 0x04007297 RID: 29335
		[Token(Token = "0x4007297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_CheckIfPontialImprovable;

		// Token: 0x04007298 RID: 29336
		[Token(Token = "0x4007298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_CheckIfSpecializedSkillCanImprove;

		// Token: 0x04007299 RID: 29337
		[Token(Token = "0x4007299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix1_CheckIfSpecializedSkillCanImprove;

		// Token: 0x0400729A RID: 29338
		[Token(Token = "0x400729A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_CheckIfTmplUpdated;

		// Token: 0x0400729B RID: 29339
		[Token(Token = "0x400729B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_TryGetTrait;

		// Token: 0x0400729C RID: 29340
		[Token(Token = "0x400729C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private static DelegateBridge __Hotfix0_IsMutuallyExclusiveChar;

		// Token: 0x0400729D RID: 29341
		[Token(Token = "0x400729D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private static DelegateBridge __Hotfix1_IsMutuallyExclusiveChar;

		// Token: 0x0400729E RID: 29342
		[Token(Token = "0x400729E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		private static DelegateBridge __Hotfix0_LoadMutuallyExclusiveCharInstIds;

		// Token: 0x0400729F RID: 29343
		[Token(Token = "0x400729F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		private static DelegateBridge __Hotfix0_HasNewCharTag;

		// Token: 0x040072A0 RID: 29344
		[Token(Token = "0x40072A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		private static DelegateBridge __Hotfix0_LogNewCharAchieved;

		// Token: 0x040072A1 RID: 29345
		[Token(Token = "0x40072A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		private static DelegateBridge __Hotfix1_LogNewCharAchieved;

		// Token: 0x040072A2 RID: 29346
		[Token(Token = "0x40072A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		private static DelegateBridge __Hotfix2_LogNewCharAchieved;

		// Token: 0x040072A3 RID: 29347
		[Token(Token = "0x40072A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private static DelegateBridge __Hotfix0_HasNewSpCharMission;

		// Token: 0x040072A4 RID: 29348
		[Token(Token = "0x40072A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		private static DelegateBridge __Hotfix0__TryLogSpCharMissionNew;

		// Token: 0x040072A5 RID: 29349
		[Token(Token = "0x40072A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		private static DelegateBridge __Hotfix0_HasUnconfirmedSpCharMissionReward;

		// Token: 0x040072A6 RID: 29350
		[Token(Token = "0x40072A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		private static DelegateBridge __Hotfix0_CheckIfSpCharMissionUnlocked;

		// Token: 0x040072A7 RID: 29351
		[Token(Token = "0x40072A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		private static DelegateBridge __Hotfix0_CheckIfSpCharMissionAllComplete;

		// Token: 0x040072A8 RID: 29352
		[Token(Token = "0x40072A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		private static DelegateBridge __Hotfix0_CheckData;

		// Token: 0x040072A9 RID: 29353
		[Token(Token = "0x40072A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		private static DelegateBridge __Hotfix0__ModifyAttrLimitedCharDataImpl;

		// Token: 0x040072AA RID: 29354
		[Token(Token = "0x40072AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private static DelegateBridge __Hotfix0_CheckAllSkillAndEquipData;

		// Token: 0x040072AB RID: 29355
		[Token(Token = "0x40072AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		private static DelegateBridge __Hotfix0_ChangeSkillIndexInSharedChar;

		// Token: 0x040072AC RID: 29356
		[Token(Token = "0x40072AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		private static DelegateBridge __Hotfix0_ConvertToCharacterCardViewModel;

		// Token: 0x040072AD RID: 29357
		[Token(Token = "0x40072AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		private static DelegateBridge __Hotfix0__CalculateNerfFavorPoint;

		// Token: 0x040072AE RID: 29358
		[Token(Token = "0x40072AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		private static DelegateBridge __Hotfix0__CheckSkillAvalibale;

		// Token: 0x040072AF RID: 29359
		[Token(Token = "0x40072AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		private static DelegateBridge __Hotfix0__CheckSkillAllLevelAvaliable;

		// Token: 0x040072B0 RID: 29360
		[Token(Token = "0x40072B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		private static DelegateBridge __Hotfix0__CheckSkillSpecializeLevelAvaliable;

		// Token: 0x040072B1 RID: 29361
		[Token(Token = "0x40072B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		private static DelegateBridge __Hotfix0_GetClampedTmplIdByEvolvePhase;

		// Token: 0x040072B2 RID: 29362
		[Token(Token = "0x40072B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		private static DelegateBridge __Hotfix0__LoadCharUniEquipDesc;

		// Token: 0x040072B3 RID: 29363
		[Token(Token = "0x40072B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		private static DelegateBridge __Hotfix0_LoadCharUniEquipDesc;

		// Token: 0x040072B4 RID: 29364
		[Token(Token = "0x40072B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		private static DelegateBridge __Hotfix1_LoadCharUniEquipDesc;

		// Token: 0x040072B5 RID: 29365
		[Token(Token = "0x40072B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		private static DelegateBridge __Hotfix2_LoadCharUniEquipDesc;

		// Token: 0x040072B6 RID: 29366
		[Token(Token = "0x40072B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		private static DelegateBridge __Hotfix0_GeneCharTalentViewModelWithEquip;

		// Token: 0x040072B7 RID: 29367
		[Token(Token = "0x40072B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		private static DelegateBridge __Hotfix0_CheckIfCharTalentHideOnUI;

		// Token: 0x040072B8 RID: 29368
		[Token(Token = "0x40072B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		private static DelegateBridge __Hotfix0_CheckIfCharSpecialOperator;

		// Token: 0x040072B9 RID: 29369
		[Token(Token = "0x40072B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		private static DelegateBridge __Hotfix0_CheckIfBattleMaster;

		// Token: 0x040072BA RID: 29370
		[Token(Token = "0x40072BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
		private static DelegateBridge __Hotfix0_CreateMasterInfosFromMasterDict;
	}
}
