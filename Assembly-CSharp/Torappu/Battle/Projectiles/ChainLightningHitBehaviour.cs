using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x0200298C RID: 10636
	[Token(Token = "0x200298C")]
	[RequireComponent(typeof(ChainLightningEffectBehaviour))]
	public class ChainLightningHitBehaviour : SelectorHitBehaviour
	{
		// Token: 0x170026E3 RID: 9955
		// (get) Token: 0x06011989 RID: 72073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026E3")]
		protected ChainLightningEffectBehaviour effect
		{
			[Token(Token = "0x6011989")]
			[Address(RVA = "0x96BB10", Offset = "0x96A710", VA = "0x18096BB10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170026E4 RID: 9956
		// (get) Token: 0x0601198A RID: 72074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026E4")]
		public IEnumerable<ObjectPtr<Entity>> targetsList
		{
			[Token(Token = "0x601198A")]
			[Address(RVA = "0x96BBF0", Offset = "0x96A7F0", VA = "0x18096BBF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601198B RID: 72075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601198B")]
		[Address(RVA = "0x96AFC0", Offset = "0x969BC0", VA = "0x18096AFC0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x0601198C RID: 72076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601198C")]
		[Address(RVA = "0x96AAD0", Offset = "0x9696D0", VA = "0x18096AAD0", Slot = "19")]
		protected override void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x0601198D RID: 72077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601198D")]
		[Address(RVA = "0x96B5F0", Offset = "0x96A1F0", VA = "0x18096B5F0", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x0601198E RID: 72078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601198E")]
		[Address(RVA = "0x96B690", Offset = "0x96A290", VA = "0x18096B690")]
		private void PlayChainAudio()
		{
		}

		// Token: 0x0601198F RID: 72079 RVA: 0x0006C2A0 File Offset: 0x0006A4A0
		[Token(Token = "0x601198F")]
		[Address(RVA = "0x96B950", Offset = "0x96A550", VA = "0x18096B950")]
		private bool _IsFreeJump(Entity target)
		{
			return default(bool);
		}

		// Token: 0x06011990 RID: 72080 RVA: 0x0006C2B8 File Offset: 0x0006A4B8
		[Token(Token = "0x6011990")]
		[Address(RVA = "0x96B850", Offset = "0x96A450", VA = "0x18096B850")]
		private bool _IsAtkScaleUp(Entity target)
		{
			return default(bool);
		}

		// Token: 0x06011991 RID: 72081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011991")]
		[Address(RVA = "0x96BA50", Offset = "0x96A650", VA = "0x18096BA50")]
		public ChainLightningHitBehaviour()
		{
		}

		// Token: 0x06011992 RID: 72082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011992")]
		[Address(RVA = "0x9693E0", Offset = "0x967FE0", VA = "0x1809693E0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011993 RID: 72083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011993")]
		[Address(RVA = "0x9682B0", Offset = "0x966EB0", VA = "0x1809682B0")]
		private void <>xLuaBaseProxy_DoSelectTargetToHit(Vector2 P0)
		{
		}

		// Token: 0x06011994 RID: 72084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011994")]
		[Address(RVA = "0x96B840", Offset = "0x96A440", VA = "0x18096B840")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x04013ADD RID: 80605
		[Token(Token = "0x4013ADD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _atkScale;

		// Token: 0x04013ADE RID: 80606
		[Token(Token = "0x4013ADE")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private bool _useChainPrefix;

		// Token: 0x04013ADF RID: 80607
		[Token(Token = "0x4013ADF")]
		[FieldOffset(Offset = "0xAD")]
		[SerializeField]
		private bool _playChainEffectAndAudioAfterSelectTarget;

		// Token: 0x04013AE0 RID: 80608
		[Token(Token = "0x4013AE0")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Tooltip("We use |Range| only to initialize the colliders.")]
		private CircleRange _rangeToLoad;

		// Token: 0x04013AE1 RID: 80609
		[Token(Token = "0x4013AE1")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public TargetValidator _freeJumpValidator;

		// Token: 0x04013AE2 RID: 80610
		[Token(Token = "0x4013AE2")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public TargetValidator _atkScaleUpValidator;

		// Token: 0x04013AE3 RID: 80611
		[Token(Token = "0x4013AE3")]
		[FieldOffset(Offset = "0xC8")]
		private ChainLightningEffectBehaviour m_effect;

		// Token: 0x04013AE4 RID: 80612
		[Token(Token = "0x4013AE4")]
		[FieldOffset(Offset = "0xD0")]
		private List<ObjectPtr<Entity>> m_targetsList;

		// Token: 0x04013AE5 RID: 80613
		[Token(Token = "0x4013AE5")]
		[FieldOffset(Offset = "0xD8")]
		private float m_atkScale;

		// Token: 0x04013AE6 RID: 80614
		[Token(Token = "0x4013AE6")]
		[FieldOffset(Offset = "0xDC")]
		private float m_atkScaleUp;

		// Token: 0x04013AE7 RID: 80615
		[Token(Token = "0x4013AE7")]
		[FieldOffset(Offset = "0xE0")]
		private int m_freeJumpBonusTarget;

		// Token: 0x04013AE8 RID: 80616
		[Token(Token = "0x4013AE8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_effect;

		// Token: 0x04013AE9 RID: 80617
		[Token(Token = "0x4013AE9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_targetsList;

		// Token: 0x04013AEA RID: 80618
		[Token(Token = "0x4013AEA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013AEB RID: 80619
		[Token(Token = "0x4013AEB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013AEC RID: 80620
		[Token(Token = "0x4013AEC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013AED RID: 80621
		[Token(Token = "0x4013AED")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayChainAudio;

		// Token: 0x04013AEE RID: 80622
		[Token(Token = "0x4013AEE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsFreeJump;

		// Token: 0x04013AEF RID: 80623
		[Token(Token = "0x4013AEF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__IsAtkScaleUp;

		// Token: 0x04013AF0 RID: 80624
		[Token(Token = "0x4013AF0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
