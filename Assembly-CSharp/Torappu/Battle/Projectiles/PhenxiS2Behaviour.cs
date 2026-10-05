using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029A0 RID: 10656
	[Token(Token = "0x20029A0")]
	public class PhenxiS2Behaviour : Projectile.Behaviour
	{
		// Token: 0x06011A4E RID: 72270 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A4E")]
		[Address(RVA = "0x97A450", Offset = "0x979050", VA = "0x18097A450", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011A4F RID: 72271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A4F")]
		[Address(RVA = "0x97A910", Offset = "0x979510", VA = "0x18097A910", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011A50 RID: 72272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A50")]
		[Address(RVA = "0x97A990", Offset = "0x979590", VA = "0x18097A990")]
		private void _CheckDistanceToEmitProjectile()
		{
		}

		// Token: 0x06011A51 RID: 72273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A51")]
		[Address(RVA = "0x97A030", Offset = "0x978C30", VA = "0x18097A030")]
		private void EmitSubProjectile(ILocatable pos)
		{
		}

		// Token: 0x06011A52 RID: 72274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A52")]
		[Address(RVA = "0x97ACF0", Offset = "0x9798F0", VA = "0x18097ACF0")]
		public PhenxiS2Behaviour()
		{
		}

		// Token: 0x06011A53 RID: 72275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A53")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A54 RID: 72276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A54")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013C10 RID: 80912
		[Token(Token = "0x4013C10")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x04013C11 RID: 80913
		[Token(Token = "0x4013C11")]
		[FieldOffset(Offset = "0x30")]
		private bool m_useHookProjectile;

		// Token: 0x04013C12 RID: 80914
		[Token(Token = "0x4013C12")]
		[FieldOffset(Offset = "0x38")]
		private string m_logicProjectileKey;

		// Token: 0x04013C13 RID: 80915
		[Token(Token = "0x4013C13")]
		[FieldOffset(Offset = "0x40")]
		private string m_graphicProjectileKey;

		// Token: 0x04013C14 RID: 80916
		[Token(Token = "0x4013C14")]
		[FieldOffset(Offset = "0x48")]
		private float m_subAtkScale;

		// Token: 0x04013C15 RID: 80917
		[Token(Token = "0x4013C15")]
		[FieldOffset(Offset = "0x50")]
		private List<ActionNode> m_damageNodeReplacedActionNodes;

		// Token: 0x04013C16 RID: 80918
		[Token(Token = "0x4013C16")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 m_targetPos;

		// Token: 0x04013C17 RID: 80919
		[Token(Token = "0x4013C17")]
		[FieldOffset(Offset = "0x60")]
		private Vector2 m_startPos;

		// Token: 0x04013C18 RID: 80920
		[Token(Token = "0x4013C18")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 m_direction;

		// Token: 0x04013C19 RID: 80921
		[Token(Token = "0x4013C19")]
		[FieldOffset(Offset = "0x70")]
		private float m_bombDist;

		// Token: 0x04013C1A RID: 80922
		[Token(Token = "0x4013C1A")]
		[FieldOffset(Offset = "0x74")]
		private int m_currentBombIndex;

		// Token: 0x04013C1B RID: 80923
		[Token(Token = "0x4013C1B")]
		[FieldOffset(Offset = "0x78")]
		private bool m_tooClose;

		// Token: 0x04013C1C RID: 80924
		[Token(Token = "0x4013C1C")]
		private const float TOO_CLOSE_DISTANCE = 0.05f;

		// Token: 0x04013C1D RID: 80925
		[Token(Token = "0x4013C1D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013C1E RID: 80926
		[Token(Token = "0x4013C1E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013C1F RID: 80927
		[Token(Token = "0x4013C1F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CheckDistanceToEmitProjectile;

		// Token: 0x04013C20 RID: 80928
		[Token(Token = "0x4013C20")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EmitSubProjectile;

		// Token: 0x04013C21 RID: 80929
		[Token(Token = "0x4013C21")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
