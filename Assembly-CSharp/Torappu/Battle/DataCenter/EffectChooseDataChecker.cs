using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.DataCenter
{
	// Token: 0x020026F6 RID: 9974
	[Token(Token = "0x20026F6")]
	public class EffectChooseDataChecker : IHotfixable
	{
		// Token: 0x06010390 RID: 66448 RVA: 0x00062F10 File Offset: 0x00061110
		[Token(Token = "0x6010390")]
		[Address(RVA = "0x7E6AD0", Offset = "0x7E56D0", VA = "0x1807E6AD0")]
		public bool IsDirty()
		{
			return default(bool);
		}

		// Token: 0x06010391 RID: 66449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010391")]
		[Address(RVA = "0x7E6B50", Offset = "0x7E5750", VA = "0x1807E6B50")]
		public EffectChooseDataChecker()
		{
		}

		// Token: 0x0401225B RID: 74331
		[Token(Token = "0x401225B")]
		[FieldOffset(Offset = "0x10")]
		private AutoChessDataCenter.DataChecker m_dataChecker;

		// Token: 0x0401225C RID: 74332
		[Token(Token = "0x401225C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_IsDirty;

		// Token: 0x0401225D RID: 74333
		[Token(Token = "0x401225D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
