using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007449 RID: 29769
	[Token(Token = "0x2007449")]
	public class Act36sideEntryZoneButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700631E RID: 25374
		// (get) Token: 0x0602A025 RID: 172069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700631E")]
		public string zoneId
		{
			[Token(Token = "0x602A025")]
			[Address(RVA = "0x259B440", Offset = "0x259A040", VA = "0x18259B440")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A026 RID: 172070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A026")]
		[Address(RVA = "0x259B0F0", Offset = "0x2599CF0", VA = "0x18259B0F0")]
		public void Render(TemplateActivityZoneGroupViewModel.ZoneViewModel viewModel, bool isAllTimeout)
		{
		}

		// Token: 0x0602A027 RID: 172071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A027")]
		[Address(RVA = "0x259AFB0", Offset = "0x2599BB0", VA = "0x18259AFB0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602A028 RID: 172072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A028")]
		[Address(RVA = "0x259B3E0", Offset = "0x2599FE0", VA = "0x18259B3E0")]
		public Act36sideEntryZoneButtonView()
		{
		}

		// Token: 0x0403C3EE RID: 246766
		[Token(Token = "0x403C3EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403C3EF RID: 246767
		[Token(Token = "0x403C3EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0403C3F0 RID: 246768
		[Token(Token = "0x403C3F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x0403C3F1 RID: 246769
		[Token(Token = "0x403C3F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelAccessible;

		// Token: 0x0403C3F2 RID: 246770
		[Token(Token = "0x403C3F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelTimeout;

		// Token: 0x0403C3F3 RID: 246771
		[Token(Token = "0x403C3F3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403C3F4 RID: 246772
		[Token(Token = "0x403C3F4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelTimeLocked;

		// Token: 0x0403C3F5 RID: 246773
		[Token(Token = "0x403C3F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelStageLocked;

		// Token: 0x0403C3F6 RID: 246774
		[Token(Token = "0x403C3F6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIStringEvent _onClicked;

		// Token: 0x0403C3F7 RID: 246775
		[Token(Token = "0x403C3F7")]
		[FieldOffset(Offset = "0x60")]
		private bool m_hasInited;

		// Token: 0x0403C3F8 RID: 246776
		[Token(Token = "0x403C3F8")]
		[FieldOffset(Offset = "0x68")]
		private GameObject m_trackPoint;

		// Token: 0x0403C3F9 RID: 246777
		[Token(Token = "0x403C3F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0403C3FA RID: 246778
		[Token(Token = "0x403C3FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C3FB RID: 246779
		[Token(Token = "0x403C3FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403C3FC RID: 246780
		[Token(Token = "0x403C3FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
