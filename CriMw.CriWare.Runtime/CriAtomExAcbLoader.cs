using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public class CriAtomExAcbLoader : CriDisposable
	{
		// Token: 0x06000368 RID: 872 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x36B9060", Offset = "0x36B7C60", VA = "0x1836B9060")]
		public static CriAtomExAcbLoader LoadAcbFileAsync(CriFsBinder binder, string acbPath, string awbPath, bool loadAwbOnMemory = false)
		{
			return null;
		}

		// Token: 0x06000369 RID: 873 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x36B8C70", Offset = "0x36B7870", VA = "0x1836B8C70")]
		public static CriAtomExAcbLoader LoadAcbDataAsync(byte[] acbData, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false)
		{
			return null;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x36B8E90", Offset = "0x36B7A90", VA = "0x1836B8E90")]
		public static CriAtomExAcbLoader LoadAcbDataAsync(IntPtr acbData, int dataSize, CriFsBinder awbBinder, string awbPath, bool loadAwbOnMemory = false)
		{
			return null;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x36B8BF0", Offset = "0x36B77F0", VA = "0x1836B8BF0")]
		public CriAtomExAcbLoader.Status GetStatus()
		{
			return CriAtomExAcbLoader.Status.Stop;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x36B92A0", Offset = "0x36B7EA0", VA = "0x1836B92A0")]
		public CriAtomExAcb MoveAcb()
		{
			return null;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x36B8A20", Offset = "0x36B7620", VA = "0x1836B8A20", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x36B8A80", Offset = "0x36B7680", VA = "0x1836B8A80")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x36B93E0", Offset = "0x36B7FE0", VA = "0x1836B93E0")]
		private CriAtomExAcbLoader(IntPtr handle, GCHandle? dataHandle)
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x36B8B90", Offset = "0x36B7790", VA = "0x1836B8B90", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000371 RID: 881
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x36B94E0", Offset = "0x36B80E0", VA = "0x1836B94E0")]
		[PreserveSig]
		private static extern IntPtr criAtomExAcbLoader_Create([In] ref CriAtomExAcbLoader.LoaderConfig config);

		// Token: 0x06000372 RID: 882
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x36B9570", Offset = "0x36B8170", VA = "0x1836B9570")]
		[PreserveSig]
		private static extern void criAtomExAcbLoader_Destroy(IntPtr acb_loader);

		// Token: 0x06000373 RID: 883
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x36B9750", Offset = "0x36B8350", VA = "0x1836B9750")]
		[PreserveSig]
		private static extern bool criAtomExAcbLoader_LoadAcbFileAsync(IntPtr acb_loader, IntPtr acb_binder, string acb_path, IntPtr awb_binder, string awb_path);

		// Token: 0x06000374 RID: 884
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x36B9670", Offset = "0x36B8270", VA = "0x1836B9670")]
		[PreserveSig]
		private static extern bool criAtomExAcbLoader_LoadAcbDataAsync(IntPtr acb_loader, IntPtr acb_data, int acb_size, IntPtr awb_binder, string awb_path);

		// Token: 0x06000375 RID: 885
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x36B95F0", Offset = "0x36B81F0", VA = "0x1836B95F0")]
		[PreserveSig]
		private static extern CriAtomExAcbLoader.Status criAtomExAcbLoader_GetStatus(IntPtr acb_loader);

		// Token: 0x06000376 RID: 886
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x36B98C0", Offset = "0x36B84C0", VA = "0x1836B98C0")]
		[PreserveSig]
		private static extern bool criAtomExAcbLoader_WaitForCompletion(IntPtr acb_loader);

		// Token: 0x06000377 RID: 887
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x36B9840", Offset = "0x36B8440", VA = "0x1836B9840")]
		[PreserveSig]
		private static extern IntPtr criAtomExAcbLoader_MoveAcbHandle(IntPtr acb_loader);

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GCHandle? gch;

		// Token: 0x02000069 RID: 105
		[Token(Token = "0x2000069")]
		public enum Status
		{
			// Token: 0x040001FA RID: 506
			[Token(Token = "0x40001FA")]
			Stop,
			// Token: 0x040001FB RID: 507
			[Token(Token = "0x40001FB")]
			Loading,
			// Token: 0x040001FC RID: 508
			[Token(Token = "0x40001FC")]
			Complete,
			// Token: 0x040001FD RID: 509
			[Token(Token = "0x40001FD")]
			Error
		}

		// Token: 0x0200006A RID: 106
		[Token(Token = "0x200006A")]
		private struct LoaderConfig
		{
			// Token: 0x040001FE RID: 510
			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool shouldLoadAwbOnMemory;
		}
	}
}
