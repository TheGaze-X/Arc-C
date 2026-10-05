using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x02005140 RID: 20800
	[Token(Token = "0x2005140")]
	public class DeepSeaRPStageModel : IHotfixable
	{
		// Token: 0x0601EBB2 RID: 125874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EBB2")]
		[Address(RVA = "0x1873A20", Offset = "0x1872620", VA = "0x181873A20")]
		public DeepSeaRPStageModel()
		{
		}

		// Token: 0x04029388 RID: 168840
		[Token(Token = "0x4029388")]
		[FieldOffset(Offset = "0x10")]
		public StageData stageData;

		// Token: 0x04029389 RID: 168841
		[Token(Token = "0x4029389")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
