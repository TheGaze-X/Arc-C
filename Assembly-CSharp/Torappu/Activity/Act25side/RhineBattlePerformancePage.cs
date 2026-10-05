using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074F3 RID: 29939
	[Token(Token = "0x20074F3")]
	public class RhineBattlePerformancePage : StateEnginePage
	{
		// Token: 0x0602A313 RID: 172819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A313")]
		[Address(RVA = "0x25D8DD0", Offset = "0x25D79D0", VA = "0x1825D8DD0")]
		public RhineBattlePerformancePage()
		{
		}

		// Token: 0x0403CA1D RID: 248349
		[Token(Token = "0x403CA1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020074F4 RID: 29940
		[Token(Token = "0x20074F4")]
		public class Params
		{
			// Token: 0x0602A314 RID: 172820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A314")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Params()
			{
			}

			// Token: 0x0403CA1E RID: 248350
			[Token(Token = "0x403CA1E")]
			[FieldOffset(Offset = "0x10")]
			public bool isRetro;

			// Token: 0x0403CA1F RID: 248351
			[Token(Token = "0x403CA1F")]
			[FieldOffset(Offset = "0x18")]
			public string groupId;
		}
	}
}
