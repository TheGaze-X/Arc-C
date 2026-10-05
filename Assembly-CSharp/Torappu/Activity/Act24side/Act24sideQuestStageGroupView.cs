using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x02007601 RID: 30209
	[Token(Token = "0x2007601")]
	public class Act24sideQuestStageGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A87C RID: 174204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A87C")]
		[Address(RVA = "0x262FF50", Offset = "0x262EB50", VA = "0x18262FF50")]
		public void Render(Act24sideQuestStageGroupModel groupModel, string selectStageId)
		{
		}

		// Token: 0x0602A87D RID: 174205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A87D")]
		[Address(RVA = "0x2630090", Offset = "0x262EC90", VA = "0x182630090")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A87E RID: 174206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A87E")]
		[Address(RVA = "0x2630260", Offset = "0x262EE60", VA = "0x182630260")]
		public Act24sideQuestStageGroupView()
		{
		}

		// Token: 0x0403D398 RID: 250776
		[Token(Token = "0x403D398")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _questList;

		// Token: 0x0403D399 RID: 250777
		[Token(Token = "0x403D399")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _rankList;

		// Token: 0x0403D39A RID: 250778
		[Token(Token = "0x403D39A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _groupInfoToggle;

		// Token: 0x0403D39B RID: 250779
		[Token(Token = "0x403D39B")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x0403D39C RID: 250780
		[Token(Token = "0x403D39C")]
		[FieldOffset(Offset = "0x38")]
		private Act24sideQuestStageGroupView.QuestListAdapter m_questListAdapter;

		// Token: 0x0403D39D RID: 250781
		[Token(Token = "0x403D39D")]
		[FieldOffset(Offset = "0x40")]
		private Act24sideQuestStageGroupView.RankListAdapter m_rankListAdapter;

		// Token: 0x0403D39E RID: 250782
		[Token(Token = "0x403D39E")]
		[FieldOffset(Offset = "0x48")]
		private Act24sideQuestStageGroupModel m_groupModel;

		// Token: 0x0403D39F RID: 250783
		[Token(Token = "0x403D39F")]
		[FieldOffset(Offset = "0x50")]
		private string m_selectStageId;

		// Token: 0x0403D3A0 RID: 250784
		[Token(Token = "0x403D3A0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403D3A1 RID: 250785
		[Token(Token = "0x403D3A1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403D3A2 RID: 250786
		[Token(Token = "0x403D3A2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007602 RID: 30210
		[Token(Token = "0x2007602")]
		private class QuestListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A87F RID: 174207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A87F")]
			[Address(RVA = "0x26349B0", Offset = "0x26335B0", VA = "0x1826349B0")]
			public QuestListAdapter(Act24sideQuestStageGroupView closure)
			{
			}

			// Token: 0x17006402 RID: 25602
			// (get) Token: 0x0602A880 RID: 174208 RVA: 0x000D8D80 File Offset: 0x000D6F80
			[Token(Token = "0x17006402")]
			public override int count
			{
				[Token(Token = "0x602A880")]
				[Address(RVA = "0x2634A30", Offset = "0x2633630", VA = "0x182634A30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A881 RID: 174209 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A881")]
			[Address(RVA = "0x2634750", Offset = "0x2633350", VA = "0x182634750", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403D3A3 RID: 250787
			[Token(Token = "0x403D3A3")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideQuestStageGroupView m_closure;

			// Token: 0x0403D3A4 RID: 250788
			[Token(Token = "0x403D3A4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D3A5 RID: 250789
			[Token(Token = "0x403D3A5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D3A6 RID: 250790
			[Token(Token = "0x403D3A6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02007603 RID: 30211
		[Token(Token = "0x2007603")]
		private class RankListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0602A882 RID: 174210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A882")]
			[Address(RVA = "0x2634BD0", Offset = "0x26337D0", VA = "0x182634BD0")]
			public RankListAdapter(Act24sideQuestStageGroupView closure)
			{
			}

			// Token: 0x17006403 RID: 25603
			// (get) Token: 0x0602A883 RID: 174211 RVA: 0x000D8D98 File Offset: 0x000D6F98
			[Token(Token = "0x17006403")]
			public override int count
			{
				[Token(Token = "0x602A883")]
				[Address(RVA = "0x2634C50", Offset = "0x2633850", VA = "0x182634C50", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602A884 RID: 174212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602A884")]
			[Address(RVA = "0x2634AD0", Offset = "0x26336D0", VA = "0x182634AD0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403D3A7 RID: 250791
			[Token(Token = "0x403D3A7")]
			[FieldOffset(Offset = "0x20")]
			private Act24sideQuestStageGroupView m_closure;

			// Token: 0x0403D3A8 RID: 250792
			[Token(Token = "0x403D3A8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403D3A9 RID: 250793
			[Token(Token = "0x403D3A9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403D3AA RID: 250794
			[Token(Token = "0x403D3AA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
