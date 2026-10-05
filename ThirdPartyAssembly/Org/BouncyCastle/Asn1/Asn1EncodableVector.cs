using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200038C RID: 908
	[Token(Token = "0x200038C")]
	public class Asn1EncodableVector : IEnumerable
	{
		// Token: 0x06001F17 RID: 7959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F17")]
		[Address(RVA = "0x530D6E0", Offset = "0x530C2E0", VA = "0x18530D6E0")]
		public static Asn1EncodableVector FromEnumerable(IEnumerable e)
		{
			return null;
		}

		// Token: 0x06001F18 RID: 7960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F18")]
		[Address(RVA = "0x530DAA0", Offset = "0x530C6A0", VA = "0x18530DAA0")]
		public Asn1EncodableVector(params Asn1Encodable[] v)
		{
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F19")]
		[Address(RVA = "0x530D590", Offset = "0x530C190", VA = "0x18530D590")]
		public void Add(params Asn1Encodable[] objs)
		{
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F1A")]
		[Address(RVA = "0x530D4F0", Offset = "0x530C0F0", VA = "0x18530D4F0")]
		public void AddOptional(params Asn1Encodable[] objs)
		{
		}

		// Token: 0x17000415 RID: 1045
		[Token(Token = "0x17000415")]
		public Asn1Encodable this[int index]
		{
			[Token(Token = "0x6001F1B")]
			[Address(RVA = "0x530DB70", Offset = "0x530C770", VA = "0x18530DB70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1C")]
		[Address(RVA = "0x530DA90", Offset = "0x530C690", VA = "0x18530DA90")]
		[Obsolete("Use 'object[index]' syntax instead")]
		public Asn1Encodable Get(int index)
		{
			return null;
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001F1D RID: 7965 RVA: 0x0000EE50 File Offset: 0x0000D050
		[Token(Token = "0x17000416")]
		[Obsolete("Use 'Count' property instead")]
		public int Size
		{
			[Token(Token = "0x6001F1D")]
			[Address(RVA = "0x530DC50", Offset = "0x530C850", VA = "0x18530DC50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001F1E RID: 7966 RVA: 0x0000EE68 File Offset: 0x0000D068
		[Token(Token = "0x17000417")]
		public int Count
		{
			[Token(Token = "0x6001F1E")]
			[Address(RVA = "0x530DB20", Offset = "0x530C720", VA = "0x18530DB20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F1F")]
		[Address(RVA = "0x530DA40", Offset = "0x530C640", VA = "0x18530DA40", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040010DF RID: 4319
		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x10")]
		private IList v;
	}
}
