using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005566 RID: 21862
	[Token(Token = "0x2005566")]
	public class RL05TopicChallengeGroup : RoguelikeTopicChallengeGroup
	{
		// Token: 0x17004B69 RID: 19305
		// (get) Token: 0x06020223 RID: 131619 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020224 RID: 131620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004B69")]
		public override Action<float> eventOnGroupSwitch
		{
			[Token(Token = "0x6020223")]
			[Address(RVA = "0x1A37390", Offset = "0x1A35F90", VA = "0x181A37390", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020224")]
			[Address(RVA = "0x1A373F0", Offset = "0x1A35FF0", VA = "0x181A373F0", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020225 RID: 131621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020225")]
		[Address(RVA = "0x1A370B0", Offset = "0x1A35CB0", VA = "0x181A370B0", Slot = "4")]
		public override void Render(RoguelikeTopicChallengeModeViewModel challengeModeViewModel, RoguelikeTopicChallengePluginContext pluginContext)
		{
		}

		// Token: 0x06020226 RID: 131622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020226")]
		[Address(RVA = "0x1A36FE0", Offset = "0x1A35BE0", VA = "0x181A36FE0")]
		public void OnGroupSwitchClick()
		{
		}

		// Token: 0x06020227 RID: 131623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020227")]
		[Address(RVA = "0x1A37290", Offset = "0x1A35E90", VA = "0x181A37290")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020228 RID: 131624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020228")]
		[Address(RVA = "0x1A37300", Offset = "0x1A35F00", VA = "0x181A37300")]
		public RL05TopicChallengeGroup()
		{
		}

		// Token: 0x06020229 RID: 131625 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020229")]
		[Address(RVA = "0x1A37270", Offset = "0x1A35E70", VA = "0x181A37270")]
		private Action<float> <>xLuaBaseProxy_get_eventOnGroupSwitch()
		{
			return null;
		}

		// Token: 0x0602022A RID: 131626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602022A")]
		[Address(RVA = "0x1A37280", Offset = "0x1A35E80", VA = "0x181A37280")]
		private void <>xLuaBaseProxy_set_eventOnGroupSwitch(Action<float> P0)
		{
		}

		// Token: 0x0402B682 RID: 177794
		[Token(Token = "0x402B682")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0402B683 RID: 177795
		[Token(Token = "0x402B683")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgGroupName;

		// Token: 0x0402B685 RID: 177797
		[Token(Token = "0x402B685")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0402B686 RID: 177798
		[Token(Token = "0x402B686")]
		[FieldOffset(Offset = "0x3C")]
		private int m_cachedGroupId;

		// Token: 0x0402B687 RID: 177799
		[Token(Token = "0x402B687")]
		[FieldOffset(Offset = "0x40")]
		private readonly float PER_PAGE_SWITCH_DUR;

		// Token: 0x0402B688 RID: 177800
		[Token(Token = "0x402B688")]
		[FieldOffset(Offset = "0x48")]
		private readonly string GROUP_NAME_PREFIX;

		// Token: 0x0402B689 RID: 177801
		[Token(Token = "0x402B689")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventOnGroupSwitch;

		// Token: 0x0402B68A RID: 177802
		[Token(Token = "0x402B68A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_eventOnGroupSwitch;

		// Token: 0x0402B68B RID: 177803
		[Token(Token = "0x402B68B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B68C RID: 177804
		[Token(Token = "0x402B68C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGroupSwitchClick;

		// Token: 0x0402B68D RID: 177805
		[Token(Token = "0x402B68D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402B68E RID: 177806
		[Token(Token = "0x402B68E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
