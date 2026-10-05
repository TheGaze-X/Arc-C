using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200014A RID: 330
	[Token(Token = "0x200014A")]
	internal class TextEditorEventHandler
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000939 RID: 2361 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600093A RID: 2362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EB")]
		private protected TextEditorEngine editorEngine
		{
			[Token(Token = "0x6000939")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600093A")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600093B RID: 2363 RVA: 0x0000212A File Offset: 0x0000032A
		// (set) Token: 0x0600093C RID: 2364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001EC")]
		private protected ITextInputField textInputField
		{
			[Token(Token = "0x600093B")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600093C")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093D")]
		[Address(RVA = "0x5ACACB0", Offset = "0x5AC98B0", VA = "0x185ACACB0")]
		protected TextEditorEventHandler(TextEditorEngine editorEngine, ITextInputField textInputField)
		{
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
		public virtual void ExecuteDefaultActionAtTarget(EventBase evt)
		{
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600093F")]
		[Address(RVA = "0x5ACAB50", Offset = "0x5AC9750", VA = "0x185ACAB50", Slot = "5")]
		public virtual void ExecuteDefaultAction(EventBase evt)
		{
		}
	}
}
