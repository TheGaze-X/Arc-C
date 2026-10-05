using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Fx
{
	// Token: 0x0200203A RID: 8250
	[Token(Token = "0x200203A")]
	[RequireComponent(typeof(Renderer))]
	[ExecuteInEditMode]
	public class FxUVRotation : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x0600CB4D RID: 52045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001811")]
		private Material activeMaterial
		{
			[Token(Token = "0x600CB4D")]
			[Address(RVA = "0x34C4FC0", Offset = "0x34C3BC0", VA = "0x1834C4FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x0600CB4E RID: 52046 RVA: 0x00049830 File Offset: 0x00047A30
		[Token(Token = "0x17001812")]
		private bool rotateTex1
		{
			[Token(Token = "0x600CB4E")]
			[Address(RVA = "0x34C50B0", Offset = "0x34C3CB0", VA = "0x1834C50B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x0600CB4F RID: 52047 RVA: 0x00049848 File Offset: 0x00047A48
		[Token(Token = "0x17001813")]
		private bool rotateTex2
		{
			[Token(Token = "0x600CB4F")]
			[Address(RVA = "0x34C5120", Offset = "0x34C3D20", VA = "0x1834C5120")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x0600CB50 RID: 52048 RVA: 0x00049860 File Offset: 0x00047A60
		[Token(Token = "0x17001814")]
		private bool rotateTex3
		{
			[Token(Token = "0x600CB50")]
			[Address(RVA = "0x34C5190", Offset = "0x34C3D90", VA = "0x1834C5190")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x0600CB51 RID: 52049 RVA: 0x00049878 File Offset: 0x00047A78
		[Token(Token = "0x17001815")]
		private bool rotateTex4
		{
			[Token(Token = "0x600CB51")]
			[Address(RVA = "0x34C5200", Offset = "0x34C3E00", VA = "0x1834C5200")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CB52 RID: 52050 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB52")]
		[Address(RVA = "0x34C46F0", Offset = "0x34C32F0", VA = "0x1834C46F0")]
		private void Awake()
		{
		}

		// Token: 0x0600CB53 RID: 52051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB53")]
		[Address(RVA = "0x34C4870", Offset = "0x34C3470", VA = "0x1834C4870")]
		private void Update()
		{
		}

		// Token: 0x0600CB54 RID: 52052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB54")]
		[Address(RVA = "0x34C4C70", Offset = "0x34C3870", VA = "0x1834C4C70")]
		private void _Initialize()
		{
		}

		// Token: 0x0600CB55 RID: 52053 RVA: 0x00049890 File Offset: 0x00047A90
		[Token(Token = "0x600CB55")]
		[Address(RVA = "0x34C4B80", Offset = "0x34C3780", VA = "0x1834C4B80")]
		private Vector4 _CalculateMatrix(float angle)
		{
			return default(Vector4);
		}

		// Token: 0x0600CB56 RID: 52054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB56")]
		[Address(RVA = "0x34C47B0", Offset = "0x34C33B0", VA = "0x1834C47B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600CB57 RID: 52055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB57")]
		[Address(RVA = "0x34C4F20", Offset = "0x34C3B20", VA = "0x1834C4F20")]
		public FxUVRotation()
		{
		}

		// Token: 0x0400D55E RID: 54622
		[Token(Token = "0x400D55E")]
		private const string HG_UV_ROTATION_KEYWORD = "_HG_UV_ROTATION";

		// Token: 0x0400D55F RID: 54623
		[Token(Token = "0x400D55F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector4 IDENTITY;

		// Token: 0x0400D560 RID: 54624
		[Token(Token = "0x400D560")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _propertyName;

		// Token: 0x0400D561 RID: 54625
		[Token(Token = "0x400D561")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _rotateTex1;

		// Token: 0x0400D562 RID: 54626
		[Token(Token = "0x400D562")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Inspect("rotateTex1")]
		private float angle1;

		// Token: 0x0400D563 RID: 54627
		[Token(Token = "0x400D563")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _rotateTex2;

		// Token: 0x0400D564 RID: 54628
		[Token(Token = "0x400D564")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Inspect("rotateTex2")]
		private float _angle2;

		// Token: 0x0400D565 RID: 54629
		[Token(Token = "0x400D565")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _rotateTex3;

		// Token: 0x0400D566 RID: 54630
		[Token(Token = "0x400D566")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Inspect("rotateTex3")]
		private float _angle3;

		// Token: 0x0400D567 RID: 54631
		[Token(Token = "0x400D567")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _rotateTex4;

		// Token: 0x0400D568 RID: 54632
		[Token(Token = "0x400D568")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Inspect("rotateTex4")]
		private float _angle4;

		// Token: 0x0400D569 RID: 54633
		[Token(Token = "0x400D569")]
		[FieldOffset(Offset = "0x40")]
		private Material m_activeMaterial;

		// Token: 0x0400D56A RID: 54634
		[Token(Token = "0x400D56A")]
		[FieldOffset(Offset = "0x48")]
		private Renderer m_renderer;

		// Token: 0x0400D56B RID: 54635
		[Token(Token = "0x400D56B")]
		[FieldOffset(Offset = "0x50")]
		private int m_rotationPropertyID0;

		// Token: 0x0400D56C RID: 54636
		[Token(Token = "0x400D56C")]
		[FieldOffset(Offset = "0x54")]
		private int m_rotationPropertyID1;

		// Token: 0x0400D56D RID: 54637
		[Token(Token = "0x400D56D")]
		[FieldOffset(Offset = "0x58")]
		private int m_rotationPropertyID2;

		// Token: 0x0400D56E RID: 54638
		[Token(Token = "0x400D56E")]
		[FieldOffset(Offset = "0x5C")]
		private int m_rotationPropertyID3;

		// Token: 0x0400D56F RID: 54639
		[Token(Token = "0x400D56F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_activeMaterial;

		// Token: 0x0400D570 RID: 54640
		[Token(Token = "0x400D570")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_rotateTex1;

		// Token: 0x0400D571 RID: 54641
		[Token(Token = "0x400D571")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rotateTex2;

		// Token: 0x0400D572 RID: 54642
		[Token(Token = "0x400D572")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_rotateTex3;

		// Token: 0x0400D573 RID: 54643
		[Token(Token = "0x400D573")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_rotateTex4;

		// Token: 0x0400D574 RID: 54644
		[Token(Token = "0x400D574")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400D575 RID: 54645
		[Token(Token = "0x400D575")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D576 RID: 54646
		[Token(Token = "0x400D576")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__Initialize;

		// Token: 0x0400D577 RID: 54647
		[Token(Token = "0x400D577")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CalculateMatrix;

		// Token: 0x0400D578 RID: 54648
		[Token(Token = "0x400D578")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400D579 RID: 54649
		[Token(Token = "0x400D579")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
