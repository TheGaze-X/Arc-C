using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	// Token: 0x020000CE RID: 206
	[Token(Token = "0x20000CE")]
	[Preserve]
	public struct JEnumerable<T> : IJEnumerable<T>, IEnumerable<T>, IEnumerable where T : JToken
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007A6")]
		public JEnumerable(IEnumerable<T> enumerable)
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A7")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A8")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x17000176 RID: 374
		[Token(Token = "0x17000176")]
		public IJEnumerable<JToken> this[object key]
		{
			[Token(Token = "0x60007A9")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x60007AA")]
		public bool Equals(JEnumerable<T> other)
		{
			return default(bool);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x60007AB")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x60007AC")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x04000328 RID: 808
		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0x0")]
		public static readonly JEnumerable<T> Empty;

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0x0")]
		private readonly IEnumerable<T> _enumerable;
	}
}
