using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x02006830 RID: 26672
	[Token(Token = "0x2006830")]
	public class SixStarStagePreviewConfigPlugin : IPreviewConfigViewModelPlugin, IHotfixable
	{
		// Token: 0x0602632D RID: 156461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602632D")]
		[Address(RVA = "0x214E100", Offset = "0x214CD00", VA = "0x18214E100", Slot = "4")]
		public void SetData(StageViewModel stageModel, IStageSelectHandler selectStageHandler)
		{
		}

		// Token: 0x0602632E RID: 156462 RVA: 0x000CA4E8 File Offset: 0x000C86E8
		[Token(Token = "0x602632E")]
		[Address(RVA = "0x214DE60", Offset = "0x214CA60", VA = "0x18214DE60", Slot = "5")]
		public bool CheckCanAutoBattle(bool canAutoBattle)
		{
			return default(bool);
		}

		// Token: 0x0602632F RID: 156463 RVA: 0x000CA500 File Offset: 0x000C8700
		[Token(Token = "0x602632F")]
		[Address(RVA = "0x214E020", Offset = "0x214CC20", VA = "0x18214E020", Slot = "6")]
		public bool CheckCanPractice(bool canPractice)
		{
			return default(bool);
		}

		// Token: 0x06026330 RID: 156464 RVA: 0x000CA518 File Offset: 0x000C8718
		[Token(Token = "0x6026330")]
		[Address(RVA = "0x214DF40", Offset = "0x214CB40", VA = "0x18214DF40", Slot = "7")]
		public bool CheckCanMultipleBattle(bool canMultipleBattle)
		{
			return default(bool);
		}

		// Token: 0x06026331 RID: 156465 RVA: 0x000CA530 File Offset: 0x000C8730
		[Token(Token = "0x6026331")]
		[Address(RVA = "0x214E210", Offset = "0x214CE10", VA = "0x18214E210")]
		private bool _CheckIfSixStarSelectBaseRune(StageViewModel.StageSixStarInfo stageSixStarInfo)
		{
			return default(bool);
		}

		// Token: 0x06026332 RID: 156466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026332")]
		[Address(RVA = "0x214E290", Offset = "0x214CE90", VA = "0x18214E290")]
		public SixStarStagePreviewConfigPlugin()
		{
		}

		// Token: 0x04035D3E RID: 220478
		[Token(Token = "0x4035D3E")]
		[FieldOffset(Offset = "0x10")]
		private StageViewModel m_stageModel;

		// Token: 0x04035D3F RID: 220479
		[Token(Token = "0x4035D3F")]
		[FieldOffset(Offset = "0x18")]
		private IStageSelectHandler m_selectStageHandler;

		// Token: 0x04035D40 RID: 220480
		[Token(Token = "0x4035D40")]
		[FieldOffset(Offset = "0x20")]
		private StageViewModel.StageSixStarInfo m_stageSixStarInfo;

		// Token: 0x04035D41 RID: 220481
		[Token(Token = "0x4035D41")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04035D42 RID: 220482
		[Token(Token = "0x4035D42")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckCanAutoBattle;

		// Token: 0x04035D43 RID: 220483
		[Token(Token = "0x4035D43")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckCanPractice;

		// Token: 0x04035D44 RID: 220484
		[Token(Token = "0x4035D44")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckCanMultipleBattle;

		// Token: 0x04035D45 RID: 220485
		[Token(Token = "0x4035D45")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfSixStarSelectBaseRune;

		// Token: 0x04035D46 RID: 220486
		[Token(Token = "0x4035D46")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
