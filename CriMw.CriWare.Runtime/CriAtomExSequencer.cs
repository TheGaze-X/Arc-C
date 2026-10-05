using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	public static class CriAtomExSequencer
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600025B RID: 603 RVA: 0x00002066 File Offset: 0x00000266
		// (remove) Token: 0x0600025C RID: 604 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1400000D")]
		public static event CriAtomExSequencer.EventCallback OnCallback
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x36CA2E0", Offset = "0x36C8EE0", VA = "0x1836CA2E0")]
			add
			{
			}
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x36CA2F0", Offset = "0x36C8EF0", VA = "0x1836CA2F0")]
			remove
			{
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x36CA2D0", Offset = "0x36C8ED0", VA = "0x1836CA2D0")]
		[Obsolete("SetEventCallback is deprecated. Use CriAtomExSequencer.OnCallback event", false)]
		public static void SetEventCallback(CriAtomExSequencer.EventCbFunc func, string separator = "\t")
		{
		}

		// Token: 0x02000051 RID: 81
		[Token(Token = "0x2000051")]
		public struct CriAtomExSequenceEventInfo
		{
			// Token: 0x040001CE RID: 462
			[Token(Token = "0x40001CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ulong position;

			// Token: 0x040001CF RID: 463
			[Token(Token = "0x40001CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public IntPtr playerHn;

			// Token: 0x040001D0 RID: 464
			[Token(Token = "0x40001D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public readonly string tag;

			// Token: 0x040001D1 RID: 465
			[Token(Token = "0x40001D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint playbackId;

			// Token: 0x040001D2 RID: 466
			[Token(Token = "0x40001D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int type;

			// Token: 0x040001D3 RID: 467
			[Token(Token = "0x40001D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint id;

			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40001D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private uint reserved;
		}

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x0600025F RID: 607
		[Token(Token = "0x2000052")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void EventCbFunc(string eventParamsString);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x06000263 RID: 611
		[Token(Token = "0x2000053")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void EventCallback(ref CriAtomExSequencer.CriAtomExSequenceEventInfo criAtomExSequenceInfo);
	}
}
