using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200353D RID: 13629
	[Token(Token = "0x200353D")]
	public class UICharacterLevelMaxView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015B98 RID: 88984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B98")]
		[Address(RVA = "0xE4F420", Offset = "0xE4E020", VA = "0x180E4F420")]
		public void Render()
		{
		}

		// Token: 0x06015B99 RID: 88985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015B99")]
		[Address(RVA = "0xE4FA40", Offset = "0xE4E640", VA = "0x180E4FA40")]
		private string _ParseCurrentValueDesc(int current, int origin)
		{
			return null;
		}

		// Token: 0x06015B9A RID: 88986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6015B9A")]
		[Address(RVA = "0xE4FB20", Offset = "0xE4E720", VA = "0x180E4FB20")]
		private string _ParseCurrentValueDesc(float current, float origin)
		{
			return null;
		}

		// Token: 0x06015B9B RID: 88987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015B9B")]
		[Address(RVA = "0xE4FC10", Offset = "0xE4E810", VA = "0x180E4FC10")]
		public UICharacterLevelMaxView()
		{
		}

		// Token: 0x0401A183 RID: 106883
		[Token(Token = "0x401A183")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgCampLogo;

		// Token: 0x0401A184 RID: 106884
		[Token(Token = "0x401A184")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _txtLevel;

		// Token: 0x0401A185 RID: 106885
		[Token(Token = "0x401A185")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _imgEvolve;

		// Token: 0x0401A186 RID: 106886
		[Token(Token = "0x401A186")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtCurMaxHp;

		// Token: 0x0401A187 RID: 106887
		[Token(Token = "0x401A187")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtOriMaxHp;

		// Token: 0x0401A188 RID: 106888
		[Token(Token = "0x401A188")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtCurAtk;

		// Token: 0x0401A189 RID: 106889
		[Token(Token = "0x401A189")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtOriAtk;

		// Token: 0x0401A18A RID: 106890
		[Token(Token = "0x401A18A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtCurDef;

		// Token: 0x0401A18B RID: 106891
		[Token(Token = "0x401A18B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtOriDef;

		// Token: 0x0401A18C RID: 106892
		[Token(Token = "0x401A18C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtCurRes;

		// Token: 0x0401A18D RID: 106893
		[Token(Token = "0x401A18D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtOriRes;

		// Token: 0x0401A18E RID: 106894
		[Token(Token = "0x401A18E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("AttrInfo")]
		private Color _highlightAttrColor;

		// Token: 0x0401A18F RID: 106895
		[Token(Token = "0x401A18F")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UICharacterLevelMaxBindWrapper _bindWrapper;

		// Token: 0x0401A190 RID: 106896
		[Token(Token = "0x401A190")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401A191 RID: 106897
		[Token(Token = "0x401A191")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ParseCurrentValueDesc;

		// Token: 0x0401A192 RID: 106898
		[Token(Token = "0x401A192")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1__ParseCurrentValueDesc;

		// Token: 0x0401A193 RID: 106899
		[Token(Token = "0x401A193")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
