using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000237 RID: 567
	[Token(Token = "0x2000237")]
	internal struct InlinedArray<TValue> : IEnumerable<TValue>, IEnumerable
	{
		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x0600148E RID: 5262 RVA: 0x0000AC50 File Offset: 0x00008E50
		[Token(Token = "0x170005C9")]
		public int Capacity
		{
			[Token(Token = "0x600148E")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600148F")]
		public InlinedArray(TValue value)
		{
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001490")]
		public InlinedArray(TValue firstValue, params TValue[] additionalValues)
		{
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001491")]
		public InlinedArray(IEnumerable<TValue> values)
		{
		}

		// Token: 0x170005CA RID: 1482
		[Token(Token = "0x170005CA")]
		public TValue this[int index]
		{
			[Token(Token = "0x6001492")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001493")]
			set
			{
			}
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001494")]
		public void Clear()
		{
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001495")]
		public void ClearWithCapacity()
		{
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0000AC68 File Offset: 0x00008E68
		[Token(Token = "0x6001496")]
		public InlinedArray<TValue> Clone()
		{
			return default(InlinedArray<TValue>);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001497")]
		public void SetLength(int size)
		{
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001498")]
		public TValue[] ToArray()
		{
			return null;
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001499")]
		public TOther[] ToArray<TOther>(Func<TValue, TOther> mapFunction)
		{
			return null;
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x0000AC80 File Offset: 0x00008E80
		[Token(Token = "0x600149A")]
		public int IndexOf(TValue value)
		{
			return 0;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0000AC98 File Offset: 0x00008E98
		[Token(Token = "0x600149B")]
		public int Append(TValue value)
		{
			return 0;
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		[Token(Token = "0x600149C")]
		public int AppendWithCapacity(TValue value, int capacityIncrement = 10)
		{
			return 0;
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149D")]
		public void AssignWithCapacity(InlinedArray<TValue> values)
		{
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149E")]
		public void Append(IEnumerable<TValue> values)
		{
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149F")]
		public void Remove(TValue value)
		{
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A0")]
		public void RemoveAtWithCapacity(int index)
		{
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A1")]
		public void RemoveAt(int index)
		{
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A2")]
		public void RemoveAtByMovingTailWithCapacity(int index)
		{
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		[Token(Token = "0x60014A3")]
		public bool RemoveByMovingTailWithCapacity(TValue value)
		{
			return default(bool);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[Token(Token = "0x60014A4")]
		public bool Contains(TValue value, IEqualityComparer<TValue> comparer)
		{
			return default(bool);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014A5")]
		public void Merge(InlinedArray<TValue> other)
		{
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60014A6")]
		public IEnumerator<TValue> GetEnumerator()
		{
			return null;
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60014A7")]
		private IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000C02 RID: 3074
		[Token(Token = "0x4000C02")]
		[FieldOffset(Offset = "0x0")]
		public int length;

		// Token: 0x04000C03 RID: 3075
		[Token(Token = "0x4000C03")]
		[FieldOffset(Offset = "0x0")]
		public TValue firstValue;

		// Token: 0x04000C04 RID: 3076
		[Token(Token = "0x4000C04")]
		[FieldOffset(Offset = "0x0")]
		public TValue[] additionalValues;

		// Token: 0x02000238 RID: 568
		[Token(Token = "0x2000238")]
		private struct Enumerator : IEnumerator<TValue>, IEnumerator, IDisposable
		{
			// Token: 0x060014A8 RID: 5288 RVA: 0x0000ACF8 File Offset: 0x00008EF8
			[Token(Token = "0x60014A8")]
			public bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060014A9 RID: 5289 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014A9")]
			public void Reset()
			{
			}

			// Token: 0x170005CB RID: 1483
			// (get) Token: 0x060014AA RID: 5290 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005CB")]
			public TValue Current
			{
				[Token(Token = "0x60014AA")]
				get
				{
					return null;
				}
			}

			// Token: 0x170005CC RID: 1484
			// (get) Token: 0x060014AB RID: 5291 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x170005CC")]
			private object Current
			{
				[Token(Token = "0x60014AB")]
				get
				{
					return null;
				}
			}

			// Token: 0x060014AC RID: 5292 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60014AC")]
			public void Dispose()
			{
			}

			// Token: 0x04000C05 RID: 3077
			[Token(Token = "0x4000C05")]
			[FieldOffset(Offset = "0x0")]
			public InlinedArray<TValue> array;

			// Token: 0x04000C06 RID: 3078
			[Token(Token = "0x4000C06")]
			[FieldOffset(Offset = "0x0")]
			public int index;
		}
	}
}
