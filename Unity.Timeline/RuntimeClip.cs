using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	internal class RuntimeClip : RuntimeClipBase
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000035E4 File Offset: 0x000017E4
		[Token(Token = "0x170000A2")]
		public override double start
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x58EB610", Offset = "0x58EA210", VA = "0x1858EB610", Slot = "11")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000035FC File Offset: 0x000017FC
		[Token(Token = "0x170000A3")]
		public override double duration
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x58EB5F0", Offset = "0x58EA1F0", VA = "0x1858EB5F0", Slot = "12")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x58EB560", Offset = "0x58EA160", VA = "0x1858EB560")]
		public RuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x58EAE70", Offset = "0x58E9A70", VA = "0x1858EAE70")]
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer)
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000250 RID: 592 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x170000A4")]
		public TimelineClip clip
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00003614 File Offset: 0x00001814
		[Token(Token = "0x170000A5")]
		public Playable mixer
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x4ED6A0", Offset = "0x4EC2A0", VA = "0x1804ED6A0")]
			get
			{
				return default(Playable);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000362C File Offset: 0x0000182C
		[Token(Token = "0x170000A6")]
		public Playable playable
		{
			[Token(Token = "0x6000252")]
			[Address(RVA = "0xF10AF0", Offset = "0xF0F6F0", VA = "0x180F10AF0")]
			get
			{
				return default(Playable);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A7")]
		public override bool enable
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x58EB640", Offset = "0x58EA240", VA = "0x1858EB640", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x58EB500", Offset = "0x58EA100", VA = "0x1858EB500")]
		public void SetTime(double time)
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x58EB4A0", Offset = "0x58EA0A0", VA = "0x1858EB4A0")]
		public void SetDuration(double duration)
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x58EB0F0", Offset = "0x58E9CF0", VA = "0x1858EB0F0", Slot = "9")]
		public override void EvaluateAt(double localTime, FrameData frameData)
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x58EAF00", Offset = "0x58E9B00", VA = "0x1858EAF00", Slot = "10")]
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData)
		{
		}

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[FieldOffset(Offset = "0x18")]
		private TimelineClip m_Clip;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[FieldOffset(Offset = "0x20")]
		private Playable m_Playable;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x30")]
		private Playable m_ParentMixer;
	}
}
