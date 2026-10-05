using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C3D RID: 11325
	[Token(Token = "0x2002C3D")]
	public class RacingAddBuffWhenCollision : RacingBaseEventListener, IBuffSource, IEffectSource
	{
		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x06013200 RID: 78336 RVA: 0x00074A30 File Offset: 0x00072C30
		[Token(Token = "0x17002A04")]
		private bool onlyAddOnce
		{
			[Token(Token = "0x6013200")]
			[Address(RVA = "0xB22800", Offset = "0xB21400", VA = "0x180B22800")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x06013201 RID: 78337 RVA: 0x00074A48 File Offset: 0x00072C48
		[Token(Token = "0x17002A05")]
		protected override RacingEnemy.RacingEvent racingEvent
		{
			[Token(Token = "0x6013201")]
			[Address(RVA = "0xB22860", Offset = "0xB21460", VA = "0x180B22860", Slot = "16")]
			get
			{
				return RacingEnemy.RacingEvent.ON_SWITCH_RACING_MODE;
			}
		}

		// Token: 0x06013202 RID: 78338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013202")]
		[Address(RVA = "0xB22110", Offset = "0xB20D10", VA = "0x180B22110", Slot = "20")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06013203 RID: 78339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013203")]
		[Address(RVA = "0xB221A0", Offset = "0xB20DA0", VA = "0x180B221A0", Slot = "21")]
		public void GatherEffects(List<string> results)
		{
		}

		// Token: 0x06013204 RID: 78340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013204")]
		[Address(RVA = "0xB22240", Offset = "0xB20E40", VA = "0x180B22240", Slot = "17")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06013205 RID: 78341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013205")]
		[Address(RVA = "0xB22370", Offset = "0xB20F70", VA = "0x180B22370", Slot = "18")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06013206 RID: 78342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013206")]
		[Address(RVA = "0xB223E0", Offset = "0xB20FE0", VA = "0x180B223E0", Slot = "19")]
		protected override void OnRacingEvent(object arg)
		{
		}

		// Token: 0x06013207 RID: 78343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013207")]
		[Address(RVA = "0xB22650", Offset = "0xB21250", VA = "0x180B22650")]
		private void _ClearEffect()
		{
		}

		// Token: 0x06013208 RID: 78344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013208")]
		[Address(RVA = "0xB22730", Offset = "0xB21330", VA = "0x180B22730")]
		public RacingAddBuffWhenCollision()
		{
		}

		// Token: 0x06013209 RID: 78345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013209")]
		[Address(RVA = "0xB225D0", Offset = "0xB211D0", VA = "0x180B225D0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x0601320A RID: 78346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601320A")]
		[Address(RVA = "0xB225E0", Offset = "0xB211E0", VA = "0x180B225E0")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x0601320B RID: 78347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601320B")]
		[Address(RVA = "0xB225F0", Offset = "0xB211F0", VA = "0x180B225F0")]
		private void <>xLuaBaseProxy_OnRacingEvent(object P0)
		{
		}

		// Token: 0x0401599D RID: 88477
		[Token(Token = "0x401599D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x0401599E RID: 88478
		[Token(Token = "0x401599E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _onlyAddOnce;

		// Token: 0x0401599F RID: 88479
		[Token(Token = "0x401599F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Inspect("onlyAddOnce")]
		private string _readyEffect;

		// Token: 0x040159A0 RID: 88480
		[Token(Token = "0x40159A0")]
		[FieldOffset(Offset = "0x48")]
		private bool m_buffAdded;

		// Token: 0x040159A1 RID: 88481
		[Token(Token = "0x40159A1")]
		[FieldOffset(Offset = "0x50")]
		private ObjectPtr<Effect> m_readyEffect;

		// Token: 0x040159A2 RID: 88482
		[Token(Token = "0x40159A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onlyAddOnce;

		// Token: 0x040159A3 RID: 88483
		[Token(Token = "0x40159A3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_racingEvent;

		// Token: 0x040159A4 RID: 88484
		[Token(Token = "0x40159A4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x040159A5 RID: 88485
		[Token(Token = "0x40159A5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040159A6 RID: 88486
		[Token(Token = "0x40159A6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040159A7 RID: 88487
		[Token(Token = "0x40159A7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040159A8 RID: 88488
		[Token(Token = "0x40159A8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRacingEvent;

		// Token: 0x040159A9 RID: 88489
		[Token(Token = "0x40159A9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ClearEffect;

		// Token: 0x040159AA RID: 88490
		[Token(Token = "0x40159AA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
