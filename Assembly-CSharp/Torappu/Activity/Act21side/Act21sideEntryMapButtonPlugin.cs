using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act21side
{
	// Token: 0x02007620 RID: 30240
	[Token(Token = "0x2007620")]
	public class Act21sideEntryMapButtonPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602A92F RID: 174383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A92F")]
		[Address(RVA = "0x265C6C0", Offset = "0x265B2C0", VA = "0x18265C6C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A930 RID: 174384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A930")]
		[Address(RVA = "0x265C390", Offset = "0x265AF90", VA = "0x18265C390", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A931 RID: 174385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A931")]
		[Address(RVA = "0x265C150", Offset = "0x265AD50", VA = "0x18265C150")]
		public void EventOnMapBtnClicked()
		{
		}

		// Token: 0x0602A932 RID: 174386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A932")]
		[Address(RVA = "0x265BFA0", Offset = "0x265ABA0", VA = "0x18265BFA0")]
		public void EventOnCommentBtnClicked()
		{
		}

		// Token: 0x0602A933 RID: 174387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A933")]
		[Address(RVA = "0x265C890", Offset = "0x265B490", VA = "0x18265C890")]
		public Act21sideEntryMapButtonPlugin()
		{
		}

		// Token: 0x0403D4B5 RID: 251061
		[Token(Token = "0x403D4B5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _trackPointMap;

		// Token: 0x0403D4B6 RID: 251062
		[Token(Token = "0x403D4B6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _trackPointNew;

		// Token: 0x0403D4B7 RID: 251063
		[Token(Token = "0x403D4B7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICommonTrackPoint _trackPointOpera;

		// Token: 0x0403D4B8 RID: 251064
		[Token(Token = "0x403D4B8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonTrackPoint _trackPointLike;

		// Token: 0x0403D4B9 RID: 251065
		[Token(Token = "0x403D4B9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _timeoutPanelMap;

		// Token: 0x0403D4BA RID: 251066
		[Token(Token = "0x403D4BA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _timeoutPanelOpera;

		// Token: 0x0403D4BB RID: 251067
		[Token(Token = "0x403D4BB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textInfoMapNew;

		// Token: 0x0403D4BC RID: 251068
		[Token(Token = "0x403D4BC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _textInfoMapClose;

		// Token: 0x0403D4BD RID: 251069
		[Token(Token = "0x403D4BD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textInfoOperaClose;

		// Token: 0x0403D4BE RID: 251070
		[Token(Token = "0x403D4BE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button _buttonMap;

		// Token: 0x0403D4BF RID: 251071
		[Token(Token = "0x403D4BF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button _buttonOpera;

		// Token: 0x0403D4C0 RID: 251072
		[Token(Token = "0x403D4C0")]
		[FieldOffset(Offset = "0x80")]
		private bool m_hasInited;

		// Token: 0x0403D4C1 RID: 251073
		[Token(Token = "0x403D4C1")]
		[FieldOffset(Offset = "0x88")]
		private TrackPointViewProperty m_trackPointMap;

		// Token: 0x0403D4C2 RID: 251074
		[Token(Token = "0x403D4C2")]
		[FieldOffset(Offset = "0x90")]
		private TrackPointViewProperty m_trackPointOpera;

		// Token: 0x0403D4C3 RID: 251075
		[Token(Token = "0x403D4C3")]
		[FieldOffset(Offset = "0x98")]
		private TrackPointViewProperty m_trackPointLike;

		// Token: 0x0403D4C4 RID: 251076
		[Token(Token = "0x403D4C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D4C5 RID: 251077
		[Token(Token = "0x403D4C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403D4C6 RID: 251078
		[Token(Token = "0x403D4C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnMapBtnClicked;

		// Token: 0x0403D4C7 RID: 251079
		[Token(Token = "0x403D4C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnCommentBtnClicked;

		// Token: 0x0403D4C8 RID: 251080
		[Token(Token = "0x403D4C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
