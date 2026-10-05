using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004BF3 RID: 19443
	[Token(Token = "0x2004BF3")]
	public class HomeActivityView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D36F RID: 119663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D36F")]
		[Address(RVA = "0x16BE610", Offset = "0x16BD210", VA = "0x1816BE610")]
		public void EventOnBannerClick()
		{
		}

		// Token: 0x0601D370 RID: 119664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D370")]
		[Address(RVA = "0x16BE710", Offset = "0x16BD310", VA = "0x1816BE710")]
		public void Render(ActivityViewEntry entry)
		{
		}

		// Token: 0x0601D371 RID: 119665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D371")]
		[Address(RVA = "0x16BE6A0", Offset = "0x16BD2A0", VA = "0x1816BE6A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601D372 RID: 119666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D372")]
		[Address(RVA = "0x16BE820", Offset = "0x16BD420", VA = "0x1816BE820")]
		public HomeActivityView()
		{
		}

		// Token: 0x040265F9 RID: 157177
		[Token(Token = "0x40265F9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _background;

		// Token: 0x040265FA RID: 157178
		[Token(Token = "0x40265FA")]
		[FieldOffset(Offset = "0x20")]
		private ActivityViewEntry m_entry;

		// Token: 0x040265FB RID: 157179
		[Token(Token = "0x40265FB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnBannerClick;

		// Token: 0x040265FC RID: 157180
		[Token(Token = "0x40265FC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040265FD RID: 157181
		[Token(Token = "0x40265FD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x040265FE RID: 157182
		[Token(Token = "0x40265FE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
