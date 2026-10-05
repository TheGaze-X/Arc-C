using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004102 RID: 16642
	[Token(Token = "0x2004102")]
	public class SandboxV2AdminShopItemDetailTopBarView : DataBinder<SandboxV2AdminShopItemDetailProperty>, IHotfixable
	{
		// Token: 0x06019BC9 RID: 105417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BC9")]
		[Address(RVA = "0x1292560", Offset = "0x1291160", VA = "0x181292560", Slot = "7")]
		public override void OnValueChanged(SandboxV2AdminShopItemDetailProperty property)
		{
		}

		// Token: 0x06019BCA RID: 105418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BCA")]
		[Address(RVA = "0x1292880", Offset = "0x1291480", VA = "0x181292880")]
		public SandboxV2AdminShopItemDetailTopBarView()
		{
		}

		// Token: 0x040203A8 RID: 132008
		[Token(Token = "0x40203A8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelGold;

		// Token: 0x040203A9 RID: 132009
		[Token(Token = "0x40203A9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgGold;

		// Token: 0x040203AA RID: 132010
		[Token(Token = "0x40203AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textGold;

		// Token: 0x040203AB RID: 132011
		[Token(Token = "0x40203AB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelDimensionCoin;

		// Token: 0x040203AC RID: 132012
		[Token(Token = "0x40203AC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgDimensionCoin;

		// Token: 0x040203AD RID: 132013
		[Token(Token = "0x40203AD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDimensionCoin;

		// Token: 0x040203AE RID: 132014
		[Token(Token = "0x40203AE")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040203AF RID: 132015
		[Token(Token = "0x40203AF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040203B0 RID: 132016
		[Token(Token = "0x40203B0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
