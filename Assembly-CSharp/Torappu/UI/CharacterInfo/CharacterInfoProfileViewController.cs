using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F34 RID: 24372
	[Token(Token = "0x2005F34")]
	public class CharacterInfoProfileViewController : DataBinder<CharInfoGroupProperty>
	{
		// Token: 0x060234BC RID: 144572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234BC")]
		[Address(RVA = "0x1DDB350", Offset = "0x1DD9F50", VA = "0x181DDB350", Slot = "7")]
		public override void OnValueChanged(CharInfoGroupProperty property)
		{
		}

		// Token: 0x060234BD RID: 144573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60234BD")]
		[Address(RVA = "0x1DDB6B0", Offset = "0x1DDA2B0", VA = "0x181DDB6B0")]
		public CharacterInfoProfileViewController()
		{
		}

		// Token: 0x04030AD4 RID: 199380
		[Token(Token = "0x4030AD4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _nickName;

		// Token: 0x04030AD5 RID: 199381
		[Token(Token = "0x4030AD5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _realName;

		// Token: 0x04030AD6 RID: 199382
		[Token(Token = "0x4030AD6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageCampLogo;

		// Token: 0x04030AD7 RID: 199383
		[Token(Token = "0x4030AD7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _rarityImg;

		// Token: 0x04030AD8 RID: 199384
		[Token(Token = "0x4030AD8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _btnTokenGo;

		// Token: 0x04030AD9 RID: 199385
		[Token(Token = "0x4030AD9")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04030ADA RID: 199386
		[Token(Token = "0x4030ADA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04030ADB RID: 199387
		[Token(Token = "0x4030ADB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
