using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B4D RID: 27469
	[Token(Token = "0x2006B4D")]
	public class ArchiveChatRecordListDataBinder : DataBinder<ChatProperty>
	{
		// Token: 0x17005CC1 RID: 23745
		// (get) Token: 0x0602741C RID: 160796 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602741D RID: 160797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005CC1")]
		public ActArchiveController controller
		{
			[Token(Token = "0x602741C")]
			[Address(RVA = "0x226F750", Offset = "0x226E350", VA = "0x18226F750")]
			private get
			{
				return null;
			}
			[Token(Token = "0x602741D")]
			[Address(RVA = "0x226F7B0", Offset = "0x226E3B0", VA = "0x18226F7B0")]
			set
			{
			}
		}

		// Token: 0x0602741E RID: 160798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602741E")]
		[Address(RVA = "0x226E7E0", Offset = "0x226D3E0", VA = "0x18226E7E0", Slot = "7")]
		public override void OnValueChanged(ChatProperty property)
		{
		}

		// Token: 0x0602741F RID: 160799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602741F")]
		[Address(RVA = "0x226EF50", Offset = "0x226DB50", VA = "0x18226EF50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027420 RID: 160800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027420")]
		[Address(RVA = "0x226F5C0", Offset = "0x226E1C0", VA = "0x18226F5C0")]
		private void _ResetScrollPosition()
		{
		}

		// Token: 0x06027421 RID: 160801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027421")]
		[Address(RVA = "0x226F4C0", Offset = "0x226E0C0", VA = "0x18226F4C0")]
		private void _PlaySwitchAnim()
		{
		}

		// Token: 0x06027422 RID: 160802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027422")]
		[Address(RVA = "0x226F180", Offset = "0x226DD80", VA = "0x18226F180")]
		private void _LoadCharIllust(RoguelikeTopicMonthSquadTeamChar teamChar)
		{
		}

		// Token: 0x06027423 RID: 160803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027423")]
		[Address(RVA = "0x226E5C0", Offset = "0x226D1C0", VA = "0x18226E5C0")]
		public void OnNextClicked()
		{
		}

		// Token: 0x06027424 RID: 160804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027424")]
		[Address(RVA = "0x226E3A0", Offset = "0x226CFA0", VA = "0x18226E3A0")]
		public void OnBackClicked()
		{
		}

		// Token: 0x06027425 RID: 160805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027425")]
		[Address(RVA = "0x226F6D0", Offset = "0x226E2D0", VA = "0x18226F6D0")]
		public ArchiveChatRecordListDataBinder()
		{
		}

		// Token: 0x040378F9 RID: 227577
		[Token(Token = "0x40378F9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelText;

		// Token: 0x040378FA RID: 227578
		[Token(Token = "0x40378FA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLock;

		// Token: 0x040378FB RID: 227579
		[Token(Token = "0x40378FB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelLockText;

		// Token: 0x040378FC RID: 227580
		[Token(Token = "0x40378FC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SimpleLayoutContent _textContent;

		// Token: 0x040378FD RID: 227581
		[Token(Token = "0x40378FD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _circleContent;

		// Token: 0x040378FE RID: 227582
		[Token(Token = "0x40378FE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private ScrollRect _contentRect;

		// Token: 0x040378FF RID: 227583
		[Token(Token = "0x40378FF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x04037900 RID: 227584
		[Token(Token = "0x4037900")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _count;

		// Token: 0x04037901 RID: 227585
		[Token(Token = "0x4037901")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _countAll;

		// Token: 0x04037902 RID: 227586
		[Token(Token = "0x4037902")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _desc;

		// Token: 0x04037903 RID: 227587
		[Token(Token = "0x4037903")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _descIndexText;

		// Token: 0x04037904 RID: 227588
		[Token(Token = "0x4037904")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04037905 RID: 227589
		[Token(Token = "0x4037905")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _subNameText;

		// Token: 0x04037906 RID: 227590
		[Token(Token = "0x4037906")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _flavorDescText;

		// Token: 0x04037907 RID: 227591
		[Token(Token = "0x4037907")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private RectTransform _charIllustHolder;

		// Token: 0x04037908 RID: 227592
		[Token(Token = "0x4037908")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _animLocation;

		// Token: 0x04037909 RID: 227593
		[Token(Token = "0x4037909")]
		[FieldOffset(Offset = "0xA8")]
		private ActArchiveController m_controller;

		// Token: 0x0403790A RID: 227594
		[Token(Token = "0x403790A")]
		[FieldOffset(Offset = "0xB0")]
		private ActArchiveProxy m_proxy;

		// Token: 0x0403790B RID: 227595
		[Token(Token = "0x403790B")]
		[FieldOffset(Offset = "0xB8")]
		private ArchiveChatRecordListDataBinder.RecordItemAdapter m_itemAdapter;

		// Token: 0x0403790C RID: 227596
		[Token(Token = "0x403790C")]
		[FieldOffset(Offset = "0xC0")]
		private ArchiveChatRecordListDataBinder.RecordCircleAdapter m_circleAdapter;

		// Token: 0x0403790D RID: 227597
		[Token(Token = "0x403790D")]
		[FieldOffset(Offset = "0xC8")]
		private bool m_isInited;

		// Token: 0x0403790E RID: 227598
		[Token(Token = "0x403790E")]
		[FieldOffset(Offset = "0xCC")]
		private int m_cachedSelectedIndex;

		// Token: 0x0403790F RID: 227599
		[Token(Token = "0x403790F")]
		[FieldOffset(Offset = "0xD0")]
		private ListDict<string, ChatItemModel> m_cachedItems;

		// Token: 0x04037910 RID: 227600
		[Token(Token = "0x4037910")]
		[FieldOffset(Offset = "0xD8")]
		private GameObject m_charIllust;

		// Token: 0x04037911 RID: 227601
		[Token(Token = "0x4037911")]
		[FieldOffset(Offset = "0xE0")]
		private string m_cachedCharId;

		// Token: 0x04037912 RID: 227602
		[Token(Token = "0x4037912")]
		[FieldOffset(Offset = "0xE8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04037913 RID: 227603
		[Token(Token = "0x4037913")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037914 RID: 227604
		[Token(Token = "0x4037914")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037915 RID: 227605
		[Token(Token = "0x4037915")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04037916 RID: 227606
		[Token(Token = "0x4037916")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037917 RID: 227607
		[Token(Token = "0x4037917")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ResetScrollPosition;

		// Token: 0x04037918 RID: 227608
		[Token(Token = "0x4037918")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlaySwitchAnim;

		// Token: 0x04037919 RID: 227609
		[Token(Token = "0x4037919")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadCharIllust;

		// Token: 0x0403791A RID: 227610
		[Token(Token = "0x403791A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnNextClicked;

		// Token: 0x0403791B RID: 227611
		[Token(Token = "0x403791B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x0403791C RID: 227612
		[Token(Token = "0x403791C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006B4E RID: 27470
		[Token(Token = "0x2006B4E")]
		public class RecordItemAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06027426 RID: 160806 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027426")]
			[Address(RVA = "0x22785D0", Offset = "0x22771D0", VA = "0x1822785D0")]
			public RecordItemAdapter(ArchiveChatRecordListDataBinder closure)
			{
			}

			// Token: 0x17005CC2 RID: 23746
			// (get) Token: 0x06027427 RID: 160807 RVA: 0x000CDD58 File Offset: 0x000CBF58
			[Token(Token = "0x17005CC2")]
			public override int count
			{
				[Token(Token = "0x6027427")]
				[Address(RVA = "0x2278650", Offset = "0x2277250", VA = "0x182278650", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06027428 RID: 160808 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027428")]
			[Address(RVA = "0x2278050", Offset = "0x2276C50", VA = "0x182278050", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x06027429 RID: 160809 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6027429")]
			[Address(RVA = "0x2278420", Offset = "0x2277020", VA = "0x182278420")]
			private string _TryLoadTextAssets(string textId)
			{
				return null;
			}

			// Token: 0x0403791D RID: 227613
			[Token(Token = "0x403791D")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveChatRecordListDataBinder m_closure;

			// Token: 0x0403791E RID: 227614
			[Token(Token = "0x403791E")]
			[FieldOffset(Offset = "0x28")]
			public ChatItemModel chatItemModel;

			// Token: 0x0403791F RID: 227615
			[Token(Token = "0x403791F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037920 RID: 227616
			[Token(Token = "0x4037920")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037921 RID: 227617
			[Token(Token = "0x4037921")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04037922 RID: 227618
			[Token(Token = "0x4037922")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__TryLoadTextAssets;
		}

		// Token: 0x02006B4F RID: 27471
		[Token(Token = "0x2006B4F")]
		public class RecordCircleAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602742A RID: 160810 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602742A")]
			[Address(RVA = "0x2277F00", Offset = "0x2276B00", VA = "0x182277F00")]
			public RecordCircleAdapter(ArchiveChatRecordListDataBinder closure)
			{
			}

			// Token: 0x17005CC3 RID: 23747
			// (get) Token: 0x0602742B RID: 160811 RVA: 0x000CDD70 File Offset: 0x000CBF70
			[Token(Token = "0x17005CC3")]
			public override int count
			{
				[Token(Token = "0x602742B")]
				[Address(RVA = "0x2277F80", Offset = "0x2276B80", VA = "0x182277F80", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602742C RID: 160812 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602742C")]
			[Address(RVA = "0x2277BE0", Offset = "0x22767E0", VA = "0x182277BE0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04037923 RID: 227619
			[Token(Token = "0x4037923")]
			[FieldOffset(Offset = "0x20")]
			private ArchiveChatRecordListDataBinder m_closure;

			// Token: 0x04037924 RID: 227620
			[Token(Token = "0x4037924")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04037925 RID: 227621
			[Token(Token = "0x4037925")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04037926 RID: 227622
			[Token(Token = "0x4037926")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
