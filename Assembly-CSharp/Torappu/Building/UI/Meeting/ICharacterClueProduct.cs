using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D0D RID: 7437
	[Token(Token = "0x2001D0D")]
	public interface ICharacterClueProduct
	{
		// Token: 0x1700160D RID: 5645
		// (get) Token: 0x0600B793 RID: 46995
		[Token(Token = "0x1700160D")]
		long startTime { [Token(Token = "0x600B793")] get; }

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x0600B794 RID: 46996
		[Token(Token = "0x1700160E")]
		long endTime { [Token(Token = "0x600B794")] get; }

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x0600B795 RID: 46997
		[Token(Token = "0x1700160F")]
		float basicProgress { [Token(Token = "0x600B795")] get; }

		// Token: 0x17001610 RID: 5648
		// (get) Token: 0x0600B796 RID: 46998
		[Token(Token = "0x17001610")]
		int creditPerClue { [Token(Token = "0x600B796")] get; }

		// Token: 0x17001611 RID: 5649
		// (get) Token: 0x0600B797 RID: 46999
		[Token(Token = "0x17001611")]
		bool running { [Token(Token = "0x600B797")] get; }
	}
}
