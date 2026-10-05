using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act25side
{
	// Token: 0x020074D7 RID: 29911
	[Token(Token = "0x20074D7")]
	public class Act25sideEntryZoneButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17006359 RID: 25433
		// (get) Token: 0x0602A2B2 RID: 172722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17006359")]
		public string zoneId
		{
			[Token(Token = "0x602A2B2")]
			[Address(RVA = "0x25C94E0", Offset = "0x25C80E0", VA = "0x1825C94E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A2B3 RID: 172723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2B3")]
		[Address(RVA = "0x25C9350", Offset = "0x25C7F50", VA = "0x1825C9350")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A2B4 RID: 172724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2B4")]
		[Address(RVA = "0x25C8C60", Offset = "0x25C7860", VA = "0x1825C8C60")]
		public void Render(TemplateActivityZoneGroupViewModel.ZoneViewModel viewModel, bool isAllTimeout)
		{
		}

		// Token: 0x0602A2B5 RID: 172725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2B5")]
		[Address(RVA = "0x25C8BC0", Offset = "0x25C77C0", VA = "0x1825C8BC0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602A2B6 RID: 172726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A2B6")]
		[Address(RVA = "0x25C9480", Offset = "0x25C8080", VA = "0x1825C9480")]
		public Act25sideEntryZoneButtonView()
		{
		}

		// Token: 0x0403C92F RID: 248111
		[Token(Token = "0x403C92F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403C930 RID: 248112
		[Token(Token = "0x403C930")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0403C931 RID: 248113
		[Token(Token = "0x403C931")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textInfo;

		// Token: 0x0403C932 RID: 248114
		[Token(Token = "0x403C932")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x0403C933 RID: 248115
		[Token(Token = "0x403C933")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelAccessible;

		// Token: 0x0403C934 RID: 248116
		[Token(Token = "0x403C934")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelTimeout;

		// Token: 0x0403C935 RID: 248117
		[Token(Token = "0x403C935")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403C936 RID: 248118
		[Token(Token = "0x403C936")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIStringEvent _onClicked;

		// Token: 0x0403C937 RID: 248119
		[Token(Token = "0x403C937")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Fog unlock track point")]
		private RectTransform _trackPointContainer;

		// Token: 0x0403C938 RID: 248120
		[Token(Token = "0x403C938")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0403C939 RID: 248121
		[Token(Token = "0x403C939")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_trackPoint;

		// Token: 0x0403C93A RID: 248122
		[Token(Token = "0x403C93A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0403C93B RID: 248123
		[Token(Token = "0x403C93B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C93C RID: 248124
		[Token(Token = "0x403C93C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C93D RID: 248125
		[Token(Token = "0x403C93D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403C93E RID: 248126
		[Token(Token = "0x403C93E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
