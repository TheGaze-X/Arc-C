using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002078 RID: 8312
	[Token(Token = "0x2002078")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class LocalTrackGenerator
	{
		// Token: 0x0600CCDC RID: 52444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCDC")]
		[Address(RVA = "0x34D7FC0", Offset = "0x34D6BC0", VA = "0x1834D7FC0")]
		private static void _AddAct1MainSSTrackPointTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCDD RID: 52445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCDD")]
		[Address(RVA = "0x34DCFC0", Offset = "0x34DBBC0", VA = "0x1834DCFC0")]
		private static void _AddTracksForAct1MainSS(string stageId, Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCDE RID: 52446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCDE")]
		[Address(RVA = "0x34D8150", Offset = "0x34D6D50", VA = "0x1834D8150")]
		private static void _AddAct1VHalfIdleTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCDF RID: 52447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCDF")]
		[Address(RVA = "0x34DD100", Offset = "0x34DBD00", VA = "0x1834DD100")]
		private static void _AddTracksForAct1VHalfIdle(string actId, Act1VHalfIdleData actData, Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCE0 RID: 52448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE0")]
		[Address(RVA = "0x34DEA90", Offset = "0x34DD690", VA = "0x1834DEA90")]
		private static void _AddTriggerForNewStage(Action<TrackTrigger> addTrigger, string newTrackType, string stageId, long ts)
		{
		}

		// Token: 0x0600CCE1 RID: 52449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE1")]
		[Address(RVA = "0x34DE920", Offset = "0x34DD520", VA = "0x1834DE920")]
		private static void _AddTriggerForHardStage(Action<TrackTrigger> addTrigger, string hardTrackType, string stageId, StageData stageData)
		{
		}

		// Token: 0x0600CCE2 RID: 52450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE2")]
		[Address(RVA = "0x34D7C50", Offset = "0x34D6850", VA = "0x1834D7C50")]
		private static void _Act20sideTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCE3 RID: 52451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE3")]
		[Address(RVA = "0x34DE2E0", Offset = "0x34DCEE0", VA = "0x1834DE2E0")]
		private static void _AddTracksForCar(CartData actData, Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCE4 RID: 52452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCE4")]
		[Address(RVA = "0x34DF5A0", Offset = "0x34DE1A0", VA = "0x1834DF5A0")]
		private static CarCondTrigger _CreateAct20sideCar(string compId)
		{
			return null;
		}

		// Token: 0x0600CCE5 RID: 52453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE5")]
		[Address(RVA = "0x34D8890", Offset = "0x34D7490", VA = "0x1834D8890")]
		public static void _AddAct42D0Tracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCE6 RID: 52454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE6")]
		[Address(RVA = "0x34D7640", Offset = "0x34D6240", VA = "0x1834D7640")]
		private static void _Act13SideTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCE7 RID: 52455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCE7")]
		[Address(RVA = "0x34DCC80", Offset = "0x34DB880", VA = "0x1834DCC80")]
		private static void _AddTracksForAct13Side(string actId, Act13SideData actData, Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCE8 RID: 52456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCE8")]
		[Address(RVA = "0x34DF1C0", Offset = "0x34DDDC0", VA = "0x1834DF1C0")]
		private static ItemCondTrigger _CreateAct13SideArchivePrestigeTrigger(Act13SideData actData, Act13SideData.ArchiveItemUnlockData unlockData)
		{
			return null;
		}

		// Token: 0x0600CCE9 RID: 52457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCE9")]
		[Address(RVA = "0x34DF0A0", Offset = "0x34DDCA0", VA = "0x1834DF0A0")]
		private static StageCondTrigger _CreateAc13SideArchiveStageTrigger(Act13SideData.ArchiveItemUnlockData unlockData)
		{
			return null;
		}

		// Token: 0x0600CCEA RID: 52458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCEA")]
		[Address(RVA = "0x34D7950", Offset = "0x34D6550", VA = "0x1834D7950")]
		private static void _Act17sideTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCEB RID: 52459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCEB")]
		[Address(RVA = "0x34DCE30", Offset = "0x34DBA30", VA = "0x1834DCE30")]
		private static void _AddTracksForAct17side(string actId, Act17sideData actData, Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCEC RID: 52460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCEC")]
		[Address(RVA = "0x34DF3A0", Offset = "0x34DDFA0", VA = "0x1834DF3A0")]
		private static DeepSeaNodeCondTrigger _CreateAct17sideArchiveNodeTrigger(Act17sideData.ArchiveItemUnlockData unlockData)
		{
			return null;
		}

		// Token: 0x0600CCED RID: 52461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCED")]
		[Address(RVA = "0x34DF490", Offset = "0x34DE090", VA = "0x1834DF490")]
		private static StageCondTrigger _CreateAct17sideArchiveStageTrigger(Act17sideData.ArchiveItemUnlockData unlockData)
		{
			return null;
		}

		// Token: 0x0600CCEE RID: 52462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCEE")]
		[Address(RVA = "0x34D82A0", Offset = "0x34D6EA0", VA = "0x1834D82A0")]
		private static void _AddAct24sideTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCEF RID: 52463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCEF")]
		[Address(RVA = "0x34DDD30", Offset = "0x34DC930", VA = "0x1834DDD30")]
		private static void _AddTracksForAct24side(string actId, Act24SideData actData, Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCF0 RID: 52464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCF0")]
		[Address(RVA = "0x34D8400", Offset = "0x34D7000", VA = "0x1834D8400")]
		private static void _AddAct25sideTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCF1 RID: 52465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCF1")]
		[Address(RVA = "0x34DE080", Offset = "0x34DCC80", VA = "0x1834DE080")]
		private static void _AddTracksForAct25side(string actId, Act25SideData actData, Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCF2 RID: 52466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCF2")]
		[Address(RVA = "0x34D8560", Offset = "0x34D7160", VA = "0x1834D8560")]
		private static void _AddAct29SideTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCF3 RID: 52467 RVA: 0x00049EC0 File Offset: 0x000480C0
		[Token(Token = "0x600CCF3")]
		[Address(RVA = "0x34DFF40", Offset = "0x34DEB40", VA = "0x1834DFF40")]
		private static long _GetTuningUpdateTime()
		{
			return 0L;
		}

		// Token: 0x0600CCF4 RID: 52468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCF4")]
		[Address(RVA = "0x34D8C50", Offset = "0x34D7850", VA = "0x1834D8C50")]
		private static void _AddAct44SideTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCF5 RID: 52469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCF5")]
		[Address(RVA = "0x34D9000", Offset = "0x34D7C00", VA = "0x1834D9000")]
		private static void _AddActArcadeTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCF6 RID: 52470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCF6")]
		[Address(RVA = "0x34D7CE0", Offset = "0x34D68E0", VA = "0x1834D7CE0")]
		private static void _ActMainlineBpTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCF7 RID: 52471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CCF7")]
		[Address(RVA = "0x34DF940", Offset = "0x34DE540", VA = "0x1834DF940")]
		private static ActMainlineBpExtraData.ActMainlineBpExtraPeriodData _FindCurrentPeriodData(List<ActMainlineBpExtraData.ActMainlineBpExtraPeriodData> periodDataList, long currTs)
		{
			return null;
		}

		// Token: 0x0600CCF8 RID: 52472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCF8")]
		[Address(RVA = "0x34D93D0", Offset = "0x34D7FD0", VA = "0x1834D93D0")]
		private static void _AddActTimeTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCF9 RID: 52473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCF9")]
		[Address(RVA = "0x34D9670", Offset = "0x34D8270", VA = "0x1834D9670")]
		private static void _AddActVecBreakV2Tracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCFA RID: 52474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFA")]
		[Address(RVA = "0x34D9BB0", Offset = "0x34D87B0", VA = "0x1834D9BB0")]
		private static void _AddArtGalleryCollectTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCFB RID: 52475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFB")]
		[Address(RVA = "0x34D9FF0", Offset = "0x34D8BF0", VA = "0x1834D9FF0")]
		private static void _AddAutoChessTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCFC RID: 52476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFC")]
		[Address(RVA = "0x34DA490", Offset = "0x34D9090", VA = "0x1834DA490")]
		private static void _AddBuildingTimeCondTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCFD RID: 52477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFD")]
		[Address(RVA = "0x34DA270", Offset = "0x34D8E70", VA = "0x1834DA270")]
		private static void _AddBuildingMusicUnlockTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCFE RID: 52478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFE")]
		[Address(RVA = "0x34DA760", Offset = "0x34D9360", VA = "0x1834DA760")]
		private static void _AddCharRotationTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CCFF RID: 52479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCFF")]
		[Address(RVA = "0x34DAB10", Offset = "0x34D9710", VA = "0x1834DAB10")]
		private static void _AddCrossDayCondTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD00 RID: 52480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD00")]
		[Address(RVA = "0x34DA8C0", Offset = "0x34D94C0", VA = "0x1834DA8C0")]
		private static void _AddCrossDayCondTrackByType(Action<TrackTrigger> addTrigger, long nowPlayerDataUpdateTs, CrossDayTrackTypeData typeData)
		{
		}

		// Token: 0x0600CD01 RID: 52481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD01")]
		[Address(RVA = "0x34D99F0", Offset = "0x34D85F0", VA = "0x1834D99F0")]
		private static void _AddActivityCrossDayCondTracks(Action<TrackTrigger> addTrigger, long nowPlayerDataUpdateTs)
		{
		}

		// Token: 0x0600CD02 RID: 52482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD02")]
		[Address(RVA = "0x34DF710", Offset = "0x34DE310", VA = "0x1834DF710")]
		private static void _EnemyHandbookTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD03 RID: 52483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD03")]
		[Address(RVA = "0x34E17A0", Offset = "0x34E03A0", VA = "0x1834E17A0")]
		private static void _UniEquipStageTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD04 RID: 52484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD04")]
		[Address(RVA = "0x34DABF0", Offset = "0x34D97F0", VA = "0x1834DABF0")]
		private static void _AddFireworkTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD05 RID: 52485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD05")]
		[Address(RVA = "0x34DAF70", Offset = "0x34D9B70", VA = "0x1834DAF70")]
		private static void _AddFriendListTimeCondTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD06 RID: 52486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD06")]
		[Address(RVA = "0x34DFA30", Offset = "0x34DE630", VA = "0x1834DFA30")]
		private static void _FurnitureAndThemeTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD07 RID: 52487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD07")]
		[Address(RVA = "0x34E0010", Offset = "0x34DEC10", VA = "0x1834E0010")]
		private static void _HandbookStageTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD08 RID: 52488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD08")]
		[Address(RVA = "0x34DB0A0", Offset = "0x34D9CA0", VA = "0x1834DB0A0")]
		private static void _AddHomeArchiveTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD09 RID: 52489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD09")]
		[Address(RVA = "0x34D6850", Offset = "0x34D5450", VA = "0x1834D6850")]
		public static void Generate(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD0A RID: 52490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD0A")]
		[Address(RVA = "0x34E0220", Offset = "0x34DEE20", VA = "0x1834E0220")]
		private static void _LongTermCheckInTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD0B RID: 52491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD0B")]
		[Address(RVA = "0x34DB1E0", Offset = "0x34D9DE0", VA = "0x1834DB1E0")]
		private static void _AddMainZoneRewardBuffTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD0C RID: 52492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD0C")]
		[Address(RVA = "0x34DE540", Offset = "0x34DD140", VA = "0x1834DE540")]
		private static void _AddTracksForMainZoneRewardBuff(Action<TrackTrigger> addTrigger, string zoneId, long startTs)
		{
		}

		// Token: 0x0600CD0D RID: 52493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD0D")]
		[Address(RVA = "0x34DB430", Offset = "0x34DA030", VA = "0x1834DB430")]
		private static void _AddNameCardSkinTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD0E RID: 52494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD0E")]
		[Address(RVA = "0x34E0420", Offset = "0x34DF020", VA = "0x1834E0420")]
		private static void _PCKeySettingTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD0F RID: 52495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD0F")]
		[Address(RVA = "0x34DB6D0", Offset = "0x34DA2D0", VA = "0x1834DB6D0")]
		private static void _AddPermModeTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD10 RID: 52496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD10")]
		[Address(RVA = "0x34DBEA0", Offset = "0x34DAAA0", VA = "0x1834DBEA0")]
		private static void _AddRecalRuneSeasonTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD11 RID: 52497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD11")]
		[Address(RVA = "0x34DC1C0", Offset = "0x34DADC0", VA = "0x1834DC1C0")]
		private static void _AddRoguelikeActivityTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD12 RID: 52498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD12")]
		[Address(RVA = "0x34E0710", Offset = "0x34DF310", VA = "0x1834E0710")]
		private static void _RoguelikeTopicMonthRefreshTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD13 RID: 52499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD13")]
		[Address(RVA = "0x34DFE50", Offset = "0x34DEA50", VA = "0x1834DFE50")]
		private static string _GetTrackIdByEnrollType(RoguelikeEnrollType enrollType)
		{
			return null;
		}

		// Token: 0x0600CD14 RID: 52500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD14")]
		[Address(RVA = "0x34DC540", Offset = "0x34DB140", VA = "0x1834DC540")]
		private static void _AddSandboxV2Tracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD15 RID: 52501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD15")]
		[Address(RVA = "0x34DC9B0", Offset = "0x34DB5B0", VA = "0x1834DC9B0")]
		private static void _AddStoryReadTipsTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD16 RID: 52502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD16")]
		[Address(RVA = "0x34E11D0", Offset = "0x34DFDD0", VA = "0x1834E11D0")]
		private static void _TrainingCampTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD17 RID: 52503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD17")]
		[Address(RVA = "0x34DFC70", Offset = "0x34DE870", VA = "0x1834DFC70")]
		private static NewTrainingCampStageData _GetNearestNewTrainingCampStageData(long curTs)
		{
			return null;
		}

		// Token: 0x0600CD18 RID: 52504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD18")]
		[Address(RVA = "0x34DEB90", Offset = "0x34DD790", VA = "0x1834DEB90")]
		private static void _AddUniEquipArchiveSysTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD19 RID: 52505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD19")]
		[Address(RVA = "0x34DED70", Offset = "0x34DD970", VA = "0x1834DED70")]
		private static void _AddUniqueOnlyTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD1A RID: 52506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD1A")]
		[Address(RVA = "0x34E1B00", Offset = "0x34E0700", VA = "0x1834E1B00")]
		private static void _VoiceLangTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD1B RID: 52507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD1B")]
		[Address(RVA = "0x34E1080", Offset = "0x34DFC80", VA = "0x1834E1080")]
		private static void _TemplateTrapTracks(Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD1C RID: 52508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD1C")]
		[Address(RVA = "0x34DE660", Offset = "0x34DD260", VA = "0x1834DE660")]
		private static void _AddTracksForTemplateTrap(string domainId, ActivityTable.ActivityTrapsData trapData, Action<TrackTrigger> addTrigger)
		{
		}

		// Token: 0x0600CD1D RID: 52509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD1D")]
		[Address(RVA = "0x34DF640", Offset = "0x34DE240", VA = "0x1834DF640")]
		private static TemplateTrapCondTrigger _CreateTemplateTrapTrigger(string domainId, string trapId)
		{
			return null;
		}

		// Token: 0x0400D819 RID: 55321
		[Token(Token = "0x400D819")]
		public const string CAR_ACT_PARAM = "CART";

		// Token: 0x0400D81A RID: 55322
		[Token(Token = "0x400D81A")]
		private const string PC_KEY_SETTING_TRACK_ID_FORMAT = "{0}_{1}";

		// Token: 0x0400D81B RID: 55323
		[Token(Token = "0x400D81B")]
		private const string TRAINING_ENTRANCE_ID = "TRAINING_ENTRANCE";

		// Token: 0x0400D81C RID: 55324
		[Token(Token = "0x400D81C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__AddAct1MainSSTrackPointTracks;

		// Token: 0x0400D81D RID: 55325
		[Token(Token = "0x400D81D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__AddTracksForAct1MainSS;

		// Token: 0x0400D81E RID: 55326
		[Token(Token = "0x400D81E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AddAct1VHalfIdleTracks;

		// Token: 0x0400D81F RID: 55327
		[Token(Token = "0x400D81F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__AddTracksForAct1VHalfIdle;

		// Token: 0x0400D820 RID: 55328
		[Token(Token = "0x400D820")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AddTriggerForNewStage;

		// Token: 0x0400D821 RID: 55329
		[Token(Token = "0x400D821")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AddTriggerForHardStage;

		// Token: 0x0400D822 RID: 55330
		[Token(Token = "0x400D822")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Act20sideTracks;

		// Token: 0x0400D823 RID: 55331
		[Token(Token = "0x400D823")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__AddTracksForCar;

		// Token: 0x0400D824 RID: 55332
		[Token(Token = "0x400D824")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CreateAct20sideCar;

		// Token: 0x0400D825 RID: 55333
		[Token(Token = "0x400D825")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__AddAct42D0Tracks;

		// Token: 0x0400D826 RID: 55334
		[Token(Token = "0x400D826")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__Act13SideTracks;

		// Token: 0x0400D827 RID: 55335
		[Token(Token = "0x400D827")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__AddTracksForAct13Side;

		// Token: 0x0400D828 RID: 55336
		[Token(Token = "0x400D828")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CreateAct13SideArchivePrestigeTrigger;

		// Token: 0x0400D829 RID: 55337
		[Token(Token = "0x400D829")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateAc13SideArchiveStageTrigger;

		// Token: 0x0400D82A RID: 55338
		[Token(Token = "0x400D82A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__Act17sideTracks;

		// Token: 0x0400D82B RID: 55339
		[Token(Token = "0x400D82B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__AddTracksForAct17side;

		// Token: 0x0400D82C RID: 55340
		[Token(Token = "0x400D82C")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__CreateAct17sideArchiveNodeTrigger;

		// Token: 0x0400D82D RID: 55341
		[Token(Token = "0x400D82D")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CreateAct17sideArchiveStageTrigger;

		// Token: 0x0400D82E RID: 55342
		[Token(Token = "0x400D82E")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__AddAct24sideTracks;

		// Token: 0x0400D82F RID: 55343
		[Token(Token = "0x400D82F")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__AddTracksForAct24side;

		// Token: 0x0400D830 RID: 55344
		[Token(Token = "0x400D830")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__AddAct25sideTracks;

		// Token: 0x0400D831 RID: 55345
		[Token(Token = "0x400D831")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__AddTracksForAct25side;

		// Token: 0x0400D832 RID: 55346
		[Token(Token = "0x400D832")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__AddAct29SideTracks;

		// Token: 0x0400D833 RID: 55347
		[Token(Token = "0x400D833")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__GetTuningUpdateTime;

		// Token: 0x0400D834 RID: 55348
		[Token(Token = "0x400D834")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__AddAct44SideTracks;

		// Token: 0x0400D835 RID: 55349
		[Token(Token = "0x400D835")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__AddActArcadeTracks;

		// Token: 0x0400D836 RID: 55350
		[Token(Token = "0x400D836")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ActMainlineBpTracks;

		// Token: 0x0400D837 RID: 55351
		[Token(Token = "0x400D837")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__FindCurrentPeriodData;

		// Token: 0x0400D838 RID: 55352
		[Token(Token = "0x400D838")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__AddActTimeTracks;

		// Token: 0x0400D839 RID: 55353
		[Token(Token = "0x400D839")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__AddActVecBreakV2Tracks;

		// Token: 0x0400D83A RID: 55354
		[Token(Token = "0x400D83A")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__AddArtGalleryCollectTracks;

		// Token: 0x0400D83B RID: 55355
		[Token(Token = "0x400D83B")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__AddAutoChessTracks;

		// Token: 0x0400D83C RID: 55356
		[Token(Token = "0x400D83C")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__AddBuildingTimeCondTracks;

		// Token: 0x0400D83D RID: 55357
		[Token(Token = "0x400D83D")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__AddBuildingMusicUnlockTracks;

		// Token: 0x0400D83E RID: 55358
		[Token(Token = "0x400D83E")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__AddCharRotationTracks;

		// Token: 0x0400D83F RID: 55359
		[Token(Token = "0x400D83F")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__AddCrossDayCondTracks;

		// Token: 0x0400D840 RID: 55360
		[Token(Token = "0x400D840")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__AddCrossDayCondTrackByType;

		// Token: 0x0400D841 RID: 55361
		[Token(Token = "0x400D841")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__AddActivityCrossDayCondTracks;

		// Token: 0x0400D842 RID: 55362
		[Token(Token = "0x400D842")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__EnemyHandbookTracks;

		// Token: 0x0400D843 RID: 55363
		[Token(Token = "0x400D843")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__UniEquipStageTracks;

		// Token: 0x0400D844 RID: 55364
		[Token(Token = "0x400D844")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__AddFireworkTracks;

		// Token: 0x0400D845 RID: 55365
		[Token(Token = "0x400D845")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__AddFriendListTimeCondTracks;

		// Token: 0x0400D846 RID: 55366
		[Token(Token = "0x400D846")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__FurnitureAndThemeTracks;

		// Token: 0x0400D847 RID: 55367
		[Token(Token = "0x400D847")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__HandbookStageTracks;

		// Token: 0x0400D848 RID: 55368
		[Token(Token = "0x400D848")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__AddHomeArchiveTracks;

		// Token: 0x0400D849 RID: 55369
		[Token(Token = "0x400D849")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_Generate;

		// Token: 0x0400D84A RID: 55370
		[Token(Token = "0x400D84A")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__LongTermCheckInTracks;

		// Token: 0x0400D84B RID: 55371
		[Token(Token = "0x400D84B")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__AddMainZoneRewardBuffTracks;

		// Token: 0x0400D84C RID: 55372
		[Token(Token = "0x400D84C")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__AddTracksForMainZoneRewardBuff;

		// Token: 0x0400D84D RID: 55373
		[Token(Token = "0x400D84D")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__AddNameCardSkinTracks;

		// Token: 0x0400D84E RID: 55374
		[Token(Token = "0x400D84E")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__PCKeySettingTracks;

		// Token: 0x0400D84F RID: 55375
		[Token(Token = "0x400D84F")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__AddPermModeTracks;

		// Token: 0x0400D850 RID: 55376
		[Token(Token = "0x400D850")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__AddRecalRuneSeasonTracks;

		// Token: 0x0400D851 RID: 55377
		[Token(Token = "0x400D851")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__AddRoguelikeActivityTracks;

		// Token: 0x0400D852 RID: 55378
		[Token(Token = "0x400D852")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__RoguelikeTopicMonthRefreshTracks;

		// Token: 0x0400D853 RID: 55379
		[Token(Token = "0x400D853")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__GetTrackIdByEnrollType;

		// Token: 0x0400D854 RID: 55380
		[Token(Token = "0x400D854")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__AddSandboxV2Tracks;

		// Token: 0x0400D855 RID: 55381
		[Token(Token = "0x400D855")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__AddStoryReadTipsTracks;

		// Token: 0x0400D856 RID: 55382
		[Token(Token = "0x400D856")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__TrainingCampTracks;

		// Token: 0x0400D857 RID: 55383
		[Token(Token = "0x400D857")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__GetNearestNewTrainingCampStageData;

		// Token: 0x0400D858 RID: 55384
		[Token(Token = "0x400D858")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__AddUniEquipArchiveSysTracks;

		// Token: 0x0400D859 RID: 55385
		[Token(Token = "0x400D859")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__AddUniqueOnlyTracks;

		// Token: 0x0400D85A RID: 55386
		[Token(Token = "0x400D85A")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0__VoiceLangTracks;

		// Token: 0x0400D85B RID: 55387
		[Token(Token = "0x400D85B")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0__TemplateTrapTracks;

		// Token: 0x0400D85C RID: 55388
		[Token(Token = "0x400D85C")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0__AddTracksForTemplateTrap;

		// Token: 0x0400D85D RID: 55389
		[Token(Token = "0x400D85D")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0__CreateTemplateTrapTrigger;
	}
}
