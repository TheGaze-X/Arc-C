using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D0B RID: 7435
	[Token(Token = "0x2001D0B")]
	public interface IMeetingClue : IHotfixable
	{
		// Token: 0x170015F4 RID: 5620
		// (get) Token: 0x0600B778 RID: 46968
		[Token(Token = "0x170015F4")]
		bool isInSlot { [Token(Token = "0x600B778")] get; }

		// Token: 0x170015F5 RID: 5621
		// (get) Token: 0x0600B779 RID: 46969
		[Token(Token = "0x170015F5")]
		int category { [Token(Token = "0x600B779")] get; }

		// Token: 0x170015F6 RID: 5622
		// (get) Token: 0x0600B77A RID: 46970
		[Token(Token = "0x170015F6")]
		int number { [Token(Token = "0x600B77A")] get; }

		// Token: 0x170015F7 RID: 5623
		// (get) Token: 0x0600B77B RID: 46971
		[Token(Token = "0x170015F7")]
		string name { [Token(Token = "0x600B77B")] get; }

		// Token: 0x170015F8 RID: 5624
		// (get) Token: 0x0600B77C RID: 46972
		[Token(Token = "0x170015F8")]
		string description { [Token(Token = "0x600B77C")] get; }

		// Token: 0x170015F9 RID: 5625
		// (get) Token: 0x0600B77D RID: 46973
		[Token(Token = "0x170015F9")]
		Sprite image { [Token(Token = "0x600B77D")] get; }

		// Token: 0x170015FA RID: 5626
		// (get) Token: 0x0600B77E RID: 46974
		[Token(Token = "0x170015FA")]
		bool external { [Token(Token = "0x600B77E")] get; }

		// Token: 0x170015FB RID: 5627
		// (get) Token: 0x0600B77F RID: 46975
		[Token(Token = "0x170015FB")]
		long expireTime { [Token(Token = "0x600B77F")] get; }

		// Token: 0x170015FC RID: 5628
		// (get) Token: 0x0600B780 RID: 46976
		[Token(Token = "0x170015FC")]
		int collectBonus { [Token(Token = "0x600B780")] get; }

		// Token: 0x170015FD RID: 5629
		// (get) Token: 0x0600B781 RID: 46977
		[Token(Token = "0x170015FD")]
		int removeBonus { [Token(Token = "0x600B781")] get; }

		// Token: 0x170015FE RID: 5630
		// (get) Token: 0x0600B782 RID: 46978
		[Token(Token = "0x170015FE")]
		IEnumerable<ClueProducerInfo> producers { [Token(Token = "0x600B782")] get; }

		// Token: 0x170015FF RID: 5631
		// (get) Token: 0x0600B783 RID: 46979
		[Token(Token = "0x170015FF")]
		string fromString { [Token(Token = "0x600B783")] get; }
	}
}
