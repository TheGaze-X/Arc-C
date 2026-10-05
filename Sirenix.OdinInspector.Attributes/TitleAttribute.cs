using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[DontApplyToListElements]
	public class TitleAttribute : Attribute
	{
		// Token: 0x06000173 RID: 371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x4E1BBF0", Offset = "0x4E1A7F0", VA = "0x184E1BBF0")]
		public TitleAttribute(string title, [Optional] string subtitle, TitleAlignments titleAlignment = TitleAlignments.Left, bool horizontalLine = true, bool bold = true)
		{
		}

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Title;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Subtitle;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Bold;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool HorizontalLine;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TitleAlignments TitleAlignment;
	}
}
