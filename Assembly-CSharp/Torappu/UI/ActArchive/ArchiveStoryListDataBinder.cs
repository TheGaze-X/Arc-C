using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C1E RID: 27678
	[Token(Token = "0x2006C1E")]
	public class ArchiveStoryListDataBinder : DataBinder<StoryProperty>
	{
		// Token: 0x17005D48 RID: 23880
		// (get) Token: 0x0602784C RID: 161868 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602784D RID: 161869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D48")]
		public ArchiveStoryController controller
		{
			[Token(Token = "0x602784C")]
			[Address(RVA = "0x22B58F0", Offset = "0x22B44F0", VA = "0x1822B58F0")]
			private get
			{
				return null;
			}
			[Token(Token = "0x602784D")]
			[Address(RVA = "0x22B5950", Offset = "0x22B4550", VA = "0x1822B5950")]
			set
			{
			}
		}

		// Token: 0x0602784E RID: 161870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602784E")]
		[Address(RVA = "0x22B4C00", Offset = "0x22B3800", VA = "0x1822B4C00", Slot = "7")]
		public override void OnValueChanged(StoryProperty property)
		{
		}

		// Token: 0x0602784F RID: 161871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602784F")]
		[Address(RVA = "0x22B4DB0", Offset = "0x22B39B0", VA = "0x1822B4DB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027850 RID: 161872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027850")]
		[Address(RVA = "0x22B4ED0", Offset = "0x22B3AD0", VA = "0x1822B4ED0")]
		private void _RefreshLeftContent()
		{
		}

		// Token: 0x06027851 RID: 161873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027851")]
		[Address(RVA = "0x22B55A0", Offset = "0x22B41A0", VA = "0x1822B55A0")]
		private void _SetContent(StoryItemModel storyModel, Sprite header, Sprite content)
		{
		}

		// Token: 0x06027852 RID: 161874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027852")]
		[Address(RVA = "0x22B4B20", Offset = "0x22B3720", VA = "0x1822B4B20")]
		public IEnumerator FocusOnSelectedItem(bool fastMode, float duration)
		{
			return null;
		}

		// Token: 0x06027853 RID: 161875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027853")]
		[Address(RVA = "0x22B5800", Offset = "0x22B4400", VA = "0x1822B5800")]
		public ArchiveStoryListDataBinder()
		{
		}

		// Token: 0x04038074 RID: 229492
		[Token(Token = "0x4038074")]
		private const float ANIM_TIME = 0.15f;

		// Token: 0x04038075 RID: 229493
		[Token(Token = "0x4038075")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoFocusScrollView _scrollView;

		// Token: 0x04038076 RID: 229494
		[Token(Token = "0x4038076")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04038077 RID: 229495
		[Token(Token = "0x4038077")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _imgListItemTitleNormal;

		// Token: 0x04038078 RID: 229496
		[Token(Token = "0x4038078")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _leftContainer;

		// Token: 0x04038079 RID: 229497
		[Token(Token = "0x4038079")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _leftCanvas;

		// Token: 0x0403807A RID: 229498
		[Token(Token = "0x403807A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _leftScrollView;

		// Token: 0x0403807B RID: 229499
		[Token(Token = "0x403807B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArchiveStoryListDataBinder.FileItemView _fileItemView;

		// Token: 0x0403807C RID: 229500
		[Token(Token = "0x403807C")]
		[FieldOffset(Offset = "0x58")]
		private bool m_hasInited;

		// Token: 0x0403807D RID: 229501
		[Token(Token = "0x403807D")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedStoryItem;

		// Token: 0x0403807E RID: 229502
		[Token(Token = "0x403807E")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, Sprite> m_cachedSprites;

		// Token: 0x0403807F RID: 229503
		[Token(Token = "0x403807F")]
		[FieldOffset(Offset = "0x70")]
		private ArchiveStoryListDataBinder.ArchiveStoryListAdapter m_listAdapter;

		// Token: 0x04038080 RID: 229504
		[Token(Token = "0x4038080")]
		[FieldOffset(Offset = "0x78")]
		private ArchiveStoryController m_controller;

		// Token: 0x04038081 RID: 229505
		[Token(Token = "0x4038081")]
		[FieldOffset(Offset = "0x80")]
		private ArchiveStoryModel m_cachedModel;

		// Token: 0x04038082 RID: 229506
		[Token(Token = "0x4038082")]
		[FieldOffset(Offset = "0x88")]
		private Tween m_tween;

		// Token: 0x04038083 RID: 229507
		[Token(Token = "0x4038083")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04038084 RID: 229508
		[Token(Token = "0x4038084")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04038085 RID: 229509
		[Token(Token = "0x4038085")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04038086 RID: 229510
		[Token(Token = "0x4038086")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038087 RID: 229511
		[Token(Token = "0x4038087")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshLeftContent;

		// Token: 0x04038088 RID: 229512
		[Token(Token = "0x4038088")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetContent;

		// Token: 0x04038089 RID: 229513
		[Token(Token = "0x4038089")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FocusOnSelectedItem;

		// Token: 0x0403808A RID: 229514
		[Token(Token = "0x403808A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C1F RID: 27679
		[Token(Token = "0x2006C1F")]
		public class ArchiveStoryListAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x17005D49 RID: 23881
			// (get) Token: 0x06027854 RID: 161876 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027855 RID: 161877 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005D49")]
			public ListDict<string, StoryItemModel> dataSet
			{
				[Token(Token = "0x6027854")]
				[Address(RVA = "0x22B49C0", Offset = "0x22B35C0", VA = "0x1822B49C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6027855")]
				[Address(RVA = "0x22B4AA0", Offset = "0x22B36A0", VA = "0x1822B4AA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005D4A RID: 23882
			// (get) Token: 0x06027856 RID: 161878 RVA: 0x000CE9D0 File Offset: 0x000CCBD0
			[Token(Token = "0x17005D4A")]
			public override int count
			{
				[Token(Token = "0x6027856")]
				[Address(RVA = "0x22B48A0", Offset = "0x22B34A0", VA = "0x1822B48A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027857 RID: 161879 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027857")]
			[Address(RVA = "0x22B46E0", Offset = "0x22B32E0", VA = "0x1822B46E0")]
			public ArchiveStoryListAdapter(ArchiveStoryListDataBinder closure)
			{
			}

			// Token: 0x06027858 RID: 161880 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027858")]
			[Address(RVA = "0x22B4160", Offset = "0x22B2D60", VA = "0x1822B4160", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403808B RID: 229515
			[Token(Token = "0x403808B")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveStoryListDataBinder m_closure;

			// Token: 0x0403808D RID: 229517
			[Token(Token = "0x403808D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x0403808E RID: 229518
			[Token(Token = "0x403808E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x0403808F RID: 229519
			[Token(Token = "0x403808F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04038090 RID: 229520
			[Token(Token = "0x4038090")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04038091 RID: 229521
			[Token(Token = "0x4038091")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02006C20 RID: 27680
		[Token(Token = "0x2006C20")]
		[Serializable]
		private class FileItemView
		{
			// Token: 0x06027859 RID: 161881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027859")]
			[Address(RVA = "0x22B9490", Offset = "0x22B8090", VA = "0x1822B9490")]
			public void ApplyData(StoryItemModel model, Sprite header, Sprite content)
			{
			}

			// Token: 0x0602785A RID: 161882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602785A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FileItemView()
			{
			}

			// Token: 0x04038092 RID: 229522
			[Token(Token = "0x4038092")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Text _textTitle;

			// Token: 0x04038093 RID: 229523
			[Token(Token = "0x4038093")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Text _textDate;

			// Token: 0x04038094 RID: 229524
			[Token(Token = "0x4038094")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Text _textContent;

			// Token: 0x04038095 RID: 229525
			[Token(Token = "0x4038095")]
			[FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Image _imageHeader;

			// Token: 0x04038096 RID: 229526
			[Token(Token = "0x4038096")]
			[FieldOffset(Offset = "0x30")]
			[SerializeField]
			private Image _imageContent;

			// Token: 0x04038097 RID: 229527
			[Token(Token = "0x4038097")]
			[FieldOffset(Offset = "0x38")]
			private string m_cachedStoryId;
		}
	}
}
