using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act4D0
{
	// Token: 0x0200727D RID: 29309
	[Token(Token = "0x200727D")]
	public class Act4D0MileStoneState : PopupFadeState
	{
		// Token: 0x06029829 RID: 170025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029829")]
		[Address(RVA = "0x24DEA20", Offset = "0x24DD620", VA = "0x1824DEA20", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602982A RID: 170026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602982A")]
		[Address(RVA = "0x24DEA80", Offset = "0x24DD680", VA = "0x1824DEA80", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602982B RID: 170027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602982B")]
		[Address(RVA = "0x24DEC30", Offset = "0x24DD830", VA = "0x1824DEC30", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0602982C RID: 170028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602982C")]
		[Address(RVA = "0x24DED90", Offset = "0x24DD990", VA = "0x1824DED90")]
		public void SendItemRequest(string rewardId)
		{
		}

		// Token: 0x0602982D RID: 170029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602982D")]
		[Address(RVA = "0x24DF340", Offset = "0x24DDF40", VA = "0x1824DF340")]
		private void _SendItemRequest(string rewardId)
		{
		}

		// Token: 0x0602982E RID: 170030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602982E")]
		[Address(RVA = "0x24DEE10", Offset = "0x24DDA10", VA = "0x1824DEE10")]
		public void SendStoryRequest(string rewardId)
		{
		}

		// Token: 0x0602982F RID: 170031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602982F")]
		[Address(RVA = "0x24DF5A0", Offset = "0x24DE1A0", VA = "0x1824DF5A0")]
		private void _SendStoryRequest(string rewardId)
		{
		}

		// Token: 0x06029830 RID: 170032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029830")]
		[Address(RVA = "0x24DEB40", Offset = "0x24DD740", VA = "0x1824DEB40")]
		public static IEnumerator ReceiveItemsCoroutine(List<ActivityItemModel> rewardList, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x06029831 RID: 170033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029831")]
		[Address(RVA = "0x24DF800", Offset = "0x24DE400", VA = "0x1824DF800")]
		public Act4D0MileStoneState()
		{
		}

		// Token: 0x06029835 RID: 170037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029835")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06029836 RID: 170038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029836")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403B4FB RID: 242939
		[Token(Token = "0x403B4FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act4D0MileStoneStateBean _stateBean;

		// Token: 0x0403B4FC RID: 242940
		[Token(Token = "0x403B4FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act4D0MileStoneHolder _view;

		// Token: 0x0403B4FD RID: 242941
		[Token(Token = "0x403B4FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _topMenu;

		// Token: 0x0403B4FE RID: 242942
		[Token(Token = "0x403B4FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private string m_cacheTransId;

		// Token: 0x0403B4FF RID: 242943
		[Token(Token = "0x403B4FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B500 RID: 242944
		[Token(Token = "0x403B500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B501 RID: 242945
		[Token(Token = "0x403B501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403B502 RID: 242946
		[Token(Token = "0x403B502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SendItemRequest;

		// Token: 0x0403B503 RID: 242947
		[Token(Token = "0x403B503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SendItemRequest;

		// Token: 0x0403B504 RID: 242948
		[Token(Token = "0x403B504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SendStoryRequest;

		// Token: 0x0403B505 RID: 242949
		[Token(Token = "0x403B505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SendStoryRequest;

		// Token: 0x0403B506 RID: 242950
		[Token(Token = "0x403B506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ReceiveItemsCoroutine;

		// Token: 0x0403B507 RID: 242951
		[Token(Token = "0x403B507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
