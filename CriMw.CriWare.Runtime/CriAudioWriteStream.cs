using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000AF RID: 175
	[Token(Token = "0x20000AF")]
	public class CriAudioWriteStream
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060005D6 RID: 1494 RVA: 0x00003914 File Offset: 0x00001B14
		// (set) Token: 0x060005D7 RID: 1495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000066")]
		public IntPtr callbackFunction
		{
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060005D8 RID: 1496 RVA: 0x0000392C File Offset: 0x00001B2C
		// (set) Token: 0x060005D9 RID: 1497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000067")]
		public IntPtr callbackPointer
		{
			[Token(Token = "0x60005D8")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x36F22A0", Offset = "0x36F0EA0", VA = "0x1836F22A0")]
		public CriAudioWriteStream(IntPtr callbackFunction, IntPtr callbackPointer)
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x36F2540", Offset = "0x36F1140", VA = "0x1836F2540")]
		public CriAudioWriteStream(CriAudioWriteStream.Delegate callback, int numChannels, int bufferSize = 256)
		{
		}

		// Token: 0x04000345 RID: 837
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CriAudioWriteStream.InternalDelegate internalDelegate;

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x060005DD RID: 1501
		[Token(Token = "0x20000B0")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate uint InternalDelegate(IntPtr cbobj, IntPtr data, uint numSamples);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x060005E1 RID: 1505
		[Token(Token = "0x20000B1")]
		public delegate uint Delegate(float[][] buffer, uint numSamples);
	}
}
