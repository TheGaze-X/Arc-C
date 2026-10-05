using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	public class CriFsInstaller : CriDisposable
	{
		// Token: 0x0600060C RID: 1548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x36F71A0", Offset = "0x36F5DA0", VA = "0x1836F71A0")]
		public CriFsInstaller()
		{
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x36F6CD0", Offset = "0x36F58D0", VA = "0x1836F6CD0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x36F6D30", Offset = "0x36F5930", VA = "0x1836F6D30")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x36F6B10", Offset = "0x36F5710", VA = "0x1836F6B10")]
		public void Copy(CriFsBinder binder, string srcPath, string dstPath, int installBufferSize)
		{
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x36F70E0", Offset = "0x36F5CE0", VA = "0x1836F70E0")]
		public void Stop()
		{
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00003A04 File Offset: 0x00001C04
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x36F7010", Offset = "0x36F5C10", VA = "0x1836F7010")]
		public CriFsInstaller.Status GetStatus()
		{
			return CriFsInstaller.Status.Stop;
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x00003A1C File Offset: 0x00001C1C
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x36F6F40", Offset = "0x36F5B40", VA = "0x1836F6F40")]
		public float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x36F6E70", Offset = "0x36F5A70", VA = "0x1836F6E70")]
		public static void ExecuteMain()
		{
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x36F6EE0", Offset = "0x36F5AE0", VA = "0x1836F6EE0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000615 RID: 1557
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x36F6E70", Offset = "0x36F5A70", VA = "0x1836F6E70")]
		[PreserveSig]
		private static extern int criFsInstaller_ExecuteMain();

		// Token: 0x06000616 RID: 1558
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x36F74A0", Offset = "0x36F60A0", VA = "0x1836F74A0")]
		[PreserveSig]
		private static extern int criFsInstaller_Create(out IntPtr installer, CriFsInstaller.CopyPolicy option);

		// Token: 0x06000617 RID: 1559
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x36F7530", Offset = "0x36F6130", VA = "0x1836F7530")]
		[PreserveSig]
		private static extern int criFsInstaller_Destroy(IntPtr installer);

		// Token: 0x06000618 RID: 1560
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x36F73A0", Offset = "0x36F5FA0", VA = "0x1836F73A0")]
		[PreserveSig]
		private static extern int criFsInstaller_Copy(IntPtr installer, IntPtr binder, string src_path, string dst_path, IntPtr buffer, long buffer_size);

		// Token: 0x06000619 RID: 1561
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x36F76D0", Offset = "0x36F62D0", VA = "0x1836F76D0")]
		[PreserveSig]
		private static extern int criFsInstaller_Stop(IntPtr installer);

		// Token: 0x0600061A RID: 1562
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x36F7640", Offset = "0x36F6240", VA = "0x1836F7640")]
		[PreserveSig]
		private static extern int criFsInstaller_GetStatus(IntPtr installer, out CriFsInstaller.Status status);

		// Token: 0x0600061B RID: 1563
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x36F75B0", Offset = "0x36F61B0", VA = "0x1836F75B0")]
		[PreserveSig]
		private static extern int criFsInstaller_GetProgress(IntPtr installer, out float progress);

		// Token: 0x04000354 RID: 852
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] installBuffer;

		// Token: 0x04000355 RID: 853
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GCHandle installBufferGch;

		// Token: 0x04000356 RID: 854
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IntPtr handle;

		// Token: 0x020000B8 RID: 184
		[Token(Token = "0x20000B8")]
		public enum Status
		{
			// Token: 0x04000358 RID: 856
			[Token(Token = "0x4000358")]
			Stop,
			// Token: 0x04000359 RID: 857
			[Token(Token = "0x4000359")]
			Busy,
			// Token: 0x0400035A RID: 858
			[Token(Token = "0x400035A")]
			Complete,
			// Token: 0x0400035B RID: 859
			[Token(Token = "0x400035B")]
			Error
		}

		// Token: 0x020000B9 RID: 185
		[Token(Token = "0x20000B9")]
		private enum CopyPolicy
		{
			// Token: 0x0400035D RID: 861
			[Token(Token = "0x400035D")]
			Always
		}
	}
}
