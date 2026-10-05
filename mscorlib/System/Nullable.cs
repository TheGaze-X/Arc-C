using System;
using System.Runtime.Versioning;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x02000116 RID: 278
	[Token(Token = "0x2000116")]
	[NonVersionable]
	[System.Serializable]
	public struct Nullable<T> where T : struct
	{
		// Token: 0x06000914 RID: 2324 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000914")]
		[NonVersionable]
		public Nullable(T value)
		{
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x1700009F")]
		public bool HasValue
		{
			[Token(Token = "0x6000915")]
			[NonVersionable]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170000A0")]
		public T Value
		{
			[Token(Token = "0x6000916")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000917")]
		[NonVersionable]
		public T GetValueOrDefault()
		{
			return null;
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000918")]
		[NonVersionable]
		public T GetValueOrDefault(T defaultValue)
		{
			return null;
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x6000919")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x00008F88 File Offset: 0x00007188
		[Token(Token = "0x600091A")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600091B")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x600091C")]
		private static object Box(T? o)
		{
			return null;
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x600091D")]
		private static T? Unbox(object o)
		{
			return null;
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x600091E")]
		private static T? UnboxExact(object o)
		{
			return null;
		}

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x0")]
		private readonly bool hasValue;

		// Token: 0x0400045F RID: 1119
		[Token(Token = "0x400045F")]
		[FieldOffset(Offset = "0x0")]
		internal T value;
	}
}
