using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public abstract class ScopedSingleton<T> : ScopedSingleton where T : ScopedSingleton<T>
	{
		// Token: 0x060001A1 RID: 417 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001A1")]
		private static T _CreateInstance()
		{
			return null;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001A2")]
		protected sealed override void DisposeBase()
		{
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000027")]
		public static T instance
		{
			[Token(Token = "0x60001A3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x17000028")]
		public bool hasInstance
		{
			[Token(Token = "0x60001A4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001A5 RID: 421
		[Token(Token = "0x60001A5")]
		protected abstract string DefineScope();

		// Token: 0x060001A6 RID: 422 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001A6")]
		protected virtual void OnDispose()
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60001A7")]
		protected ScopedSingleton()
		{
		}

		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		[FieldOffset(Offset = "0x0")]
		private static T s_instance;
	}
}
