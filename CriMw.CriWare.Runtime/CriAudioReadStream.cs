using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000AB RID: 171
	[Token(Token = "0x20000AB")]
	public class CriAudioReadStream
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x000038CC File Offset: 0x00001ACC
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000064")]
		public IntPtr callbackFunction
		{
			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x000038E4 File Offset: 0x00001AE4
		// (set) Token: 0x060005C9 RID: 1481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000065")]
		public IntPtr callbackPointer
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x36F22A0", Offset = "0x36F0EA0", VA = "0x1836F22A0")]
		public CriAudioReadStream(IntPtr callbackFunction, IntPtr callbackPointer)
		{
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x36F22E0", Offset = "0x36F0EE0", VA = "0x1836F22E0")]
		public CriAudioReadStream(CriAudioReadStream.Delegate callback, int numChannels, int bufferSize = 256)
		{
		}

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CriAudioReadStream.InternalDelegate internalDelegate;

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x060005CD RID: 1485
		[Token(Token = "0x20000AC")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x060005D1 RID: 1489
		[Token(Token = "0x20000AD")]
		public delegate uint Delegate(float[][] buffer, uint numSamples);
	}
}
