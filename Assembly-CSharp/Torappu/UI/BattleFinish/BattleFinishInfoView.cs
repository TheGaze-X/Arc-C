using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006210 RID: 25104
	[Token(Token = "0x2006210")]
	public class BattleFinishInfoView : MonoBehaviour
	{
		// Token: 0x06024393 RID: 148371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024393")]
		[Address(RVA = "0x1F17520", Offset = "0x1F16120", VA = "0x181F17520")]
		public void Render(BattleInfoViewModel viewModel, bool isPrewarm = false)
		{
		}

		// Token: 0x06024394 RID: 148372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024394")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BattleFinishInfoView()
		{
		}

		// Token: 0x040325DE RID: 206302
		[Token(Token = "0x40325DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BattleFinishInfoView.StageInfoView _stageView;

		// Token: 0x040325DF RID: 206303
		[Token(Token = "0x40325DF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private BattleFinishInfoView.CampaignInfoView _campaignView;

		// Token: 0x02006211 RID: 25105
		[Token(Token = "0x2006211")]
		public interface ISubInfoView
		{
			// Token: 0x17005576 RID: 21878
			// (get) Token: 0x06024395 RID: 148373
			[Token(Token = "0x17005576")]
			bool isActive { [Token(Token = "0x6024395")] get; }

			// Token: 0x06024396 RID: 148374
			[Token(Token = "0x6024396")]
			void Render(BattleInfoViewModel viewModel, bool isPrewarm);
		}

		// Token: 0x02006212 RID: 25106
		[Token(Token = "0x2006212")]
		[Serializable]
		public struct StageInfoView : BattleFinishInfoView.ISubInfoView
		{
			// Token: 0x17005577 RID: 21879
			// (get) Token: 0x06024397 RID: 148375 RVA: 0x000C37F8 File Offset: 0x000C19F8
			// (set) Token: 0x06024398 RID: 148376 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005577")]
			public bool isActive
			{
				[Token(Token = "0x6024397")]
				[Address(RVA = "0x1F19610", Offset = "0x1F18210", VA = "0x181F19610", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6024398")]
				[Address(RVA = "0x1F19640", Offset = "0x1F18240", VA = "0x181F19640")]
				set
				{
				}
			}

			// Token: 0x06024399 RID: 148377 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6024399")]
			[Address(RVA = "0x1F1E800", Offset = "0x1F1D400", VA = "0x181F1E800", Slot = "5")]
			public void Render(BattleInfoViewModel viewModel, bool isPrewarm)
			{
			}

			// Token: 0x0602439A RID: 148378 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602439A")]
			[Address(RVA = "0x1F1EB40", Offset = "0x1F1D740", VA = "0x181F1EB40")]
			private void _PlayFstarPopupSE()
			{
			}

			// Token: 0x040325E0 RID: 206304
			[Token(Token = "0x40325E0")]
			[FieldOffset(Offset = "0x0")]
			public RectTransform holder;

			// Token: 0x040325E1 RID: 206305
			[Token(Token = "0x40325E1")]
			[FieldOffset(Offset = "0x8")]
			public Text stageCode;

			// Token: 0x040325E2 RID: 206306
			[Token(Token = "0x40325E2")]
			[FieldOffset(Offset = "0x10")]
			public Text stageName;

			// Token: 0x040325E3 RID: 206307
			[Token(Token = "0x40325E3")]
			[FieldOffset(Offset = "0x18")]
			public BattleFinishRankGroup rankGroup;

			// Token: 0x040325E4 RID: 206308
			[Token(Token = "0x40325E4")]
			[FieldOffset(Offset = "0x20")]
			public GameObject fourStarRankGroup;

			// Token: 0x040325E5 RID: 206309
			[Token(Token = "0x40325E5")]
			[FieldOffset(Offset = "0x28")]
			public GameObject diffGrpEasy;

			// Token: 0x040325E6 RID: 206310
			[Token(Token = "0x40325E6")]
			[FieldOffset(Offset = "0x30")]
			public GameObject diffGrpNormal;

			// Token: 0x040325E7 RID: 206311
			[Token(Token = "0x40325E7")]
			[FieldOffset(Offset = "0x38")]
			public GameObject diffGrpHard;

			// Token: 0x040325E8 RID: 206312
			[Token(Token = "0x40325E8")]
			[FieldOffset(Offset = "0x40")]
			public GameObject multipleBattleStat;

			// Token: 0x040325E9 RID: 206313
			[Token(Token = "0x40325E9")]
			[FieldOffset(Offset = "0x48")]
			public Text multipleBattleStatText;
		}

		// Token: 0x02006213 RID: 25107
		[Token(Token = "0x2006213")]
		[Serializable]
		public struct CampaignInfoView : BattleFinishInfoView.ISubInfoView
		{
			// Token: 0x17005578 RID: 21880
			// (get) Token: 0x0602439B RID: 148379 RVA: 0x000C3810 File Offset: 0x000C1A10
			// (set) Token: 0x0602439C RID: 148380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17005578")]
			public bool isActive
			{
				[Token(Token = "0x602439B")]
				[Address(RVA = "0x1F19610", Offset = "0x1F18210", VA = "0x181F19610", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x602439C")]
				[Address(RVA = "0x1F19640", Offset = "0x1F18240", VA = "0x181F19640")]
				set
				{
				}
			}

			// Token: 0x0602439D RID: 148381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602439D")]
			[Address(RVA = "0x1F19560", Offset = "0x1F18160", VA = "0x181F19560", Slot = "5")]
			public void Render(BattleInfoViewModel viewModel, bool isPrewarm)
			{
			}

			// Token: 0x040325EA RID: 206314
			[Token(Token = "0x40325EA")]
			[FieldOffset(Offset = "0x0")]
			public RectTransform holder;

			// Token: 0x040325EB RID: 206315
			[Token(Token = "0x40325EB")]
			[FieldOffset(Offset = "0x8")]
			public Text stageCode;

			// Token: 0x040325EC RID: 206316
			[Token(Token = "0x40325EC")]
			[FieldOffset(Offset = "0x10")]
			public Text stageName;
		}
	}
}
