using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side.UI
{
	// Token: 0x02007A50 RID: 31312
	[Token(Token = "0x2007A50")]
	public class Act13sideMapZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170066D5 RID: 26325
		// (get) Token: 0x0602BDDE RID: 179678 RVA: 0x000DD718 File Offset: 0x000DB918
		[Token(Token = "0x170066D5")]
		public Act13SideData.ActZoneClass zoneClass
		{
			[Token(Token = "0x602BDDE")]
			[Address(RVA = "0x27CBF60", Offset = "0x27CAB60", VA = "0x1827CBF60")]
			get
			{
				return Act13SideData.ActZoneClass.NONE;
			}
		}

		// Token: 0x0602BDDF RID: 179679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDDF")]
		[Address(RVA = "0x27CBBF0", Offset = "0x27CA7F0", VA = "0x1827CBBF0")]
		public void Render(Act13sideZoneDescViewModel viewModel, bool isSelected)
		{
		}

		// Token: 0x0602BDE0 RID: 179680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDE0")]
		[Address(RVA = "0x27CBDA0", Offset = "0x27CA9A0", VA = "0x1827CBDA0", Slot = "4")]
		protected virtual void _InitIfNot()
		{
		}

		// Token: 0x0602BDE1 RID: 179681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDE1")]
		[Address(RVA = "0x27CBB60", Offset = "0x27CA760", VA = "0x1827CBB60")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602BDE2 RID: 179682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDE2")]
		[Address(RVA = "0x27CBED0", Offset = "0x27CAAD0", VA = "0x1827CBED0")]
		public Act13sideMapZoneView()
		{
		}

		// Token: 0x0403F865 RID: 260197
		[Token(Token = "0x403F865")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act13SideData.ActZoneClass _zoneClass;

		// Token: 0x0403F866 RID: 260198
		[Token(Token = "0x403F866")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0403F867 RID: 260199
		[Token(Token = "0x403F867")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelIcon;

		// Token: 0x0403F868 RID: 260200
		[Token(Token = "0x403F868")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _canvasGroupIcon;

		// Token: 0x0403F869 RID: 260201
		[Token(Token = "0x403F869")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403F86A RID: 260202
		[Token(Token = "0x403F86A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403F86B RID: 260203
		[Token(Token = "0x403F86B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIStringEvent _onClicked;

		// Token: 0x0403F86C RID: 260204
		[Token(Token = "0x403F86C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _trackPointContainer;

		// Token: 0x0403F86D RID: 260205
		[Token(Token = "0x403F86D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _trackPointPrefab;

		// Token: 0x0403F86E RID: 260206
		[Token(Token = "0x403F86E")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0403F86F RID: 260207
		[Token(Token = "0x403F86F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_trackPoint;

		// Token: 0x0403F870 RID: 260208
		[Token(Token = "0x403F870")]
		[FieldOffset(Offset = "0x70")]
		private string m_zoneId;

		// Token: 0x0403F871 RID: 260209
		[Token(Token = "0x403F871")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneClass;

		// Token: 0x0403F872 RID: 260210
		[Token(Token = "0x403F872")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F873 RID: 260211
		[Token(Token = "0x403F873")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F874 RID: 260212
		[Token(Token = "0x403F874")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403F875 RID: 260213
		[Token(Token = "0x403F875")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
