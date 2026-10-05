using System;
using Il2CppDummyDll;
using Torappu.UI.TemplateCharSelect;
using UnityEngine;
using XLua;

namespace Torappu.UI.AutoChess.CharSelect
{
	// Token: 0x020063C7 RID: 25543
	[Token(Token = "0x20063C7")]
	public class AutoChessCharSelectShuffleView : TemplateCharSelectShuffleViewBase<AutoChessCharSelectShuffleViewModel>
	{
		// Token: 0x06024D44 RID: 150852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D44")]
		[Address(RVA = "0x1FBB590", Offset = "0x1FBA190", VA = "0x181FBB590", Slot = "11")]
		protected override void OnRenderViewModel(TemplateCharSelectMainViewModel mainViewModel)
		{
		}

		// Token: 0x06024D45 RID: 150853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D45")]
		[Address(RVA = "0x1FBBB90", Offset = "0x1FBA790", VA = "0x181FBBB90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024D46 RID: 150854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D46")]
		[Address(RVA = "0x1FBBA70", Offset = "0x1FBA670", VA = "0x181FBBA70")]
		private void _EventOnFilterShow(bool show)
		{
		}

		// Token: 0x06024D47 RID: 150855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D47")]
		[Address(RVA = "0x1FBB8A0", Offset = "0x1FBA4A0", VA = "0x181FBB8A0")]
		private void _EventOnFilterChange(UICharacterProfessionFilterHolder.FilterParam filterParam)
		{
		}

		// Token: 0x06024D48 RID: 150856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024D48")]
		[Address(RVA = "0x1FBBD30", Offset = "0x1FBA930", VA = "0x181FBBD30")]
		public AutoChessCharSelectShuffleView()
		{
		}

		// Token: 0x040337DA RID: 210906
		[Token(Token = "0x40337DA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICharacterSortFilterPanel _sortFilterPanel;

		// Token: 0x040337DB RID: 210907
		[Token(Token = "0x40337DB")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x040337DC RID: 210908
		[Token(Token = "0x40337DC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x040337DD RID: 210909
		[Token(Token = "0x40337DD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040337DE RID: 210910
		[Token(Token = "0x40337DE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnFilterShow;

		// Token: 0x040337DF RID: 210911
		[Token(Token = "0x40337DF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnFilterChange;

		// Token: 0x040337E0 RID: 210912
		[Token(Token = "0x40337E0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
