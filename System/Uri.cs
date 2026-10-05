using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	[TypeConverter(typeof(UriTypeConverter))]
	[Serializable]
	public class Uri : ISerializable
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x17000094")]
		private bool IsImplicitFile
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x5048F10", Offset = "0x5047B10", VA = "0x185048F10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000396 RID: 918 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x17000095")]
		private bool IsUncOrDosPath
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x5048FE0", Offset = "0x5047BE0", VA = "0x185048FE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000397 RID: 919 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x17000096")]
		private bool IsDosPath
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x5048E30", Offset = "0x5047A30", VA = "0x185048E30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x17000097")]
		private bool IsUncPath
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x5048FF0", Offset = "0x5047BF0", VA = "0x185048FF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x17000098")]
		private Uri.Flags HostType
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x5048BA0", Offset = "0x50477A0", VA = "0x185048BA0")]
			get
			{
				return Uri.Flags.Zero;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000099")]
		private UriParser Syntax
		{
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x1700009A")]
		private bool IsNotAbsoluteUri
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x2420A20", Offset = "0x241F620", VA = "0x182420A20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x5042F30", Offset = "0x5041B30", VA = "0x185042F30")]
		internal static bool IriParsingStatic(UriParser syntax)
		{
			return default(bool);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x1700009B")]
		private bool AllowIdn
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x5048440", Offset = "0x5047040", VA = "0x185048440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x5039420", Offset = "0x5038020", VA = "0x185039420")]
		private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags)
		{
			return default(bool);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		private bool IsIntranet(string schemeHost)
		{
			return default(bool);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x1700009C")]
		internal bool UserDrivenParsing
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x5049930", Offset = "0x5048530", VA = "0x185049930")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x50467C0", Offset = "0x50453C0", VA = "0x1850467C0")]
		private void SetUserDrivenParsing()
		{
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x1700009D")]
		private ushort SecuredPathIndex
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x50496B0", Offset = "0x50482B0", VA = "0x1850496B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x5043470", Offset = "0x5042070", VA = "0x185043470")]
		private bool NotAny(Uri.Flags flags)
		{
			return default(bool);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x50421C0", Offset = "0x5040DC0", VA = "0x1850421C0")]
		private bool InFact(Uri.Flags flags)
		{
			return default(bool);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x5046810", Offset = "0x5045410", VA = "0x185046810")]
		private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags)
		{
			return default(bool);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x50467E0", Offset = "0x50453E0", VA = "0x1850467E0")]
		private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags)
		{
			return default(bool);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x503E520", Offset = "0x503D120", VA = "0x18503E520")]
		private Uri.UriInfo EnsureUriInfo()
		{
			return null;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x503E500", Offset = "0x503D100", VA = "0x18503E500")]
		private void EnsureParseRemaining()
		{
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x503E4A0", Offset = "0x503D0A0", VA = "0x18503E4A0")]
		private void EnsureHostString(bool allowDnsOptimization)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x5047CD0", Offset = "0x50468D0", VA = "0x185047CD0")]
		public Uri(string uriString)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x50479B0", Offset = "0x50465B0", VA = "0x1850479B0")]
		public Uri(string uriString, UriKind uriKind)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x5047E80", Offset = "0x5046A80", VA = "0x185047E80")]
		public Uri(Uri baseUri, string relativeUri)
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x503E130", Offset = "0x503CD30", VA = "0x18503E130")]
		private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape)
		{
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x5047A50", Offset = "0x5046650", VA = "0x185047A50")]
		public Uri(Uri baseUri, Uri relativeUri)
		{
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x503F9E0", Offset = "0x503E5E0", VA = "0x18503F9E0")]
		private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result)
		{
			return ParsingError.None;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x5040240", Offset = "0x503EE40", VA = "0x185040240")]
		private static UriFormatException GetException(ParsingError err)
		{
			return null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x5047F80", Offset = "0x5046B80", VA = "0x185047F80")]
		protected Uri(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x5041310", Offset = "0x503FF10", VA = "0x185041310", Slot = "4")]
		private void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x5041310", Offset = "0x503FF10", VA = "0x185041310")]
		protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
		{
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009E")]
		public string AbsolutePath
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x5048210", Offset = "0x5046E10", VA = "0x185048210")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009F")]
		private string PrivateAbsolutePath
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x50493E0", Offset = "0x5047FE0", VA = "0x1850493E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A0")]
		public string AbsoluteUri
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x50482E0", Offset = "0x5046EE0", VA = "0x1850482E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A1")]
		public string LocalPath
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x5049090", Offset = "0x5047C90", VA = "0x185049090")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A2")]
		public string Authority
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x5048530", Offset = "0x5047130", VA = "0x185048530")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x170000A3")]
		public UriHostNameType HostNameType
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x5048A50", Offset = "0x5047650", VA = "0x185048A50")]
			get
			{
				return UriHostNameType.Unknown;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x170000A4")]
		public bool IsDefaultPort
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x5048D30", Offset = "0x5047930", VA = "0x185048D30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x170000A5")]
		public bool IsFile
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x5048E40", Offset = "0x5047A40", VA = "0x185048E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060003BC RID: 956 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x170000A6")]
		public bool IsLoopback
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x5048F20", Offset = "0x5047B20", VA = "0x185048F20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		public string PathAndQuery
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x50491F0", Offset = "0x5047DF0", VA = "0x1850491F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A8")]
		public string[] Segments
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x5049710", Offset = "0x5048310", VA = "0x185049710")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060003BF RID: 959 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x170000A9")]
		public bool IsUnc
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x5049000", Offset = "0x5047C00", VA = "0x185049000")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AA")]
		public string Host
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x5048BB0", Offset = "0x50477B0", VA = "0x185048BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x50467F0", Offset = "0x50453F0", VA = "0x1850467F0")]
		private static bool StaticIsFile(UriParser syntax)
		{
			return default(bool);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		private static object InitializeLock
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x5048C40", Offset = "0x5047840", VA = "0x185048C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x50421D0", Offset = "0x5040DD0", VA = "0x1850421D0")]
		private static void InitializeUriConfig()
		{
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x5040A50", Offset = "0x503F650", VA = "0x185040A50")]
		private string GetLocalPath()
		{
			return null;
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x170000AC")]
		public int Port
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x50492D0", Offset = "0x5047ED0", VA = "0x1850492D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AD")]
		public string Query
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x50494C0", Offset = "0x50480C0", VA = "0x1850494C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AE")]
		public string Fragment
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x50488E0", Offset = "0x50474E0", VA = "0x1850488E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AF")]
		public string Scheme
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x5049620", Offset = "0x5048220", VA = "0x185049620")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x170000B0")]
		private bool OriginalStringSwitched
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x5049120", Offset = "0x5047D20", VA = "0x185049120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B1")]
		public string OriginalString
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x5049190", Offset = "0x5047D90", VA = "0x185049190")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B2")]
		public string DnsSafeHost
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x50485C0", Offset = "0x50471C0", VA = "0x1850485C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x170000B3")]
		public bool IsAbsoluteUri
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x926F60", Offset = "0x925B60", VA = "0x180926F60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x170000B4")]
		public bool UserEscaped
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x5049940", Offset = "0x5048540", VA = "0x185049940")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000B5")]
		public string UserInfo
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x5049950", Offset = "0x5048550", VA = "0x185049950")]
			get
			{
				return null;
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x50433E0", Offset = "0x5041FE0", VA = "0x1850433E0")]
		internal static bool IsGenDelim(char ch)
		{
			return default(bool);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x503BA80", Offset = "0x503A680", VA = "0x18503BA80")]
		public static bool CheckSchemeName(string schemeName)
		{
			return default(bool);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x5043410", Offset = "0x5042010", VA = "0x185043410")]
		public static bool IsHexDigit(char character)
		{
			return default(bool);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x503F170", Offset = "0x503DD70", VA = "0x18503F170")]
		public static int FromHex(char digit)
		{
			return 0;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x5040410", Offset = "0x503F010", VA = "0x185040410", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x5046980", Offset = "0x5045580", VA = "0x185046980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x50499E0", Offset = "0x50485E0", VA = "0x1850499E0")]
		public static bool operator ==(Uri uri1, Uri uri2)
		{
			return default(bool);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x5049A00", Offset = "0x5048600", VA = "0x185049A00")]
		public static bool operator !=(Uri uri1, Uri uri2)
		{
			return default(bool);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x503E550", Offset = "0x503D150", VA = "0x18503E550", Slot = "0")]
		public override bool Equals(object comparand)
		{
			return default(bool);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x5042E40", Offset = "0x5041A40", VA = "0x185042E40")]
		internal static string InternalEscapeString(string rawString)
		{
			return null;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x50446F0", Offset = "0x50432F0", VA = "0x1850446F0")]
		private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax)
		{
			return ParsingError.None;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x5043480", Offset = "0x5042080", VA = "0x185043480")]
		internal UriFormatException ParseMinimal()
		{
			return null;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x5044900", Offset = "0x5043500", VA = "0x185044900")]
		private ParsingError PrivateParseMinimal()
		{
			return ParsingError.None;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x50447E0", Offset = "0x50433E0", VA = "0x1850447E0")]
		private void PrivateParseMinimalIri(string newHost, ushort idx)
		{
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x503DBA0", Offset = "0x503C7A0", VA = "0x18503DBA0")]
		private void CreateUriInfo(Uri.Flags cF)
		{
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x503D380", Offset = "0x503BF80", VA = "0x18503D380")]
		private void CreateHostString()
		{
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x503D180", Offset = "0x503BD80", VA = "0x18503D180")]
		private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId)
		{
			return null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x50405B0", Offset = "0x503F1B0", VA = "0x1850405B0")]
		private void GetHostViaCustomSyntax()
		{
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x5041400", Offset = "0x5040000", VA = "0x185041400")]
		internal string GetParts(UriComponents uriParts, UriFormat formatAs)
		{
			return null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x5040140", Offset = "0x503ED40", VA = "0x185040140")]
		private string GetEscapedParts(UriComponents uriParts)
		{
			return null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x50417F0", Offset = "0x50403F0", VA = "0x1850417F0")]
		private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs)
		{
			return null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x50450B0", Offset = "0x5043CB0", VA = "0x1850450B0")]
		private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs)
		{
			return null;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x50418C0", Offset = "0x50404C0", VA = "0x1850418C0")]
		private string GetUriPartsFromUserString(UriComponents uriParts)
		{
			return null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x5043500", Offset = "0x5042100", VA = "0x185043500")]
		private void ParseRemaining()
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x5044240", Offset = "0x5042E40", VA = "0x185044240")]
		private unsafe static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax)
		{
			return 0;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x503B550", Offset = "0x503A150", VA = "0x18503B550")]
		private unsafe static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax)
		{
			return default(bool);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x503BBF0", Offset = "0x503A7F0", VA = "0x18503BBF0")]
		private unsafe static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax)
		{
			return ParsingError.None;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x5039E20", Offset = "0x5038A20", VA = "0x185039E20")]
		private unsafe ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost)
		{
			return 0;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x50398F0", Offset = "0x50384F0", VA = "0x1850398F0")]
		private unsafe void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err)
		{
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x50395F0", Offset = "0x50381F0", VA = "0x1850395F0")]
		private unsafe void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err)
		{
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x503F0C0", Offset = "0x503DCC0", VA = "0x18503F0C0")]
		private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim)
		{
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x503F020", Offset = "0x503DC20", VA = "0x18503F020")]
		private unsafe void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim)
		{
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x503ADF0", Offset = "0x50399F0", VA = "0x18503ADF0")]
		private unsafe Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim)
		{
			return Uri.Check.None;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x503F220", Offset = "0x503DE20", VA = "0x18503F220")]
		private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs)
		{
			return null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x50471D0", Offset = "0x5045DD0", VA = "0x1850471D0")]
		private unsafe static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3)
		{
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x503C9D0", Offset = "0x503B5D0", VA = "0x18503C9D0")]
		private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax)
		{
			return null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x5039520", Offset = "0x5038120", VA = "0x185039520")]
		internal static int CalculateCaseInsensitiveHashCode(string text)
		{
			return 0;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x503BD10", Offset = "0x503A910", VA = "0x18503BD10")]
		private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat)
		{
			return null;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x170000B6")]
		internal bool HasAuthority
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x5048A40", Offset = "0x5047640", VA = "0x185048A40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x5043440", Offset = "0x5042040", VA = "0x185043440")]
		private static bool IsLWS(char ch)
		{
			return default(bool);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x5043050", Offset = "0x5041C50", VA = "0x185043050")]
		private static bool IsAsciiLetter(char character)
		{
			return default(bool);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x5042FD0", Offset = "0x5041BD0", VA = "0x185042FD0")]
		internal static bool IsAsciiLetterOrDigit(char character)
		{
			return default(bool);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x50433A0", Offset = "0x5041FA0", VA = "0x1850433A0")]
		internal static bool IsBidiControlCharacter(char ch)
		{
			return default(bool);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x5046820", Offset = "0x5045420", VA = "0x185046820")]
		internal unsafe static string StripBidiControlCharacter(char* strToClean, int start, int length)
		{
			return null;
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x503D9B0", Offset = "0x503C5B0", VA = "0x18503D9B0")]
		private void CreateThis(string uri, bool dontEscape, UriKind uriKind)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x5042440", Offset = "0x5041040", VA = "0x185042440")]
		private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e)
		{
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x503B1C0", Offset = "0x5039DC0", VA = "0x18503B1C0")]
		private bool CheckForConfigLoad(string data)
		{
			return default(bool);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x503B410", Offset = "0x503A010", VA = "0x18503B410")]
		private bool CheckForUnicode(string data)
		{
			return default(bool);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x503B270", Offset = "0x5039E70", VA = "0x18503B270")]
		private bool CheckForEscapedUnreserved(string data)
		{
			return default(bool);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x5046AA0", Offset = "0x50456A0", VA = "0x185046AA0")]
		public static bool TryCreate(string uriString, UriKind uriKind, out Uri result)
		{
			return default(bool);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x5046B80", Offset = "0x5045780", VA = "0x185046B80")]
		public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result)
		{
			return default(bool);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x5046E60", Offset = "0x5045A60", VA = "0x185046E60")]
		public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result)
		{
			return default(bool);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x503FF30", Offset = "0x503EB30", VA = "0x18503FF30")]
		public string GetComponents(UriComponents components, UriFormat format)
		{
			return null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x503C8E0", Offset = "0x503B4E0", VA = "0x18503C8E0")]
		public static int Compare(Uri uri1, Uri uri2, UriComponents partsToCompare, UriFormat compareFormat, StringComparison comparisonType)
		{
			return 0;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x5047010", Offset = "0x5045C10", VA = "0x185047010")]
		public static string UnescapeDataString(string stringToUnescape)
		{
			return null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x503EED0", Offset = "0x503DAD0", VA = "0x18503EED0")]
		public static string EscapeUriString(string stringToEscape)
		{
			return null;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x503ED20", Offset = "0x503D920", VA = "0x18503ED20")]
		public static string EscapeDataString(string stringToEscape)
		{
			return null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x503EE70", Offset = "0x503DA70", VA = "0x18503EE70")]
		internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component)
		{
			return null;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x5047E20", Offset = "0x5046A20", VA = "0x185047E20")]
		private Uri(Uri.Flags flags, UriParser uriParser, string uri)
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x503CE90", Offset = "0x503BA90", VA = "0x18503CE90")]
		internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e)
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x5046280", Offset = "0x5044E80", VA = "0x185046280")]
		internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e)
		{
			return null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x5041410", Offset = "0x5040010", VA = "0x185041410")]
		private string GetRelativeSerializationString(UriFormat format)
		{
			return null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x503FC00", Offset = "0x503E800", VA = "0x18503FC00")]
		internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat)
		{
			return null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x50432D0", Offset = "0x5041ED0", VA = "0x1850432D0")]
		public bool IsBaseOf(Uri uri)
		{
			return default(bool);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x5043070", Offset = "0x5041C70", VA = "0x185043070")]
		internal bool IsBaseOfHelper(Uri uriLink)
		{
			return default(bool);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x503D800", Offset = "0x503C400", VA = "0x18503D800")]
		private void CreateThisFromUri(Uri otherUri)
		{
		}

		// Token: 0x04000224 RID: 548
		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string UriSchemeFile;

		// Token: 0x04000225 RID: 549
		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string UriSchemeFtp;

		// Token: 0x04000226 RID: 550
		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string UriSchemeGopher;

		// Token: 0x04000227 RID: 551
		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string UriSchemeHttp;

		// Token: 0x04000228 RID: 552
		[Token(Token = "0x4000228")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string UriSchemeHttps;

		// Token: 0x04000229 RID: 553
		[Token(Token = "0x4000229")]
		[FieldOffset(Offset = "0x28")]
		internal static readonly string UriSchemeWs;

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x30")]
		internal static readonly string UriSchemeWss;

		// Token: 0x0400022B RID: 555
		[Token(Token = "0x400022B")]
		[FieldOffset(Offset = "0x38")]
		public static readonly string UriSchemeMailto;

		// Token: 0x0400022C RID: 556
		[Token(Token = "0x400022C")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string UriSchemeNews;

		// Token: 0x0400022D RID: 557
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x48")]
		public static readonly string UriSchemeNntp;

		// Token: 0x0400022E RID: 558
		[Token(Token = "0x400022E")]
		[FieldOffset(Offset = "0x50")]
		public static readonly string UriSchemeNetTcp;

		// Token: 0x0400022F RID: 559
		[Token(Token = "0x400022F")]
		[FieldOffset(Offset = "0x58")]
		public static readonly string UriSchemeNetPipe;

		// Token: 0x04000230 RID: 560
		[Token(Token = "0x4000230")]
		[FieldOffset(Offset = "0x60")]
		public static readonly string SchemeDelimiter;

		// Token: 0x04000231 RID: 561
		[Token(Token = "0x4000231")]
		private const int c_Max16BitUtf8SequenceLength = 12;

		// Token: 0x04000232 RID: 562
		[Token(Token = "0x4000232")]
		internal const int c_MaxUriBufferSize = 65520;

		// Token: 0x04000233 RID: 563
		[Token(Token = "0x4000233")]
		private const int c_MaxUriSchemeName = 1024;

		// Token: 0x04000234 RID: 564
		[Token(Token = "0x4000234")]
		[FieldOffset(Offset = "0x10")]
		private string m_String;

		// Token: 0x04000235 RID: 565
		[Token(Token = "0x4000235")]
		[FieldOffset(Offset = "0x18")]
		private string m_originalUnicodeString;

		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		[FieldOffset(Offset = "0x20")]
		private UriParser m_Syntax;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x28")]
		private string m_DnsSafeHost;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x30")]
		private Uri.Flags m_Flags;

		// Token: 0x04000239 RID: 569
		[Token(Token = "0x4000239")]
		[FieldOffset(Offset = "0x38")]
		private Uri.UriInfo m_Info;

		// Token: 0x0400023A RID: 570
		[Token(Token = "0x400023A")]
		[FieldOffset(Offset = "0x40")]
		private bool m_iriParsing;

		// Token: 0x0400023B RID: 571
		[Token(Token = "0x400023B")]
		[FieldOffset(Offset = "0x68")]
		private static bool s_ConfigInitialized;

		// Token: 0x0400023C RID: 572
		[Token(Token = "0x400023C")]
		[FieldOffset(Offset = "0x69")]
		private static bool s_ConfigInitializing;

		// Token: 0x0400023D RID: 573
		[Token(Token = "0x400023D")]
		[FieldOffset(Offset = "0x6C")]
		private static UriIdnScope s_IdnScope;

		// Token: 0x0400023E RID: 574
		[Token(Token = "0x400023E")]
		[FieldOffset(Offset = "0x70")]
		private static bool s_IriParsing;

		// Token: 0x0400023F RID: 575
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x71")]
		private static bool useDotNetRelativeOrAbsolute;

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		private const UriKind DotNetRelativeOrAbsolute = (UriKind)300;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x72")]
		internal static readonly bool IsWindowsFileSystem;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x78")]
		private static object s_initLock;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		private const UriFormat V1ToStringUnescape = (UriFormat)32767;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		internal const char c_DummyChar = '￿';

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		internal const char c_EOL = '￾';

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x80")]
		internal static readonly char[] HexLowerChars;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x88")]
		private static readonly char[] _WSchars;

		// Token: 0x020000BA RID: 186
		[Token(Token = "0x20000BA")]
		[Flags]
		private enum Flags : ulong
		{
			// Token: 0x04000249 RID: 585
			[Token(Token = "0x4000249")]
			Zero = 0UL,
			// Token: 0x0400024A RID: 586
			[Token(Token = "0x400024A")]
			SchemeNotCanonical = 1UL,
			// Token: 0x0400024B RID: 587
			[Token(Token = "0x400024B")]
			UserNotCanonical = 2UL,
			// Token: 0x0400024C RID: 588
			[Token(Token = "0x400024C")]
			HostNotCanonical = 4UL,
			// Token: 0x0400024D RID: 589
			[Token(Token = "0x400024D")]
			PortNotCanonical = 8UL,
			// Token: 0x0400024E RID: 590
			[Token(Token = "0x400024E")]
			PathNotCanonical = 16UL,
			// Token: 0x0400024F RID: 591
			[Token(Token = "0x400024F")]
			QueryNotCanonical = 32UL,
			// Token: 0x04000250 RID: 592
			[Token(Token = "0x4000250")]
			FragmentNotCanonical = 64UL,
			// Token: 0x04000251 RID: 593
			[Token(Token = "0x4000251")]
			CannotDisplayCanonical = 127UL,
			// Token: 0x04000252 RID: 594
			[Token(Token = "0x4000252")]
			E_UserNotCanonical = 128UL,
			// Token: 0x04000253 RID: 595
			[Token(Token = "0x4000253")]
			E_HostNotCanonical = 256UL,
			// Token: 0x04000254 RID: 596
			[Token(Token = "0x4000254")]
			E_PortNotCanonical = 512UL,
			// Token: 0x04000255 RID: 597
			[Token(Token = "0x4000255")]
			E_PathNotCanonical = 1024UL,
			// Token: 0x04000256 RID: 598
			[Token(Token = "0x4000256")]
			E_QueryNotCanonical = 2048UL,
			// Token: 0x04000257 RID: 599
			[Token(Token = "0x4000257")]
			E_FragmentNotCanonical = 4096UL,
			// Token: 0x04000258 RID: 600
			[Token(Token = "0x4000258")]
			E_CannotDisplayCanonical = 8064UL,
			// Token: 0x04000259 RID: 601
			[Token(Token = "0x4000259")]
			ShouldBeCompressed = 8192UL,
			// Token: 0x0400025A RID: 602
			[Token(Token = "0x400025A")]
			FirstSlashAbsent = 16384UL,
			// Token: 0x0400025B RID: 603
			[Token(Token = "0x400025B")]
			BackslashInPath = 32768UL,
			// Token: 0x0400025C RID: 604
			[Token(Token = "0x400025C")]
			IndexMask = 65535UL,
			// Token: 0x0400025D RID: 605
			[Token(Token = "0x400025D")]
			HostTypeMask = 458752UL,
			// Token: 0x0400025E RID: 606
			[Token(Token = "0x400025E")]
			HostNotParsed = 0UL,
			// Token: 0x0400025F RID: 607
			[Token(Token = "0x400025F")]
			IPv6HostType = 65536UL,
			// Token: 0x04000260 RID: 608
			[Token(Token = "0x4000260")]
			IPv4HostType = 131072UL,
			// Token: 0x04000261 RID: 609
			[Token(Token = "0x4000261")]
			DnsHostType = 196608UL,
			// Token: 0x04000262 RID: 610
			[Token(Token = "0x4000262")]
			UncHostType = 262144UL,
			// Token: 0x04000263 RID: 611
			[Token(Token = "0x4000263")]
			BasicHostType = 327680UL,
			// Token: 0x04000264 RID: 612
			[Token(Token = "0x4000264")]
			UnusedHostType = 393216UL,
			// Token: 0x04000265 RID: 613
			[Token(Token = "0x4000265")]
			UnknownHostType = 458752UL,
			// Token: 0x04000266 RID: 614
			[Token(Token = "0x4000266")]
			UserEscaped = 524288UL,
			// Token: 0x04000267 RID: 615
			[Token(Token = "0x4000267")]
			AuthorityFound = 1048576UL,
			// Token: 0x04000268 RID: 616
			[Token(Token = "0x4000268")]
			HasUserInfo = 2097152UL,
			// Token: 0x04000269 RID: 617
			[Token(Token = "0x4000269")]
			LoopbackHost = 4194304UL,
			// Token: 0x0400026A RID: 618
			[Token(Token = "0x400026A")]
			NotDefaultPort = 8388608UL,
			// Token: 0x0400026B RID: 619
			[Token(Token = "0x400026B")]
			UserDrivenParsing = 16777216UL,
			// Token: 0x0400026C RID: 620
			[Token(Token = "0x400026C")]
			CanonicalDnsHost = 33554432UL,
			// Token: 0x0400026D RID: 621
			[Token(Token = "0x400026D")]
			ErrorOrParsingRecursion = 67108864UL,
			// Token: 0x0400026E RID: 622
			[Token(Token = "0x400026E")]
			DosPath = 134217728UL,
			// Token: 0x0400026F RID: 623
			[Token(Token = "0x400026F")]
			UncPath = 268435456UL,
			// Token: 0x04000270 RID: 624
			[Token(Token = "0x4000270")]
			ImplicitFile = 536870912UL,
			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000271")]
			MinimalUriInfoSet = 1073741824UL,
			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000272")]
			AllUriInfoSet = 2147483648UL,
			// Token: 0x04000273 RID: 627
			[Token(Token = "0x4000273")]
			IdnHost = 4294967296UL,
			// Token: 0x04000274 RID: 628
			[Token(Token = "0x4000274")]
			HasUnicode = 8589934592UL,
			// Token: 0x04000275 RID: 629
			[Token(Token = "0x4000275")]
			HostUnicodeNormalized = 17179869184UL,
			// Token: 0x04000276 RID: 630
			[Token(Token = "0x4000276")]
			RestUnicodeNormalized = 34359738368UL,
			// Token: 0x04000277 RID: 631
			[Token(Token = "0x4000277")]
			UnicodeHost = 68719476736UL,
			// Token: 0x04000278 RID: 632
			[Token(Token = "0x4000278")]
			IntranetUri = 137438953472UL,
			// Token: 0x04000279 RID: 633
			[Token(Token = "0x4000279")]
			UseOrigUncdStrOffset = 274877906944UL,
			// Token: 0x0400027A RID: 634
			[Token(Token = "0x400027A")]
			UserIriCanonical = 549755813888UL,
			// Token: 0x0400027B RID: 635
			[Token(Token = "0x400027B")]
			PathIriCanonical = 1099511627776UL,
			// Token: 0x0400027C RID: 636
			[Token(Token = "0x400027C")]
			QueryIriCanonical = 2199023255552UL,
			// Token: 0x0400027D RID: 637
			[Token(Token = "0x400027D")]
			FragmentIriCanonical = 4398046511104UL,
			// Token: 0x0400027E RID: 638
			[Token(Token = "0x400027E")]
			IriCanonical = 8246337208320UL,
			// Token: 0x0400027F RID: 639
			[Token(Token = "0x400027F")]
			CompressedSlashes = 17592186044416UL
		}

		// Token: 0x020000BB RID: 187
		[Token(Token = "0x20000BB")]
		private class UriInfo
		{
			// Token: 0x06000412 RID: 1042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000412")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public UriInfo()
			{
			}

			// Token: 0x04000280 RID: 640
			[Token(Token = "0x4000280")]
			[FieldOffset(Offset = "0x10")]
			public string Host;

			// Token: 0x04000281 RID: 641
			[Token(Token = "0x4000281")]
			[FieldOffset(Offset = "0x18")]
			public string ScopeId;

			// Token: 0x04000282 RID: 642
			[Token(Token = "0x4000282")]
			[FieldOffset(Offset = "0x20")]
			public string String;

			// Token: 0x04000283 RID: 643
			[Token(Token = "0x4000283")]
			[FieldOffset(Offset = "0x28")]
			public Uri.Offset Offset;

			// Token: 0x04000284 RID: 644
			[Token(Token = "0x4000284")]
			[FieldOffset(Offset = "0x38")]
			public string DnsSafeHost;

			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000285")]
			[FieldOffset(Offset = "0x40")]
			public Uri.MoreInfo MoreInfo;
		}

		// Token: 0x020000BC RID: 188
		[Token(Token = "0x20000BC")]
		private struct Offset
		{
			// Token: 0x04000286 RID: 646
			[Token(Token = "0x4000286")]
			[FieldOffset(Offset = "0x0")]
			public ushort Scheme;

			// Token: 0x04000287 RID: 647
			[Token(Token = "0x4000287")]
			[FieldOffset(Offset = "0x2")]
			public ushort User;

			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000288")]
			[FieldOffset(Offset = "0x4")]
			public ushort Host;

			// Token: 0x04000289 RID: 649
			[Token(Token = "0x4000289")]
			[FieldOffset(Offset = "0x6")]
			public ushort PortValue;

			// Token: 0x0400028A RID: 650
			[Token(Token = "0x400028A")]
			[FieldOffset(Offset = "0x8")]
			public ushort Path;

			// Token: 0x0400028B RID: 651
			[Token(Token = "0x400028B")]
			[FieldOffset(Offset = "0xA")]
			public ushort Query;

			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400028C")]
			[FieldOffset(Offset = "0xC")]
			public ushort Fragment;

			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400028D")]
			[FieldOffset(Offset = "0xE")]
			public ushort End;
		}

		// Token: 0x020000BD RID: 189
		[Token(Token = "0x20000BD")]
		private class MoreInfo
		{
			// Token: 0x06000413 RID: 1043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000413")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MoreInfo()
			{
			}

			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			[FieldOffset(Offset = "0x10")]
			public string Path;

			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			[FieldOffset(Offset = "0x18")]
			public string Query;

			// Token: 0x04000290 RID: 656
			[Token(Token = "0x4000290")]
			[FieldOffset(Offset = "0x20")]
			public string Fragment;

			// Token: 0x04000291 RID: 657
			[Token(Token = "0x4000291")]
			[FieldOffset(Offset = "0x28")]
			public string AbsoluteUri;

			// Token: 0x04000292 RID: 658
			[Token(Token = "0x4000292")]
			[FieldOffset(Offset = "0x30")]
			public int Hash;

			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			[FieldOffset(Offset = "0x38")]
			public string RemoteUrl;
		}

		// Token: 0x020000BE RID: 190
		[Token(Token = "0x20000BE")]
		[Flags]
		private enum Check
		{
			// Token: 0x04000295 RID: 661
			[Token(Token = "0x4000295")]
			None = 0,
			// Token: 0x04000296 RID: 662
			[Token(Token = "0x4000296")]
			EscapedCanonical = 1,
			// Token: 0x04000297 RID: 663
			[Token(Token = "0x4000297")]
			DisplayCanonical = 2,
			// Token: 0x04000298 RID: 664
			[Token(Token = "0x4000298")]
			DotSlashAttn = 4,
			// Token: 0x04000299 RID: 665
			[Token(Token = "0x4000299")]
			DotSlashEscaped = 128,
			// Token: 0x0400029A RID: 666
			[Token(Token = "0x400029A")]
			BackslashInPath = 16,
			// Token: 0x0400029B RID: 667
			[Token(Token = "0x400029B")]
			ReservedFound = 32,
			// Token: 0x0400029C RID: 668
			[Token(Token = "0x400029C")]
			NotIriCanonical = 64,
			// Token: 0x0400029D RID: 669
			[Token(Token = "0x400029D")]
			FoundNonAscii = 8
		}
	}
}
