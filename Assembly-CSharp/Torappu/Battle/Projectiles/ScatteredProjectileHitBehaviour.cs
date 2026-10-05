using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029AC RID: 10668
	[Token(Token = "0x20029AC")]
	public class ScatteredProjectileHitBehaviour : SelectorHitBehaviour
	{
		// Token: 0x06011AA6 RID: 72358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AA6")]
		[Address(RVA = "0x983A10", Offset = "0x982610", VA = "0x180983A10", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011AA7 RID: 72359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AA7")]
		[Address(RVA = "0x983750", Offset = "0x982350", VA = "0x180983750")]
		private void EmitScatteredProjectile(Entity entity)
		{
		}

		// Token: 0x06011AA8 RID: 72360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AA8")]
		[Address(RVA = "0x983550", Offset = "0x982150", VA = "0x180983550", Slot = "19")]
		protected override void DoSelectTargetToHit(Vector2 inputPos)
		{
		}

		// Token: 0x06011AA9 RID: 72361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AA9")]
		[Address(RVA = "0x983D80", Offset = "0x982980", VA = "0x180983D80")]
		public ScatteredProjectileHitBehaviour()
		{
		}

		// Token: 0x06011AAA RID: 72362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AAA")]
		[Address(RVA = "0x9693E0", Offset = "0x967FE0", VA = "0x1809693E0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011AAB RID: 72363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011AAB")]
		[Address(RVA = "0x9682B0", Offset = "0x966EB0", VA = "0x1809682B0")]
		private void <>xLuaBaseProxy_DoSelectTargetToHit(Vector2 P0)
		{
		}

		// Token: 0x04013CA2 RID: 81058
		[Token(Token = "0x4013CA2")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x04013CA3 RID: 81059
		[Token(Token = "0x4013CA3")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_useHookProjectile;

		// Token: 0x04013CA4 RID: 81060
		[Token(Token = "0x4013CA4")]
		[FieldOffset(Offset = "0xB8")]
		private string m_logicProjectileKey;

		// Token: 0x04013CA5 RID: 81061
		[Token(Token = "0x4013CA5")]
		[FieldOffset(Offset = "0xC0")]
		private string m_graphicProjectileKey;

		// Token: 0x04013CA6 RID: 81062
		[Token(Token = "0x4013CA6")]
		[FieldOffset(Offset = "0xC8")]
		private float m_subAtkScale;

		// Token: 0x04013CA7 RID: 81063
		[Token(Token = "0x4013CA7")]
		[FieldOffset(Offset = "0xD0")]
		private List<ActionNode> m_damageNodeReplacedActionNodes;

		// Token: 0x04013CA8 RID: 81064
		[Token(Token = "0x4013CA8")]
		[FieldOffset(Offset = "0xD8")]
		private int m_maxTargetNum;

		// Token: 0x04013CA9 RID: 81065
		[Token(Token = "0x4013CA9")]
		[FieldOffset(Offset = "0xDC")]
		private int m_targetHit;

		// Token: 0x04013CAA RID: 81066
		[Token(Token = "0x4013CAA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013CAB RID: 81067
		[Token(Token = "0x4013CAB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EmitScatteredProjectile;

		// Token: 0x04013CAC RID: 81068
		[Token(Token = "0x4013CAC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSelectTargetToHit;

		// Token: 0x04013CAD RID: 81069
		[Token(Token = "0x4013CAD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
