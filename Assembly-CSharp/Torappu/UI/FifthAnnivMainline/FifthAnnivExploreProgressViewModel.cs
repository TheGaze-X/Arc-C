using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F25 RID: 20261
	[Token(Token = "0x2004F25")]
	public class FifthAnnivExploreProgressViewModel : IHotfixable
	{
		// Token: 0x0601E301 RID: 123649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E301")]
		[Address(RVA = "0x17F1480", Offset = "0x17F0080", VA = "0x1817F1480")]
		public void LoadData(bool isInit)
		{
		}

		// Token: 0x0601E302 RID: 123650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E302")]
		[Address(RVA = "0x17F1790", Offset = "0x17F0390", VA = "0x1817F1790")]
		public FifthAnnivExploreProgressViewModel()
		{
		}

		// Token: 0x04028361 RID: 164705
		[Token(Token = "0x4028361")]
		[FieldOffset(Offset = "0x10")]
		public int totalStageCount;

		// Token: 0x04028362 RID: 164706
		[Token(Token = "0x4028362")]
		[FieldOffset(Offset = "0x14")]
		public int currStageIndex;

		// Token: 0x04028363 RID: 164707
		[Token(Token = "0x4028363")]
		[FieldOffset(Offset = "0x18")]
		public int totalNodeCount;

		// Token: 0x04028364 RID: 164708
		[Token(Token = "0x4028364")]
		[FieldOffset(Offset = "0x1C")]
		public int currNodeIndex;

		// Token: 0x04028365 RID: 164709
		[Token(Token = "0x4028365")]
		[FieldOffset(Offset = "0x20")]
		public int initSeq;

		// Token: 0x04028366 RID: 164710
		[Token(Token = "0x4028366")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04028367 RID: 164711
		[Token(Token = "0x4028367")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
