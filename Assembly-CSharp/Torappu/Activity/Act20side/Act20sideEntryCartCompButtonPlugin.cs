using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act20side
{
	// Token: 0x0200765A RID: 30298
	[Token(Token = "0x200765A")]
	public class Act20sideEntryCartCompButtonPlugin : TemplateActivityCommonPlugin
	{
		// Token: 0x0602A9DF RID: 174559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9DF")]
		[Address(RVA = "0x2658400", Offset = "0x2657000", VA = "0x182658400")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A9E0 RID: 174560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9E0")]
		[Address(RVA = "0x2658120", Offset = "0x2656D20", VA = "0x182658120", Slot = "5")]
		public override void OnViewModelRefresh(TemplateActivityViewModel viewModel)
		{
		}

		// Token: 0x0602A9E1 RID: 174561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9E1")]
		[Address(RVA = "0x2657F60", Offset = "0x2656B60", VA = "0x182657F60")]
		public void EventOnCartCompBtnClicked()
		{
		}

		// Token: 0x0602A9E2 RID: 174562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A9E2")]
		[Address(RVA = "0x2658490", Offset = "0x2657090", VA = "0x182658490")]
		public Act20sideEntryCartCompButtonPlugin()
		{
		}

		// Token: 0x0403D5F9 RID: 251385
		[Token(Token = "0x403D5F9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelLocked;

		// Token: 0x0403D5FA RID: 251386
		[Token(Token = "0x403D5FA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelAccessible;

		// Token: 0x0403D5FB RID: 251387
		[Token(Token = "0x403D5FB")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _txtUnlockInfo;

		// Token: 0x0403D5FC RID: 251388
		[Token(Token = "0x403D5FC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICommonTrackPoint _trackPoint;

		// Token: 0x0403D5FD RID: 251389
		[Token(Token = "0x403D5FD")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelNew;

		// Token: 0x0403D5FE RID: 251390
		[Token(Token = "0x403D5FE")]
		[FieldOffset(Offset = "0x50")]
		private bool m_hasInited;

		// Token: 0x0403D5FF RID: 251391
		[Token(Token = "0x403D5FF")]
		[FieldOffset(Offset = "0x58")]
		private TrackPointViewProperty m_trackPoint;

		// Token: 0x0403D600 RID: 251392
		[Token(Token = "0x403D600")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D601 RID: 251393
		[Token(Token = "0x403D601")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnViewModelRefresh;

		// Token: 0x0403D602 RID: 251394
		[Token(Token = "0x403D602")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCartCompBtnClicked;

		// Token: 0x0403D603 RID: 251395
		[Token(Token = "0x403D603")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
