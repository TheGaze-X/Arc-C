using System;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x02003592 RID: 13714
	[Token(Token = "0x2003592")]
	public interface ICharDetailInfo : ICharacterInfo, IHotfixable
	{
		// Token: 0x17003406 RID: 13318
		// (get) Token: 0x06015CFF RID: 89343
		[Token(Token = "0x17003406")]
		string nickName { [Token(Token = "0x6015CFF")] get; }

		// Token: 0x17003407 RID: 13319
		// (get) Token: 0x06015D00 RID: 89344
		[Token(Token = "0x17003407")]
		string subProfessionId { [Token(Token = "0x6015D00")] get; }

		// Token: 0x17003408 RID: 13320
		// (get) Token: 0x06015D01 RID: 89345
		[Token(Token = "0x17003408")]
		int maxLevel { [Token(Token = "0x6015D01")] get; }

		// Token: 0x17003409 RID: 13321
		// (get) Token: 0x06015D02 RID: 89346
		[Token(Token = "0x17003409")]
		float expPercent { [Token(Token = "0x6015D02")] get; }

		// Token: 0x1700340A RID: 13322
		// (get) Token: 0x06015D03 RID: 89347
		[Token(Token = "0x1700340A")]
		string description { [Token(Token = "0x6015D03")] get; }

		// Token: 0x1700340B RID: 13323
		// (get) Token: 0x06015D04 RID: 89348
		[Token(Token = "0x1700340B")]
		string positionStr { [Token(Token = "0x6015D04")] get; }

		// Token: 0x1700340C RID: 13324
		// (get) Token: 0x06015D05 RID: 89349
		[Token(Token = "0x1700340C")]
		DateTime gainTime { [Token(Token = "0x6015D05")] get; }

		// Token: 0x1700340D RID: 13325
		// (get) Token: 0x06015D06 RID: 89350
		[Token(Token = "0x1700340D")]
		CharStarMarkState starMark { [Token(Token = "0x6015D06")] get; }
	}
}
