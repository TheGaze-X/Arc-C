using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Friend
{
	// Token: 0x02004DF2 RID: 19954
	[Token(Token = "0x2004DF2")]
	public class NameCardSkinTmplChangeView : DataBinder<NameCardSkinChangeProperty>
	{
		// Token: 0x0601DD2D RID: 122157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD2D")]
		[Address(RVA = "0x1757970", Offset = "0x1756570", VA = "0x181757970", Slot = "7")]
		public override void OnValueChanged(NameCardSkinChangeProperty property)
		{
		}

		// Token: 0x0601DD2E RID: 122158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD2E")]
		[Address(RVA = "0x1757C20", Offset = "0x1756820", VA = "0x181757C20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601DD2F RID: 122159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD2F")]
		[Address(RVA = "0x17578D0", Offset = "0x17564D0", VA = "0x1817578D0")]
		public void OnCancelChangeSubSkin()
		{
		}

		// Token: 0x0601DD30 RID: 122160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DD30")]
		[Address(RVA = "0x1757D20", Offset = "0x1756920", VA = "0x181757D20")]
		public NameCardSkinTmplChangeView()
		{
		}

		// Token: 0x0402781E RID: 161822
		[Token(Token = "0x402781E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x0402781F RID: 161823
		[Token(Token = "0x402781F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private NameCardSkinListAdapter _skinTmplListAdapter;

		// Token: 0x04027820 RID: 161824
		[Token(Token = "0x4027820")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _selectTips;

		// Token: 0x04027821 RID: 161825
		[Token(Token = "0x4027821")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04027822 RID: 161826
		[Token(Token = "0x4027822")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04027823 RID: 161827
		[Token(Token = "0x4027823")]
		[FieldOffset(Offset = "0x58")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x04027824 RID: 161828
		[Token(Token = "0x4027824")]
		[FieldOffset(Offset = "0x60")]
		private int m_skinTmplShowSeqNum;

		// Token: 0x04027825 RID: 161829
		[Token(Token = "0x4027825")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04027826 RID: 161830
		[Token(Token = "0x4027826")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027827 RID: 161831
		[Token(Token = "0x4027827")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCancelChangeSubSkin;

		// Token: 0x04027828 RID: 161832
		[Token(Token = "0x4027828")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
