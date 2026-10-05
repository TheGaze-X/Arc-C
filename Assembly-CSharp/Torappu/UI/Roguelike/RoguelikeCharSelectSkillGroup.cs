using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054A0 RID: 21664
	[Token(Token = "0x20054A0")]
	public class RoguelikeCharSelectSkillGroup : MonoBehaviour
	{
		// Token: 0x0601FE08 RID: 130568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE08")]
		[Address(RVA = "0x19F3010", Offset = "0x19F1C10", VA = "0x1819F3010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601FE09 RID: 130569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE09")]
		[Address(RVA = "0x19F3020", Offset = "0x19F1C20", VA = "0x1819F3020")]
		private void _OnSkillClicked(string skillId)
		{
		}

		// Token: 0x0601FE0A RID: 130570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE0A")]
		[Address(RVA = "0x19F2DF0", Offset = "0x19F19F0", VA = "0x1819F2DF0")]
		public void RenderSkills(RoguelikeCharSelectSkillGroupViewModel viewModel, UIStringEvent onSkillSelect)
		{
		}

		// Token: 0x0601FE0B RID: 130571 RVA: 0x000B3A60 File Offset: 0x000B1C60
		[Token(Token = "0x601FE0B")]
		[Address(RVA = "0x19F30F0", Offset = "0x19F1CF0", VA = "0x1819F30F0")]
		private bool _UpdateLastActiveChar(RoguelikeCharSelectSkillGroupViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601FE0C RID: 130572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE0C")]
		[Address(RVA = "0x19F3070", Offset = "0x19F1C70", VA = "0x1819F3070")]
		private void _ResetSkillScroll()
		{
		}

		// Token: 0x0601FE0D RID: 130573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FE0D")]
		[Address(RVA = "0x19F3160", Offset = "0x19F1D60", VA = "0x1819F3160")]
		public RoguelikeCharSelectSkillGroup()
		{
		}

		// Token: 0x0402AF8E RID: 176014
		[Token(Token = "0x402AF8E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("The container layout of skill items")]
		private SimpleLayoutContent _skillLayout;

		// Token: 0x0402AF8F RID: 176015
		[Token(Token = "0x402AF8F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelDisable;

		// Token: 0x0402AF90 RID: 176016
		[Token(Token = "0x402AF90")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDisable;

		// Token: 0x0402AF91 RID: 176017
		[Token(Token = "0x402AF91")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _skillScroll;

		// Token: 0x0402AF92 RID: 176018
		[Token(Token = "0x402AF92")]
		[FieldOffset(Offset = "0x38")]
		private RoguelikeCharSelectSkillGroup.SkillAdapter m_adapter;

		// Token: 0x0402AF93 RID: 176019
		[Token(Token = "0x402AF93")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x0402AF94 RID: 176020
		[Token(Token = "0x402AF94")]
		[FieldOffset(Offset = "0x48")]
		private string m_lastActiveChar;

		// Token: 0x0402AF95 RID: 176021
		[Token(Token = "0x402AF95")]
		[FieldOffset(Offset = "0x50")]
		private UIStringEvent m_onSkillSelected;

		// Token: 0x020054A1 RID: 21665
		[Token(Token = "0x20054A1")]
		private class SkillAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004ABA RID: 19130
			// (get) Token: 0x0601FE0E RID: 130574 RVA: 0x000B3A78 File Offset: 0x000B1C78
			[Token(Token = "0x17004ABA")]
			public override int count
			{
				[Token(Token = "0x601FE0E")]
				[Address(RVA = "0x19FDFA0", Offset = "0x19FCBA0", VA = "0x1819FDFA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601FE0F RID: 130575 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601FE0F")]
			[Address(RVA = "0x19FDAC0", Offset = "0x19FC6C0", VA = "0x1819FDAC0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601FE10 RID: 130576 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601FE10")]
			[Address(RVA = "0x19FDF40", Offset = "0x19FCB40", VA = "0x1819FDF40")]
			public SkillAdapter()
			{
			}

			// Token: 0x0402AF96 RID: 176022
			[Token(Token = "0x402AF96")]
			[FieldOffset(Offset = "0x20")]
			public RoguelikeCharSelectSkillGroupViewModel viewModel;

			// Token: 0x0402AF97 RID: 176023
			[Token(Token = "0x402AF97")]
			[FieldOffset(Offset = "0x28")]
			public RoguelikeCharSelectSkillGroup closure;

			// Token: 0x0402AF98 RID: 176024
			[Token(Token = "0x402AF98")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402AF99 RID: 176025
			[Token(Token = "0x402AF99")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0402AF9A RID: 176026
			[Token(Token = "0x402AF9A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
