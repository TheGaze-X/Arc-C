using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02001035 RID: 4149
	[Token(Token = "0x2001035")]
	[Serializable]
	public struct Undefinable<T> : IUndefinable
	{
		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06006D97 RID: 28055 RVA: 0x00031D40 File Offset: 0x0002FF40
		// (set) Token: 0x06006D98 RID: 28056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D16")]
		[JsonIgnore]
		public bool FBOnly_m_defined
		{
			[Token(Token = "0x6006D97")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006D98")]
			set
			{
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06006D99 RID: 28057 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D9A RID: 28058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D17")]
		[JsonIgnore]
		public T FBOnly_m_value
		{
			[Token(Token = "0x6006D99")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D9A")]
			set
			{
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06006D9B RID: 28059 RVA: 0x00031D58 File Offset: 0x0002FF58
		// (set) Token: 0x06006D9C RID: 28060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D18")]
		[JsonIgnore]
		public bool isDefined
		{
			[Token(Token = "0x6006D9B")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6006D9C")]
			set
			{
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06006D9D RID: 28061 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06006D9E RID: 28062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000D19")]
		[JsonIgnore]
		public T value
		{
			[Token(Token = "0x6006D9D")]
			get
			{
				return null;
			}
			[Token(Token = "0x6006D9E")]
			set
			{
			}
		}

		// Token: 0x06006D9F RID: 28063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D9F")]
		public object GetValue()
		{
			return null;
		}

		// Token: 0x06006DA0 RID: 28064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006DA0")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006DA1 RID: 28065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006DA1")]
		public Undefinable(bool defined, T value)
		{
		}

		// Token: 0x06006DA2 RID: 28066 RVA: 0x00031D70 File Offset: 0x0002FF70
		[Token(Token = "0x6006DA2")]
		public static implicit operator Undefinable<T>(T value)
		{
			return default(Undefinable<T>);
		}

		// Token: 0x04005823 RID: 22563
		[Token(Token = "0x4005823")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Undefinable<T> DEFAULT;

		// Token: 0x04005824 RID: 22564
		[Token(Token = "0x4005824")]
		[FieldOffset(Offset = "0x0")]
		[JsonProperty]
		private bool m_defined;

		// Token: 0x04005825 RID: 22565
		[Token(Token = "0x4005825")]
		[FieldOffset(Offset = "0x0")]
		[JsonProperty]
		private T m_value;
	}
}
