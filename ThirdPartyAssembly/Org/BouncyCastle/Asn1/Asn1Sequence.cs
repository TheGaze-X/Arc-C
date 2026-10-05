using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000396 RID: 918
	[Token(Token = "0x2000396")]
	public abstract class Asn1Sequence : Asn1Object, IEnumerable
	{
		// Token: 0x06001F51 RID: 8017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F51")]
		[Address(RVA = "0x5311610", Offset = "0x5310210", VA = "0x185311610")]
		public static Asn1Sequence GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F52")]
		[Address(RVA = "0x53119E0", Offset = "0x53105E0", VA = "0x1853119E0")]
		public static Asn1Sequence GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F53")]
		[Address(RVA = "0x5311D80", Offset = "0x5310980", VA = "0x185311D80")]
		protected internal Asn1Sequence(int capacity)
		{
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F54")]
		[Address(RVA = "0x53115C0", Offset = "0x53101C0", VA = "0x1853115C0", Slot = "10")]
		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0x4F23820", Offset = "0x4F22420", VA = "0x184F23820")]
		[Obsolete("Use GetEnumerator() instead")]
		public IEnumerator GetObjects()
		{
			return null;
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001F56 RID: 8022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700041A")]
		public virtual Asn1SequenceParser Parser
		{
			[Token(Token = "0x6001F56")]
			[Address(RVA = "0x5311F20", Offset = "0x5310B20", VA = "0x185311F20", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700041B RID: 1051
		[Token(Token = "0x1700041B")]
		public virtual Asn1Encodable this[int index]
		{
			[Token(Token = "0x6001F57")]
			[Address(RVA = "0x5311E40", Offset = "0x5310A40", VA = "0x185311E40", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F58")]
		[Address(RVA = "0x5311D20", Offset = "0x5310920", VA = "0x185311D20")]
		[Obsolete("Use 'object[index]' syntax instead")]
		public Asn1Encodable GetObjectAt(int index)
		{
			return null;
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001F59 RID: 8025 RVA: 0x0000EF28 File Offset: 0x0000D128
		[Token(Token = "0x1700041C")]
		[Obsolete("Use 'Count' property instead")]
		public int Size
		{
			[Token(Token = "0x6001F59")]
			[Address(RVA = "0xFACF90", Offset = "0xFABB90", VA = "0x180FACF90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001F5A RID: 8026 RVA: 0x0000EF40 File Offset: 0x0000D140
		[Token(Token = "0x1700041D")]
		public virtual int Count
		{
			[Token(Token = "0x6001F5A")]
			[Address(RVA = "0x5311DF0", Offset = "0x53109F0", VA = "0x185311DF0", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x0000EF58 File Offset: 0x0000D158
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x5311210", Offset = "0x530FE10", VA = "0x185311210", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0000EF70 File Offset: 0x0000D170
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x5310F80", Offset = "0x530FB80", VA = "0x185310F80", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x53114B0", Offset = "0x53100B0", VA = "0x1853114B0")]
		private Asn1Encodable GetCurrent(IEnumerator e)
		{
			return null;
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F5E")]
		[Address(RVA = "0x5310F20", Offset = "0x530FB20", VA = "0x185310F20")]
		protected internal void AddObject(Asn1Encodable obj)
		{
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x5311D70", Offset = "0x5310970", VA = "0x185311D70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x040010E4 RID: 4324
		[Token(Token = "0x40010E4")]
		[FieldOffset(Offset = "0x10")]
		private readonly IList seq;

		// Token: 0x02000397 RID: 919
		[Token(Token = "0x2000397")]
		private class Asn1SequenceParserImpl : Asn1SequenceParser, IAsn1Convertible
		{
			// Token: 0x06001F60 RID: 8032 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001F60")]
			[Address(RVA = "0x5310EB0", Offset = "0x530FAB0", VA = "0x185310EB0")]
			public Asn1SequenceParserImpl(Asn1Sequence outer)
			{
			}

			// Token: 0x06001F61 RID: 8033 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F61")]
			[Address(RVA = "0x5310C10", Offset = "0x530F810", VA = "0x185310C10", Slot = "4")]
			public IAsn1Convertible ReadObject()
			{
				return null;
			}

			// Token: 0x06001F62 RID: 8034 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001F62")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
			public Asn1Object ToAsn1Object()
			{
				return null;
			}

			// Token: 0x040010E5 RID: 4325
			[Token(Token = "0x40010E5")]
			[FieldOffset(Offset = "0x10")]
			private readonly Asn1Sequence outer;

			// Token: 0x040010E6 RID: 4326
			[Token(Token = "0x40010E6")]
			[FieldOffset(Offset = "0x18")]
			private readonly int max;

			// Token: 0x040010E7 RID: 4327
			[Token(Token = "0x40010E7")]
			[FieldOffset(Offset = "0x1C")]
			private int index;
		}
	}
}
