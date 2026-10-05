using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AD3 RID: 10963
	[Token(Token = "0x2002AD3")]
	public class PausableActiveBuffAbility : ActiveBuffAbility, IPausableAbility
	{
		// Token: 0x17002812 RID: 10258
		// (get) Token: 0x06012449 RID: 74825 RVA: 0x0006FED0 File Offset: 0x0006E0D0
		// (set) Token: 0x0601244A RID: 74826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002812")]
		public bool atPauseState
		{
			[Token(Token = "0x6012449")]
			[Address(RVA = "0xA59760", Offset = "0xA58360", VA = "0x180A59760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601244A")]
			[Address(RVA = "0xA597C0", Offset = "0xA583C0", VA = "0x180A597C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0601244B RID: 74827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601244B")]
		[Address(RVA = "0xA59170", Offset = "0xA57D70", VA = "0x180A59170", Slot = "99")]
		public void Pause()
		{
		}

		// Token: 0x0601244C RID: 74828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601244C")]
		[Address(RVA = "0xA59330", Offset = "0xA57F30", VA = "0x180A59330", Slot = "100")]
		public void Recover()
		{
		}

		// Token: 0x0601244D RID: 74829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601244D")]
		[Address(RVA = "0xA58FE0", Offset = "0xA57BE0", VA = "0x180A58FE0", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601244E RID: 74830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601244E")]
		[Address(RVA = "0xA593F0", Offset = "0xA57FF0", VA = "0x180A593F0", Slot = "39")]
		public override void StopAffect()
		{
		}

		// Token: 0x0601244F RID: 74831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601244F")]
		[Address(RVA = "0xA59560", Offset = "0xA58160", VA = "0x180A59560")]
		private void _SpawnOverrideBuff()
		{
		}

		// Token: 0x06012450 RID: 74832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012450")]
		[Address(RVA = "0xA59470", Offset = "0xA58070", VA = "0x180A59470")]
		private void _RemoveOverrideBuff()
		{
		}

		// Token: 0x06012451 RID: 74833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012451")]
		[Address(RVA = "0xA59680", Offset = "0xA58280", VA = "0x180A59680")]
		public PausableActiveBuffAbility()
		{
		}

		// Token: 0x06012452 RID: 74834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012452")]
		[Address(RVA = "0xA4CBC0", Offset = "0xA4B7C0", VA = "0x180A4CBC0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06012453 RID: 74835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012453")]
		[Address(RVA = "0xA59460", Offset = "0xA58060", VA = "0x180A59460")]
		private void <>xLuaBaseProxy_StopAffect()
		{
		}

		// Token: 0x04014A82 RID: 84610
		[Token(Token = "0x4014A82")]
		[FieldOffset(Offset = "0x168")]
		[SerializeField]
		private BuffData[] _overrideBuffData;

		// Token: 0x04014A83 RID: 84611
		[Token(Token = "0x4014A83")]
		[FieldOffset(Offset = "0x170")]
		private List<uint> m_overrideBuffIds;

		// Token: 0x04014A85 RID: 84613
		[Token(Token = "0x4014A85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_atPauseState;

		// Token: 0x04014A86 RID: 84614
		[Token(Token = "0x4014A86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_atPauseState;

		// Token: 0x04014A87 RID: 84615
		[Token(Token = "0x4014A87")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Pause;

		// Token: 0x04014A88 RID: 84616
		[Token(Token = "0x4014A88")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Recover;

		// Token: 0x04014A89 RID: 84617
		[Token(Token = "0x4014A89")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04014A8A RID: 84618
		[Token(Token = "0x4014A8A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StopAffect;

		// Token: 0x04014A8B RID: 84619
		[Token(Token = "0x4014A8B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SpawnOverrideBuff;

		// Token: 0x04014A8C RID: 84620
		[Token(Token = "0x4014A8C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RemoveOverrideBuff;

		// Token: 0x04014A8D RID: 84621
		[Token(Token = "0x4014A8D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
