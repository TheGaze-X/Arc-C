using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap.Chat
{
	// Token: 0x02003FCA RID: 16330
	[Token(Token = "0x2003FCA")]
	public abstract class SiracusaChatSwitchableComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x060194FE RID: 103678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194FE")]
		[Address(RVA = "0x1208DC0", Offset = "0x12079C0", VA = "0x181208DC0")]
		protected void _SetDisplay(bool isShow, bool useFastMode)
		{
		}

		// Token: 0x060194FF RID: 103679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60194FF")]
		[Address(RVA = "0x1208F90", Offset = "0x1207B90", VA = "0x181208F90")]
		protected SiracusaChatSwitchableComp()
		{
		}

		// Token: 0x0401F72C RID: 128812
		[Token(Token = "0x401F72C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("FadeIn")]
		private float _fadeInPos;

		// Token: 0x0401F72D RID: 128813
		[Token(Token = "0x401F72D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("FadeIn")]
		private CanvasGroup _fadeInAlpha;

		// Token: 0x0401F72E RID: 128814
		[Token(Token = "0x401F72E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("FadeIn")]
		private RectTransform _fadeInTrans;

		// Token: 0x0401F72F RID: 128815
		[Token(Token = "0x401F72F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("FadeIn")]
		private float _fadeInDuration;

		// Token: 0x0401F730 RID: 128816
		[Token(Token = "0x401F730")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected float _postDelay;

		// Token: 0x0401F731 RID: 128817
		[Token(Token = "0x401F731")]
		[FieldOffset(Offset = "0x38")]
		protected FadeTranslationSwitchTween m_switchTween;

		// Token: 0x0401F732 RID: 128818
		[Token(Token = "0x401F732")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetDisplay;

		// Token: 0x0401F733 RID: 128819
		[Token(Token = "0x401F733")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
