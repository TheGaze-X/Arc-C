using System;
using System.Collections;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002E8 RID: 744
	[Token(Token = "0x20002E8")]
	[Serializable]
	public class CookieCollection : ICollection, IEnumerable
	{
		// Token: 0x06001490 RID: 5264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001490")]
		[Address(RVA = "0x504B4A0", Offset = "0x504A0A0", VA = "0x18504B4A0")]
		public CookieCollection()
		{
		}

		// Token: 0x1700045A RID: 1114
		[Token(Token = "0x1700045A")]
		public Cookie this[int index]
		{
			[Token(Token = "0x6001491")]
			[Address(RVA = "0x504B550", Offset = "0x504A150", VA = "0x18504B550")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001492")]
		[Address(RVA = "0x504A790", Offset = "0x5049390", VA = "0x18504A790")]
		public void Add(Cookie cookie)
		{
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001493")]
		[Address(RVA = "0x504A880", Offset = "0x5049480", VA = "0x18504A880")]
		public void Add(CookieCollection cookies)
		{
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x1700045B")]
		public int Count
		{
			[Token(Token = "0x6001494")]
			[Address(RVA = "0x4B16780", Offset = "0x4B15380", VA = "0x184B16780", Slot = "5")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x1700045C")]
		public bool IsSynchronized
		{
			[Token(Token = "0x6001495")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001496 RID: 5270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045D")]
		public object SyncRoot
		{
			[Token(Token = "0x6001496")]
			[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001497")]
		[Address(RVA = "0x504ABE0", Offset = "0x50497E0", VA = "0x18504ABE0", Slot = "4")]
		public void CopyTo(Array array, int index)
		{
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00009B70 File Offset: 0x00007D70
		[Token(Token = "0x6001498")]
		[Address(RVA = "0x504B3A0", Offset = "0x5049FA0", VA = "0x18504B3A0")]
		internal DateTime TimeStamp(CookieCollection.Stamp how)
		{
			return default(DateTime);
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x00009B88 File Offset: 0x00007D88
		[Token(Token = "0x1700045E")]
		internal bool IsOtherVersionSeen
		{
			[Token(Token = "0x6001499")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600149A RID: 5274 RVA: 0x00009BA0 File Offset: 0x00007DA0
		[Token(Token = "0x600149A")]
		[Address(RVA = "0x504AF90", Offset = "0x5049B90", VA = "0x18504AF90")]
		internal int InternalAdd(Cookie cookie, bool isStrict)
		{
			return 0;
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00009BB8 File Offset: 0x00007DB8
		[Token(Token = "0x600149B")]
		[Address(RVA = "0x504AD00", Offset = "0x5049900", VA = "0x18504AD00")]
		internal int IndexOf(Cookie cookie)
		{
			return 0;
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600149C")]
		[Address(RVA = "0x504B350", Offset = "0x5049F50", VA = "0x18504B350")]
		internal void RemoveAt(int idx)
		{
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600149D")]
		[Address(RVA = "0x504AC40", Offset = "0x5049840", VA = "0x18504AC40", Slot = "8")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x04000B44 RID: 2884
		[Token(Token = "0x4000B44")]
		[FieldOffset(Offset = "0x10")]
		internal int m_version;

		// Token: 0x04000B45 RID: 2885
		[Token(Token = "0x4000B45")]
		[FieldOffset(Offset = "0x18")]
		private ArrayList m_list;

		// Token: 0x04000B46 RID: 2886
		[Token(Token = "0x4000B46")]
		[FieldOffset(Offset = "0x20")]
		private DateTime m_TimeStamp;

		// Token: 0x04000B47 RID: 2887
		[Token(Token = "0x4000B47")]
		[FieldOffset(Offset = "0x28")]
		private bool m_has_other_versions;

		// Token: 0x04000B48 RID: 2888
		[Token(Token = "0x4000B48")]
		[FieldOffset(Offset = "0x29")]
		[OptionalField]
		private bool m_IsReadOnly;

		// Token: 0x020002E9 RID: 745
		[Token(Token = "0x20002E9")]
		internal enum Stamp
		{
			// Token: 0x04000B4A RID: 2890
			[Token(Token = "0x4000B4A")]
			Check,
			// Token: 0x04000B4B RID: 2891
			[Token(Token = "0x4000B4B")]
			Set,
			// Token: 0x04000B4C RID: 2892
			[Token(Token = "0x4000B4C")]
			SetToUnused,
			// Token: 0x04000B4D RID: 2893
			[Token(Token = "0x4000B4D")]
			SetToMaxUsed
		}

		// Token: 0x020002EA RID: 746
		[Token(Token = "0x20002EA")]
		private class CookieCollectionEnumerator : IEnumerator
		{
			// Token: 0x0600149E RID: 5278 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600149E")]
			[Address(RVA = "0x504A700", Offset = "0x5049300", VA = "0x18504A700")]
			internal CookieCollectionEnumerator(CookieCollection cookies)
			{
			}

			// Token: 0x1700045F RID: 1119
			// (get) Token: 0x0600149F RID: 5279 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700045F")]
			private object Current
			{
				[Token(Token = "0x600149F")]
				[Address(RVA = "0x504A5F0", Offset = "0x50491F0", VA = "0x18504A5F0", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x060014A0 RID: 5280 RVA: 0x00009BD0 File Offset: 0x00007DD0
			[Token(Token = "0x60014A0")]
			[Address(RVA = "0x504A530", Offset = "0x5049130", VA = "0x18504A530", Slot = "4")]
			private bool MoveNext()
			{
				return default(bool);
			}

			// Token: 0x060014A1 RID: 5281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60014A1")]
			[Address(RVA = "0x504A5E0", Offset = "0x50491E0", VA = "0x18504A5E0", Slot = "6")]
			private void Reset()
			{
			}

			// Token: 0x04000B4E RID: 2894
			[Token(Token = "0x4000B4E")]
			[FieldOffset(Offset = "0x10")]
			private CookieCollection m_cookies;

			// Token: 0x04000B4F RID: 2895
			[Token(Token = "0x4000B4F")]
			[FieldOffset(Offset = "0x18")]
			private int m_count;

			// Token: 0x04000B50 RID: 2896
			[Token(Token = "0x4000B50")]
			[FieldOffset(Offset = "0x1C")]
			private int m_index;

			// Token: 0x04000B51 RID: 2897
			[Token(Token = "0x4000B51")]
			[FieldOffset(Offset = "0x20")]
			private int m_version;
		}
	}
}
