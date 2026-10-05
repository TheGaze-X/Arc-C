using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x0200776C RID: 30572
	[Token(Token = "0x200776C")]
	public class Act1VHalfidlePlotSelectViewModel : IHotfixable
	{
		// Token: 0x170064AB RID: 25771
		// (get) Token: 0x0602AEFC RID: 175868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170064AB")]
		public string stageId
		{
			[Token(Token = "0x602AEFC")]
			[Address(RVA = "0x26BE340", Offset = "0x26BCF40", VA = "0x1826BE340")]
			get
			{
				return null;
			}
		}

		// Token: 0x170064AC RID: 25772
		// (get) Token: 0x0602AEFD RID: 175869 RVA: 0x000DA730 File Offset: 0x000D8930
		[Token(Token = "0x170064AC")]
		public Act1VHalfIdlePlotStageLimit plotSquadLimit
		{
			[Token(Token = "0x602AEFD")]
			[Address(RVA = "0x26BE1D0", Offset = "0x26BCDD0", VA = "0x1826BE1D0")]
			get
			{
				return default(Act1VHalfIdlePlotStageLimit);
			}
		}

		// Token: 0x170064AD RID: 25773
		// (get) Token: 0x0602AEFE RID: 175870 RVA: 0x000DA748 File Offset: 0x000D8948
		[Token(Token = "0x170064AD")]
		public Act1VHalfIdlePlotType squadPlotType
		{
			[Token(Token = "0x602AEFE")]
			[Address(RVA = "0x26BE2E0", Offset = "0x26BCEE0", VA = "0x1826BE2E0")]
			get
			{
				return Act1VHalfIdlePlotType.NONE;
			}
		}

		// Token: 0x0602AEFF RID: 175871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AEFF")]
		[Address(RVA = "0x26BD890", Offset = "0x26BC490", VA = "0x1826BD890")]
		public void UpdatePlotStatus(Act1VHalfidlePlotSelectStateBean.SelectInput input)
		{
		}

		// Token: 0x0602AF00 RID: 175872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF00")]
		[Address(RVA = "0x26BD540", Offset = "0x26BC140", VA = "0x1826BD540")]
		public void RestorePlotStatus()
		{
		}

		// Token: 0x0602AF01 RID: 175873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF01")]
		[Address(RVA = "0x26BD240", Offset = "0x26BBE40", VA = "0x1826BD240")]
		public List<Act1VHalfidlePlotViewModel> GetSelectedPlotList()
		{
			return null;
		}

		// Token: 0x170064AE RID: 25774
		// (get) Token: 0x0602AF02 RID: 175874 RVA: 0x000DA760 File Offset: 0x000D8960
		[Token(Token = "0x170064AE")]
		public bool selectedValid
		{
			[Token(Token = "0x602AF02")]
			[Address(RVA = "0x26BE250", Offset = "0x26BCE50", VA = "0x1826BE250")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602AF03 RID: 175875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF03")]
		[Address(RVA = "0x26BD440", Offset = "0x26BC040", VA = "0x1826BD440")]
		public void LoadData(string inputActId, string inputStageId, Act1VHalfIdlePlotType type)
		{
		}

		// Token: 0x0602AF04 RID: 175876 RVA: 0x000DA778 File Offset: 0x000D8978
		[Token(Token = "0x602AF04")]
		[Address(RVA = "0x26BD5B0", Offset = "0x26BC1B0", VA = "0x1826BD5B0")]
		public bool SelectPlot(string plotId)
		{
			return default(bool);
		}

		// Token: 0x0602AF05 RID: 175877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF05")]
		[Address(RVA = "0x26BDF20", Offset = "0x26BCB20", VA = "0x1826BDF20")]
		private void _RefreshSelectStatus()
		{
		}

		// Token: 0x0602AF06 RID: 175878 RVA: 0x000DA790 File Offset: 0x000D8990
		[Token(Token = "0x602AF06")]
		[Address(RVA = "0x26BD9B0", Offset = "0x26BC5B0", VA = "0x1826BD9B0")]
		private bool _HandleMultiSelect(string plotId, bool alreadySelected)
		{
			return default(bool);
		}

		// Token: 0x0602AF07 RID: 175879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF07")]
		[Address(RVA = "0x26BD7D0", Offset = "0x26BC3D0", VA = "0x1826BD7D0")]
		public void UnselectAllPlots()
		{
		}

		// Token: 0x0602AF08 RID: 175880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602AF08")]
		[Address(RVA = "0x26BD190", Offset = "0x26BBD90", VA = "0x1826BD190")]
		public Act1VHalfidlePlotViewModel GetPlotViewModel(string plotId)
		{
			return null;
		}

		// Token: 0x0602AF09 RID: 175881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF09")]
		[Address(RVA = "0x26BDB30", Offset = "0x26BC730", VA = "0x1826BDB30")]
		private void _LoadPlotList(string actId, Act1VHalfIdlePlotType type)
		{
		}

		// Token: 0x0602AF0A RID: 175882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AF0A")]
		[Address(RVA = "0x26BE040", Offset = "0x26BCC40", VA = "0x1826BE040")]
		public Act1VHalfidlePlotSelectViewModel()
		{
		}

		// Token: 0x0403DF27 RID: 253735
		[Token(Token = "0x403DF27")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403DF28 RID: 253736
		[Token(Token = "0x403DF28")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, Act1VHalfidlePlotViewModel> m_allTypePlotList;

		// Token: 0x0403DF29 RID: 253737
		[Token(Token = "0x403DF29")]
		[FieldOffset(Offset = "0x20")]
		private Act1VHalfIdlePlotType m_cachedType;

		// Token: 0x0403DF2A RID: 253738
		[Token(Token = "0x403DF2A")]
		[FieldOffset(Offset = "0x24")]
		private Act1VHalfIdlePlotStageLimit m_plotLimit;

		// Token: 0x0403DF2B RID: 253739
		[Token(Token = "0x403DF2B")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedStageId;

		// Token: 0x0403DF2C RID: 253740
		[Token(Token = "0x403DF2C")]
		[FieldOffset(Offset = "0x38")]
		public List<Act1VHalfidlePlotViewModel> selectedPlotList;

		// Token: 0x0403DF2D RID: 253741
		[Token(Token = "0x403DF2D")]
		[FieldOffset(Offset = "0x40")]
		public List<Act1VHalfidlePlotViewModel> selectablePlotList;

		// Token: 0x0403DF2E RID: 253742
		[Token(Token = "0x403DF2E")]
		[FieldOffset(Offset = "0x48")]
		public List<string> selectedPlotIdList;

		// Token: 0x0403DF2F RID: 253743
		[Token(Token = "0x403DF2F")]
		[FieldOffset(Offset = "0x50")]
		public List<string> originSelectedIdList;

		// Token: 0x0403DF30 RID: 253744
		[Token(Token = "0x403DF30")]
		[FieldOffset(Offset = "0x58")]
		public string lastSelectPlotId;

		// Token: 0x0403DF31 RID: 253745
		[Token(Token = "0x403DF31")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_stageId;

		// Token: 0x0403DF32 RID: 253746
		[Token(Token = "0x403DF32")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_plotSquadLimit;

		// Token: 0x0403DF33 RID: 253747
		[Token(Token = "0x403DF33")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_squadPlotType;

		// Token: 0x0403DF34 RID: 253748
		[Token(Token = "0x403DF34")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdatePlotStatus;

		// Token: 0x0403DF35 RID: 253749
		[Token(Token = "0x403DF35")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RestorePlotStatus;

		// Token: 0x0403DF36 RID: 253750
		[Token(Token = "0x403DF36")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetSelectedPlotList;

		// Token: 0x0403DF37 RID: 253751
		[Token(Token = "0x403DF37")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectedValid;

		// Token: 0x0403DF38 RID: 253752
		[Token(Token = "0x403DF38")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403DF39 RID: 253753
		[Token(Token = "0x403DF39")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SelectPlot;

		// Token: 0x0403DF3A RID: 253754
		[Token(Token = "0x403DF3A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__RefreshSelectStatus;

		// Token: 0x0403DF3B RID: 253755
		[Token(Token = "0x403DF3B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__HandleMultiSelect;

		// Token: 0x0403DF3C RID: 253756
		[Token(Token = "0x403DF3C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_UnselectAllPlots;

		// Token: 0x0403DF3D RID: 253757
		[Token(Token = "0x403DF3D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetPlotViewModel;

		// Token: 0x0403DF3E RID: 253758
		[Token(Token = "0x403DF3E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__LoadPlotList;

		// Token: 0x0403DF3F RID: 253759
		[Token(Token = "0x403DF3F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
