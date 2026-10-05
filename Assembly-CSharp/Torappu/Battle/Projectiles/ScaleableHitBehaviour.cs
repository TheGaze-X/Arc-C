using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029AB RID: 10667
	[Token(Token = "0x20029AB")]
	public class ScaleableHitBehaviour : HitBehaviour
	{
		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x06011A9D RID: 72349 RVA: 0x0006C4E0 File Offset: 0x0006A6E0
		[Token(Token = "0x170026EF")]
		public bool applyAtkScaleTraceTgt
		{
			[Token(Token = "0x6011A9D")]
			[Address(RVA = "0x9834F0", Offset = "0x9820F0", VA = "0x1809834F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x06011A9E RID: 72350 RVA: 0x0006C4F8 File Offset: 0x0006A6F8
		[Token(Token = "0x170026F0")]
		public bool applyAtkScaleExcludeTraceTgt
		{
			[Token(Token = "0x6011A9E")]
			[Address(RVA = "0x983490", Offset = "0x982090", VA = "0x180983490")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170026F1 RID: 9969
		// (get) Token: 0x06011A9F RID: 72351 RVA: 0x0006C510 File Offset: 0x0006A710
		[Token(Token = "0x170026F1")]
		public bool applyAtkScaleCheckTargetNum
		{
			[Token(Token = "0x6011A9F")]
			[Address(RVA = "0x983430", Offset = "0x982030", VA = "0x180983430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06011AA0 RID: 72352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AA0")]
		[Address(RVA = "0x982CE0", Offset = "0x9818E0", VA = "0x180982CE0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011AA1 RID: 72353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AA1")]
		[Address(RVA = "0x982C30", Offset = "0x981830", VA = "0x180982C30", Slot = "15")]
		protected override void DealHitTarget(Entity target, bool force)
		{
		}

		// Token: 0x06011AA2 RID: 72354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AA2")]
		[Address(RVA = "0x982FD0", Offset = "0x981BD0", VA = "0x180982FD0")]
		protected void OnBeforeHitTarget(Entity target)
		{
		}

		// Token: 0x06011AA3 RID: 72355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AA3")]
		[Address(RVA = "0x9832C0", Offset = "0x981EC0", VA = "0x1809832C0")]
		public ScaleableHitBehaviour()
		{
		}

		// Token: 0x06011AA4 RID: 72356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AA4")]
		[Address(RVA = "0x9795A0", Offset = "0x9781A0", VA = "0x1809795A0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011AA5 RID: 72357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AA5")]
		[Address(RVA = "0x979590", Offset = "0x978190", VA = "0x180979590")]
		private void <>xLuaBaseProxy_DealHitTarget(Entity P0, bool P1)
		{
		}

		// Token: 0x04013C8A RID: 81034
		[Token(Token = "0x4013C8A")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _applyExtraAtkScale;

		// Token: 0x04013C8B RID: 81035
		[Token(Token = "0x4013C8B")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _atkScale;

		// Token: 0x04013C8C RID: 81036
		[Token(Token = "0x4013C8C")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _atkScaleKey;

		// Token: 0x04013C8D RID: 81037
		[Token(Token = "0x4013C8D")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _checkValidViaBBKey;

		// Token: 0x04013C8E RID: 81038
		[Token(Token = "0x4013C8E")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool _applyAtkScaleTraceTgt;

		// Token: 0x04013C8F RID: 81039
		[Token(Token = "0x4013C8F")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Inspect("applyAtkScaleTraceTgt")]
		private string _atkScaleKeyTraceTgt;

		// Token: 0x04013C90 RID: 81040
		[Token(Token = "0x4013C90")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private bool _applyAtkScaleExcludeTraceTgt;

		// Token: 0x04013C91 RID: 81041
		[Token(Token = "0x4013C91")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Inspect("applyAtkScaleExcludeTraceTgt")]
		private string _atkScaleKeyExcludeTraceTgt;

		// Token: 0x04013C92 RID: 81042
		[Token(Token = "0x4013C92")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private bool _applyAtkScaleCheckTargetNum;

		// Token: 0x04013C93 RID: 81043
		[Token(Token = "0x4013C93")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[Inspect("applyAtkScaleCheckTargetNum")]
		private CompareType _compareTargetNumType;

		// Token: 0x04013C94 RID: 81044
		[Token(Token = "0x4013C94")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Inspect("applyAtkScaleCheckTargetNum")]
		private string _atkScaleKeyCheckTargetNum;

		// Token: 0x04013C95 RID: 81045
		[Token(Token = "0x4013C95")]
		[FieldOffset(Offset = "0xF0")]
		private float m_extraAtkScale;

		// Token: 0x04013C96 RID: 81046
		[Token(Token = "0x4013C96")]
		[FieldOffset(Offset = "0xF4")]
		private float m_atkScaleToTraceTgt;

		// Token: 0x04013C97 RID: 81047
		[Token(Token = "0x4013C97")]
		[FieldOffset(Offset = "0xF8")]
		private float m_atkScaleExcludeTraceTgt;

		// Token: 0x04013C98 RID: 81048
		[Token(Token = "0x4013C98")]
		[FieldOffset(Offset = "0xFC")]
		private float m_atkScaleCheckTargetNum;

		// Token: 0x04013C99 RID: 81049
		[Token(Token = "0x4013C99")]
		[FieldOffset(Offset = "0x100")]
		private bool m_isValid;

		// Token: 0x04013C9A RID: 81050
		[Token(Token = "0x4013C9A")]
		[FieldOffset(Offset = "0x104")]
		private int m_checkTargetNum;

		// Token: 0x04013C9B RID: 81051
		[Token(Token = "0x4013C9B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_applyAtkScaleTraceTgt;

		// Token: 0x04013C9C RID: 81052
		[Token(Token = "0x4013C9C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_applyAtkScaleExcludeTraceTgt;

		// Token: 0x04013C9D RID: 81053
		[Token(Token = "0x4013C9D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_applyAtkScaleCheckTargetNum;

		// Token: 0x04013C9E RID: 81054
		[Token(Token = "0x4013C9E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013C9F RID: 81055
		[Token(Token = "0x4013C9F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DealHitTarget;

		// Token: 0x04013CA0 RID: 81056
		[Token(Token = "0x4013CA0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnBeforeHitTarget;

		// Token: 0x04013CA1 RID: 81057
		[Token(Token = "0x4013CA1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
