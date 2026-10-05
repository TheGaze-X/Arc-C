using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Vuplex.WebView
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public interface IPointerInputDetector
	{
		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060000DC RID: 220
		// (remove) Token: 0x060000DD RID: 221
		[Token(Token = "0x14000013")]
		event EventHandler<EventArgs<Vector2>> BeganDrag;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060000DE RID: 222
		// (remove) Token: 0x060000DF RID: 223
		[Token(Token = "0x14000014")]
		event EventHandler<EventArgs<Vector2>> Dragged;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x060000E0 RID: 224
		// (remove) Token: 0x060000E1 RID: 225
		[Token(Token = "0x14000015")]
		event EventHandler<PointerEventArgs> PointerDown;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060000E2 RID: 226
		// (remove) Token: 0x060000E3 RID: 227
		[Token(Token = "0x14000016")]
		event EventHandler PointerEntered;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060000E4 RID: 228
		// (remove) Token: 0x060000E5 RID: 229
		[Token(Token = "0x14000017")]
		event EventHandler<EventArgs<Vector2>> PointerExited;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060000E6 RID: 230
		// (remove) Token: 0x060000E7 RID: 231
		[Token(Token = "0x14000018")]
		event EventHandler<EventArgs<Vector2>> PointerMoved;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060000E8 RID: 232
		// (remove) Token: 0x060000E9 RID: 233
		[Token(Token = "0x14000019")]
		event EventHandler<PointerEventArgs> PointerUp;

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060000EA RID: 234
		// (remove) Token: 0x060000EB RID: 235
		[Token(Token = "0x1400001A")]
		event EventHandler<ScrolledEventArgs> Scrolled;

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000EC RID: 236
		// (set) Token: 0x060000ED RID: 237
		[Token(Token = "0x17000014")]
		bool PointerMovedEnabled { [Token(Token = "0x60000EC")] get; [Token(Token = "0x60000ED")] set; }
	}
}
