using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public abstract class ScopedSingleton : IHotfixable
	{
		// Token: 0x0600019A RID: 410 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x54ECC50", Offset = "0x54EB850", VA = "0x1854ECC50")]
		public static void NotifyScopeChanged(string scope)
		{
		}

		// Token: 0x0600019B RID: 411
		[Token(Token = "0x600019B")]
		protected abstract void DisposeBase();

		// Token: 0x0600019C RID: 412 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x54ECD00", Offset = "0x54EB900", VA = "0x1854ECD00")]
		protected ScopedSingleton()
		{
		}

		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 __Hotfix0_NotifyScopeChanged;

		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x0200007D RID: 125
		[Token(Token = "0x200007D")]
		protected class Store : Singleton<ScopedSingleton.Store>, IDisposable
		{
			// Token: 0x0600019D RID: 413 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x54EEAC0", Offset = "0x54ED6C0", VA = "0x1854EEAC0", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0600019E RID: 414 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x54EE940", Offset = "0x54ED540", VA = "0x1854EE940")]
			public void AddInstance(string scope, ScopedSingleton item)
			{
			}

			// Token: 0x0600019F RID: 415 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x54EED80", Offset = "0x54ED980", VA = "0x1854EED80")]
			public void ResetByScope(string scope)
			{
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x54EF0D0", Offset = "0x54EDCD0", VA = "0x1854EF0D0")]
			private Store()
			{
			}

			// Token: 0x0400031E RID: 798
			[Token(Token = "0x400031E")]
			[FieldOffset(Offset = "0x10")]
			private Dictionary<string, ListSet<ScopedSingleton>> m_singletons;

			// Token: 0x0400031F RID: 799
			[Token(Token = "0x400031F")]
			[FieldOffset(Offset = "0x18")]
			private List<ScopedSingleton> m_buffer;

			// Token: 0x04000320 RID: 800
			[Token(Token = "0x4000320")]
			[FieldOffset(Offset = "0x0")]
			private static __XLua_Gen_Delegate1 __Hotfix0_Dispose;

			// Token: 0x04000321 RID: 801
			[Token(Token = "0x4000321")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate5 __Hotfix0_AddInstance;

			// Token: 0x04000322 RID: 802
			[Token(Token = "0x4000322")]
			[FieldOffset(Offset = "0x10")]
			private static __XLua_Gen_Delegate0 __Hotfix0_ResetByScope;

			// Token: 0x04000323 RID: 803
			[Token(Token = "0x4000323")]
			[FieldOffset(Offset = "0x18")]
			private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
		}
	}
}
