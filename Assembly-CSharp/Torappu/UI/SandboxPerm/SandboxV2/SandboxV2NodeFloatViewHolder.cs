using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004253 RID: 16979
	[Token(Token = "0x2004253")]
	public class SandboxV2NodeFloatViewHolder : MonoBehaviour, ISandboxV2OrderedView, IHotfixable
	{
		// Token: 0x0601A2C1 RID: 107201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2C1")]
		[Address(RVA = "0x131D860", Offset = "0x131C460", VA = "0x18131D860")]
		public void Render(SandboxV2DungeonNodeViewModel nodeViewModel, SandboxV2DungeonViewModel dungeonViewModel)
		{
		}

		// Token: 0x0601A2C2 RID: 107202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2C2")]
		[Address(RVA = "0x131D7A0", Offset = "0x131C3A0", VA = "0x18131D7A0", Slot = "4")]
		public void OnRecycle()
		{
		}

		// Token: 0x0601A2C3 RID: 107203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A2C3")]
		[Address(RVA = "0x131DB10", Offset = "0x131C710", VA = "0x18131DB10")]
		public SandboxV2NodeFloatViewHolder()
		{
		}

		// Token: 0x0402113A RID: 135482
		[Token(Token = "0x402113A")]
		private const uint PER_OBJ_COST = 15U;

		// Token: 0x0402113B RID: 135483
		[Token(Token = "0x402113B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2NodeFloatView _floatViewPrefab;

		// Token: 0x0402113C RID: 135484
		[Token(Token = "0x402113C")]
		[FieldOffset(Offset = "0x20")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402113D RID: 135485
		[Token(Token = "0x402113D")]
		[FieldOffset(Offset = "0x30")]
		private AsyncDataViewHandler<SandboxV2NodeFloatView, SandboxV2NodeFloatView.RenderParam> m_viewHandler;

		// Token: 0x0402113E RID: 135486
		[Token(Token = "0x402113E")]
		[FieldOffset(Offset = "0x38")]
		private SandboxV2DungeonViewModel m_cachedDungeonViewModel;

		// Token: 0x0402113F RID: 135487
		[Token(Token = "0x402113F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04021140 RID: 135488
		[Token(Token = "0x4021140")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRecycle;

		// Token: 0x04021141 RID: 135489
		[Token(Token = "0x4021141")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
