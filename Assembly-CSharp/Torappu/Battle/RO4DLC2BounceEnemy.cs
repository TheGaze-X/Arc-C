using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200260A RID: 9738
	[Token(Token = "0x200260A")]
	public class RO4DLC2BounceEnemy : InteractableBounceEnemy
	{
		// Token: 0x1700222A RID: 8746
		// (get) Token: 0x0600FDC0 RID: 64960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700222A")]
		public RO4DLC2BounceEnemy.RO4DLC2BounceEnemyForceInfo RO4DLC2TypeDescriteForceInfo
		{
			[Token(Token = "0x600FDC0")]
			[Address(RVA = "0x75E850", Offset = "0x75D450", VA = "0x18075E850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700222B RID: 8747
		// (get) Token: 0x0600FDC1 RID: 64961 RVA: 0x00060168 File Offset: 0x0005E368
		[Token(Token = "0x1700222B")]
		public FP kickBackDefaultForce
		{
			[Token(Token = "0x600FDC1")]
			[Address(RVA = "0x75E9B0", Offset = "0x75D5B0", VA = "0x18075E9B0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x1700222C RID: 8748
		// (get) Token: 0x0600FDC2 RID: 64962 RVA: 0x00060180 File Offset: 0x0005E380
		[Token(Token = "0x1700222C")]
		public FP kickBackDamageValue
		{
			[Token(Token = "0x600FDC2")]
			[Address(RVA = "0x75E950", Offset = "0x75D550", VA = "0x18075E950")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0600FDC3 RID: 64963 RVA: 0x00060198 File Offset: 0x0005E398
		[Token(Token = "0x600FDC3")]
		[Address(RVA = "0x75E170", Offset = "0x75CD70", VA = "0x18075E170")]
		public Vector2 GetVelocity()
		{
			return default(Vector2);
		}

		// Token: 0x0600FDC4 RID: 64964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDC4")]
		[Address(RVA = "0x75DD90", Offset = "0x75C990", VA = "0x18075DD90", Slot = "223")]
		public override void ApplyForce(Entity forceSource, InteractableBounceEnemy.IForceInfo forceInfo)
		{
		}

		// Token: 0x0600FDC5 RID: 64965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDC5")]
		[Address(RVA = "0x75E1E0", Offset = "0x75CDE0", VA = "0x18075E1E0", Slot = "27")]
		public override void OnTick(FP fixedDeltaTime)
		{
		}

		// Token: 0x0600FDC6 RID: 64966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDC6")]
		[Address(RVA = "0x75E590", Offset = "0x75D190", VA = "0x18075E590", Slot = "229")]
		protected override void _UpdateAnimation(FP deltaTime)
		{
		}

		// Token: 0x0600FDC7 RID: 64967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDC7")]
		[Address(RVA = "0x75E3D0", Offset = "0x75CFD0", VA = "0x18075E3D0", Slot = "221")]
		public override void PlayUnbalanceAnimation()
		{
		}

		// Token: 0x0600FDC8 RID: 64968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDC8")]
		[Address(RVA = "0x75E5F0", Offset = "0x75D1F0", VA = "0x18075E5F0", Slot = "230")]
		protected override void _UpdateUnbalanceAnimation()
		{
		}

		// Token: 0x0600FDC9 RID: 64969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDC9")]
		[Address(RVA = "0x75E480", Offset = "0x75D080", VA = "0x18075E480", Slot = "170")]
		public override void PreloadSpecialAudioSignals(string characterId, string tmplId, Action<string, string> preloader)
		{
		}

		// Token: 0x0600FDCA RID: 64970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDCA")]
		[Address(RVA = "0x75E650", Offset = "0x75D250", VA = "0x18075E650")]
		public RO4DLC2BounceEnemy()
		{
		}

		// Token: 0x0600FDCB RID: 64971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDCB")]
		[Address(RVA = "0x75E560", Offset = "0x75D160", VA = "0x18075E560")]
		private void <>xLuaBaseProxy_ApplyForce(Entity P0, InteractableBounceEnemy.IForceInfo P1)
		{
		}

		// Token: 0x0600FDCC RID: 64972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDCC")]
		[Address(RVA = "0x75E570", Offset = "0x75D170", VA = "0x18075E570")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600FDCD RID: 64973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDCD")]
		[Address(RVA = "0x75E580", Offset = "0x75D180", VA = "0x18075E580")]
		private void <>xLuaBaseProxy__UpdateAnimation(FP P0)
		{
		}

		// Token: 0x0600FDCE RID: 64974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDCE")]
		[Address(RVA = "0x758AE0", Offset = "0x7576E0", VA = "0x180758AE0")]
		private void <>xLuaBaseProxy_PlayUnbalanceAnimation()
		{
		}

		// Token: 0x0600FDCF RID: 64975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDCF")]
		[Address(RVA = "0x759A90", Offset = "0x758690", VA = "0x180759A90")]
		private void <>xLuaBaseProxy__UpdateUnbalanceAnimation()
		{
		}

		// Token: 0x0600FDD0 RID: 64976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600FDD0")]
		[Address(RVA = "0x6099F0", Offset = "0x6085F0", VA = "0x1806099F0")]
		private void <>xLuaBaseProxy_PreloadSpecialAudioSignals(string P0, string P1, Action<string, string> P2)
		{
		}

		// Token: 0x04011A0E RID: 72206
		[Token(Token = "0x4011A0E")]
		[FieldOffset(Offset = "0x5A8")]
		[SerializeField]
		private string _directionEffectKey;

		// Token: 0x04011A0F RID: 72207
		[Token(Token = "0x4011A0F")]
		private const float FORCE_FACTOR = 100f;

		// Token: 0x04011A10 RID: 72208
		[Token(Token = "0x4011A10")]
		private const string BOUNCE_AUDIO_SIGNAL = "skzamb_bounce";

		// Token: 0x04011A11 RID: 72209
		[Token(Token = "0x4011A11")]
		[FieldOffset(Offset = "0x5B0")]
		private RO4DLC2BounceEnemy.RO4DLC2BounceEnemyForceInfo m_RO4DLC2TypeDescriteForceInfo;

		// Token: 0x04011A12 RID: 72210
		[Token(Token = "0x4011A12")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_RO4DLC2TypeDescriteForceInfo;

		// Token: 0x04011A13 RID: 72211
		[Token(Token = "0x4011A13")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_kickBackDefaultForce;

		// Token: 0x04011A14 RID: 72212
		[Token(Token = "0x4011A14")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_kickBackDamageValue;

		// Token: 0x04011A15 RID: 72213
		[Token(Token = "0x4011A15")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetVelocity;

		// Token: 0x04011A16 RID: 72214
		[Token(Token = "0x4011A16")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyForce;

		// Token: 0x04011A17 RID: 72215
		[Token(Token = "0x4011A17")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04011A18 RID: 72216
		[Token(Token = "0x4011A18")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateAnimation;

		// Token: 0x04011A19 RID: 72217
		[Token(Token = "0x4011A19")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PlayUnbalanceAnimation;

		// Token: 0x04011A1A RID: 72218
		[Token(Token = "0x4011A1A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__UpdateUnbalanceAnimation;

		// Token: 0x04011A1B RID: 72219
		[Token(Token = "0x4011A1B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_PreloadSpecialAudioSignals;

		// Token: 0x04011A1C RID: 72220
		[Token(Token = "0x4011A1C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200260B RID: 9739
		[Token(Token = "0x200260B")]
		public class RO4DLC2BounceEnemyForceInfo : InteractableBounceEnemy.IForceInfo, IHotfixable
		{
			// Token: 0x0600FDD1 RID: 64977 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600FDD1")]
			[Address(RVA = "0x75DD30", Offset = "0x75C930", VA = "0x18075DD30")]
			public RO4DLC2BounceEnemyForceInfo()
			{
			}

			// Token: 0x04011A1D RID: 72221
			[Token(Token = "0x4011A1D")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 direction;

			// Token: 0x04011A1E RID: 72222
			[Token(Token = "0x4011A1E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
