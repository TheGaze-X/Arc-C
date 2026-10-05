using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public class CriAtomEx3dRegion : CriDisposable
	{
		// Token: 0x06000323 RID: 803 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x36B5720", Offset = "0x36B4320", VA = "0x1836B5720")]
		public CriAtomEx3dRegion()
		{
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x36B54E0", Offset = "0x36B40E0", VA = "0x1836B54E0", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000325")]
		[Address(RVA = "0x36B54F0", Offset = "0x36B40F0", VA = "0x1836B54F0")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x36B5640", Offset = "0x36B4240", VA = "0x1836B5640", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00002C6C File Offset: 0x00000E6C
		[Token(Token = "0x6000327")]
		[Address(RVA = "0x36B56A0", Offset = "0x36B42A0", VA = "0x1836B56A0")]
		public bool IsDestroyable()
		{
			return default(bool);
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00002C84 File Offset: 0x00000E84
		[Token(Token = "0x17000047")]
		public IntPtr nativeHandle
		{
			[Token(Token = "0x6000328")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x02000065 RID: 101
		[Token(Token = "0x2000065")]
		public struct Config
		{
			// Token: 0x040001F4 RID: 500
			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int reserved;
		}

		// Token: 0x02000066 RID: 102
		[Token(Token = "0x2000066")]
		private static class UnsafeNativeMethods
		{
			// Token: 0x06000329 RID: 809
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x36DD1A0", Offset = "0x36DBDA0", VA = "0x1836DD1A0")]
			[PreserveSig]
			internal static extern IntPtr criAtomEx3dRegion_Create(ref CriAtomEx3dRegion.Config config, IntPtr work, int work_size);

			// Token: 0x0600032A RID: 810
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x36DD240", Offset = "0x36DBE40", VA = "0x1836DD240")]
			[PreserveSig]
			internal static extern void criAtomEx3dRegion_Destroy(IntPtr ex_3d_region);

			// Token: 0x0600032B RID: 811
			[Token(Token = "0x600032B")]
			[Address(RVA = "0x36DD2C0", Offset = "0x36DBEC0", VA = "0x1836DD2C0")]
			[PreserveSig]
			internal static extern bool criAtomEx3dRegion_IsDestroyable(IntPtr ex3dRegion);
		}
	}
}
