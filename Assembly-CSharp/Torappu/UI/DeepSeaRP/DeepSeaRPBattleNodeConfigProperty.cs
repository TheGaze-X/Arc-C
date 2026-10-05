using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Stage;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200518B RID: 20875
	[Token(Token = "0x200518B")]
	public class DeepSeaRPBattleNodeConfigProperty : DynamicBindProperty<DeepSeaRPBattleNodeConfigProperty, DeepSeaRPBattleNodeConfigViewModel>
	{
		// Token: 0x0601ED9D RID: 126365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED9D")]
		[Address(RVA = "0x1897160", Offset = "0x1895D60", VA = "0x181897160")]
		public void OnStageSelected(StageViewModel stageModel, StageViewModel hardStageModel)
		{
		}

		// Token: 0x0601ED9E RID: 126366 RVA: 0x000AFF20 File Offset: 0x000AE120
		[Token(Token = "0x601ED9E")]
		[Address(RVA = "0x1897310", Offset = "0x1895F10", VA = "0x181897310")]
		private bool _CheckCanHardBattle(StageViewModel stageModel, StageViewModel hardStageModel)
		{
			return default(bool);
		}

		// Token: 0x0601ED9F RID: 126367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ED9F")]
		[Address(RVA = "0x1897380", Offset = "0x1895F80", VA = "0x181897380")]
		public DeepSeaRPBattleNodeConfigProperty()
		{
		}
	}
}
