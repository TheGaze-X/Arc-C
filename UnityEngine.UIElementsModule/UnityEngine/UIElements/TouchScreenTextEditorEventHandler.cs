using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000159 RID: 345
	[Token(Token = "0x2000159")]
	internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler
	{
		// Token: 0x060009CE RID: 2510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x5ACCFF0", Offset = "0x5ACBBF0", VA = "0x185ACCFF0")]
		public TouchScreenTextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField)
		{
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x5ACCE50", Offset = "0x5ACBA50", VA = "0x185ACCE50")]
		private void PollTouchScreenKeyboard()
		{
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x5ACC6A0", Offset = "0x5ACB2A0", VA = "0x185ACC6A0")]
		private void DoPollTouchScreenKeyboard()
		{
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x5ACC9F0", Offset = "0x5ACB5F0", VA = "0x185ACC9F0", Slot = "4")]
		public override void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x20")]
		private IVisualElementScheduledItem m_TouchKeyboardPoller;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x28")]
		private VisualElement m_LastPointerDownTarget;
	}
}
