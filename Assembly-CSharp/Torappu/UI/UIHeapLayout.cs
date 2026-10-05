using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x020038E7 RID: 14567
	[Token(Token = "0x20038E7")]
	[RequireComponent(typeof(RectTransform))]
	public class UIHeapLayout : LayoutGroup
	{
		// Token: 0x06017075 RID: 94325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017075")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "29")]
		public override void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x06017076 RID: 94326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017076")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "37")]
		public override void SetLayoutHorizontal()
		{
		}

		// Token: 0x06017077 RID: 94327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017077")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "38")]
		public override void SetLayoutVertical()
		{
		}

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x06017078 RID: 94328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170036F0")]
		public RectTransform rectTrans
		{
			[Token(Token = "0x6017078")]
			[Address(RVA = "0xF76160", Offset = "0xF74D60", VA = "0x180F76160")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017079 RID: 94329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017079")]
		[Address(RVA = "0xF75B70", Offset = "0xF74770", VA = "0x180F75B70")]
		[Inspect(Level = 2)]
		public void ResetRandomLayout()
		{
		}

		// Token: 0x0601707A RID: 94330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601707A")]
		[Address(RVA = "0xF75B30", Offset = "0xF74730", VA = "0x180F75B30", Slot = "10")]
		protected override void OnRectTransformDimensionsChange()
		{
		}

		// Token: 0x0601707B RID: 94331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601707B")]
		[Address(RVA = "0xF75B50", Offset = "0xF74750", VA = "0x180F75B50", Slot = "39")]
		protected override void OnTransformChildrenChanged()
		{
		}

		// Token: 0x0601707C RID: 94332 RVA: 0x000946B0 File Offset: 0x000928B0
		[Token(Token = "0x601707C")]
		[Address(RVA = "0xF75910", Offset = "0xF74510", VA = "0x180F75910", Slot = "40")]
		protected virtual Vector2 GetPosition(RectTransform child, int index)
		{
			return default(Vector2);
		}

		// Token: 0x0601707D RID: 94333 RVA: 0x000946C8 File Offset: 0x000928C8
		[Token(Token = "0x601707D")]
		[Address(RVA = "0xF75A70", Offset = "0xF74670", VA = "0x180F75A70", Slot = "41")]
		protected virtual Quaternion GetRotation(RectTransform child, int index)
		{
			return default(Quaternion);
		}

		// Token: 0x0601707E RID: 94334 RVA: 0x000946E0 File Offset: 0x000928E0
		[Token(Token = "0x601707E")]
		[Address(RVA = "0xF758A0", Offset = "0xF744A0", VA = "0x180F758A0")]
		protected float GetNormalRandomFactor(float normalSize)
		{
			return 0f;
		}

		// Token: 0x0601707F RID: 94335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601707F")]
		[Address(RVA = "0xF75BE0", Offset = "0xF747E0", VA = "0x180F75BE0")]
		private void _RelayoutChildren()
		{
		}

		// Token: 0x06017080 RID: 94336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017080")]
		[Address(RVA = "0xF760C0", Offset = "0xF74CC0", VA = "0x180F760C0")]
		public UIHeapLayout()
		{
		}

		// Token: 0x0401BCD6 RID: 113878
		[Token(Token = "0x401BCD6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Normal Distribution")]
		private float _normalExpectation;

		// Token: 0x0401BCD7 RID: 113879
		[Token(Token = "0x401BCD7")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Range(0.4f, 2f)]
		[Group("Normal Distribution")]
		private float _normalVariance;

		// Token: 0x0401BCD8 RID: 113880
		[Token(Token = "0x401BCD8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Range(1f, 3f)]
		[Group("Normal Distribution")]
		private float _positionNormalSize;

		// Token: 0x0401BCD9 RID: 113881
		[Token(Token = "0x401BCD9")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		[Range(1f, 3f)]
		[Group("Normal Distribution")]
		private float _rotationNormalSize;

		// Token: 0x0401BCDA RID: 113882
		[Token(Token = "0x401BCDA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float _maxRotationAngle;

		// Token: 0x0401BCDB RID: 113883
		[Token(Token = "0x401BCDB")]
		[FieldOffset(Offset = "0x70")]
		private RectTransform m_rectTrans;

		// Token: 0x0401BCDC RID: 113884
		[Token(Token = "0x401BCDC")]
		[FieldOffset(Offset = "0x78")]
		private ListDict<int, UIHeapLayout.LayoutInfo> m_childrenInfo;

		// Token: 0x020038E8 RID: 14568
		[Token(Token = "0x20038E8")]
		private class LayoutInfo
		{
			// Token: 0x06017081 RID: 94337 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017081")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public LayoutInfo()
			{
			}

			// Token: 0x0401BCDD RID: 113885
			[Token(Token = "0x401BCDD")]
			[FieldOffset(Offset = "0x10")]
			public RectTransform rectTrans;

			// Token: 0x0401BCDE RID: 113886
			[Token(Token = "0x401BCDE")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 position;

			// Token: 0x0401BCDF RID: 113887
			[Token(Token = "0x401BCDF")]
			[FieldOffset(Offset = "0x20")]
			public Quaternion rotation;
		}
	}
}
