using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace TMPro
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	public interface ITextElement
	{
		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004A0 RID: 1184
		[Token(Token = "0x17000109")]
		Material sharedMaterial { [Token(Token = "0x60004A0")] get; }

		// Token: 0x060004A1 RID: 1185
		[Token(Token = "0x60004A1")]
		void Rebuild(CanvasUpdate update);

		// Token: 0x060004A2 RID: 1186
		[Token(Token = "0x60004A2")]
		int GetInstanceID();
	}
}
