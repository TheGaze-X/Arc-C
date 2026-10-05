using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024D5 RID: 9429
	[Token(Token = "0x20024D5")]
	public class PireneAuraRange : PhysicsRange
	{
		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x0600F2DC RID: 62172 RVA: 0x00059748 File Offset: 0x00057948
		[Token(Token = "0x17001F98")]
		private GridPosition root
		{
			[Token(Token = "0x600F2DC")]
			[Address(RVA = "0x6AEF40", Offset = "0x6ADB40", VA = "0x1806AEF40")]
			get
			{
				return default(GridPosition);
			}
		}

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x0600F2DD RID: 62173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F99")]
		private Character owner
		{
			[Token(Token = "0x600F2DD")]
			[Address(RVA = "0x6AED50", Offset = "0x6AD950", VA = "0x1806AED50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x0600F2DE RID: 62174 RVA: 0x00059760 File Offset: 0x00057960
		[Token(Token = "0x17001F9A")]
		public override bool extendable
		{
			[Token(Token = "0x600F2DE")]
			[Address(RVA = "0x6AECF0", Offset = "0x6AD8F0", VA = "0x1806AECF0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600F2DF RID: 62175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2DF")]
		[Address(RVA = "0x6ADF40", Offset = "0x6ACB40", VA = "0x1806ADF40", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F2E0 RID: 62176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2E0")]
		[Address(RVA = "0x6ADEC0", Offset = "0x6ACAC0", VA = "0x1806ADEC0", Slot = "18")]
		protected override void InitCollidersIfNot(Range.Options options)
		{
		}

		// Token: 0x0600F2E1 RID: 62177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2E1")]
		[Address(RVA = "0x6AE670", Offset = "0x6AD270", VA = "0x1806AE670")]
		private void _UpdateRangeByData()
		{
		}

		// Token: 0x0600F2E2 RID: 62178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2E2")]
		[Address(RVA = "0x6ADFE0", Offset = "0x6ACBE0", VA = "0x1806ADFE0")]
		private void _RebuildBoxCollider()
		{
		}

		// Token: 0x0600F2E3 RID: 62179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2E3")]
		[Address(RVA = "0x6AE5A0", Offset = "0x6AD1A0", VA = "0x1806AE5A0")]
		private static void _SetBoxCollider(BoxCollider2D boxCollider, Vector2 offset, Vector2 size)
		{
		}

		// Token: 0x0600F2E4 RID: 62180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2E4")]
		[Address(RVA = "0x6AEBC0", Offset = "0x6AD7C0", VA = "0x1806AEBC0")]
		public PireneAuraRange()
		{
		}

		// Token: 0x0600F2E5 RID: 62181 RVA: 0x00059778 File Offset: 0x00057978
		[Token(Token = "0x600F2E5")]
		[Address(RVA = "0x6ADDF0", Offset = "0x6AC9F0", VA = "0x1806ADDF0")]
		private bool <>xLuaBaseProxy_get_extendable()
		{
			return default(bool);
		}

		// Token: 0x0600F2E6 RID: 62182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2E6")]
		[Address(RVA = "0x681A60", Offset = "0x680660", VA = "0x180681A60")]
		private void <>xLuaBaseProxy_OnInit(Range.Options P0)
		{
		}

		// Token: 0x0600F2E7 RID: 62183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2E7")]
		[Address(RVA = "0x682AF0", Offset = "0x6816F0", VA = "0x180682AF0")]
		private void <>xLuaBaseProxy_InitCollidersIfNot(Range.Options P0)
		{
		}

		// Token: 0x04010CC0 RID: 68800
		[Token(Token = "0x4010CC0")]
		[FieldOffset(Offset = "0x50")]
		private ObjectPtr<Character> m_owner;

		// Token: 0x04010CC1 RID: 68801
		[Token(Token = "0x4010CC1")]
		[FieldOffset(Offset = "0x60")]
		private RangeData m_rangeData;

		// Token: 0x04010CC2 RID: 68802
		[Token(Token = "0x4010CC2")]
		[FieldOffset(Offset = "0x68")]
		private readonly List<Collider2D> m_cachedColliders;

		// Token: 0x04010CC3 RID: 68803
		[Token(Token = "0x4010CC3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_root;

		// Token: 0x04010CC4 RID: 68804
		[Token(Token = "0x4010CC4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_owner;

		// Token: 0x04010CC5 RID: 68805
		[Token(Token = "0x4010CC5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_extendable;

		// Token: 0x04010CC6 RID: 68806
		[Token(Token = "0x4010CC6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010CC7 RID: 68807
		[Token(Token = "0x4010CC7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitCollidersIfNot;

		// Token: 0x04010CC8 RID: 68808
		[Token(Token = "0x4010CC8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateRangeByData;

		// Token: 0x04010CC9 RID: 68809
		[Token(Token = "0x4010CC9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RebuildBoxCollider;

		// Token: 0x04010CCA RID: 68810
		[Token(Token = "0x4010CCA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetBoxCollider;

		// Token: 0x04010CCB RID: 68811
		[Token(Token = "0x4010CCB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
