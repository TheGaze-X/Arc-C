using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000B5 RID: 181
	[Token(Token = "0x20000B5")]
	public class CriFsLoader : CriDisposable
	{
		// Token: 0x060005F6 RID: 1526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x36F9050", Offset = "0x36F7C50", VA = "0x1836F9050")]
		public CriFsLoader()
		{
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x36F8780", Offset = "0x36F7380", VA = "0x1836F8780", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x36F8630", Offset = "0x36F7230", VA = "0x1836F8630")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x36F8D60", Offset = "0x36F7960", VA = "0x1836F8D60")]
		public void Load(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer)
		{
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x36F8960", Offset = "0x36F7560", VA = "0x1836F8960")]
		public void LoadById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer)
		{
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x36F8C00", Offset = "0x36F7800", VA = "0x1836F8C00")]
		public void LoadWithoutDecompression(CriFsBinder binder, string path, long fileOffset, long loadSize, byte[] buffer)
		{
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x36F8AB0", Offset = "0x36F76B0", VA = "0x1836F8AB0")]
		public void LoadWithoutDecompressionById(CriFsBinder binder, int id, long fileOffset, long loadSize, byte[] buffer)
		{
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x36F8520", Offset = "0x36F7120", VA = "0x1836F8520")]
		public void DecompressData(long srcSize, byte[] srcBuffer, long dstSize, byte[] dstBuffer)
		{
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x36F8F90", Offset = "0x36F7B90", VA = "0x1836F8F90")]
		public void Stop()
		{
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000039EC File Offset: 0x00001BEC
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x36F8840", Offset = "0x36F7440", VA = "0x1836F8840")]
		public CriFsLoader.Status GetStatus()
		{
			return CriFsLoader.Status.Stop;
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x36F8EC0", Offset = "0x36F7AC0", VA = "0x1836F8EC0")]
		public void SetReadUnitSize(int unit_size)
		{
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x36F87E0", Offset = "0x36F73E0", VA = "0x1836F87E0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000602 RID: 1538
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x36F9250", Offset = "0x36F7E50", VA = "0x1836F9250")]
		[PreserveSig]
		private static extern int criFsLoader_Create(out IntPtr loader);

		// Token: 0x06000603 RID: 1539
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x36F9390", Offset = "0x36F7F90", VA = "0x1836F9390")]
		[PreserveSig]
		private static extern int criFsLoader_Destroy(IntPtr loader);

		// Token: 0x06000604 RID: 1540
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x36F9730", Offset = "0x36F8330", VA = "0x1836F9730")]
		[PreserveSig]
		private static extern int criFsLoader_Load(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size);

		// Token: 0x06000605 RID: 1541
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x36F94A0", Offset = "0x36F80A0", VA = "0x1836F94A0")]
		[PreserveSig]
		private static extern int criFsLoader_LoadById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size);

		// Token: 0x06000606 RID: 1542
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x36F98B0", Offset = "0x36F84B0", VA = "0x1836F98B0")]
		[PreserveSig]
		private static extern int criFsLoader_Stop(IntPtr loader);

		// Token: 0x06000607 RID: 1543
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x36F9410", Offset = "0x36F8010", VA = "0x1836F9410")]
		[PreserveSig]
		private static extern int criFsLoader_GetStatus(IntPtr loader, out CriFsLoader.Status status);

		// Token: 0x06000608 RID: 1544
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x36F9820", Offset = "0x36F8420", VA = "0x1836F9820")]
		[PreserveSig]
		private static extern int criFsLoader_SetReadUnitSize(IntPtr loader, long unit_size);

		// Token: 0x06000609 RID: 1545
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x36F9640", Offset = "0x36F8240", VA = "0x1836F9640")]
		[PreserveSig]
		private static extern int criFsLoader_LoadWithoutDecompression(IntPtr loader, IntPtr binder, string path, long offset, long load_size, IntPtr buffer, long buffer_size);

		// Token: 0x0600060A RID: 1546
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x36F9570", Offset = "0x36F8170", VA = "0x1836F9570")]
		[PreserveSig]
		private static extern int criFsLoader_LoadWithoutDecompressionById(IntPtr loader, IntPtr binder, int id, long offset, long load_size, IntPtr buffer, long buffer_size);

		// Token: 0x0600060B RID: 1547
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x36F92D0", Offset = "0x36F7ED0", VA = "0x1836F92D0")]
		[PreserveSig]
		private static extern int criFsLoader_DecompressData(IntPtr loader, IntPtr src, long src_size, IntPtr dst, long dst_size);

		// Token: 0x0400034C RID: 844
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x0400034D RID: 845
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GCHandle dstGch;

		// Token: 0x0400034E RID: 846
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GCHandle srcGch;

		// Token: 0x020000B6 RID: 182
		[Token(Token = "0x20000B6")]
		public enum Status
		{
			// Token: 0x04000350 RID: 848
			[Token(Token = "0x4000350")]
			Stop,
			// Token: 0x04000351 RID: 849
			[Token(Token = "0x4000351")]
			Loading,
			// Token: 0x04000352 RID: 850
			[Token(Token = "0x4000352")]
			Complete,
			// Token: 0x04000353 RID: 851
			[Token(Token = "0x4000353")]
			Error
		}
	}
}
