using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D0
{
	// Token: 0x020071FC RID: 29180
	[Token(Token = "0x20071FC")]
	public class Act5D0MissionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029629 RID: 169513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029629")]
		[Address(RVA = "0x24C36C0", Offset = "0x24C22C0", VA = "0x1824C36C0")]
		public void RenderInfo(List<Act5D0MissionViewModel> missionList, int curStoneToken)
		{
		}

		// Token: 0x0602962A RID: 169514 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602962A")]
		[Address(RVA = "0x24C39E0", Offset = "0x24C25E0", VA = "0x1824C39E0")]
		private IEnumerator _ScrollToFirstSlot()
		{
			return null;
		}

		// Token: 0x0602962B RID: 169515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602962B")]
		[Address(RVA = "0x24C3A90", Offset = "0x24C2690", VA = "0x1824C3A90")]
		public Act5D0MissionView()
		{
		}

		// Token: 0x0403B1CA RID: 242122
		[Token(Token = "0x403B1CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act5D0MissionGridAdapter _adapter;

		// Token: 0x0403B1CB RID: 242123
		[Token(Token = "0x403B1CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _passedMissionRate;

		// Token: 0x0403B1CC RID: 242124
		[Token(Token = "0x403B1CC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LoopScrollRect _rect;

		// Token: 0x0403B1CD RID: 242125
		[Token(Token = "0x403B1CD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _curMilestoneToken;

		// Token: 0x0403B1CE RID: 242126
		[Token(Token = "0x403B1CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderInfo;

		// Token: 0x0403B1CF RID: 242127
		[Token(Token = "0x403B1CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ScrollToFirstSlot;

		// Token: 0x0403B1D0 RID: 242128
		[Token(Token = "0x403B1D0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
