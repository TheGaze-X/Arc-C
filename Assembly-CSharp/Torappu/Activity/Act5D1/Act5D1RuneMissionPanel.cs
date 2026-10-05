using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x0200724C RID: 29260
	[Token(Token = "0x200724C")]
	internal class Act5D1RuneMissionPanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700622C RID: 25132
		// (get) Token: 0x06029777 RID: 169847 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029778 RID: 169848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700622C")]
		public Act5D1RuneMissionState ownerState
		{
			[Token(Token = "0x6029777")]
			[Address(RVA = "0x24E4810", Offset = "0x24E3410", VA = "0x1824E4810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6029778")]
			[Address(RVA = "0x24E4870", Offset = "0x24E3470", VA = "0x1824E4870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06029779 RID: 169849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029779")]
		[Address(RVA = "0x24E44D0", Offset = "0x24E30D0", VA = "0x1824E44D0")]
		public void SynContent(List<MissionGroup> missionGrps, Act5D1RuneMissionState owner)
		{
		}

		// Token: 0x0602977A RID: 169850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602977A")]
		[Address(RVA = "0x24E3EB0", Offset = "0x24E2AB0", VA = "0x1824E3EB0")]
		public void Refresh()
		{
		}

		// Token: 0x0602977B RID: 169851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602977B")]
		[Address(RVA = "0x24E45E0", Offset = "0x24E31E0", VA = "0x1824E45E0")]
		private void _AppendMissions(List<MissionData> missions, ref int pos)
		{
		}

		// Token: 0x0602977C RID: 169852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602977C")]
		[Address(RVA = "0x24E47B0", Offset = "0x24E33B0", VA = "0x1824E47B0")]
		public Act5D1RuneMissionPanel()
		{
		}

		// Token: 0x0403B3F1 RID: 242673
		[Token(Token = "0x403B3F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollRect _missionList;

		// Token: 0x0403B3F2 RID: 242674
		[Token(Token = "0x403B3F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _contentRoot;

		// Token: 0x0403B3F3 RID: 242675
		[Token(Token = "0x403B3F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Act5D1RuneMissionItem _itemPrefab;

		// Token: 0x0403B3F4 RID: 242676
		[Token(Token = "0x403B3F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _remainHours;

		// Token: 0x0403B3F5 RID: 242677
		[Token(Token = "0x403B3F5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _remainMinutes;

		// Token: 0x0403B3F6 RID: 242678
		[Token(Token = "0x403B3F6")]
		[FieldOffset(Offset = "0x40")]
		private List<MissionGroup> m_missionGrps;

		// Token: 0x0403B3F8 RID: 242680
		[Token(Token = "0x403B3F8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_ownerState;

		// Token: 0x0403B3F9 RID: 242681
		[Token(Token = "0x403B3F9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_ownerState;

		// Token: 0x0403B3FA RID: 242682
		[Token(Token = "0x403B3FA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SynContent;

		// Token: 0x0403B3FB RID: 242683
		[Token(Token = "0x403B3FB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403B3FC RID: 242684
		[Token(Token = "0x403B3FC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AppendMissions;

		// Token: 0x0403B3FD RID: 242685
		[Token(Token = "0x403B3FD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
