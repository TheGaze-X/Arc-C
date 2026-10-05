using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000094 RID: 148
	[Token(Token = "0x2000094")]
	public class CriAtomExSoundObject : CriDisposable
	{
		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00003794 File Offset: 0x00001994
		[Token(Token = "0x1700005B")]
		public IntPtr nativeHandle
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x36EFE40", Offset = "0x36EEA40", VA = "0x1836EFE40")]
		public CriAtomExSoundObject(bool enableVoiceLimitScope, bool enableCategoryCueLimitScope)
		{
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x36EFD00", Offset = "0x36EE900", VA = "0x1836EFD00", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x36EFB40", Offset = "0x36EE740", VA = "0x1836EFB40")]
		public void AddPlayer(CriAtomExPlayer player)
		{
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x36EFC60", Offset = "0x36EE860", VA = "0x1836EFC60")]
		public void DeletePlayer(CriAtomExPlayer player)
		{
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x36EFBE0", Offset = "0x36EE7E0", VA = "0x1836EFBE0")]
		public void DeleteAllPlayers()
		{
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x36C1240", Offset = "0x36BFE40", VA = "0x1836C1240", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x0600058A RID: 1418
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x36F0090", Offset = "0x36EEC90", VA = "0x1836F0090")]
		[PreserveSig]
		private static extern IntPtr criAtomExSoundObject_Create(ref CriAtomExSoundObject.Config config, IntPtr work, int work_size);

		// Token: 0x0600058B RID: 1419
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x36F0270", Offset = "0x36EEE70", VA = "0x1836F0270")]
		[PreserveSig]
		private static extern void criAtomExSoundObject_Destroy(IntPtr soundObject);

		// Token: 0x0600058C RID: 1420
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x36F0000", Offset = "0x36EEC00", VA = "0x1836F0000")]
		[PreserveSig]
		private static extern void criAtomExSoundObject_AddPlayer(IntPtr soundObject, IntPtr player);

		// Token: 0x0600058D RID: 1421
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x36F01E0", Offset = "0x36EEDE0", VA = "0x1836F01E0")]
		[PreserveSig]
		private static extern void criAtomExSoundObject_DeletePlayer(IntPtr soundObject, IntPtr player);

		// Token: 0x0600058E RID: 1422
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x36F0160", Offset = "0x36EED60", VA = "0x1836F0160")]
		[PreserveSig]
		private static extern void criAtomExSoundObject_DeleteAllPlayers(IntPtr soundObject);

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IntPtr handle;

		// Token: 0x02000095 RID: 149
		[Token(Token = "0x2000095")]
		private struct Config
		{
			// Token: 0x040002F7 RID: 759
			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool enableVoiceLimitScope;

			// Token: 0x040002F8 RID: 760
			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool enableCategoryCueLimitScope;
		}
	}
}
