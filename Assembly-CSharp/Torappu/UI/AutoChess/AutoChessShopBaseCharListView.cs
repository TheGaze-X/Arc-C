using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006356 RID: 25430
	[Token(Token = "0x2006356")]
	public abstract class AutoChessShopBaseCharListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170056A1 RID: 22177
		// (get) Token: 0x06024B11 RID: 150289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056A1")]
		public virtual AutoChessShopLevelCharGroupItemView groupCharChessItemPrefab
		{
			[Token(Token = "0x6024B11")]
			[Address(RVA = "0x1F80E90", Offset = "0x1F7FA90", VA = "0x181F80E90", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170056A2 RID: 22178
		// (get) Token: 0x06024B12 RID: 150290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056A2")]
		public UILayoutDimensionListener contentDimensionListener
		{
			[Token(Token = "0x6024B12")]
			[Address(RVA = "0x1F80E30", Offset = "0x1F7FA30", VA = "0x181F80E30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06024B13 RID: 150291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B13")]
		[Address(RVA = "0x1F80C70", Offset = "0x1F7F870", VA = "0x181F80C70")]
		protected void DoFocusAfterLayout(Action<AutoChessShopBaseCharListView.FocusParams> focusAction, AutoChessShopBaseCharListView.FocusParams focusParams)
		{
		}

		// Token: 0x06024B14 RID: 150292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B14")]
		[Address(RVA = "0x1F80DD0", Offset = "0x1F7F9D0", VA = "0x181F80DD0")]
		protected AutoChessShopBaseCharListView()
		{
		}

		// Token: 0x040333A6 RID: 209830
		[Token(Token = "0x40333A6")]
		private const float MAX_FOCUS_SCROLL_DISTANCE = 1280f;

		// Token: 0x040333A7 RID: 209831
		[Token(Token = "0x40333A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UILayoutDimensionListener _contentDimensionListener;

		// Token: 0x040333A8 RID: 209832
		[Token(Token = "0x40333A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_groupCharChessItemPrefab;

		// Token: 0x040333A9 RID: 209833
		[Token(Token = "0x40333A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_contentDimensionListener;

		// Token: 0x040333AA RID: 209834
		[Token(Token = "0x40333AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoFocusAfterLayout;

		// Token: 0x040333AB RID: 209835
		[Token(Token = "0x40333AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006357 RID: 25431
		[Token(Token = "0x2006357")]
		public struct FocusInput
		{
			// Token: 0x040333AC RID: 209836
			[Token(Token = "0x40333AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string chessId;

			// Token: 0x040333AD RID: 209837
			[Token(Token = "0x40333AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int chessLv;
		}

		// Token: 0x02006358 RID: 25432
		[Token(Token = "0x2006358")]
		public struct FocusParams
		{
			// Token: 0x040333AE RID: 209838
			[Token(Token = "0x40333AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool needFocus;

			// Token: 0x040333AF RID: 209839
			[Token(Token = "0x40333AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool fastModeFocus;

			// Token: 0x040333B0 RID: 209840
			[Token(Token = "0x40333B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool focusByRelativePosition;

			// Token: 0x040333B1 RID: 209841
			[Token(Token = "0x40333B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string focusCharChessId;

			// Token: 0x040333B2 RID: 209842
			[Token(Token = "0x40333B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int level;

			// Token: 0x040333B3 RID: 209843
			[Token(Token = "0x40333B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float columnIndex;

			// Token: 0x040333B4 RID: 209844
			[Token(Token = "0x40333B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action onFocusFinished;

			// Token: 0x040333B5 RID: 209845
			[Token(Token = "0x40333B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly AutoChessShopBaseCharListView.FocusParams DEFAULT_NO_NEED_FOCUS;
		}

		// Token: 0x02006359 RID: 25433
		[Token(Token = "0x2006359")]
		protected class FocusCoreLogic
		{
			// Token: 0x06024B16 RID: 150294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B16")]
			[Address(RVA = "0x1F94B40", Offset = "0x1F93740", VA = "0x181F94B40")]
			public void InitFocusInput(AutoChessShopBaseCharListView.FocusCoreLogic.ViewInput input)
			{
			}

			// Token: 0x06024B17 RID: 150295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B17")]
			[Address(RVA = "0x1F93E30", Offset = "0x1F92A30", VA = "0x181F93E30")]
			public void FocusToCharListChessCard(string chessId, int level, [Optional] Action onFocusFinished)
			{
			}

			// Token: 0x06024B18 RID: 150296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B18")]
			[Address(RVA = "0x1F944F0", Offset = "0x1F930F0", VA = "0x181F944F0")]
			public void FocusToSingleEditCharCard(string chessId, int level, bool fastMode, [Optional] Action onFocusComplete)
			{
			}

			// Token: 0x06024B19 RID: 150297 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B19")]
			[Address(RVA = "0x1F940D0", Offset = "0x1F92CD0", VA = "0x181F940D0")]
			public void FocusToPos(float pos, bool fastMode = false, [Optional] Action onFocusComplete)
			{
			}

			// Token: 0x06024B1A RID: 150298 RVA: 0x000C5388 File Offset: 0x000C3588
			[Token(Token = "0x6024B1A")]
			[Address(RVA = "0x1F94A90", Offset = "0x1F93690", VA = "0x181F94A90")]
			public float GetPositionFromLevelAndColumnIndex(int level, float columnIndex)
			{
				return 0f;
			}

			// Token: 0x06024B1B RID: 150299 RVA: 0x000C53A0 File Offset: 0x000C35A0
			[Token(Token = "0x6024B1B")]
			[Address(RVA = "0x1F94610", Offset = "0x1F93210", VA = "0x181F94610")]
			public int GetLeftMostFocusChessInfo(out float columnIndex)
			{
				return 0;
			}

			// Token: 0x06024B1C RID: 150300 RVA: 0x000C53B8 File Offset: 0x000C35B8
			[Token(Token = "0x6024B1C")]
			[Address(RVA = "0x1F94CE0", Offset = "0x1F938E0", VA = "0x181F94CE0")]
			private bool _IsViewInputValid()
			{
				return default(bool);
			}

			// Token: 0x06024B1D RID: 150301 RVA: 0x000C53D0 File Offset: 0x000C35D0
			[Token(Token = "0x6024B1D")]
			[Address(RVA = "0x1F94CA0", Offset = "0x1F938A0", VA = "0x181F94CA0")]
			private float _GetPositionInsideChild(float columnIndex)
			{
				return 0f;
			}

			// Token: 0x06024B1E RID: 150302 RVA: 0x000C53E8 File Offset: 0x000C35E8
			[Token(Token = "0x6024B1E")]
			[Address(RVA = "0x1F94B70", Offset = "0x1F93770", VA = "0x181F94B70")]
			private float _CalculateVisibleColumnInsideChild(Bounds elementBounds, float viewportMin)
			{
				return 0f;
			}

			// Token: 0x06024B1F RID: 150303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B1F")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FocusCoreLogic()
			{
			}

			// Token: 0x040333B6 RID: 209846
			[Token(Token = "0x40333B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private AutoChessShopBaseCharListView.FocusCoreLogic.ViewInput m_inputInfo;

			// Token: 0x040333B7 RID: 209847
			[Token(Token = "0x40333B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Tween m_focusTween;

			// Token: 0x0200635A RID: 25434
			[Token(Token = "0x200635A")]
			public struct ViewInput
			{
				// Token: 0x040333B8 RID: 209848
				[Token(Token = "0x40333B8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float groupViewHeaderWidth;

				// Token: 0x040333B9 RID: 209849
				[Token(Token = "0x40333B9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float groupViewElementWidth;

				// Token: 0x040333BA RID: 209850
				[Token(Token = "0x40333BA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public float groupViewElementSpacing;

				// Token: 0x040333BB RID: 209851
				[Token(Token = "0x40333BB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public float charCardBoundsMargin;

				// Token: 0x040333BC RID: 209852
				[Token(Token = "0x40333BC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public float focusTweenDuration;

				// Token: 0x040333BD RID: 209853
				[Token(Token = "0x40333BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public ScrollRect scrollView;

				// Token: 0x040333BE RID: 209854
				[Token(Token = "0x40333BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public RectTransform viewport;

				// Token: 0x040333BF RID: 209855
				[Token(Token = "0x40333BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public UIRecycleHorizonLayoutGroup recycleLayoutList;

				// Token: 0x040333C0 RID: 209856
				[Token(Token = "0x40333C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public AutoChessShopCharListRecycleAdapter adapter;
			}
		}

		// Token: 0x0200635C RID: 25436
		[Token(Token = "0x200635C")]
		protected class DoFocusAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x170056A3 RID: 22179
			// (get) Token: 0x06024B22 RID: 150306 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06024B23 RID: 150307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170056A3")]
			public Action<AutoChessShopBaseCharListView.FocusParams> focusAction
			{
				[Token(Token = "0x6024B22")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x6024B23")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170056A4 RID: 22180
			// (get) Token: 0x06024B24 RID: 150308 RVA: 0x000C5400 File Offset: 0x000C3600
			// (set) Token: 0x06024B25 RID: 150309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170056A4")]
			public AutoChessShopBaseCharListView.FocusParams focusParams
			{
				[Token(Token = "0x6024B24")]
				[Address(RVA = "0x120F310", Offset = "0x120DF10", VA = "0x18120F310")]
				[CompilerGenerated]
				private get
				{
					return default(AutoChessShopBaseCharListView.FocusParams);
				}
				[Token(Token = "0x6024B25")]
				[Address(RVA = "0x1F93E10", Offset = "0x1F92A10", VA = "0x181F93E10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x06024B26 RID: 150310 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B26")]
			[Address(RVA = "0x1F93DD0", Offset = "0x1F929D0", VA = "0x181F93DD0", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x06024B27 RID: 150311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B27")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DoFocusAction()
			{
			}
		}
	}
}
