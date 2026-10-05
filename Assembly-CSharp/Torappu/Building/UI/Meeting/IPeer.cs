using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Building.UI.Meeting
{
	// Token: 0x02001D0C RID: 7436
	[Token(Token = "0x2001D0C")]
	public interface IPeer : IHotfixable
	{
		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x0600B784 RID: 46980
		[Token(Token = "0x17001600")]
		Sprite icon { [Token(Token = "0x600B784")] get; }

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x0600B785 RID: 46981
		[Token(Token = "0x17001601")]
		string userId { [Token(Token = "0x600B785")] get; }

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x0600B786 RID: 46982
		[Token(Token = "0x17001602")]
		string nickName { [Token(Token = "0x600B786")] get; }

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x0600B787 RID: 46983
		[Token(Token = "0x17001603")]
		string nickNumber { [Token(Token = "0x600B787")] get; }

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x0600B788 RID: 46984
		[Token(Token = "0x17001604")]
		string comment { [Token(Token = "0x600B788")] get; }

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x0600B789 RID: 46985
		[Token(Token = "0x17001605")]
		int level { [Token(Token = "0x600B789")] get; }

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x0600B78A RID: 46986
		[Token(Token = "0x17001606")]
		bool online { [Token(Token = "0x600B78A")] get; }

		// Token: 0x17001607 RID: 5639
		// (get) Token: 0x0600B78B RID: 46987
		[Token(Token = "0x17001607")]
		DateTime lastLoginTime { [Token(Token = "0x600B78B")] get; }

		// Token: 0x0600B78C RID: 46988
		[Token(Token = "0x600B78C")]
		bool HasCard(int category);

		// Token: 0x0600B78D RID: 46989
		[Token(Token = "0x600B78D")]
		bool HasAllTypesOfClue();

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x0600B78E RID: 46990
		[Token(Token = "0x17001608")]
		int creditReward { [Token(Token = "0x600B78E")] get; }

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x0600B78F RID: 46991
		[Token(Token = "0x17001609")]
		PlayerAvatarQuery avatarQuery { [Token(Token = "0x600B78F")] get; }

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x0600B790 RID: 46992
		[Token(Token = "0x1700160A")]
		PlayerNameCardSkin nameCardSkin { [Token(Token = "0x600B790")] get; }

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x0600B791 RID: 46993
		[Token(Token = "0x1700160B")]
		List<int> hasCluesFromMe { [Token(Token = "0x600B791")] get; }

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x0600B792 RID: 46994
		[Token(Token = "0x1700160C")]
		int numCluesSentToMe { [Token(Token = "0x600B792")] get; }
	}
}
