using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B3F RID: 11071
	[Token(Token = "0x2002B3F")]
	[RequireComponent(typeof(Collider2D))]
	public class RO4DLC2BounceAbility : EmptyAbility
	{
		// Token: 0x06012921 RID: 76065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012921")]
		[Address(RVA = "0xA8E010", Offset = "0xA8CC10", VA = "0x180A8E010", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012922 RID: 76066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012922")]
		[Address(RVA = "0xA8DE80", Offset = "0xA8CA80", VA = "0x180A8DE80", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012923 RID: 76067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012923")]
		[Address(RVA = "0xA8DF50", Offset = "0xA8CB50", VA = "0x180A8DF50", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x06012924 RID: 76068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012924")]
		[Address(RVA = "0xA8EFB0", Offset = "0xA8DBB0", VA = "0x180A8EFB0")]
		private void _DealCollisionWithSealedEnemy(Collider2D collision)
		{
		}

		// Token: 0x06012925 RID: 76069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012925")]
		[Address(RVA = "0xA8EE20", Offset = "0xA8DA20", VA = "0x180A8EE20")]
		private void _DealCollisionWithSealedCharacter(Collider2D collision)
		{
		}

		// Token: 0x06012926 RID: 76070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012926")]
		[Address(RVA = "0xA8F150", Offset = "0xA8DD50", VA = "0x180A8F150")]
		private void _DealCollisionWithTile(Collider2D collision)
		{
		}

		// Token: 0x06012927 RID: 76071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012927")]
		[Address(RVA = "0xA8E970", Offset = "0xA8D570", VA = "0x180A8E970")]
		private void _ApplyCollision(Collider2D collision, Vector2 targetMapPos, [Optional] Entity source)
		{
		}

		// Token: 0x06012928 RID: 76072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012928")]
		[Address(RVA = "0xA8E1E0", Offset = "0xA8CDE0", VA = "0x180A8E1E0", Slot = "46")]
		public override void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012929 RID: 76073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012929")]
		[Address(RVA = "0xA8F310", Offset = "0xA8DF10", VA = "0x180A8F310")]
		private void _PlayEffect(Entity target)
		{
		}

		// Token: 0x0601292A RID: 76074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601292A")]
		[Address(RVA = "0xA8E590", Offset = "0xA8D190", VA = "0x180A8E590")]
		private void OnTriggerStay2D(Collider2D collision)
		{
		}

		// Token: 0x0601292B RID: 76075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601292B")]
		[Address(RVA = "0xA8E2A0", Offset = "0xA8CEA0", VA = "0x180A8E2A0")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		// Token: 0x0601292C RID: 76076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601292C")]
		[Address(RVA = "0xA8F530", Offset = "0xA8E130", VA = "0x180A8F530")]
		public RO4DLC2BounceAbility()
		{
		}

		// Token: 0x0601292D RID: 76077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601292D")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x0601292E RID: 76078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601292E")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x0601292F RID: 76079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601292F")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x06012930 RID: 76080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012930")]
		[Address(RVA = "0xA53380", Offset = "0xA51F80", VA = "0x180A53380")]
		private void <>xLuaBaseProxy_GatherEffects(List<string> P0)
		{
		}

		// Token: 0x04014FA6 RID: 85926
		[Token(Token = "0x4014FA6")]
		public const float COLLISION_PARALLEL_DOT_THRESHOLD = 0.5f;

		// Token: 0x04014FA7 RID: 85927
		[Token(Token = "0x4014FA7")]
		public const float ZERO_VELOCITY_MARGIN = 0.1f;

		// Token: 0x04014FA8 RID: 85928
		[Token(Token = "0x4014FA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private string _velocityDecayFactorKey;

		// Token: 0x04014FA9 RID: 85929
		[Token(Token = "0x4014FA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float _velocityDecayFactor;

		// Token: 0x04014FAA RID: 85930
		[Token(Token = "0x4014FAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private string _collisionEffect;

		// Token: 0x04014FAB RID: 85931
		[Token(Token = "0x4014FAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private string _sealCharBuffKey;

		// Token: 0x04014FAC RID: 85932
		[Token(Token = "0x4014FAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private string _sealEnemyBuffKey;

		// Token: 0x04014FAD RID: 85933
		[Token(Token = "0x4014FAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[SerializeField]
		private string _bossBuffKey;

		// Token: 0x04014FAE RID: 85934
		[Token(Token = "0x4014FAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[SerializeField]
		private bool _dealTileCollision;

		// Token: 0x04014FAF RID: 85935
		[Token(Token = "0x4014FAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[SerializeField]
		[Group("Buff to the collision counterpart")]
		private BuffData _buff;

		// Token: 0x04014FB0 RID: 85936
		[Token(Token = "0x4014FB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[SerializeField]
		private float _colliderRadius;

		// Token: 0x04014FB1 RID: 85937
		[Token(Token = "0x4014FB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		[SerializeField]
		private float _frameInterval;

		// Token: 0x04014FB2 RID: 85938
		[Token(Token = "0x4014FB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private ObjectPtr<RO4DLC2BounceEnemy> m_bounceEnemy;

		// Token: 0x04014FB3 RID: 85939
		[Token(Token = "0x4014FB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Collider2D m_collider;

		// Token: 0x04014FB4 RID: 85940
		[Token(Token = "0x4014FB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private ContactPoint2D[] m_contact2DList;

		// Token: 0x04014FB5 RID: 85941
		[Token(Token = "0x4014FB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float m_velocityDecayFactor;

		// Token: 0x04014FB6 RID: 85942
		[Token(Token = "0x4014FB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014FB7 RID: 85943
		[Token(Token = "0x4014FB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014FB8 RID: 85944
		[Token(Token = "0x4014FB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x04014FB9 RID: 85945
		[Token(Token = "0x4014FB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DealCollisionWithSealedEnemy;

		// Token: 0x04014FBA RID: 85946
		[Token(Token = "0x4014FBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DealCollisionWithSealedCharacter;

		// Token: 0x04014FBB RID: 85947
		[Token(Token = "0x4014FBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DealCollisionWithTile;

		// Token: 0x04014FBC RID: 85948
		[Token(Token = "0x4014FBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ApplyCollision;

		// Token: 0x04014FBD RID: 85949
		[Token(Token = "0x4014FBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04014FBE RID: 85950
		[Token(Token = "0x4014FBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayEffect;

		// Token: 0x04014FBF RID: 85951
		[Token(Token = "0x4014FBF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnTriggerStay2D;

		// Token: 0x04014FC0 RID: 85952
		[Token(Token = "0x4014FC0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnTriggerEnter2D;

		// Token: 0x04014FC1 RID: 85953
		[Token(Token = "0x4014FC1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
