using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005323 RID: 21283
	[Token(Token = "0x2005323")]
	public class RoguelikeMenuRelicWindow : RoguelikeMenuWindow<RoguelikeMenuRelicViewModel>
	{
		// Token: 0x0601F65D RID: 128605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F65D")]
		[Address(RVA = "0x1915590", Offset = "0x1914190", VA = "0x181915590")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F65E RID: 128606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F65E")]
		[Address(RVA = "0x1914E40", Offset = "0x1913A40", VA = "0x181914E40", Slot = "9")]
		protected override UISwitchTween GetSwitchTween()
		{
			return null;
		}

		// Token: 0x1700499A RID: 18842
		// (get) Token: 0x0601F65F RID: 128607 RVA: 0x000B1C60 File Offset: 0x000AFE60
		[Token(Token = "0x1700499A")]
		public override RoguelikeMenuType selectType
		{
			[Token(Token = "0x601F65F")]
			[Address(RVA = "0x1915720", Offset = "0x1914320", VA = "0x181915720", Slot = "4")]
			get
			{
				return RoguelikeMenuType.INIT_SQUAD;
			}
		}

		// Token: 0x0601F660 RID: 128608 RVA: 0x000B1C78 File Offset: 0x000AFE78
		[Token(Token = "0x601F660")]
		[Address(RVA = "0x1914F70", Offset = "0x1913B70", VA = "0x181914F70", Slot = "7")]
		public override bool IsSelected(RoguelikeMenuType type)
		{
			return default(bool);
		}

		// Token: 0x0601F661 RID: 128609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F661")]
		[Address(RVA = "0x1915000", Offset = "0x1913C00", VA = "0x181915000", Slot = "8")]
		public override void RenderSelection(RoguelikeMenuType type, bool fastMode)
		{
		}

		// Token: 0x0601F662 RID: 128610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F662")]
		[Address(RVA = "0x19150C0", Offset = "0x1913CC0", VA = "0x1819150C0", Slot = "10")]
		public override void Render(RoguelikeMenuRelicViewModel viewModel)
		{
		}

		// Token: 0x0601F663 RID: 128611 RVA: 0x000B1C90 File Offset: 0x000AFE90
		[Token(Token = "0x601F663")]
		[Address(RVA = "0x19153F0", Offset = "0x1913FF0", VA = "0x1819153F0")]
		private bool _GetLimitStatus(RoguelikeMenuRelicViewModel viewModel)
		{
			return default(bool);
		}

		// Token: 0x0601F664 RID: 128612 RVA: 0x000B1CA8 File Offset: 0x000AFEA8
		[Token(Token = "0x601F664")]
		[Address(RVA = "0x1915500", Offset = "0x1914100", VA = "0x181915500")]
		private int _GetRelicCount(RoguelikeMenuRelicViewModel viewModel)
		{
			return 0;
		}

		// Token: 0x0601F665 RID: 128613 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F665")]
		[Address(RVA = "0x19156B0", Offset = "0x19142B0", VA = "0x1819156B0")]
		public RoguelikeMenuRelicWindow()
		{
		}

		// Token: 0x0601F666 RID: 128614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F666")]
		[Address(RVA = "0x19153C0", Offset = "0x1913FC0", VA = "0x1819153C0")]
		private UISwitchTween <>xLuaBaseProxy_GetSwitchTween()
		{
			return null;
		}

		// Token: 0x0601F667 RID: 128615 RVA: 0x000B1CC0 File Offset: 0x000AFEC0
		[Token(Token = "0x601F667")]
		[Address(RVA = "0x19153D0", Offset = "0x1913FD0", VA = "0x1819153D0")]
		private bool <>xLuaBaseProxy_IsSelected(RoguelikeMenuType P0)
		{
			return default(bool);
		}

		// Token: 0x0601F668 RID: 128616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F668")]
		[Address(RVA = "0x19153E0", Offset = "0x1913FE0", VA = "0x1819153E0")]
		private void <>xLuaBaseProxy_RenderSelection(RoguelikeMenuType P0, bool P1)
		{
		}

		// Token: 0x0402A368 RID: 172904
		[Token(Token = "0x402A368")]
		private const float ANIM_DURATION = 0.16f;

		// Token: 0x0402A369 RID: 172905
		[Token(Token = "0x402A369")]
		private const int ITEM_COUNT_PER_ROW = 3;

		// Token: 0x0402A36A RID: 172906
		[Token(Token = "0x402A36A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _container;

		// Token: 0x0402A36B RID: 172907
		[Token(Token = "0x402A36B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _showTrap;

		// Token: 0x0402A36C RID: 172908
		[Token(Token = "0x402A36C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _showAnim;

		// Token: 0x0402A36D RID: 172909
		[Token(Token = "0x402A36D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RoguelikeMenuRelicWindow.RowLimitType _limitType;

		// Token: 0x0402A36E RID: 172910
		[Token(Token = "0x402A36E")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private int _limitNum;

		// Token: 0x0402A36F RID: 172911
		[Token(Token = "0x402A36F")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeMenuRelicWindow.Adapter m_adapter;

		// Token: 0x0402A370 RID: 172912
		[Token(Token = "0x402A370")]
		[FieldOffset(Offset = "0x58")]
		private bool m_cachedShowStatus;

		// Token: 0x0402A371 RID: 172913
		[Token(Token = "0x402A371")]
		[FieldOffset(Offset = "0x59")]
		private bool m_cachedLimitStatus;

		// Token: 0x0402A372 RID: 172914
		[Token(Token = "0x402A372")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeMenuRelicViewModel m_cachedModel;

		// Token: 0x0402A373 RID: 172915
		[Token(Token = "0x402A373")]
		[FieldOffset(Offset = "0x68")]
		private List<IRoguelikeRelicViewModel> m_wholeRelicViewModels;

		// Token: 0x0402A374 RID: 172916
		[Token(Token = "0x402A374")]
		[FieldOffset(Offset = "0x70")]
		private AnimationSwitchTween m_showSwitchTween;

		// Token: 0x0402A375 RID: 172917
		[Token(Token = "0x402A375")]
		[FieldOffset(Offset = "0x78")]
		private bool m_inited;

		// Token: 0x0402A376 RID: 172918
		[Token(Token = "0x402A376")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A377 RID: 172919
		[Token(Token = "0x402A377")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetSwitchTween;

		// Token: 0x0402A378 RID: 172920
		[Token(Token = "0x402A378")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectType;

		// Token: 0x0402A379 RID: 172921
		[Token(Token = "0x402A379")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsSelected;

		// Token: 0x0402A37A RID: 172922
		[Token(Token = "0x402A37A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderSelection;

		// Token: 0x0402A37B RID: 172923
		[Token(Token = "0x402A37B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402A37C RID: 172924
		[Token(Token = "0x402A37C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetLimitStatus;

		// Token: 0x0402A37D RID: 172925
		[Token(Token = "0x402A37D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetRelicCount;

		// Token: 0x0402A37E RID: 172926
		[Token(Token = "0x402A37E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005324 RID: 21284
		[Token(Token = "0x2005324")]
		private enum RowLimitType
		{
			// Token: 0x0402A380 RID: 172928
			[Token(Token = "0x402A380")]
			NONE,
			// Token: 0x0402A381 RID: 172929
			[Token(Token = "0x402A381")]
			LIMIT_MAX_ROW,
			// Token: 0x0402A382 RID: 172930
			[Token(Token = "0x402A382")]
			LIMIT_MIN_ROW
		}

		// Token: 0x02005325 RID: 21285
		[Token(Token = "0x2005325")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601F669 RID: 128617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F669")]
			[Address(RVA = "0x190AE30", Offset = "0x1909A30", VA = "0x18190AE30")]
			public Adapter(RoguelikeMenuRelicWindow closure)
			{
			}

			// Token: 0x1700499B RID: 18843
			// (get) Token: 0x0601F66A RID: 128618 RVA: 0x000B1CD8 File Offset: 0x000AFED8
			[Token(Token = "0x1700499B")]
			public override int count
			{
				[Token(Token = "0x601F66A")]
				[Address(RVA = "0x190AEB0", Offset = "0x1909AB0", VA = "0x18190AEB0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601F66B RID: 128619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F66B")]
			[Address(RVA = "0x190AC80", Offset = "0x1909880", VA = "0x18190AC80", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402A383 RID: 172931
			[Token(Token = "0x402A383")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeMenuRelicWindow m_closure;

			// Token: 0x0402A384 RID: 172932
			[Token(Token = "0x402A384")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A385 RID: 172933
			[Token(Token = "0x402A385")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402A386 RID: 172934
			[Token(Token = "0x402A386")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
