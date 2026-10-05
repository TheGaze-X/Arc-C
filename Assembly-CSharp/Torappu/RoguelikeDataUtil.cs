using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle;
using Torappu.UI.Roguelike;
using XLua;

namespace Torappu
{
	// Token: 0x0200142A RID: 5162
	[Token(Token = "0x200142A")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeDataUtil
	{
		// Token: 0x060076EB RID: 30443 RVA: 0x00035220 File Offset: 0x00033420
		[Token(Token = "0x60076EB")]
		[Address(RVA = "0x2423E50", Offset = "0x2422A50", VA = "0x182423E50")]
		public static bool EnsurePlayerRoguelike()
		{
			return default(bool);
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076EC")]
		[Address(RVA = "0x242C650", Offset = "0x242B250", VA = "0x18242C650")]
		public static string GetZonePath(RogueZoneIndex notify)
		{
			return null;
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60076ED")]
		[Address(RVA = "0x242A8E0", Offset = "0x24294E0", VA = "0x18242A8E0")]
		public static void GetRoguelikeNodeName(string topicId, RoguelikeEventType type, int nodeDisplaySubType, string stageId, PlayerNodeForesightType foresightType, bool isPassed, out string nodeTypeName, out string nodeBattleName)
		{
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076EE")]
		[Address(RVA = "0x242B8B0", Offset = "0x242A4B0", VA = "0x18242B8B0")]
		public static string GetStageFinalLevelId(RoguelikeGameStageData stageData)
		{
			return null;
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x00035238 File Offset: 0x00033438
		[Token(Token = "0x60076EF")]
		[Address(RVA = "0x242CEC0", Offset = "0x242BAC0", VA = "0x18242CEC0")]
		public static bool IsInInitialState()
		{
			return default(bool);
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x00035250 File Offset: 0x00033450
		[Token(Token = "0x60076F0")]
		[Address(RVA = "0x24303C0", Offset = "0x242EFC0", VA = "0x1824303C0")]
		private static bool _IsDiscardedNode(RoguelikeDungeonNode node)
		{
			return default(bool);
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x00035268 File Offset: 0x00033468
		[Token(Token = "0x60076F1")]
		[Address(RVA = "0x2430490", Offset = "0x242F090", VA = "0x182430490")]
		private static bool _IsFutureNode(RoguelikeDungeonNode node)
		{
			return default(bool);
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x00035280 File Offset: 0x00033480
		[Token(Token = "0x60076F2")]
		[Address(RVA = "0x242D170", Offset = "0x242BD70", VA = "0x18242D170")]
		public static bool IsLineDiscard(RoguelikeDungeonNode node1, RoguelikeDungeonNode node2)
		{
			return default(bool);
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076F3")]
		[Address(RVA = "0x24272F0", Offset = "0x2425EF0", VA = "0x1824272F0")]
		public static RoguelikeDungeonZone GetCurrentDungeonZone([Optional] RoguelikeDungeonGeneSpZonePluginBase geneSpZonePlugin)
		{
			return null;
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076F4")]
		[Address(RVA = "0x242FF30", Offset = "0x242EB30", VA = "0x18242FF30")]
		private static RoguelikeDungeonZone _GetDefaultCurrentDungeonZone(PlayerRoguelikeV2Zone playerZone)
		{
			return null;
		}

		// Token: 0x060076F5 RID: 30453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076F5")]
		[Address(RVA = "0x242FE70", Offset = "0x242EA70", VA = "0x18242FE70")]
		private static RoguelikeDungeonZone _GeneSpZoneCurrentDungeonZone(PlayerRoguelikeV2Zone playerZone, RoguelikeDungeonGeneSpZonePluginBase geneSpZonePlugin)
		{
			return null;
		}

		// Token: 0x060076F6 RID: 30454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076F6")]
		[Address(RVA = "0x2424230", Offset = "0x2422E30", VA = "0x182424230")]
		public static RoguelikeDungeonZone GeneCommonDungeonZoneWithoutReachability(PlayerRoguelikeV2Zone playerZone)
		{
			return null;
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x00035298 File Offset: 0x00033498
		[Token(Token = "0x60076F7")]
		[Address(RVA = "0x24271E0", Offset = "0x2425DE0", VA = "0x1824271E0")]
		public static PlayerRoguelikeZoneType GetCurrentDungeonZoneType()
		{
			return PlayerRoguelikeZoneType.NORMAL;
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x000352B0 File Offset: 0x000334B0
		[Token(Token = "0x60076F8")]
		[Address(RVA = "0x2427120", Offset = "0x2425D20", VA = "0x182427120")]
		public static int GetCurrentDepth()
		{
			return 0;
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x000352C8 File Offset: 0x000334C8
		[Token(Token = "0x60076F9")]
		[Address(RVA = "0x24275F0", Offset = "0x24261F0", VA = "0x1824275F0")]
		public static int GetCurrentIndex()
		{
			return 0;
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60076FA")]
		[Address(RVA = "0x2427A10", Offset = "0x2426610", VA = "0x182427A10")]
		public static RoguelikeDungeonNode GetFinishedNode(RoguelikeDungeonZone zone, int depth)
		{
			return null;
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x000352E0 File Offset: 0x000334E0
		[Token(Token = "0x60076FB")]
		[Address(RVA = "0x242C8C0", Offset = "0x242B4C0", VA = "0x18242C8C0")]
		public static bool IsBattleNode(RoguelikeDungeonNode node)
		{
			return default(bool);
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x000352F8 File Offset: 0x000334F8
		[Token(Token = "0x60076FC")]
		[Address(RVA = "0x242C960", Offset = "0x242B560", VA = "0x18242C960")]
		public static bool IsChoiceNode(RoguelikeDungeonNode node)
		{
			return default(bool);
		}

		// Token: 0x060076FD RID: 30461 RVA: 0x00035310 File Offset: 0x00033510
		[Token(Token = "0x60076FD")]
		[Address(RVA = "0x2420A30", Offset = "0x241F630", VA = "0x182420A30")]
		public static bool CanMoveToDirectly(RoguelikeDungeonNode node)
		{
			return default(bool);
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x00035328 File Offset: 0x00033528
		[Token(Token = "0x60076FE")]
		[Address(RVA = "0x242D7B0", Offset = "0x242C3B0", VA = "0x18242D7B0")]
		public static bool IsShopNode(RoguelikeDungeonNode node)
		{
			return default(bool);
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x00035340 File Offset: 0x00033540
		[Token(Token = "0x60076FF")]
		[Address(RVA = "0x242C6D0", Offset = "0x242B2D0", VA = "0x18242C6D0")]
		public static bool IsAlchemyNode(RoguelikeDungeonNode node)
		{
			return default(bool);
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x00035358 File Offset: 0x00033558
		[Token(Token = "0x6007700")]
		[Address(RVA = "0x242CB20", Offset = "0x242B720", VA = "0x18242CB20")]
		public static bool IsCurrentNode(RoguelikeDungeonNode node)
		{
			return default(bool);
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x00035370 File Offset: 0x00033570
		[Token(Token = "0x6007701")]
		[Address(RVA = "0x2420E60", Offset = "0x241FA60", VA = "0x182420E60")]
		public static bool CanReachNode(RoguelikeDungeonZone curZone, RoguelikeDungeonNode node)
		{
			return default(bool);
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x00035388 File Offset: 0x00033588
		[Token(Token = "0x6007702")]
		[Address(RVA = "0x2420AE0", Offset = "0x241F6E0", VA = "0x182420AE0")]
		public static bool CanNextStepNode(RoguelikeDungeonNode node, out bool isLocked)
		{
			return default(bool);
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x000353A0 File Offset: 0x000335A0
		[Token(Token = "0x6007703")]
		[Address(RVA = "0x2430500", Offset = "0x242F100", VA = "0x182430500")]
		private static bool _SearchNode(RoguelikeDungeonNode from, RoguelikeDungeonNode to, List<RoguelikeDungeonNode> searched)
		{
			return default(bool);
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x000353B8 File Offset: 0x000335B8
		[Token(Token = "0x6007704")]
		[Address(RVA = "0x242D210", Offset = "0x242BE10", VA = "0x18242D210")]
		public static bool IsLineInTrace(RoguelikeDungeonNode node1, RoguelikeDungeonNode node2)
		{
			return default(bool);
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x000353D0 File Offset: 0x000335D0
		[Token(Token = "0x6007705")]
		[Address(RVA = "0x242BE90", Offset = "0x242AA90", VA = "0x18242BE90")]
		public static int GetTraceIndex(RoguelikeDungeonNode node)
		{
			return 0;
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x000353E8 File Offset: 0x000335E8
		[Token(Token = "0x6007706")]
		[Address(RVA = "0x242CF70", Offset = "0x242BB70", VA = "0x18242CF70")]
		public static bool IsInTrace(RoguelikeDungeonNode node)
		{
			return default(bool);
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x00035400 File Offset: 0x00033600
		[Token(Token = "0x6007707")]
		[Address(RVA = "0x242CD80", Offset = "0x242B980", VA = "0x18242CD80")]
		public static bool IsFinalBoss(RoguelikeDungeonNode node)
		{
			return default(bool);
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x00035418 File Offset: 0x00033618
		[Token(Token = "0x6007708")]
		[Address(RVA = "0x242CBC0", Offset = "0x242B7C0", VA = "0x18242CBC0")]
		public static bool IsDiffDisplayZone(string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007709")]
		[Address(RVA = "0x2429310", Offset = "0x2427F10", VA = "0x182429310")]
		public static string GetNodeKeyByPos(int depth, int index)
		{
			return null;
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x00035430 File Offset: 0x00033630
		[Token(Token = "0x600770A")]
		[Address(RVA = "0x2423F00", Offset = "0x2422B00", VA = "0x182423F00")]
		public static bool FetchFirstRecruitOrUpgradeTicket(out PlayerRoguelikeV2.CurrentData.Recruit ticket)
		{
			return default(bool);
		}

		// Token: 0x0600770B RID: 30475 RVA: 0x00035448 File Offset: 0x00033648
		[Token(Token = "0x600770B")]
		[Address(RVA = "0x2421790", Offset = "0x2420390", VA = "0x182421790")]
		public static bool CheckIfHavePendingRecruit(out string recruitIndex)
		{
			return default(bool);
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x00035460 File Offset: 0x00033660
		[Token(Token = "0x600770C")]
		[Address(RVA = "0x2421640", Offset = "0x2420240", VA = "0x182421640")]
		public static bool CheckIfFirstHavePendingUseStashedTicket(out int leftCount, out int recruitCostAdd)
		{
			return default(bool);
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x00035478 File Offset: 0x00033678
		[Token(Token = "0x600770D")]
		[Address(RVA = "0x242EEC0", Offset = "0x242DAC0", VA = "0x18242EEC0")]
		public static bool TryGetPlayerUseStashedTicketLeftCntAfterRecruit(out int playerUseLeftCnt)
		{
			return default(bool);
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x00035490 File Offset: 0x00033690
		[Token(Token = "0x600770E")]
		[Address(RVA = "0x2421460", Offset = "0x2420060", VA = "0x182421460")]
		public static bool CheckFirstPendingEvent(PlayerRoguelikePlayerEventType eventType)
		{
			return default(bool);
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x000354A8 File Offset: 0x000336A8
		[Token(Token = "0x600770F")]
		[Address(RVA = "0x242F240", Offset = "0x242DE40", VA = "0x18242F240")]
		public static bool TryGetRecruitData(string ticketIndex, out PlayerRoguelikeV2.CurrentData.Recruit recruit)
		{
			return default(bool);
		}

		// Token: 0x06007710 RID: 30480 RVA: 0x000354C0 File Offset: 0x000336C0
		[Token(Token = "0x6007710")]
		[Address(RVA = "0x2421070", Offset = "0x241FC70", VA = "0x182421070")]
		public static bool CheckCanStashTicket(string topicId, string ticketId)
		{
			return default(bool);
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007711")]
		[Address(RVA = "0x242B980", Offset = "0x242A580", VA = "0x18242B980")]
		public static RoguelikeGameStashableTicketData GetStashData(string topicId, string ticketId)
		{
			return null;
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007712")]
		[Address(RVA = "0x242BC80", Offset = "0x242A880", VA = "0x18242BC80")]
		public static string GetTicketIdByTicketIndex(string ticketIndex)
		{
			return null;
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x000354D8 File Offset: 0x000336D8
		[Token(Token = "0x6007713")]
		[Address(RVA = "0x242F030", Offset = "0x242DC30", VA = "0x18242F030")]
		public static bool TryGetPopulation(out PlayerRoguelikeV2.CurrentData.PlayerStatus.Properties.Population population)
		{
			return default(bool);
		}

		// Token: 0x06007714 RID: 30484 RVA: 0x000354F0 File Offset: 0x000336F0
		[Token(Token = "0x6007714")]
		[Address(RVA = "0x242F100", Offset = "0x242DD00", VA = "0x18242F100")]
		public static bool TryGetProfessionFromTicket(string topicId, string ticketId, out ProfessionCategory profession)
		{
			return default(bool);
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007715")]
		[Address(RVA = "0x242B280", Offset = "0x2429E80", VA = "0x18242B280")]
		public static PlayerRoguelikeV2.OuterData.Bank GetRoguelikeTopicBankData(string topicId)
		{
			return null;
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x00035508 File Offset: 0x00033708
		[Token(Token = "0x6007716")]
		[Address(RVA = "0x2426E60", Offset = "0x2425A60", VA = "0x182426E60")]
		public static int GetCurrRoguelikeTopicBpLimit(string topicId)
		{
			return 0;
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007717")]
		[Address(RVA = "0x2426CC0", Offset = "0x24258C0", VA = "0x182426CC0")]
		public static RoguelikeTopicMilestoneUpdateData GetCurrRoguelikeTopicBpLimitData(string topicId)
		{
			return null;
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x00035520 File Offset: 0x00033720
		[Token(Token = "0x6007718")]
		[Address(RVA = "0x242E7C0", Offset = "0x242D3C0", VA = "0x18242E7C0")]
		public static bool TryGetCurrRoguelikeTopicBp(string topicId, int bpPoint, out RoguelikeTopicBP roguelikeTopicBp)
		{
			return default(bool);
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007719")]
		[Address(RVA = "0x2429740", Offset = "0x2428340", VA = "0x182429740")]
		public static PlayerRoguelikeV2.OuterData.BattlePass GetPlayerBattlePass(string topicId)
		{
			return null;
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x00035538 File Offset: 0x00033738
		[Token(Token = "0x600771A")]
		[Address(RVA = "0x242E5C0", Offset = "0x242D1C0", VA = "0x18242E5C0")]
		public static bool TryFindSpecialOperator(string topicId, out string charId)
		{
			return default(bool);
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x00035550 File Offset: 0x00033750
		[Token(Token = "0x600771B")]
		[Address(RVA = "0x242D2F0", Offset = "0x242BEF0", VA = "0x18242D2F0")]
		public static bool IsMonthSquadAwardReceived(string topicId, string monthSquadId)
		{
			return default(bool);
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x00035568 File Offset: 0x00033768
		[Token(Token = "0x600771C")]
		[Address(RVA = "0x242D600", Offset = "0x242C200", VA = "0x18242D600")]
		public static bool IsMonthTaskAvailable(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x00035580 File Offset: 0x00033780
		[Token(Token = "0x600771D")]
		[Address(RVA = "0x242D450", Offset = "0x242C050", VA = "0x18242D450")]
		public static bool IsMonthTaskAllCompleted(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600771E")]
		[Address(RVA = "0x2426A00", Offset = "0x2425600", VA = "0x182426A00")]
		public static RoguelikeTopicUpdate GetCurrMonthTaskUpdateData(string topicId, out bool isFinalUpdate)
		{
			return null;
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x00035598 File Offset: 0x00033798
		[Token(Token = "0x600771F")]
		[Address(RVA = "0x242E090", Offset = "0x242CC90", VA = "0x18242E090")]
		public static bool NeedEntryDLCTrackPoint(string topicId)
		{
			return default(bool);
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x000355B0 File Offset: 0x000337B0
		[Token(Token = "0x6007720")]
		[Address(RVA = "0x242E1B0", Offset = "0x242CDB0", VA = "0x18242E1B0")]
		public static bool NeedEntryReviewTrackPointAllTopic()
		{
			return default(bool);
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x000355C8 File Offset: 0x000337C8
		[Token(Token = "0x6007721")]
		[Address(RVA = "0x242E310", Offset = "0x242CF10", VA = "0x18242E310")]
		public static bool NeedEntryReviewTrackPoint(string topicId)
		{
			return default(bool);
		}

		// Token: 0x06007722 RID: 30498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007722")]
		[Address(RVA = "0x2423260", Offset = "0x2421E60", VA = "0x182423260")]
		public static void ConsumeEntryTrackPoint(string topicId)
		{
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007723")]
		[Address(RVA = "0x242FC90", Offset = "0x242E890", VA = "0x18242FC90")]
		private static void _ConsumeEntryDLCTrackPoint(string topicId)
		{
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007724")]
		[Address(RVA = "0x242FDA0", Offset = "0x242E9A0", VA = "0x18242FDA0")]
		private static void _ConsumeEntryReviewTrackPoint(string topicId)
		{
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007725")]
		[Address(RVA = "0x24232D0", Offset = "0x2421ED0", VA = "0x1824232D0")]
		public static void ConsumeExpiredEntryTrackPoint()
		{
		}

		// Token: 0x06007726 RID: 30502 RVA: 0x000355E0 File Offset: 0x000337E0
		[Token(Token = "0x6007726")]
		[Address(RVA = "0x242E4F0", Offset = "0x242D0F0", VA = "0x18242E4F0")]
		public static bool NeedMonthRefreshTrackPoint(string topicId, string trackId)
		{
			return default(bool);
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007727")]
		[Address(RVA = "0x24235B0", Offset = "0x24221B0", VA = "0x1824235B0")]
		public static void ConsumeMonthRefreshTrackPoint(string topicId, string trackId)
		{
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x000355F8 File Offset: 0x000337F8
		[Token(Token = "0x6007728")]
		[Address(RVA = "0x242E3E0", Offset = "0x242CFE0", VA = "0x18242E3E0")]
		public static bool NeedModeOpenTrackPoint(string topicId, RoguelikeTopicMode mode)
		{
			return default(bool);
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007729")]
		[Address(RVA = "0x24234A0", Offset = "0x24220A0", VA = "0x1824234A0")]
		public static void ConsumeModeOpenTrackPoint(string topicId, RoguelikeTopicMode mode)
		{
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00035610 File Offset: 0x00033810
		[Token(Token = "0x600772A")]
		[Address(RVA = "0x242A820", Offset = "0x2429420", VA = "0x18242A820")]
		public static int GetRoguelikeGameGold()
		{
			return 0;
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600772B")]
		[Address(RVA = "0x2424CF0", Offset = "0x24238F0", VA = "0x182424CF0")]
		public static string GetBankCountFormatStr(int count)
		{
			return null;
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x00035628 File Offset: 0x00033828
		[Token(Token = "0x600772C")]
		[Address(RVA = "0x242A750", Offset = "0x2429350", VA = "0x18242A750")]
		public static int GetRoguelikeBankMaxGold(string topicId)
		{
			return 0;
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x00035640 File Offset: 0x00033840
		[Token(Token = "0x600772D")]
		[Address(RVA = "0x242C770", Offset = "0x242B370", VA = "0x18242C770")]
		public static bool IsBankGoldMax(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x00035658 File Offset: 0x00033858
		[Token(Token = "0x600772E")]
		[Address(RVA = "0x2424D90", Offset = "0x2423990", VA = "0x182424D90")]
		public static int GetBankLockSlotCount(string topicId, bool hasBoss)
		{
			return 0;
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x00035670 File Offset: 0x00033870
		[Token(Token = "0x600772F")]
		[Address(RVA = "0x2425060", Offset = "0x2423C60", VA = "0x182425060")]
		public static int GetBankRewardAccumulatedCount(PlayerRoguelikeV2.OuterData.Bank bank, RoguelikeBankRewardCountType type)
		{
			return 0;
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x00035688 File Offset: 0x00033888
		[Token(Token = "0x6007730")]
		[Address(RVA = "0x2421C80", Offset = "0x2420880", VA = "0x182421C80")]
		public static bool CheckLevelUpStatus(Dictionary<int, RoguelikeTopicDetailConst.PlayerLevelData> levelDataTable, int maxLevel, ref int level, ref int exp)
		{
			return default(bool);
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x000356A0 File Offset: 0x000338A0
		[Token(Token = "0x6007731")]
		[Address(RVA = "0x2428AB0", Offset = "0x24276B0", VA = "0x182428AB0")]
		public static RoguelikeGameItemType GetItemType(string topicId, string itemId)
		{
			return RoguelikeGameItemType.NONE;
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007732")]
		[Address(RVA = "0x2428950", Offset = "0x2427550", VA = "0x182428950")]
		public static string GetItemName(string topicId, string itemId)
		{
			return null;
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007733")]
		[Address(RVA = "0x2427B10", Offset = "0x2426710", VA = "0x182427B10")]
		public static string GetGoldItemName(string topicId)
		{
			return null;
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007734")]
		[Address(RVA = "0x2429840", Offset = "0x2428440", VA = "0x182429840")]
		public static string GetPopulationItemName(string topicId)
		{
			return null;
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007735")]
		[Address(RVA = "0x2426720", Offset = "0x2425320", VA = "0x182426720")]
		public static string GetCopperGildName(string topicId, string copperId)
		{
			return null;
		}

		// Token: 0x06007736 RID: 30518 RVA: 0x000356B8 File Offset: 0x000338B8
		[Token(Token = "0x6007736")]
		[Address(RVA = "0x242F8B0", Offset = "0x242E4B0", VA = "0x18242F8B0")]
		public static bool TryGetUpgradeTicketFromItem(string topicId, string itemId, out RoguelikeGameUpgradeTicketData upgradeTicketData)
		{
			return default(bool);
		}

		// Token: 0x06007737 RID: 30519 RVA: 0x000356D0 File Offset: 0x000338D0
		[Token(Token = "0x6007737")]
		[Address(RVA = "0x242F6F0", Offset = "0x242E2F0", VA = "0x18242F6F0")]
		public static bool TryGetTreasureData(string topicId, string treasureGroupId, int index, out RoguelikeGameTreasureData treasureData)
		{
			return default(bool);
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x000356E8 File Offset: 0x000338E8
		[Token(Token = "0x6007738")]
		[Address(RVA = "0x242DBA0", Offset = "0x242C7A0", VA = "0x18242DBA0")]
		public static bool IsUpgradeTicketItem(string topicId, string itemId)
		{
			return default(bool);
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x00035700 File Offset: 0x00033900
		[Token(Token = "0x6007739")]
		[Address(RVA = "0x242C340", Offset = "0x242AF40", VA = "0x18242C340")]
		public static int GetUpgradableCharCount(string topicId, string itemId)
		{
			return 0;
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x00035718 File Offset: 0x00033918
		[Token(Token = "0x600773A")]
		[Address(RVA = "0x2421540", Offset = "0x2420140", VA = "0x182421540")]
		public static bool CheckIfCanDice()
		{
			return default(bool);
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x00035730 File Offset: 0x00033930
		[Token(Token = "0x600773B")]
		[Address(RVA = "0x2421DE0", Offset = "0x24209E0", VA = "0x182421DE0")]
		public static bool CheckModuleValid(string topicId, RoguelikeModuleType type)
		{
			return default(bool);
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x00035748 File Offset: 0x00033948
		[Token(Token = "0x600773C")]
		[Address(RVA = "0x2429A90", Offset = "0x2428690", VA = "0x182429A90")]
		public static int GetRecruitSimilarCharCount(string topicId, string itemId)
		{
			return 0;
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00035760 File Offset: 0x00033960
		[Token(Token = "0x600773D")]
		[Address(RVA = "0x242F360", Offset = "0x242DF60", VA = "0x18242F360")]
		public static bool TryGetRelicEffectiveCharCount(string topicId, string itemId, out int charCount)
		{
			return default(bool);
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773E")]
		[Address(RVA = "0x2429DF0", Offset = "0x24289F0", VA = "0x182429DF0")]
		public static List<BattleRoguelikeRelicBuff> GetRelicFeatures()
		{
			return null;
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600773F")]
		[Address(RVA = "0x2429470", Offset = "0x2428070", VA = "0x182429470")]
		public static List<RoguelikeBuff> GetOutBuffs()
		{
			return null;
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x00035778 File Offset: 0x00033978
		[Token(Token = "0x6007740")]
		[Address(RVA = "0x2425850", Offset = "0x2424450", VA = "0x182425850")]
		public static RoguelikeGameCharBuffType GetCharBuffType(string topicId, string charBuffId)
		{
			return RoguelikeGameCharBuffType.NONE;
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007741")]
		[Address(RVA = "0x2425990", Offset = "0x2424590", VA = "0x182425990")]
		public static List<RoguelikeGameCharBuffBattleData> GetCharBuffs(List<RoguelikeCharCardViewModel> charList)
		{
			return null;
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x00035790 File Offset: 0x00033990
		[Token(Token = "0x6007742")]
		[Address(RVA = "0x2421310", Offset = "0x241FF10", VA = "0x182421310")]
		public static bool CheckCharHasTargetBuff(string targetBuffId, int troopInstId)
		{
			return default(bool);
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007743")]
		[Address(RVA = "0x2425410", Offset = "0x2424010", VA = "0x182425410")]
		public static string GetCandleBuffId(string topicId)
		{
			return null;
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007744")]
		[Address(RVA = "0x2427C60", Offset = "0x2426860", VA = "0x182427C60")]
		public static Dictionary<string, int> GetHasCandleHolderBuffCharDict(string topicId)
		{
			return null;
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x000357A8 File Offset: 0x000339A8
		[Token(Token = "0x6007745")]
		[Address(RVA = "0x2421B60", Offset = "0x2420760", VA = "0x182421B60")]
		public static bool CheckIsCandleBattleStage(string topicId, string stageId)
		{
			return default(bool);
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x000357C0 File Offset: 0x000339C0
		[Token(Token = "0x6007746")]
		[Address(RVA = "0x2428520", Offset = "0x2427120", VA = "0x182428520")]
		public static bool GetIsGetCandleTicketRecruit(string topicId)
		{
			return default(bool);
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007747")]
		[Address(RVA = "0x2425500", Offset = "0x2424100", VA = "0x182425500")]
		public static void GetCandleRecruitCharStatus(string topicId, RoguelikeCharCardViewModel charCardViewModel, out bool willRecruit, out bool willUpgrade, out bool willGetCandle)
		{
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007748")]
		[Address(RVA = "0x2423790", Offset = "0x2422390", VA = "0x182423790")]
		public static BattlePlayerData CreateBattlePlayerData(RequestSquadSlot[] slots, LevelData levelData)
		{
			return null;
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007749")]
		[Address(RVA = "0x2426380", Offset = "0x2424F80", VA = "0x182426380")]
		public static PlayerRoguelikeV2.CurrentData.Char GetCharInTroop(int troopInstId)
		{
			return null;
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600774A")]
		[Address(RVA = "0x24249D0", Offset = "0x24235D0", VA = "0x1824249D0")]
		public static List<RoguelikeCharSelectSkillItemViewModel> GenerateSkillViewModel(RoguelikeCharCardViewModel viewModel)
		{
			return null;
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600774B")]
		[Address(RVA = "0x2426900", Offset = "0x2425500", VA = "0x182426900")]
		public static string GetCurrCapsuleId()
		{
			return null;
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600774C")]
		[Address(RVA = "0x2427060", Offset = "0x2425C60", VA = "0x182427060")]
		public static string GetCurrTrapId()
		{
			return null;
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600774D")]
		[Address(RVA = "0x2428170", Offset = "0x2426D70", VA = "0x182428170")]
		public static string GetHomeEntryDisplayId(string topicId, long timestamp, out long startTs)
		{
			return null;
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600774E")]
		[Address(RVA = "0x2427F20", Offset = "0x2426B20", VA = "0x182427F20")]
		public static string GetHomeEntryDisplayIdForToDoListItem(string topicId, long timestamp)
		{
			return null;
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x000357D8 File Offset: 0x000339D8
		[Token(Token = "0x600774F")]
		[Address(RVA = "0x242D8C0", Offset = "0x242C4C0", VA = "0x18242D8C0")]
		public static bool IsTopicAccessible(string topicId)
		{
			return default(bool);
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007750")]
		[Address(RVA = "0x2424120", Offset = "0x2422D20", VA = "0x182424120")]
		public static string FindBestTopic()
		{
			return null;
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x000357F0 File Offset: 0x000339F0
		[Token(Token = "0x6007751")]
		[Address(RVA = "0x2421B00", Offset = "0x2420700", VA = "0x182421B00")]
		public static bool CheckIfNormalGameMode(RoguelikeTopicMode mode)
		{
			return default(bool);
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007752")]
		[Address(RVA = "0x24276B0", Offset = "0x24262B0", VA = "0x1824276B0")]
		public static RoguelikeTopicDifficulty GetDifficultyData(string topicId, RoguelikeTopicMode mode, int grade)
		{
			return null;
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x00035808 File Offset: 0x00033A08
		[Token(Token = "0x6007753")]
		[Address(RVA = "0x24291D0", Offset = "0x2427DD0", VA = "0x1824291D0")]
		public static int GetMostDifficultyByMode(RoguelikeTopicDetail topicDetail, RoguelikeTopicMode mode)
		{
			return 0;
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x00035820 File Offset: 0x00033A20
		[Token(Token = "0x6007754")]
		[Address(RVA = "0x242CA00", Offset = "0x242B600", VA = "0x18242CA00")]
		public static bool IsCurrentGameNormalMode()
		{
			return default(bool);
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x00035838 File Offset: 0x00033A38
		[Token(Token = "0x6007755")]
		[Address(RVA = "0x24227E0", Offset = "0x24213E0", VA = "0x1824227E0")]
		public static bool CheckOpenTime(string topicId, string enrollId)
		{
			return default(bool);
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00035850 File Offset: 0x00033A50
		[Token(Token = "0x6007756")]
		[Address(RVA = "0x2426490", Offset = "0x2425090", VA = "0x182426490")]
		public static RoguelikeDataUtil.ChatUnlockStatus GetChatUnlockStatus(PlayerRoguelikeV2.CurrentData curPlayerData)
		{
			return default(RoguelikeDataUtil.ChatUnlockStatus);
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007757")]
		[Address(RVA = "0x2428BF0", Offset = "0x24277F0", VA = "0x182428BF0")]
		public static ActArchiveChatItemData GetLastChatUnlockedItemData(PlayerRoguelikeV2.CurrentData curPlayerData)
		{
			return null;
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007758")]
		[Address(RVA = "0x242C270", Offset = "0x242AE70", VA = "0x18242C270")]
		public static IEnumerator<ActArchiveChatItemData> GetUnlockedArchiveChatItems(ActArchiveChatGroupData chatGroupData, List<string> zoneIdList)
		{
			return null;
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00035868 File Offset: 0x00033A68
		[Token(Token = "0x6007759")]
		[Address(RVA = "0x242AC60", Offset = "0x2429860", VA = "0x18242AC60")]
		public static bool GetRoguelikeTopicArchiveChatUnlockInfo(string topicId, string monthSquadId, out int totalChatItems, out int unlockedChatItems)
		{
			return default(bool);
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00035880 File Offset: 0x00033A80
		[Token(Token = "0x600775A")]
		[Address(RVA = "0x242B0C0", Offset = "0x2429CC0", VA = "0x18242B0C0")]
		public static bool GetRoguelikeTopicArchiveEndUnlock(string endingId, PlayerRoguelikeV2.OuterData.Record record)
		{
			return default(bool);
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600775B")]
		[Address(RVA = "0x24295B0", Offset = "0x24281B0", VA = "0x1824295B0")]
		public static void GetOuterBuffItemIdAndName(string topicId, ref string outerBuffItemId, ref string outerBuffItemName)
		{
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x00035898 File Offset: 0x00033A98
		[Token(Token = "0x600775C")]
		[Address(RVA = "0x242D9C0", Offset = "0x242C5C0", VA = "0x18242D9C0")]
		public static bool IsTopicBpPurchaseAvailable(string topicId)
		{
			return default(bool);
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600775D")]
		[Address(RVA = "0x2425330", Offset = "0x2423F30", VA = "0x182425330")]
		public static string GetBpSystemName(string topicId)
		{
			return null;
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600775E")]
		[Address(RVA = "0x24251D0", Offset = "0x2423DD0", VA = "0x1824251D0")]
		public static string GetBpItemName(string topicId)
		{
			return null;
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600775F")]
		[Address(RVA = "0x24250F0", Offset = "0x2423CF0", VA = "0x1824250F0")]
		public static string GetBattlePassUpdateName(string topicId)
		{
			return null;
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007760")]
		[Address(RVA = "0x24290F0", Offset = "0x2427CF0", VA = "0x1824290F0")]
		public static string GetMonthModeName(string topicId)
		{
			return null;
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007761")]
		[Address(RVA = "0x242BDB0", Offset = "0x242A9B0", VA = "0x18242BDB0")]
		public static string GetTopicName(string topicId)
		{
			return null;
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x000358B0 File Offset: 0x00033AB0
		[Token(Token = "0x6007762")]
		[Address(RVA = "0x242E9B0", Offset = "0x242D5B0", VA = "0x18242E9B0")]
		public static bool TryGetCurrentValidRogueActivityId(string topicId, out string rlActId)
		{
			return default(bool);
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007763")]
		[Address(RVA = "0x242A600", Offset = "0x2429200", VA = "0x18242A600")]
		public static RoguelikeActivityBasicData GetRoguelikeActivityBasicData(string topicId, string rlActId)
		{
			return null;
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007764")]
		[Address(RVA = "0x2423D90", Offset = "0x2422990", VA = "0x182423D90")]
		public static string CullLocalizationFromPasteContent(string pasteContent)
		{
			return null;
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007765")]
		[Address(RVA = "0x242B700", Offset = "0x242A300", VA = "0x18242B700")]
		public static string GetSeedStringFromPasteContent(string pasteContent)
		{
			return null;
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007766")]
		[Address(RVA = "0x2423680", Offset = "0x2422280", VA = "0x182423680")]
		public static void CopyFormatSeedString(string seedStr, string format)
		{
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x000358C8 File Offset: 0x00033AC8
		[Token(Token = "0x6007767")]
		[Address(RVA = "0x242B670", Offset = "0x242A270", VA = "0x18242B670")]
		public static int GetSeedGradeFromSeed(string seed)
		{
			return 0;
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007768")]
		[Address(RVA = "0x242B800", Offset = "0x242A400", VA = "0x18242B800")]
		public static string GetSeedTopicIdFromSeed(string seed)
		{
			return null;
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x000358E0 File Offset: 0x00033AE0
		[Token(Token = "0x6007769")]
		[Address(RVA = "0x2421F90", Offset = "0x2420B90", VA = "0x182421F90")]
		public static bool CheckNeedTrigMonthChatWithTopic(string topicId, RoguelikeMonthChatTrigType trigType)
		{
			return default(bool);
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600776A")]
		[Address(RVA = "0x24277F0", Offset = "0x24263F0", VA = "0x1824277F0")]
		public static string GetExpeditionReturnDesc(string topicId, string charName, bool isUpgrade, bool isCure, List<ItemBundle> items)
		{
			return null;
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600776B")]
		[Address(RVA = "0x242C090", Offset = "0x242AC90", VA = "0x18242C090")]
		public static string GetTravelReturnDesc(string topicId, string charName, bool isUpgrade, List<ItemBundle> items)
		{
			return null;
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600776C")]
		[Address(RVA = "0x2425640", Offset = "0x2424240", VA = "0x182425640")]
		public static string GetCandleReturnDesc(string topicId, string charName, bool isUpgrade, bool isCandle, List<ItemBundle> items)
		{
			return null;
		}

		// Token: 0x0600776D RID: 30573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600776D")]
		[Address(RVA = "0x242A320", Offset = "0x2428F20", VA = "0x18242A320")]
		public static string GetRewardItemDesc(string topicId, string prefixDesc, List<ItemBundle> items, List<string> blackList)
		{
			return null;
		}

		// Token: 0x0600776E RID: 30574 RVA: 0x000358F8 File Offset: 0x00033AF8
		[Token(Token = "0x600776E")]
		[Address(RVA = "0x242A240", Offset = "0x2428E40", VA = "0x18242A240")]
		public static RoguelikeRewardExDropTagSrcType GetRewardExDropTagSrcType(bool isTreasureExDrop, RogueLikeRewardItemExDropSrc exDropSrc)
		{
			return RoguelikeRewardExDropTagSrcType.NONE;
		}

		// Token: 0x0600776F RID: 30575 RVA: 0x00035910 File Offset: 0x00033B10
		[Token(Token = "0x600776F")]
		[Address(RVA = "0x24218C0", Offset = "0x24204C0", VA = "0x1824218C0")]
		public static bool CheckIfInPortal(string topicId, string zoneId)
		{
			return default(bool);
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x00035928 File Offset: 0x00033B28
		[Token(Token = "0x6007770")]
		[Address(RVA = "0x242B520", Offset = "0x242A120", VA = "0x18242B520")]
		public static int GetRouteNeedItemCount(string topicId)
		{
			return 0;
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x00035940 File Offset: 0x00033B40
		[Token(Token = "0x6007771")]
		[Address(RVA = "0x2421A20", Offset = "0x2420620", VA = "0x182421A20")]
		public static bool CheckIfNeedSpZonePlugin(string topicId)
		{
			return default(bool);
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x00035958 File Offset: 0x00033B58
		[Token(Token = "0x6007772")]
		[Address(RVA = "0x2428380", Offset = "0x2426F80", VA = "0x182428380")]
		public static int GetInitPredefinedStyle(string topicId, RoguelikeTopicMode mode, string predefinedId, int modeGrade)
		{
			return 0;
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007773")]
		[Address(RVA = "0x242B360", Offset = "0x2429F60", VA = "0x18242B360")]
		public static RoguelikeTopicDetailConst GetRoguelikeTopicDetailConst(string topicId)
		{
			return null;
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007774")]
		[Address(RVA = "0x242B440", Offset = "0x242A040", VA = "0x18242B440")]
		public static RoguelikeGameConst GetRoguelikeTopicGameConst(string topicId)
		{
			return null;
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x00035970 File Offset: 0x00033B70
		[Token(Token = "0x6007775")]
		[Address(RVA = "0x242D860", Offset = "0x242C460", VA = "0x18242D860")]
		public static bool IsSpExpStyleWithInitPredefinedStyle(int initPredefinedStyle)
		{
			return default(bool);
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007776")]
		[Address(RVA = "0x2429390", Offset = "0x2427F90", VA = "0x182429390")]
		public static Dictionary<int, RoguelikeTopicDetailConst.PlayerLevelData> GetNormalLevelDataTable(string topicId)
		{
			return null;
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007777")]
		[Address(RVA = "0x242BAF0", Offset = "0x242A6F0", VA = "0x18242BAF0")]
		public static Dictionary<int, RoguelikeTopicDetailConst.PlayerLevelData> GetTargetPredefinedLevelDataTable(string topicId, RoguelikeTopicMode mode, string predefinedId, int modeGrade)
		{
			return null;
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007778")]
		[Address(RVA = "0x2428D50", Offset = "0x2427950", VA = "0x182428D50")]
		public static Dictionary<int, RoguelikeTopicDetailConst.PlayerLevelData> GetLevelDataTableConsideringPredefined(string topicId, RoguelikeTopicMode mode, string predefinedId, int modeGrade)
		{
			return null;
		}

		// Token: 0x06007779 RID: 30585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007779")]
		[Address(RVA = "0x2428F30", Offset = "0x2427B30", VA = "0x182428F30")]
		public static RoguelikeTopicDetailConst.PlayerLevelData GetLevelTargetDataFromTable(Dictionary<int, RoguelikeTopicDetailConst.PlayerLevelData> levelDataTable, int maxLevel, int targetLevel)
		{
			return null;
		}

		// Token: 0x0600777A RID: 30586 RVA: 0x00035988 File Offset: 0x00033B88
		[Token(Token = "0x600777A")]
		[Address(RVA = "0x2429020", Offset = "0x2427C20", VA = "0x182429020")]
		public static int GetLevelWithExp(Dictionary<int, RoguelikeTopicDetailConst.PlayerLevelData> levelDataTable, int exp)
		{
			return 0;
		}

		// Token: 0x0600777B RID: 30587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600777B")]
		[Address(RVA = "0x2429990", Offset = "0x2428590", VA = "0x182429990")]
		public static string GetPredefinedLevelTableKey(RoguelikeTopicMode mode, string predefinedId, int modeGrade)
		{
			return null;
		}

		// Token: 0x0600777C RID: 30588 RVA: 0x000359A0 File Offset: 0x00033BA0
		[Token(Token = "0x600777C")]
		[Address(RVA = "0x242ED30", Offset = "0x242D930", VA = "0x18242ED30")]
		public static bool TryGetExpStyleRewardLoseHpTitle(string topicId, out string rewardLoseHpTitle)
		{
			return default(bool);
		}

		// Token: 0x0600777D RID: 30589 RVA: 0x000359B8 File Offset: 0x00033BB8
		[Token(Token = "0x600777D")]
		[Address(RVA = "0x2422070", Offset = "0x2420C70", VA = "0x182422070")]
		public static NodeUpgradeStatus CheckNodeUpgradeStatus(string topicId, RoguelikeEventType nodeType, out string upgradedNodeName)
		{
			return NodeUpgradeStatus.NONE;
		}

		// Token: 0x0600777E RID: 30590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600777E")]
		[Address(RVA = "0x242DC50", Offset = "0x242C850", VA = "0x18242DC50")]
		public static RoguelikePermNodeUpgradeItemData LoadFirstPermNodeUpgradeData(List<RoguelikePermNodeUpgradeItemData> permList)
		{
			return null;
		}

		// Token: 0x0600777F RID: 30591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600777F")]
		[Address(RVA = "0x242DDC0", Offset = "0x242C9C0", VA = "0x18242DDC0")]
		public static RoguelikePermNodeUpgradeItemData LoadLastPermNodeUpgradeData(List<RoguelikePermNodeUpgradeItemData> permList, List<string> playerPermList, out bool isPermComplete, out bool enoughPermUpgrade)
		{
			return null;
		}

		// Token: 0x06007780 RID: 30592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007780")]
		[Address(RVA = "0x24228A0", Offset = "0x24214A0", VA = "0x1824228A0")]
		public static List<RoguelikeCharCardComparer> ConstructDefaultComparers()
		{
			return null;
		}

		// Token: 0x0400745B RID: 29787
		[Token(Token = "0x400745B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnsurePlayerRoguelike;

		// Token: 0x0400745C RID: 29788
		[Token(Token = "0x400745C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetZonePath;

		// Token: 0x0400745D RID: 29789
		[Token(Token = "0x400745D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetRoguelikeNodeName;

		// Token: 0x0400745E RID: 29790
		[Token(Token = "0x400745E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetStageFinalLevelId;

		// Token: 0x0400745F RID: 29791
		[Token(Token = "0x400745F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsInInitialState;

		// Token: 0x04007460 RID: 29792
		[Token(Token = "0x4007460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsDiscardedNode;

		// Token: 0x04007461 RID: 29793
		[Token(Token = "0x4007461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsFutureNode;

		// Token: 0x04007462 RID: 29794
		[Token(Token = "0x4007462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsLineDiscard;

		// Token: 0x04007463 RID: 29795
		[Token(Token = "0x4007463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetCurrentDungeonZone;

		// Token: 0x04007464 RID: 29796
		[Token(Token = "0x4007464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetDefaultCurrentDungeonZone;

		// Token: 0x04007465 RID: 29797
		[Token(Token = "0x4007465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GeneSpZoneCurrentDungeonZone;

		// Token: 0x04007466 RID: 29798
		[Token(Token = "0x4007466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GeneCommonDungeonZoneWithoutReachability;

		// Token: 0x04007467 RID: 29799
		[Token(Token = "0x4007467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetCurrentDungeonZoneType;

		// Token: 0x04007468 RID: 29800
		[Token(Token = "0x4007468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetCurrentDepth;

		// Token: 0x04007469 RID: 29801
		[Token(Token = "0x4007469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetCurrentIndex;

		// Token: 0x0400746A RID: 29802
		[Token(Token = "0x400746A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetFinishedNode;

		// Token: 0x0400746B RID: 29803
		[Token(Token = "0x400746B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsBattleNode;

		// Token: 0x0400746C RID: 29804
		[Token(Token = "0x400746C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_IsChoiceNode;

		// Token: 0x0400746D RID: 29805
		[Token(Token = "0x400746D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_CanMoveToDirectly;

		// Token: 0x0400746E RID: 29806
		[Token(Token = "0x400746E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_IsShopNode;

		// Token: 0x0400746F RID: 29807
		[Token(Token = "0x400746F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_IsAlchemyNode;

		// Token: 0x04007470 RID: 29808
		[Token(Token = "0x4007470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_IsCurrentNode;

		// Token: 0x04007471 RID: 29809
		[Token(Token = "0x4007471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_CanReachNode;

		// Token: 0x04007472 RID: 29810
		[Token(Token = "0x4007472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_CanNextStepNode;

		// Token: 0x04007473 RID: 29811
		[Token(Token = "0x4007473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__SearchNode;

		// Token: 0x04007474 RID: 29812
		[Token(Token = "0x4007474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_IsLineInTrace;

		// Token: 0x04007475 RID: 29813
		[Token(Token = "0x4007475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_GetTraceIndex;

		// Token: 0x04007476 RID: 29814
		[Token(Token = "0x4007476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_IsInTrace;

		// Token: 0x04007477 RID: 29815
		[Token(Token = "0x4007477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_IsFinalBoss;

		// Token: 0x04007478 RID: 29816
		[Token(Token = "0x4007478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_IsDiffDisplayZone;

		// Token: 0x04007479 RID: 29817
		[Token(Token = "0x4007479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_GetNodeKeyByPos;

		// Token: 0x0400747A RID: 29818
		[Token(Token = "0x400747A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_FetchFirstRecruitOrUpgradeTicket;

		// Token: 0x0400747B RID: 29819
		[Token(Token = "0x400747B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CheckIfHavePendingRecruit;

		// Token: 0x0400747C RID: 29820
		[Token(Token = "0x400747C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_CheckIfFirstHavePendingUseStashedTicket;

		// Token: 0x0400747D RID: 29821
		[Token(Token = "0x400747D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_TryGetPlayerUseStashedTicketLeftCntAfterRecruit;

		// Token: 0x0400747E RID: 29822
		[Token(Token = "0x400747E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_CheckFirstPendingEvent;

		// Token: 0x0400747F RID: 29823
		[Token(Token = "0x400747F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_TryGetRecruitData;

		// Token: 0x04007480 RID: 29824
		[Token(Token = "0x4007480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_CheckCanStashTicket;

		// Token: 0x04007481 RID: 29825
		[Token(Token = "0x4007481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_GetStashData;

		// Token: 0x04007482 RID: 29826
		[Token(Token = "0x4007482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetTicketIdByTicketIndex;

		// Token: 0x04007483 RID: 29827
		[Token(Token = "0x4007483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_TryGetPopulation;

		// Token: 0x04007484 RID: 29828
		[Token(Token = "0x4007484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_TryGetProfessionFromTicket;

		// Token: 0x04007485 RID: 29829
		[Token(Token = "0x4007485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_GetRoguelikeTopicBankData;

		// Token: 0x04007486 RID: 29830
		[Token(Token = "0x4007486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_GetCurrRoguelikeTopicBpLimit;

		// Token: 0x04007487 RID: 29831
		[Token(Token = "0x4007487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_GetCurrRoguelikeTopicBpLimitData;

		// Token: 0x04007488 RID: 29832
		[Token(Token = "0x4007488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_TryGetCurrRoguelikeTopicBp;

		// Token: 0x04007489 RID: 29833
		[Token(Token = "0x4007489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_GetPlayerBattlePass;

		// Token: 0x0400748A RID: 29834
		[Token(Token = "0x400748A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_TryFindSpecialOperator;

		// Token: 0x0400748B RID: 29835
		[Token(Token = "0x400748B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_IsMonthSquadAwardReceived;

		// Token: 0x0400748C RID: 29836
		[Token(Token = "0x400748C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_IsMonthTaskAvailable;

		// Token: 0x0400748D RID: 29837
		[Token(Token = "0x400748D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_IsMonthTaskAllCompleted;

		// Token: 0x0400748E RID: 29838
		[Token(Token = "0x400748E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_GetCurrMonthTaskUpdateData;

		// Token: 0x0400748F RID: 29839
		[Token(Token = "0x400748F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_NeedEntryDLCTrackPoint;

		// Token: 0x04007490 RID: 29840
		[Token(Token = "0x4007490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_NeedEntryReviewTrackPointAllTopic;

		// Token: 0x04007491 RID: 29841
		[Token(Token = "0x4007491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_NeedEntryReviewTrackPoint;

		// Token: 0x04007492 RID: 29842
		[Token(Token = "0x4007492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_ConsumeEntryTrackPoint;

		// Token: 0x04007493 RID: 29843
		[Token(Token = "0x4007493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__ConsumeEntryDLCTrackPoint;

		// Token: 0x04007494 RID: 29844
		[Token(Token = "0x4007494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__ConsumeEntryReviewTrackPoint;

		// Token: 0x04007495 RID: 29845
		[Token(Token = "0x4007495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_ConsumeExpiredEntryTrackPoint;

		// Token: 0x04007496 RID: 29846
		[Token(Token = "0x4007496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_NeedMonthRefreshTrackPoint;

		// Token: 0x04007497 RID: 29847
		[Token(Token = "0x4007497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_ConsumeMonthRefreshTrackPoint;

		// Token: 0x04007498 RID: 29848
		[Token(Token = "0x4007498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_NeedModeOpenTrackPoint;

		// Token: 0x04007499 RID: 29849
		[Token(Token = "0x4007499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_ConsumeModeOpenTrackPoint;

		// Token: 0x0400749A RID: 29850
		[Token(Token = "0x400749A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_GetRoguelikeGameGold;

		// Token: 0x0400749B RID: 29851
		[Token(Token = "0x400749B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_GetBankCountFormatStr;

		// Token: 0x0400749C RID: 29852
		[Token(Token = "0x400749C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_GetRoguelikeBankMaxGold;

		// Token: 0x0400749D RID: 29853
		[Token(Token = "0x400749D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_IsBankGoldMax;

		// Token: 0x0400749E RID: 29854
		[Token(Token = "0x400749E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_GetBankLockSlotCount;

		// Token: 0x0400749F RID: 29855
		[Token(Token = "0x400749F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_GetBankRewardAccumulatedCount;

		// Token: 0x040074A0 RID: 29856
		[Token(Token = "0x40074A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_CheckLevelUpStatus;

		// Token: 0x040074A1 RID: 29857
		[Token(Token = "0x40074A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_GetItemType;

		// Token: 0x040074A2 RID: 29858
		[Token(Token = "0x40074A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GetItemName;

		// Token: 0x040074A3 RID: 29859
		[Token(Token = "0x40074A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_GetGoldItemName;

		// Token: 0x040074A4 RID: 29860
		[Token(Token = "0x40074A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_GetPopulationItemName;

		// Token: 0x040074A5 RID: 29861
		[Token(Token = "0x40074A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_GetCopperGildName;

		// Token: 0x040074A6 RID: 29862
		[Token(Token = "0x40074A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_TryGetUpgradeTicketFromItem;

		// Token: 0x040074A7 RID: 29863
		[Token(Token = "0x40074A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_TryGetTreasureData;

		// Token: 0x040074A8 RID: 29864
		[Token(Token = "0x40074A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_IsUpgradeTicketItem;

		// Token: 0x040074A9 RID: 29865
		[Token(Token = "0x40074A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_GetUpgradableCharCount;

		// Token: 0x040074AA RID: 29866
		[Token(Token = "0x40074AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_CheckIfCanDice;

		// Token: 0x040074AB RID: 29867
		[Token(Token = "0x40074AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_CheckModuleValid;

		// Token: 0x040074AC RID: 29868
		[Token(Token = "0x40074AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_GetRecruitSimilarCharCount;

		// Token: 0x040074AD RID: 29869
		[Token(Token = "0x40074AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_TryGetRelicEffectiveCharCount;

		// Token: 0x040074AE RID: 29870
		[Token(Token = "0x40074AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_GetRelicFeatures;

		// Token: 0x040074AF RID: 29871
		[Token(Token = "0x40074AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_GetOutBuffs;

		// Token: 0x040074B0 RID: 29872
		[Token(Token = "0x40074B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_GetCharBuffType;

		// Token: 0x040074B1 RID: 29873
		[Token(Token = "0x40074B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_GetCharBuffs;

		// Token: 0x040074B2 RID: 29874
		[Token(Token = "0x40074B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_CheckCharHasTargetBuff;

		// Token: 0x040074B3 RID: 29875
		[Token(Token = "0x40074B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_GetCandleBuffId;

		// Token: 0x040074B4 RID: 29876
		[Token(Token = "0x40074B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_GetHasCandleHolderBuffCharDict;

		// Token: 0x040074B5 RID: 29877
		[Token(Token = "0x40074B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_CheckIsCandleBattleStage;

		// Token: 0x040074B6 RID: 29878
		[Token(Token = "0x40074B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_GetIsGetCandleTicketRecruit;

		// Token: 0x040074B7 RID: 29879
		[Token(Token = "0x40074B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_GetCandleRecruitCharStatus;

		// Token: 0x040074B8 RID: 29880
		[Token(Token = "0x40074B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_CreateBattlePlayerData;

		// Token: 0x040074B9 RID: 29881
		[Token(Token = "0x40074B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_GetCharInTroop;

		// Token: 0x040074BA RID: 29882
		[Token(Token = "0x40074BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_GenerateSkillViewModel;

		// Token: 0x040074BB RID: 29883
		[Token(Token = "0x40074BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_GetCurrCapsuleId;

		// Token: 0x040074BC RID: 29884
		[Token(Token = "0x40074BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_GetCurrTrapId;

		// Token: 0x040074BD RID: 29885
		[Token(Token = "0x40074BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_GetHomeEntryDisplayId;

		// Token: 0x040074BE RID: 29886
		[Token(Token = "0x40074BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_GetHomeEntryDisplayIdForToDoListItem;

		// Token: 0x040074BF RID: 29887
		[Token(Token = "0x40074BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_IsTopicAccessible;

		// Token: 0x040074C0 RID: 29888
		[Token(Token = "0x40074C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_FindBestTopic;

		// Token: 0x040074C1 RID: 29889
		[Token(Token = "0x40074C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_CheckIfNormalGameMode;

		// Token: 0x040074C2 RID: 29890
		[Token(Token = "0x40074C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_GetDifficultyData;

		// Token: 0x040074C3 RID: 29891
		[Token(Token = "0x40074C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_GetMostDifficultyByMode;

		// Token: 0x040074C4 RID: 29892
		[Token(Token = "0x40074C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_IsCurrentGameNormalMode;

		// Token: 0x040074C5 RID: 29893
		[Token(Token = "0x40074C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_CheckOpenTime;

		// Token: 0x040074C6 RID: 29894
		[Token(Token = "0x40074C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_GetChatUnlockStatus;

		// Token: 0x040074C7 RID: 29895
		[Token(Token = "0x40074C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_GetLastChatUnlockedItemData;

		// Token: 0x040074C8 RID: 29896
		[Token(Token = "0x40074C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_GetUnlockedArchiveChatItems;

		// Token: 0x040074C9 RID: 29897
		[Token(Token = "0x40074C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_GetRoguelikeTopicArchiveChatUnlockInfo;

		// Token: 0x040074CA RID: 29898
		[Token(Token = "0x40074CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0_GetRoguelikeTopicArchiveEndUnlock;

		// Token: 0x040074CB RID: 29899
		[Token(Token = "0x40074CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_GetOuterBuffItemIdAndName;

		// Token: 0x040074CC RID: 29900
		[Token(Token = "0x40074CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_IsTopicBpPurchaseAvailable;

		// Token: 0x040074CD RID: 29901
		[Token(Token = "0x40074CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_GetBpSystemName;

		// Token: 0x040074CE RID: 29902
		[Token(Token = "0x40074CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_GetBpItemName;

		// Token: 0x040074CF RID: 29903
		[Token(Token = "0x40074CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_GetBattlePassUpdateName;

		// Token: 0x040074D0 RID: 29904
		[Token(Token = "0x40074D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_GetMonthModeName;

		// Token: 0x040074D1 RID: 29905
		[Token(Token = "0x40074D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_GetTopicName;

		// Token: 0x040074D2 RID: 29906
		[Token(Token = "0x40074D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_TryGetCurrentValidRogueActivityId;

		// Token: 0x040074D3 RID: 29907
		[Token(Token = "0x40074D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_GetRoguelikeActivityBasicData;

		// Token: 0x040074D4 RID: 29908
		[Token(Token = "0x40074D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_CullLocalizationFromPasteContent;

		// Token: 0x040074D5 RID: 29909
		[Token(Token = "0x40074D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_GetSeedStringFromPasteContent;

		// Token: 0x040074D6 RID: 29910
		[Token(Token = "0x40074D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_CopyFormatSeedString;

		// Token: 0x040074D7 RID: 29911
		[Token(Token = "0x40074D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_GetSeedGradeFromSeed;

		// Token: 0x040074D8 RID: 29912
		[Token(Token = "0x40074D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_GetSeedTopicIdFromSeed;

		// Token: 0x040074D9 RID: 29913
		[Token(Token = "0x40074D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_CheckNeedTrigMonthChatWithTopic;

		// Token: 0x040074DA RID: 29914
		[Token(Token = "0x40074DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_GetExpeditionReturnDesc;

		// Token: 0x040074DB RID: 29915
		[Token(Token = "0x40074DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_GetTravelReturnDesc;

		// Token: 0x040074DC RID: 29916
		[Token(Token = "0x40074DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_GetCandleReturnDesc;

		// Token: 0x040074DD RID: 29917
		[Token(Token = "0x40074DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_GetRewardItemDesc;

		// Token: 0x040074DE RID: 29918
		[Token(Token = "0x40074DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_GetRewardExDropTagSrcType;

		// Token: 0x040074DF RID: 29919
		[Token(Token = "0x40074DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0_CheckIfInPortal;

		// Token: 0x040074E0 RID: 29920
		[Token(Token = "0x40074E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_GetRouteNeedItemCount;

		// Token: 0x040074E1 RID: 29921
		[Token(Token = "0x40074E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_CheckIfNeedSpZonePlugin;

		// Token: 0x040074E2 RID: 29922
		[Token(Token = "0x40074E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private static DelegateBridge __Hotfix0_GetInitPredefinedStyle;

		// Token: 0x040074E3 RID: 29923
		[Token(Token = "0x40074E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private static DelegateBridge __Hotfix0_GetRoguelikeTopicDetailConst;

		// Token: 0x040074E4 RID: 29924
		[Token(Token = "0x40074E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		private static DelegateBridge __Hotfix0_GetRoguelikeTopicGameConst;

		// Token: 0x040074E5 RID: 29925
		[Token(Token = "0x40074E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		private static DelegateBridge __Hotfix0_IsSpExpStyleWithInitPredefinedStyle;

		// Token: 0x040074E6 RID: 29926
		[Token(Token = "0x40074E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		private static DelegateBridge __Hotfix0_GetNormalLevelDataTable;

		// Token: 0x040074E7 RID: 29927
		[Token(Token = "0x40074E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		private static DelegateBridge __Hotfix0_GetTargetPredefinedLevelDataTable;

		// Token: 0x040074E8 RID: 29928
		[Token(Token = "0x40074E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		private static DelegateBridge __Hotfix0_GetLevelDataTableConsideringPredefined;

		// Token: 0x040074E9 RID: 29929
		[Token(Token = "0x40074E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private static DelegateBridge __Hotfix0_GetLevelTargetDataFromTable;

		// Token: 0x040074EA RID: 29930
		[Token(Token = "0x40074EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		private static DelegateBridge __Hotfix0_GetLevelWithExp;

		// Token: 0x040074EB RID: 29931
		[Token(Token = "0x40074EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		private static DelegateBridge __Hotfix0_GetPredefinedLevelTableKey;

		// Token: 0x040074EC RID: 29932
		[Token(Token = "0x40074EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		private static DelegateBridge __Hotfix0_TryGetExpStyleRewardLoseHpTitle;

		// Token: 0x040074ED RID: 29933
		[Token(Token = "0x40074ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		private static DelegateBridge __Hotfix0_CheckNodeUpgradeStatus;

		// Token: 0x040074EE RID: 29934
		[Token(Token = "0x40074EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		private static DelegateBridge __Hotfix0_LoadFirstPermNodeUpgradeData;

		// Token: 0x040074EF RID: 29935
		[Token(Token = "0x40074EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		private static DelegateBridge __Hotfix0_LoadLastPermNodeUpgradeData;

		// Token: 0x040074F0 RID: 29936
		[Token(Token = "0x40074F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private static DelegateBridge __Hotfix0_ConstructDefaultComparers;

		// Token: 0x0200142B RID: 5163
		[Token(Token = "0x200142B")]
		public struct ChatUnlockStatus
		{
			// Token: 0x06007781 RID: 30593 RVA: 0x000359D0 File Offset: 0x00033BD0
			[Token(Token = "0x6007781")]
			[Address(RVA = "0x1F00EC0", Offset = "0x1EFFAC0", VA = "0x181F00EC0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x040074F1 RID: 29937
			[Token(Token = "0x40074F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly RoguelikeDataUtil.ChatUnlockStatus EMPTY;

			// Token: 0x040074F2 RID: 29938
			[Token(Token = "0x40074F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string topicId;

			// Token: 0x040074F3 RID: 29939
			[Token(Token = "0x40074F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string teamId;

			// Token: 0x040074F4 RID: 29940
			[Token(Token = "0x40074F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string curZoneId;

			// Token: 0x040074F5 RID: 29941
			[Token(Token = "0x40074F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ActArchiveChatGroupData chatGroup;
		}
	}
}
