using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.Ending
{
	// Token: 0x02004683 RID: 18051
	[Token(Token = "0x2004683")]
	public class RoguelikeTopicEndingSPOperatorView : RoguelikeTopicEndingPageAnimatedView<RoguelikeTopicEndingSPOperatorViewModel>, ICompDialogCallBack
	{
		// Token: 0x17004144 RID: 16708
		// (get) Token: 0x0601B673 RID: 112243 RVA: 0x000A51C8 File Offset: 0x000A33C8
		[Token(Token = "0x17004144")]
		protected override UIAnimationLocation showAnimation
		{
			[Token(Token = "0x601B673")]
			[Address(RVA = "0x14BAB80", Offset = "0x14B9780", VA = "0x1814BAB80", Slot = "9")]
			get
			{
				return default(UIAnimationLocation);
			}
		}

		// Token: 0x17004145 RID: 16709
		// (get) Token: 0x0601B674 RID: 112244 RVA: 0x000A51E0 File Offset: 0x000A33E0
		[Token(Token = "0x17004145")]
		protected override UIAnimationLocation hideAnimation
		{
			[Token(Token = "0x601B674")]
			[Address(RVA = "0x14BAB00", Offset = "0x14B9700", VA = "0x1814BAB00", Slot = "10")]
			get
			{
				return default(UIAnimationLocation);
			}
		}

		// Token: 0x0601B675 RID: 112245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B675")]
		[Address(RVA = "0x14B9D20", Offset = "0x14B8920", VA = "0x1814B9D20", Slot = "8")]
		protected override void Render(RoguelikeTopicEndingSPOperatorViewModel viewModel)
		{
		}

		// Token: 0x0601B676 RID: 112246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B676")]
		[Address(RVA = "0x14BA2D0", Offset = "0x14B8ED0", VA = "0x1814BA2D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B677 RID: 112247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B677")]
		[Address(RVA = "0x14BA680", Offset = "0x14B9280", VA = "0x1814BA680")]
		private void _LoadIllust(int instId)
		{
		}

		// Token: 0x0601B678 RID: 112248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B678")]
		[Address(RVA = "0x14BA480", Offset = "0x14B9080", VA = "0x1814BA480")]
		private void _LoadButton(RoguelikeTopicEndingSPOperatorViewModel viewModel)
		{
		}

		// Token: 0x0601B679 RID: 112249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B679")]
		[Address(RVA = "0x14BA9B0", Offset = "0x14B95B0", VA = "0x1814BA9B0")]
		private void _UpdateButton()
		{
		}

		// Token: 0x0601B67A RID: 112250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B67A")]
		[Address(RVA = "0x14B9940", Offset = "0x14B8540", VA = "0x1814B9940")]
		public void EventOnNextClick()
		{
		}

		// Token: 0x0601B67B RID: 112251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B67B")]
		[Address(RVA = "0x14B9B00", Offset = "0x14B8700", VA = "0x1814B9B00")]
		public void EventOnToEvolveClick()
		{
		}

		// Token: 0x0601B67C RID: 112252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B67C")]
		[Address(RVA = "0x14B9A20", Offset = "0x14B8620", VA = "0x1814B9A20")]
		public void EventOnToCheckNodesClick()
		{
		}

		// Token: 0x0601B67D RID: 112253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B67D")]
		[Address(RVA = "0x14BA770", Offset = "0x14B9370", VA = "0x1814BA770")]
		private void _OpenLevelMaxDialog()
		{
		}

		// Token: 0x0601B67E RID: 112254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B67E")]
		[Address(RVA = "0x14B9BE0", Offset = "0x14B87E0", VA = "0x1814B9BE0", Slot = "11")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0601B67F RID: 112255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B67F")]
		[Address(RVA = "0x14BAA70", Offset = "0x14B9670", VA = "0x1814BAA70")]
		public RoguelikeTopicEndingSPOperatorView()
		{
		}

		// Token: 0x040236DD RID: 145117
		[Token(Token = "0x40236DD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _illustContainer;

		// Token: 0x040236DE RID: 145118
		[Token(Token = "0x40236DE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeTopicEndingSPOperatorGainExpView _gainExpView;

		// Token: 0x040236DF RID: 145119
		[Token(Token = "0x40236DF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _gainExpEffectHolder;

		// Token: 0x040236E0 RID: 145120
		[Token(Token = "0x40236E0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RoguelikeTopicEndingSPOperatorLevelView _levelView;

		// Token: 0x040236E1 RID: 145121
		[Token(Token = "0x40236E1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _infoItemContent;

		// Token: 0x040236E2 RID: 145122
		[Token(Token = "0x40236E2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _toNextButton;

		// Token: 0x040236E3 RID: 145123
		[Token(Token = "0x40236E3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _toEvolveButton;

		// Token: 0x040236E4 RID: 145124
		[Token(Token = "0x40236E4")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _toCheckNodeButton;

		// Token: 0x040236E5 RID: 145125
		[Token(Token = "0x40236E5")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _stillShowAnimation;

		// Token: 0x040236E6 RID: 145126
		[Token(Token = "0x40236E6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _changeShowAnimation;

		// Token: 0x040236E7 RID: 145127
		[Token(Token = "0x40236E7")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _hideAnimation;

		// Token: 0x040236E8 RID: 145128
		[Token(Token = "0x40236E8")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_hasInited;

		// Token: 0x040236E9 RID: 145129
		[Token(Token = "0x40236E9")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeTopicEndingSPOperatorView.InfoAdapter m_adapter;

		// Token: 0x040236EA RID: 145130
		[Token(Token = "0x40236EA")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_stillShow;

		// Token: 0x040236EB RID: 145131
		[Token(Token = "0x40236EB")]
		[FieldOffset(Offset = "0xB4")]
		private int m_instId;

		// Token: 0x040236EC RID: 145132
		[Token(Token = "0x40236EC")]
		[FieldOffset(Offset = "0xB8")]
		private string m_topicId;

		// Token: 0x040236ED RID: 145133
		[Token(Token = "0x40236ED")]
		[FieldOffset(Offset = "0xC0")]
		private string m_charId;

		// Token: 0x040236EE RID: 145134
		[Token(Token = "0x40236EE")]
		[FieldOffset(Offset = "0xC8")]
		private int m_levelBefore;

		// Token: 0x040236EF RID: 145135
		[Token(Token = "0x40236EF")]
		[FieldOffset(Offset = "0xCC")]
		private bool m_toMax;

		// Token: 0x040236F0 RID: 145136
		[Token(Token = "0x40236F0")]
		[FieldOffset(Offset = "0xCD")]
		private bool m_toEvolve;

		// Token: 0x040236F1 RID: 145137
		[Token(Token = "0x40236F1")]
		[FieldOffset(Offset = "0xCE")]
		private bool m_toCheckNodes;

		// Token: 0x040236F2 RID: 145138
		[Token(Token = "0x40236F2")]
		[FieldOffset(Offset = "0xD0")]
		private int m_loadedInstId;

		// Token: 0x040236F3 RID: 145139
		[Token(Token = "0x40236F3")]
		[FieldOffset(Offset = "0xD8")]
		private UICharacterIllust m_illustInstance;

		// Token: 0x040236F4 RID: 145140
		[Token(Token = "0x40236F4")]
		[FieldOffset(Offset = "0xE0")]
		private int m_maxLevelDialogInstId;

		// Token: 0x040236F5 RID: 145141
		[Token(Token = "0x40236F5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_showAnimation;

		// Token: 0x040236F6 RID: 145142
		[Token(Token = "0x40236F6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_hideAnimation;

		// Token: 0x040236F7 RID: 145143
		[Token(Token = "0x40236F7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040236F8 RID: 145144
		[Token(Token = "0x40236F8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040236F9 RID: 145145
		[Token(Token = "0x40236F9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__LoadIllust;

		// Token: 0x040236FA RID: 145146
		[Token(Token = "0x40236FA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadButton;

		// Token: 0x040236FB RID: 145147
		[Token(Token = "0x40236FB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateButton;

		// Token: 0x040236FC RID: 145148
		[Token(Token = "0x40236FC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnNextClick;

		// Token: 0x040236FD RID: 145149
		[Token(Token = "0x40236FD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnToEvolveClick;

		// Token: 0x040236FE RID: 145150
		[Token(Token = "0x40236FE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnToCheckNodesClick;

		// Token: 0x040236FF RID: 145151
		[Token(Token = "0x40236FF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OpenLevelMaxDialog;

		// Token: 0x04023700 RID: 145152
		[Token(Token = "0x4023700")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04023701 RID: 145153
		[Token(Token = "0x4023701")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004684 RID: 18052
		[Token(Token = "0x2004684")]
		private class InfoAdapter : SimpleLayoutAdapter
		{
			// Token: 0x17004146 RID: 16710
			// (get) Token: 0x0601B680 RID: 112256 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601B681 RID: 112257 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17004146")]
			public List<RoguelikeTopicEndingSPOperatorGrowInfoItemViewModel> items
			{
				[Token(Token = "0x601B680")]
				[Address(RVA = "0x14AB760", Offset = "0x14AA360", VA = "0x1814AB760")]
				[CompilerGenerated]
				private get
				{
					return null;
				}
				[Token(Token = "0x601B681")]
				[Address(RVA = "0x14AB7C0", Offset = "0x14AA3C0", VA = "0x1814AB7C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17004147 RID: 16711
			// (get) Token: 0x0601B682 RID: 112258 RVA: 0x000A51F8 File Offset: 0x000A33F8
			[Token(Token = "0x17004147")]
			public override int count
			{
				[Token(Token = "0x601B682")]
				[Address(RVA = "0x14AB6A0", Offset = "0x14AA2A0", VA = "0x1814AB6A0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B683 RID: 112259 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B683")]
			[Address(RVA = "0x14AB3B0", Offset = "0x14A9FB0", VA = "0x1814AB3B0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0601B684 RID: 112260 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B684")]
			[Address(RVA = "0x14AB640", Offset = "0x14AA240", VA = "0x1814AB640")]
			public InfoAdapter()
			{
			}

			// Token: 0x04023703 RID: 145155
			[Token(Token = "0x4023703")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_items;

			// Token: 0x04023704 RID: 145156
			[Token(Token = "0x4023704")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_items;

			// Token: 0x04023705 RID: 145157
			[Token(Token = "0x4023705")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04023706 RID: 145158
			[Token(Token = "0x4023706")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04023707 RID: 145159
			[Token(Token = "0x4023707")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
