using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(half3.DebuggerProxy))]
	[Serializable]
	public struct half3 : IEquatable<half3>, IFormattable
	{
		// Token: 0x060015E3 RID: 5603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E3")]
		[Address(RVA = "0x5758BE0", Offset = "0x57577E0", VA = "0x185758BE0")]
		[MethodImpl(256)]
		public half3(half x, half y, half z)
		{
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E4")]
		[Address(RVA = "0x57D1E70", Offset = "0x57D0A70", VA = "0x1857D1E70")]
		[MethodImpl(256)]
		public half3(half x, half2 yz)
		{
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E5")]
		[Address(RVA = "0x57D1EF0", Offset = "0x57D0AF0", VA = "0x1857D1EF0")]
		[MethodImpl(256)]
		public half3(half2 xy, half z)
		{
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E6")]
		[Address(RVA = "0x57D1F50", Offset = "0x57D0B50", VA = "0x1857D1F50")]
		[MethodImpl(256)]
		public half3(half3 xyz)
		{
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E7")]
		[Address(RVA = "0x57D1FC0", Offset = "0x57D0BC0", VA = "0x1857D1FC0")]
		[MethodImpl(256)]
		public half3(half v)
		{
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E8")]
		[Address(RVA = "0x57D1F00", Offset = "0x57D0B00", VA = "0x1857D1F00")]
		[MethodImpl(256)]
		public half3(float v)
		{
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015E9")]
		[Address(RVA = "0x57D1F70", Offset = "0x57D0B70", VA = "0x1857D1F70")]
		[MethodImpl(256)]
		public half3(float3 v)
		{
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EA")]
		[Address(RVA = "0x57D1E20", Offset = "0x57D0A20", VA = "0x1857D1E20")]
		[MethodImpl(256)]
		public half3(double v)
		{
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EB")]
		[Address(RVA = "0x57D1E90", Offset = "0x57D0A90", VA = "0x1857D1E90")]
		[MethodImpl(256)]
		public half3(double3 v)
		{
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0001EBB8 File Offset: 0x0001CDB8
		[Token(Token = "0x60015EC")]
		[Address(RVA = "0x571B5C0", Offset = "0x571A1C0", VA = "0x18571B5C0")]
		[MethodImpl(256)]
		public static implicit operator half3(half v)
		{
			return default(half3);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x0001EBD0 File Offset: 0x0001CDD0
		[Token(Token = "0x60015ED")]
		[Address(RVA = "0x571B5D0", Offset = "0x571A1D0", VA = "0x18571B5D0")]
		[MethodImpl(256)]
		public static explicit operator half3(float v)
		{
			return default(half3);
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x0001EBE8 File Offset: 0x0001CDE8
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x571B560", Offset = "0x571A160", VA = "0x18571B560")]
		[MethodImpl(256)]
		public static explicit operator half3(float3 v)
		{
			return default(half3);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x0001EC00 File Offset: 0x0001CE00
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x571B460", Offset = "0x571A060", VA = "0x18571B460")]
		[MethodImpl(256)]
		public static explicit operator half3(double v)
		{
			return default(half3);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x0001EC18 File Offset: 0x0001CE18
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x571B4F0", Offset = "0x571A0F0", VA = "0x18571B4F0")]
		[MethodImpl(256)]
		public static explicit operator half3(double3 v)
		{
			return default(half3);
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x0001EC30 File Offset: 0x0001CE30
		[Token(Token = "0x60015F1")]
		[Address(RVA = "0x57D2EF0", Offset = "0x57D1AF0", VA = "0x1857D2EF0")]
		[MethodImpl(256)]
		public static bool3 operator ==(half3 lhs, half3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x0001EC48 File Offset: 0x0001CE48
		[Token(Token = "0x60015F2")]
		[Address(RVA = "0x57D2F20", Offset = "0x57D1B20", VA = "0x1857D2F20")]
		[MethodImpl(256)]
		public static bool3 operator ==(half3 lhs, half rhs)
		{
			return default(bool3);
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x0001EC60 File Offset: 0x0001CE60
		[Token(Token = "0x60015F3")]
		[Address(RVA = "0x57D2F50", Offset = "0x57D1B50", VA = "0x1857D2F50")]
		[MethodImpl(256)]
		public static bool3 operator ==(half lhs, half3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x0001EC78 File Offset: 0x0001CE78
		[Token(Token = "0x60015F4")]
		[Address(RVA = "0x57D2FB0", Offset = "0x57D1BB0", VA = "0x1857D2FB0")]
		[MethodImpl(256)]
		public static bool3 operator !=(half3 lhs, half3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x0001EC90 File Offset: 0x0001CE90
		[Token(Token = "0x60015F5")]
		[Address(RVA = "0x57D2FE0", Offset = "0x57D1BE0", VA = "0x1857D2FE0")]
		[MethodImpl(256)]
		public static bool3 operator !=(half3 lhs, half rhs)
		{
			return default(bool3);
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x0001ECA8 File Offset: 0x0001CEA8
		[Token(Token = "0x60015F6")]
		[Address(RVA = "0x57D2F80", Offset = "0x57D1B80", VA = "0x1857D2F80")]
		[MethodImpl(256)]
		public static bool3 operator !=(half lhs, half3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x0001ECC0 File Offset: 0x0001CEC0
		[Token(Token = "0x170005E9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxxx
		{
			[Token(Token = "0x60015F7")]
			[Address(RVA = "0x57D1670", Offset = "0x57D0270", VA = "0x1857D1670")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060015F8 RID: 5624 RVA: 0x0001ECD8 File Offset: 0x0001CED8
		[Token(Token = "0x170005EA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxxy
		{
			[Token(Token = "0x60015F8")]
			[Address(RVA = "0x57D1690", Offset = "0x57D0290", VA = "0x1857D1690")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x0001ECF0 File Offset: 0x0001CEF0
		[Token(Token = "0x170005EB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxxz
		{
			[Token(Token = "0x60015F9")]
			[Address(RVA = "0x57D1FD0", Offset = "0x57D0BD0", VA = "0x1857D1FD0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x0001ED08 File Offset: 0x0001CF08
		[Token(Token = "0x170005EC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxyx
		{
			[Token(Token = "0x60015FA")]
			[Address(RVA = "0x57D16E0", Offset = "0x57D02E0", VA = "0x1857D16E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x0001ED20 File Offset: 0x0001CF20
		[Token(Token = "0x170005ED")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxyy
		{
			[Token(Token = "0x60015FB")]
			[Address(RVA = "0x57D1710", Offset = "0x57D0310", VA = "0x1857D1710")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060015FC RID: 5628 RVA: 0x0001ED38 File Offset: 0x0001CF38
		[Token(Token = "0x170005EE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxyz
		{
			[Token(Token = "0x60015FC")]
			[Address(RVA = "0x57D2000", Offset = "0x57D0C00", VA = "0x1857D2000")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x0001ED50 File Offset: 0x0001CF50
		[Token(Token = "0x170005EF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxzx
		{
			[Token(Token = "0x60015FD")]
			[Address(RVA = "0x57D2050", Offset = "0x57D0C50", VA = "0x1857D2050")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x0001ED68 File Offset: 0x0001CF68
		[Token(Token = "0x170005F0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxzy
		{
			[Token(Token = "0x60015FE")]
			[Address(RVA = "0x57D2080", Offset = "0x57D0C80", VA = "0x1857D2080")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x0001ED80 File Offset: 0x0001CF80
		[Token(Token = "0x170005F1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxzz
		{
			[Token(Token = "0x60015FF")]
			[Address(RVA = "0x57D20B0", Offset = "0x57D0CB0", VA = "0x1857D20B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001600 RID: 5632 RVA: 0x0001ED98 File Offset: 0x0001CF98
		[Token(Token = "0x170005F2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyxx
		{
			[Token(Token = "0x6001600")]
			[Address(RVA = "0x57D1780", Offset = "0x57D0380", VA = "0x1857D1780")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x0001EDB0 File Offset: 0x0001CFB0
		[Token(Token = "0x170005F3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyxy
		{
			[Token(Token = "0x6001601")]
			[Address(RVA = "0x57D17B0", Offset = "0x57D03B0", VA = "0x1857D17B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x0001EDC8 File Offset: 0x0001CFC8
		[Token(Token = "0x170005F4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyxz
		{
			[Token(Token = "0x6001602")]
			[Address(RVA = "0x57D20E0", Offset = "0x57D0CE0", VA = "0x1857D20E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x0001EDE0 File Offset: 0x0001CFE0
		[Token(Token = "0x170005F5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyyx
		{
			[Token(Token = "0x6001603")]
			[Address(RVA = "0x57D1800", Offset = "0x57D0400", VA = "0x1857D1800")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x0001EDF8 File Offset: 0x0001CFF8
		[Token(Token = "0x170005F6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyyy
		{
			[Token(Token = "0x6001604")]
			[Address(RVA = "0x57D1830", Offset = "0x57D0430", VA = "0x1857D1830")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x0001EE10 File Offset: 0x0001D010
		[Token(Token = "0x170005F7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyyz
		{
			[Token(Token = "0x6001605")]
			[Address(RVA = "0x57D2110", Offset = "0x57D0D10", VA = "0x1857D2110")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x06001606 RID: 5638 RVA: 0x0001EE28 File Offset: 0x0001D028
		[Token(Token = "0x170005F8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyzx
		{
			[Token(Token = "0x6001606")]
			[Address(RVA = "0x57D2160", Offset = "0x57D0D60", VA = "0x1857D2160")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x0001EE40 File Offset: 0x0001D040
		[Token(Token = "0x170005F9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyzy
		{
			[Token(Token = "0x6001607")]
			[Address(RVA = "0x57D2190", Offset = "0x57D0D90", VA = "0x1857D2190")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x0001EE58 File Offset: 0x0001D058
		[Token(Token = "0x170005FA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyzz
		{
			[Token(Token = "0x6001608")]
			[Address(RVA = "0x57D21C0", Offset = "0x57D0DC0", VA = "0x1857D21C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x0001EE70 File Offset: 0x0001D070
		[Token(Token = "0x170005FB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzxx
		{
			[Token(Token = "0x6001609")]
			[Address(RVA = "0x57D2230", Offset = "0x57D0E30", VA = "0x1857D2230")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x0001EE88 File Offset: 0x0001D088
		[Token(Token = "0x170005FC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzxy
		{
			[Token(Token = "0x600160A")]
			[Address(RVA = "0x57D2260", Offset = "0x57D0E60", VA = "0x1857D2260")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600160B RID: 5643 RVA: 0x0001EEA0 File Offset: 0x0001D0A0
		[Token(Token = "0x170005FD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzxz
		{
			[Token(Token = "0x600160B")]
			[Address(RVA = "0x57D2290", Offset = "0x57D0E90", VA = "0x1857D2290")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x0001EEB8 File Offset: 0x0001D0B8
		[Token(Token = "0x170005FE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzyx
		{
			[Token(Token = "0x600160C")]
			[Address(RVA = "0x57D22E0", Offset = "0x57D0EE0", VA = "0x1857D22E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600160D RID: 5645 RVA: 0x0001EED0 File Offset: 0x0001D0D0
		[Token(Token = "0x170005FF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzyy
		{
			[Token(Token = "0x600160D")]
			[Address(RVA = "0x57D2310", Offset = "0x57D0F10", VA = "0x1857D2310")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x0001EEE8 File Offset: 0x0001D0E8
		[Token(Token = "0x17000600")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzyz
		{
			[Token(Token = "0x600160E")]
			[Address(RVA = "0x57D2340", Offset = "0x57D0F40", VA = "0x1857D2340")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x0001EF00 File Offset: 0x0001D100
		[Token(Token = "0x17000601")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzzx
		{
			[Token(Token = "0x600160F")]
			[Address(RVA = "0x57D2390", Offset = "0x57D0F90", VA = "0x1857D2390")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001610 RID: 5648 RVA: 0x0001EF18 File Offset: 0x0001D118
		[Token(Token = "0x17000602")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzzy
		{
			[Token(Token = "0x6001610")]
			[Address(RVA = "0x57D23C0", Offset = "0x57D0FC0", VA = "0x1857D23C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x0001EF30 File Offset: 0x0001D130
		[Token(Token = "0x17000603")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzzz
		{
			[Token(Token = "0x6001611")]
			[Address(RVA = "0x57D23F0", Offset = "0x57D0FF0", VA = "0x1857D23F0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001612 RID: 5650 RVA: 0x0001EF48 File Offset: 0x0001D148
		[Token(Token = "0x17000604")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxxx
		{
			[Token(Token = "0x6001612")]
			[Address(RVA = "0x57D18A0", Offset = "0x57D04A0", VA = "0x1857D18A0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x0001EF60 File Offset: 0x0001D160
		[Token(Token = "0x17000605")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxxy
		{
			[Token(Token = "0x6001613")]
			[Address(RVA = "0x57D18D0", Offset = "0x57D04D0", VA = "0x1857D18D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001614 RID: 5652 RVA: 0x0001EF78 File Offset: 0x0001D178
		[Token(Token = "0x17000606")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxxz
		{
			[Token(Token = "0x6001614")]
			[Address(RVA = "0x57D2420", Offset = "0x57D1020", VA = "0x1857D2420")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x0001EF90 File Offset: 0x0001D190
		[Token(Token = "0x17000607")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxyx
		{
			[Token(Token = "0x6001615")]
			[Address(RVA = "0x57D1920", Offset = "0x57D0520", VA = "0x1857D1920")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x0001EFA8 File Offset: 0x0001D1A8
		[Token(Token = "0x17000608")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxyy
		{
			[Token(Token = "0x6001616")]
			[Address(RVA = "0x57D1950", Offset = "0x57D0550", VA = "0x1857D1950")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x0001EFC0 File Offset: 0x0001D1C0
		[Token(Token = "0x17000609")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxyz
		{
			[Token(Token = "0x6001617")]
			[Address(RVA = "0x57D2450", Offset = "0x57D1050", VA = "0x1857D2450")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06001618 RID: 5656 RVA: 0x0001EFD8 File Offset: 0x0001D1D8
		[Token(Token = "0x1700060A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxzx
		{
			[Token(Token = "0x6001618")]
			[Address(RVA = "0x57D24A0", Offset = "0x57D10A0", VA = "0x1857D24A0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x0001EFF0 File Offset: 0x0001D1F0
		[Token(Token = "0x1700060B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxzy
		{
			[Token(Token = "0x6001619")]
			[Address(RVA = "0x57D24D0", Offset = "0x57D10D0", VA = "0x1857D24D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x0600161A RID: 5658 RVA: 0x0001F008 File Offset: 0x0001D208
		[Token(Token = "0x1700060C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxzz
		{
			[Token(Token = "0x600161A")]
			[Address(RVA = "0x57D2500", Offset = "0x57D1100", VA = "0x1857D2500")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x0001F020 File Offset: 0x0001D220
		[Token(Token = "0x1700060D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyxx
		{
			[Token(Token = "0x600161B")]
			[Address(RVA = "0x57D19C0", Offset = "0x57D05C0", VA = "0x1857D19C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x0600161C RID: 5660 RVA: 0x0001F038 File Offset: 0x0001D238
		[Token(Token = "0x1700060E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyxy
		{
			[Token(Token = "0x600161C")]
			[Address(RVA = "0x57D19F0", Offset = "0x57D05F0", VA = "0x1857D19F0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x0001F050 File Offset: 0x0001D250
		[Token(Token = "0x1700060F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyxz
		{
			[Token(Token = "0x600161D")]
			[Address(RVA = "0x57D2530", Offset = "0x57D1130", VA = "0x1857D2530")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x0600161E RID: 5662 RVA: 0x0001F068 File Offset: 0x0001D268
		[Token(Token = "0x17000610")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyyx
		{
			[Token(Token = "0x600161E")]
			[Address(RVA = "0x57D1A40", Offset = "0x57D0640", VA = "0x1857D1A40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x0001F080 File Offset: 0x0001D280
		[Token(Token = "0x17000611")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyyy
		{
			[Token(Token = "0x600161F")]
			[Address(RVA = "0x57D1A70", Offset = "0x57D0670", VA = "0x1857D1A70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001620 RID: 5664 RVA: 0x0001F098 File Offset: 0x0001D298
		[Token(Token = "0x17000612")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyyz
		{
			[Token(Token = "0x6001620")]
			[Address(RVA = "0x57D2560", Offset = "0x57D1160", VA = "0x1857D2560")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		[Token(Token = "0x17000613")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyzx
		{
			[Token(Token = "0x6001621")]
			[Address(RVA = "0x57D25B0", Offset = "0x57D11B0", VA = "0x1857D25B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x06001622 RID: 5666 RVA: 0x0001F0C8 File Offset: 0x0001D2C8
		[Token(Token = "0x17000614")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyzy
		{
			[Token(Token = "0x6001622")]
			[Address(RVA = "0x57D25E0", Offset = "0x57D11E0", VA = "0x1857D25E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x0001F0E0 File Offset: 0x0001D2E0
		[Token(Token = "0x17000615")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyzz
		{
			[Token(Token = "0x6001623")]
			[Address(RVA = "0x57D2610", Offset = "0x57D1210", VA = "0x1857D2610")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
		[Token(Token = "0x17000616")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzxx
		{
			[Token(Token = "0x6001624")]
			[Address(RVA = "0x57D2680", Offset = "0x57D1280", VA = "0x1857D2680")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x0001F110 File Offset: 0x0001D310
		[Token(Token = "0x17000617")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzxy
		{
			[Token(Token = "0x6001625")]
			[Address(RVA = "0x57D26B0", Offset = "0x57D12B0", VA = "0x1857D26B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x0001F128 File Offset: 0x0001D328
		[Token(Token = "0x17000618")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzxz
		{
			[Token(Token = "0x6001626")]
			[Address(RVA = "0x57D26E0", Offset = "0x57D12E0", VA = "0x1857D26E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x0001F140 File Offset: 0x0001D340
		[Token(Token = "0x17000619")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzyx
		{
			[Token(Token = "0x6001627")]
			[Address(RVA = "0x57D2730", Offset = "0x57D1330", VA = "0x1857D2730")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x06001628 RID: 5672 RVA: 0x0001F158 File Offset: 0x0001D358
		[Token(Token = "0x1700061A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzyy
		{
			[Token(Token = "0x6001628")]
			[Address(RVA = "0x57D2760", Offset = "0x57D1360", VA = "0x1857D2760")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x06001629 RID: 5673 RVA: 0x0001F170 File Offset: 0x0001D370
		[Token(Token = "0x1700061B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzyz
		{
			[Token(Token = "0x6001629")]
			[Address(RVA = "0x57D2790", Offset = "0x57D1390", VA = "0x1857D2790")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x0600162A RID: 5674 RVA: 0x0001F188 File Offset: 0x0001D388
		[Token(Token = "0x1700061C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzzx
		{
			[Token(Token = "0x600162A")]
			[Address(RVA = "0x57D27E0", Offset = "0x57D13E0", VA = "0x1857D27E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700061D RID: 1565
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x0001F1A0 File Offset: 0x0001D3A0
		[Token(Token = "0x1700061D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzzy
		{
			[Token(Token = "0x600162B")]
			[Address(RVA = "0x57D2810", Offset = "0x57D1410", VA = "0x1857D2810")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x0600162C RID: 5676 RVA: 0x0001F1B8 File Offset: 0x0001D3B8
		[Token(Token = "0x1700061E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzzz
		{
			[Token(Token = "0x600162C")]
			[Address(RVA = "0x57D2840", Offset = "0x57D1440", VA = "0x1857D2840")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600162D RID: 5677 RVA: 0x0001F1D0 File Offset: 0x0001D3D0
		[Token(Token = "0x1700061F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxxx
		{
			[Token(Token = "0x600162D")]
			[Address(RVA = "0x57D28B0", Offset = "0x57D14B0", VA = "0x1857D28B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x0600162E RID: 5678 RVA: 0x0001F1E8 File Offset: 0x0001D3E8
		[Token(Token = "0x17000620")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxxy
		{
			[Token(Token = "0x600162E")]
			[Address(RVA = "0x57D28E0", Offset = "0x57D14E0", VA = "0x1857D28E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x0600162F RID: 5679 RVA: 0x0001F200 File Offset: 0x0001D400
		[Token(Token = "0x17000621")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxxz
		{
			[Token(Token = "0x600162F")]
			[Address(RVA = "0x57D2910", Offset = "0x57D1510", VA = "0x1857D2910")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x0001F218 File Offset: 0x0001D418
		[Token(Token = "0x17000622")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxyx
		{
			[Token(Token = "0x6001630")]
			[Address(RVA = "0x57D2960", Offset = "0x57D1560", VA = "0x1857D2960")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001631 RID: 5681 RVA: 0x0001F230 File Offset: 0x0001D430
		[Token(Token = "0x17000623")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxyy
		{
			[Token(Token = "0x6001631")]
			[Address(RVA = "0x57D2990", Offset = "0x57D1590", VA = "0x1857D2990")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000624 RID: 1572
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x0001F248 File Offset: 0x0001D448
		[Token(Token = "0x17000624")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxyz
		{
			[Token(Token = "0x6001632")]
			[Address(RVA = "0x57D29C0", Offset = "0x57D15C0", VA = "0x1857D29C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x0001F260 File Offset: 0x0001D460
		[Token(Token = "0x17000625")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxzx
		{
			[Token(Token = "0x6001633")]
			[Address(RVA = "0x57D2A10", Offset = "0x57D1610", VA = "0x1857D2A10")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x0001F278 File Offset: 0x0001D478
		[Token(Token = "0x17000626")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxzy
		{
			[Token(Token = "0x6001634")]
			[Address(RVA = "0x57D2A40", Offset = "0x57D1640", VA = "0x1857D2A40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x0001F290 File Offset: 0x0001D490
		[Token(Token = "0x17000627")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxzz
		{
			[Token(Token = "0x6001635")]
			[Address(RVA = "0x57D2A70", Offset = "0x57D1670", VA = "0x1857D2A70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001636 RID: 5686 RVA: 0x0001F2A8 File Offset: 0x0001D4A8
		[Token(Token = "0x17000628")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyxx
		{
			[Token(Token = "0x6001636")]
			[Address(RVA = "0x57D2AE0", Offset = "0x57D16E0", VA = "0x1857D2AE0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x0001F2C0 File Offset: 0x0001D4C0
		[Token(Token = "0x17000629")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyxy
		{
			[Token(Token = "0x6001637")]
			[Address(RVA = "0x57D2B10", Offset = "0x57D1710", VA = "0x1857D2B10")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06001638 RID: 5688 RVA: 0x0001F2D8 File Offset: 0x0001D4D8
		[Token(Token = "0x1700062A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyxz
		{
			[Token(Token = "0x6001638")]
			[Address(RVA = "0x57D2B40", Offset = "0x57D1740", VA = "0x1857D2B40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
		[Token(Token = "0x1700062B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyyx
		{
			[Token(Token = "0x6001639")]
			[Address(RVA = "0x57D2B90", Offset = "0x57D1790", VA = "0x1857D2B90")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x0600163A RID: 5690 RVA: 0x0001F308 File Offset: 0x0001D508
		[Token(Token = "0x1700062C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyyy
		{
			[Token(Token = "0x600163A")]
			[Address(RVA = "0x57D2BC0", Offset = "0x57D17C0", VA = "0x1857D2BC0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x0001F320 File Offset: 0x0001D520
		[Token(Token = "0x1700062D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyyz
		{
			[Token(Token = "0x600163B")]
			[Address(RVA = "0x57D2BF0", Offset = "0x57D17F0", VA = "0x1857D2BF0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x0600163C RID: 5692 RVA: 0x0001F338 File Offset: 0x0001D538
		[Token(Token = "0x1700062E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyzx
		{
			[Token(Token = "0x600163C")]
			[Address(RVA = "0x57D2C40", Offset = "0x57D1840", VA = "0x1857D2C40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x0001F350 File Offset: 0x0001D550
		[Token(Token = "0x1700062F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyzy
		{
			[Token(Token = "0x600163D")]
			[Address(RVA = "0x57D2C70", Offset = "0x57D1870", VA = "0x1857D2C70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x0600163E RID: 5694 RVA: 0x0001F368 File Offset: 0x0001D568
		[Token(Token = "0x17000630")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyzz
		{
			[Token(Token = "0x600163E")]
			[Address(RVA = "0x57D2CA0", Offset = "0x57D18A0", VA = "0x1857D2CA0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x0001F380 File Offset: 0x0001D580
		[Token(Token = "0x17000631")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzxx
		{
			[Token(Token = "0x600163F")]
			[Address(RVA = "0x57D2D10", Offset = "0x57D1910", VA = "0x1857D2D10")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x0001F398 File Offset: 0x0001D598
		[Token(Token = "0x17000632")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzxy
		{
			[Token(Token = "0x6001640")]
			[Address(RVA = "0x57D2D40", Offset = "0x57D1940", VA = "0x1857D2D40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x0001F3B0 File Offset: 0x0001D5B0
		[Token(Token = "0x17000633")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzxz
		{
			[Token(Token = "0x6001641")]
			[Address(RVA = "0x57D2D70", Offset = "0x57D1970", VA = "0x1857D2D70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06001642 RID: 5698 RVA: 0x0001F3C8 File Offset: 0x0001D5C8
		[Token(Token = "0x17000634")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzyx
		{
			[Token(Token = "0x6001642")]
			[Address(RVA = "0x57D2DC0", Offset = "0x57D19C0", VA = "0x1857D2DC0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x0001F3E0 File Offset: 0x0001D5E0
		[Token(Token = "0x17000635")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzyy
		{
			[Token(Token = "0x6001643")]
			[Address(RVA = "0x57D2DF0", Offset = "0x57D19F0", VA = "0x1857D2DF0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001644 RID: 5700 RVA: 0x0001F3F8 File Offset: 0x0001D5F8
		[Token(Token = "0x17000636")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzyz
		{
			[Token(Token = "0x6001644")]
			[Address(RVA = "0x57D2E20", Offset = "0x57D1A20", VA = "0x1857D2E20")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x0001F410 File Offset: 0x0001D610
		[Token(Token = "0x17000637")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzzx
		{
			[Token(Token = "0x6001645")]
			[Address(RVA = "0x57D2E70", Offset = "0x57D1A70", VA = "0x1857D2E70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001646 RID: 5702 RVA: 0x0001F428 File Offset: 0x0001D628
		[Token(Token = "0x17000638")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzzy
		{
			[Token(Token = "0x6001646")]
			[Address(RVA = "0x57D2EA0", Offset = "0x57D1AA0", VA = "0x1857D2EA0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x0001F440 File Offset: 0x0001D640
		[Token(Token = "0x17000639")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzzz
		{
			[Token(Token = "0x6001647")]
			[Address(RVA = "0x57D2ED0", Offset = "0x57D1AD0", VA = "0x1857D2ED0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x0001F458 File Offset: 0x0001D658
		[Token(Token = "0x1700063A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xxx
		{
			[Token(Token = "0x6001648")]
			[Address(RVA = "0x57D1650", Offset = "0x57D0250", VA = "0x1857D1650")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x0001F470 File Offset: 0x0001D670
		[Token(Token = "0x1700063B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xxy
		{
			[Token(Token = "0x6001649")]
			[Address(RVA = "0x57D16C0", Offset = "0x57D02C0", VA = "0x1857D16C0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x0001F488 File Offset: 0x0001D688
		[Token(Token = "0x1700063C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xxz
		{
			[Token(Token = "0x600164A")]
			[Address(RVA = "0x57D2030", Offset = "0x57D0C30", VA = "0x1857D2030")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x0001F4A0 File Offset: 0x0001D6A0
		[Token(Token = "0x1700063D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xyx
		{
			[Token(Token = "0x600164B")]
			[Address(RVA = "0x57D1760", Offset = "0x57D0360", VA = "0x1857D1760")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x0001F4B8 File Offset: 0x0001D6B8
		[Token(Token = "0x1700063E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xyy
		{
			[Token(Token = "0x600164C")]
			[Address(RVA = "0x57D17E0", Offset = "0x57D03E0", VA = "0x1857D17E0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x0001F4D0 File Offset: 0x0001D6D0
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700063F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xyz
		{
			[Token(Token = "0x600164D")]
			[Address(RVA = "0x57D2140", Offset = "0x57D0D40", VA = "0x1857D2140")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x600164E")]
			[Address(RVA = "0x57D1F50", Offset = "0x57D0B50", VA = "0x1857D1F50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x0001F4E8 File Offset: 0x0001D6E8
		[Token(Token = "0x17000640")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xzx
		{
			[Token(Token = "0x600164F")]
			[Address(RVA = "0x57D2210", Offset = "0x57D0E10", VA = "0x1857D2210")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x0001F500 File Offset: 0x0001D700
		// (set) Token: 0x06001651 RID: 5713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000641")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xzy
		{
			[Token(Token = "0x6001650")]
			[Address(RVA = "0x57D22C0", Offset = "0x57D0EC0", VA = "0x1857D22C0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x6001651")]
			[Address(RVA = "0x57D3020", Offset = "0x57D1C20", VA = "0x1857D3020")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001652 RID: 5714 RVA: 0x0001F518 File Offset: 0x0001D718
		[Token(Token = "0x17000642")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xzz
		{
			[Token(Token = "0x6001652")]
			[Address(RVA = "0x57D2370", Offset = "0x57D0F70", VA = "0x1857D2370")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x0001F530 File Offset: 0x0001D730
		[Token(Token = "0x17000643")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yxx
		{
			[Token(Token = "0x6001653")]
			[Address(RVA = "0x57D1880", Offset = "0x57D0480", VA = "0x1857D1880")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001654 RID: 5716 RVA: 0x0001F548 File Offset: 0x0001D748
		[Token(Token = "0x17000644")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yxy
		{
			[Token(Token = "0x6001654")]
			[Address(RVA = "0x57D1900", Offset = "0x57D0500", VA = "0x1857D1900")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x0001F560 File Offset: 0x0001D760
		// (set) Token: 0x06001656 RID: 5718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000645")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yxz
		{
			[Token(Token = "0x6001655")]
			[Address(RVA = "0x57D2480", Offset = "0x57D1080", VA = "0x1857D2480")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x6001656")]
			[Address(RVA = "0x57D3040", Offset = "0x57D1C40", VA = "0x1857D3040")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x0001F578 File Offset: 0x0001D778
		[Token(Token = "0x17000646")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yyx
		{
			[Token(Token = "0x6001657")]
			[Address(RVA = "0x57D19A0", Offset = "0x57D05A0", VA = "0x1857D19A0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001658 RID: 5720 RVA: 0x0001F590 File Offset: 0x0001D790
		[Token(Token = "0x17000647")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yyy
		{
			[Token(Token = "0x6001658")]
			[Address(RVA = "0x57D1A20", Offset = "0x57D0620", VA = "0x1857D1A20")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x0001F5A8 File Offset: 0x0001D7A8
		[Token(Token = "0x17000648")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yyz
		{
			[Token(Token = "0x6001659")]
			[Address(RVA = "0x57D2590", Offset = "0x57D1190", VA = "0x1857D2590")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x0600165A RID: 5722 RVA: 0x0001F5C0 File Offset: 0x0001D7C0
		// (set) Token: 0x0600165B RID: 5723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000649")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yzx
		{
			[Token(Token = "0x600165A")]
			[Address(RVA = "0x57D2660", Offset = "0x57D1260", VA = "0x1857D2660")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x600165B")]
			[Address(RVA = "0x57D3070", Offset = "0x57D1C70", VA = "0x1857D3070")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x0600165C RID: 5724 RVA: 0x0001F5D8 File Offset: 0x0001D7D8
		[Token(Token = "0x1700064A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yzy
		{
			[Token(Token = "0x600165C")]
			[Address(RVA = "0x57D2710", Offset = "0x57D1310", VA = "0x1857D2710")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x0001F5F0 File Offset: 0x0001D7F0
		[Token(Token = "0x1700064B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yzz
		{
			[Token(Token = "0x600165D")]
			[Address(RVA = "0x57D27C0", Offset = "0x57D13C0", VA = "0x1857D27C0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x0001F608 File Offset: 0x0001D808
		[Token(Token = "0x1700064C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zxx
		{
			[Token(Token = "0x600165E")]
			[Address(RVA = "0x57D2890", Offset = "0x57D1490", VA = "0x1857D2890")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x0001F620 File Offset: 0x0001D820
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700064D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zxy
		{
			[Token(Token = "0x600165F")]
			[Address(RVA = "0x57D2940", Offset = "0x57D1540", VA = "0x1857D2940")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x6001660")]
			[Address(RVA = "0x57D30A0", Offset = "0x57D1CA0", VA = "0x1857D30A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x0001F638 File Offset: 0x0001D838
		[Token(Token = "0x1700064E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zxz
		{
			[Token(Token = "0x6001661")]
			[Address(RVA = "0x57D29F0", Offset = "0x57D15F0", VA = "0x1857D29F0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x0001F650 File Offset: 0x0001D850
		// (set) Token: 0x06001663 RID: 5731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700064F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zyx
		{
			[Token(Token = "0x6001662")]
			[Address(RVA = "0x57D2AC0", Offset = "0x57D16C0", VA = "0x1857D2AC0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x6001663")]
			[Address(RVA = "0x57D30D0", Offset = "0x57D1CD0", VA = "0x1857D30D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x0001F668 File Offset: 0x0001D868
		[Token(Token = "0x17000650")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zyy
		{
			[Token(Token = "0x6001664")]
			[Address(RVA = "0x57D2B70", Offset = "0x57D1770", VA = "0x1857D2B70")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x0001F680 File Offset: 0x0001D880
		[Token(Token = "0x17000651")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zyz
		{
			[Token(Token = "0x6001665")]
			[Address(RVA = "0x57D2C20", Offset = "0x57D1820", VA = "0x1857D2C20")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x0001F698 File Offset: 0x0001D898
		[Token(Token = "0x17000652")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zzx
		{
			[Token(Token = "0x6001666")]
			[Address(RVA = "0x57D2CF0", Offset = "0x57D18F0", VA = "0x1857D2CF0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x0001F6B0 File Offset: 0x0001D8B0
		[Token(Token = "0x17000653")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zzy
		{
			[Token(Token = "0x6001667")]
			[Address(RVA = "0x57D2DA0", Offset = "0x57D19A0", VA = "0x1857D2DA0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x0001F6C8 File Offset: 0x0001D8C8
		[Token(Token = "0x17000654")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zzz
		{
			[Token(Token = "0x6001668")]
			[Address(RVA = "0x57D2E50", Offset = "0x57D1A50", VA = "0x1857D2E50")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x0001F6E0 File Offset: 0x0001D8E0
		[Token(Token = "0x17000655")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 xx
		{
			[Token(Token = "0x6001669")]
			[Address(RVA = "0x57D1630", Offset = "0x57D0230", VA = "0x1857D1630")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600166A RID: 5738 RVA: 0x0001F6F8 File Offset: 0x0001D8F8
		// (set) Token: 0x0600166B RID: 5739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000656")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 xy
		{
			[Token(Token = "0x600166A")]
			[Address(RVA = "0x57D1740", Offset = "0x57D0340", VA = "0x1857D1740")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x600166B")]
			[Address(RVA = "0x57D15D0", Offset = "0x57D01D0", VA = "0x1857D15D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x0600166C RID: 5740 RVA: 0x0001F710 File Offset: 0x0001D910
		// (set) Token: 0x0600166D RID: 5741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000657")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 xz
		{
			[Token(Token = "0x600166C")]
			[Address(RVA = "0x57D21F0", Offset = "0x57D0DF0", VA = "0x1857D21F0")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x600166D")]
			[Address(RVA = "0x57D3010", Offset = "0x57D1C10", VA = "0x1857D3010")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600166E RID: 5742 RVA: 0x0001F728 File Offset: 0x0001D928
		// (set) Token: 0x0600166F RID: 5743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000658")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 yx
		{
			[Token(Token = "0x600166E")]
			[Address(RVA = "0x57D1860", Offset = "0x57D0460", VA = "0x1857D1860")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x600166F")]
			[Address(RVA = "0x57D1B50", Offset = "0x57D0750", VA = "0x1857D1B50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001670 RID: 5744 RVA: 0x0001F740 File Offset: 0x0001D940
		[Token(Token = "0x17000659")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 yy
		{
			[Token(Token = "0x6001670")]
			[Address(RVA = "0x57D1980", Offset = "0x57D0580", VA = "0x1857D1980")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001671 RID: 5745 RVA: 0x0001F758 File Offset: 0x0001D958
		// (set) Token: 0x06001672 RID: 5746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 yz
		{
			[Token(Token = "0x6001671")]
			[Address(RVA = "0x57D2640", Offset = "0x57D1240", VA = "0x1857D2640")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x6001672")]
			[Address(RVA = "0x57D3060", Offset = "0x57D1C60", VA = "0x1857D3060")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x0001F770 File Offset: 0x0001D970
		// (set) Token: 0x06001674 RID: 5748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 zx
		{
			[Token(Token = "0x6001673")]
			[Address(RVA = "0x57D2870", Offset = "0x57D1470", VA = "0x1857D2870")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x6001674")]
			[Address(RVA = "0x57D3090", Offset = "0x57D1C90", VA = "0x1857D3090")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x0001F788 File Offset: 0x0001D988
		// (set) Token: 0x06001676 RID: 5750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700065C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 zy
		{
			[Token(Token = "0x6001675")]
			[Address(RVA = "0x57D2AA0", Offset = "0x57D16A0", VA = "0x1857D2AA0")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x6001676")]
			[Address(RVA = "0x57D30C0", Offset = "0x57D1CC0", VA = "0x1857D30C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x0001F7A0 File Offset: 0x0001D9A0
		[Token(Token = "0x1700065D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 zz
		{
			[Token(Token = "0x6001677")]
			[Address(RVA = "0x57D2CD0", Offset = "0x57D18D0", VA = "0x1857D2CD0")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
		}

		// Token: 0x1700065E RID: 1630
		[Token(Token = "0x1700065E")]
		public half this[int index]
		{
			[Token(Token = "0x6001678")]
			[Address(RVA = "0x3D28680", Offset = "0x3D27280", VA = "0x183D28680")]
			get
			{
				return default(half);
			}
			[Token(Token = "0x6001679")]
			[Address(RVA = "0x3D28A60", Offset = "0x3D27660", VA = "0x183D28A60")]
			set
			{
			}
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x0001F7D0 File Offset: 0x0001D9D0
		[Token(Token = "0x600167A")]
		[Address(RVA = "0x57D1B60", Offset = "0x57D0760", VA = "0x1857D1B60", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(half3 rhs)
		{
			return default(bool);
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		[Token(Token = "0x600167B")]
		[Address(RVA = "0x57D1B90", Offset = "0x57D0790", VA = "0x1857D1B90", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x0001F800 File Offset: 0x0001DA00
		[Token(Token = "0x600167C")]
		[Address(RVA = "0x57D1C30", Offset = "0x57D0830", VA = "0x1857D1C30", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x600167D")]
		[Address(RVA = "0x57D1D70", Offset = "0x57D0970", VA = "0x1857D1D70", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x600167E")]
		[Address(RVA = "0x57D1CB0", Offset = "0x57D08B0", VA = "0x1857D1CB0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x0")]
		public half x;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x2")]
		public half y;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x4")]
		public half z;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x0")]
		public static readonly half3 zero;

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x2000039")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x0600167F RID: 5759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600167F")]
			[Address(RVA = "0x57D11C0", Offset = "0x57CFDC0", VA = "0x1857D11C0")]
			public DebuggerProxy(half3 v)
			{
			}

			// Token: 0x040000DC RID: 220
			[Token(Token = "0x40000DC")]
			[FieldOffset(Offset = "0x10")]
			public half x;

			// Token: 0x040000DD RID: 221
			[Token(Token = "0x40000DD")]
			[FieldOffset(Offset = "0x12")]
			public half y;

			// Token: 0x040000DE RID: 222
			[Token(Token = "0x40000DE")]
			[FieldOffset(Offset = "0x14")]
			public half z;
		}
	}
}
