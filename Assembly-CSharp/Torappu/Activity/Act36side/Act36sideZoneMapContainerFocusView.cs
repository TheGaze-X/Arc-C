using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x0200746F RID: 29807
	[Token(Token = "0x200746F")]
	public class Act36sideZoneMapContainerFocusView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A0BB RID: 172219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0BB")]
		[Address(RVA = "0x25A23E0", Offset = "0x25A0FE0", VA = "0x1825A23E0")]
		public void RenderStable(int focusIndex, Act36sideZoneMapCardBackView cardBackView, Act36sideZoneFocusAnimView animViewPrefab, bool fastMode)
		{
		}

		// Token: 0x0602A0BC RID: 172220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0BC")]
		[Address(RVA = "0x25A2640", Offset = "0x25A1240", VA = "0x1825A2640")]
		public void RenderUnStable()
		{
		}

		// Token: 0x0602A0BD RID: 172221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A0BD")]
		[Address(RVA = "0x25A2710", Offset = "0x25A1310", VA = "0x1825A2710")]
		public Act36sideZoneMapContainerFocusView()
		{
		}

		// Token: 0x0403C545 RID: 247109
		[Token(Token = "0x403C545")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _cardImg;

		// Token: 0x0403C546 RID: 247110
		[Token(Token = "0x403C546")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _frontAnimContainer;

		// Token: 0x0403C547 RID: 247111
		[Token(Token = "0x403C547")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act36sideZoneFocusAnimView _animView;

		// Token: 0x0403C548 RID: 247112
		[Token(Token = "0x403C548")]
		[FieldOffset(Offset = "0x30")]
		private int m_cachedFocusIndex;

		// Token: 0x0403C549 RID: 247113
		[Token(Token = "0x403C549")]
		[FieldOffset(Offset = "0x38")]
		private Act36sideZoneFocusAnimView m_frontAnimView;

		// Token: 0x0403C54A RID: 247114
		[Token(Token = "0x403C54A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderStable;

		// Token: 0x0403C54B RID: 247115
		[Token(Token = "0x403C54B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderUnStable;

		// Token: 0x0403C54C RID: 247116
		[Token(Token = "0x403C54C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
