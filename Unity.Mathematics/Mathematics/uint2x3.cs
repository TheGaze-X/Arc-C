using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct uint2x3 : IEquatable<uint2x3>, IFormattable
	{
		// Token: 0x06001F4C RID: 8012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4C")]
		[Address(RVA = "0x4C2F060", Offset = "0x4C2DC60", VA = "0x184C2F060")]
		[MethodImpl(256)]
		public uint2x3(uint2 c0, uint2 c1, uint2 c2)
		{
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4D")]
		[Address(RVA = "0x57D9450", Offset = "0x57D8050", VA = "0x1857D9450")]
		[MethodImpl(256)]
		public uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12)
		{
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4E")]
		[Address(RVA = "0x57D93C0", Offset = "0x57D7FC0", VA = "0x1857D93C0")]
		[MethodImpl(256)]
		public uint2x3(uint v)
		{
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F4F")]
		[Address(RVA = "0x56FF160", Offset = "0x56FDD60", VA = "0x1856FF160")]
		[MethodImpl(256)]
		public uint2x3(bool v)
		{
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F50")]
		[Address(RVA = "0x56FF080", Offset = "0x56FDC80", VA = "0x1856FF080")]
		[MethodImpl(256)]
		public uint2x3(bool2x3 v)
		{
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F51")]
		[Address(RVA = "0x57D93C0", Offset = "0x57D7FC0", VA = "0x1857D93C0")]
		[MethodImpl(256)]
		public uint2x3(int v)
		{
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F52")]
		[Address(RVA = "0x57D9400", Offset = "0x57D8000", VA = "0x1857D9400")]
		[MethodImpl(256)]
		public uint2x3(int2x3 v)
		{
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F53")]
		[Address(RVA = "0x57035E0", Offset = "0x57021E0", VA = "0x1857035E0")]
		[MethodImpl(256)]
		public uint2x3(float v)
		{
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F54")]
		[Address(RVA = "0x5703470", Offset = "0x5702070", VA = "0x185703470")]
		[MethodImpl(256)]
		public uint2x3(float2x3 v)
		{
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F55")]
		[Address(RVA = "0x5703540", Offset = "0x5702140", VA = "0x185703540")]
		[MethodImpl(256)]
		public uint2x3(double v)
		{
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F56")]
		[Address(RVA = "0x5703680", Offset = "0x5702280", VA = "0x185703680")]
		[MethodImpl(256)]
		public uint2x3(double2x3 v)
		{
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x0002A6D8 File Offset: 0x000288D8
		[Token(Token = "0x6001F57")]
		[Address(RVA = "0x5728CC0", Offset = "0x57278C0", VA = "0x185728CC0")]
		[MethodImpl(256)]
		public static implicit operator uint2x3(uint v)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x0002A6F0 File Offset: 0x000288F0
		[Token(Token = "0x6001F58")]
		[Address(RVA = "0x57D9E20", Offset = "0x57D8A20", VA = "0x1857D9E20")]
		[MethodImpl(256)]
		public static explicit operator uint2x3(bool v)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x0002A708 File Offset: 0x00028908
		[Token(Token = "0x6001F59")]
		[Address(RVA = "0x57D9E50", Offset = "0x57D8A50", VA = "0x1857D9E50")]
		[MethodImpl(256)]
		public static explicit operator uint2x3(bool2x3 v)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x0002A720 File Offset: 0x00028920
		[Token(Token = "0x6001F5A")]
		[Address(RVA = "0x5728CC0", Offset = "0x57278C0", VA = "0x185728CC0")]
		[MethodImpl(256)]
		public static explicit operator uint2x3(int v)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x0002A738 File Offset: 0x00028938
		[Token(Token = "0x6001F5B")]
		[Address(RVA = "0x5728C30", Offset = "0x5727830", VA = "0x185728C30")]
		[MethodImpl(256)]
		public static explicit operator uint2x3(int2x3 v)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x0002A750 File Offset: 0x00028950
		[Token(Token = "0x6001F5C")]
		[Address(RVA = "0x5812AE0", Offset = "0x58116E0", VA = "0x185812AE0")]
		[MethodImpl(256)]
		public static explicit operator uint2x3(float v)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x0002A768 File Offset: 0x00028968
		[Token(Token = "0x6001F5D")]
		[Address(RVA = "0x5812B90", Offset = "0x5811790", VA = "0x185812B90")]
		[MethodImpl(256)]
		public static explicit operator uint2x3(float2x3 v)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x0002A780 File Offset: 0x00028980
		[Token(Token = "0x6001F5E")]
		[Address(RVA = "0x5812B10", Offset = "0x5811710", VA = "0x185812B10")]
		[MethodImpl(256)]
		public static explicit operator uint2x3(double v)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x0002A798 File Offset: 0x00028998
		[Token(Token = "0x6001F5F")]
		[Address(RVA = "0x5812B40", Offset = "0x5811740", VA = "0x185812B40")]
		[MethodImpl(256)]
		public static explicit operator uint2x3(double2x3 v)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x0002A7B0 File Offset: 0x000289B0
		[Token(Token = "0x6001F60")]
		[Address(RVA = "0x57DA8E0", Offset = "0x57D94E0", VA = "0x1857DA8E0")]
		[MethodImpl(256)]
		public static uint2x3 operator *(uint2x3 lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x0002A7C8 File Offset: 0x000289C8
		[Token(Token = "0x6001F61")]
		[Address(RVA = "0x57DA7E0", Offset = "0x57D93E0", VA = "0x1857DA7E0")]
		[MethodImpl(256)]
		public static uint2x3 operator *(uint2x3 lhs, uint rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F62 RID: 8034 RVA: 0x0002A7E0 File Offset: 0x000289E0
		[Token(Token = "0x6001F62")]
		[Address(RVA = "0x57DA860", Offset = "0x57D9460", VA = "0x1857DA860")]
		[MethodImpl(256)]
		public static uint2x3 operator *(uint lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F63 RID: 8035 RVA: 0x0002A7F8 File Offset: 0x000289F8
		[Token(Token = "0x6001F63")]
		[Address(RVA = "0x57D9510", Offset = "0x57D8110", VA = "0x1857D9510")]
		[MethodImpl(256)]
		public static uint2x3 operator +(uint2x3 lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F64 RID: 8036 RVA: 0x0002A810 File Offset: 0x00028A10
		[Token(Token = "0x6001F64")]
		[Address(RVA = "0x57D95A0", Offset = "0x57D81A0", VA = "0x1857D95A0")]
		[MethodImpl(256)]
		public static uint2x3 operator +(uint2x3 lhs, uint rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F65 RID: 8037 RVA: 0x0002A828 File Offset: 0x00028A28
		[Token(Token = "0x6001F65")]
		[Address(RVA = "0x57D94A0", Offset = "0x57D80A0", VA = "0x1857D94A0")]
		[MethodImpl(256)]
		public static uint2x3 operator +(uint lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F66 RID: 8038 RVA: 0x0002A840 File Offset: 0x00028A40
		[Token(Token = "0x6001F66")]
		[Address(RVA = "0x57DAAF0", Offset = "0x57D96F0", VA = "0x1857DAAF0")]
		[MethodImpl(256)]
		public static uint2x3 operator -(uint2x3 lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F67 RID: 8039 RVA: 0x0002A858 File Offset: 0x00028A58
		[Token(Token = "0x6001F67")]
		[Address(RVA = "0x57DAB80", Offset = "0x57D9780", VA = "0x1857DAB80")]
		[MethodImpl(256)]
		public static uint2x3 operator -(uint2x3 lhs, uint rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F68 RID: 8040 RVA: 0x0002A870 File Offset: 0x00028A70
		[Token(Token = "0x6001F68")]
		[Address(RVA = "0x57DAA70", Offset = "0x57D9670", VA = "0x1857DAA70")]
		[MethodImpl(256)]
		public static uint2x3 operator -(uint lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F69 RID: 8041 RVA: 0x0002A888 File Offset: 0x00028A88
		[Token(Token = "0x6001F69")]
		[Address(RVA = "0x5812910", Offset = "0x5811510", VA = "0x185812910")]
		[MethodImpl(256)]
		public static uint2x3 operator /(uint2x3 lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F6A RID: 8042 RVA: 0x0002A8A0 File Offset: 0x00028AA0
		[Token(Token = "0x6001F6A")]
		[Address(RVA = "0x5812A50", Offset = "0x5811650", VA = "0x185812A50")]
		[MethodImpl(256)]
		public static uint2x3 operator /(uint2x3 lhs, uint rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F6B RID: 8043 RVA: 0x0002A8B8 File Offset: 0x00028AB8
		[Token(Token = "0x6001F6B")]
		[Address(RVA = "0x58129C0", Offset = "0x58115C0", VA = "0x1858129C0")]
		[MethodImpl(256)]
		public static uint2x3 operator /(uint lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F6C RID: 8044 RVA: 0x0002A8D0 File Offset: 0x00028AD0
		[Token(Token = "0x6001F6C")]
		[Address(RVA = "0x58131A0", Offset = "0x5811DA0", VA = "0x1858131A0")]
		[MethodImpl(256)]
		public static uint2x3 operator %(uint2x3 lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F6D RID: 8045 RVA: 0x0002A8E8 File Offset: 0x00028AE8
		[Token(Token = "0x6001F6D")]
		[Address(RVA = "0x5813110", Offset = "0x5811D10", VA = "0x185813110")]
		[MethodImpl(256)]
		public static uint2x3 operator %(uint2x3 lhs, uint rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F6E RID: 8046 RVA: 0x0002A900 File Offset: 0x00028B00
		[Token(Token = "0x6001F6E")]
		[Address(RVA = "0x5813250", Offset = "0x5811E50", VA = "0x185813250")]
		[MethodImpl(256)]
		public static uint2x3 operator %(uint lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F6F RID: 8047 RVA: 0x0002A918 File Offset: 0x00028B18
		[Token(Token = "0x6001F6F")]
		[Address(RVA = "0x57DA130", Offset = "0x57D8D30", VA = "0x1857DA130")]
		[MethodImpl(256)]
		public static uint2x3 operator ++(uint2x3 val)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F70 RID: 8048 RVA: 0x0002A930 File Offset: 0x00028B30
		[Token(Token = "0x6001F70")]
		[Address(RVA = "0x57D9910", Offset = "0x57D8510", VA = "0x1857D9910")]
		[MethodImpl(256)]
		public static uint2x3 operator --(uint2x3 val)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x0002A948 File Offset: 0x00028B48
		[Token(Token = "0x6001F71")]
		[Address(RVA = "0x5813090", Offset = "0x5811C90", VA = "0x185813090")]
		[MethodImpl(256)]
		public static bool2x3 operator <(uint2x3 lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x0002A960 File Offset: 0x00028B60
		[Token(Token = "0x6001F72")]
		[Address(RVA = "0x5812FC0", Offset = "0x5811BC0", VA = "0x185812FC0")]
		[MethodImpl(256)]
		public static bool2x3 operator <(uint2x3 lhs, uint rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x0002A978 File Offset: 0x00028B78
		[Token(Token = "0x6001F73")]
		[Address(RVA = "0x5813030", Offset = "0x5811C30", VA = "0x185813030")]
		[MethodImpl(256)]
		public static bool2x3 operator <(uint lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x0002A990 File Offset: 0x00028B90
		[Token(Token = "0x6001F74")]
		[Address(RVA = "0x5812E70", Offset = "0x5811A70", VA = "0x185812E70")]
		[MethodImpl(256)]
		public static bool2x3 operator <=(uint2x3 lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F75 RID: 8053 RVA: 0x0002A9A8 File Offset: 0x00028BA8
		[Token(Token = "0x6001F75")]
		[Address(RVA = "0x5812EF0", Offset = "0x5811AF0", VA = "0x185812EF0")]
		[MethodImpl(256)]
		public static bool2x3 operator <=(uint2x3 lhs, uint rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F76 RID: 8054 RVA: 0x0002A9C0 File Offset: 0x00028BC0
		[Token(Token = "0x6001F76")]
		[Address(RVA = "0x5812F60", Offset = "0x5811B60", VA = "0x185812F60")]
		[MethodImpl(256)]
		public static bool2x3 operator <=(uint lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F77 RID: 8055 RVA: 0x0002A9D8 File Offset: 0x00028BD8
		[Token(Token = "0x6001F77")]
		[Address(RVA = "0x5812D20", Offset = "0x5811920", VA = "0x185812D20")]
		[MethodImpl(256)]
		public static bool2x3 operator >(uint2x3 lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F78 RID: 8056 RVA: 0x0002A9F0 File Offset: 0x00028BF0
		[Token(Token = "0x6001F78")]
		[Address(RVA = "0x5812DA0", Offset = "0x58119A0", VA = "0x185812DA0")]
		[MethodImpl(256)]
		public static bool2x3 operator >(uint2x3 lhs, uint rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F79 RID: 8057 RVA: 0x0002AA08 File Offset: 0x00028C08
		[Token(Token = "0x6001F79")]
		[Address(RVA = "0x5812E10", Offset = "0x5811A10", VA = "0x185812E10")]
		[MethodImpl(256)]
		public static bool2x3 operator >(uint lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x0002AA20 File Offset: 0x00028C20
		[Token(Token = "0x6001F7A")]
		[Address(RVA = "0x5812CA0", Offset = "0x58118A0", VA = "0x185812CA0")]
		[MethodImpl(256)]
		public static bool2x3 operator >=(uint2x3 lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x0002AA38 File Offset: 0x00028C38
		[Token(Token = "0x6001F7B")]
		[Address(RVA = "0x5812C30", Offset = "0x5811830", VA = "0x185812C30")]
		[MethodImpl(256)]
		public static bool2x3 operator >=(uint2x3 lhs, uint rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x0002AA50 File Offset: 0x00028C50
		[Token(Token = "0x6001F7C")]
		[Address(RVA = "0x5812BD0", Offset = "0x58117D0", VA = "0x185812BD0")]
		[MethodImpl(256)]
		public static bool2x3 operator >=(uint lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x0002AA68 File Offset: 0x00028C68
		[Token(Token = "0x6001F7D")]
		[Address(RVA = "0x57DAC00", Offset = "0x57D9800", VA = "0x1857DAC00")]
		[MethodImpl(256)]
		public static uint2x3 operator -(uint2x3 val)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x0002AA80 File Offset: 0x00028C80
		[Token(Token = "0x6001F7E")]
		[Address(RVA = "0x57DAC70", Offset = "0x57D9870", VA = "0x1857DAC70")]
		[MethodImpl(256)]
		public static uint2x3 operator +(uint2x3 val)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x0002AA98 File Offset: 0x00028C98
		[Token(Token = "0x6001F7F")]
		[Address(RVA = "0x57DA300", Offset = "0x57D8F00", VA = "0x1857DA300")]
		[MethodImpl(256)]
		public static uint2x3 operator <<(uint2x3 x, int n)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x0002AAB0 File Offset: 0x00028CB0
		[Token(Token = "0x6001F80")]
		[Address(RVA = "0x58132E0", Offset = "0x5811EE0", VA = "0x1858132E0")]
		[MethodImpl(256)]
		public static uint2x3 operator >>(uint2x3 x, int n)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x0002AAC8 File Offset: 0x00028CC8
		[Token(Token = "0x6001F81")]
		[Address(RVA = "0x57D9B50", Offset = "0x57D8750", VA = "0x1857D9B50")]
		[MethodImpl(256)]
		public static bool2x3 operator ==(uint2x3 lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x0002AAE0 File Offset: 0x00028CE0
		[Token(Token = "0x6001F82")]
		[Address(RVA = "0x57D9BD0", Offset = "0x57D87D0", VA = "0x1857D9BD0")]
		[MethodImpl(256)]
		public static bool2x3 operator ==(uint2x3 lhs, uint rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x0002AAF8 File Offset: 0x00028CF8
		[Token(Token = "0x6001F83")]
		[Address(RVA = "0x57D9C40", Offset = "0x57D8840", VA = "0x1857D9C40")]
		[MethodImpl(256)]
		public static bool2x3 operator ==(uint lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F84 RID: 8068 RVA: 0x0002AB10 File Offset: 0x00028D10
		[Token(Token = "0x6001F84")]
		[Address(RVA = "0x57DA1B0", Offset = "0x57D8DB0", VA = "0x1857DA1B0")]
		[MethodImpl(256)]
		public static bool2x3 operator !=(uint2x3 lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F85 RID: 8069 RVA: 0x0002AB28 File Offset: 0x00028D28
		[Token(Token = "0x6001F85")]
		[Address(RVA = "0x57DA230", Offset = "0x57D8E30", VA = "0x1857DA230")]
		[MethodImpl(256)]
		public static bool2x3 operator !=(uint2x3 lhs, uint rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F86 RID: 8070 RVA: 0x0002AB40 File Offset: 0x00028D40
		[Token(Token = "0x6001F86")]
		[Address(RVA = "0x57DA2A0", Offset = "0x57D8EA0", VA = "0x1857DA2A0")]
		[MethodImpl(256)]
		public static bool2x3 operator !=(uint lhs, uint2x3 rhs)
		{
			return default(bool2x3);
		}

		// Token: 0x06001F87 RID: 8071 RVA: 0x0002AB58 File Offset: 0x00028D58
		[Token(Token = "0x6001F87")]
		[Address(RVA = "0x57DA980", Offset = "0x57D9580", VA = "0x1857DA980")]
		[MethodImpl(256)]
		public static uint2x3 operator ~(uint2x3 val)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F88 RID: 8072 RVA: 0x0002AB70 File Offset: 0x00028D70
		[Token(Token = "0x6001F88")]
		[Address(RVA = "0x57D9610", Offset = "0x57D8210", VA = "0x1857D9610")]
		[MethodImpl(256)]
		public static uint2x3 operator &(uint2x3 lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x0002AB88 File Offset: 0x00028D88
		[Token(Token = "0x6001F89")]
		[Address(RVA = "0x57D96A0", Offset = "0x57D82A0", VA = "0x1857D96A0")]
		[MethodImpl(256)]
		public static uint2x3 operator &(uint2x3 lhs, uint rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x0002ABA0 File Offset: 0x00028DA0
		[Token(Token = "0x6001F8A")]
		[Address(RVA = "0x57D9720", Offset = "0x57D8320", VA = "0x1857D9720")]
		[MethodImpl(256)]
		public static uint2x3 operator &(uint lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F8B RID: 8075 RVA: 0x0002ABB8 File Offset: 0x00028DB8
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0x57D9800", Offset = "0x57D8400", VA = "0x1857D9800")]
		[MethodImpl(256)]
		public static uint2x3 operator |(uint2x3 lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F8C RID: 8076 RVA: 0x0002ABD0 File Offset: 0x00028DD0
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0x57D9890", Offset = "0x57D8490", VA = "0x1857D9890")]
		[MethodImpl(256)]
		public static uint2x3 operator |(uint2x3 lhs, uint rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F8D RID: 8077 RVA: 0x0002ABE8 File Offset: 0x00028DE8
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0x57D9790", Offset = "0x57D8390", VA = "0x1857D9790")]
		[MethodImpl(256)]
		public static uint2x3 operator |(uint lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0002AC00 File Offset: 0x00028E00
		[Token(Token = "0x6001F8E")]
		[Address(RVA = "0x57D9D90", Offset = "0x57D8990", VA = "0x1857D9D90")]
		[MethodImpl(256)]
		public static uint2x3 operator ^(uint2x3 lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0002AC18 File Offset: 0x00028E18
		[Token(Token = "0x6001F8F")]
		[Address(RVA = "0x57D9D10", Offset = "0x57D8910", VA = "0x1857D9D10")]
		[MethodImpl(256)]
		public static uint2x3 operator ^(uint2x3 lhs, uint rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x0002AC30 File Offset: 0x00028E30
		[Token(Token = "0x6001F90")]
		[Address(RVA = "0x57D9CA0", Offset = "0x57D88A0", VA = "0x1857D9CA0")]
		[MethodImpl(256)]
		public static uint2x3 operator ^(uint lhs, uint2x3 rhs)
		{
			return default(uint2x3);
		}

		// Token: 0x170009BB RID: 2491
		[Token(Token = "0x170009BB")]
		public uint2 this[int index]
		{
			[Token(Token = "0x6001F91")]
			[Address(RVA = "0x3D28190", Offset = "0x3D26D90", VA = "0x183D28190")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x0002AC48 File Offset: 0x00028E48
		[Token(Token = "0x6001F92")]
		[Address(RVA = "0x57D8B40", Offset = "0x57D7740", VA = "0x1857D8B40", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(uint2x3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x0002AC60 File Offset: 0x00028E60
		[Token(Token = "0x6001F93")]
		[Address(RVA = "0x5812240", Offset = "0x5810E40", VA = "0x185812240", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x0002AC78 File Offset: 0x00028E78
		[Token(Token = "0x6001F94")]
		[Address(RVA = "0x5812340", Offset = "0x5810F40", VA = "0x185812340", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001F95")]
		[Address(RVA = "0x5812370", Offset = "0x5810F70", VA = "0x185812370", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x5812640", Offset = "0x5811240", VA = "0x185812640", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x0")]
		public uint2 c0;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x8")]
		public uint2 c1;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x10")]
		public uint2 c2;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x0")]
		public static readonly uint2x3 zero;
	}
}
