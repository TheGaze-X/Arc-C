using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000399 RID: 921
	[Token(Token = "0x2000399")]
	public abstract class Asn1Set : Asn1Object, IEnumerable
	{
		// Token: 0x06001F64 RID: 8036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x5312FA0", Offset = "0x5311BA0", VA = "0x185312FA0")]
		public static Asn1Set GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x53129C0", Offset = "0x53115C0", VA = "0x1853129C0")]
		public static Asn1Set GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x5313AA0", Offset = "0x53126A0", VA = "0x185313AA0")]
		protected internal Asn1Set(int capacity)
		{
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x5312970", Offset = "0x5311570", VA = "0x185312970", Slot = "10")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x4F23820", Offset = "0x4F22420", VA = "0x184F23820")]
		[Obsolete("Use GetEnumerator() instead")]
		public IEnumerator GetObjects()
		{
			return null;
		}

		// Token: 0x1700041E RID: 1054
		[Token(Token = "0x1700041E")]
		public virtual Asn1Encodable this[int index]
		{
			[Token(Token = "0x6001F69")]
			[Address(RVA = "0x5313B60", Offset = "0x5312760", VA = "0x185313B60", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6A")]
		[Address(RVA = "0x5313370", Offset = "0x5311F70", VA = "0x185313370")]
		[Obsolete("Use 'object[index]' syntax instead")]
		public Asn1Encodable GetObjectAt(int index)
		{
			return null;
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001F6B RID: 8043 RVA: 0x0000EF88 File Offset: 0x0000D188
		[Token(Token = "0x1700041F")]
		[Obsolete("Use 'Count' property instead")]
		public int Size
		{
			[Token(Token = "0x6001F6B")]
			[Address(RVA = "0x4F242E0", Offset = "0x4F22EE0", VA = "0x184F242E0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x0000EFA0 File Offset: 0x0000D1A0
		[Token(Token = "0x17000420")]
		public virtual int Count
		{
			[Token(Token = "0x6001F6C")]
			[Address(RVA = "0x5313B10", Offset = "0x5312710", VA = "0x185313B10", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F6D")]
		[Address(RVA = "0x5313960", Offset = "0x5312560", VA = "0x185313960", Slot = "13")]
		public virtual Asn1Encodable[] ToArray()
		{
			return null;
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000421")]
		public Asn1SetParser Parser
		{
			[Token(Token = "0x6001F6E")]
			[Address(RVA = "0x5313C40", Offset = "0x5312840", VA = "0x185313C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0x53125C0", Offset = "0x53111C0", VA = "0x1853125C0", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x0000EFD0 File Offset: 0x0000D1D0
		[Token(Token = "0x6001F70")]
		[Address(RVA = "0x5312330", Offset = "0x5310F30", VA = "0x185312330", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F71")]
		[Address(RVA = "0x5312860", Offset = "0x5311460", VA = "0x185312860")]
		private Asn1Encodable GetCurrent(IEnumerator e)
		{
			return null;
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F72")]
		[Address(RVA = "0x53133C0", Offset = "0x5311FC0", VA = "0x1853133C0")]
		protected internal void Sort()
		{
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x53122D0", Offset = "0x5310ED0", VA = "0x1853122D0")]
		protected internal void AddObject(Asn1Encodable obj)
		{
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x5311D70", Offset = "0x5310970", VA = "0x185311D70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040010E8 RID: 4328
		[Token(Token = "0x40010E8")]
		[FieldOffset(Offset = "0x10")]
		private readonly IList _set;

		// Token: 0x0200039A RID: 922
		[Token(Token = "0x200039A")]
		private class Asn1SetParserImpl : Asn1SetParser, IAsn1Convertible
		{
			// Token: 0x06001F75 RID: 8053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F75")]
			[Address(RVA = "0x5312260", Offset = "0x5310E60", VA = "0x185312260")]
			public Asn1SetParserImpl(Asn1Set outer)
			{
			}

			// Token: 0x06001F76 RID: 8054 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F76")]
			[Address(RVA = "0x5311FC0", Offset = "0x5310BC0", VA = "0x185311FC0", Slot = "4")]
			public IAsn1Convertible ReadObject()
			{
				return null;
			}

			// Token: 0x06001F77 RID: 8055 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F77")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
			public virtual Asn1Object ToAsn1Object()
			{
				return null;
			}

			// Token: 0x040010E9 RID: 4329
			[Token(Token = "0x40010E9")]
			[FieldOffset(Offset = "0x10")]
			private readonly Asn1Set outer;

			// Token: 0x040010EA RID: 4330
			[Token(Token = "0x40010EA")]
			[FieldOffset(Offset = "0x18")]
			private readonly int max;

			// Token: 0x040010EB RID: 4331
			[Token(Token = "0x40010EB")]
			[FieldOffset(Offset = "0x1C")]
			private int index;
		}

		// Token: 0x0200039B RID: 923
		[Token(Token = "0x200039B")]
		private class DerComparer : IComparer
		{
			// Token: 0x06001F78 RID: 8056 RVA: 0x0000EFE8 File Offset: 0x0000D1E8
			[Token(Token = "0x6001F78")]
			[Address(RVA = "0x531D180", Offset = "0x531BD80", VA = "0x18531D180", Slot = "4")]
			public int Compare(object x, object y)
			{
				return 0;
			}

			// Token: 0x06001F79 RID: 8057 RVA: 0x0000F000 File Offset: 0x0000D200
			[Token(Token = "0x6001F79")]
			[Address(RVA = "0x531D140", Offset = "0x531BD40", VA = "0x18531D140")]
			private bool AllZeroesFrom(byte[] bs, int pos)
			{
				return default(bool);
			}

			// Token: 0x06001F7A RID: 8058 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F7A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DerComparer()
			{
			}
		}
	}
}
