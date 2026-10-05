using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	internal class KeyboardTextEditorEventHandler : TextEditorEventHandler
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00005178 File Offset: 0x00003378
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001B3")]
		private bool isClicking
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x5AB73F0", Offset = "0x5AB5FF0", VA = "0x185AB73F0")]
			set
			{
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x5AB7350", Offset = "0x5AB5F50", VA = "0x185AB7350")]
		public KeyboardTextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField)
		{
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x5AB5310", Offset = "0x5AB3F10", VA = "0x185AB5310", Slot = "4")]
		public override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x5AB5FE0", Offset = "0x5AB4BE0", VA = "0x185AB5FE0")]
		private void OnFocus(FocusEvent _)
		{
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x5AB5C40", Offset = "0x5AB4840", VA = "0x185AB5C40")]
		private void OnBlur(BlurEvent _)
		{
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x5AB65E0", Offset = "0x5AB51E0", VA = "0x185AB65E0")]
		private void OnMouseDown(MouseDownEvent evt)
		{
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x5AB6B60", Offset = "0x5AB5760", VA = "0x185AB6B60")]
		private void OnMouseUp(MouseUpEvent evt)
		{
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x5AB6930", Offset = "0x5AB5530", VA = "0x185AB6930")]
		private void OnMouseMove(MouseMoveEvent evt)
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x5AB71E0", Offset = "0x5AB5DE0", VA = "0x185AB71E0")]
		private void ProcessDragMove(MouseMoveEvent evt)
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x5AB5C00", Offset = "0x5AB4800", VA = "0x185AB5C00")]
		private bool MoveDistanceQualifiesForDrag(Vector2 start, Vector2 current)
		{
			return default(bool);
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x5AB6140", Offset = "0x5AB4D40", VA = "0x185AB6140")]
		private void OnKeyDown(KeyDownEvent evt)
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x5AB6C70", Offset = "0x5AB5870", VA = "0x185AB6C70")]
		private void OnValidateCommandEvent(ValidateCommandEvent evt)
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x5AB5C50", Offset = "0x5AB4850", VA = "0x185AB5C50")]
		private void OnExecuteCommandEvent(ExecuteCommandEvent evt)
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x5AB6EF0", Offset = "0x5AB5AF0", VA = "0x185AB6EF0")]
		public void PreDrawCursor(string newText)
		{
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x5AB6EC0", Offset = "0x5AB5AC0", VA = "0x185AB6EC0")]
		public void PostDrawCursor()
		{
		}

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x20")]
		internal bool m_Changed;

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		[FieldOffset(Offset = "0x21")]
		private bool m_Dragged;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		[FieldOffset(Offset = "0x22")]
		private bool m_DragToPosition;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x23")]
		private bool m_SelectAllOnMouseUp;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x28")]
		private string m_PreDrawCursorText;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x30")]
		private bool m_IsClicking;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x34")]
		private Vector2 m_ClickStartPosition;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0x40")]
		private readonly Event m_ImguiEvent;
	}
}
