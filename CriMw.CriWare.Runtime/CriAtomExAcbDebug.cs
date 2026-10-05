using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x0200010F RID: 271
	[Token(Token = "0x200010F")]
	public static class CriAtomExAcbDebug
	{
		// Token: 0x06000809 RID: 2057 RVA: 0x000042BC File Offset: 0x000024BC
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x36DF540", Offset = "0x36DE140", VA = "0x1836DF540")]
		public static bool GetAcbInfo(CriAtomExAcb acb, out CriAtomExAcbDebug.AcbInfo acbInfo)
		{
			return default(bool);
		}

		// Token: 0x0600080A RID: 2058
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x36DF630", Offset = "0x36DE230", VA = "0x1836DF630")]
		[PreserveSig]
		private static extern int criAtomExAcb_GetAcbInfo(IntPtr acbHn, out CriAtomExAcbDebug.AcbInfoForMarshaling acbInfo);

		// Token: 0x02000110 RID: 272
		[Token(Token = "0x2000110")]
		public struct AcbInfo
		{
			// Token: 0x040004E8 RID: 1256
			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			// Token: 0x040004E9 RID: 1257
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint size;

			// Token: 0x040004EA RID: 1258
			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public uint version;

			// Token: 0x040004EB RID: 1259
			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CriAtomEx.CharacterEncoding characterEncoding;

			// Token: 0x040004EC RID: 1260
			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float volume;

			// Token: 0x040004ED RID: 1261
			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int numCues;
		}

		// Token: 0x02000111 RID: 273
		[Token(Token = "0x2000111")]
		private struct AcbInfoForMarshaling
		{
			// Token: 0x0600080B RID: 2059 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600080B")]
			[Address(RVA = "0x36DE250", Offset = "0x36DCE50", VA = "0x1836DE250")]
			public void Convert(out CriAtomExAcbDebug.AcbInfo x)
			{
			}

			// Token: 0x040004EE RID: 1262
			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IntPtr namePtr;

			// Token: 0x040004EF RID: 1263
			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public uint size;

			// Token: 0x040004F0 RID: 1264
			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public uint version;

			// Token: 0x040004F1 RID: 1265
			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CriAtomEx.CharacterEncoding characterEncoding;

			// Token: 0x040004F2 RID: 1266
			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float volume;

			// Token: 0x040004F3 RID: 1267
			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int numCues;
		}
	}
}
