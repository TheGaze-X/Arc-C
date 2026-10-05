using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Prime31
{
	// Token: 0x02000024 RID: 36
	[Token(Token = "0x2000024")]
	public sealed class P31Error
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000013")]
		public string message
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000014")]
		public string domain
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000023A0 File Offset: 0x000005A0
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000015")]
		public int code
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000016")]
		public Dictionary<string, object> userInfo
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x4E0DE80", Offset = "0x4E0CA80", VA = "0x184E0DE80")]
		public static P31Error errorFromJson(string json)
		{
			return null;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x4E0DDC0", Offset = "0x4E0C9C0", VA = "0x184E0DDC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public P31Error()
		{
		}

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x30")]
		private bool _containsOnlyMessage;
	}
}
