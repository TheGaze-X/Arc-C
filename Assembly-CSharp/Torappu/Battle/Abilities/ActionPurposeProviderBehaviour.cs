using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C0D RID: 11277
	[Token(Token = "0x2002C0D")]
	public class ActionPurposeProviderBehaviour : AbilityStandard.Behaviour
	{
		// Token: 0x170029F1 RID: 10737
		// (get) Token: 0x060130C2 RID: 78018 RVA: 0x00074760 File Offset: 0x00072960
		[Token(Token = "0x170029F1")]
		public ActionPurposeMask purposeMask
		{
			[Token(Token = "0x60130C2")]
			[Address(RVA = "0xB13810", Offset = "0xB12410", VA = "0x180B13810")]
			get
			{
				return ActionPurposeMask.NONE;
			}
		}

		// Token: 0x060130C3 RID: 78019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130C3")]
		[Address(RVA = "0xB13630", Offset = "0xB12230", VA = "0x180B13630", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060130C4 RID: 78020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130C4")]
		[Address(RVA = "0xB137A0", Offset = "0xB123A0", VA = "0x180B137A0")]
		public ActionPurposeProviderBehaviour()
		{
		}

		// Token: 0x060130C5 RID: 78021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130C5")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015823 RID: 88099
		[Token(Token = "0x4015823")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActionPurposeMask _purposeMask;

		// Token: 0x04015824 RID: 88100
		[Token(Token = "0x4015824")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private SideType _sideType;

		// Token: 0x04015825 RID: 88101
		[Token(Token = "0x4015825")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_purposeMask;

		// Token: 0x04015826 RID: 88102
		[Token(Token = "0x4015826")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015827 RID: 88103
		[Token(Token = "0x4015827")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002C0E RID: 11278
		[Token(Token = "0x2002C0E")]
		private class ActionPurposeProvider : Entity.IHitRangeProvider, IHotfixable
		{
			// Token: 0x060130C6 RID: 78022 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130C6")]
			[Address(RVA = "0xB13A70", Offset = "0xB12670", VA = "0x180B13A70")]
			public ActionPurposeProvider(ActionPurposeProviderBehaviour behaviour, SideType sideType)
			{
			}

			// Token: 0x170029F2 RID: 10738
			// (get) Token: 0x060130C7 RID: 78023 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170029F2")]
			public string providerId
			{
				[Token(Token = "0x60130C7")]
				[Address(RVA = "0xB13B00", Offset = "0xB12700", VA = "0x180B13B00", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x060130C8 RID: 78024 RVA: 0x00074778 File Offset: 0x00072978
			[Token(Token = "0x60130C8")]
			[Address(RVA = "0xB13870", Offset = "0xB12470", VA = "0x180B13870", Slot = "4")]
			public bool IsInHitRange(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x060130C9 RID: 78025 RVA: 0x00074790 File Offset: 0x00072990
			[Token(Token = "0x60130C9")]
			[Address(RVA = "0xB139E0", Offset = "0xB125E0", VA = "0x180B139E0", Slot = "5")]
			public bool IsTargetIn(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x04015828 RID: 88104
			[Token(Token = "0x4015828")]
			public const string HEAL_PURPOSE_PROVIDER = "HEAL_PURPOSE_PROVIDER";

			// Token: 0x04015829 RID: 88105
			[Token(Token = "0x4015829")]
			[FieldOffset(Offset = "0x10")]
			private ActionPurposeProviderBehaviour m_behaviour;

			// Token: 0x0401582A RID: 88106
			[Token(Token = "0x401582A")]
			[FieldOffset(Offset = "0x18")]
			private SideType m_sideType;

			// Token: 0x0401582B RID: 88107
			[Token(Token = "0x401582B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401582C RID: 88108
			[Token(Token = "0x401582C")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_providerId;

			// Token: 0x0401582D RID: 88109
			[Token(Token = "0x401582D")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsInHitRange;

			// Token: 0x0401582E RID: 88110
			[Token(Token = "0x401582E")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IsTargetIn;
		}
	}
}
