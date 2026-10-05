using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052BE RID: 21182
	[Token(Token = "0x20052BE")]
	public class RoguelikeClassicEndingStatsRelicGroupViewModel : RoguelikeClassicEndingStatsViewComponentModel
	{
		// Token: 0x0601F3D4 RID: 127956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3D4")]
		[Address(RVA = "0x18F6030", Offset = "0x18F4C30", VA = "0x1818F6030", Slot = "4")]
		public override void LoadData(string topicId, PlayerRoguelikePendingEvent.EndingResult result)
		{
		}

		// Token: 0x0601F3D5 RID: 127957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3D5")]
		[Address(RVA = "0x18F6420", Offset = "0x18F5020", VA = "0x1818F6420")]
		private void _LoadRelics(string topicId, PlayerRoguelikePendingEvent.EndingRecord endingRecord)
		{
		}

		// Token: 0x0601F3D6 RID: 127958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F3D6")]
		[Address(RVA = "0x18F6180", Offset = "0x18F4D80", VA = "0x1818F6180")]
		public List<IRoguelikeRelicViewModel> LoadWholeRelicViewModelList(RoguelikeClassicEndingStatsRelicGroupViewModel.CombineParam combineParam)
		{
			return null;
		}

		// Token: 0x0601F3D7 RID: 127959 RVA: 0x000B14B0 File Offset: 0x000AF6B0
		[Token(Token = "0x601F3D7")]
		[Address(RVA = "0x18F5F50", Offset = "0x18F4B50", VA = "0x1818F5F50")]
		public int GetWholeRelicViewModelsCount(RoguelikeClassicEndingStatsRelicGroupViewModel.CombineParam combineParam)
		{
			return 0;
		}

		// Token: 0x0601F3D8 RID: 127960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F3D8")]
		[Address(RVA = "0x18F67B0", Offset = "0x18F53B0", VA = "0x1818F67B0")]
		public RoguelikeClassicEndingStatsRelicGroupViewModel()
		{
		}

		// Token: 0x04029F55 RID: 171861
		[Token(Token = "0x4029F55")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeRelicViewModel> relicViewModels;

		// Token: 0x04029F56 RID: 171862
		[Token(Token = "0x4029F56")]
		[FieldOffset(Offset = "0x18")]
		public List<RoguelikeTrapViewModel> trapViewModels;

		// Token: 0x04029F57 RID: 171863
		[Token(Token = "0x4029F57")]
		[FieldOffset(Offset = "0x20")]
		public List<RoguelikeExploreToolViewModel> exploreToolViewModels;

		// Token: 0x04029F58 RID: 171864
		[Token(Token = "0x4029F58")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029F59 RID: 171865
		[Token(Token = "0x4029F59")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__LoadRelics;

		// Token: 0x04029F5A RID: 171866
		[Token(Token = "0x4029F5A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadWholeRelicViewModelList;

		// Token: 0x04029F5B RID: 171867
		[Token(Token = "0x4029F5B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetWholeRelicViewModelsCount;

		// Token: 0x04029F5C RID: 171868
		[Token(Token = "0x4029F5C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052BF RID: 21183
		[Token(Token = "0x20052BF")]
		public struct CombineParam
		{
			// Token: 0x04029F5D RID: 171869
			[Token(Token = "0x4029F5D")]
			[FieldOffset(Offset = "0x0")]
			public bool ignoreExploreTool;

			// Token: 0x04029F5E RID: 171870
			[Token(Token = "0x4029F5E")]
			[FieldOffset(Offset = "0x1")]
			public bool ignoreTrap;
		}
	}
}
