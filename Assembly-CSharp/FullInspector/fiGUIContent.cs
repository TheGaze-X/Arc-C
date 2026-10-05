using System;
using Il2CppDummyDll;
using UnityEngine;

namespace FullInspector
{
	// Token: 0x02007BC8 RID: 31688
	[Token(Token = "0x2007BC8")]
	public class fiGUIContent
	{
		// Token: 0x0602C5A6 RID: 181670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5A6")]
		[Address(RVA = "0x2868370", Offset = "0x2866F70", VA = "0x182868370")]
		public fiGUIContent()
		{
		}

		// Token: 0x0602C5A7 RID: 181671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5A7")]
		[Address(RVA = "0x2868280", Offset = "0x2866E80", VA = "0x182868280")]
		public fiGUIContent(string text)
		{
		}

		// Token: 0x0602C5A8 RID: 181672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5A8")]
		[Address(RVA = "0x2868310", Offset = "0x2866F10", VA = "0x182868310")]
		public fiGUIContent(string text, string tooltip)
		{
		}

		// Token: 0x0602C5A9 RID: 181673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5A9")]
		[Address(RVA = "0x22FF1A0", Offset = "0x22FDDA0", VA = "0x1822FF1A0")]
		public fiGUIContent(string text, string tooltip, Texture image)
		{
		}

		// Token: 0x0602C5AA RID: 181674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5AA")]
		[Address(RVA = "0x2868170", Offset = "0x2866D70", VA = "0x182868170")]
		public fiGUIContent(Texture image)
		{
		}

		// Token: 0x0602C5AB RID: 181675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C5AB")]
		[Address(RVA = "0x28681F0", Offset = "0x2866DF0", VA = "0x1828681F0")]
		public fiGUIContent(Texture image, string tooltip)
		{
		}

		// Token: 0x170067D6 RID: 26582
		// (get) Token: 0x0602C5AC RID: 181676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170067D6")]
		public GUIContent AsGUIContent
		{
			[Token(Token = "0x602C5AC")]
			[Address(RVA = "0x28683F0", Offset = "0x2866FF0", VA = "0x1828683F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170067D7 RID: 26583
		// (get) Token: 0x0602C5AD RID: 181677 RVA: 0x000DFB60 File Offset: 0x000DDD60
		[Token(Token = "0x170067D7")]
		public bool IsEmpty
		{
			[Token(Token = "0x602C5AD")]
			[Address(RVA = "0x2868480", Offset = "0x2867080", VA = "0x182868480")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602C5AE RID: 181678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5AE")]
		[Address(RVA = "0x2868500", Offset = "0x2867100", VA = "0x182868500")]
		public static implicit operator GUIContent(fiGUIContent label)
		{
			return null;
		}

		// Token: 0x0602C5AF RID: 181679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5AF")]
		[Address(RVA = "0x28685E0", Offset = "0x28671E0", VA = "0x1828685E0")]
		public static implicit operator fiGUIContent(string text)
		{
			return null;
		}

		// Token: 0x0602C5B0 RID: 181680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C5B0")]
		[Address(RVA = "0x2868650", Offset = "0x2867250", VA = "0x182868650")]
		public static implicit operator fiGUIContent(GUIContent label)
		{
			return null;
		}

		// Token: 0x04040229 RID: 262697
		[Token(Token = "0x4040229")]
		[FieldOffset(Offset = "0x0")]
		public static fiGUIContent Empty;

		// Token: 0x0404022A RID: 262698
		[Token(Token = "0x404022A")]
		[FieldOffset(Offset = "0x10")]
		private string _text;

		// Token: 0x0404022B RID: 262699
		[Token(Token = "0x404022B")]
		[FieldOffset(Offset = "0x18")]
		private string _tooltip;

		// Token: 0x0404022C RID: 262700
		[Token(Token = "0x404022C")]
		[FieldOffset(Offset = "0x20")]
		private Texture _image;
	}
}
