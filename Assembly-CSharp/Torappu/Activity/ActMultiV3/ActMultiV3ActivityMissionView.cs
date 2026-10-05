using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F63 RID: 28515
	[Token(Token = "0x2006F63")]
	public class ActMultiV3ActivityMissionView : ActMultiV3TabContentAbstractView
	{
		// Token: 0x060287D0 RID: 165840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287D0")]
		[Address(RVA = "0x23BED10", Offset = "0x23BD910", VA = "0x1823BED10", Slot = "4")]
		public override void Render(ActMultiV3ManualViewModel viewModel)
		{
		}

		// Token: 0x060287D1 RID: 165841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287D1")]
		[Address(RVA = "0x23BEC80", Offset = "0x23BD880", VA = "0x1823BEC80")]
		public void OnClickClaimAllBtn()
		{
		}

		// Token: 0x060287D2 RID: 165842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60287D2")]
		[Address(RVA = "0x23BEE70", Offset = "0x23BDA70", VA = "0x1823BEE70")]
		public ActMultiV3ActivityMissionView()
		{
		}

		// Token: 0x040399CE RID: 235982
		[Token(Token = "0x40399CE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ActMultiV3ActivityMissionAdapter _missionAdapter;

		// Token: 0x040399CF RID: 235983
		[Token(Token = "0x40399CF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _completedTaskText;

		// Token: 0x040399D0 RID: 235984
		[Token(Token = "0x40399D0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _totalTaskText;

		// Token: 0x040399D1 RID: 235985
		[Token(Token = "0x40399D1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TwoStateToggle _claimAllToggle;

		// Token: 0x040399D2 RID: 235986
		[Token(Token = "0x40399D2")]
		[FieldOffset(Offset = "0x38")]
		private UIStateFinder m_finder;

		// Token: 0x040399D3 RID: 235987
		[Token(Token = "0x40399D3")]
		[FieldOffset(Offset = "0x48")]
		private int m_cachedLoadSeqNum;

		// Token: 0x040399D4 RID: 235988
		[Token(Token = "0x40399D4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040399D5 RID: 235989
		[Token(Token = "0x40399D5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClickClaimAllBtn;

		// Token: 0x040399D6 RID: 235990
		[Token(Token = "0x40399D6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
