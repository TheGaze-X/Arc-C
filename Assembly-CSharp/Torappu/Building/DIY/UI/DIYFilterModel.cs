using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019EB RID: 6635
	[Token(Token = "0x20019EB")]
	public class DIYFilterModel : IHotfixable
	{
		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x0600A68A RID: 42634 RVA: 0x000404B8 File Offset: 0x0003E6B8
		// (set) Token: 0x0600A68B RID: 42635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001327")]
		public bool hasTrackpoint
		{
			[Token(Token = "0x600A68A")]
			[Address(RVA = "0x321AED0", Offset = "0x3219AD0", VA = "0x18321AED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A68B")]
			[Address(RVA = "0x321B140", Offset = "0x3219D40", VA = "0x18321B140")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x0600A68C RID: 42636 RVA: 0x000404D0 File Offset: 0x0003E6D0
		// (set) Token: 0x0600A68D RID: 42637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001328")]
		public DIYFilterType filterType
		{
			[Token(Token = "0x600A68C")]
			[Address(RVA = "0x321AE70", Offset = "0x3219A70", VA = "0x18321AE70")]
			get
			{
				return DIYFilterType.FLOOR;
			}
			[Token(Token = "0x600A68D")]
			[Address(RVA = "0x321B0D0", Offset = "0x3219CD0", VA = "0x18321B0D0")]
			set
			{
			}
		}

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x0600A68E RID: 42638 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A68F RID: 42639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001329")]
		public string displayName
		{
			[Token(Token = "0x600A68E")]
			[Address(RVA = "0x321AE10", Offset = "0x3219A10", VA = "0x18321AE10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A68F")]
			[Address(RVA = "0x321B050", Offset = "0x3219C50", VA = "0x18321B050")]
			set
			{
			}
		}

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x0600A690 RID: 42640 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A691 RID: 42641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700132A")]
		public ListDict<BuildingData.FurnitureSubType, DIYFilterSubTypeModel> subTypes
		{
			[Token(Token = "0x600A690")]
			[Address(RVA = "0x321AFF0", Offset = "0x3219BF0", VA = "0x18321AFF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A691")]
			[Address(RVA = "0x321B290", Offset = "0x3219E90", VA = "0x18321B290")]
			set
			{
			}
		}

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x0600A692 RID: 42642 RVA: 0x000404E8 File Offset: 0x0003E6E8
		// (set) Token: 0x0600A693 RID: 42643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700132B")]
		public bool isFixed
		{
			[Token(Token = "0x600A692")]
			[Address(RVA = "0x321AF30", Offset = "0x3219B30", VA = "0x18321AF30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A693")]
			[Address(RVA = "0x321B1B0", Offset = "0x3219DB0", VA = "0x18321B1B0")]
			set
			{
			}
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x0600A694 RID: 42644 RVA: 0x00040500 File Offset: 0x0003E700
		// (set) Token: 0x0600A695 RID: 42645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700132C")]
		public BuildingData.FurnitureSubType selectedSubType
		{
			[Token(Token = "0x600A694")]
			[Address(RVA = "0x321AF90", Offset = "0x3219B90", VA = "0x18321AF90")]
			get
			{
				return BuildingData.FurnitureSubType.NONE;
			}
			[Token(Token = "0x600A695")]
			[Address(RVA = "0x321B220", Offset = "0x3219E20", VA = "0x18321B220")]
			set
			{
			}
		}

		// Token: 0x0600A696 RID: 42646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A696")]
		[Address(RVA = "0x321AB90", Offset = "0x3219790", VA = "0x18321AB90")]
		public void ClearTrackpointStatus()
		{
		}

		// Token: 0x0600A697 RID: 42647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A697")]
		[Address(RVA = "0x321AD60", Offset = "0x3219960", VA = "0x18321AD60")]
		public DIYFilterModel()
		{
		}

		// Token: 0x04009EA1 RID: 40609
		[Token(Token = "0x4009EA1")]
		[FieldOffset(Offset = "0x10")]
		private DIYFilterType m_filterType;

		// Token: 0x04009EA2 RID: 40610
		[Token(Token = "0x4009EA2")]
		[FieldOffset(Offset = "0x14")]
		private BuildingData.FurnitureSubType m_selectedSubType;

		// Token: 0x04009EA3 RID: 40611
		[Token(Token = "0x4009EA3")]
		[FieldOffset(Offset = "0x18")]
		private string m_displayName;

		// Token: 0x04009EA4 RID: 40612
		[Token(Token = "0x4009EA4")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isFixed;

		// Token: 0x04009EA5 RID: 40613
		[Token(Token = "0x4009EA5")]
		[FieldOffset(Offset = "0x28")]
		private ListDict<BuildingData.FurnitureSubType, DIYFilterSubTypeModel> m_subTypes;

		// Token: 0x04009EA7 RID: 40615
		[Token(Token = "0x4009EA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasTrackpoint;

		// Token: 0x04009EA8 RID: 40616
		[Token(Token = "0x4009EA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_hasTrackpoint;

		// Token: 0x04009EA9 RID: 40617
		[Token(Token = "0x4009EA9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_filterType;

		// Token: 0x04009EAA RID: 40618
		[Token(Token = "0x4009EAA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_filterType;

		// Token: 0x04009EAB RID: 40619
		[Token(Token = "0x4009EAB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_displayName;

		// Token: 0x04009EAC RID: 40620
		[Token(Token = "0x4009EAC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_displayName;

		// Token: 0x04009EAD RID: 40621
		[Token(Token = "0x4009EAD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_subTypes;

		// Token: 0x04009EAE RID: 40622
		[Token(Token = "0x4009EAE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_subTypes;

		// Token: 0x04009EAF RID: 40623
		[Token(Token = "0x4009EAF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isFixed;

		// Token: 0x04009EB0 RID: 40624
		[Token(Token = "0x4009EB0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isFixed;

		// Token: 0x04009EB1 RID: 40625
		[Token(Token = "0x4009EB1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_selectedSubType;

		// Token: 0x04009EB2 RID: 40626
		[Token(Token = "0x4009EB2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_selectedSubType;

		// Token: 0x04009EB3 RID: 40627
		[Token(Token = "0x4009EB3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ClearTrackpointStatus;

		// Token: 0x04009EB4 RID: 40628
		[Token(Token = "0x4009EB4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
