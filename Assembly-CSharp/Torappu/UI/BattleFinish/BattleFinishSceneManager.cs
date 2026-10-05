using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Activity.Act4fun;
using Torappu.Battle;
using Torappu.ObjectPool;
using Torappu.UI.BossRush;
using UnityEngine;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x020061DB RID: 25051
	[Token(Token = "0x20061DB")]
	[Hotfix(HotfixFlag.Stateless)]
	public class BattleFinishSceneManager : SingletonMonoBehaviour<BattleFinishSceneManager>, ISingletonNotAutoCreate
	{
		// Token: 0x17005543 RID: 21827
		// (get) Token: 0x0602424D RID: 148045 RVA: 0x000C33D8 File Offset: 0x000C15D8
		// (set) Token: 0x0602424E RID: 148046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005543")]
		public bool hasCheckDontSkip
		{
			[Token(Token = "0x602424D")]
			[Address(RVA = "0x1EDBB10", Offset = "0x1EDA710", VA = "0x181EDBB10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x602424E")]
			[Address(RVA = "0x1EDBB70", Offset = "0x1EDA770", VA = "0x181EDBB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602424F RID: 148047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602424F")]
		[Address(RVA = "0x1ED5460", Offset = "0x1ED4060", VA = "0x181ED5460", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06024250 RID: 148048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024250")]
		[Address(RVA = "0x1ED5320", Offset = "0x1ED3F20", VA = "0x181ED5320", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06024251 RID: 148049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024251")]
		[Address(RVA = "0x1ED3EA0", Offset = "0x1ED2AA0", VA = "0x181ED3EA0")]
		public void EventOnItemDescCloseClicked()
		{
		}

		// Token: 0x06024252 RID: 148050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024252")]
		[Address(RVA = "0x1ED3D50", Offset = "0x1ED2950", VA = "0x181ED3D50")]
		public void EventOnConfirmSaveBattleLog()
		{
		}

		// Token: 0x06024253 RID: 148051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024253")]
		[Address(RVA = "0x1ED3B70", Offset = "0x1ED2770", VA = "0x181ED3B70")]
		public void EventOnCancelSaveBattleLog()
		{
		}

		// Token: 0x06024254 RID: 148052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024254")]
		[Address(RVA = "0x1ED3CA0", Offset = "0x1ED28A0", VA = "0x181ED3CA0")]
		public void EventOnConfirmAllowAutoBattle()
		{
		}

		// Token: 0x06024255 RID: 148053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024255")]
		[Address(RVA = "0x1ED3E10", Offset = "0x1ED2A10", VA = "0x181ED3E10")]
		public void EventOnConfirmSendFriendRequest()
		{
		}

		// Token: 0x06024256 RID: 148054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024256")]
		[Address(RVA = "0x1ED3C20", Offset = "0x1ED2820", VA = "0x181ED3C20")]
		public void EventOnCanncelSendFriendRequest()
		{
		}

		// Token: 0x06024257 RID: 148055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024257")]
		[Address(RVA = "0x1ED9100", Offset = "0x1ED7D00", VA = "0x181ED9100")]
		public void _OnLvlUpCloseClicked()
		{
		}

		// Token: 0x17005544 RID: 21828
		// (get) Token: 0x06024258 RID: 148056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005544")]
		public GameObjectPool dropItemPool
		{
			[Token(Token = "0x6024258")]
			[Address(RVA = "0x1EDBAA0", Offset = "0x1EDA6A0", VA = "0x181EDBAA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005545 RID: 21829
		// (get) Token: 0x06024259 RID: 148057 RVA: 0x000C33F0 File Offset: 0x000C15F0
		[Token(Token = "0x17005545")]
		public int bgmInstId
		{
			[Token(Token = "0x6024259")]
			[Address(RVA = "0x1EDBA40", Offset = "0x1EDA640", VA = "0x181EDBA40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602425A RID: 148058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602425A")]
		[Address(RVA = "0x1ED6090", Offset = "0x1ED4C90", VA = "0x181ED6090")]
		public static void ShowItemDesc(GameObject itemObj, UIItemViewModel itemModel)
		{
		}

		// Token: 0x0602425B RID: 148059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602425B")]
		[Address(RVA = "0x1ED6280", Offset = "0x1ED4E80", VA = "0x181ED6280")]
		public static void ShowLvlUp([Optional] Action onLvlUpHide)
		{
		}

		// Token: 0x0602425C RID: 148060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602425C")]
		[Address(RVA = "0x1ED3F50", Offset = "0x1ED2B50", VA = "0x181ED3F50")]
		public static void HideLvlUp()
		{
		}

		// Token: 0x0602425D RID: 148061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602425D")]
		[Address(RVA = "0x1ED6350", Offset = "0x1ED4F50", VA = "0x181ED6350")]
		public static void StartDealWithAutoBattle([Optional] Action onFinished)
		{
		}

		// Token: 0x0602425E RID: 148062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602425E")]
		[Address(RVA = "0x1ED38B0", Offset = "0x1ED24B0", VA = "0x181ED38B0")]
		public static void ActivityOnlyStartDealWithFriendAdd(SquadFriendData friendData)
		{
		}

		// Token: 0x0602425F RID: 148063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602425F")]
		[Address(RVA = "0x1ED3A20", Offset = "0x1ED2620", VA = "0x181ED3A20")]
		public static void ActivityOnly_DealWithCancelFriendRequest()
		{
		}

		// Token: 0x06024260 RID: 148064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024260")]
		[Address(RVA = "0x1ED55B0", Offset = "0x1ED41B0", VA = "0x181ED55B0")]
		public static void RouteToHomeSceneDefault()
		{
		}

		// Token: 0x06024261 RID: 148065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024261")]
		[Address(RVA = "0x1ED7F80", Offset = "0x1ED6B80", VA = "0x181ED7F80")]
		private static void _JumpToHandBook()
		{
		}

		// Token: 0x06024262 RID: 148066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024262")]
		[Address(RVA = "0x1ED4EF0", Offset = "0x1ED3AF0", VA = "0x181ED4EF0")]
		public static void JumpToCampaign()
		{
		}

		// Token: 0x06024263 RID: 148067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024263")]
		[Address(RVA = "0x1ED50B0", Offset = "0x1ED3CB0", VA = "0x181ED50B0")]
		public static void JumpToClimbTower()
		{
		}

		// Token: 0x06024264 RID: 148068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024264")]
		[Address(RVA = "0x1ED4B00", Offset = "0x1ED3700", VA = "0x181ED4B00")]
		public static void JumpToBossRush()
		{
		}

		// Token: 0x06024265 RID: 148069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024265")]
		[Address(RVA = "0x1ED8980", Offset = "0x1ED7580", VA = "0x181ED8980")]
		private static void _JumpToTrainingCamp()
		{
		}

		// Token: 0x06024266 RID: 148070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024266")]
		[Address(RVA = "0x1ED9790", Offset = "0x1ED8390", VA = "0x181ED9790")]
		private static ISceneParam _SceneParamToBossRush(DataBundle stageBundle, BossRushPage.Params bossRushParam)
		{
			return null;
		}

		// Token: 0x06024267 RID: 148071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024267")]
		[Address(RVA = "0x1ED5260", Offset = "0x1ED3E60", VA = "0x181ED5260")]
		public static Sprite LoadBattleFinishBkg(BattleFinishBkg config)
		{
			return null;
		}

		// Token: 0x06024268 RID: 148072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024268")]
		[Address(RVA = "0x1EDA300", Offset = "0x1ED8F00", VA = "0x181EDA300")]
		private void _ShowItemDescImpl(GameObject itemObj, UIItemViewModel itemModel)
		{
		}

		// Token: 0x06024269 RID: 148073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024269")]
		[Address(RVA = "0x1EDA450", Offset = "0x1ED9050", VA = "0x181EDA450")]
		private void _ShowLvlUp(Action onLvlUpHide)
		{
		}

		// Token: 0x0602426A RID: 148074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602426A")]
		[Address(RVA = "0x1ED7820", Offset = "0x1ED6420", VA = "0x181ED7820")]
		private void _HideLvlUp()
		{
		}

		// Token: 0x0602426B RID: 148075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602426B")]
		[Address(RVA = "0x1ED6630", Offset = "0x1ED5230", VA = "0x181ED6630")]
		private void _DealWithAutoBattle(Action onFinished)
		{
		}

		// Token: 0x0602426C RID: 148076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602426C")]
		[Address(RVA = "0x1ED6D90", Offset = "0x1ED5990", VA = "0x181ED6D90")]
		private void _DealWithBattleLogSave(bool showAutoBattleUI, bool battleLogValid, BattleInfoCache.Data battleCache)
		{
		}

		// Token: 0x0602426D RID: 148077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602426D")]
		[Address(RVA = "0x1ED7010", Offset = "0x1ED5C10", VA = "0x181ED7010")]
		private void _DealWithFriendAdd()
		{
		}

		// Token: 0x0602426E RID: 148078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602426E")]
		[Address(RVA = "0x1ED64C0", Offset = "0x1ED50C0", VA = "0x181ED64C0")]
		private void _ActivityOnlyDealWithFriendAdd(SquadFriendData friendData)
		{
		}

		// Token: 0x0602426F RID: 148079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602426F")]
		[Address(RVA = "0x1ED6590", Offset = "0x1ED5190", VA = "0x181ED6590")]
		private void _ActivityOnly_DealWithCancelFriendRequest()
		{
		}

		// Token: 0x06024270 RID: 148080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024270")]
		[Address(RVA = "0x1ED9880", Offset = "0x1ED8480", VA = "0x181ED9880")]
		private void _SendFriendProcessRequestListRequest(SquadFriendData friend)
		{
		}

		// Token: 0x06024271 RID: 148081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024271")]
		[Address(RVA = "0x1ED9C30", Offset = "0x1ED8830", VA = "0x181ED9C30")]
		private void _SendSaveBattleLogService([Optional] Action onSucceed)
		{
		}

		// Token: 0x06024272 RID: 148082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024272")]
		[Address(RVA = "0x1EDAE00", Offset = "0x1ED9A00", VA = "0x181EDAE00")]
		private BattleLogMeta _TryToCreateBattleLogMeta()
		{
			return null;
		}

		// Token: 0x06024273 RID: 148083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024273")]
		[Address(RVA = "0x1ED74C0", Offset = "0x1ED60C0", VA = "0x181ED74C0")]
		private BattleCharmsData _GeneCharmsData(BattleCharmMeta charmMeta)
		{
			return null;
		}

		// Token: 0x06024274 RID: 148084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024274")]
		[Address(RVA = "0x1ED76C0", Offset = "0x1ED62C0", VA = "0x181ED76C0")]
		private BattleTechData _GeneTechesData(BattleTechMeta techMeta)
		{
			return null;
		}

		// Token: 0x06024275 RID: 148085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024275")]
		[Address(RVA = "0x1ED7410", Offset = "0x1ED6010", VA = "0x181ED7410")]
		private BattleCartData _GeneCartData(BattleCartMeta cartMeta)
		{
			return null;
		}

		// Token: 0x06024276 RID: 148086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024276")]
		[Address(RVA = "0x1ED7770", Offset = "0x1ED6370", VA = "0x181ED7770")]
		private BattleTrapToolData _GeneTrapToolsData(BattleTrapToolMeta trapToolMeta)
		{
			return null;
		}

		// Token: 0x06024277 RID: 148087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024277")]
		[Address(RVA = "0x1ED7360", Offset = "0x1ED5F60", VA = "0x181ED7360")]
		private BattlePerformanceData _GeneBattlePerformanceData(BattlePerformanceMeta battlePerformanceMeta)
		{
			return null;
		}

		// Token: 0x06024278 RID: 148088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024278")]
		[Address(RVA = "0x1ED7290", Offset = "0x1ED5E90", VA = "0x181ED7290")]
		private BattleFireworkData _GeneBattleFireworkData(BattleFireworkMeta battleFireworkMeta)
		{
			return null;
		}

		// Token: 0x06024279 RID: 148089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024279")]
		[Address(RVA = "0x1ED7570", Offset = "0x1ED6170", VA = "0x181ED7570")]
		private PredefinedAssistData _GenePredefinedAssistData(SquadFriendData assistData)
		{
			return null;
		}

		// Token: 0x0602427A RID: 148090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602427A")]
		[Address(RVA = "0x1EDA270", Offset = "0x1ED8E70", VA = "0x181EDA270")]
		private void _ShowAllowAutoBattle(bool isShow)
		{
		}

		// Token: 0x0602427B RID: 148091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602427B")]
		[Address(RVA = "0x1EDA780", Offset = "0x1ED9380", VA = "0x181EDA780")]
		private void _ShowSaveBattleLog(bool isShow)
		{
		}

		// Token: 0x0602427C RID: 148092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602427C")]
		[Address(RVA = "0x1ED84D0", Offset = "0x1ED70D0", VA = "0x181ED84D0")]
		private static void _JumpToStage()
		{
		}

		// Token: 0x0602427D RID: 148093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602427D")]
		[Address(RVA = "0x1ED7900", Offset = "0x1ED6500", VA = "0x181ED7900")]
		private static void _InjectBattleFinishInfoToStageBundle(DataBundle stageBundle, BattleStageInfo lastStageData, CommonFinishBattleResponse finishResponse)
		{
		}

		// Token: 0x0602427E RID: 148094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602427E")]
		[Address(RVA = "0x1ED7B10", Offset = "0x1ED6710", VA = "0x181ED7B10")]
		private static void _InjectFlashAlertInfo(DataBundle stageBundle, BattleStageInfo lastStageData, CommonFinishBattleResponse finishResponse)
		{
		}

		// Token: 0x0602427F RID: 148095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602427F")]
		[Address(RVA = "0x1ED7DD0", Offset = "0x1ED69D0", VA = "0x181ED7DD0")]
		private static void _JumpToCrisisV2()
		{
		}

		// Token: 0x06024280 RID: 148096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024280")]
		[Address(RVA = "0x1ED8150", Offset = "0x1ED6D50", VA = "0x181ED8150")]
		private static void _JumpToRecalRune()
		{
		}

		// Token: 0x06024281 RID: 148097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024281")]
		[Address(RVA = "0x1ED8300", Offset = "0x1ED6F00", VA = "0x181ED8300")]
		private static void _JumpToSandboxV2()
		{
		}

		// Token: 0x06024282 RID: 148098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024282")]
		[Address(RVA = "0x1ED7C20", Offset = "0x1ED6820", VA = "0x181ED7C20")]
		private static void _JumpToAutoChess()
		{
		}

		// Token: 0x06024283 RID: 148099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024283")]
		[Address(RVA = "0x1ED8B30", Offset = "0x1ED7730", VA = "0x181ED8B30")]
		private static void _JumpWithRoutePolicy()
		{
		}

		// Token: 0x06024284 RID: 148100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024284")]
		[Address(RVA = "0x1ED4010", Offset = "0x1ED2C10", VA = "0x181ED4010")]
		public static void JumpToAct4fun()
		{
		}

		// Token: 0x06024285 RID: 148101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024285")]
		[Address(RVA = "0x1ED4530", Offset = "0x1ED3130", VA = "0x181ED4530")]
		public static void JumpToAct6fun()
		{
		}

		// Token: 0x06024286 RID: 148102 RVA: 0x000C3408 File Offset: 0x000C1608
		[Token(Token = "0x6024286")]
		[Address(RVA = "0x1ED93F0", Offset = "0x1ED7FF0", VA = "0x181ED93F0")]
		private static bool _RouteToHomeSceneActivity(BattleInOut.InParams input)
		{
			return default(bool);
		}

		// Token: 0x06024287 RID: 148103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024287")]
		[Address(RVA = "0x1ED9160", Offset = "0x1ED7D60", VA = "0x181ED9160")]
		private static UIPageControllerParam _ParamToHomeAct(string actId, DataBundle actMeta)
		{
			return null;
		}

		// Token: 0x06024288 RID: 148104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024288")]
		[Address(RVA = "0x1EDA810", Offset = "0x1ED9410", VA = "0x181EDA810")]
		private static void _TestFillPlayerLiveData(BattleFinishSceneManager.PlayerAct4funLiveData data)
		{
		}

		// Token: 0x06024289 RID: 148105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024289")]
		[Address(RVA = "0x1EDB980", Offset = "0x1EDA580", VA = "0x181EDB980")]
		public BattleFinishSceneManager()
		{
		}

		// Token: 0x04032429 RID: 205865
		[Token(Token = "0x4032429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BattleFinishHomeState _homeState;

		// Token: 0x0403242A RID: 205866
		[Token(Token = "0x403242A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObjectPoolComponent _objectPool;

		// Token: 0x0403242B RID: 205867
		[Token(Token = "0x403242B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIItemDescFloatBinder _itemDescFloatBinder;

		// Token: 0x0403242C RID: 205868
		[Token(Token = "0x403242C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Left Float")]
		private GameObject _panelLeftFloat;

		// Token: 0x0403242D RID: 205869
		[Token(Token = "0x403242D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Left Float")]
		private BattleFinishFriendView _friendView;

		// Token: 0x0403242E RID: 205870
		[Token(Token = "0x403242E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Left Float")]
		private GameObject _panelSaveBattleLog;

		// Token: 0x0403242F RID: 205871
		[Token(Token = "0x403242F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Left Float")]
		private GameObject _panelAllowAutoBattle;

		// Token: 0x04032430 RID: 205872
		[Token(Token = "0x4032430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _lvlUpContainer;

		// Token: 0x04032431 RID: 205873
		[Token(Token = "0x4032431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private UIItemDescViewProperty m_itemDescProperty;

		// Token: 0x04032432 RID: 205874
		[Token(Token = "0x4032432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private SquadFriendData m_cacheFriendData;

		// Token: 0x04032433 RID: 205875
		[Token(Token = "0x4032433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BattleFinishLevelUpView m_lvlUpView;

		// Token: 0x04032434 RID: 205876
		[Token(Token = "0x4032434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Action m_onLvlUpHide;

		// Token: 0x04032436 RID: 205878
		[Token(Token = "0x4032436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasCheckDontSkip;

		// Token: 0x04032437 RID: 205879
		[Token(Token = "0x4032437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_hasCheckDontSkip;

		// Token: 0x04032438 RID: 205880
		[Token(Token = "0x4032438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04032439 RID: 205881
		[Token(Token = "0x4032439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403243A RID: 205882
		[Token(Token = "0x403243A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnItemDescCloseClicked;

		// Token: 0x0403243B RID: 205883
		[Token(Token = "0x403243B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnConfirmSaveBattleLog;

		// Token: 0x0403243C RID: 205884
		[Token(Token = "0x403243C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EventOnCancelSaveBattleLog;

		// Token: 0x0403243D RID: 205885
		[Token(Token = "0x403243D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnConfirmAllowAutoBattle;

		// Token: 0x0403243E RID: 205886
		[Token(Token = "0x403243E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnConfirmSendFriendRequest;

		// Token: 0x0403243F RID: 205887
		[Token(Token = "0x403243F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnCanncelSendFriendRequest;

		// Token: 0x04032440 RID: 205888
		[Token(Token = "0x4032440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnLvlUpCloseClicked;

		// Token: 0x04032441 RID: 205889
		[Token(Token = "0x4032441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_dropItemPool;

		// Token: 0x04032442 RID: 205890
		[Token(Token = "0x4032442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_bgmInstId;

		// Token: 0x04032443 RID: 205891
		[Token(Token = "0x4032443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ShowItemDesc;

		// Token: 0x04032444 RID: 205892
		[Token(Token = "0x4032444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_ShowLvlUp;

		// Token: 0x04032445 RID: 205893
		[Token(Token = "0x4032445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_HideLvlUp;

		// Token: 0x04032446 RID: 205894
		[Token(Token = "0x4032446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_StartDealWithAutoBattle;

		// Token: 0x04032447 RID: 205895
		[Token(Token = "0x4032447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ActivityOnlyStartDealWithFriendAdd;

		// Token: 0x04032448 RID: 205896
		[Token(Token = "0x4032448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ActivityOnly_DealWithCancelFriendRequest;

		// Token: 0x04032449 RID: 205897
		[Token(Token = "0x4032449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_RouteToHomeSceneDefault;

		// Token: 0x0403244A RID: 205898
		[Token(Token = "0x403244A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__JumpToHandBook;

		// Token: 0x0403244B RID: 205899
		[Token(Token = "0x403244B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_JumpToCampaign;

		// Token: 0x0403244C RID: 205900
		[Token(Token = "0x403244C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_JumpToClimbTower;

		// Token: 0x0403244D RID: 205901
		[Token(Token = "0x403244D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_JumpToBossRush;

		// Token: 0x0403244E RID: 205902
		[Token(Token = "0x403244E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__JumpToTrainingCamp;

		// Token: 0x0403244F RID: 205903
		[Token(Token = "0x403244F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__SceneParamToBossRush;

		// Token: 0x04032450 RID: 205904
		[Token(Token = "0x4032450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_LoadBattleFinishBkg;

		// Token: 0x04032451 RID: 205905
		[Token(Token = "0x4032451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ShowItemDescImpl;

		// Token: 0x04032452 RID: 205906
		[Token(Token = "0x4032452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ShowLvlUp;

		// Token: 0x04032453 RID: 205907
		[Token(Token = "0x4032453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__HideLvlUp;

		// Token: 0x04032454 RID: 205908
		[Token(Token = "0x4032454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__DealWithAutoBattle;

		// Token: 0x04032455 RID: 205909
		[Token(Token = "0x4032455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__DealWithBattleLogSave;

		// Token: 0x04032456 RID: 205910
		[Token(Token = "0x4032456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__DealWithFriendAdd;

		// Token: 0x04032457 RID: 205911
		[Token(Token = "0x4032457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__ActivityOnlyDealWithFriendAdd;

		// Token: 0x04032458 RID: 205912
		[Token(Token = "0x4032458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__ActivityOnly_DealWithCancelFriendRequest;

		// Token: 0x04032459 RID: 205913
		[Token(Token = "0x4032459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__SendFriendProcessRequestListRequest;

		// Token: 0x0403245A RID: 205914
		[Token(Token = "0x403245A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__SendSaveBattleLogService;

		// Token: 0x0403245B RID: 205915
		[Token(Token = "0x403245B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__TryToCreateBattleLogMeta;

		// Token: 0x0403245C RID: 205916
		[Token(Token = "0x403245C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__GeneCharmsData;

		// Token: 0x0403245D RID: 205917
		[Token(Token = "0x403245D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__GeneTechesData;

		// Token: 0x0403245E RID: 205918
		[Token(Token = "0x403245E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__GeneCartData;

		// Token: 0x0403245F RID: 205919
		[Token(Token = "0x403245F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__GeneTrapToolsData;

		// Token: 0x04032460 RID: 205920
		[Token(Token = "0x4032460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__GeneBattlePerformanceData;

		// Token: 0x04032461 RID: 205921
		[Token(Token = "0x4032461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__GeneBattleFireworkData;

		// Token: 0x04032462 RID: 205922
		[Token(Token = "0x4032462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__GenePredefinedAssistData;

		// Token: 0x04032463 RID: 205923
		[Token(Token = "0x4032463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__ShowAllowAutoBattle;

		// Token: 0x04032464 RID: 205924
		[Token(Token = "0x4032464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__ShowSaveBattleLog;

		// Token: 0x04032465 RID: 205925
		[Token(Token = "0x4032465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__JumpToStage;

		// Token: 0x04032466 RID: 205926
		[Token(Token = "0x4032466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__InjectBattleFinishInfoToStageBundle;

		// Token: 0x04032467 RID: 205927
		[Token(Token = "0x4032467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__InjectFlashAlertInfo;

		// Token: 0x04032468 RID: 205928
		[Token(Token = "0x4032468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0__JumpToCrisisV2;

		// Token: 0x04032469 RID: 205929
		[Token(Token = "0x4032469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0__JumpToRecalRune;

		// Token: 0x0403246A RID: 205930
		[Token(Token = "0x403246A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__JumpToSandboxV2;

		// Token: 0x0403246B RID: 205931
		[Token(Token = "0x403246B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__JumpToAutoChess;

		// Token: 0x0403246C RID: 205932
		[Token(Token = "0x403246C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__JumpWithRoutePolicy;

		// Token: 0x0403246D RID: 205933
		[Token(Token = "0x403246D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_JumpToAct4fun;

		// Token: 0x0403246E RID: 205934
		[Token(Token = "0x403246E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_JumpToAct6fun;

		// Token: 0x0403246F RID: 205935
		[Token(Token = "0x403246F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__RouteToHomeSceneActivity;

		// Token: 0x04032470 RID: 205936
		[Token(Token = "0x4032470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__ParamToHomeAct;

		// Token: 0x04032471 RID: 205937
		[Token(Token = "0x4032471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0__TestFillPlayerLiveData;

		// Token: 0x04032472 RID: 205938
		[Token(Token = "0x4032472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020061DC RID: 25052
		[Token(Token = "0x20061DC")]
		public class PlayerAct4funLiveData
		{
			// Token: 0x0602428A RID: 148106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602428A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerAct4funLiveData()
			{
			}

			// Token: 0x04032473 RID: 205939
			[Token(Token = "0x4032473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Act4FunBattleFinishResponse resp;
		}
	}
}
