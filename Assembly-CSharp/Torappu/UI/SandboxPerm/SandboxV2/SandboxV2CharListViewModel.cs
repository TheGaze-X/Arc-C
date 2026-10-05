using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200404C RID: 16460
	[Token(Token = "0x200404C")]
	public class SandboxV2CharListViewModel : IHotfixable
	{
		// Token: 0x17003C98 RID: 15512
		// (get) Token: 0x0601976C RID: 104300 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601976D RID: 104301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C98")]
		public SandboxV2CharViewModel lastSelectViewModel
		{
			[Token(Token = "0x601976C")]
			[Address(RVA = "0x1235610", Offset = "0x1234210", VA = "0x181235610")]
			get
			{
				return null;
			}
			[Token(Token = "0x601976D")]
			[Address(RVA = "0x1235670", Offset = "0x1234270", VA = "0x181235670")]
			set
			{
			}
		}

		// Token: 0x0601976E RID: 104302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601976E")]
		[Address(RVA = "0x1234040", Offset = "0x1232C40", VA = "0x181234040")]
		public List<SandboxV2CharViewModel> GetCharViewModelShuffledList()
		{
			return null;
		}

		// Token: 0x0601976F RID: 104303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601976F")]
		[Address(RVA = "0x1233F40", Offset = "0x1232B40", VA = "0x181233F40")]
		public SandboxV2CharViewModel GetCharViewModelByInstId(int instId)
		{
			return null;
		}

		// Token: 0x06019770 RID: 104304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019770")]
		[Address(RVA = "0x12342D0", Offset = "0x1232ED0", VA = "0x1812342D0")]
		public void InitViewModel(SandboxV2AdminCharSelectStateBean.OpenOption option)
		{
		}

		// Token: 0x06019771 RID: 104305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019771")]
		[Address(RVA = "0x1235060", Offset = "0x1233C60", VA = "0x181235060")]
		public void OnCharClear()
		{
		}

		// Token: 0x06019772 RID: 104306 RVA: 0x0009E250 File Offset: 0x0009C450
		[Token(Token = "0x6019772")]
		[Address(RVA = "0x1235260", Offset = "0x1233E60", VA = "0x181235260")]
		private bool _IsCharFiltered(SandboxV2AdminCharSelectStateBean.OpenOption options, SandboxV2CharViewModel charViewModel)
		{
			return default(bool);
		}

		// Token: 0x06019773 RID: 104307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019773")]
		[Address(RVA = "0x1235130", Offset = "0x1233D30", VA = "0x181235130")]
		public void SortViewModel()
		{
		}

		// Token: 0x06019774 RID: 104308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019774")]
		[Address(RVA = "0x12354E0", Offset = "0x12340E0", VA = "0x1812354E0")]
		public SandboxV2CharListViewModel()
		{
		}

		// Token: 0x0401FB86 RID: 129926
		[Token(Token = "0x401FB86")]
		[FieldOffset(Offset = "0x10")]
		private SandboxV2CharViewModel m_lastSelectViewModel;

		// Token: 0x0401FB87 RID: 129927
		[Token(Token = "0x401FB87")]
		[FieldOffset(Offset = "0x18")]
		public string topicId;

		// Token: 0x0401FB88 RID: 129928
		[Token(Token = "0x401FB88")]
		[FieldOffset(Offset = "0x20")]
		public SandboxV2SelectPluginLogic logic;

		// Token: 0x0401FB89 RID: 129929
		[Token(Token = "0x401FB89")]
		[FieldOffset(Offset = "0x28")]
		public SandboxV2CharSelectTabEnum attryTabType;

		// Token: 0x0401FB8A RID: 129930
		[Token(Token = "0x401FB8A")]
		[FieldOffset(Offset = "0x30")]
		public List<SandboxV2CharViewModel> charViewModels;

		// Token: 0x0401FB8B RID: 129931
		[Token(Token = "0x401FB8B")]
		[FieldOffset(Offset = "0x38")]
		public List<SandboxV2CharViewModel> selectedViewModels;

		// Token: 0x0401FB8C RID: 129932
		[Token(Token = "0x401FB8C")]
		[FieldOffset(Offset = "0x40")]
		public List<SandboxV2CharViewModel> resultList;

		// Token: 0x0401FB8D RID: 129933
		[Token(Token = "0x401FB8D")]
		[FieldOffset(Offset = "0x48")]
		public bool needShuffle;

		// Token: 0x0401FB8E RID: 129934
		[Token(Token = "0x401FB8E")]
		[FieldOffset(Offset = "0x4C")]
		public SandboxV2AdminCharSelectStateMode mode;

		// Token: 0x0401FB8F RID: 129935
		[Token(Token = "0x401FB8F")]
		[FieldOffset(Offset = "0x50")]
		public SandboxV2ShuffleViewModel shuffleViewModel;

		// Token: 0x0401FB90 RID: 129936
		[Token(Token = "0x401FB90")]
		[FieldOffset(Offset = "0x58")]
		public SandboxV2ExpeditionCharSelectViewModel expeditionViewModel;

		// Token: 0x0401FB91 RID: 129937
		[Token(Token = "0x401FB91")]
		[FieldOffset(Offset = "0x60")]
		public SandboxV2LogisticsCharSelectViewModel logisticsViewModel;

		// Token: 0x0401FB92 RID: 129938
		[Token(Token = "0x401FB92")]
		[FieldOffset(Offset = "0x68")]
		public bool showPopView;

		// Token: 0x0401FB93 RID: 129939
		[Token(Token = "0x401FB93")]
		[FieldOffset(Offset = "0x6C")]
		public int focusIndex;

		// Token: 0x0401FB94 RID: 129940
		[Token(Token = "0x401FB94")]
		[FieldOffset(Offset = "0x70")]
		public int focusSeqNun;

		// Token: 0x0401FB95 RID: 129941
		[Token(Token = "0x401FB95")]
		[FieldOffset(Offset = "0x74")]
		public int selectMaxCount;

		// Token: 0x0401FB96 RID: 129942
		[Token(Token = "0x401FB96")]
		[FieldOffset(Offset = "0x78")]
		public int selectCount;

		// Token: 0x0401FB97 RID: 129943
		[Token(Token = "0x401FB97")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_lastSelectViewModel;

		// Token: 0x0401FB98 RID: 129944
		[Token(Token = "0x401FB98")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_lastSelectViewModel;

		// Token: 0x0401FB99 RID: 129945
		[Token(Token = "0x401FB99")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCharViewModelShuffledList;

		// Token: 0x0401FB9A RID: 129946
		[Token(Token = "0x401FB9A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCharViewModelByInstId;

		// Token: 0x0401FB9B RID: 129947
		[Token(Token = "0x401FB9B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitViewModel;

		// Token: 0x0401FB9C RID: 129948
		[Token(Token = "0x401FB9C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnCharClear;

		// Token: 0x0401FB9D RID: 129949
		[Token(Token = "0x401FB9D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsCharFiltered;

		// Token: 0x0401FB9E RID: 129950
		[Token(Token = "0x401FB9E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SortViewModel;

		// Token: 0x0401FB9F RID: 129951
		[Token(Token = "0x401FB9F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
