using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AsyncLoader;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D59 RID: 15705
	[Token(Token = "0x2003D59")]
	public class TemplateShopGroupListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601875F RID: 100191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601875F")]
		[Address(RVA = "0x10F3740", Offset = "0x10F2340", VA = "0x1810F3740")]
		public void _InitIfNot()
		{
		}

		// Token: 0x06018760 RID: 100192 RVA: 0x0009A740 File Offset: 0x00098940
		[Token(Token = "0x6018760")]
		[Address(RVA = "0x10F2F70", Offset = "0x10F1B70", VA = "0x1810F2F70")]
		private int CalcConstraint()
		{
			return 0;
		}

		// Token: 0x06018761 RID: 100193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018761")]
		[Address(RVA = "0x10F30A0", Offset = "0x10F1CA0", VA = "0x1810F30A0")]
		public void FocusOnIndex(int itemIndex)
		{
		}

		// Token: 0x06018762 RID: 100194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018762")]
		[Address(RVA = "0x10F3280", Offset = "0x10F1E80", VA = "0x1810F3280")]
		public void Render(List<TemplateShopGroupViewModel> viewModelList, TemplateShopResHolder resHolder)
		{
		}

		// Token: 0x06018763 RID: 100195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018763")]
		[Address(RVA = "0x10F38E0", Offset = "0x10F24E0", VA = "0x1810F38E0")]
		public TemplateShopGroupListView()
		{
		}

		// Token: 0x0401DF31 RID: 122673
		[Token(Token = "0x401DF31")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector2 CELL_SIZE;

		// Token: 0x0401DF32 RID: 122674
		[Token(Token = "0x401DF32")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Vector2 SPACING;

		// Token: 0x0401DF33 RID: 122675
		[Token(Token = "0x401DF33")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIRecycleHorizonLayoutGroup _recycleList;

		// Token: 0x0401DF34 RID: 122676
		[Token(Token = "0x401DF34")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TemplateShopLoopGroupView _groupView;

		// Token: 0x0401DF35 RID: 122677
		[Token(Token = "0x401DF35")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public AsyncGameObjectLoader objLoader;

		// Token: 0x0401DF36 RID: 122678
		[Token(Token = "0x401DF36")]
		[FieldOffset(Offset = "0x30")]
		private TemplateShopGroupLoopAdapter m_loopAdapter;

		// Token: 0x0401DF37 RID: 122679
		[Token(Token = "0x401DF37")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0401DF38 RID: 122680
		[Token(Token = "0x401DF38")]
		[FieldOffset(Offset = "0x40")]
		private int m_constraintCount;

		// Token: 0x0401DF39 RID: 122681
		[Token(Token = "0x401DF39")]
		[FieldOffset(Offset = "0x44")]
		private bool m_isInited;

		// Token: 0x0401DF3A RID: 122682
		[Token(Token = "0x401DF3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DF3B RID: 122683
		[Token(Token = "0x401DF3B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CalcConstraint;

		// Token: 0x0401DF3C RID: 122684
		[Token(Token = "0x401DF3C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FocusOnIndex;

		// Token: 0x0401DF3D RID: 122685
		[Token(Token = "0x401DF3D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DF3E RID: 122686
		[Token(Token = "0x401DF3E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
