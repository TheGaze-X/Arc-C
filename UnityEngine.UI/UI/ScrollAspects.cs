using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000090 RID: 144
	[Token(Token = "0x2000090")]
	public abstract class ScrollAspects
	{
		// Token: 0x060005A3 RID: 1443
		[Token(Token = "0x60005A3")]
		public abstract void OnEnable(ScrollRect scrollRect);

		// Token: 0x060005A4 RID: 1444
		[Token(Token = "0x60005A4")]
		public abstract void OnUpdate(float deltaTime, ScrollRect scrollRect);

		// Token: 0x060005A5 RID: 1445
		[Token(Token = "0x60005A5")]
		public abstract void OnScrollEvent(PointerEventData data, ScrollRect scrollRect);

		// Token: 0x060005A6 RID: 1446
		[Token(Token = "0x60005A6")]
		public abstract void OnScrollHandle(Vector2 delta, ScrollRect scrollRect);

		// Token: 0x060005A7 RID: 1447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ScrollAspects()
		{
		}
	}
}
