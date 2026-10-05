using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E10 RID: 15888
	[Token(Token = "0x2003E10")]
	public class SquadFriendAssistCharSkillItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018B77 RID: 101239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B77")]
		[Address(RVA = "0x11392B0", Offset = "0x1137EB0", VA = "0x1811392B0")]
		public void Render(SkillItemViewModel skillModel, bool isSelected, int skillIndex, bool isLimited)
		{
		}

		// Token: 0x06018B78 RID: 101240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B78")]
		[Address(RVA = "0x11391D0", Offset = "0x1137DD0", VA = "0x1811391D0")]
		public void OnClick()
		{
		}

		// Token: 0x06018B79 RID: 101241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B79")]
		[Address(RVA = "0x11395F0", Offset = "0x11381F0", VA = "0x1811395F0")]
		public SquadFriendAssistCharSkillItem()
		{
		}

		// Token: 0x0401E521 RID: 124193
		[Token(Token = "0x401E521")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelEnable;

		// Token: 0x0401E522 RID: 124194
		[Token(Token = "0x401E522")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0401E523 RID: 124195
		[Token(Token = "0x401E523")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0401E524 RID: 124196
		[Token(Token = "0x401E524")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _selectFrame;

		// Token: 0x0401E525 RID: 124197
		[Token(Token = "0x401E525")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageSkill;

		// Token: 0x0401E526 RID: 124198
		[Token(Token = "0x401E526")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textCost;

		// Token: 0x0401E527 RID: 124199
		[Token(Token = "0x401E527")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textInit;

		// Token: 0x0401E528 RID: 124200
		[Token(Token = "0x401E528")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _skillCost;

		// Token: 0x0401E529 RID: 124201
		[Token(Token = "0x401E529")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _skillInit;

		// Token: 0x0401E52A RID: 124202
		[Token(Token = "0x401E52A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgSpecIcon;

		// Token: 0x0401E52B RID: 124203
		[Token(Token = "0x401E52B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textMainLv;

		// Token: 0x0401E52C RID: 124204
		[Token(Token = "0x401E52C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x0401E52D RID: 124205
		[Token(Token = "0x401E52D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _skillUnselectAlpha;

		// Token: 0x0401E52E RID: 124206
		[Token(Token = "0x401E52E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image _mainLevelBg;

		// Token: 0x0401E52F RID: 124207
		[Token(Token = "0x401E52F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _unlimitLevelBgColor;

		// Token: 0x0401E530 RID: 124208
		[Token(Token = "0x401E530")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Color _limitLevelBgColor;

		// Token: 0x0401E531 RID: 124209
		[Token(Token = "0x401E531")]
		[FieldOffset(Offset = "0xA8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E532 RID: 124210
		[Token(Token = "0x401E532")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cachedIndex;

		// Token: 0x0401E533 RID: 124211
		[Token(Token = "0x401E533")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E534 RID: 124212
		[Token(Token = "0x401E534")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401E535 RID: 124213
		[Token(Token = "0x401E535")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
