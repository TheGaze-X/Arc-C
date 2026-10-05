using System;
using System.Runtime.InteropServices;
using CriWare.CriMana;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace CriWare.CriTimeline.Mana
{
	// Token: 0x0200011C RID: 284
	[Token(Token = "0x200011C")]
	public abstract class CriManaClipBase : PlayableAsset, ITimelineClipAsset
	{
		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600083B RID: 2107
		[Token(Token = "0x170000A3")]
		public abstract string MoviePath { [Token(Token = "0x600083B")] get; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600083C RID: 2108
		[Token(Token = "0x170000A4")]
		public abstract byte[] MovieData { [Token(Token = "0x600083C")] get; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600083D RID: 2109
		[Token(Token = "0x170000A5")]
		public abstract string MovieName { [Token(Token = "0x600083D")] get; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600083E RID: 2110
		[Token(Token = "0x170000A6")]
		public abstract int DataId { [Token(Token = "0x600083E")] get; }

		// Token: 0x0600083F RID: 2111 RVA: 0x0000443C File Offset: 0x0000263C
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x370D620", Offset = "0x370C220", VA = "0x18370D620")]
		private CriManaClipBase.MovieInfoStruct? StructToMovieInfo(MovieInfo movieInfo)
		{
			return null;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00004454 File Offset: 0x00002654
		[Token(Token = "0x170000A7")]
		public ClipCaps clipCaps
		{
			[Token(Token = "0x6000840")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "9")]
			get
			{
				return ClipCaps.None;
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x370D400", Offset = "0x370C000", VA = "0x18370D400")]
		public void ReplaceMovieInfo(MovieInfo movieInfo)
		{
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0000446C File Offset: 0x0000266C
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x370D280", Offset = "0x370BE80", VA = "0x18370D280")]
		public bool IsSameMovie(MovieInfo movieInfo)
		{
			return default(bool);
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00004484 File Offset: 0x00002684
		[Token(Token = "0x170000A8")]
		public bool IsMovieInfoReady
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x370D7C0", Offset = "0x370C3C0", VA = "0x18370D7C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0000449C File Offset: 0x0000269C
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x370D1A0", Offset = "0x370BDA0", VA = "0x18370D1A0")]
		public int GetSeekFrame(double seekTimeSec, bool loop)
		{
			return 0;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x000044B4 File Offset: 0x000026B4
		[Token(Token = "0x170000A9")]
		public override double duration
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x370D800", Offset = "0x370C400", VA = "0x18370D800", Slot = "7")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x370D720", Offset = "0x370C320", VA = "0x18370D720")]
		protected CriManaClipBase()
		{
		}

		// Token: 0x04000508 RID: 1288
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Guid guid;

		// Token: 0x04000509 RID: 1289
		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool m_loopWithinClip;

		// Token: 0x0400050A RID: 1290
		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool m_useOnMemoryPlayback;

		// Token: 0x0400050B RID: 1291
		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GCHandle gcHandle;

		// Token: 0x0400050C RID: 1292
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private double m_movieFrameRate;

		// Token: 0x0400050D RID: 1293
		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private double m_clipDuration;

		// Token: 0x0400050E RID: 1294
		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float m_fadeinDuration;

		// Token: 0x0400050F RID: 1295
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve m_fadeinCurve;

		// Token: 0x04000510 RID: 1296
		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float m_fadeoutDuration;

		// Token: 0x04000511 RID: 1297
		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve m_fadeoutCurve;

		// Token: 0x04000512 RID: 1298
		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool m_fadeAudio;

		// Token: 0x04000513 RID: 1299
		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public TimelineClip m_clip;

		// Token: 0x04000514 RID: 1300
		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CriManaClipBase.MovieInfoStruct? m_movieInfoStruct;

		// Token: 0x0200011D RID: 285
		[Token(Token = "0x200011D")]
		private struct MovieInfoStruct
		{
			// Token: 0x04000515 RID: 1301
			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint width;

			// Token: 0x04000516 RID: 1302
			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint height;

			// Token: 0x04000517 RID: 1303
			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint dispWidth;

			// Token: 0x04000518 RID: 1304
			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public uint dispHeight;

			// Token: 0x04000519 RID: 1305
			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint framerateN;

			// Token: 0x0400051A RID: 1306
			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint framerateD;

			// Token: 0x0400051B RID: 1307
			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint totalFrames;

			// Token: 0x0400051C RID: 1308
			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public CodecType _codecType;

			// Token: 0x0400051D RID: 1309
			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CodecType _alphaCodecType;
		}
	}
}
