using System;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class DisplayAsStringAttribute : Attribute
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x4E17ED0", Offset = "0x4E16AD0", VA = "0x184E17ED0")]
		public DisplayAsStringAttribute()
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x4EC7C0", Offset = "0x4EB3C0", VA = "0x1804EC7C0")]
		public DisplayAsStringAttribute(bool overflow)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x4F4D30", Offset = "0x4F3930", VA = "0x1804F4D30")]
		public DisplayAsStringAttribute(TextAlignment alignment)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x4E17F70", Offset = "0x4E16B70", VA = "0x184E17F70")]
		public DisplayAsStringAttribute(int fontSize)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x4E17F30", Offset = "0x4E16B30", VA = "0x184E17F30")]
		public DisplayAsStringAttribute(bool overflow, TextAlignment alignment)
		{
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x4E17EF0", Offset = "0x4E16AF0", VA = "0x184E17EF0")]
		public DisplayAsStringAttribute(bool overflow, int fontSize)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x4E18030", Offset = "0x4E16C30", VA = "0x184E18030")]
		public DisplayAsStringAttribute(int fontSize, TextAlignment alignment)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x4E17E80", Offset = "0x4E16A80", VA = "0x184E17E80")]
		public DisplayAsStringAttribute(bool overflow, int fontSize, TextAlignment alignment)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x4E17FF0", Offset = "0x4E16BF0", VA = "0x184E17FF0")]
		public DisplayAsStringAttribute(TextAlignment alignment, bool enableRichText)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x4E18070", Offset = "0x4E16C70", VA = "0x184E18070")]
		public DisplayAsStringAttribute(int fontSize, bool enableRichText)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4E17FA0", Offset = "0x4E16BA0", VA = "0x184E17FA0")]
		public DisplayAsStringAttribute(bool overflow, TextAlignment alignment, bool enableRichText)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4E17D90", Offset = "0x4E16990", VA = "0x184E17D90")]
		public DisplayAsStringAttribute(bool overflow, int fontSize, bool enableRichText)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4E17E30", Offset = "0x4E16A30", VA = "0x184E17E30")]
		public DisplayAsStringAttribute(int fontSize, TextAlignment alignment, bool enableRichText)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x4E17DE0", Offset = "0x4E169E0", VA = "0x184E17DE0")]
		public DisplayAsStringAttribute(bool overflow, int fontSize, TextAlignment alignment, bool enableRichText)
		{
		}

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x10")]
		public bool Overflow;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[FieldOffset(Offset = "0x14")]
		public TextAlignment Alignment;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[FieldOffset(Offset = "0x18")]
		public int FontSize;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x1C")]
		public bool EnableRichText;
	}
}
