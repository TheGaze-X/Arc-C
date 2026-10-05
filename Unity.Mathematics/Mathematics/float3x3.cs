using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct float3x3 : IEquatable<float3x3>, IFormattable
	{
		// Token: 0x06001247 RID: 4679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001247")]
		[Address(RVA = "0x57B5D70", Offset = "0x57B4970", VA = "0x1857B5D70")]
		[MethodImpl(256)]
		public float3x3(float3 c0, float3 c1, float3 c2)
		{
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001248")]
		[Address(RVA = "0x57B5C10", Offset = "0x57B4810", VA = "0x1857B5C10")]
		[MethodImpl(256)]
		public float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001249")]
		[Address(RVA = "0x57B5DB0", Offset = "0x57B49B0", VA = "0x1857B5DB0")]
		[MethodImpl(256)]
		public float3x3(float v)
		{
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124A")]
		[Address(RVA = "0x56FD5D0", Offset = "0x56FC1D0", VA = "0x1856FD5D0")]
		[MethodImpl(256)]
		public float3x3(bool v)
		{
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124B")]
		[Address(RVA = "0x56FD7E0", Offset = "0x56FC3E0", VA = "0x1856FD7E0")]
		[MethodImpl(256)]
		public float3x3(bool3x3 v)
		{
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124C")]
		[Address(RVA = "0x57B5B00", Offset = "0x57B4700", VA = "0x1857B5B00")]
		[MethodImpl(256)]
		public float3x3(int v)
		{
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124D")]
		[Address(RVA = "0x56FD4D0", Offset = "0x56FC0D0", VA = "0x1856FD4D0")]
		[MethodImpl(256)]
		public float3x3(int3x3 v)
		{
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124E")]
		[Address(RVA = "0x57B5D10", Offset = "0x57B4910", VA = "0x1857B5D10")]
		[MethodImpl(256)]
		public float3x3(uint v)
		{
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600124F")]
		[Address(RVA = "0x56FD690", Offset = "0x56FC290", VA = "0x1856FD690")]
		[MethodImpl(256)]
		public float3x3(uint3x3 v)
		{
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001250")]
		[Address(RVA = "0x57B5E00", Offset = "0x57B4A00", VA = "0x1857B5E00")]
		[MethodImpl(256)]
		public float3x3(double v)
		{
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001251")]
		[Address(RVA = "0x57B5B60", Offset = "0x57B4760", VA = "0x1857B5B60")]
		[MethodImpl(256)]
		public float3x3(double3x3 v)
		{
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0001A5E0 File Offset: 0x000187E0
		[Token(Token = "0x6001252")]
		[Address(RVA = "0x57176E0", Offset = "0x57162E0", VA = "0x1857176E0")]
		[MethodImpl(256)]
		public static implicit operator float3x3(float v)
		{
			return default(float3x3);
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0001A5F8 File Offset: 0x000187F8
		[Token(Token = "0x6001253")]
		[Address(RVA = "0x57B6D90", Offset = "0x57B5990", VA = "0x1857B6D90")]
		[MethodImpl(256)]
		public static explicit operator float3x3(bool v)
		{
			return default(float3x3);
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0001A610 File Offset: 0x00018810
		[Token(Token = "0x6001254")]
		[Address(RVA = "0x57B6D50", Offset = "0x57B5950", VA = "0x1857B6D50")]
		[MethodImpl(256)]
		public static explicit operator float3x3(bool3x3 v)
		{
			return default(float3x3);
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0001A628 File Offset: 0x00018828
		[Token(Token = "0x6001255")]
		[Address(RVA = "0x57179D0", Offset = "0x57165D0", VA = "0x1857179D0")]
		[MethodImpl(256)]
		public static implicit operator float3x3(int v)
		{
			return default(float3x3);
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x0001A640 File Offset: 0x00018840
		[Token(Token = "0x6001256")]
		[Address(RVA = "0x57B7370", Offset = "0x57B5F70", VA = "0x1857B7370")]
		[MethodImpl(256)]
		public static implicit operator float3x3(int3x3 v)
		{
			return default(float3x3);
		}

		// Token: 0x06001257 RID: 4695 RVA: 0x0001A658 File Offset: 0x00018858
		[Token(Token = "0x6001257")]
		[Address(RVA = "0x5717BB0", Offset = "0x57167B0", VA = "0x185717BB0")]
		[MethodImpl(256)]
		public static implicit operator float3x3(uint v)
		{
			return default(float3x3);
		}

		// Token: 0x06001258 RID: 4696 RVA: 0x0001A670 File Offset: 0x00018870
		[Token(Token = "0x6001258")]
		[Address(RVA = "0x57B7320", Offset = "0x57B5F20", VA = "0x1857B7320")]
		[MethodImpl(256)]
		public static implicit operator float3x3(uint3x3 v)
		{
			return default(float3x3);
		}

		// Token: 0x06001259 RID: 4697 RVA: 0x0001A688 File Offset: 0x00018888
		[Token(Token = "0x6001259")]
		[Address(RVA = "0x5717C60", Offset = "0x5716860", VA = "0x185717C60")]
		[MethodImpl(256)]
		public static explicit operator float3x3(double v)
		{
			return default(float3x3);
		}

		// Token: 0x0600125A RID: 4698 RVA: 0x0001A6A0 File Offset: 0x000188A0
		[Token(Token = "0x600125A")]
		[Address(RVA = "0x5717740", Offset = "0x5716340", VA = "0x185717740")]
		[MethodImpl(256)]
		public static explicit operator float3x3(double3x3 v)
		{
			return default(float3x3);
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0001A6B8 File Offset: 0x000188B8
		[Token(Token = "0x600125B")]
		[Address(RVA = "0x57B8230", Offset = "0x57B6E30", VA = "0x1857B8230")]
		[MethodImpl(256)]
		public static float3x3 operator *(float3x3 lhs, float3x3 rhs)
		{
			return default(float3x3);
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0001A6D0 File Offset: 0x000188D0
		[Token(Token = "0x600125C")]
		[Address(RVA = "0x57B8440", Offset = "0x57B7040", VA = "0x1857B8440")]
		[MethodImpl(256)]
		public static float3x3 operator *(float3x3 lhs, float rhs)
		{
			return default(float3x3);
		}

		// Token: 0x0600125D RID: 4701 RVA: 0x0001A6E8 File Offset: 0x000188E8
		[Token(Token = "0x600125D")]
		[Address(RVA = "0x57B8350", Offset = "0x57B6F50", VA = "0x1857B8350")]
		[MethodImpl(256)]
		public static float3x3 operator *(float lhs, float3x3 rhs)
		{
			return default(float3x3);
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0001A700 File Offset: 0x00018900
		[Token(Token = "0x600125E")]
		[Address(RVA = "0x57B6320", Offset = "0x57B4F20", VA = "0x1857B6320")]
		[MethodImpl(256)]
		public static float3x3 operator +(float3x3 lhs, float3x3 rhs)
		{
			return default(float3x3);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0001A718 File Offset: 0x00018918
		[Token(Token = "0x600125F")]
		[Address(RVA = "0x57B6230", Offset = "0x57B4E30", VA = "0x1857B6230")]
		[MethodImpl(256)]
		public static float3x3 operator +(float3x3 lhs, float rhs)
		{
			return default(float3x3);
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0001A730 File Offset: 0x00018930
		[Token(Token = "0x6001260")]
		[Address(RVA = "0x57B6440", Offset = "0x57B5040", VA = "0x1857B6440")]
		[MethodImpl(256)]
		public static float3x3 operator +(float lhs, float3x3 rhs)
		{
			return default(float3x3);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0001A748 File Offset: 0x00018948
		[Token(Token = "0x6001261")]
		[Address(RVA = "0x57B8530", Offset = "0x57B7130", VA = "0x1857B8530")]
		[MethodImpl(256)]
		public static float3x3 operator -(float3x3 lhs, float3x3 rhs)
		{
			return default(float3x3);
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0001A760 File Offset: 0x00018960
		[Token(Token = "0x6001262")]
		[Address(RVA = "0x57B8640", Offset = "0x57B7240", VA = "0x1857B8640")]
		[MethodImpl(256)]
		public static float3x3 operator -(float3x3 lhs, float rhs)
		{
			return default(float3x3);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0001A778 File Offset: 0x00018978
		[Token(Token = "0x6001263")]
		[Address(RVA = "0x57B8730", Offset = "0x57B7330", VA = "0x1857B8730")]
		[MethodImpl(256)]
		public static float3x3 operator -(float lhs, float3x3 rhs)
		{
			return default(float3x3);
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x0001A790 File Offset: 0x00018990
		[Token(Token = "0x6001264")]
		[Address(RVA = "0x57B6620", Offset = "0x57B5220", VA = "0x1857B6620")]
		[MethodImpl(256)]
		public static float3x3 operator /(float3x3 lhs, float3x3 rhs)
		{
			return default(float3x3);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x0001A7A8 File Offset: 0x000189A8
		[Token(Token = "0x6001265")]
		[Address(RVA = "0x57B6830", Offset = "0x57B5430", VA = "0x1857B6830")]
		[MethodImpl(256)]
		public static float3x3 operator /(float3x3 lhs, float rhs)
		{
			return default(float3x3);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x0001A7C0 File Offset: 0x000189C0
		[Token(Token = "0x6001266")]
		[Address(RVA = "0x57B6730", Offset = "0x57B5330", VA = "0x1857B6730")]
		[MethodImpl(256)]
		public static float3x3 operator /(float lhs, float3x3 rhs)
		{
			return default(float3x3);
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0001A7D8 File Offset: 0x000189D8
		[Token(Token = "0x6001267")]
		[Address(RVA = "0x57B7F20", Offset = "0x57B6B20", VA = "0x1857B7F20")]
		[MethodImpl(256)]
		public static float3x3 operator %(float3x3 lhs, float3x3 rhs)
		{
			return default(float3x3);
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x0001A7F0 File Offset: 0x000189F0
		[Token(Token = "0x6001268")]
		[Address(RVA = "0x57B80C0", Offset = "0x57B6CC0", VA = "0x1857B80C0")]
		[MethodImpl(256)]
		public static float3x3 operator %(float3x3 lhs, float rhs)
		{
			return default(float3x3);
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0001A808 File Offset: 0x00018A08
		[Token(Token = "0x6001269")]
		[Address(RVA = "0x57B7DB0", Offset = "0x57B69B0", VA = "0x1857B7DB0")]
		[MethodImpl(256)]
		public static float3x3 operator %(float lhs, float3x3 rhs)
		{
			return default(float3x3);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0001A820 File Offset: 0x00018A20
		[Token(Token = "0x600126A")]
		[Address(RVA = "0x57B73C0", Offset = "0x57B5FC0", VA = "0x1857B73C0")]
		[MethodImpl(256)]
		public static float3x3 operator ++(float3x3 val)
		{
			return default(float3x3);
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x0001A838 File Offset: 0x00018A38
		[Token(Token = "0x600126B")]
		[Address(RVA = "0x57B6530", Offset = "0x57B5130", VA = "0x1857B6530")]
		[MethodImpl(256)]
		public static float3x3 operator --(float3x3 val)
		{
			return default(float3x3);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0001A850 File Offset: 0x00018A50
		[Token(Token = "0x600126C")]
		[Address(RVA = "0x57B7CA0", Offset = "0x57B68A0", VA = "0x1857B7CA0")]
		[MethodImpl(256)]
		public static bool3x3 operator <(float3x3 lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0001A868 File Offset: 0x00018A68
		[Token(Token = "0x600126D")]
		[Address(RVA = "0x57B7B00", Offset = "0x57B6700", VA = "0x1857B7B00")]
		[MethodImpl(256)]
		public static bool3x3 operator <(float3x3 lhs, float rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x0001A880 File Offset: 0x00018A80
		[Token(Token = "0x600126E")]
		[Address(RVA = "0x57B7BC0", Offset = "0x57B67C0", VA = "0x1857B7BC0")]
		[MethodImpl(256)]
		public static bool3x3 operator <(float lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0001A898 File Offset: 0x00018A98
		[Token(Token = "0x600126F")]
		[Address(RVA = "0x57B7930", Offset = "0x57B6530", VA = "0x1857B7930")]
		[MethodImpl(256)]
		public static bool3x3 operator <=(float3x3 lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0001A8B0 File Offset: 0x00018AB0
		[Token(Token = "0x6001270")]
		[Address(RVA = "0x57B7A40", Offset = "0x57B6640", VA = "0x1857B7A40")]
		[MethodImpl(256)]
		public static bool3x3 operator <=(float3x3 lhs, float rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0001A8C8 File Offset: 0x00018AC8
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x57B7850", Offset = "0x57B6450", VA = "0x1857B7850")]
		[MethodImpl(256)]
		public static bool3x3 operator <=(float lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0001A8E0 File Offset: 0x00018AE0
		[Token(Token = "0x6001272")]
		[Address(RVA = "0x57B7140", Offset = "0x57B5D40", VA = "0x1857B7140")]
		[MethodImpl(256)]
		public static bool3x3 operator >(float3x3 lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		[Token(Token = "0x6001273")]
		[Address(RVA = "0x57B7070", Offset = "0x57B5C70", VA = "0x1857B7070")]
		[MethodImpl(256)]
		public static bool3x3 operator >(float3x3 lhs, float rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0001A910 File Offset: 0x00018B10
		[Token(Token = "0x6001274")]
		[Address(RVA = "0x57B7250", Offset = "0x57B5E50", VA = "0x1857B7250")]
		[MethodImpl(256)]
		public static bool3x3 operator >(float lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0001A928 File Offset: 0x00018B28
		[Token(Token = "0x6001275")]
		[Address(RVA = "0x57B6E90", Offset = "0x57B5A90", VA = "0x1857B6E90")]
		[MethodImpl(256)]
		public static bool3x3 operator >=(float3x3 lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0001A940 File Offset: 0x00018B40
		[Token(Token = "0x6001276")]
		[Address(RVA = "0x57B6DC0", Offset = "0x57B59C0", VA = "0x1857B6DC0")]
		[MethodImpl(256)]
		public static bool3x3 operator >=(float3x3 lhs, float rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0001A958 File Offset: 0x00018B58
		[Token(Token = "0x6001277")]
		[Address(RVA = "0x57B6FA0", Offset = "0x57B5BA0", VA = "0x1857B6FA0")]
		[MethodImpl(256)]
		public static bool3x3 operator >=(float lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0001A970 File Offset: 0x00018B70
		[Token(Token = "0x6001278")]
		[Address(RVA = "0x57B8830", Offset = "0x57B7430", VA = "0x1857B8830")]
		[MethodImpl(256)]
		public static float3x3 operator -(float3x3 val)
		{
			return default(float3x3);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0001A988 File Offset: 0x00018B88
		[Token(Token = "0x6001279")]
		[Address(RVA = "0x57B8910", Offset = "0x57B7510", VA = "0x1857B8910")]
		[MethodImpl(256)]
		public static float3x3 operator +(float3x3 val)
		{
			return default(float3x3);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0001A9A0 File Offset: 0x00018BA0
		[Token(Token = "0x600127A")]
		[Address(RVA = "0x57B6B60", Offset = "0x57B5760", VA = "0x1857B6B60")]
		[MethodImpl(256)]
		public static bool3x3 operator ==(float3x3 lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0001A9B8 File Offset: 0x00018BB8
		[Token(Token = "0x600127B")]
		[Address(RVA = "0x57B6A30", Offset = "0x57B5630", VA = "0x1857B6A30")]
		[MethodImpl(256)]
		public static bool3x3 operator ==(float3x3 lhs, float rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0001A9D0 File Offset: 0x00018BD0
		[Token(Token = "0x600127C")]
		[Address(RVA = "0x57B6920", Offset = "0x57B5520", VA = "0x1857B6920")]
		[MethodImpl(256)]
		public static bool3x3 operator ==(float lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0001A9E8 File Offset: 0x00018BE8
		[Token(Token = "0x600127D")]
		[Address(RVA = "0x57B76F0", Offset = "0x57B62F0", VA = "0x1857B76F0")]
		[MethodImpl(256)]
		public static bool3x3 operator !=(float3x3 lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0001AA00 File Offset: 0x00018C00
		[Token(Token = "0x600127E")]
		[Address(RVA = "0x57B75C0", Offset = "0x57B61C0", VA = "0x1857B75C0")]
		[MethodImpl(256)]
		public static bool3x3 operator !=(float3x3 lhs, float rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0001AA18 File Offset: 0x00018C18
		[Token(Token = "0x600127F")]
		[Address(RVA = "0x57B74B0", Offset = "0x57B60B0", VA = "0x1857B74B0")]
		[MethodImpl(256)]
		public static bool3x3 operator !=(float lhs, float3x3 rhs)
		{
			return default(bool3x3);
		}

		// Token: 0x17000472 RID: 1138
		[Token(Token = "0x17000472")]
		public float3 this[int index]
		{
			[Token(Token = "0x6001280")]
			[Address(RVA = "0x3D281B0", Offset = "0x3D26DB0", VA = "0x183D281B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0001AA30 File Offset: 0x00018C30
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x57A7870", Offset = "0x57A6470", VA = "0x1857A7870", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(float3x3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0001AA48 File Offset: 0x00018C48
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x57B4200", Offset = "0x57B2E00", VA = "0x1857B4200", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0001AA60 File Offset: 0x00018C60
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x57B48A0", Offset = "0x57B34A0", VA = "0x1857B48A0", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x57B52B0", Offset = "0x57B3EB0", VA = "0x1857B52B0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001285")]
		[Address(RVA = "0x57B56C0", Offset = "0x57B42C0", VA = "0x1857B56C0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001286")]
		[Address(RVA = "0x57B5C90", Offset = "0x57B4890", VA = "0x1857B5C90")]
		public float3x3(float4x4 f4x4)
		{
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001287")]
		[Address(RVA = "0x57B5E60", Offset = "0x57B4A60", VA = "0x1857B5E60")]
		public float3x3(quaternion q)
		{
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0001AA78 File Offset: 0x00018C78
		[Token(Token = "0x6001288")]
		[Address(RVA = "0x57B3E80", Offset = "0x57B2A80", VA = "0x1857B3E80")]
		[MethodImpl(256)]
		public static float3x3 AxisAngle(float3 axis, float angle)
		{
			return default(float3x3);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0001AA90 File Offset: 0x00018C90
		[Token(Token = "0x6001289")]
		[Address(RVA = "0x57A7940", Offset = "0x57A6540", VA = "0x1857A7940")]
		[MethodImpl(256)]
		public static float3x3 EulerXYZ(float3 xyz)
		{
			return default(float3x3);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0001AAA8 File Offset: 0x00018CA8
		[Token(Token = "0x600128A")]
		[Address(RVA = "0x57A7AF0", Offset = "0x57A66F0", VA = "0x1857A7AF0")]
		[MethodImpl(256)]
		public static float3x3 EulerXZY(float3 xyz)
		{
			return default(float3x3);
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		[Token(Token = "0x600128B")]
		[Address(RVA = "0x57A7CA0", Offset = "0x57A68A0", VA = "0x1857A7CA0")]
		[MethodImpl(256)]
		public static float3x3 EulerYXZ(float3 xyz)
		{
			return default(float3x3);
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0001AAD8 File Offset: 0x00018CD8
		[Token(Token = "0x600128C")]
		[Address(RVA = "0x57A7E60", Offset = "0x57A6A60", VA = "0x1857A7E60")]
		[MethodImpl(256)]
		public static float3x3 EulerYZX(float3 xyz)
		{
			return default(float3x3);
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0001AAF0 File Offset: 0x00018CF0
		[Token(Token = "0x600128D")]
		[Address(RVA = "0x57A7FF0", Offset = "0x57A6BF0", VA = "0x1857A7FF0")]
		[MethodImpl(256)]
		public static float3x3 EulerZXY(float3 xyz)
		{
			return default(float3x3);
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0001AB08 File Offset: 0x00018D08
		[Token(Token = "0x600128E")]
		[Address(RVA = "0x57A8190", Offset = "0x57A6D90", VA = "0x1857A8190")]
		[MethodImpl(256)]
		public static float3x3 EulerZYX(float3 xyz)
		{
			return default(float3x3);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0001AB20 File Offset: 0x00018D20
		[Token(Token = "0x600128F")]
		[Address(RVA = "0x57B42B0", Offset = "0x57B2EB0", VA = "0x1857B42B0")]
		[MethodImpl(256)]
		public static float3x3 EulerXYZ(float x, float y, float z)
		{
			return default(float3x3);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0001AB38 File Offset: 0x00018D38
		[Token(Token = "0x6001290")]
		[Address(RVA = "0x57B4310", Offset = "0x57B2F10", VA = "0x1857B4310")]
		[MethodImpl(256)]
		public static float3x3 EulerXZY(float x, float y, float z)
		{
			return default(float3x3);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0001AB50 File Offset: 0x00018D50
		[Token(Token = "0x6001291")]
		[Address(RVA = "0x57B4370", Offset = "0x57B2F70", VA = "0x1857B4370")]
		[MethodImpl(256)]
		public static float3x3 EulerYXZ(float x, float y, float z)
		{
			return default(float3x3);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0001AB68 File Offset: 0x00018D68
		[Token(Token = "0x6001292")]
		[Address(RVA = "0x57B43D0", Offset = "0x57B2FD0", VA = "0x1857B43D0")]
		[MethodImpl(256)]
		public static float3x3 EulerYZX(float x, float y, float z)
		{
			return default(float3x3);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0001AB80 File Offset: 0x00018D80
		[Token(Token = "0x6001293")]
		[Address(RVA = "0x57B4430", Offset = "0x57B3030", VA = "0x1857B4430")]
		[MethodImpl(256)]
		public static float3x3 EulerZXY(float x, float y, float z)
		{
			return default(float3x3);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0001AB98 File Offset: 0x00018D98
		[Token(Token = "0x6001294")]
		[Address(RVA = "0x57B4490", Offset = "0x57B3090", VA = "0x1857B4490")]
		[MethodImpl(256)]
		public static float3x3 EulerZYX(float x, float y, float z)
		{
			return default(float3x3);
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0001ABB0 File Offset: 0x00018DB0
		[Token(Token = "0x6001295")]
		[Address(RVA = "0x57B46E0", Offset = "0x57B32E0", VA = "0x1857B46E0")]
		[MethodImpl(256)]
		public static float3x3 Euler(float3 xyz, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default(float3x3);
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0001ABC8 File Offset: 0x00018DC8
		[Token(Token = "0x6001296")]
		[Address(RVA = "0x57B44F0", Offset = "0x57B30F0", VA = "0x1857B44F0")]
		[MethodImpl(256)]
		public static float3x3 Euler(float x, float y, float z, math.RotationOrder order = math.RotationOrder.ZXY)
		{
			return default(float3x3);
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0001ABE0 File Offset: 0x00018DE0
		[Token(Token = "0x6001297")]
		[Address(RVA = "0x57B4E60", Offset = "0x57B3A60", VA = "0x1857B4E60")]
		[MethodImpl(256)]
		public static float3x3 RotateX(float angle)
		{
			return default(float3x3);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		[Token(Token = "0x6001298")]
		[Address(RVA = "0x57B4F60", Offset = "0x57B3B60", VA = "0x1857B4F60")]
		[MethodImpl(256)]
		public static float3x3 RotateY(float angle)
		{
			return default(float3x3);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0001AC10 File Offset: 0x00018E10
		[Token(Token = "0x6001299")]
		[Address(RVA = "0x57B5090", Offset = "0x57B3C90", VA = "0x1857B5090")]
		[MethodImpl(256)]
		public static float3x3 RotateZ(float angle)
		{
			return default(float3x3);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0001AC28 File Offset: 0x00018E28
		[Token(Token = "0x600129A")]
		[Address(RVA = "0x57B5250", Offset = "0x57B3E50", VA = "0x1857B5250")]
		[MethodImpl(256)]
		public static float3x3 Scale(float s)
		{
			return default(float3x3);
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0001AC40 File Offset: 0x00018E40
		[Token(Token = "0x600129B")]
		[Address(RVA = "0x57B51A0", Offset = "0x57B3DA0", VA = "0x1857B51A0")]
		[MethodImpl(256)]
		public static float3x3 Scale(float x, float y, float z)
		{
			return default(float3x3);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x0001AC58 File Offset: 0x00018E58
		[Token(Token = "0x600129C")]
		[Address(RVA = "0x57B51F0", Offset = "0x57B3DF0", VA = "0x1857B51F0")]
		[MethodImpl(256)]
		public static float3x3 Scale(float3 v)
		{
			return default(float3x3);
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x0001AC70 File Offset: 0x00018E70
		[Token(Token = "0x600129D")]
		[Address(RVA = "0x57B4CB0", Offset = "0x57B38B0", VA = "0x1857B4CB0")]
		[MethodImpl(256)]
		public static float3x3 LookRotation(float3 forward, float3 up)
		{
			return default(float3x3);
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0001AC88 File Offset: 0x00018E88
		[Token(Token = "0x600129E")]
		[Address(RVA = "0x57B48D0", Offset = "0x57B34D0", VA = "0x1857B48D0")]
		[MethodImpl(256)]
		public static float3x3 LookRotationSafe(float3 forward, float3 up)
		{
			return default(float3x3);
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0001ACA0 File Offset: 0x00018EA0
		[Token(Token = "0x600129F")]
		[Address(RVA = "0x57B6CC0", Offset = "0x57B58C0", VA = "0x1857B6CC0")]
		public static explicit operator float3x3(float4x4 f4x4)
		{
			return default(float3x3);
		}

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x0")]
		public float3 c0;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0xC")]
		public float3 c1;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x18")]
		public float3 c2;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float3x3 identity;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x24")]
		public static readonly float3x3 zero;
	}
}
