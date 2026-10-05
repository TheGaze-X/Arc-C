using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000524 RID: 1316
	[Token(Token = "0x2000524")]
	public struct CustomAttributeTypedArgument
	{
		// Token: 0x060025E7 RID: 9703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E7")]
		[Address(RVA = "0x4BD2EA0", Offset = "0x4BD1AA0", VA = "0x184BD2EA0")]
		public CustomAttributeTypedArgument(object value)
		{
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025E8")]
		[Address(RVA = "0x4BD2B90", Offset = "0x4BD1790", VA = "0x184BD2B90")]
		public CustomAttributeTypedArgument(System.Type argumentType, object value)
		{
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700053C")]
		public readonly System.Type ArgumentType
		{
			[Token(Token = "0x60025E9")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700053D")]
		public readonly object Value
		{
			[Token(Token = "0x60025EA")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00015378 File Offset: 0x00013578
		[Token(Token = "0x60025EB")]
		[Address(RVA = "0x4BD2400", Offset = "0x4BD1000", VA = "0x184BD2400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00015390 File Offset: 0x00013590
		[Token(Token = "0x60025EC")]
		[Address(RVA = "0x4BD2460", Offset = "0x4BD1060", VA = "0x184BD2460", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x000153A8 File Offset: 0x000135A8
		[Token(Token = "0x60025ED")]
		[Address(RVA = "0x4BD2F50", Offset = "0x4BD1B50", VA = "0x184BD2F50")]
		public static bool operator ==(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			return default(bool);
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x000153C0 File Offset: 0x000135C0
		[Token(Token = "0x60025EE")]
		[Address(RVA = "0x4BD2FE0", Offset = "0x4BD1BE0", VA = "0x184BD2FE0")]
		public static bool operator !=(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right)
		{
			return default(bool);
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025EF")]
		[Address(RVA = "0x4BD2B80", Offset = "0x4BD1780", VA = "0x184BD2B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025F0")]
		[Address(RVA = "0x4BD24B0", Offset = "0x4BD10B0", VA = "0x184BD24B0")]
		internal string ToString(bool typed)
		{
			return null;
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025F1")]
		[Address(RVA = "0x4BD2290", Offset = "0x4BD0E90", VA = "0x184BD2290")]
		private static object CanonicalizeValue(object value)
		{
			return null;
		}
	}
}
