using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002606 RID: 9734
	[Token(Token = "0x2002606")]
	public class PropLikeEnemy : Enemy
	{
		// Token: 0x1700221F RID: 8735
		// (get) Token: 0x0600FD8C RID: 64908 RVA: 0x0005FF10 File Offset: 0x0005E110
		[Token(Token = "0x1700221F")]
		private bool acceptSpecificDamageType
		{
			[Token(Token = "0x600FD8C")]
			[Address(RVA = "0x75CB30", Offset = "0x75B730", VA = "0x18075CB30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002220 RID: 8736
		// (get) Token: 0x0600FD8D RID: 64909 RVA: 0x0005FF28 File Offset: 0x0005E128
		[Token(Token = "0x17002220")]
		private bool onlyAffectSpecificModeIndex
		{
			[Token(Token = "0x600FD8D")]
			[Address(RVA = "0x75CB90", Offset = "0x75B790", VA = "0x18075CB90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600FD8E RID: 64910 RVA: 0x0005FF40 File Offset: 0x0005E140
		[Token(Token = "0x600FD8E")]
		[Address(RVA = "0x75C4B0", Offset = "0x75B0B0", VA = "0x18075C4B0", Slot = "120")]
		protected override bool DoApplyModifier(ref Modifier modifier, bool force)
		{
			return default(bool);
		}

		// Token: 0x0600FD8F RID: 64911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD8F")]
		[Address(RVA = "0x75CA00", Offset = "0x75B600", VA = "0x18075CA00", Slot = "32")]
		protected override void OnBorn()
		{
		}

		// Token: 0x0600FD90 RID: 64912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD90")]
		[Address(RVA = "0x75C880", Offset = "0x75B480", VA = "0x18075C880", Slot = "172")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x0600FD91 RID: 64913 RVA: 0x0005FF58 File Offset: 0x0005E158
		[Token(Token = "0x600FD91")]
		[Address(RVA = "0x75C3E0", Offset = "0x75AFE0", VA = "0x18075C3E0")]
		public bool CheckIsInPropLikeState()
		{
			return default(bool);
		}

		// Token: 0x0600FD92 RID: 64914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD92")]
		[Address(RVA = "0x75CAB0", Offset = "0x75B6B0", VA = "0x18075CAB0")]
		public PropLikeEnemy()
		{
		}

		// Token: 0x0600FD93 RID: 64915 RVA: 0x0005FF70 File Offset: 0x0005E170
		[Token(Token = "0x600FD93")]
		[Address(RVA = "0x75CAA0", Offset = "0x75B6A0", VA = "0x18075CAA0")]
		private bool <>xLuaBaseProxy_DoApplyModifier(ref Modifier P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0600FD94 RID: 64916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD94")]
		[Address(RVA = "0x6099B0", Offset = "0x6085B0", VA = "0x1806099B0")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x0600FD95 RID: 64917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FD95")]
		[Address(RVA = "0x7424C0", Offset = "0x7410C0", VA = "0x1807424C0")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x040119DC RID: 72156
		[Token(Token = "0x40119DC")]
		[FieldOffset(Offset = "0x528")]
		[SerializeField]
		[Group("PropLikeEnemy")]
		private bool _acceptSpecificDamageType;

		// Token: 0x040119DD RID: 72157
		[Token(Token = "0x40119DD")]
		[FieldOffset(Offset = "0x52C")]
		[Group("PropLikeEnemy")]
		[SerializeField]
		[Inspect("acceptSpecificDamageType")]
		private DamageType _acceptDamageType;

		// Token: 0x040119DE RID: 72158
		[Token(Token = "0x40119DE")]
		[FieldOffset(Offset = "0x530")]
		[SerializeField]
		[Group("PropLikeEnemy")]
		private List<string> _basicEffects;

		// Token: 0x040119DF RID: 72159
		[Token(Token = "0x40119DF")]
		[FieldOffset(Offset = "0x538")]
		[SerializeField]
		[Group("PropLikeEnemy")]
		private bool _onlyAffectSpecificModeIndex;

		// Token: 0x040119E0 RID: 72160
		[Token(Token = "0x40119E0")]
		[FieldOffset(Offset = "0x53C")]
		[SerializeField]
		[Inspect("onlyAffectSpecificModeIndex")]
		[Group("PropLikeEnemy")]
		private int _specificModeIndex;

		// Token: 0x040119E1 RID: 72161
		[Token(Token = "0x40119E1")]
		[FieldOffset(Offset = "0x540")]
		[SerializeField]
		private bool _hasSp;

		// Token: 0x040119E2 RID: 72162
		[Token(Token = "0x40119E2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_acceptSpecificDamageType;

		// Token: 0x040119E3 RID: 72163
		[Token(Token = "0x40119E3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_onlyAffectSpecificModeIndex;

		// Token: 0x040119E4 RID: 72164
		[Token(Token = "0x40119E4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoApplyModifier;

		// Token: 0x040119E5 RID: 72165
		[Token(Token = "0x40119E5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x040119E6 RID: 72166
		[Token(Token = "0x40119E6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x040119E7 RID: 72167
		[Token(Token = "0x40119E7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_CheckIsInPropLikeState;

		// Token: 0x040119E8 RID: 72168
		[Token(Token = "0x40119E8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
