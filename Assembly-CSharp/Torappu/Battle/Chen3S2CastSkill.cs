using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002455 RID: 9301
	[Token(Token = "0x2002455")]
	public class Chen3S2CastSkill : CastSkill
	{
		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x0600EF01 RID: 61185 RVA: 0x00057E88 File Offset: 0x00056088
		[Token(Token = "0x17001F04")]
		public override FP remainingProgress
		{
			[Token(Token = "0x600EF01")]
			[Address(RVA = "0x66E2C0", Offset = "0x66CEC0", VA = "0x18066E2C0", Slot = "30")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x0600EF02 RID: 61186 RVA: 0x00057EA0 File Offset: 0x000560A0
		[Token(Token = "0x17001F05")]
		public override bool isAffecting
		{
			[Token(Token = "0x600EF02")]
			[Address(RVA = "0x66E240", Offset = "0x66CE40", VA = "0x18066E240", Slot = "25")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600EF03 RID: 61187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF03")]
		[Address(RVA = "0x66DE90", Offset = "0x66CA90", VA = "0x18066DE90", Slot = "58")]
		public override void OnBorn()
		{
		}

		// Token: 0x0600EF04 RID: 61188 RVA: 0x00057EB8 File Offset: 0x000560B8
		[Token(Token = "0x600EF04")]
		[Address(RVA = "0x66E100", Offset = "0x66CD00", VA = "0x18066E100")]
		private bool _RedeployAbilityReady()
		{
			return default(bool);
		}

		// Token: 0x0600EF05 RID: 61189 RVA: 0x00057ED0 File Offset: 0x000560D0
		[Token(Token = "0x600EF05")]
		[Address(RVA = "0x66DFD0", Offset = "0x66CBD0", VA = "0x18066DFD0")]
		private bool _RedeployAbilityAffecting()
		{
			return default(bool);
		}

		// Token: 0x0600EF06 RID: 61190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF06")]
		[Address(RVA = "0x66E1C0", Offset = "0x66CDC0", VA = "0x18066E1C0")]
		public Chen3S2CastSkill()
		{
		}

		// Token: 0x0600EF07 RID: 61191 RVA: 0x00057EE8 File Offset: 0x000560E8
		[Token(Token = "0x600EF07")]
		[Address(RVA = "0x6346D0", Offset = "0x6332D0", VA = "0x1806346D0")]
		private FP <>xLuaBaseProxy_get_remainingProgress()
		{
			return default(FP);
		}

		// Token: 0x0600EF08 RID: 61192 RVA: 0x00057F00 File Offset: 0x00056100
		[Token(Token = "0x600EF08")]
		[Address(RVA = "0x6346C0", Offset = "0x6332C0", VA = "0x1806346C0")]
		private bool <>xLuaBaseProxy_get_isAffecting()
		{
			return default(bool);
		}

		// Token: 0x0600EF09 RID: 61193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EF09")]
		[Address(RVA = "0x634E00", Offset = "0x633A00", VA = "0x180634E00")]
		private void <>xLuaBaseProxy_OnBorn()
		{
		}

		// Token: 0x04010852 RID: 67666
		[Token(Token = "0x4010852")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private Ability _redeployAbility;

		// Token: 0x04010853 RID: 67667
		[Token(Token = "0x4010853")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("Respawn Blackboard Keys")]
		private string _respawnBlackboardKey;

		// Token: 0x04010854 RID: 67668
		[Token(Token = "0x4010854")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_remainingProgress;

		// Token: 0x04010855 RID: 67669
		[Token(Token = "0x4010855")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isAffecting;

		// Token: 0x04010856 RID: 67670
		[Token(Token = "0x4010856")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBorn;

		// Token: 0x04010857 RID: 67671
		[Token(Token = "0x4010857")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RedeployAbilityReady;

		// Token: 0x04010858 RID: 67672
		[Token(Token = "0x4010858")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RedeployAbilityAffecting;

		// Token: 0x04010859 RID: 67673
		[Token(Token = "0x4010859")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
