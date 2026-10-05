using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL01
{
	// Token: 0x0200465A RID: 18010
	[Token(Token = "0x200465A")]
	public class Rl01OuterBuffSkillTreeView : DataBinder<RoguelikeTopicOuterBuffSkillTreeProperty>
	{
		// Token: 0x17004121 RID: 16673
		// (get) Token: 0x0601B59B RID: 112027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004121")]
		public List<Rl01OuterBuffSkillTreeNode> nodes
		{
			[Token(Token = "0x601B59B")]
			[Address(RVA = "0x14AD670", Offset = "0x14AC270", VA = "0x1814AD670")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004122 RID: 16674
		// (get) Token: 0x0601B59C RID: 112028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004122")]
		public List<Sprite> progressNodeProgressBarSpriteList
		{
			[Token(Token = "0x601B59C")]
			[Address(RVA = "0x14AD730", Offset = "0x14AC330", VA = "0x1814AD730")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004123 RID: 16675
		// (get) Token: 0x0601B59D RID: 112029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004123")]
		public List<Sprite> mainNodeStageNumSpriteList
		{
			[Token(Token = "0x601B59D")]
			[Address(RVA = "0x14AD610", Offset = "0x14AC210", VA = "0x1814AD610")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004124 RID: 16676
		// (get) Token: 0x0601B59E RID: 112030 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B59F RID: 112031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004124")]
		private Rl01TopicOuterBuffController bindTopicController
		{
			[Token(Token = "0x601B59E")]
			[Address(RVA = "0x14AD5B0", Offset = "0x14AC1B0", VA = "0x1814AD5B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B59F")]
			[Address(RVA = "0x14AD790", Offset = "0x14AC390", VA = "0x1814AD790")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17004125 RID: 16677
		// (get) Token: 0x0601B5A0 RID: 112032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004125")]
		public RectTransform panel
		{
			[Token(Token = "0x601B5A0")]
			[Address(RVA = "0x14AD6D0", Offset = "0x14AC2D0", VA = "0x1814AD6D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B5A1 RID: 112033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5A1")]
		[Address(RVA = "0x14ACCB0", Offset = "0x14AB8B0", VA = "0x1814ACCB0")]
		public void Init(Rl01TopicOuterBuffController topicController)
		{
		}

		// Token: 0x0601B5A2 RID: 112034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5A2")]
		[Address(RVA = "0x14ACF20", Offset = "0x14ABB20", VA = "0x1814ACF20", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicOuterBuffSkillTreeProperty property)
		{
		}

		// Token: 0x0601B5A3 RID: 112035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5A3")]
		[Address(RVA = "0x14AD0E0", Offset = "0x14ABCE0", VA = "0x1814AD0E0")]
		public void ResetView()
		{
		}

		// Token: 0x0601B5A4 RID: 112036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5A4")]
		[Address(RVA = "0x14AD1D0", Offset = "0x14ABDD0", VA = "0x1814AD1D0")]
		public void ShowView()
		{
		}

		// Token: 0x0601B5A5 RID: 112037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B5A5")]
		[Address(RVA = "0x14AD4A0", Offset = "0x14AC0A0", VA = "0x1814AD4A0")]
		public Rl01OuterBuffSkillTreeView()
		{
		}

		// Token: 0x04023566 RID: 144742
		[Token(Token = "0x4023566")]
		private const float FOCUS_DURATION = 0.5f;

		// Token: 0x04023567 RID: 144743
		[Token(Token = "0x4023567")]
		private const float FOCUS_START_DELTA = 1000f;

		// Token: 0x04023568 RID: 144744
		[Token(Token = "0x4023568")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Sprite> _mainNodeStageNumSpriteList;

		// Token: 0x04023569 RID: 144745
		[Token(Token = "0x4023569")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Sprite> _progressNodeProgressBarSpriteList;

		// Token: 0x0402356A RID: 144746
		[Token(Token = "0x402356A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _panel;

		// Token: 0x0402356B RID: 144747
		[Token(Token = "0x402356B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Rl01OuterBuffSkillTreeNode> _nodes;

		// Token: 0x0402356C RID: 144748
		[Token(Token = "0x402356C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0402356D RID: 144749
		[Token(Token = "0x402356D")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<string, Rl01OuterBuffSkillTreeNode> m_nodesDict;

		// Token: 0x0402356E RID: 144750
		[Token(Token = "0x402356E")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_focusTween;

		// Token: 0x0402356F RID: 144751
		[Token(Token = "0x402356F")]
		[FieldOffset(Offset = "0x58")]
		private string m_cachedFocusItem;

		// Token: 0x04023571 RID: 144753
		[Token(Token = "0x4023571")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_nodes;

		// Token: 0x04023572 RID: 144754
		[Token(Token = "0x4023572")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_progressNodeProgressBarSpriteList;

		// Token: 0x04023573 RID: 144755
		[Token(Token = "0x4023573")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_mainNodeStageNumSpriteList;

		// Token: 0x04023574 RID: 144756
		[Token(Token = "0x4023574")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_bindTopicController;

		// Token: 0x04023575 RID: 144757
		[Token(Token = "0x4023575")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_bindTopicController;

		// Token: 0x04023576 RID: 144758
		[Token(Token = "0x4023576")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_panel;

		// Token: 0x04023577 RID: 144759
		[Token(Token = "0x4023577")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04023578 RID: 144760
		[Token(Token = "0x4023578")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04023579 RID: 144761
		[Token(Token = "0x4023579")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_ResetView;

		// Token: 0x0402357A RID: 144762
		[Token(Token = "0x402357A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ShowView;

		// Token: 0x0402357B RID: 144763
		[Token(Token = "0x402357B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
