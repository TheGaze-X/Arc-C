using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Mission;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003872 RID: 14450
	[Token(Token = "0x2003872")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class UIRouteUtil
	{
		// Token: 0x06016E08 RID: 93704 RVA: 0x00093798 File Offset: 0x00091998
		[Token(Token = "0x6016E08")]
		[Address(RVA = "0xF621A0", Offset = "0xF60DA0", VA = "0x180F621A0")]
		public static bool RouteToTarget(UIRouteTarget target, [Optional] object param)
		{
			return default(bool);
		}

		// Token: 0x06016E09 RID: 93705 RVA: 0x000937B0 File Offset: 0x000919B0
		[Token(Token = "0x6016E09")]
		[Address(RVA = "0xF644B0", Offset = "0xF630B0", VA = "0x180F644B0")]
		private static bool _RouteSceneHome(UIRouteTarget target, object param)
		{
			return default(bool);
		}

		// Token: 0x06016E0A RID: 93706 RVA: 0x000937C8 File Offset: 0x000919C8
		[Token(Token = "0x6016E0A")]
		[Address(RVA = "0xF64140", Offset = "0xF62D40", VA = "0x180F64140")]
		private static bool _RouteSceneBuilding(UIRouteTarget target, object param)
		{
			return default(bool);
		}

		// Token: 0x06016E0B RID: 93707 RVA: 0x000937E0 File Offset: 0x000919E0
		[Token(Token = "0x6016E0B")]
		[Address(RVA = "0xF64870", Offset = "0xF63470", VA = "0x180F64870")]
		private static bool _RouteSceneOthers(UIRouteTarget target)
		{
			return default(bool);
		}

		// Token: 0x06016E0C RID: 93708 RVA: 0x000937F8 File Offset: 0x000919F8
		[Token(Token = "0x6016E0C")]
		[Address(RVA = "0xF64D00", Offset = "0xF63900", VA = "0x180F64D00")]
		private static BuildingData.RoomType _RouteTargetToRoomType(UIRouteTarget target)
		{
			return BuildingData.RoomType.NONE;
		}

		// Token: 0x06016E0D RID: 93709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016E0D")]
		[Address(RVA = "0xF64B00", Offset = "0xF63700", VA = "0x180F64B00")]
		private static string _RouteTargetToPageName(UIRouteTarget target)
		{
			return null;
		}

		// Token: 0x06016E0E RID: 93710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016E0E")]
		[Address(RVA = "0xF627D0", Offset = "0xF613D0", VA = "0x180F627D0")]
		private static object _GetArgumentFromRouteTarget(UIRouteTarget target, object param)
		{
			return null;
		}

		// Token: 0x06016E0F RID: 93711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016E0F")]
		[Address(RVA = "0xF63EA0", Offset = "0xF62AA0", VA = "0x180F63EA0")]
		private static UIPageControllerParam _ParsePageControllerParamForHome(UIRouteTarget target)
		{
			return null;
		}

		// Token: 0x06016E10 RID: 93712 RVA: 0x00093810 File Offset: 0x00091A10
		[Token(Token = "0x6016E10")]
		[Address(RVA = "0xF60240", Offset = "0xF5EE40", VA = "0x180F60240")]
		public static bool IsRouteToStageSupported()
		{
			return default(bool);
		}

		// Token: 0x06016E11 RID: 93713 RVA: 0x00093828 File Offset: 0x00091A28
		[Token(Token = "0x6016E11")]
		[Address(RVA = "0xF601C0", Offset = "0xF5EDC0", VA = "0x180F601C0")]
		public static bool IsRouteToBuildingSupported()
		{
			return default(bool);
		}

		// Token: 0x06016E12 RID: 93714 RVA: 0x00093840 File Offset: 0x00091A40
		[Token(Token = "0x6016E12")]
		[Address(RVA = "0xF62B70", Offset = "0xF61770", VA = "0x180F62B70")]
		private static bool _IsRouteSupported()
		{
			return default(bool);
		}

		// Token: 0x06016E13 RID: 93715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E13")]
		[Address(RVA = "0xF620A0", Offset = "0xF60CA0", VA = "0x180F620A0")]
		public static void RouteToStage(string zoneId, string stageId)
		{
		}

		// Token: 0x06016E14 RID: 93716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E14")]
		[Address(RVA = "0xF622F0", Offset = "0xF60EF0", VA = "0x180F622F0")]
		public static void RouteToZoneViewType(ZoneViewType zoneViewType)
		{
		}

		// Token: 0x06016E15 RID: 93717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E15")]
		[Address(RVA = "0xF61000", Offset = "0xF5FC00", VA = "0x180F61000")]
		public static void RouteToMixStory(bool focusLastUnlockedMainline)
		{
		}

		// Token: 0x06016E16 RID: 93718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E16")]
		[Address(RVA = "0xF602C0", Offset = "0xF5EEC0", VA = "0x180F602C0")]
		public static void RouteToCampaign([Optional] string zoneId, [Optional] string stageId)
		{
		}

		// Token: 0x06016E17 RID: 93719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E17")]
		[Address(RVA = "0xF605B0", Offset = "0xF5F1B0", VA = "0x180F605B0")]
		public static void RouteToClimbTower()
		{
		}

		// Token: 0x06016E18 RID: 93720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E18")]
		[Address(RVA = "0xF61DB0", Offset = "0xF609B0", VA = "0x180F61DB0")]
		public static void RouteToStageActivity(string activityId)
		{
		}

		// Token: 0x06016E19 RID: 93721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016E19")]
		[Address(RVA = "0xF62910", Offset = "0xF61510", VA = "0x180F62910")]
		private static List<UIPageStackParam.StackElement> _GetDefaultStageActivityRouteStack(string activityId)
		{
			return null;
		}

		// Token: 0x06016E1A RID: 93722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E1A")]
		[Address(RVA = "0xF60AD0", Offset = "0xF5F6D0", VA = "0x180F60AD0")]
		public static void RouteToHomeThemeState(string themeId)
		{
		}

		// Token: 0x06016E1B RID: 93723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E1B")]
		[Address(RVA = "0xF65090", Offset = "0xF63C90", VA = "0x180F65090")]
		private static void _RouteToHomeThemeStateOthers(string themeId)
		{
		}

		// Token: 0x06016E1C RID: 93724 RVA: 0x00093858 File Offset: 0x00091A58
		[Token(Token = "0x6016E1C")]
		[Address(RVA = "0xF63380", Offset = "0xF61F80", VA = "0x180F63380")]
		private static UIPageStackParam _PageStackParamToHomeThemeState(string themeId)
		{
			return default(UIPageStackParam);
		}

		// Token: 0x06016E1D RID: 93725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E1D")]
		[Address(RVA = "0xF614A0", Offset = "0xF600A0", VA = "0x180F614A0")]
		public static void RouteToRoguelikeTopic(string topicId)
		{
		}

		// Token: 0x06016E1E RID: 93726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E1E")]
		[Address(RVA = "0xF611A0", Offset = "0xF5FDA0", VA = "0x180F611A0")]
		public static void RouteToRogueSpecialOperator(string topicId, string charId)
		{
		}

		// Token: 0x06016E1F RID: 93727 RVA: 0x00093870 File Offset: 0x00091A70
		[Token(Token = "0x6016E1F")]
		[Address(RVA = "0xF623D0", Offset = "0xF60FD0", VA = "0x180F623D0")]
		private static ValueTuple<bool, List<UIPageStackParam.StackElement>> _GenerateRoguelikeTopicRouteStack(string topicId)
		{
			return default(ValueTuple<bool, List<UIPageStackParam.StackElement>>);
		}

		// Token: 0x06016E20 RID: 93728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E20")]
		[Address(RVA = "0xF61690", Offset = "0xF60290", VA = "0x180F61690")]
		public static void RouteToSandboxPerm(string topicId)
		{
		}

		// Token: 0x06016E21 RID: 93729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E21")]
		[Address(RVA = "0xF65590", Offset = "0xF64190", VA = "0x180F65590")]
		private static void _RouteToStageHome(DataBundle savedInst)
		{
		}

		// Token: 0x06016E22 RID: 93730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E22")]
		[Address(RVA = "0xF65420", Offset = "0xF64020", VA = "0x180F65420")]
		private static void _RouteToStageCampaign(string zoneId, string stageId)
		{
		}

		// Token: 0x06016E23 RID: 93731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E23")]
		[Address(RVA = "0xF65640", Offset = "0xF64240", VA = "0x180F65640")]
		private static void _RouteToStageOthers(DataBundle savedInst)
		{
		}

		// Token: 0x06016E24 RID: 93732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E24")]
		[Address(RVA = "0xF64DA0", Offset = "0xF639A0", VA = "0x180F64DA0")]
		private static void _RouteToCampaignOthers(string zoneId, string stageId)
		{
		}

		// Token: 0x06016E25 RID: 93733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E25")]
		[Address(RVA = "0xF654F0", Offset = "0xF640F0", VA = "0x180F654F0")]
		private static void _RouteToStageClimbTower()
		{
		}

		// Token: 0x06016E26 RID: 93734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E26")]
		[Address(RVA = "0xF64F30", Offset = "0xF63B30", VA = "0x180F64F30")]
		private static void _RouteToClimbTowerOthers()
		{
		}

		// Token: 0x06016E27 RID: 93735 RVA: 0x00093888 File Offset: 0x00091A88
		[Token(Token = "0x6016E27")]
		[Address(RVA = "0xF63BB0", Offset = "0xF627B0", VA = "0x180F63BB0")]
		private static UIPageStackParam _PageStackParamToStage(DataBundle stageSavedInst)
		{
			return default(UIPageStackParam);
		}

		// Token: 0x06016E28 RID: 93736 RVA: 0x000938A0 File Offset: 0x00091AA0
		[Token(Token = "0x6016E28")]
		[Address(RVA = "0xF62C30", Offset = "0xF61830", VA = "0x180F62C30")]
		private static UIPageStackParam _PageStackParamToCampaign(string zoneId, string stageId)
		{
			return default(UIPageStackParam);
		}

		// Token: 0x06016E29 RID: 93737 RVA: 0x000938B8 File Offset: 0x00091AB8
		[Token(Token = "0x6016E29")]
		[Address(RVA = "0xF63060", Offset = "0xF61C60", VA = "0x180F63060")]
		private static UIPageStackParam _PageStackParamToClimbTower()
		{
			return default(UIPageStackParam);
		}

		// Token: 0x06016E2A RID: 93738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E2A")]
		[Address(RVA = "0xF610E0", Offset = "0xF5FCE0", VA = "0x180F610E0")]
		public static void RouteToNameCardSkinChangeState(string skinId)
		{
		}

		// Token: 0x06016E2B RID: 93739 RVA: 0x000938D0 File Offset: 0x00091AD0
		[Token(Token = "0x6016E2B")]
		[Address(RVA = "0xF638E0", Offset = "0xF624E0", VA = "0x180F638E0")]
		private static UIPageStackParam _PageStackParamToNameCardSkinChangeState(string skinId)
		{
			return default(UIPageStackParam);
		}

		// Token: 0x06016E2C RID: 93740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E2C")]
		[Address(RVA = "0xF60D20", Offset = "0xF5F920", VA = "0x180F60D20")]
		public static void RouteToMission(MissionPageType initMissionPage)
		{
		}

		// Token: 0x06016E2D RID: 93741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E2D")]
		[Address(RVA = "0xF65200", Offset = "0xF63E00", VA = "0x180F65200")]
		private static void _RouteToMissionHome(DataBundle savedInst)
		{
		}

		// Token: 0x06016E2E RID: 93742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016E2E")]
		[Address(RVA = "0xF652B0", Offset = "0xF63EB0", VA = "0x180F652B0")]
		private static void _RouteToMissionOthers(DataBundle savedInst)
		{
		}

		// Token: 0x06016E2F RID: 93743 RVA: 0x000938E8 File Offset: 0x00091AE8
		[Token(Token = "0x6016E2F")]
		[Address(RVA = "0xF63630", Offset = "0xF62230", VA = "0x180F63630")]
		private static UIPageStackParam _PageStackParamToMission(DataBundle stageSavedInst)
		{
			return default(UIPageStackParam);
		}

		// Token: 0x06016E30 RID: 93744 RVA: 0x00093900 File Offset: 0x00091B00
		[Token(Token = "0x6016E30")]
		[Address(RVA = "0xF60850", Offset = "0xF5F450", VA = "0x180F60850")]
		public static bool RouteToDiamondShopViaUIOperation()
		{
			return default(bool);
		}

		// Token: 0x06016E31 RID: 93745 RVA: 0x00093918 File Offset: 0x00091B18
		[Token(Token = "0x6016E31")]
		[Address(RVA = "0xF61AC0", Offset = "0xF606C0", VA = "0x180F61AC0")]
		public static bool RouteToShopAndResetStack(object param)
		{
			return default(bool);
		}

		// Token: 0x06016E32 RID: 93746 RVA: 0x00093930 File Offset: 0x00091B30
		[Token(Token = "0x6016E32")]
		[Address(RVA = "0xF657B0", Offset = "0xF643B0", VA = "0x180F657B0")]
		private static bool _TryRouteToBuildingPagesInHome(BuildingData.RoomType roomType, object param)
		{
			return default(bool);
		}

		// Token: 0x0401B9B9 RID: 113081
		[Token(Token = "0x401B9B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly ListSet<UIRouteTarget> BUILDING_ROUTE_TARGETS;

		// Token: 0x0401B9BA RID: 113082
		[Token(Token = "0x401B9BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RouteToTarget;

		// Token: 0x0401B9BB RID: 113083
		[Token(Token = "0x401B9BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RouteSceneHome;

		// Token: 0x0401B9BC RID: 113084
		[Token(Token = "0x401B9BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RouteSceneBuilding;

		// Token: 0x0401B9BD RID: 113085
		[Token(Token = "0x401B9BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RouteSceneOthers;

		// Token: 0x0401B9BE RID: 113086
		[Token(Token = "0x401B9BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RouteTargetToRoomType;

		// Token: 0x0401B9BF RID: 113087
		[Token(Token = "0x401B9BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RouteTargetToPageName;

		// Token: 0x0401B9C0 RID: 113088
		[Token(Token = "0x401B9C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetArgumentFromRouteTarget;

		// Token: 0x0401B9C1 RID: 113089
		[Token(Token = "0x401B9C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ParsePageControllerParamForHome;

		// Token: 0x0401B9C2 RID: 113090
		[Token(Token = "0x401B9C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsRouteToStageSupported;

		// Token: 0x0401B9C3 RID: 113091
		[Token(Token = "0x401B9C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_IsRouteToBuildingSupported;

		// Token: 0x0401B9C4 RID: 113092
		[Token(Token = "0x401B9C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__IsRouteSupported;

		// Token: 0x0401B9C5 RID: 113093
		[Token(Token = "0x401B9C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RouteToStage;

		// Token: 0x0401B9C6 RID: 113094
		[Token(Token = "0x401B9C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RouteToZoneViewType;

		// Token: 0x0401B9C7 RID: 113095
		[Token(Token = "0x401B9C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_RouteToMixStory;

		// Token: 0x0401B9C8 RID: 113096
		[Token(Token = "0x401B9C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RouteToCampaign;

		// Token: 0x0401B9C9 RID: 113097
		[Token(Token = "0x401B9C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_RouteToClimbTower;

		// Token: 0x0401B9CA RID: 113098
		[Token(Token = "0x401B9CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_RouteToStageActivity;

		// Token: 0x0401B9CB RID: 113099
		[Token(Token = "0x401B9CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__GetDefaultStageActivityRouteStack;

		// Token: 0x0401B9CC RID: 113100
		[Token(Token = "0x401B9CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_RouteToHomeThemeState;

		// Token: 0x0401B9CD RID: 113101
		[Token(Token = "0x401B9CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__RouteToHomeThemeStateOthers;

		// Token: 0x0401B9CE RID: 113102
		[Token(Token = "0x401B9CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__PageStackParamToHomeThemeState;

		// Token: 0x0401B9CF RID: 113103
		[Token(Token = "0x401B9CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_RouteToRoguelikeTopic;

		// Token: 0x0401B9D0 RID: 113104
		[Token(Token = "0x401B9D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RouteToRogueSpecialOperator;

		// Token: 0x0401B9D1 RID: 113105
		[Token(Token = "0x401B9D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GenerateRoguelikeTopicRouteStack;

		// Token: 0x0401B9D2 RID: 113106
		[Token(Token = "0x401B9D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_RouteToSandboxPerm;

		// Token: 0x0401B9D3 RID: 113107
		[Token(Token = "0x401B9D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RouteToStageHome;

		// Token: 0x0401B9D4 RID: 113108
		[Token(Token = "0x401B9D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RouteToStageCampaign;

		// Token: 0x0401B9D5 RID: 113109
		[Token(Token = "0x401B9D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__RouteToStageOthers;

		// Token: 0x0401B9D6 RID: 113110
		[Token(Token = "0x401B9D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__RouteToCampaignOthers;

		// Token: 0x0401B9D7 RID: 113111
		[Token(Token = "0x401B9D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__RouteToStageClimbTower;

		// Token: 0x0401B9D8 RID: 113112
		[Token(Token = "0x401B9D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__RouteToClimbTowerOthers;

		// Token: 0x0401B9D9 RID: 113113
		[Token(Token = "0x401B9D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__PageStackParamToStage;

		// Token: 0x0401B9DA RID: 113114
		[Token(Token = "0x401B9DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__PageStackParamToCampaign;

		// Token: 0x0401B9DB RID: 113115
		[Token(Token = "0x401B9DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__PageStackParamToClimbTower;

		// Token: 0x0401B9DC RID: 113116
		[Token(Token = "0x401B9DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_RouteToNameCardSkinChangeState;

		// Token: 0x0401B9DD RID: 113117
		[Token(Token = "0x401B9DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__PageStackParamToNameCardSkinChangeState;

		// Token: 0x0401B9DE RID: 113118
		[Token(Token = "0x401B9DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_RouteToMission;

		// Token: 0x0401B9DF RID: 113119
		[Token(Token = "0x401B9DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__RouteToMissionHome;

		// Token: 0x0401B9E0 RID: 113120
		[Token(Token = "0x401B9E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__RouteToMissionOthers;

		// Token: 0x0401B9E1 RID: 113121
		[Token(Token = "0x401B9E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__PageStackParamToMission;

		// Token: 0x0401B9E2 RID: 113122
		[Token(Token = "0x401B9E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_RouteToDiamondShopViaUIOperation;

		// Token: 0x0401B9E3 RID: 113123
		[Token(Token = "0x401B9E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_RouteToShopAndResetStack;

		// Token: 0x0401B9E4 RID: 113124
		[Token(Token = "0x401B9E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__TryRouteToBuildingPagesInHome;
	}
}
