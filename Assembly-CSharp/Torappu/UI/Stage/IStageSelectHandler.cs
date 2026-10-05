using System;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x020069FE RID: 27134
	[Token(Token = "0x20069FE")]
	public interface IStageSelectHandler
	{
		// Token: 0x17005B95 RID: 23445
		// (get) Token: 0x06026CC5 RID: 158917
		[Token(Token = "0x17005B95")]
		SpecialStageType stageSelectedType { [Token(Token = "0x6026CC5")] get; }

		// Token: 0x06026CC6 RID: 158918
		[Token(Token = "0x6026CC6")]
		StageViewModel FindNormalStageFromSpecialStage(string notNormalStageId, SpecialStageType sourceStageType);

		// Token: 0x06026CC7 RID: 158919
		[Token(Token = "0x6026CC7")]
		StageViewModel FindSpecialStageFromNormal(string normalStageId, SpecialStageType targetStageType);

		// Token: 0x06026CC8 RID: 158920
		[Token(Token = "0x6026CC8")]
		StageViewModel GetStageByType(SpecialStageType stageType);

		// Token: 0x17005B96 RID: 23446
		// (get) Token: 0x06026CC9 RID: 158921
		[Token(Token = "0x17005B96")]
		StageViewModel selectedStage { [Token(Token = "0x6026CC9")] get; }
	}
}
