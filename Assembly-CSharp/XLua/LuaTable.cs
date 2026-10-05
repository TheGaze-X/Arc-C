using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace XLua
{
	// Token: 0x020002CA RID: 714
	[Token(Token = "0x20002CA")]
	public class LuaTable : LuaBase
	{
		// Token: 0x06003705 RID: 14085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003705")]
		[Address(RVA = "0x3326640", Offset = "0x3325240", VA = "0x183326640")]
		public LuaTable(int reference, LuaEnv luaenv)
		{
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003706")]
		public void Get<TKey, TValue>(TKey key, out TValue value)
		{
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x00016578 File Offset: 0x00014778
		[Token(Token = "0x6003707")]
		public bool ContainsKey<TKey>(TKey key)
		{
			return default(bool);
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003708")]
		public void Set<TKey, TValue>(TKey key, TValue value)
		{
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003709")]
		public T GetInPath<T>(string path)
		{
			return null;
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370A")]
		public void SetInPath<T>(string path, T val)
		{
		}

		// Token: 0x1700014E RID: 334
		[Token(Token = "0x1700014E")]
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[string field]
		{
			[Token(Token = "0x600370B")]
			[Address(RVA = "0x33292F0", Offset = "0x3327EF0", VA = "0x1833292F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600370C")]
			[Address(RVA = "0x33294F0", Offset = "0x33280F0", VA = "0x1833294F0")]
			set
			{
			}
		}

		// Token: 0x1700014F RID: 335
		[Token(Token = "0x1700014F")]
		[Obsolete("use no boxing version: GetInPath/SetInPath Get/Set instead!")]
		public object this[object field]
		{
			[Token(Token = "0x600370D")]
			[Address(RVA = "0x3329340", Offset = "0x3327F40", VA = "0x183329340")]
			get
			{
				return null;
			}
			[Token(Token = "0x600370E")]
			[Address(RVA = "0x3329490", Offset = "0x3328090", VA = "0x183329490")]
			set
			{
			}
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600370F")]
		public void ForEach<TKey, TValue>(Action<TKey, TValue> action)
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06003710 RID: 14096 RVA: 0x00016590 File Offset: 0x00014790
		[Token(Token = "0x17000150")]
		public int Length
		{
			[Token(Token = "0x6003710")]
			[Address(RVA = "0x3329390", Offset = "0x3327F90", VA = "0x183329390")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003711")]
		[Address(RVA = "0x3329090", Offset = "0x3327C90", VA = "0x183329090")]
		[Obsolete("not thread safe!", true)]
		public IEnumerable GetKeys()
		{
			return null;
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003712")]
		[Obsolete("not thread safe!", true)]
		public IEnumerable<T> GetKeys<T>()
		{
			return null;
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003713")]
		[Obsolete("use no boxing version: Get<TKey, TValue> !")]
		public T Get<T>(object key)
		{
			return null;
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003714")]
		public TValue Get<TKey, TValue>(TKey key)
		{
			return null;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003715")]
		public TValue Get<TValue>(string key)
		{
			return null;
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003716")]
		[Address(RVA = "0x3329110", Offset = "0x3327D10", VA = "0x183329110")]
		public void SetMetaTable(LuaTable metaTable)
		{
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003717")]
		public T Cast<T>()
		{
			return null;
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003718")]
		[Address(RVA = "0x3326680", Offset = "0x3325280", VA = "0x183326680", Slot = "6")]
		internal override void push(IntPtr L)
		{
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003719")]
		[Address(RVA = "0x33292A0", Offset = "0x3327EA0", VA = "0x1833292A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
