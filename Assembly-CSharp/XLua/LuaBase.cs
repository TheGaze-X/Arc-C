using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002C4 RID: 708
	[Token(Token = "0x20002C4")]
	public abstract class LuaBase : IDisposable
	{
		// Token: 0x060036CF RID: 14031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036CF")]
		[Address(RVA = "0x3326640", Offset = "0x3325240", VA = "0x183326640")]
		public LuaBase(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x060036D0 RID: 14032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D0")]
		[Address(RVA = "0x3326530", Offset = "0x3325130", VA = "0x183326530", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060036D1 RID: 14033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D1")]
		[Address(RVA = "0x3326280", Offset = "0x3324E80", VA = "0x183326280", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060036D2 RID: 14034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D2")]
		[Address(RVA = "0x33260A0", Offset = "0x3324CA0", VA = "0x1833260A0", Slot = "5")]
		public virtual void Dispose(bool disposeManagedResources)
		{
		}

		// Token: 0x060036D3 RID: 14035 RVA: 0x000164B8 File Offset: 0x000146B8
		[Token(Token = "0x60036D3")]
		[Address(RVA = "0x33262F0", Offset = "0x3324EF0", VA = "0x1833262F0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060036D4 RID: 14036 RVA: 0x000164D0 File Offset: 0x000146D0
		[Token(Token = "0x60036D4")]
		[Address(RVA = "0x33265B0", Offset = "0x33251B0", VA = "0x1833265B0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060036D5 RID: 14037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036D5")]
		[Address(RVA = "0x3326680", Offset = "0x3325280", VA = "0x183326680", Slot = "6")]
		internal virtual void push(IntPtr L)
		{
		}

		// Token: 0x04000D09 RID: 3337
		[Token(Token = "0x4000D09")]
		[FieldOffset(Offset = "0x10")]
		protected bool disposed;

		// Token: 0x04000D0A RID: 3338
		[Token(Token = "0x4000D0A")]
		[FieldOffset(Offset = "0x14")]
		protected readonly int luaReference;

		// Token: 0x04000D0B RID: 3339
		[Token(Token = "0x4000D0B")]
		[FieldOffset(Offset = "0x18")]
		protected readonly LuaEnv luaEnv;
	}
}
