using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquipArchive
{
	// Token: 0x02003BC8 RID: 15304
	[Token(Token = "0x2003BC8")]
	public class UniEquipArchiveEquipTypeFilterItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017F61 RID: 98145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F61")]
		[Address(RVA = "0x1063AB0", Offset = "0x10626B0", VA = "0x181063AB0")]
		public void Render(UniEquipArchiveModuleTYpeFilterItemInfoData itemInfoData, string selectingFilterType)
		{
		}

		// Token: 0x06017F62 RID: 98146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F62")]
		[Address(RVA = "0x1063A40", Offset = "0x1062640", VA = "0x181063A40")]
		public void OnClick()
		{
		}

		// Token: 0x06017F63 RID: 98147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017F63")]
		[Address(RVA = "0x1063CB0", Offset = "0x10628B0", VA = "0x181063CB0")]
		public UniEquipArchiveEquipTypeFilterItemView()
		{
		}

		// Token: 0x0401CFED RID: 118765
		[Token(Token = "0x401CFED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _txtType;

		// Token: 0x0401CFEE RID: 118766
		[Token(Token = "0x401CFEE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgType;

		// Token: 0x0401CFEF RID: 118767
		[Token(Token = "0x401CFEF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x0401CFF0 RID: 118768
		[Token(Token = "0x401CFF0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Color _unselectedColor;

		// Token: 0x0401CFF1 RID: 118769
		[Token(Token = "0x401CFF1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _objSplitLine;

		// Token: 0x0401CFF2 RID: 118770
		[Token(Token = "0x401CFF2")]
		[FieldOffset(Offset = "0x50")]
		private string m_filterType;

		// Token: 0x0401CFF3 RID: 118771
		[Token(Token = "0x401CFF3")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<string> onFilterTypeItemClick;

		// Token: 0x0401CFF4 RID: 118772
		[Token(Token = "0x401CFF4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401CFF5 RID: 118773
		[Token(Token = "0x401CFF5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401CFF6 RID: 118774
		[Token(Token = "0x401CFF6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
