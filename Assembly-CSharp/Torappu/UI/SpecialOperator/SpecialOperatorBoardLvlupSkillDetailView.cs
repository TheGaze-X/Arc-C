using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E72 RID: 15986
	[Token(Token = "0x2003E72")]
	public class SpecialOperatorBoardLvlupSkillDetailView : SpecialOperatorBoardLvlupDetailView<SpecialOperatorBoardSkillNode>
	{
		// Token: 0x17003B50 RID: 15184
		// (get) Token: 0x06018D96 RID: 101782 RVA: 0x0009C318 File Offset: 0x0009A518
		[Token(Token = "0x17003B50")]
		public override SpecialOperatorDetailNodeType nodeType
		{
			[Token(Token = "0x6018D96")]
			[Address(RVA = "0x118DFC0", Offset = "0x118CBC0", VA = "0x18118DFC0", Slot = "4")]
			get
			{
				return SpecialOperatorDetailNodeType.NONE;
			}
		}

		// Token: 0x06018D97 RID: 101783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D97")]
		[Address(RVA = "0x118DDB0", Offset = "0x118C9B0", VA = "0x18118DDB0", Slot = "5")]
		public override void SetViewShow(bool isShow)
		{
		}

		// Token: 0x06018D98 RID: 101784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D98")]
		[Address(RVA = "0x118DE30", Offset = "0x118CA30", VA = "0x18118DE30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018D99 RID: 101785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D99")]
		[Address(RVA = "0x118D400", Offset = "0x118C000", VA = "0x18118D400", Slot = "7")]
		public override void Render(SpecialOperatorBoardSkillNode viewModel, bool fastMode)
		{
		}

		// Token: 0x06018D9A RID: 101786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D9A")]
		[Address(RVA = "0x118DF50", Offset = "0x118CB50", VA = "0x18118DF50")]
		public SpecialOperatorBoardLvlupSkillDetailView()
		{
		}

		// Token: 0x0401E949 RID: 125257
		[Token(Token = "0x401E949")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelRoot;

		// Token: 0x0401E94A RID: 125258
		[Token(Token = "0x401E94A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCost;

		// Token: 0x0401E94B RID: 125259
		[Token(Token = "0x401E94B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textInit;

		// Token: 0x0401E94C RID: 125260
		[Token(Token = "0x401E94C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _skillCost;

		// Token: 0x0401E94D RID: 125261
		[Token(Token = "0x401E94D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _skillInit;

		// Token: 0x0401E94E RID: 125262
		[Token(Token = "0x401E94E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imageSkill;

		// Token: 0x0401E94F RID: 125263
		[Token(Token = "0x401E94F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpecialOperatorBoardLvlupSkillSpLevelView _spLevels;

		// Token: 0x0401E950 RID: 125264
		[Token(Token = "0x401E950")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelRightLevel;

		// Token: 0x0401E951 RID: 125265
		[Token(Token = "0x401E951")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SpecialOperatorBoardLvlupSkillSpLevelView _spLevelsRightFrom;

		// Token: 0x0401E952 RID: 125266
		[Token(Token = "0x401E952")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SpecialOperatorBoardLvlupSkillSpLevelView _spLevelsRightTo;

		// Token: 0x0401E953 RID: 125267
		[Token(Token = "0x401E953")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _levelFrom;

		// Token: 0x0401E954 RID: 125268
		[Token(Token = "0x401E954")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _levelTo;

		// Token: 0x0401E955 RID: 125269
		[Token(Token = "0x401E955")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0401E956 RID: 125270
		[Token(Token = "0x401E956")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UISkillTagGroup _sillTagGroup;

		// Token: 0x0401E957 RID: 125271
		[Token(Token = "0x401E957")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _skillDetails;

		// Token: 0x0401E958 RID: 125272
		[Token(Token = "0x401E958")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _panelActivePre;

		// Token: 0x0401E959 RID: 125273
		[Token(Token = "0x401E959")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelCanActive;

		// Token: 0x0401E95A RID: 125274
		[Token(Token = "0x401E95A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _panelActivated;

		// Token: 0x0401E95B RID: 125275
		[Token(Token = "0x401E95B")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _panelTaskFinished;

		// Token: 0x0401E95C RID: 125276
		[Token(Token = "0x401E95C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _taskDesc;

		// Token: 0x0401E95D RID: 125277
		[Token(Token = "0x401E95D")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Color _unfinishedTaskColor;

		// Token: 0x0401E95E RID: 125278
		[Token(Token = "0x401E95E")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Color _finishedTaskColor;

		// Token: 0x0401E95F RID: 125279
		[Token(Token = "0x401E95F")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private ScrollRect _contentScrollRect;

		// Token: 0x0401E960 RID: 125280
		[Token(Token = "0x401E960")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private ScrollRect _taskScrollRect;

		// Token: 0x0401E961 RID: 125281
		[Token(Token = "0x401E961")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private GameObject _panelHotspot;

		// Token: 0x0401E962 RID: 125282
		[Token(Token = "0x401E962")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private UIAnimationLocation _unlockAnim;

		// Token: 0x0401E963 RID: 125283
		[Token(Token = "0x401E963")]
		[FieldOffset(Offset = "0x118")]
		private bool m_isInited;

		// Token: 0x0401E964 RID: 125284
		[Token(Token = "0x401E964")]
		[FieldOffset(Offset = "0x120")]
		private string m_cachedNodeId;

		// Token: 0x0401E965 RID: 125285
		[Token(Token = "0x401E965")]
		[FieldOffset(Offset = "0x128")]
		private string m_cachedSkillId;

		// Token: 0x0401E966 RID: 125286
		[Token(Token = "0x401E966")]
		[FieldOffset(Offset = "0x130")]
		private AnimationSwitchTween m_unlockTween;

		// Token: 0x0401E967 RID: 125287
		[Token(Token = "0x401E967")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0401E968 RID: 125288
		[Token(Token = "0x401E968")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetViewShow;

		// Token: 0x0401E969 RID: 125289
		[Token(Token = "0x401E969")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E96A RID: 125290
		[Token(Token = "0x401E96A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E96B RID: 125291
		[Token(Token = "0x401E96B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E73 RID: 15987
		[Token(Token = "0x2003E73")]
		private enum State
		{
			// Token: 0x0401E96D RID: 125293
			[Token(Token = "0x401E96D")]
			ACTIVATE_PRE,
			// Token: 0x0401E96E RID: 125294
			[Token(Token = "0x401E96E")]
			CAN_ACTIVATE,
			// Token: 0x0401E96F RID: 125295
			[Token(Token = "0x401E96F")]
			ACTIVATED
		}
	}
}
