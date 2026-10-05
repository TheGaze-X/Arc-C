using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019E5 RID: 6629
	[Token(Token = "0x20019E5")]
	public class DIYFilterGroupModel : IHotfixable
	{
		// Token: 0x17001325 RID: 4901
		// (get) Token: 0x0600A672 RID: 42610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001325")]
		public ListDict<DIYFilterType, DIYFilterModel> filterModels
		{
			[Token(Token = "0x600A672")]
			[Address(RVA = "0x321AA30", Offset = "0x3219630", VA = "0x18321AA30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001326 RID: 4902
		// (get) Token: 0x0600A673 RID: 42611 RVA: 0x00040410 File Offset: 0x0003E610
		[Token(Token = "0x17001326")]
		public BuildingData.FurnitureSubType selectedSubType
		{
			[Token(Token = "0x600A673")]
			[Address(RVA = "0x321AA90", Offset = "0x3219690", VA = "0x18321AA90")]
			get
			{
				return BuildingData.FurnitureSubType.NONE;
			}
		}

		// Token: 0x0600A674 RID: 42612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A674")]
		[Address(RVA = "0x321A2B0", Offset = "0x3218EB0", VA = "0x18321A2B0")]
		private void _LoadALLFilter()
		{
		}

		// Token: 0x0600A675 RID: 42613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A675")]
		[Address(RVA = "0x321A490", Offset = "0x3219090", VA = "0x18321A490")]
		private void _LoadFilters()
		{
		}

		// Token: 0x0600A676 RID: 42614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A676")]
		[Address(RVA = "0x321A130", Offset = "0x3218D30", VA = "0x18321A130")]
		private void _ClearTrackpointStatus()
		{
		}

		// Token: 0x0600A677 RID: 42615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A677")]
		[Address(RVA = "0x32197C0", Offset = "0x32183C0", VA = "0x1832197C0")]
		public void LoadData()
		{
		}

		// Token: 0x0600A678 RID: 42616 RVA: 0x00040428 File Offset: 0x0003E628
		[Token(Token = "0x600A678")]
		[Address(RVA = "0x3219B30", Offset = "0x3218730", VA = "0x183219B30")]
		public bool SetSelectFilterType(DIYFilterType filterType)
		{
			return default(bool);
		}

		// Token: 0x0600A679 RID: 42617 RVA: 0x00040440 File Offset: 0x0003E640
		[Token(Token = "0x600A679")]
		[Address(RVA = "0x32199F0", Offset = "0x32185F0", VA = "0x1832199F0")]
		public bool SetSelectFilterSubType(BuildingData.FurnitureSubType subType)
		{
			return default(bool);
		}

		// Token: 0x0600A67A RID: 42618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A67A")]
		[Address(RVA = "0x3219C20", Offset = "0x3218820", VA = "0x183219C20")]
		public void UpdateTrackpointStatus(bool useRecent = false)
		{
		}

		// Token: 0x0600A67B RID: 42619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A67B")]
		[Address(RVA = "0x321A970", Offset = "0x3219570", VA = "0x18321A970")]
		public DIYFilterGroupModel()
		{
		}

		// Token: 0x04009E79 RID: 40569
		[Token(Token = "0x4009E79")]
		[FieldOffset(Offset = "0x10")]
		public DIYFilterType selectedFilterType;

		// Token: 0x04009E7A RID: 40570
		[Token(Token = "0x4009E7A")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, long> recentFurnitures;

		// Token: 0x04009E7B RID: 40571
		[Token(Token = "0x4009E7B")]
		[FieldOffset(Offset = "0x20")]
		public bool isHide;

		// Token: 0x04009E7C RID: 40572
		[Token(Token = "0x4009E7C")]
		[FieldOffset(Offset = "0x21")]
		public bool isReset;

		// Token: 0x04009E7D RID: 40573
		[Token(Token = "0x4009E7D")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<DIYFilterType, DIYFilterModel> m_filterModels;

		// Token: 0x04009E7E RID: 40574
		[Token(Token = "0x4009E7E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_filterModels;

		// Token: 0x04009E7F RID: 40575
		[Token(Token = "0x4009E7F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedSubType;

		// Token: 0x04009E80 RID: 40576
		[Token(Token = "0x4009E80")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadALLFilter;

		// Token: 0x04009E81 RID: 40577
		[Token(Token = "0x4009E81")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__LoadFilters;

		// Token: 0x04009E82 RID: 40578
		[Token(Token = "0x4009E82")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearTrackpointStatus;

		// Token: 0x04009E83 RID: 40579
		[Token(Token = "0x4009E83")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04009E84 RID: 40580
		[Token(Token = "0x4009E84")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetSelectFilterType;

		// Token: 0x04009E85 RID: 40581
		[Token(Token = "0x4009E85")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetSelectFilterSubType;

		// Token: 0x04009E86 RID: 40582
		[Token(Token = "0x4009E86")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateTrackpointStatus;

		// Token: 0x04009E87 RID: 40583
		[Token(Token = "0x4009E87")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
