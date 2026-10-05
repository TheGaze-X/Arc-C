using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Mission;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1
{
	// Token: 0x02007B5B RID: 31579
	[Token(Token = "0x2007B5B")]
	public class ActivityFirstMissionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602C33B RID: 181051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C33B")]
		[Address(RVA = "0x281E5C0", Offset = "0x281D1C0", VA = "0x18281E5C0")]
		public void InitData(List<MissionViewModel> missionList)
		{
		}

		// Token: 0x0602C33C RID: 181052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C33C")]
		[Address(RVA = "0x281E830", Offset = "0x281D430", VA = "0x18281E830")]
		public ActivityFirstMissionView()
		{
		}

		// Token: 0x04040146 RID: 262470
		[Token(Token = "0x4040146")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _missionContainer;

		// Token: 0x04040147 RID: 262471
		[Token(Token = "0x4040147")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActivityFirstMissionItem _missionItem;

		// Token: 0x04040148 RID: 262472
		[Token(Token = "0x4040148")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIStringEvent _stringEvent;

		// Token: 0x04040149 RID: 262473
		[Token(Token = "0x4040149")]
		[FieldOffset(Offset = "0x30")]
		private List<ActivityFirstMissionItem> m_missionList;

		// Token: 0x0404014A RID: 262474
		[Token(Token = "0x404014A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0404014B RID: 262475
		[Token(Token = "0x404014B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
