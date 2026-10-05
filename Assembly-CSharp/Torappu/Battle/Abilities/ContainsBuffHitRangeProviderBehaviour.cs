using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C0F RID: 11279
	[Token(Token = "0x2002C0F")]
	public class ContainsBuffHitRangeProviderBehaviour : AbilityStandard.Behaviour
	{
		// Token: 0x170029F3 RID: 10739
		// (get) Token: 0x060130CA RID: 78026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170029F3")]
		public List<string> buffKeys
		{
			[Token(Token = "0x60130CA")]
			[Address(RVA = "0xB190E0", Offset = "0xB17CE0", VA = "0x180B190E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060130CB RID: 78027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130CB")]
		[Address(RVA = "0xB18F20", Offset = "0xB17B20", VA = "0x180B18F20", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060130CC RID: 78028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130CC")]
		[Address(RVA = "0xB19080", Offset = "0xB17C80", VA = "0x180B19080")]
		public ContainsBuffHitRangeProviderBehaviour()
		{
		}

		// Token: 0x060130CD RID: 78029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130CD")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0401582F RID: 88111
		[Token(Token = "0x401582F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<string> _buffKeys;

		// Token: 0x04015830 RID: 88112
		[Token(Token = "0x4015830")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_buffKeys;

		// Token: 0x04015831 RID: 88113
		[Token(Token = "0x4015831")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015832 RID: 88114
		[Token(Token = "0x4015832")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002C10 RID: 11280
		[Token(Token = "0x2002C10")]
		private class ContainsBuffHitRangeProvider : Entity.IHitRangeProvider, IHotfixable
		{
			// Token: 0x060130CE RID: 78030 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60130CE")]
			[Address(RVA = "0xB19520", Offset = "0xB18120", VA = "0x180B19520")]
			public ContainsBuffHitRangeProvider(ContainsBuffHitRangeProviderBehaviour behaviour)
			{
			}

			// Token: 0x170029F4 RID: 10740
			// (get) Token: 0x060130CF RID: 78031 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170029F4")]
			public string providerId
			{
				[Token(Token = "0x60130CF")]
				[Address(RVA = "0xB195A0", Offset = "0xB181A0", VA = "0x180B195A0", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x060130D0 RID: 78032 RVA: 0x000747A8 File Offset: 0x000729A8
			[Token(Token = "0x60130D0")]
			[Address(RVA = "0xB191D0", Offset = "0xB17DD0", VA = "0x180B191D0", Slot = "4")]
			public bool IsInHitRange(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x060130D1 RID: 78033 RVA: 0x000747C0 File Offset: 0x000729C0
			[Token(Token = "0x60130D1")]
			[Address(RVA = "0xB19490", Offset = "0xB18090", VA = "0x180B19490", Slot = "5")]
			public bool IsTargetIn(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x060130D2 RID: 78034 RVA: 0x000747D8 File Offset: 0x000729D8
			[Token(Token = "0x60130D2")]
			[Address(RVA = "0xB19140", Offset = "0xB17D40", VA = "0x180B19140")]
			public bool CheckValidateCondition(Entity.HitRangeOption option)
			{
				return default(bool);
			}

			// Token: 0x04015833 RID: 88115
			[Token(Token = "0x4015833")]
			public const string CONTAINS_BUFF_PROVIDER = "CONTAINS_BUFF_PROVIDER";

			// Token: 0x04015834 RID: 88116
			[Token(Token = "0x4015834")]
			[FieldOffset(Offset = "0x10")]
			private ContainsBuffHitRangeProviderBehaviour m_behaviour;

			// Token: 0x04015835 RID: 88117
			[Token(Token = "0x4015835")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04015836 RID: 88118
			[Token(Token = "0x4015836")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_providerId;

			// Token: 0x04015837 RID: 88119
			[Token(Token = "0x4015837")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_IsInHitRange;

			// Token: 0x04015838 RID: 88120
			[Token(Token = "0x4015838")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_IsTargetIn;

			// Token: 0x04015839 RID: 88121
			[Token(Token = "0x4015839")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_CheckValidateCondition;
		}
	}
}
