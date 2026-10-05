using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002095 RID: 8341
	[Token(Token = "0x2002095")]
	public abstract class PlayerTrackTriggerHolder<TriggerType> : TrackTriggerHolder<TriggerType>, IPlayerTrackTriggerHolder where TriggerType : PlayerTrackTrigger
	{
		// Token: 0x0600CD6F RID: 52591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD6F")]
		protected override void OnTriggerAdded(TriggerType trigger)
		{
		}

		// Token: 0x0600CD70 RID: 52592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD70")]
		public void NotifyPlayerDataChanged(PlayerDataDelta delta, PlayerDataModel prevData, PlayerDataModel curData)
		{
		}

		// Token: 0x0600CD71 RID: 52593
		[Token(Token = "0x600CD71")]
		protected abstract IList<string> CreatePlayerDataPathList();

		// Token: 0x0600CD72 RID: 52594
		[Token(Token = "0x600CD72")]
		protected abstract bool CheckIfToTrigger(TriggerType trigger, PlayerDataModel prevData, PlayerDataModel curData);

		// Token: 0x0600CD73 RID: 52595 RVA: 0x0004A0B8 File Offset: 0x000482B8
		[Token(Token = "0x600CD73")]
		private static bool _FetchChangedIdsFromDelta(PlayerDataDelta playerDelta, IList<string> pathList, HashSet<string> outIDSet)
		{
			return default(bool);
		}

		// Token: 0x0600CD74 RID: 52596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD74")]
		protected PlayerTrackTriggerHolder()
		{
		}

		// Token: 0x0400D8B9 RID: 55481
		[Token(Token = "0x400D8B9")]
		[FieldOffset(Offset = "0x0")]
		private HashSet<string> m_changeIds;

		// Token: 0x0400D8BA RID: 55482
		[Token(Token = "0x400D8BA")]
		[FieldOffset(Offset = "0x0")]
		private IList<string> m_pathList;

		// Token: 0x0400D8BB RID: 55483
		[Token(Token = "0x400D8BB")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, List<TriggerType>> m_dataToTriggers;

		// Token: 0x0400D8BC RID: 55484
		[Token(Token = "0x400D8BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTriggerAdded;

		// Token: 0x0400D8BD RID: 55485
		[Token(Token = "0x400D8BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_NotifyPlayerDataChanged;

		// Token: 0x0400D8BE RID: 55486
		[Token(Token = "0x400D8BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__FetchChangedIdsFromDelta;

		// Token: 0x0400D8BF RID: 55487
		[Token(Token = "0x400D8BF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
