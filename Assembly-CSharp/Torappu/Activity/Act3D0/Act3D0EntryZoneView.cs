using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073F8 RID: 29688
	[Token(Token = "0x20073F8")]
	public class Act3D0EntryZoneView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029EF5 RID: 171765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EF5")]
		[Address(RVA = "0x25881C0", Offset = "0x2586DC0", VA = "0x1825881C0")]
		public void OnZoneDescModelUpdated(List<Act3D0ZoneDescModel> descModels)
		{
		}

		// Token: 0x06029EF6 RID: 171766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EF6")]
		[Address(RVA = "0x2588150", Offset = "0x2586D50", VA = "0x182588150")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x06029EF7 RID: 171767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029EF7")]
		[Address(RVA = "0x2588430", Offset = "0x2587030", VA = "0x182588430")]
		public Act3D0EntryZoneView()
		{
		}

		// Token: 0x0403C16C RID: 246124
		[Token(Token = "0x403C16C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _zoneId;

		// Token: 0x0403C16D RID: 246125
		[Token(Token = "0x403C16D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnlocked;

		// Token: 0x0403C16E RID: 246126
		[Token(Token = "0x403C16E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403C16F RID: 246127
		[Token(Token = "0x403C16F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelTrackPoint;

		// Token: 0x0403C170 RID: 246128
		[Token(Token = "0x403C170")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textLocked;

		// Token: 0x0403C171 RID: 246129
		[Token(Token = "0x403C171")]
		[FieldOffset(Offset = "0x40")]
		[NonSerialized]
		public Action<string> onZoneClicked;

		// Token: 0x0403C172 RID: 246130
		[Token(Token = "0x403C172")]
		[FieldOffset(Offset = "0x48")]
		private Act3D0ZoneDescModel m_cachedModel;

		// Token: 0x0403C173 RID: 246131
		[Token(Token = "0x403C173")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0403C174 RID: 246132
		[Token(Token = "0x403C174")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnZoneDescModelUpdated;

		// Token: 0x0403C175 RID: 246133
		[Token(Token = "0x403C175")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x0403C176 RID: 246134
		[Token(Token = "0x403C176")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
