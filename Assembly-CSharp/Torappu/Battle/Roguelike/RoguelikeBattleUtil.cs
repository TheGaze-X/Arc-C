using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Roguelike
{
	// Token: 0x02002922 RID: 10530
	[Token(Token = "0x2002922")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeBattleUtil
	{
		// Token: 0x06011762 RID: 71522 RVA: 0x0006B670 File Offset: 0x00069870
		[Token(Token = "0x6011762")]
		[Address(RVA = "0x94C780", Offset = "0x94B380", VA = "0x18094C780")]
		public static bool CheckIsMimicEnemy(string key)
		{
			return default(bool);
		}

		// Token: 0x06011763 RID: 71523 RVA: 0x0006B688 File Offset: 0x00069888
		[Token(Token = "0x6011763")]
		[Address(RVA = "0x94C680", Offset = "0x94B280", VA = "0x18094C680")]
		public static bool CheckIsGoldTrap(string key)
		{
			return default(bool);
		}

		// Token: 0x06011764 RID: 71524 RVA: 0x0006B6A0 File Offset: 0x000698A0
		[Token(Token = "0x6011764")]
		[Address(RVA = "0x94C880", Offset = "0x94B480", VA = "0x18094C880")]
		public static bool CheckIsRogue2GoldTrap(string key)
		{
			return default(bool);
		}

		// Token: 0x06011765 RID: 71525 RVA: 0x0006B6B8 File Offset: 0x000698B8
		[Token(Token = "0x6011765")]
		[Address(RVA = "0x94CC90", Offset = "0x94B890", VA = "0x18094CC90")]
		public static bool CheckIsRoguelikeBoss(string key)
		{
			return default(bool);
		}

		// Token: 0x06011766 RID: 71526 RVA: 0x0006B6D0 File Offset: 0x000698D0
		[Token(Token = "0x6011766")]
		[Address(RVA = "0x94CA00", Offset = "0x94B600", VA = "0x18094CA00")]
		public static bool CheckIsRoguelikeBossStage()
		{
			return default(bool);
		}

		// Token: 0x06011767 RID: 71527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011767")]
		[Address(RVA = "0x94CD90", Offset = "0x94B990", VA = "0x18094CD90")]
		public static string GetRoguelikeGoldKey()
		{
			return null;
		}

		// Token: 0x06011768 RID: 71528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011768")]
		[Address(RVA = "0x94CE70", Offset = "0x94BA70", VA = "0x18094CE70")]
		public static string GetRoguelikeShieldKey()
		{
			return null;
		}

		// Token: 0x06011769 RID: 71529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011769")]
		[Address(RVA = "0x94D110", Offset = "0x94BD10", VA = "0x18094D110")]
		public static GameObject LoadUIPlugin(string topicId)
		{
			return null;
		}

		// Token: 0x0601176A RID: 71530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601176A")]
		[Address(RVA = "0x94D080", Offset = "0x94BC80", VA = "0x18094D080")]
		public static GameObject LoadDuelUIPlugin(string topicId)
		{
			return null;
		}

		// Token: 0x0601176B RID: 71531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601176B")]
		[Address(RVA = "0x94CFE0", Offset = "0x94BBE0", VA = "0x18094CFE0")]
		public static GameObject LoadCameraPlugin(string topicId, string cameraPluginName)
		{
			return null;
		}

		// Token: 0x0601176C RID: 71532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601176C")]
		[Address(RVA = "0x94CF60", Offset = "0x94BB60", VA = "0x18094CF60")]
		public static RoguelikeBattleTopicHolder LoadBattleTopicHolder()
		{
			return null;
		}

		// Token: 0x0601176D RID: 71533 RVA: 0x0006B6E8 File Offset: 0x000698E8
		[Token(Token = "0x601176D")]
		[Address(RVA = "0x94D1A0", Offset = "0x94BDA0", VA = "0x18094D1A0")]
		public static bool TryGetRoguelikeEnemyExpPattern(out int[] expArray)
		{
			return default(bool);
		}

		// Token: 0x0601176E RID: 71534 RVA: 0x0006B700 File Offset: 0x00069900
		[Token(Token = "0x601176E")]
		[Address(RVA = "0x94C470", Offset = "0x94B070", VA = "0x18094C470")]
		public static bool CheckFailProtectBeforeGameModeInit()
		{
			return default(bool);
		}

		// Token: 0x0601176F RID: 71535 RVA: 0x0006B718 File Offset: 0x00069918
		[Token(Token = "0x601176F")]
		[Address(RVA = "0x94C250", Offset = "0x94AE50", VA = "0x18094C250")]
		public static bool CheckBattleFailDisplayTypeBeforeGameModeInit(RoguelikeBattleFailDisplay battleFailDisplay)
		{
			return default(bool);
		}

		// Token: 0x04013846 RID: 79942
		[Token(Token = "0x4013846")]
		[FieldOffset(Offset = "0x0")]
		public static string topicId;

		// Token: 0x04013847 RID: 79943
		[Token(Token = "0x4013847")]
		[FieldOffset(Offset = "0x8")]
		public static RoguelikeTopicMode mode;

		// Token: 0x04013848 RID: 79944
		[Token(Token = "0x4013848")]
		private const string UI_PLUGIN_PATH = "UI/RoguelikeTopic/Topics/{0}/rogue_plugin.prefab";

		// Token: 0x04013849 RID: 79945
		[Token(Token = "0x4013849")]
		private const string DUEL_UI_PLUGIN_PATH = "UI/RoguelikeTopic/Topics/{0}/RoguelikeDuel/roguelike_duel_ui_plugin.prefab";

		// Token: 0x0401384A RID: 79946
		[Token(Token = "0x401384A")]
		private const string CAMERA_PLUGIN_PATH = "UI/RoguelikeTopic/Topics/{0}/CameraPlugin/{1}.prefab";

		// Token: 0x0401384B RID: 79947
		[Token(Token = "0x401384B")]
		private const string BATTLE_TOPIC_HOLDER_PATH = "UI/RoguelikeTopic/Topics/rogue_battle_topic_holder.asset";

		// Token: 0x0401384C RID: 79948
		[Token(Token = "0x401384C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckIsMimicEnemy;

		// Token: 0x0401384D RID: 79949
		[Token(Token = "0x401384D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIsGoldTrap;

		// Token: 0x0401384E RID: 79950
		[Token(Token = "0x401384E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckIsRogue2GoldTrap;

		// Token: 0x0401384F RID: 79951
		[Token(Token = "0x401384F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckIsRoguelikeBoss;

		// Token: 0x04013850 RID: 79952
		[Token(Token = "0x4013850")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckIsRoguelikeBossStage;

		// Token: 0x04013851 RID: 79953
		[Token(Token = "0x4013851")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetRoguelikeGoldKey;

		// Token: 0x04013852 RID: 79954
		[Token(Token = "0x4013852")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetRoguelikeShieldKey;

		// Token: 0x04013853 RID: 79955
		[Token(Token = "0x4013853")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_LoadUIPlugin;

		// Token: 0x04013854 RID: 79956
		[Token(Token = "0x4013854")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadDuelUIPlugin;

		// Token: 0x04013855 RID: 79957
		[Token(Token = "0x4013855")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_LoadCameraPlugin;

		// Token: 0x04013856 RID: 79958
		[Token(Token = "0x4013856")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_LoadBattleTopicHolder;

		// Token: 0x04013857 RID: 79959
		[Token(Token = "0x4013857")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_TryGetRoguelikeEnemyExpPattern;

		// Token: 0x04013858 RID: 79960
		[Token(Token = "0x4013858")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CheckFailProtectBeforeGameModeInit;

		// Token: 0x04013859 RID: 79961
		[Token(Token = "0x4013859")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CheckBattleFailDisplayTypeBeforeGameModeInit;
	}
}
