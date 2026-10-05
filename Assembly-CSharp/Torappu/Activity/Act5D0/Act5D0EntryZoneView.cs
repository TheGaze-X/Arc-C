using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071EE RID: 29166
	[Token(Token = "0x20071EE")]
	public class Act5D0EntryZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060295FA RID: 169466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295FA")]
		[Address(RVA = "0x24A9220", Offset = "0x24A7E20", VA = "0x1824A9220")]
		public void OnZoneDescModelUpdated(List<Act5D0ZoneDescModel> descModels)
		{
		}

		// Token: 0x060295FB RID: 169467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295FB")]
		[Address(RVA = "0x24A91B0", Offset = "0x24A7DB0", VA = "0x1824A91B0")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x060295FC RID: 169468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60295FC")]
		[Address(RVA = "0x24A9520", Offset = "0x24A8120", VA = "0x1824A9520")]
		public Act5D0EntryZoneView()
		{
		}

		// Token: 0x0403B15D RID: 242013
		[Token(Token = "0x403B15D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403B15E RID: 242014
		[Token(Token = "0x403B15E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Button _btn;

		// Token: 0x0403B15F RID: 242015
		[Token(Token = "0x403B15F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _notOpenLocked;

		// Token: 0x0403B160 RID: 242016
		[Token(Token = "0x403B160")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _timeOutLocked;

		// Token: 0x0403B161 RID: 242017
		[Token(Token = "0x403B161")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textLocked;

		// Token: 0x0403B162 RID: 242018
		[Token(Token = "0x403B162")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelTrackPoint;

		// Token: 0x0403B163 RID: 242019
		[Token(Token = "0x403B163")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public Action<string> onZoneClicked;

		// Token: 0x0403B164 RID: 242020
		[Token(Token = "0x403B164")]
		[FieldOffset(Offset = "0x50")]
		private Act5D0ZoneDescModel m_cachedModel;

		// Token: 0x0403B165 RID: 242021
		[Token(Token = "0x403B165")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x0403B166 RID: 242022
		[Token(Token = "0x403B166")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnZoneDescModelUpdated;

		// Token: 0x0403B167 RID: 242023
		[Token(Token = "0x403B167")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x0403B168 RID: 242024
		[Token(Token = "0x403B168")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
