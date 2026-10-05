using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[NativeType(Header = "Runtime/Math/Vector3.h")]
	[NativeHeader("Runtime/Math/Vector3.h")]
	[NativeHeader("Runtime/Math/MathScripting.h")]
	[NativeClass("Vector3f")]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[Il2CppEagerStaticClassConstruction]
	public struct Vector3 : IEquatable<Vector3>, IFormattable
	{
		// Token: 0x0600072F RID: 1839 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x5956750", Offset = "0x5955350", VA = "0x185956750")]
		[FreeFunction("VectorScripting::Slerp", IsThreadSafe = true)]
		public static Vector3 Slerp(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x5956670", Offset = "0x5955270", VA = "0x185956670")]
		[FreeFunction("VectorScripting::SlerpUnclamped", IsThreadSafe = true)]
		public static Vector3 SlerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06000731 RID: 1841
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x5955FC0", Offset = "0x5954BC0", VA = "0x185955FC0")]
		[FreeFunction("VectorScripting::OrthoNormalize", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void OrthoNormalize2(ref Vector3 a, ref Vector3 b);

		// Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x5955FC0", Offset = "0x5954BC0", VA = "0x185955FC0")]
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
		{
		}

		// Token: 0x06000733 RID: 1843
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x5956010", Offset = "0x5954C10", VA = "0x185956010")]
		[FreeFunction("VectorScripting::OrthoNormalize", IsThreadSafe = true)]
		[MethodImpl(4096)]
		private static extern void OrthoNormalize3(ref Vector3 a, ref Vector3 b, ref Vector3 c);

		// Token: 0x06000734 RID: 1844 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x5956010", Offset = "0x5954C10", VA = "0x185956010")]
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent, ref Vector3 binormal)
		{
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x5956400", Offset = "0x5955000", VA = "0x185956400")]
		[FreeFunction(IsThreadSafe = true)]
		public static Vector3 RotateTowards(Vector3 current, Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta)
		{
			return default(Vector3);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x5955B70", Offset = "0x5954770", VA = "0x185955B70")]
		[MethodImpl(256)]
		public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x5955B10", Offset = "0x5954710", VA = "0x185955B10")]
		[MethodImpl(256)]
		public static Vector3 LerpUnclamped(Vector3 a, Vector3 b, float t)
		{
			return default(Vector3);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x5955D20", Offset = "0x5954920", VA = "0x185955D20")]
		[MethodImpl(256)]
		public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta)
		{
			return default(Vector3);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x5956B60", Offset = "0x5955760", VA = "0x185956B60")]
		[ExcludeFromDocs]
		[MethodImpl(256)]
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, float maxSpeed)
		{
			return default(Vector3);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x5956C20", Offset = "0x5955820", VA = "0x185956C20")]
		[ExcludeFromDocs]
		[MethodImpl(256)]
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime)
		{
			return default(Vector3);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x59567C0", Offset = "0x59553C0", VA = "0x1859567C0")]
		public static Vector3 SmoothDamp(Vector3 current, Vector3 target, ref Vector3 currentVelocity, float smoothTime, [DefaultValue("Mathf.Infinity")] float maxSpeed, [DefaultValue("Time.deltaTime")] float deltaTime)
		{
			return default(Vector3);
		}

		// Token: 0x170001B1 RID: 433
		[Token(Token = "0x170001B1")]
		public float this[int index]
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x992BB0", Offset = "0x9917B0", VA = "0x180992BB0")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x5957730", Offset = "0x5956330", VA = "0x185957730")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x36DB840", Offset = "0x36DA440", VA = "0x1836DB840")]
		[MethodImpl(256)]
		public Vector3(float x, float y, float z)
		{
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x5957140", Offset = "0x5955D40", VA = "0x185957140")]
		[MethodImpl(256)]
		public Vector3(float x, float y)
		{
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x36DB840", Offset = "0x36DA440", VA = "0x1836DB840")]
		[MethodImpl(256)]
		public void Set(float newX, float newY, float newZ)
		{
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x5956480", Offset = "0x5955080", VA = "0x185956480")]
		[MethodImpl(256)]
		public static Vector3 Scale(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x59564C0", Offset = "0x59550C0", VA = "0x1859564C0")]
		[MethodImpl(256)]
		public void Scale(Vector3 scale)
		{
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x5955700", Offset = "0x5954300", VA = "0x185955700")]
		[MethodImpl(256)]
		public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
		{
			return default(Vector3);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x5955AB0", Offset = "0x59546B0", VA = "0x185955AB0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x5955880", Offset = "0x5954480", VA = "0x185955880", Slot = "0")]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x57B02D0", Offset = "0x57AEED0", VA = "0x1857B02D0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x5956300", Offset = "0x5954F00", VA = "0x185956300")]
		[MethodImpl(256)]
		public static Vector3 Reflect(Vector3 inDirection, Vector3 inNormal)
		{
			return default(Vector3);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x4F7140", Offset = "0x4F5D40", VA = "0x1804F7140")]
		[MethodImpl(256)]
		public static Vector3 Normalize(Vector3 value)
		{
			return default(Vector3);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x5955EA0", Offset = "0x5954AA0", VA = "0x185955EA0")]
		[MethodImpl(256)]
		public void Normalize()
		{
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x170001B2")]
		public Vector3 normalized
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x59573D0", Offset = "0x5955FD0", VA = "0x1859573D0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x5955850", Offset = "0x5954450", VA = "0x185955850")]
		[MethodImpl(256)]
		public static float Dot(Vector3 lhs, Vector3 rhs)
		{
			return 0f;
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x59561B0", Offset = "0x5954DB0", VA = "0x1859561B0")]
		[MethodImpl(256)]
		public static Vector3 Project(Vector3 vector, Vector3 onNormal)
		{
			return default(Vector3);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x5956070", Offset = "0x5954C70", VA = "0x185956070")]
		[MethodImpl(256)]
		public static Vector3 ProjectOnPlane(Vector3 vector, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x5955440", Offset = "0x5954040", VA = "0x185955440")]
		[MethodImpl(256)]
		public static float Angle(Vector3 from, Vector3 to)
		{
			return 0f;
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x59564F0", Offset = "0x59550F0", VA = "0x1859564F0")]
		[MethodImpl(256)]
		public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			return 0f;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x5955780", Offset = "0x5954380", VA = "0x185955780")]
		[MethodImpl(256)]
		public static float Distance(Vector3 a, Vector3 b)
		{
			return 0f;
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x59555C0", Offset = "0x59541C0", VA = "0x1859555C0")]
		[MethodImpl(256)]
		public static Vector3 ClampMagnitude(Vector3 vector, float maxLength)
		{
			return default(Vector3);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x5955BF0", Offset = "0x59547F0", VA = "0x185955BF0")]
		[MethodImpl(256)]
		public static float Magnitude(Vector3 vector)
		{
			return 0f;
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x170001B3")]
		public float magnitude
		{
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x59572D0", Offset = "0x5955ED0", VA = "0x1859572D0")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x5956CE0", Offset = "0x59558E0", VA = "0x185956CE0")]
		[MethodImpl(256)]
		public static float SqrMagnitude(Vector3 vector)
		{
			return 0f;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x170001B4")]
		public float sqrMagnitude
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x5956CE0", Offset = "0x59558E0", VA = "0x185956CE0")]
			[MethodImpl(256)]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x5955CE0", Offset = "0x59548E0", VA = "0x185955CE0")]
		[MethodImpl(256)]
		public static Vector3 Min(Vector3 lhs, Vector3 rhs)
		{
			return default(Vector3);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x5955CA0", Offset = "0x59548A0", VA = "0x185955CA0")]
		[MethodImpl(256)]
		public static Vector3 Max(Vector3 lhs, Vector3 rhs)
		{
			return default(Vector3);
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x170001B5")]
		public static Vector3 zero
		{
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x5957560", Offset = "0x5956160", VA = "0x185957560")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x170001B6")]
		public static Vector3 one
		{
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x5957420", Offset = "0x5956020", VA = "0x185957420")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600075A RID: 1882 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x170001B7")]
		public static Vector3 forward
		{
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x5957200", Offset = "0x5955E00", VA = "0x185957200")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600075B RID: 1883 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x170001B8")]
		public static Vector3 back
		{
			[Token(Token = "0x600075B")]
			[Address(RVA = "0x5957160", Offset = "0x5955D60", VA = "0x185957160")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600075C RID: 1884 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x170001B9")]
		public static Vector3 up
		{
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x5957510", Offset = "0x5956110", VA = "0x185957510")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600075D RID: 1885 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x170001BA")]
		public static Vector3 down
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0x59571B0", Offset = "0x5955DB0", VA = "0x1859571B0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x170001BB")]
		public static Vector3 left
		{
			[Token(Token = "0x600075E")]
			[Address(RVA = "0x5957280", Offset = "0x5955E80", VA = "0x185957280")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x170001BC")]
		public static Vector3 right
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x59574C0", Offset = "0x59560C0", VA = "0x1859574C0")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x170001BD")]
		public static Vector3 positiveInfinity
		{
			[Token(Token = "0x6000760")]
			[Address(RVA = "0x5957470", Offset = "0x5956070", VA = "0x185957470")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x170001BE")]
		public static Vector3 negativeInfinity
		{
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x5957380", Offset = "0x5955F80", VA = "0x185957380")]
			[MethodImpl(256)]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x4F73A0", Offset = "0x4F5FA0", VA = "0x1804F73A0")]
		[MethodImpl(256)]
		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x4F7420", Offset = "0x4F6020", VA = "0x1804F7420")]
		[MethodImpl(256)]
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x59576E0", Offset = "0x59562E0", VA = "0x1859576E0")]
		[MethodImpl(256)]
		public static Vector3 operator -(Vector3 a)
		{
			return default(Vector3);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x59576A0", Offset = "0x59562A0", VA = "0x1859576A0")]
		[MethodImpl(256)]
		public static Vector3 operator *(Vector3 a, float d)
		{
			return default(Vector3);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x5957660", Offset = "0x5956260", VA = "0x185957660")]
		[MethodImpl(256)]
		public static Vector3 operator *(float d, Vector3 a)
		{
			return default(Vector3);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x4F73E0", Offset = "0x4F5FE0", VA = "0x1804F73E0")]
		[MethodImpl(256)]
		public static Vector3 operator /(Vector3 a, float d)
		{
			return default(Vector3);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x59575B0", Offset = "0x59561B0", VA = "0x1859575B0")]
		[MethodImpl(256)]
		public static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x59575F0", Offset = "0x59561F0", VA = "0x1859575F0")]
		[MethodImpl(256)]
		public static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x5956D20", Offset = "0x5955920", VA = "0x185956D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x5956D10", Offset = "0x5955910", VA = "0x185956D10")]
		public string ToString(string format)
		{
			return null;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x5956D30", Offset = "0x5955930", VA = "0x185956D30", Slot = "5")]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x170001BF")]
		[Obsolete("Use Vector3.forward instead.")]
		public static Vector3 fwd
		{
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x5957250", Offset = "0x5955E50", VA = "0x185957250")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x5955320", Offset = "0x5953F20", VA = "0x185955320")]
		[Obsolete("Use Vector3.Angle instead. AngleBetween uses radians instead of degrees and was deprecated for this reason")]
		public static float AngleBetween(Vector3 from, Vector3 to)
		{
			return 0f;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x5955940", Offset = "0x5954540", VA = "0x185955940")]
		[Obsolete("Use Vector3.ProjectOnPlane instead.")]
		public static Vector3 Exclude(Vector3 excludeThis, Vector3 fromThat)
		{
			return default(Vector3);
		}

		// Token: 0x06000771 RID: 1905
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x59566E0", Offset = "0x59552E0", VA = "0x1859566E0")]
		[MethodImpl(4096)]
		private static extern void Slerp_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret);

		// Token: 0x06000772 RID: 1906
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x5956600", Offset = "0x5955200", VA = "0x185956600")]
		[MethodImpl(4096)]
		private static extern void SlerpUnclamped_Injected(ref Vector3 a, ref Vector3 b, float t, out Vector3 ret);

		// Token: 0x06000773 RID: 1907
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x5956390", Offset = "0x5954F90", VA = "0x185956390")]
		[MethodImpl(4096)]
		private static extern void RotateTowards_Injected(ref Vector3 current, ref Vector3 target, float maxRadiansDelta, float maxMagnitudeDelta, out Vector3 ret);

		// Token: 0x04000437 RID: 1079
		[Token(Token = "0x4000437")]
		public const float kEpsilon = 1E-05f;

		// Token: 0x04000438 RID: 1080
		[Token(Token = "0x4000438")]
		public const float kEpsilonNormalSqrt = 1E-15f;

		// Token: 0x04000439 RID: 1081
		[Token(Token = "0x4000439")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x0400043A RID: 1082
		[Token(Token = "0x400043A")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x0400043B RID: 1083
		[Token(Token = "0x400043B")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x0400043C RID: 1084
		[Token(Token = "0x400043C")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Vector3 zeroVector;

		// Token: 0x0400043D RID: 1085
		[Token(Token = "0x400043D")]
		[FieldOffset(Offset = "0xC")]
		private static readonly Vector3 oneVector;

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x18")]
		private static readonly Vector3 upVector;

		// Token: 0x0400043F RID: 1087
		[Token(Token = "0x400043F")]
		[FieldOffset(Offset = "0x24")]
		private static readonly Vector3 downVector;

		// Token: 0x04000440 RID: 1088
		[Token(Token = "0x4000440")]
		[FieldOffset(Offset = "0x30")]
		private static readonly Vector3 leftVector;

		// Token: 0x04000441 RID: 1089
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x3C")]
		private static readonly Vector3 rightVector;

		// Token: 0x04000442 RID: 1090
		[Token(Token = "0x4000442")]
		[FieldOffset(Offset = "0x48")]
		private static readonly Vector3 forwardVector;

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		[FieldOffset(Offset = "0x54")]
		private static readonly Vector3 backVector;

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		[FieldOffset(Offset = "0x60")]
		private static readonly Vector3 positiveInfinityVector;

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		[FieldOffset(Offset = "0x6C")]
		private static readonly Vector3 negativeInfinityVector;
	}
}
