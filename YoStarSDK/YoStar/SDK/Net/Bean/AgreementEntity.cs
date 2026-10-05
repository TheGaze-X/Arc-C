using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x020001EC RID: 492
	[Token(Token = "0x20001EC")]
	public class AgreementEntity
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000E0")]
		[JsonProperty("List")]
		public List<AgreementItem> List
		{
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x170000E1")]
		[JsonProperty("Agreement")]
		public List<AgreementItem> Agreement
		{
			[Token(Token = "0x6000BDC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BDD")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AgreementEntity()
		{
		}
	}
}
