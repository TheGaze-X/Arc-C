using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.CharSelect
{
	// Token: 0x02005E22 RID: 24098
	[Token(Token = "0x2005E22")]
	public class CharSelectSkillGroup : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022EAA RID: 143018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EAA")]
		[Address(RVA = "0x1D67290", Offset = "0x1D65E90", VA = "0x181D67290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06022EAB RID: 143019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EAB")]
		[Address(RVA = "0x1D672F0", Offset = "0x1D65EF0", VA = "0x181D672F0")]
		private void _OnSkillClicked(string skillId)
		{
		}

		// Token: 0x06022EAC RID: 143020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EAC")]
		[Address(RVA = "0x1D66F80", Offset = "0x1D65B80", VA = "0x181D66F80")]
		public void RenderSkills(CharSelectSkillGroupViewModel viewModel)
		{
		}

		// Token: 0x06022EAD RID: 143021 RVA: 0x000BF730 File Offset: 0x000BD930
		[Token(Token = "0x6022EAD")]
		[Address(RVA = "0x1D67440", Offset = "0x1D66040", VA = "0x181D67440")]
		private bool _UpdateLastActiveChar(CharSelectSkillGroupViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x06022EAE RID: 143022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EAE")]
		[Address(RVA = "0x1D67380", Offset = "0x1D65F80", VA = "0x181D67380")]
		private void _ResetSkillScroll()
		{
		}

		// Token: 0x06022EAF RID: 143023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022EAF")]
		[Address(RVA = "0x1D67500", Offset = "0x1D66100", VA = "0x181D67500")]
		public CharSelectSkillGroup()
		{
		}

		// Token: 0x04030188 RID: 197000
		[Token(Token = "0x4030188")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("The container layout of skill items")]
		private SimpleLayoutContent _skillLayout;

		// Token: 0x04030189 RID: 197001
		[Token(Token = "0x4030189")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelDisable;

		// Token: 0x0403018A RID: 197002
		[Token(Token = "0x403018A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textDisable;

		// Token: 0x0403018B RID: 197003
		[Token(Token = "0x403018B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ScrollRect _skillScroll;

		// Token: 0x0403018C RID: 197004
		[Token(Token = "0x403018C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CharSelectSkillGroup.SkillSelectEvent _onSkillSelected;

		// Token: 0x0403018D RID: 197005
		[Token(Token = "0x403018D")]
		[FieldOffset(Offset = "0x40")]
		private CharSelectSkillGroup.SkillAdapter m_adapter;

		// Token: 0x0403018E RID: 197006
		[Token(Token = "0x403018E")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0403018F RID: 197007
		[Token(Token = "0x403018F")]
		[FieldOffset(Offset = "0x50")]
		private string m_lastActiveChar;

		// Token: 0x04030190 RID: 197008
		[Token(Token = "0x4030190")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030191 RID: 197009
		[Token(Token = "0x4030191")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnSkillClicked;

		// Token: 0x04030192 RID: 197010
		[Token(Token = "0x4030192")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderSkills;

		// Token: 0x04030193 RID: 197011
		[Token(Token = "0x4030193")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateLastActiveChar;

		// Token: 0x04030194 RID: 197012
		[Token(Token = "0x4030194")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetSkillScroll;

		// Token: 0x04030195 RID: 197013
		[Token(Token = "0x4030195")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005E23 RID: 24099
		[Token(Token = "0x2005E23")]
		[Serializable]
		public class SkillSelectEvent : UnityEvent<string>
		{
			// Token: 0x06022EB0 RID: 143024 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022EB0")]
			[Address(RVA = "0x1D72F60", Offset = "0x1D71B60", VA = "0x181D72F60")]
			public SkillSelectEvent()
			{
			}
		}

		// Token: 0x02005E24 RID: 24100
		[Token(Token = "0x2005E24")]
		private class SkillAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170052C4 RID: 21188
			// (get) Token: 0x06022EB1 RID: 143025 RVA: 0x000BF748 File Offset: 0x000BD948
			[Token(Token = "0x170052C4")]
			public override int count
			{
				[Token(Token = "0x6022EB1")]
				[Address(RVA = "0x1D72B90", Offset = "0x1D71790", VA = "0x181D72B90", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06022EB2 RID: 143026 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6022EB2")]
			[Address(RVA = "0x1D72840", Offset = "0x1D71440", VA = "0x181D72840", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06022EB3 RID: 143027 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022EB3")]
			[Address(RVA = "0x1D72B30", Offset = "0x1D71730", VA = "0x181D72B30")]
			public SkillAdapter()
			{
			}

			// Token: 0x04030196 RID: 197014
			[Token(Token = "0x4030196")]
			[FieldOffset(Offset = "0x20")]
			public CharSelectSkillGroupViewModel viewModel;

			// Token: 0x04030197 RID: 197015
			[Token(Token = "0x4030197")]
			[FieldOffset(Offset = "0x28")]
			public CharSelectSkillGroup closure;

			// Token: 0x04030198 RID: 197016
			[Token(Token = "0x4030198")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04030199 RID: 197017
			[Token(Token = "0x4030199")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403019A RID: 197018
			[Token(Token = "0x403019A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
