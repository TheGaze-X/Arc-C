using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001CA RID: 458
	[Token(Token = "0x20001CA")]
	internal class TypeNames
	{
		// Token: 0x020001CB RID: 459
		[Token(Token = "0x20001CB")]
		internal abstract class ATypeName : TypeName, System.IEquatable<TypeName>
		{
			// Token: 0x17000180 RID: 384
			// (get) Token: 0x060010AF RID: 4271
			[Token(Token = "0x17000180")]
			public abstract string DisplayName { [Token(Token = "0x60010AF")] get; }

			// Token: 0x060010B0 RID: 4272 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
			[Token(Token = "0x60010B0")]
			[Address(RVA = "0x4D47AC0", Offset = "0x4D466C0", VA = "0x184D47AC0", Slot = "5")]
			public bool Equals(TypeName other)
			{
				return default(bool);
			}

			// Token: 0x060010B1 RID: 4273 RVA: 0x0000D8F0 File Offset: 0x0000BAF0
			[Token(Token = "0x60010B1")]
			[Address(RVA = "0x4D47C20", Offset = "0x4D46820", VA = "0x184D47C20", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x060010B2 RID: 4274 RVA: 0x0000D908 File Offset: 0x0000BB08
			[Token(Token = "0x60010B2")]
			[Address(RVA = "0x4D47B60", Offset = "0x4D46760", VA = "0x184D47B60", Slot = "0")]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			// Token: 0x060010B3 RID: 4275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010B3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected ATypeName()
			{
			}
		}
	}
}
