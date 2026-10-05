using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005544 RID: 21828
	[Token(Token = "0x2005544")]
	public interface IRoguelikeStashedTicketItemViewModel : IHotfixable, IComparable
	{
		// Token: 0x17004B3E RID: 19262
		// (get) Token: 0x0602018A RID: 131466
		[Token(Token = "0x17004B3E")]
		string topicId { [Token(Token = "0x602018A")] get; }

		// Token: 0x17004B3F RID: 19263
		// (get) Token: 0x0602018B RID: 131467
		[Token(Token = "0x17004B3F")]
		string itemId { [Token(Token = "0x602018B")] get; }

		// Token: 0x17004B40 RID: 19264
		// (get) Token: 0x0602018C RID: 131468
		[Token(Token = "0x17004B40")]
		int sortId { [Token(Token = "0x602018C")] get; }

		// Token: 0x17004B41 RID: 19265
		// (get) Token: 0x0602018D RID: 131469
		[Token(Token = "0x17004B41")]
		string name { [Token(Token = "0x602018D")] get; }

		// Token: 0x17004B42 RID: 19266
		// (get) Token: 0x0602018E RID: 131470
		[Token(Token = "0x17004B42")]
		string usage { [Token(Token = "0x602018E")] get; }

		// Token: 0x17004B43 RID: 19267
		// (get) Token: 0x0602018F RID: 131471
		[Token(Token = "0x17004B43")]
		int recruitSimilarCnt { [Token(Token = "0x602018F")] get; }
	}
}
