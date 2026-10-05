using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DFA RID: 28154
	[Token(Token = "0x2006DFA")]
	public class ActVecBreakV2RewardHintView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602814B RID: 164171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602814B")]
		[Address(RVA = "0x2355DE0", Offset = "0x23549E0", VA = "0x182355DE0")]
		public void Render(int commonCnt, int firstCnt, bool hasCommonReward, bool hasFirstReward, string iconId)
		{
		}

		// Token: 0x0602814C RID: 164172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602814C")]
		[Address(RVA = "0x2356130", Offset = "0x2354D30", VA = "0x182356130")]
		public ActVecBreakV2RewardHintView()
		{
		}

		// Token: 0x04038DD9 RID: 232921
		[Token(Token = "0x4038DD9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _commonRewardPart;

		// Token: 0x04038DDA RID: 232922
		[Token(Token = "0x4038DDA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _commonRewardCntText;

		// Token: 0x04038DDB RID: 232923
		[Token(Token = "0x4038DDB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _firstRewardPart;

		// Token: 0x04038DDC RID: 232924
		[Token(Token = "0x4038DDC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _firstRewardCntText;

		// Token: 0x04038DDD RID: 232925
		[Token(Token = "0x4038DDD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _rewardIcon;

		// Token: 0x04038DDE RID: 232926
		[Token(Token = "0x4038DDE")]
		[FieldOffset(Offset = "0x40")]
		private string m_cachedIconId;

		// Token: 0x04038DDF RID: 232927
		[Token(Token = "0x4038DDF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04038DE0 RID: 232928
		[Token(Token = "0x4038DE0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
