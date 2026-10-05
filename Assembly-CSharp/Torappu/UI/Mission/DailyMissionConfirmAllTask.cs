using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x02004882 RID: 18562
	[Token(Token = "0x2004882")]
	public class DailyMissionConfirmAllTask : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601C06C RID: 114796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C06C")]
		[Address(RVA = "0x1562D50", Offset = "0x1561950", VA = "0x181562D50")]
		public void InitData(DailyMissionSimpleView.DailyOrWeekly dataType)
		{
		}

		// Token: 0x0601C06D RID: 114797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C06D")]
		[Address(RVA = "0x1562CE0", Offset = "0x15618E0", VA = "0x181562CE0")]
		public void ApplyAllReward()
		{
		}

		// Token: 0x0601C06E RID: 114798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C06E")]
		[Address(RVA = "0x1562E90", Offset = "0x1561A90", VA = "0x181562E90")]
		public DailyMissionConfirmAllTask()
		{
		}

		// Token: 0x0402490B RID: 149771
		[Token(Token = "0x402490B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _describeText;

		// Token: 0x0402490C RID: 149772
		[Token(Token = "0x402490C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _buttonText;

		// Token: 0x0402490D RID: 149773
		[Token(Token = "0x402490D")]
		[FieldOffset(Offset = "0x28")]
		private MissionType m_missionType;

		// Token: 0x0402490E RID: 149774
		[Token(Token = "0x402490E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402490F RID: 149775
		[Token(Token = "0x402490F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyAllReward;

		// Token: 0x04024910 RID: 149776
		[Token(Token = "0x4024910")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
