using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071F0 RID: 29168
	[Token(Token = "0x20071F0")]
	public class Act5D0MapZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029601 RID: 169473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029601")]
		[Address(RVA = "0x24C07C0", Offset = "0x24BF3C0", VA = "0x1824C07C0")]
		public void OnZoneDescModelUpdated(List<Act5D0ZoneDescModel> descModels, string selectedZoneId)
		{
		}

		// Token: 0x06029602 RID: 169474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029602")]
		[Address(RVA = "0x24C0750", Offset = "0x24BF350", VA = "0x1824C0750")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x06029603 RID: 169475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029603")]
		[Address(RVA = "0x24C0A00", Offset = "0x24BF600", VA = "0x1824C0A00")]
		public Act5D0MapZoneView()
		{
		}

		// Token: 0x0403B170 RID: 242032
		[Token(Token = "0x403B170")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string _zoneId;

		// Token: 0x0403B171 RID: 242033
		[Token(Token = "0x403B171")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _panelContent;

		// Token: 0x0403B172 RID: 242034
		[Token(Token = "0x403B172")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403B173 RID: 242035
		[Token(Token = "0x403B173")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0403B174 RID: 242036
		[Token(Token = "0x403B174")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelTrackPoint;

		// Token: 0x0403B175 RID: 242037
		[Token(Token = "0x403B175")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _lockColor;

		// Token: 0x0403B176 RID: 242038
		[Token(Token = "0x403B176")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public Action<string> onZoneClicked;

		// Token: 0x0403B177 RID: 242039
		[Token(Token = "0x403B177")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnZoneDescModelUpdated;

		// Token: 0x0403B178 RID: 242040
		[Token(Token = "0x403B178")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x0403B179 RID: 242041
		[Token(Token = "0x403B179")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
