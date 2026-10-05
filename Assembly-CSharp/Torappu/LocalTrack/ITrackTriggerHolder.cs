using System;
using Il2CppDummyDll;

namespace Torappu.LocalTrack
{
	// Token: 0x0200208E RID: 8334
	[Token(Token = "0x200208E")]
	public interface ITrackTriggerHolder
	{
		// Token: 0x0600CD5D RID: 52573
		[Token(Token = "0x600CD5D")]
		Type GetTriggerType();

		// Token: 0x0600CD5E RID: 52574
		[Token(Token = "0x600CD5E")]
		void AddTrigger(TrackTrigger trigger);

		// Token: 0x0600CD5F RID: 52575
		[Token(Token = "0x600CD5F")]
		void Init(LocalTrackStore.HolderHandler handler);
	}
}
