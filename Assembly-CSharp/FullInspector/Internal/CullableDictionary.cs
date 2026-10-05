using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector.Internal
{
	// Token: 0x02007C7F RID: 31871
	[Token(Token = "0x2007C7F")]
	public class CullableDictionary<TKey, TValue, TDictionary> : ICullableDictionary<TKey, TValue> where TDictionary : IDictionary<TKey, TValue>, new()
	{
		// Token: 0x0602C867 RID: 182375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C867")]
		public CullableDictionary()
		{
		}

		// Token: 0x1700683D RID: 26685
		[Token(Token = "0x1700683D")]
		public TValue this[TKey key]
		{
			[Token(Token = "0x602C868")]
			get
			{
				return null;
			}
			[Token(Token = "0x602C869")]
			set
			{
			}
		}

		// Token: 0x1700683E RID: 26686
		// (get) Token: 0x0602C86A RID: 182378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700683E")]
		public IEnumerable<KeyValuePair<TKey, TValue>> Items
		{
			[Token(Token = "0x602C86A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602C86B RID: 182379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C86B")]
		public void Add(TKey key, TValue value)
		{
		}

		// Token: 0x0602C86C RID: 182380 RVA: 0x000E0898 File Offset: 0x000DEA98
		[Token(Token = "0x602C86C")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default(bool);
		}

		// Token: 0x0602C86D RID: 182381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C86D")]
		public void BeginCullZone()
		{
		}

		// Token: 0x0602C86E RID: 182382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C86E")]
		public void EndCullZone()
		{
		}

		// Token: 0x1700683F RID: 26687
		// (get) Token: 0x0602C86F RID: 182383 RVA: 0x000E08B0 File Offset: 0x000DEAB0
		[Token(Token = "0x1700683F")]
		public bool IsEmpty
		{
			[Token(Token = "0x602C86F")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04040362 RID: 263010
		[Token(Token = "0x4040362")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TDictionary _primary;

		// Token: 0x04040363 RID: 263011
		[Token(Token = "0x4040363")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private TDictionary _culled;

		// Token: 0x04040364 RID: 263012
		[Token(Token = "0x4040364")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _isCulling;
	}
}
