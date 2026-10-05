using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare.CriTimeline.Atom
{
	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	public class CriAtomTimelinePreviewer : IDisposable
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x170000B8")]
		public static CriAtomTimelinePreviewer Instance
		{
			[Token(Token = "0x600088B")]
			[Address(RVA = "0x370CA50", Offset = "0x370B650", VA = "0x18370CA50")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088C")]
		[Address(RVA = "0x370B9F0", Offset = "0x370A5F0", VA = "0x18370B9F0")]
		public static void InstanceDispose()
		{
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x00004664 File Offset: 0x00002864
		[Token(Token = "0x170000B9")]
		public static bool IsInitialized
		{
			[Token(Token = "0x600088D")]
			[Address(RVA = "0x370CC70", Offset = "0x370B870", VA = "0x18370CC70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088E")]
		[Address(RVA = "0x370C8C0", Offset = "0x370B4C0", VA = "0x18370C8C0")]
		public CriAtomTimelinePreviewer()
		{
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x370B360", Offset = "0x3709F60", VA = "0x18370B360")]
		private CriAtomTimelinePreviewer.PlayerSource GetPlayer(Guid trackId)
		{
			return null;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x370BF70", Offset = "0x370AB70", VA = "0x18370BF70")]
		public void Update3dTransform(Guid trackId, Transform transform, float deltaTime)
		{
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x370B5D0", Offset = "0x370A1D0", VA = "0x18370B5D0")]
		public void InitPreviewListenerList(CriAtomListener[] listenerList)
		{
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000892")]
		[Address(RVA = "0x370C080", Offset = "0x370AC80", VA = "0x18370C080")]
		public void UpdateAllListeners(Guid trackId, float deltaTime, CriAtomListener exclusiveObj)
		{
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x370BBA0", Offset = "0x370A7A0", VA = "0x18370BBA0")]
		public void SetCue(Guid trackId, CriAtomExAcb acb, string cueName)
		{
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000894")]
		[Address(RVA = "0x370B000", Offset = "0x3709C00", VA = "0x18370B000")]
		public CriAtomExAcb GetAcb(string acbPath, string awbPath)
		{
			return null;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0000467C File Offset: 0x0000287C
		[Token(Token = "0x6000895")]
		[Address(RVA = "0x370BAB0", Offset = "0x370A6B0", VA = "0x18370BAB0")]
		public CriAtomExPlayback Play(Guid trackId)
		{
			return default(CriAtomExPlayback);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x370BF10", Offset = "0x370AB10", VA = "0x18370BF10")]
		public void StopTrack(Guid trackId, bool stopWithoutRelease = true)
		{
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x370BDB0", Offset = "0x370A9B0", VA = "0x18370BDB0")]
		public void StopAllTracks(bool stopWithoutRelease = true)
		{
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x370BD10", Offset = "0x370A910", VA = "0x18370BD10")]
		public void SetStartTime(Guid trackId, long startTimeMs)
		{
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x370BC70", Offset = "0x370A870", VA = "0x18370BC70")]
		public void SetLoop(Guid trackId, bool sw)
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x370BD60", Offset = "0x370A960", VA = "0x18370BD60")]
		public void SetVolume(Guid trackId, float volume)
		{
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x370BCC0", Offset = "0x370A8C0", VA = "0x18370BCC0")]
		public void SetPitch(Guid trackId, float pitch)
		{
		}

		// Token: 0x0600089C RID: 2204 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089C")]
		[Address(RVA = "0x370BB40", Offset = "0x370A740", VA = "0x18370BB40")]
		public void SetAISAC(Guid trackId, string controlName, float value)
		{
		}

		// Token: 0x0600089D RID: 2205 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089D")]
		[Address(RVA = "0x370BAF0", Offset = "0x370A6F0", VA = "0x18370BAF0")]
		public void PlayerUpdateParameter(Guid trackId, CriAtomExPlayback atomExPlayback)
		{
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x370C890", Offset = "0x370B490", VA = "0x18370C890")]
		public void UpdateTimelineExtension(CriAtomSourceBase bindObject, Guid trackGuid)
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x370AFA0", Offset = "0x3709BA0", VA = "0x18370AFA0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x370A9B0", Offset = "0x37095B0", VA = "0x18370A9B0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x370AA10", Offset = "0x3709610", VA = "0x18370AA10")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x0400056B RID: 1387
		[Token(Token = "0x400056B")]
		[FieldOffset(Offset = "0x0")]
		private static CriAtomTimelinePreviewer instance;

		// Token: 0x0400056C RID: 1388
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x10")]
		private CriAtom atom;

		// Token: 0x0400056D RID: 1389
		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x18")]
		private string lastAcfFile;

		// Token: 0x0400056E RID: 1390
		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<string, CriAtomExAcb> acbTable;

		// Token: 0x0400056F RID: 1391
		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Guid, CriAtomTimelinePreviewer.PlayerSource> playerTable;

		// Token: 0x04000570 RID: 1392
		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<Guid, CriAtomTimelinePreviewer.PreviewListener> listenerTable;

		// Token: 0x04000571 RID: 1393
		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x38")]
		private List<KeyValuePair<Guid, CriAtomTimelinePreviewer.PreviewListener>> listenerPurgeList;

		// Token: 0x04000572 RID: 1394
		[Token(Token = "0x4000572")]
		[FieldOffset(Offset = "0x40")]
		private Guid? trackIdForListenerUpdate;

		// Token: 0x02000129 RID: 297
		[Token(Token = "0x2000129")]
		private class PlayerSource : IDisposable
		{
			// Token: 0x060008A2 RID: 2210 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x3710E80", Offset = "0x370FA80", VA = "0x183710E80")]
			public PlayerSource()
			{
			}

			// Token: 0x060008A3 RID: 2211 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x3710C60", Offset = "0x370F860", VA = "0x183710C60", Slot = "1")]
			protected override void Finalize()
			{
			}

			// Token: 0x060008A4 RID: 2212 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x3710C00", Offset = "0x370F800", VA = "0x183710C00", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060008A5 RID: 2213 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x3710F80", Offset = "0x370FB80", VA = "0x183710F80")]
			private void dispose()
			{
			}

			// Token: 0x060008A6 RID: 2214 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x3710CC0", Offset = "0x370F8C0", VA = "0x183710CC0")]
			public void Set3dTransform(Vector3 pos, Vector3 forward, Vector3 up, float deltaTime)
			{
			}

			// Token: 0x060008A7 RID: 2215 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x3710BF0", Offset = "0x370F7F0", VA = "0x183710BF0")]
			public void ClearLastPos()
			{
			}

			// Token: 0x04000573 RID: 1395
			[Token(Token = "0x4000573")]
			[FieldOffset(Offset = "0x10")]
			public readonly CriAtomExPlayer player;

			// Token: 0x04000574 RID: 1396
			[Token(Token = "0x4000574")]
			[FieldOffset(Offset = "0x18")]
			public readonly CriAtomEx3dSource source3d;

			// Token: 0x04000575 RID: 1397
			[Token(Token = "0x4000575")]
			[FieldOffset(Offset = "0x20")]
			private Vector3? lastPos;

			// Token: 0x04000576 RID: 1398
			[Token(Token = "0x4000576")]
			[FieldOffset(Offset = "0x30")]
			private bool disposed;
		}

		// Token: 0x0200012A RID: 298
		[Token(Token = "0x200012A")]
		private class PreviewListener : IDisposable
		{
			// Token: 0x060008A8 RID: 2216 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x371A8F0", Offset = "0x37194F0", VA = "0x18371A8F0")]
			public PreviewListener(CriAtomListener listenerObj)
			{
			}

			// Token: 0x060008A9 RID: 2217 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x371A510", Offset = "0x3719110", VA = "0x18371A510", Slot = "1")]
			protected override void Finalize()
			{
			}

			// Token: 0x060008AA RID: 2218 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x371A430", Offset = "0x3719030", VA = "0x18371A430", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x060008AB RID: 2219 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x371A990", Offset = "0x3719590", VA = "0x18371A990")]
			private void dispose()
			{
			}

			// Token: 0x060008AC RID: 2220 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x371A5B0", Offset = "0x37191B0", VA = "0x18371A5B0")]
			public void Set3dTransform(float deltaTime)
			{
			}

			// Token: 0x060008AD RID: 2221 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x371A4C0", Offset = "0x37190C0", VA = "0x18371A4C0")]
			public void Exile()
			{
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x3710BF0", Offset = "0x370F7F0", VA = "0x183710BF0")]
			public void ClearLastPos()
			{
			}

			// Token: 0x04000577 RID: 1399
			[Token(Token = "0x4000577")]
			[FieldOffset(Offset = "0x10")]
			public readonly CriAtomEx3dListener listener;

			// Token: 0x04000578 RID: 1400
			[Token(Token = "0x4000578")]
			[FieldOffset(Offset = "0x18")]
			public readonly CriAtomListener transformObj;

			// Token: 0x04000579 RID: 1401
			[Token(Token = "0x4000579")]
			[FieldOffset(Offset = "0x20")]
			private Vector3? lastPos;

			// Token: 0x0400057A RID: 1402
			[Token(Token = "0x400057A")]
			[FieldOffset(Offset = "0x30")]
			private bool disposed;
		}
	}
}
