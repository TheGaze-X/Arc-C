using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Recruit
{
	// Token: 0x02004734 RID: 18228
	[Token(Token = "0x2004734")]
	public class RecruitBuildConfigRarityItem : MonoBehaviour
	{
		// Token: 0x0601BA0D RID: 113165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA0D")]
		[Address(RVA = "0x14F6D60", Offset = "0x14F5960", VA = "0x1814F6D60")]
		public void InitData(RarityRank i)
		{
		}

		// Token: 0x0601BA0E RID: 113166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA0E")]
		[Address(RVA = "0x14F6D30", Offset = "0x14F5930", VA = "0x1814F6D30")]
		public void CheckState(bool upFlag)
		{
		}

		// Token: 0x0601BA0F RID: 113167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BA0F")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public RecruitBuildConfigRarityItem()
		{
		}

		// Token: 0x04023D2F RID: 146735
		[Token(Token = "0x4023D2F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _rarityIndex;

		// Token: 0x04023D30 RID: 146736
		[Token(Token = "0x4023D30")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _rarityIndex_2;

		// Token: 0x04023D31 RID: 146737
		[Token(Token = "0x4023D31")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _upStateFlag;
	}
}
