using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006BF3 RID: 27635
	[Token(Token = "0x2006BF3")]
	public class ArchiveQuestListItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D24 RID: 23844
		// (get) Token: 0x0602776E RID: 161646 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0602776F RID: 161647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D24")]
		public Action<int> itemSelectEvent
		{
			[Token(Token = "0x602776E")]
			[Address(RVA = "0x22A9C70", Offset = "0x22A8870", VA = "0x1822A9C70")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x602776F")]
			[Address(RVA = "0x22A9CD0", Offset = "0x22A88D0", VA = "0x1822A9CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027770 RID: 161648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027770")]
		[Address(RVA = "0x22A9510", Offset = "0x22A8110", VA = "0x1822A9510")]
		public void OnItemSelectEvent()
		{
		}

		// Token: 0x06027771 RID: 161649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027771")]
		[Address(RVA = "0x22A95F0", Offset = "0x22A81F0", VA = "0x1822A95F0")]
		public void Render(ArchiveQuestListItemView.ViewParam param, bool initRender)
		{
		}

		// Token: 0x06027772 RID: 161650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027772")]
		[Address(RVA = "0x22A9980", Offset = "0x22A8580", VA = "0x1822A9980")]
		private void _CheckIfPlayTrackPointLoopAnim(bool isNew)
		{
		}

		// Token: 0x06027773 RID: 161651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027773")]
		[Address(RVA = "0x22A9B20", Offset = "0x22A8720", VA = "0x1822A9B20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027774 RID: 161652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027774")]
		[Address(RVA = "0x22A9C00", Offset = "0x22A8800", VA = "0x1822A9C00")]
		public ArchiveQuestListItemView()
		{
		}

		// Token: 0x04037ED0 RID: 229072
		[Token(Token = "0x4037ED0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _firstFarLinePanel;

		// Token: 0x04037ED1 RID: 229073
		[Token(Token = "0x4037ED1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _rightLinePanel;

		// Token: 0x04037ED2 RID: 229074
		[Token(Token = "0x4037ED2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _normalPanel;

		// Token: 0x04037ED3 RID: 229075
		[Token(Token = "0x4037ED3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x04037ED4 RID: 229076
		[Token(Token = "0x4037ED4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArchiveQuestListItemView.ArchiveQuestTypePanel[] _typePanels;

		// Token: 0x04037ED5 RID: 229077
		[Token(Token = "0x4037ED5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _selectedGroup;

		// Token: 0x04037ED6 RID: 229078
		[Token(Token = "0x4037ED6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animTrackPointNew;

		// Token: 0x04037ED7 RID: 229079
		[Token(Token = "0x4037ED7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text[] _titleTexts;

		// Token: 0x04037ED8 RID: 229080
		[Token(Token = "0x4037ED8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Graphic _selectGraphic;

		// Token: 0x04037ED9 RID: 229081
		[Token(Token = "0x4037ED9")]
		[FieldOffset(Offset = "0x68")]
		private bool m_hasInited;

		// Token: 0x04037EDA RID: 229082
		[Token(Token = "0x4037EDA")]
		[FieldOffset(Offset = "0x70")]
		private UISwitchTween m_selectTween;

		// Token: 0x04037EDB RID: 229083
		[Token(Token = "0x4037EDB")]
		[FieldOffset(Offset = "0x78")]
		private Tween m_trackPointTween;

		// Token: 0x04037EDC RID: 229084
		[Token(Token = "0x4037EDC")]
		[FieldOffset(Offset = "0x80")]
		private int m_cachedIndex;

		// Token: 0x04037EDE RID: 229086
		[Token(Token = "0x4037EDE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemSelectEvent;

		// Token: 0x04037EDF RID: 229087
		[Token(Token = "0x4037EDF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_itemSelectEvent;

		// Token: 0x04037EE0 RID: 229088
		[Token(Token = "0x4037EE0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnItemSelectEvent;

		// Token: 0x04037EE1 RID: 229089
		[Token(Token = "0x4037EE1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04037EE2 RID: 229090
		[Token(Token = "0x4037EE2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckIfPlayTrackPointLoopAnim;

		// Token: 0x04037EE3 RID: 229091
		[Token(Token = "0x4037EE3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04037EE4 RID: 229092
		[Token(Token = "0x4037EE4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006BF4 RID: 27636
		[Token(Token = "0x2006BF4")]
		public class ViewParam
		{
			// Token: 0x06027775 RID: 161653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6027775")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ViewParam()
			{
			}

			// Token: 0x04037EE5 RID: 229093
			[Token(Token = "0x4037EE5")]
			[FieldOffset(Offset = "0x10")]
			public bool isFirst;

			// Token: 0x04037EE6 RID: 229094
			[Token(Token = "0x4037EE6")]
			[FieldOffset(Offset = "0x11")]
			public bool isLast;

			// Token: 0x04037EE7 RID: 229095
			[Token(Token = "0x4037EE7")]
			[FieldOffset(Offset = "0x14")]
			public int index;

			// Token: 0x04037EE8 RID: 229096
			[Token(Token = "0x4037EE8")]
			[FieldOffset(Offset = "0x18")]
			public ArchiveQuestItemModel item;

			// Token: 0x04037EE9 RID: 229097
			[Token(Token = "0x4037EE9")]
			[FieldOffset(Offset = "0x20")]
			public bool selected;

			// Token: 0x04037EEA RID: 229098
			[Token(Token = "0x4037EEA")]
			[FieldOffset(Offset = "0x28")]
			public Action<int> itemSelectEvent;
		}

		// Token: 0x02006BF5 RID: 27637
		[Token(Token = "0x2006BF5")]
		[Serializable]
		public struct ArchiveQuestTypePanel
		{
			// Token: 0x04037EEB RID: 229099
			[Token(Token = "0x4037EEB")]
			[FieldOffset(Offset = "0x0")]
			public ArchiveQuestItemModel.ArchiveQuestItemType type;

			// Token: 0x04037EEC RID: 229100
			[Token(Token = "0x4037EEC")]
			[FieldOffset(Offset = "0x8")]
			public GameObject panel;
		}
	}
}
