using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act0D5
{
	// Token: 0x02007B5F RID: 31583
	[Token(Token = "0x2007B5F")]
	public class Act0D5Entry : ActivityCommonMissionEntry, IHotfixable
	{
		// Token: 0x0602C34A RID: 181066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C34A")]
		[Address(RVA = "0x281A680", Offset = "0x2819280", VA = "0x18281A680", Slot = "4")]
		public override void OnEnter(string activityId)
		{
		}

		// Token: 0x0602C34B RID: 181067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C34B")]
		[Address(RVA = "0x281B410", Offset = "0x281A010", VA = "0x18281B410")]
		private void _RenderMissionGroup(MissionGroup missionGroup)
		{
		}

		// Token: 0x0602C34C RID: 181068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C34C")]
		[Address(RVA = "0x281AFE0", Offset = "0x2819BE0", VA = "0x18281AFE0")]
		public void SendMissionRequest(string missionId)
		{
		}

		// Token: 0x0602C34D RID: 181069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C34D")]
		[Address(RVA = "0x281AD70", Offset = "0x2819970", VA = "0x18281AD70")]
		public void SendMissionGroupRequest()
		{
		}

		// Token: 0x0602C34E RID: 181070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C34E")]
		[Address(RVA = "0x281B360", Offset = "0x2819F60", VA = "0x18281B360")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x0602C34F RID: 181071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C34F")]
		[Address(RVA = "0x281BB00", Offset = "0x281A700", VA = "0x18281BB00")]
		public Act0D5Entry()
		{
		}

		// Token: 0x04040162 RID: 262498
		[Token(Token = "0x4040162")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04040163 RID: 262499
		[Token(Token = "0x4040163")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ActivityCommonMissionItem _missionItem;

		// Token: 0x04040164 RID: 262500
		[Token(Token = "0x4040164")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _allFinishPart;

		// Token: 0x04040165 RID: 262501
		[Token(Token = "0x4040165")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _notAllFinishPart;

		// Token: 0x04040166 RID: 262502
		[Token(Token = "0x4040166")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _btnReceived;

		// Token: 0x04040167 RID: 262503
		[Token(Token = "0x4040167")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _btnLocked;

		// Token: 0x04040168 RID: 262504
		[Token(Token = "0x4040168")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _btnAble;

		// Token: 0x04040169 RID: 262505
		[Token(Token = "0x4040169")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float maxLength;

		// Token: 0x0404016A RID: 262506
		[Token(Token = "0x404016A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform _yellowBar;

		// Token: 0x0404016B RID: 262507
		[Token(Token = "0x404016B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _remainTime;

		// Token: 0x0404016C RID: 262508
		[Token(Token = "0x404016C")]
		[FieldOffset(Offset = "0x90")]
		private MissionGroup m_missionGroup;

		// Token: 0x0404016D RID: 262509
		[Token(Token = "0x404016D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0404016E RID: 262510
		[Token(Token = "0x404016E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderMissionGroup;

		// Token: 0x0404016F RID: 262511
		[Token(Token = "0x404016F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendMissionRequest;

		// Token: 0x04040170 RID: 262512
		[Token(Token = "0x4040170")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendMissionGroupRequest;

		// Token: 0x04040171 RID: 262513
		[Token(Token = "0x4040171")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04040172 RID: 262514
		[Token(Token = "0x4040172")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
