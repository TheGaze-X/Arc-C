using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200776A RID: 30570
	[Token(Token = "0x200776A")]
	public class Act1VHalfidlePlotSelectStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170064AA RID: 25770
		// (get) Token: 0x0602AEF4 RID: 175860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170064AA")]
		public Act1VHalfidlePlotSelectProperty property
		{
			[Token(Token = "0x602AEF4")]
			[Address(RVA = "0x26BB490", Offset = "0x26BA090", VA = "0x1826BB490")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602AEF5 RID: 175861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEF5")]
		[Address(RVA = "0x26BACF0", Offset = "0x26B98F0", VA = "0x1826BACF0")]
		public void LoadData(string actId, string stageId, Act1VHalfIdlePlotType type)
		{
		}

		// Token: 0x0602AEF6 RID: 175862 RVA: 0x000DA718 File Offset: 0x000D8918
		[Token(Token = "0x602AEF6")]
		[Address(RVA = "0x26BAF60", Offset = "0x26B9B60", VA = "0x1826BAF60")]
		public bool SelectPlotById(string plotId)
		{
			return default(bool);
		}

		// Token: 0x0602AEF7 RID: 175863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEF7")]
		[Address(RVA = "0x26BB040", Offset = "0x26B9C40", VA = "0x1826BB040")]
		public void SetSelecetedParam(Act1VHalfidlePlotSelectStateBean.SelectInput inputParam)
		{
		}

		// Token: 0x0602AEF8 RID: 175864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEF8")]
		[Address(RVA = "0x26BB200", Offset = "0x26B9E00", VA = "0x1826BB200")]
		public void UnselectAllPlots()
		{
		}

		// Token: 0x0602AEF9 RID: 175865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEF9")]
		[Address(RVA = "0x26BAEA0", Offset = "0x26B9AA0", VA = "0x1826BAEA0")]
		public void RestorePlots()
		{
		}

		// Token: 0x0602AEFA RID: 175866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEFA")]
		[Address(RVA = "0x26BB3A0", Offset = "0x26B9FA0", VA = "0x1826BB3A0")]
		public Act1VHalfidlePlotSelectStateBean()
		{
		}

		// Token: 0x0403DF1C RID: 253724
		[Token(Token = "0x403DF1C")]
		[FieldOffset(Offset = "0x10")]
		private Act1VHalfidlePlotSelectProperty m_property;

		// Token: 0x0403DF1D RID: 253725
		[Token(Token = "0x403DF1D")]
		[FieldOffset(Offset = "0x18")]
		public string activityId;

		// Token: 0x0403DF1E RID: 253726
		[Token(Token = "0x403DF1E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x0403DF1F RID: 253727
		[Token(Token = "0x403DF1F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403DF20 RID: 253728
		[Token(Token = "0x403DF20")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectPlotById;

		// Token: 0x0403DF21 RID: 253729
		[Token(Token = "0x403DF21")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetSelecetedParam;

		// Token: 0x0403DF22 RID: 253730
		[Token(Token = "0x403DF22")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UnselectAllPlots;

		// Token: 0x0403DF23 RID: 253731
		[Token(Token = "0x403DF23")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RestorePlots;

		// Token: 0x0403DF24 RID: 253732
		[Token(Token = "0x403DF24")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200776B RID: 30571
		[Token(Token = "0x200776B")]
		public class SelectInput
		{
			// Token: 0x0602AEFB RID: 175867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602AEFB")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SelectInput()
			{
			}

			// Token: 0x0403DF25 RID: 253733
			[Token(Token = "0x403DF25")]
			[FieldOffset(Offset = "0x10")]
			public string selectedPlotId;

			// Token: 0x0403DF26 RID: 253734
			[Token(Token = "0x403DF26")]
			[FieldOffset(Offset = "0x18")]
			public List<string> selectedIds;
		}
	}
}
