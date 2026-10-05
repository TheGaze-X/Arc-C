using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001CC RID: 460
	[Token(Token = "0x20001CC")]
	internal class TypeIdentifiers
	{
		// Token: 0x060010B4 RID: 4276 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60010B4")]
		[Address(RVA = "0x4D5CA70", Offset = "0x4D5B670", VA = "0x184D5CA70")]
		internal static TypeIdentifier FromDisplay(string displayName)
		{
			return null;
		}

		// Token: 0x020001CD RID: 461
		[Token(Token = "0x20001CD")]
		private class Display : TypeNames.ATypeName, TypeIdentifier, TypeName, System.IEquatable<TypeName>
		{
			// Token: 0x060010B5 RID: 4277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60010B5")]
			[Address(RVA = "0x4D52F60", Offset = "0x4D51B60", VA = "0x184D52F60")]
			internal Display(string displayName)
			{
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x060010B6 RID: 4278 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000181")]
			public override string DisplayName
			{
				[Token(Token = "0x60010B6")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000182 RID: 386
			// (get) Token: 0x060010B7 RID: 4279 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x17000182")]
			public string InternalName
			{
				[Token(Token = "0x60010B7")]
				[Address(RVA = "0x4D52FB0", Offset = "0x4D51BB0", VA = "0x184D52FB0", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x060010B8 RID: 4280 RVA: 0x000020CA File Offset: 0x000002CA
			[Token(Token = "0x60010B8")]
			[Address(RVA = "0x4D52E70", Offset = "0x4D51A70", VA = "0x184D52E70")]
			private string GetInternalName()
			{
				return null;
			}

			// Token: 0x0400096E RID: 2414
			[Token(Token = "0x400096E")]
			[FieldOffset(Offset = "0x10")]
			private string displayName;

			// Token: 0x0400096F RID: 2415
			[Token(Token = "0x400096F")]
			[FieldOffset(Offset = "0x18")]
			private string internal_name;
		}
	}
}
