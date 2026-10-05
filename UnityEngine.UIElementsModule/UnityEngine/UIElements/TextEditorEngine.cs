using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014B RID: 331
	[Token(Token = "0x200014B")]
	internal class TextEditorEngine : TextEditor
	{
		// Token: 0x06000940 RID: 2368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000940")]
		[Address(RVA = "0x5ACAA40", Offset = "0x5AC9640", VA = "0x185ACAA40")]
		public TextEditorEngine(TextEditorEngine.OnDetectFocusChangeFunction detectFocusChange, TextEditorEngine.OnIndexChangeFunction indexChangeFunction)
		{
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x00005670 File Offset: 0x00003870
		[Token(Token = "0x170001ED")]
		internal override Rect localPosition
		{
			[Token(Token = "0x6000941")]
			[Address(RVA = "0x5ACAAA0", Offset = "0x5AC96A0", VA = "0x185ACAAA0", Slot = "4")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x5ACAA10", Offset = "0x5AC9610", VA = "0x185ACAA10", Slot = "5")]
		internal override void OnDetectFocusChange()
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x5ACA9E0", Offset = "0x5AC95E0", VA = "0x185ACA9E0", Slot = "6")]
		internal override void OnCursorIndexChange()
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x5ACA9E0", Offset = "0x5AC95E0", VA = "0x185ACA9E0", Slot = "7")]
		internal override void OnSelectIndexChange()
		{
		}

		// Token: 0x04000529 RID: 1321
		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x90")]
		private TextEditorEngine.OnDetectFocusChangeFunction m_DetectFocusChangeFunction;

		// Token: 0x0400052A RID: 1322
		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x98")]
		private TextEditorEngine.OnIndexChangeFunction m_IndexChangeFunction;

		// Token: 0x0200014C RID: 332
		// (Invoke) Token: 0x06000946 RID: 2374
		[Token(Token = "0x200014C")]
		internal delegate void OnDetectFocusChangeFunction();

		// Token: 0x0200014D RID: 333
		// (Invoke) Token: 0x06000948 RID: 2376
		[Token(Token = "0x200014D")]
		internal delegate void OnIndexChangeFunction();
	}
}
