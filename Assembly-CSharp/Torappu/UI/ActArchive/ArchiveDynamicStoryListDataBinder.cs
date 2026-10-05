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
	// Token: 0x02006C18 RID: 27672
	[Token(Token = "0x2006C18")]
	public class ArchiveDynamicStoryListDataBinder : DataBinder<StoryProperty>
	{
		// Token: 0x17005D41 RID: 23873
		// (get) Token: 0x06027828 RID: 161832 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027829 RID: 161833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D41")]
		public ArchiveDynamicStoryController controller
		{
			[Token(Token = "0x6027828")]
			[Address(RVA = "0x22A8BA0", Offset = "0x22A77A0", VA = "0x1822A8BA0")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6027829")]
			[Address(RVA = "0x22A8C00", Offset = "0x22A7800", VA = "0x1822A8C00")]
			set
			{
			}
		}

		// Token: 0x0602782A RID: 161834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602782A")]
		[Address(RVA = "0x22A7F80", Offset = "0x22A6B80", VA = "0x1822A7F80", Slot = "7")]
		public override void OnValueChanged(StoryProperty property)
		{
		}

		// Token: 0x0602782B RID: 161835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602782B")]
		[Address(RVA = "0x22A8130", Offset = "0x22A6D30", VA = "0x1822A8130")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602782C RID: 161836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602782C")]
		[Address(RVA = "0x22A8250", Offset = "0x22A6E50", VA = "0x1822A8250")]
		private void _RefreshLeftContent()
		{
		}

		// Token: 0x0602782D RID: 161837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602782D")]
		[Address(RVA = "0x22A8950", Offset = "0x22A7550", VA = "0x1822A8950")]
		private void _SetContent(StoryItemModel storyModel, Sprite header, Sprite content)
		{
		}

		// Token: 0x0602782E RID: 161838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602782E")]
		[Address(RVA = "0x22A7EA0", Offset = "0x22A6AA0", VA = "0x1822A7EA0")]
		public IEnumerator FocusOnSelectedItem(bool fastMode, float duration)
		{
			return null;
		}

		// Token: 0x0602782F RID: 161839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602782F")]
		[Address(RVA = "0x22A8AA0", Offset = "0x22A76A0", VA = "0x1822A8AA0")]
		public ArchiveDynamicStoryListDataBinder()
		{
		}

		// Token: 0x0403803E RID: 229438
		[Token(Token = "0x403803E")]
		private const float ANIM_TIME = 0.15f;

		// Token: 0x0403803F RID: 229439
		[Token(Token = "0x403803F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoFocusScrollView _scrollView;

		// Token: 0x04038040 RID: 229440
		[Token(Token = "0x4038040")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _viewContainer;

		// Token: 0x04038041 RID: 229441
		[Token(Token = "0x4038041")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Sprite _imgListItemTitleNormal;

		// Token: 0x04038042 RID: 229442
		[Token(Token = "0x4038042")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _leftContainer;

		// Token: 0x04038043 RID: 229443
		[Token(Token = "0x4038043")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _leftCanvas;

		// Token: 0x04038044 RID: 229444
		[Token(Token = "0x4038044")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _leftScrollView;

		// Token: 0x04038045 RID: 229445
		[Token(Token = "0x4038045")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArchiveDynamicStoryContentBaseView _contentView;

		// Token: 0x04038046 RID: 229446
		[Token(Token = "0x4038046")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _selectTweenFromPos;

		// Token: 0x04038047 RID: 229447
		[Token(Token = "0x4038047")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _selectTweenToPos;

		// Token: 0x04038048 RID: 229448
		[Token(Token = "0x4038048")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x04038049 RID: 229449
		[Token(Token = "0x4038049")]
		[FieldOffset(Offset = "0x68")]
		private string m_cachedStoryItem;

		// Token: 0x0403804A RID: 229450
		[Token(Token = "0x403804A")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, Sprite> m_cachedSprites;

		// Token: 0x0403804B RID: 229451
		[Token(Token = "0x403804B")]
		[FieldOffset(Offset = "0x78")]
		private ArchiveDynamicStoryListDataBinder.ArchiveStoryListAdapter m_listAdapter;

		// Token: 0x0403804C RID: 229452
		[Token(Token = "0x403804C")]
		[FieldOffset(Offset = "0x80")]
		private ArchiveDynamicStoryController m_controller;

		// Token: 0x0403804D RID: 229453
		[Token(Token = "0x403804D")]
		[FieldOffset(Offset = "0x88")]
		private ArchiveStoryModel m_cachedModel;

		// Token: 0x0403804E RID: 229454
		[Token(Token = "0x403804E")]
		[FieldOffset(Offset = "0x90")]
		private Tween m_tween;

		// Token: 0x0403804F RID: 229455
		[Token(Token = "0x403804F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04038050 RID: 229456
		[Token(Token = "0x4038050")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04038051 RID: 229457
		[Token(Token = "0x4038051")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04038052 RID: 229458
		[Token(Token = "0x4038052")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04038053 RID: 229459
		[Token(Token = "0x4038053")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshLeftContent;

		// Token: 0x04038054 RID: 229460
		[Token(Token = "0x4038054")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetContent;

		// Token: 0x04038055 RID: 229461
		[Token(Token = "0x4038055")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_FocusOnSelectedItem;

		// Token: 0x04038056 RID: 229462
		[Token(Token = "0x4038056")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006C19 RID: 27673
		[Token(Token = "0x2006C19")]
		public class ArchiveStoryListAdapter : SimpleLayoutAdapter, IHotfixable
		{
			// Token: 0x17005D42 RID: 23874
			// (get) Token: 0x06027830 RID: 161840 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06027831 RID: 161841 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005D42")]
			public ListDict<string, StoryItemModel> dataSet
			{
				[Token(Token = "0x6027830")]
				[Address(RVA = "0x22B4960", Offset = "0x22B3560", VA = "0x1822B4960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6027831")]
				[Address(RVA = "0x22B4A20", Offset = "0x22B3620", VA = "0x1822B4A20")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005D43 RID: 23875
			// (get) Token: 0x06027832 RID: 161842 RVA: 0x000CE988 File Offset: 0x000CCB88
			[Token(Token = "0x17005D43")]
			public override int count
			{
				[Token(Token = "0x6027832")]
				[Address(RVA = "0x22B47E0", Offset = "0x22B33E0", VA = "0x1822B47E0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027833 RID: 161843 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027833")]
			[Address(RVA = "0x22B4760", Offset = "0x22B3360", VA = "0x1822B4760")]
			public ArchiveStoryListAdapter(ArchiveDynamicStoryListDataBinder closure)
			{
			}

			// Token: 0x06027834 RID: 161844 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027834")]
			[Address(RVA = "0x22B4420", Offset = "0x22B3020", VA = "0x1822B4420", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04038057 RID: 229463
			[Token(Token = "0x4038057")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveDynamicStoryListDataBinder m_closure;

			// Token: 0x04038059 RID: 229465
			[Token(Token = "0x4038059")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x0403805A RID: 229466
			[Token(Token = "0x403805A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x0403805B RID: 229467
			[Token(Token = "0x403805B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403805C RID: 229468
			[Token(Token = "0x403805C")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403805D RID: 229469
			[Token(Token = "0x403805D")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
