using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003537 RID: 13623
	[Token(Token = "0x2003537")]
	public class UICharacterHandbookStageCountItem : DataBinder<IntProperty>
	{
		// Token: 0x06015B6B RID: 88939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B6B")]
		[Address(RVA = "0xE4EBC0", Offset = "0xE4D7C0", VA = "0x180E4EBC0", Slot = "7")]
		public override void OnValueChanged(IntProperty property)
		{
		}

		// Token: 0x06015B6C RID: 88940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B6C")]
		[Address(RVA = "0xE4EA90", Offset = "0xE4D690", VA = "0x180E4EA90")]
		public void ChangeColor(Color textColor, Color bgColor)
		{
		}

		// Token: 0x06015B6D RID: 88941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B6D")]
		[Address(RVA = "0xE4ECC0", Offset = "0xE4D8C0", VA = "0x180E4ECC0")]
		public UICharacterHandbookStageCountItem()
		{
		}

		// Token: 0x0401A168 RID: 106856
		[Token(Token = "0x401A168")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0401A169 RID: 106857
		[Token(Token = "0x401A169")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _trackItemBg;

		// Token: 0x0401A16A RID: 106858
		[Token(Token = "0x401A16A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401A16B RID: 106859
		[Token(Token = "0x401A16B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ChangeColor;

		// Token: 0x0401A16C RID: 106860
		[Token(Token = "0x401A16C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
