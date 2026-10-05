using System;
using Il2CppDummyDll;
using Torappu.Building.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001ABB RID: 6843
	[Token(Token = "0x2001ABB")]
	public class BShopRoom : BOutputRoom
	{
		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x0600ACC8 RID: 44232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001475")]
		protected override GameObject harvestIcon
		{
			[Token(Token = "0x600ACC8")]
			[Address(RVA = "0x3277C70", Offset = "0x3276870", VA = "0x183277C70", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ACC9 RID: 44233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACC9")]
		[Address(RVA = "0x32771A0", Offset = "0x3275DA0", VA = "0x1832771A0", Slot = "15")]
		protected override void TriggerSettleEffect(BuildingUIResMenu.AsyncSettleInfo settleInfo, Action<BuildingUIResMenu.AsyncSettleInfo> triggerFunc)
		{
		}

		// Token: 0x0600ACCA RID: 44234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACCA")]
		[Address(RVA = "0x3276F40", Offset = "0x3275B40", VA = "0x183276F40", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600ACCB RID: 44235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ACCB")]
		[Address(RVA = "0x3276E90", Offset = "0x3275A90", VA = "0x183276E90", Slot = "4")]
		public override Action<object> ListenerToPlayerData()
		{
			return null;
		}

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x0600ACCC RID: 44236 RVA: 0x000429F0 File Offset: 0x00040BF0
		[Token(Token = "0x17001476")]
		protected override bool isWorking
		{
			[Token(Token = "0x600ACCC")]
			[Address(RVA = "0x3277D30", Offset = "0x3276930", VA = "0x183277D30", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ACCD RID: 44237 RVA: 0x00042A08 File Offset: 0x00040C08
		[Token(Token = "0x600ACCD")]
		[Address(RVA = "0x3276FE0", Offset = "0x3275BE0", VA = "0x183276FE0", Slot = "7")]
		protected override bool OnRoomClicked()
		{
			return default(bool);
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x0600ACCE RID: 44238 RVA: 0x00042A20 File Offset: 0x00040C20
		[Token(Token = "0x17001477")]
		protected override bool isHarvestable
		{
			[Token(Token = "0x600ACCE")]
			[Address(RVA = "0x3277CD0", Offset = "0x32768D0", VA = "0x183277CD0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600ACCF RID: 44239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACCF")]
		[Address(RVA = "0x32774E0", Offset = "0x32760E0", VA = "0x1832774E0")]
		private void _SetIsHarvestable(bool value)
		{
		}

		// Token: 0x0600ACD0 RID: 44240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD0")]
		[Address(RVA = "0x3277410", Offset = "0x3276010", VA = "0x183277410")]
		private void _OnPlayerDataChanged(object _)
		{
		}

		// Token: 0x0600ACD1 RID: 44241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD1")]
		[Address(RVA = "0x3277340", Offset = "0x3275F40", VA = "0x183277340")]
		private void Update()
		{
		}

		// Token: 0x0600ACD2 RID: 44242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD2")]
		[Address(RVA = "0x3277570", Offset = "0x3276170", VA = "0x183277570")]
		private void _UpdatePlayerData()
		{
		}

		// Token: 0x0600ACD3 RID: 44243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD3")]
		[Address(RVA = "0x32777A0", Offset = "0x32763A0", VA = "0x1832777A0")]
		private void _UpdateShopStatus()
		{
		}

		// Token: 0x0600ACD4 RID: 44244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD4")]
		[Address(RVA = "0x3277B70", Offset = "0x3276770", VA = "0x183277B70")]
		public BShopRoom()
		{
		}

		// Token: 0x0600ACD5 RID: 44245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ACD5")]
		[Address(RVA = "0x32712F0", Offset = "0x326FEF0", VA = "0x1832712F0")]
		private GameObject <>xLuaBaseProxy_get_harvestIcon()
		{
			return null;
		}

		// Token: 0x0600ACD6 RID: 44246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD6")]
		[Address(RVA = "0x3271250", Offset = "0x326FE50", VA = "0x183271250")]
		private void <>xLuaBaseProxy_TriggerSettleEffect(BuildingUIResMenu.AsyncSettleInfo P0, Action<BuildingUIResMenu.AsyncSettleInfo> P1)
		{
		}

		// Token: 0x0600ACD7 RID: 44247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ACD7")]
		[Address(RVA = "0x32711E0", Offset = "0x326FDE0", VA = "0x1832711E0")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600ACD8 RID: 44248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ACD8")]
		[Address(RVA = "0x326C700", Offset = "0x326B300", VA = "0x18326C700")]
		private Action<object> <>xLuaBaseProxy_ListenerToPlayerData()
		{
			return null;
		}

		// Token: 0x0600ACD9 RID: 44249 RVA: 0x00042A38 File Offset: 0x00040C38
		[Token(Token = "0x600ACD9")]
		[Address(RVA = "0x32711F0", Offset = "0x326FDF0", VA = "0x1832711F0")]
		private bool <>xLuaBaseProxy_OnRoomClicked()
		{
			return default(bool);
		}

		// Token: 0x0600ACDA RID: 44250 RVA: 0x00042A50 File Offset: 0x00040C50
		[Token(Token = "0x600ACDA")]
		[Address(RVA = "0x3271350", Offset = "0x326FF50", VA = "0x183271350")]
		private bool <>xLuaBaseProxy_get_isHarvestable()
		{
			return default(bool);
		}

		// Token: 0x0400A4FF RID: 42239
		[Token(Token = "0x400A4FF")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _iconProduct;

		// Token: 0x0400A500 RID: 42240
		[Token(Token = "0x400A500")]
		[FieldOffset(Offset = "0x100")]
		private CountDownTask[] m_countDowns;

		// Token: 0x0400A501 RID: 42241
		[Token(Token = "0x400A501")]
		[FieldOffset(Offset = "0x108")]
		private ShopStockSnapshot[] m_snapshots;

		// Token: 0x0400A502 RID: 42242
		[Token(Token = "0x400A502")]
		[FieldOffset(Offset = "0x110")]
		private ShopInfoViewModel m_shopModel;

		// Token: 0x0400A503 RID: 42243
		[Token(Token = "0x400A503")]
		[FieldOffset(Offset = "0x118")]
		private bool m_isHarvestable;

		// Token: 0x0400A504 RID: 42244
		[Token(Token = "0x400A504")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_harvestIcon;

		// Token: 0x0400A505 RID: 42245
		[Token(Token = "0x400A505")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TriggerSettleEffect;

		// Token: 0x0400A506 RID: 42246
		[Token(Token = "0x400A506")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A507 RID: 42247
		[Token(Token = "0x400A507")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ListenerToPlayerData;

		// Token: 0x0400A508 RID: 42248
		[Token(Token = "0x400A508")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isWorking;

		// Token: 0x0400A509 RID: 42249
		[Token(Token = "0x400A509")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRoomClicked;

		// Token: 0x0400A50A RID: 42250
		[Token(Token = "0x400A50A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isHarvestable;

		// Token: 0x0400A50B RID: 42251
		[Token(Token = "0x400A50B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetIsHarvestable;

		// Token: 0x0400A50C RID: 42252
		[Token(Token = "0x400A50C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400A50D RID: 42253
		[Token(Token = "0x400A50D")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400A50E RID: 42254
		[Token(Token = "0x400A50E")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdatePlayerData;

		// Token: 0x0400A50F RID: 42255
		[Token(Token = "0x400A50F")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateShopStatus;

		// Token: 0x0400A510 RID: 42256
		[Token(Token = "0x400A510")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
