using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004736 RID: 18230
	[Token(Token = "0x2004736")]
	public class RecruitBuildConfigTagGroupView : DataBinder<BuildConfigTagGroupViewProperty>
	{
		// Token: 0x0601BA13 RID: 113171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA13")]
		[Address(RVA = "0x14F7620", Offset = "0x14F6220", VA = "0x1814F7620")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BA14 RID: 113172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA14")]
		[Address(RVA = "0x14F7A80", Offset = "0x14F6680", VA = "0x1814F7A80")]
		private void _RefreshTagState(object obj)
		{
		}

		// Token: 0x0601BA15 RID: 113173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA15")]
		[Address(RVA = "0x14F7430", Offset = "0x14F6030", VA = "0x1814F7430", Slot = "7")]
		public override void OnValueChanged(BuildConfigTagGroupViewProperty property)
		{
		}

		// Token: 0x0601BA16 RID: 113174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA16")]
		[Address(RVA = "0x14F79F0", Offset = "0x14F65F0", VA = "0x1814F79F0")]
		private void _OnTagClick(int tagIndex)
		{
		}

		// Token: 0x0601BA17 RID: 113175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA17")]
		[Address(RVA = "0x14F7BC0", Offset = "0x14F67C0", VA = "0x1814F7BC0")]
		public RecruitBuildConfigTagGroupView()
		{
		}

		// Token: 0x04023D39 RID: 146745
		[Token(Token = "0x4023D39")]
		private const int TAG_COUNT = 6;

		// Token: 0x04023D3A RID: 146746
		[Token(Token = "0x4023D3A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("The param is the tag's index")]
		private UIIntEvent _tagClickEvent;

		// Token: 0x04023D3B RID: 146747
		[Token(Token = "0x4023D3B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _emptyState;

		// Token: 0x04023D3C RID: 146748
		[Token(Token = "0x4023D3C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _unFinishState;

		// Token: 0x04023D3D RID: 146749
		[Token(Token = "0x4023D3D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _finishState;

		// Token: 0x04023D3E RID: 146750
		[Token(Token = "0x4023D3E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RecruitBuildConfigTagView _tagPrefab;

		// Token: 0x04023D3F RID: 146751
		[Token(Token = "0x4023D3F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _tagContainer;

		// Token: 0x04023D40 RID: 146752
		[Token(Token = "0x4023D40")]
		[FieldOffset(Offset = "0x50")]
		private RecruitBuildConfigTagView[] m_tagViews;

		// Token: 0x04023D41 RID: 146753
		[Token(Token = "0x4023D41")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04023D42 RID: 146754
		[Token(Token = "0x4023D42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04023D43 RID: 146755
		[Token(Token = "0x4023D43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RefreshTagState;

		// Token: 0x04023D44 RID: 146756
		[Token(Token = "0x4023D44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023D45 RID: 146757
		[Token(Token = "0x4023D45")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnTagClick;

		// Token: 0x04023D46 RID: 146758
		[Token(Token = "0x4023D46")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
