using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public class LabelTextAttribute : Attribute
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
		public LabelTextAttribute(string text)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x4E18C30", Offset = "0x4E17830", VA = "0x184E18C30")]
		public LabelTextAttribute(SdfIconType icon)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x4CEC6B0", Offset = "0x4CEB2B0", VA = "0x184CEC6B0")]
		public LabelTextAttribute(string text, bool nicifyText)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x4E18BE0", Offset = "0x4E177E0", VA = "0x184E18BE0")]
		public LabelTextAttribute(string text, SdfIconType icon)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x4E18C60", Offset = "0x4E17860", VA = "0x184E18C60")]
		public LabelTextAttribute(string text, bool nicifyText, SdfIconType icon)
		{
		}

		// Token: 0x0400008F RID: 143
		[Token(Token = "0x400008F")]
		[FieldOffset(Offset = "0x10")]
		public string Text;

		// Token: 0x04000090 RID: 144
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x18")]
		public bool NicifyText;

		// Token: 0x04000091 RID: 145
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x1C")]
		public SdfIconType Icon;

		// Token: 0x04000092 RID: 146
		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x20")]
		public string IconColor;
	}
}
