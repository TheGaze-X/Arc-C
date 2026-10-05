using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	internal class InfiniteRuntimeClip : RuntimeElement
	{
		// Token: 0x06000237 RID: 567 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x58E9B90", Offset = "0x58E8790", VA = "0x1858E9B90")]
		public InfiniteRuntimeClip(Playable playable)
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00003584 File Offset: 0x00001784
		[Token(Token = "0x1700009C")]
		public override long intervalStart
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "6")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000359C File Offset: 0x0000179C
		[Token(Token = "0x1700009D")]
		public override long intervalEnd
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x58E9BC0", Offset = "0x58E87C0", VA = "0x1858E9BC0", Slot = "7")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700009E RID: 158
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700009E")]
		public override bool enable
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x58E9C10", Offset = "0x58E8810", VA = "0x1858E9C10", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x58E9A50", Offset = "0x58E8650", VA = "0x1858E9A50", Slot = "9")]
		public override void EvaluateAt(double localTime, FrameData frameData)
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x58E99D0", Offset = "0x58E85D0", VA = "0x1858E99D0", Slot = "10")]
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData)
		{
		}

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x18")]
		private Playable m_Playable;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x0")]
		private static readonly long kIntervalEnd;
	}
}
