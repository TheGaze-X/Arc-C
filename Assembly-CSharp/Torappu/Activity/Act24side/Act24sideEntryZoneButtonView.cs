using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007591 RID: 30097
	[Token(Token = "0x2007591")]
	public class Act24sideEntryZoneButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170063B3 RID: 25523
		// (get) Token: 0x0602A5D7 RID: 173527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170063B3")]
		public string zoneId
		{
			[Token(Token = "0x602A5D7")]
			[Address(RVA = "0x2601D90", Offset = "0x2600990", VA = "0x182601D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602A5D8 RID: 173528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5D8")]
		[Address(RVA = "0x2601C50", Offset = "0x2600850", VA = "0x182601C50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A5D9 RID: 173529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5D9")]
		[Address(RVA = "0x26015C0", Offset = "0x26001C0", VA = "0x1826015C0")]
		public void Render(TemplateActivityZoneGroupViewModel.ZoneViewModel viewModel)
		{
		}

		// Token: 0x0602A5DA RID: 173530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5DA")]
		[Address(RVA = "0x26014F0", Offset = "0x26000F0", VA = "0x1826014F0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0602A5DB RID: 173531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5DB")]
		[Address(RVA = "0x2601CE0", Offset = "0x26008E0", VA = "0x182601CE0")]
		public Act24sideEntryZoneButtonView()
		{
		}

		// Token: 0x0403CF1B RID: 249627
		[Token(Token = "0x403CF1B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403CF1C RID: 249628
		[Token(Token = "0x403CF1C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x0403CF1D RID: 249629
		[Token(Token = "0x403CF1D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _normGroup;

		// Token: 0x0403CF1E RID: 249630
		[Token(Token = "0x403CF1E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelStageLock;

		// Token: 0x0403CF1F RID: 249631
		[Token(Token = "0x403CF1F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textStageLockInfo;

		// Token: 0x0403CF20 RID: 249632
		[Token(Token = "0x403CF20")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelTimeout;

		// Token: 0x0403CF21 RID: 249633
		[Token(Token = "0x403CF21")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textTimeOutInfo;

		// Token: 0x0403CF22 RID: 249634
		[Token(Token = "0x403CF22")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelTimeLock;

		// Token: 0x0403CF23 RID: 249635
		[Token(Token = "0x403CF23")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textTimeLockInfo;

		// Token: 0x0403CF24 RID: 249636
		[Token(Token = "0x403CF24")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UICommonTrackPoint _trackPointNew;

		// Token: 0x0403CF25 RID: 249637
		[Token(Token = "0x403CF25")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIStringEvent _onClicked;

		// Token: 0x0403CF26 RID: 249638
		[Token(Token = "0x403CF26")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _alphaAccess;

		// Token: 0x0403CF27 RID: 249639
		[Token(Token = "0x403CF27")]
		[FieldOffset(Offset = "0x74")]
		private bool m_hasInited;

		// Token: 0x0403CF28 RID: 249640
		[Token(Token = "0x403CF28")]
		[FieldOffset(Offset = "0x78")]
		private GameObject m_trackPoint;

		// Token: 0x0403CF29 RID: 249641
		[Token(Token = "0x403CF29")]
		[FieldOffset(Offset = "0x80")]
		private TrackPointViewProperty m_trackPointNew;

		// Token: 0x0403CF2A RID: 249642
		[Token(Token = "0x403CF2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_zoneId;

		// Token: 0x0403CF2B RID: 249643
		[Token(Token = "0x403CF2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CF2C RID: 249644
		[Token(Token = "0x403CF2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403CF2D RID: 249645
		[Token(Token = "0x403CF2D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x0403CF2E RID: 249646
		[Token(Token = "0x403CF2E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
