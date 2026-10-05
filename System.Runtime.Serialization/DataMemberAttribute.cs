using System;
using Il2CppDummyDll;

namespace System.Runtime.Serialization
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
	public sealed class DataMemberAttribute : Attribute
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		public string Name
		{
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x17000003")]
		public int Order
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002084 File Offset: 0x00000284
		[Token(Token = "0x17000004")]
		public bool IsRequired
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x12411F0", Offset = "0x123FDF0", VA = "0x1812411F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x17000005")]
		public bool EmitDefaultValue
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x1241200", Offset = "0x123FE00", VA = "0x181241200")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x10")]
		private string name;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x18")]
		private int order;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x1C")]
		private bool isRequired;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x1D")]
		private bool emitDefaultValue;
	}
}
