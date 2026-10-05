using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200681A RID: 26650
	[Token(Token = "0x200681A")]
	public class StageSideStoryZoneTabView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060262E2 RID: 156386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262E2")]
		[Address(RVA = "0x213D7B0", Offset = "0x213C3B0", VA = "0x18213D7B0")]
		public void OnZoneDescModelUpdated(List<ZoneViewModel> models, string selectedZoneId)
		{
		}

		// Token: 0x060262E3 RID: 156387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262E3")]
		[Address(RVA = "0x213D6F0", Offset = "0x213C2F0", VA = "0x18213D6F0")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x060262E4 RID: 156388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262E4")]
		[Address(RVA = "0x213DB10", Offset = "0x213C710", VA = "0x18213DB10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060262E5 RID: 156389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262E5")]
		[Address(RVA = "0x213DBA0", Offset = "0x213C7A0", VA = "0x18213DBA0")]
		public StageSideStoryZoneTabView()
		{
		}

		// Token: 0x04035C9B RID: 220315
		[Token(Token = "0x4035C9B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public string _zoneId;

		// Token: 0x04035C9C RID: 220316
		[Token(Token = "0x4035C9C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelUnlocked;

		// Token: 0x04035C9D RID: 220317
		[Token(Token = "0x4035C9D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x04035C9E RID: 220318
		[Token(Token = "0x4035C9E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x04035C9F RID: 220319
		[Token(Token = "0x4035C9F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelUnselected;

		// Token: 0x04035CA0 RID: 220320
		[Token(Token = "0x4035CA0")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _zoneName;

		// Token: 0x04035CA1 RID: 220321
		[Token(Token = "0x4035CA1")]
		[FieldOffset(Offset = "0x48")]
		private StageSideStoryZoneTabViewPlugin m_tabViewPlugin;

		// Token: 0x04035CA2 RID: 220322
		[Token(Token = "0x4035CA2")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x04035CA3 RID: 220323
		[Token(Token = "0x4035CA3")]
		[FieldOffset(Offset = "0x58")]
		[NonSerialized]
		public Action<string> onZoneClicked;

		// Token: 0x04035CA4 RID: 220324
		[Token(Token = "0x4035CA4")]
		[FieldOffset(Offset = "0x60")]
		private ZoneViewModel m_zoneViewModel;

		// Token: 0x04035CA5 RID: 220325
		[Token(Token = "0x4035CA5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnZoneDescModelUpdated;

		// Token: 0x04035CA6 RID: 220326
		[Token(Token = "0x4035CA6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x04035CA7 RID: 220327
		[Token(Token = "0x4035CA7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04035CA8 RID: 220328
		[Token(Token = "0x4035CA8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
