using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E60 RID: 15968
	[Token(Token = "0x2003E60")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SpecialOperatorUtil
	{
		// Token: 0x06018D4E RID: 101710 RVA: 0x0009C198 File Offset: 0x0009A398
		[Token(Token = "0x6018D4E")]
		[Address(RVA = "0x117D180", Offset = "0x117BD80", VA = "0x18117D180")]
		public static bool CheckIfCharReachLv(string charId, EvolvePhase evolvePhase, int level)
		{
			return default(bool);
		}

		// Token: 0x06018D4F RID: 101711 RVA: 0x0009C1B0 File Offset: 0x0009A3B0
		[Token(Token = "0x6018D4F")]
		[Address(RVA = "0x117D920", Offset = "0x117C520", VA = "0x18117D920")]
		public static bool GetMasterUnlockPhase(string charId, string masterId, int level, out EvolvePhase unlockPhase)
		{
			return default(bool);
		}

		// Token: 0x06018D50 RID: 101712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D50")]
		[Address(RVA = "0x117F0E0", Offset = "0x117DCE0", VA = "0x18117F0E0")]
		public static SpecialOperatorModeData SearchModeData(SpecialOperatorTargetType type)
		{
			return null;
		}

		// Token: 0x06018D51 RID: 101713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D51")]
		[Address(RVA = "0x117DCA0", Offset = "0x117C8A0", VA = "0x18117DCA0")]
		public static PlayerSpecialOperatorNode GetSpNode(string charId, SpecialOperatorDetailNodeType nodeType, string nodeId)
		{
			return null;
		}

		// Token: 0x06018D52 RID: 101714 RVA: 0x0009C1C8 File Offset: 0x0009A3C8
		[Token(Token = "0x6018D52")]
		[Address(RVA = "0x117DB40", Offset = "0x117C740", VA = "0x18117DB40")]
		public static SpecialOperatorNodeStyleType GetNodeStyleType(string frontNodeId)
		{
			return SpecialOperatorNodeStyleType.NEW;
		}

		// Token: 0x06018D53 RID: 101715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D53")]
		[Address(RVA = "0x117DBB0", Offset = "0x117C7B0", VA = "0x18117DBB0")]
		public static string GetNodeUpgradeNoticeStr(int upgradeCount)
		{
			return null;
		}

		// Token: 0x06018D54 RID: 101716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D54")]
		[Address(RVA = "0x117D7B0", Offset = "0x117C3B0", VA = "0x18117D7B0")]
		public static string GetConditionDesc(SpecialOperatorConditionViewType viewType, string taskId, EvolvePhase evolvePhase)
		{
			return null;
		}

		// Token: 0x06018D55 RID: 101717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D55")]
		[Address(RVA = "0x117DDF0", Offset = "0x117C9F0", VA = "0x18117DDF0")]
		public static string GetSpecialOperatorTargetName(SpecialOperatorTargetType targetType, string targetId)
		{
			return null;
		}

		// Token: 0x06018D56 RID: 101718 RVA: 0x0009C1E0 File Offset: 0x0009A3E0
		[Token(Token = "0x6018D56")]
		[Address(RVA = "0x117E200", Offset = "0x117CE00", VA = "0x18117E200")]
		public static bool IsNodeTaskCompleted(string charId, string nodeId)
		{
			return default(bool);
		}

		// Token: 0x06018D57 RID: 101719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D57")]
		[Address(RVA = "0x117DEF0", Offset = "0x117CAF0", VA = "0x18117DEF0")]
		public static string GetSpecialOperatorTypeName(SpecialOperatorTargetType targetType)
		{
			return null;
		}

		// Token: 0x06018D58 RID: 101720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D58")]
		[Address(RVA = "0x117EFA0", Offset = "0x117DBA0", VA = "0x18117EFA0")]
		public static void RouteToTarget(SpecialOperatorTargetType targetType, string targetId, string charId)
		{
		}

		// Token: 0x06018D59 RID: 101721 RVA: 0x0009C1F8 File Offset: 0x0009A3F8
		[Token(Token = "0x6018D59")]
		[Address(RVA = "0x117EE90", Offset = "0x117DA90", VA = "0x18117EE90")]
		public static bool NeedInGameToast(SpecialOperatorTargetType targetType, string targetId)
		{
			return default(bool);
		}

		// Token: 0x06018D5A RID: 101722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D5A")]
		[Address(RVA = "0x117D700", Offset = "0x117C300", VA = "0x18117D700")]
		public static Sprite GetBoardBgSprite(string bgId, ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x06018D5B RID: 101723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D5B")]
		[Address(RVA = "0x117E050", Offset = "0x117CC50", VA = "0x18117E050")]
		public static Sprite GetTargetTypeIconSprite(string iconId, bool isTiny, ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x06018D5C RID: 101724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D5C")]
		[Address(RVA = "0x117E150", Offset = "0x117CD50", VA = "0x18117E150")]
		public static Sprite GetTargetTypeMissionBackSprite(string iconId, ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x06018D5D RID: 101725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D5D")]
		[Address(RVA = "0x117DFA0", Offset = "0x117CBA0", VA = "0x18117DFA0")]
		public static Sprite GetTargetIdIconSprite(string iconId, ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x06018D5E RID: 101726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D5E")]
		[Address(RVA = "0x117F200", Offset = "0x117DE00", VA = "0x18117F200")]
		private static Sprite _GetSpriteByAutoPackSpriteHub(string spriteId, AutoPackSpriteHub hub, ILoadAsset iLoadAsset)
		{
			return null;
		}

		// Token: 0x06018D5F RID: 101727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D5F")]
		[Address(RVA = "0x117F420", Offset = "0x117E020", VA = "0x18117F420")]
		private static Sprite _LoadEliteIcon(string spriteId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06018D60 RID: 101728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D60")]
		[Address(RVA = "0x117E570", Offset = "0x117D170", VA = "0x18117E570")]
		public static Sprite LoadEliteIconLarge(int phaseIndex, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06018D61 RID: 101729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D61")]
		[Address(RVA = "0x117E610", Offset = "0x117D210", VA = "0x18117E610")]
		public static Sprite LoadEliteIconSmall(int phaseIndex, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06018D62 RID: 101730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D62")]
		[Address(RVA = "0x117E400", Offset = "0x117D000", VA = "0x18117E400")]
		public static GameObject LoadBgParticleEffect(string effectId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06018D63 RID: 101731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018D63")]
		[Address(RVA = "0x117ED90", Offset = "0x117D990", VA = "0x18117ED90")]
		public static Sprite LoadUnlockEliteIcon(EvolvePhase evolvePhase, bool isUnlock, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x06018D64 RID: 101732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D64")]
		[Address(RVA = "0x117EB00", Offset = "0x117D700", VA = "0x18117EB00")]
		public static void LoadUniEquipChanges(ref ListDict<string, string> changes, CharacterData charData, UniEquipData uniEquipData, PlayerCharacter playerChar, int equipLevel)
		{
		}

		// Token: 0x06018D65 RID: 101733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D65")]
		[Address(RVA = "0x117E7A0", Offset = "0x117D3A0", VA = "0x18117E7A0")]
		public static void LoadSpecialOperatorNodesGeneralInfo(string soCharId, out bool canEvolve, out bool hasUpgrade)
		{
		}

		// Token: 0x06018D66 RID: 101734 RVA: 0x0009C210 File Offset: 0x0009A410
		[Token(Token = "0x6018D66")]
		[Address(RVA = "0x117D250", Offset = "0x117BE50", VA = "0x18117D250")]
		public static bool CheckSpecialOperatorNodeCanActivate(Dictionary<string, SpecialOperatorDetailNodeUnlockData> nodeUnlockDict, SpecialOperatorDetailNodeUnlockData unlockData, PlayerCharacter playerChar, Dictionary<string, Dictionary<string, PlayerSpecialOperatorNode>> nodeMap, Dictionary<string, MissionPlayerState> missions)
		{
			return default(bool);
		}

		// Token: 0x06018D67 RID: 101735 RVA: 0x0009C228 File Offset: 0x0009A428
		[Token(Token = "0x6018D67")]
		[Address(RVA = "0x117D5F0", Offset = "0x117C1F0", VA = "0x18117D5F0")]
		public static bool CheckSpecialOperatorNodeUnlocked(Dictionary<string, SpecialOperatorDetailNodeUnlockData> nodeUnlockDict, SpecialOperatorDetailNodeUnlockData unlockData, PlayerCharacter playerChar, Dictionary<string, Dictionary<string, PlayerSpecialOperatorNode>> nodeMap)
		{
			return default(bool);
		}

		// Token: 0x06018D68 RID: 101736 RVA: 0x0009C240 File Offset: 0x0009A440
		[Token(Token = "0x6018D68")]
		[Address(RVA = "0x117E6B0", Offset = "0x117D2B0", VA = "0x18117E6B0")]
		public static PlayerSpecialOperatorNode.State LoadSpecialOperatorNodeState(Dictionary<string, Dictionary<string, PlayerSpecialOperatorNode>> nodeMap, SpecialOperatorDetailNodeUnlockData unlockData)
		{
			return PlayerSpecialOperatorNode.State.LOCK;
		}

		// Token: 0x06018D69 RID: 101737 RVA: 0x0009C258 File Offset: 0x0009A458
		[Token(Token = "0x6018D69")]
		[Address(RVA = "0x117D410", Offset = "0x117C010", VA = "0x18117D410")]
		public static bool CheckSpecialOperatorNodeMissionComplete(Dictionary<string, MissionPlayerState> playerMissions, string missionId)
		{
			return default(bool);
		}

		// Token: 0x0401E889 RID: 125065
		[Token(Token = "0x401E889")]
		public const string SPECIAL_OPERATOR_EVOLVE_MAX_EXP = "-";

		// Token: 0x0401E88A RID: 125066
		[Token(Token = "0x401E88A")]
		private const string SPECIAL_OPERATOR_ELITE_ICON_LARGE_FORMAT = "elite_{0}_large";

		// Token: 0x0401E88B RID: 125067
		[Token(Token = "0x401E88B")]
		private const string SPECIAL_OPERATOR_ELITE_ICON_SMALL_FORMAT = "elite_{0}_small";

		// Token: 0x0401E88C RID: 125068
		[Token(Token = "0x401E88C")]
		private const string SPECIAL_OPERATOR_ELITE_ICON_LOCKED_FORMAT = "elite_{0}_locked";

		// Token: 0x0401E88D RID: 125069
		[Token(Token = "0x401E88D")]
		private const string SPECIAL_OPERATOR_ELITE_ICON_ACTIVATED_FORMAT = "elite_{0}_activated";

		// Token: 0x0401E88E RID: 125070
		[Token(Token = "0x401E88E")]
		private const string SPECIAL_OPERATOR_TARGET_TYPE_ICON_TINY = "{0}_tiny";

		// Token: 0x0401E88F RID: 125071
		[Token(Token = "0x401E88F")]
		private const int SPECIAL_OPERATOR_NODE_UPGRADE_ONCE = 1;

		// Token: 0x0401E890 RID: 125072
		[Token(Token = "0x401E890")]
		private const int SPECIAL_OPERATOR_NODE_UPGRADE_TWICE = 2;

		// Token: 0x0401E891 RID: 125073
		[Token(Token = "0x401E891")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfCharReachLv;

		// Token: 0x0401E892 RID: 125074
		[Token(Token = "0x401E892")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetMasterUnlockPhase;

		// Token: 0x0401E893 RID: 125075
		[Token(Token = "0x401E893")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SearchModeData;

		// Token: 0x0401E894 RID: 125076
		[Token(Token = "0x401E894")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSpNode;

		// Token: 0x0401E895 RID: 125077
		[Token(Token = "0x401E895")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetNodeStyleType;

		// Token: 0x0401E896 RID: 125078
		[Token(Token = "0x401E896")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetNodeUpgradeNoticeStr;

		// Token: 0x0401E897 RID: 125079
		[Token(Token = "0x401E897")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetConditionDesc;

		// Token: 0x0401E898 RID: 125080
		[Token(Token = "0x401E898")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetSpecialOperatorTargetName;

		// Token: 0x0401E899 RID: 125081
		[Token(Token = "0x401E899")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsNodeTaskCompleted;

		// Token: 0x0401E89A RID: 125082
		[Token(Token = "0x401E89A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetSpecialOperatorTypeName;

		// Token: 0x0401E89B RID: 125083
		[Token(Token = "0x401E89B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_RouteToTarget;

		// Token: 0x0401E89C RID: 125084
		[Token(Token = "0x401E89C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_NeedInGameToast;

		// Token: 0x0401E89D RID: 125085
		[Token(Token = "0x401E89D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetBoardBgSprite;

		// Token: 0x0401E89E RID: 125086
		[Token(Token = "0x401E89E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetTargetTypeIconSprite;

		// Token: 0x0401E89F RID: 125087
		[Token(Token = "0x401E89F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetTargetTypeMissionBackSprite;

		// Token: 0x0401E8A0 RID: 125088
		[Token(Token = "0x401E8A0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetTargetIdIconSprite;

		// Token: 0x0401E8A1 RID: 125089
		[Token(Token = "0x401E8A1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GetSpriteByAutoPackSpriteHub;

		// Token: 0x0401E8A2 RID: 125090
		[Token(Token = "0x401E8A2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__LoadEliteIcon;

		// Token: 0x0401E8A3 RID: 125091
		[Token(Token = "0x401E8A3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_LoadEliteIconLarge;

		// Token: 0x0401E8A4 RID: 125092
		[Token(Token = "0x401E8A4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_LoadEliteIconSmall;

		// Token: 0x0401E8A5 RID: 125093
		[Token(Token = "0x401E8A5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_LoadBgParticleEffect;

		// Token: 0x0401E8A6 RID: 125094
		[Token(Token = "0x401E8A6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_LoadUnlockEliteIcon;

		// Token: 0x0401E8A7 RID: 125095
		[Token(Token = "0x401E8A7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadUniEquipChanges;

		// Token: 0x0401E8A8 RID: 125096
		[Token(Token = "0x401E8A8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_LoadSpecialOperatorNodesGeneralInfo;

		// Token: 0x0401E8A9 RID: 125097
		[Token(Token = "0x401E8A9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_CheckSpecialOperatorNodeCanActivate;

		// Token: 0x0401E8AA RID: 125098
		[Token(Token = "0x401E8AA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_CheckSpecialOperatorNodeUnlocked;

		// Token: 0x0401E8AB RID: 125099
		[Token(Token = "0x401E8AB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_LoadSpecialOperatorNodeState;

		// Token: 0x0401E8AC RID: 125100
		[Token(Token = "0x401E8AC")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_CheckSpecialOperatorNodeMissionComplete;
	}
}
