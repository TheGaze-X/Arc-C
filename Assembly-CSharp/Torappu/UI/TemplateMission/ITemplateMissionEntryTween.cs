using System;
using DG.Tweening;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003DA2 RID: 15778
	[Token(Token = "0x2003DA2")]
	public interface ITemplateMissionEntryTween : IHotfixable
	{
		// Token: 0x17003A83 RID: 14979
		// (get) Token: 0x06018890 RID: 100496
		[Token(Token = "0x17003A83")]
		float entryDelay { [Token(Token = "0x6018890")] get; }

		// Token: 0x17003A84 RID: 14980
		// (get) Token: 0x06018891 RID: 100497
		[Token(Token = "0x17003A84")]
		Tween entryTween { [Token(Token = "0x6018891")] get; }

		// Token: 0x06018892 RID: 100498
		[Token(Token = "0x6018892")]
		void ResetTween();
	}
}
