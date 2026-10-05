using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x02002049 RID: 8265
	[Token(Token = "0x2002049")]
	public class SceneCustomReflection : BaseSceneEffect
	{
		// Token: 0x0600CBA8 RID: 52136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBA8")]
		[Address(RVA = "0x34CA100", Offset = "0x34C8D00", VA = "0x1834CA100", Slot = "6")]
		protected override void OnLateInit()
		{
		}

		// Token: 0x0600CBA9 RID: 52137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBA9")]
		[Address(RVA = "0x34CA1E0", Offset = "0x34C8DE0", VA = "0x1834CA1E0")]
		private void Update()
		{
		}

		// Token: 0x0600CBAA RID: 52138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBAA")]
		[Address(RVA = "0x34C9F60", Offset = "0x34C8B60", VA = "0x1834C9F60", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CBAB RID: 52139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600CBAB")]
		[Address(RVA = "0x34CA910", Offset = "0x34C9510", VA = "0x1834CA910")]
		private Camera _CreateReflCamera(Camera sceneCamera)
		{
			return null;
		}

		// Token: 0x0600CBAC RID: 52140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBAC")]
		[Address(RVA = "0x34C9A30", Offset = "0x34C8630", VA = "0x1834C9A30")]
		private void InitReflection()
		{
		}

		// Token: 0x0600CBAD RID: 52141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBAD")]
		[Address(RVA = "0x34CAE50", Offset = "0x34C9A50", VA = "0x1834CAE50")]
		private void _UpdateReflectCamera()
		{
		}

		// Token: 0x0600CBAE RID: 52142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBAE")]
		[Address(RVA = "0x34CA330", Offset = "0x34C8F30", VA = "0x1834CA330")]
		private void _CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
		{
		}

		// Token: 0x0600CBAF RID: 52143 RVA: 0x00049A28 File Offset: 0x00047C28
		[Token(Token = "0x600CBAF")]
		[Address(RVA = "0x34CA4E0", Offset = "0x34C90E0", VA = "0x1834CA4E0")]
		private Vector4 _CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign, float clipPlaneOffset)
		{
			return default(Vector4);
		}

		// Token: 0x0600CBB0 RID: 52144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBB0")]
		[Address(RVA = "0x34C9DA0", Offset = "0x34C89A0", VA = "0x1834C9DA0", Slot = "4")]
		public override void OnCameraChanged(Camera old, Camera current)
		{
		}

		// Token: 0x0600CBB1 RID: 52145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBB1")]
		[Address(RVA = "0x34CADA0", Offset = "0x34C99A0", VA = "0x1834CADA0")]
		private void _InitCamera(Camera camera)
		{
		}

		// Token: 0x0600CBB2 RID: 52146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBB2")]
		[Address(RVA = "0x34CA860", Offset = "0x34C9460", VA = "0x1834CA860")]
		private void _ClearCurrentCamera()
		{
		}

		// Token: 0x0600CBB3 RID: 52147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBB3")]
		[Address(RVA = "0x34CB6A0", Offset = "0x34CA2A0", VA = "0x1834CB6A0")]
		public SceneCustomReflection()
		{
		}

		// Token: 0x0600CBB4 RID: 52148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBB4")]
		[Address(RVA = "0x34BE790", Offset = "0x34BD390", VA = "0x1834BE790")]
		private void <>xLuaBaseProxy_OnLateInit()
		{
		}

		// Token: 0x0600CBB5 RID: 52149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBB5")]
		[Address(RVA = "0x34BE6D0", Offset = "0x34BD2D0", VA = "0x1834BE6D0")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0600CBB6 RID: 52150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBB6")]
		[Address(RVA = "0x34BE650", Offset = "0x34BD250", VA = "0x1834BE650")]
		private void <>xLuaBaseProxy_OnCameraChanged(Camera P0, Camera P1)
		{
		}

		// Token: 0x0400D608 RID: 54792
		[Token(Token = "0x400D608")]
		[FieldOffset(Offset = "0x20")]
		public GameObject reflectPlane;

		// Token: 0x0400D609 RID: 54793
		[Token(Token = "0x400D609")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture reflectRT;

		// Token: 0x0400D60A RID: 54794
		[Token(Token = "0x400D60A")]
		[FieldOffset(Offset = "0x30")]
		public Shader replaceShader;

		// Token: 0x0400D60B RID: 54795
		[Token(Token = "0x400D60B")]
		[FieldOffset(Offset = "0x38")]
		public Material reflectMat;

		// Token: 0x0400D60C RID: 54796
		[Token(Token = "0x400D60C")]
		[FieldOffset(Offset = "0x40")]
		[Range(1f, 4f)]
		public int downScale;

		// Token: 0x0400D60D RID: 54797
		[Token(Token = "0x400D60D")]
		[FieldOffset(Offset = "0x44")]
		public float refPlaneOffset;

		// Token: 0x0400D60E RID: 54798
		[Token(Token = "0x400D60E")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 7f)]
		public int reflectRoughness;

		// Token: 0x0400D60F RID: 54799
		[Token(Token = "0x400D60F")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 2f)]
		public float reflectIntensity;

		// Token: 0x0400D610 RID: 54800
		[Token(Token = "0x400D610")]
		[FieldOffset(Offset = "0x50")]
		public bool isUpdate;

		// Token: 0x0400D611 RID: 54801
		[Token(Token = "0x400D611")]
		[FieldOffset(Offset = "0x58")]
		private Camera m_camera;

		// Token: 0x0400D612 RID: 54802
		[Token(Token = "0x400D612")]
		[FieldOffset(Offset = "0x60")]
		private Camera m_reflCamera;

		// Token: 0x0400D613 RID: 54803
		[Token(Token = "0x400D613")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_oldPos;

		// Token: 0x0400D614 RID: 54804
		[Token(Token = "0x400D614")]
		[FieldOffset(Offset = "0x74")]
		private bool m_inited;

		// Token: 0x0400D615 RID: 54805
		[Token(Token = "0x400D615")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnLateInit;

		// Token: 0x0400D616 RID: 54806
		[Token(Token = "0x400D616")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D617 RID: 54807
		[Token(Token = "0x400D617")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D618 RID: 54808
		[Token(Token = "0x400D618")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CreateReflCamera;

		// Token: 0x0400D619 RID: 54809
		[Token(Token = "0x400D619")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_InitReflection;

		// Token: 0x0400D61A RID: 54810
		[Token(Token = "0x400D61A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateReflectCamera;

		// Token: 0x0400D61B RID: 54811
		[Token(Token = "0x400D61B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalculateReflectionMatrix;

		// Token: 0x0400D61C RID: 54812
		[Token(Token = "0x400D61C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CameraSpacePlane;

		// Token: 0x0400D61D RID: 54813
		[Token(Token = "0x400D61D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnCameraChanged;

		// Token: 0x0400D61E RID: 54814
		[Token(Token = "0x400D61E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__InitCamera;

		// Token: 0x0400D61F RID: 54815
		[Token(Token = "0x400D61F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClearCurrentCamera;

		// Token: 0x0400D620 RID: 54816
		[Token(Token = "0x400D620")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
