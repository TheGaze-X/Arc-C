using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	public class CriFsBinder : CriDisposable
	{
		// Token: 0x0600061C RID: 1564 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x36F5850", Offset = "0x36F4450", VA = "0x1836F5850")]
		public CriFsBinder()
		{
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x36F4A30", Offset = "0x36F3630", VA = "0x1836F4A30", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x36F4A90", Offset = "0x36F3690", VA = "0x1836F4A90")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00003A34 File Offset: 0x00001C34
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x36F4420", Offset = "0x36F3020", VA = "0x1836F4420")]
		public uint BindCpk(CriFsBinder srcBinder, string path)
		{
			return 0U;
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00003A4C File Offset: 0x00001C4C
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x36F4580", Offset = "0x36F3180", VA = "0x1836F4580")]
		public uint BindDirectory(CriFsBinder srcBinder, string path)
		{
			return 0U;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00003A64 File Offset: 0x00001C64
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x36F4880", Offset = "0x36F3480", VA = "0x1836F4880")]
		public uint BindFile(CriFsBinder srcBinder, string path)
		{
			return 0U;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00003A7C File Offset: 0x00001C7C
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x36F46E0", Offset = "0x36F32E0", VA = "0x1836F46E0")]
		public uint BindFileSection(CriFsBinder srcBinder, string path, ulong offset, int size, string sectionName)
		{
			return 0U;
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x36F5790", Offset = "0x36F4390", VA = "0x1836F5790")]
		public static void Unbind(uint bindId)
		{
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00003A94 File Offset: 0x00001C94
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x36F5600", Offset = "0x36F4200", VA = "0x1836F5600")]
		public static CriFsBinder.Status GetStatus(uint bindId)
		{
			return CriFsBinder.Status.None;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00003AAC File Offset: 0x00001CAC
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x36F54F0", Offset = "0x36F40F0", VA = "0x1836F54F0")]
		public long GetFileSize(string path)
		{
			return 0L;
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00003AC4 File Offset: 0x00001CC4
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x36F5400", Offset = "0x36F4000", VA = "0x1836F5400")]
		public long GetFileSize(int id)
		{
			return 0L;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00003ADC File Offset: 0x00001CDC
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x36F4F80", Offset = "0x36F3B80", VA = "0x1836F4F80")]
		public bool GetContentsFileInfo(string path, out CriFsBinder.ContentsFileInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x36F51D0", Offset = "0x36F3DD0", VA = "0x1836F51D0")]
		public bool GetContentsFileInfo(int id, out CriFsBinder.ContentsFileInfo info)
		{
			return default(bool);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00003B0C File Offset: 0x00001D0C
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x36F4C00", Offset = "0x36F3800", VA = "0x1836F4C00")]
		public static bool GetContentsFileInfoByIndex(uint bindId, int index, int numFiles, out CriFsBinder.ContentsFileInfo[] info)
		{
			return default(bool);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00003B24 File Offset: 0x00001D24
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x36F49B0", Offset = "0x36F35B0", VA = "0x1836F49B0")]
		public static int GetNumContentsFiles(uint bindId)
		{
			return 0;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x36F56D0", Offset = "0x36F42D0", VA = "0x1836F56D0")]
		public static void SetPriority(uint bindId, int priority)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00003B3C File Offset: 0x00001D3C
		[Token(Token = "0x17000068")]
		public IntPtr nativeHandle
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x36F4BA0", Offset = "0x36F37A0", VA = "0x1836F4BA0", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600062E RID: 1582
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x36F5E10", Offset = "0x36F4A10", VA = "0x1836F5E10")]
		[PreserveSig]
		private static extern uint criFsBinder_Create(out IntPtr binder);

		// Token: 0x0600062F RID: 1583
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x36F5E90", Offset = "0x36F4A90", VA = "0x1836F5E90")]
		[PreserveSig]
		private static extern uint criFsBinder_Destroy(IntPtr binder);

		// Token: 0x06000630 RID: 1584
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x36F5A50", Offset = "0x36F4650", VA = "0x1836F5A50")]
		[PreserveSig]
		private static extern uint criFsBinder_BindCpk(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId);

		// Token: 0x06000631 RID: 1585
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x36F5B30", Offset = "0x36F4730", VA = "0x1836F5B30")]
		[PreserveSig]
		private static extern uint criFsBinder_BindDirectory(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId);

		// Token: 0x06000632 RID: 1586
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x36F5D30", Offset = "0x36F4930", VA = "0x1836F5D30")]
		[PreserveSig]
		private static extern uint criFsBinder_BindFile(IntPtr binder, IntPtr srcBinder, string path, IntPtr work, int worksize, out uint bindId);

		// Token: 0x06000633 RID: 1587
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x36F5C10", Offset = "0x36F4810", VA = "0x1836F5C10")]
		[PreserveSig]
		private static extern uint criFsBinder_BindFileSection(IntPtr binder, IntPtr srcBinder, string path, ulong offset, int size, string sectionName, IntPtr work, int worksize, out uint bindId);

		// Token: 0x06000634 RID: 1588
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x36F6370", Offset = "0x36F4F70", VA = "0x1836F6370")]
		[PreserveSig]
		private static extern int criFsBinder_Unbind(uint bindId);

		// Token: 0x06000635 RID: 1589
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x36F6250", Offset = "0x36F4E50", VA = "0x1836F6250")]
		[PreserveSig]
		private static extern int criFsBinder_GetStatus(uint bindId, out CriFsBinder.Status status);

		// Token: 0x06000636 RID: 1590
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x36F61A0", Offset = "0x36F4DA0", VA = "0x1836F61A0")]
		[PreserveSig]
		private static extern int criFsBinder_GetFileSize(IntPtr binder, string path, out long size);

		// Token: 0x06000637 RID: 1591
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x36F6100", Offset = "0x36F4D00", VA = "0x1836F6100")]
		[PreserveSig]
		private static extern int criFsBinder_GetFileSizeById(IntPtr binder, int id, out long size);

		// Token: 0x06000638 RID: 1592
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x36F62E0", Offset = "0x36F4EE0", VA = "0x1836F62E0")]
		[PreserveSig]
		private static extern int criFsBinder_SetPriority(uint bindId, int priority);

		// Token: 0x06000639 RID: 1593
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x36F6050", Offset = "0x36F4C50", VA = "0x1836F6050")]
		[PreserveSig]
		private static extern int criFsBinder_GetContentsFileInfo(IntPtr binder, string path, IntPtr info);

		// Token: 0x0600063A RID: 1594
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x36F5F10", Offset = "0x36F4B10", VA = "0x1836F5F10")]
		[PreserveSig]
		private static extern int criFsBinder_GetContentsFileInfoById(IntPtr binder, int id, IntPtr info);

		// Token: 0x0600063B RID: 1595
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x36F5FB0", Offset = "0x36F4BB0", VA = "0x1836F5FB0")]
		[PreserveSig]
		private static extern int criFsBinder_GetContentsFileInfoByIndex(uint id, int index, IntPtr info, int num);

		// Token: 0x0600063C RID: 1596
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x36F49B0", Offset = "0x36F35B0", VA = "0x1836F49B0")]
		[PreserveSig]
		private static extern int CRIWARE7B222EA4(uint id);

		// Token: 0x0400035E RID: 862
		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x020000BB RID: 187
		[Token(Token = "0x20000BB")]
		public enum Status
		{
			// Token: 0x04000360 RID: 864
			[Token(Token = "0x4000360")]
			None,
			// Token: 0x04000361 RID: 865
			[Token(Token = "0x4000361")]
			Analyze,
			// Token: 0x04000362 RID: 866
			[Token(Token = "0x4000362")]
			Complete,
			// Token: 0x04000363 RID: 867
			[Token(Token = "0x4000363")]
			Unbind,
			// Token: 0x04000364 RID: 868
			[Token(Token = "0x4000364")]
			Removed,
			// Token: 0x04000365 RID: 869
			[Token(Token = "0x4000365")]
			Invalid,
			// Token: 0x04000366 RID: 870
			[Token(Token = "0x4000366")]
			Error
		}

		// Token: 0x020000BC RID: 188
		[Token(Token = "0x20000BC")]
		public struct ContentsFileInfo
		{
			// Token: 0x0600063D RID: 1597 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x36DEE40", Offset = "0x36DDA40", VA = "0x1836DEE40")]
			public ContentsFileInfo(byte[] data, int startIndex)
			{
			}

			// Token: 0x04000367 RID: 871
			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public readonly string directory;

			// Token: 0x04000368 RID: 872
			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public readonly string fileName;

			// Token: 0x04000369 RID: 873
			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint readSize;

			// Token: 0x0400036A RID: 874
			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint extractSize;

			// Token: 0x0400036B RID: 875
			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ulong offset;

			// Token: 0x0400036C RID: 876
			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int fileId;

			// Token: 0x0400036D RID: 877
			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string userStr;
		}
	}
}
