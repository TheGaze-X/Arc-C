using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.HandBook
{
	// Token: 0x02006696 RID: 26262
	[Token(Token = "0x2006696")]
	public class HandBookInfoStageSkillItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025B9C RID: 154524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B9C")]
		[Address(RVA = "0x20A69C0", Offset = "0x20A55C0", VA = "0x1820A69C0")]
		public void Render(SkillItemViewModel skillData, int idx, bool isSelect)
		{
		}

		// Token: 0x06025B9D RID: 154525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B9D")]
		[Address(RVA = "0x20A68E0", Offset = "0x20A54E0", VA = "0x1820A68E0")]
		public void OnSelectSkill()
		{
		}

		// Token: 0x06025B9E RID: 154526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B9E")]
		[Address(RVA = "0x20A6DA0", Offset = "0x20A59A0", VA = "0x1820A6DA0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025B9F RID: 154527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025B9F")]
		[Address(RVA = "0x20A6EC0", Offset = "0x20A5AC0", VA = "0x1820A6EC0")]
		public HandBookInfoStageSkillItemView()
		{
		}

		// Token: 0x04035012 RID: 217106
		[Token(Token = "0x4035012")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _unlockPartGo;

		// Token: 0x04035013 RID: 217107
		[Token(Token = "0x4035013")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _emptyPartGo;

		// Token: 0x04035014 RID: 217108
		[Token(Token = "0x4035014")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04035015 RID: 217109
		[Token(Token = "0x4035015")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x04035016 RID: 217110
		[Token(Token = "0x4035016")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _specialLevelIcon;

		// Token: 0x04035017 RID: 217111
		[Token(Token = "0x4035017")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _spInitGo;

		// Token: 0x04035018 RID: 217112
		[Token(Token = "0x4035018")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textSpInit;

		// Token: 0x04035019 RID: 217113
		[Token(Token = "0x4035019")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _spCostGo;

		// Token: 0x0403501A RID: 217114
		[Token(Token = "0x403501A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textSpCost;

		// Token: 0x0403501B RID: 217115
		[Token(Token = "0x403501B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UISkillTagGroup _skillTagGroup;

		// Token: 0x0403501C RID: 217116
		[Token(Token = "0x403501C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x0403501D RID: 217117
		[Token(Token = "0x403501D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _selectAnim;

		// Token: 0x0403501E RID: 217118
		[Token(Token = "0x403501E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Sprite[] _levelIconList;

		// Token: 0x0403501F RID: 217119
		[Token(Token = "0x403501F")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04035020 RID: 217120
		[Token(Token = "0x4035020")]
		[FieldOffset(Offset = "0x8C")]
		private int m_cachedIndex;

		// Token: 0x04035021 RID: 217121
		[Token(Token = "0x4035021")]
		[FieldOffset(Offset = "0x90")]
		private bool m_cachedSelected;

		// Token: 0x04035022 RID: 217122
		[Token(Token = "0x4035022")]
		[FieldOffset(Offset = "0x98")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x04035023 RID: 217123
		[Token(Token = "0x4035023")]
		[FieldOffset(Offset = "0xA0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04035024 RID: 217124
		[Token(Token = "0x4035024")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04035025 RID: 217125
		[Token(Token = "0x4035025")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnSelectSkill;

		// Token: 0x04035026 RID: 217126
		[Token(Token = "0x4035026")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035027 RID: 217127
		[Token(Token = "0x4035027")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
