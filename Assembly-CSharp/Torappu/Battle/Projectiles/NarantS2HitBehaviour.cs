using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x0200299F RID: 10655
	[Token(Token = "0x200299F")]
	public class NarantS2HitBehaviour : HitBehaviour
	{
		// Token: 0x06011A46 RID: 72262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A46")]
		[Address(RVA = "0x979A10", Offset = "0x978610", VA = "0x180979A10", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011A47 RID: 72263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A47")]
		[Address(RVA = "0x979970", Offset = "0x978570", VA = "0x180979970", Slot = "15")]
		protected override void DealHitTarget(Entity target, bool force)
		{
		}

		// Token: 0x06011A48 RID: 72264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A48")]
		[Address(RVA = "0x979D00", Offset = "0x978900", VA = "0x180979D00")]
		public void SwitchToComebackState()
		{
		}

		// Token: 0x06011A49 RID: 72265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A49")]
		[Address(RVA = "0x979B00", Offset = "0x978700", VA = "0x180979B00")]
		private void OnTriggerStay2D(Collider2D collision)
		{
		}

		// Token: 0x06011A4A RID: 72266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A4A")]
		[Address(RVA = "0x979E00", Offset = "0x978A00", VA = "0x180979E00")]
		private void _DoTargetStay(IPtrObject obj)
		{
		}

		// Token: 0x06011A4B RID: 72267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A4B")]
		[Address(RVA = "0x979F80", Offset = "0x978B80", VA = "0x180979F80")]
		public NarantS2HitBehaviour()
		{
		}

		// Token: 0x06011A4C RID: 72268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A4C")]
		[Address(RVA = "0x9795A0", Offset = "0x9781A0", VA = "0x1809795A0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A4D RID: 72269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A4D")]
		[Address(RVA = "0x979590", Offset = "0x978190", VA = "0x180979590")]
		private void <>xLuaBaseProxy_DealHitTarget(Entity P0, bool P1)
		{
		}

		// Token: 0x04013C07 RID: 80903
		[Token(Token = "0x4013C07")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string m_comebackAtkScaleKey;

		// Token: 0x04013C08 RID: 80904
		[Token(Token = "0x4013C08")]
		[FieldOffset(Offset = "0xB0")]
		private float m_comebackAtkScale;

		// Token: 0x04013C09 RID: 80905
		[Token(Token = "0x4013C09")]
		[FieldOffset(Offset = "0xB4")]
		private bool m_active;

		// Token: 0x04013C0A RID: 80906
		[Token(Token = "0x4013C0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013C0B RID: 80907
		[Token(Token = "0x4013C0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DealHitTarget;

		// Token: 0x04013C0C RID: 80908
		[Token(Token = "0x4013C0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SwitchToComebackState;

		// Token: 0x04013C0D RID: 80909
		[Token(Token = "0x4013C0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTriggerStay2D;

		// Token: 0x04013C0E RID: 80910
		[Token(Token = "0x4013C0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoTargetStay;

		// Token: 0x04013C0F RID: 80911
		[Token(Token = "0x4013C0F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
