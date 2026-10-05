using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;

namespace CriWare.CriTimeline.Atom
{
	// Token: 0x02000124 RID: 292
	[Token(Token = "0x2000124")]
	[Serializable]
	public class CriAtomBehaviour : PlayableBehaviour
	{
		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0000458C File Offset: 0x0000278C
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AB")]
		public CriAtomExPlayback playback
		{
			[Token(Token = "0x6000863")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			[CompilerGenerated]
			get
			{
				return default(CriAtomExPlayback);
			}
			[Token(Token = "0x6000864")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x000045A4 File Offset: 0x000027A4
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AC")]
		public bool IsClipPlaying
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x2033950", Offset = "0x2032550", VA = "0x182033950")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x2033A00", Offset = "0x2032600", VA = "0x182033A00")]
			private set
			{
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x000045BC File Offset: 0x000027BC
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000AD")]
		public double CueLength
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x3709AF0", Offset = "0x37086F0", VA = "0x183709AF0")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x3709B00", Offset = "0x3708700", VA = "0x183709B00")]
			private set
			{
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000869")]
		[Address(RVA = "0x3709180", Offset = "0x3707D80", VA = "0x183709180", Slot = "14")]
		public override void OnGraphStop(Playable playable)
		{
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086A")]
		[Address(RVA = "0x37091B0", Offset = "0x3707DB0", VA = "0x1837091B0")]
		public void Play(CriAtomSourceBase atomSource, CriAtomClipPlayConfig config)
		{
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x3709510", Offset = "0x3708110", VA = "0x183709510")]
		public void PreviewPlay(Guid trackId, bool instantStop, CriAtomClipPlayConfig config)
		{
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x37099F0", Offset = "0x37085F0", VA = "0x1837099F0")]
		private void WaitAndStop()
		{
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x3709940", Offset = "0x3708540", VA = "0x183709940")]
		public void Stop(bool noReleaseTime = false)
		{
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000045D4 File Offset: 0x000027D4
		[Token(Token = "0x600086E")]
		[Address(RVA = "0x3709120", Offset = "0x3707D20", VA = "0x183709120")]
		private double GetCueLengthSec(CriAtomExAcb acb, string cueName)
		{
			return 0.0;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086F")]
		[Address(RVA = "0x3709AE0", Offset = "0x37086E0", VA = "0x183709AE0")]
		public CriAtomBehaviour()
		{
		}

		// Token: 0x0400054B RID: 1355
		[Token(Token = "0x400054B")]
		[FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float volume;

		// Token: 0x0400054C RID: 1356
		[Token(Token = "0x400054C")]
		[FieldOffset(Offset = "0x14")]
		[Range(-1200f, 1200f)]
		public float pitch;

		// Token: 0x0400054D RID: 1357
		[Token(Token = "0x400054D")]
		[FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float AISACValue;

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x0")]
		private static int cPreviewStopTimeMs;

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x20")]
		private CriAtomExAcb m_acb;

		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x28")]
		private string m_lastCueSheetPath;

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x34")]
		private bool _IsClipPlaying;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x38")]
		private double _CueLength;
	}
}
