using System;
using System.Collections;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x020002E2 RID: 738
	[Token(Token = "0x20002E2")]
	[Serializable]
	public sealed class Cookie
	{
		// Token: 0x0600144E RID: 5198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144E")]
		[Address(RVA = "0x5052870", Offset = "0x5051470", VA = "0x185052870")]
		public Cookie()
		{
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600144F")]
		[Address(RVA = "0x50529D0", Offset = "0x50515D0", VA = "0x1850529D0")]
		public Cookie(string name, string value)
		{
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043E")]
		public string Comment
		{
			[Token(Token = "0x6001450")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001451")]
			[Address(RVA = "0x50530C0", Offset = "0x5051CC0", VA = "0x1850530C0")]
			set
			{
			}
		}

		// Token: 0x1700043F RID: 1087
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700043F")]
		public Uri CommentUri
		{
			[Token(Token = "0x6001452")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000440 RID: 1088
		// (set) Token: 0x06001453 RID: 5203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000440")]
		public bool HttpOnly
		{
			[Token(Token = "0x6001453")]
			[Address(RVA = "0x37002C0", Offset = "0x36FEEC0", VA = "0x1837002C0")]
			set
			{
			}
		}

		// Token: 0x17000441 RID: 1089
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000441")]
		public bool Discard
		{
			[Token(Token = "0x6001454")]
			[Address(RVA = "0x4EA980", Offset = "0x4E9580", VA = "0x1804EA980")]
			set
			{
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000442")]
		public string Domain
		{
			[Token(Token = "0x6001455")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001456")]
			[Address(RVA = "0x5053120", Offset = "0x5051D20", VA = "0x185053120")]
			set
			{
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000443")]
		private string _Domain
		{
			[Token(Token = "0x6001457")]
			[Address(RVA = "0x5052DA0", Offset = "0x50519A0", VA = "0x185052DA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x00009948 File Offset: 0x00007B48
		[Token(Token = "0x17000444")]
		public bool Expired
		{
			[Token(Token = "0x6001458")]
			[Address(RVA = "0x5052CE0", Offset = "0x50518E0", VA = "0x185052CE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (set) Token: 0x06001459 RID: 5209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000445")]
		public DateTime Expires
		{
			[Token(Token = "0x6001459")]
			[Address(RVA = "0x1796DB0", Offset = "0x17959B0", VA = "0x181796DB0")]
			set
			{
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x0600145A RID: 5210 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600145B RID: 5211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000446")]
		public string Name
		{
			[Token(Token = "0x600145A")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
			[Token(Token = "0x600145B")]
			[Address(RVA = "0x50531B0", Offset = "0x5051DB0", VA = "0x1850531B0")]
			set
			{
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00009960 File Offset: 0x00007B60
		[Token(Token = "0x600145C")]
		[Address(RVA = "0x5050E70", Offset = "0x504FA70", VA = "0x185050E70")]
		internal bool InternalSetName(string value)
		{
			return default(bool);
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000447")]
		public string Path
		{
			[Token(Token = "0x600145D")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
			[Token(Token = "0x600145E")]
			[Address(RVA = "0x5053330", Offset = "0x5051F30", VA = "0x185053330")]
			set
			{
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x0600145F RID: 5215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000448")]
		private string _Path
		{
			[Token(Token = "0x600145F")]
			[Address(RVA = "0x5052E70", Offset = "0x5051A70", VA = "0x185052E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001460 RID: 5216 RVA: 0x00009978 File Offset: 0x00007B78
		[Token(Token = "0x17000449")]
		internal bool Plain
		{
			[Token(Token = "0x6001460")]
			[Address(RVA = "0x21005D0", Offset = "0x20FF1D0", VA = "0x1821005D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00009990 File Offset: 0x00007B90
		[Token(Token = "0x6001461")]
		[Address(RVA = "0x5050F80", Offset = "0x504FB80", VA = "0x185050F80")]
		private static bool IsDomainEqualToHost(string domain, string host)
		{
			return default(bool);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x000099A8 File Offset: 0x00007BA8
		[Token(Token = "0x6001462")]
		[Address(RVA = "0x5051640", Offset = "0x5050240", VA = "0x185051640")]
		internal bool VerifySetDefaults(CookieVariant variant, Uri uri, bool isLocalDomain, string localDomain, bool set_default, bool isThrow)
		{
			return default(bool);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x000099C0 File Offset: 0x00007BC0
		[Token(Token = "0x6001463")]
		[Address(RVA = "0x50508E0", Offset = "0x504F4E0", VA = "0x1850508E0")]
		private static bool DomainCharsTest(string name)
		{
			return default(bool);
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001464 RID: 5220 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001465 RID: 5221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044A")]
		public string Port
		{
			[Token(Token = "0x6001464")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001465")]
			[Address(RVA = "0x50533A0", Offset = "0x5051FA0", VA = "0x1850533A0")]
			set
			{
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001466 RID: 5222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044B")]
		internal int[] PortList
		{
			[Token(Token = "0x6001466")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001467 RID: 5223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700044C")]
		private string _Port
		{
			[Token(Token = "0x6001467")]
			[Address(RVA = "0x5052EF0", Offset = "0x5051AF0", VA = "0x185052EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001468 RID: 5224 RVA: 0x000099D8 File Offset: 0x00007BD8
		// (set) Token: 0x06001469 RID: 5225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044D")]
		public bool Secure
		{
			[Token(Token = "0x6001468")]
			[Address(RVA = "0x2109C30", Offset = "0x2108830", VA = "0x182109C30")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001469")]
			[Address(RVA = "0x4D6B950", Offset = "0x4D6A550", VA = "0x184D6B950")]
			set
			{
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600146B RID: 5227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700044E")]
		public string Value
		{
			[Token(Token = "0x600146A")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600146B")]
			[Address(RVA = "0x5053870", Offset = "0x5052470", VA = "0x185053870")]
			set
			{
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600146C RID: 5228 RVA: 0x000099F0 File Offset: 0x00007BF0
		[Token(Token = "0x1700044F")]
		internal CookieVariant Variant
		{
			[Token(Token = "0x600146C")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return CookieVariant.Unknown;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x0600146D RID: 5229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000450")]
		internal string DomainKey
		{
			[Token(Token = "0x600146D")]
			[Address(RVA = "0x5052CC0", Offset = "0x50518C0", VA = "0x185052CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x00009A08 File Offset: 0x00007C08
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000451")]
		public int Version
		{
			[Token(Token = "0x600146E")]
			[Address(RVA = "0x12905A0", Offset = "0x128F1A0", VA = "0x1812905A0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600146F")]
			[Address(RVA = "0x50538E0", Offset = "0x50524E0", VA = "0x1850538E0")]
			set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001470 RID: 5232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000452")]
		private string _Version
		{
			[Token(Token = "0x6001470")]
			[Address(RVA = "0x5052FB0", Offset = "0x5051BB0", VA = "0x185052FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001471")]
		[Address(RVA = "0x5050A80", Offset = "0x504F680", VA = "0x185050A80")]
		internal static IComparer GetComparer()
		{
			return null;
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00009A20 File Offset: 0x00007C20
		[Token(Token = "0x6001472")]
		[Address(RVA = "0x5050970", Offset = "0x504F570", VA = "0x185050970", Slot = "0")]
		public override bool Equals(object comparand)
		{
			return default(bool);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x00009A38 File Offset: 0x00007C38
		[Token(Token = "0x6001473")]
		[Address(RVA = "0x5050AD0", Offset = "0x504F6D0", VA = "0x185050AD0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001474")]
		[Address(RVA = "0x5050FE0", Offset = "0x504FBE0", VA = "0x185050FE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000B07 RID: 2823
		[Token(Token = "0x4000B07")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly char[] PortSplitDelimiters;

		// Token: 0x04000B08 RID: 2824
		[Token(Token = "0x4000B08")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly char[] Reserved2Name;

		// Token: 0x04000B09 RID: 2825
		[Token(Token = "0x4000B09")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly char[] Reserved2Value;

		// Token: 0x04000B0A RID: 2826
		[Token(Token = "0x4000B0A")]
		[FieldOffset(Offset = "0x18")]
		private static Comparer staticComparer;

		// Token: 0x04000B0B RID: 2827
		[Token(Token = "0x4000B0B")]
		[FieldOffset(Offset = "0x10")]
		private string m_comment;

		// Token: 0x04000B0C RID: 2828
		[Token(Token = "0x4000B0C")]
		[FieldOffset(Offset = "0x18")]
		private Uri m_commentUri;

		// Token: 0x04000B0D RID: 2829
		[Token(Token = "0x4000B0D")]
		[FieldOffset(Offset = "0x20")]
		private CookieVariant m_cookieVariant;

		// Token: 0x04000B0E RID: 2830
		[Token(Token = "0x4000B0E")]
		[FieldOffset(Offset = "0x24")]
		private bool m_discard;

		// Token: 0x04000B0F RID: 2831
		[Token(Token = "0x4000B0F")]
		[FieldOffset(Offset = "0x28")]
		private string m_domain;

		// Token: 0x04000B10 RID: 2832
		[Token(Token = "0x4000B10")]
		[FieldOffset(Offset = "0x30")]
		private bool m_domain_implicit;

		// Token: 0x04000B11 RID: 2833
		[Token(Token = "0x4000B11")]
		[FieldOffset(Offset = "0x38")]
		private DateTime m_expires;

		// Token: 0x04000B12 RID: 2834
		[Token(Token = "0x4000B12")]
		[FieldOffset(Offset = "0x40")]
		private string m_name;

		// Token: 0x04000B13 RID: 2835
		[Token(Token = "0x4000B13")]
		[FieldOffset(Offset = "0x48")]
		private string m_path;

		// Token: 0x04000B14 RID: 2836
		[Token(Token = "0x4000B14")]
		[FieldOffset(Offset = "0x50")]
		private bool m_path_implicit;

		// Token: 0x04000B15 RID: 2837
		[Token(Token = "0x4000B15")]
		[FieldOffset(Offset = "0x58")]
		private string m_port;

		// Token: 0x04000B16 RID: 2838
		[Token(Token = "0x4000B16")]
		[FieldOffset(Offset = "0x60")]
		private bool m_port_implicit;

		// Token: 0x04000B17 RID: 2839
		[Token(Token = "0x4000B17")]
		[FieldOffset(Offset = "0x68")]
		private int[] m_port_list;

		// Token: 0x04000B18 RID: 2840
		[Token(Token = "0x4000B18")]
		[FieldOffset(Offset = "0x70")]
		private bool m_secure;

		// Token: 0x04000B19 RID: 2841
		[Token(Token = "0x4000B19")]
		[FieldOffset(Offset = "0x71")]
		[OptionalField]
		private bool m_httpOnly;

		// Token: 0x04000B1A RID: 2842
		[Token(Token = "0x4000B1A")]
		[FieldOffset(Offset = "0x78")]
		private DateTime m_timeStamp;

		// Token: 0x04000B1B RID: 2843
		[Token(Token = "0x4000B1B")]
		[FieldOffset(Offset = "0x80")]
		private string m_value;

		// Token: 0x04000B1C RID: 2844
		[Token(Token = "0x4000B1C")]
		[FieldOffset(Offset = "0x88")]
		private int m_version;

		// Token: 0x04000B1D RID: 2845
		[Token(Token = "0x4000B1D")]
		[FieldOffset(Offset = "0x90")]
		private string m_domainKey;

		// Token: 0x04000B1E RID: 2846
		[Token(Token = "0x4000B1E")]
		[FieldOffset(Offset = "0x98")]
		internal bool IsQuotedVersion;

		// Token: 0x04000B1F RID: 2847
		[Token(Token = "0x4000B1F")]
		[FieldOffset(Offset = "0x99")]
		internal bool IsQuotedDomain;
	}
}
