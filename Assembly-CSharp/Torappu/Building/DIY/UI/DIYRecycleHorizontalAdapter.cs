using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019B5 RID: 6581
	[Token(Token = "0x20019B5")]
	public class DIYRecycleHorizontalAdapter : UIRecycleLayoutAdapter
	{
		// Token: 0x1700130D RID: 4877
		// (get) Token: 0x0600A54E RID: 42318 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A54F RID: 42319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700130D")]
		public List<DIYItemViewData> dataSource
		{
			[Token(Token = "0x600A54E")]
			[Address(RVA = "0x31F6820", Offset = "0x31F5420", VA = "0x1831F6820")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A54F")]
			[Address(RVA = "0x31F68E0", Offset = "0x31F54E0", VA = "0x1831F68E0")]
			set
			{
			}
		}

		// Token: 0x1700130E RID: 4878
		// (get) Token: 0x0600A550 RID: 42320 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A551 RID: 42321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700130E")]
		public List<DIYItemViewData> funcDataSource
		{
			[Token(Token = "0x600A550")]
			[Address(RVA = "0x31F6880", Offset = "0x31F5480", VA = "0x1831F6880")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A551")]
			[Address(RVA = "0x31F6960", Offset = "0x31F5560", VA = "0x1831F6960")]
			set
			{
			}
		}

		// Token: 0x0600A552 RID: 42322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A552")]
		[Address(RVA = "0x31F6680", Offset = "0x31F5280", VA = "0x1831F6680")]
		public DIYRecycleHorizontalAdapter(List<DIYItemViewData> data, List<DIYItemViewData> funcData, DIYRecycleElementView prefab, DIYRecycleElementView emptyPrefab)
		{
		}

		// Token: 0x0600A553 RID: 42323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A553")]
		[Address(RVA = "0x31F6390", Offset = "0x31F4F90", VA = "0x1831F6390")]
		public void Rebuild()
		{
		}

		// Token: 0x0600A554 RID: 42324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A554")]
		[Address(RVA = "0x31F64B0", Offset = "0x31F50B0", VA = "0x1831F64B0")]
		public void TryUpdateItemViews()
		{
		}

		// Token: 0x0600A555 RID: 42325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A555")]
		[Address(RVA = "0x31F5F20", Offset = "0x31F4B20", VA = "0x1831F5F20", Slot = "4")]
		public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
		{
			return null;
		}

		// Token: 0x04009CDA RID: 40154
		[Token(Token = "0x4009CDA")]
		[FieldOffset(Offset = "0x18")]
		public Func<DIYItemViewData, bool> OnButtonSelected;

		// Token: 0x04009CDB RID: 40155
		[Token(Token = "0x4009CDB")]
		[FieldOffset(Offset = "0x20")]
		public Func<DIYItemViewData, bool> OnButtonInfo;

		// Token: 0x04009CDC RID: 40156
		[Token(Token = "0x4009CDC")]
		[FieldOffset(Offset = "0x28")]
		private DIYRecycleElementView m_prefab;

		// Token: 0x04009CDD RID: 40157
		[Token(Token = "0x4009CDD")]
		[FieldOffset(Offset = "0x30")]
		private DIYRecycleElementView m_emptyPrefab;

		// Token: 0x04009CDE RID: 40158
		[Token(Token = "0x4009CDE")]
		[FieldOffset(Offset = "0x38")]
		private List<DIYItemViewData> m_viewDatas;

		// Token: 0x04009CDF RID: 40159
		[Token(Token = "0x4009CDF")]
		[FieldOffset(Offset = "0x40")]
		private List<DIYItemViewData> m_funcViewDatas;

		// Token: 0x04009CE0 RID: 40160
		[Token(Token = "0x4009CE0")]
		[FieldOffset(Offset = "0x48")]
		private List<UIRecycleLayoutAdapter.IVirtualView> m_views;

		// Token: 0x04009CE1 RID: 40161
		[Token(Token = "0x4009CE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dataSource;

		// Token: 0x04009CE2 RID: 40162
		[Token(Token = "0x4009CE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_dataSource;

		// Token: 0x04009CE3 RID: 40163
		[Token(Token = "0x4009CE3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_funcDataSource;

		// Token: 0x04009CE4 RID: 40164
		[Token(Token = "0x4009CE4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_funcDataSource;

		// Token: 0x04009CE5 RID: 40165
		[Token(Token = "0x4009CE5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04009CE6 RID: 40166
		[Token(Token = "0x4009CE6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Rebuild;

		// Token: 0x04009CE7 RID: 40167
		[Token(Token = "0x4009CE7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TryUpdateItemViews;

		// Token: 0x04009CE8 RID: 40168
		[Token(Token = "0x4009CE8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;
	}
}
