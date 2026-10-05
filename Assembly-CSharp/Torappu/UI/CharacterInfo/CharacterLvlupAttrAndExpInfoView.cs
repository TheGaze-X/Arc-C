using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F5C RID: 24412
	[Token(Token = "0x2005F5C")]
	public class CharacterLvlupAttrAndExpInfoView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023590 RID: 144784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023590")]
		[Address(RVA = "0x1DDC470", Offset = "0x1DDB070", VA = "0x181DDC470")]
		public void Render(CharacterLvlupViewModel viewModel)
		{
		}

		// Token: 0x06023591 RID: 144785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023591")]
		[Address(RVA = "0x1DDCB10", Offset = "0x1DDB710", VA = "0x181DDCB10")]
		private string _ParseTargetValueDesc(int target, int current)
		{
			return null;
		}

		// Token: 0x06023592 RID: 144786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023592")]
		[Address(RVA = "0x1DDCA20", Offset = "0x1DDB620", VA = "0x181DDCA20")]
		private string _ParseTargetValueDesc(float target, float current)
		{
			return null;
		}

		// Token: 0x06023593 RID: 144787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023593")]
		[Address(RVA = "0x1DDCBF0", Offset = "0x1DDB7F0", VA = "0x181DDCBF0")]
		public CharacterLvlupAttrAndExpInfoView()
		{
		}

		// Token: 0x04030C7D RID: 199805
		[Token(Token = "0x4030C7D")]
		private const string CONST_LEVEL_FORMAT = "LV  {0}";

		// Token: 0x04030C7E RID: 199806
		[Token(Token = "0x4030C7E")]
		private const string CONST_MAX_EXP = "-";

		// Token: 0x04030C7F RID: 199807
		[Token(Token = "0x4030C7F")]
		private const string CONST_ADD_EXP_FORMAT = "+{0}";

		// Token: 0x04030C80 RID: 199808
		[Token(Token = "0x4030C80")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtCurMaxHp;

		// Token: 0x04030C81 RID: 199809
		[Token(Token = "0x4030C81")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtTarMaxHp;

		// Token: 0x04030C82 RID: 199810
		[Token(Token = "0x4030C82")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtCurAtk;

		// Token: 0x04030C83 RID: 199811
		[Token(Token = "0x4030C83")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtTarAtk;

		// Token: 0x04030C84 RID: 199812
		[Token(Token = "0x4030C84")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtCurDef;

		// Token: 0x04030C85 RID: 199813
		[Token(Token = "0x4030C85")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtTarDef;

		// Token: 0x04030C86 RID: 199814
		[Token(Token = "0x4030C86")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtCurRes;

		// Token: 0x04030C87 RID: 199815
		[Token(Token = "0x4030C87")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("AttrInfo")]
		private Text _txtTarRes;

		// Token: 0x04030C88 RID: 199816
		[Token(Token = "0x4030C88")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("AttrInfo")]
		private Color _highlightAttrColor;

		// Token: 0x04030C89 RID: 199817
		[Token(Token = "0x4030C89")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("ExpInfo")]
		private Text _txtTargetLevel;

		// Token: 0x04030C8A RID: 199818
		[Token(Token = "0x4030C8A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("ExpInfo")]
		private Text _txtCurExp;

		// Token: 0x04030C8B RID: 199819
		[Token(Token = "0x4030C8B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("ExpInfo")]
		private Text _txtTotalExp;

		// Token: 0x04030C8C RID: 199820
		[Token(Token = "0x4030C8C")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("ExpInfo")]
		private Text _txtAddExp;

		// Token: 0x04030C8D RID: 199821
		[Token(Token = "0x4030C8D")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("ExpInfo")]
		private GameObject _panelCounting;

		// Token: 0x04030C8E RID: 199822
		[Token(Token = "0x4030C8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030C8F RID: 199823
		[Token(Token = "0x4030C8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ParseTargetValueDesc;

		// Token: 0x04030C90 RID: 199824
		[Token(Token = "0x4030C90")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix1__ParseTargetValueDesc;

		// Token: 0x04030C91 RID: 199825
		[Token(Token = "0x4030C91")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
