using System;
using System.Globalization;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001E0 RID: 480
	[Token(Token = "0x20001E0")]
	public class SingleConverter : BaseNumberConverter
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00007200 File Offset: 0x00005400
		[Token(Token = "0x170002A8")]
		internal override bool AllowHex
		{
			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002A9")]
		internal override Type TargetType
		{
			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x5174030", Offset = "0x5172C30", VA = "0x185174030", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x5173EE0", Offset = "0x5172AE0", VA = "0x185173EE0", Slot = "18")]
		internal override object FromString(string value, int radix)
		{
			return null;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x5173E70", Offset = "0x5172A70", VA = "0x185173E70", Slot = "19")]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			return null;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x5173F90", Offset = "0x5172B90", VA = "0x185173F90", Slot = "20")]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			return null;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x286AC00", Offset = "0x2869800", VA = "0x18286AC00")]
		public SingleConverter()
		{
		}
	}
}
