using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AF2 RID: 6898
	[Token(Token = "0x2001AF2")]
	public class BuildingCharCtrlTouchBtn : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600AE54 RID: 44628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE54")]
		[Address(RVA = "0x328E940", Offset = "0x328D540", VA = "0x18328E940")]
		public void Render(bool isEnable, bool isActive)
		{
		}

		// Token: 0x0600AE55 RID: 44629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE55")]
		[Address(RVA = "0x328EB20", Offset = "0x328D720", VA = "0x18328EB20")]
		public BuildingCharCtrlTouchBtn()
		{
		}

		// Token: 0x0400A6E1 RID: 42721
		[Token(Token = "0x400A6E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroupEnable;

		// Token: 0x0400A6E2 RID: 42722
		[Token(Token = "0x400A6E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroupActive;

		// Token: 0x0400A6E3 RID: 42723
		[Token(Token = "0x400A6E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _btnTouch;

		// Token: 0x0400A6E4 RID: 42724
		[Token(Token = "0x400A6E4")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_enableFadeTween;

		// Token: 0x0400A6E5 RID: 42725
		[Token(Token = "0x400A6E5")]
		[FieldOffset(Offset = "0x38")]
		private FadeSwitchTween m_activeFadeTween;

		// Token: 0x0400A6E6 RID: 42726
		[Token(Token = "0x400A6E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400A6E7 RID: 42727
		[Token(Token = "0x400A6E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
