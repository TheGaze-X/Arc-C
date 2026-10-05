using System;
using Il2CppDummyDll;

namespace Torappu.UI.Home
{
	// Token: 0x02004B9C RID: 19356
	[Token(Token = "0x2004B9C")]
	public interface ICommonLimitInfoModel : IComparable<ICommonLimitInfoModel>, ITimeValidInfo, IHotfixable
	{
		// Token: 0x17004483 RID: 17539
		// (get) Token: 0x0601D1DB RID: 119259
		// (set) Token: 0x0601D1DC RID: 119260
		[Token(Token = "0x17004483")]
		long startTs { [Token(Token = "0x601D1DB")] get; [Token(Token = "0x601D1DC")] set; }

		// Token: 0x17004484 RID: 17540
		// (get) Token: 0x0601D1DD RID: 119261
		// (set) Token: 0x0601D1DE RID: 119262
		[Token(Token = "0x17004484")]
		long endTs { [Token(Token = "0x601D1DD")] get; [Token(Token = "0x601D1DE")] set; }

		// Token: 0x17004485 RID: 17541
		// (get) Token: 0x0601D1DF RID: 119263
		// (set) Token: 0x0601D1E0 RID: 119264
		[Token(Token = "0x17004485")]
		string canNotGainDesc { [Token(Token = "0x601D1DF")] get; [Token(Token = "0x601D1E0")] set; }
	}
}
