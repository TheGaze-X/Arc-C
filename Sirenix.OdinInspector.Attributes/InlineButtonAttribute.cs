using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200003E RID: 62
	[Token(Token = "0x200003E")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[DontApplyToListElements]
	public sealed class InlineButtonAttribute : Attribute
	{
		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000020")]
		[Obsolete("Use the Action member instead.", false)]
		public string MemberMethod
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2637490", Offset = "0x2636090", VA = "0x182637490")]
		public InlineButtonAttribute(string action, [Optional] string label)
		{
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x4E189F0", Offset = "0x4E175F0", VA = "0x184E189F0")]
		public InlineButtonAttribute(string action, SdfIconType icon, [Optional] string label)
		{
		}

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Action;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Label;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ShowIf;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string ButtonColor;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string TextColor;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SdfIconType Icon;

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public IconAlignment IconAlignment;
	}
}
