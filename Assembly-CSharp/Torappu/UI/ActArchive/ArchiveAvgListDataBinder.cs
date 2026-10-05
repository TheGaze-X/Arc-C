using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B08 RID: 27400
	[Token(Token = "0x2006B08")]
	public class ArchiveAvgListDataBinder : DataBinder<AvgProperty>
	{
		// Token: 0x17005C97 RID: 23703
		// (get) Token: 0x060272DC RID: 160476 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060272DD RID: 160477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C97")]
		public ArchiveAvgController controller
		{
			[Token(Token = "0x60272DC")]
			[Address(RVA = "0x22558F0", Offset = "0x22544F0", VA = "0x1822558F0")]
			private get
			{
				return null;
			}
			[Token(Token = "0x60272DD")]
			[Address(RVA = "0x2255950", Offset = "0x2254550", VA = "0x182255950")]
			set
			{
			}
		}

		// Token: 0x060272DE RID: 160478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272DE")]
		[Address(RVA = "0x2254640", Offset = "0x2253240", VA = "0x182254640")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060272DF RID: 160479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272DF")]
		[Address(RVA = "0x2254170", Offset = "0x2252D70", VA = "0x182254170", Slot = "7")]
		public override void OnValueChanged(AvgProperty property)
		{
		}

		// Token: 0x060272E0 RID: 160480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272E0")]
		[Address(RVA = "0x2254BD0", Offset = "0x22537D0", VA = "0x182254BD0")]
		private void _RefreshLeftPanel()
		{
		}

		// Token: 0x060272E1 RID: 160481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272E1")]
		[Address(RVA = "0x2254060", Offset = "0x2252C60", VA = "0x182254060")]
		public void OnAvgCardItemClick()
		{
		}

		// Token: 0x060272E2 RID: 160482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272E2")]
		[Address(RVA = "0x2255700", Offset = "0x2254300", VA = "0x182255700")]
		private void _SetContent(string title, string content, Sprite sprite)
		{
		}

		// Token: 0x060272E3 RID: 160483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272E3")]
		[Address(RVA = "0x2254960", Offset = "0x2253560", VA = "0x182254960")]
		private void _OnStoryClicked(string storyId)
		{
		}

		// Token: 0x060272E4 RID: 160484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60272E4")]
		[Address(RVA = "0x22544B0", Offset = "0x22530B0", VA = "0x1822544B0")]
		private DataBundle _ArchiveAvgDetailToDataBundle()
		{
			return null;
		}

		// Token: 0x060272E5 RID: 160485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60272E5")]
		[Address(RVA = "0x2254590", Offset = "0x2253190", VA = "0x182254590")]
		private static string _GetStoryBriefPath(string key)
		{
			return null;
		}

		// Token: 0x060272E6 RID: 160486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60272E6")]
		[Address(RVA = "0x2253F80", Offset = "0x2252B80", VA = "0x182253F80")]
		public IEnumerator FocusOnSelectedItem(bool fastMode, float duration)
		{
			return null;
		}

		// Token: 0x060272E7 RID: 160487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272E7")]
		[Address(RVA = "0x2255820", Offset = "0x2254420", VA = "0x182255820")]
		public ArchiveAvgListDataBinder()
		{
		}

		// Token: 0x040376BB RID: 227003
		[Token(Token = "0x40376BB")]
		private const float FADE_TIME = 0.15f;

		// Token: 0x040376BC RID: 227004
		[Token(Token = "0x40376BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _listViewContainer;

		// Token: 0x040376BD RID: 227005
		[Token(Token = "0x40376BD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AutoFocusScrollView _scrollView;

		// Token: 0x040376BE RID: 227006
		[Token(Token = "0x40376BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Left Panel Canvas Group")]
		private CanvasGroup _titleCanvas;

		// Token: 0x040376BF RID: 227007
		[Token(Token = "0x40376BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Left Panel Canvas Group")]
		private CanvasGroup _contentCanvas;

		// Token: 0x040376C0 RID: 227008
		[Token(Token = "0x40376C0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Left Panel Canvas Group")]
		private CanvasGroup _spriteCanvas;

		// Token: 0x040376C1 RID: 227009
		[Token(Token = "0x40376C1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Left Panel Item")]
		private Text _title;

		// Token: 0x040376C2 RID: 227010
		[Token(Token = "0x40376C2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Left Panel Item")]
		private Text _content;

		// Token: 0x040376C3 RID: 227011
		[Token(Token = "0x40376C3")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Left Panel Item")]
		private Image _sprite;

		// Token: 0x040376C4 RID: 227012
		[Token(Token = "0x40376C4")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<ArchivePicListDataBinder.ArchivePicIcon> _imgListItemTitleGroup;

		// Token: 0x040376C5 RID: 227013
		[Token(Token = "0x40376C5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Sprite _defaultListIcon;

		// Token: 0x040376C6 RID: 227014
		[Token(Token = "0x40376C6")]
		[FieldOffset(Offset = "0x70")]
		private ArchiveAvgListDataBinder.ListAdapter m_listAdapter;

		// Token: 0x040376C7 RID: 227015
		[Token(Token = "0x40376C7")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x040376C8 RID: 227016
		[Token(Token = "0x40376C8")]
		[FieldOffset(Offset = "0x80")]
		private string m_cachedItemId;

		// Token: 0x040376C9 RID: 227017
		[Token(Token = "0x40376C9")]
		[FieldOffset(Offset = "0x88")]
		private ArchiveAvgModel m_cachedModel;

		// Token: 0x040376CA RID: 227018
		[Token(Token = "0x40376CA")]
		[FieldOffset(Offset = "0x90")]
		private string m_cachedAvgItem;

		// Token: 0x040376CB RID: 227019
		[Token(Token = "0x40376CB")]
		[FieldOffset(Offset = "0x98")]
		private ArchiveAvgController m_controller;

		// Token: 0x040376CC RID: 227020
		[Token(Token = "0x40376CC")]
		[FieldOffset(Offset = "0xA0")]
		private Sequence m_tween;

		// Token: 0x040376CD RID: 227021
		[Token(Token = "0x40376CD")]
		[FieldOffset(Offset = "0xA8")]
		private Dictionary<string, Sprite> m_imgListItemTitleMap;

		// Token: 0x040376CE RID: 227022
		[Token(Token = "0x40376CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040376CF RID: 227023
		[Token(Token = "0x40376CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040376D0 RID: 227024
		[Token(Token = "0x40376D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040376D1 RID: 227025
		[Token(Token = "0x40376D1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040376D2 RID: 227026
		[Token(Token = "0x40376D2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshLeftPanel;

		// Token: 0x040376D3 RID: 227027
		[Token(Token = "0x40376D3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnAvgCardItemClick;

		// Token: 0x040376D4 RID: 227028
		[Token(Token = "0x40376D4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SetContent;

		// Token: 0x040376D5 RID: 227029
		[Token(Token = "0x40376D5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnStoryClicked;

		// Token: 0x040376D6 RID: 227030
		[Token(Token = "0x40376D6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ArchiveAvgDetailToDataBundle;

		// Token: 0x040376D7 RID: 227031
		[Token(Token = "0x40376D7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetStoryBriefPath;

		// Token: 0x040376D8 RID: 227032
		[Token(Token = "0x40376D8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_FocusOnSelectedItem;

		// Token: 0x040376D9 RID: 227033
		[Token(Token = "0x40376D9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B09 RID: 27401
		[Token(Token = "0x2006B09")]
		private class ListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17005C98 RID: 23704
			// (get) Token: 0x060272E8 RID: 160488 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060272E9 RID: 160489 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005C98")]
			public ListDict<string, AvgItemModel> dataSet
			{
				[Token(Token = "0x60272E8")]
				[Address(RVA = "0x225DE60", Offset = "0x225CA60", VA = "0x18225DE60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60272E9")]
				[Address(RVA = "0x225DF20", Offset = "0x225CB20", VA = "0x18225DF20")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005C99 RID: 23705
			// (get) Token: 0x060272EA RID: 160490 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060272EB RID: 160491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005C99")]
			public string selectedItemId
			{
				[Token(Token = "0x60272EA")]
				[Address(RVA = "0x225DEC0", Offset = "0x225CAC0", VA = "0x18225DEC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60272EB")]
				[Address(RVA = "0x225DFA0", Offset = "0x225CBA0", VA = "0x18225DFA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17005C9A RID: 23706
			// (get) Token: 0x060272EC RID: 160492 RVA: 0x000CD968 File Offset: 0x000CBB68
			[Token(Token = "0x17005C9A")]
			public override int count
			{
				[Token(Token = "0x60272EC")]
				[Address(RVA = "0x225DDA0", Offset = "0x225C9A0", VA = "0x18225DDA0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060272ED RID: 160493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60272ED")]
			[Address(RVA = "0x225DD20", Offset = "0x225C920", VA = "0x18225DD20")]
			public ListAdapter(ArchiveAvgListDataBinder closure)
			{
			}

			// Token: 0x060272EE RID: 160494 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60272EE")]
			[Address(RVA = "0x225D780", Offset = "0x225C380", VA = "0x18225D780", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060272EF RID: 160495 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60272EF")]
			[Address(RVA = "0x225DBA0", Offset = "0x225C7A0", VA = "0x18225DBA0")]
			private Sprite _TryLoadAvgTitleSprite(AvgItemModel itemModel)
			{
				return null;
			}

			// Token: 0x040376DA RID: 227034
			[Token(Token = "0x40376DA")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveAvgListDataBinder m_closure;

			// Token: 0x040376DD RID: 227037
			[Token(Token = "0x40376DD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_dataSet;

			// Token: 0x040376DE RID: 227038
			[Token(Token = "0x40376DE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_dataSet;

			// Token: 0x040376DF RID: 227039
			[Token(Token = "0x40376DF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_selectedItemId;

			// Token: 0x040376E0 RID: 227040
			[Token(Token = "0x40376E0")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_set_selectedItemId;

			// Token: 0x040376E1 RID: 227041
			[Token(Token = "0x40376E1")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040376E2 RID: 227042
			[Token(Token = "0x40376E2")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040376E3 RID: 227043
			[Token(Token = "0x40376E3")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x040376E4 RID: 227044
			[Token(Token = "0x40376E4")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__TryLoadAvgTitleSprite;
		}
	}
}
