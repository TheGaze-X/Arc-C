using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200724D RID: 29261
	[Token(Token = "0x200724D")]
	public class Act5D1RuneMissionState : PopupFloatState
	{
		// Token: 0x0602977D RID: 169853 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602977D")]
		[Address(RVA = "0x24E4950", Offset = "0x24E3550", VA = "0x1824E4950", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602977E RID: 169854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602977E")]
		[Address(RVA = "0x24E49B0", Offset = "0x24E35B0", VA = "0x1824E49B0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602977F RID: 169855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602977F")]
		[Address(RVA = "0x24E4F90", Offset = "0x24E3B90", VA = "0x1824E4F90")]
		public void showRuneDetail(List<RuneShowInfo> runes, bool cannotUseBenefit)
		{
		}

		// Token: 0x06029780 RID: 169856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029780")]
		[Address(RVA = "0x24E4A80", Offset = "0x24E3680", VA = "0x1824E4A80", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06029781 RID: 169857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029781")]
		[Address(RVA = "0x24E4F30", Offset = "0x24E3B30", VA = "0x1824E4F30")]
		public Act5D1RuneMissionState()
		{
		}

		// Token: 0x06029784 RID: 169860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029784")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06029785 RID: 169861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029785")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0403B3FE RID: 242686
		[Token(Token = "0x403B3FE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act5D1RuneMissionStateBean _stateBean;

		// Token: 0x0403B3FF RID: 242687
		[Token(Token = "0x403B3FF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act5D1RuneMissionPanel _urgentMission;

		// Token: 0x0403B400 RID: 242688
		[Token(Token = "0x403B400")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act5D1RuneMissionPanel _permanentMissison;

		// Token: 0x0403B401 RID: 242689
		[Token(Token = "0x403B401")]
		[FieldOffset(Offset = "0x88")]
		private List<RuneShowInfo> m_tempRunesForShow;

		// Token: 0x0403B402 RID: 242690
		[Token(Token = "0x403B402")]
		[FieldOffset(Offset = "0x90")]
		private bool m_cannotUseBenefit;

		// Token: 0x0403B403 RID: 242691
		[Token(Token = "0x403B403")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403B404 RID: 242692
		[Token(Token = "0x403B404")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403B405 RID: 242693
		[Token(Token = "0x403B405")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_showRuneDetail;

		// Token: 0x0403B406 RID: 242694
		[Token(Token = "0x403B406")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403B407 RID: 242695
		[Token(Token = "0x403B407")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
