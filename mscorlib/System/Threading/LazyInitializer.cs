using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x020001ED RID: 493
	[Token(Token = "0x20001ED")]
	public static class LazyInitializer
	{
		// Token: 0x0600119B RID: 4507 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600119B")]
		public static T EnsureInitialized<T>(ref T target) where T : class
		{
			return null;
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600119C")]
		private static T EnsureInitializedCore<T>(ref T target) where T : class
		{
			return null;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600119D")]
		public static T EnsureInitialized<T>(ref T target, System.Func<T> valueFactory) where T : class
		{
			return null;
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600119E")]
		private static T EnsureInitializedCore<T>(ref T target, System.Func<T> valueFactory) where T : class
		{
			return null;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600119F")]
		public static T EnsureInitialized<T>(ref T target, ref object syncLock, System.Func<T> valueFactory) where T : class
		{
			return null;
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60011A0")]
		private static T EnsureInitializedCore<T>(ref T target, ref object syncLock, System.Func<T> valueFactory) where T : class
		{
			return null;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60011A1")]
		[Address(RVA = "0x4D54EB0", Offset = "0x4D53AB0", VA = "0x184D54EB0")]
		private static object EnsureLockInitialized(ref object syncLock)
		{
			return null;
		}
	}
}
