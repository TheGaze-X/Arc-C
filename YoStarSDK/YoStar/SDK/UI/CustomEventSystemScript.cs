using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YoStar.SDK.UI
{
	// Token: 0x0200016F RID: 367
	[Token(Token = "0x200016F")]
	public class CustomEventSystemScript : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
	{
		// Token: 0x06000941 RID: 2369 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000941")]
		[Address(RVA = "0x3104BA0", Offset = "0x31037A0", VA = "0x183104BA0", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000942")]
		[Address(RVA = "0x5137A0", Offset = "0x5123A0", VA = "0x1805137A0", Slot = "6")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000943")]
		[Address(RVA = "0x591B740", Offset = "0x591A340", VA = "0x18591B740", Slot = "5")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public CustomEventSystemScript()
		{
		}

		// Token: 0x040005DF RID: 1503
		[Token(Token = "0x40005DF")]
		[FieldOffset(Offset = "0x18")]
		public CustomEventSystemScript.OnPointerClickCallback onPointerClickCallback;

		// Token: 0x040005E0 RID: 1504
		[Token(Token = "0x40005E0")]
		[FieldOffset(Offset = "0x20")]
		public CustomEventSystemScript.OnPointerEnterCallback onPointerEnterCallback;

		// Token: 0x040005E1 RID: 1505
		[Token(Token = "0x40005E1")]
		[FieldOffset(Offset = "0x28")]
		public CustomEventSystemScript.OnPointerExitCallback onPointerExitCallback;

		// Token: 0x02000170 RID: 368
		// (Invoke) Token: 0x06000946 RID: 2374
		[Token(Token = "0x2000170")]
		public delegate void OnPointerClickCallback(PointerEventData eventData);

		// Token: 0x02000171 RID: 369
		// (Invoke) Token: 0x0600094A RID: 2378
		[Token(Token = "0x2000171")]
		public delegate void OnPointerEnterCallback(PointerEventData eventData);

		// Token: 0x02000172 RID: 370
		// (Invoke) Token: 0x0600094E RID: 2382
		[Token(Token = "0x2000172")]
		public delegate void OnPointerExitCallback(PointerEventData eventData);
	}
}
