using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BFD RID: 11261
	[Token(Token = "0x2002BFD")]
	public class AirSupportLockEffectBehaviour : AbstractEffectEmitter
	{
		// Token: 0x0601304D RID: 77901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601304D")]
		[Address(RVA = "0xADB150", Offset = "0xAD9D50", VA = "0x180ADB150", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0601304E RID: 77902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601304E")]
		[Address(RVA = "0xADAE10", Offset = "0xAD9A10", VA = "0x180ADAE10", Slot = "13")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601304F RID: 77903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601304F")]
		[Address(RVA = "0xADAD70", Offset = "0xAD9970", VA = "0x180ADAD70", Slot = "17")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06013050 RID: 77904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013050")]
		[Address(RVA = "0xADB330", Offset = "0xAD9F30", VA = "0x180ADB330")]
		private void _FinishEffect(object arg)
		{
		}

		// Token: 0x06013051 RID: 77905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013051")]
		[Address(RVA = "0xADB400", Offset = "0xADA000", VA = "0x180ADB400")]
		public AirSupportLockEffectBehaviour()
		{
		}

		// Token: 0x06013052 RID: 77906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013052")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06013053 RID: 77907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013053")]
		[Address(RVA = "0xADA600", Offset = "0xAD9200", VA = "0x180ADA600")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040157BC RID: 87996
		[Token(Token = "0x40157BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("LockEffect")]
		private string _tileEffect;

		// Token: 0x040157BD RID: 87997
		[Token(Token = "0x40157BD")]
		[FieldOffset(Offset = "0x28")]
		private bool m_effectCreated;

		// Token: 0x040157BE RID: 87998
		[Token(Token = "0x40157BE")]
		[FieldOffset(Offset = "0x30")]
		private Effect m_tileEffect;

		// Token: 0x040157BF RID: 87999
		[Token(Token = "0x40157BF")]
		[FieldOffset(Offset = "0x38")]
		private ObjectPtr<Enemy> m_ownerEnemy;

		// Token: 0x040157C0 RID: 88000
		[Token(Token = "0x40157C0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040157C1 RID: 88001
		[Token(Token = "0x40157C1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040157C2 RID: 88002
		[Token(Token = "0x40157C2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040157C3 RID: 88003
		[Token(Token = "0x40157C3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__FinishEffect;

		// Token: 0x040157C4 RID: 88004
		[Token(Token = "0x40157C4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
