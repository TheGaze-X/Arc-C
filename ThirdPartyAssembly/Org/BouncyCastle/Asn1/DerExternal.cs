using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003B7 RID: 951
	[Token(Token = "0x20003B7")]
	public class DerExternal : Asn1Object
	{
		// Token: 0x06002021 RID: 8225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x531E320", Offset = "0x531CF20", VA = "0x18531E320")]
		public DerExternal(Asn1EncodableVector vector)
		{
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002022")]
		[Address(RVA = "0x531E910", Offset = "0x531D510", VA = "0x18531E910")]
		public DerExternal(DerObjectIdentifier directReference, DerInteger indirectReference, Asn1Object dataValueDescriptor, DerTaggedObject externalData)
		{
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002023")]
		[Address(RVA = "0x531E260", Offset = "0x531CE60", VA = "0x18531E260")]
		public DerExternal(DerObjectIdentifier directReference, DerInteger indirectReference, Asn1Object dataValueDescriptor, int encoding, Asn1Object externalData)
		{
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002024")]
		[Address(RVA = "0x531DE80", Offset = "0x531CA80", VA = "0x18531DE80", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		[Token(Token = "0x6002025")]
		[Address(RVA = "0x531DD80", Offset = "0x531C980", VA = "0x18531DD80", Slot = "8")]
		protected override int Asn1GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
		[Token(Token = "0x6002026")]
		[Address(RVA = "0x531DC60", Offset = "0x531C860", VA = "0x18531DC60", Slot = "7")]
		protected override bool Asn1Equals(Asn1Object asn1Object)
		{
			return default(bool);
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06002027 RID: 8231 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002028 RID: 8232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042C")]
		public Asn1Object DataValueDescriptor
		{
			[Token(Token = "0x6002027")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002028")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600202A RID: 8234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042D")]
		public DerObjectIdentifier DirectReference
		{
			[Token(Token = "0x6002029")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600202A")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
		// (set) Token: 0x0600202C RID: 8236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042E")]
		public int Encoding
		{
			[Token(Token = "0x600202B")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600202C")]
			[Address(RVA = "0x531EA10", Offset = "0x531D610", VA = "0x18531EA10")]
			set
			{
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600202E RID: 8238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700042F")]
		public Asn1Object ExternalContent
		{
			[Token(Token = "0x600202D")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600202E")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			set
			{
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002030 RID: 8240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000430")]
		public DerInteger IndirectReference
		{
			[Token(Token = "0x600202F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002030")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002031")]
		[Address(RVA = "0x531E0D0", Offset = "0x531CCD0", VA = "0x18531E0D0")]
		private static Asn1Object GetObjFromVector(Asn1EncodableVector v, int index)
		{
			return null;
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002032")]
		[Address(RVA = "0x531E1E0", Offset = "0x531CDE0", VA = "0x18531E1E0")]
		private static void WriteEncodable(MemoryStream ms, Asn1Encodable e)
		{
		}

		// Token: 0x0400112F RID: 4399
		[Token(Token = "0x400112F")]
		[FieldOffset(Offset = "0x10")]
		private DerObjectIdentifier directReference;

		// Token: 0x04001130 RID: 4400
		[Token(Token = "0x4001130")]
		[FieldOffset(Offset = "0x18")]
		private DerInteger indirectReference;

		// Token: 0x04001131 RID: 4401
		[Token(Token = "0x4001131")]
		[FieldOffset(Offset = "0x20")]
		private Asn1Object dataValueDescriptor;

		// Token: 0x04001132 RID: 4402
		[Token(Token = "0x4001132")]
		[FieldOffset(Offset = "0x28")]
		private int encoding;

		// Token: 0x04001133 RID: 4403
		[Token(Token = "0x4001133")]
		[FieldOffset(Offset = "0x30")]
		private Asn1Object externalContent;
	}
}
