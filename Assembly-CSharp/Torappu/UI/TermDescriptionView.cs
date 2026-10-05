using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B79 RID: 15225
	[Token(Token = "0x2003B79")]
	public class TermDescriptionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06017DF2 RID: 97778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DF2")]
		[Address(RVA = "0x101EFD0", Offset = "0x101DBD0", VA = "0x18101EFD0")]
		public void AddTermDescription(UITermDescDataModel termParamPair)
		{
		}

		// Token: 0x06017DF3 RID: 97779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DF3")]
		[Address(RVA = "0x101F740", Offset = "0x101E340", VA = "0x18101F740")]
		public void PopTermDescription()
		{
		}

		// Token: 0x06017DF4 RID: 97780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DF4")]
		[Address(RVA = "0x101FBB0", Offset = "0x101E7B0", VA = "0x18101FBB0")]
		public void ShowPanel()
		{
		}

		// Token: 0x06017DF5 RID: 97781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DF5")]
		[Address(RVA = "0x101F4D0", Offset = "0x101E0D0", VA = "0x18101F4D0")]
		public void HidePanel()
		{
		}

		// Token: 0x06017DF6 RID: 97782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DF6")]
		[Address(RVA = "0x1020CB0", Offset = "0x101F8B0", VA = "0x181020CB0")]
		private void _UpdateTermFocus()
		{
		}

		// Token: 0x06017DF7 RID: 97783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DF7")]
		[Address(RVA = "0x10205D0", Offset = "0x101F1D0", VA = "0x1810205D0")]
		private void _MoveTermsUp()
		{
		}

		// Token: 0x06017DF8 RID: 97784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DF8")]
		[Address(RVA = "0x1020450", Offset = "0x101F050", VA = "0x181020450")]
		private void _MoveTermsDown()
		{
		}

		// Token: 0x06017DF9 RID: 97785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DF9")]
		[Address(RVA = "0x10202A0", Offset = "0x101EEA0", VA = "0x1810202A0")]
		private void _InitFocusViewIfNeeded()
		{
		}

		// Token: 0x06017DFA RID: 97786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DFA")]
		[Address(RVA = "0x10201F0", Offset = "0x101EDF0", VA = "0x1810201F0")]
		private void _InitFocusPlusViewIfNeeded()
		{
		}

		// Token: 0x06017DFB RID: 97787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DFB")]
		[Address(RVA = "0x10200F0", Offset = "0x101ECF0", VA = "0x1810200F0")]
		private void _InitBottomFlowViewIfNeeded()
		{
		}

		// Token: 0x06017DFC RID: 97788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DFC")]
		[Address(RVA = "0x1020350", Offset = "0x101EF50", VA = "0x181020350")]
		private void _InitUpperFlowViewIfNeeded()
		{
		}

		// Token: 0x06017DFD RID: 97789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DFD")]
		[Address(RVA = "0x101FEE0", Offset = "0x101EAE0", VA = "0x18101FEE0")]
		private void _EnsureTermItemView(ref TermDescriptionTipItemView itemView)
		{
		}

		// Token: 0x06017DFE RID: 97790 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DFE")]
		[Address(RVA = "0x1020040", Offset = "0x101EC40", VA = "0x181020040")]
		private void _EnsureTermParamWrapper(ref UITermDescViewModel viewModel)
		{
		}

		// Token: 0x06017DFF RID: 97791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DFF")]
		[Address(RVA = "0x1020B60", Offset = "0x101F760", VA = "0x181020B60")]
		private void _RenderTopFlowView()
		{
		}

		// Token: 0x06017E00 RID: 97792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E00")]
		[Address(RVA = "0x1020750", Offset = "0x101F350", VA = "0x181020750")]
		private void _RenderBottomFlowView()
		{
		}

		// Token: 0x06017E01 RID: 97793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E01")]
		[Address(RVA = "0x1020A00", Offset = "0x101F600", VA = "0x181020A00")]
		private void _RenderFocusView()
		{
		}

		// Token: 0x06017E02 RID: 97794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E02")]
		[Address(RVA = "0x10208A0", Offset = "0x101F4A0", VA = "0x1810208A0")]
		private void _RenderFocusPlusView()
		{
		}

		// Token: 0x06017E03 RID: 97795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E03")]
		[Address(RVA = "0x101FE30", Offset = "0x101EA30", VA = "0x18101FE30")]
		private IEnumerator TweenShowPanel()
		{
			return null;
		}

		// Token: 0x06017E04 RID: 97796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017E04")]
		[Address(RVA = "0x101FD80", Offset = "0x101E980", VA = "0x18101FD80")]
		private IEnumerator TweenHidePanel()
		{
			return null;
		}

		// Token: 0x06017E05 RID: 97797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E05")]
		[Address(RVA = "0x10210F0", Offset = "0x101FCF0", VA = "0x1810210F0")]
		public TermDescriptionView()
		{
		}

		// Token: 0x0401CD87 RID: 118151
		[Token(Token = "0x401CD87")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _rootView;

		// Token: 0x0401CD88 RID: 118152
		[Token(Token = "0x401CD88")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _btnBack;

		// Token: 0x0401CD89 RID: 118153
		[Token(Token = "0x401CD89")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _tipItemViewContainer;

		// Token: 0x0401CD8A RID: 118154
		[Token(Token = "0x401CD8A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TermDescriptionTipItemView _prefab;

		// Token: 0x0401CD8B RID: 118155
		[Token(Token = "0x401CD8B")]
		[FieldOffset(Offset = "0x38")]
		private List<UITermDescDataModel> m_termList;

		// Token: 0x0401CD8C RID: 118156
		[Token(Token = "0x401CD8C")]
		[FieldOffset(Offset = "0x40")]
		private int m_focuseIdx;

		// Token: 0x0401CD8D RID: 118157
		[Token(Token = "0x401CD8D")]
		[FieldOffset(Offset = "0x44")]
		private int m_focusePlusIdx;

		// Token: 0x0401CD8E RID: 118158
		[Token(Token = "0x401CD8E")]
		private const float FADE_DURATION = 0.23f;

		// Token: 0x0401CD8F RID: 118159
		[Token(Token = "0x401CD8F")]
		[FieldOffset(Offset = "0x48")]
		private bool m_showed;

		// Token: 0x0401CD90 RID: 118160
		[Token(Token = "0x401CD90")]
		[FieldOffset(Offset = "0x50")]
		private TermDescriptionTipItemView m_flowTermItemView;

		// Token: 0x0401CD91 RID: 118161
		[Token(Token = "0x401CD91")]
		[FieldOffset(Offset = "0x58")]
		private TermDescriptionTipItemView m_focusTermItemView;

		// Token: 0x0401CD92 RID: 118162
		[Token(Token = "0x401CD92")]
		[FieldOffset(Offset = "0x60")]
		private TermDescriptionTipItemView m_focusPlusTermItemView;

		// Token: 0x0401CD93 RID: 118163
		[Token(Token = "0x401CD93")]
		[FieldOffset(Offset = "0x68")]
		private UITermDescViewModel m_flowTermViewModel;

		// Token: 0x0401CD94 RID: 118164
		[Token(Token = "0x401CD94")]
		[FieldOffset(Offset = "0x88")]
		private UITermDescViewModel m_focusTermViewModel;

		// Token: 0x0401CD95 RID: 118165
		[Token(Token = "0x401CD95")]
		[FieldOffset(Offset = "0xA8")]
		private UITermDescViewModel m_focusPlusTermViewModel;

		// Token: 0x0401CD96 RID: 118166
		[Token(Token = "0x401CD96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AddTermDescription;

		// Token: 0x0401CD97 RID: 118167
		[Token(Token = "0x401CD97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PopTermDescription;

		// Token: 0x0401CD98 RID: 118168
		[Token(Token = "0x401CD98")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowPanel;

		// Token: 0x0401CD99 RID: 118169
		[Token(Token = "0x401CD99")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HidePanel;

		// Token: 0x0401CD9A RID: 118170
		[Token(Token = "0x401CD9A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateTermFocus;

		// Token: 0x0401CD9B RID: 118171
		[Token(Token = "0x401CD9B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__MoveTermsUp;

		// Token: 0x0401CD9C RID: 118172
		[Token(Token = "0x401CD9C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__MoveTermsDown;

		// Token: 0x0401CD9D RID: 118173
		[Token(Token = "0x401CD9D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__InitFocusViewIfNeeded;

		// Token: 0x0401CD9E RID: 118174
		[Token(Token = "0x401CD9E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitFocusPlusViewIfNeeded;

		// Token: 0x0401CD9F RID: 118175
		[Token(Token = "0x401CD9F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitBottomFlowViewIfNeeded;

		// Token: 0x0401CDA0 RID: 118176
		[Token(Token = "0x401CDA0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__InitUpperFlowViewIfNeeded;

		// Token: 0x0401CDA1 RID: 118177
		[Token(Token = "0x401CDA1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EnsureTermItemView;

		// Token: 0x0401CDA2 RID: 118178
		[Token(Token = "0x401CDA2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EnsureTermParamWrapper;

		// Token: 0x0401CDA3 RID: 118179
		[Token(Token = "0x401CDA3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__RenderTopFlowView;

		// Token: 0x0401CDA4 RID: 118180
		[Token(Token = "0x401CDA4")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__RenderBottomFlowView;

		// Token: 0x0401CDA5 RID: 118181
		[Token(Token = "0x401CDA5")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__RenderFocusView;

		// Token: 0x0401CDA6 RID: 118182
		[Token(Token = "0x401CDA6")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__RenderFocusPlusView;

		// Token: 0x0401CDA7 RID: 118183
		[Token(Token = "0x401CDA7")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_TweenShowPanel;

		// Token: 0x0401CDA8 RID: 118184
		[Token(Token = "0x401CDA8")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_TweenHidePanel;

		// Token: 0x0401CDA9 RID: 118185
		[Token(Token = "0x401CDA9")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
