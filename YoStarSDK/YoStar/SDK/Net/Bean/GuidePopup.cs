using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace YoStar.SDK.Net.Bean
{
	// Token: 0x02000209 RID: 521
	[Token(Token = "0x2000209")]
	public class GuidePopup
	{
		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000D72 RID: 3442 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000D73 RID: 3443 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700019E")]
		[JsonProperty("DATA")]
		public object DATA
		{
			[Token(Token = "0x6000D72")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D73")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000D74 RID: 3444 RVA: 0x00003FD4 File Offset: 0x000021D4
		// (set) Token: 0x06000D75 RID: 3445 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x1700019F")]
		[JsonProperty("ENABLE")]
		public long ENABLE
		{
			[Token(Token = "0x6000D74")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000D75")]
			[Address(RVA = "0x3244A50", Offset = "0x3243650", VA = "0x183244A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000D76")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GuidePopup()
		{
		}
	}
}
