using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace DG.Tweening.Core
{
	// Token: 0x020000B2 RID: 178
	[Token(Token = "0x20000B2")]
	internal struct SafeModeReport
	{
		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00003990 File Offset: 0x00001B90
		// (set) Token: 0x06000421 RID: 1057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		public int totMissingTargetOrFieldErrors
		{
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x000039A8 File Offset: 0x00001BA8
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001D")]
		public int totCallbackErrors
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x06000425 RID: 1061 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001E")]
		public int totStartupErrors
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000425")]
			[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001F")]
		public int totUnsetErrors
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x375DB10", Offset = "0x375C710", VA = "0x18375DB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x375DAE0", Offset = "0x375C6E0", VA = "0x18375DAE0")]
		public void Add(SafeModeReport.SafeModeReportType type)
		{
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x375DB00", Offset = "0x375C700", VA = "0x18375DB00")]
		public int GetTotErrors()
		{
			return 0;
		}

		// Token: 0x020000B3 RID: 179
		[Token(Token = "0x20000B3")]
		internal enum SafeModeReportType
		{
			// Token: 0x0400021B RID: 539
			[Token(Token = "0x400021B")]
			Unset,
			// Token: 0x0400021C RID: 540
			[Token(Token = "0x400021C")]
			TargetOrFieldMissing,
			// Token: 0x0400021D RID: 541
			[Token(Token = "0x400021D")]
			Callback,
			// Token: 0x0400021E RID: 542
			[Token(Token = "0x400021E")]
			StartupFailure
		}
	}
}
