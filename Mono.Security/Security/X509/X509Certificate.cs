using System;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x02000011 RID: 17
	[Token(Token = "0x2000011")]
	public class X509Certificate : ISerializable
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x4A88DA0", Offset = "0x4A879A0", VA = "0x184A88DA0")]
		private void Parse(byte[] data)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x4A89DD0", Offset = "0x4A889D0", VA = "0x184A89DD0")]
		public X509Certificate(byte[] data)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x4A88BD0", Offset = "0x4A877D0", VA = "0x184A88BD0")]
		private byte[] GetUnsignedBigInteger(byte[] integer)
		{
			return null;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000091 RID: 145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000029")]
		public DSA DSA
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0x4A8A030", Offset = "0x4A88C30", VA = "0x184A8A030")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000091")]
			[Address(RVA = "0x4A8B0F0", Offset = "0x4A89CF0", VA = "0x184A8B0F0")]
			set
			{
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002A")]
		public X509ExtensionCollection Extensions
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x22F8850", Offset = "0x22F7450", VA = "0x1822F8850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002B")]
		public byte[] Hash
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x4A8A420", Offset = "0x4A89020", VA = "0x184A8A420")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002C")]
		public virtual string IssuerName
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		public virtual string KeyAlgorithm
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700002E")]
		public virtual byte[] KeyAlgorithmParameters
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x4A8A860", Offset = "0x4A89460", VA = "0x184A8A860", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x4EEA30", Offset = "0x4ED630", VA = "0x1804EEA30", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public virtual byte[] PublicKey
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x4A8A8E0", Offset = "0x4A894E0", VA = "0x184A8A8E0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000030")]
		public virtual RSA RSA
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x4A8A960", Offset = "0x4A89560", VA = "0x184A8A960", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x4A8B140", Offset = "0x4A89D40", VA = "0x184A8B140", Slot = "11")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public virtual byte[] RawData
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0x4A8ABE0", Offset = "0x4A897E0", VA = "0x184A8ABE0", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000032")]
		public virtual byte[] SerialNumber
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0x4A8AC60", Offset = "0x4A89860", VA = "0x184A8AC60", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		public virtual byte[] Signature
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0x4A8ACE0", Offset = "0x4A898E0", VA = "0x184A8ACE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000034")]
		public virtual string SubjectName
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x17000035")]
		public virtual DateTime ValidFrom
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "16")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x17000036")]
		public virtual DateTime ValidUntil
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "17")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000037")]
		public int Version
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x7CEE30", Offset = "0x7CDA30", VA = "0x1807CEE30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x17000038")]
		public bool IsCurrent
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x4A8A670", Offset = "0x4A89270", VA = "0x184A8A670")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x4A89C80", Offset = "0x4A88880", VA = "0x184A89C80")]
		public bool WasCurrent(DateTime instant)
		{
			return default(bool);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002340 File Offset: 0x00000540
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x4A89B70", Offset = "0x4A88770", VA = "0x184A89B70")]
		internal bool VerifySignature(DSA dsa)
		{
			return default(bool);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002358 File Offset: 0x00000558
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x4A89A00", Offset = "0x4A88600", VA = "0x184A89A00")]
		internal bool VerifySignature(RSA rsa)
		{
			return default(bool);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x4A89770", Offset = "0x4A88370", VA = "0x184A89770")]
		public bool VerifySignature(AsymmetricAlgorithm aa)
		{
			return default(bool);
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x17000039")]
		public bool IsSelfSigned
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x4A8A7A0", Offset = "0x4A893A0", VA = "0x184A8A7A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x4A88B70", Offset = "0x4A87770", VA = "0x184A88B70", Slot = "18")]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x4A88C70", Offset = "0x4A87870", VA = "0x184A88C70")]
		private static byte[] PEM(string type, byte[] data)
		{
			return null;
		}

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x10")]
		private ASN1 decoder;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x18")]
		private byte[] m_encodedcert;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x20")]
		private DateTime m_from;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x28")]
		private DateTime m_until;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x30")]
		private ASN1 issuer;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x38")]
		private string m_issuername;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x40")]
		private string m_keyalgo;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x48")]
		private byte[] m_keyalgoparams;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x50")]
		private ASN1 subject;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x58")]
		private string m_subject;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x60")]
		private byte[] m_publickey;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x68")]
		private byte[] signature;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x70")]
		private string m_signaturealgo;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x78")]
		private byte[] m_signaturealgoparams;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x80")]
		private byte[] certhash;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x88")]
		private RSA _rsa;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x90")]
		private DSA _dsa;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x98")]
		private int version;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0xA0")]
		private byte[] serialnumber;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0xA8")]
		private byte[] issuerUniqueID;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0xB0")]
		private byte[] subjectUniqueID;

		// Token: 0x0400005F RID: 95
		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0xB8")]
		private X509ExtensionCollection extensions;

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x0")]
		private static string encoding_error;
	}
}
