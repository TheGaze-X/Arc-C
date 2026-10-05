using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL02
{
	// Token: 0x02005729 RID: 22313
	[Token(Token = "0x2005729")]
	public class RL02TopicChallengeGroup : RoguelikeTopicChallengeGroup
	{
		// Token: 0x17004CAF RID: 19631
		// (get) Token: 0x06020B43 RID: 133955 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020B44 RID: 133956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004CAF")]
		public override Action<float> eventOnGroupSwitch
		{
			[Token(Token = "0x6020B43")]
			[Address(RVA = "0x1B0C620", Offset = "0x1B0B220", VA = "0x181B0C620", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020B44")]
			[Address(RVA = "0x1B0C680", Offset = "0x1B0B280", VA = "0x181B0C680", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020B45 RID: 133957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B45")]
		[Address(RVA = "0x1B0C360", Offset = "0x1B0AF60", VA = "0x181B0C360", Slot = "4")]
		public override void Render(RoguelikeTopicChallengeModeViewModel challengeModeViewModel, RoguelikeTopicChallengePluginContext pluginContext)
		{
		}

		// Token: 0x06020B46 RID: 133958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B46")]
		[Address(RVA = "0x1B0C290", Offset = "0x1B0AE90", VA = "0x181B0C290")]
		public void OnGroupSwitchClick()
		{
		}

		// Token: 0x06020B47 RID: 133959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B47")]
		[Address(RVA = "0x1B0C520", Offset = "0x1B0B120", VA = "0x181B0C520")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020B48 RID: 133960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B48")]
		[Address(RVA = "0x1B0C590", Offset = "0x1B0B190", VA = "0x181B0C590")]
		public RL02TopicChallengeGroup()
		{
		}

		// Token: 0x06020B49 RID: 133961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020B49")]
		[Address(RVA = "0x1A37270", Offset = "0x1A35E70", VA = "0x181A37270")]
		private Action<float> <>xLuaBaseProxy_get_eventOnGroupSwitch()
		{
			return null;
		}

		// Token: 0x06020B4A RID: 133962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B4A")]
		[Address(RVA = "0x1A37280", Offset = "0x1A35E80", VA = "0x181A37280")]
		private void <>xLuaBaseProxy_set_eventOnGroupSwitch(Action<float> P0)
		{
		}

		// Token: 0x0402C640 RID: 181824
		[Token(Token = "0x402C640")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0402C641 RID: 181825
		[Token(Token = "0x402C641")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgGroupName;

		// Token: 0x0402C643 RID: 181827
		[Token(Token = "0x402C643")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0402C644 RID: 181828
		[Token(Token = "0x402C644")]
		[FieldOffset(Offset = "0x3C")]
		private int m_cachedGroupId;

		// Token: 0x0402C645 RID: 181829
		[Token(Token = "0x402C645")]
		[FieldOffset(Offset = "0x40")]
		private readonly float PER_PAGE_SWITCH_DUR;

		// Token: 0x0402C646 RID: 181830
		[Token(Token = "0x402C646")]
		[FieldOffset(Offset = "0x48")]
		private readonly string GROUP_NAME_PREFIX;

		// Token: 0x0402C647 RID: 181831
		[Token(Token = "0x402C647")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventOnGroupSwitch;

		// Token: 0x0402C648 RID: 181832
		[Token(Token = "0x402C648")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_eventOnGroupSwitch;

		// Token: 0x0402C649 RID: 181833
		[Token(Token = "0x402C649")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C64A RID: 181834
		[Token(Token = "0x402C64A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGroupSwitchClick;

		// Token: 0x0402C64B RID: 181835
		[Token(Token = "0x402C64B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C64C RID: 181836
		[Token(Token = "0x402C64C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
