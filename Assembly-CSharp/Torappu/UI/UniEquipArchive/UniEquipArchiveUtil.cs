using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BE2 RID: 15330
	[Token(Token = "0x2003BE2")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class UniEquipArchiveUtil
	{
		// Token: 0x06017FC9 RID: 98249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017FC9")]
		[Address(RVA = "0x1067FA0", Offset = "0x1066BA0", VA = "0x181067FA0")]
		public static Sprite LoadRarityIcon(RarityRank rarity, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06017FCA RID: 98250 RVA: 0x00098CE8 File Offset: 0x00096EE8
		[Token(Token = "0x6017FCA")]
		[Address(RVA = "0x1067980", Offset = "0x1066580", VA = "0x181067980")]
		public static bool CheckIfUniEquipMissionsComplete(List<string> missionList)
		{
			return default(bool);
		}

		// Token: 0x06017FCB RID: 98251 RVA: 0x00098D00 File Offset: 0x00096F00
		[Token(Token = "0x6017FCB")]
		[Address(RVA = "0x1067870", Offset = "0x1066470", VA = "0x181067870")]
		public static bool CheckIfUniEquipMissionComplete(string missionId)
		{
			return default(bool);
		}

		// Token: 0x06017FCC RID: 98252 RVA: 0x00098D18 File Offset: 0x00096F18
		[Token(Token = "0x6017FCC")]
		[Address(RVA = "0x1067C90", Offset = "0x1066890", VA = "0x181067C90")]
		public static bool CheckUniEquipUnlockIfAllRequireIsSatisfied(UniEquipData uniEquipData, PlayerCharacter playerChar)
		{
			return default(bool);
		}

		// Token: 0x06017FCD RID: 98253 RVA: 0x00098D30 File Offset: 0x00096F30
		[Token(Token = "0x6017FCD")]
		[Address(RVA = "0x1067B10", Offset = "0x1066710", VA = "0x181067B10")]
		public static bool CheckUniEquipLevelUpIfAllRequireIsSatisfied(UniEquipData uniEquipData, PlayerCharacter playerChar, int fromLevel, int targetLevel)
		{
			return default(bool);
		}

		// Token: 0x06017FCE RID: 98254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017FCE")]
		[Address(RVA = "0x1067DE0", Offset = "0x10669E0", VA = "0x181067DE0")]
		public static string GetInfoNameByType(UniEquipArchiveCollectionInfoType type)
		{
			return null;
		}

		// Token: 0x06017FCF RID: 98255 RVA: 0x00098D48 File Offset: 0x00096F48
		[Token(Token = "0x6017FCF")]
		[Address(RVA = "0x1068080", Offset = "0x1066C80", VA = "0x181068080")]
		public static bool PassEquipShowInArchivePreCheck(UniEquipData equipData)
		{
			return default(bool);
		}

		// Token: 0x06017FD0 RID: 98256 RVA: 0x00098D60 File Offset: 0x00096F60
		[Token(Token = "0x6017FD0")]
		[Address(RVA = "0x10681D0", Offset = "0x1066DD0", VA = "0x1810681D0")]
		public static bool PassEquipShowInArchivePreCheck(UniEquipType type, string charId)
		{
			return default(bool);
		}

		// Token: 0x06017FD1 RID: 98257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017FD1")]
		[Address(RVA = "0x1067EF0", Offset = "0x1066AF0", VA = "0x181067EF0")]
		public static Comparison<UniEquipArchiveModuleItemBaseViewModel> GetUniEquipComparison(UniEquipSortType sortType)
		{
			return null;
		}

		// Token: 0x06017FD2 RID: 98258 RVA: 0x00098D78 File Offset: 0x00096F78
		[Token(Token = "0x6017FD2")]
		[Address(RVA = "0x1068F70", Offset = "0x1067B70", VA = "0x181068F70")]
		private static int _CompareByLevelUp(UniEquipArchiveModuleItemBaseViewModel x, UniEquipArchiveModuleItemBaseViewModel y)
		{
			return 0;
		}

		// Token: 0x06017FD3 RID: 98259 RVA: 0x00098D90 File Offset: 0x00096F90
		[Token(Token = "0x6017FD3")]
		[Address(RVA = "0x1068E50", Offset = "0x1067A50", VA = "0x181068E50")]
		private static int _CompareByLevelDown(UniEquipArchiveModuleItemBaseViewModel x, UniEquipArchiveModuleItemBaseViewModel y)
		{
			return 0;
		}

		// Token: 0x06017FD4 RID: 98260 RVA: 0x00098DA8 File Offset: 0x00096FA8
		[Token(Token = "0x6017FD4")]
		[Address(RVA = "0x10691B0", Offset = "0x1067DB0", VA = "0x1810691B0")]
		private static int _CompareByUpdateTimeUp(UniEquipArchiveModuleItemBaseViewModel x, UniEquipArchiveModuleItemBaseViewModel y)
		{
			return 0;
		}

		// Token: 0x06017FD5 RID: 98261 RVA: 0x00098DC0 File Offset: 0x00096FC0
		[Token(Token = "0x6017FD5")]
		[Address(RVA = "0x1069090", Offset = "0x1067C90", VA = "0x181069090")]
		private static int _CompareByUpdateTimeDown(UniEquipArchiveModuleItemBaseViewModel x, UniEquipArchiveModuleItemBaseViewModel y)
		{
			return 0;
		}

		// Token: 0x06017FD6 RID: 98262 RVA: 0x00098DD8 File Offset: 0x00096FD8
		[Token(Token = "0x6017FD6")]
		[Address(RVA = "0x1068B20", Offset = "0x1067720", VA = "0x181068B20")]
		private static int _CompUnlockState(UniEquipArchiveModuleItemBaseViewModel a, UniEquipArchiveModuleItemBaseViewModel b)
		{
			return 0;
		}

		// Token: 0x06017FD7 RID: 98263 RVA: 0x00098DF0 File Offset: 0x00096FF0
		[Token(Token = "0x6017FD7")]
		[Address(RVA = "0x10689B0", Offset = "0x10675B0", VA = "0x1810689B0")]
		private static int _CompUnlockStateWithSinkNotPhase2(UniEquipArchiveModuleItemBaseViewModel a, UniEquipArchiveModuleItemBaseViewModel b)
		{
			return 0;
		}

		// Token: 0x06017FD8 RID: 98264 RVA: 0x00098E08 File Offset: 0x00097008
		[Token(Token = "0x6017FD8")]
		[Address(RVA = "0x1068740", Offset = "0x1067340", VA = "0x181068740")]
		private static int _CompLevelWithoutLockState(UniEquipArchiveModuleItemBaseViewModel a, UniEquipArchiveModuleItemBaseViewModel b)
		{
			return 0;
		}

		// Token: 0x06017FD9 RID: 98265 RVA: 0x00098E20 File Offset: 0x00097020
		[Token(Token = "0x6017FD9")]
		[Address(RVA = "0x1068830", Offset = "0x1067430", VA = "0x181068830")]
		private static int _CompLevel(UniEquipArchiveModuleItemBaseViewModel a, UniEquipArchiveModuleItemBaseViewModel b)
		{
			return 0;
		}

		// Token: 0x06017FDA RID: 98266 RVA: 0x00098E38 File Offset: 0x00097038
		[Token(Token = "0x6017FDA")]
		[Address(RVA = "0x1068C20", Offset = "0x1067820", VA = "0x181068C20")]
		private static int _CompUpdateTime(UniEquipArchiveModuleItemBaseViewModel a, UniEquipArchiveModuleItemBaseViewModel b)
		{
			return 0;
		}

		// Token: 0x06017FDB RID: 98267 RVA: 0x00098E50 File Offset: 0x00097050
		[Token(Token = "0x6017FDB")]
		[Address(RVA = "0x10688F0", Offset = "0x10674F0", VA = "0x1810688F0")]
		private static int _CompType(UniEquipArchiveModuleItemBaseViewModel a, UniEquipArchiveModuleItemBaseViewModel b)
		{
			return 0;
		}

		// Token: 0x06017FDC RID: 98268 RVA: 0x00098E68 File Offset: 0x00097068
		[Token(Token = "0x6017FDC")]
		[Address(RVA = "0x1068680", Offset = "0x1067280", VA = "0x181068680")]
		private static int _CompId(UniEquipArchiveModuleItemBaseViewModel a, UniEquipArchiveModuleItemBaseViewModel b)
		{
			return 0;
		}

		// Token: 0x06017FDD RID: 98269 RVA: 0x00098E80 File Offset: 0x00097080
		[Token(Token = "0x6017FDD")]
		[Address(RVA = "0x1068CE0", Offset = "0x10678E0", VA = "0x181068CE0")]
		private static int _CompareByChain(UniEquipArchiveModuleItemBaseViewModel a, UniEquipArchiveModuleItemBaseViewModel b, Func<UniEquipArchiveModuleItemBaseViewModel, UniEquipArchiveModuleItemBaseViewModel, int> targetComp, bool isInverse, Func<UniEquipArchiveModuleItemBaseViewModel, UniEquipArchiveModuleItemBaseViewModel, int>[] compFunc)
		{
			return 0;
		}

		// Token: 0x06017FDE RID: 98270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FDE")]
		[Address(RVA = "0x10684F0", Offset = "0x10670F0", VA = "0x1810684F0")]
		public static void TryOpenUniEquipInfoPage(int charInstId, string uniEquipId, bool isTmpl, bool isCurrentTmpl)
		{
		}

		// Token: 0x06017FDF RID: 98271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FDF")]
		[Address(RVA = "0x1068290", Offset = "0x1066E90", VA = "0x181068290")]
		public static void TryOpenCharacterInfoPage(int charInstId)
		{
		}

		// Token: 0x06017FE0 RID: 98272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017FE0")]
		[Address(RVA = "0x10683B0", Offset = "0x1066FB0", VA = "0x1810683B0")]
		public static void TryOpenCharacterShowPage(string charId)
		{
		}

		// Token: 0x0401D0B1 RID: 118961
		[Token(Token = "0x401D0B1")]
		public const string UNIEQUIP_ARCHIVE_ENTRY_TIME_TRACK_ID = "uni_equip_archive_entry";

		// Token: 0x0401D0B2 RID: 118962
		[Token(Token = "0x401D0B2")]
		public const string UNIEQUIP_ARCHIVE_SYS_TRACK = "uni_equip_archive_sys";

		// Token: 0x0401D0B3 RID: 118963
		[Token(Token = "0x401D0B3")]
		private const string RARITY_ICON_FORMAT = "rarity_{0}";

		// Token: 0x0401D0B4 RID: 118964
		[Token(Token = "0x401D0B4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ListDict<UniEquipSortType, Comparison<UniEquipArchiveModuleItemBaseViewModel>> UNIEQUIP_COMPARISONS;

		// Token: 0x0401D0B5 RID: 118965
		[Token(Token = "0x401D0B5")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Func<UniEquipArchiveModuleItemBaseViewModel, UniEquipArchiveModuleItemBaseViewModel, int>[] COMPARE_PRIORITY_COMMON;

		// Token: 0x0401D0B6 RID: 118966
		[Token(Token = "0x401D0B6")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Func<UniEquipArchiveModuleItemBaseViewModel, UniEquipArchiveModuleItemBaseViewModel, int>[] COMPARE_PRIORITY_FOR_LEVEL_SORT;

		// Token: 0x0401D0B7 RID: 118967
		[Token(Token = "0x401D0B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadRarityIcon;

		// Token: 0x0401D0B8 RID: 118968
		[Token(Token = "0x401D0B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIfUniEquipMissionsComplete;

		// Token: 0x0401D0B9 RID: 118969
		[Token(Token = "0x401D0B9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckIfUniEquipMissionComplete;

		// Token: 0x0401D0BA RID: 118970
		[Token(Token = "0x401D0BA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckUniEquipUnlockIfAllRequireIsSatisfied;

		// Token: 0x0401D0BB RID: 118971
		[Token(Token = "0x401D0BB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckUniEquipLevelUpIfAllRequireIsSatisfied;

		// Token: 0x0401D0BC RID: 118972
		[Token(Token = "0x401D0BC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetInfoNameByType;

		// Token: 0x0401D0BD RID: 118973
		[Token(Token = "0x401D0BD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_PassEquipShowInArchivePreCheck;

		// Token: 0x0401D0BE RID: 118974
		[Token(Token = "0x401D0BE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix1_PassEquipShowInArchivePreCheck;

		// Token: 0x0401D0BF RID: 118975
		[Token(Token = "0x401D0BF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetUniEquipComparison;

		// Token: 0x0401D0C0 RID: 118976
		[Token(Token = "0x401D0C0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CompareByLevelUp;

		// Token: 0x0401D0C1 RID: 118977
		[Token(Token = "0x401D0C1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CompareByLevelDown;

		// Token: 0x0401D0C2 RID: 118978
		[Token(Token = "0x401D0C2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CompareByUpdateTimeUp;

		// Token: 0x0401D0C3 RID: 118979
		[Token(Token = "0x401D0C3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CompareByUpdateTimeDown;

		// Token: 0x0401D0C4 RID: 118980
		[Token(Token = "0x401D0C4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CompUnlockState;

		// Token: 0x0401D0C5 RID: 118981
		[Token(Token = "0x401D0C5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CompUnlockStateWithSinkNotPhase2;

		// Token: 0x0401D0C6 RID: 118982
		[Token(Token = "0x401D0C6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__CompLevelWithoutLockState;

		// Token: 0x0401D0C7 RID: 118983
		[Token(Token = "0x401D0C7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CompLevel;

		// Token: 0x0401D0C8 RID: 118984
		[Token(Token = "0x401D0C8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__CompUpdateTime;

		// Token: 0x0401D0C9 RID: 118985
		[Token(Token = "0x401D0C9")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CompType;

		// Token: 0x0401D0CA RID: 118986
		[Token(Token = "0x401D0CA")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CompId;

		// Token: 0x0401D0CB RID: 118987
		[Token(Token = "0x401D0CB")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__CompareByChain;

		// Token: 0x0401D0CC RID: 118988
		[Token(Token = "0x401D0CC")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_TryOpenUniEquipInfoPage;

		// Token: 0x0401D0CD RID: 118989
		[Token(Token = "0x401D0CD")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_TryOpenCharacterInfoPage;

		// Token: 0x0401D0CE RID: 118990
		[Token(Token = "0x401D0CE")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_TryOpenCharacterShowPage;
	}
}
