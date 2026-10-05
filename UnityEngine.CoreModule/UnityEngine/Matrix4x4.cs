using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D3 RID: 211
	[Token(Token = "0x20000D3")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeClass("Matrix4x4f")]
	[Il2CppEagerStaticClassConstruction]
	[NativeType(Header = "Runtime/Math/Matrix4x4.h")]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	public struct Matrix4x4 : IEquatable<Matrix4x4>, IFormattable
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x594D7C0", Offset = "0x594C3C0", VA = "0x18594D7C0")]
		[ThreadSafe]
		private Quaternion GetRotation()
		{
			return default(Quaternion);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x594D6F0", Offset = "0x594C2F0", VA = "0x18594D6F0")]
		[ThreadSafe]
		private Vector3 GetLossyScale()
		{
			return default(Vector3);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x594D4C0", Offset = "0x594C0C0", VA = "0x18594D4C0")]
		[ThreadSafe]
		private float GetDeterminant()
		{
			return 0f;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x594CFB0", Offset = "0x594BBB0", VA = "0x18594CFB0")]
		[ThreadSafe]
		private FrustumPlanes DecomposeProjection()
		{
			return default(FrustumPlanes);
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x170001A8")]
		public Quaternion rotation
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x594EFF0", Offset = "0x594DBF0", VA = "0x18594EFF0")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000700 RID: 1792 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x170001A9")]
		public Vector3 lossyScale
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x594EF80", Offset = "0x594DB80", VA = "0x18594EF80")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x170001AA")]
		public float determinant
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x594D4C0", Offset = "0x594C0C0", VA = "0x18594D4C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x06000702 RID: 1794 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x170001AB")]
		public FrustumPlanes decomposeProjection
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x594EE00", Offset = "0x594DA00", VA = "0x18594EE00")]
			get
			{
				return default(FrustumPlanes);
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x594E2F0", Offset = "0x594CEF0", VA = "0x18594E2F0")]
		[FreeFunction("MatrixScripting::TRS", IsThreadSafe = true)]
		public static Matrix4x4 TRS(Vector3 pos, Quaternion q, Vector3 s)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x594E1C0", Offset = "0x594CDC0", VA = "0x18594E1C0")]
		public void SetTRS(Vector3 pos, Quaternion q, Vector3 s)
		{
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x594D960", Offset = "0x594C560", VA = "0x18594D960")]
		[FreeFunction("MatrixScripting::Inverse3DAffine", IsThreadSafe = true)]
		public static bool Inverse3DAffine(Matrix4x4 input, ref Matrix4x4 result)
		{
			return default(bool);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x594DA00", Offset = "0x594C600", VA = "0x18594DA00")]
		[FreeFunction("MatrixScripting::Inverse", IsThreadSafe = true)]
		public static Matrix4x4 Inverse(Matrix4x4 m)
		{
			return default(Matrix4x4);
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x170001AC")]
		public Matrix4x4 inverse
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x594EED0", Offset = "0x594DAD0", VA = "0x18594EED0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x594DD20", Offset = "0x594C920", VA = "0x18594DD20")]
		[FreeFunction("MatrixScripting::Ortho", IsThreadSafe = true)]
		public static Matrix4x4 Ortho(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x594DE50", Offset = "0x594CA50", VA = "0x18594DE50")]
		[FreeFunction("MatrixScripting::Perspective", IsThreadSafe = true)]
		public static Matrix4x4 Perspective(float fov, float aspect, float zNear, float zFar)
		{
			return default(Matrix4x4);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x594D340", Offset = "0x594BF40", VA = "0x18594D340")]
		[FreeFunction("MatrixScripting::Frustum", IsThreadSafe = true)]
		public static Matrix4x4 Frustum(float left, float right, float bottom, float top, float zNear, float zFar)
		{
			return default(Matrix4x4);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x594D250", Offset = "0x594BE50", VA = "0x18594D250")]
		public static Matrix4x4 Frustum(FrustumPlanes fp)
		{
			return default(Matrix4x4);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x594EC20", Offset = "0x594D820", VA = "0x18594EC20")]
		public Matrix4x4(Vector4 column0, Vector4 column1, Vector4 column2, Vector4 column3)
		{
		}

		// Token: 0x170001AD RID: 429
		[Token(Token = "0x170001AD")]
		public float this[int row, int column]
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x594EDF0", Offset = "0x594D9F0", VA = "0x18594EDF0")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600070E")]
			[Address(RVA = "0x594F8C0", Offset = "0x594E4C0", VA = "0x18594F8C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170001AE RID: 430
		[Token(Token = "0x170001AE")]
		public float this[int index]
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x594EC90", Offset = "0x594D890", VA = "0x18594EC90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000710")]
			[Address(RVA = "0x594F760", Offset = "0x594E360", VA = "0x18594F760")]
			set
			{
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x594D500", Offset = "0x594C100", VA = "0x18594D500", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x594D010", Offset = "0x594BC10", VA = "0x18594D010", Slot = "0")]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x594D0C0", Offset = "0x594BCC0", VA = "0x18594D0C0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(Matrix4x4 other)
		{
			return default(bool);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x594F220", Offset = "0x594DE20", VA = "0x18594F220")]
		public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
		{
			return default(Matrix4x4);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x594F0B0", Offset = "0x594DCB0", VA = "0x18594F0B0")]
		public static Vector4 operator *(Matrix4x4 lhs, Vector4 vector)
		{
			return default(Vector4);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x594D3F0", Offset = "0x594BFF0", VA = "0x18594D3F0")]
		public Vector4 GetColumn(int index)
		{
			return default(Vector4);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x594D810", Offset = "0x594C410", VA = "0x18594D810")]
		public Vector4 GetRow(int index)
		{
			return default(Vector4);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x594D740", Offset = "0x594C340", VA = "0x18594D740")]
		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x594E150", Offset = "0x594CD50", VA = "0x18594E150")]
		public void SetRow(int index, Vector4 row)
		{
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x594DB10", Offset = "0x594C710", VA = "0x18594DB10")]
		public Vector3 MultiplyPoint(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x594DA60", Offset = "0x594C660", VA = "0x18594DA60")]
		public Vector3 MultiplyPoint3x4(Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x594DC00", Offset = "0x594C800", VA = "0x18594DC00")]
		public Vector3 MultiplyVector(Vector3 vector)
		{
			return default(Vector3);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x594E0A0", Offset = "0x594CCA0", VA = "0x18594E0A0")]
		public static Matrix4x4 Scale(Vector3 vector)
		{
			return default(Matrix4x4);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x594EA60", Offset = "0x594D660", VA = "0x18594EA60")]
		public static Matrix4x4 Translate(Vector3 vector)
		{
			return default(Matrix4x4);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x594DEE0", Offset = "0x594CAE0", VA = "0x18594DEE0")]
		public static Matrix4x4 Rotate(Quaternion q)
		{
			return default(Matrix4x4);
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000720 RID: 1824 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x170001AF")]
		public static Matrix4x4 zero
		{
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x594F050", Offset = "0x594DC50", VA = "0x18594F050")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x170001B0")]
		public static Matrix4x4 identity
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x594EE70", Offset = "0x594DA70", VA = "0x18594EE70")]
			[MethodImpl(256)]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x594E370", Offset = "0x594CF70", VA = "0x18594E370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x594E380", Offset = "0x594CF80", VA = "0x18594E380", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06000725 RID: 1829
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x594D770", Offset = "0x594C370", VA = "0x18594D770")]
		[MethodImpl(4096)]
		private static extern void GetRotation_Injected(ref Matrix4x4 _unity_self, out Quaternion ret);

		// Token: 0x06000726 RID: 1830
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x594D6A0", Offset = "0x594C2A0", VA = "0x18594D6A0")]
		[MethodImpl(4096)]
		private static extern void GetLossyScale_Injected(ref Matrix4x4 _unity_self, out Vector3 ret);

		// Token: 0x06000727 RID: 1831
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x594D4C0", Offset = "0x594C0C0", VA = "0x18594D4C0")]
		[MethodImpl(4096)]
		private static extern float GetDeterminant_Injected(ref Matrix4x4 _unity_self);

		// Token: 0x06000728 RID: 1832
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x594CF60", Offset = "0x594BB60", VA = "0x18594CF60")]
		[MethodImpl(4096)]
		private static extern void DecomposeProjection_Injected(ref Matrix4x4 _unity_self, out FrustumPlanes ret);

		// Token: 0x06000729 RID: 1833
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x594E280", Offset = "0x594CE80", VA = "0x18594E280")]
		[MethodImpl(4096)]
		private static extern void TRS_Injected(ref Vector3 pos, ref Quaternion q, ref Vector3 s, out Matrix4x4 ret);

		// Token: 0x0600072A RID: 1834
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x594D910", Offset = "0x594C510", VA = "0x18594D910")]
		[MethodImpl(4096)]
		private static extern bool Inverse3DAffine_Injected(ref Matrix4x4 input, ref Matrix4x4 result);

		// Token: 0x0600072B RID: 1835
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x594D9B0", Offset = "0x594C5B0", VA = "0x18594D9B0")]
		[MethodImpl(4096)]
		private static extern void Inverse_Injected(ref Matrix4x4 m, out Matrix4x4 ret);

		// Token: 0x0600072C RID: 1836
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x594DCA0", Offset = "0x594C8A0", VA = "0x18594DCA0")]
		[MethodImpl(4096)]
		private static extern void Ortho_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret);

		// Token: 0x0600072D RID: 1837
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x594DDD0", Offset = "0x594C9D0", VA = "0x18594DDD0")]
		[MethodImpl(4096)]
		private static extern void Perspective_Injected(float fov, float aspect, float zNear, float zFar, out Matrix4x4 ret);

		// Token: 0x0600072E RID: 1838
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x594D1D0", Offset = "0x594BDD0", VA = "0x18594D1D0")]
		[MethodImpl(4096)]
		private static extern void Frustum_Injected(float left, float right, float bottom, float top, float zNear, float zFar, out Matrix4x4 ret);

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x0")]
		[NativeName("m_Data[0]")]
		public float m00;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x4")]
		[NativeName("m_Data[1]")]
		public float m10;

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x8")]
		[NativeName("m_Data[2]")]
		public float m20;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0xC")]
		[NativeName("m_Data[3]")]
		public float m30;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x10")]
		[NativeName("m_Data[4]")]
		public float m01;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x14")]
		[NativeName("m_Data[5]")]
		public float m11;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x18")]
		[NativeName("m_Data[6]")]
		public float m21;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x1C")]
		[NativeName("m_Data[7]")]
		public float m31;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x20")]
		[NativeName("m_Data[8]")]
		public float m02;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x24")]
		[NativeName("m_Data[9]")]
		public float m12;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x28")]
		[NativeName("m_Data[10]")]
		public float m22;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x2C")]
		[NativeName("m_Data[11]")]
		public float m32;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x30")]
		[NativeName("m_Data[12]")]
		public float m03;

		// Token: 0x04000432 RID: 1074
		[Token(Token = "0x4000432")]
		[FieldOffset(Offset = "0x34")]
		[NativeName("m_Data[13]")]
		public float m13;

		// Token: 0x04000433 RID: 1075
		[Token(Token = "0x4000433")]
		[FieldOffset(Offset = "0x38")]
		[NativeName("m_Data[14]")]
		public float m23;

		// Token: 0x04000434 RID: 1076
		[Token(Token = "0x4000434")]
		[FieldOffset(Offset = "0x3C")]
		[NativeName("m_Data[15]")]
		public float m33;

		// Token: 0x04000435 RID: 1077
		[Token(Token = "0x4000435")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Matrix4x4 zeroMatrix;

		// Token: 0x04000436 RID: 1078
		[Token(Token = "0x4000436")]
		[FieldOffset(Offset = "0x40")]
		private static readonly Matrix4x4 identityMatrix;
	}
}
