using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(uint2.DebuggerProxy))]
	[Serializable]
	public struct uint2 : IEquatable<uint2>, IFormattable
	{
		// Token: 0x06001E95 RID: 7829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E95")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		[MethodImpl(256)]
		public uint2(uint x, uint y)
		{
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E96")]
		[Address(RVA = "0x576D820", Offset = "0x576C420", VA = "0x18576D820")]
		[MethodImpl(256)]
		public uint2(uint2 xy)
		{
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E97")]
		[Address(RVA = "0x57D6BF0", Offset = "0x57D57F0", VA = "0x1857D6BF0")]
		[MethodImpl(256)]
		public uint2(uint v)
		{
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E98")]
		[Address(RVA = "0x57D6C10", Offset = "0x57D5810", VA = "0x1857D6C10")]
		[MethodImpl(256)]
		public uint2(bool v)
		{
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E99")]
		[Address(RVA = "0x57D6C50", Offset = "0x57D5850", VA = "0x1857D6C50")]
		[MethodImpl(256)]
		public uint2(bool2 v)
		{
		}

		// Token: 0x06001E9A RID: 7834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9A")]
		[Address(RVA = "0x57D6BF0", Offset = "0x57D57F0", VA = "0x1857D6BF0")]
		[MethodImpl(256)]
		public uint2(int v)
		{
		}

		// Token: 0x06001E9B RID: 7835 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9B")]
		[Address(RVA = "0x576D820", Offset = "0x576C420", VA = "0x18576D820")]
		[MethodImpl(256)]
		public uint2(int2 v)
		{
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x58110D0", Offset = "0x580FCD0", VA = "0x1858110D0")]
		[MethodImpl(256)]
		public uint2(float v)
		{
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x5811100", Offset = "0x580FD00", VA = "0x185811100")]
		[MethodImpl(256)]
		public uint2(float2 v)
		{
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x58110A0", Offset = "0x580FCA0", VA = "0x1858110A0")]
		[MethodImpl(256)]
		public uint2(double v)
		{
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E9F")]
		[Address(RVA = "0x5811140", Offset = "0x580FD40", VA = "0x185811140")]
		[MethodImpl(256)]
		public uint2(double2 v)
		{
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x000298B0 File Offset: 0x00027AB0
		[Token(Token = "0x6001EA0")]
		[Address(RVA = "0x57288C0", Offset = "0x57274C0", VA = "0x1857288C0")]
		[MethodImpl(256)]
		public static implicit operator uint2(uint v)
		{
			return default(uint2);
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x000298C8 File Offset: 0x00027AC8
		[Token(Token = "0x6001EA1")]
		[Address(RVA = "0x5728860", Offset = "0x5727460", VA = "0x185728860")]
		[MethodImpl(256)]
		public static explicit operator uint2(bool v)
		{
			return default(uint2);
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x000298E0 File Offset: 0x00027AE0
		[Token(Token = "0x6001EA2")]
		[Address(RVA = "0x57288A0", Offset = "0x57274A0", VA = "0x1857288A0")]
		[MethodImpl(256)]
		public static explicit operator uint2(bool2 v)
		{
			return default(uint2);
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x000298F8 File Offset: 0x00027AF8
		[Token(Token = "0x6001EA3")]
		[Address(RVA = "0x57288C0", Offset = "0x57274C0", VA = "0x1857288C0")]
		[MethodImpl(256)]
		public static explicit operator uint2(int v)
		{
			return default(uint2);
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00029910 File Offset: 0x00027B10
		[Token(Token = "0x6001EA4")]
		[Address(RVA = "0x5707920", Offset = "0x5706520", VA = "0x185707920")]
		[MethodImpl(256)]
		public static explicit operator uint2(int2 v)
		{
			return default(uint2);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00029928 File Offset: 0x00027B28
		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0x5753380", Offset = "0x5751F80", VA = "0x185753380")]
		[MethodImpl(256)]
		public static explicit operator uint2(float v)
		{
			return default(uint2);
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00029940 File Offset: 0x00027B40
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x57533C0", Offset = "0x5751FC0", VA = "0x1857533C0")]
		[MethodImpl(256)]
		public static explicit operator uint2(float2 v)
		{
			return default(uint2);
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00029958 File Offset: 0x00027B58
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x5753340", Offset = "0x5751F40", VA = "0x185753340")]
		[MethodImpl(256)]
		public static explicit operator uint2(double v)
		{
			return default(uint2);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00029970 File Offset: 0x00027B70
		[Token(Token = "0x6001EA8")]
		[Address(RVA = "0x57532E0", Offset = "0x5751EE0", VA = "0x1857532E0")]
		[MethodImpl(256)]
		public static explicit operator uint2(double2 v)
		{
			return default(uint2);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x00029988 File Offset: 0x00027B88
		[Token(Token = "0x6001EA9")]
		[Address(RVA = "0x57D71B0", Offset = "0x57D5DB0", VA = "0x1857D71B0")]
		[MethodImpl(256)]
		public static uint2 operator *(uint2 lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x000299A0 File Offset: 0x00027BA0
		[Token(Token = "0x6001EAA")]
		[Address(RVA = "0x1DED520", Offset = "0x1DEC120", VA = "0x181DED520")]
		[MethodImpl(256)]
		public static uint2 operator *(uint2 lhs, uint rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x000299B8 File Offset: 0x00027BB8
		[Token(Token = "0x6001EAB")]
		[Address(RVA = "0x1DED570", Offset = "0x1DEC170", VA = "0x181DED570")]
		[MethodImpl(256)]
		public static uint2 operator *(uint lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x000299D0 File Offset: 0x00027BD0
		[Token(Token = "0x6001EAC")]
		[Address(RVA = "0x1DED430", Offset = "0x1DEC030", VA = "0x181DED430")]
		[MethodImpl(256)]
		public static uint2 operator +(uint2 lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x000299E8 File Offset: 0x00027BE8
		[Token(Token = "0x6001EAD")]
		[Address(RVA = "0x57D6CA0", Offset = "0x57D58A0", VA = "0x1857D6CA0")]
		[MethodImpl(256)]
		public static uint2 operator +(uint2 lhs, uint rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00029A00 File Offset: 0x00027C00
		[Token(Token = "0x6001EAE")]
		[Address(RVA = "0x57D6C80", Offset = "0x57D5880", VA = "0x1857D6C80")]
		[MethodImpl(256)]
		public static uint2 operator +(uint lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00029A18 File Offset: 0x00027C18
		[Token(Token = "0x6001EAF")]
		[Address(RVA = "0x1DED590", Offset = "0x1DEC190", VA = "0x181DED590")]
		[MethodImpl(256)]
		public static uint2 operator -(uint2 lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00029A30 File Offset: 0x00027C30
		[Token(Token = "0x6001EB0")]
		[Address(RVA = "0x57D7240", Offset = "0x57D5E40", VA = "0x1857D7240")]
		[MethodImpl(256)]
		public static uint2 operator -(uint2 lhs, uint rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00029A48 File Offset: 0x00027C48
		[Token(Token = "0x6001EB1")]
		[Address(RVA = "0x57D7220", Offset = "0x57D5E20", VA = "0x1857D7220")]
		[MethodImpl(256)]
		public static uint2 operator -(uint lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00029A60 File Offset: 0x00027C60
		[Token(Token = "0x6001EB2")]
		[Address(RVA = "0x58111B0", Offset = "0x580FDB0", VA = "0x1858111B0")]
		[MethodImpl(256)]
		public static uint2 operator /(uint2 lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00029A78 File Offset: 0x00027C78
		[Token(Token = "0x6001EB3")]
		[Address(RVA = "0x58111E0", Offset = "0x580FDE0", VA = "0x1858111E0")]
		[MethodImpl(256)]
		public static uint2 operator /(uint2 lhs, uint rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00029A90 File Offset: 0x00027C90
		[Token(Token = "0x6001EB4")]
		[Address(RVA = "0x5811180", Offset = "0x580FD80", VA = "0x185811180")]
		[MethodImpl(256)]
		public static uint2 operator /(uint lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EB5 RID: 7861 RVA: 0x00029AA8 File Offset: 0x00027CA8
		[Token(Token = "0x6001EB5")]
		[Address(RVA = "0x58113F0", Offset = "0x580FFF0", VA = "0x1858113F0")]
		[MethodImpl(256)]
		public static uint2 operator %(uint2 lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EB6 RID: 7862 RVA: 0x00029AC0 File Offset: 0x00027CC0
		[Token(Token = "0x6001EB6")]
		[Address(RVA = "0x58113C0", Offset = "0x580FFC0", VA = "0x1858113C0")]
		[MethodImpl(256)]
		public static uint2 operator %(uint2 lhs, uint rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00029AD8 File Offset: 0x00027CD8
		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x5811390", Offset = "0x580FF90", VA = "0x185811390")]
		[MethodImpl(256)]
		public static uint2 operator %(uint lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00029AF0 File Offset: 0x00027CF0
		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x57D6FB0", Offset = "0x57D5BB0", VA = "0x1857D6FB0")]
		[MethodImpl(256)]
		public static uint2 operator ++(uint2 val)
		{
			return default(uint2);
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00029B08 File Offset: 0x00027D08
		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x57D6D80", Offset = "0x57D5980", VA = "0x1857D6D80")]
		[MethodImpl(256)]
		public static uint2 operator --(uint2 val)
		{
			return default(uint2);
		}

		// Token: 0x06001EBA RID: 7866 RVA: 0x00029B20 File Offset: 0x00027D20
		[Token(Token = "0x6001EBA")]
		[Address(RVA = "0x5811330", Offset = "0x580FF30", VA = "0x185811330")]
		[MethodImpl(256)]
		public static bool2 operator <(uint2 lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EBB RID: 7867 RVA: 0x00029B38 File Offset: 0x00027D38
		[Token(Token = "0x6001EBB")]
		[Address(RVA = "0x5811370", Offset = "0x580FF70", VA = "0x185811370")]
		[MethodImpl(256)]
		public static bool2 operator <(uint2 lhs, uint rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EBC RID: 7868 RVA: 0x00029B50 File Offset: 0x00027D50
		[Token(Token = "0x6001EBC")]
		[Address(RVA = "0x5811350", Offset = "0x580FF50", VA = "0x185811350")]
		[MethodImpl(256)]
		public static bool2 operator <(uint lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x00029B68 File Offset: 0x00027D68
		[Token(Token = "0x6001EBD")]
		[Address(RVA = "0x58112F0", Offset = "0x580FEF0", VA = "0x1858112F0")]
		[MethodImpl(256)]
		public static bool2 operator <=(uint2 lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00029B80 File Offset: 0x00027D80
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x5811310", Offset = "0x580FF10", VA = "0x185811310")]
		[MethodImpl(256)]
		public static bool2 operator <=(uint2 lhs, uint rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x00029B98 File Offset: 0x00027D98
		[Token(Token = "0x6001EBF")]
		[Address(RVA = "0x58112D0", Offset = "0x580FED0", VA = "0x1858112D0")]
		[MethodImpl(256)]
		public static bool2 operator <=(uint lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EC0 RID: 7872 RVA: 0x00029BB0 File Offset: 0x00027DB0
		[Token(Token = "0x6001EC0")]
		[Address(RVA = "0x5811290", Offset = "0x580FE90", VA = "0x185811290")]
		[MethodImpl(256)]
		public static bool2 operator >(uint2 lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EC1 RID: 7873 RVA: 0x00029BC8 File Offset: 0x00027DC8
		[Token(Token = "0x6001EC1")]
		[Address(RVA = "0x58112B0", Offset = "0x580FEB0", VA = "0x1858112B0")]
		[MethodImpl(256)]
		public static bool2 operator >(uint2 lhs, uint rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EC2 RID: 7874 RVA: 0x00029BE0 File Offset: 0x00027DE0
		[Token(Token = "0x6001EC2")]
		[Address(RVA = "0x5811270", Offset = "0x580FE70", VA = "0x185811270")]
		[MethodImpl(256)]
		public static bool2 operator >(uint lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00029BF8 File Offset: 0x00027DF8
		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0x5811210", Offset = "0x580FE10", VA = "0x185811210")]
		[MethodImpl(256)]
		public static bool2 operator >=(uint2 lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00029C10 File Offset: 0x00027E10
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0x5811230", Offset = "0x580FE30", VA = "0x185811230")]
		[MethodImpl(256)]
		public static bool2 operator >=(uint2 lhs, uint rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00029C28 File Offset: 0x00027E28
		[Token(Token = "0x6001EC5")]
		[Address(RVA = "0x5811250", Offset = "0x580FE50", VA = "0x185811250")]
		[MethodImpl(256)]
		public static bool2 operator >=(uint lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00029C40 File Offset: 0x00027E40
		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0x1DED5B0", Offset = "0x1DEC1B0", VA = "0x181DED5B0")]
		[MethodImpl(256)]
		public static uint2 operator -(uint2 val)
		{
			return default(uint2);
		}

		// Token: 0x06001EC7 RID: 7879 RVA: 0x00029C58 File Offset: 0x00027E58
		[Token(Token = "0x6001EC7")]
		[Address(RVA = "0x5707920", Offset = "0x5706520", VA = "0x185707920")]
		[MethodImpl(256)]
		public static uint2 operator +(uint2 val)
		{
			return default(uint2);
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x00029C70 File Offset: 0x00027E70
		[Token(Token = "0x6001EC8")]
		[Address(RVA = "0x57D7030", Offset = "0x57D5C30", VA = "0x1857D7030")]
		[MethodImpl(256)]
		public static uint2 operator <<(uint2 x, int n)
		{
			return default(uint2);
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x00029C88 File Offset: 0x00027E88
		[Token(Token = "0x6001EC9")]
		[Address(RVA = "0x5811420", Offset = "0x5810020", VA = "0x185811420")]
		[MethodImpl(256)]
		public static uint2 operator >>(uint2 x, int n)
		{
			return default(uint2);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x00029CA0 File Offset: 0x00027EA0
		[Token(Token = "0x6001ECA")]
		[Address(RVA = "0x57D6E50", Offset = "0x57D5A50", VA = "0x1857D6E50")]
		[MethodImpl(256)]
		public static bool2 operator ==(uint2 lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x00029CB8 File Offset: 0x00027EB8
		[Token(Token = "0x6001ECB")]
		[Address(RVA = "0x57D6E70", Offset = "0x57D5A70", VA = "0x1857D6E70")]
		[MethodImpl(256)]
		public static bool2 operator ==(uint2 lhs, uint rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00029CD0 File Offset: 0x00027ED0
		[Token(Token = "0x6001ECC")]
		[Address(RVA = "0x57D6E30", Offset = "0x57D5A30", VA = "0x1857D6E30")]
		[MethodImpl(256)]
		public static bool2 operator ==(uint lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00029CE8 File Offset: 0x00027EE8
		[Token(Token = "0x6001ECD")]
		[Address(RVA = "0x57D6FD0", Offset = "0x57D5BD0", VA = "0x1857D6FD0")]
		[MethodImpl(256)]
		public static bool2 operator !=(uint2 lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00029D00 File Offset: 0x00027F00
		[Token(Token = "0x6001ECE")]
		[Address(RVA = "0x57D6FF0", Offset = "0x57D5BF0", VA = "0x1857D6FF0")]
		[MethodImpl(256)]
		public static bool2 operator !=(uint2 lhs, uint rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00029D18 File Offset: 0x00027F18
		[Token(Token = "0x6001ECF")]
		[Address(RVA = "0x57D7010", Offset = "0x57D5C10", VA = "0x1857D7010")]
		[MethodImpl(256)]
		public static bool2 operator !=(uint lhs, uint2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00029D30 File Offset: 0x00027F30
		[Token(Token = "0x6001ED0")]
		[Address(RVA = "0x57D71D0", Offset = "0x57D5DD0", VA = "0x1857D71D0")]
		[MethodImpl(256)]
		public static uint2 operator ~(uint2 val)
		{
			return default(uint2);
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x00029D48 File Offset: 0x00027F48
		[Token(Token = "0x6001ED1")]
		[Address(RVA = "0x57D6D00", Offset = "0x57D5900", VA = "0x1857D6D00")]
		[MethodImpl(256)]
		public static uint2 operator &(uint2 lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x00029D60 File Offset: 0x00027F60
		[Token(Token = "0x6001ED2")]
		[Address(RVA = "0x57D6CC0", Offset = "0x57D58C0", VA = "0x1857D6CC0")]
		[MethodImpl(256)]
		public static uint2 operator &(uint2 lhs, uint rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x00029D78 File Offset: 0x00027F78
		[Token(Token = "0x6001ED3")]
		[Address(RVA = "0x57D6CE0", Offset = "0x57D58E0", VA = "0x1857D6CE0")]
		[MethodImpl(256)]
		public static uint2 operator &(uint lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x00029D90 File Offset: 0x00027F90
		[Token(Token = "0x6001ED4")]
		[Address(RVA = "0x57D6D20", Offset = "0x57D5920", VA = "0x1857D6D20")]
		[MethodImpl(256)]
		public static uint2 operator |(uint2 lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x00029DA8 File Offset: 0x00027FA8
		[Token(Token = "0x6001ED5")]
		[Address(RVA = "0x57D6D60", Offset = "0x57D5960", VA = "0x1857D6D60")]
		[MethodImpl(256)]
		public static uint2 operator |(uint2 lhs, uint rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x00029DC0 File Offset: 0x00027FC0
		[Token(Token = "0x6001ED6")]
		[Address(RVA = "0x57D6D40", Offset = "0x57D5940", VA = "0x1857D6D40")]
		[MethodImpl(256)]
		public static uint2 operator |(uint lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x00029DD8 File Offset: 0x00027FD8
		[Token(Token = "0x6001ED7")]
		[Address(RVA = "0x57D6ED0", Offset = "0x57D5AD0", VA = "0x1857D6ED0")]
		[MethodImpl(256)]
		public static uint2 operator ^(uint2 lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x00029DF0 File Offset: 0x00027FF0
		[Token(Token = "0x6001ED8")]
		[Address(RVA = "0x57D6EB0", Offset = "0x57D5AB0", VA = "0x1857D6EB0")]
		[MethodImpl(256)]
		public static uint2 operator ^(uint2 lhs, uint rhs)
		{
			return default(uint2);
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x00029E08 File Offset: 0x00028008
		[Token(Token = "0x6001ED9")]
		[Address(RVA = "0x57D6E90", Offset = "0x57D5A90", VA = "0x1857D6E90")]
		[MethodImpl(256)]
		public static uint2 operator ^(uint lhs, uint2 rhs)
		{
			return default(uint2);
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x00029E20 File Offset: 0x00028020
		[Token(Token = "0x1700099D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxx
		{
			[Token(Token = "0x6001EDA")]
			[Address(RVA = "0x576B0E0", Offset = "0x5769CE0", VA = "0x18576B0E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00029E38 File Offset: 0x00028038
		[Token(Token = "0x1700099E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxy
		{
			[Token(Token = "0x6001EDB")]
			[Address(RVA = "0x576B100", Offset = "0x5769D00", VA = "0x18576B100")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06001EDC RID: 7900 RVA: 0x00029E50 File Offset: 0x00028050
		[Token(Token = "0x1700099F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyx
		{
			[Token(Token = "0x6001EDC")]
			[Address(RVA = "0x576B180", Offset = "0x5769D80", VA = "0x18576B180")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x00029E68 File Offset: 0x00028068
		[Token(Token = "0x170009A0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyy
		{
			[Token(Token = "0x6001EDD")]
			[Address(RVA = "0x576B1A0", Offset = "0x5769DA0", VA = "0x18576B1A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001EDE RID: 7902 RVA: 0x00029E80 File Offset: 0x00028080
		[Token(Token = "0x170009A1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxx
		{
			[Token(Token = "0x6001EDE")]
			[Address(RVA = "0x576B380", Offset = "0x5769F80", VA = "0x18576B380")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00029E98 File Offset: 0x00028098
		[Token(Token = "0x170009A2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxy
		{
			[Token(Token = "0x6001EDF")]
			[Address(RVA = "0x576B3A0", Offset = "0x5769FA0", VA = "0x18576B3A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001EE0 RID: 7904 RVA: 0x00029EB0 File Offset: 0x000280B0
		[Token(Token = "0x170009A3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyx
		{
			[Token(Token = "0x6001EE0")]
			[Address(RVA = "0x576B420", Offset = "0x576A020", VA = "0x18576B420")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x00029EC8 File Offset: 0x000280C8
		[Token(Token = "0x170009A4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyy
		{
			[Token(Token = "0x6001EE1")]
			[Address(RVA = "0x576B440", Offset = "0x576A040", VA = "0x18576B440")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x00029EE0 File Offset: 0x000280E0
		[Token(Token = "0x170009A5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxx
		{
			[Token(Token = "0x6001EE2")]
			[Address(RVA = "0x576BB60", Offset = "0x576A760", VA = "0x18576BB60")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x00029EF8 File Offset: 0x000280F8
		[Token(Token = "0x170009A6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxy
		{
			[Token(Token = "0x6001EE3")]
			[Address(RVA = "0x576BB80", Offset = "0x576A780", VA = "0x18576BB80")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00029F10 File Offset: 0x00028110
		[Token(Token = "0x170009A7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyx
		{
			[Token(Token = "0x6001EE4")]
			[Address(RVA = "0x576BC00", Offset = "0x576A800", VA = "0x18576BC00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00029F28 File Offset: 0x00028128
		[Token(Token = "0x170009A8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyy
		{
			[Token(Token = "0x6001EE5")]
			[Address(RVA = "0x576BC20", Offset = "0x576A820", VA = "0x18576BC20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001EE6 RID: 7910 RVA: 0x00029F40 File Offset: 0x00028140
		[Token(Token = "0x170009A9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxx
		{
			[Token(Token = "0x6001EE6")]
			[Address(RVA = "0x576BE00", Offset = "0x576AA00", VA = "0x18576BE00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x00029F58 File Offset: 0x00028158
		[Token(Token = "0x170009AA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxy
		{
			[Token(Token = "0x6001EE7")]
			[Address(RVA = "0x576BE20", Offset = "0x576AA20", VA = "0x18576BE20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x00029F70 File Offset: 0x00028170
		[Token(Token = "0x170009AB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyx
		{
			[Token(Token = "0x6001EE8")]
			[Address(RVA = "0x576BE90", Offset = "0x576AA90", VA = "0x18576BE90")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001EE9 RID: 7913 RVA: 0x00029F88 File Offset: 0x00028188
		[Token(Token = "0x170009AC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyy
		{
			[Token(Token = "0x6001EE9")]
			[Address(RVA = "0x576BEB0", Offset = "0x576AAB0", VA = "0x18576BEB0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x00029FA0 File Offset: 0x000281A0
		[Token(Token = "0x170009AD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxx
		{
			[Token(Token = "0x6001EEA")]
			[Address(RVA = "0x576B0B0", Offset = "0x5769CB0", VA = "0x18576B0B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001EEB RID: 7915 RVA: 0x00029FB8 File Offset: 0x000281B8
		[Token(Token = "0x170009AE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxy
		{
			[Token(Token = "0x6001EEB")]
			[Address(RVA = "0x576B140", Offset = "0x5769D40", VA = "0x18576B140")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001EEC RID: 7916 RVA: 0x00029FD0 File Offset: 0x000281D0
		[Token(Token = "0x170009AF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyx
		{
			[Token(Token = "0x6001EEC")]
			[Address(RVA = "0x576B340", Offset = "0x5769F40", VA = "0x18576B340")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001EED RID: 7917 RVA: 0x00029FE8 File Offset: 0x000281E8
		[Token(Token = "0x170009B0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyy
		{
			[Token(Token = "0x6001EED")]
			[Address(RVA = "0x576B3E0", Offset = "0x5769FE0", VA = "0x18576B3E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001EEE RID: 7918 RVA: 0x0002A000 File Offset: 0x00028200
		[Token(Token = "0x170009B1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxx
		{
			[Token(Token = "0x6001EEE")]
			[Address(RVA = "0x576BB20", Offset = "0x576A720", VA = "0x18576BB20")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001EEF RID: 7919 RVA: 0x0002A018 File Offset: 0x00028218
		[Token(Token = "0x170009B2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxy
		{
			[Token(Token = "0x6001EEF")]
			[Address(RVA = "0x576BBC0", Offset = "0x576A7C0", VA = "0x18576BBC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x0002A030 File Offset: 0x00028230
		[Token(Token = "0x170009B3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyx
		{
			[Token(Token = "0x6001EF0")]
			[Address(RVA = "0x576BDC0", Offset = "0x576A9C0", VA = "0x18576BDC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06001EF1 RID: 7921 RVA: 0x0002A048 File Offset: 0x00028248
		[Token(Token = "0x170009B4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyy
		{
			[Token(Token = "0x6001EF1")]
			[Address(RVA = "0x576BE60", Offset = "0x576AA60", VA = "0x18576BE60")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x0002A060 File Offset: 0x00028260
		[Token(Token = "0x170009B5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xx
		{
			[Token(Token = "0x6001EF2")]
			[Address(RVA = "0x576B000", Offset = "0x5769C00", VA = "0x18576B000")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x0002A078 File Offset: 0x00028278
		// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xy
		{
			[Token(Token = "0x6001EF3")]
			[Address(RVA = "0x576B280", Offset = "0x5769E80", VA = "0x18576B280")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x6001EF4")]
			[Address(RVA = "0x576D820", Offset = "0x576C420", VA = "0x18576D820")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06001EF5 RID: 7925 RVA: 0x0002A090 File Offset: 0x00028290
		// (set) Token: 0x06001EF6 RID: 7926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009B7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yx
		{
			[Token(Token = "0x6001EF5")]
			[Address(RVA = "0x576BA60", Offset = "0x576A660", VA = "0x18576BA60")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x6001EF6")]
			[Address(RVA = "0x576D990", Offset = "0x576C590", VA = "0x18576D990")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06001EF7 RID: 7927 RVA: 0x0002A0A8 File Offset: 0x000282A8
		[Token(Token = "0x170009B8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yy
		{
			[Token(Token = "0x6001EF7")]
			[Address(RVA = "0x576BD00", Offset = "0x576A900", VA = "0x18576BD00")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		// Token: 0x170009B9 RID: 2489
		[Token(Token = "0x170009B9")]
		public uint this[int index]
		{
			[Token(Token = "0x6001EF8")]
			[Address(RVA = "0x3D284D0", Offset = "0x3D270D0", VA = "0x183D284D0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6001EF9")]
			[Address(RVA = "0x3D288C0", Offset = "0x3D274C0", VA = "0x183D288C0")]
			set
			{
			}
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x0002A0D8 File Offset: 0x000282D8
		[Token(Token = "0x6001EFA")]
		[Address(RVA = "0x1DECC50", Offset = "0x1DEB850", VA = "0x181DECC50", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(uint2 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x0002A0F0 File Offset: 0x000282F0
		[Token(Token = "0x6001EFB")]
		[Address(RVA = "0x5810EA0", Offset = "0x580FAA0", VA = "0x185810EA0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001EFC RID: 7932 RVA: 0x0002A108 File Offset: 0x00028308
		[Token(Token = "0x6001EFC")]
		[Address(RVA = "0x5810F30", Offset = "0x580FB30", VA = "0x185810F30", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001EFD RID: 7933 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001EFD")]
		[Address(RVA = "0x5811010", Offset = "0x580FC10", VA = "0x185811010", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001EFE RID: 7934 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001EFE")]
		[Address(RVA = "0x5810F80", Offset = "0x580FB80", VA = "0x185810F80", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x0")]
		public uint x;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x4")]
		public uint y;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly uint2 zero;

		// Token: 0x02000052 RID: 82
		[Token(Token = "0x2000052")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x06001EFF RID: 7935 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001EFF")]
			[Address(RVA = "0x57D1240", Offset = "0x57CFE40", VA = "0x1857D1240")]
			public DebuggerProxy(uint2 v)
			{
			}

			// Token: 0x0400012D RID: 301
			[Token(Token = "0x400012D")]
			[FieldOffset(Offset = "0x10")]
			public uint x;

			// Token: 0x0400012E RID: 302
			[Token(Token = "0x400012E")]
			[FieldOffset(Offset = "0x14")]
			public uint y;
		}
	}
}
