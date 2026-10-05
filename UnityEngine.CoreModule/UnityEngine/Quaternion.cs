using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	[NativeType(Header = "Runtime/Math/Quaternion.h")]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[UsedByNativeCode]
	[Il2CppEagerStaticClassConstruction]
	public struct Quaternion : IEquatable<Quaternion>, IFormattable
	{
		// Token: 0x06000774 RID: 1908 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x5950B20", Offset = "0x594F720", VA = "0x185950B20")]
		[FreeFunction("FromToQuaternionSafe", IsThreadSafe = true)]
		public static Quaternion FromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
			return default(Quaternion);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x5950E60", Offset = "0x594FA60", VA = "0x185950E60")]
		[FreeFunction(IsThreadSafe = true)]
		public static Quaternion Inverse(Quaternion rotation)
		{
			return default(Quaternion);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x59518D0", Offset = "0x59504D0", VA = "0x1859518D0")]
		[FreeFunction("QuaternionScripting::Slerp", IsThreadSafe = true)]
		public static Quaternion Slerp(Quaternion a, Quaternion b, float t)
		{
			return default(Quaternion);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x59517F0", Offset = "0x59503F0", VA = "0x1859517F0")]
		[FreeFunction("QuaternionScripting::SlerpUnclamped", IsThreadSafe = true)]
		public static Quaternion SlerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			return default(Quaternion);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x5951010", Offset = "0x594FC10", VA = "0x185951010")]
		[FreeFunction("QuaternionScripting::Lerp", IsThreadSafe = true)]
		public static Quaternion Lerp(Quaternion a, Quaternion b, float t)
		{
			return default(Quaternion);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x5950F30", Offset = "0x594FB30", VA = "0x185950F30")]
		[FreeFunction("QuaternionScripting::LerpUnclamped", IsThreadSafe = true)]
		public static Quaternion LerpUnclamped(Quaternion a, Quaternion b, float t)
		{
			return default(Quaternion);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x5950BD0", Offset = "0x594F7D0", VA = "0x185950BD0")]
		[FreeFunction("EulerToQuaternion", IsThreadSafe = true)]
		private static Quaternion Internal_FromEulerRad(Vector3 euler)
		{
			return default(Quaternion);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x5950DC0", Offset = "0x594F9C0", VA = "0x185950DC0")]
		[FreeFunction("QuaternionScripting::ToEuler", IsThreadSafe = true)]
		private static Vector3 Internal_ToEulerRad(Quaternion rotation)
		{
			return default(Vector3);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x5950D10", Offset = "0x594F910", VA = "0x185950D10")]
		[FreeFunction("QuaternionScripting::ToAxisAngle", IsThreadSafe = true)]
		private static void Internal_ToAxisAngleRad(Quaternion q, out Vector3 axis, out float angle)
		{
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x5950610", Offset = "0x594F210", VA = "0x185950610")]
		[FreeFunction("QuaternionScripting::AngleAxis", IsThreadSafe = true)]
		public static Quaternion AngleAxis(float angle, Vector3 axis)
		{
			return default(Quaternion);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x59511A0", Offset = "0x594FDA0", VA = "0x1859511A0")]
		[FreeFunction("QuaternionScripting::LookRotation", IsThreadSafe = true)]
		public static Quaternion LookRotation(Vector3 forward, [DefaultValue("Vector3.up")] Vector3 upwards)
		{
			return default(Quaternion);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x59510E0", Offset = "0x594FCE0", VA = "0x1859510E0")]
		[ExcludeFromDocs]
		public static Quaternion LookRotation(Vector3 forward)
		{
			return default(Quaternion);
		}

		// Token: 0x170001C0 RID: 448
		[Token(Token = "0x170001C0")]
		public float this[int index]
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x5951D50", Offset = "0x5950950", VA = "0x185951D50")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x5952210", Offset = "0x5950E10", VA = "0x185952210")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x57C0300", Offset = "0x57BEF00", VA = "0x1857C0300")]
		[MethodImpl(256)]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x57C0300", Offset = "0x57BEF00", VA = "0x1857C0300")]
		[MethodImpl(256)]
		public void Set(float newX, float newY, float newZ, float newW)
		{
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x170001C1")]
		public static Quaternion identity
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x5951F10", Offset = "0x5950B10", VA = "0x185951F10")]
			[MethodImpl(256)]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x6000785")]
		[Address(RVA = "0xA35110", Offset = "0xA33D10", VA = "0x180A35110")]
		[MethodImpl(256)]
		public static Quaternion operator *(Quaternion lhs, Quaternion rhs)
		{
			return default(Quaternion);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x5952060", Offset = "0x5950C60", VA = "0x185952060")]
		public static Vector3 operator *(Quaternion rotation, Vector3 point)
		{
			return default(Vector3);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x5950EB0", Offset = "0x594FAB0", VA = "0x185950EB0")]
		[MethodImpl(256)]
		private static bool IsEqualUsingDot(float dot)
		{
			return default(bool);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x5951FA0", Offset = "0x5950BA0", VA = "0x185951FA0")]
		[MethodImpl(256)]
		public static bool operator ==(Quaternion lhs, Quaternion rhs)
		{
			return default(bool);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00004830 File Offset: 0x00002A30
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x5952000", Offset = "0x5950C00", VA = "0x185952000")]
		[MethodImpl(256)]
		public static bool operator !=(Quaternion lhs, Quaternion rhs)
		{
			return default(bool);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x5950780", Offset = "0x594F380", VA = "0x185950780")]
		[MethodImpl(256)]
		public static float Dot(Quaternion a, Quaternion b)
		{
			return 0f;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x59516D0", Offset = "0x59502D0", VA = "0x1859516D0")]
		[ExcludeFromDocs]
		[MethodImpl(256)]
		public void SetLookRotation(Vector3 view)
		{
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x5951650", Offset = "0x5950250", VA = "0x185951650")]
		[MethodImpl(256)]
		public void SetLookRotation(Vector3 view, [DefaultValue("Vector3.up")] Vector3 up)
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x5950670", Offset = "0x594F270", VA = "0x185950670")]
		[MethodImpl(256)]
		public static float Angle(Quaternion a, Quaternion b)
		{
			return 0f;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x5950C20", Offset = "0x594F820", VA = "0x185950C20")]
		private static Vector3 Internal_MakePositive(Vector3 euler)
		{
			return default(Vector3);
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00004890 File Offset: 0x00002A90
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001C2")]
		public Vector3 eulerAngles
		{
			[Token(Token = "0x600078F")]
			[Address(RVA = "0x5951DF0", Offset = "0x59509F0", VA = "0x185951DF0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000790")]
			[Address(RVA = "0x59522B0", Offset = "0x5950EB0", VA = "0x1859522B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x5950A30", Offset = "0x594F630", VA = "0x185950A30")]
		[MethodImpl(256)]
		public static Quaternion Euler(float x, float y, float z)
		{
			return default(Quaternion);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x5950980", Offset = "0x594F580", VA = "0x185950980")]
		[MethodImpl(256)]
		public static Quaternion Euler(Vector3 euler)
		{
			return default(Quaternion);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x5951940", Offset = "0x5950540", VA = "0x185951940")]
		[MethodImpl(256)]
		public void ToAngleAxis(out float angle, out Vector3 axis)
		{
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x59515D0", Offset = "0x59501D0", VA = "0x1859515D0")]
		[MethodImpl(256)]
		public void SetFromToRotation(Vector3 fromDirection, Vector3 toDirection)
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x5951340", Offset = "0x594FF40", VA = "0x185951340")]
		[MethodImpl(256)]
		public static Quaternion RotateTowards(Quaternion from, Quaternion to, float maxDegreesDelta)
		{
			return default(Quaternion);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x5951230", Offset = "0x594FE30", VA = "0x185951230")]
		[MethodImpl(256)]
		public static Quaternion Normalize(Quaternion q)
		{
			return default(Quaternion);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x5951200", Offset = "0x594FE00", VA = "0x185951200")]
		[MethodImpl(256)]
		public void Normalize()
		{
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x170001C3")]
		public Quaternion normalized
		{
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x5951F60", Offset = "0x5950B60", VA = "0x185951F60")]
			[MethodImpl(256)]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x114B970", Offset = "0x114A570", VA = "0x18114B970", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x59507C0", Offset = "0x594F3C0", VA = "0x1859507C0", Slot = "0")]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x5948D00", Offset = "0x5947900", VA = "0x185948D00", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x5951D00", Offset = "0x5950900", VA = "0x185951D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x5951A60", Offset = "0x5950660", VA = "0x185951A60")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x5951A70", Offset = "0x5950670", VA = "0x185951A70", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x5950910", Offset = "0x594F510", VA = "0x185950910")]
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public static Quaternion EulerRotation(float x, float y, float z)
		{
			return default(Quaternion);
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x59508A0", Offset = "0x594F4A0", VA = "0x1859508A0")]
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public static Quaternion EulerRotation(Vector3 euler)
		{
			return default(Quaternion);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x5951560", Offset = "0x5950160", VA = "0x185951560")]
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public void SetEulerRotation(float x, float y, float z)
		{
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x5951500", Offset = "0x5950100", VA = "0x185951500")]
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public void SetEulerRotation(Vector3 euler)
		{
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x59519F0", Offset = "0x59505F0", VA = "0x1859519F0")]
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public Vector3 ToEuler()
		{
			return default(Vector3);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x5950910", Offset = "0x594F510", VA = "0x185950910")]
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public static Quaternion EulerAngles(float x, float y, float z)
		{
			return default(Quaternion);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x59508A0", Offset = "0x594F4A0", VA = "0x1859508A0")]
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public static Quaternion EulerAngles(Vector3 euler)
		{
			return default(Quaternion);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x59519A0", Offset = "0x59505A0", VA = "0x1859519A0")]
		[Obsolete("Use Quaternion.ToAngleAxis instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public void ToAxisAngle(out Vector3 axis, out float angle)
		{
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x5951560", Offset = "0x5950160", VA = "0x185951560")]
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public void SetEulerAngles(float x, float y, float z)
		{
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x5951500", Offset = "0x5950100", VA = "0x185951500")]
		[Obsolete("Use Quaternion.Euler instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public void SetEulerAngles(Vector3 euler)
		{
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x59519F0", Offset = "0x59505F0", VA = "0x1859519F0")]
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public static Vector3 ToEulerAngles(Quaternion rotation)
		{
			return default(Vector3);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x59519F0", Offset = "0x59505F0", VA = "0x1859519F0")]
		[Obsolete("Use Quaternion.eulerAngles instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public Vector3 ToEulerAngles()
		{
			return default(Vector3);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x5951480", Offset = "0x5950080", VA = "0x185951480")]
		[Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees.")]
		[MethodImpl(256)]
		public void SetAxisAngle(Vector3 axis, float angle)
		{
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x5950700", Offset = "0x594F300", VA = "0x185950700")]
		[Obsolete("Use Quaternion.AngleAxis instead. This function was deprecated because it uses radians instead of degrees")]
		[MethodImpl(256)]
		public static Quaternion AxisAngle(Vector3 axis, float angle)
		{
			return default(Quaternion);
		}

		// Token: 0x060007AE RID: 1966
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x5950AC0", Offset = "0x594F6C0", VA = "0x185950AC0")]
		[MethodImpl(4096)]
		private static extern void FromToRotation_Injected(ref Vector3 fromDirection, ref Vector3 toDirection, out Quaternion ret);

		// Token: 0x060007AF RID: 1967
		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x5950E10", Offset = "0x594FA10", VA = "0x185950E10")]
		[MethodImpl(4096)]
		private static extern void Inverse_Injected(ref Quaternion rotation, out Quaternion ret);

		// Token: 0x060007B0 RID: 1968
		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x5951860", Offset = "0x5950460", VA = "0x185951860")]
		[MethodImpl(4096)]
		private static extern void Slerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret);

		// Token: 0x060007B1 RID: 1969
		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x5951780", Offset = "0x5950380", VA = "0x185951780")]
		[MethodImpl(4096)]
		private static extern void SlerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret);

		// Token: 0x060007B2 RID: 1970
		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x5950FA0", Offset = "0x594FBA0", VA = "0x185950FA0")]
		[MethodImpl(4096)]
		private static extern void Lerp_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret);

		// Token: 0x060007B3 RID: 1971
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x5950EC0", Offset = "0x594FAC0", VA = "0x185950EC0")]
		[MethodImpl(4096)]
		private static extern void LerpUnclamped_Injected(ref Quaternion a, ref Quaternion b, float t, out Quaternion ret);

		// Token: 0x060007B4 RID: 1972
		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x5950B80", Offset = "0x594F780", VA = "0x185950B80")]
		[MethodImpl(4096)]
		private static extern void Internal_FromEulerRad_Injected(ref Vector3 euler, out Quaternion ret);

		// Token: 0x060007B5 RID: 1973
		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x5950D70", Offset = "0x594F970", VA = "0x185950D70")]
		[MethodImpl(4096)]
		private static extern void Internal_ToEulerRad_Injected(ref Quaternion rotation, out Vector3 ret);

		// Token: 0x060007B6 RID: 1974
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x5950CB0", Offset = "0x594F8B0", VA = "0x185950CB0")]
		[MethodImpl(4096)]
		private static extern void Internal_ToAxisAngleRad_Injected(ref Quaternion q, out Vector3 axis, out float angle);

		// Token: 0x060007B7 RID: 1975
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x59505B0", Offset = "0x594F1B0", VA = "0x1859505B0")]
		[MethodImpl(4096)]
		private static extern void AngleAxis_Injected(float angle, ref Vector3 axis, out Quaternion ret);

		// Token: 0x060007B8 RID: 1976
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x5951080", Offset = "0x594FC80", VA = "0x185951080")]
		[MethodImpl(4096)]
		private static extern void LookRotation_Injected(ref Vector3 forward, [DefaultValue("Vector3.up")] ref Vector3 upwards, out Quaternion ret);

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0xC")]
		public float w;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Quaternion identityQuaternion;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		public const float kEpsilon = 1E-06f;
	}
}
