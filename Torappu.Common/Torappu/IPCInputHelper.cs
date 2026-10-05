using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Torappu
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public interface IPCInputHelper
	{
		// Token: 0x06000053 RID: 83
		[Token(Token = "0x6000053")]
		void OnProcess();

		// Token: 0x06000054 RID: 84
		[Token(Token = "0x6000054")]
		int RegisterButton(IPCInputHelper.Input input);

		// Token: 0x06000055 RID: 85
		[Token(Token = "0x6000055")]
		void UnRegisterInstIdRelatedEntity(int instId);

		// Token: 0x06000056 RID: 86
		[Token(Token = "0x6000056")]
		void OnTouchEventTrigger();

		// Token: 0x06000057 RID: 87
		[Token(Token = "0x6000057")]
		void TriggerFullScreenScrollDelta(PointerEventData eventData);

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		public class Input
		{
			// Token: 0x06000058 RID: 88 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			[FieldOffset(Offset = "0x10")]
			public int instId;

			// Token: 0x04000051 RID: 81
			[Token(Token = "0x4000051")]
			[FieldOffset(Offset = "0x18")]
			public RectTransform targetBtn;

			// Token: 0x04000052 RID: 82
			[Token(Token = "0x4000052")]
			[FieldOffset(Offset = "0x20")]
			public KeyBoardVirtualButtonConfig buttonConfig;

			// Token: 0x04000053 RID: 83
			[Token(Token = "0x4000053")]
			[FieldOffset(Offset = "0x28")]
			public Action<PointerEventData> onKeyPress;
		}
	}
}
