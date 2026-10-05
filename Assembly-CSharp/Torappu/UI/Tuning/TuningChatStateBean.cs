using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C82 RID: 15490
	[Token(Token = "0x2003C82")]
	public class TuningChatStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601831B RID: 99099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601831B")]
		[Address(RVA = "0x10ABC60", Offset = "0x10AA860", VA = "0x1810ABC60")]
		public TuningChatStateBean()
		{
		}

		// Token: 0x0401D743 RID: 120643
		[Token(Token = "0x401D743")]
		[FieldOffset(Offset = "0x10")]
		public string investId;

		// Token: 0x0401D744 RID: 120644
		[Token(Token = "0x401D744")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
