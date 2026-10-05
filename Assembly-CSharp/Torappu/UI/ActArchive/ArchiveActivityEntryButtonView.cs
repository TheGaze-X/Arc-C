using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AFB RID: 27387
	[Token(Token = "0x2006AFB")]
	public class ArchiveActivityEntryButtonView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005C91 RID: 23697
		// (get) Token: 0x06027296 RID: 160406 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027297 RID: 160407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005C91")]
		public ArchiveActivityEntryController controller
		{
			[Token(Token = "0x6027296")]
			[Address(RVA = "0x22521A0", Offset = "0x2250DA0", VA = "0x1822521A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6027297")]
			[Address(RVA = "0x2252200", Offset = "0x2250E00", VA = "0x182252200")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06027298 RID: 160408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027298")]
		[Address(RVA = "0x2251DE0", Offset = "0x22509E0", VA = "0x182251DE0")]
		public void ApplyData(Dictionary<ActArchiveType, ActArchiveCompInfo> itemData)
		{
		}

		// Token: 0x06027299 RID: 160409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027299")]
		[Address(RVA = "0x2251FE0", Offset = "0x2250BE0", VA = "0x182251FE0")]
		public void EventOnBtnClicked()
		{
		}

		// Token: 0x0602729A RID: 160410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602729A")]
		[Address(RVA = "0x2252140", Offset = "0x2250D40", VA = "0x182252140")]
		public ArchiveActivityEntryButtonView()
		{
		}

		// Token: 0x0403765B RID: 226907
		[Token(Token = "0x403765B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403765C RID: 226908
		[Token(Token = "0x403765C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActArchiveType _archivePanelType;

		// Token: 0x0403765D RID: 226909
		[Token(Token = "0x403765D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403765E RID: 226910
		[Token(Token = "0x403765E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelUnlocked;

		// Token: 0x0403765F RID: 226911
		[Token(Token = "0x403765F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x04037660 RID: 226912
		[Token(Token = "0x4037660")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ArchiveEntryButtonBasePlugin _plugin;

		// Token: 0x04037662 RID: 226914
		[Token(Token = "0x4037662")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x04037663 RID: 226915
		[Token(Token = "0x4037663")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x04037664 RID: 226916
		[Token(Token = "0x4037664")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04037665 RID: 226917
		[Token(Token = "0x4037665")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBtnClicked;

		// Token: 0x04037666 RID: 226918
		[Token(Token = "0x4037666")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
