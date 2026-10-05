using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020024DB RID: 9435
	[Token(Token = "0x20024DB")]
	public class Thorn2PolygonRange : PhysicsRange
	{
		// Token: 0x17001F9D RID: 8093
		// (get) Token: 0x0600F302 RID: 62210 RVA: 0x000598B0 File Offset: 0x00057AB0
		[Token(Token = "0x17001F9D")]
		public override bool extendable
		{
			[Token(Token = "0x600F302")]
			[Address(RVA = "0x6B2AC0", Offset = "0x6B16C0", VA = "0x1806B2AC0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001F9E RID: 8094
		// (get) Token: 0x0600F303 RID: 62211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F9E")]
		public List<Tile> inputPoints
		{
			[Token(Token = "0x600F303")]
			[Address(RVA = "0x6B2B30", Offset = "0x6B1730", VA = "0x1806B2B30")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001F9F RID: 8095
		// (get) Token: 0x0600F304 RID: 62212 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001F9F")]
		public List<Vector2> resultForEffect
		{
			[Token(Token = "0x600F304")]
			[Address(RVA = "0x6B2BB0", Offset = "0x6B17B0", VA = "0x1806B2BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600F305 RID: 62213 RVA: 0x000598C8 File Offset: 0x00057AC8
		[Token(Token = "0x600F305")]
		[Address(RVA = "0x6B0430", Offset = "0x6AF030", VA = "0x1806B0430", Slot = "12")]
		public override bool CheckTargetIn(ILocatable target)
		{
			return default(bool);
		}

		// Token: 0x0600F306 RID: 62214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F306")]
		[Address(RVA = "0x6B09E0", Offset = "0x6AF5E0", VA = "0x1806B09E0", Slot = "17")]
		protected override Collider2D[] FetchColliders(Range.Options options)
		{
			return null;
		}

		// Token: 0x0600F307 RID: 62215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F307")]
		[Address(RVA = "0x6B10D0", Offset = "0x6AFCD0", VA = "0x1806B10D0", Slot = "15")]
		protected override void UpdateExtend(FP extend, bool force)
		{
		}

		// Token: 0x0600F308 RID: 62216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F308")]
		[Address(RVA = "0x6B0FE0", Offset = "0x6AFBE0", VA = "0x1806B0FE0", Slot = "14")]
		protected override void OnInit(Range.Options options)
		{
		}

		// Token: 0x0600F309 RID: 62217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F309")]
		[Address(RVA = "0x6B04B0", Offset = "0x6AF0B0", VA = "0x1806B04B0", Slot = "10")]
		protected override ReusableList<Entity> DoFindTargets_DISPOSE(Vector2 mapPos, TargetOptions options, Func<Entity, bool> validator)
		{
			return null;
		}

		// Token: 0x0600F30A RID: 62218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F30A")]
		[Address(RVA = "0x6B0B90", Offset = "0x6AF790", VA = "0x1806B0B90")]
		public void InitPolygonCollidersIfNot(GridPosition pos)
		{
		}

		// Token: 0x0600F30B RID: 62219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F30B")]
		[Address(RVA = "0x6B1270", Offset = "0x6AFE70", VA = "0x1806B1270")]
		private void _DoCalculateHull(List<Vector2> input, ref List<Vector2> result)
		{
		}

		// Token: 0x0600F30C RID: 62220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F30C")]
		[Address(RVA = "0x6B1DF0", Offset = "0x6B09F0", VA = "0x1806B1DF0")]
		private void _OptimizeLineCollider(ref List<Vector2> result)
		{
		}

		// Token: 0x0600F30D RID: 62221 RVA: 0x000598E0 File Offset: 0x00057AE0
		[Token(Token = "0x600F30D")]
		[Address(RVA = "0x6B1160", Offset = "0x6AFD60", VA = "0x1806B1160")]
		private float _Cross(Vector2 a, Vector2 b, Vector2 c)
		{
			return 0f;
		}

		// Token: 0x0600F30E RID: 62222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F30E")]
		[Address(RVA = "0x6B18E0", Offset = "0x6B04E0", VA = "0x1806B18E0")]
		private void _GetBoxColliderData()
		{
		}

		// Token: 0x0600F30F RID: 62223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F30F")]
		[Address(RVA = "0x6B26B0", Offset = "0x6B12B0", VA = "0x1806B26B0")]
		private void _SetBoxCollider(GridPosition pos)
		{
		}

		// Token: 0x0600F310 RID: 62224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F310")]
		[Address(RVA = "0x6B28A0", Offset = "0x6B14A0", VA = "0x1806B28A0")]
		public Thorn2PolygonRange()
		{
		}

		// Token: 0x0600F312 RID: 62226 RVA: 0x000598F8 File Offset: 0x00057AF8
		[Token(Token = "0x600F312")]
		[Address(RVA = "0x6ADDF0", Offset = "0x6AC9F0", VA = "0x1806ADDF0")]
		private bool <>xLuaBaseProxy_get_extendable()
		{
			return default(bool);
		}

		// Token: 0x0600F313 RID: 62227 RVA: 0x00059910 File Offset: 0x00057B10
		[Token(Token = "0x600F313")]
		[Address(RVA = "0x6886B0", Offset = "0x6872B0", VA = "0x1806886B0")]
		private bool <>xLuaBaseProxy_CheckTargetIn(ILocatable P0)
		{
			return default(bool);
		}

		// Token: 0x0600F314 RID: 62228 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F314")]
		[Address(RVA = "0x6A8590", Offset = "0x6A7190", VA = "0x1806A8590")]
		private Collider2D[] <>xLuaBaseProxy_FetchColliders(Range.Options P0)
		{
			return null;
		}

		// Token: 0x0600F315 RID: 62229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F315")]
		[Address(RVA = "0x687210", Offset = "0x685E10", VA = "0x180687210")]
		private void <>xLuaBaseProxy_UpdateExtend(FP P0, bool P1)
		{
		}

		// Token: 0x0600F316 RID: 62230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F316")]
		[Address(RVA = "0x681A60", Offset = "0x680660", VA = "0x180681A60")]
		private void <>xLuaBaseProxy_OnInit(Range.Options P0)
		{
		}

		// Token: 0x0600F317 RID: 62231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F317")]
		[Address(RVA = "0x682A40", Offset = "0x681640", VA = "0x180682A40")]
		private ReusableList<Entity> <>xLuaBaseProxy_DoFindTargets_DISPOSE(Vector2 P0, TargetOptions P1, Func<Entity, bool> P2)
		{
			return null;
		}

		// Token: 0x04010CDE RID: 68830
		[Token(Token = "0x4010CDE")]
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public static readonly int MAX_POLYGON_POINT_COUNT;

		// Token: 0x04010CDF RID: 68831
		[Token(Token = "0x4010CDF")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _polygonLineColliderWide;

		// Token: 0x04010CE0 RID: 68832
		[Token(Token = "0x4010CE0")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float _polygonColliderOffset;

		// Token: 0x04010CE1 RID: 68833
		[Token(Token = "0x4010CE1")]
		[FieldOffset(Offset = "0x58")]
		private Vector2 m_boxCenter;

		// Token: 0x04010CE2 RID: 68834
		[Token(Token = "0x4010CE2")]
		[FieldOffset(Offset = "0x60")]
		private FP m_boxWidth;

		// Token: 0x04010CE3 RID: 68835
		[Token(Token = "0x4010CE3")]
		[FieldOffset(Offset = "0x68")]
		private FP m_boxLength;

		// Token: 0x04010CE4 RID: 68836
		[Token(Token = "0x4010CE4")]
		[FieldOffset(Offset = "0x70")]
		private BoxCollider2D m_boxCollider;

		// Token: 0x04010CE5 RID: 68837
		[Token(Token = "0x4010CE5")]
		[FieldOffset(Offset = "0x78")]
		private List<Vector2> m_resultOrigin;

		// Token: 0x04010CE6 RID: 68838
		[Token(Token = "0x4010CE6")]
		[FieldOffset(Offset = "0x80")]
		private List<Tile> m_inputTiles;

		// Token: 0x04010CE7 RID: 68839
		[Token(Token = "0x4010CE7")]
		[FieldOffset(Offset = "0x88")]
		private List<Vector2> m_input;

		// Token: 0x04010CE8 RID: 68840
		[Token(Token = "0x4010CE8")]
		[FieldOffset(Offset = "0x90")]
		private List<Vector2> m_result;

		// Token: 0x04010CE9 RID: 68841
		[Token(Token = "0x4010CE9")]
		[FieldOffset(Offset = "0x98")]
		private List<Vector2> m_stack;

		// Token: 0x04010CEA RID: 68842
		[Token(Token = "0x4010CEA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_extendable;

		// Token: 0x04010CEB RID: 68843
		[Token(Token = "0x4010CEB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_inputPoints;

		// Token: 0x04010CEC RID: 68844
		[Token(Token = "0x4010CEC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_resultForEffect;

		// Token: 0x04010CED RID: 68845
		[Token(Token = "0x4010CED")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CheckTargetIn;

		// Token: 0x04010CEE RID: 68846
		[Token(Token = "0x4010CEE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_FetchColliders;

		// Token: 0x04010CEF RID: 68847
		[Token(Token = "0x4010CEF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdateExtend;

		// Token: 0x04010CF0 RID: 68848
		[Token(Token = "0x4010CF0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04010CF1 RID: 68849
		[Token(Token = "0x4010CF1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_DoFindTargets_DISPOSE;

		// Token: 0x04010CF2 RID: 68850
		[Token(Token = "0x4010CF2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_InitPolygonCollidersIfNot;

		// Token: 0x04010CF3 RID: 68851
		[Token(Token = "0x4010CF3")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DoCalculateHull;

		// Token: 0x04010CF4 RID: 68852
		[Token(Token = "0x4010CF4")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OptimizeLineCollider;

		// Token: 0x04010CF5 RID: 68853
		[Token(Token = "0x4010CF5")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__Cross;

		// Token: 0x04010CF6 RID: 68854
		[Token(Token = "0x4010CF6")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetBoxColliderData;

		// Token: 0x04010CF7 RID: 68855
		[Token(Token = "0x4010CF7")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__SetBoxCollider;

		// Token: 0x04010CF8 RID: 68856
		[Token(Token = "0x4010CF8")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
