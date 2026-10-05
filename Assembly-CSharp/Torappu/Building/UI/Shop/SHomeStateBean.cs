using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CE8 RID: 7400
	[Token(Token = "0x2001CE8")]
	public class SHomeStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0600B6DA RID: 46810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6DA")]
		[Address(RVA = "0x3350180", Offset = "0x334ED80", VA = "0x183350180")]
		public SHomeStateBean()
		{
		}

		// Token: 0x0600B6DB RID: 46811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6DB")]
		[Address(RVA = "0x334F420", Offset = "0x334E020", VA = "0x18334F420")]
		public void Tick()
		{
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x0600B6DC RID: 46812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015F0")]
		public string selectedSlotId
		{
			[Token(Token = "0x600B6DC")]
			[Address(RVA = "0x3350380", Offset = "0x334EF80", VA = "0x183350380")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B6DD RID: 46813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6DD")]
		[Address(RVA = "0x334F270", Offset = "0x334DE70", VA = "0x18334F270")]
		public void SetSelectedSlot(string slotId)
		{
		}

		// Token: 0x0600B6DE RID: 46814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6DE")]
		[Address(RVA = "0x334ECB0", Offset = "0x334D8B0", VA = "0x18334ECB0")]
		public void InitData()
		{
		}

		// Token: 0x0600B6DF RID: 46815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6DF")]
		[Address(RVA = "0x334F4E0", Offset = "0x334E0E0", VA = "0x18334F4E0")]
		public void UpdateData()
		{
		}

		// Token: 0x0600B6E0 RID: 46816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6E0")]
		[Address(RVA = "0x334EB50", Offset = "0x334D750", VA = "0x18334EB50")]
		public void EditChangeFormula(SStockViewModel stockModel, BuildingData.ShopFormula formula)
		{
		}

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6E1")]
		[Address(RVA = "0x334EA50", Offset = "0x334D650", VA = "0x18334EA50")]
		public void EditChangeCount(SStockViewModel stockModel, int delta)
		{
		}

		// Token: 0x0600B6E2 RID: 46818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6E2")]
		[Address(RVA = "0x334E5D0", Offset = "0x334D1D0", VA = "0x18334E5D0")]
		public void CancelEdit(int stockIndex)
		{
		}

		// Token: 0x0600B6E3 RID: 46819 RVA: 0x000450A8 File Offset: 0x000432A8
		[Token(Token = "0x600B6E3")]
		[Address(RVA = "0x334E680", Offset = "0x334D280", VA = "0x18334E680")]
		public bool CheckConfirmEdit(int stockIndex, out string errorInfo)
		{
			return default(bool);
		}

		// Token: 0x0600B6E4 RID: 46820 RVA: 0x000450C0 File Offset: 0x000432C0
		[Token(Token = "0x600B6E4")]
		[Address(RVA = "0x334E9B0", Offset = "0x334D5B0", VA = "0x18334E9B0")]
		public bool CheckIfCanHarvest()
		{
			return default(bool);
		}

		// Token: 0x0600B6E5 RID: 46821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6E5")]
		[Address(RVA = "0x334F970", Offset = "0x334E570", VA = "0x18334F970")]
		private void _OnCountDownTimeout()
		{
		}

		// Token: 0x0600B6E6 RID: 46822 RVA: 0x000450D8 File Offset: 0x000432D8
		[Token(Token = "0x600B6E6")]
		[Address(RVA = "0x334F880", Offset = "0x334E480", VA = "0x18334F880")]
		private bool _CheckTabTrackPoint(PlayerBuildingShop shop)
		{
			return default(bool);
		}

		// Token: 0x0600B6E7 RID: 46823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6E7")]
		[Address(RVA = "0x334FF80", Offset = "0x334EB80", VA = "0x18334FF80")]
		private void _UpdateStocks(SRoomViewModel selectedRoom)
		{
		}

		// Token: 0x0600B6E8 RID: 46824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6E8")]
		[Address(RVA = "0x334FC70", Offset = "0x334E870", VA = "0x18334FC70")]
		private void _UpdateEditInfo(int stockIndex)
		{
		}

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6E9")]
		[Address(RVA = "0x334F9D0", Offset = "0x334E5D0", VA = "0x18334F9D0")]
		private void _ResetEdit(params int[] indexes)
		{
		}

		// Token: 0x0600B6EA RID: 46826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6EA")]
		[Address(RVA = "0x334FB10", Offset = "0x334E710", VA = "0x18334FB10")]
		private void _UpdateCountDowns()
		{
		}

		// Token: 0x0400B4A1 RID: 46241
		[Token(Token = "0x400B4A1")]
		[FieldOffset(Offset = "0x10")]
		private readonly int[] ALL_STOCK_INDEXES;

		// Token: 0x0400B4A2 RID: 46242
		[Token(Token = "0x400B4A2")]
		[FieldOffset(Offset = "0x18")]
		public SRoomGroupViewProperty roomGroupProperty;

		// Token: 0x0400B4A3 RID: 46243
		[Token(Token = "0x400B4A3")]
		[FieldOffset(Offset = "0x20")]
		public SRoomViewProperty selectedRoomProperty;

		// Token: 0x0400B4A4 RID: 46244
		[Token(Token = "0x400B4A4")]
		[FieldOffset(Offset = "0x28")]
		public SStockViewProperty[] stockSlotProperties;

		// Token: 0x0400B4A5 RID: 46245
		[Token(Token = "0x400B4A5")]
		[FieldOffset(Offset = "0x30")]
		private CountDownTask[] m_countDowns;

		// Token: 0x0400B4A6 RID: 46246
		[Token(Token = "0x400B4A6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400B4A7 RID: 46247
		[Token(Token = "0x400B4A7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Tick;

		// Token: 0x0400B4A8 RID: 46248
		[Token(Token = "0x400B4A8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedSlotId;

		// Token: 0x0400B4A9 RID: 46249
		[Token(Token = "0x400B4A9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSelectedSlot;

		// Token: 0x0400B4AA RID: 46250
		[Token(Token = "0x400B4AA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0400B4AB RID: 46251
		[Token(Token = "0x400B4AB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0400B4AC RID: 46252
		[Token(Token = "0x400B4AC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_EditChangeFormula;

		// Token: 0x0400B4AD RID: 46253
		[Token(Token = "0x400B4AD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EditChangeCount;

		// Token: 0x0400B4AE RID: 46254
		[Token(Token = "0x400B4AE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CancelEdit;

		// Token: 0x0400B4AF RID: 46255
		[Token(Token = "0x400B4AF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckConfirmEdit;

		// Token: 0x0400B4B0 RID: 46256
		[Token(Token = "0x400B4B0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfCanHarvest;

		// Token: 0x0400B4B1 RID: 46257
		[Token(Token = "0x400B4B1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnCountDownTimeout;

		// Token: 0x0400B4B2 RID: 46258
		[Token(Token = "0x400B4B2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__CheckTabTrackPoint;

		// Token: 0x0400B4B3 RID: 46259
		[Token(Token = "0x400B4B3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateStocks;

		// Token: 0x0400B4B4 RID: 46260
		[Token(Token = "0x400B4B4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateEditInfo;

		// Token: 0x0400B4B5 RID: 46261
		[Token(Token = "0x400B4B5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ResetEdit;

		// Token: 0x0400B4B6 RID: 46262
		[Token(Token = "0x400B4B6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateCountDowns;
	}
}
