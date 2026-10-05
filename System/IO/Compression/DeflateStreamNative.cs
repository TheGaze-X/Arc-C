using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Mono.Util;

namespace System.IO.Compression
{
	// Token: 0x02000279 RID: 633
	[Token(Token = "0x2000279")]
	internal class DeflateStreamNative
	{
		// Token: 0x060011D1 RID: 4561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private DeflateStreamNative()
		{
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011D2")]
		[Address(RVA = "0x519C5D0", Offset = "0x519B1D0", VA = "0x18519C5D0")]
		public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip)
		{
			return null;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D3")]
		[Address(RVA = "0x519C900", Offset = "0x519B500", VA = "0x18519C900", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D4")]
		[Address(RVA = "0x519C7E0", Offset = "0x519B3E0", VA = "0x18519C7E0")]
		public void Dispose(bool disposing)
		{
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D5")]
		[Address(RVA = "0x519C960", Offset = "0x519B560", VA = "0x18519C960")]
		public void Flush()
		{
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x00008B20 File Offset: 0x00006D20
		[Token(Token = "0x60011D6")]
		[Address(RVA = "0x519CA80", Offset = "0x519B680", VA = "0x18519CA80")]
		public int ReadZStream(IntPtr buffer, int length)
		{
			return 0;
		}

		// Token: 0x060011D7 RID: 4567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011D7")]
		[Address(RVA = "0x519D070", Offset = "0x519BC70", VA = "0x18519D070")]
		public void WriteZStream(IntPtr buffer, int length)
		{
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00008B38 File Offset: 0x00006D38
		[Token(Token = "0x60011D8")]
		[Address(RVA = "0x519CBC0", Offset = "0x519B7C0", VA = "0x18519CBC0")]
		[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
		private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data)
		{
			return 0;
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00008B50 File Offset: 0x00006D50
		[Token(Token = "0x60011D9")]
		[Address(RVA = "0x519CCA0", Offset = "0x519B8A0", VA = "0x18519CCA0")]
		private int UnmanagedRead(IntPtr buffer, int length)
		{
			return 0;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00008B68 File Offset: 0x00006D68
		[Token(Token = "0x60011DA")]
		[Address(RVA = "0x519CF90", Offset = "0x519BB90", VA = "0x18519CF90")]
		[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
		private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data)
		{
			return 0;
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x60011DB")]
		[Address(RVA = "0x519CE10", Offset = "0x519BA10", VA = "0x18519CE10")]
		private int UnmanagedWrite(IntPtr buffer, int length)
		{
			return 0;
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60011DC")]
		[Address(RVA = "0x519C3B0", Offset = "0x519AFB0", VA = "0x18519C3B0")]
		private void CheckResult(int result, string where)
		{
		}

		// Token: 0x060011DD RID: 4573
		[Token(Token = "0x60011DD")]
		[Address(RVA = "0x519C510", Offset = "0x519B110", VA = "0x18519C510")]
		[PreserveSig]
		private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data);

		// Token: 0x060011DE RID: 4574
		[Token(Token = "0x60011DE")]
		[Address(RVA = "0x519C500", Offset = "0x519B100", VA = "0x18519C500")]
		[PreserveSig]
		private static extern int CloseZStream(IntPtr stream);

		// Token: 0x060011DF RID: 4575
		[Token(Token = "0x60011DF")]
		[Address(RVA = "0x519CA10", Offset = "0x519B610", VA = "0x18519CA10")]
		[PreserveSig]
		private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream);

		// Token: 0x060011E0 RID: 4576
		[Token(Token = "0x60011E0")]
		[Address(RVA = "0x519CB40", Offset = "0x519B740", VA = "0x18519CB40")]
		[PreserveSig]
		private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length);

		// Token: 0x060011E1 RID: 4577
		[Token(Token = "0x60011E1")]
		[Address(RVA = "0x519D130", Offset = "0x519BD30", VA = "0x18519D130")]
		[PreserveSig]
		private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length);

		// Token: 0x040008BD RID: 2237
		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DeflateStreamNative.UnmanagedReadOrWrite feeder;

		// Token: 0x040008BE RID: 2238
		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Stream base_stream;

		// Token: 0x040008BF RID: 2239
		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DeflateStreamNative.SafeDeflateStreamHandle z_stream;

		// Token: 0x040008C0 RID: 2240
		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GCHandle data;

		// Token: 0x040008C1 RID: 2241
		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool disposed;

		// Token: 0x040008C2 RID: 2242
		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private byte[] io_buffer;

		// Token: 0x040008C3 RID: 2243
		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Exception last_error;

		// Token: 0x0200027A RID: 634
		// (Invoke) Token: 0x060011E3 RID: 4579
		[Token(Token = "0x200027A")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate int UnmanagedReadOrWrite(IntPtr buffer, int length, IntPtr data);

		// Token: 0x0200027B RID: 635
		[Token(Token = "0x200027B")]
		private sealed class SafeDeflateStreamHandle : SafeHandle
		{
			// Token: 0x170003B2 RID: 946
			// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00008B98 File Offset: 0x00006D98
			[Token(Token = "0x170003B2")]
			public override bool IsInvalid
			{
				[Token(Token = "0x60011E4")]
				[Address(RVA = "0x51B4D10", Offset = "0x51B3910", VA = "0x1851B4D10", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x060011E5 RID: 4581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60011E5")]
			[Address(RVA = "0x51B4CC0", Offset = "0x51B38C0", VA = "0x1851B4CC0")]
			private SafeDeflateStreamHandle()
			{
			}

			// Token: 0x060011E6 RID: 4582 RVA: 0x00008BB0 File Offset: 0x00006DB0
			[Token(Token = "0x60011E6")]
			[Address(RVA = "0x51B4CA0", Offset = "0x51B38A0", VA = "0x1851B4CA0", Slot = "7")]
			protected override bool ReleaseHandle()
			{
				return default(bool);
			}
		}
	}
}
