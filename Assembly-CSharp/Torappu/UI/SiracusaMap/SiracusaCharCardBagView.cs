using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F02 RID: 16130
	[Token(Token = "0x2003F02")]
	public class SiracusaCharCardBagView : DataBinder<SiracusaMapPanelMapProperty>
	{
		// Token: 0x060190B0 RID: 102576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190B0")]
		[Address(RVA = "0x11ADE30", Offset = "0x11ACA30", VA = "0x1811ADE30", Slot = "7")]
		public override void OnValueChanged(SiracusaMapPanelMapProperty property)
		{
		}

		// Token: 0x060190B1 RID: 102577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190B1")]
		[Address(RVA = "0x11AE070", Offset = "0x11ACC70", VA = "0x1811AE070")]
		public void SetClosure(AutoPackSpriteHub itemSpriteHub)
		{
		}

		// Token: 0x060190B2 RID: 102578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60190B2")]
		[Address(RVA = "0x11AE0F0", Offset = "0x11ACCF0", VA = "0x1811AE0F0")]
		public SiracusaCharCardBagView()
		{
		}

		// Token: 0x0401EF81 RID: 126849
		[Token(Token = "0x401EF81")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0401EF82 RID: 126850
		[Token(Token = "0x401EF82")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textNameItaly;

		// Token: 0x0401EF83 RID: 126851
		[Token(Token = "0x401EF83")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0401EF84 RID: 126852
		[Token(Token = "0x401EF84")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCloseTip;

		// Token: 0x0401EF85 RID: 126853
		[Token(Token = "0x401EF85")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIDynImage _imgItemIcon;

		// Token: 0x0401EF86 RID: 126854
		[Token(Token = "0x401EF86")]
		[FieldOffset(Offset = "0x48")]
		private AutoPackSpriteHub m_itemSpriteHub;

		// Token: 0x0401EF87 RID: 126855
		[Token(Token = "0x401EF87")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401EF88 RID: 126856
		[Token(Token = "0x401EF88")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetClosure;

		// Token: 0x0401EF89 RID: 126857
		[Token(Token = "0x401EF89")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
