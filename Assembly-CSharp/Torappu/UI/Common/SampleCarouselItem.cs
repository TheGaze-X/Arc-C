using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Common
{
	// Token: 0x02005C22 RID: 23586
	[Token(Token = "0x2005C22")]
	public class SampleCarouselItem : UICommonCarouselItem
	{
		// Token: 0x06022318 RID: 140056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022318")]
		[Address(RVA = "0x1CB19F0", Offset = "0x1CB05F0", VA = "0x181CB19F0")]
		public void Render(int count, int max)
		{
		}

		// Token: 0x06022319 RID: 140057 RVA: 0x000BC9D0 File Offset: 0x000BABD0
		[Token(Token = "0x6022319")]
		[Address(RVA = "0x1CB1990", Offset = "0x1CB0590", VA = "0x181CB1990", Slot = "4")]
		public override float GetWidth()
		{
			return 0f;
		}

		// Token: 0x0602231A RID: 140058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602231A")]
		[Address(RVA = "0x1CB1B30", Offset = "0x1CB0730", VA = "0x181CB1B30")]
		public SampleCarouselItem()
		{
		}

		// Token: 0x0402EE74 RID: 192116
		[Token(Token = "0x402EE74")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _image;

		// Token: 0x0402EE75 RID: 192117
		[Token(Token = "0x402EE75")]
		[FieldOffset(Offset = "0x20")]
		private int m_count;

		// Token: 0x0402EE76 RID: 192118
		[Token(Token = "0x402EE76")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EE77 RID: 192119
		[Token(Token = "0x402EE77")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetWidth;

		// Token: 0x0402EE78 RID: 192120
		[Token(Token = "0x402EE78")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
