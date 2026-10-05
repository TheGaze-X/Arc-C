using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Mono.Util;

namespace Mono.Btls
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	internal class MonoBtlsBioMono : MonoBtlsBio
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x4F543A0", Offset = "0x4F52FA0", VA = "0x184F543A0")]
		public MonoBtlsBioMono(IMonoBtlsBioMono backend)
		{
		}

		// Token: 0x060001A2 RID: 418
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x4F54960", Offset = "0x4F53560", VA = "0x184F54960")]
		[PreserveSig]
		private static extern IntPtr mono_btls_bio_mono_new();

		// Token: 0x060001A3 RID: 419
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x4F548A0", Offset = "0x4F534A0", VA = "0x184F548A0")]
		[PreserveSig]
		private static extern void mono_btls_bio_mono_initialize(IntPtr handle, IntPtr instance, IntPtr readFunc, IntPtr writeFunc, IntPtr controlFunc);

		// Token: 0x060001A4 RID: 420 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x4F53B40", Offset = "0x4F52740", VA = "0x184F53B40")]
		private long Control(MonoBtlsBioMono.ControlCommand command, long arg)
		{
			return 0L;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x4F53E60", Offset = "0x4F52A60", VA = "0x184F53E60")]
		private int OnRead(IntPtr data, int dataLength, out int wantMore)
		{
			return 0;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x4F53BE0", Offset = "0x4F527E0", VA = "0x184F53BE0")]
		[MonoPInvokeCallback(typeof(MonoBtlsBioMono.BioReadFunc))]
		private static int OnRead(IntPtr instance, IntPtr data, int dataLength, out int wantMore)
		{
			return 0;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x4F53FF0", Offset = "0x4F52BF0", VA = "0x184F53FF0")]
		private int OnWrite(IntPtr data, int dataLength)
		{
			return 0;
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x4F54150", Offset = "0x4F52D50", VA = "0x184F54150")]
		[MonoPInvokeCallback(typeof(MonoBtlsBioMono.BioWriteFunc))]
		private static int OnWrite(IntPtr instance, IntPtr data, int dataLength)
		{
			return 0;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x4F53990", Offset = "0x4F52590", VA = "0x184F53990")]
		[MonoPInvokeCallback(typeof(MonoBtlsBioMono.BioControlFunc))]
		private static long Control(IntPtr instance, MonoBtlsBioMono.ControlCommand command, long arg)
		{
			return 0L;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x4F538E0", Offset = "0x4F524E0", VA = "0x184F538E0", Slot = "5")]
		protected override void Close()
		{
		}

		// Token: 0x04000111 RID: 273
		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GCHandle handle;

		// Token: 0x04000112 RID: 274
		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr instance;

		// Token: 0x04000113 RID: 275
		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MonoBtlsBioMono.BioReadFunc readFunc;

		// Token: 0x04000114 RID: 276
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MonoBtlsBioMono.BioWriteFunc writeFunc;

		// Token: 0x04000115 RID: 277
		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private MonoBtlsBioMono.BioControlFunc controlFunc;

		// Token: 0x04000116 RID: 278
		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IntPtr readFuncPtr;

		// Token: 0x04000117 RID: 279
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IntPtr writeFuncPtr;

		// Token: 0x04000118 RID: 280
		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IntPtr controlFuncPtr;

		// Token: 0x04000119 RID: 281
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IMonoBtlsBioMono backend;

		// Token: 0x0200006E RID: 110
		[Token(Token = "0x200006E")]
		private enum ControlCommand
		{
			// Token: 0x0400011B RID: 283
			[Token(Token = "0x400011B")]
			Flush = 1
		}

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x060001AC RID: 428
		[Token(Token = "0x200006F")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int BioReadFunc(IntPtr bio, IntPtr data, int dataLength, out int wantMore);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x060001AE RID: 430
		[Token(Token = "0x2000070")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int BioWriteFunc(IntPtr bio, IntPtr data, int dataLength);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x060001B0 RID: 432
		[Token(Token = "0x2000071")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate long BioControlFunc(IntPtr bio, MonoBtlsBioMono.ControlCommand command, long arg);
	}
}
