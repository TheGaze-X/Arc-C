using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x020024C4 RID: 9412
	[Token(Token = "0x20024C4")]
	public static class Box2dPhysicsUtil
	{
		// Token: 0x0600F22C RID: 61996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F22C")]
		[Address(RVA = "0x685450", Offset = "0x684050", VA = "0x180685450")]
		public static void ClearStaticVariables()
		{
		}

		// Token: 0x0600F22D RID: 61997 RVA: 0x000592E0 File Offset: 0x000574E0
		[Token(Token = "0x600F22D")]
		[Address(RVA = "0x685BD0", Offset = "0x6847D0", VA = "0x180685BD0")]
		public static float GetWorldRadius(CircleCollider2D collider)
		{
			return 0f;
		}

		// Token: 0x0600F22E RID: 61998 RVA: 0x000592F8 File Offset: 0x000574F8
		[Token(Token = "0x600F22E")]
		[Address(RVA = "0x685CD0", Offset = "0x6848D0", VA = "0x180685CD0")]
		public static Bounds SafeBounds(this BoxCollider2D collider)
		{
			return default(Bounds);
		}

		// Token: 0x0600F22F RID: 61999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F22F")]
		[Address(RVA = "0x685550", Offset = "0x684150", VA = "0x180685550")]
		public static ReusableList<Entity> FindTargets_DISPOSE(IList<Collider2D> colliders, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F230 RID: 62000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F230")]
		[Address(RVA = "0x6859D0", Offset = "0x6845D0", VA = "0x1806859D0")]
		public static List<Tile> FindTiles(Collider2D[] colliders, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F231 RID: 62001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F231")]
		[Address(RVA = "0x685EC0", Offset = "0x684AC0", VA = "0x180685EC0")]
		public static void WakeUpRigidBody(Collider2D[] colliders, TargetOptions options, Func<Entity, bool> validator)
		{
		}

		// Token: 0x0600F232 RID: 62002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F232")]
		[Address(RVA = "0x686150", Offset = "0x684D50", VA = "0x180686150")]
		private static Collider2D[] _OverlapCollider(Collider2D collider, int layerMask, out int num)
		{
			return null;
		}

		// Token: 0x0600F233 RID: 62003 RVA: 0x00059310 File Offset: 0x00057510
		[Token(Token = "0x600F233")]
		[Address(RVA = "0x685290", Offset = "0x683E90", VA = "0x180685290")]
		private static bool CheckOverlap(Collider2D[] colliders, ILocatable pos)
		{
			return default(bool);
		}

		// Token: 0x04010C17 RID: 68631
		[Token(Token = "0x4010C17")]
		[FieldOffset(Offset = "0x0")]
		private static HashSet<uint> s_sharedSet;

		// Token: 0x04010C18 RID: 68632
		[Token(Token = "0x4010C18")]
		[FieldOffset(Offset = "0x8")]
		private static Collider2D[] s_sharedColliders;

		// Token: 0x04010C19 RID: 68633
		[Token(Token = "0x4010C19")]
		[FieldOffset(Offset = "0x10")]
		private static List<Tile> s_sharedTiles;

		// Token: 0x04010C1A RID: 68634
		[Token(Token = "0x4010C1A")]
		[FieldOffset(Offset = "0x18")]
		private static ContactFilter2D s_contactFilter2D;
	}
}
