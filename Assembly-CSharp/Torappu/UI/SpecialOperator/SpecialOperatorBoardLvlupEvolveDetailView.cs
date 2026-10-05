using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E6D RID: 15981
	[Token(Token = "0x2003E6D")]
	public class SpecialOperatorBoardLvlupEvolveDetailView : SpecialOperatorBoardLvlupDetailView<SpecialOperatorBoardEvolveNodeViewModel>
	{
		// Token: 0x06018D85 RID: 101765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D85")]
		[Address(RVA = "0x118A4E0", Offset = "0x11890E0", VA = "0x18118A4E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018D86 RID: 101766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D86")]
		[Address(RVA = "0x1189CC0", Offset = "0x11888C0", VA = "0x181189CC0", Slot = "7")]
		public override void Render(SpecialOperatorBoardEvolveNodeViewModel viewModel, bool fastMode)
		{
		}

		// Token: 0x06018D87 RID: 101767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D87")]
		[Address(RVA = "0x118A460", Offset = "0x1189060", VA = "0x18118A460", Slot = "5")]
		public override void SetViewShow(bool isShow)
		{
		}

		// Token: 0x17003B4D RID: 15181
		// (get) Token: 0x06018D88 RID: 101768 RVA: 0x0009C2B8 File Offset: 0x0009A4B8
		[Token(Token = "0x17003B4D")]
		public override SpecialOperatorDetailNodeType nodeType
		{
			[Token(Token = "0x6018D88")]
			[Address(RVA = "0x118A7A0", Offset = "0x11893A0", VA = "0x18118A7A0", Slot = "4")]
			get
			{
				return SpecialOperatorDetailNodeType.NONE;
			}
		}

		// Token: 0x06018D89 RID: 101769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D89")]
		[Address(RVA = "0x1189C20", Offset = "0x1188820", VA = "0x181189C20")]
		public void OnClick()
		{
		}

		// Token: 0x06018D8A RID: 101770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D8A")]
		[Address(RVA = "0x118A6D0", Offset = "0x11892D0", VA = "0x18118A6D0")]
		public SpecialOperatorBoardLvlupEvolveDetailView()
		{
		}

		// Token: 0x0401E909 RID: 125193
		[Token(Token = "0x401E909")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _icon;

		// Token: 0x0401E90A RID: 125194
		[Token(Token = "0x401E90A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelRoot;

		// Token: 0x0401E90B RID: 125195
		[Token(Token = "0x401E90B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _featureContent;

		// Token: 0x0401E90C RID: 125196
		[Token(Token = "0x401E90C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelEvolvePre;

		// Token: 0x0401E90D RID: 125197
		[Token(Token = "0x401E90D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelCanEvolve;

		// Token: 0x0401E90E RID: 125198
		[Token(Token = "0x401E90E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelEvolved;

		// Token: 0x0401E90F RID: 125199
		[Token(Token = "0x401E90F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelTaskFinished;

		// Token: 0x0401E910 RID: 125200
		[Token(Token = "0x401E910")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _taskDesc;

		// Token: 0x0401E911 RID: 125201
		[Token(Token = "0x401E911")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Color _unfinishedTaskColor;

		// Token: 0x0401E912 RID: 125202
		[Token(Token = "0x401E912")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Color _finishedTaskColor;

		// Token: 0x0401E913 RID: 125203
		[Token(Token = "0x401E913")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text _title;

		// Token: 0x0401E914 RID: 125204
		[Token(Token = "0x401E914")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textEvolvePreBtn;

		// Token: 0x0401E915 RID: 125205
		[Token(Token = "0x401E915")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private ScrollRect _contentScrollRect;

		// Token: 0x0401E916 RID: 125206
		[Token(Token = "0x401E916")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ScrollRect _taskScrollRect;

		// Token: 0x0401E917 RID: 125207
		[Token(Token = "0x401E917")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _panelHotspot;

		// Token: 0x0401E918 RID: 125208
		[Token(Token = "0x401E918")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIAnimationLocation _unlockAnim;

		// Token: 0x0401E919 RID: 125209
		[Token(Token = "0x401E919")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isInited;

		// Token: 0x0401E91A RID: 125210
		[Token(Token = "0x401E91A")]
		[FieldOffset(Offset = "0xD0")]
		private SpecialOperatorBoardLvlupEvolveDetailView.Adapter m_adapter;

		// Token: 0x0401E91B RID: 125211
		[Token(Token = "0x401E91B")]
		[FieldOffset(Offset = "0xD8")]
		private List<SpecialOperatorBoardEvolveNodeViewModel.Feature> m_cachedFeature;

		// Token: 0x0401E91C RID: 125212
		[Token(Token = "0x401E91C")]
		[FieldOffset(Offset = "0xE0")]
		private int m_evolvePhase;

		// Token: 0x0401E91D RID: 125213
		[Token(Token = "0x401E91D")]
		[FieldOffset(Offset = "0xE8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401E91E RID: 125214
		[Token(Token = "0x401E91E")]
		[FieldOffset(Offset = "0xF8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E91F RID: 125215
		[Token(Token = "0x401E91F")]
		[FieldOffset(Offset = "0x108")]
		private AnimationSwitchTween m_unlockTween;

		// Token: 0x0401E920 RID: 125216
		[Token(Token = "0x401E920")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E921 RID: 125217
		[Token(Token = "0x401E921")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E922 RID: 125218
		[Token(Token = "0x401E922")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetViewShow;

		// Token: 0x0401E923 RID: 125219
		[Token(Token = "0x401E923")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_nodeType;

		// Token: 0x0401E924 RID: 125220
		[Token(Token = "0x401E924")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401E925 RID: 125221
		[Token(Token = "0x401E925")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E6E RID: 15982
		[Token(Token = "0x2003E6E")]
		private enum State
		{
			// Token: 0x0401E927 RID: 125223
			[Token(Token = "0x401E927")]
			EVOLVE_PRE,
			// Token: 0x0401E928 RID: 125224
			[Token(Token = "0x401E928")]
			CAN_EVOLVE,
			// Token: 0x0401E929 RID: 125225
			[Token(Token = "0x401E929")]
			EVOLVED
		}

		// Token: 0x02003E6F RID: 15983
		[Token(Token = "0x2003E6F")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06018D8B RID: 101771 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018D8B")]
			[Address(RVA = "0x1181A90", Offset = "0x1180690", VA = "0x181181A90")]
			public Adapter(SpecialOperatorBoardLvlupEvolveDetailView closure)
			{
			}

			// Token: 0x17003B4E RID: 15182
			// (get) Token: 0x06018D8C RID: 101772 RVA: 0x0009C2D0 File Offset: 0x0009A4D0
			[Token(Token = "0x17003B4E")]
			public override int count
			{
				[Token(Token = "0x6018D8C")]
				[Address(RVA = "0x1181BA0", Offset = "0x11807A0", VA = "0x181181BA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018D8D RID: 101773 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018D8D")]
			[Address(RVA = "0x1181430", Offset = "0x1180030", VA = "0x181181430", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401E92A RID: 125226
			[Token(Token = "0x401E92A")]
			[FieldOffset(Offset = "0x20")]
			private SpecialOperatorBoardLvlupEvolveDetailView m_closure;

			// Token: 0x0401E92B RID: 125227
			[Token(Token = "0x401E92B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E92C RID: 125228
			[Token(Token = "0x401E92C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E92D RID: 125229
			[Token(Token = "0x401E92D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
