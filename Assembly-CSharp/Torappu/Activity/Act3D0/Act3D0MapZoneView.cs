using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x02007405 RID: 29701
	[Token(Token = "0x2007405")]
	public class Act3D0MapZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F25 RID: 171813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F25")]
		[Address(RVA = "0x258DF90", Offset = "0x258CB90", VA = "0x18258DF90")]
		public void OnZoneDescModelUpdated(List<Act3D0ZoneDescModel> descModels, string selectedZoneId)
		{
		}

		// Token: 0x06029F26 RID: 171814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F26")]
		[Address(RVA = "0x258DF20", Offset = "0x258CB20", VA = "0x18258DF20")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x06029F27 RID: 171815 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F27")]
		[Address(RVA = "0x258E150", Offset = "0x258CD50", VA = "0x18258E150")]
		public Act3D0MapZoneView()
		{
		}

		// Token: 0x0403C1E7 RID: 246247
		[Token(Token = "0x403C1E7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string _zoneId;

		// Token: 0x0403C1E8 RID: 246248
		[Token(Token = "0x403C1E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnlocked;

		// Token: 0x0403C1E9 RID: 246249
		[Token(Token = "0x403C1E9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403C1EA RID: 246250
		[Token(Token = "0x403C1EA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x0403C1EB RID: 246251
		[Token(Token = "0x403C1EB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelTrackPoint;

		// Token: 0x0403C1EC RID: 246252
		[Token(Token = "0x403C1EC")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<string> onZoneClicked;

		// Token: 0x0403C1ED RID: 246253
		[Token(Token = "0x403C1ED")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnZoneDescModelUpdated;

		// Token: 0x0403C1EE RID: 246254
		[Token(Token = "0x403C1EE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x0403C1EF RID: 246255
		[Token(Token = "0x403C1EF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
