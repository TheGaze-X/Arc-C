using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F8B RID: 16267
	[Token(Token = "0x2003F8B")]
	public class SiracusaMapCoinView : DataBinder<SiracusaMapPanelMapProperty>
	{
		// Token: 0x060193D2 RID: 103378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193D2")]
		[Address(RVA = "0x11EC390", Offset = "0x11EAF90", VA = "0x1811EC390", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x060193D3 RID: 103379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193D3")]
		[Address(RVA = "0x11EC750", Offset = "0x11EB350", VA = "0x1811EC750")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060193D4 RID: 103380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193D4")]
		[Address(RVA = "0x11EC820", Offset = "0x11EB420", VA = "0x1811EC820")]
		public SiracusaMapCoinView()
		{
		}

		// Token: 0x0401F50B RID: 128267
		[Token(Token = "0x401F50B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Coin")]
		private Text _coinCount;

		// Token: 0x0401F50C RID: 128268
		[Token(Token = "0x401F50C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Coin")]
		private GameObject _coinGameObject;

		// Token: 0x0401F50D RID: 128269
		[Token(Token = "0x401F50D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401F50E RID: 128270
		[Token(Token = "0x401F50E")]
		[FieldOffset(Offset = "0x38")]
		private UISwitchTween m_fadeTween;

		// Token: 0x0401F50F RID: 128271
		[Token(Token = "0x401F50F")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0401F510 RID: 128272
		[Token(Token = "0x401F510")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401F511 RID: 128273
		[Token(Token = "0x401F511")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401F512 RID: 128274
		[Token(Token = "0x401F512")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
