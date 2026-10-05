using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Mission;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x02007172 RID: 29042
	[Token(Token = "0x2007172")]
	public class Act9D0MissionSubView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060293AE RID: 168878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293AE")]
		[Address(RVA = "0x249CF50", Offset = "0x249BB50", VA = "0x18249CF50")]
		public void Render(List<MissionViewModel> missionViewModel)
		{
		}

		// Token: 0x060293AF RID: 168879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60293AF")]
		[Address(RVA = "0x249CFE0", Offset = "0x249BBE0", VA = "0x18249CFE0")]
		public Act9D0MissionSubView()
		{
		}

		// Token: 0x0403AE0B RID: 241163
		[Token(Token = "0x403AE0B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Act9D0MissionGroupAdapter _missionGroupAdapter;

		// Token: 0x0403AE0C RID: 241164
		[Token(Token = "0x403AE0C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403AE0D RID: 241165
		[Token(Token = "0x403AE0D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
