using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.GraphicEffect.Reflection
{
	// Token: 0x02001635 RID: 5685
	[Token(Token = "0x2001635")]
	public class ReflectCameraHolder : IHotfixable
	{
		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06008101 RID: 33025 RVA: 0x00038508 File Offset: 0x00036708
		[Token(Token = "0x17000F47")]
		public bool holded
		{
			[Token(Token = "0x6008101")]
			[Address(RVA = "0x2B0BF00", Offset = "0x2B0AB00", VA = "0x182B0BF00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06008102 RID: 33026 RVA: 0x00038520 File Offset: 0x00036720
		[Token(Token = "0x17000F48")]
		public virtual bool reflectEnable
		{
			[Token(Token = "0x6008102")]
			[Address(RVA = "0x2B0BF90", Offset = "0x2B0AB90", VA = "0x182B0BF90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06008103 RID: 33027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008103")]
		[Address(RVA = "0x2B0BE30", Offset = "0x2B0AA30", VA = "0x182B0BE30")]
		public ReflectCameraHolder(HGReflectionShaderProfile shaderProfile)
		{
		}

		// Token: 0x06008104 RID: 33028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008104")]
		[Address(RVA = "0x2B0B0D0", Offset = "0x2B09CD0", VA = "0x182B0B0D0")]
		public void HoldCamera(ReflectCamera camera, bool forceActive = false)
		{
		}

		// Token: 0x06008105 RID: 33029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6008105")]
		[Address(RVA = "0x2B0B3D0", Offset = "0x2B09FD0", VA = "0x182B0B3D0")]
		public ReflectCamera ReleaseCamera()
		{
			return null;
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008106")]
		[Address(RVA = "0x2B0B2F0", Offset = "0x2B09EF0", VA = "0x182B0B2F0")]
		public void RegisterReflectObject(MeshRenderer renderer)
		{
		}

		// Token: 0x06008107 RID: 33031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008107")]
		[Address(RVA = "0x2B0B7E0", Offset = "0x2B0A3E0", VA = "0x182B0B7E0")]
		public void UnregisterReflectObject(MeshRenderer renderer)
		{
		}

		// Token: 0x06008108 RID: 33032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008108")]
		[Address(RVA = "0x2B0B630", Offset = "0x2B0A230", VA = "0x182B0B630")]
		public void Setup(Camera mainCamera, Renderer floorRenderer, MeshRenderer bound, float floorReflectFadeHeight)
		{
		}

		// Token: 0x06008109 RID: 33033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6008109")]
		[Address(RVA = "0x2B0BA90", Offset = "0x2B0A690", VA = "0x182B0BA90")]
		private void _ApplyReflect()
		{
		}

		// Token: 0x0600810A RID: 33034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600810A")]
		[Address(RVA = "0x2B0B4C0", Offset = "0x2B0A0C0", VA = "0x182B0B4C0")]
		public void SetFloorRenderer(Renderer floorRenderer)
		{
		}

		// Token: 0x0600810B RID: 33035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600810B")]
		[Address(RVA = "0x2B0B8C0", Offset = "0x2B0A4C0", VA = "0x182B0B8C0")]
		private void _ApplyReflectFloor()
		{
		}

		// Token: 0x0600810C RID: 33036 RVA: 0x00038538 File Offset: 0x00036738
		[Token(Token = "0x600810C")]
		[Address(RVA = "0x2B0BD60", Offset = "0x2B0A960", VA = "0x182B0BD60")]
		private bool _CheckReflectable(Material mat)
		{
			return default(bool);
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600810D")]
		[Address(RVA = "0x2B0B060", Offset = "0x2B09C60", VA = "0x182B0B060")]
		public void EnableCamera()
		{
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600810E")]
		[Address(RVA = "0x2B0B170", Offset = "0x2B09D70", VA = "0x182B0B170")]
		protected void RefreshCameraEnable()
		{
		}

		// Token: 0x04008292 RID: 33426
		[Token(Token = "0x4008292")]
		[FieldOffset(Offset = "0x10")]
		protected ReflectCamera m_camera;

		// Token: 0x04008293 RID: 33427
		[Token(Token = "0x4008293")]
		[FieldOffset(Offset = "0x18")]
		private Camera m_mainCamera;

		// Token: 0x04008294 RID: 33428
		[Token(Token = "0x4008294")]
		[FieldOffset(Offset = "0x20")]
		private HGReflectionShaderProfile m_shaderProfile;

		// Token: 0x04008295 RID: 33429
		[Token(Token = "0x4008295")]
		[FieldOffset(Offset = "0x28")]
		private bool m_forceActive;

		// Token: 0x04008296 RID: 33430
		[Token(Token = "0x4008296")]
		[FieldOffset(Offset = "0x29")]
		private bool m_enabledByFloorMat;

		// Token: 0x04008297 RID: 33431
		[Token(Token = "0x4008297")]
		[FieldOffset(Offset = "0x2C")]
		private float m_floorReflectFadeHeight;

		// Token: 0x04008298 RID: 33432
		[Token(Token = "0x4008298")]
		[FieldOffset(Offset = "0x30")]
		private MeshRenderer m_floorReflectBound;

		// Token: 0x04008299 RID: 33433
		[Token(Token = "0x4008299")]
		[FieldOffset(Offset = "0x38")]
		private MeshRenderer m_floorRenderer;

		// Token: 0x0400829A RID: 33434
		[Token(Token = "0x400829A")]
		[FieldOffset(Offset = "0x40")]
		private HashSet<MeshRenderer> m_renderers;

		// Token: 0x0400829B RID: 33435
		[Token(Token = "0x400829B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_holded;

		// Token: 0x0400829C RID: 33436
		[Token(Token = "0x400829C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_reflectEnable;

		// Token: 0x0400829D RID: 33437
		[Token(Token = "0x400829D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400829E RID: 33438
		[Token(Token = "0x400829E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HoldCamera;

		// Token: 0x0400829F RID: 33439
		[Token(Token = "0x400829F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ReleaseCamera;

		// Token: 0x040082A0 RID: 33440
		[Token(Token = "0x40082A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterReflectObject;

		// Token: 0x040082A1 RID: 33441
		[Token(Token = "0x40082A1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UnregisterReflectObject;

		// Token: 0x040082A2 RID: 33442
		[Token(Token = "0x40082A2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x040082A3 RID: 33443
		[Token(Token = "0x40082A3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ApplyReflect;

		// Token: 0x040082A4 RID: 33444
		[Token(Token = "0x40082A4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetFloorRenderer;

		// Token: 0x040082A5 RID: 33445
		[Token(Token = "0x40082A5")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ApplyReflectFloor;

		// Token: 0x040082A6 RID: 33446
		[Token(Token = "0x40082A6")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CheckReflectable;

		// Token: 0x040082A7 RID: 33447
		[Token(Token = "0x40082A7")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EnableCamera;

		// Token: 0x040082A8 RID: 33448
		[Token(Token = "0x40082A8")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RefreshCameraEnable;
	}
}
