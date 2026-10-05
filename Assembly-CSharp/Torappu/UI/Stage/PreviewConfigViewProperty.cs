using System;
using Il2CppDummyDll;
using Torappu.DataBind;

namespace Torappu.UI.Stage
{
	// Token: 0x020068B2 RID: 26802
	[Token(Token = "0x20068B2")]
	[Serializable]
	public class PreviewConfigViewProperty : DynamicBindProperty<PreviewConfigViewProperty, PreviewConfigViewModel>
	{
		// Token: 0x06026666 RID: 157286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026666")]
		[Address(RVA = "0x217AAF0", Offset = "0x21796F0", VA = "0x18217AAF0")]
		public void OnStageSelected(StageViewModel stageModel, IStageSelectHandler selectStageHandler, PreviewConfigViewModel.Config config)
		{
		}

		// Token: 0x06026667 RID: 157287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026667")]
		[Address(RVA = "0x217B090", Offset = "0x2179C90", VA = "0x18217B090")]
		public void RefreshPluginRelatedData(StageViewModel stageModel, IStageSelectHandler selectStageHandler)
		{
		}

		// Token: 0x06026668 RID: 157288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026668")]
		[Address(RVA = "0x217B310", Offset = "0x2179F10", VA = "0x18217B310")]
		private void _SetDataPluginRelated(StageViewModel stageModel, IPreviewConfigViewModelPlugin plugin, ref PreviewConfigViewModel viewModel)
		{
		}

		// Token: 0x06026669 RID: 157289 RVA: 0x000CADD0 File Offset: 0x000C8FD0
		[Token(Token = "0x6026669")]
		[Address(RVA = "0x217B150", Offset = "0x2179D50", VA = "0x18217B150")]
		private bool _CheckCanHardBattle(StageViewModel stageModel, IStageSelectHandler stageHandler)
		{
			return default(bool);
		}

		// Token: 0x0602666A RID: 157290 RVA: 0x000CADE8 File Offset: 0x000C8FE8
		[Token(Token = "0x602666A")]
		[Address(RVA = "0x217B260", Offset = "0x2179E60", VA = "0x18217B260")]
		private bool _CheckCanSixStarBattle(StageViewModel normalStageModel, IStageSelectHandler stageHandler)
		{
			return default(bool);
		}

		// Token: 0x0602666B RID: 157291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602666B")]
		[Address(RVA = "0x217B630", Offset = "0x217A230", VA = "0x18217B630")]
		public PreviewConfigViewProperty()
		{
		}
	}
}
