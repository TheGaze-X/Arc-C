using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074D4 RID: 29908
	[Token(Token = "0x20074D4")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act25sideTrackTriggerUtil
	{
		// Token: 0x0602A2A9 RID: 172713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2A9")]
		[Address(RVA = "0x25CEF60", Offset = "0x25CDB60", VA = "0x1825CEF60")]
		public static void RecordTriggerOnArchiveUnlock(PlayerActivity.PlayerAct25SideActivity prevData, PlayerActivity.PlayerAct25SideActivity currData, string actId, string missionId)
		{
		}

		// Token: 0x0602A2AA RID: 172714 RVA: 0x000D79D0 File Offset: 0x000D5BD0
		[Token(Token = "0x602A2AA")]
		[Address(RVA = "0x25CF130", Offset = "0x25CDD30", VA = "0x1825CF130")]
		private static PlayerActivity.PlayerAct25SideActivity.MissionState _GetMissionState(PlayerActivity.PlayerAct25SideActivity actData, string missionId, string areaId)
		{
			return PlayerActivity.PlayerAct25SideActivity.MissionState.UNFINISH;
		}

		// Token: 0x0403C918 RID: 248088
		[Token(Token = "0x403C918")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RecordTriggerOnArchiveUnlock;

		// Token: 0x0403C919 RID: 248089
		[Token(Token = "0x403C919")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetMissionState;
	}
}
