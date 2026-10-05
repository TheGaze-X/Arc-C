using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI.RoguelikeTopic;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x02005686 RID: 22150
	[Token(Token = "0x2005686")]
	public class RL04TopicChallengeGroup : RoguelikeTopicChallengeGroup
	{
		// Token: 0x17004C25 RID: 19493
		// (get) Token: 0x060207ED RID: 133101 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060207EE RID: 133102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004C25")]
		public override Action<float> eventOnGroupSwitch
		{
			[Token(Token = "0x60207ED")]
			[Address(RVA = "0x1AA0F50", Offset = "0x1A9FB50", VA = "0x181AA0F50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60207EE")]
			[Address(RVA = "0x1AA0FB0", Offset = "0x1A9FBB0", VA = "0x181AA0FB0", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060207EF RID: 133103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207EF")]
		[Address(RVA = "0x1AA0C90", Offset = "0x1A9F890", VA = "0x181AA0C90", Slot = "4")]
		public override void Render(RoguelikeTopicChallengeModeViewModel challengeModeViewModel, RoguelikeTopicChallengePluginContext pluginContext)
		{
		}

		// Token: 0x060207F0 RID: 133104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207F0")]
		[Address(RVA = "0x1AA0BC0", Offset = "0x1A9F7C0", VA = "0x181AA0BC0")]
		public void OnGroupSwitchClick()
		{
		}

		// Token: 0x060207F1 RID: 133105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207F1")]
		[Address(RVA = "0x1AA0E50", Offset = "0x1A9FA50", VA = "0x181AA0E50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060207F2 RID: 133106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207F2")]
		[Address(RVA = "0x1AA0EC0", Offset = "0x1A9FAC0", VA = "0x181AA0EC0")]
		public RL04TopicChallengeGroup()
		{
		}

		// Token: 0x060207F3 RID: 133107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60207F3")]
		[Address(RVA = "0x1A37270", Offset = "0x1A35E70", VA = "0x181A37270")]
		private Action<float> <>xLuaBaseProxy_get_eventOnGroupSwitch()
		{
			return null;
		}

		// Token: 0x060207F4 RID: 133108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60207F4")]
		[Address(RVA = "0x1A37280", Offset = "0x1A35E80", VA = "0x181A37280")]
		private void <>xLuaBaseProxy_set_eventOnGroupSwitch(Action<float> P0)
		{
		}

		// Token: 0x0402C095 RID: 180373
		[Token(Token = "0x402C095")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0402C096 RID: 180374
		[Token(Token = "0x402C096")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgGroupName;

		// Token: 0x0402C098 RID: 180376
		[Token(Token = "0x402C098")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0402C099 RID: 180377
		[Token(Token = "0x402C099")]
		[FieldOffset(Offset = "0x3C")]
		private int m_cachedGroupId;

		// Token: 0x0402C09A RID: 180378
		[Token(Token = "0x402C09A")]
		[FieldOffset(Offset = "0x40")]
		private readonly float PER_PAGE_SWITCH_DUR;

		// Token: 0x0402C09B RID: 180379
		[Token(Token = "0x402C09B")]
		[FieldOffset(Offset = "0x48")]
		private readonly string GROUP_NAME_PREFIX;

		// Token: 0x0402C09C RID: 180380
		[Token(Token = "0x402C09C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventOnGroupSwitch;

		// Token: 0x0402C09D RID: 180381
		[Token(Token = "0x402C09D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_eventOnGroupSwitch;

		// Token: 0x0402C09E RID: 180382
		[Token(Token = "0x402C09E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402C09F RID: 180383
		[Token(Token = "0x402C09F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnGroupSwitchClick;

		// Token: 0x0402C0A0 RID: 180384
		[Token(Token = "0x402C0A0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402C0A1 RID: 180385
		[Token(Token = "0x402C0A1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
