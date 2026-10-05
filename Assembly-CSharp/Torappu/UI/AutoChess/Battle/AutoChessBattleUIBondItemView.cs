using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064D6 RID: 25814
	[Token(Token = "0x20064D6")]
	public class AutoChessBattleUIBondItemView : UISimpleRecycleLayoutItemView<AutoChessBondItemModel>, IHotfixable
	{
		// Token: 0x0602517D RID: 151933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602517D")]
		[Address(RVA = "0x1FE4340", Offset = "0x1FE2F40", VA = "0x181FE4340", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x0602517E RID: 151934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602517E")]
		[Address(RVA = "0x1FE43B0", Offset = "0x1FE2FB0", VA = "0x181FE43B0", Slot = "6")]
		protected override void OnRender(AutoChessBondItemModel viewModel, ValueBundle value)
		{
		}

		// Token: 0x0602517F RID: 151935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602517F")]
		[Address(RVA = "0x1FE4730", Offset = "0x1FE3330", VA = "0x181FE4730")]
		private void _RegisterTutorialGOIfNeed()
		{
		}

		// Token: 0x06025180 RID: 151936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025180")]
		[Address(RVA = "0x1FE4630", Offset = "0x1FE3230", VA = "0x181FE4630")]
		public void OnSetSelectedIdx()
		{
		}

		// Token: 0x06025181 RID: 151937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025181")]
		[Address(RVA = "0x1FE48B0", Offset = "0x1FE34B0", VA = "0x181FE48B0")]
		private void _RenderContent(AutoChessBondItemModel itemModel)
		{
		}

		// Token: 0x06025182 RID: 151938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025182")]
		[Address(RVA = "0x1FE4A80", Offset = "0x1FE3680", VA = "0x181FE4A80")]
		private void _RenderSelection(string selectedBondId, AutoChessGameStatus.SubState subState)
		{
		}

		// Token: 0x06025183 RID: 151939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025183")]
		[Address(RVA = "0x1FE4C80", Offset = "0x1FE3880", VA = "0x181FE4C80")]
		public AutoChessBattleUIBondItemView()
		{
		}

		// Token: 0x04033F6E RID: 212846
		[Token(Token = "0x4033F6E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AutoChessBattleUIBondIconView _iconView;

		// Token: 0x04033F6F RID: 212847
		[Token(Token = "0x4033F6F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _stackGrp;

		// Token: 0x04033F70 RID: 212848
		[Token(Token = "0x4033F70")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _stackText;

		// Token: 0x04033F71 RID: 212849
		[Token(Token = "0x4033F71")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04033F72 RID: 212850
		[Token(Token = "0x4033F72")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AutoChessBattleUIBondItemView.ColorConfig _inactiveColorConfig;

		// Token: 0x04033F73 RID: 212851
		[Token(Token = "0x4033F73")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AutoChessBattleUIBondItemView.ColorConfig _activeColorConfig;

		// Token: 0x04033F74 RID: 212852
		[Token(Token = "0x4033F74")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _selectedObj;

		// Token: 0x04033F75 RID: 212853
		[Token(Token = "0x4033F75")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _selectAnimLocation;

		// Token: 0x04033F76 RID: 212854
		[Token(Token = "0x4033F76")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Graphic _tutorialGraphic;

		// Token: 0x04033F77 RID: 212855
		[Token(Token = "0x4033F77")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private TwoStateToggle _hotspotToggle;

		// Token: 0x04033F78 RID: 212856
		[Token(Token = "0x4033F78")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cachedBondId;

		// Token: 0x04033F79 RID: 212857
		[Token(Token = "0x4033F79")]
		[FieldOffset(Offset = "0xB8")]
		private string m_cachedSelectedBondId;

		// Token: 0x04033F7A RID: 212858
		[Token(Token = "0x4033F7A")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_tween;

		// Token: 0x04033F7B RID: 212859
		[Token(Token = "0x4033F7B")]
		[FieldOffset(Offset = "0xC8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04033F7C RID: 212860
		[Token(Token = "0x4033F7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033F7D RID: 212861
		[Token(Token = "0x4033F7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04033F7E RID: 212862
		[Token(Token = "0x4033F7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RegisterTutorialGOIfNeed;

		// Token: 0x04033F7F RID: 212863
		[Token(Token = "0x4033F7F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnSetSelectedIdx;

		// Token: 0x04033F80 RID: 212864
		[Token(Token = "0x4033F80")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderContent;

		// Token: 0x04033F81 RID: 212865
		[Token(Token = "0x4033F81")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderSelection;

		// Token: 0x04033F82 RID: 212866
		[Token(Token = "0x4033F82")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020064D7 RID: 25815
		[Token(Token = "0x20064D7")]
		[Serializable]
		public struct ColorConfig
		{
			// Token: 0x04033F83 RID: 212867
			[Token(Token = "0x4033F83")]
			[FieldOffset(Offset = "0x0")]
			public Color nameColor;

			// Token: 0x04033F84 RID: 212868
			[Token(Token = "0x4033F84")]
			[FieldOffset(Offset = "0x10")]
			public Color stackColor;
		}
	}
}
