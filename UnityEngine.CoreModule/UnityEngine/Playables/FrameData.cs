using System;
using Il2CppDummyDll;

namespace UnityEngine.Playables
{
	// Token: 0x0200027F RID: 639
	[Token(Token = "0x200027F")]
	public struct FrameData
	{
		// Token: 0x06000E73 RID: 3699 RVA: 0x00007188 File Offset: 0x00005388
		[Token(Token = "0x6000E73")]
		[Address(RVA = "0x597E540", Offset = "0x597D140", VA = "0x18597E540")]
		private bool HasFlags(FrameData.Flags flag)
		{
			return default(bool);
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000E74 RID: 3700 RVA: 0x000071A0 File Offset: 0x000053A0
		[Token(Token = "0x170002E9")]
		public float deltaTime
		{
			[Token(Token = "0x6000E74")]
			[Address(RVA = "0x597E550", Offset = "0x597D150", VA = "0x18597E550")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000E75 RID: 3701 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x170002EA")]
		public float effectiveSpeed
		{
			[Token(Token = "0x6000E75")]
			[Address(RVA = "0x5958CB0", Offset = "0x59578B0", VA = "0x185958CB0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x000071D0 File Offset: 0x000053D0
		[Token(Token = "0x170002EB")]
		public FrameData.EvaluationType evaluationType
		{
			[Token(Token = "0x6000E76")]
			[Address(RVA = "0x597E580", Offset = "0x597D180", VA = "0x18597E580")]
			get
			{
				return FrameData.EvaluationType.Evaluate;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000E77 RID: 3703 RVA: 0x000071E8 File Offset: 0x000053E8
		[Token(Token = "0x170002EC")]
		public bool seekOccurred
		{
			[Token(Token = "0x6000E77")]
			[Address(RVA = "0x597E5A0", Offset = "0x597D1A0", VA = "0x18597E5A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000E78 RID: 3704 RVA: 0x00007200 File Offset: 0x00005400
		[Token(Token = "0x170002ED")]
		public bool timeLooped
		{
			[Token(Token = "0x6000E78")]
			[Address(RVA = "0x597E5C0", Offset = "0x597D1C0", VA = "0x18597E5C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00007218 File Offset: 0x00005418
		[Token(Token = "0x170002EE")]
		public bool timeHeld
		{
			[Token(Token = "0x6000E79")]
			[Address(RVA = "0x597E5B0", Offset = "0x597D1B0", VA = "0x18597E5B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000E7A RID: 3706 RVA: 0x00007230 File Offset: 0x00005430
		[Token(Token = "0x170002EF")]
		public PlayableOutput output
		{
			[Token(Token = "0x6000E7A")]
			[Address(RVA = "0x597E590", Offset = "0x597D190", VA = "0x18597E590")]
			get
			{
				return default(PlayableOutput);
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x00007248 File Offset: 0x00005448
		[Token(Token = "0x170002F0")]
		public PlayState effectivePlayState
		{
			[Token(Token = "0x6000E7B")]
			[Address(RVA = "0x597E560", Offset = "0x597D160", VA = "0x18597E560")]
			get
			{
				return PlayState.Paused;
			}
		}

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x0")]
		internal ulong m_FrameID;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0x8")]
		internal double m_DeltaTime;

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x10")]
		internal float m_Weight;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x14")]
		internal float m_EffectiveWeight;

		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x18")]
		internal double m_EffectiveParentDelay;

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0x20")]
		internal float m_EffectiveParentSpeed;

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		[FieldOffset(Offset = "0x24")]
		internal float m_EffectiveSpeed;

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x28")]
		internal FrameData.Flags m_Flags;

		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x30")]
		internal PlayableOutput m_Output;

		// Token: 0x02000280 RID: 640
		[Token(Token = "0x2000280")]
		[Flags]
		internal enum Flags
		{
			// Token: 0x040007D7 RID: 2007
			[Token(Token = "0x40007D7")]
			Evaluate = 1,
			// Token: 0x040007D8 RID: 2008
			[Token(Token = "0x40007D8")]
			SeekOccured = 2,
			// Token: 0x040007D9 RID: 2009
			[Token(Token = "0x40007D9")]
			Loop = 4,
			// Token: 0x040007DA RID: 2010
			[Token(Token = "0x40007DA")]
			Hold = 8,
			// Token: 0x040007DB RID: 2011
			[Token(Token = "0x40007DB")]
			EffectivePlayStateDelayed = 16,
			// Token: 0x040007DC RID: 2012
			[Token(Token = "0x40007DC")]
			EffectivePlayStatePlaying = 32
		}

		// Token: 0x02000281 RID: 641
		[Token(Token = "0x2000281")]
		public enum EvaluationType
		{
			// Token: 0x040007DE RID: 2014
			[Token(Token = "0x40007DE")]
			Evaluate,
			// Token: 0x040007DF RID: 2015
			[Token(Token = "0x40007DF")]
			Playback
		}
	}
}
