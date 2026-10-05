using System;
using Il2CppDummyDll;

namespace Torappu.Audio
{
	// Token: 0x02001FAB RID: 8107
	[Token(Token = "0x2001FAB")]
	public interface IAudioTweenValueBlender
	{
		// Token: 0x0600C95B RID: 51547
		[Token(Token = "0x600C95B")]
		float GetValue();

		// Token: 0x0600C95C RID: 51548
		[Token(Token = "0x600C95C")]
		void AddBlenderItem(string channelName, AudioChannelEffect channelEffect);

		// Token: 0x0600C95D RID: 51549
		[Token(Token = "0x600C95D")]
		void RefreshItems();

		// Token: 0x0600C95E RID: 51550
		[Token(Token = "0x600C95E")]
		bool IsActive();

		// Token: 0x0600C95F RID: 51551
		[Token(Token = "0x600C95F")]
		void RemoveBlenderItem(AudioChannelEffect channelEffect);

		// Token: 0x0600C960 RID: 51552
		[Token(Token = "0x600C960")]
		void Clear();
	}
}
