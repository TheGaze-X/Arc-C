using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act12D6
{
	// Token: 0x02007AD3 RID: 31443
	[Token(Token = "0x2007AD3")]
	public class Act12D6StageFloat : ActivityStageStateEngine, IHotfixable
	{
		// Token: 0x0602C092 RID: 180370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C092")]
		[Address(RVA = "0x27FD550", Offset = "0x27FC150", VA = "0x1827FD550")]
		public IEnumerator OpenGameEndCoroutine()
		{
			return null;
		}

		// Token: 0x0602C093 RID: 180371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C093")]
		[Address(RVA = "0x27FD600", Offset = "0x27FC200", VA = "0x1827FD600")]
		public Act12D6StageFloat()
		{
		}

		// Token: 0x0403FCCD RID: 261325
		[Token(Token = "0x403FCCD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OpenGameEndCoroutine;

		// Token: 0x0403FCCE RID: 261326
		[Token(Token = "0x403FCCE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
