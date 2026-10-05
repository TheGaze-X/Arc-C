using System;
using System.Collections;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	public class WaitForSpineEvent : IEnumerator
	{
		// Token: 0x06000710 RID: 1808 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x4E9F9E0", Offset = "0x4E9E5E0", VA = "0x184E9F9E0")]
		private void Subscribe(AnimationState state, EventData eventDataReference, bool unsubscribe)
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x4E9F890", Offset = "0x4E9E490", VA = "0x184E9F890")]
		private void SubscribeByName(AnimationState state, string eventName, bool unsubscribe)
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x4E9FC40", Offset = "0x4E9E840", VA = "0x184E9FC40")]
		public WaitForSpineEvent(AnimationState state, EventData eventDataReference, bool unsubscribeAfterFiring = true)
		{
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x4E9FBD0", Offset = "0x4E9E7D0", VA = "0x184E9FBD0")]
		public WaitForSpineEvent(SkeletonAnimation skeletonAnimation, EventData eventDataReference, bool unsubscribeAfterFiring = true)
		{
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x4E9FB70", Offset = "0x4E9E770", VA = "0x184E9FB70")]
		public WaitForSpineEvent(AnimationState state, string eventName, bool unsubscribeAfterFiring = true)
		{
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x4E9FCA0", Offset = "0x4E9E8A0", VA = "0x184E9FCA0")]
		public WaitForSpineEvent(SkeletonAnimation skeletonAnimation, string eventName, bool unsubscribeAfterFiring = true)
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x4E9F5C0", Offset = "0x4E9E1C0", VA = "0x184E9F5C0")]
		private void HandleAnimationStateEventByName(TrackEntry trackEntry, Event e)
		{
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x4E9F690", Offset = "0x4E9E290", VA = "0x184E9F690")]
		private void HandleAnimationStateEvent(TrackEntry trackEntry, Event e)
		{
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x00004874 File Offset: 0x00002A74
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170001C4")]
		public bool WillUnsubscribeAfterFiring
		{
			[Token(Token = "0x6000718")]
			[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1636A20", Offset = "0x1635620", VA = "0x181636A20")]
			set
			{
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x4E9F750", Offset = "0x4E9E350", VA = "0x184E9F750")]
		public WaitForSpineEvent NowWaitFor(AnimationState state, EventData eventDataReference, bool unsubscribeAfterFiring = true)
		{
			return null;
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x4E9F7F0", Offset = "0x4E9E3F0", VA = "0x184E9F7F0")]
		public WaitForSpineEvent NowWaitFor(AnimationState state, string eventName, bool unsubscribeAfterFiring = true)
		{
			return null;
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x4E9F4E0", Offset = "0x4E9E0E0", VA = "0x184E9F4E0")]
		private void Clear(AnimationState state)
		{
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0000488C File Offset: 0x00002A8C
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x4E9FB20", Offset = "0x4E9E720", VA = "0x184E9FB20", Slot = "4")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x4ADC600", Offset = "0x4ADB200", VA = "0x184ADC600", Slot = "6")]
		private void Reset()
		{
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001C5")]
		private object Current
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x10")]
		private EventData m_TargetEvent;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x18")]
		private string m_EventName;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x20")]
		private AnimationState m_AnimationState;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x28")]
		private bool m_WasFired;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x29")]
		private bool m_unsubscribeAfterFiring;
	}
}
