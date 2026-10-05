using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F8E RID: 28558
	[Token(Token = "0x2006F8E")]
	public class ActMultiV3MatchingModeGroupItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028890 RID: 166032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028890")]
		[Address(RVA = "0x23D9AA0", Offset = "0x23D86A0", VA = "0x1823D9AA0")]
		public void Render(ActMultiV3QuickMatchModel matchModel, ActMultiV3MatchModeGroupModel groupModel)
		{
		}

		// Token: 0x06028891 RID: 166033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028891")]
		[Address(RVA = "0x23D9D60", Offset = "0x23D8960", VA = "0x1823D9D60")]
		private void _UpdateDiffList(ActMultiV3QuickMatchModel matchModel, ActMultiV3MatchModeGroupModel groupModel)
		{
		}

		// Token: 0x06028892 RID: 166034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028892")]
		[Address(RVA = "0x23D9ED0", Offset = "0x23D8AD0", VA = "0x1823D9ED0")]
		public ActMultiV3MatchingModeGroupItemView()
		{
		}

		// Token: 0x04039B70 RID: 236400
		[Token(Token = "0x4039B70")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgModeIcon;

		// Token: 0x04039B71 RID: 236401
		[Token(Token = "0x4039B71")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgGlow;

		// Token: 0x04039B72 RID: 236402
		[Token(Token = "0x4039B72")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActMultiV3MatchingModeGroupItemView.DiffItem[] _diffList;

		// Token: 0x04039B73 RID: 236403
		[Token(Token = "0x4039B73")]
		[FieldOffset(Offset = "0x30")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04039B74 RID: 236404
		[Token(Token = "0x4039B74")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04039B75 RID: 236405
		[Token(Token = "0x4039B75")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateDiffList;

		// Token: 0x04039B76 RID: 236406
		[Token(Token = "0x4039B76")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F8F RID: 28559
		[Token(Token = "0x2006F8F")]
		[Serializable]
		public class DiffItem
		{
			// Token: 0x06028893 RID: 166035 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028893")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DiffItem()
			{
			}

			// Token: 0x04039B77 RID: 236407
			[Token(Token = "0x4039B77")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3MapDiffType diffType;

			// Token: 0x04039B78 RID: 236408
			[Token(Token = "0x4039B78")]
			[FieldOffset(Offset = "0x18")]
			public GameObject diffGO;
		}
	}
}
