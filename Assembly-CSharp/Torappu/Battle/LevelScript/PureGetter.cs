using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.LevelScript
{
	// Token: 0x02002843 RID: 10307
	[Token(Token = "0x2002843")]
	public abstract class PureGetter<T> : GetterNodeBase
	{
		// Token: 0x06011294 RID: 70292
		[Token(Token = "0x6011294")]
		public abstract T GetResult();

		// Token: 0x06011295 RID: 70293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011295")]
		protected PureGetter()
		{
		}

		// Token: 0x04013385 RID: 78725
		[Token(Token = "0x4013385")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
