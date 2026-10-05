using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Home
{
	// Token: 0x02004C14 RID: 19476
	[Token(Token = "0x2004C14")]
	public class HomeResourceView : DataBinder<ResourceBarViewProperty>
	{
		// Token: 0x0601D423 RID: 119843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D423")]
		[Address(RVA = "0x16D5CF0", Offset = "0x16D48F0", VA = "0x1816D5CF0", Slot = "7")]
		public override void OnValueChanged(ResourceBarViewProperty property)
		{
		}

		// Token: 0x0601D424 RID: 119844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D424")]
		[Address(RVA = "0x16D5F60", Offset = "0x16D4B60", VA = "0x1816D5F60")]
		public HomeResourceView()
		{
		}

		// Token: 0x04026760 RID: 157536
		[Token(Token = "0x4026760")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textGold;

		// Token: 0x04026761 RID: 157537
		[Token(Token = "0x4026761")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textGoldShadow;

		// Token: 0x04026762 RID: 157538
		[Token(Token = "0x4026762")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCrystal;

		// Token: 0x04026763 RID: 157539
		[Token(Token = "0x4026763")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCrystalShadow;

		// Token: 0x04026764 RID: 157540
		[Token(Token = "0x4026764")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textDiamondShard;

		// Token: 0x04026765 RID: 157541
		[Token(Token = "0x4026765")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textDiamondShardShadow;

		// Token: 0x04026766 RID: 157542
		[Token(Token = "0x4026766")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04026767 RID: 157543
		[Token(Token = "0x4026767")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
