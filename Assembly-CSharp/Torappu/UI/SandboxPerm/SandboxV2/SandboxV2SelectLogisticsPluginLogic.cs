using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200403E RID: 16446
	[Token(Token = "0x200403E")]
	public class SandboxV2SelectLogisticsPluginLogic : SandboxV2SelectPluginLogic, IHotfixable
	{
		// Token: 0x0601972B RID: 104235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601972B")]
		[Address(RVA = "0x123FE10", Offset = "0x123EA10", VA = "0x18123FE10", Slot = "10")]
		public void InitShuffleViewModel(SandboxV2ShuffleViewModel shuffleViewModel)
		{
		}

		// Token: 0x0601972C RID: 104236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601972C")]
		[Address(RVA = "0x123FE90", Offset = "0x123EA90", VA = "0x18123FE90", Slot = "4")]
		public void OnEnsure(SandboxV2CharListProperty property, Action onEnsure, Action dismissAction)
		{
		}

		// Token: 0x0601972D RID: 104237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601972D")]
		[Address(RVA = "0x123FA90", Offset = "0x123E690", VA = "0x18123FA90", Slot = "5")]
		public void HandlerClick(int instId, SandboxV2CharListProperty property)
		{
		}

		// Token: 0x0601972E RID: 104238 RVA: 0x0009E190 File Offset: 0x0009C390
		[Token(Token = "0x601972E")]
		[Address(RVA = "0x1240060", Offset = "0x123EC60", VA = "0x181240060", Slot = "6")]
		public bool ShuffleChar(SandboxV2CharViewModel viewModel, SandboxV2ShuffleViewModel shuffleViewModel)
		{
			return default(bool);
		}

		// Token: 0x0601972F RID: 104239 RVA: 0x0009E1A8 File Offset: 0x0009C3A8
		[Token(Token = "0x601972F")]
		[Address(RVA = "0x123FDB0", Offset = "0x123E9B0", VA = "0x18123FDB0", Slot = "7")]
		public bool IfShowIndex()
		{
			return default(bool);
		}

		// Token: 0x06019730 RID: 104240 RVA: 0x0009E1C0 File Offset: 0x0009C3C0
		[Token(Token = "0x6019730")]
		[Address(RVA = "0x1240130", Offset = "0x123ED30", VA = "0x181240130", Slot = "8")]
		public int SortRule(SandboxV2CharViewModel obj1, SandboxV2CharViewModel obj2)
		{
			return 0;
		}

		// Token: 0x06019731 RID: 104241 RVA: 0x0009E1D8 File Offset: 0x0009C3D8
		[Token(Token = "0x6019731")]
		[Address(RVA = "0x123FD50", Offset = "0x123E950", VA = "0x18123FD50", Slot = "9")]
		public bool IfFetchPlayerChar()
		{
			return default(bool);
		}

		// Token: 0x06019732 RID: 104242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019732")]
		[Address(RVA = "0x12404C0", Offset = "0x123F0C0", VA = "0x1812404C0")]
		private void _HandleSetSupplyService(string topicId, List<int> charInstIds, Action onEnsure, Action dismissAction)
		{
		}

		// Token: 0x06019733 RID: 104243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019733")]
		[Address(RVA = "0x1240790", Offset = "0x123F390", VA = "0x181240790")]
		public SandboxV2SelectLogisticsPluginLogic()
		{
		}

		// Token: 0x0401FB2F RID: 129839
		[Token(Token = "0x401FB2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitShuffleViewModel;

		// Token: 0x0401FB30 RID: 129840
		[Token(Token = "0x401FB30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnsure;

		// Token: 0x0401FB31 RID: 129841
		[Token(Token = "0x401FB31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandlerClick;

		// Token: 0x0401FB32 RID: 129842
		[Token(Token = "0x401FB32")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShuffleChar;

		// Token: 0x0401FB33 RID: 129843
		[Token(Token = "0x401FB33")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IfShowIndex;

		// Token: 0x0401FB34 RID: 129844
		[Token(Token = "0x401FB34")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SortRule;

		// Token: 0x0401FB35 RID: 129845
		[Token(Token = "0x401FB35")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IfFetchPlayerChar;

		// Token: 0x0401FB36 RID: 129846
		[Token(Token = "0x401FB36")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__HandleSetSupplyService;

		// Token: 0x0401FB37 RID: 129847
		[Token(Token = "0x401FB37")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
