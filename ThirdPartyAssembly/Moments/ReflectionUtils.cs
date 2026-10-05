using System;
using System.Linq.Expressions;
using System.Reflection;
using Il2CppDummyDll;

namespace Moments
{
	// Token: 0x020000F5 RID: 245
	[Token(Token = "0x20000F5")]
	public class ReflectionUtils<T> where T : class, new()
	{
		// Token: 0x06000416 RID: 1046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000416")]
		public ReflectionUtils(T instance)
		{
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000417")]
		public string GetFieldName<U>(Expression<Func<T, U>> fieldAccess)
		{
			return null;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000418")]
		public FieldInfo GetField(string fieldName)
		{
			return null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000419")]
		public A GetAttribute<A>(FieldInfo field) where A : Attribute
		{
			return null;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041A")]
		public void ConstrainMin<U>(Expression<Func<T, U>> fieldAccess, float value)
		{
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041B")]
		public void ConstrainMin<U>(Expression<Func<T, U>> fieldAccess, int value)
		{
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041C")]
		public void ConstrainRange<U>(Expression<Func<T, U>> fieldAccess, float value)
		{
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600041D")]
		public void ConstrainRange<U>(Expression<Func<T, U>> fieldAccess, int value)
		{
		}

		// Token: 0x04000569 RID: 1385
		[Token(Token = "0x4000569")]
		[FieldOffset(Offset = "0x0")]
		private readonly T _Instance;
	}
}
