using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001E9 RID: 489
	[Token(Token = "0x20001E9")]
	[AttributeUsage(AttributeTargets.Class, Inherited = true)]
	public sealed class TypeDescriptionProviderAttribute : Attribute
	{
		// Token: 0x06000D09 RID: 3337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D09")]
		[Address(RVA = "0x5175150", Offset = "0x5173D50", VA = "0x185175150")]
		public TypeDescriptionProviderAttribute(string typeName)
		{
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x51751E0", Offset = "0x5173DE0", VA = "0x1851751E0")]
		public TypeDescriptionProviderAttribute(Type type)
		{
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002AE")]
		public string TypeName
		{
			[Token(Token = "0x6000D0B")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}
	}
}
