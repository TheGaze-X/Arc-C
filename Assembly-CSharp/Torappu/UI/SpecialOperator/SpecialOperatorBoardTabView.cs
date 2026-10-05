using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003EA8 RID: 16040
	[Token(Token = "0x2003EA8")]
	public class SpecialOperatorBoardTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003B63 RID: 15203
		// (get) Token: 0x06018E5A RID: 101978 RVA: 0x0009C5A0 File Offset: 0x0009A7A0
		[Token(Token = "0x17003B63")]
		public SpecialOperatorBoardTabType tabType
		{
			[Token(Token = "0x6018E5A")]
			[Address(RVA = "0x1191FE0", Offset = "0x1190BE0", VA = "0x181191FE0")]
			get
			{
				return SpecialOperatorBoardTabType.NONE;
			}
		}

		// Token: 0x06018E5B RID: 101979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E5B")]
		[Address(RVA = "0x1191D40", Offset = "0x1190940", VA = "0x181191D40")]
		public void Render(SpecialOperatorBoardTabType curTabType, SpecialOperatorBoardTabView.Param param)
		{
		}

		// Token: 0x06018E5C RID: 101980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E5C")]
		[Address(RVA = "0x1191C60", Offset = "0x1190860", VA = "0x181191C60")]
		public void OnTabSelected()
		{
		}

		// Token: 0x06018E5D RID: 101981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018E5D")]
		[Address(RVA = "0x1191F80", Offset = "0x1190B80", VA = "0x181191F80")]
		public SpecialOperatorBoardTabView()
		{
		}

		// Token: 0x0401EB58 RID: 125784
		[Token(Token = "0x401EB58")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpecialOperatorBoardTabType _tabType;

		// Token: 0x0401EB59 RID: 125785
		[Token(Token = "0x401EB59")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hotspot;

		// Token: 0x0401EB5A RID: 125786
		[Token(Token = "0x401EB5A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Graphic[] _contentGraphics;

		// Token: 0x0401EB5B RID: 125787
		[Token(Token = "0x401EB5B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _selectedColor;

		// Token: 0x0401EB5C RID: 125788
		[Token(Token = "0x401EB5C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _unselectedColor;

		// Token: 0x0401EB5D RID: 125789
		[Token(Token = "0x401EB5D")]
		[FieldOffset(Offset = "0x50")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401EB5E RID: 125790
		[Token(Token = "0x401EB5E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tabType;

		// Token: 0x0401EB5F RID: 125791
		[Token(Token = "0x401EB5F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401EB60 RID: 125792
		[Token(Token = "0x401EB60")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTabSelected;

		// Token: 0x0401EB61 RID: 125793
		[Token(Token = "0x401EB61")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003EA9 RID: 16041
		[Token(Token = "0x2003EA9")]
		public struct Param
		{
			// Token: 0x0401EB62 RID: 125794
			[Token(Token = "0x401EB62")]
			[FieldOffset(Offset = "0x0")]
			public bool isFirstRender;

			// Token: 0x0401EB63 RID: 125795
			[Token(Token = "0x401EB63")]
			[FieldOffset(Offset = "0x4")]
			public float tweenDuration;
		}
	}
}
