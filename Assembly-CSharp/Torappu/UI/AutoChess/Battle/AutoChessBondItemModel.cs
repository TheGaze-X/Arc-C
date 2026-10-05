using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064D9 RID: 25817
	[Token(Token = "0x20064D9")]
	public class AutoChessBondItemModel : UISimpleRecycleLayoutItemViewModel, IHotfixable, IComparable<AutoChessBondItemModel>
	{
		// Token: 0x17005782 RID: 22402
		// (get) Token: 0x06025188 RID: 151944 RVA: 0x000C66F0 File Offset: 0x000C48F0
		[Token(Token = "0x17005782")]
		public int gap
		{
			[Token(Token = "0x6025188")]
			[Address(RVA = "0x1FEED70", Offset = "0x1FED970", VA = "0x181FEED70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06025189 RID: 151945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025189")]
		[Address(RVA = "0x1FEE7E0", Offset = "0x1FED3E0", VA = "0x181FEE7E0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x0602518A RID: 151946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602518A")]
		[Address(RVA = "0x1FEE850", Offset = "0x1FED450", VA = "0x181FEE850")]
		public void LoadData(string bondId)
		{
		}

		// Token: 0x0602518B RID: 151947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602518B")]
		[Address(RVA = "0x1FEE960", Offset = "0x1FED560", VA = "0x181FEE960")]
		public void UpdateData(GarrisonBond bondData, int playerIndex, List<string> bannedChessIds, ActAutoChessData actData)
		{
		}

		// Token: 0x0602518C RID: 151948 RVA: 0x000C6708 File Offset: 0x000C4908
		[Token(Token = "0x602518C")]
		[Address(RVA = "0x1FEE6E0", Offset = "0x1FED2E0", VA = "0x181FEE6E0", Slot = "6")]
		public int CompareTo(AutoChessBondItemModel other)
		{
			return 0;
		}

		// Token: 0x0602518D RID: 151949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602518D")]
		[Address(RVA = "0x1FEEA60", Offset = "0x1FED660", VA = "0x181FEEA60")]
		private void _UpdateCharData(int playerIndex, List<string> bannedChessIds, ActAutoChessData actData)
		{
		}

		// Token: 0x0602518E RID: 151950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602518E")]
		[Address(RVA = "0x1FEECC0", Offset = "0x1FED8C0", VA = "0x181FEECC0")]
		public AutoChessBondItemModel()
		{
		}

		// Token: 0x04033F90 RID: 212880
		[Token(Token = "0x4033F90")]
		public const string VIEW_TYPE = "HUD_BOND_ITEM";

		// Token: 0x04033F91 RID: 212881
		[Token(Token = "0x4033F91")]
		[FieldOffset(Offset = "0x10")]
		public string bondId;

		// Token: 0x04033F92 RID: 212882
		[Token(Token = "0x4033F92")]
		[FieldOffset(Offset = "0x18")]
		public string bondName;

		// Token: 0x04033F93 RID: 212883
		[Token(Token = "0x4033F93")]
		[FieldOffset(Offset = "0x20")]
		public string bondIcon;

		// Token: 0x04033F94 RID: 212884
		[Token(Token = "0x4033F94")]
		[FieldOffset(Offset = "0x28")]
		public int activeCount;

		// Token: 0x04033F95 RID: 212885
		[Token(Token = "0x4033F95")]
		[FieldOffset(Offset = "0x2C")]
		public int requireCount;

		// Token: 0x04033F96 RID: 212886
		[Token(Token = "0x4033F96")]
		[FieldOffset(Offset = "0x30")]
		public bool isActive;

		// Token: 0x04033F97 RID: 212887
		[Token(Token = "0x4033F97")]
		[FieldOffset(Offset = "0x31")]
		public bool hasStack;

		// Token: 0x04033F98 RID: 212888
		[Token(Token = "0x4033F98")]
		[FieldOffset(Offset = "0x34")]
		public int stack;

		// Token: 0x04033F99 RID: 212889
		[Token(Token = "0x4033F99")]
		[FieldOffset(Offset = "0x38")]
		private int m_identifier;

		// Token: 0x04033F9A RID: 212890
		[Token(Token = "0x4033F9A")]
		[FieldOffset(Offset = "0x40")]
		public List<AutoChessBondCharModel> charModels;

		// Token: 0x04033F9B RID: 212891
		[Token(Token = "0x4033F9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gap;

		// Token: 0x04033F9C RID: 212892
		[Token(Token = "0x4033F9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033F9D RID: 212893
		[Token(Token = "0x4033F9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033F9E RID: 212894
		[Token(Token = "0x4033F9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x04033F9F RID: 212895
		[Token(Token = "0x4033F9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04033FA0 RID: 212896
		[Token(Token = "0x4033FA0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateCharData;

		// Token: 0x04033FA1 RID: 212897
		[Token(Token = "0x4033FA1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
