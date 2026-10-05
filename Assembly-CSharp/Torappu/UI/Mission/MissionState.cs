using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Mission;
using UnityEngine;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004877 RID: 18551
	[Token(Token = "0x2004877")]
	public class MissionState : State, IValueMsgReceiver, ICompDialogCallBack
	{
		// Token: 0x0601C03B RID: 114747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C03B")]
		[Address(RVA = "0x156D790", Offset = "0x156C390", VA = "0x18156D790", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601C03C RID: 114748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C03C")]
		[Address(RVA = "0x156DCD0", Offset = "0x156C8D0", VA = "0x18156DCD0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601C03D RID: 114749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C03D")]
		[Address(RVA = "0x156D9E0", Offset = "0x156C5E0", VA = "0x18156D9E0")]
		public void InitData(MissionPageType? initMissionType)
		{
		}

		// Token: 0x0601C03E RID: 114750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C03E")]
		[Address(RVA = "0x156F7D0", Offset = "0x156E3D0", VA = "0x18156F7D0")]
		private static void _PlayStampSeIfNeed(MissionType type)
		{
		}

		// Token: 0x0601C03F RID: 114751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C03F")]
		[Address(RVA = "0x156DAF0", Offset = "0x156C6F0", VA = "0x18156DAF0", Slot = "23")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601C040 RID: 114752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C040")]
		[Address(RVA = "0x156E270", Offset = "0x156CE70", VA = "0x18156E270")]
		public static void SendConfirmMissionRequest(string missionID_, MissionType type_ = MissionType.UNKNOWN, [Optional] Action onFinish)
		{
		}

		// Token: 0x0601C041 RID: 114753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C041")]
		[Address(RVA = "0x156EE40", Offset = "0x156DA40", VA = "0x18156EE40")]
		public void SendSoCharConfirmMissionRequest(SOCharMissionRequest request)
		{
		}

		// Token: 0x0601C042 RID: 114754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C042")]
		[Address(RVA = "0x156FD80", Offset = "0x156E980", VA = "0x18156FD80")]
		private void _ShowExpOverJudgeDialog(int maxLvl, Action onConfirm)
		{
		}

		// Token: 0x0601C043 RID: 114755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C043")]
		[Address(RVA = "0x156FAF0", Offset = "0x156E6F0", VA = "0x18156FAF0")]
		private void _SendSoCharSingleRequest(SOCharMissionRequest request)
		{
		}

		// Token: 0x0601C044 RID: 114756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C044")]
		[Address(RVA = "0x156EA40", Offset = "0x156D640", VA = "0x18156EA40")]
		public void SendSoCharConfirmMissionGroupRequest(SOCharMissionGroupRequest request)
		{
		}

		// Token: 0x0601C045 RID: 114757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C045")]
		[Address(RVA = "0x156F870", Offset = "0x156E470", VA = "0x18156F870")]
		private void _SendSoCharGroupRequest(SOCharMissionGroupRequest request, List<string> missionIdList)
		{
		}

		// Token: 0x0601C046 RID: 114758 RVA: 0x000A6F38 File Offset: 0x000A5138
		[Token(Token = "0x601C046")]
		[Address(RVA = "0x156F0A0", Offset = "0x156DCA0", VA = "0x18156F0A0")]
		private bool _CheckSoCharMissionUnFinished(MissionViewModel mission)
		{
			return default(bool);
		}

		// Token: 0x0601C047 RID: 114759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C047")]
		[Address(RVA = "0x156DFD0", Offset = "0x156CBD0", VA = "0x18156DFD0")]
		public static void SendConfirmMissionGroupRequest(string missionGroupID_)
		{
		}

		// Token: 0x0601C048 RID: 114760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C048")]
		[Address(RVA = "0x156E500", Offset = "0x156D100", VA = "0x18156E500")]
		public static void SendConfirmSOCharMissionGroupRequest(string missionGroupID_)
		{
		}

		// Token: 0x0601C049 RID: 114761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C049")]
		[Address(RVA = "0x156E7A0", Offset = "0x156D3A0", VA = "0x18156E7A0")]
		public static void SendExchangeMissionRewardsRequest(string missionID_, MissionType type_)
		{
		}

		// Token: 0x0601C04A RID: 114762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C04A")]
		[Address(RVA = "0x156DD40", Offset = "0x156C940", VA = "0x18156DD40")]
		public static void SendAutoConfirmMissionsRequest(MissionType type = MissionType.UNKNOWN)
		{
		}

		// Token: 0x0601C04B RID: 114763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C04B")]
		[Address(RVA = "0x156FFE0", Offset = "0x156EBE0", VA = "0x18156FFE0")]
		private static IEnumerator _ShowGain(List<UIItemViewModel> rewardList, MissionType type)
		{
			return null;
		}

		// Token: 0x0601C04C RID: 114764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C04C")]
		[Address(RVA = "0x156F1C0", Offset = "0x156DDC0", VA = "0x18156F1C0")]
		private void _EventOnOpenGetExpDialog(Vector3 startPos, Vector3 endPos, bool isSingle)
		{
		}

		// Token: 0x0601C04D RID: 114765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C04D")]
		[Address(RVA = "0x156D7F0", Offset = "0x156C3F0", VA = "0x18156D7F0", Slot = "24")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601C04E RID: 114766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C04E")]
		[Address(RVA = "0x156F400", Offset = "0x156E000", VA = "0x18156F400")]
		private void _HandleSoCharExpOverDlgCallback(ValueBundle output)
		{
		}

		// Token: 0x0601C04F RID: 114767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C04F")]
		[Address(RVA = "0x156F530", Offset = "0x156E130", VA = "0x18156F530")]
		private void _HandleSoCharRewardDlgCallback()
		{
		}

		// Token: 0x0601C050 RID: 114768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C050")]
		[Address(RVA = "0x15700A0", Offset = "0x156ECA0", VA = "0x1815700A0")]
		public MissionState()
		{
		}

		// Token: 0x0601C051 RID: 114769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C051")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x040248D3 RID: 149715
		[Token(Token = "0x40248D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MissionModel _stateBean;

		// Token: 0x040248D4 RID: 149716
		[Token(Token = "0x40248D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private MissionBookViewBase _bookView;

		// Token: 0x040248D5 RID: 149717
		[Token(Token = "0x40248D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _dialogContainer;

		// Token: 0x040248D6 RID: 149718
		[Token(Token = "0x40248D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040248D7 RID: 149719
		[Token(Token = "0x40248D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_soCharRewardDlgInst;

		// Token: 0x040248D8 RID: 149720
		[Token(Token = "0x40248D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int m_soCharExpOverDlgInst;

		// Token: 0x040248D9 RID: 149721
		[Token(Token = "0x40248D9")]
		[NonSerialized]
		public const int ON_RECEIVE_SO_CHAR_MISSION = 0;

		// Token: 0x040248DA RID: 149722
		[Token(Token = "0x40248DA")]
		[NonSerialized]
		public const int ON_RECEIVE_ALL_SO_CHAR_MISSION = 1;

		// Token: 0x040248DB RID: 149723
		[Token(Token = "0x40248DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool m_lockFlag;

		// Token: 0x040248DC RID: 149724
		[Token(Token = "0x40248DC")]
		private const int AUTO_BREAK_MAX = 100;

		// Token: 0x040248DD RID: 149725
		[Token(Token = "0x40248DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x040248DE RID: 149726
		[Token(Token = "0x40248DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x040248DF RID: 149727
		[Token(Token = "0x40248DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x040248E0 RID: 149728
		[Token(Token = "0x40248E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayStampSeIfNeed;

		// Token: 0x040248E1 RID: 149729
		[Token(Token = "0x40248E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040248E2 RID: 149730
		[Token(Token = "0x40248E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SendConfirmMissionRequest;

		// Token: 0x040248E3 RID: 149731
		[Token(Token = "0x40248E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SendSoCharConfirmMissionRequest;

		// Token: 0x040248E4 RID: 149732
		[Token(Token = "0x40248E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowExpOverJudgeDialog;

		// Token: 0x040248E5 RID: 149733
		[Token(Token = "0x40248E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SendSoCharSingleRequest;

		// Token: 0x040248E6 RID: 149734
		[Token(Token = "0x40248E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SendSoCharConfirmMissionGroupRequest;

		// Token: 0x040248E7 RID: 149735
		[Token(Token = "0x40248E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SendSoCharGroupRequest;

		// Token: 0x040248E8 RID: 149736
		[Token(Token = "0x40248E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CheckSoCharMissionUnFinished;

		// Token: 0x040248E9 RID: 149737
		[Token(Token = "0x40248E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_SendConfirmMissionGroupRequest;

		// Token: 0x040248EA RID: 149738
		[Token(Token = "0x40248EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_SendConfirmSOCharMissionGroupRequest;

		// Token: 0x040248EB RID: 149739
		[Token(Token = "0x40248EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_SendExchangeMissionRewardsRequest;

		// Token: 0x040248EC RID: 149740
		[Token(Token = "0x40248EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_SendAutoConfirmMissionsRequest;

		// Token: 0x040248ED RID: 149741
		[Token(Token = "0x40248ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__ShowGain;

		// Token: 0x040248EE RID: 149742
		[Token(Token = "0x40248EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnOpenGetExpDialog;

		// Token: 0x040248EF RID: 149743
		[Token(Token = "0x40248EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x040248F0 RID: 149744
		[Token(Token = "0x40248F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__HandleSoCharExpOverDlgCallback;

		// Token: 0x040248F1 RID: 149745
		[Token(Token = "0x40248F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__HandleSoCharRewardDlgCallback;

		// Token: 0x040248F2 RID: 149746
		[Token(Token = "0x40248F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
