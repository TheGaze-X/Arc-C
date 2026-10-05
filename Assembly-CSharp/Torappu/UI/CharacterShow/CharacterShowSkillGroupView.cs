using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharacterShow
{
	// Token: 0x02005DF2 RID: 24050
	[Token(Token = "0x2005DF2")]
	public class CharacterShowSkillGroupView : CharacterShowRightInfoViewBase
	{
		// Token: 0x06022D96 RID: 142742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D96")]
		[Address(RVA = "0x1D6DC10", Offset = "0x1D6C810", VA = "0x181D6DC10", Slot = "7")]
		public override void OnValueChanged(CharacterShowProp property)
		{
		}

		// Token: 0x06022D97 RID: 142743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D97")]
		[Address(RVA = "0x1D6E200", Offset = "0x1D6CE00", VA = "0x181D6E200")]
		private void _RenderSkillView()
		{
		}

		// Token: 0x06022D98 RID: 142744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D98")]
		[Address(RVA = "0x1D6E3C0", Offset = "0x1D6CFC0", VA = "0x181D6E3C0")]
		private void _UpdateSelectedSkillInfo()
		{
		}

		// Token: 0x06022D99 RID: 142745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022D99")]
		[Address(RVA = "0x1D6DE20", Offset = "0x1D6CA20", VA = "0x181D6DE20")]
		private string _GetUnlockIconName(CharacterData.UnlockCondition unlockCond)
		{
			return null;
		}

		// Token: 0x06022D9A RID: 142746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D9A")]
		[Address(RVA = "0x1D6DEC0", Offset = "0x1D6CAC0", VA = "0x181D6DEC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022D9B RID: 142747 RVA: 0x000BF448 File Offset: 0x000BD648
		[Token(Token = "0x6022D9B")]
		[Address(RVA = "0x1D6DCD0", Offset = "0x1D6C8D0", VA = "0x181D6DCD0")]
		private float _GetSkillDescMaxHeight()
		{
			return 0f;
		}

		// Token: 0x06022D9C RID: 142748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022D9C")]
		[Address(RVA = "0x1D6E920", Offset = "0x1D6D520", VA = "0x181D6E920")]
		public CharacterShowSkillGroupView()
		{
		}

		// Token: 0x0402FFAE RID: 196526
		[Token(Token = "0x402FFAE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICommentedText _textDesc;

		// Token: 0x0402FFAF RID: 196527
		[Token(Token = "0x402FFAF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayoutElement _layoutDesc;

		// Token: 0x0402FFB0 RID: 196528
		[Token(Token = "0x402FFB0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _tagPanel;

		// Token: 0x0402FFB1 RID: 196529
		[Token(Token = "0x402FFB1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UISkillTagGroup _tagGroup;

		// Token: 0x0402FFB2 RID: 196530
		[Token(Token = "0x402FFB2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _rangeBtnViewContent;

		// Token: 0x0402FFB3 RID: 196531
		[Token(Token = "0x402FFB3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SimpleLayoutContent _skillList;

		// Token: 0x0402FFB4 RID: 196532
		[Token(Token = "0x402FFB4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _skillGroupGo;

		// Token: 0x0402FFB5 RID: 196533
		[Token(Token = "0x402FFB5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _emptyGo;

		// Token: 0x0402FFB6 RID: 196534
		[Token(Token = "0x402FFB6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _unlockCondGo;

		// Token: 0x0402FFB7 RID: 196535
		[Token(Token = "0x402FFB7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textUnlockHint;

		// Token: 0x0402FFB8 RID: 196536
		[Token(Token = "0x402FFB8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAtlasImage _imgUnlockIcon;

		// Token: 0x0402FFB9 RID: 196537
		[Token(Token = "0x402FFB9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasObject _atlasUnlockIcon;

		// Token: 0x0402FFBA RID: 196538
		[Token(Token = "0x402FFBA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _iconEvolveOneUnlockName;

		// Token: 0x0402FFBB RID: 196539
		[Token(Token = "0x402FFBB")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _iconEvolveTwoUnlockName;

		// Token: 0x0402FFBC RID: 196540
		[Token(Token = "0x402FFBC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _singleSkillGo;

		// Token: 0x0402FFBD RID: 196541
		[Token(Token = "0x402FFBD")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private CharacterShowSkillItem _singleSkillItem;

		// Token: 0x0402FFBE RID: 196542
		[Token(Token = "0x402FFBE")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x0402FFBF RID: 196543
		[Token(Token = "0x402FFBF")]
		[FieldOffset(Offset = "0xA8")]
		private CharacterShowV2Model m_charShowModel;

		// Token: 0x0402FFC0 RID: 196544
		[Token(Token = "0x402FFC0")]
		[FieldOffset(Offset = "0xB0")]
		private CharacterShowSkillGroupView.SkillListAdapter m_skillListAdapter;

		// Token: 0x0402FFC1 RID: 196545
		[Token(Token = "0x402FFC1")]
		[FieldOffset(Offset = "0xB8")]
		private TextGenerator m_textGenerator;

		// Token: 0x0402FFC2 RID: 196546
		[Token(Token = "0x402FFC2")]
		[FieldOffset(Offset = "0xC0")]
		private UIPageFinder m_uiPageFinder;

		// Token: 0x0402FFC3 RID: 196547
		[Token(Token = "0x402FFC3")]
		[FieldOffset(Offset = "0xD0")]
		private AbstractSkillRangeButtonView m_skillRangeButton;

		// Token: 0x0402FFC4 RID: 196548
		[Token(Token = "0x402FFC4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402FFC5 RID: 196549
		[Token(Token = "0x402FFC5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderSkillView;

		// Token: 0x0402FFC6 RID: 196550
		[Token(Token = "0x402FFC6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateSelectedSkillInfo;

		// Token: 0x0402FFC7 RID: 196551
		[Token(Token = "0x402FFC7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetUnlockIconName;

		// Token: 0x0402FFC8 RID: 196552
		[Token(Token = "0x402FFC8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402FFC9 RID: 196553
		[Token(Token = "0x402FFC9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GetSkillDescMaxHeight;

		// Token: 0x0402FFCA RID: 196554
		[Token(Token = "0x402FFCA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DF3 RID: 24051
		[Token(Token = "0x2005DF3")]
		private class SkillListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06022D9D RID: 142749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022D9D")]
			[Address(RVA = "0x1D72E40", Offset = "0x1D71A40", VA = "0x181D72E40")]
			public SkillListAdapter(CharacterShowSkillGroupView closure)
			{
			}

			// Token: 0x1700528F RID: 21135
			// (get) Token: 0x06022D9E RID: 142750 RVA: 0x000BF460 File Offset: 0x000BD660
			[Token(Token = "0x1700528F")]
			public override int count
			{
				[Token(Token = "0x6022D9E")]
				[Address(RVA = "0x1D72EC0", Offset = "0x1D71AC0", VA = "0x181D72EC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022D9F RID: 142751 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022D9F")]
			[Address(RVA = "0x1D72C00", Offset = "0x1D71800", VA = "0x181D72C00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402FFCB RID: 196555
			[Token(Token = "0x402FFCB")]
			[FieldOffset(Offset = "0x20")]
			private CharacterShowSkillGroupView m_closure;

			// Token: 0x0402FFCC RID: 196556
			[Token(Token = "0x402FFCC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402FFCD RID: 196557
			[Token(Token = "0x402FFCD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402FFCE RID: 196558
			[Token(Token = "0x402FFCE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
