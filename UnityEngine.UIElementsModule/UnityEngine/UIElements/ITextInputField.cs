using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000152 RID: 338
	[Token(Token = "0x2000152")]
	internal interface ITextInputField : IEventHandler, ITextElement
	{
		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000961 RID: 2401
		[Token(Token = "0x170001F4")]
		bool hasFocus { [Token(Token = "0x6000961")] get; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000962 RID: 2402
		[Token(Token = "0x170001F5")]
		bool doubleClickSelectsWord { [Token(Token = "0x6000962")] get; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000963 RID: 2403
		[Token(Token = "0x170001F6")]
		bool tripleClickSelectsLine { [Token(Token = "0x6000963")] get; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000964 RID: 2404
		[Token(Token = "0x170001F7")]
		bool isReadOnly { [Token(Token = "0x6000964")] get; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000965 RID: 2405
		[Token(Token = "0x170001F8")]
		bool isDelayed { [Token(Token = "0x6000965")] get; }

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000966 RID: 2406
		[Token(Token = "0x170001F9")]
		bool isPasswordField { [Token(Token = "0x6000966")] get; }

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000967 RID: 2407
		[Token(Token = "0x170001FA")]
		TextEditorEngine editorEngine { [Token(Token = "0x6000967")] get; }

		// Token: 0x06000968 RID: 2408
		[Token(Token = "0x6000968")]
		void SyncTextEngine();

		// Token: 0x06000969 RID: 2409
		[Token(Token = "0x6000969")]
		bool AcceptCharacter(char c);

		// Token: 0x0600096A RID: 2410
		[Token(Token = "0x600096A")]
		string CullString(string s);

		// Token: 0x0600096B RID: 2411
		[Token(Token = "0x600096B")]
		void UpdateText(string value);

		// Token: 0x0600096C RID: 2412
		[Token(Token = "0x600096C")]
		void UpdateValueFromText();
	}
}
