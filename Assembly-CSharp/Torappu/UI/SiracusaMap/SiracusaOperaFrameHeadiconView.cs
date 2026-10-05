using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F45 RID: 16197
	[Token(Token = "0x2003F45")]
	public class SiracusaOperaFrameHeadiconView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019264 RID: 103012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019264")]
		[Address(RVA = "0x11DBBD0", Offset = "0x11DA7D0", VA = "0x1811DBBD0")]
		public void Render(string headIcon, UIPage page)
		{
		}

		// Token: 0x06019265 RID: 103013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019265")]
		[Address(RVA = "0x11DBC80", Offset = "0x11DA880", VA = "0x1811DBC80")]
		public SiracusaOperaFrameHeadiconView()
		{
		}

		// Token: 0x0401F290 RID: 127632
		[Token(Token = "0x401F290")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _operaHeadIcon;

		// Token: 0x0401F291 RID: 127633
		[Token(Token = "0x401F291")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F292 RID: 127634
		[Token(Token = "0x401F292")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
