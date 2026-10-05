using System;
using Il2CppDummyDll;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	internal class ScheduleRuntimeClip : RuntimeClipBase
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000265 RID: 613 RVA: 0x0000368C File Offset: 0x0000188C
		[Token(Token = "0x170000B0")]
		public override double start
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x58EBD90", Offset = "0x58EA990", VA = "0x1858EBD90", Slot = "11")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000266 RID: 614 RVA: 0x000036A4 File Offset: 0x000018A4
		[Token(Token = "0x170000B1")]
		public override double duration
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x58EBD00", Offset = "0x58EA900", VA = "0x1858EBD00", Slot = "12")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x58EBBF0", Offset = "0x58EA7F0", VA = "0x1858EBBF0")]
		public void SetTime(double time)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000268 RID: 616 RVA: 0x000021E6 File Offset: 0x000003E6
		[Token(Token = "0x170000B2")]
		public TimelineClip clip
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000036BC File Offset: 0x000018BC
		[Token(Token = "0x170000B3")]
		public Playable mixer
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x4ED6A0", Offset = "0x4EC2A0", VA = "0x1804ED6A0")]
			get
			{
				return default(Playable);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000036D4 File Offset: 0x000018D4
		[Token(Token = "0x170000B4")]
		public Playable playable
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0xF10AF0", Offset = "0xF0F6F0", VA = "0x180F10AF0")]
			get
			{
				return default(Playable);
			}
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x58EBC50", Offset = "0x58EA850", VA = "0x1858EBC50")]
		public ScheduleRuntimeClip(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay = 0.2, double finishTail = 0.1)
		{
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x58EB7D0", Offset = "0x58EA3D0", VA = "0x1858EB7D0")]
		private void Create(TimelineClip clip, Playable clipPlayable, Playable parentMixer, double startDelay, double finishTail)
		{
		}

		// Token: 0x170000B5 RID: 181
		// (set) Token: 0x0600026D RID: 621 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000B5")]
		public override bool enable
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x58EBE10", Offset = "0x58EAA10", VA = "0x1858EBE10", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x58EB8B0", Offset = "0x58EA4B0", VA = "0x1858EB8B0", Slot = "9")]
		public override void EvaluateAt(double localTime, FrameData frameData)
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x58EB870", Offset = "0x58EA470", VA = "0x1858EB870", Slot = "10")]
		public override void DisableAt(double localTime, double rootDuration, FrameData frameData)
		{
		}

		// Token: 0x0400011B RID: 283
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x18")]
		private TimelineClip m_Clip;

		// Token: 0x0400011C RID: 284
		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x20")]
		private Playable m_Playable;

		// Token: 0x0400011D RID: 285
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x30")]
		private Playable m_ParentMixer;

		// Token: 0x0400011E RID: 286
		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x40")]
		private double m_StartDelay;

		// Token: 0x0400011F RID: 287
		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x48")]
		private double m_FinishTail;

		// Token: 0x04000120 RID: 288
		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x50")]
		private bool m_Started;
	}
}
