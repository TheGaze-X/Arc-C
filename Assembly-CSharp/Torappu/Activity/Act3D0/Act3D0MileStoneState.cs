using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073F4 RID: 29684
	[Token(Token = "0x20073F4")]
	public class Act3D0MileStoneState : PopupFadeState
	{
		// Token: 0x06029EDE RID: 171742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029EDE")]
		[Address(RVA = "0x258FA70", Offset = "0x258E670", VA = "0x18258FA70", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06029EDF RID: 171743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EDF")]
		[Address(RVA = "0x258FAD0", Offset = "0x258E6D0", VA = "0x18258FAD0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06029EE0 RID: 171744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EE0")]
		[Address(RVA = "0x258FC80", Offset = "0x258E880", VA = "0x18258FC80")]
		public void SendGachaRequest(string rewardId)
		{
		}

		// Token: 0x06029EE1 RID: 171745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EE1")]
		[Address(RVA = "0x258FFA0", Offset = "0x258EBA0", VA = "0x18258FFA0")]
		private void _SendGachaRequest(string rewardId)
		{
		}

		// Token: 0x06029EE2 RID: 171746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029EE2")]
		[Address(RVA = "0x258FB90", Offset = "0x258E790", VA = "0x18258FB90")]
		public static IEnumerator ReceiveItemsCoroutine(List<ActivityItemModel> rewardList, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x06029EE3 RID: 171747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EE3")]
		[Address(RVA = "0x2590200", Offset = "0x258EE00", VA = "0x182590200")]
		public Act3D0MileStoneState()
		{
		}

		// Token: 0x06029EE5 RID: 171749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EE5")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403C153 RID: 246099
		[Token(Token = "0x403C153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act3D0MileStoneStateBean _stateBean;

		// Token: 0x0403C154 RID: 246100
		[Token(Token = "0x403C154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act3D0MileStoneHolder _view;

		// Token: 0x0403C155 RID: 246101
		[Token(Token = "0x403C155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _topMenu;

		// Token: 0x0403C156 RID: 246102
		[Token(Token = "0x403C156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403C157 RID: 246103
		[Token(Token = "0x403C157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403C158 RID: 246104
		[Token(Token = "0x403C158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SendGachaRequest;

		// Token: 0x0403C159 RID: 246105
		[Token(Token = "0x403C159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SendGachaRequest;

		// Token: 0x0403C15A RID: 246106
		[Token(Token = "0x403C15A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x0403C15B RID: 246107
		[Token(Token = "0x403C15B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
