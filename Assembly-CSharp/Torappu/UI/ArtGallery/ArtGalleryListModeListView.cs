using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x02006614 RID: 26132
	[Token(Token = "0x2006614")]
	public class ArtGalleryListModeListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06025898 RID: 153752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025898")]
		[Address(RVA = "0x2085600", Offset = "0x2084200", VA = "0x182085600")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025899 RID: 153753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025899")]
		[Address(RVA = "0x20853A0", Offset = "0x2083FA0", VA = "0x1820853A0")]
		public void OnRebuild(IArtGalleryListModeGroupSetViewModel groupSetViewModel, ArtGalleryDisplayViewModel.ArtGalleryFocusParam curFocusParam)
		{
		}

		// Token: 0x0602589A RID: 153754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602589A")]
		[Address(RVA = "0x2085880", Offset = "0x2084480", VA = "0x182085880")]
		private void _OnScrollValueChanged(Vector2 input)
		{
		}

		// Token: 0x0602589B RID: 153755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602589B")]
		[Address(RVA = "0x2085B70", Offset = "0x2084770", VA = "0x182085B70")]
		private void _TryRebuild(ArtGalleryListModeListView.PostLayoutRebuildParam rebuildParam)
		{
		}

		// Token: 0x0602589C RID: 153756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602589C")]
		[Address(RVA = "0x2085A10", Offset = "0x2084610", VA = "0x182085A10")]
		private void _TryFocus(ArtGalleryListModeListView.PostLayoutFocusParam focusParam)
		{
		}

		// Token: 0x0602589D RID: 153757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602589D")]
		[Address(RVA = "0x2085CF0", Offset = "0x20848F0", VA = "0x182085CF0")]
		public ArtGalleryListModeListView()
		{
		}

		// Token: 0x04034BB9 RID: 215993
		[Token(Token = "0x4034BB9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollRect _scrollView;

		// Token: 0x04034BBA RID: 215994
		[Token(Token = "0x4034BBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ArtGalleryListModeGridItemView _gridItemViewAsset;

		// Token: 0x04034BBB RID: 215995
		[Token(Token = "0x4034BBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRecycleVerticalGridLayoutGroup _recycleGridLayoutGroup;

		// Token: 0x04034BBC RID: 215996
		[Token(Token = "0x4034BBC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _listStatusToggle;

		// Token: 0x04034BBD RID: 215997
		[Token(Token = "0x4034BBD")]
		[FieldOffset(Offset = "0x38")]
		private UILayoutDimensionListener m_dimensionListener;

		// Token: 0x04034BBE RID: 215998
		[Token(Token = "0x4034BBE")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isBaseInited;

		// Token: 0x04034BBF RID: 215999
		[Token(Token = "0x4034BBF")]
		[FieldOffset(Offset = "0x48")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034BC0 RID: 216000
		[Token(Token = "0x4034BC0")]
		[FieldOffset(Offset = "0x58")]
		private int m_renderSeqNum;

		// Token: 0x04034BC1 RID: 216001
		[Token(Token = "0x4034BC1")]
		[FieldOffset(Offset = "0x60")]
		private ArtGalleryListModeListView.ArtGalleryListModeRecycleAdapter m_adapter;

		// Token: 0x04034BC2 RID: 216002
		[Token(Token = "0x4034BC2")]
		[FieldOffset(Offset = "0x68")]
		private int m_cachedRefreshSeq;

		// Token: 0x04034BC3 RID: 216003
		[Token(Token = "0x4034BC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04034BC4 RID: 216004
		[Token(Token = "0x4034BC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRebuild;

		// Token: 0x04034BC5 RID: 216005
		[Token(Token = "0x4034BC5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnScrollValueChanged;

		// Token: 0x04034BC6 RID: 216006
		[Token(Token = "0x4034BC6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryRebuild;

		// Token: 0x04034BC7 RID: 216007
		[Token(Token = "0x4034BC7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryFocus;

		// Token: 0x04034BC8 RID: 216008
		[Token(Token = "0x4034BC8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006615 RID: 26133
		[Token(Token = "0x2006615")]
		private struct PostLayoutParam
		{
			// Token: 0x04034BC9 RID: 216009
			[Token(Token = "0x4034BC9")]
			[FieldOffset(Offset = "0x0")]
			public int seqNum;

			// Token: 0x04034BCA RID: 216010
			[Token(Token = "0x4034BCA")]
			[FieldOffset(Offset = "0x4")]
			public bool needRebuild;

			// Token: 0x04034BCB RID: 216011
			[Token(Token = "0x4034BCB")]
			[FieldOffset(Offset = "0x8")]
			public ArtGalleryListModeListView.PostLayoutRebuildParam rebuildParam;

			// Token: 0x04034BCC RID: 216012
			[Token(Token = "0x4034BCC")]
			[FieldOffset(Offset = "0x10")]
			public bool needFocus;

			// Token: 0x04034BCD RID: 216013
			[Token(Token = "0x4034BCD")]
			[FieldOffset(Offset = "0x14")]
			public ArtGalleryListModeListView.PostLayoutFocusParam focusParam;
		}

		// Token: 0x02006616 RID: 26134
		[Token(Token = "0x2006616")]
		private struct PostLayoutRebuildParam
		{
			// Token: 0x04034BCE RID: 216014
			[Token(Token = "0x4034BCE")]
			[FieldOffset(Offset = "0x0")]
			public IArtGalleryListModeGroupSetViewModel groupSetViewModel;
		}

		// Token: 0x02006617 RID: 26135
		[Token(Token = "0x2006617")]
		private struct PostLayoutFocusParam
		{
			// Token: 0x04034BCF RID: 216015
			[Token(Token = "0x4034BCF")]
			[FieldOffset(Offset = "0x0")]
			public float focusNormalizedPos;
		}

		// Token: 0x02006618 RID: 26136
		[Token(Token = "0x2006618")]
		private class PostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0602589E RID: 153758 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602589E")]
			[Address(RVA = "0x2087C70", Offset = "0x2086870", VA = "0x182087C70")]
			public PostLayoutAction(ArtGalleryListModeListView closure, ArtGalleryListModeListView.PostLayoutParam postLayoutParam)
			{
			}

			// Token: 0x0602589F RID: 153759 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602589F")]
			[Address(RVA = "0x2087930", Offset = "0x2086530", VA = "0x182087930", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x04034BD0 RID: 216016
			[Token(Token = "0x4034BD0")]
			[FieldOffset(Offset = "0x10")]
			private ArtGalleryListModeListView m_closure;

			// Token: 0x04034BD1 RID: 216017
			[Token(Token = "0x4034BD1")]
			[FieldOffset(Offset = "0x18")]
			private ArtGalleryListModeListView.PostLayoutParam m_postLayoutParam;
		}

		// Token: 0x02006619 RID: 26137
		[Token(Token = "0x2006619")]
		private class ArtGalleryListModeRecycleAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x060258A0 RID: 153760 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60258A0")]
			[Address(RVA = "0x2086C00", Offset = "0x2085800", VA = "0x182086C00")]
			public ArtGalleryListModeRecycleAdapter(ArtGalleryListModeListView closure)
			{
			}

			// Token: 0x060258A1 RID: 153761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60258A1")]
			[Address(RVA = "0x2086320", Offset = "0x2084F20", VA = "0x182086320", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x060258A2 RID: 153762 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60258A2")]
			[Address(RVA = "0x2086450", Offset = "0x2085050", VA = "0x182086450")]
			public void RebuildList(IArtGalleryListModeGroupSetViewModel groupSetViewModel)
			{
			}

			// Token: 0x060258A3 RID: 153763 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60258A3")]
			[Address(RVA = "0x2086A10", Offset = "0x2085610", VA = "0x182086A10")]
			public void RefreshView()
			{
			}

			// Token: 0x04034BD2 RID: 216018
			[Token(Token = "0x4034BD2")]
			[FieldOffset(Offset = "0x18")]
			private ArtGalleryListModeListView m_closure;

			// Token: 0x04034BD3 RID: 216019
			[Token(Token = "0x4034BD3")]
			[FieldOffset(Offset = "0x20")]
			private List<ArtGalleryListModeListView.ArtGalleryListModeRecycleAdapter.ArtGalleryGridItemVirtualView> m_views;

			// Token: 0x04034BD4 RID: 216020
			[Token(Token = "0x4034BD4")]
			[FieldOffset(Offset = "0x28")]
			private Queue<ArtGalleryListModeListView.ArtGalleryListModeRecycleAdapter.ArtGalleryGridItemVirtualView> m_virtualViewPool;

			// Token: 0x04034BD5 RID: 216021
			[Token(Token = "0x4034BD5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04034BD6 RID: 216022
			[Token(Token = "0x4034BD6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x04034BD7 RID: 216023
			[Token(Token = "0x4034BD7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RebuildList;

			// Token: 0x04034BD8 RID: 216024
			[Token(Token = "0x4034BD8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RefreshView;

			// Token: 0x0200661A RID: 26138
			[Token(Token = "0x200661A")]
			private class ArtGalleryGridItemVirtualView : UIRecycleLayoutAdapter.VirtualView<ArtGalleryListModeGridItemView>, UIRecycleGridLayoutGroup.IGridVirtualView, UIRecycleLayoutAdapter.IVirtualView, IHotfixable, UIRecycleLayoutAdapter.ICustomSpacing
			{
				// Token: 0x060258A4 RID: 153764 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60258A4")]
				[Address(RVA = "0x2082800", Offset = "0x2081400", VA = "0x182082800")]
				public void InitVirtualView(ArtGalleryListModeGridItemView asset, ArtGalleryDisplayGridVirtualParam param)
				{
				}

				// Token: 0x060258A5 RID: 153765 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60258A5")]
				[Address(RVA = "0x2082980", Offset = "0x2081580", VA = "0x182082980")]
				public void RefreshView()
				{
				}

				// Token: 0x060258A6 RID: 153766 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60258A6")]
				[Address(RVA = "0x20828C0", Offset = "0x20814C0", VA = "0x1820828C0", Slot = "10")]
				protected override void OnViewAttached()
				{
				}

				// Token: 0x060258A7 RID: 153767 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60258A7")]
				[Address(RVA = "0x2082920", Offset = "0x2081520", VA = "0x182082920", Slot = "11")]
				protected override void OnViewDetached()
				{
				}

				// Token: 0x060258A8 RID: 153768 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x60258A8")]
				[Address(RVA = "0x2082700", Offset = "0x2081300", VA = "0x182082700", Slot = "12")]
				public override GameObject GetPrefab()
				{
					return null;
				}

				// Token: 0x060258A9 RID: 153769 RVA: 0x000C8238 File Offset: 0x000C6438
				[Token(Token = "0x60258A9")]
				[Address(RVA = "0x2082770", Offset = "0x2081370", VA = "0x182082770", Slot = "13")]
				public override float GetPreferSize()
				{
					return 0f;
				}

				// Token: 0x060258AA RID: 153770 RVA: 0x000C8250 File Offset: 0x000C6450
				[Token(Token = "0x60258AA")]
				[Address(RVA = "0x2082670", Offset = "0x2081270", VA = "0x182082670", Slot = "14")]
				public float GetPerpendicularPreferSize()
				{
					return 0f;
				}

				// Token: 0x060258AB RID: 153771 RVA: 0x000C8268 File Offset: 0x000C6468
				[Token(Token = "0x60258AB")]
				[Address(RVA = "0x20824D0", Offset = "0x20810D0", VA = "0x1820824D0", Slot = "15")]
				public bool ForceLineBreak()
				{
					return default(bool);
				}

				// Token: 0x060258AC RID: 153772 RVA: 0x000C8280 File Offset: 0x000C6480
				[Token(Token = "0x60258AC")]
				[Address(RVA = "0x2082540", Offset = "0x2081140", VA = "0x182082540", Slot = "16")]
				public float GetCustomSpacing()
				{
					return 0f;
				}

				// Token: 0x060258AD RID: 153773 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60258AD")]
				[Address(RVA = "0x2082A70", Offset = "0x2081670", VA = "0x182082A70")]
				public ArtGalleryGridItemVirtualView()
				{
				}

				// Token: 0x04034BD9 RID: 216025
				[Token(Token = "0x4034BD9")]
				[FieldOffset(Offset = "0x20")]
				private ArtGalleryListModeGridItemView m_asset;

				// Token: 0x04034BDA RID: 216026
				[Token(Token = "0x4034BDA")]
				[FieldOffset(Offset = "0x28")]
				private ArtGalleryDisplayGridVirtualParam m_itemParam;

				// Token: 0x04034BDB RID: 216027
				[Token(Token = "0x4034BDB")]
				[FieldOffset(Offset = "0x0")]
				private static DelegateBridge __Hotfix0_InitVirtualView;

				// Token: 0x04034BDC RID: 216028
				[Token(Token = "0x4034BDC")]
				[FieldOffset(Offset = "0x8")]
				private static DelegateBridge __Hotfix0_RefreshView;

				// Token: 0x04034BDD RID: 216029
				[Token(Token = "0x4034BDD")]
				[FieldOffset(Offset = "0x10")]
				private static DelegateBridge __Hotfix0_OnViewAttached;

				// Token: 0x04034BDE RID: 216030
				[Token(Token = "0x4034BDE")]
				[FieldOffset(Offset = "0x18")]
				private static DelegateBridge __Hotfix0_OnViewDetached;

				// Token: 0x04034BDF RID: 216031
				[Token(Token = "0x4034BDF")]
				[FieldOffset(Offset = "0x20")]
				private static DelegateBridge __Hotfix0_GetPrefab;

				// Token: 0x04034BE0 RID: 216032
				[Token(Token = "0x4034BE0")]
				[FieldOffset(Offset = "0x28")]
				private static DelegateBridge __Hotfix0_GetPreferSize;

				// Token: 0x04034BE1 RID: 216033
				[Token(Token = "0x4034BE1")]
				[FieldOffset(Offset = "0x30")]
				private static DelegateBridge __Hotfix0_GetPerpendicularPreferSize;

				// Token: 0x04034BE2 RID: 216034
				[Token(Token = "0x4034BE2")]
				[FieldOffset(Offset = "0x38")]
				private static DelegateBridge __Hotfix0_ForceLineBreak;

				// Token: 0x04034BE3 RID: 216035
				[Token(Token = "0x4034BE3")]
				[FieldOffset(Offset = "0x40")]
				private static DelegateBridge __Hotfix0_GetCustomSpacing;

				// Token: 0x04034BE4 RID: 216036
				[Token(Token = "0x4034BE4")]
				[FieldOffset(Offset = "0x48")]
				private static DelegateBridge _c__Hotfix0_ctor;
			}
		}
	}
}
