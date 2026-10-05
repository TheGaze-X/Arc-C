using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200008C RID: 140
	[Token(Token = "0x200008C")]
	public sealed class ColorGradingComponent : PostProcessingComponentRenderTexture<ColorGradingModel>
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060002DA RID: 730 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x1700003A")]
		public override bool active
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x52F6630", Offset = "0x52F5230", VA = "0x1852F6630", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x52F65C0", Offset = "0x52F51C0", VA = "0x1852F65C0")]
		private float StandardIlluminantY(float x)
		{
			return 0f;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x52F3DD0", Offset = "0x52F29D0", VA = "0x1852F3DD0")]
		private Vector3 CIExyToLMS(float x, float y)
		{
			return default(Vector3);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x52F3E60", Offset = "0x52F2A60", VA = "0x1852F3E60")]
		private Vector3 CalculateColorBalance(float temperature, float tint)
		{
			return default(Vector3);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x52F5EF0", Offset = "0x52F4AF0", VA = "0x1852F5EF0")]
		private static Color NormalizeColor(Color c)
		{
			return default(Color);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x52F45F0", Offset = "0x52F31F0", VA = "0x1852F45F0")]
		private static Vector3 ClampVector(Vector3 v, float min, float max)
		{
			return default(Vector3);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x52F59D0", Offset = "0x52F45D0", VA = "0x1852F59D0")]
		public static Vector3 GetLiftValue(Color lift)
		{
			return default(Vector3);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x52F57C0", Offset = "0x52F43C0", VA = "0x1852F57C0")]
		public static Vector3 GetGammaValue(Color gamma)
		{
			return default(Vector3);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x52F5620", Offset = "0x52F4220", VA = "0x1852F5620")]
		public static Vector3 GetGainValue(Color gain)
		{
			return default(Vector3);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x52F3F80", Offset = "0x52F2B80", VA = "0x1852F3F80")]
		public static void CalculateLiftGammaGain(Color lift, Color gamma, Color gain, out Vector3 outLift, out Vector3 outGamma, out Vector3 outGain)
		{
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x52F5D40", Offset = "0x52F4940", VA = "0x1852F5D40")]
		public static Vector3 GetSlopeValue(Color slope)
		{
			return default(Vector3);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x52F5BC0", Offset = "0x52F47C0", VA = "0x1852F5BC0")]
		public static Vector3 GetPowerValue(Color power)
		{
			return default(Vector3);
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x52F5AC0", Offset = "0x52F46C0", VA = "0x1852F5AC0")]
		public static Vector3 GetOffsetValue(Color offset)
		{
			return default(Vector3);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x52F4270", Offset = "0x52F2E70", VA = "0x1852F4270")]
		public static void CalculateSlopePowerOffset(Color slope, Color power, Color offset, out Vector3 outSlope, out Vector3 outPower, out Vector3 outOffset)
		{
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x52F51C0", Offset = "0x52F3DC0", VA = "0x1852F51C0")]
		private Texture2D GetCurveTexture()
		{
			return null;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x52F5E50", Offset = "0x52F4A50", VA = "0x1852F5E50")]
		private bool IsLogLutValid(RenderTexture lut)
		{
			return default(bool);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x52F4660", Offset = "0x52F3260", VA = "0x1852F4660")]
		private void GenerateLut()
		{
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x52F6250", Offset = "0x52F4E50", VA = "0x1852F6250", Slot = "10")]
		public override void Prepare(Material uberMaterial)
		{
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x52F60C0", Offset = "0x52F4CC0", VA = "0x1852F60C0")]
		public void OnGUI()
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x52F6030", Offset = "0x52F4C30", VA = "0x1852F6030", Slot = "7")]
		public override void OnDisable()
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x52F65F0", Offset = "0x52F51F0", VA = "0x1852F65F0")]
		public ColorGradingComponent()
		{
		}

		// Token: 0x04000380 RID: 896
		[Token(Token = "0x4000380")]
		private const int k_InternalLogLutSize = 32;

		// Token: 0x04000381 RID: 897
		[Token(Token = "0x4000381")]
		private const int k_CurvePrecision = 128;

		// Token: 0x04000382 RID: 898
		[Token(Token = "0x4000382")]
		private const float k_CurveStep = 0.0078125f;

		// Token: 0x04000383 RID: 899
		[Token(Token = "0x4000383")]
		[FieldOffset(Offset = "0x20")]
		private Texture2D m_GradingCurves;

		// Token: 0x0200008D RID: 141
		[Token(Token = "0x200008D")]
		private static class Uniforms
		{
			// Token: 0x04000384 RID: 900
			[Token(Token = "0x4000384")]
			[FieldOffset(Offset = "0x0")]
			internal static readonly int _LutParams;

			// Token: 0x04000385 RID: 901
			[Token(Token = "0x4000385")]
			[FieldOffset(Offset = "0x4")]
			internal static readonly int _NeutralTonemapperParams1;

			// Token: 0x04000386 RID: 902
			[Token(Token = "0x4000386")]
			[FieldOffset(Offset = "0x8")]
			internal static readonly int _NeutralTonemapperParams2;

			// Token: 0x04000387 RID: 903
			[Token(Token = "0x4000387")]
			[FieldOffset(Offset = "0xC")]
			internal static readonly int _HueShift;

			// Token: 0x04000388 RID: 904
			[Token(Token = "0x4000388")]
			[FieldOffset(Offset = "0x10")]
			internal static readonly int _Saturation;

			// Token: 0x04000389 RID: 905
			[Token(Token = "0x4000389")]
			[FieldOffset(Offset = "0x14")]
			internal static readonly int _Contrast;

			// Token: 0x0400038A RID: 906
			[Token(Token = "0x400038A")]
			[FieldOffset(Offset = "0x18")]
			internal static readonly int _Balance;

			// Token: 0x0400038B RID: 907
			[Token(Token = "0x400038B")]
			[FieldOffset(Offset = "0x1C")]
			internal static readonly int _Lift;

			// Token: 0x0400038C RID: 908
			[Token(Token = "0x400038C")]
			[FieldOffset(Offset = "0x20")]
			internal static readonly int _InvGamma;

			// Token: 0x0400038D RID: 909
			[Token(Token = "0x400038D")]
			[FieldOffset(Offset = "0x24")]
			internal static readonly int _Gain;

			// Token: 0x0400038E RID: 910
			[Token(Token = "0x400038E")]
			[FieldOffset(Offset = "0x28")]
			internal static readonly int _Slope;

			// Token: 0x0400038F RID: 911
			[Token(Token = "0x400038F")]
			[FieldOffset(Offset = "0x2C")]
			internal static readonly int _Power;

			// Token: 0x04000390 RID: 912
			[Token(Token = "0x4000390")]
			[FieldOffset(Offset = "0x30")]
			internal static readonly int _Offset;

			// Token: 0x04000391 RID: 913
			[Token(Token = "0x4000391")]
			[FieldOffset(Offset = "0x34")]
			internal static readonly int _ChannelMixerRed;

			// Token: 0x04000392 RID: 914
			[Token(Token = "0x4000392")]
			[FieldOffset(Offset = "0x38")]
			internal static readonly int _ChannelMixerGreen;

			// Token: 0x04000393 RID: 915
			[Token(Token = "0x4000393")]
			[FieldOffset(Offset = "0x3C")]
			internal static readonly int _ChannelMixerBlue;

			// Token: 0x04000394 RID: 916
			[Token(Token = "0x4000394")]
			[FieldOffset(Offset = "0x40")]
			internal static readonly int _Curves;

			// Token: 0x04000395 RID: 917
			[Token(Token = "0x4000395")]
			[FieldOffset(Offset = "0x44")]
			internal static readonly int _LogLut;

			// Token: 0x04000396 RID: 918
			[Token(Token = "0x4000396")]
			[FieldOffset(Offset = "0x48")]
			internal static readonly int _LogLut_Params;

			// Token: 0x04000397 RID: 919
			[Token(Token = "0x4000397")]
			[FieldOffset(Offset = "0x4C")]
			internal static readonly int _ExposureEV;
		}
	}
}
