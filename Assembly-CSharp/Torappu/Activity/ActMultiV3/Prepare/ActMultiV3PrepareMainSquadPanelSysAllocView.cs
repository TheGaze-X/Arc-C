using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x02007079 RID: 28793
	[Token(Token = "0x2007079")]
	public class ActMultiV3PrepareMainSquadPanelSysAllocView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06028E42 RID: 167490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E42")]
		[Address(RVA = "0x245B530", Offset = "0x245A130", VA = "0x18245B530")]
		public void Show(ActMultiV3PrepareMainSquadPanelViewModel.SysAllocModel model)
		{
		}

		// Token: 0x06028E43 RID: 167491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E43")]
		[Address(RVA = "0x245B3C0", Offset = "0x2459FC0", VA = "0x18245B3C0")]
		public void Hide()
		{
		}

		// Token: 0x06028E44 RID: 167492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E44")]
		[Address(RVA = "0x245B440", Offset = "0x245A040", VA = "0x18245B440")]
		private void OnDestroy()
		{
		}

		// Token: 0x06028E45 RID: 167493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E45")]
		[Address(RVA = "0x245B6A0", Offset = "0x245A2A0", VA = "0x18245B6A0")]
		private void _ClearCoroutine()
		{
		}

		// Token: 0x06028E46 RID: 167494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E46")]
		[Address(RVA = "0x245B4A0", Offset = "0x245A0A0", VA = "0x18245B4A0")]
		public void Reset(bool v)
		{
		}

		// Token: 0x06028E47 RID: 167495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E47")]
		[Address(RVA = "0x245B790", Offset = "0x245A390", VA = "0x18245B790")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028E48 RID: 167496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028E48")]
		[Address(RVA = "0x245B8F0", Offset = "0x245A4F0", VA = "0x18245B8F0")]
		public ActMultiV3PrepareMainSquadPanelSysAllocView()
		{
		}

		// Token: 0x0403A549 RID: 238921
		[Token(Token = "0x403A549")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGrp;

		// Token: 0x0403A54A RID: 238922
		[Token(Token = "0x403A54A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403A54B RID: 238923
		[Token(Token = "0x403A54B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _cardListContent;

		// Token: 0x0403A54C RID: 238924
		[Token(Token = "0x403A54C")]
		[FieldOffset(Offset = "0x38")]
		private ActMultiV3PrepareMainSquadPanelSysAllocView.Adapter m_adapter;

		// Token: 0x0403A54D RID: 238925
		[Token(Token = "0x403A54D")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine m_switchCoroutine;

		// Token: 0x0403A54E RID: 238926
		[Token(Token = "0x403A54E")]
		[FieldOffset(Offset = "0x48")]
		private FadeSwitchTween m_switch;

		// Token: 0x0403A54F RID: 238927
		[Token(Token = "0x403A54F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0403A550 RID: 238928
		[Token(Token = "0x403A550")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0403A551 RID: 238929
		[Token(Token = "0x403A551")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403A552 RID: 238930
		[Token(Token = "0x403A552")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ClearCoroutine;

		// Token: 0x0403A553 RID: 238931
		[Token(Token = "0x403A553")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x0403A554 RID: 238932
		[Token(Token = "0x403A554")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A555 RID: 238933
		[Token(Token = "0x403A555")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200707A RID: 28794
		[Token(Token = "0x200707A")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x170060B3 RID: 24755
			// (get) Token: 0x06028E49 RID: 167497 RVA: 0x000D3818 File Offset: 0x000D1A18
			[Token(Token = "0x170060B3")]
			public override int count
			{
				[Token(Token = "0x6028E49")]
				[Address(RVA = "0x24619E0", Offset = "0x24605E0", VA = "0x1824619E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06028E4A RID: 167498 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6028E4A")]
			[Address(RVA = "0x2461800", Offset = "0x2460400", VA = "0x182461800", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06028E4B RID: 167499 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6028E4B")]
			[Address(RVA = "0x2461980", Offset = "0x2460580", VA = "0x182461980")]
			public Adapter()
			{
			}

			// Token: 0x0403A556 RID: 238934
			[Token(Token = "0x403A556")]
			[FieldOffset(Offset = "0x20")]
			public List<ActMultiV3PrepareMainSmallCharCardModel> charList;

			// Token: 0x0403A557 RID: 238935
			[Token(Token = "0x403A557")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403A558 RID: 238936
			[Token(Token = "0x403A558")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403A559 RID: 238937
			[Token(Token = "0x403A559")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
