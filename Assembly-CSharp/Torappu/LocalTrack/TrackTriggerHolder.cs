using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.LocalTrack
{
	// Token: 0x02002092 RID: 8338
	[Token(Token = "0x2002092")]
	public abstract class TrackTriggerHolder<TriggerType> : IHotfixable, ITrackTriggerHolder where TriggerType : TrackTrigger
	{
		// Token: 0x0600CD64 RID: 52580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CD64")]
		public Type GetTriggerType()
		{
			return null;
		}

		// Token: 0x0600CD65 RID: 52581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD65")]
		public void AddTrigger(TrackTrigger rawTrigger)
		{
		}

		// Token: 0x0600CD66 RID: 52582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD66")]
		public void Init(LocalTrackStore.HolderHandler handler)
		{
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x0600CD67 RID: 52583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001847")]
		protected Dictionary<string, Dictionary<string, TriggerType>> triggerStore
		{
			[Token(Token = "0x600CD67")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CD68 RID: 52584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD68")]
		protected virtual void OnTriggerAdded(TriggerType trigger)
		{
		}

		// Token: 0x0600CD69 RID: 52585 RVA: 0x0004A088 File Offset: 0x00048288
		[Token(Token = "0x600CD69")]
		protected bool DoTrackTrigger(TriggerType trigger)
		{
			return default(bool);
		}

		// Token: 0x0600CD6A RID: 52586 RVA: 0x0004A0A0 File Offset: 0x000482A0
		[Token(Token = "0x600CD6A")]
		protected long GetTrackTypeVersion(string type)
		{
			return 0L;
		}

		// Token: 0x0600CD6B RID: 52587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CD6B")]
		protected TrackTriggerHolder()
		{
		}

		// Token: 0x0400D8AE RID: 55470
		[Token(Token = "0x400D8AE")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<string, Dictionary<string, TriggerType>> m_triggerStore;

		// Token: 0x0400D8AF RID: 55471
		[Token(Token = "0x400D8AF")]
		[FieldOffset(Offset = "0x0")]
		private LocalTrackStore.HolderHandler m_storeHandler;

		// Token: 0x0400D8B0 RID: 55472
		[Token(Token = "0x400D8B0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetTriggerType;

		// Token: 0x0400D8B1 RID: 55473
		[Token(Token = "0x400D8B1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AddTrigger;

		// Token: 0x0400D8B2 RID: 55474
		[Token(Token = "0x400D8B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400D8B3 RID: 55475
		[Token(Token = "0x400D8B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_triggerStore;

		// Token: 0x0400D8B4 RID: 55476
		[Token(Token = "0x400D8B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTriggerAdded;

		// Token: 0x0400D8B5 RID: 55477
		[Token(Token = "0x400D8B5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoTrackTrigger;

		// Token: 0x0400D8B6 RID: 55478
		[Token(Token = "0x400D8B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetTrackTypeVersion;

		// Token: 0x0400D8B7 RID: 55479
		[Token(Token = "0x400D8B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
