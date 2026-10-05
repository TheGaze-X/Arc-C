using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044DE RID: 17630
	[Token(Token = "0x20044DE")]
	public class RoguelikeTopicMonthSquadDetailView : DataBinder<RoguelikeTopicModeViewProperty>
	{
		// Token: 0x17003FE1 RID: 16353
		// (get) Token: 0x0601AEBC RID: 110268 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AEBD RID: 110269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FE1")]
		private RoguelikeTopicMonthSquadDetailState bindState
		{
			[Token(Token = "0x601AEBC")]
			[Address(RVA = "0x1411D60", Offset = "0x1410960", VA = "0x181411D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AEBD")]
			[Address(RVA = "0x1411DC0", Offset = "0x14109C0", VA = "0x181411DC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AEBE RID: 110270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEBE")]
		[Address(RVA = "0x14114B0", Offset = "0x14100B0", VA = "0x1814114B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601AEBF RID: 110271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEBF")]
		[Address(RVA = "0x1411300", Offset = "0x140FF00", VA = "0x181411300")]
		public void Init(RoguelikeTopicMonthSquadDetailState state, RoguelikeTopicMonthSquadStyle style)
		{
		}

		// Token: 0x0601AEC0 RID: 110272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEC0")]
		[Address(RVA = "0x1411410", Offset = "0x1410010", VA = "0x181411410", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601AEC1 RID: 110273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEC1")]
		[Address(RVA = "0x1411790", Offset = "0x1410390", VA = "0x181411790")]
		private void _Render(RoguelikeTopicModeViewModel model)
		{
		}

		// Token: 0x0601AEC2 RID: 110274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AEC2")]
		[Address(RVA = "0x1411CF0", Offset = "0x14108F0", VA = "0x181411CF0")]
		public RoguelikeTopicMonthSquadDetailView()
		{
		}

		// Token: 0x04022843 RID: 141379
		[Token(Token = "0x4022843")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _monthSquadTitle;

		// Token: 0x04022844 RID: 141380
		[Token(Token = "0x4022844")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _monthSquadDesc;

		// Token: 0x04022845 RID: 141381
		[Token(Token = "0x4022845")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _monthSquadSubDesc;

		// Token: 0x04022846 RID: 141382
		[Token(Token = "0x4022846")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textTarget;

		// Token: 0x04022847 RID: 141383
		[Token(Token = "0x4022847")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _iconTeam;

		// Token: 0x04022848 RID: 141384
		[Token(Token = "0x4022848")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _rewardViewHolder;

		// Token: 0x04022849 RID: 141385
		[Token(Token = "0x4022849")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RoguelikeTopicMonthSquadRewardView _rewardViewPrefab;

		// Token: 0x0402284B RID: 141387
		[Token(Token = "0x402284B")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeTopicMonthSquadStyle m_style;

		// Token: 0x0402284C RID: 141388
		[Token(Token = "0x402284C")]
		[FieldOffset(Offset = "0x68")]
		private RoguelikeTopicMonthSquadRewardView m_rewardView;

		// Token: 0x0402284D RID: 141389
		[Token(Token = "0x402284D")]
		[FieldOffset(Offset = "0x70")]
		private string m_cachedSquadId;

		// Token: 0x0402284E RID: 141390
		[Token(Token = "0x402284E")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0402284F RID: 141391
		[Token(Token = "0x402284F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindState;

		// Token: 0x04022850 RID: 141392
		[Token(Token = "0x4022850")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindState;

		// Token: 0x04022851 RID: 141393
		[Token(Token = "0x4022851")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022852 RID: 141394
		[Token(Token = "0x4022852")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022853 RID: 141395
		[Token(Token = "0x4022853")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04022854 RID: 141396
		[Token(Token = "0x4022854")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04022855 RID: 141397
		[Token(Token = "0x4022855")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
