using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	public static class CriAtomExBeatSync
	{
		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000266 RID: 614 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x06000267 RID: 615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000E")]
		public static event CriAtomExBeatSync.CbFunc OnCallback
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x36C4FA0", Offset = "0x36C3BA0", VA = "0x1836C4FA0")]
			add
			{
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x36C4FB0", Offset = "0x36C3BB0", VA = "0x1836C4FB0")]
			remove
			{
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x36C4E80", Offset = "0x36C3A80", VA = "0x1836C4E80")]
		[Obsolete("SetCallback is deprecated. Use OnBeatSyncCallback event", false)]
		public static void SetCallback(CriAtomExBeatSync.CbFunc func)
		{
		}

		// Token: 0x02000055 RID: 85
		[Token(Token = "0x2000055")]
		public struct Info
		{
			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000269 RID: 617 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x17000043")]
			public string label
			{
				[Token(Token = "0x6000269")]
				[Address(RVA = "0x36DB7C0", Offset = "0x36DA3C0", VA = "0x1836DB7C0")]
				get
				{
					return null;
				}
			}

			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40001D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr playerHn;

			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x40001D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint playbackId;

			// Token: 0x040001D7 RID: 471
			[Token(Token = "0x40001D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public uint barCount;

			// Token: 0x040001D8 RID: 472
			[Token(Token = "0x40001D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint beatCount;

			// Token: 0x040001D9 RID: 473
			[Token(Token = "0x40001D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float beatProgress;

			// Token: 0x040001DA RID: 474
			[Token(Token = "0x40001DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float bpm;

			// Token: 0x040001DB RID: 475
			[Token(Token = "0x40001DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int offset;

			// Token: 0x040001DC RID: 476
			[Token(Token = "0x40001DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint numBeats;

			// Token: 0x040001DD RID: 477
			[Token(Token = "0x40001DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IntPtr labelPtr;
		}

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x0600026B RID: 619
		[Token(Token = "0x2000056")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void CbFunc(ref CriAtomExBeatSync.Info info);
	}
}
