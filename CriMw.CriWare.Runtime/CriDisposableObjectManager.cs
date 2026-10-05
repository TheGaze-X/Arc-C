using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000114 RID: 276
	[Token(Token = "0x2000114")]
	public static class CriDisposableObjectManager
	{
		// Token: 0x06000818 RID: 2072 RVA: 0x0000434C File Offset: 0x0000254C
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x36F2F30", Offset = "0x36F1B30", VA = "0x1836F2F30")]
		private static int SearchForDisposable(CriDisposable disposable)
		{
			return 0;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x36F2CC0", Offset = "0x36F18C0", VA = "0x1836F2CC0")]
		public static void Register(CriDisposable disposable, CriDisposableObjectManager.ModuleType type)
		{
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00004364 File Offset: 0x00002564
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x36F3120", Offset = "0x36F1D20", VA = "0x1836F3120")]
		public static bool Unregister(CriDisposable disposable)
		{
			return default(bool);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0000437C File Offset: 0x0000257C
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x36F2C70", Offset = "0x36F1870", VA = "0x1836F2C70")]
		public static bool IsDisposed(CriDisposable disposable)
		{
			return default(bool);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x36F27A0", Offset = "0x36F13A0", VA = "0x1836F27A0")]
		public static void CallOnModuleFinalization(CriDisposableObjectManager.ModuleType type)
		{
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00004394 File Offset: 0x00002594
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x36F2B80", Offset = "0x36F1780", VA = "0x1836F2B80")]
		private static int GetNextWithType(CriDisposableObjectManager.ModuleType type)
		{
			return 0;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x36F27F0", Offset = "0x36F13F0", VA = "0x1836F27F0")]
		public static void DisposeAll(CriDisposableObjectManager.ModuleType type)
		{
		}

		// Token: 0x040004F5 RID: 1269
		[Token(Token = "0x40004F5")]
		[FieldOffset(Offset = "0x0")]
		private static List<CriDisposableObjectManager.ObjectRef> refList;

		// Token: 0x02000115 RID: 277
		[Token(Token = "0x2000115")]
		public enum ModuleType
		{
			// Token: 0x040004F7 RID: 1271
			[Token(Token = "0x40004F7")]
			Atom,
			// Token: 0x040004F8 RID: 1272
			[Token(Token = "0x40004F8")]
			AtomMic,
			// Token: 0x040004F9 RID: 1273
			[Token(Token = "0x40004F9")]
			Fs,
			// Token: 0x040004FA RID: 1274
			[Token(Token = "0x40004FA")]
			FsWeb,
			// Token: 0x040004FB RID: 1275
			[Token(Token = "0x40004FB")]
			Mana,
			// Token: 0x040004FC RID: 1276
			[Token(Token = "0x40004FC")]
			Lips,
			// Token: 0x040004FD RID: 1277
			[Token(Token = "0x40004FD")]
			Vip,
			// Token: 0x040004FE RID: 1278
			[Token(Token = "0x40004FE")]
			Rtc
		}

		// Token: 0x02000116 RID: 278
		[Token(Token = "0x2000116")]
		public struct ObjectRef
		{
			// Token: 0x06000820 RID: 2080 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x3708580", Offset = "0x3707180", VA = "0x183708580")]
			public ObjectRef(Guid _guid, CriDisposable _disposable, CriDisposableObjectManager.ModuleType _type)
			{
			}

			// Token: 0x040004FF RID: 1279
			[Token(Token = "0x40004FF")]
			[FieldOffset(Offset = "0x0")]
			public Guid guid;

			// Token: 0x04000500 RID: 1280
			[Token(Token = "0x4000500")]
			[FieldOffset(Offset = "0x10")]
			public CriDisposableObjectManager.ModuleType type;

			// Token: 0x04000501 RID: 1281
			[Token(Token = "0x4000501")]
			[FieldOffset(Offset = "0x18")]
			public CriDisposable disposable;
		}
	}
}
