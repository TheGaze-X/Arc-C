using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C2C RID: 27692
	[Token(Token = "0x2006C2C")]
	public class ArchiveTimelineCategoryBtn : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005D4E RID: 23886
		// (get) Token: 0x06027884 RID: 161924 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027885 RID: 161925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005D4E")]
		public ArchiveTimelineController controller
		{
			[Token(Token = "0x6027884")]
			[Address(RVA = "0x22B6AC0", Offset = "0x22B56C0", VA = "0x1822B6AC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6027885")]
			[Address(RVA = "0x22B6B20", Offset = "0x22B5720", VA = "0x1822B6B20")]
			set
			{
			}
		}

		// Token: 0x06027886 RID: 161926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027886")]
		[Address(RVA = "0x22B6840", Offset = "0x22B5440", VA = "0x1822B6840")]
		public void ApplyData(bool locked)
		{
		}

		// Token: 0x06027887 RID: 161927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027887")]
		[Address(RVA = "0x22B6930", Offset = "0x22B5530", VA = "0x1822B6930")]
		public void EventOnBtnNormalClicked()
		{
		}

		// Token: 0x06027888 RID: 161928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027888")]
		[Address(RVA = "0x22B68D0", Offset = "0x22B54D0", VA = "0x1822B68D0")]
		public void EventOnBtnLockedClicked()
		{
		}

		// Token: 0x06027889 RID: 161929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027889")]
		[Address(RVA = "0x22B6A60", Offset = "0x22B5660", VA = "0x1822B6A60")]
		public ArchiveTimelineCategoryBtn()
		{
		}

		// Token: 0x040380CB RID: 229579
		[Token(Token = "0x40380CB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _btnNormal;

		// Token: 0x040380CC RID: 229580
		[Token(Token = "0x40380CC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _btnLocked;

		// Token: 0x040380CD RID: 229581
		[Token(Token = "0x40380CD")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ActArchiveType _archiveType;

		// Token: 0x040380CE RID: 229582
		[Token(Token = "0x40380CE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imgNormal;

		// Token: 0x040380CF RID: 229583
		[Token(Token = "0x40380CF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgLocked;

		// Token: 0x040380D0 RID: 229584
		[Token(Token = "0x40380D0")]
		[FieldOffset(Offset = "0x40")]
		private bool m_cachedLocked;

		// Token: 0x040380D1 RID: 229585
		[Token(Token = "0x40380D1")]
		[FieldOffset(Offset = "0x48")]
		private ArchiveTimelineController m_controller;

		// Token: 0x040380D2 RID: 229586
		[Token(Token = "0x40380D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040380D3 RID: 229587
		[Token(Token = "0x40380D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x040380D4 RID: 229588
		[Token(Token = "0x40380D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x040380D5 RID: 229589
		[Token(Token = "0x40380D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBtnNormalClicked;

		// Token: 0x040380D6 RID: 229590
		[Token(Token = "0x40380D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnBtnLockedClicked;

		// Token: 0x040380D7 RID: 229591
		[Token(Token = "0x40380D7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
