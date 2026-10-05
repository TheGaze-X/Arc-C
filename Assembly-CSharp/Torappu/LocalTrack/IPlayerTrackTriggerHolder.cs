using System;
using Il2CppDummyDll;

namespace Torappu.LocalTrack
{
	// Token: 0x02002093 RID: 8339
	[Token(Token = "0x2002093")]
	public interface IPlayerTrackTriggerHolder
	{
		// Token: 0x0600CD6C RID: 52588
		[Token(Token = "0x600CD6C")]
		void NotifyPlayerDataChanged(PlayerDataDelta delta, PlayerDataModel prevData, PlayerDataModel curData);
	}
}
