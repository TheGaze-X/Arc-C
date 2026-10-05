using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F5A RID: 28506
	[Token(Token = "0x2006F5A")]
	public class ActMultiV3AlbumView : ActMultiV3TabContentAbstractView
	{
		// Token: 0x060287B3 RID: 165811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287B3")]
		[Address(RVA = "0x23BF4D0", Offset = "0x23BE0D0", VA = "0x1823BF4D0", Slot = "4")]
		public override void Render(ActMultiV3ManualViewModel viewModel)
		{
		}

		// Token: 0x060287B4 RID: 165812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287B4")]
		[Address(RVA = "0x23BF3F0", Offset = "0x23BDFF0", VA = "0x1823BF3F0")]
		public void OnClaimAlbum()
		{
		}

		// Token: 0x060287B5 RID: 165813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287B5")]
		[Address(RVA = "0x23BF820", Offset = "0x23BE420", VA = "0x1823BF820")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060287B6 RID: 165814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287B6")]
		[Address(RVA = "0x23BF8D0", Offset = "0x23BE4D0", VA = "0x1823BF8D0")]
		public ActMultiV3AlbumView()
		{
		}

		// Token: 0x0403996C RID: 235884
		[Token(Token = "0x403996C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _weekTabContent;

		// Token: 0x0403996D RID: 235885
		[Token(Token = "0x403996D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Photo Board")]
		private SimpleLayoutContent _photoContent;

		// Token: 0x0403996E RID: 235886
		[Token(Token = "0x403996E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Photo Board")]
		private Text _collectPhotoCnt;

		// Token: 0x0403996F RID: 235887
		[Token(Token = "0x403996F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Photo Board")]
		private Text _totalPhotoCnt;

		// Token: 0x04039970 RID: 235888
		[Token(Token = "0x4039970")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Reward")]
		private SimpleLayoutContent _rewardContent;

		// Token: 0x04039971 RID: 235889
		[Token(Token = "0x4039971")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _cantClaimGo;

		// Token: 0x04039972 RID: 235890
		[Token(Token = "0x4039972")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _canClaimGo;

		// Token: 0x04039973 RID: 235891
		[Token(Token = "0x4039973")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Reward")]
		private GameObject _confirmedGo;

		// Token: 0x04039974 RID: 235892
		[Token(Token = "0x4039974")]
		[FieldOffset(Offset = "0x58")]
		private bool m_inited;

		// Token: 0x04039975 RID: 235893
		[Token(Token = "0x4039975")]
		[FieldOffset(Offset = "0x5C")]
		private int m_cachedInitSeqNum;

		// Token: 0x04039976 RID: 235894
		[Token(Token = "0x4039976")]
		[FieldOffset(Offset = "0x60")]
		private int m_cachedRenderSeqNum;

		// Token: 0x04039977 RID: 235895
		[Token(Token = "0x4039977")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedWeekRewardId;

		// Token: 0x04039978 RID: 235896
		[Token(Token = "0x4039978")]
		[FieldOffset(Offset = "0x70")]
		private ActMultiV3AlbumView.WeekTabAdapter m_weekTabAdapter;

		// Token: 0x04039979 RID: 235897
		[Token(Token = "0x4039979")]
		[FieldOffset(Offset = "0x78")]
		private ActMultiV3AlbumView.PhotoAdapter m_photoAdapter;

		// Token: 0x0403997A RID: 235898
		[Token(Token = "0x403997A")]
		[FieldOffset(Offset = "0x80")]
		private ActMultiV3AlbumView.PhotoRewardAdapter m_photoRewardAdapter;

		// Token: 0x0403997B RID: 235899
		[Token(Token = "0x403997B")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403997C RID: 235900
		[Token(Token = "0x403997C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403997D RID: 235901
		[Token(Token = "0x403997D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClaimAlbum;

		// Token: 0x0403997E RID: 235902
		[Token(Token = "0x403997E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403997F RID: 235903
		[Token(Token = "0x403997F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F5B RID: 28507
		[Token(Token = "0x2006F5B")]
		private class WeekTabAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005F71 RID: 24433
			// (get) Token: 0x060287B7 RID: 165815 RVA: 0x000D1DF0 File Offset: 0x000CFFF0
			[Token(Token = "0x17005F71")]
			public override int count
			{
				[Token(Token = "0x60287B7")]
				[Address(RVA = "0x23D3CC0", Offset = "0x23D28C0", VA = "0x1823D3CC0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060287B8 RID: 165816 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60287B8")]
			[Address(RVA = "0x23D3AB0", Offset = "0x23D26B0", VA = "0x1823D3AB0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060287B9 RID: 165817 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60287B9")]
			[Address(RVA = "0x23D3C60", Offset = "0x23D2860", VA = "0x1823D3C60")]
			public WeekTabAdapter()
			{
			}

			// Token: 0x04039980 RID: 235904
			[Token(Token = "0x4039980")]
			[FieldOffset(Offset = "0x20")]
			public List<ActMultiV3WeekAlbumViewModel> dataSource;

			// Token: 0x04039981 RID: 235905
			[Token(Token = "0x4039981")]
			[FieldOffset(Offset = "0x28")]
			public bool fastMode;

			// Token: 0x04039982 RID: 235906
			[Token(Token = "0x4039982")]
			[FieldOffset(Offset = "0x2C")]
			public int selectedIdx;

			// Token: 0x04039983 RID: 235907
			[Token(Token = "0x4039983")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039984 RID: 235908
			[Token(Token = "0x4039984")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04039985 RID: 235909
			[Token(Token = "0x4039985")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006F5C RID: 28508
		[Token(Token = "0x2006F5C")]
		private class PhotoAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005F72 RID: 24434
			// (get) Token: 0x060287BA RID: 165818 RVA: 0x000D1E08 File Offset: 0x000D0008
			[Token(Token = "0x17005F72")]
			public override int count
			{
				[Token(Token = "0x60287BA")]
				[Address(RVA = "0x23D2520", Offset = "0x23D1120", VA = "0x1823D2520", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060287BB RID: 165819 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60287BB")]
			[Address(RVA = "0x23D2320", Offset = "0x23D0F20", VA = "0x1823D2320", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060287BC RID: 165820 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60287BC")]
			[Address(RVA = "0x23D24C0", Offset = "0x23D10C0", VA = "0x1823D24C0")]
			public PhotoAdapter()
			{
			}

			// Token: 0x04039986 RID: 235910
			[Token(Token = "0x4039986")]
			[FieldOffset(Offset = "0x20")]
			public List<ActMultiV3PhotoViewModel> dataSource;

			// Token: 0x04039987 RID: 235911
			[Token(Token = "0x4039987")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039988 RID: 235912
			[Token(Token = "0x4039988")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04039989 RID: 235913
			[Token(Token = "0x4039989")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006F5D RID: 28509
		[Token(Token = "0x2006F5D")]
		private class PhotoRewardAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005F73 RID: 24435
			// (get) Token: 0x060287BD RID: 165821 RVA: 0x000D1E20 File Offset: 0x000D0020
			[Token(Token = "0x17005F73")]
			public override int count
			{
				[Token(Token = "0x60287BD")]
				[Address(RVA = "0x23D2920", Offset = "0x23D1520", VA = "0x1823D2920", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060287BE RID: 165822 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60287BE")]
			[Address(RVA = "0x23D2590", Offset = "0x23D1190", VA = "0x1823D2590")]
			public void RefreshStatus(bool hasRecieved)
			{
			}

			// Token: 0x060287BF RID: 165823 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60287BF")]
			[Address(RVA = "0x23D2600", Offset = "0x23D1200", VA = "0x1823D2600", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060287C0 RID: 165824 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60287C0")]
			[Address(RVA = "0x23D28C0", Offset = "0x23D14C0", VA = "0x1823D28C0")]
			public PhotoRewardAdapter()
			{
			}

			// Token: 0x0403998A RID: 235914
			[Token(Token = "0x403998A")]
			[FieldOffset(Offset = "0x20")]
			public List<ItemBundle> dataSource;

			// Token: 0x0403998B RID: 235915
			[Token(Token = "0x403998B")]
			[FieldOffset(Offset = "0x28")]
			private bool m_hasRecieved;

			// Token: 0x0403998C RID: 235916
			[Token(Token = "0x403998C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403998D RID: 235917
			[Token(Token = "0x403998D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RefreshStatus;

			// Token: 0x0403998E RID: 235918
			[Token(Token = "0x403998E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x0403998F RID: 235919
			[Token(Token = "0x403998F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
