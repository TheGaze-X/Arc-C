using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000189 RID: 393
	[Token(Token = "0x2000189")]
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class DataObjectFieldAttribute : Attribute
	{
		// Token: 0x06000A0B RID: 2571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A0B")]
		[Address(RVA = "0x5141BD0", Offset = "0x51407D0", VA = "0x185141BD0")]
		public DataObjectFieldAttribute(bool primaryKey)
		{
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A0C")]
		[Address(RVA = "0x5141B80", Offset = "0x5140780", VA = "0x185141B80")]
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity)
		{
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x5141C10", Offset = "0x5140810", VA = "0x185141C10")]
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable)
		{
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x5141C60", Offset = "0x5140860", VA = "0x185141C60")]
		public DataObjectFieldAttribute(bool primaryKey, bool isIdentity, bool isNullable, int length)
		{
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000A0F RID: 2575 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x170001FA")]
		public bool IsIdentity
		{
			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x170001FB")]
		public bool IsNullable
		{
			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x00005D78 File Offset: 0x00003F78
		[Token(Token = "0x170001FC")]
		public int Length
		{
			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000A12 RID: 2578 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x170001FD")]
		public bool PrimaryKey
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x5141AE0", Offset = "0x51406E0", VA = "0x185141AE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
