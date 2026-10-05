using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	[Preserve]
	public class ErrorEventArgs : EventArgs
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000CC")]
		public object CurrentObject
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000CD")]
		public ErrorContext ErrorContext
		{
			[Token(Token = "0x60004C4")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x4DA3C80", Offset = "0x4DA2880", VA = "0x184DA3C80")]
		public ErrorEventArgs(object currentObject, ErrorContext errorContext)
		{
		}
	}
}
