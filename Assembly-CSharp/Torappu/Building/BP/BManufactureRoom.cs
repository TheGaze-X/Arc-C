using System;
using Il2CppDummyDll;
using Torappu.Building.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001AB4 RID: 6836
	[Token(Token = "0x2001AB4")]
	public class BManufactureRoom : BOutputRoom
	{
		// Token: 0x17001467 RID: 5223
		// (get) Token: 0x0600AC7C RID: 44156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001467")]
		protected override GameObject harvestIcon
		{
			[Token(Token = "0x600AC7C")]
			[Address(RVA = "0x3271DA0", Offset = "0x32709A0", VA = "0x183271DA0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC7D")]
		[Address(RVA = "0x3271080", Offset = "0x326FC80", VA = "0x183271080", Slot = "15")]
		protected override void TriggerSettleEffect(BuildingUIResMenu.AsyncSettleInfo settleInfo, Action<BuildingUIResMenu.AsyncSettleInfo> triggerFunc)
		{
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC7E")]
		[Address(RVA = "0x3270E20", Offset = "0x326FA20", VA = "0x183270E20", Slot = "5")]
		protected override void OnInit(BRoomSlot roomSlot, RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC7F RID: 44159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC7F")]
		[Address(RVA = "0x3270D70", Offset = "0x326F970", VA = "0x183270D70", Slot = "4")]
		public override Action<object> ListenerToPlayerData()
		{
			return null;
		}

		// Token: 0x0600AC80 RID: 44160 RVA: 0x00042888 File Offset: 0x00040A88
		[Token(Token = "0x600AC80")]
		[Address(RVA = "0x3270EC0", Offset = "0x326FAC0", VA = "0x183270EC0", Slot = "7")]
		protected override bool OnRoomClicked()
		{
			return default(bool);
		}

		// Token: 0x17001468 RID: 5224
		// (get) Token: 0x0600AC81 RID: 44161 RVA: 0x000428A0 File Offset: 0x00040AA0
		[Token(Token = "0x17001468")]
		protected override bool isWorking
		{
			[Token(Token = "0x600AC81")]
			[Address(RVA = "0x3271E60", Offset = "0x3270A60", VA = "0x183271E60", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x0600AC82 RID: 44162 RVA: 0x000428B8 File Offset: 0x00040AB8
		[Token(Token = "0x17001469")]
		protected override bool isHarvestable
		{
			[Token(Token = "0x600AC82")]
			[Address(RVA = "0x3271E00", Offset = "0x3270A00", VA = "0x183271E00", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600AC83 RID: 44163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC83")]
		[Address(RVA = "0x3271620", Offset = "0x3270220", VA = "0x183271620")]
		private void _SetIsHarvestable(bool value)
		{
		}

		// Token: 0x0600AC84 RID: 44164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC84")]
		[Address(RVA = "0x3271550", Offset = "0x3270150", VA = "0x183271550")]
		private void _OnPlayerDataChanged(object _)
		{
		}

		// Token: 0x0600AC85 RID: 44165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC85")]
		[Address(RVA = "0x32714E0", Offset = "0x32700E0", VA = "0x1832714E0")]
		private void Update()
		{
		}

		// Token: 0x0600AC86 RID: 44166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC86")]
		[Address(RVA = "0x3271AC0", Offset = "0x32706C0", VA = "0x183271AC0")]
		private void _UpdatePlayerData()
		{
		}

		// Token: 0x0600AC87 RID: 44167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC87")]
		[Address(RVA = "0x32716B0", Offset = "0x32702B0", VA = "0x1832716B0")]
		private void _UpdateManufactStatus()
		{
		}

		// Token: 0x0600AC88 RID: 44168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC88")]
		[Address(RVA = "0x3271CF0", Offset = "0x32708F0", VA = "0x183271CF0")]
		public BManufactureRoom()
		{
		}

		// Token: 0x0600AC8A RID: 44170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC8A")]
		[Address(RVA = "0x32712F0", Offset = "0x326FEF0", VA = "0x1832712F0")]
		private GameObject <>xLuaBaseProxy_get_harvestIcon()
		{
			return null;
		}

		// Token: 0x0600AC8B RID: 44171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC8B")]
		[Address(RVA = "0x3271250", Offset = "0x326FE50", VA = "0x183271250")]
		private void <>xLuaBaseProxy_TriggerSettleEffect(BuildingUIResMenu.AsyncSettleInfo P0, Action<BuildingUIResMenu.AsyncSettleInfo> P1)
		{
		}

		// Token: 0x0600AC8C RID: 44172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC8C")]
		[Address(RVA = "0x32711E0", Offset = "0x326FDE0", VA = "0x1832711E0")]
		private void <>xLuaBaseProxy_OnInit(BRoomSlot P0, RoomSlotModel P1)
		{
		}

		// Token: 0x0600AC8D RID: 44173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC8D")]
		[Address(RVA = "0x326C700", Offset = "0x326B300", VA = "0x18326C700")]
		private Action<object> <>xLuaBaseProxy_ListenerToPlayerData()
		{
			return null;
		}

		// Token: 0x0600AC8E RID: 44174 RVA: 0x000428D0 File Offset: 0x00040AD0
		[Token(Token = "0x600AC8E")]
		[Address(RVA = "0x32711F0", Offset = "0x326FDF0", VA = "0x1832711F0")]
		private bool <>xLuaBaseProxy_OnRoomClicked()
		{
			return default(bool);
		}

		// Token: 0x0600AC8F RID: 44175 RVA: 0x000428E8 File Offset: 0x00040AE8
		[Token(Token = "0x600AC8F")]
		[Address(RVA = "0x3271350", Offset = "0x326FF50", VA = "0x183271350")]
		private bool <>xLuaBaseProxy_get_isHarvestable()
		{
			return default(bool);
		}

		// Token: 0x0400A4A8 RID: 42152
		[Token(Token = "0x400A4A8")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _iconProduct;

		// Token: 0x0400A4A9 RID: 42153
		[Token(Token = "0x400A4A9")]
		[FieldOffset(Offset = "0x100")]
		private CountDownTask m_countDown;

		// Token: 0x0400A4AA RID: 42154
		[Token(Token = "0x400A4AA")]
		[FieldOffset(Offset = "0x108")]
		private ManufactInfoViewModel m_manufactModel;

		// Token: 0x0400A4AB RID: 42155
		[Token(Token = "0x400A4AB")]
		[FieldOffset(Offset = "0x110")]
		private bool m_isHarvestable;

		// Token: 0x0400A4AC RID: 42156
		[Token(Token = "0x400A4AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_harvestIcon;

		// Token: 0x0400A4AD RID: 42157
		[Token(Token = "0x400A4AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TriggerSettleEffect;

		// Token: 0x0400A4AE RID: 42158
		[Token(Token = "0x400A4AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400A4AF RID: 42159
		[Token(Token = "0x400A4AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ListenerToPlayerData;

		// Token: 0x0400A4B0 RID: 42160
		[Token(Token = "0x400A4B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRoomClicked;

		// Token: 0x0400A4B1 RID: 42161
		[Token(Token = "0x400A4B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isWorking;

		// Token: 0x0400A4B2 RID: 42162
		[Token(Token = "0x400A4B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isHarvestable;

		// Token: 0x0400A4B3 RID: 42163
		[Token(Token = "0x400A4B3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetIsHarvestable;

		// Token: 0x0400A4B4 RID: 42164
		[Token(Token = "0x400A4B4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnPlayerDataChanged;

		// Token: 0x0400A4B5 RID: 42165
		[Token(Token = "0x400A4B5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400A4B6 RID: 42166
		[Token(Token = "0x400A4B6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdatePlayerData;

		// Token: 0x0400A4B7 RID: 42167
		[Token(Token = "0x400A4B7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateManufactStatus;

		// Token: 0x0400A4B8 RID: 42168
		[Token(Token = "0x400A4B8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
