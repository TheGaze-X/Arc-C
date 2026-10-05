using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(int2.DebuggerProxy))]
	[Serializable]
	public struct int2 : IEquatable<int2>, IFormattable
	{
		// Token: 0x0600182C RID: 6188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600182C")]
		[Address(RVA = "0x4F1E60", Offset = "0x4F0A60", VA = "0x1804F1E60")]
		[MethodImpl(256)]
		public int2(int x, int y)
		{
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600182D")]
		[Address(RVA = "0x576D820", Offset = "0x576C420", VA = "0x18576D820")]
		[MethodImpl(256)]
		public int2(int2 xy)
		{
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600182E")]
		[Address(RVA = "0x57D6BF0", Offset = "0x57D57F0", VA = "0x1857D6BF0")]
		[MethodImpl(256)]
		public int2(int v)
		{
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600182F")]
		[Address(RVA = "0x57D6C10", Offset = "0x57D5810", VA = "0x1857D6C10")]
		[MethodImpl(256)]
		public int2(bool v)
		{
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001830")]
		[Address(RVA = "0x57D6C50", Offset = "0x57D5850", VA = "0x1857D6C50")]
		[MethodImpl(256)]
		public int2(bool2 v)
		{
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001831")]
		[Address(RVA = "0x57D6BF0", Offset = "0x57D57F0", VA = "0x1857D6BF0")]
		[MethodImpl(256)]
		public int2(uint v)
		{
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001832")]
		[Address(RVA = "0x576D820", Offset = "0x576C420", VA = "0x18576D820")]
		[MethodImpl(256)]
		public int2(uint2 v)
		{
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001833")]
		[Address(RVA = "0x57D6C70", Offset = "0x57D5870", VA = "0x1857D6C70")]
		[MethodImpl(256)]
		public int2(float v)
		{
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001834")]
		[Address(RVA = "0x57D6C20", Offset = "0x57D5820", VA = "0x1857D6C20")]
		[MethodImpl(256)]
		public int2(float2 v)
		{
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001835")]
		[Address(RVA = "0x57D6C40", Offset = "0x57D5840", VA = "0x1857D6C40")]
		[MethodImpl(256)]
		public int2(double v)
		{
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001836")]
		[Address(RVA = "0x57D6C00", Offset = "0x57D5800", VA = "0x1857D6C00")]
		[MethodImpl(256)]
		public int2(double2 v)
		{
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x00021900 File Offset: 0x0001FB00
		[Token(Token = "0x6001837")]
		[Address(RVA = "0x57288C0", Offset = "0x57274C0", VA = "0x1857288C0")]
		[MethodImpl(256)]
		public static implicit operator int2(int v)
		{
			return default(int2);
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00021918 File Offset: 0x0001FB18
		[Token(Token = "0x6001838")]
		[Address(RVA = "0x5728860", Offset = "0x5727460", VA = "0x185728860")]
		[MethodImpl(256)]
		public static explicit operator int2(bool v)
		{
			return default(int2);
		}

		// Token: 0x06001839 RID: 6201 RVA: 0x00021930 File Offset: 0x0001FB30
		[Token(Token = "0x6001839")]
		[Address(RVA = "0x57288A0", Offset = "0x57274A0", VA = "0x1857288A0")]
		[MethodImpl(256)]
		public static explicit operator int2(bool2 v)
		{
			return default(int2);
		}

		// Token: 0x0600183A RID: 6202 RVA: 0x00021948 File Offset: 0x0001FB48
		[Token(Token = "0x600183A")]
		[Address(RVA = "0x57288C0", Offset = "0x57274C0", VA = "0x1857288C0")]
		[MethodImpl(256)]
		public static explicit operator int2(uint v)
		{
			return default(int2);
		}

		// Token: 0x0600183B RID: 6203 RVA: 0x00021960 File Offset: 0x0001FB60
		[Token(Token = "0x600183B")]
		[Address(RVA = "0x5707920", Offset = "0x5706520", VA = "0x185707920")]
		[MethodImpl(256)]
		public static explicit operator int2(uint2 v)
		{
			return default(int2);
		}

		// Token: 0x0600183C RID: 6204 RVA: 0x00021978 File Offset: 0x0001FB78
		[Token(Token = "0x600183C")]
		[Address(RVA = "0x5728880", Offset = "0x5727480", VA = "0x185728880")]
		[MethodImpl(256)]
		public static explicit operator int2(float v)
		{
			return default(int2);
		}

		// Token: 0x0600183D RID: 6205 RVA: 0x00021990 File Offset: 0x0001FB90
		[Token(Token = "0x600183D")]
		[Address(RVA = "0x5728820", Offset = "0x5727420", VA = "0x185728820")]
		[MethodImpl(256)]
		public static explicit operator int2(float2 v)
		{
			return default(int2);
		}

		// Token: 0x0600183E RID: 6206 RVA: 0x000219A8 File Offset: 0x0001FBA8
		[Token(Token = "0x600183E")]
		[Address(RVA = "0x5728840", Offset = "0x5727440", VA = "0x185728840")]
		[MethodImpl(256)]
		public static explicit operator int2(double v)
		{
			return default(int2);
		}

		// Token: 0x0600183F RID: 6207 RVA: 0x000219C0 File Offset: 0x0001FBC0
		[Token(Token = "0x600183F")]
		[Address(RVA = "0x57288D0", Offset = "0x57274D0", VA = "0x1857288D0")]
		[MethodImpl(256)]
		public static explicit operator int2(double2 v)
		{
			return default(int2);
		}

		// Token: 0x06001840 RID: 6208 RVA: 0x000219D8 File Offset: 0x0001FBD8
		[Token(Token = "0x6001840")]
		[Address(RVA = "0x57D71B0", Offset = "0x57D5DB0", VA = "0x1857D71B0")]
		[MethodImpl(256)]
		public static int2 operator *(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x06001841 RID: 6209 RVA: 0x000219F0 File Offset: 0x0001FBF0
		[Token(Token = "0x6001841")]
		[Address(RVA = "0x1DED520", Offset = "0x1DEC120", VA = "0x181DED520")]
		[MethodImpl(256)]
		public static int2 operator *(int2 lhs, int rhs)
		{
			return default(int2);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00021A08 File Offset: 0x0001FC08
		[Token(Token = "0x6001842")]
		[Address(RVA = "0x1DED570", Offset = "0x1DEC170", VA = "0x181DED570")]
		[MethodImpl(256)]
		public static int2 operator *(int lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00021A20 File Offset: 0x0001FC20
		[Token(Token = "0x6001843")]
		[Address(RVA = "0x1DED430", Offset = "0x1DEC030", VA = "0x181DED430")]
		[MethodImpl(256)]
		public static int2 operator +(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00021A38 File Offset: 0x0001FC38
		[Token(Token = "0x6001844")]
		[Address(RVA = "0x57D6CA0", Offset = "0x57D58A0", VA = "0x1857D6CA0")]
		[MethodImpl(256)]
		public static int2 operator +(int2 lhs, int rhs)
		{
			return default(int2);
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00021A50 File Offset: 0x0001FC50
		[Token(Token = "0x6001845")]
		[Address(RVA = "0x57D6C80", Offset = "0x57D5880", VA = "0x1857D6C80")]
		[MethodImpl(256)]
		public static int2 operator +(int lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00021A68 File Offset: 0x0001FC68
		[Token(Token = "0x6001846")]
		[Address(RVA = "0x1DED590", Offset = "0x1DEC190", VA = "0x181DED590")]
		[MethodImpl(256)]
		public static int2 operator -(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00021A80 File Offset: 0x0001FC80
		[Token(Token = "0x6001847")]
		[Address(RVA = "0x57D7240", Offset = "0x57D5E40", VA = "0x1857D7240")]
		[MethodImpl(256)]
		public static int2 operator -(int2 lhs, int rhs)
		{
			return default(int2);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00021A98 File Offset: 0x0001FC98
		[Token(Token = "0x6001848")]
		[Address(RVA = "0x57D7220", Offset = "0x57D5E20", VA = "0x1857D7220")]
		[MethodImpl(256)]
		public static int2 operator -(int lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x00021AB0 File Offset: 0x0001FCB0
		[Token(Token = "0x6001849")]
		[Address(RVA = "0x57D6DA0", Offset = "0x57D59A0", VA = "0x1857D6DA0")]
		[MethodImpl(256)]
		public static int2 operator /(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00021AC8 File Offset: 0x0001FCC8
		[Token(Token = "0x600184A")]
		[Address(RVA = "0x57D6E00", Offset = "0x57D5A00", VA = "0x1857D6E00")]
		[MethodImpl(256)]
		public static int2 operator /(int2 lhs, int rhs)
		{
			return default(int2);
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00021AE0 File Offset: 0x0001FCE0
		[Token(Token = "0x600184B")]
		[Address(RVA = "0x57D6DD0", Offset = "0x57D59D0", VA = "0x1857D6DD0")]
		[MethodImpl(256)]
		public static int2 operator /(int lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00021AF8 File Offset: 0x0001FCF8
		[Token(Token = "0x600184C")]
		[Address(RVA = "0x57D7180", Offset = "0x57D5D80", VA = "0x1857D7180")]
		[MethodImpl(256)]
		public static int2 operator %(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00021B10 File Offset: 0x0001FD10
		[Token(Token = "0x600184D")]
		[Address(RVA = "0x57D7150", Offset = "0x57D5D50", VA = "0x1857D7150")]
		[MethodImpl(256)]
		public static int2 operator %(int2 lhs, int rhs)
		{
			return default(int2);
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00021B28 File Offset: 0x0001FD28
		[Token(Token = "0x600184E")]
		[Address(RVA = "0x57D7120", Offset = "0x57D5D20", VA = "0x1857D7120")]
		[MethodImpl(256)]
		public static int2 operator %(int lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00021B40 File Offset: 0x0001FD40
		[Token(Token = "0x600184F")]
		[Address(RVA = "0x57D6FB0", Offset = "0x57D5BB0", VA = "0x1857D6FB0")]
		[MethodImpl(256)]
		public static int2 operator ++(int2 val)
		{
			return default(int2);
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00021B58 File Offset: 0x0001FD58
		[Token(Token = "0x6001850")]
		[Address(RVA = "0x57D6D80", Offset = "0x57D5980", VA = "0x1857D6D80")]
		[MethodImpl(256)]
		public static int2 operator --(int2 val)
		{
			return default(int2);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00021B70 File Offset: 0x0001FD70
		[Token(Token = "0x6001851")]
		[Address(RVA = "0x57D7100", Offset = "0x57D5D00", VA = "0x1857D7100")]
		[MethodImpl(256)]
		public static bool2 operator <(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00021B88 File Offset: 0x0001FD88
		[Token(Token = "0x6001852")]
		[Address(RVA = "0x57D70C0", Offset = "0x57D5CC0", VA = "0x1857D70C0")]
		[MethodImpl(256)]
		public static bool2 operator <(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00021BA0 File Offset: 0x0001FDA0
		[Token(Token = "0x6001853")]
		[Address(RVA = "0x57D70E0", Offset = "0x57D5CE0", VA = "0x1857D70E0")]
		[MethodImpl(256)]
		public static bool2 operator <(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00021BB8 File Offset: 0x0001FDB8
		[Token(Token = "0x6001854")]
		[Address(RVA = "0x57D70A0", Offset = "0x57D5CA0", VA = "0x1857D70A0")]
		[MethodImpl(256)]
		public static bool2 operator <=(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00021BD0 File Offset: 0x0001FDD0
		[Token(Token = "0x6001855")]
		[Address(RVA = "0x57D7060", Offset = "0x57D5C60", VA = "0x1857D7060")]
		[MethodImpl(256)]
		public static bool2 operator <=(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00021BE8 File Offset: 0x0001FDE8
		[Token(Token = "0x6001856")]
		[Address(RVA = "0x57D7080", Offset = "0x57D5C80", VA = "0x1857D7080")]
		[MethodImpl(256)]
		public static bool2 operator <=(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00021C00 File Offset: 0x0001FE00
		[Token(Token = "0x6001857")]
		[Address(RVA = "0x57D6F70", Offset = "0x57D5B70", VA = "0x1857D6F70")]
		[MethodImpl(256)]
		public static bool2 operator >(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00021C18 File Offset: 0x0001FE18
		[Token(Token = "0x6001858")]
		[Address(RVA = "0x57D6F90", Offset = "0x57D5B90", VA = "0x1857D6F90")]
		[MethodImpl(256)]
		public static bool2 operator >(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00021C30 File Offset: 0x0001FE30
		[Token(Token = "0x6001859")]
		[Address(RVA = "0x57D6F50", Offset = "0x57D5B50", VA = "0x1857D6F50")]
		[MethodImpl(256)]
		public static bool2 operator >(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00021C48 File Offset: 0x0001FE48
		[Token(Token = "0x600185A")]
		[Address(RVA = "0x57D6F30", Offset = "0x57D5B30", VA = "0x1857D6F30")]
		[MethodImpl(256)]
		public static bool2 operator >=(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00021C60 File Offset: 0x0001FE60
		[Token(Token = "0x600185B")]
		[Address(RVA = "0x57D6EF0", Offset = "0x57D5AF0", VA = "0x1857D6EF0")]
		[MethodImpl(256)]
		public static bool2 operator >=(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00021C78 File Offset: 0x0001FE78
		[Token(Token = "0x600185C")]
		[Address(RVA = "0x57D6F10", Offset = "0x57D5B10", VA = "0x1857D6F10")]
		[MethodImpl(256)]
		public static bool2 operator >=(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00021C90 File Offset: 0x0001FE90
		[Token(Token = "0x600185D")]
		[Address(RVA = "0x1DED5B0", Offset = "0x1DEC1B0", VA = "0x181DED5B0")]
		[MethodImpl(256)]
		public static int2 operator -(int2 val)
		{
			return default(int2);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00021CA8 File Offset: 0x0001FEA8
		[Token(Token = "0x600185E")]
		[Address(RVA = "0x5707920", Offset = "0x5706520", VA = "0x185707920")]
		[MethodImpl(256)]
		public static int2 operator +(int2 val)
		{
			return default(int2);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00021CC0 File Offset: 0x0001FEC0
		[Token(Token = "0x600185F")]
		[Address(RVA = "0x57D7030", Offset = "0x57D5C30", VA = "0x1857D7030")]
		[MethodImpl(256)]
		public static int2 operator <<(int2 x, int n)
		{
			return default(int2);
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00021CD8 File Offset: 0x0001FED8
		[Token(Token = "0x6001860")]
		[Address(RVA = "0x57D71F0", Offset = "0x57D5DF0", VA = "0x1857D71F0")]
		[MethodImpl(256)]
		public static int2 operator >>(int2 x, int n)
		{
			return default(int2);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00021CF0 File Offset: 0x0001FEF0
		[Token(Token = "0x6001861")]
		[Address(RVA = "0x57D6E50", Offset = "0x57D5A50", VA = "0x1857D6E50")]
		[MethodImpl(256)]
		public static bool2 operator ==(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00021D08 File Offset: 0x0001FF08
		[Token(Token = "0x6001862")]
		[Address(RVA = "0x57D6E70", Offset = "0x57D5A70", VA = "0x1857D6E70")]
		[MethodImpl(256)]
		public static bool2 operator ==(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x00021D20 File Offset: 0x0001FF20
		[Token(Token = "0x6001863")]
		[Address(RVA = "0x57D6E30", Offset = "0x57D5A30", VA = "0x1857D6E30")]
		[MethodImpl(256)]
		public static bool2 operator ==(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00021D38 File Offset: 0x0001FF38
		[Token(Token = "0x6001864")]
		[Address(RVA = "0x57D6FD0", Offset = "0x57D5BD0", VA = "0x1857D6FD0")]
		[MethodImpl(256)]
		public static bool2 operator !=(int2 lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00021D50 File Offset: 0x0001FF50
		[Token(Token = "0x6001865")]
		[Address(RVA = "0x57D6FF0", Offset = "0x57D5BF0", VA = "0x1857D6FF0")]
		[MethodImpl(256)]
		public static bool2 operator !=(int2 lhs, int rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00021D68 File Offset: 0x0001FF68
		[Token(Token = "0x6001866")]
		[Address(RVA = "0x57D7010", Offset = "0x57D5C10", VA = "0x1857D7010")]
		[MethodImpl(256)]
		public static bool2 operator !=(int lhs, int2 rhs)
		{
			return default(bool2);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x00021D80 File Offset: 0x0001FF80
		[Token(Token = "0x6001867")]
		[Address(RVA = "0x57D71D0", Offset = "0x57D5DD0", VA = "0x1857D71D0")]
		[MethodImpl(256)]
		public static int2 operator ~(int2 val)
		{
			return default(int2);
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00021D98 File Offset: 0x0001FF98
		[Token(Token = "0x6001868")]
		[Address(RVA = "0x57D6D00", Offset = "0x57D5900", VA = "0x1857D6D00")]
		[MethodImpl(256)]
		public static int2 operator &(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00021DB0 File Offset: 0x0001FFB0
		[Token(Token = "0x6001869")]
		[Address(RVA = "0x57D6CC0", Offset = "0x57D58C0", VA = "0x1857D6CC0")]
		[MethodImpl(256)]
		public static int2 operator &(int2 lhs, int rhs)
		{
			return default(int2);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x00021DC8 File Offset: 0x0001FFC8
		[Token(Token = "0x600186A")]
		[Address(RVA = "0x57D6CE0", Offset = "0x57D58E0", VA = "0x1857D6CE0")]
		[MethodImpl(256)]
		public static int2 operator &(int lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x00021DE0 File Offset: 0x0001FFE0
		[Token(Token = "0x600186B")]
		[Address(RVA = "0x57D6D20", Offset = "0x57D5920", VA = "0x1857D6D20")]
		[MethodImpl(256)]
		public static int2 operator |(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00021DF8 File Offset: 0x0001FFF8
		[Token(Token = "0x600186C")]
		[Address(RVA = "0x57D6D60", Offset = "0x57D5960", VA = "0x1857D6D60")]
		[MethodImpl(256)]
		public static int2 operator |(int2 lhs, int rhs)
		{
			return default(int2);
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00021E10 File Offset: 0x00020010
		[Token(Token = "0x600186D")]
		[Address(RVA = "0x57D6D40", Offset = "0x57D5940", VA = "0x1857D6D40")]
		[MethodImpl(256)]
		public static int2 operator |(int lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00021E28 File Offset: 0x00020028
		[Token(Token = "0x600186E")]
		[Address(RVA = "0x57D6ED0", Offset = "0x57D5AD0", VA = "0x1857D6ED0")]
		[MethodImpl(256)]
		public static int2 operator ^(int2 lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00021E40 File Offset: 0x00020040
		[Token(Token = "0x600186F")]
		[Address(RVA = "0x57D6EB0", Offset = "0x57D5AB0", VA = "0x1857D6EB0")]
		[MethodImpl(256)]
		public static int2 operator ^(int2 lhs, int rhs)
		{
			return default(int2);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00021E58 File Offset: 0x00020058
		[Token(Token = "0x6001870")]
		[Address(RVA = "0x57D6E90", Offset = "0x57D5A90", VA = "0x1857D6E90")]
		[MethodImpl(256)]
		public static int2 operator ^(int lhs, int2 rhs)
		{
			return default(int2);
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x00021E70 File Offset: 0x00020070
		[Token(Token = "0x170007B0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxxx
		{
			[Token(Token = "0x6001871")]
			[Address(RVA = "0x576B0E0", Offset = "0x5769CE0", VA = "0x18576B0E0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x00021E88 File Offset: 0x00020088
		[Token(Token = "0x170007B1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxxy
		{
			[Token(Token = "0x6001872")]
			[Address(RVA = "0x576B100", Offset = "0x5769D00", VA = "0x18576B100")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x00021EA0 File Offset: 0x000200A0
		[Token(Token = "0x170007B2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxyx
		{
			[Token(Token = "0x6001873")]
			[Address(RVA = "0x576B180", Offset = "0x5769D80", VA = "0x18576B180")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00021EB8 File Offset: 0x000200B8
		[Token(Token = "0x170007B3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xxyy
		{
			[Token(Token = "0x6001874")]
			[Address(RVA = "0x576B1A0", Offset = "0x5769DA0", VA = "0x18576B1A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x00021ED0 File Offset: 0x000200D0
		[Token(Token = "0x170007B4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxx
		{
			[Token(Token = "0x6001875")]
			[Address(RVA = "0x576B380", Offset = "0x5769F80", VA = "0x18576B380")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x00021EE8 File Offset: 0x000200E8
		[Token(Token = "0x170007B5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyxy
		{
			[Token(Token = "0x6001876")]
			[Address(RVA = "0x576B3A0", Offset = "0x5769FA0", VA = "0x18576B3A0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007B6 RID: 1974
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x00021F00 File Offset: 0x00020100
		[Token(Token = "0x170007B6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyyx
		{
			[Token(Token = "0x6001877")]
			[Address(RVA = "0x576B420", Offset = "0x576A020", VA = "0x18576B420")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x00021F18 File Offset: 0x00020118
		[Token(Token = "0x170007B7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 xyyy
		{
			[Token(Token = "0x6001878")]
			[Address(RVA = "0x576B440", Offset = "0x576A040", VA = "0x18576B440")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x00021F30 File Offset: 0x00020130
		[Token(Token = "0x170007B8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxxx
		{
			[Token(Token = "0x6001879")]
			[Address(RVA = "0x576BB60", Offset = "0x576A760", VA = "0x18576BB60")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x00021F48 File Offset: 0x00020148
		[Token(Token = "0x170007B9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxxy
		{
			[Token(Token = "0x600187A")]
			[Address(RVA = "0x576BB80", Offset = "0x576A780", VA = "0x18576BB80")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x00021F60 File Offset: 0x00020160
		[Token(Token = "0x170007BA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxyx
		{
			[Token(Token = "0x600187B")]
			[Address(RVA = "0x576BC00", Offset = "0x576A800", VA = "0x18576BC00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x00021F78 File Offset: 0x00020178
		[Token(Token = "0x170007BB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yxyy
		{
			[Token(Token = "0x600187C")]
			[Address(RVA = "0x576BC20", Offset = "0x576A820", VA = "0x18576BC20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x00021F90 File Offset: 0x00020190
		[Token(Token = "0x170007BC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyxx
		{
			[Token(Token = "0x600187D")]
			[Address(RVA = "0x576BE00", Offset = "0x576AA00", VA = "0x18576BE00")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x00021FA8 File Offset: 0x000201A8
		[Token(Token = "0x170007BD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyxy
		{
			[Token(Token = "0x600187E")]
			[Address(RVA = "0x576BE20", Offset = "0x576AA20", VA = "0x18576BE20")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x00021FC0 File Offset: 0x000201C0
		[Token(Token = "0x170007BE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyyx
		{
			[Token(Token = "0x600187F")]
			[Address(RVA = "0x576BE90", Offset = "0x576AA90", VA = "0x18576BE90")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x00021FD8 File Offset: 0x000201D8
		[Token(Token = "0x170007BF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int4 yyyy
		{
			[Token(Token = "0x6001880")]
			[Address(RVA = "0x576BEB0", Offset = "0x576AAB0", VA = "0x18576BEB0")]
			[MethodImpl(256)]
			get
			{
				return default(int4);
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x00021FF0 File Offset: 0x000201F0
		[Token(Token = "0x170007C0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xxx
		{
			[Token(Token = "0x6001881")]
			[Address(RVA = "0x576B0B0", Offset = "0x5769CB0", VA = "0x18576B0B0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x00022008 File Offset: 0x00020208
		[Token(Token = "0x170007C1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xxy
		{
			[Token(Token = "0x6001882")]
			[Address(RVA = "0x576B140", Offset = "0x5769D40", VA = "0x18576B140")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x00022020 File Offset: 0x00020220
		[Token(Token = "0x170007C2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyx
		{
			[Token(Token = "0x6001883")]
			[Address(RVA = "0x576B340", Offset = "0x5769F40", VA = "0x18576B340")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00022038 File Offset: 0x00020238
		[Token(Token = "0x170007C3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 xyy
		{
			[Token(Token = "0x6001884")]
			[Address(RVA = "0x576B3E0", Offset = "0x5769FE0", VA = "0x18576B3E0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00022050 File Offset: 0x00020250
		[Token(Token = "0x170007C4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yxx
		{
			[Token(Token = "0x6001885")]
			[Address(RVA = "0x576BB20", Offset = "0x576A720", VA = "0x18576BB20")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x00022068 File Offset: 0x00020268
		[Token(Token = "0x170007C5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yxy
		{
			[Token(Token = "0x6001886")]
			[Address(RVA = "0x576BBC0", Offset = "0x576A7C0", VA = "0x18576BBC0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x00022080 File Offset: 0x00020280
		[Token(Token = "0x170007C6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yyx
		{
			[Token(Token = "0x6001887")]
			[Address(RVA = "0x576BDC0", Offset = "0x576A9C0", VA = "0x18576BDC0")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x00022098 File Offset: 0x00020298
		[Token(Token = "0x170007C7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int3 yyy
		{
			[Token(Token = "0x6001888")]
			[Address(RVA = "0x576BE60", Offset = "0x576AA60", VA = "0x18576BE60")]
			[MethodImpl(256)]
			get
			{
				return default(int3);
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x000220B0 File Offset: 0x000202B0
		[Token(Token = "0x170007C8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xx
		{
			[Token(Token = "0x6001889")]
			[Address(RVA = "0x576B000", Offset = "0x5769C00", VA = "0x18576B000")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x000220C8 File Offset: 0x000202C8
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007C9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 xy
		{
			[Token(Token = "0x600188A")]
			[Address(RVA = "0x576B280", Offset = "0x5769E80", VA = "0x18576B280")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x600188B")]
			[Address(RVA = "0x576D820", Offset = "0x576C420", VA = "0x18576D820")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x000220E0 File Offset: 0x000202E0
		// (set) Token: 0x0600188D RID: 6285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170007CA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yx
		{
			[Token(Token = "0x600188C")]
			[Address(RVA = "0x576BA60", Offset = "0x576A660", VA = "0x18576BA60")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
			[Token(Token = "0x600188D")]
			[Address(RVA = "0x576D990", Offset = "0x576C590", VA = "0x18576D990")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x0600188E RID: 6286 RVA: 0x000220F8 File Offset: 0x000202F8
		[Token(Token = "0x170007CB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int2 yy
		{
			[Token(Token = "0x600188E")]
			[Address(RVA = "0x576BD00", Offset = "0x576A900", VA = "0x18576BD00")]
			[MethodImpl(256)]
			get
			{
				return default(int2);
			}
		}

		// Token: 0x170007CC RID: 1996
		[Token(Token = "0x170007CC")]
		public int this[int index]
		{
			[Token(Token = "0x600188F")]
			[Address(RVA = "0x3D284D0", Offset = "0x3D270D0", VA = "0x183D284D0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001890")]
			[Address(RVA = "0x3D288C0", Offset = "0x3D274C0", VA = "0x183D288C0")]
			set
			{
			}
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00022128 File Offset: 0x00020328
		[Token(Token = "0x6001891")]
		[Address(RVA = "0x1DECC50", Offset = "0x1DEB850", VA = "0x181DECC50", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(int2 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00022140 File Offset: 0x00020340
		[Token(Token = "0x6001892")]
		[Address(RVA = "0x57D69E0", Offset = "0x57D55E0", VA = "0x1857D69E0", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x00022158 File Offset: 0x00020358
		[Token(Token = "0x6001893")]
		[Address(RVA = "0x57D6A70", Offset = "0x57D5670", VA = "0x1857D6A70", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001894")]
		[Address(RVA = "0x57D6B60", Offset = "0x57D5760", VA = "0x1857D6B60", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001895")]
		[Address(RVA = "0x57D6AD0", Offset = "0x57D56D0", VA = "0x1857D6AD0", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x4")]
		public int y;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int2 zero;

		// Token: 0x0200003D RID: 61
		[Token(Token = "0x200003D")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x06001896 RID: 6294 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001896")]
			[Address(RVA = "0x57D1240", Offset = "0x57CFE40", VA = "0x1857D1240")]
			public DebuggerProxy(int2 v)
			{
			}

			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			[FieldOffset(Offset = "0x10")]
			public int x;

			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			[FieldOffset(Offset = "0x14")]
			public int y;
		}
	}
}
