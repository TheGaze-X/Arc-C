using System;
using Il2CppDummyDll;

namespace Torappu.AVG
{
	// Token: 0x02001E73 RID: 7795
	[Token(Token = "0x2001E73")]
	public interface IFadeTimeRatio
	{
		// Token: 0x0600C12F RID: 49455
		[Token(Token = "0x600C12F")]
		float CalculateFadetime(float initialFadetime);

		// Token: 0x0600C130 RID: 49456
		[Token(Token = "0x600C130")]
		bool NeedSkipAnimation(float fadetime);
	}
}
