using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x02007995 RID: 31125
	[Token(Token = "0x2007995")]
	public class Act1ArcadeStageScoreInfoItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BAB4 RID: 178868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAB4")]
		[Address(RVA = "0x278C870", Offset = "0x278B470", VA = "0x18278C870")]
		private void _InitIfNot(Act1ArcadeStageSelectViewModel stageSelectModel, ActArcadeData.ArcadeStageRankRewardLevelData curLevelReward, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0602BAB5 RID: 178869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAB5")]
		[Address(RVA = "0x278C560", Offset = "0x278B160", VA = "0x18278C560")]
		public void Render(Act1ArcadeStageSelectViewModel stageSelectModel, ActArcadeData.ArcadeStageRankRewardLevelData curLevelReward, ILoadAsset assetLoader)
		{
		}

		// Token: 0x0602BAB6 RID: 178870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAB6")]
		[Address(RVA = "0x278CA00", Offset = "0x278B600", VA = "0x18278CA00")]
		public Act1ArcadeStageScoreInfoItemView()
		{
		}

		// Token: 0x0403F2C1 RID: 258753
		[Token(Token = "0x403F2C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _rewardStateToggle;

		// Token: 0x0403F2C2 RID: 258754
		[Token(Token = "0x403F2C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgRank;

		// Token: 0x0403F2C3 RID: 258755
		[Token(Token = "0x403F2C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textScoreLimit;

		// Token: 0x0403F2C4 RID: 258756
		[Token(Token = "0x403F2C4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textReward;

		// Token: 0x0403F2C5 RID: 258757
		[Token(Token = "0x403F2C5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imgToken;

		// Token: 0x0403F2C6 RID: 258758
		[Token(Token = "0x403F2C6")]
		[FieldOffset(Offset = "0x40")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0403F2C7 RID: 258759
		[Token(Token = "0x403F2C7")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0403F2C8 RID: 258760
		[Token(Token = "0x403F2C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F2C9 RID: 258761
		[Token(Token = "0x403F2C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403F2CA RID: 258762
		[Token(Token = "0x403F2CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
