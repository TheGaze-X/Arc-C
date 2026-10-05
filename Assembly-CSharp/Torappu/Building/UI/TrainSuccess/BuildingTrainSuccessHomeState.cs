using System;
using Il2CppDummyDll;
using Torappu.Building.UI.Train;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.TrainSuccess
{
	// Token: 0x02001C02 RID: 7170
	[Token(Token = "0x2001C02")]
	public class BuildingTrainSuccessHomeState : State
	{
		// Token: 0x0600B2BD RID: 45757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B2BD")]
		[Address(RVA = "0x32DC6F0", Offset = "0x32DB2F0", VA = "0x1832DC6F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600B2BE RID: 45758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2BE")]
		[Address(RVA = "0x32DCED0", Offset = "0x32DBAD0", VA = "0x1832DCED0")]
		private void _OnLevelupConfirmed()
		{
		}

		// Token: 0x0600B2BF RID: 45759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2BF")]
		[Address(RVA = "0x32DC750", Offset = "0x32DB350", VA = "0x1832DC750", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600B2C0 RID: 45760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2C0")]
		[Address(RVA = "0x32DCF90", Offset = "0x32DBB90", VA = "0x1832DCF90")]
		public BuildingTrainSuccessHomeState()
		{
		}

		// Token: 0x0600B2C1 RID: 45761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B2C1")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0400ADC6 RID: 44486
		[Token(Token = "0x400ADC6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _successViewProto;

		// Token: 0x0400ADC7 RID: 44487
		[Token(Token = "0x400ADC7")]
		[FieldOffset(Offset = "0x58")]
		private BuildingTrainingLevelUpSuccessFullView m_fullView;

		// Token: 0x0400ADC8 RID: 44488
		[Token(Token = "0x400ADC8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400ADC9 RID: 44489
		[Token(Token = "0x400ADC9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnLevelupConfirmed;

		// Token: 0x0400ADCA RID: 44490
		[Token(Token = "0x400ADCA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400ADCB RID: 44491
		[Token(Token = "0x400ADCB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
