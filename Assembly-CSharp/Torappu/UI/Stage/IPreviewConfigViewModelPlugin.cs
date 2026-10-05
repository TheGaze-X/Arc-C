using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020068B1 RID: 26801
	[Token(Token = "0x20068B1")]
	public interface IPreviewConfigViewModelPlugin
	{
		// Token: 0x06026662 RID: 157282
		[Token(Token = "0x6026662")]
		void SetData(StageViewModel stageModel, IStageSelectHandler selectStageHandler);

		// Token: 0x06026663 RID: 157283
		[Token(Token = "0x6026663")]
		bool CheckCanAutoBattle(bool canAutoBattle);

		// Token: 0x06026664 RID: 157284
		[Token(Token = "0x6026664")]
		bool CheckCanPractice(bool canPractice);

		// Token: 0x06026665 RID: 157285
		[Token(Token = "0x6026665")]
		bool CheckCanMultipleBattle(bool canMultipleBattle);
	}
}
