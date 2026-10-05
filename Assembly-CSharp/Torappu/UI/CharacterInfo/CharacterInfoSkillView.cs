using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005FB6 RID: 24502
	[Token(Token = "0x2005FB6")]
	public class CharacterInfoSkillView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602370C RID: 145164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602370C")]
		[Address(RVA = "0x1E20FE0", Offset = "0x1E1FBE0", VA = "0x181E20FE0", Slot = "4")]
		public virtual void Render(SkillItemViewModel viewModel)
		{
		}

		// Token: 0x0602370D RID: 145165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602370D")]
		[Address(RVA = "0x1E20EC0", Offset = "0x1E1FAC0", VA = "0x181E20EC0")]
		public void RenderCommentedTextVisible(bool isDownState)
		{
		}

		// Token: 0x0602370E RID: 145166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602370E")]
		[Address(RVA = "0x1E21220", Offset = "0x1E1FE20", VA = "0x181E21220")]
		public CharacterInfoSkillView()
		{
		}

		// Token: 0x04030FED RID: 200685
		[Token(Token = "0x4030FED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEnable;

		// Token: 0x04030FEE RID: 200686
		[Token(Token = "0x4030FEE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04030FEF RID: 200687
		[Token(Token = "0x4030FEF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x04030FF0 RID: 200688
		[Token(Token = "0x4030FF0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageSkillIcon;

		// Token: 0x04030FF1 RID: 200689
		[Token(Token = "0x4030FF1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCost;

		// Token: 0x04030FF2 RID: 200690
		[Token(Token = "0x4030FF2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textInitCost;

		// Token: 0x04030FF3 RID: 200691
		[Token(Token = "0x4030FF3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _textCostObj;

		// Token: 0x04030FF4 RID: 200692
		[Token(Token = "0x4030FF4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _textInitCostObj;

		// Token: 0x04030FF5 RID: 200693
		[Token(Token = "0x4030FF5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04030FF6 RID: 200694
		[Token(Token = "0x4030FF6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UISkillTagGroup _tagGroup;

		// Token: 0x04030FF7 RID: 200695
		[Token(Token = "0x4030FF7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UICommentedText _textDesc;

		// Token: 0x04030FF8 RID: 200696
		[Token(Token = "0x4030FF8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _textUnlockCond;

		// Token: 0x04030FF9 RID: 200697
		[Token(Token = "0x4030FF9")]
		[FieldOffset(Offset = "0x78")]
		private string m_skillIdCache;

		// Token: 0x04030FFA RID: 200698
		[Token(Token = "0x4030FFA")]
		[FieldOffset(Offset = "0x80")]
		private SkillItemViewModel m_cachedViewModel;

		// Token: 0x04030FFB RID: 200699
		[Token(Token = "0x4030FFB")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public bool isSkillLvUpGroupDownPos;

		// Token: 0x04030FFC RID: 200700
		[Token(Token = "0x4030FFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030FFD RID: 200701
		[Token(Token = "0x4030FFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderCommentedTextVisible;

		// Token: 0x04030FFE RID: 200702
		[Token(Token = "0x4030FFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
