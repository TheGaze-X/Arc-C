using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Common
{
	// Token: 0x02005C23 RID: 23587
	[Token(Token = "0x2005C23")]
	public class SampleCarouselTest : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602231B RID: 140059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602231B")]
		[Address(RVA = "0x1CB2160", Offset = "0x1CB0D60", VA = "0x181CB2160")]
		private void Start()
		{
		}

		// Token: 0x0602231C RID: 140060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602231C")]
		[Address(RVA = "0x1CB1BD0", Offset = "0x1CB07D0", VA = "0x181CB1BD0")]
		public void Render()
		{
		}

		// Token: 0x0602231D RID: 140061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602231D")]
		[Address(RVA = "0x1CB21C0", Offset = "0x1CB0DC0", VA = "0x181CB21C0")]
		public SampleCarouselTest()
		{
		}

		// Token: 0x0402EE79 RID: 192121
		[Token(Token = "0x402EE79")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICommonCarousel _commonCarousel;

		// Token: 0x0402EE7A RID: 192122
		[Token(Token = "0x402EE7A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SampleCarouselItem _item;

		// Token: 0x0402EE7B RID: 192123
		[Token(Token = "0x402EE7B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _count;

		// Token: 0x0402EE7C RID: 192124
		[Token(Token = "0x402EE7C")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float speed;

		// Token: 0x0402EE7D RID: 192125
		[Token(Token = "0x402EE7D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0402EE7E RID: 192126
		[Token(Token = "0x402EE7E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EE7F RID: 192127
		[Token(Token = "0x402EE7F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
