using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200392F RID: 14639
	[Token(Token = "0x200392F")]
	public interface IExposure
	{
		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x06017236 RID: 94774
		[Token(Token = "0x17003742")]
		string exposureId { [Token(Token = "0x6017236")] get; }

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x06017237 RID: 94775
		[Token(Token = "0x17003743")]
		Action onExpose { [Token(Token = "0x6017237")] get; }

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x06017238 RID: 94776
		[Token(Token = "0x17003744")]
		RectTransform exposureRectTransform { [Token(Token = "0x6017238")] get; }

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x06017239 RID: 94777
		// (set) Token: 0x0601723A RID: 94778
		[Token(Token = "0x17003745")]
		Action<IExposure> registerExposure { [Token(Token = "0x6017239")] get; [Token(Token = "0x601723A")] set; }

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x0601723B RID: 94779
		// (set) Token: 0x0601723C RID: 94780
		[Token(Token = "0x17003746")]
		Action<IExposure> unregisterExposure { [Token(Token = "0x601723B")] get; [Token(Token = "0x601723C")] set; }

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x0601723D RID: 94781
		// (set) Token: 0x0601723E RID: 94782
		[Token(Token = "0x17003747")]
		Action tickExposure { [Token(Token = "0x601723D")] get; [Token(Token = "0x601723E")] set; }
	}
}
