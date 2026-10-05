using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Runtime.InteropServices
{
	// Token: 0x02000459 RID: 1113
	[Token(Token = "0x2000459")]
	public readonly struct OSPlatform : System.IEquatable<OSPlatform>
	{
		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x00013AE8 File Offset: 0x00011CE8
		[Token(Token = "0x17000468")]
		public static OSPlatform Linux
		{
			[Token(Token = "0x6002209")]
			[Address(RVA = "0x4BB8F40", Offset = "0x4BB7B40", VA = "0x184BB8F40")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(OSPlatform);
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600220A RID: 8714 RVA: 0x00013B00 File Offset: 0x00011D00
		[Token(Token = "0x17000469")]
		public static OSPlatform OSX
		{
			[Token(Token = "0x600220A")]
			[Address(RVA = "0x4BB8F90", Offset = "0x4BB7B90", VA = "0x184BB8F90")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(OSPlatform);
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x0600220B RID: 8715 RVA: 0x00013B18 File Offset: 0x00011D18
		[Token(Token = "0x1700046A")]
		public static OSPlatform Windows
		{
			[Token(Token = "0x600220B")]
			[Address(RVA = "0x4BB8FE0", Offset = "0x4BB7BE0", VA = "0x184BB8FE0")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(OSPlatform);
			}
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600220C")]
		[Address(RVA = "0x4BB8E60", Offset = "0x4BB7A60", VA = "0x184BB8E60")]
		private OSPlatform(string osPlatform)
		{
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x00013B30 File Offset: 0x00011D30
		[Token(Token = "0x600220D")]
		[Address(RVA = "0x4BB8850", Offset = "0x4BB7450", VA = "0x184BB8850")]
		public static OSPlatform Create(string osPlatform)
		{
			return default(OSPlatform);
		}

		// Token: 0x0600220E RID: 8718 RVA: 0x00013B48 File Offset: 0x00011D48
		[Token(Token = "0x600220E")]
		[Address(RVA = "0x4BB8940", Offset = "0x4BB7540", VA = "0x184BB8940", Slot = "4")]
		public bool Equals(OSPlatform other)
		{
			return default(bool);
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x00013B60 File Offset: 0x00011D60
		[Token(Token = "0x600220F")]
		[Address(RVA = "0x4BB8A80", Offset = "0x4BB7680", VA = "0x184BB8A80")]
		internal bool Equals(string other)
		{
			return default(bool);
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x00013B78 File Offset: 0x00011D78
		[Token(Token = "0x6002210")]
		[Address(RVA = "0x4BB89A0", Offset = "0x4BB75A0", VA = "0x184BB89A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x00013B90 File Offset: 0x00011D90
		[Token(Token = "0x6002211")]
		[Address(RVA = "0x4B2D280", Offset = "0x4B2BE80", VA = "0x184B2D280", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6002212")]
		[Address(RVA = "0x4BB8A90", Offset = "0x4BB7690", VA = "0x184BB8A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x00013BA8 File Offset: 0x00011DA8
		[Token(Token = "0x6002213")]
		[Address(RVA = "0x4BB9030", Offset = "0x4BB7C30", VA = "0x184BB9030")]
		public static bool operator ==(OSPlatform left, OSPlatform right)
		{
			return default(bool);
		}

		// Token: 0x0400131E RID: 4894
		[Token(Token = "0x400131E")]
		[FieldOffset(Offset = "0x0")]
		private readonly string _osPlatform;
	}
}
