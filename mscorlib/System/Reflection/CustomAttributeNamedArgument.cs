using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000523 RID: 1315
	[Token(Token = "0x2000523")]
	public struct CustomAttributeNamedArgument
	{
		// Token: 0x060025DB RID: 9691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DB")]
		[Address(RVA = "0x4BD19D0", Offset = "0x4BD05D0", VA = "0x184BD19D0")]
		internal CustomAttributeNamedArgument(System.Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue)
		{
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DC")]
		[Address(RVA = "0x4BD1A40", Offset = "0x4BD0640", VA = "0x184BD1A40")]
		public CustomAttributeNamedArgument(MemberInfo memberInfo, object value)
		{
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60025DD")]
		[Address(RVA = "0x4BD1D80", Offset = "0x4BD0980", VA = "0x184BD1D80")]
		public CustomAttributeNamedArgument(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument)
		{
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x000152E8 File Offset: 0x000134E8
		[Token(Token = "0x17000538")]
		public readonly CustomAttributeTypedArgument TypedValue
		{
			[Token(Token = "0x60025DE")]
			[Address(RVA = "0x253ECA0", Offset = "0x253D8A0", VA = "0x18253ECA0")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(CustomAttributeTypedArgument);
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x00015300 File Offset: 0x00013500
		[Token(Token = "0x17000539")]
		public readonly bool IsField
		{
			[Token(Token = "0x60025DF")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700053A")]
		public readonly string MemberName
		{
			[Token(Token = "0x60025E0")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x1700053B")]
		public MemberInfo MemberInfo
		{
			[Token(Token = "0x60025E1")]
			[Address(RVA = "0x4BD1F50", Offset = "0x4BD0B50", VA = "0x184BD1F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x060025E2 RID: 9698 RVA: 0x00015318 File Offset: 0x00013518
		[Token(Token = "0x60025E2")]
		[Address(RVA = "0x4BD1640", Offset = "0x4BD0240", VA = "0x184BD1640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x00015330 File Offset: 0x00013530
		[Token(Token = "0x60025E3")]
		[Address(RVA = "0x4BD16B0", Offset = "0x4BD02B0", VA = "0x184BD16B0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00015348 File Offset: 0x00013548
		[Token(Token = "0x60025E4")]
		[Address(RVA = "0x4BD2110", Offset = "0x4BD0D10", VA = "0x184BD2110")]
		public static bool operator ==(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			return default(bool);
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00015360 File Offset: 0x00013560
		[Token(Token = "0x60025E5")]
		[Address(RVA = "0x4BD21D0", Offset = "0x4BD0DD0", VA = "0x184BD21D0")]
		public static bool operator !=(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right)
		{
			return default(bool);
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60025E6")]
		[Address(RVA = "0x4BD1710", Offset = "0x4BD0310", VA = "0x184BD1710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04001574 RID: 5492
		[Token(Token = "0x4001574")]
		[FieldOffset(Offset = "0x20")]
		private readonly System.Type _attributeType;

		// Token: 0x04001575 RID: 5493
		[Token(Token = "0x4001575")]
		[FieldOffset(Offset = "0x28")]
		private MemberInfo _lazyMemberInfo;
	}
}
