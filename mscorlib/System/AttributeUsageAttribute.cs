using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	[System.AttributeUsage(System.AttributeTargets.Class, Inherited = true)]
	[System.Serializable]
	public sealed class AttributeUsageAttribute : System.Attribute
	{
		// Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x4CA5420", Offset = "0x4CA4020", VA = "0x184CA5420")]
		public AttributeUsageAttribute(System.AttributeTargets validOn)
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00004380 File Offset: 0x00002580
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000069")]
		public bool AllowMultiple
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x4E8AE0", Offset = "0x4E76E0", VA = "0x1804E8AE0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000468")]
			[Address(RVA = "0x4EAC50", Offset = "0x4E9850", VA = "0x1804EAC50")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x00004398 File Offset: 0x00002598
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006A")]
		public bool Inherited
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x780A90", Offset = "0x77F690", VA = "0x180780A90")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x4CA5450", Offset = "0x4CA4050", VA = "0x184CA5450")]
			set
			{
			}
		}

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[FieldOffset(Offset = "0x10")]
		private System.AttributeTargets _attributeTarget;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[FieldOffset(Offset = "0x14")]
		private bool _allowMultiple;

		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		[FieldOffset(Offset = "0x15")]
		private bool _inherited;

		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		[FieldOffset(Offset = "0x0")]
		internal static System.AttributeUsageAttribute Default;
	}
}
