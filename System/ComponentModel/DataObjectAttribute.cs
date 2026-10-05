using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000188 RID: 392
	[Token(Token = "0x2000188")]
	[AttributeUsage(AttributeTargets.Class)]
	public sealed class DataObjectAttribute : Attribute
	{
		// Token: 0x06000A04 RID: 2564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x4E17ED0", Offset = "0x4E16AD0", VA = "0x184E17ED0")]
		public DataObjectAttribute()
		{
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000A05")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public DataObjectAttribute(bool isDataObject)
		{
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000A06 RID: 2566 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x170001F9")]
		public bool IsDataObject
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x6000A07")]
		[Address(RVA = "0x5141870", Offset = "0x5140470", VA = "0x185141870", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x6000A08")]
		[Address(RVA = "0x51418F0", Offset = "0x51404F0", VA = "0x1851418F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x00005D30 File Offset: 0x00003F30
		[Token(Token = "0x6000A09")]
		[Address(RVA = "0x5141950", Offset = "0x5140550", VA = "0x185141950", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DataObjectAttribute DataObject;

		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DataObjectAttribute NonDataObject;

		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DataObjectAttribute Default;
	}
}
