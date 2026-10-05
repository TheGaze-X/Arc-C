using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005807 RID: 22535
	[Token(Token = "0x2005807")]
	public class RL03TopicChallengeGroup : RoguelikeTopicChallengeGroup
	{
		// Token: 0x17004D53 RID: 19795
		// (get) Token: 0x06020EF9 RID: 134905 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06020EFA RID: 134906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004D53")]
		public override Action<float> eventOnGroupSwitch
		{
			[Token(Token = "0x6020EF9")]
			[Address(RVA = "0x1B333C0", Offset = "0x1B31FC0", VA = "0x181B333C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6020EFA")]
			[Address(RVA = "0x1B33420", Offset = "0x1B32020", VA = "0x181B33420", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06020EFB RID: 134907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EFB")]
		[Address(RVA = "0x1B33100", Offset = "0x1B31D00", VA = "0x181B33100", Slot = "4")]
		public override void Render(RoguelikeTopicChallengeModeViewModel challengeModeViewModel, RoguelikeTopicChallengePluginContext pluginContext)
		{
		}

		// Token: 0x06020EFC RID: 134908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EFC")]
		[Address(RVA = "0x1B33030", Offset = "0x1B31C30", VA = "0x181B33030")]
		public void OnGroupSwitchClick()
		{
		}

		// Token: 0x06020EFD RID: 134909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EFD")]
		[Address(RVA = "0x1B332C0", Offset = "0x1B31EC0", VA = "0x181B332C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06020EFE RID: 134910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020EFE")]
		[Address(RVA = "0x1B33330", Offset = "0x1B31F30", VA = "0x181B33330")]
		public RL03TopicChallengeGroup()
		{
		}

		// Token: 0x06020EFF RID: 134911 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6020EFF")]
		[Address(RVA = "0x1A37270", Offset = "0x1A35E70", VA = "0x181A37270")]
		private Action<float> <>xLuaBaseProxy_get_eventOnGroupSwitch()
		{
			return null;
		}

		// Token: 0x06020F00 RID: 134912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020F00")]
		[Address(RVA = "0x1A37280", Offset = "0x1A35E80", VA = "0x181A37280")]
		private void <>xLuaBaseProxy_set_eventOnGroupSwitch(Action<float> P0)
		{
		}

		// Token: 0x0402CC89 RID: 183433
		[Token(Token = "0x402CC89")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0402CC8A RID: 183434
		[Token(Token = "0x402CC8A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgGroupName;

		// Token: 0x0402CC8C RID: 183436
		[Token(Token = "0x402CC8C")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0402CC8D RID: 183437
		[Token(Token = "0x402CC8D")]
		[FieldOffset(Offset = "0x3C")]
		private int m_cachedGroupId;

		// Token: 0x0402CC8E RID: 183438
		[Token(Token = "0x402CC8E")]
		[FieldOffset(Offset = "0x40")]
		private readonly float PER_PAGE_SWITCH_DUR;

		// Token: 0x0402CC8F RID: 183439
		[Token(Token = "0x402CC8F")]
		[FieldOffset(Offset = "0x48")]
		private readonly string GROUP_NAME_PREFIX;

		// Token: 0x0402CC90 RID: 183440
		[Token(Token = "0x402CC90")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventOnGroupSwitch;

		// Token: 0x0402CC91 RID: 183441
		[Token(Token = "0x402CC91")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_eventOnGroupSwitch;

		// Token: 0x0402CC92 RID: 183442
		[Token(Token = "0x402CC92")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402CC93 RID: 183443
		[Token(Token = "0x402CC93")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGroupSwitchClick;

		// Token: 0x0402CC94 RID: 183444
		[Token(Token = "0x402CC94")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402CC95 RID: 183445
		[Token(Token = "0x402CC95")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
