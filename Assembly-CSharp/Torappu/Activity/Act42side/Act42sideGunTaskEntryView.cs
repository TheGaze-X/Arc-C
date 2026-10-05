using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007327 RID: 29479
	[Token(Token = "0x2007327")]
	public class Act42sideGunTaskEntryView : DataBinder<Act42sideGunTaskEntryProperty>
	{
		// Token: 0x06029AF8 RID: 170744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AF8")]
		[Address(RVA = "0x2517A20", Offset = "0x2516620", VA = "0x182517A20", Slot = "7")]
		public override void OnValueChanged(Act42sideGunTaskEntryProperty property)
		{
		}

		// Token: 0x06029AF9 RID: 170745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AF9")]
		[Address(RVA = "0x2517840", Offset = "0x2516440", VA = "0x182517840")]
		public void EventOnRewardAvailClick()
		{
		}

		// Token: 0x06029AFA RID: 170746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AFA")]
		[Address(RVA = "0x25178E0", Offset = "0x25164E0", VA = "0x1825178E0")]
		public void EventOnRewardUnavailClick()
		{
		}

		// Token: 0x06029AFB RID: 170747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AFB")]
		[Address(RVA = "0x2517980", Offset = "0x2516580", VA = "0x182517980")]
		public void EventOnTokenDetailClick()
		{
		}

		// Token: 0x06029AFC RID: 170748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AFC")]
		[Address(RVA = "0x25177A0", Offset = "0x25163A0", VA = "0x1825177A0")]
		public void EventOnArchiveClick()
		{
		}

		// Token: 0x06029AFD RID: 170749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029AFD")]
		[Address(RVA = "0x2517C20", Offset = "0x2516820", VA = "0x182517C20")]
		public Act42sideGunTaskEntryView()
		{
		}

		// Token: 0x0403BA5A RID: 244314
		[Token(Token = "0x403BA5A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act42sideGunTaskEntryTrustorView[] _trustorItems;

		// Token: 0x0403BA5B RID: 244315
		[Token(Token = "0x403BA5B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _tokenCount;

		// Token: 0x0403BA5C RID: 244316
		[Token(Token = "0x403BA5C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelRewardAvail;

		// Token: 0x0403BA5D RID: 244317
		[Token(Token = "0x403BA5D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelRewardUnavail;

		// Token: 0x0403BA5E RID: 244318
		[Token(Token = "0x403BA5E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelArchive;

		// Token: 0x0403BA5F RID: 244319
		[Token(Token = "0x403BA5F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelArchiveTrack;

		// Token: 0x0403BA60 RID: 244320
		[Token(Token = "0x403BA60")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelArchiveLock;

		// Token: 0x0403BA61 RID: 244321
		[Token(Token = "0x403BA61")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403BA62 RID: 244322
		[Token(Token = "0x403BA62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403BA63 RID: 244323
		[Token(Token = "0x403BA63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnRewardAvailClick;

		// Token: 0x0403BA64 RID: 244324
		[Token(Token = "0x403BA64")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnRewardUnavailClick;

		// Token: 0x0403BA65 RID: 244325
		[Token(Token = "0x403BA65")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnTokenDetailClick;

		// Token: 0x0403BA66 RID: 244326
		[Token(Token = "0x403BA66")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnArchiveClick;

		// Token: 0x0403BA67 RID: 244327
		[Token(Token = "0x403BA67")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
