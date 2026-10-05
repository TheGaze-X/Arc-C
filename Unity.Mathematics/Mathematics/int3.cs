using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[DebuggerTypeProxy(typeof(int3.DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct int3 : IEquatable<int3>, IFormattable
	{
		// Token: 0x06001979 RID: 6521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001979")]
		[Address(RVA = "0x4CD2130", Offset = "0x4CD0D30", VA = "0x184CD2130")]
		[MethodImpl(256)]
		public int3(int x, int y, int z)
		{
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197A")]
		[Address(RVA = "0x57DFD00", Offset = "0x57DE900", VA = "0x1857DFD00")]
		[MethodImpl(256)]
		public int3(int x, int2 yz)
		{
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197B")]
		[Address(RVA = "0x57DFDC0", Offset = "0x57DE9C0", VA = "0x1857DFDC0")]
		[MethodImpl(256)]
		public int3(int2 xy, int z)
		{
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197C")]
		[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
		[MethodImpl(256)]
		public int3(int3 xyz)
		{
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197D")]
		[Address(RVA = "0x57DFD80", Offset = "0x57DE980", VA = "0x1857DFD80")]
		[MethodImpl(256)]
		public int3(int v)
		{
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197E")]
		[Address(RVA = "0x57DFDB0", Offset = "0x57DE9B0", VA = "0x1857DFDB0")]
		[MethodImpl(256)]
		public int3(bool v)
		{
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600197F")]
		[Address(RVA = "0x57DFD30", Offset = "0x57DE930", VA = "0x1857DFD30")]
		[MethodImpl(256)]
		public int3(bool3 v)
		{
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001980")]
		[Address(RVA = "0x57DFD80", Offset = "0x57DE980", VA = "0x1857DFD80")]
		[MethodImpl(256)]
		public int3(uint v)
		{
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001981")]
		[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
		[MethodImpl(256)]
		public int3(uint3 v)
		{
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001982")]
		[Address(RVA = "0x57DFD60", Offset = "0x57DE960", VA = "0x1857DFD60")]
		[MethodImpl(256)]
		public int3(float v)
		{
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001983")]
		[Address(RVA = "0x57DFD10", Offset = "0x57DE910", VA = "0x1857DFD10")]
		[MethodImpl(256)]
		public int3(float3 v)
		{
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001984")]
		[Address(RVA = "0x57DFD70", Offset = "0x57DE970", VA = "0x1857DFD70")]
		[MethodImpl(256)]
		public int3(double v)
		{
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001985")]
		[Address(RVA = "0x57DFD90", Offset = "0x57DE990", VA = "0x1857DFD90")]
		[MethodImpl(256)]
		public int3(double3 v)
		{
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00023298 File Offset: 0x00021498
		[Token(Token = "0x6001986")]
		[Address(RVA = "0x5729510", Offset = "0x5728110", VA = "0x185729510")]
		[MethodImpl(256)]
		public static implicit operator int3(int v)
		{
			return default(int3);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x000232B0 File Offset: 0x000214B0
		[Token(Token = "0x6001987")]
		[Address(RVA = "0x57294F0", Offset = "0x57280F0", VA = "0x1857294F0")]
		[MethodImpl(256)]
		public static explicit operator int3(bool v)
		{
			return default(int3);
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x000232C8 File Offset: 0x000214C8
		[Token(Token = "0x6001988")]
		[Address(RVA = "0x57295F0", Offset = "0x57281F0", VA = "0x1857295F0")]
		[MethodImpl(256)]
		public static explicit operator int3(bool3 v)
		{
			return default(int3);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x000232E0 File Offset: 0x000214E0
		[Token(Token = "0x6001989")]
		[Address(RVA = "0x5729510", Offset = "0x5728110", VA = "0x185729510")]
		[MethodImpl(256)]
		public static explicit operator int3(uint v)
		{
			return default(int3);
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x000232F8 File Offset: 0x000214F8
		[Token(Token = "0x600198A")]
		[Address(RVA = "0x57295A0", Offset = "0x57281A0", VA = "0x1857295A0")]
		[MethodImpl(256)]
		public static explicit operator int3(uint3 v)
		{
			return default(int3);
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00023310 File Offset: 0x00021510
		[Token(Token = "0x600198B")]
		[Address(RVA = "0x57295E0", Offset = "0x57281E0", VA = "0x1857295E0")]
		[MethodImpl(256)]
		public static explicit operator int3(float v)
		{
			return default(int3);
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00023328 File Offset: 0x00021528
		[Token(Token = "0x600198C")]
		[Address(RVA = "0x5729520", Offset = "0x5728120", VA = "0x185729520")]
		[MethodImpl(256)]
		public static explicit operator int3(float3 v)
		{
			return default(int3);
		}

		// Token: 0x0600198D RID: 6541 RVA: 0x00023340 File Offset: 0x00021540
		[Token(Token = "0x600198D")]
		[Address(RVA = "0x57295D0", Offset = "0x57281D0", VA = "0x1857295D0")]
		[MethodImpl(256)]
		public static explicit operator int3(double v)
		{
			return default(int3);
		}

		// Token: 0x0600198E RID: 6542 RVA: 0x00023358 File Offset: 0x00021558
		[Token(Token = "0x600198E")]
		[Address(RVA = "0x5729630", Offset = "0x5728230", VA = "0x185729630")]
		[MethodImpl(256)]
		public static explicit operator int3(double3 v)
		{
			return default(int3);
		}

		// Token: 0x0600198F RID: 6543 RVA: 0x00023370 File Offset: 0x00021570
		[Token(Token = "0x600198F")]
		[Address(RVA = "0x57E0390", Offset = "0x57DEF90", VA = "0x1857E0390")]
		[MethodImpl(256)]
		public static int3 operator *(int3 lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00023388 File Offset: 0x00021588
		[Token(Token = "0x6001990")]
		[Address(RVA = "0x57E03C0", Offset = "0x57DEFC0", VA = "0x1857E03C0")]
		[MethodImpl(256)]
		public static int3 operator *(int3 lhs, int rhs)
		{
			return default(int3);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x000233A0 File Offset: 0x000215A0
		[Token(Token = "0x6001991")]
		[Address(RVA = "0x57E03E0", Offset = "0x57DEFE0", VA = "0x1857E03E0")]
		[MethodImpl(256)]
		public static int3 operator *(int lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x000233B8 File Offset: 0x000215B8
		[Token(Token = "0x6001992")]
		[Address(RVA = "0x57DFDF0", Offset = "0x57DE9F0", VA = "0x1857DFDF0")]
		[MethodImpl(256)]
		public static int3 operator +(int3 lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000233D0 File Offset: 0x000215D0
		[Token(Token = "0x6001993")]
		[Address(RVA = "0x57DFE10", Offset = "0x57DEA10", VA = "0x1857DFE10")]
		[MethodImpl(256)]
		public static int3 operator +(int3 lhs, int rhs)
		{
			return default(int3);
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x000233E8 File Offset: 0x000215E8
		[Token(Token = "0x6001994")]
		[Address(RVA = "0x57DFDD0", Offset = "0x57DE9D0", VA = "0x1857DFDD0")]
		[MethodImpl(256)]
		public static int3 operator +(int lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00023400 File Offset: 0x00021600
		[Token(Token = "0x6001995")]
		[Address(RVA = "0x57E0490", Offset = "0x57DF090", VA = "0x1857E0490")]
		[MethodImpl(256)]
		public static int3 operator -(int3 lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x06001996 RID: 6550 RVA: 0x00023418 File Offset: 0x00021618
		[Token(Token = "0x6001996")]
		[Address(RVA = "0x57E0470", Offset = "0x57DF070", VA = "0x1857E0470")]
		[MethodImpl(256)]
		public static int3 operator -(int3 lhs, int rhs)
		{
			return default(int3);
		}

		// Token: 0x06001997 RID: 6551 RVA: 0x00023430 File Offset: 0x00021630
		[Token(Token = "0x6001997")]
		[Address(RVA = "0x57E0450", Offset = "0x57DF050", VA = "0x1857E0450")]
		[MethodImpl(256)]
		public static int3 operator -(int lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00023448 File Offset: 0x00021648
		[Token(Token = "0x6001998")]
		[Address(RVA = "0x57DFF50", Offset = "0x57DEB50", VA = "0x1857DFF50")]
		[MethodImpl(256)]
		public static int3 operator /(int3 lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00023460 File Offset: 0x00021660
		[Token(Token = "0x6001999")]
		[Address(RVA = "0x57DFF20", Offset = "0x57DEB20", VA = "0x1857DFF20")]
		[MethodImpl(256)]
		public static int3 operator /(int3 lhs, int rhs)
		{
			return default(int3);
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00023478 File Offset: 0x00021678
		[Token(Token = "0x600199A")]
		[Address(RVA = "0x57DFF80", Offset = "0x57DEB80", VA = "0x1857DFF80")]
		[MethodImpl(256)]
		public static int3 operator /(int lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00023490 File Offset: 0x00021690
		[Token(Token = "0x600199B")]
		[Address(RVA = "0x57E0330", Offset = "0x57DEF30", VA = "0x1857E0330")]
		[MethodImpl(256)]
		public static int3 operator %(int3 lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x000234A8 File Offset: 0x000216A8
		[Token(Token = "0x600199C")]
		[Address(RVA = "0x57E0360", Offset = "0x57DEF60", VA = "0x1857E0360")]
		[MethodImpl(256)]
		public static int3 operator %(int3 lhs, int rhs)
		{
			return default(int3);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x000234C0 File Offset: 0x000216C0
		[Token(Token = "0x600199D")]
		[Address(RVA = "0x57E0300", Offset = "0x57DEF00", VA = "0x1857E0300")]
		[MethodImpl(256)]
		public static int3 operator %(int lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x000234D8 File Offset: 0x000216D8
		[Token(Token = "0x600199E")]
		[Address(RVA = "0x57E0160", Offset = "0x57DED60", VA = "0x1857E0160")]
		[MethodImpl(256)]
		public static int3 operator ++(int3 val)
		{
			return default(int3);
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x000234F0 File Offset: 0x000216F0
		[Token(Token = "0x600199F")]
		[Address(RVA = "0x57DFF00", Offset = "0x57DEB00", VA = "0x1857DFF00")]
		[MethodImpl(256)]
		public static int3 operator --(int3 val)
		{
			return default(int3);
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x00023508 File Offset: 0x00021708
		[Token(Token = "0x60019A0")]
		[Address(RVA = "0x57E0290", Offset = "0x57DEE90", VA = "0x1857E0290")]
		[MethodImpl(256)]
		public static bool3 operator <(int3 lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x00023520 File Offset: 0x00021720
		[Token(Token = "0x60019A1")]
		[Address(RVA = "0x57E02E0", Offset = "0x57DEEE0", VA = "0x1857E02E0")]
		[MethodImpl(256)]
		public static bool3 operator <(int3 lhs, int rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00023538 File Offset: 0x00021738
		[Token(Token = "0x60019A2")]
		[Address(RVA = "0x57E02C0", Offset = "0x57DEEC0", VA = "0x1857E02C0")]
		[MethodImpl(256)]
		public static bool3 operator <(int lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x00023550 File Offset: 0x00021750
		[Token(Token = "0x60019A3")]
		[Address(RVA = "0x57E0220", Offset = "0x57DEE20", VA = "0x1857E0220")]
		[MethodImpl(256)]
		public static bool3 operator <=(int3 lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x00023568 File Offset: 0x00021768
		[Token(Token = "0x60019A4")]
		[Address(RVA = "0x57E0250", Offset = "0x57DEE50", VA = "0x1857E0250")]
		[MethodImpl(256)]
		public static bool3 operator <=(int3 lhs, int rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00023580 File Offset: 0x00021780
		[Token(Token = "0x60019A5")]
		[Address(RVA = "0x57E0270", Offset = "0x57DEE70", VA = "0x1857E0270")]
		[MethodImpl(256)]
		public static bool3 operator <=(int lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00023598 File Offset: 0x00021798
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0x57E0110", Offset = "0x57DED10", VA = "0x1857E0110")]
		[MethodImpl(256)]
		public static bool3 operator >(int3 lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x000235B0 File Offset: 0x000217B0
		[Token(Token = "0x60019A7")]
		[Address(RVA = "0x57E0140", Offset = "0x57DED40", VA = "0x1857E0140")]
		[MethodImpl(256)]
		public static bool3 operator >(int3 lhs, int rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000235C8 File Offset: 0x000217C8
		[Token(Token = "0x60019A8")]
		[Address(RVA = "0x57E00F0", Offset = "0x57DECF0", VA = "0x1857E00F0")]
		[MethodImpl(256)]
		public static bool3 operator >(int lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x000235E0 File Offset: 0x000217E0
		[Token(Token = "0x60019A9")]
		[Address(RVA = "0x57E0080", Offset = "0x57DEC80", VA = "0x1857E0080")]
		[MethodImpl(256)]
		public static bool3 operator >=(int3 lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x000235F8 File Offset: 0x000217F8
		[Token(Token = "0x60019AA")]
		[Address(RVA = "0x57E00B0", Offset = "0x57DECB0", VA = "0x1857E00B0")]
		[MethodImpl(256)]
		public static bool3 operator >=(int3 lhs, int rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00023610 File Offset: 0x00021810
		[Token(Token = "0x60019AB")]
		[Address(RVA = "0x57E00D0", Offset = "0x57DECD0", VA = "0x1857E00D0")]
		[MethodImpl(256)]
		public static bool3 operator >=(int lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00023628 File Offset: 0x00021828
		[Token(Token = "0x60019AC")]
		[Address(RVA = "0x57E04B0", Offset = "0x57DF0B0", VA = "0x1857E04B0")]
		[MethodImpl(256)]
		public static int3 operator -(int3 val)
		{
			return default(int3);
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00023640 File Offset: 0x00021840
		[Token(Token = "0x60019AD")]
		[Address(RVA = "0x576B480", Offset = "0x576A080", VA = "0x18576B480")]
		[MethodImpl(256)]
		public static int3 operator +(int3 val)
		{
			return default(int3);
		}

		// Token: 0x060019AE RID: 6574 RVA: 0x00023658 File Offset: 0x00021858
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x57E01F0", Offset = "0x57DEDF0", VA = "0x1857E01F0")]
		[MethodImpl(256)]
		public static int3 operator <<(int3 x, int n)
		{
			return default(int3);
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00023670 File Offset: 0x00021870
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x57E0420", Offset = "0x57DF020", VA = "0x1857E0420")]
		[MethodImpl(256)]
		public static int3 operator >>(int3 x, int n)
		{
			return default(int3);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00023688 File Offset: 0x00021888
		[Token(Token = "0x60019B0")]
		[Address(RVA = "0x57DFFB0", Offset = "0x57DEBB0", VA = "0x1857DFFB0")]
		[MethodImpl(256)]
		public static bool3 operator ==(int3 lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x000236A0 File Offset: 0x000218A0
		[Token(Token = "0x60019B1")]
		[Address(RVA = "0x57DFFE0", Offset = "0x57DEBE0", VA = "0x1857DFFE0")]
		[MethodImpl(256)]
		public static bool3 operator ==(int3 lhs, int rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x000236B8 File Offset: 0x000218B8
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x57E0000", Offset = "0x57DEC00", VA = "0x1857E0000")]
		[MethodImpl(256)]
		public static bool3 operator ==(int lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x000236D0 File Offset: 0x000218D0
		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x57E01C0", Offset = "0x57DEDC0", VA = "0x1857E01C0")]
		[MethodImpl(256)]
		public static bool3 operator !=(int3 lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x000236E8 File Offset: 0x000218E8
		[Token(Token = "0x60019B4")]
		[Address(RVA = "0x57E01A0", Offset = "0x57DEDA0", VA = "0x1857E01A0")]
		[MethodImpl(256)]
		public static bool3 operator !=(int3 lhs, int rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x00023700 File Offset: 0x00021900
		[Token(Token = "0x60019B5")]
		[Address(RVA = "0x57E0180", Offset = "0x57DED80", VA = "0x1857E0180")]
		[MethodImpl(256)]
		public static bool3 operator !=(int lhs, int3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x00023718 File Offset: 0x00021918
		[Token(Token = "0x60019B6")]
		[Address(RVA = "0x57E0400", Offset = "0x57DF000", VA = "0x1857E0400")]
		[MethodImpl(256)]
		public static int3 operator ~(int3 val)
		{
			return default(int3);
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x00023730 File Offset: 0x00021930
		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x57DFE60", Offset = "0x57DEA60", VA = "0x1857DFE60")]
		[MethodImpl(256)]
		public static int3 operator &(int3 lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x00023748 File Offset: 0x00021948
		[Token(Token = "0x60019B8")]
		[Address(RVA = "0x57DFE40", Offset = "0x57DEA40", VA = "0x1857DFE40")]
		[MethodImpl(256)]
		public static int3 operator &(int3 lhs, int rhs)
		{
			return default(int3);
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x00023760 File Offset: 0x00021960
		[Token(Token = "0x60019B9")]
		[Address(RVA = "0x57DFE80", Offset = "0x57DEA80", VA = "0x1857DFE80")]
		[MethodImpl(256)]
		public static int3 operator &(int lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x00023778 File Offset: 0x00021978
		[Token(Token = "0x60019BA")]
		[Address(RVA = "0x57DFEA0", Offset = "0x57DEAA0", VA = "0x1857DFEA0")]
		[MethodImpl(256)]
		public static int3 operator |(int3 lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x060019BB RID: 6587 RVA: 0x00023790 File Offset: 0x00021990
		[Token(Token = "0x60019BB")]
		[Address(RVA = "0x57DFEE0", Offset = "0x57DEAE0", VA = "0x1857DFEE0")]
		[MethodImpl(256)]
		public static int3 operator |(int3 lhs, int rhs)
		{
			return default(int3);
		}

		// Token: 0x060019BC RID: 6588 RVA: 0x000237A8 File Offset: 0x000219A8
		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x57DFEC0", Offset = "0x57DEAC0", VA = "0x1857DFEC0")]
		[MethodImpl(256)]
		public static int3 operator |(int lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x000237C0 File Offset: 0x000219C0
		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x57E0020", Offset = "0x57DEC20", VA = "0x1857E0020")]
		[MethodImpl(256)]
		public static int3 operator ^(int3 lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x000237D8 File Offset: 0x000219D8
		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x57E0040", Offset = "0x57DEC40", VA = "0x1857E0040")]
		[MethodImpl(256)]
		public static int3 operator ^(int3 lhs, int rhs)
		{
			return default(int3);
		}

		// Token: 0x060019BF RID: 6591 RVA: 0x000237F0 File Offset: 0x000219F0
		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x57E0060", Offset = "0x57DEC60", VA = "0x1857E0060")]
		[MethodImpl(256)]
		public static int3 operator ^(int lhs, int3 rhs)
		{
			return default(int3);
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00023808 File Offset: 0x00021A08
		[Token(Token = "0x170007D0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxxx
		{
			[Token(Token = "0x60019C0")]
			[Address(RVA = "0x576B0E0", Offset = "0x5769CE0", VA = "0x18576B0E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x00023820 File Offset: 0x00021A20
		[Token(Token = "0x170007D1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxxy
		{
			[Token(Token = "0x60019C1")]
			[Address(RVA = "0x576B100", Offset = "0x5769D00", VA = "0x18576B100")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x060019C2 RID: 6594 RVA: 0x00023838 File Offset: 0x00021A38
		[Token(Token = "0x170007D2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxxz
		{
			[Token(Token = "0x60019C2")]
			[Address(RVA = "0x576B120", Offset = "0x5769D20", VA = "0x18576B120")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x00023850 File Offset: 0x00021A50
		[Token(Token = "0x170007D3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxyx
		{
			[Token(Token = "0x60019C3")]
			[Address(RVA = "0x576B180", Offset = "0x5769D80", VA = "0x18576B180")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x060019C4 RID: 6596 RVA: 0x00023868 File Offset: 0x00021A68
		[Token(Token = "0x170007D4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxyy
		{
			[Token(Token = "0x60019C4")]
			[Address(RVA = "0x576B1A0", Offset = "0x5769DA0", VA = "0x18576B1A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x00023880 File Offset: 0x00021A80
		[Token(Token = "0x170007D5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxyz
		{
			[Token(Token = "0x60019C5")]
			[Address(RVA = "0x576B1C0", Offset = "0x5769DC0", VA = "0x18576B1C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00023898 File Offset: 0x00021A98
		[Token(Token = "0x170007D6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxzx
		{
			[Token(Token = "0x60019C6")]
			[Address(RVA = "0x576B220", Offset = "0x5769E20", VA = "0x18576B220")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x000238B0 File Offset: 0x00021AB0
		[Token(Token = "0x170007D7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxzy
		{
			[Token(Token = "0x60019C7")]
			[Address(RVA = "0x576B240", Offset = "0x5769E40", VA = "0x18576B240")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x000238C8 File Offset: 0x00021AC8
		[Token(Token = "0x170007D8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxzz
		{
			[Token(Token = "0x60019C8")]
			[Address(RVA = "0x576B260", Offset = "0x5769E60", VA = "0x18576B260")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060019C9 RID: 6601 RVA: 0x000238E0 File Offset: 0x00021AE0
		[Token(Token = "0x170007D9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxx
		{
			[Token(Token = "0x60019C9")]
			[Address(RVA = "0x576B380", Offset = "0x5769F80", VA = "0x18576B380")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x000238F8 File Offset: 0x00021AF8
		[Token(Token = "0x170007DA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxy
		{
			[Token(Token = "0x60019CA")]
			[Address(RVA = "0x576B3A0", Offset = "0x5769FA0", VA = "0x18576B3A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x00023910 File Offset: 0x00021B10
		[Token(Token = "0x170007DB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxz
		{
			[Token(Token = "0x60019CB")]
			[Address(RVA = "0x576B3C0", Offset = "0x5769FC0", VA = "0x18576B3C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x00023928 File Offset: 0x00021B28
		[Token(Token = "0x170007DC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyyx
		{
			[Token(Token = "0x60019CC")]
			[Address(RVA = "0x576B420", Offset = "0x576A020", VA = "0x18576B420")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060019CD RID: 6605 RVA: 0x00023940 File Offset: 0x00021B40
		[Token(Token = "0x170007DD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyyy
		{
			[Token(Token = "0x60019CD")]
			[Address(RVA = "0x576B440", Offset = "0x576A040", VA = "0x18576B440")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x00023958 File Offset: 0x00021B58
		[Token(Token = "0x170007DE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyyz
		{
			[Token(Token = "0x60019CE")]
			[Address(RVA = "0x576B460", Offset = "0x576A060", VA = "0x18576B460")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x00023970 File Offset: 0x00021B70
		[Token(Token = "0x170007DF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyzx
		{
			[Token(Token = "0x60019CF")]
			[Address(RVA = "0x576B4C0", Offset = "0x576A0C0", VA = "0x18576B4C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x00023988 File Offset: 0x00021B88
		[Token(Token = "0x170007E0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyzy
		{
			[Token(Token = "0x60019D0")]
			[Address(RVA = "0x576B4E0", Offset = "0x576A0E0", VA = "0x18576B4E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x000239A0 File Offset: 0x00021BA0
		[Token(Token = "0x170007E1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyzz
		{
			[Token(Token = "0x60019D1")]
			[Address(RVA = "0x576B500", Offset = "0x576A100", VA = "0x18576B500")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x000239B8 File Offset: 0x00021BB8
		[Token(Token = "0x170007E2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzxx
		{
			[Token(Token = "0x60019D2")]
			[Address(RVA = "0x576B620", Offset = "0x576A220", VA = "0x18576B620")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060019D3 RID: 6611 RVA: 0x000239D0 File Offset: 0x00021BD0
		[Token(Token = "0x170007E3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzxy
		{
			[Token(Token = "0x60019D3")]
			[Address(RVA = "0x576B640", Offset = "0x576A240", VA = "0x18576B640")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060019D4 RID: 6612 RVA: 0x000239E8 File Offset: 0x00021BE8
		[Token(Token = "0x170007E4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzxz
		{
			[Token(Token = "0x60019D4")]
			[Address(RVA = "0x576B660", Offset = "0x576A260", VA = "0x18576B660")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x00023A00 File Offset: 0x00021C00
		[Token(Token = "0x170007E5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzyx
		{
			[Token(Token = "0x60019D5")]
			[Address(RVA = "0x576B6C0", Offset = "0x576A2C0", VA = "0x18576B6C0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00023A18 File Offset: 0x00021C18
		[Token(Token = "0x170007E6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzyy
		{
			[Token(Token = "0x60019D6")]
			[Address(RVA = "0x576B6E0", Offset = "0x576A2E0", VA = "0x18576B6E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x00023A30 File Offset: 0x00021C30
		[Token(Token = "0x170007E7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzyz
		{
			[Token(Token = "0x60019D7")]
			[Address(RVA = "0x576B700", Offset = "0x576A300", VA = "0x18576B700")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00023A48 File Offset: 0x00021C48
		[Token(Token = "0x170007E8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzzx
		{
			[Token(Token = "0x60019D8")]
			[Address(RVA = "0x576B760", Offset = "0x576A360", VA = "0x18576B760")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x00023A60 File Offset: 0x00021C60
		[Token(Token = "0x170007E9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzzy
		{
			[Token(Token = "0x60019D9")]
			[Address(RVA = "0x576B780", Offset = "0x576A380", VA = "0x18576B780")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x00023A78 File Offset: 0x00021C78
		[Token(Token = "0x170007EA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xzzz
		{
			[Token(Token = "0x60019DA")]
			[Address(RVA = "0x576B7A0", Offset = "0x576A3A0", VA = "0x18576B7A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x00023A90 File Offset: 0x00021C90
		[Token(Token = "0x170007EB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxxx
		{
			[Token(Token = "0x60019DB")]
			[Address(RVA = "0x576BB60", Offset = "0x576A760", VA = "0x18576BB60")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x00023AA8 File Offset: 0x00021CA8
		[Token(Token = "0x170007EC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxxy
		{
			[Token(Token = "0x60019DC")]
			[Address(RVA = "0x576BB80", Offset = "0x576A780", VA = "0x18576BB80")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x060019DD RID: 6621 RVA: 0x00023AC0 File Offset: 0x00021CC0
		[Token(Token = "0x170007ED")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxxz
		{
			[Token(Token = "0x60019DD")]
			[Address(RVA = "0x576BBA0", Offset = "0x576A7A0", VA = "0x18576BBA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x00023AD8 File Offset: 0x00021CD8
		[Token(Token = "0x170007EE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxyx
		{
			[Token(Token = "0x60019DE")]
			[Address(RVA = "0x576BC00", Offset = "0x576A800", VA = "0x18576BC00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x00023AF0 File Offset: 0x00021CF0
		[Token(Token = "0x170007EF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxyy
		{
			[Token(Token = "0x60019DF")]
			[Address(RVA = "0x576BC20", Offset = "0x576A820", VA = "0x18576BC20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00023B08 File Offset: 0x00021D08
		[Token(Token = "0x170007F0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxyz
		{
			[Token(Token = "0x60019E0")]
			[Address(RVA = "0x576BC40", Offset = "0x576A840", VA = "0x18576BC40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x00023B20 File Offset: 0x00021D20
		[Token(Token = "0x170007F1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxzx
		{
			[Token(Token = "0x60019E1")]
			[Address(RVA = "0x576BCA0", Offset = "0x576A8A0", VA = "0x18576BCA0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00023B38 File Offset: 0x00021D38
		[Token(Token = "0x170007F2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxzy
		{
			[Token(Token = "0x60019E2")]
			[Address(RVA = "0x576BCC0", Offset = "0x576A8C0", VA = "0x18576BCC0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060019E3 RID: 6627 RVA: 0x00023B50 File Offset: 0x00021D50
		[Token(Token = "0x170007F3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxzz
		{
			[Token(Token = "0x60019E3")]
			[Address(RVA = "0x576BCE0", Offset = "0x576A8E0", VA = "0x18576BCE0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00023B68 File Offset: 0x00021D68
		[Token(Token = "0x170007F4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyxx
		{
			[Token(Token = "0x60019E4")]
			[Address(RVA = "0x576BE00", Offset = "0x576AA00", VA = "0x18576BE00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060019E5 RID: 6629 RVA: 0x00023B80 File Offset: 0x00021D80
		[Token(Token = "0x170007F5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyxy
		{
			[Token(Token = "0x60019E5")]
			[Address(RVA = "0x576BE20", Offset = "0x576AA20", VA = "0x18576BE20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00023B98 File Offset: 0x00021D98
		[Token(Token = "0x170007F6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyxz
		{
			[Token(Token = "0x60019E6")]
			[Address(RVA = "0x576BE40", Offset = "0x576AA40", VA = "0x18576BE40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x00023BB0 File Offset: 0x00021DB0
		[Token(Token = "0x170007F7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyyx
		{
			[Token(Token = "0x60019E7")]
			[Address(RVA = "0x576BE90", Offset = "0x576AA90", VA = "0x18576BE90")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00023BC8 File Offset: 0x00021DC8
		[Token(Token = "0x170007F8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyyy
		{
			[Token(Token = "0x60019E8")]
			[Address(RVA = "0x576BEB0", Offset = "0x576AAB0", VA = "0x18576BEB0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x00023BE0 File Offset: 0x00021DE0
		[Token(Token = "0x170007F9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyyz
		{
			[Token(Token = "0x60019E9")]
			[Address(RVA = "0x576BED0", Offset = "0x576AAD0", VA = "0x18576BED0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x00023BF8 File Offset: 0x00021DF8
		[Token(Token = "0x170007FA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyzx
		{
			[Token(Token = "0x60019EA")]
			[Address(RVA = "0x576BF30", Offset = "0x576AB30", VA = "0x18576BF30")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x00023C10 File Offset: 0x00021E10
		[Token(Token = "0x170007FB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyzy
		{
			[Token(Token = "0x60019EB")]
			[Address(RVA = "0x576BF50", Offset = "0x576AB50", VA = "0x18576BF50")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060019EC RID: 6636 RVA: 0x00023C28 File Offset: 0x00021E28
		[Token(Token = "0x170007FC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyzz
		{
			[Token(Token = "0x60019EC")]
			[Address(RVA = "0x576BF70", Offset = "0x576AB70", VA = "0x18576BF70")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x00023C40 File Offset: 0x00021E40
		[Token(Token = "0x170007FD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzxx
		{
			[Token(Token = "0x60019ED")]
			[Address(RVA = "0x576C090", Offset = "0x576AC90", VA = "0x18576C090")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060019EE RID: 6638 RVA: 0x00023C58 File Offset: 0x00021E58
		[Token(Token = "0x170007FE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzxy
		{
			[Token(Token = "0x60019EE")]
			[Address(RVA = "0x576C0B0", Offset = "0x576ACB0", VA = "0x18576C0B0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060019EF RID: 6639 RVA: 0x00023C70 File Offset: 0x00021E70
		[Token(Token = "0x170007FF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzxz
		{
			[Token(Token = "0x60019EF")]
			[Address(RVA = "0x576C0D0", Offset = "0x576ACD0", VA = "0x18576C0D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00023C88 File Offset: 0x00021E88
		[Token(Token = "0x17000800")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzyx
		{
			[Token(Token = "0x60019F0")]
			[Address(RVA = "0x576C130", Offset = "0x576AD30", VA = "0x18576C130")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060019F1 RID: 6641 RVA: 0x00023CA0 File Offset: 0x00021EA0
		[Token(Token = "0x17000801")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzyy
		{
			[Token(Token = "0x60019F1")]
			[Address(RVA = "0x576C150", Offset = "0x576AD50", VA = "0x18576C150")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00023CB8 File Offset: 0x00021EB8
		[Token(Token = "0x17000802")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzyz
		{
			[Token(Token = "0x60019F2")]
			[Address(RVA = "0x576C170", Offset = "0x576AD70", VA = "0x18576C170")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x00023CD0 File Offset: 0x00021ED0
		[Token(Token = "0x17000803")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzzx
		{
			[Token(Token = "0x60019F3")]
			[Address(RVA = "0x576C1D0", Offset = "0x576ADD0", VA = "0x18576C1D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00023CE8 File Offset: 0x00021EE8
		[Token(Token = "0x17000804")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzzy
		{
			[Token(Token = "0x60019F4")]
			[Address(RVA = "0x576C1F0", Offset = "0x576ADF0", VA = "0x18576C1F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x00023D00 File Offset: 0x00021F00
		[Token(Token = "0x17000805")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yzzz
		{
			[Token(Token = "0x60019F5")]
			[Address(RVA = "0x576C210", Offset = "0x576AE10", VA = "0x18576C210")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00023D18 File Offset: 0x00021F18
		[Token(Token = "0x17000806")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxxx
		{
			[Token(Token = "0x60019F6")]
			[Address(RVA = "0x576C5B0", Offset = "0x576B1B0", VA = "0x18576C5B0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060019F7 RID: 6647 RVA: 0x00023D30 File Offset: 0x00021F30
		[Token(Token = "0x17000807")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxxy
		{
			[Token(Token = "0x60019F7")]
			[Address(RVA = "0x576C5D0", Offset = "0x576B1D0", VA = "0x18576C5D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00023D48 File Offset: 0x00021F48
		[Token(Token = "0x17000808")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxxz
		{
			[Token(Token = "0x60019F8")]
			[Address(RVA = "0x576C5F0", Offset = "0x576B1F0", VA = "0x18576C5F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060019F9 RID: 6649 RVA: 0x00023D60 File Offset: 0x00021F60
		[Token(Token = "0x17000809")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxyx
		{
			[Token(Token = "0x60019F9")]
			[Address(RVA = "0x576C650", Offset = "0x576B250", VA = "0x18576C650")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x00023D78 File Offset: 0x00021F78
		[Token(Token = "0x1700080A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxyy
		{
			[Token(Token = "0x60019FA")]
			[Address(RVA = "0x576C670", Offset = "0x576B270", VA = "0x18576C670")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x00023D90 File Offset: 0x00021F90
		[Token(Token = "0x1700080B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxyz
		{
			[Token(Token = "0x60019FB")]
			[Address(RVA = "0x576C690", Offset = "0x576B290", VA = "0x18576C690")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x00023DA8 File Offset: 0x00021FA8
		[Token(Token = "0x1700080C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxzx
		{
			[Token(Token = "0x60019FC")]
			[Address(RVA = "0x576C6F0", Offset = "0x576B2F0", VA = "0x18576C6F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x060019FD RID: 6653 RVA: 0x00023DC0 File Offset: 0x00021FC0
		[Token(Token = "0x1700080D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxzy
		{
			[Token(Token = "0x60019FD")]
			[Address(RVA = "0x576C710", Offset = "0x576B310", VA = "0x18576C710")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060019FE RID: 6654 RVA: 0x00023DD8 File Offset: 0x00021FD8
		[Token(Token = "0x1700080E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zxzz
		{
			[Token(Token = "0x60019FE")]
			[Address(RVA = "0x576C730", Offset = "0x576B330", VA = "0x18576C730")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060019FF RID: 6655 RVA: 0x00023DF0 File Offset: 0x00021FF0
		[Token(Token = "0x1700080F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyxx
		{
			[Token(Token = "0x60019FF")]
			[Address(RVA = "0x576C850", Offset = "0x576B450", VA = "0x18576C850")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00023E08 File Offset: 0x00022008
		[Token(Token = "0x17000810")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyxy
		{
			[Token(Token = "0x6001A00")]
			[Address(RVA = "0x576C870", Offset = "0x576B470", VA = "0x18576C870")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x06001A01 RID: 6657 RVA: 0x00023E20 File Offset: 0x00022020
		[Token(Token = "0x17000811")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyxz
		{
			[Token(Token = "0x6001A01")]
			[Address(RVA = "0x576C890", Offset = "0x576B490", VA = "0x18576C890")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00023E38 File Offset: 0x00022038
		[Token(Token = "0x17000812")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyyx
		{
			[Token(Token = "0x6001A02")]
			[Address(RVA = "0x576C8F0", Offset = "0x576B4F0", VA = "0x18576C8F0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x00023E50 File Offset: 0x00022050
		[Token(Token = "0x17000813")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyyy
		{
			[Token(Token = "0x6001A03")]
			[Address(RVA = "0x576C910", Offset = "0x576B510", VA = "0x18576C910")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x00023E68 File Offset: 0x00022068
		[Token(Token = "0x17000814")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyyz
		{
			[Token(Token = "0x6001A04")]
			[Address(RVA = "0x576C930", Offset = "0x576B530", VA = "0x18576C930")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001A05 RID: 6661 RVA: 0x00023E80 File Offset: 0x00022080
		[Token(Token = "0x17000815")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyzx
		{
			[Token(Token = "0x6001A05")]
			[Address(RVA = "0x576C990", Offset = "0x576B590", VA = "0x18576C990")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001A06 RID: 6662 RVA: 0x00023E98 File Offset: 0x00022098
		[Token(Token = "0x17000816")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyzy
		{
			[Token(Token = "0x6001A06")]
			[Address(RVA = "0x576C9B0", Offset = "0x576B5B0", VA = "0x18576C9B0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001A07 RID: 6663 RVA: 0x00023EB0 File Offset: 0x000220B0
		[Token(Token = "0x17000817")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zyzz
		{
			[Token(Token = "0x6001A07")]
			[Address(RVA = "0x576C9D0", Offset = "0x576B5D0", VA = "0x18576C9D0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001A08 RID: 6664 RVA: 0x00023EC8 File Offset: 0x000220C8
		[Token(Token = "0x17000818")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzxx
		{
			[Token(Token = "0x6001A08")]
			[Address(RVA = "0x576CAF0", Offset = "0x576B6F0", VA = "0x18576CAF0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x00023EE0 File Offset: 0x000220E0
		[Token(Token = "0x17000819")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzxy
		{
			[Token(Token = "0x6001A09")]
			[Address(RVA = "0x576CB10", Offset = "0x576B710", VA = "0x18576CB10")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001A0A RID: 6666 RVA: 0x00023EF8 File Offset: 0x000220F8
		[Token(Token = "0x1700081A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzxz
		{
			[Token(Token = "0x6001A0A")]
			[Address(RVA = "0x576CB30", Offset = "0x576B730", VA = "0x18576CB30")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001A0B RID: 6667 RVA: 0x00023F10 File Offset: 0x00022110
		[Token(Token = "0x1700081B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzyx
		{
			[Token(Token = "0x6001A0B")]
			[Address(RVA = "0x576CB90", Offset = "0x576B790", VA = "0x18576CB90")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001A0C RID: 6668 RVA: 0x00023F28 File Offset: 0x00022128
		[Token(Token = "0x1700081C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzyy
		{
			[Token(Token = "0x6001A0C")]
			[Address(RVA = "0x576CBB0", Offset = "0x576B7B0", VA = "0x18576CBB0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00023F40 File Offset: 0x00022140
		[Token(Token = "0x1700081D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzyz
		{
			[Token(Token = "0x6001A0D")]
			[Address(RVA = "0x576CBD0", Offset = "0x576B7D0", VA = "0x18576CBD0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001A0E RID: 6670 RVA: 0x00023F58 File Offset: 0x00022158
		[Token(Token = "0x1700081E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzzx
		{
			[Token(Token = "0x6001A0E")]
			[Address(RVA = "0x576CC20", Offset = "0x576B820", VA = "0x18576CC20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001A0F RID: 6671 RVA: 0x00023F70 File Offset: 0x00022170
		[Token(Token = "0x1700081F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzzy
		{
			[Token(Token = "0x6001A0F")]
			[Address(RVA = "0x576CC40", Offset = "0x576B840", VA = "0x18576CC40")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x00023F88 File Offset: 0x00022188
		[Token(Token = "0x17000820")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 zzzz
		{
			[Token(Token = "0x6001A10")]
			[Address(RVA = "0x576CC60", Offset = "0x576B860", VA = "0x18576CC60")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001A11 RID: 6673 RVA: 0x00023FA0 File Offset: 0x000221A0
		[Token(Token = "0x17000821")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xxx
		{
			[Token(Token = "0x6001A11")]
			[Address(RVA = "0x576B0B0", Offset = "0x5769CB0", VA = "0x18576B0B0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001A12 RID: 6674 RVA: 0x00023FB8 File Offset: 0x000221B8
		[Token(Token = "0x17000822")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xxy
		{
			[Token(Token = "0x6001A12")]
			[Address(RVA = "0x576B140", Offset = "0x5769D40", VA = "0x18576B140")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00023FD0 File Offset: 0x000221D0
		[Token(Token = "0x17000823")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xxz
		{
			[Token(Token = "0x6001A13")]
			[Address(RVA = "0x576B1E0", Offset = "0x5769DE0", VA = "0x18576B1E0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x00023FE8 File Offset: 0x000221E8
		[Token(Token = "0x17000824")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyx
		{
			[Token(Token = "0x6001A14")]
			[Address(RVA = "0x576B340", Offset = "0x5769F40", VA = "0x18576B340")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x00024000 File Offset: 0x00022200
		[Token(Token = "0x17000825")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyy
		{
			[Token(Token = "0x6001A15")]
			[Address(RVA = "0x576B3E0", Offset = "0x5769FE0", VA = "0x18576B3E0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x00024018 File Offset: 0x00022218
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000826")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyz
		{
			[Token(Token = "0x6001A16")]
			[Address(RVA = "0x576B480", Offset = "0x576A080", VA = "0x18576B480")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001A17")]
			[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x00024030 File Offset: 0x00022230
		[Token(Token = "0x17000827")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xzx
		{
			[Token(Token = "0x6001A18")]
			[Address(RVA = "0x576B5E0", Offset = "0x576A1E0", VA = "0x18576B5E0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00024048 File Offset: 0x00022248
		// (set) Token: 0x06001A1A RID: 6682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000828")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xzy
		{
			[Token(Token = "0x6001A19")]
			[Address(RVA = "0x576B680", Offset = "0x576A280", VA = "0x18576B680")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001A1A")]
			[Address(RVA = "0x576D8C0", Offset = "0x576C4C0", VA = "0x18576D8C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x00024060 File Offset: 0x00022260
		[Token(Token = "0x17000829")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xzz
		{
			[Token(Token = "0x6001A1B")]
			[Address(RVA = "0x576B720", Offset = "0x576A320", VA = "0x18576B720")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00024078 File Offset: 0x00022278
		[Token(Token = "0x1700082A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yxx
		{
			[Token(Token = "0x6001A1C")]
			[Address(RVA = "0x576BB20", Offset = "0x576A720", VA = "0x18576BB20")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00024090 File Offset: 0x00022290
		[Token(Token = "0x1700082B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yxy
		{
			[Token(Token = "0x6001A1D")]
			[Address(RVA = "0x576BBC0", Offset = "0x576A7C0", VA = "0x18576BBC0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x000240A8 File Offset: 0x000222A8
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700082C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yxz
		{
			[Token(Token = "0x6001A1E")]
			[Address(RVA = "0x576BC60", Offset = "0x576A860", VA = "0x18576BC60")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001A1F")]
			[Address(RVA = "0x576D9E0", Offset = "0x576C5E0", VA = "0x18576D9E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x000240C0 File Offset: 0x000222C0
		[Token(Token = "0x1700082D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yyx
		{
			[Token(Token = "0x6001A20")]
			[Address(RVA = "0x576BDC0", Offset = "0x576A9C0", VA = "0x18576BDC0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001A21 RID: 6689 RVA: 0x000240D8 File Offset: 0x000222D8
		[Token(Token = "0x1700082E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yyy
		{
			[Token(Token = "0x6001A21")]
			[Address(RVA = "0x576BE60", Offset = "0x576AA60", VA = "0x18576BE60")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x000240F0 File Offset: 0x000222F0
		[Token(Token = "0x1700082F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yyz
		{
			[Token(Token = "0x6001A22")]
			[Address(RVA = "0x576BEF0", Offset = "0x576AAF0", VA = "0x18576BEF0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001A23 RID: 6691 RVA: 0x00024108 File Offset: 0x00022308
		// (set) Token: 0x06001A24 RID: 6692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000830")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yzx
		{
			[Token(Token = "0x6001A23")]
			[Address(RVA = "0x576C050", Offset = "0x576AC50", VA = "0x18576C050")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001A24")]
			[Address(RVA = "0x576DA70", Offset = "0x576C670", VA = "0x18576DA70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00024120 File Offset: 0x00022320
		[Token(Token = "0x17000831")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yzy
		{
			[Token(Token = "0x6001A25")]
			[Address(RVA = "0x576C0F0", Offset = "0x576ACF0", VA = "0x18576C0F0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001A26 RID: 6694 RVA: 0x00024138 File Offset: 0x00022338
		[Token(Token = "0x17000832")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yzz
		{
			[Token(Token = "0x6001A26")]
			[Address(RVA = "0x576C190", Offset = "0x576AD90", VA = "0x18576C190")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001A27 RID: 6695 RVA: 0x00024150 File Offset: 0x00022350
		[Token(Token = "0x17000833")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zxx
		{
			[Token(Token = "0x6001A27")]
			[Address(RVA = "0x576C570", Offset = "0x576B170", VA = "0x18576C570")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001A28 RID: 6696 RVA: 0x00024168 File Offset: 0x00022368
		// (set) Token: 0x06001A29 RID: 6697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000834")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zxy
		{
			[Token(Token = "0x6001A28")]
			[Address(RVA = "0x576C610", Offset = "0x576B210", VA = "0x18576C610")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001A29")]
			[Address(RVA = "0x576DB90", Offset = "0x576C790", VA = "0x18576DB90")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00024180 File Offset: 0x00022380
		[Token(Token = "0x17000835")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zxz
		{
			[Token(Token = "0x6001A2A")]
			[Address(RVA = "0x576C6B0", Offset = "0x576B2B0", VA = "0x18576C6B0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001A2B RID: 6699 RVA: 0x00024198 File Offset: 0x00022398
		// (set) Token: 0x06001A2C RID: 6700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000836")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zyx
		{
			[Token(Token = "0x6001A2B")]
			[Address(RVA = "0x576C810", Offset = "0x576B410", VA = "0x18576C810")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
			[Token(Token = "0x6001A2C")]
			[Address(RVA = "0x576DC20", Offset = "0x576C820", VA = "0x18576DC20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001A2D RID: 6701 RVA: 0x000241B0 File Offset: 0x000223B0
		[Token(Token = "0x17000837")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zyy
		{
			[Token(Token = "0x6001A2D")]
			[Address(RVA = "0x576C8B0", Offset = "0x576B4B0", VA = "0x18576C8B0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001A2E RID: 6702 RVA: 0x000241C8 File Offset: 0x000223C8
		[Token(Token = "0x17000838")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zyz
		{
			[Token(Token = "0x6001A2E")]
			[Address(RVA = "0x576C950", Offset = "0x576B550", VA = "0x18576C950")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001A2F RID: 6703 RVA: 0x000241E0 File Offset: 0x000223E0
		[Token(Token = "0x17000839")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zzx
		{
			[Token(Token = "0x6001A2F")]
			[Address(RVA = "0x576CAB0", Offset = "0x576B6B0", VA = "0x18576CAB0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x000241F8 File Offset: 0x000223F8
		[Token(Token = "0x1700083A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zzy
		{
			[Token(Token = "0x6001A30")]
			[Address(RVA = "0x576CB50", Offset = "0x576B750", VA = "0x18576CB50")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00024210 File Offset: 0x00022410
		[Token(Token = "0x1700083B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 zzz
		{
			[Token(Token = "0x6001A31")]
			[Address(RVA = "0x576CBF0", Offset = "0x576B7F0", VA = "0x18576CBF0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x06001A32 RID: 6706 RVA: 0x00024228 File Offset: 0x00022428
		[Token(Token = "0x1700083C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xx
		{
			[Token(Token = "0x6001A32")]
			[Address(RVA = "0x576B000", Offset = "0x5769C00", VA = "0x18576B000")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001A33 RID: 6707 RVA: 0x00024240 File Offset: 0x00022440
		// (set) Token: 0x06001A34 RID: 6708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xy
		{
			[Token(Token = "0x6001A33")]
			[Address(RVA = "0x576B280", Offset = "0x5769E80", VA = "0x18576B280")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001A34")]
			[Address(RVA = "0x576D820", Offset = "0x576C420", VA = "0x18576D820")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00024258 File Offset: 0x00022458
		// (set) Token: 0x06001A36 RID: 6710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xz
		{
			[Token(Token = "0x6001A35")]
			[Address(RVA = "0x576B520", Offset = "0x576A120", VA = "0x18576B520")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001A36")]
			[Address(RVA = "0x576D870", Offset = "0x576C470", VA = "0x18576D870")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x00024270 File Offset: 0x00022470
		// (set) Token: 0x06001A38 RID: 6712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700083F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yx
		{
			[Token(Token = "0x6001A37")]
			[Address(RVA = "0x576BA60", Offset = "0x576A660", VA = "0x18576BA60")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001A38")]
			[Address(RVA = "0x576D990", Offset = "0x576C590", VA = "0x18576D990")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001A39 RID: 6713 RVA: 0x00024288 File Offset: 0x00022488
		[Token(Token = "0x17000840")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yy
		{
			[Token(Token = "0x6001A39")]
			[Address(RVA = "0x576BD00", Offset = "0x576A900", VA = "0x18576BD00")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x06001A3A RID: 6714 RVA: 0x000242A0 File Offset: 0x000224A0
		// (set) Token: 0x06001A3B RID: 6715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000841")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yz
		{
			[Token(Token = "0x6001A3A")]
			[Address(RVA = "0x576BF90", Offset = "0x576AB90", VA = "0x18576BF90")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001A3B")]
			[Address(RVA = "0x576DA20", Offset = "0x576C620", VA = "0x18576DA20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001A3C RID: 6716 RVA: 0x000242B8 File Offset: 0x000224B8
		// (set) Token: 0x06001A3D RID: 6717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000842")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 zx
		{
			[Token(Token = "0x6001A3C")]
			[Address(RVA = "0x576C4B0", Offset = "0x576B0B0", VA = "0x18576C4B0")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001A3D")]
			[Address(RVA = "0x576DB40", Offset = "0x576C740", VA = "0x18576DB40")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x000242D0 File Offset: 0x000224D0
		// (set) Token: 0x06001A3F RID: 6719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000843")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 zy
		{
			[Token(Token = "0x6001A3E")]
			[Address(RVA = "0x576C750", Offset = "0x576B350", VA = "0x18576C750")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x6001A3F")]
			[Address(RVA = "0x576DBD0", Offset = "0x576C7D0", VA = "0x18576DBD0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001A40 RID: 6720 RVA: 0x000242E8 File Offset: 0x000224E8
		[Token(Token = "0x17000844")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 zz
		{
			[Token(Token = "0x6001A40")]
			[Address(RVA = "0x576C9F0", Offset = "0x576B5F0", VA = "0x18576C9F0")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
		}

		// Token: 0x17000845 RID: 2117
		[Token(Token = "0x17000845")]
		public int this[int index]
		{
			[Token(Token = "0x6001A41")]
			[Address(RVA = "0x3D284D0", Offset = "0x3D270D0", VA = "0x183D284D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001A42")]
			[Address(RVA = "0x3D288C0", Offset = "0x3D274C0", VA = "0x183D288C0")]
			set
			{
			}
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x00024318 File Offset: 0x00022518
		[Token(Token = "0x6001A43")]
		[Address(RVA = "0x57DFAC0", Offset = "0x57DE6C0", VA = "0x1857DFAC0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(int3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00024330 File Offset: 0x00022530
		[Token(Token = "0x6001A44")]
		[Address(RVA = "0x57DFAE0", Offset = "0x57DE6E0", VA = "0x1857DFAE0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x00024348 File Offset: 0x00022548
		[Token(Token = "0x6001A45")]
		[Address(RVA = "0x57212E0", Offset = "0x571FEE0", VA = "0x1857212E0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001A46")]
		[Address(RVA = "0x57DFC50", Offset = "0x57DE850", VA = "0x1857DFC50", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001A47")]
		[Address(RVA = "0x57DFB90", Offset = "0x57DE790", VA = "0x1857DFB90", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x4")]
		public int y;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x8")]
		public int z;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int3 zero;

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x06001A48 RID: 6728 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001A48")]
			[Address(RVA = "0x57A9750", Offset = "0x57A8350", VA = "0x1857A9750")]
			public DebuggerProxy(int3 v)
			{
			}

			// Token: 0x040000FE RID: 254
			[Token(Token = "0x40000FE")]
			[FieldOffset(Offset = "0x10")]
			public int x;

			// Token: 0x040000FF RID: 255
			[Token(Token = "0x40000FF")]
			[FieldOffset(Offset = "0x14")]
			public int y;

			// Token: 0x04000100 RID: 256
			[Token(Token = "0x4000100")]
			[FieldOffset(Offset = "0x18")]
			public int z;
		}
	}
}
