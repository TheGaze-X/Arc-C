using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Il2CppDummyDll;

namespace Mono.Security.Interface
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	public sealed class MonoTlsSettings
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600015C RID: 348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006C")]
		public MonoRemoteCertificateValidationCallback RemoteCertificateValidationCallback
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600015E RID: 350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006D")]
		public MonoLocalCertificateSelectionCallback ClientCertificateSelectionCallback
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600015F RID: 351 RVA: 0x00002640 File Offset: 0x00000840
		// (set) Token: 0x06000160 RID: 352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006E")]
		public bool? UseServicePointManagerCallback
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x4A9EEF0", Offset = "0x4A9DAF0", VA = "0x184A9EEF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x4A9EF20", Offset = "0x4A9DB20", VA = "0x184A9EF20")]
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x1700006F")]
		public bool CallbackNeedsCertificateChain
		{
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x4A9EE30", Offset = "0x4A9DA30", VA = "0x184A9EE30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000162 RID: 354 RVA: 0x00002670 File Offset: 0x00000870
		// (set) Token: 0x06000163 RID: 355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000070")]
		public DateTime? CertificateValidationTime
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xF10AF0", Offset = "0xF0F6F0", VA = "0x180F10AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x4A9EF00", Offset = "0x4A9DB00", VA = "0x184A9EF00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000071")]
		public X509CertificateCollection TrustAnchors
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000072")]
		public object UserSettings
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000167")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000073")]
		internal string[] CertificateSearchPaths
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00002688 File Offset: 0x00000888
		// (set) Token: 0x0600016B RID: 363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000074")]
		internal bool SendCloseNotify
		{
			[Token(Token = "0x600016A")]
			[Address(RVA = "0x16647A0", Offset = "0x16633A0", VA = "0x1816647A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x16647B0", Offset = "0x16633B0", VA = "0x1816647B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000075")]
		public string[] ClientCertificateIssuers
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x5EC4C0", Offset = "0x5EB0C0", VA = "0x1805EC4C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000026A0 File Offset: 0x000008A0
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000076")]
		public bool DisallowUnauthenticatedCertificateRequest
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xC97C20", Offset = "0xC96820", VA = "0x180C97C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000026B8 File Offset: 0x000008B8
		// (set) Token: 0x06000171 RID: 369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000077")]
		public TlsProtocols? EnabledProtocols
		{
			[Token(Token = "0x6000170")]
			[Address(RVA = "0x4A9EEE0", Offset = "0x4A9DAE0", VA = "0x184A9EEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x4A9EF10", Offset = "0x4A9DB10", VA = "0x184A9EF10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000172 RID: 370 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000173 RID: 371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000078")]
		[CLSCompliant(false)]
		public CipherSuiteCode[] EnabledCiphers
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x4A9EE20", Offset = "0x4A9DA20", VA = "0x184A9EE20")]
		public MonoTlsSettings()
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000079")]
		public static MonoTlsSettings DefaultSettings
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x4A9EE40", Offset = "0x4A9DA40", VA = "0x184A9EE40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x4A9EBA0", Offset = "0x4A9D7A0", VA = "0x184A9EBA0")]
		public static MonoTlsSettings CopyDefaultSettings()
		{
			return null;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007A")]
		[Obsolete("Do not use outside System.dll!")]
		public ICertificateValidator CertificateValidator
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x4A9EAA0", Offset = "0x4A9D6A0", VA = "0x184A9EAA0")]
		[Obsolete("Do not use outside System.dll!")]
		public MonoTlsSettings CloneWithValidator(ICertificateValidator validator)
		{
			return null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x4A9EB40", Offset = "0x4A9D740", VA = "0x184A9EB40")]
		public MonoTlsSettings Clone()
		{
			return null;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x4A9EC90", Offset = "0x4A9D890", VA = "0x184A9EC90")]
		private MonoTlsSettings(MonoTlsSettings other)
		{
		}

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x70")]
		private bool cloned;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x71")]
		private bool checkCertName;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x72")]
		private bool checkCertRevocationStatus;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x73")]
		private bool? useServicePointManagerCallback;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x75")]
		private bool skipSystemValidators;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x76")]
		private bool callbackNeedsChain;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x78")]
		private ICertificateValidator certificateValidator;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x0")]
		private static MonoTlsSettings defaultSettings;
	}
}
