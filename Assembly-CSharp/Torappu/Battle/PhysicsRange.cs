using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024D3 RID: 9427
	[Token(Token = "0x20024D3")]
	public class PhysicsRange : Range
	{
		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x0600F2CC RID: 62156 RVA: 0x000596E8 File Offset: 0x000578E8
		// (set) Token: 0x0600F2CD RID: 62157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001F97")]
		public override bool extendable
		{
			[Token(Token = "0x600F2CC")]
			[Address(RVA = "0x6ADDF0", Offset = "0x6AC9F0", VA = "0x1806ADDF0", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600F2CD")]
			[Address(RVA = "0x6ADE50", Offset = "0x6ACA50", VA = "0x1806ADE50", Slot = "9")]
			set
			{
			}
		}

		// Token: 0x0600F2CE RID: 62158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2CE")]
		[Address(RVA = "0x6AD3A0", Offset = "0x6ABFA0", VA = "0x1806AD3A0", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F2CF RID: 62159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2CF")]
		[Address(RVA = "0x6ADBE0", Offset = "0x6AC7E0", VA = "0x1806ADBE0")]
		public void UpdateExternColliders(List<Collider2D> externColliders)
		{
		}

		// Token: 0x0600F2D0 RID: 62160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2D0")]
		[Address(RVA = "0x6AD740", Offset = "0x6AC340", VA = "0x1806AD740")]
		protected void UpdateColliders()
		{
		}

		// Token: 0x0600F2D1 RID: 62161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2D1")]
		[Address(RVA = "0x6AD900", Offset = "0x6AC500", VA = "0x1806AD900", Slot = "15")]
		protected override void UpdateExtend(FP extend, bool force)
		{
		}

		// Token: 0x0600F2D2 RID: 62162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2D2")]
		[Address(RVA = "0x6ACC50", Offset = "0x6AB850", VA = "0x1806ACC50", Slot = "10")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2D3 RID: 62163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2D3")]
		[Address(RVA = "0x6ACF00", Offset = "0x6ABB00", VA = "0x1806ACF00", Slot = "11")]
		public override List<Tile> FindTiles(Vector2 mapPos, Func<Tile, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F2D4 RID: 62164 RVA: 0x00059700 File Offset: 0x00057900
		[Token(Token = "0x600F2D4")]
		[Address(RVA = "0x6AC8C0", Offset = "0x6AB4C0", VA = "0x1806AC8C0", Slot = "12")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F2D5 RID: 62165 RVA: 0x00059718 File Offset: 0x00057918
		[Token(Token = "0x600F2D5")]
		[Address(RVA = "0x6AC530", Offset = "0x6AB130", VA = "0x1806AC530", Slot = "13")]
		public override bool CheckTargetInOriginRange(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F2D6 RID: 62166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F2D6")]
		[Address(RVA = "0x6A8590", Offset = "0x6A7190", VA = "0x1806A8590", Slot = "17")]
		protected virtual Collider2D[] FetchColliders(Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F2D7 RID: 62167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2D7")]
		[Address(RVA = "0x6AD0C0", Offset = "0x6ABCC0", VA = "0x1806AD0C0", Slot = "18")]
		protected virtual void InitCollidersIfNot(Range.Options options)
		{
		}

		// Token: 0x0600F2D8 RID: 62168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2D8")]
		[Address(RVA = "0x6ADC60", Offset = "0x6AC860", VA = "0x1806ADC60", Slot = "16")]
		public override void UpdateRangeByOptions(Range.Options options)
		{
		}

		// Token: 0x0600F2D9 RID: 62169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2D9")]
		[Address(RVA = "0x6ADD90", Offset = "0x6AC990", VA = "0x1806ADD90")]
		public PhysicsRange()
		{
		}

		// Token: 0x0600F2DA RID: 62170 RVA: 0x00059730 File Offset: 0x00057930
		[Token(Token = "0x600F2DA")]
		[Address(RVA = "0x6AD6B0", Offset = "0x6AC2B0", VA = "0x1806AD6B0")]
		private bool <>xLuaBaseProxy_CheckTargetInOriginRange(ILocatable P0)
		{
			return default(bool);
		}

		// Token: 0x0600F2DB RID: 62171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F2DB")]
		[Address(RVA = "0x6A4DD0", Offset = "0x6A39D0", VA = "0x1806A4DD0")]
		private void <>xLuaBaseProxy_UpdateRangeByOptions(Range.Options P0)
		{
		}

		// Token: 0x04010CAA RID: 68778
		[Token(Token = "0x4010CAA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _extendable;

		// Token: 0x04010CAB RID: 68779
		[Token(Token = "0x4010CAB")]
		[FieldOffset(Offset = "0x28")]
		protected Collider2D[] m_originColliders;

		// Token: 0x04010CAC RID: 68780
		[Token(Token = "0x4010CAC")]
		[FieldOffset(Offset = "0x30")]
		protected Collider2D[] m_allColliders;

		// Token: 0x04010CAD RID: 68781
		[Token(Token = "0x4010CAD")]
		[FieldOffset(Offset = "0x38")]
		private PhysicsRange.BoxColliderData[] m_originBoxColliderData;

		// Token: 0x04010CAE RID: 68782
		[Token(Token = "0x4010CAE")]
		[FieldOffset(Offset = "0x40")]
		private List<Collider2D> m_allCollidersList;

		// Token: 0x04010CAF RID: 68783
		[Token(Token = "0x4010CAF")]
		[FieldOffset(Offset = "0x48")]
		private List<Collider2D> m_externCollidersList;

		// Token: 0x04010CB0 RID: 68784
		[Token(Token = "0x4010CB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_extendable;

		// Token: 0x04010CB1 RID: 68785
		[Token(Token = "0x4010CB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_extendable;

		// Token: 0x04010CB2 RID: 68786
		[Token(Token = "0x4010CB2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010CB3 RID: 68787
		[Token(Token = "0x4010CB3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateExternColliders;

		// Token: 0x04010CB4 RID: 68788
		[Token(Token = "0x4010CB4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateColliders;

		// Token: 0x04010CB5 RID: 68789
		[Token(Token = "0x4010CB5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateExtend;

		// Token: 0x04010CB6 RID: 68790
		[Token(Token = "0x4010CB6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010CB7 RID: 68791
		[Token(Token = "0x4010CB7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_FindTiles;

		// Token: 0x04010CB8 RID: 68792
		[Token(Token = "0x4010CB8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010CB9 RID: 68793
		[Token(Token = "0x4010CB9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CheckTargetInOriginRange;

		// Token: 0x04010CBA RID: 68794
		[Token(Token = "0x4010CBA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_FetchColliders;

		// Token: 0x04010CBB RID: 68795
		[Token(Token = "0x4010CBB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_InitCollidersIfNot;

		// Token: 0x04010CBC RID: 68796
		[Token(Token = "0x4010CBC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_UpdateRangeByOptions;

		// Token: 0x04010CBD RID: 68797
		[Token(Token = "0x4010CBD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020024D4 RID: 9428
		[Token(Token = "0x20024D4")]
		private struct BoxColliderData
		{
			// Token: 0x04010CBE RID: 68798
			[Token(Token = "0x4010CBE")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 size;

			// Token: 0x04010CBF RID: 68799
			[Token(Token = "0x4010CBF")]
			[FieldOffset(Offset = "0x8")]
			public Vector2 offset;
		}
	}
}
