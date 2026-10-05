using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003EAB RID: 16043
	[Token(Token = "0x2003EAB")]
	public class SpecialOperatorBoardUniEquipNodeView : SpecialOperatorPointViewBase
	{
		// Token: 0x17003B65 RID: 15205
		// (get) Token: 0x06018E68 RID: 101992 RVA: 0x0009C5E8 File Offset: 0x0009A7E8
		[Token(Token = "0x17003B65")]
		public override SpecialOperatorPointViewType viewType
		{
			[Token(Token = "0x6018E68")]
			[Address(RVA = "0x1193840", Offset = "0x1192440", VA = "0x181193840", Slot = "6")]
			get
			{
				return SpecialOperatorPointViewType.NONE;
			}
		}

		// Token: 0x06018E69 RID: 101993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E69")]
		[Address(RVA = "0x11931B0", Offset = "0x1191DB0", VA = "0x1811931B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018E6A RID: 101994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E6A")]
		[Address(RVA = "0x1192B20", Offset = "0x1191720", VA = "0x181192B20", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x06018E6B RID: 101995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E6B")]
		[Address(RVA = "0x1192CB0", Offset = "0x11918B0", VA = "0x181192CB0", Slot = "4")]
		protected override void OnRender()
		{
		}

		// Token: 0x06018E6C RID: 101996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E6C")]
		[Address(RVA = "0x1193360", Offset = "0x1191F60", VA = "0x181193360")]
		private void _RenderIcon(SpecialOperatorBoardUniEquipNodeView.RenderState renderState, UniEquipData equipData)
		{
		}

		// Token: 0x06018E6D RID: 101997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E6D")]
		[Address(RVA = "0x1193530", Offset = "0x1192130", VA = "0x181193530")]
		private void _RenderNode(SpecialOperatorBoardUniEquipNodeView.RenderState renderState)
		{
		}

		// Token: 0x06018E6E RID: 101998 RVA: 0x0009C600 File Offset: 0x0009A800
		[Token(Token = "0x6018E6E")]
		[Address(RVA = "0x1193020", Offset = "0x1191C20", VA = "0x181193020")]
		private SpecialOperatorBoardUniEquipNodeView.RenderState _CalcRenderState(SpecialOperatorBoardUniEquipNode equipNodeModel)
		{
			return SpecialOperatorBoardUniEquipNodeView.RenderState.LOCK;
		}

		// Token: 0x06018E6F RID: 101999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E6F")]
		[Address(RVA = "0x1193660", Offset = "0x1192260", VA = "0x181193660")]
		private void _SetNodeUnlockAnim(bool isNode, bool isUnlock, bool isFastMode)
		{
		}

		// Token: 0x06018E70 RID: 102000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E70")]
		[Address(RVA = "0x1192A30", Offset = "0x1191630", VA = "0x181192A30")]
		public void OnClick()
		{
		}

		// Token: 0x06018E71 RID: 102001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E71")]
		[Address(RVA = "0x1193790", Offset = "0x1192390", VA = "0x181193790")]
		public SpecialOperatorBoardUniEquipNodeView()
		{
		}

		// Token: 0x06018E72 RID: 102002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E72")]
		[Address(RVA = "0x118ECE0", Offset = "0x118D8E0", VA = "0x18118ECE0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x06018E73 RID: 102003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E73")]
		[Address(RVA = "0x118ED40", Offset = "0x118D940", VA = "0x18118ED40")]
		private void <>xLuaBaseProxy_OnRender()
		{
		}

		// Token: 0x0401EB7B RID: 125819
		[Token(Token = "0x401EB7B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelIcon;

		// Token: 0x0401EB7C RID: 125820
		[Token(Token = "0x401EB7C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelNode;

		// Token: 0x0401EB7D RID: 125821
		[Token(Token = "0x401EB7D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonEquipTypeIcon _equipTypeIcon;

		// Token: 0x0401EB7E RID: 125822
		[Token(Token = "0x401EB7E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelIconLockBack;

		// Token: 0x0401EB7F RID: 125823
		[Token(Token = "0x401EB7F")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelIconCanUnlockBack;

		// Token: 0x0401EB80 RID: 125824
		[Token(Token = "0x401EB80")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelIconCanUnlock;

		// Token: 0x0401EB81 RID: 125825
		[Token(Token = "0x401EB81")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelIconLockpre;

		// Token: 0x0401EB82 RID: 125826
		[Token(Token = "0x401EB82")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x0401EB83 RID: 125827
		[Token(Token = "0x401EB83")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _panelLockpre;

		// Token: 0x0401EB84 RID: 125828
		[Token(Token = "0x401EB84")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelCanUnlock;

		// Token: 0x0401EB85 RID: 125829
		[Token(Token = "0x401EB85")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelTag;

		// Token: 0x0401EB86 RID: 125830
		[Token(Token = "0x401EB86")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _level;

		// Token: 0x0401EB87 RID: 125831
		[Token(Token = "0x401EB87")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _iconUnlockAnim;

		// Token: 0x0401EB88 RID: 125832
		[Token(Token = "0x401EB88")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _nodeUnlockAnim;

		// Token: 0x0401EB89 RID: 125833
		[Token(Token = "0x401EB89")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x0401EB8A RID: 125834
		[Token(Token = "0x401EB8A")]
		[FieldOffset(Offset = "0xB8")]
		private string m_nodeId;

		// Token: 0x0401EB8B RID: 125835
		[Token(Token = "0x401EB8B")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isRenderNode;

		// Token: 0x0401EB8C RID: 125836
		[Token(Token = "0x401EB8C")]
		[FieldOffset(Offset = "0xC8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EB8D RID: 125837
		[Token(Token = "0x401EB8D")]
		[FieldOffset(Offset = "0xD8")]
		private AnimationSwitchTween m_iconUnlockTween;

		// Token: 0x0401EB8E RID: 125838
		[Token(Token = "0x401EB8E")]
		[FieldOffset(Offset = "0xE0")]
		private AnimationSwitchTween m_nodeUnlockTween;

		// Token: 0x0401EB8F RID: 125839
		[Token(Token = "0x401EB8F")]
		[FieldOffset(Offset = "0xE8")]
		private string m_equipId;

		// Token: 0x0401EB90 RID: 125840
		[Token(Token = "0x401EB90")]
		[FieldOffset(Offset = "0xF0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401EB91 RID: 125841
		[Token(Token = "0x401EB91")]
		[FieldOffset(Offset = "0x100")]
		private int m_cachedEnterSeq;

		// Token: 0x0401EB92 RID: 125842
		[Token(Token = "0x401EB92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewType;

		// Token: 0x0401EB93 RID: 125843
		[Token(Token = "0x401EB93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401EB94 RID: 125844
		[Token(Token = "0x401EB94")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401EB95 RID: 125845
		[Token(Token = "0x401EB95")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0401EB96 RID: 125846
		[Token(Token = "0x401EB96")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderIcon;

		// Token: 0x0401EB97 RID: 125847
		[Token(Token = "0x401EB97")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderNode;

		// Token: 0x0401EB98 RID: 125848
		[Token(Token = "0x401EB98")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalcRenderState;

		// Token: 0x0401EB99 RID: 125849
		[Token(Token = "0x401EB99")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetNodeUnlockAnim;

		// Token: 0x0401EB9A RID: 125850
		[Token(Token = "0x401EB9A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401EB9B RID: 125851
		[Token(Token = "0x401EB9B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003EAC RID: 16044
		[Token(Token = "0x2003EAC")]
		private enum RenderState
		{
			// Token: 0x0401EB9D RID: 125853
			[Token(Token = "0x401EB9D")]
			LOCK,
			// Token: 0x0401EB9E RID: 125854
			[Token(Token = "0x401EB9E")]
			LOCK_PRE,
			// Token: 0x0401EB9F RID: 125855
			[Token(Token = "0x401EB9F")]
			CAN_UNLOCK,
			// Token: 0x0401EBA0 RID: 125856
			[Token(Token = "0x401EBA0")]
			UNLOCK
		}
	}
}
