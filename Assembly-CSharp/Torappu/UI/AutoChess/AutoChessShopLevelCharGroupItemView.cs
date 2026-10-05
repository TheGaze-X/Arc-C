using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006365 RID: 25445
	[Token(Token = "0x2006365")]
	public class AutoChessShopLevelCharGroupItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170056AC RID: 22188
		// (get) Token: 0x06024B60 RID: 150368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170056AC")]
		public GridLayoutGroup gridLayout
		{
			[Token(Token = "0x6024B60")]
			[Address(RVA = "0x1F87590", Offset = "0x1F86190", VA = "0x181F87590")]
			get
			{
				return null;
			}
		}

		// Token: 0x170056AD RID: 22189
		// (get) Token: 0x06024B61 RID: 150369 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06024B62 RID: 150370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170056AD")]
		private IDragHandler parentScrollHandler
		{
			[Token(Token = "0x6024B61")]
			[Address(RVA = "0x1F875F0", Offset = "0x1F861F0", VA = "0x181F875F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6024B62")]
			[Address(RVA = "0x1F87650", Offset = "0x1F86250", VA = "0x181F87650")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06024B63 RID: 150371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B63")]
		[Address(RVA = "0x1F86410", Offset = "0x1F85010", VA = "0x181F86410")]
		public void Render(AutoChessShopCharListRecycleAdapter.CharGroupViewParams viewParams)
		{
		}

		// Token: 0x06024B64 RID: 150372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B64")]
		[Address(RVA = "0x1F86750", Offset = "0x1F85350", VA = "0x181F86750")]
		public void TryRefreshCharCardViewsInfos(AutoChessShopLevelCharGroupItemViewModel groupItemViewModel, int viewIndex)
		{
		}

		// Token: 0x06024B65 RID: 150373 RVA: 0x000C54C0 File Offset: 0x000C36C0
		[Token(Token = "0x6024B65")]
		[Address(RVA = "0x1F863B0", Offset = "0x1F84FB0", VA = "0x181F863B0")]
		public int GetViewIndex()
		{
			return 0;
		}

		// Token: 0x06024B66 RID: 150374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B66")]
		[Address(RVA = "0x1F861D0", Offset = "0x1F84DD0", VA = "0x181F861D0")]
		public AutoChessShopLevelCharItemCardView GetLevelCharItemCardView(int position)
		{
			return null;
		}

		// Token: 0x06024B67 RID: 150375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B67")]
		[Address(RVA = "0x1F862B0", Offset = "0x1F84EB0", VA = "0x181F862B0")]
		public GameObject GetLevelLastIndexCharItemCardView()
		{
			return null;
		}

		// Token: 0x06024B68 RID: 150376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B68")]
		[Address(RVA = "0x1F86DE0", Offset = "0x1F859E0", VA = "0x181F86DE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06024B69 RID: 150377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024B69")]
		[Address(RVA = "0x1F86C60", Offset = "0x1F85860", VA = "0x181F86C60")]
		private List<AutoChessShopLevelCharItemCardViewModel> _GenShowList(List<AutoChessShopLevelCharItemCardViewModel> itemCardViewModelList)
		{
			return null;
		}

		// Token: 0x06024B6A RID: 150378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B6A")]
		[Address(RVA = "0x1F86F60", Offset = "0x1F85B60", VA = "0x181F86F60")]
		private void _RefreshAdapter(List<AutoChessShopLevelCharItemCardViewModel> itemCardViewModelList)
		{
		}

		// Token: 0x06024B6B RID: 150379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B6B")]
		[Address(RVA = "0x1F870E0", Offset = "0x1F85CE0", VA = "0x181F870E0")]
		private void _RefreshCacheDict(List<AutoChessShopLevelCharItemCardViewModel> itemCardViewModelList)
		{
		}

		// Token: 0x06024B6C RID: 150380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024B6C")]
		[Address(RVA = "0x1F874D0", Offset = "0x1F860D0", VA = "0x181F874D0")]
		public AutoChessShopLevelCharGroupItemView()
		{
		}

		// Token: 0x04033414 RID: 209940
		[Token(Token = "0x4033414")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rectLevelTagViewContainer;

		// Token: 0x04033415 RID: 209941
		[Token(Token = "0x4033415")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoChessShopLevelTagView _levelTagViewPrefab;

		// Token: 0x04033416 RID: 209942
		[Token(Token = "0x4033416")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _charList;

		// Token: 0x04033417 RID: 209943
		[Token(Token = "0x4033417")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GridLayoutGroup _gridLayout;

		// Token: 0x04033419 RID: 209945
		[Token(Token = "0x4033419")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0403341A RID: 209946
		[Token(Token = "0x403341A")]
		[FieldOffset(Offset = "0x44")]
		private int m_cachedIndex;

		// Token: 0x0403341B RID: 209947
		[Token(Token = "0x403341B")]
		[FieldOffset(Offset = "0x48")]
		private AutoChessShopLevelTagView m_levelTagView;

		// Token: 0x0403341C RID: 209948
		[Token(Token = "0x403341C")]
		[FieldOffset(Offset = "0x50")]
		private AutoChessShopLevelCharGroupItemView.CharListAdapter m_adapter;

		// Token: 0x0403341D RID: 209949
		[Token(Token = "0x403341D")]
		[FieldOffset(Offset = "0x58")]
		private ListDict<string, AutoChessShopLevelCharGroupItemView.ChessCacheInfo> m_cachedDict;

		// Token: 0x0403341E RID: 209950
		[Token(Token = "0x403341E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_gridLayout;

		// Token: 0x0403341F RID: 209951
		[Token(Token = "0x403341F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_parentScrollHandler;

		// Token: 0x04033420 RID: 209952
		[Token(Token = "0x4033420")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_parentScrollHandler;

		// Token: 0x04033421 RID: 209953
		[Token(Token = "0x4033421")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04033422 RID: 209954
		[Token(Token = "0x4033422")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TryRefreshCharCardViewsInfos;

		// Token: 0x04033423 RID: 209955
		[Token(Token = "0x4033423")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetViewIndex;

		// Token: 0x04033424 RID: 209956
		[Token(Token = "0x4033424")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetLevelCharItemCardView;

		// Token: 0x04033425 RID: 209957
		[Token(Token = "0x4033425")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetLevelLastIndexCharItemCardView;

		// Token: 0x04033426 RID: 209958
		[Token(Token = "0x4033426")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04033427 RID: 209959
		[Token(Token = "0x4033427")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GenShowList;

		// Token: 0x04033428 RID: 209960
		[Token(Token = "0x4033428")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshAdapter;

		// Token: 0x04033429 RID: 209961
		[Token(Token = "0x4033429")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__RefreshCacheDict;

		// Token: 0x0403342A RID: 209962
		[Token(Token = "0x403342A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006366 RID: 25446
		[Token(Token = "0x2006366")]
		private class CharListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06024B6D RID: 150381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024B6D")]
			[Address(RVA = "0x1F93BA0", Offset = "0x1F927A0", VA = "0x181F93BA0")]
			public CharListAdapter(AutoChessShopLevelCharGroupItemView closure)
			{
			}

			// Token: 0x170056AE RID: 22190
			// (get) Token: 0x06024B6E RID: 150382 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06024B6F RID: 150383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170056AE")]
			public List<AutoChessShopLevelCharItemCardViewModel> viewModelList
			{
				[Token(Token = "0x6024B6E")]
				[Address(RVA = "0x1F93CF0", Offset = "0x1F928F0", VA = "0x181F93CF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6024B6F")]
				[Address(RVA = "0x1F93D50", Offset = "0x1F92950", VA = "0x181F93D50")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170056AF RID: 22191
			// (get) Token: 0x06024B70 RID: 150384 RVA: 0x000C54D8 File Offset: 0x000C36D8
			[Token(Token = "0x170056AF")]
			public override int count
			{
				[Token(Token = "0x6024B70")]
				[Address(RVA = "0x1F93C20", Offset = "0x1F92820", VA = "0x181F93C20", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06024B71 RID: 150385 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6024B71")]
			[Address(RVA = "0x1F93930", Offset = "0x1F92530", VA = "0x181F93930", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403342B RID: 209963
			[Token(Token = "0x403342B")]
			[FieldOffset(Offset = "0x20")]
			private AutoChessShopLevelCharGroupItemView m_closure;

			// Token: 0x0403342D RID: 209965
			[Token(Token = "0x403342D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403342E RID: 209966
			[Token(Token = "0x403342E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_viewModelList;

			// Token: 0x0403342F RID: 209967
			[Token(Token = "0x403342F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_set_viewModelList;

			// Token: 0x04033430 RID: 209968
			[Token(Token = "0x4033430")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04033431 RID: 209969
			[Token(Token = "0x4033431")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006367 RID: 25447
		[Token(Token = "0x2006367")]
		private struct ChessCacheInfo
		{
			// Token: 0x04033432 RID: 209970
			[Token(Token = "0x4033432")]
			[FieldOffset(Offset = "0x0")]
			public AutoChessShopLevelCharItemType itemType;

			// Token: 0x04033433 RID: 209971
			[Token(Token = "0x4033433")]
			[FieldOffset(Offset = "0x4")]
			public AutoChessShopQuickEditType quickEditType;

			// Token: 0x04033434 RID: 209972
			[Token(Token = "0x4033434")]
			[FieldOffset(Offset = "0x8")]
			public CharQuery charQuery;

			// Token: 0x04033435 RID: 209973
			[Token(Token = "0x4033435")]
			[FieldOffset(Offset = "0x20")]
			public string skillId;

			// Token: 0x04033436 RID: 209974
			[Token(Token = "0x4033436")]
			[FieldOffset(Offset = "0x28")]
			public string equipId;

			// Token: 0x04033437 RID: 209975
			[Token(Token = "0x4033437")]
			[FieldOffset(Offset = "0x30")]
			public bool isSelect;

			// Token: 0x04033438 RID: 209976
			[Token(Token = "0x4033438")]
			[FieldOffset(Offset = "0x31")]
			public bool isNew;
		}
	}
}
