using System;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x0200002C RID: 44
	[Token(Token = "0x200002C")]
	public interface IWithNative2DMode
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600015E RID: 350
		[Token(Token = "0x17000021")]
		bool Native2DModeEnabled { [Token(Token = "0x600015E")] get; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600015F RID: 351
		[Token(Token = "0x17000022")]
		Rect Rect { [Token(Token = "0x600015F")] get; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000160 RID: 352
		[Token(Token = "0x17000023")]
		bool Visible { [Token(Token = "0x6000160")] get; }

		// Token: 0x06000161 RID: 353
		[Token(Token = "0x6000161")]
		void BringToFront();

		// Token: 0x06000162 RID: 354
		[Token(Token = "0x6000162")]
		Task InitInNative2DMode(Rect rect);

		// Token: 0x06000163 RID: 355
		[Token(Token = "0x6000163")]
		void SetNativeZoomEnabled(bool enabled);

		// Token: 0x06000164 RID: 356
		[Token(Token = "0x6000164")]
		void SetRect(Rect rect);

		// Token: 0x06000165 RID: 357
		[Token(Token = "0x6000165")]
		void SetVisible(bool visible);
	}
}
