using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006C87 RID: 27783
	[Token(Token = "0x2006C87")]
	public class TemplateActivityEntryZoneButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005DAE RID: 23982
		// (get) Token: 0x06027A45 RID: 162373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005DAE")]
		public string zoneId
		{
			[Token(Token = "0x6027A45")]
			[Address(RVA = "0x22CE5F0", Offset = "0x22CD1F0", VA = "0x1822CE5F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027A46 RID: 162374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A46")]
		[Address(RVA = "0x22CE3E0", Offset = "0x22CCFE0", VA = "0x1822CE3E0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06027A47 RID: 162375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A47")]
		[Address(RVA = "0x22CDB40", Offset = "0x22CC740", VA = "0x1822CDB40")]
		public void Render(TemplateActivityZoneGroupViewModel.ZoneViewModel viewModel, bool isAllTimeout)
		{
		}

		// Token: 0x06027A48 RID: 162376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A48")]
		[Address(RVA = "0x22CD9C0", Offset = "0x22CC5C0", VA = "0x1822CD9C0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06027A49 RID: 162377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027A49")]
		[Address(RVA = "0x22CE540", Offset = "0x22CD140", VA = "0x1822CE540")]
		public TemplateActivityEntryZoneButtonView()
		{
		}

		// Token: 0x04038399 RID: 230297
		[Token(Token = "0x4038399")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403839A RID: 230298
		[Token(Token = "0x403839A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0403839B RID: 230299
		[Token(Token = "0x403839B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textInfo;

		// Token: 0x0403839C RID: 230300
		[Token(Token = "0x403839C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textExtraInfo;

		// Token: 0x0403839D RID: 230301
		[Token(Token = "0x403839D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _imageNew;

		// Token: 0x0403839E RID: 230302
		[Token(Token = "0x403839E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelAccessible;

		// Token: 0x0403839F RID: 230303
		[Token(Token = "0x403839F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelTimeout;

		// Token: 0x040383A0 RID: 230304
		[Token(Token = "0x40383A0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x040383A1 RID: 230305
		[Token(Token = "0x40383A1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIStringEvent _onClicked;

		// Token: 0x040383A2 RID: 230306
		[Token(Token = "0x40383A2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Fog unlock track point")]
		private RectTransform _trackPointContainer;

		// Token: 0x040383A3 RID: 230307
		[Token(Token = "0x40383A3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Fog unlock track point")]
		private GameObject _trackPointPrefab;

		// Token: 0x040383A4 RID: 230308
		[Token(Token = "0x40383A4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UICommonTrackPoint _trackPointNew;

		// Token: 0x040383A5 RID: 230309
		[Token(Token = "0x40383A5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _playStagePushAudio;

		// Token: 0x040383A6 RID: 230310
		[Token(Token = "0x40383A6")]
		[FieldOffset(Offset = "0x79")]
		private bool m_hasInited;

		// Token: 0x040383A7 RID: 230311
		[Token(Token = "0x40383A7")]
		[FieldOffset(Offset = "0x80")]
		private GameObject m_trackPoint;

		// Token: 0x040383A8 RID: 230312
		[Token(Token = "0x40383A8")]
		[FieldOffset(Offset = "0x88")]
		private TrackPointViewProperty m_trackPointNew;

		// Token: 0x040383A9 RID: 230313
		[Token(Token = "0x40383A9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x040383AA RID: 230314
		[Token(Token = "0x40383AA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040383AB RID: 230315
		[Token(Token = "0x40383AB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040383AC RID: 230316
		[Token(Token = "0x40383AC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x040383AD RID: 230317
		[Token(Token = "0x40383AD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
