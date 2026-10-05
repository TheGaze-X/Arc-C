using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039AA RID: 14762
	[Token(Token = "0x20039AA")]
	[RequireComponent(typeof(ScrollRect))]
	public class ScrollViewMoveToughPager : ScrollViewPager
	{
		// Token: 0x06017544 RID: 95556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017544")]
		[Address(RVA = "0xFB3870", Offset = "0xFB2470", VA = "0x180FB3870", Slot = "10")]
		protected override void _OnBeginDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06017545 RID: 95557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017545")]
		[Address(RVA = "0xFB3980", Offset = "0xFB2580", VA = "0x180FB3980", Slot = "11")]
		protected override void _OnEndDrag(PointerEventData eventData)
		{
		}

		// Token: 0x06017546 RID: 95558 RVA: 0x00096048 File Offset: 0x00094248
		[Token(Token = "0x6017546")]
		[Address(RVA = "0xFB3B50", Offset = "0xFB2750", VA = "0x180FB3B50", Slot = "12")]
		protected override float _ScrollValue2PageIndex(float value)
		{
			return 0f;
		}

		// Token: 0x06017547 RID: 95559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017547")]
		[Address(RVA = "0xFB3BE0", Offset = "0xFB27E0", VA = "0x180FB3BE0")]
		public ScrollViewMoveToughPager()
		{
		}

		// Token: 0x06017548 RID: 95560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017548")]
		[Address(RVA = "0xFB3630", Offset = "0xFB2230", VA = "0x180FB3630")]
		private void <>xLuaBaseProxy__OnBeginDrag(PointerEventData P0)
		{
		}

		// Token: 0x06017549 RID: 95561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017549")]
		[Address(RVA = "0xFB3700", Offset = "0xFB2300", VA = "0x180FB3700")]
		private void <>xLuaBaseProxy__OnEndDrag(PointerEventData P0)
		{
		}

		// Token: 0x0601754A RID: 95562 RVA: 0x00096060 File Offset: 0x00094260
		[Token(Token = "0x601754A")]
		[Address(RVA = "0xFB37E0", Offset = "0xFB23E0", VA = "0x180FB37E0")]
		private float <>xLuaBaseProxy__ScrollValue2PageIndex(float P0)
		{
			return 0f;
		}

		// Token: 0x0401C28E RID: 115342
		[Token(Token = "0x401C28E")]
		[FieldOffset(Offset = "0x88")]
		private DateTime m_time;

		// Token: 0x0401C28F RID: 115343
		[Token(Token = "0x401C28F")]
		[FieldOffset(Offset = "0x90")]
		private float m_cache;

		// Token: 0x0401C290 RID: 115344
		[Token(Token = "0x401C290")]
		private const float DELTATHEROTIME = 500f;

		// Token: 0x0401C291 RID: 115345
		[Token(Token = "0x401C291")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__OnBeginDrag;

		// Token: 0x0401C292 RID: 115346
		[Token(Token = "0x401C292")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnEndDrag;

		// Token: 0x0401C293 RID: 115347
		[Token(Token = "0x401C293")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ScrollValue2PageIndex;

		// Token: 0x0401C294 RID: 115348
		[Token(Token = "0x401C294")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
