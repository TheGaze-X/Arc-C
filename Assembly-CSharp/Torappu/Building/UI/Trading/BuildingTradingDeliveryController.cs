using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Trading
{
	// Token: 0x02001C31 RID: 7217
	[Token(Token = "0x2001C31")]
	public class BuildingTradingDeliveryController : PageSingleComponent
	{
		// Token: 0x0600B3A4 RID: 45988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3A4")]
		[Address(RVA = "0x32D2FC0", Offset = "0x32D1BC0", VA = "0x1832D2FC0")]
		public static BuildingTradingDeliveryController GetInstance()
		{
			return null;
		}

		// Token: 0x0600B3A5 RID: 45989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3A5")]
		[Address(RVA = "0x32D3030", Offset = "0x32D1C30", VA = "0x1832D3030")]
		public static void LogOrderForDelivery(BuildingTradingOrderView orderView, TradingOrderStruct orderStruct)
		{
		}

		// Token: 0x0600B3A6 RID: 45990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3A6")]
		[Address(RVA = "0x32D3260", Offset = "0x32D1E60", VA = "0x1832D3260")]
		public static Coroutine TriggerDeliveryEffect()
		{
			return null;
		}

		// Token: 0x0600B3A7 RID: 45991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3A7")]
		[Address(RVA = "0x32D2F10", Offset = "0x32D1B10", VA = "0x1832D2F10")]
		public static void ClearLog()
		{
		}

		// Token: 0x0600B3A8 RID: 45992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3A8")]
		[Address(RVA = "0x32D33B0", Offset = "0x32D1FB0", VA = "0x1832D33B0")]
		private void _Clear()
		{
		}

		// Token: 0x0600B3A9 RID: 45993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B3A9")]
		[Address(RVA = "0x32D3450", Offset = "0x32D2050", VA = "0x1832D3450")]
		private IEnumerator _DeliveryCoroutine()
		{
			return null;
		}

		// Token: 0x0600B3AA RID: 45994 RVA: 0x000443B8 File Offset: 0x000425B8
		[Token(Token = "0x600B3AA")]
		[Address(RVA = "0x32D3500", Offset = "0x32D2100", VA = "0x1832D3500")]
		private static ItemType _GetRewardItemType(TradingOrderReward rewardType)
		{
			return ItemType.NONE;
		}

		// Token: 0x0600B3AB RID: 45995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B3AB")]
		[Address(RVA = "0x32D3570", Offset = "0x32D2170", VA = "0x1832D3570")]
		public BuildingTradingDeliveryController()
		{
		}

		// Token: 0x0400AF12 RID: 44818
		[Token(Token = "0x400AF12")]
		private const float DELIVERY_EFFECT_DURATION = 0.5f;

		// Token: 0x0400AF13 RID: 44819
		[Token(Token = "0x400AF13")]
		[FieldOffset(Offset = "0x20")]
		private List<BuildingTradingDeliveryController.OrderLog> m_orderLogs;

		// Token: 0x0400AF14 RID: 44820
		[Token(Token = "0x400AF14")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetInstance;

		// Token: 0x0400AF15 RID: 44821
		[Token(Token = "0x400AF15")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LogOrderForDelivery;

		// Token: 0x0400AF16 RID: 44822
		[Token(Token = "0x400AF16")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TriggerDeliveryEffect;

		// Token: 0x0400AF17 RID: 44823
		[Token(Token = "0x400AF17")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ClearLog;

		// Token: 0x0400AF18 RID: 44824
		[Token(Token = "0x400AF18")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Clear;

		// Token: 0x0400AF19 RID: 44825
		[Token(Token = "0x400AF19")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DeliveryCoroutine;

		// Token: 0x0400AF1A RID: 44826
		[Token(Token = "0x400AF1A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetRewardItemType;

		// Token: 0x0400AF1B RID: 44827
		[Token(Token = "0x400AF1B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001C32 RID: 7218
		[Token(Token = "0x2001C32")]
		public struct OrderLog
		{
			// Token: 0x0400AF1C RID: 44828
			[Token(Token = "0x400AF1C")]
			[FieldOffset(Offset = "0x0")]
			public BuildingTradingOrderView orderView;

			// Token: 0x0400AF1D RID: 44829
			[Token(Token = "0x400AF1D")]
			[FieldOffset(Offset = "0x8")]
			public TradingOrderStruct orderStruct;
		}
	}
}
