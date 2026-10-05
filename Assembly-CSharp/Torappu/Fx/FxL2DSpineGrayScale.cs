using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Fx
{
	// Token: 0x02002035 RID: 8245
	[Token(Token = "0x2002035")]
	[ExecuteAlways]
	public class FxL2DSpineGrayScale : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x0600CB2B RID: 52011 RVA: 0x000497E8 File Offset: 0x000479E8
		[Token(Token = "0x1700180C")]
		private bool isDirty
		{
			[Token(Token = "0x600CB2B")]
			[Address(RVA = "0x34C2B30", Offset = "0x34C1730", VA = "0x1834C2B30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CB2C RID: 52012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB2C")]
		[Address(RVA = "0x34C2970", Offset = "0x34C1570", VA = "0x1834C2970")]
		private void _UpdateParams(float useGray, float grayScale)
		{
		}

		// Token: 0x0600CB2D RID: 52013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB2D")]
		[Address(RVA = "0x34C2620", Offset = "0x34C1220", VA = "0x1834C2620")]
		private void Awake()
		{
		}

		// Token: 0x0600CB2E RID: 52014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB2E")]
		[Address(RVA = "0x34C2800", Offset = "0x34C1400", VA = "0x1834C2800")]
		private void Update()
		{
		}

		// Token: 0x0600CB2F RID: 52015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB2F")]
		[Address(RVA = "0x34C2790", Offset = "0x34C1390", VA = "0x1834C2790")]
		private void OnDisable()
		{
		}

		// Token: 0x0600CB30 RID: 52016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB30")]
		[Address(RVA = "0x34C2A90", Offset = "0x34C1690", VA = "0x1834C2A90")]
		public FxL2DSpineGrayScale()
		{
		}

		// Token: 0x0400D520 RID: 54560
		[Token(Token = "0x400D520")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _grayScale;

		// Token: 0x0400D521 RID: 54561
		[Token(Token = "0x400D521")]
		[FieldOffset(Offset = "0x1C")]
		private readonly int m_useGrayPropID;

		// Token: 0x0400D522 RID: 54562
		[Token(Token = "0x400D522")]
		[FieldOffset(Offset = "0x20")]
		private readonly int m_grayScalePropID;

		// Token: 0x0400D523 RID: 54563
		[Token(Token = "0x400D523")]
		[FieldOffset(Offset = "0x28")]
		private Material[] m_spineMaterials;

		// Token: 0x0400D524 RID: 54564
		[Token(Token = "0x400D524")]
		[FieldOffset(Offset = "0x30")]
		private float m_currentGrayScale;

		// Token: 0x0400D525 RID: 54565
		[Token(Token = "0x400D525")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isDirty;

		// Token: 0x0400D526 RID: 54566
		[Token(Token = "0x400D526")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateParams;

		// Token: 0x0400D527 RID: 54567
		[Token(Token = "0x400D527")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400D528 RID: 54568
		[Token(Token = "0x400D528")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D529 RID: 54569
		[Token(Token = "0x400D529")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0400D52A RID: 54570
		[Token(Token = "0x400D52A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
