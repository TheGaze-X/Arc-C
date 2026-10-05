using System;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002C9 RID: 713
	[Token(Token = "0x20002C9")]
	public class LuaFunction : LuaBase
	{
		// Token: 0x060036FA RID: 14074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FA")]
		[Address(RVA = "0x3326640", Offset = "0x3325240", VA = "0x183326640")]
		public LuaFunction(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FB")]
		public void Action<T>(T a)
		{
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FC")]
		public TResult Func<T, TResult>(T a)
		{
			return null;
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60036FD")]
		public void Action<T1, T2>(T1 a1, T2 a2)
		{
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FE")]
		public TResult Func<T1, T2, TResult>(T1 a1, T2 a2)
		{
			return null;
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036FF")]
		[Address(RVA = "0x3328C70", Offset = "0x3327870", VA = "0x183328C70")]
		public object[] Call(object[] args, Type[] returnTypes)
		{
			return null;
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003700")]
		[Address(RVA = "0x3328EE0", Offset = "0x3327AE0", VA = "0x183328EE0")]
		public object[] Call(params object[] args)
		{
			return null;
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003701")]
		public T Cast<T>()
		{
			return null;
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003702")]
		[Address(RVA = "0x3328EF0", Offset = "0x3327AF0", VA = "0x183328EF0")]
		public void SetEnv(LuaTable env)
		{
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003703")]
		[Address(RVA = "0x3326680", Offset = "0x3325280", VA = "0x183326680", Slot = "6")]
		internal override void push(IntPtr L)
		{
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003704")]
		[Address(RVA = "0x3329040", Offset = "0x3327C40", VA = "0x183329040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
