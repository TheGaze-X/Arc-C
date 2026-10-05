using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003847 RID: 14407
	[Token(Token = "0x2003847")]
	public interface ITrackPointModel : IHotfixable
	{
		// Token: 0x06016D41 RID: 93505
		[Token(Token = "0x6016D41")]
		void UpdateState(object param);

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x06016D42 RID: 93506
		[Token(Token = "0x17003695")]
		bool isShow { [Token(Token = "0x6016D42")] get; }
	}
}
