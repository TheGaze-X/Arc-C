using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Rendering.Behaviours
{
	// Token: 0x02002076 RID: 8310
	[Token(Token = "0x2002076")]
	[RequireComponent(typeof(Camera))]
	public class BattleSceneCameraRTScaler : AbstractRenderBehaviour
	{
		// Token: 0x17001846 RID: 6214
		// (get) Token: 0x0600CCD1 RID: 52433 RVA: 0x00049E48 File Offset: 0x00048048
		[Token(Token = "0x17001846")]
		protected override bool isValid
		{
			[Token(Token = "0x600CCD1")]
			[Address(RVA = "0x34D00A0", Offset = "0x34CECA0", VA = "0x1834D00A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CCD2 RID: 52434 RVA: 0x00049E60 File Offset: 0x00048060
		[Token(Token = "0x600CCD2")]
		[Address(RVA = "0x34CF9A0", Offset = "0x34CE5A0", VA = "0x1834CF9A0", Slot = "5")]
		protected override bool DoApply()
		{
			return default(bool);
		}

		// Token: 0x0600CCD3 RID: 52435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCD3")]
		[Address(RVA = "0x34CFC50", Offset = "0x34CE850", VA = "0x1834CFC50", Slot = "6")]
		protected override void DoTerminate()
		{
		}

		// Token: 0x0600CCD4 RID: 52436 RVA: 0x00049E78 File Offset: 0x00048078
		[Token(Token = "0x600CCD4")]
		[Address(RVA = "0x34CFD50", Offset = "0x34CE950", VA = "0x1834CFD50")]
		protected Vector2 GetScaledTargetResolution()
		{
			return default(Vector2);
		}

		// Token: 0x0600CCD5 RID: 52437 RVA: 0x00049E90 File Offset: 0x00048090
		[Token(Token = "0x600CCD5")]
		[Address(RVA = "0x34CFF80", Offset = "0x34CEB80", VA = "0x1834CFF80")]
		private static bool _IsHighDPIMobileDevice()
		{
			return default(bool);
		}

		// Token: 0x0600CCD6 RID: 52438 RVA: 0x00049EA8 File Offset: 0x000480A8
		[Token(Token = "0x600CCD6")]
		[Address(RVA = "0x34CFED0", Offset = "0x34CEAD0", VA = "0x1834CFED0")]
		private static bool _DefineHighDPIMobileDevice(DeviceInfoUtil.SimulatorInfo simulatorInfo)
		{
			return default(bool);
		}

		// Token: 0x0600CCD7 RID: 52439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCD7")]
		[Address(RVA = "0x34CF920", Offset = "0x34CE520", VA = "0x1834CF920")]
		private void Awake()
		{
		}

		// Token: 0x0600CCD8 RID: 52440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CCD8")]
		[Address(RVA = "0x34D0000", Offset = "0x34CEC00", VA = "0x1834D0000")]
		public BattleSceneCameraRTScaler()
		{
		}

		// Token: 0x0400D80A RID: 55306
		[Token(Token = "0x400D80A")]
		private const float RESOLUTION_SCALER_RATIO = 0.8f;

		// Token: 0x0400D80B RID: 55307
		[Token(Token = "0x400D80B")]
		private const float LOW_DPI_THRESHOLD = 320f;

		// Token: 0x0400D80C RID: 55308
		[Token(Token = "0x400D80C")]
		private const float UNSCALED_DPI_THRESHOLD = 400f;

		// Token: 0x0400D80D RID: 55309
		[Token(Token = "0x400D80D")]
		[FieldOffset(Offset = "0x20")]
		private Camera m_camera;

		// Token: 0x0400D80E RID: 55310
		[Token(Token = "0x400D80E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isValid;

		// Token: 0x0400D80F RID: 55311
		[Token(Token = "0x400D80F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoApply;

		// Token: 0x0400D810 RID: 55312
		[Token(Token = "0x400D810")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoTerminate;

		// Token: 0x0400D811 RID: 55313
		[Token(Token = "0x400D811")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetScaledTargetResolution;

		// Token: 0x0400D812 RID: 55314
		[Token(Token = "0x400D812")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsHighDPIMobileDevice;

		// Token: 0x0400D813 RID: 55315
		[Token(Token = "0x400D813")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DefineHighDPIMobileDevice;

		// Token: 0x0400D814 RID: 55316
		[Token(Token = "0x400D814")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400D815 RID: 55317
		[Token(Token = "0x400D815")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
