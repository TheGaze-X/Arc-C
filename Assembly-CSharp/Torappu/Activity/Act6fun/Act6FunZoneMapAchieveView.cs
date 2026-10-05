using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act6fun
{
	// Token: 0x020071C3 RID: 29123
	[Token(Token = "0x20071C3")]
	public class Act6FunZoneMapAchieveView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170061DE RID: 25054
		// (get) Token: 0x06029544 RID: 169284 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06029545 RID: 169285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170061DE")]
		public Action<string> onClaimReward
		{
			[Token(Token = "0x6029544")]
			[Address(RVA = "0x24B2D80", Offset = "0x24B1980", VA = "0x1824B2D80")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6029545")]
			[Address(RVA = "0x24B2DE0", Offset = "0x24B19E0", VA = "0x1824B2DE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06029546 RID: 169286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029546")]
		[Address(RVA = "0x24B2900", Offset = "0x24B1500", VA = "0x1824B2900")]
		public void Render(Act6FunZoneMapAchievePluginViewModel viewModel)
		{
		}

		// Token: 0x06029547 RID: 169287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029547")]
		[Address(RVA = "0x24B2B50", Offset = "0x24B1750", VA = "0x1824B2B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029548 RID: 169288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029548")]
		[Address(RVA = "0x24B2D20", Offset = "0x24B1920", VA = "0x1824B2D20")]
		public Act6FunZoneMapAchieveView()
		{
		}

		// Token: 0x0403B05F RID: 241759
		[Token(Token = "0x403B05F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _curAchieveCount;

		// Token: 0x0403B060 RID: 241760
		[Token(Token = "0x403B060")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _totalAchieveCount;

		// Token: 0x0403B061 RID: 241761
		[Token(Token = "0x403B061")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _rewardListContent;

		// Token: 0x0403B062 RID: 241762
		[Token(Token = "0x403B062")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SimpleLayoutContent _progressListContent;

		// Token: 0x0403B064 RID: 241764
		[Token(Token = "0x403B064")]
		[FieldOffset(Offset = "0x40")]
		private bool m_hasInited;

		// Token: 0x0403B065 RID: 241765
		[Token(Token = "0x403B065")]
		[FieldOffset(Offset = "0x48")]
		private Act6FunZoneMapAchievePluginViewModel m_viewModel;

		// Token: 0x0403B066 RID: 241766
		[Token(Token = "0x403B066")]
		[FieldOffset(Offset = "0x50")]
		private Act6FunZoneMapAchieveView.RewardListAdapter m_rewardListAdapter;

		// Token: 0x0403B067 RID: 241767
		[Token(Token = "0x403B067")]
		[FieldOffset(Offset = "0x58")]
		private Act6FunZoneMapAchieveView.ProgressListAdapter m_progressListAdapter;

		// Token: 0x0403B068 RID: 241768
		[Token(Token = "0x403B068")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClaimReward;

		// Token: 0x0403B069 RID: 241769
		[Token(Token = "0x403B069")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClaimReward;

		// Token: 0x0403B06A RID: 241770
		[Token(Token = "0x403B06A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403B06B RID: 241771
		[Token(Token = "0x403B06B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B06C RID: 241772
		[Token(Token = "0x403B06C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020071C4 RID: 29124
		[Token(Token = "0x20071C4")]
		private class RewardListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06029549 RID: 169289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029549")]
			[Address(RVA = "0x24BF1E0", Offset = "0x24BDDE0", VA = "0x1824BF1E0")]
			public RewardListAdapter(Act6FunZoneMapAchieveView clousre)
			{
			}

			// Token: 0x170061DF RID: 25055
			// (get) Token: 0x0602954A RID: 169290 RVA: 0x000D5588 File Offset: 0x000D3788
			[Token(Token = "0x170061DF")]
			public override int count
			{
				[Token(Token = "0x602954A")]
				[Address(RVA = "0x24BF260", Offset = "0x24BDE60", VA = "0x1824BF260", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602954B RID: 169291 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602954B")]
			[Address(RVA = "0x24BEF50", Offset = "0x24BDB50", VA = "0x1824BEF50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B06D RID: 241773
			[Token(Token = "0x403B06D")]
			[FieldOffset(Offset = "0x20")]
			private Act6FunZoneMapAchieveView m_closure;

			// Token: 0x0403B06E RID: 241774
			[Token(Token = "0x403B06E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B06F RID: 241775
			[Token(Token = "0x403B06F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B070 RID: 241776
			[Token(Token = "0x403B070")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020071C5 RID: 29125
		[Token(Token = "0x20071C5")]
		private class ProgressListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602954C RID: 169292 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602954C")]
			[Address(RVA = "0x24BEDE0", Offset = "0x24BD9E0", VA = "0x1824BEDE0")]
			public ProgressListAdapter(Act6FunZoneMapAchieveView clousre)
			{
			}

			// Token: 0x170061E0 RID: 25056
			// (get) Token: 0x0602954D RID: 169293 RVA: 0x000D55A0 File Offset: 0x000D37A0
			[Token(Token = "0x170061E0")]
			public override int count
			{
				[Token(Token = "0x602954D")]
				[Address(RVA = "0x24BEE60", Offset = "0x24BDA60", VA = "0x1824BEE60", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602954E RID: 169294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602954E")]
			[Address(RVA = "0x24BEB50", Offset = "0x24BD750", VA = "0x1824BEB50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403B071 RID: 241777
			[Token(Token = "0x403B071")]
			[FieldOffset(Offset = "0x20")]
			private Act6FunZoneMapAchieveView m_closure;

			// Token: 0x0403B072 RID: 241778
			[Token(Token = "0x403B072")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403B073 RID: 241779
			[Token(Token = "0x403B073")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403B074 RID: 241780
			[Token(Token = "0x403B074")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
