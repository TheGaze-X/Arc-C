using System;
using System.Collections;
using Il2CppDummyDll;

namespace Spine.Unity
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	public class WaitForSpineAnimation : IEnumerator
	{
		// Token: 0x06000705 RID: 1797 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x4E9F4A0", Offset = "0x4E9E0A0", VA = "0x184E9F4A0")]
		public WaitForSpineAnimation(TrackEntry trackEntry, WaitForSpineAnimation.AnimationEventTypes eventsToWaitFor)
		{
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x4E9F230", Offset = "0x4E9DE30", VA = "0x184E9F230")]
		public WaitForSpineAnimation NowWaitFor(TrackEntry trackEntry, WaitForSpineAnimation.AnimationEventTypes eventsToWaitFor)
		{
			return null;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0000485C File Offset: 0x00002A5C
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x4E9F450", Offset = "0x4E9E050", VA = "0x184E9F450", Slot = "4")]
		private bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x13A5FA0", Offset = "0x13A4BA0", VA = "0x1813A5FA0", Slot = "6")]
		private void Reset()
		{
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x170001C3")]
		private object Current
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x4E9F250", Offset = "0x4E9DE50", VA = "0x184E9F250")]
		protected void SafeSubscribe(TrackEntry trackEntry, WaitForSpineAnimation.AnimationEventTypes eventsToWaitFor)
		{
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600070B")]
		[Address(RVA = "0xF3CBA0", Offset = "0xF3B7A0", VA = "0x180F3CBA0")]
		private void HandleComplete(TrackEntry trackEntry)
		{
		}

		// Token: 0x04000465 RID: 1125
		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x10")]
		private bool m_WasFired;

		// Token: 0x020000C4 RID: 196
		[Token(Token = "0x20000C4")]
		[Flags]
		public enum AnimationEventTypes
		{
			// Token: 0x04000467 RID: 1127
			[Token(Token = "0x4000467")]
			Start = 1,
			// Token: 0x04000468 RID: 1128
			[Token(Token = "0x4000468")]
			Interrupt = 2,
			// Token: 0x04000469 RID: 1129
			[Token(Token = "0x4000469")]
			End = 4,
			// Token: 0x0400046A RID: 1130
			[Token(Token = "0x400046A")]
			Dispose = 8,
			// Token: 0x0400046B RID: 1131
			[Token(Token = "0x400046B")]
			Complete = 16
		}
	}
}
