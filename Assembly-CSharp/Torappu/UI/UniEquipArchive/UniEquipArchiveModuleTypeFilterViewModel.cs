using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BD4 RID: 15316
	[Token(Token = "0x2003BD4")]
	public class UniEquipArchiveModuleTypeFilterViewModel : IHotfixable
	{
		// Token: 0x1700393D RID: 14653
		// (get) Token: 0x06017F81 RID: 98177 RVA: 0x00098CA0 File Offset: 0x00096EA0
		[Token(Token = "0x1700393D")]
		public UniEquipArchiveModuleTYpeFilterItemInfoData selectedTypeInfoData
		{
			[Token(Token = "0x6017F81")]
			[Address(RVA = "0x10672F0", Offset = "0x1065EF0", VA = "0x1810672F0")]
			get
			{
				return default(UniEquipArchiveModuleTYpeFilterItemInfoData);
			}
		}

		// Token: 0x1700393E RID: 14654
		// (get) Token: 0x06017F82 RID: 98178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700393E")]
		public List<UniEquipArchiveModuleTYpeFilterItemInfoData> filterItemInfoDataList
		{
			[Token(Token = "0x6017F82")]
			[Address(RVA = "0x1067230", Offset = "0x1065E30", VA = "0x181067230")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700393F RID: 14655
		// (get) Token: 0x06017F83 RID: 98179 RVA: 0x00098CB8 File Offset: 0x00096EB8
		[Token(Token = "0x1700393F")]
		public bool isFilterViewShowing
		{
			[Token(Token = "0x6017F83")]
			[Address(RVA = "0x1067290", Offset = "0x1065E90", VA = "0x181067290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06017F84 RID: 98180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F84")]
		[Address(RVA = "0x1066BD0", Offset = "0x10657D0", VA = "0x181066BD0")]
		public void InitData()
		{
		}

		// Token: 0x06017F85 RID: 98181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F85")]
		[Address(RVA = "0x1066CA0", Offset = "0x10658A0", VA = "0x181066CA0")]
		public void SetSelectedFilterType(string type)
		{
		}

		// Token: 0x06017F86 RID: 98182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F86")]
		[Address(RVA = "0x1066C30", Offset = "0x1065830", VA = "0x181066C30")]
		public void SetFilterViewShowing(bool isShowing)
		{
		}

		// Token: 0x06017F87 RID: 98183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F87")]
		[Address(RVA = "0x1066DC0", Offset = "0x10659C0", VA = "0x181066DC0")]
		private void _InitData()
		{
		}

		// Token: 0x06017F88 RID: 98184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F88")]
		[Address(RVA = "0x1067180", Offset = "0x1065D80", VA = "0x181067180")]
		public UniEquipArchiveModuleTypeFilterViewModel()
		{
		}

		// Token: 0x0401D041 RID: 118849
		[Token(Token = "0x401D041")]
		[FieldOffset(Offset = "0x10")]
		private UniEquipArchiveModuleTYpeFilterItemInfoData m_selectedTypeInfoData;

		// Token: 0x0401D042 RID: 118850
		[Token(Token = "0x401D042")]
		[FieldOffset(Offset = "0x28")]
		private List<UniEquipArchiveModuleTYpeFilterItemInfoData> m_filterItemInfoDataList;

		// Token: 0x0401D043 RID: 118851
		[Token(Token = "0x401D043")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isFilterViewShowing;

		// Token: 0x0401D044 RID: 118852
		[Token(Token = "0x401D044")]
		public const string ALL_TYPE = "ALL";

		// Token: 0x0401D045 RID: 118853
		[Token(Token = "0x401D045")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedTypeInfoData;

		// Token: 0x0401D046 RID: 118854
		[Token(Token = "0x401D046")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_filterItemInfoDataList;

		// Token: 0x0401D047 RID: 118855
		[Token(Token = "0x401D047")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isFilterViewShowing;

		// Token: 0x0401D048 RID: 118856
		[Token(Token = "0x401D048")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401D049 RID: 118857
		[Token(Token = "0x401D049")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetSelectedFilterType;

		// Token: 0x0401D04A RID: 118858
		[Token(Token = "0x401D04A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetFilterViewShowing;

		// Token: 0x0401D04B RID: 118859
		[Token(Token = "0x401D04B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitData;

		// Token: 0x0401D04C RID: 118860
		[Token(Token = "0x401D04C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
