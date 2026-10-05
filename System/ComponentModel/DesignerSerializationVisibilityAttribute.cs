using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x0200015E RID: 350
	[Token(Token = "0x200015E")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
	public sealed class DesignerSerializationVisibilityAttribute : Attribute
	{
		// Token: 0x060008EF RID: 2287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x1FF21E0", Offset = "0x1FF0DE0", VA = "0x181FF21E0")]
		public DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility visibility)
		{
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x000055C8 File Offset: 0x000037C8
		[Token(Token = "0x170001BE")]
		public DesignerSerializationVisibility Visibility
		{
			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			[CompilerGenerated]
			get
			{
				return DesignerSerializationVisibility.Hidden;
			}
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x000055E0 File Offset: 0x000037E0
		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x5122E50", Offset = "0x5121A50", VA = "0x185122E50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x000055F8 File Offset: 0x000037F8
		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x511C230", Offset = "0x511AE30", VA = "0x18511C230", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00005610 File Offset: 0x00003810
		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x5122F10", Offset = "0x5121B10", VA = "0x185122F10", Slot = "6")]
		public override bool IsDefaultAttribute()
		{
			return default(bool);
		}

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DesignerSerializationVisibilityAttribute Content;

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		[FieldOffset(Offset = "0x8")]
		public static readonly DesignerSerializationVisibilityAttribute Hidden;

		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x4000620")]
		[FieldOffset(Offset = "0x10")]
		public static readonly DesignerSerializationVisibilityAttribute Visible;

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x4000621")]
		[FieldOffset(Offset = "0x18")]
		public static readonly DesignerSerializationVisibilityAttribute Default;
	}
}
