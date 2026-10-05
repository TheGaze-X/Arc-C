using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace CriWare.CriTimeline.Atom
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	public abstract class CriAtomClipBase : PlayableAsset, ITimelineClipAsset
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x00004604 File Offset: 0x00002804
		[Token(Token = "0x170000B1")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x600087A")]
			[Address(RVA = "0x3709B30", Offset = "0x3708730", VA = "0x183709B30", Slot = "9")]
			get
			{
				return ClipCaps.None;
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x3709B10", Offset = "0x3708710", VA = "0x183709B10")]
		public void SetClipDuration(double clipDuration)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0000461C File Offset: 0x0000281C
		[Token(Token = "0x170000B2")]
		public override double duration
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0x3709B40", Offset = "0x3708740", VA = "0x183709B40", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600087D RID: 2173
		[Token(Token = "0x170000B3")]
		public abstract string CueName { [Token(Token = "0x600087D")] get; }

		// Token: 0x0600087E RID: 2174
		[Token(Token = "0x600087E")]
		public abstract CriAtomExAcb GetAcb();

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600087F RID: 2175
		[Token(Token = "0x170000B4")]
		public abstract string AcbPath { [Token(Token = "0x600087F")] get; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000880 RID: 2176
		[Token(Token = "0x170000B5")]
		public abstract string AwbPath { [Token(Token = "0x6000880")] get; }

		// Token: 0x06000881 RID: 2177
		[Token(Token = "0x6000881")]
		public abstract void SetCueFromAtomSource(CriAtomSourceBase atomSource);

		// Token: 0x06000882 RID: 2178 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x3709B20", Offset = "0x3708720", VA = "0x183709B20")]
		protected CriAtomClipBase()
		{
		}

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x18")]
		public bool stopWithoutRelease;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x19")]
		public bool muted;

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x1A")]
		public bool ignoreBlend;

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x1B")]
		public bool loopWithinClip;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x1C")]
		public bool stopAtClipEnd;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		private double clipDuration;
	}
}
