using System;
using Il2CppDummyDll;

namespace System.Resources
{
	// Token: 0x020004DD RID: 1245
	[Token(Token = "0x20004DD")]
	internal struct ResourceLocator
	{
		// Token: 0x060023EA RID: 9194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023EA")]
		[Address(RVA = "0x4BB0A00", Offset = "0x4BAF600", VA = "0x184BB0A00")]
		internal ResourceLocator(int dataPos, object value)
		{
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x00014418 File Offset: 0x00012618
		[Token(Token = "0x170004A3")]
		internal int DataPosition
		{
			[Token(Token = "0x60023EB")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x000020CA File Offset: 0x000002CA
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004A4")]
		internal object Value
		{
			[Token(Token = "0x60023EC")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
			[Token(Token = "0x60023ED")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			set
			{
			}
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x00014430 File Offset: 0x00012630
		[Token(Token = "0x60023EE")]
		[Address(RVA = "0x4BDCED0", Offset = "0x4BDBAD0", VA = "0x184BDCED0")]
		internal static bool CanCache(ResourceTypeCode value)
		{
			return default(bool);
		}

		// Token: 0x0400146C RID: 5228
		[Token(Token = "0x400146C")]
		[FieldOffset(Offset = "0x0")]
		internal object _value;

		// Token: 0x0400146D RID: 5229
		[Token(Token = "0x400146D")]
		[FieldOffset(Offset = "0x8")]
		internal int _dataPos;
	}
}
