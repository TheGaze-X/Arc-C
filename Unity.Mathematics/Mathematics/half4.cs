using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	[DebuggerTypeProxy(typeof(half4.DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct half4 : IEquatable<half4>, IFormattable
	{
		// Token: 0x06001680 RID: 5760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001680")]
		[Address(RVA = "0x57599A0", Offset = "0x57585A0", VA = "0x1857599A0")]
		[MethodImpl(256)]
		public half4(half x, half y, half z, half w)
		{
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001681")]
		[Address(RVA = "0x57D36D0", Offset = "0x57D22D0", VA = "0x1857D36D0")]
		[MethodImpl(256)]
		public half4(half x, half y, half2 zw)
		{
		}

		// Token: 0x06001682 RID: 5762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001682")]
		[Address(RVA = "0x57D3820", Offset = "0x57D2420", VA = "0x1857D3820")]
		[MethodImpl(256)]
		public half4(half x, half2 yz, half w)
		{
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001683")]
		[Address(RVA = "0x57D3870", Offset = "0x57D2470", VA = "0x1857D3870")]
		[MethodImpl(256)]
		public half4(half x, half3 yzw)
		{
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001684")]
		[Address(RVA = "0x57D3600", Offset = "0x57D2200", VA = "0x1857D3600")]
		[MethodImpl(256)]
		public half4(half2 xy, half z, half w)
		{
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001685")]
		[Address(RVA = "0x57D3680", Offset = "0x57D2280", VA = "0x1857D3680")]
		[MethodImpl(256)]
		public half4(half2 xy, half2 zw)
		{
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001686")]
		[Address(RVA = "0x57D3850", Offset = "0x57D2450", VA = "0x1857D3850")]
		[MethodImpl(256)]
		public half4(half3 xyz, half w)
		{
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001687")]
		[Address(RVA = "0x57D36A0", Offset = "0x57D22A0", VA = "0x1857D36A0")]
		[MethodImpl(256)]
		public half4(half4 xyzw)
		{
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001688")]
		[Address(RVA = "0x57D3840", Offset = "0x57D2440", VA = "0x1857D3840")]
		[MethodImpl(256)]
		public half4(half v)
		{
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001689")]
		[Address(RVA = "0x57D37C0", Offset = "0x57D23C0", VA = "0x1857D37C0")]
		[MethodImpl(256)]
		public half4(float v)
		{
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168A")]
		[Address(RVA = "0x57D3620", Offset = "0x57D2220", VA = "0x1857D3620")]
		[MethodImpl(256)]
		public half4(float4 v)
		{
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168B")]
		[Address(RVA = "0x57D3760", Offset = "0x57D2360", VA = "0x1857D3760")]
		[MethodImpl(256)]
		public half4(double v)
		{
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600168C")]
		[Address(RVA = "0x57D36F0", Offset = "0x57D22F0", VA = "0x1857D36F0")]
		[MethodImpl(256)]
		public half4(double4 v)
		{
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0001F818 File Offset: 0x0001DA18
		[Token(Token = "0x600168D")]
		[Address(RVA = "0x571B690", Offset = "0x571A290", VA = "0x18571B690")]
		[MethodImpl(256)]
		public static implicit operator half4(half v)
		{
			return default(half4);
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0001F830 File Offset: 0x0001DA30
		[Token(Token = "0x600168E")]
		[Address(RVA = "0x571B780", Offset = "0x571A380", VA = "0x18571B780")]
		[MethodImpl(256)]
		public static explicit operator half4(float v)
		{
			return default(half4);
		}

		// Token: 0x0600168F RID: 5775 RVA: 0x0001F848 File Offset: 0x0001DA48
		[Token(Token = "0x600168F")]
		[Address(RVA = "0x571B900", Offset = "0x571A500", VA = "0x18571B900")]
		[MethodImpl(256)]
		public static explicit operator half4(float4 v)
		{
			return default(half4);
		}

		// Token: 0x06001690 RID: 5776 RVA: 0x0001F860 File Offset: 0x0001DA60
		[Token(Token = "0x6001690")]
		[Address(RVA = "0x571B840", Offset = "0x571A440", VA = "0x18571B840")]
		[MethodImpl(256)]
		public static explicit operator half4(double v)
		{
			return default(half4);
		}

		// Token: 0x06001691 RID: 5777 RVA: 0x0001F878 File Offset: 0x0001DA78
		[Token(Token = "0x6001691")]
		[Address(RVA = "0x571B6E0", Offset = "0x571A2E0", VA = "0x18571B6E0")]
		[MethodImpl(256)]
		public static explicit operator half4(double4 v)
		{
			return default(half4);
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0001F890 File Offset: 0x0001DA90
		[Token(Token = "0x6001692")]
		[Address(RVA = "0x57D5F10", Offset = "0x57D4B10", VA = "0x1857D5F10")]
		[MethodImpl(256)]
		public static bool4 operator ==(half4 lhs, half4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0001F8A8 File Offset: 0x0001DAA8
		[Token(Token = "0x6001693")]
		[Address(RVA = "0x57D5F60", Offset = "0x57D4B60", VA = "0x1857D5F60")]
		[MethodImpl(256)]
		public static bool4 operator ==(half4 lhs, half rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0001F8C0 File Offset: 0x0001DAC0
		[Token(Token = "0x6001694")]
		[Address(RVA = "0x57D5ED0", Offset = "0x57D4AD0", VA = "0x1857D5ED0")]
		[MethodImpl(256)]
		public static bool4 operator ==(half lhs, half4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0001F8D8 File Offset: 0x0001DAD8
		[Token(Token = "0x6001695")]
		[Address(RVA = "0x57D5FE0", Offset = "0x57D4BE0", VA = "0x1857D5FE0")]
		[MethodImpl(256)]
		public static bool4 operator !=(half4 lhs, half4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0001F8F0 File Offset: 0x0001DAF0
		[Token(Token = "0x6001696")]
		[Address(RVA = "0x57D5FA0", Offset = "0x57D4BA0", VA = "0x1857D5FA0")]
		[MethodImpl(256)]
		public static bool4 operator !=(half4 lhs, half rhs)
		{
			return default(bool4);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x0001F908 File Offset: 0x0001DB08
		[Token(Token = "0x6001697")]
		[Address(RVA = "0x57D6030", Offset = "0x57D4C30", VA = "0x1857D6030")]
		[MethodImpl(256)]
		public static bool4 operator !=(half lhs, half4 rhs)
		{
			return default(bool4);
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x0001F920 File Offset: 0x0001DB20
		[Token(Token = "0x1700065F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxxx
		{
			[Token(Token = "0x6001698")]
			[Address(RVA = "0x57D1670", Offset = "0x57D0270", VA = "0x1857D1670")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001699 RID: 5785 RVA: 0x0001F938 File Offset: 0x0001DB38
		[Token(Token = "0x17000660")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxxy
		{
			[Token(Token = "0x6001699")]
			[Address(RVA = "0x57D1690", Offset = "0x57D0290", VA = "0x1857D1690")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x0001F950 File Offset: 0x0001DB50
		[Token(Token = "0x17000661")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxxz
		{
			[Token(Token = "0x600169A")]
			[Address(RVA = "0x57D1FD0", Offset = "0x57D0BD0", VA = "0x1857D1FD0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x0001F968 File Offset: 0x0001DB68
		[Token(Token = "0x17000662")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxxw
		{
			[Token(Token = "0x600169B")]
			[Address(RVA = "0x57D4B80", Offset = "0x57D3780", VA = "0x1857D4B80")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x0001F980 File Offset: 0x0001DB80
		[Token(Token = "0x17000663")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxyx
		{
			[Token(Token = "0x600169C")]
			[Address(RVA = "0x57D16E0", Offset = "0x57D02E0", VA = "0x1857D16E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x0001F998 File Offset: 0x0001DB98
		[Token(Token = "0x17000664")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxyy
		{
			[Token(Token = "0x600169D")]
			[Address(RVA = "0x57D1710", Offset = "0x57D0310", VA = "0x1857D1710")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x0001F9B0 File Offset: 0x0001DBB0
		[Token(Token = "0x17000665")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxyz
		{
			[Token(Token = "0x600169E")]
			[Address(RVA = "0x57D2000", Offset = "0x57D0C00", VA = "0x1857D2000")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
		[Token(Token = "0x17000666")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxyw
		{
			[Token(Token = "0x600169F")]
			[Address(RVA = "0x57D4BB0", Offset = "0x57D37B0", VA = "0x1857D4BB0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0001F9E0 File Offset: 0x0001DBE0
		[Token(Token = "0x17000667")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxzx
		{
			[Token(Token = "0x60016A0")]
			[Address(RVA = "0x57D2050", Offset = "0x57D0C50", VA = "0x1857D2050")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x0001F9F8 File Offset: 0x0001DBF8
		[Token(Token = "0x17000668")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxzy
		{
			[Token(Token = "0x60016A1")]
			[Address(RVA = "0x57D2080", Offset = "0x57D0C80", VA = "0x1857D2080")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x0001FA10 File Offset: 0x0001DC10
		[Token(Token = "0x17000669")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxzz
		{
			[Token(Token = "0x60016A2")]
			[Address(RVA = "0x57D20B0", Offset = "0x57D0CB0", VA = "0x1857D20B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x0001FA28 File Offset: 0x0001DC28
		[Token(Token = "0x1700066A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxzw
		{
			[Token(Token = "0x60016A3")]
			[Address(RVA = "0x57D4BE0", Offset = "0x57D37E0", VA = "0x1857D4BE0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x0001FA40 File Offset: 0x0001DC40
		[Token(Token = "0x1700066B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxwx
		{
			[Token(Token = "0x60016A4")]
			[Address(RVA = "0x57D4AF0", Offset = "0x57D36F0", VA = "0x1857D4AF0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x0001FA58 File Offset: 0x0001DC58
		[Token(Token = "0x1700066C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxwy
		{
			[Token(Token = "0x60016A5")]
			[Address(RVA = "0x57D4B20", Offset = "0x57D3720", VA = "0x1857D4B20")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x0001FA70 File Offset: 0x0001DC70
		[Token(Token = "0x1700066D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxwz
		{
			[Token(Token = "0x60016A6")]
			[Address(RVA = "0x57D4B50", Offset = "0x57D3750", VA = "0x1857D4B50")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x0001FA88 File Offset: 0x0001DC88
		[Token(Token = "0x1700066E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xxww
		{
			[Token(Token = "0x60016A7")]
			[Address(RVA = "0x57D4AC0", Offset = "0x57D36C0", VA = "0x1857D4AC0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x0001FAA0 File Offset: 0x0001DCA0
		[Token(Token = "0x1700066F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyxx
		{
			[Token(Token = "0x60016A8")]
			[Address(RVA = "0x57D1780", Offset = "0x57D0380", VA = "0x1857D1780")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x0001FAB8 File Offset: 0x0001DCB8
		[Token(Token = "0x17000670")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyxy
		{
			[Token(Token = "0x60016A9")]
			[Address(RVA = "0x57D17B0", Offset = "0x57D03B0", VA = "0x1857D17B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060016AA RID: 5802 RVA: 0x0001FAD0 File Offset: 0x0001DCD0
		[Token(Token = "0x17000671")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyxz
		{
			[Token(Token = "0x60016AA")]
			[Address(RVA = "0x57D20E0", Offset = "0x57D0CE0", VA = "0x1857D20E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x0001FAE8 File Offset: 0x0001DCE8
		[Token(Token = "0x17000672")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyxw
		{
			[Token(Token = "0x60016AB")]
			[Address(RVA = "0x57D4CF0", Offset = "0x57D38F0", VA = "0x1857D4CF0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x060016AC RID: 5804 RVA: 0x0001FB00 File Offset: 0x0001DD00
		[Token(Token = "0x17000673")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyyx
		{
			[Token(Token = "0x60016AC")]
			[Address(RVA = "0x57D1800", Offset = "0x57D0400", VA = "0x1857D1800")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x0001FB18 File Offset: 0x0001DD18
		[Token(Token = "0x17000674")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyyy
		{
			[Token(Token = "0x60016AD")]
			[Address(RVA = "0x57D1830", Offset = "0x57D0430", VA = "0x1857D1830")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x060016AE RID: 5806 RVA: 0x0001FB30 File Offset: 0x0001DD30
		[Token(Token = "0x17000675")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyyz
		{
			[Token(Token = "0x60016AE")]
			[Address(RVA = "0x57D2110", Offset = "0x57D0D10", VA = "0x1857D2110")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x060016AF RID: 5807 RVA: 0x0001FB48 File Offset: 0x0001DD48
		[Token(Token = "0x17000676")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyyw
		{
			[Token(Token = "0x60016AF")]
			[Address(RVA = "0x57D4D20", Offset = "0x57D3920", VA = "0x1857D4D20")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x060016B0 RID: 5808 RVA: 0x0001FB60 File Offset: 0x0001DD60
		[Token(Token = "0x17000677")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyzx
		{
			[Token(Token = "0x60016B0")]
			[Address(RVA = "0x57D2160", Offset = "0x57D0D60", VA = "0x1857D2160")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x060016B1 RID: 5809 RVA: 0x0001FB78 File Offset: 0x0001DD78
		[Token(Token = "0x17000678")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyzy
		{
			[Token(Token = "0x60016B1")]
			[Address(RVA = "0x57D2190", Offset = "0x57D0D90", VA = "0x1857D2190")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060016B2 RID: 5810 RVA: 0x0001FB90 File Offset: 0x0001DD90
		[Token(Token = "0x17000679")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyzz
		{
			[Token(Token = "0x60016B2")]
			[Address(RVA = "0x57D21C0", Offset = "0x57D0DC0", VA = "0x1857D21C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x060016B3 RID: 5811 RVA: 0x0001FBA8 File Offset: 0x0001DDA8
		// (set) Token: 0x060016B4 RID: 5812 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyzw
		{
			[Token(Token = "0x60016B3")]
			[Address(RVA = "0x57D4D50", Offset = "0x57D3950", VA = "0x1857D4D50")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x60016B4")]
			[Address(RVA = "0x57D36A0", Offset = "0x57D22A0", VA = "0x1857D36A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x0001FBC0 File Offset: 0x0001DDC0
		[Token(Token = "0x1700067B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xywx
		{
			[Token(Token = "0x60016B5")]
			[Address(RVA = "0x57D4C60", Offset = "0x57D3860", VA = "0x1857D4C60")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x060016B6 RID: 5814 RVA: 0x0001FBD8 File Offset: 0x0001DDD8
		[Token(Token = "0x1700067C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xywy
		{
			[Token(Token = "0x60016B6")]
			[Address(RVA = "0x57D4C90", Offset = "0x57D3890", VA = "0x1857D4C90")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x0001FBF0 File Offset: 0x0001DDF0
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700067D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xywz
		{
			[Token(Token = "0x60016B7")]
			[Address(RVA = "0x57D4CC0", Offset = "0x57D38C0", VA = "0x1857D4CC0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x60016B8")]
			[Address(RVA = "0x57D6350", Offset = "0x57D4F50", VA = "0x1857D6350")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x0001FC08 File Offset: 0x0001DE08
		[Token(Token = "0x1700067E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xyww
		{
			[Token(Token = "0x60016B9")]
			[Address(RVA = "0x57D4C30", Offset = "0x57D3830", VA = "0x1857D4C30")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x0001FC20 File Offset: 0x0001DE20
		[Token(Token = "0x1700067F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzxx
		{
			[Token(Token = "0x60016BA")]
			[Address(RVA = "0x57D2230", Offset = "0x57D0E30", VA = "0x1857D2230")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x0001FC38 File Offset: 0x0001DE38
		[Token(Token = "0x17000680")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzxy
		{
			[Token(Token = "0x60016BB")]
			[Address(RVA = "0x57D2260", Offset = "0x57D0E60", VA = "0x1857D2260")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x0001FC50 File Offset: 0x0001DE50
		[Token(Token = "0x17000681")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzxz
		{
			[Token(Token = "0x60016BC")]
			[Address(RVA = "0x57D2290", Offset = "0x57D0E90", VA = "0x1857D2290")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x0001FC68 File Offset: 0x0001DE68
		[Token(Token = "0x17000682")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzxw
		{
			[Token(Token = "0x60016BD")]
			[Address(RVA = "0x57D4E60", Offset = "0x57D3A60", VA = "0x1857D4E60")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x0001FC80 File Offset: 0x0001DE80
		[Token(Token = "0x17000683")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzyx
		{
			[Token(Token = "0x60016BE")]
			[Address(RVA = "0x57D22E0", Offset = "0x57D0EE0", VA = "0x1857D22E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x0001FC98 File Offset: 0x0001DE98
		[Token(Token = "0x17000684")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzyy
		{
			[Token(Token = "0x60016BF")]
			[Address(RVA = "0x57D2310", Offset = "0x57D0F10", VA = "0x1857D2310")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x0001FCB0 File Offset: 0x0001DEB0
		[Token(Token = "0x17000685")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzyz
		{
			[Token(Token = "0x60016C0")]
			[Address(RVA = "0x57D2340", Offset = "0x57D0F40", VA = "0x1857D2340")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000686")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzyw
		{
			[Token(Token = "0x60016C1")]
			[Address(RVA = "0x57D4E90", Offset = "0x57D3A90", VA = "0x1857D4E90")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x60016C2")]
			[Address(RVA = "0x57D63D0", Offset = "0x57D4FD0", VA = "0x1857D63D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x0001FCE0 File Offset: 0x0001DEE0
		[Token(Token = "0x17000687")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzzx
		{
			[Token(Token = "0x60016C3")]
			[Address(RVA = "0x57D2390", Offset = "0x57D0F90", VA = "0x1857D2390")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x060016C4 RID: 5828 RVA: 0x0001FCF8 File Offset: 0x0001DEF8
		[Token(Token = "0x17000688")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzzy
		{
			[Token(Token = "0x60016C4")]
			[Address(RVA = "0x57D23C0", Offset = "0x57D0FC0", VA = "0x1857D23C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x060016C5 RID: 5829 RVA: 0x0001FD10 File Offset: 0x0001DF10
		[Token(Token = "0x17000689")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzzz
		{
			[Token(Token = "0x60016C5")]
			[Address(RVA = "0x57D23F0", Offset = "0x57D0FF0", VA = "0x1857D23F0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x0001FD28 File Offset: 0x0001DF28
		[Token(Token = "0x1700068A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzzw
		{
			[Token(Token = "0x60016C6")]
			[Address(RVA = "0x57D4EC0", Offset = "0x57D3AC0", VA = "0x1857D4EC0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x060016C7 RID: 5831 RVA: 0x0001FD40 File Offset: 0x0001DF40
		[Token(Token = "0x1700068B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzwx
		{
			[Token(Token = "0x60016C7")]
			[Address(RVA = "0x57D4DD0", Offset = "0x57D39D0", VA = "0x1857D4DD0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x0001FD58 File Offset: 0x0001DF58
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700068C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzwy
		{
			[Token(Token = "0x60016C8")]
			[Address(RVA = "0x57D4E00", Offset = "0x57D3A00", VA = "0x1857D4E00")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x60016C9")]
			[Address(RVA = "0x57D63A0", Offset = "0x57D4FA0", VA = "0x1857D63A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x0001FD70 File Offset: 0x0001DF70
		[Token(Token = "0x1700068D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzwz
		{
			[Token(Token = "0x60016CA")]
			[Address(RVA = "0x57D4E30", Offset = "0x57D3A30", VA = "0x1857D4E30")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x0001FD88 File Offset: 0x0001DF88
		[Token(Token = "0x1700068E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xzww
		{
			[Token(Token = "0x60016CB")]
			[Address(RVA = "0x57D4DA0", Offset = "0x57D39A0", VA = "0x1857D4DA0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060016CC RID: 5836 RVA: 0x0001FDA0 File Offset: 0x0001DFA0
		[Token(Token = "0x1700068F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwxx
		{
			[Token(Token = "0x60016CC")]
			[Address(RVA = "0x57D4850", Offset = "0x57D3450", VA = "0x1857D4850")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x060016CD RID: 5837 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
		[Token(Token = "0x17000690")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwxy
		{
			[Token(Token = "0x60016CD")]
			[Address(RVA = "0x57D4880", Offset = "0x57D3480", VA = "0x1857D4880")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x0001FDD0 File Offset: 0x0001DFD0
		[Token(Token = "0x17000691")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwxz
		{
			[Token(Token = "0x60016CE")]
			[Address(RVA = "0x57D48B0", Offset = "0x57D34B0", VA = "0x1857D48B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x060016CF RID: 5839 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
		[Token(Token = "0x17000692")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwxw
		{
			[Token(Token = "0x60016CF")]
			[Address(RVA = "0x57D4820", Offset = "0x57D3420", VA = "0x1857D4820")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x0001FE00 File Offset: 0x0001E000
		[Token(Token = "0x17000693")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwyx
		{
			[Token(Token = "0x60016D0")]
			[Address(RVA = "0x57D4930", Offset = "0x57D3530", VA = "0x1857D4930")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x0001FE18 File Offset: 0x0001E018
		[Token(Token = "0x17000694")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwyy
		{
			[Token(Token = "0x60016D1")]
			[Address(RVA = "0x57D4960", Offset = "0x57D3560", VA = "0x1857D4960")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x0001FE30 File Offset: 0x0001E030
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000695")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwyz
		{
			[Token(Token = "0x60016D2")]
			[Address(RVA = "0x57D4990", Offset = "0x57D3590", VA = "0x1857D4990")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x60016D3")]
			[Address(RVA = "0x57D62B0", Offset = "0x57D4EB0", VA = "0x1857D62B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x0001FE48 File Offset: 0x0001E048
		[Token(Token = "0x17000696")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwyw
		{
			[Token(Token = "0x60016D4")]
			[Address(RVA = "0x57D4900", Offset = "0x57D3500", VA = "0x1857D4900")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x0001FE60 File Offset: 0x0001E060
		[Token(Token = "0x17000697")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwzx
		{
			[Token(Token = "0x60016D5")]
			[Address(RVA = "0x57D4A10", Offset = "0x57D3610", VA = "0x1857D4A10")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x0001FE78 File Offset: 0x0001E078
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000698")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwzy
		{
			[Token(Token = "0x60016D6")]
			[Address(RVA = "0x57D4A40", Offset = "0x57D3640", VA = "0x1857D4A40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x60016D7")]
			[Address(RVA = "0x57D6300", Offset = "0x57D4F00", VA = "0x1857D6300")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x0001FE90 File Offset: 0x0001E090
		[Token(Token = "0x17000699")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwzz
		{
			[Token(Token = "0x60016D8")]
			[Address(RVA = "0x57D4A70", Offset = "0x57D3670", VA = "0x1857D4A70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x060016D9 RID: 5849 RVA: 0x0001FEA8 File Offset: 0x0001E0A8
		[Token(Token = "0x1700069A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwzw
		{
			[Token(Token = "0x60016D9")]
			[Address(RVA = "0x57D49E0", Offset = "0x57D35E0", VA = "0x1857D49E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x0001FEC0 File Offset: 0x0001E0C0
		[Token(Token = "0x1700069B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwwx
		{
			[Token(Token = "0x60016DA")]
			[Address(RVA = "0x57D4770", Offset = "0x57D3370", VA = "0x1857D4770")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x060016DB RID: 5851 RVA: 0x0001FED8 File Offset: 0x0001E0D8
		[Token(Token = "0x1700069C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwwy
		{
			[Token(Token = "0x60016DB")]
			[Address(RVA = "0x57D47A0", Offset = "0x57D33A0", VA = "0x1857D47A0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x0001FEF0 File Offset: 0x0001E0F0
		[Token(Token = "0x1700069D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwwz
		{
			[Token(Token = "0x60016DC")]
			[Address(RVA = "0x57D47D0", Offset = "0x57D33D0", VA = "0x1857D47D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060016DD RID: 5853 RVA: 0x0001FF08 File Offset: 0x0001E108
		[Token(Token = "0x1700069E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 xwww
		{
			[Token(Token = "0x60016DD")]
			[Address(RVA = "0x57D4740", Offset = "0x57D3340", VA = "0x1857D4740")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060016DE RID: 5854 RVA: 0x0001FF20 File Offset: 0x0001E120
		[Token(Token = "0x1700069F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxxx
		{
			[Token(Token = "0x60016DE")]
			[Address(RVA = "0x57D18A0", Offset = "0x57D04A0", VA = "0x1857D18A0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x060016DF RID: 5855 RVA: 0x0001FF38 File Offset: 0x0001E138
		[Token(Token = "0x170006A0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxxy
		{
			[Token(Token = "0x60016DF")]
			[Address(RVA = "0x57D18D0", Offset = "0x57D04D0", VA = "0x1857D18D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060016E0 RID: 5856 RVA: 0x0001FF50 File Offset: 0x0001E150
		[Token(Token = "0x170006A1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxxz
		{
			[Token(Token = "0x60016E0")]
			[Address(RVA = "0x57D2420", Offset = "0x57D1020", VA = "0x1857D2420")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060016E1 RID: 5857 RVA: 0x0001FF68 File Offset: 0x0001E168
		[Token(Token = "0x170006A2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxxw
		{
			[Token(Token = "0x60016E1")]
			[Address(RVA = "0x57D5370", Offset = "0x57D3F70", VA = "0x1857D5370")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060016E2 RID: 5858 RVA: 0x0001FF80 File Offset: 0x0001E180
		[Token(Token = "0x170006A3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxyx
		{
			[Token(Token = "0x60016E2")]
			[Address(RVA = "0x57D1920", Offset = "0x57D0520", VA = "0x1857D1920")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x060016E3 RID: 5859 RVA: 0x0001FF98 File Offset: 0x0001E198
		[Token(Token = "0x170006A4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxyy
		{
			[Token(Token = "0x60016E3")]
			[Address(RVA = "0x57D1950", Offset = "0x57D0550", VA = "0x1857D1950")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x0001FFB0 File Offset: 0x0001E1B0
		[Token(Token = "0x170006A5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxyz
		{
			[Token(Token = "0x60016E4")]
			[Address(RVA = "0x57D2450", Offset = "0x57D1050", VA = "0x1857D2450")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x060016E5 RID: 5861 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		[Token(Token = "0x170006A6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxyw
		{
			[Token(Token = "0x60016E5")]
			[Address(RVA = "0x57D53A0", Offset = "0x57D3FA0", VA = "0x1857D53A0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x060016E6 RID: 5862 RVA: 0x0001FFE0 File Offset: 0x0001E1E0
		[Token(Token = "0x170006A7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxzx
		{
			[Token(Token = "0x60016E6")]
			[Address(RVA = "0x57D24A0", Offset = "0x57D10A0", VA = "0x1857D24A0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x060016E7 RID: 5863 RVA: 0x0001FFF8 File Offset: 0x0001E1F8
		[Token(Token = "0x170006A8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxzy
		{
			[Token(Token = "0x60016E7")]
			[Address(RVA = "0x57D24D0", Offset = "0x57D10D0", VA = "0x1857D24D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x00020010 File Offset: 0x0001E210
		[Token(Token = "0x170006A9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxzz
		{
			[Token(Token = "0x60016E8")]
			[Address(RVA = "0x57D2500", Offset = "0x57D1100", VA = "0x1857D2500")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006AA RID: 1706
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x00020028 File Offset: 0x0001E228
		// (set) Token: 0x060016EA RID: 5866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxzw
		{
			[Token(Token = "0x60016E9")]
			[Address(RVA = "0x57D53D0", Offset = "0x57D3FD0", VA = "0x1857D53D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x60016EA")]
			[Address(RVA = "0x57D6500", Offset = "0x57D5100", VA = "0x1857D6500")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170006AB RID: 1707
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x00020040 File Offset: 0x0001E240
		[Token(Token = "0x170006AB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxwx
		{
			[Token(Token = "0x60016EB")]
			[Address(RVA = "0x57D52E0", Offset = "0x57D3EE0", VA = "0x1857D52E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006AC RID: 1708
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x00020058 File Offset: 0x0001E258
		[Token(Token = "0x170006AC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxwy
		{
			[Token(Token = "0x60016EC")]
			[Address(RVA = "0x57D5310", Offset = "0x57D3F10", VA = "0x1857D5310")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x00020070 File Offset: 0x0001E270
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006AD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxwz
		{
			[Token(Token = "0x60016ED")]
			[Address(RVA = "0x57D5340", Offset = "0x57D3F40", VA = "0x1857D5340")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x60016EE")]
			[Address(RVA = "0x57D64D0", Offset = "0x57D50D0", VA = "0x1857D64D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x00020088 File Offset: 0x0001E288
		[Token(Token = "0x170006AE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yxww
		{
			[Token(Token = "0x60016EF")]
			[Address(RVA = "0x57D52B0", Offset = "0x57D3EB0", VA = "0x1857D52B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x060016F0 RID: 5872 RVA: 0x000200A0 File Offset: 0x0001E2A0
		[Token(Token = "0x170006AF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyxx
		{
			[Token(Token = "0x60016F0")]
			[Address(RVA = "0x57D19C0", Offset = "0x57D05C0", VA = "0x1857D19C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x000200B8 File Offset: 0x0001E2B8
		[Token(Token = "0x170006B0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyxy
		{
			[Token(Token = "0x60016F1")]
			[Address(RVA = "0x57D19F0", Offset = "0x57D05F0", VA = "0x1857D19F0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x000200D0 File Offset: 0x0001E2D0
		[Token(Token = "0x170006B1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyxz
		{
			[Token(Token = "0x60016F2")]
			[Address(RVA = "0x57D2530", Offset = "0x57D1130", VA = "0x1857D2530")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x000200E8 File Offset: 0x0001E2E8
		[Token(Token = "0x170006B2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyxw
		{
			[Token(Token = "0x60016F3")]
			[Address(RVA = "0x57D54E0", Offset = "0x57D40E0", VA = "0x1857D54E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x060016F4 RID: 5876 RVA: 0x00020100 File Offset: 0x0001E300
		[Token(Token = "0x170006B3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyyx
		{
			[Token(Token = "0x60016F4")]
			[Address(RVA = "0x57D1A40", Offset = "0x57D0640", VA = "0x1857D1A40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x00020118 File Offset: 0x0001E318
		[Token(Token = "0x170006B4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyyy
		{
			[Token(Token = "0x60016F5")]
			[Address(RVA = "0x57D1A70", Offset = "0x57D0670", VA = "0x1857D1A70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x060016F6 RID: 5878 RVA: 0x00020130 File Offset: 0x0001E330
		[Token(Token = "0x170006B5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyyz
		{
			[Token(Token = "0x60016F6")]
			[Address(RVA = "0x57D2560", Offset = "0x57D1160", VA = "0x1857D2560")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x00020148 File Offset: 0x0001E348
		[Token(Token = "0x170006B6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyyw
		{
			[Token(Token = "0x60016F7")]
			[Address(RVA = "0x57D5510", Offset = "0x57D4110", VA = "0x1857D5510")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x060016F8 RID: 5880 RVA: 0x00020160 File Offset: 0x0001E360
		[Token(Token = "0x170006B7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyzx
		{
			[Token(Token = "0x60016F8")]
			[Address(RVA = "0x57D25B0", Offset = "0x57D11B0", VA = "0x1857D25B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x060016F9 RID: 5881 RVA: 0x00020178 File Offset: 0x0001E378
		[Token(Token = "0x170006B8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyzy
		{
			[Token(Token = "0x60016F9")]
			[Address(RVA = "0x57D25E0", Offset = "0x57D11E0", VA = "0x1857D25E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x060016FA RID: 5882 RVA: 0x00020190 File Offset: 0x0001E390
		[Token(Token = "0x170006B9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyzz
		{
			[Token(Token = "0x60016FA")]
			[Address(RVA = "0x57D2610", Offset = "0x57D1210", VA = "0x1857D2610")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060016FB RID: 5883 RVA: 0x000201A8 File Offset: 0x0001E3A8
		[Token(Token = "0x170006BA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyzw
		{
			[Token(Token = "0x60016FB")]
			[Address(RVA = "0x57D5540", Offset = "0x57D4140", VA = "0x1857D5540")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060016FC RID: 5884 RVA: 0x000201C0 File Offset: 0x0001E3C0
		[Token(Token = "0x170006BB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yywx
		{
			[Token(Token = "0x60016FC")]
			[Address(RVA = "0x57D5450", Offset = "0x57D4050", VA = "0x1857D5450")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060016FD RID: 5885 RVA: 0x000201D8 File Offset: 0x0001E3D8
		[Token(Token = "0x170006BC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yywy
		{
			[Token(Token = "0x60016FD")]
			[Address(RVA = "0x57D5480", Offset = "0x57D4080", VA = "0x1857D5480")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060016FE RID: 5886 RVA: 0x000201F0 File Offset: 0x0001E3F0
		[Token(Token = "0x170006BD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yywz
		{
			[Token(Token = "0x60016FE")]
			[Address(RVA = "0x57D54B0", Offset = "0x57D40B0", VA = "0x1857D54B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060016FF RID: 5887 RVA: 0x00020208 File Offset: 0x0001E408
		[Token(Token = "0x170006BE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yyww
		{
			[Token(Token = "0x60016FF")]
			[Address(RVA = "0x57D5420", Offset = "0x57D4020", VA = "0x1857D5420")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x00020220 File Offset: 0x0001E420
		[Token(Token = "0x170006BF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzxx
		{
			[Token(Token = "0x6001700")]
			[Address(RVA = "0x57D2680", Offset = "0x57D1280", VA = "0x1857D2680")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x00020238 File Offset: 0x0001E438
		[Token(Token = "0x170006C0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzxy
		{
			[Token(Token = "0x6001701")]
			[Address(RVA = "0x57D26B0", Offset = "0x57D12B0", VA = "0x1857D26B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001702 RID: 5890 RVA: 0x00020250 File Offset: 0x0001E450
		[Token(Token = "0x170006C1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzxz
		{
			[Token(Token = "0x6001702")]
			[Address(RVA = "0x57D26E0", Offset = "0x57D12E0", VA = "0x1857D26E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001703 RID: 5891 RVA: 0x00020268 File Offset: 0x0001E468
		// (set) Token: 0x06001704 RID: 5892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzxw
		{
			[Token(Token = "0x6001703")]
			[Address(RVA = "0x57D5650", Offset = "0x57D4250", VA = "0x1857D5650")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x6001704")]
			[Address(RVA = "0x57D6580", Offset = "0x57D5180", VA = "0x1857D6580")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x00020280 File Offset: 0x0001E480
		[Token(Token = "0x170006C3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzyx
		{
			[Token(Token = "0x6001705")]
			[Address(RVA = "0x57D2730", Offset = "0x57D1330", VA = "0x1857D2730")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x00020298 File Offset: 0x0001E498
		[Token(Token = "0x170006C4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzyy
		{
			[Token(Token = "0x6001706")]
			[Address(RVA = "0x57D2760", Offset = "0x57D1360", VA = "0x1857D2760")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x000202B0 File Offset: 0x0001E4B0
		[Token(Token = "0x170006C5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzyz
		{
			[Token(Token = "0x6001707")]
			[Address(RVA = "0x57D2790", Offset = "0x57D1390", VA = "0x1857D2790")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x000202C8 File Offset: 0x0001E4C8
		[Token(Token = "0x170006C6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzyw
		{
			[Token(Token = "0x6001708")]
			[Address(RVA = "0x57D5680", Offset = "0x57D4280", VA = "0x1857D5680")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x000202E0 File Offset: 0x0001E4E0
		[Token(Token = "0x170006C7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzzx
		{
			[Token(Token = "0x6001709")]
			[Address(RVA = "0x57D27E0", Offset = "0x57D13E0", VA = "0x1857D27E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x000202F8 File Offset: 0x0001E4F8
		[Token(Token = "0x170006C8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzzy
		{
			[Token(Token = "0x600170A")]
			[Address(RVA = "0x57D2810", Offset = "0x57D1410", VA = "0x1857D2810")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x00020310 File Offset: 0x0001E510
		[Token(Token = "0x170006C9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzzz
		{
			[Token(Token = "0x600170B")]
			[Address(RVA = "0x57D2840", Offset = "0x57D1440", VA = "0x1857D2840")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x00020328 File Offset: 0x0001E528
		[Token(Token = "0x170006CA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzzw
		{
			[Token(Token = "0x600170C")]
			[Address(RVA = "0x57D56B0", Offset = "0x57D42B0", VA = "0x1857D56B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x00020340 File Offset: 0x0001E540
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006CB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzwx
		{
			[Token(Token = "0x600170D")]
			[Address(RVA = "0x57D55C0", Offset = "0x57D41C0", VA = "0x1857D55C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x600170E")]
			[Address(RVA = "0x57D6550", Offset = "0x57D5150", VA = "0x1857D6550")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x00020358 File Offset: 0x0001E558
		[Token(Token = "0x170006CC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzwy
		{
			[Token(Token = "0x600170F")]
			[Address(RVA = "0x57D55F0", Offset = "0x57D41F0", VA = "0x1857D55F0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x00020370 File Offset: 0x0001E570
		[Token(Token = "0x170006CD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzwz
		{
			[Token(Token = "0x6001710")]
			[Address(RVA = "0x57D5620", Offset = "0x57D4220", VA = "0x1857D5620")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001711 RID: 5905 RVA: 0x00020388 File Offset: 0x0001E588
		[Token(Token = "0x170006CE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 yzww
		{
			[Token(Token = "0x6001711")]
			[Address(RVA = "0x57D5590", Offset = "0x57D4190", VA = "0x1857D5590")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x000203A0 File Offset: 0x0001E5A0
		[Token(Token = "0x170006CF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywxx
		{
			[Token(Token = "0x6001712")]
			[Address(RVA = "0x57D5040", Offset = "0x57D3C40", VA = "0x1857D5040")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001713 RID: 5907 RVA: 0x000203B8 File Offset: 0x0001E5B8
		[Token(Token = "0x170006D0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywxy
		{
			[Token(Token = "0x6001713")]
			[Address(RVA = "0x57D5070", Offset = "0x57D3C70", VA = "0x1857D5070")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x000203D0 File Offset: 0x0001E5D0
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywxz
		{
			[Token(Token = "0x6001714")]
			[Address(RVA = "0x57D50A0", Offset = "0x57D3CA0", VA = "0x1857D50A0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x6001715")]
			[Address(RVA = "0x57D6430", Offset = "0x57D5030", VA = "0x1857D6430")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001716 RID: 5910 RVA: 0x000203E8 File Offset: 0x0001E5E8
		[Token(Token = "0x170006D2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywxw
		{
			[Token(Token = "0x6001716")]
			[Address(RVA = "0x57D5010", Offset = "0x57D3C10", VA = "0x1857D5010")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x00020400 File Offset: 0x0001E600
		[Token(Token = "0x170006D3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywyx
		{
			[Token(Token = "0x6001717")]
			[Address(RVA = "0x57D5120", Offset = "0x57D3D20", VA = "0x1857D5120")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x00020418 File Offset: 0x0001E618
		[Token(Token = "0x170006D4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywyy
		{
			[Token(Token = "0x6001718")]
			[Address(RVA = "0x57D5150", Offset = "0x57D3D50", VA = "0x1857D5150")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x00020430 File Offset: 0x0001E630
		[Token(Token = "0x170006D5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywyz
		{
			[Token(Token = "0x6001719")]
			[Address(RVA = "0x57D5180", Offset = "0x57D3D80", VA = "0x1857D5180")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x00020448 File Offset: 0x0001E648
		[Token(Token = "0x170006D6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywyw
		{
			[Token(Token = "0x600171A")]
			[Address(RVA = "0x57D50F0", Offset = "0x57D3CF0", VA = "0x1857D50F0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x00020460 File Offset: 0x0001E660
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywzx
		{
			[Token(Token = "0x600171B")]
			[Address(RVA = "0x57D5200", Offset = "0x57D3E00", VA = "0x1857D5200")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x600171C")]
			[Address(RVA = "0x57D6480", Offset = "0x57D5080", VA = "0x1857D6480")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00020478 File Offset: 0x0001E678
		[Token(Token = "0x170006D8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywzy
		{
			[Token(Token = "0x600171D")]
			[Address(RVA = "0x57D5230", Offset = "0x57D3E30", VA = "0x1857D5230")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x00020490 File Offset: 0x0001E690
		[Token(Token = "0x170006D9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywzz
		{
			[Token(Token = "0x600171E")]
			[Address(RVA = "0x57D5260", Offset = "0x57D3E60", VA = "0x1857D5260")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x000204A8 File Offset: 0x0001E6A8
		[Token(Token = "0x170006DA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywzw
		{
			[Token(Token = "0x600171F")]
			[Address(RVA = "0x57D51D0", Offset = "0x57D3DD0", VA = "0x1857D51D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001720 RID: 5920 RVA: 0x000204C0 File Offset: 0x0001E6C0
		[Token(Token = "0x170006DB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywwx
		{
			[Token(Token = "0x6001720")]
			[Address(RVA = "0x57D4F60", Offset = "0x57D3B60", VA = "0x1857D4F60")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001721 RID: 5921 RVA: 0x000204D8 File Offset: 0x0001E6D8
		[Token(Token = "0x170006DC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywwy
		{
			[Token(Token = "0x6001721")]
			[Address(RVA = "0x57D4F90", Offset = "0x57D3B90", VA = "0x1857D4F90")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001722 RID: 5922 RVA: 0x000204F0 File Offset: 0x0001E6F0
		[Token(Token = "0x170006DD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywwz
		{
			[Token(Token = "0x6001722")]
			[Address(RVA = "0x57D4FC0", Offset = "0x57D3BC0", VA = "0x1857D4FC0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001723 RID: 5923 RVA: 0x00020508 File Offset: 0x0001E708
		[Token(Token = "0x170006DE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 ywww
		{
			[Token(Token = "0x6001723")]
			[Address(RVA = "0x57D4F30", Offset = "0x57D3B30", VA = "0x1857D4F30")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001724 RID: 5924 RVA: 0x00020520 File Offset: 0x0001E720
		[Token(Token = "0x170006DF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxxx
		{
			[Token(Token = "0x6001724")]
			[Address(RVA = "0x57D28B0", Offset = "0x57D14B0", VA = "0x1857D28B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001725 RID: 5925 RVA: 0x00020538 File Offset: 0x0001E738
		[Token(Token = "0x170006E0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxxy
		{
			[Token(Token = "0x6001725")]
			[Address(RVA = "0x57D28E0", Offset = "0x57D14E0", VA = "0x1857D28E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001726 RID: 5926 RVA: 0x00020550 File Offset: 0x0001E750
		[Token(Token = "0x170006E1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxxz
		{
			[Token(Token = "0x6001726")]
			[Address(RVA = "0x57D2910", Offset = "0x57D1510", VA = "0x1857D2910")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001727 RID: 5927 RVA: 0x00020568 File Offset: 0x0001E768
		[Token(Token = "0x170006E2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxxw
		{
			[Token(Token = "0x6001727")]
			[Address(RVA = "0x57D5B60", Offset = "0x57D4760", VA = "0x1857D5B60")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x06001728 RID: 5928 RVA: 0x00020580 File Offset: 0x0001E780
		[Token(Token = "0x170006E3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxyx
		{
			[Token(Token = "0x6001728")]
			[Address(RVA = "0x57D2960", Offset = "0x57D1560", VA = "0x1857D2960")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x06001729 RID: 5929 RVA: 0x00020598 File Offset: 0x0001E798
		[Token(Token = "0x170006E4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxyy
		{
			[Token(Token = "0x6001729")]
			[Address(RVA = "0x57D2990", Offset = "0x57D1590", VA = "0x1857D2990")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000205B0 File Offset: 0x0001E7B0
		[Token(Token = "0x170006E5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxyz
		{
			[Token(Token = "0x600172A")]
			[Address(RVA = "0x57D29C0", Offset = "0x57D15C0", VA = "0x1857D29C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x000205C8 File Offset: 0x0001E7C8
		// (set) Token: 0x0600172C RID: 5932 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006E6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxyw
		{
			[Token(Token = "0x600172B")]
			[Address(RVA = "0x57D5B90", Offset = "0x57D4790", VA = "0x1857D5B90")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x600172C")]
			[Address(RVA = "0x57D66B0", Offset = "0x57D52B0", VA = "0x1857D66B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x000205E0 File Offset: 0x0001E7E0
		[Token(Token = "0x170006E7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxzx
		{
			[Token(Token = "0x600172D")]
			[Address(RVA = "0x57D2A10", Offset = "0x57D1610", VA = "0x1857D2A10")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x000205F8 File Offset: 0x0001E7F8
		[Token(Token = "0x170006E8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxzy
		{
			[Token(Token = "0x600172E")]
			[Address(RVA = "0x57D2A40", Offset = "0x57D1640", VA = "0x1857D2A40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x00020610 File Offset: 0x0001E810
		[Token(Token = "0x170006E9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxzz
		{
			[Token(Token = "0x600172F")]
			[Address(RVA = "0x57D2A70", Offset = "0x57D1670", VA = "0x1857D2A70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001730 RID: 5936 RVA: 0x00020628 File Offset: 0x0001E828
		[Token(Token = "0x170006EA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxzw
		{
			[Token(Token = "0x6001730")]
			[Address(RVA = "0x57D5BC0", Offset = "0x57D47C0", VA = "0x1857D5BC0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001731 RID: 5937 RVA: 0x00020640 File Offset: 0x0001E840
		[Token(Token = "0x170006EB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxwx
		{
			[Token(Token = "0x6001731")]
			[Address(RVA = "0x57D5AD0", Offset = "0x57D46D0", VA = "0x1857D5AD0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x00020658 File Offset: 0x0001E858
		// (set) Token: 0x06001733 RID: 5939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006EC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxwy
		{
			[Token(Token = "0x6001732")]
			[Address(RVA = "0x57D5B00", Offset = "0x57D4700", VA = "0x1857D5B00")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x6001733")]
			[Address(RVA = "0x57D6680", Offset = "0x57D5280", VA = "0x1857D6680")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00020670 File Offset: 0x0001E870
		[Token(Token = "0x170006ED")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxwz
		{
			[Token(Token = "0x6001734")]
			[Address(RVA = "0x57D5B30", Offset = "0x57D4730", VA = "0x1857D5B30")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001735 RID: 5941 RVA: 0x00020688 File Offset: 0x0001E888
		[Token(Token = "0x170006EE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zxww
		{
			[Token(Token = "0x6001735")]
			[Address(RVA = "0x57D5AA0", Offset = "0x57D46A0", VA = "0x1857D5AA0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x000206A0 File Offset: 0x0001E8A0
		[Token(Token = "0x170006EF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyxx
		{
			[Token(Token = "0x6001736")]
			[Address(RVA = "0x57D2AE0", Offset = "0x57D16E0", VA = "0x1857D2AE0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x000206B8 File Offset: 0x0001E8B8
		[Token(Token = "0x170006F0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyxy
		{
			[Token(Token = "0x6001737")]
			[Address(RVA = "0x57D2B10", Offset = "0x57D1710", VA = "0x1857D2B10")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x000206D0 File Offset: 0x0001E8D0
		[Token(Token = "0x170006F1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyxz
		{
			[Token(Token = "0x6001738")]
			[Address(RVA = "0x57D2B40", Offset = "0x57D1740", VA = "0x1857D2B40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x000206E8 File Offset: 0x0001E8E8
		// (set) Token: 0x0600173A RID: 5946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006F2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyxw
		{
			[Token(Token = "0x6001739")]
			[Address(RVA = "0x57D5CD0", Offset = "0x57D48D0", VA = "0x1857D5CD0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x600173A")]
			[Address(RVA = "0x57D6730", Offset = "0x57D5330", VA = "0x1857D6730")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00020700 File Offset: 0x0001E900
		[Token(Token = "0x170006F3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyyx
		{
			[Token(Token = "0x600173B")]
			[Address(RVA = "0x57D2B90", Offset = "0x57D1790", VA = "0x1857D2B90")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00020718 File Offset: 0x0001E918
		[Token(Token = "0x170006F4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyyy
		{
			[Token(Token = "0x600173C")]
			[Address(RVA = "0x57D2BC0", Offset = "0x57D17C0", VA = "0x1857D2BC0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x00020730 File Offset: 0x0001E930
		[Token(Token = "0x170006F5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyyz
		{
			[Token(Token = "0x600173D")]
			[Address(RVA = "0x57D2BF0", Offset = "0x57D17F0", VA = "0x1857D2BF0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x00020748 File Offset: 0x0001E948
		[Token(Token = "0x170006F6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyyw
		{
			[Token(Token = "0x600173E")]
			[Address(RVA = "0x57D5D00", Offset = "0x57D4900", VA = "0x1857D5D00")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600173F RID: 5951 RVA: 0x00020760 File Offset: 0x0001E960
		[Token(Token = "0x170006F7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyzx
		{
			[Token(Token = "0x600173F")]
			[Address(RVA = "0x57D2C40", Offset = "0x57D1840", VA = "0x1857D2C40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x00020778 File Offset: 0x0001E978
		[Token(Token = "0x170006F8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyzy
		{
			[Token(Token = "0x6001740")]
			[Address(RVA = "0x57D2C70", Offset = "0x57D1870", VA = "0x1857D2C70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x00020790 File Offset: 0x0001E990
		[Token(Token = "0x170006F9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyzz
		{
			[Token(Token = "0x6001741")]
			[Address(RVA = "0x57D2CA0", Offset = "0x57D18A0", VA = "0x1857D2CA0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x000207A8 File Offset: 0x0001E9A8
		[Token(Token = "0x170006FA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyzw
		{
			[Token(Token = "0x6001742")]
			[Address(RVA = "0x57D5D30", Offset = "0x57D4930", VA = "0x1857D5D30")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x000207C0 File Offset: 0x0001E9C0
		// (set) Token: 0x06001744 RID: 5956 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006FB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zywx
		{
			[Token(Token = "0x6001743")]
			[Address(RVA = "0x57D5C40", Offset = "0x57D4840", VA = "0x1857D5C40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x6001744")]
			[Address(RVA = "0x57D6700", Offset = "0x57D5300", VA = "0x1857D6700")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x000207D8 File Offset: 0x0001E9D8
		[Token(Token = "0x170006FC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zywy
		{
			[Token(Token = "0x6001745")]
			[Address(RVA = "0x57D5C70", Offset = "0x57D4870", VA = "0x1857D5C70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x000207F0 File Offset: 0x0001E9F0
		[Token(Token = "0x170006FD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zywz
		{
			[Token(Token = "0x6001746")]
			[Address(RVA = "0x57D5CA0", Offset = "0x57D48A0", VA = "0x1857D5CA0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001747 RID: 5959 RVA: 0x00020808 File Offset: 0x0001EA08
		[Token(Token = "0x170006FE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zyww
		{
			[Token(Token = "0x6001747")]
			[Address(RVA = "0x57D5C10", Offset = "0x57D4810", VA = "0x1857D5C10")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x00020820 File Offset: 0x0001EA20
		[Token(Token = "0x170006FF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzxx
		{
			[Token(Token = "0x6001748")]
			[Address(RVA = "0x57D2D10", Offset = "0x57D1910", VA = "0x1857D2D10")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001749 RID: 5961 RVA: 0x00020838 File Offset: 0x0001EA38
		[Token(Token = "0x17000700")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzxy
		{
			[Token(Token = "0x6001749")]
			[Address(RVA = "0x57D2D40", Offset = "0x57D1940", VA = "0x1857D2D40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x00020850 File Offset: 0x0001EA50
		[Token(Token = "0x17000701")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzxz
		{
			[Token(Token = "0x600174A")]
			[Address(RVA = "0x57D2D70", Offset = "0x57D1970", VA = "0x1857D2D70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x00020868 File Offset: 0x0001EA68
		[Token(Token = "0x17000702")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzxw
		{
			[Token(Token = "0x600174B")]
			[Address(RVA = "0x57D5E40", Offset = "0x57D4A40", VA = "0x1857D5E40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x00020880 File Offset: 0x0001EA80
		[Token(Token = "0x17000703")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzyx
		{
			[Token(Token = "0x600174C")]
			[Address(RVA = "0x57D2DC0", Offset = "0x57D19C0", VA = "0x1857D2DC0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600174D RID: 5965 RVA: 0x00020898 File Offset: 0x0001EA98
		[Token(Token = "0x17000704")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzyy
		{
			[Token(Token = "0x600174D")]
			[Address(RVA = "0x57D2DF0", Offset = "0x57D19F0", VA = "0x1857D2DF0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600174E RID: 5966 RVA: 0x000208B0 File Offset: 0x0001EAB0
		[Token(Token = "0x17000705")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzyz
		{
			[Token(Token = "0x600174E")]
			[Address(RVA = "0x57D2E20", Offset = "0x57D1A20", VA = "0x1857D2E20")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x000208C8 File Offset: 0x0001EAC8
		[Token(Token = "0x17000706")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzyw
		{
			[Token(Token = "0x600174F")]
			[Address(RVA = "0x57D5E70", Offset = "0x57D4A70", VA = "0x1857D5E70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x000208E0 File Offset: 0x0001EAE0
		[Token(Token = "0x17000707")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzzx
		{
			[Token(Token = "0x6001750")]
			[Address(RVA = "0x57D2E70", Offset = "0x57D1A70", VA = "0x1857D2E70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001751 RID: 5969 RVA: 0x000208F8 File Offset: 0x0001EAF8
		[Token(Token = "0x17000708")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzzy
		{
			[Token(Token = "0x6001751")]
			[Address(RVA = "0x57D2EA0", Offset = "0x57D1AA0", VA = "0x1857D2EA0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x00020910 File Offset: 0x0001EB10
		[Token(Token = "0x17000709")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzzz
		{
			[Token(Token = "0x6001752")]
			[Address(RVA = "0x57D2ED0", Offset = "0x57D1AD0", VA = "0x1857D2ED0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001753 RID: 5971 RVA: 0x00020928 File Offset: 0x0001EB28
		[Token(Token = "0x1700070A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzzw
		{
			[Token(Token = "0x6001753")]
			[Address(RVA = "0x57D5EA0", Offset = "0x57D4AA0", VA = "0x1857D5EA0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001754 RID: 5972 RVA: 0x00020940 File Offset: 0x0001EB40
		[Token(Token = "0x1700070B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzwx
		{
			[Token(Token = "0x6001754")]
			[Address(RVA = "0x57D5DB0", Offset = "0x57D49B0", VA = "0x1857D5DB0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001755 RID: 5973 RVA: 0x00020958 File Offset: 0x0001EB58
		[Token(Token = "0x1700070C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzwy
		{
			[Token(Token = "0x6001755")]
			[Address(RVA = "0x57D5DE0", Offset = "0x57D49E0", VA = "0x1857D5DE0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001756 RID: 5974 RVA: 0x00020970 File Offset: 0x0001EB70
		[Token(Token = "0x1700070D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzwz
		{
			[Token(Token = "0x6001756")]
			[Address(RVA = "0x57D5E10", Offset = "0x57D4A10", VA = "0x1857D5E10")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001757 RID: 5975 RVA: 0x00020988 File Offset: 0x0001EB88
		[Token(Token = "0x1700070E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zzww
		{
			[Token(Token = "0x6001757")]
			[Address(RVA = "0x57D5D80", Offset = "0x57D4980", VA = "0x1857D5D80")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001758 RID: 5976 RVA: 0x000209A0 File Offset: 0x0001EBA0
		[Token(Token = "0x1700070F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwxx
		{
			[Token(Token = "0x6001758")]
			[Address(RVA = "0x57D5830", Offset = "0x57D4430", VA = "0x1857D5830")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x000209B8 File Offset: 0x0001EBB8
		// (set) Token: 0x0600175A RID: 5978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000710")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwxy
		{
			[Token(Token = "0x6001759")]
			[Address(RVA = "0x57D5860", Offset = "0x57D4460", VA = "0x1857D5860")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x600175A")]
			[Address(RVA = "0x57D65E0", Offset = "0x57D51E0", VA = "0x1857D65E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600175B RID: 5979 RVA: 0x000209D0 File Offset: 0x0001EBD0
		[Token(Token = "0x17000711")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwxz
		{
			[Token(Token = "0x600175B")]
			[Address(RVA = "0x57D5890", Offset = "0x57D4490", VA = "0x1857D5890")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600175C RID: 5980 RVA: 0x000209E8 File Offset: 0x0001EBE8
		[Token(Token = "0x17000712")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwxw
		{
			[Token(Token = "0x600175C")]
			[Address(RVA = "0x57D5800", Offset = "0x57D4400", VA = "0x1857D5800")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600175D RID: 5981 RVA: 0x00020A00 File Offset: 0x0001EC00
		// (set) Token: 0x0600175E RID: 5982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000713")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwyx
		{
			[Token(Token = "0x600175D")]
			[Address(RVA = "0x57D5910", Offset = "0x57D4510", VA = "0x1857D5910")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x600175E")]
			[Address(RVA = "0x57D6630", Offset = "0x57D5230", VA = "0x1857D6630")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x0600175F RID: 5983 RVA: 0x00020A18 File Offset: 0x0001EC18
		[Token(Token = "0x17000714")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwyy
		{
			[Token(Token = "0x600175F")]
			[Address(RVA = "0x57D5940", Offset = "0x57D4540", VA = "0x1857D5940")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x00020A30 File Offset: 0x0001EC30
		[Token(Token = "0x17000715")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwyz
		{
			[Token(Token = "0x6001760")]
			[Address(RVA = "0x57D5970", Offset = "0x57D4570", VA = "0x1857D5970")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x00020A48 File Offset: 0x0001EC48
		[Token(Token = "0x17000716")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwyw
		{
			[Token(Token = "0x6001761")]
			[Address(RVA = "0x57D58E0", Offset = "0x57D44E0", VA = "0x1857D58E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x00020A60 File Offset: 0x0001EC60
		[Token(Token = "0x17000717")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwzx
		{
			[Token(Token = "0x6001762")]
			[Address(RVA = "0x57D59F0", Offset = "0x57D45F0", VA = "0x1857D59F0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001763 RID: 5987 RVA: 0x00020A78 File Offset: 0x0001EC78
		[Token(Token = "0x17000718")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwzy
		{
			[Token(Token = "0x6001763")]
			[Address(RVA = "0x57D5A20", Offset = "0x57D4620", VA = "0x1857D5A20")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001764 RID: 5988 RVA: 0x00020A90 File Offset: 0x0001EC90
		[Token(Token = "0x17000719")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwzz
		{
			[Token(Token = "0x6001764")]
			[Address(RVA = "0x57D5A50", Offset = "0x57D4650", VA = "0x1857D5A50")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x00020AA8 File Offset: 0x0001ECA8
		[Token(Token = "0x1700071A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwzw
		{
			[Token(Token = "0x6001765")]
			[Address(RVA = "0x57D59C0", Offset = "0x57D45C0", VA = "0x1857D59C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001766 RID: 5990 RVA: 0x00020AC0 File Offset: 0x0001ECC0
		[Token(Token = "0x1700071B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwwx
		{
			[Token(Token = "0x6001766")]
			[Address(RVA = "0x57D5750", Offset = "0x57D4350", VA = "0x1857D5750")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x00020AD8 File Offset: 0x0001ECD8
		[Token(Token = "0x1700071C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwwy
		{
			[Token(Token = "0x6001767")]
			[Address(RVA = "0x57D5780", Offset = "0x57D4380", VA = "0x1857D5780")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x00020AF0 File Offset: 0x0001ECF0
		[Token(Token = "0x1700071D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwwz
		{
			[Token(Token = "0x6001768")]
			[Address(RVA = "0x57D57B0", Offset = "0x57D43B0", VA = "0x1857D57B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00020B08 File Offset: 0x0001ED08
		[Token(Token = "0x1700071E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 zwww
		{
			[Token(Token = "0x6001769")]
			[Address(RVA = "0x57D5720", Offset = "0x57D4320", VA = "0x1857D5720")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600176A RID: 5994 RVA: 0x00020B20 File Offset: 0x0001ED20
		[Token(Token = "0x1700071F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxxx
		{
			[Token(Token = "0x600176A")]
			[Address(RVA = "0x57D3D70", Offset = "0x57D2970", VA = "0x1857D3D70")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x00020B38 File Offset: 0x0001ED38
		[Token(Token = "0x17000720")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxxy
		{
			[Token(Token = "0x600176B")]
			[Address(RVA = "0x57D3DA0", Offset = "0x57D29A0", VA = "0x1857D3DA0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600176C RID: 5996 RVA: 0x00020B50 File Offset: 0x0001ED50
		[Token(Token = "0x17000721")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxxz
		{
			[Token(Token = "0x600176C")]
			[Address(RVA = "0x57D3DD0", Offset = "0x57D29D0", VA = "0x1857D3DD0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x00020B68 File Offset: 0x0001ED68
		[Token(Token = "0x17000722")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxxw
		{
			[Token(Token = "0x600176D")]
			[Address(RVA = "0x57D3D40", Offset = "0x57D2940", VA = "0x1857D3D40")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x00020B80 File Offset: 0x0001ED80
		[Token(Token = "0x17000723")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxyx
		{
			[Token(Token = "0x600176E")]
			[Address(RVA = "0x57D3E50", Offset = "0x57D2A50", VA = "0x1857D3E50")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600176F RID: 5999 RVA: 0x00020B98 File Offset: 0x0001ED98
		[Token(Token = "0x17000724")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxyy
		{
			[Token(Token = "0x600176F")]
			[Address(RVA = "0x57D3E80", Offset = "0x57D2A80", VA = "0x1857D3E80")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x00020BB0 File Offset: 0x0001EDB0
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000725")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxyz
		{
			[Token(Token = "0x6001770")]
			[Address(RVA = "0x57D3EB0", Offset = "0x57D2AB0", VA = "0x1857D3EB0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x6001771")]
			[Address(RVA = "0x57D60A0", Offset = "0x57D4CA0", VA = "0x1857D60A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x00020BC8 File Offset: 0x0001EDC8
		[Token(Token = "0x17000726")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxyw
		{
			[Token(Token = "0x6001772")]
			[Address(RVA = "0x57D3E20", Offset = "0x57D2A20", VA = "0x1857D3E20")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001773 RID: 6003 RVA: 0x00020BE0 File Offset: 0x0001EDE0
		[Token(Token = "0x17000727")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxzx
		{
			[Token(Token = "0x6001773")]
			[Address(RVA = "0x57D3F30", Offset = "0x57D2B30", VA = "0x1857D3F30")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x00020BF8 File Offset: 0x0001EDF8
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000728")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxzy
		{
			[Token(Token = "0x6001774")]
			[Address(RVA = "0x57D3F60", Offset = "0x57D2B60", VA = "0x1857D3F60")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x6001775")]
			[Address(RVA = "0x57D60F0", Offset = "0x57D4CF0", VA = "0x1857D60F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001776 RID: 6006 RVA: 0x00020C10 File Offset: 0x0001EE10
		[Token(Token = "0x17000729")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxzz
		{
			[Token(Token = "0x6001776")]
			[Address(RVA = "0x57D3F90", Offset = "0x57D2B90", VA = "0x1857D3F90")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x00020C28 File Offset: 0x0001EE28
		[Token(Token = "0x1700072A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxzw
		{
			[Token(Token = "0x6001777")]
			[Address(RVA = "0x57D3F00", Offset = "0x57D2B00", VA = "0x1857D3F00")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x06001778 RID: 6008 RVA: 0x00020C40 File Offset: 0x0001EE40
		[Token(Token = "0x1700072B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxwx
		{
			[Token(Token = "0x6001778")]
			[Address(RVA = "0x57D3C90", Offset = "0x57D2890", VA = "0x1857D3C90")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x00020C58 File Offset: 0x0001EE58
		[Token(Token = "0x1700072C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxwy
		{
			[Token(Token = "0x6001779")]
			[Address(RVA = "0x57D3CC0", Offset = "0x57D28C0", VA = "0x1857D3CC0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x0600177A RID: 6010 RVA: 0x00020C70 File Offset: 0x0001EE70
		[Token(Token = "0x1700072D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxwz
		{
			[Token(Token = "0x600177A")]
			[Address(RVA = "0x57D3CF0", Offset = "0x57D28F0", VA = "0x1857D3CF0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x00020C88 File Offset: 0x0001EE88
		[Token(Token = "0x1700072E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wxww
		{
			[Token(Token = "0x600177B")]
			[Address(RVA = "0x57D3C60", Offset = "0x57D2860", VA = "0x1857D3C60")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x0600177C RID: 6012 RVA: 0x00020CA0 File Offset: 0x0001EEA0
		[Token(Token = "0x1700072F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyxx
		{
			[Token(Token = "0x600177C")]
			[Address(RVA = "0x57D4110", Offset = "0x57D2D10", VA = "0x1857D4110")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x00020CB8 File Offset: 0x0001EEB8
		[Token(Token = "0x17000730")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyxy
		{
			[Token(Token = "0x600177D")]
			[Address(RVA = "0x57D4140", Offset = "0x57D2D40", VA = "0x1857D4140")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x00020CD0 File Offset: 0x0001EED0
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000731")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyxz
		{
			[Token(Token = "0x600177E")]
			[Address(RVA = "0x57D4170", Offset = "0x57D2D70", VA = "0x1857D4170")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x600177F")]
			[Address(RVA = "0x57D6150", Offset = "0x57D4D50", VA = "0x1857D6150")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x00020CE8 File Offset: 0x0001EEE8
		[Token(Token = "0x17000732")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyxw
		{
			[Token(Token = "0x6001780")]
			[Address(RVA = "0x57D40E0", Offset = "0x57D2CE0", VA = "0x1857D40E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x06001781 RID: 6017 RVA: 0x00020D00 File Offset: 0x0001EF00
		[Token(Token = "0x17000733")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyyx
		{
			[Token(Token = "0x6001781")]
			[Address(RVA = "0x57D41F0", Offset = "0x57D2DF0", VA = "0x1857D41F0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001782 RID: 6018 RVA: 0x00020D18 File Offset: 0x0001EF18
		[Token(Token = "0x17000734")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyyy
		{
			[Token(Token = "0x6001782")]
			[Address(RVA = "0x57D4220", Offset = "0x57D2E20", VA = "0x1857D4220")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x06001783 RID: 6019 RVA: 0x00020D30 File Offset: 0x0001EF30
		[Token(Token = "0x17000735")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyyz
		{
			[Token(Token = "0x6001783")]
			[Address(RVA = "0x57D4250", Offset = "0x57D2E50", VA = "0x1857D4250")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x06001784 RID: 6020 RVA: 0x00020D48 File Offset: 0x0001EF48
		[Token(Token = "0x17000736")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyyw
		{
			[Token(Token = "0x6001784")]
			[Address(RVA = "0x57D41C0", Offset = "0x57D2DC0", VA = "0x1857D41C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x00020D60 File Offset: 0x0001EF60
		// (set) Token: 0x06001786 RID: 6022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000737")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyzx
		{
			[Token(Token = "0x6001785")]
			[Address(RVA = "0x57D42D0", Offset = "0x57D2ED0", VA = "0x1857D42D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x6001786")]
			[Address(RVA = "0x57D61A0", Offset = "0x57D4DA0", VA = "0x1857D61A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x00020D78 File Offset: 0x0001EF78
		[Token(Token = "0x17000738")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyzy
		{
			[Token(Token = "0x6001787")]
			[Address(RVA = "0x57D4300", Offset = "0x57D2F00", VA = "0x1857D4300")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001788 RID: 6024 RVA: 0x00020D90 File Offset: 0x0001EF90
		[Token(Token = "0x17000739")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyzz
		{
			[Token(Token = "0x6001788")]
			[Address(RVA = "0x57D4330", Offset = "0x57D2F30", VA = "0x1857D4330")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x06001789 RID: 6025 RVA: 0x00020DA8 File Offset: 0x0001EFA8
		[Token(Token = "0x1700073A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyzw
		{
			[Token(Token = "0x6001789")]
			[Address(RVA = "0x57D42A0", Offset = "0x57D2EA0", VA = "0x1857D42A0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x0600178A RID: 6026 RVA: 0x00020DC0 File Offset: 0x0001EFC0
		[Token(Token = "0x1700073B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wywx
		{
			[Token(Token = "0x600178A")]
			[Address(RVA = "0x57D4030", Offset = "0x57D2C30", VA = "0x1857D4030")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x00020DD8 File Offset: 0x0001EFD8
		[Token(Token = "0x1700073C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wywy
		{
			[Token(Token = "0x600178B")]
			[Address(RVA = "0x57D4060", Offset = "0x57D2C60", VA = "0x1857D4060")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600178C RID: 6028 RVA: 0x00020DF0 File Offset: 0x0001EFF0
		[Token(Token = "0x1700073D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wywz
		{
			[Token(Token = "0x600178C")]
			[Address(RVA = "0x57D4090", Offset = "0x57D2C90", VA = "0x1857D4090")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x0600178D RID: 6029 RVA: 0x00020E08 File Offset: 0x0001F008
		[Token(Token = "0x1700073E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wyww
		{
			[Token(Token = "0x600178D")]
			[Address(RVA = "0x57D4000", Offset = "0x57D2C00", VA = "0x1857D4000")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00020E20 File Offset: 0x0001F020
		[Token(Token = "0x1700073F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzxx
		{
			[Token(Token = "0x600178E")]
			[Address(RVA = "0x57D44B0", Offset = "0x57D30B0", VA = "0x1857D44B0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x00020E38 File Offset: 0x0001F038
		// (set) Token: 0x06001790 RID: 6032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000740")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzxy
		{
			[Token(Token = "0x600178F")]
			[Address(RVA = "0x57D44E0", Offset = "0x57D30E0", VA = "0x1857D44E0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x6001790")]
			[Address(RVA = "0x57D6200", Offset = "0x57D4E00", VA = "0x1857D6200")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001791 RID: 6033 RVA: 0x00020E50 File Offset: 0x0001F050
		[Token(Token = "0x17000741")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzxz
		{
			[Token(Token = "0x6001791")]
			[Address(RVA = "0x57D4510", Offset = "0x57D3110", VA = "0x1857D4510")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x00020E68 File Offset: 0x0001F068
		[Token(Token = "0x17000742")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzxw
		{
			[Token(Token = "0x6001792")]
			[Address(RVA = "0x57D4480", Offset = "0x57D3080", VA = "0x1857D4480")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x00020E80 File Offset: 0x0001F080
		// (set) Token: 0x06001794 RID: 6036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000743")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzyx
		{
			[Token(Token = "0x6001793")]
			[Address(RVA = "0x57D4590", Offset = "0x57D3190", VA = "0x1857D4590")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
			[Token(Token = "0x6001794")]
			[Address(RVA = "0x57D6250", Offset = "0x57D4E50", VA = "0x1857D6250")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x00020E98 File Offset: 0x0001F098
		[Token(Token = "0x17000744")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzyy
		{
			[Token(Token = "0x6001795")]
			[Address(RVA = "0x57D45C0", Offset = "0x57D31C0", VA = "0x1857D45C0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x00020EB0 File Offset: 0x0001F0B0
		[Token(Token = "0x17000745")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzyz
		{
			[Token(Token = "0x6001796")]
			[Address(RVA = "0x57D45F0", Offset = "0x57D31F0", VA = "0x1857D45F0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x00020EC8 File Offset: 0x0001F0C8
		[Token(Token = "0x17000746")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzyw
		{
			[Token(Token = "0x6001797")]
			[Address(RVA = "0x57D4560", Offset = "0x57D3160", VA = "0x1857D4560")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x00020EE0 File Offset: 0x0001F0E0
		[Token(Token = "0x17000747")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzzx
		{
			[Token(Token = "0x6001798")]
			[Address(RVA = "0x57D4670", Offset = "0x57D3270", VA = "0x1857D4670")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001799 RID: 6041 RVA: 0x00020EF8 File Offset: 0x0001F0F8
		[Token(Token = "0x17000748")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzzy
		{
			[Token(Token = "0x6001799")]
			[Address(RVA = "0x57D46A0", Offset = "0x57D32A0", VA = "0x1857D46A0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x00020F10 File Offset: 0x0001F110
		[Token(Token = "0x17000749")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzzz
		{
			[Token(Token = "0x600179A")]
			[Address(RVA = "0x57D46D0", Offset = "0x57D32D0", VA = "0x1857D46D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600179B RID: 6043 RVA: 0x00020F28 File Offset: 0x0001F128
		[Token(Token = "0x1700074A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzzw
		{
			[Token(Token = "0x600179B")]
			[Address(RVA = "0x57D4640", Offset = "0x57D3240", VA = "0x1857D4640")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00020F40 File Offset: 0x0001F140
		[Token(Token = "0x1700074B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzwx
		{
			[Token(Token = "0x600179C")]
			[Address(RVA = "0x57D43D0", Offset = "0x57D2FD0", VA = "0x1857D43D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x0600179D RID: 6045 RVA: 0x00020F58 File Offset: 0x0001F158
		[Token(Token = "0x1700074C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzwy
		{
			[Token(Token = "0x600179D")]
			[Address(RVA = "0x57D4400", Offset = "0x57D3000", VA = "0x1857D4400")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00020F70 File Offset: 0x0001F170
		[Token(Token = "0x1700074D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzwz
		{
			[Token(Token = "0x600179E")]
			[Address(RVA = "0x57D4430", Offset = "0x57D3030", VA = "0x1857D4430")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700074E RID: 1870
		// (get) Token: 0x0600179F RID: 6047 RVA: 0x00020F88 File Offset: 0x0001F188
		[Token(Token = "0x1700074E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wzww
		{
			[Token(Token = "0x600179F")]
			[Address(RVA = "0x57D43A0", Offset = "0x57D2FA0", VA = "0x1857D43A0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700074F RID: 1871
		// (get) Token: 0x060017A0 RID: 6048 RVA: 0x00020FA0 File Offset: 0x0001F1A0
		[Token(Token = "0x1700074F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwxx
		{
			[Token(Token = "0x60017A0")]
			[Address(RVA = "0x57D39D0", Offset = "0x57D25D0", VA = "0x1857D39D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000750 RID: 1872
		// (get) Token: 0x060017A1 RID: 6049 RVA: 0x00020FB8 File Offset: 0x0001F1B8
		[Token(Token = "0x17000750")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwxy
		{
			[Token(Token = "0x60017A1")]
			[Address(RVA = "0x57D3A00", Offset = "0x57D2600", VA = "0x1857D3A00")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000751 RID: 1873
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00020FD0 File Offset: 0x0001F1D0
		[Token(Token = "0x17000751")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwxz
		{
			[Token(Token = "0x60017A2")]
			[Address(RVA = "0x57D3A30", Offset = "0x57D2630", VA = "0x1857D3A30")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x060017A3 RID: 6051 RVA: 0x00020FE8 File Offset: 0x0001F1E8
		[Token(Token = "0x17000752")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwxw
		{
			[Token(Token = "0x60017A3")]
			[Address(RVA = "0x57D39A0", Offset = "0x57D25A0", VA = "0x1857D39A0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000753 RID: 1875
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00021000 File Offset: 0x0001F200
		[Token(Token = "0x17000753")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwyx
		{
			[Token(Token = "0x60017A4")]
			[Address(RVA = "0x57D3AB0", Offset = "0x57D26B0", VA = "0x1857D3AB0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x00021018 File Offset: 0x0001F218
		[Token(Token = "0x17000754")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwyy
		{
			[Token(Token = "0x60017A5")]
			[Address(RVA = "0x57D3AE0", Offset = "0x57D26E0", VA = "0x1857D3AE0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x00021030 File Offset: 0x0001F230
		[Token(Token = "0x17000755")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwyz
		{
			[Token(Token = "0x60017A6")]
			[Address(RVA = "0x57D3B10", Offset = "0x57D2710", VA = "0x1857D3B10")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060017A7 RID: 6055 RVA: 0x00021048 File Offset: 0x0001F248
		[Token(Token = "0x17000756")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwyw
		{
			[Token(Token = "0x60017A7")]
			[Address(RVA = "0x57D3A80", Offset = "0x57D2680", VA = "0x1857D3A80")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x060017A8 RID: 6056 RVA: 0x00021060 File Offset: 0x0001F260
		[Token(Token = "0x17000757")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwzx
		{
			[Token(Token = "0x60017A8")]
			[Address(RVA = "0x57D3B90", Offset = "0x57D2790", VA = "0x1857D3B90")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000758 RID: 1880
		// (get) Token: 0x060017A9 RID: 6057 RVA: 0x00021078 File Offset: 0x0001F278
		[Token(Token = "0x17000758")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwzy
		{
			[Token(Token = "0x60017A9")]
			[Address(RVA = "0x57D3BC0", Offset = "0x57D27C0", VA = "0x1857D3BC0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x060017AA RID: 6058 RVA: 0x00021090 File Offset: 0x0001F290
		[Token(Token = "0x17000759")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwzz
		{
			[Token(Token = "0x60017AA")]
			[Address(RVA = "0x57D3BF0", Offset = "0x57D27F0", VA = "0x1857D3BF0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060017AB RID: 6059 RVA: 0x000210A8 File Offset: 0x0001F2A8
		[Token(Token = "0x1700075A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwzw
		{
			[Token(Token = "0x60017AB")]
			[Address(RVA = "0x57D3B60", Offset = "0x57D2760", VA = "0x1857D3B60")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060017AC RID: 6060 RVA: 0x000210C0 File Offset: 0x0001F2C0
		[Token(Token = "0x1700075B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwwx
		{
			[Token(Token = "0x60017AC")]
			[Address(RVA = "0x57D38F0", Offset = "0x57D24F0", VA = "0x1857D38F0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060017AD RID: 6061 RVA: 0x000210D8 File Offset: 0x0001F2D8
		[Token(Token = "0x1700075C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwwy
		{
			[Token(Token = "0x60017AD")]
			[Address(RVA = "0x57D3920", Offset = "0x57D2520", VA = "0x1857D3920")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x000210F0 File Offset: 0x0001F2F0
		[Token(Token = "0x1700075D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwwz
		{
			[Token(Token = "0x60017AE")]
			[Address(RVA = "0x57D3950", Offset = "0x57D2550", VA = "0x1857D3950")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060017AF RID: 6063 RVA: 0x00021108 File Offset: 0x0001F308
		[Token(Token = "0x1700075E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half4 wwww
		{
			[Token(Token = "0x60017AF")]
			[Address(RVA = "0x57D38D0", Offset = "0x57D24D0", VA = "0x1857D38D0")]
			[MethodImpl(256)]
			get
			{
				return default(half4);
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060017B0 RID: 6064 RVA: 0x00021120 File Offset: 0x0001F320
		[Token(Token = "0x1700075F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xxx
		{
			[Token(Token = "0x60017B0")]
			[Address(RVA = "0x57D1650", Offset = "0x57D0250", VA = "0x1857D1650")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060017B1 RID: 6065 RVA: 0x00021138 File Offset: 0x0001F338
		[Token(Token = "0x17000760")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xxy
		{
			[Token(Token = "0x60017B1")]
			[Address(RVA = "0x57D16C0", Offset = "0x57D02C0", VA = "0x1857D16C0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x00021150 File Offset: 0x0001F350
		[Token(Token = "0x17000761")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xxz
		{
			[Token(Token = "0x60017B2")]
			[Address(RVA = "0x57D2030", Offset = "0x57D0C30", VA = "0x1857D2030")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x060017B3 RID: 6067 RVA: 0x00021168 File Offset: 0x0001F368
		[Token(Token = "0x17000762")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xxw
		{
			[Token(Token = "0x60017B3")]
			[Address(RVA = "0x57D4AA0", Offset = "0x57D36A0", VA = "0x1857D4AA0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x00021180 File Offset: 0x0001F380
		[Token(Token = "0x17000763")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xyx
		{
			[Token(Token = "0x60017B4")]
			[Address(RVA = "0x57D1760", Offset = "0x57D0360", VA = "0x1857D1760")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00021198 File Offset: 0x0001F398
		[Token(Token = "0x17000764")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xyy
		{
			[Token(Token = "0x60017B5")]
			[Address(RVA = "0x57D17E0", Offset = "0x57D03E0", VA = "0x1857D17E0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x060017B6 RID: 6070 RVA: 0x000211B0 File Offset: 0x0001F3B0
		// (set) Token: 0x060017B7 RID: 6071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000765")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xyz
		{
			[Token(Token = "0x60017B6")]
			[Address(RVA = "0x57D2140", Offset = "0x57D0D40", VA = "0x1857D2140")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017B7")]
			[Address(RVA = "0x57D1F50", Offset = "0x57D0B50", VA = "0x1857D1F50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x060017B8 RID: 6072 RVA: 0x000211C8 File Offset: 0x0001F3C8
		// (set) Token: 0x060017B9 RID: 6073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000766")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xyw
		{
			[Token(Token = "0x60017B8")]
			[Address(RVA = "0x57D4C10", Offset = "0x57D3810", VA = "0x1857D4C10")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017B9")]
			[Address(RVA = "0x57D6330", Offset = "0x57D4F30", VA = "0x1857D6330")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x000211E0 File Offset: 0x0001F3E0
		[Token(Token = "0x17000767")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xzx
		{
			[Token(Token = "0x60017BA")]
			[Address(RVA = "0x57D2210", Offset = "0x57D0E10", VA = "0x1857D2210")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x000211F8 File Offset: 0x0001F3F8
		// (set) Token: 0x060017BC RID: 6076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000768")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xzy
		{
			[Token(Token = "0x60017BB")]
			[Address(RVA = "0x57D22C0", Offset = "0x57D0EC0", VA = "0x1857D22C0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017BC")]
			[Address(RVA = "0x57D3020", Offset = "0x57D1C20", VA = "0x1857D3020")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x00021210 File Offset: 0x0001F410
		[Token(Token = "0x17000769")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xzz
		{
			[Token(Token = "0x60017BD")]
			[Address(RVA = "0x57D2370", Offset = "0x57D0F70", VA = "0x1857D2370")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x00021228 File Offset: 0x0001F428
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700076A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xzw
		{
			[Token(Token = "0x60017BE")]
			[Address(RVA = "0x57D4D80", Offset = "0x57D3980", VA = "0x1857D4D80")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017BF")]
			[Address(RVA = "0x57D6380", Offset = "0x57D4F80", VA = "0x1857D6380")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00021240 File Offset: 0x0001F440
		[Token(Token = "0x1700076B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xwx
		{
			[Token(Token = "0x60017C0")]
			[Address(RVA = "0x57D4800", Offset = "0x57D3400", VA = "0x1857D4800")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x00021258 File Offset: 0x0001F458
		// (set) Token: 0x060017C2 RID: 6082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700076C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xwy
		{
			[Token(Token = "0x60017C1")]
			[Address(RVA = "0x57D48E0", Offset = "0x57D34E0", VA = "0x1857D48E0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017C2")]
			[Address(RVA = "0x57D6290", Offset = "0x57D4E90", VA = "0x1857D6290")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060017C3 RID: 6083 RVA: 0x00021270 File Offset: 0x0001F470
		// (set) Token: 0x060017C4 RID: 6084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700076D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xwz
		{
			[Token(Token = "0x60017C3")]
			[Address(RVA = "0x57D49C0", Offset = "0x57D35C0", VA = "0x1857D49C0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017C4")]
			[Address(RVA = "0x57D62E0", Offset = "0x57D4EE0", VA = "0x1857D62E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x060017C5 RID: 6085 RVA: 0x00021288 File Offset: 0x0001F488
		[Token(Token = "0x1700076E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 xww
		{
			[Token(Token = "0x60017C5")]
			[Address(RVA = "0x57D4720", Offset = "0x57D3320", VA = "0x1857D4720")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x000212A0 File Offset: 0x0001F4A0
		[Token(Token = "0x1700076F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yxx
		{
			[Token(Token = "0x60017C6")]
			[Address(RVA = "0x57D1880", Offset = "0x57D0480", VA = "0x1857D1880")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x060017C7 RID: 6087 RVA: 0x000212B8 File Offset: 0x0001F4B8
		[Token(Token = "0x17000770")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yxy
		{
			[Token(Token = "0x60017C7")]
			[Address(RVA = "0x57D1900", Offset = "0x57D0500", VA = "0x1857D1900")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x000212D0 File Offset: 0x0001F4D0
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000771")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yxz
		{
			[Token(Token = "0x60017C8")]
			[Address(RVA = "0x57D2480", Offset = "0x57D1080", VA = "0x1857D2480")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017C9")]
			[Address(RVA = "0x57D3040", Offset = "0x57D1C40", VA = "0x1857D3040")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x000212E8 File Offset: 0x0001F4E8
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000772")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yxw
		{
			[Token(Token = "0x60017CA")]
			[Address(RVA = "0x57D5290", Offset = "0x57D3E90", VA = "0x1857D5290")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017CB")]
			[Address(RVA = "0x57D64B0", Offset = "0x57D50B0", VA = "0x1857D64B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x00021300 File Offset: 0x0001F500
		[Token(Token = "0x17000773")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yyx
		{
			[Token(Token = "0x60017CC")]
			[Address(RVA = "0x57D19A0", Offset = "0x57D05A0", VA = "0x1857D19A0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060017CD RID: 6093 RVA: 0x00021318 File Offset: 0x0001F518
		[Token(Token = "0x17000774")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yyy
		{
			[Token(Token = "0x60017CD")]
			[Address(RVA = "0x57D1A20", Offset = "0x57D0620", VA = "0x1857D1A20")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x00021330 File Offset: 0x0001F530
		[Token(Token = "0x17000775")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yyz
		{
			[Token(Token = "0x60017CE")]
			[Address(RVA = "0x57D2590", Offset = "0x57D1190", VA = "0x1857D2590")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x00021348 File Offset: 0x0001F548
		[Token(Token = "0x17000776")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yyw
		{
			[Token(Token = "0x60017CF")]
			[Address(RVA = "0x57D5400", Offset = "0x57D4000", VA = "0x1857D5400")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00021360 File Offset: 0x0001F560
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000777")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yzx
		{
			[Token(Token = "0x60017D0")]
			[Address(RVA = "0x57D2660", Offset = "0x57D1260", VA = "0x1857D2660")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017D1")]
			[Address(RVA = "0x57D3070", Offset = "0x57D1C70", VA = "0x1857D3070")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x00021378 File Offset: 0x0001F578
		[Token(Token = "0x17000778")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yzy
		{
			[Token(Token = "0x60017D2")]
			[Address(RVA = "0x57D2710", Offset = "0x57D1310", VA = "0x1857D2710")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060017D3 RID: 6099 RVA: 0x00021390 File Offset: 0x0001F590
		[Token(Token = "0x17000779")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yzz
		{
			[Token(Token = "0x60017D3")]
			[Address(RVA = "0x57D27C0", Offset = "0x57D13C0", VA = "0x1857D27C0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060017D4 RID: 6100 RVA: 0x000213A8 File Offset: 0x0001F5A8
		// (set) Token: 0x060017D5 RID: 6101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yzw
		{
			[Token(Token = "0x60017D4")]
			[Address(RVA = "0x57D5570", Offset = "0x57D4170", VA = "0x1857D5570")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017D5")]
			[Address(RVA = "0x57D6530", Offset = "0x57D5130", VA = "0x1857D6530")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x000213C0 File Offset: 0x0001F5C0
		// (set) Token: 0x060017D7 RID: 6103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 ywx
		{
			[Token(Token = "0x60017D6")]
			[Address(RVA = "0x57D4FF0", Offset = "0x57D3BF0", VA = "0x1857D4FF0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017D7")]
			[Address(RVA = "0x57D6410", Offset = "0x57D5010", VA = "0x1857D6410")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x000213D8 File Offset: 0x0001F5D8
		[Token(Token = "0x1700077C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 ywy
		{
			[Token(Token = "0x60017D8")]
			[Address(RVA = "0x57D50D0", Offset = "0x57D3CD0", VA = "0x1857D50D0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x000213F0 File Offset: 0x0001F5F0
		// (set) Token: 0x060017DA RID: 6106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700077D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 ywz
		{
			[Token(Token = "0x60017D9")]
			[Address(RVA = "0x57D51B0", Offset = "0x57D3DB0", VA = "0x1857D51B0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017DA")]
			[Address(RVA = "0x57D6460", Offset = "0x57D5060", VA = "0x1857D6460")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060017DB RID: 6107 RVA: 0x00021408 File Offset: 0x0001F608
		[Token(Token = "0x1700077E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 yww
		{
			[Token(Token = "0x60017DB")]
			[Address(RVA = "0x57D4F10", Offset = "0x57D3B10", VA = "0x1857D4F10")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060017DC RID: 6108 RVA: 0x00021420 File Offset: 0x0001F620
		[Token(Token = "0x1700077F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zxx
		{
			[Token(Token = "0x60017DC")]
			[Address(RVA = "0x57D2890", Offset = "0x57D1490", VA = "0x1857D2890")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x00021438 File Offset: 0x0001F638
		// (set) Token: 0x060017DE RID: 6110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000780")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zxy
		{
			[Token(Token = "0x60017DD")]
			[Address(RVA = "0x57D2940", Offset = "0x57D1540", VA = "0x1857D2940")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017DE")]
			[Address(RVA = "0x57D30A0", Offset = "0x57D1CA0", VA = "0x1857D30A0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060017DF RID: 6111 RVA: 0x00021450 File Offset: 0x0001F650
		[Token(Token = "0x17000781")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zxz
		{
			[Token(Token = "0x60017DF")]
			[Address(RVA = "0x57D29F0", Offset = "0x57D15F0", VA = "0x1857D29F0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x00021468 File Offset: 0x0001F668
		// (set) Token: 0x060017E1 RID: 6113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000782")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zxw
		{
			[Token(Token = "0x60017E0")]
			[Address(RVA = "0x57D5A80", Offset = "0x57D4680", VA = "0x1857D5A80")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017E1")]
			[Address(RVA = "0x57D6660", Offset = "0x57D5260", VA = "0x1857D6660")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060017E2 RID: 6114 RVA: 0x00021480 File Offset: 0x0001F680
		// (set) Token: 0x060017E3 RID: 6115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000783")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zyx
		{
			[Token(Token = "0x60017E2")]
			[Address(RVA = "0x57D2AC0", Offset = "0x57D16C0", VA = "0x1857D2AC0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017E3")]
			[Address(RVA = "0x57D30D0", Offset = "0x57D1CD0", VA = "0x1857D30D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x00021498 File Offset: 0x0001F698
		[Token(Token = "0x17000784")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zyy
		{
			[Token(Token = "0x60017E4")]
			[Address(RVA = "0x57D2B70", Offset = "0x57D1770", VA = "0x1857D2B70")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x000214B0 File Offset: 0x0001F6B0
		[Token(Token = "0x17000785")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zyz
		{
			[Token(Token = "0x60017E5")]
			[Address(RVA = "0x57D2C20", Offset = "0x57D1820", VA = "0x1857D2C20")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x000214C8 File Offset: 0x0001F6C8
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000786")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zyw
		{
			[Token(Token = "0x60017E6")]
			[Address(RVA = "0x57D5BF0", Offset = "0x57D47F0", VA = "0x1857D5BF0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017E7")]
			[Address(RVA = "0x57D66E0", Offset = "0x57D52E0", VA = "0x1857D66E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x000214E0 File Offset: 0x0001F6E0
		[Token(Token = "0x17000787")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zzx
		{
			[Token(Token = "0x60017E8")]
			[Address(RVA = "0x57D2CF0", Offset = "0x57D18F0", VA = "0x1857D2CF0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x060017E9 RID: 6121 RVA: 0x000214F8 File Offset: 0x0001F6F8
		[Token(Token = "0x17000788")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zzy
		{
			[Token(Token = "0x60017E9")]
			[Address(RVA = "0x57D2DA0", Offset = "0x57D19A0", VA = "0x1857D2DA0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060017EA RID: 6122 RVA: 0x00021510 File Offset: 0x0001F710
		[Token(Token = "0x17000789")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zzz
		{
			[Token(Token = "0x60017EA")]
			[Address(RVA = "0x57D2E50", Offset = "0x57D1A50", VA = "0x1857D2E50")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x00021528 File Offset: 0x0001F728
		[Token(Token = "0x1700078A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zzw
		{
			[Token(Token = "0x60017EB")]
			[Address(RVA = "0x57D5D60", Offset = "0x57D4960", VA = "0x1857D5D60")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060017EC RID: 6124 RVA: 0x00021540 File Offset: 0x0001F740
		// (set) Token: 0x060017ED RID: 6125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zwx
		{
			[Token(Token = "0x60017EC")]
			[Address(RVA = "0x57D57E0", Offset = "0x57D43E0", VA = "0x1857D57E0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017ED")]
			[Address(RVA = "0x57D65C0", Offset = "0x57D51C0", VA = "0x1857D65C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060017EE RID: 6126 RVA: 0x00021558 File Offset: 0x0001F758
		// (set) Token: 0x060017EF RID: 6127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700078C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zwy
		{
			[Token(Token = "0x60017EE")]
			[Address(RVA = "0x57D58C0", Offset = "0x57D44C0", VA = "0x1857D58C0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017EF")]
			[Address(RVA = "0x57D6610", Offset = "0x57D5210", VA = "0x1857D6610")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x00021570 File Offset: 0x0001F770
		[Token(Token = "0x1700078D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zwz
		{
			[Token(Token = "0x60017F0")]
			[Address(RVA = "0x57D59A0", Offset = "0x57D45A0", VA = "0x1857D59A0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x00021588 File Offset: 0x0001F788
		[Token(Token = "0x1700078E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 zww
		{
			[Token(Token = "0x60017F1")]
			[Address(RVA = "0x57D5700", Offset = "0x57D4300", VA = "0x1857D5700")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x000215A0 File Offset: 0x0001F7A0
		[Token(Token = "0x1700078F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wxx
		{
			[Token(Token = "0x60017F2")]
			[Address(RVA = "0x57D3D20", Offset = "0x57D2920", VA = "0x1857D3D20")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x000215B8 File Offset: 0x0001F7B8
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000790")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wxy
		{
			[Token(Token = "0x60017F3")]
			[Address(RVA = "0x57D3E00", Offset = "0x57D2A00", VA = "0x1857D3E00")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017F4")]
			[Address(RVA = "0x57D6080", Offset = "0x57D4C80", VA = "0x1857D6080")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x000215D0 File Offset: 0x0001F7D0
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000791")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wxz
		{
			[Token(Token = "0x60017F5")]
			[Address(RVA = "0x57D3EE0", Offset = "0x57D2AE0", VA = "0x1857D3EE0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017F6")]
			[Address(RVA = "0x57D60D0", Offset = "0x57D4CD0", VA = "0x1857D60D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x000215E8 File Offset: 0x0001F7E8
		[Token(Token = "0x17000792")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wxw
		{
			[Token(Token = "0x60017F7")]
			[Address(RVA = "0x57D3C40", Offset = "0x57D2840", VA = "0x1857D3C40")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x00021600 File Offset: 0x0001F800
		// (set) Token: 0x060017F9 RID: 6137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000793")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wyx
		{
			[Token(Token = "0x60017F8")]
			[Address(RVA = "0x57D40C0", Offset = "0x57D2CC0", VA = "0x1857D40C0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017F9")]
			[Address(RVA = "0x57D6130", Offset = "0x57D4D30", VA = "0x1857D6130")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00021618 File Offset: 0x0001F818
		[Token(Token = "0x17000794")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wyy
		{
			[Token(Token = "0x60017FA")]
			[Address(RVA = "0x57D41A0", Offset = "0x57D2DA0", VA = "0x1857D41A0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060017FB RID: 6139 RVA: 0x00021630 File Offset: 0x0001F830
		// (set) Token: 0x060017FC RID: 6140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000795")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wyz
		{
			[Token(Token = "0x60017FB")]
			[Address(RVA = "0x57D4280", Offset = "0x57D2E80", VA = "0x1857D4280")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017FC")]
			[Address(RVA = "0x57D6180", Offset = "0x57D4D80", VA = "0x1857D6180")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x060017FD RID: 6141 RVA: 0x00021648 File Offset: 0x0001F848
		[Token(Token = "0x17000796")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wyw
		{
			[Token(Token = "0x60017FD")]
			[Address(RVA = "0x57D3FE0", Offset = "0x57D2BE0", VA = "0x1857D3FE0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00021660 File Offset: 0x0001F860
		// (set) Token: 0x060017FF RID: 6143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000797")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wzx
		{
			[Token(Token = "0x60017FE")]
			[Address(RVA = "0x57D4460", Offset = "0x57D3060", VA = "0x1857D4460")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x60017FF")]
			[Address(RVA = "0x57D61E0", Offset = "0x57D4DE0", VA = "0x1857D61E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x00021678 File Offset: 0x0001F878
		// (set) Token: 0x06001801 RID: 6145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000798")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wzy
		{
			[Token(Token = "0x6001800")]
			[Address(RVA = "0x57D4540", Offset = "0x57D3140", VA = "0x1857D4540")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
			[Token(Token = "0x6001801")]
			[Address(RVA = "0x57D6230", Offset = "0x57D4E30", VA = "0x1857D6230")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001802 RID: 6146 RVA: 0x00021690 File Offset: 0x0001F890
		[Token(Token = "0x17000799")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wzz
		{
			[Token(Token = "0x6001802")]
			[Address(RVA = "0x57D4620", Offset = "0x57D3220", VA = "0x1857D4620")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x06001803 RID: 6147 RVA: 0x000216A8 File Offset: 0x0001F8A8
		[Token(Token = "0x1700079A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wzw
		{
			[Token(Token = "0x6001803")]
			[Address(RVA = "0x57D4380", Offset = "0x57D2F80", VA = "0x1857D4380")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x000216C0 File Offset: 0x0001F8C0
		[Token(Token = "0x1700079B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wwx
		{
			[Token(Token = "0x6001804")]
			[Address(RVA = "0x57D3980", Offset = "0x57D2580", VA = "0x1857D3980")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001805 RID: 6149 RVA: 0x000216D8 File Offset: 0x0001F8D8
		[Token(Token = "0x1700079C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wwy
		{
			[Token(Token = "0x6001805")]
			[Address(RVA = "0x57D3A60", Offset = "0x57D2660", VA = "0x1857D3A60")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x000216F0 File Offset: 0x0001F8F0
		[Token(Token = "0x1700079D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 wwz
		{
			[Token(Token = "0x6001806")]
			[Address(RVA = "0x57D3B40", Offset = "0x57D2740", VA = "0x1857D3B40")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x00021708 File Offset: 0x0001F908
		[Token(Token = "0x1700079E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half3 www
		{
			[Token(Token = "0x6001807")]
			[Address(RVA = "0x57D38B0", Offset = "0x57D24B0", VA = "0x1857D38B0")]
			[MethodImpl(256)]
			get
			{
				return default(half3);
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x00021720 File Offset: 0x0001F920
		[Token(Token = "0x1700079F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 xx
		{
			[Token(Token = "0x6001808")]
			[Address(RVA = "0x57D1630", Offset = "0x57D0230", VA = "0x1857D1630")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x06001809 RID: 6153 RVA: 0x00021738 File Offset: 0x0001F938
		// (set) Token: 0x0600180A RID: 6154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 xy
		{
			[Token(Token = "0x6001809")]
			[Address(RVA = "0x57D1740", Offset = "0x57D0340", VA = "0x1857D1740")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x600180A")]
			[Address(RVA = "0x57D15D0", Offset = "0x57D01D0", VA = "0x1857D15D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x0600180B RID: 6155 RVA: 0x00021750 File Offset: 0x0001F950
		// (set) Token: 0x0600180C RID: 6156 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 xz
		{
			[Token(Token = "0x600180B")]
			[Address(RVA = "0x57D21F0", Offset = "0x57D0DF0", VA = "0x1857D21F0")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x600180C")]
			[Address(RVA = "0x57D3010", Offset = "0x57D1C10", VA = "0x1857D3010")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600180D RID: 6157 RVA: 0x00021768 File Offset: 0x0001F968
		// (set) Token: 0x0600180E RID: 6158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 xw
		{
			[Token(Token = "0x600180D")]
			[Address(RVA = "0x57D4700", Offset = "0x57D3300", VA = "0x1857D4700")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x600180E")]
			[Address(RVA = "0x57D6280", Offset = "0x57D4E80", VA = "0x1857D6280")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x0600180F RID: 6159 RVA: 0x00021780 File Offset: 0x0001F980
		// (set) Token: 0x06001810 RID: 6160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 yx
		{
			[Token(Token = "0x600180F")]
			[Address(RVA = "0x57D1860", Offset = "0x57D0460", VA = "0x1857D1860")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x6001810")]
			[Address(RVA = "0x57D1B50", Offset = "0x57D0750", VA = "0x1857D1B50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x06001811 RID: 6161 RVA: 0x00021798 File Offset: 0x0001F998
		[Token(Token = "0x170007A4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 yy
		{
			[Token(Token = "0x6001811")]
			[Address(RVA = "0x57D1980", Offset = "0x57D0580", VA = "0x1857D1980")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
		}

		// Token: 0x170007A5 RID: 1957
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x000217B0 File Offset: 0x0001F9B0
		// (set) Token: 0x06001813 RID: 6163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 yz
		{
			[Token(Token = "0x6001812")]
			[Address(RVA = "0x57D2640", Offset = "0x57D1240", VA = "0x1857D2640")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x6001813")]
			[Address(RVA = "0x57D3060", Offset = "0x57D1C60", VA = "0x1857D3060")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007A6 RID: 1958
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x000217C8 File Offset: 0x0001F9C8
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 yw
		{
			[Token(Token = "0x6001814")]
			[Address(RVA = "0x57D4EF0", Offset = "0x57D3AF0", VA = "0x1857D4EF0")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x6001815")]
			[Address(RVA = "0x57D6400", Offset = "0x57D5000", VA = "0x1857D6400")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007A7 RID: 1959
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x000217E0 File Offset: 0x0001F9E0
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 zx
		{
			[Token(Token = "0x6001816")]
			[Address(RVA = "0x57D2870", Offset = "0x57D1470", VA = "0x1857D2870")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x6001817")]
			[Address(RVA = "0x57D3090", Offset = "0x57D1C90", VA = "0x1857D3090")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001818 RID: 6168 RVA: 0x000217F8 File Offset: 0x0001F9F8
		// (set) Token: 0x06001819 RID: 6169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007A8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 zy
		{
			[Token(Token = "0x6001818")]
			[Address(RVA = "0x57D2AA0", Offset = "0x57D16A0", VA = "0x1857D2AA0")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x6001819")]
			[Address(RVA = "0x57D30C0", Offset = "0x57D1CC0", VA = "0x1857D30C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x0600181A RID: 6170 RVA: 0x00021810 File Offset: 0x0001FA10
		[Token(Token = "0x170007A9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 zz
		{
			[Token(Token = "0x600181A")]
			[Address(RVA = "0x57D2CD0", Offset = "0x57D18D0", VA = "0x1857D2CD0")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
		}

		// Token: 0x170007AA RID: 1962
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00021828 File Offset: 0x0001FA28
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 zw
		{
			[Token(Token = "0x600181B")]
			[Address(RVA = "0x57D56E0", Offset = "0x57D42E0", VA = "0x1857D56E0")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x600181C")]
			[Address(RVA = "0x57D65B0", Offset = "0x57D51B0", VA = "0x1857D65B0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007AB RID: 1963
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x00021840 File Offset: 0x0001FA40
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 wx
		{
			[Token(Token = "0x600181D")]
			[Address(RVA = "0x57D3C20", Offset = "0x57D2820", VA = "0x1857D3C20")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x600181E")]
			[Address(RVA = "0x57D6070", Offset = "0x57D4C70", VA = "0x1857D6070")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007AC RID: 1964
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00021858 File Offset: 0x0001FA58
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 wy
		{
			[Token(Token = "0x600181F")]
			[Address(RVA = "0x57D3FC0", Offset = "0x57D2BC0", VA = "0x1857D3FC0")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x6001820")]
			[Address(RVA = "0x57D6120", Offset = "0x57D4D20", VA = "0x1857D6120")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007AD RID: 1965
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x00021870 File Offset: 0x0001FA70
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007AD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 wz
		{
			[Token(Token = "0x6001821")]
			[Address(RVA = "0x57D4360", Offset = "0x57D2F60", VA = "0x1857D4360")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
			[Token(Token = "0x6001822")]
			[Address(RVA = "0x57D61D0", Offset = "0x57D4DD0", VA = "0x1857D61D0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x00021888 File Offset: 0x0001FA88
		[Token(Token = "0x170007AE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public half2 ww
		{
			[Token(Token = "0x6001823")]
			[Address(RVA = "0x57D3890", Offset = "0x57D2490", VA = "0x1857D3890")]
			[MethodImpl(256)]
			get
			{
				return default(half2);
			}
		}

		// Token: 0x170007AF RID: 1967
		[Token(Token = "0x170007AF")]
		public half this[int index]
		{
			[Token(Token = "0x6001824")]
			[Address(RVA = "0x3D28680", Offset = "0x3D27280", VA = "0x183D28680")]
			get
			{
				return default(half);
			}
			[Token(Token = "0x6001825")]
			[Address(RVA = "0x3D28A60", Offset = "0x3D27660", VA = "0x183D28A60")]
			set
			{
			}
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x000218B8 File Offset: 0x0001FAB8
		[Token(Token = "0x6001826")]
		[Address(RVA = "0x57D30F0", Offset = "0x57D1CF0", VA = "0x1857D30F0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(half4 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x000218D0 File Offset: 0x0001FAD0
		[Token(Token = "0x6001827")]
		[Address(RVA = "0x57D3120", Offset = "0x57D1D20", VA = "0x1857D3120", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000218E8 File Offset: 0x0001FAE8
		[Token(Token = "0x6001828")]
		[Address(RVA = "0x57D31D0", Offset = "0x57D1DD0", VA = "0x1857D31D0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001829")]
		[Address(RVA = "0x57D31E0", Offset = "0x57D1DE0", VA = "0x1857D31E0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x600182A")]
		[Address(RVA = "0x57D33F0", Offset = "0x57D1FF0", VA = "0x1857D33F0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x0")]
		public half x;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x2")]
		public half y;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x4")]
		public half z;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x6")]
		public half w;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly half4 zero;

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x0600182B RID: 6187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600182B")]
			[Address(RVA = "0x57D1280", Offset = "0x57CFE80", VA = "0x1857D1280")]
			public DebuggerProxy(half4 v)
			{
			}

			// Token: 0x040000E4 RID: 228
			[Token(Token = "0x40000E4")]
			[FieldOffset(Offset = "0x10")]
			public half x;

			// Token: 0x040000E5 RID: 229
			[Token(Token = "0x40000E5")]
			[FieldOffset(Offset = "0x12")]
			public half y;

			// Token: 0x040000E6 RID: 230
			[Token(Token = "0x40000E6")]
			[FieldOffset(Offset = "0x14")]
			public half z;

			// Token: 0x040000E7 RID: 231
			[Token(Token = "0x40000E7")]
			[FieldOffset(Offset = "0x16")]
			public half w;
		}
	}
}
