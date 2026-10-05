using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001ABC RID: 6844
	[Token(Token = "0x2001ABC")]
	public class BTradingRoom : BOutputRoom
	{
		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x0600ACDB RID: 44251 RVA: 0x00042A68 File Offset: 0x00040C68
		[Token(Token = "0x17001478")]
		protected override bool isWorking
		{
			[Token(Token = "0x600ACDB")]
			[Address(RVA = "0x3279580", Offset = "0x3278180", VA = "0x183279580", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ACDC RID: 44252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACDC")]
		[Address(RVA = "0x32782B0", Offset = "0x3276EB0", VA = "0x1832782B0", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600ACDD RID: 44253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ACDD")]
		[Address(RVA = "0x3278200", Offset = "0x3276E00", VA = "0x183278200", Slot = "4")]
		public override Action<object> ListenerToPlayerData()
		{
			return null;
		}

		// Token: 0x0600ACDE RID: 44254 RVA: 0x00042A80 File Offset: 0x00040C80
		[Token(Token = "0x600ACDE")]
		[Address(RVA = "0x3278350", Offset = "0x3276F50", VA = "0x183278350", Slot = "7")]
		protected override bool OnRoomClicked()
		{
			return default(bool);
		}

		// Token: 0x0600ACDF RID: 44255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACDF")]
		[Address(RVA = "0x32788C0", Offset = "0x32774C0", VA = "0x1832788C0")]
		private void _OnProcess(BuildingDeliveryBatchOrderResponse resp)
		{
		}

		// Token: 0x0600ACE0 RID: 44256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACE0")]
		[Address(RVA = "0x3278560", Offset = "0x3277160", VA = "0x183278560")]
		private void _DoBatchOrderToast(ListDict<ItemType, int> otherCountDict)
		{
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x0600ACE1 RID: 44257 RVA: 0x00042A98 File Offset: 0x00040C98
		[Token(Token = "0x17001479")]
		protected override bool isHarvestable
		{
			[Token(Token = "0x600ACE1")]
			[Address(RVA = "0x3279520", Offset = "0x3278120", VA = "0x183279520", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x0600ACE2 RID: 44258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700147A")]
		protected override GameObject harvestIcon
		{
			[Token(Token = "0x600ACE2")]
			[Address(RVA = "0x32794C0", Offset = "0x32780C0", VA = "0x1832794C0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ACE3 RID: 44259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACE3")]
		[Address(RVA = "0x3278E80", Offset = "0x3277A80", VA = "0x183278E80")]
		private void _SetIsDelivertable(bool value)
		{
		}

		// Token: 0x0600ACE4 RID: 44260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACE4")]
		[Address(RVA = "0x3278790", Offset = "0x3277390", VA = "0x183278790")]
		private void _OnPlayerDataChanged(object arg)
		{
		}

		// Token: 0x0600ACE5 RID: 44261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACE5")]
		[Address(RVA = "0x3278F10", Offset = "0x3277B10", VA = "0x183278F10")]
		private void _UpdatePlayerStatus()
		{
		}

		// Token: 0x0600ACE6 RID: 44262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACE6")]
		[Address(RVA = "0x3279340", Offset = "0x3277F40", VA = "0x183279340")]
		public BTradingRoom()
		{
		}

		// Token: 0x0600ACE7 RID: 44263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACE7")]
		[Address(RVA = "0x32711E0", Offset = "0x326FDE0", VA = "0x1832711E0")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600ACE8 RID: 44264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ACE8")]
		[Address(RVA = "0x326C700", Offset = "0x326B300", VA = "0x18326C700")]
		private Action<object> <>xLuaBaseProxy_ListenerToPlayerData()
		{
			return null;
		}

		// Token: 0x0600ACE9 RID: 44265 RVA: 0x00042AB0 File Offset: 0x00040CB0
		[Token(Token = "0x600ACE9")]
		[Address(RVA = "0x32711F0", Offset = "0x326FDF0", VA = "0x1832711F0")]
		private bool <>xLuaBaseProxy_OnRoomClicked()
		{
			return default(bool);
		}

		// Token: 0x0600ACEA RID: 44266 RVA: 0x00042AC8 File Offset: 0x00040CC8
		[Token(Token = "0x600ACEA")]
		[Address(RVA = "0x3271350", Offset = "0x326FF50", VA = "0x183271350")]
		private bool <>xLuaBaseProxy_get_isHarvestable()
		{
			return default(bool);
		}

		// Token: 0x0600ACEB RID: 44267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ACEB")]
		[Address(RVA = "0x32712F0", Offset = "0x326FEF0", VA = "0x1832712F0")]
		private GameObject <>xLuaBaseProxy_get_harvestIcon()
		{
			return null;
		}

		// Token: 0x0400A511 RID: 42257
		[Token(Token = "0x400A511")]
		private const float NOTIFY_INTERVAL = 0.5f;

		// Token: 0x0400A512 RID: 42258
		[Token(Token = "0x400A512")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _iconOrders;

		// Token: 0x0400A513 RID: 42259
		[Token(Token = "0x400A513")]
		[FieldOffset(Offset = "0x100")]
		private TradingInfoViewStruct m_tradingInfo;

		// Token: 0x0400A514 RID: 42260
		[Token(Token = "0x400A514")]
		[FieldOffset(Offset = "0x180")]
		private bool m_isDelivertable;

		// Token: 0x0400A515 RID: 42261
		[Token(Token = "0x400A515")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isWorking;

		// Token: 0x0400A516 RID: 42262
		[Token(Token = "0x400A516")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A517 RID: 42263
		[Token(Token = "0x400A517")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ListenerToPlayerData;

		// Token: 0x0400A518 RID: 42264
		[Token(Token = "0x400A518")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRoomClicked;

		// Token: 0x0400A519 RID: 42265
		[Token(Token = "0x400A519")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnProcess;

		// Token: 0x0400A51A RID: 42266
		[Token(Token = "0x400A51A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoBatchOrderToast;

		// Token: 0x0400A51B RID: 42267
		[Token(Token = "0x400A51B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isHarvestable;

		// Token: 0x0400A51C RID: 42268
		[Token(Token = "0x400A51C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_harvestIcon;

		// Token: 0x0400A51D RID: 42269
		[Token(Token = "0x400A51D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SetIsDelivertable;

		// Token: 0x0400A51E RID: 42270
		[Token(Token = "0x400A51E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400A51F RID: 42271
		[Token(Token = "0x400A51F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdatePlayerStatus;

		// Token: 0x0400A520 RID: 42272
		[Token(Token = "0x400A520")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
