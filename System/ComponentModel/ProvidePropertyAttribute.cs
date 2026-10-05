using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001D6 RID: 470
	[Token(Token = "0x20001D6")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
	public sealed class ProvidePropertyAttribute : Attribute
	{
		// Token: 0x06000C9C RID: 3228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x51625A0", Offset = "0x51611A0", VA = "0x1851625A0")]
		public ProvidePropertyAttribute(string propertyName, Type receiverType)
		{
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x2637490", Offset = "0x2636090", VA = "0x182637490")]
		public ProvidePropertyAttribute(string propertyName, string receiverTypeName)
		{
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029C")]
		public string PropertyName
		{
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029D")]
		public string ReceiverTypeName
		{
			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x51624F0", Offset = "0x51610F0", VA = "0x1851624F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x515B100", Offset = "0x5159D00", VA = "0x18515B100", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700029E")]
		public override object TypeId
		{
			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x5122DE0", Offset = "0x51219E0", VA = "0x185122DE0", Slot = "4")]
			get
			{
				return null;
			}
		}
	}
}
