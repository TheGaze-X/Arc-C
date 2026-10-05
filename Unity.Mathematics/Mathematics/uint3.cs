using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[DebuggerTypeProxy(typeof(uint3.DebuggerProxy))]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct uint3 : IEquatable<uint3>, IFormattable
	{
		// Token: 0x06001FE2 RID: 8162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x4CD2130", Offset = "0x4CD0D30", VA = "0x184CD2130")]
		[MethodImpl(256)]
		public uint3(uint x, uint y, uint z)
		{
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x57DFD00", Offset = "0x57DE900", VA = "0x1857DFD00")]
		[MethodImpl(256)]
		public uint3(uint x, uint2 yz)
		{
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x57DFDC0", Offset = "0x57DE9C0", VA = "0x1857DFDC0")]
		[MethodImpl(256)]
		public uint3(uint2 xy, uint z)
		{
		}

		// Token: 0x06001FE5 RID: 8165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
		[MethodImpl(256)]
		public uint3(uint3 xyz)
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x57DFD80", Offset = "0x57DE980", VA = "0x1857DFD80")]
		[MethodImpl(256)]
		public uint3(uint v)
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x57DFDB0", Offset = "0x57DE9B0", VA = "0x1857DFDB0")]
		[MethodImpl(256)]
		public uint3(bool v)
		{
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x57DFD30", Offset = "0x57DE930", VA = "0x1857DFD30")]
		[MethodImpl(256)]
		public uint3(bool3 v)
		{
		}

		// Token: 0x06001FE9 RID: 8169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x57DFD80", Offset = "0x57DE980", VA = "0x1857DFD80")]
		[MethodImpl(256)]
		public uint3(int v)
		{
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
		[MethodImpl(256)]
		public uint3(int3 v)
		{
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x5814C70", Offset = "0x5813870", VA = "0x185814C70")]
		[MethodImpl(256)]
		public uint3(float v)
		{
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x5814BE0", Offset = "0x58137E0", VA = "0x185814BE0")]
		[MethodImpl(256)]
		public uint3(float3 v)
		{
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x5814C30", Offset = "0x5813830", VA = "0x185814C30")]
		[MethodImpl(256)]
		public uint3(double v)
		{
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x5814B90", Offset = "0x5813790", VA = "0x185814B90")]
		[MethodImpl(256)]
		public uint3(double3 v)
		{
		}

		// Token: 0x06001FEF RID: 8175 RVA: 0x0002B248 File Offset: 0x00029448
		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x5729510", Offset = "0x5728110", VA = "0x185729510")]
		[MethodImpl(256)]
		public static implicit operator uint3(uint v)
		{
			return default(uint3);
		}

		// Token: 0x06001FF0 RID: 8176 RVA: 0x0002B260 File Offset: 0x00029460
		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x57294F0", Offset = "0x57280F0", VA = "0x1857294F0")]
		[MethodImpl(256)]
		public static explicit operator uint3(bool v)
		{
			return default(uint3);
		}

		// Token: 0x06001FF1 RID: 8177 RVA: 0x0002B278 File Offset: 0x00029478
		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x57295F0", Offset = "0x57281F0", VA = "0x1857295F0")]
		[MethodImpl(256)]
		public static explicit operator uint3(bool3 v)
		{
			return default(uint3);
		}

		// Token: 0x06001FF2 RID: 8178 RVA: 0x0002B290 File Offset: 0x00029490
		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x5729510", Offset = "0x5728110", VA = "0x185729510")]
		[MethodImpl(256)]
		public static explicit operator uint3(int v)
		{
			return default(uint3);
		}

		// Token: 0x06001FF3 RID: 8179 RVA: 0x0002B2A8 File Offset: 0x000294A8
		[Token(Token = "0x6001FF3")]
		[Address(RVA = "0x57295A0", Offset = "0x57281A0", VA = "0x1857295A0")]
		[MethodImpl(256)]
		public static explicit operator uint3(int3 v)
		{
			return default(uint3);
		}

		// Token: 0x06001FF4 RID: 8180 RVA: 0x0002B2C0 File Offset: 0x000294C0
		[Token(Token = "0x6001FF4")]
		[Address(RVA = "0x5753EE0", Offset = "0x5752AE0", VA = "0x185753EE0")]
		[MethodImpl(256)]
		public static explicit operator uint3(float v)
		{
			return default(uint3);
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0002B2D8 File Offset: 0x000294D8
		[Token(Token = "0x6001FF5")]
		[Address(RVA = "0x5753DB0", Offset = "0x57529B0", VA = "0x185753DB0")]
		[MethodImpl(256)]
		public static explicit operator uint3(float3 v)
		{
			return default(uint3);
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0002B2F0 File Offset: 0x000294F0
		[Token(Token = "0x6001FF6")]
		[Address(RVA = "0x5753EA0", Offset = "0x5752AA0", VA = "0x185753EA0")]
		[MethodImpl(256)]
		public static explicit operator uint3(double v)
		{
			return default(uint3);
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0002B308 File Offset: 0x00029508
		[Token(Token = "0x6001FF7")]
		[Address(RVA = "0x5753E20", Offset = "0x5752A20", VA = "0x185753E20")]
		[MethodImpl(256)]
		public static explicit operator uint3(double3 v)
		{
			return default(uint3);
		}

		// Token: 0x06001FF8 RID: 8184 RVA: 0x0002B320 File Offset: 0x00029520
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x57E0390", Offset = "0x57DEF90", VA = "0x1857E0390")]
		[MethodImpl(256)]
		public static uint3 operator *(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06001FF9 RID: 8185 RVA: 0x0002B338 File Offset: 0x00029538
		[Token(Token = "0x6001FF9")]
		[Address(RVA = "0x57E03C0", Offset = "0x57DEFC0", VA = "0x1857E03C0")]
		[MethodImpl(256)]
		public static uint3 operator *(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		// Token: 0x06001FFA RID: 8186 RVA: 0x0002B350 File Offset: 0x00029550
		[Token(Token = "0x6001FFA")]
		[Address(RVA = "0x57E03E0", Offset = "0x57DEFE0", VA = "0x1857E03E0")]
		[MethodImpl(256)]
		public static uint3 operator *(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06001FFB RID: 8187 RVA: 0x0002B368 File Offset: 0x00029568
		[Token(Token = "0x6001FFB")]
		[Address(RVA = "0x57DFDF0", Offset = "0x57DE9F0", VA = "0x1857DFDF0")]
		[MethodImpl(256)]
		public static uint3 operator +(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06001FFC RID: 8188 RVA: 0x0002B380 File Offset: 0x00029580
		[Token(Token = "0x6001FFC")]
		[Address(RVA = "0x57DFE10", Offset = "0x57DEA10", VA = "0x1857DFE10")]
		[MethodImpl(256)]
		public static uint3 operator +(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		// Token: 0x06001FFD RID: 8189 RVA: 0x0002B398 File Offset: 0x00029598
		[Token(Token = "0x6001FFD")]
		[Address(RVA = "0x57DFDD0", Offset = "0x57DE9D0", VA = "0x1857DFDD0")]
		[MethodImpl(256)]
		public static uint3 operator +(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06001FFE RID: 8190 RVA: 0x0002B3B0 File Offset: 0x000295B0
		[Token(Token = "0x6001FFE")]
		[Address(RVA = "0x57E0490", Offset = "0x57DF090", VA = "0x1857E0490")]
		[MethodImpl(256)]
		public static uint3 operator -(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06001FFF RID: 8191 RVA: 0x0002B3C8 File Offset: 0x000295C8
		[Token(Token = "0x6001FFF")]
		[Address(RVA = "0x57E0470", Offset = "0x57DF070", VA = "0x1857E0470")]
		[MethodImpl(256)]
		public static uint3 operator -(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002000 RID: 8192 RVA: 0x0002B3E0 File Offset: 0x000295E0
		[Token(Token = "0x6002000")]
		[Address(RVA = "0x57E0450", Offset = "0x57DF050", VA = "0x1857E0450")]
		[MethodImpl(256)]
		public static uint3 operator -(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x0002B3F8 File Offset: 0x000295F8
		[Token(Token = "0x6002001")]
		[Address(RVA = "0x5814D10", Offset = "0x5813910", VA = "0x185814D10")]
		[MethodImpl(256)]
		public static uint3 operator /(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002002 RID: 8194 RVA: 0x0002B410 File Offset: 0x00029610
		[Token(Token = "0x6002002")]
		[Address(RVA = "0x5814CE0", Offset = "0x58138E0", VA = "0x185814CE0")]
		[MethodImpl(256)]
		public static uint3 operator /(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x0002B428 File Offset: 0x00029628
		[Token(Token = "0x6002003")]
		[Address(RVA = "0x5814CB0", Offset = "0x58138B0", VA = "0x185814CB0")]
		[MethodImpl(256)]
		public static uint3 operator /(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x0002B440 File Offset: 0x00029640
		[Token(Token = "0x6002004")]
		[Address(RVA = "0x5814F00", Offset = "0x5813B00", VA = "0x185814F00")]
		[MethodImpl(256)]
		public static uint3 operator %(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x0002B458 File Offset: 0x00029658
		[Token(Token = "0x6002005")]
		[Address(RVA = "0x5814F30", Offset = "0x5813B30", VA = "0x185814F30")]
		[MethodImpl(256)]
		public static uint3 operator %(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x0002B470 File Offset: 0x00029670
		[Token(Token = "0x6002006")]
		[Address(RVA = "0x5814F60", Offset = "0x5813B60", VA = "0x185814F60")]
		[MethodImpl(256)]
		public static uint3 operator %(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002007 RID: 8199 RVA: 0x0002B488 File Offset: 0x00029688
		[Token(Token = "0x6002007")]
		[Address(RVA = "0x57E0160", Offset = "0x57DED60", VA = "0x1857E0160")]
		[MethodImpl(256)]
		public static uint3 operator ++(uint3 val)
		{
			return default(uint3);
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x0002B4A0 File Offset: 0x000296A0
		[Token(Token = "0x6002008")]
		[Address(RVA = "0x57DFF00", Offset = "0x57DEB00", VA = "0x1857DFF00")]
		[MethodImpl(256)]
		public static uint3 operator --(uint3 val)
		{
			return default(uint3);
		}

		// Token: 0x06002009 RID: 8201 RVA: 0x0002B4B8 File Offset: 0x000296B8
		[Token(Token = "0x6002009")]
		[Address(RVA = "0x5814ED0", Offset = "0x5813AD0", VA = "0x185814ED0")]
		[MethodImpl(256)]
		public static bool3 operator <(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x0002B4D0 File Offset: 0x000296D0
		[Token(Token = "0x600200A")]
		[Address(RVA = "0x5814E90", Offset = "0x5813A90", VA = "0x185814E90")]
		[MethodImpl(256)]
		public static bool3 operator <(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x0002B4E8 File Offset: 0x000296E8
		[Token(Token = "0x600200B")]
		[Address(RVA = "0x5814EB0", Offset = "0x5813AB0", VA = "0x185814EB0")]
		[MethodImpl(256)]
		public static bool3 operator <(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600200C RID: 8204 RVA: 0x0002B500 File Offset: 0x00029700
		[Token(Token = "0x600200C")]
		[Address(RVA = "0x5814E40", Offset = "0x5813A40", VA = "0x185814E40")]
		[MethodImpl(256)]
		public static bool3 operator <=(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0002B518 File Offset: 0x00029718
		[Token(Token = "0x600200D")]
		[Address(RVA = "0x5814E70", Offset = "0x5813A70", VA = "0x185814E70")]
		[MethodImpl(256)]
		public static bool3 operator <=(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600200E RID: 8206 RVA: 0x0002B530 File Offset: 0x00029730
		[Token(Token = "0x600200E")]
		[Address(RVA = "0x5814E20", Offset = "0x5813A20", VA = "0x185814E20")]
		[MethodImpl(256)]
		public static bool3 operator <=(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600200F RID: 8207 RVA: 0x0002B548 File Offset: 0x00029748
		[Token(Token = "0x600200F")]
		[Address(RVA = "0x5814DF0", Offset = "0x58139F0", VA = "0x185814DF0")]
		[MethodImpl(256)]
		public static bool3 operator >(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0002B560 File Offset: 0x00029760
		[Token(Token = "0x6002010")]
		[Address(RVA = "0x5814DB0", Offset = "0x58139B0", VA = "0x185814DB0")]
		[MethodImpl(256)]
		public static bool3 operator >(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0002B578 File Offset: 0x00029778
		[Token(Token = "0x6002011")]
		[Address(RVA = "0x5814DD0", Offset = "0x58139D0", VA = "0x185814DD0")]
		[MethodImpl(256)]
		public static bool3 operator >(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0002B590 File Offset: 0x00029790
		[Token(Token = "0x6002012")]
		[Address(RVA = "0x5814D60", Offset = "0x5813960", VA = "0x185814D60")]
		[MethodImpl(256)]
		public static bool3 operator >=(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0002B5A8 File Offset: 0x000297A8
		[Token(Token = "0x6002013")]
		[Address(RVA = "0x5814D40", Offset = "0x5813940", VA = "0x185814D40")]
		[MethodImpl(256)]
		public static bool3 operator >=(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0002B5C0 File Offset: 0x000297C0
		[Token(Token = "0x6002014")]
		[Address(RVA = "0x5814D90", Offset = "0x5813990", VA = "0x185814D90")]
		[MethodImpl(256)]
		public static bool3 operator >=(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x0002B5D8 File Offset: 0x000297D8
		[Token(Token = "0x6002015")]
		[Address(RVA = "0x57E04B0", Offset = "0x57DF0B0", VA = "0x1857E04B0")]
		[MethodImpl(256)]
		public static uint3 operator -(uint3 val)
		{
			return default(uint3);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x0002B5F0 File Offset: 0x000297F0
		[Token(Token = "0x6002016")]
		[Address(RVA = "0x576B480", Offset = "0x576A080", VA = "0x18576B480")]
		[MethodImpl(256)]
		public static uint3 operator +(uint3 val)
		{
			return default(uint3);
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x0002B608 File Offset: 0x00029808
		[Token(Token = "0x6002017")]
		[Address(RVA = "0x57E01F0", Offset = "0x57DEDF0", VA = "0x1857E01F0")]
		[MethodImpl(256)]
		public static uint3 operator <<(uint3 x, int n)
		{
			return default(uint3);
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0002B620 File Offset: 0x00029820
		[Token(Token = "0x6002018")]
		[Address(RVA = "0x5814F90", Offset = "0x5813B90", VA = "0x185814F90")]
		[MethodImpl(256)]
		public static uint3 operator >>(uint3 x, int n)
		{
			return default(uint3);
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x0002B638 File Offset: 0x00029838
		[Token(Token = "0x6002019")]
		[Address(RVA = "0x57DFFB0", Offset = "0x57DEBB0", VA = "0x1857DFFB0")]
		[MethodImpl(256)]
		public static bool3 operator ==(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x0002B650 File Offset: 0x00029850
		[Token(Token = "0x600201A")]
		[Address(RVA = "0x57DFFE0", Offset = "0x57DEBE0", VA = "0x1857DFFE0")]
		[MethodImpl(256)]
		public static bool3 operator ==(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0002B668 File Offset: 0x00029868
		[Token(Token = "0x600201B")]
		[Address(RVA = "0x57E0000", Offset = "0x57DEC00", VA = "0x1857E0000")]
		[MethodImpl(256)]
		public static bool3 operator ==(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x0002B680 File Offset: 0x00029880
		[Token(Token = "0x600201C")]
		[Address(RVA = "0x57E01C0", Offset = "0x57DEDC0", VA = "0x1857E01C0")]
		[MethodImpl(256)]
		public static bool3 operator !=(uint3 lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x0002B698 File Offset: 0x00029898
		[Token(Token = "0x600201D")]
		[Address(RVA = "0x57E01A0", Offset = "0x57DEDA0", VA = "0x1857E01A0")]
		[MethodImpl(256)]
		public static bool3 operator !=(uint3 lhs, uint rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x0002B6B0 File Offset: 0x000298B0
		[Token(Token = "0x600201E")]
		[Address(RVA = "0x57E0180", Offset = "0x57DED80", VA = "0x1857E0180")]
		[MethodImpl(256)]
		public static bool3 operator !=(uint lhs, uint3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x0002B6C8 File Offset: 0x000298C8
		[Token(Token = "0x600201F")]
		[Address(RVA = "0x57E0400", Offset = "0x57DF000", VA = "0x1857E0400")]
		[MethodImpl(256)]
		public static uint3 operator ~(uint3 val)
		{
			return default(uint3);
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x0002B6E0 File Offset: 0x000298E0
		[Token(Token = "0x6002020")]
		[Address(RVA = "0x57DFE60", Offset = "0x57DEA60", VA = "0x1857DFE60")]
		[MethodImpl(256)]
		public static uint3 operator &(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x0002B6F8 File Offset: 0x000298F8
		[Token(Token = "0x6002021")]
		[Address(RVA = "0x57DFE40", Offset = "0x57DEA40", VA = "0x1857DFE40")]
		[MethodImpl(256)]
		public static uint3 operator &(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x0002B710 File Offset: 0x00029910
		[Token(Token = "0x6002022")]
		[Address(RVA = "0x57DFE80", Offset = "0x57DEA80", VA = "0x1857DFE80")]
		[MethodImpl(256)]
		public static uint3 operator &(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x0002B728 File Offset: 0x00029928
		[Token(Token = "0x6002023")]
		[Address(RVA = "0x57DFEA0", Offset = "0x57DEAA0", VA = "0x1857DFEA0")]
		[MethodImpl(256)]
		public static uint3 operator |(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x0002B740 File Offset: 0x00029940
		[Token(Token = "0x6002024")]
		[Address(RVA = "0x57DFEE0", Offset = "0x57DEAE0", VA = "0x1857DFEE0")]
		[MethodImpl(256)]
		public static uint3 operator |(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x0002B758 File Offset: 0x00029958
		[Token(Token = "0x6002025")]
		[Address(RVA = "0x57DFEC0", Offset = "0x57DEAC0", VA = "0x1857DFEC0")]
		[MethodImpl(256)]
		public static uint3 operator |(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x0002B770 File Offset: 0x00029970
		[Token(Token = "0x6002026")]
		[Address(RVA = "0x57E0020", Offset = "0x57DEC20", VA = "0x1857E0020")]
		[MethodImpl(256)]
		public static uint3 operator ^(uint3 lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x0002B788 File Offset: 0x00029988
		[Token(Token = "0x6002027")]
		[Address(RVA = "0x57E0040", Offset = "0x57DEC40", VA = "0x1857E0040")]
		[MethodImpl(256)]
		public static uint3 operator ^(uint3 lhs, uint rhs)
		{
			return default(uint3);
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x0002B7A0 File Offset: 0x000299A0
		[Token(Token = "0x6002028")]
		[Address(RVA = "0x57E0060", Offset = "0x57DEC60", VA = "0x1857E0060")]
		[MethodImpl(256)]
		public static uint3 operator ^(uint lhs, uint3 rhs)
		{
			return default(uint3);
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002029 RID: 8233 RVA: 0x0002B7B8 File Offset: 0x000299B8
		[Token(Token = "0x170009BD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxx
		{
			[Token(Token = "0x6002029")]
			[Address(RVA = "0x576B0E0", Offset = "0x5769CE0", VA = "0x18576B0E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x0002B7D0 File Offset: 0x000299D0
		[Token(Token = "0x170009BE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxy
		{
			[Token(Token = "0x600202A")]
			[Address(RVA = "0x576B100", Offset = "0x5769D00", VA = "0x18576B100")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x0600202B RID: 8235 RVA: 0x0002B7E8 File Offset: 0x000299E8
		[Token(Token = "0x170009BF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxxz
		{
			[Token(Token = "0x600202B")]
			[Address(RVA = "0x576B120", Offset = "0x5769D20", VA = "0x18576B120")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x0600202C RID: 8236 RVA: 0x0002B800 File Offset: 0x00029A00
		[Token(Token = "0x170009C0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyx
		{
			[Token(Token = "0x600202C")]
			[Address(RVA = "0x576B180", Offset = "0x5769D80", VA = "0x18576B180")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x0002B818 File Offset: 0x00029A18
		[Token(Token = "0x170009C1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyy
		{
			[Token(Token = "0x600202D")]
			[Address(RVA = "0x576B1A0", Offset = "0x5769DA0", VA = "0x18576B1A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x0002B830 File Offset: 0x00029A30
		[Token(Token = "0x170009C2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxyz
		{
			[Token(Token = "0x600202E")]
			[Address(RVA = "0x576B1C0", Offset = "0x5769DC0", VA = "0x18576B1C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x0002B848 File Offset: 0x00029A48
		[Token(Token = "0x170009C3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxzx
		{
			[Token(Token = "0x600202F")]
			[Address(RVA = "0x576B220", Offset = "0x5769E20", VA = "0x18576B220")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x0002B860 File Offset: 0x00029A60
		[Token(Token = "0x170009C4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxzy
		{
			[Token(Token = "0x6002030")]
			[Address(RVA = "0x576B240", Offset = "0x5769E40", VA = "0x18576B240")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x0002B878 File Offset: 0x00029A78
		[Token(Token = "0x170009C5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xxzz
		{
			[Token(Token = "0x6002031")]
			[Address(RVA = "0x576B260", Offset = "0x5769E60", VA = "0x18576B260")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06002032 RID: 8242 RVA: 0x0002B890 File Offset: 0x00029A90
		[Token(Token = "0x170009C6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxx
		{
			[Token(Token = "0x6002032")]
			[Address(RVA = "0x576B380", Offset = "0x5769F80", VA = "0x18576B380")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x0002B8A8 File Offset: 0x00029AA8
		[Token(Token = "0x170009C7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxy
		{
			[Token(Token = "0x6002033")]
			[Address(RVA = "0x576B3A0", Offset = "0x5769FA0", VA = "0x18576B3A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x0002B8C0 File Offset: 0x00029AC0
		[Token(Token = "0x170009C8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyxz
		{
			[Token(Token = "0x6002034")]
			[Address(RVA = "0x576B3C0", Offset = "0x5769FC0", VA = "0x18576B3C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x0002B8D8 File Offset: 0x00029AD8
		[Token(Token = "0x170009C9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyx
		{
			[Token(Token = "0x6002035")]
			[Address(RVA = "0x576B420", Offset = "0x576A020", VA = "0x18576B420")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x0002B8F0 File Offset: 0x00029AF0
		[Token(Token = "0x170009CA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyy
		{
			[Token(Token = "0x6002036")]
			[Address(RVA = "0x576B440", Offset = "0x576A040", VA = "0x18576B440")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x0002B908 File Offset: 0x00029B08
		[Token(Token = "0x170009CB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyyz
		{
			[Token(Token = "0x6002037")]
			[Address(RVA = "0x576B460", Offset = "0x576A060", VA = "0x18576B460")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06002038 RID: 8248 RVA: 0x0002B920 File Offset: 0x00029B20
		[Token(Token = "0x170009CC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzx
		{
			[Token(Token = "0x6002038")]
			[Address(RVA = "0x576B4C0", Offset = "0x576A0C0", VA = "0x18576B4C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x0002B938 File Offset: 0x00029B38
		[Token(Token = "0x170009CD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzy
		{
			[Token(Token = "0x6002039")]
			[Address(RVA = "0x576B4E0", Offset = "0x576A0E0", VA = "0x18576B4E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x0600203A RID: 8250 RVA: 0x0002B950 File Offset: 0x00029B50
		[Token(Token = "0x170009CE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xyzz
		{
			[Token(Token = "0x600203A")]
			[Address(RVA = "0x576B500", Offset = "0x576A100", VA = "0x18576B500")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x0600203B RID: 8251 RVA: 0x0002B968 File Offset: 0x00029B68
		[Token(Token = "0x170009CF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzxx
		{
			[Token(Token = "0x600203B")]
			[Address(RVA = "0x576B620", Offset = "0x576A220", VA = "0x18576B620")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x0600203C RID: 8252 RVA: 0x0002B980 File Offset: 0x00029B80
		[Token(Token = "0x170009D0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzxy
		{
			[Token(Token = "0x600203C")]
			[Address(RVA = "0x576B640", Offset = "0x576A240", VA = "0x18576B640")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x0600203D RID: 8253 RVA: 0x0002B998 File Offset: 0x00029B98
		[Token(Token = "0x170009D1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzxz
		{
			[Token(Token = "0x600203D")]
			[Address(RVA = "0x576B660", Offset = "0x576A260", VA = "0x18576B660")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x0600203E RID: 8254 RVA: 0x0002B9B0 File Offset: 0x00029BB0
		[Token(Token = "0x170009D2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzyx
		{
			[Token(Token = "0x600203E")]
			[Address(RVA = "0x576B6C0", Offset = "0x576A2C0", VA = "0x18576B6C0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x0600203F RID: 8255 RVA: 0x0002B9C8 File Offset: 0x00029BC8
		[Token(Token = "0x170009D3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzyy
		{
			[Token(Token = "0x600203F")]
			[Address(RVA = "0x576B6E0", Offset = "0x576A2E0", VA = "0x18576B6E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06002040 RID: 8256 RVA: 0x0002B9E0 File Offset: 0x00029BE0
		[Token(Token = "0x170009D4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzyz
		{
			[Token(Token = "0x6002040")]
			[Address(RVA = "0x576B700", Offset = "0x576A300", VA = "0x18576B700")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0002B9F8 File Offset: 0x00029BF8
		[Token(Token = "0x170009D5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzzx
		{
			[Token(Token = "0x6002041")]
			[Address(RVA = "0x576B760", Offset = "0x576A360", VA = "0x18576B760")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002042 RID: 8258 RVA: 0x0002BA10 File Offset: 0x00029C10
		[Token(Token = "0x170009D6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzzy
		{
			[Token(Token = "0x6002042")]
			[Address(RVA = "0x576B780", Offset = "0x576A380", VA = "0x18576B780")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x0002BA28 File Offset: 0x00029C28
		[Token(Token = "0x170009D7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 xzzz
		{
			[Token(Token = "0x6002043")]
			[Address(RVA = "0x576B7A0", Offset = "0x576A3A0", VA = "0x18576B7A0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x0002BA40 File Offset: 0x00029C40
		[Token(Token = "0x170009D8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxx
		{
			[Token(Token = "0x6002044")]
			[Address(RVA = "0x576BB60", Offset = "0x576A760", VA = "0x18576BB60")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x0002BA58 File Offset: 0x00029C58
		[Token(Token = "0x170009D9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxy
		{
			[Token(Token = "0x6002045")]
			[Address(RVA = "0x576BB80", Offset = "0x576A780", VA = "0x18576BB80")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x0002BA70 File Offset: 0x00029C70
		[Token(Token = "0x170009DA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxxz
		{
			[Token(Token = "0x6002046")]
			[Address(RVA = "0x576BBA0", Offset = "0x576A7A0", VA = "0x18576BBA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0002BA88 File Offset: 0x00029C88
		[Token(Token = "0x170009DB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyx
		{
			[Token(Token = "0x6002047")]
			[Address(RVA = "0x576BC00", Offset = "0x576A800", VA = "0x18576BC00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x0002BAA0 File Offset: 0x00029CA0
		[Token(Token = "0x170009DC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyy
		{
			[Token(Token = "0x6002048")]
			[Address(RVA = "0x576BC20", Offset = "0x576A820", VA = "0x18576BC20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002049 RID: 8265 RVA: 0x0002BAB8 File Offset: 0x00029CB8
		[Token(Token = "0x170009DD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxyz
		{
			[Token(Token = "0x6002049")]
			[Address(RVA = "0x576BC40", Offset = "0x576A840", VA = "0x18576BC40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x0002BAD0 File Offset: 0x00029CD0
		[Token(Token = "0x170009DE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxzx
		{
			[Token(Token = "0x600204A")]
			[Address(RVA = "0x576BCA0", Offset = "0x576A8A0", VA = "0x18576BCA0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x0600204B RID: 8267 RVA: 0x0002BAE8 File Offset: 0x00029CE8
		[Token(Token = "0x170009DF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxzy
		{
			[Token(Token = "0x600204B")]
			[Address(RVA = "0x576BCC0", Offset = "0x576A8C0", VA = "0x18576BCC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x0002BB00 File Offset: 0x00029D00
		[Token(Token = "0x170009E0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yxzz
		{
			[Token(Token = "0x600204C")]
			[Address(RVA = "0x576BCE0", Offset = "0x576A8E0", VA = "0x18576BCE0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x0600204D RID: 8269 RVA: 0x0002BB18 File Offset: 0x00029D18
		[Token(Token = "0x170009E1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxx
		{
			[Token(Token = "0x600204D")]
			[Address(RVA = "0x576BE00", Offset = "0x576AA00", VA = "0x18576BE00")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x0002BB30 File Offset: 0x00029D30
		[Token(Token = "0x170009E2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxy
		{
			[Token(Token = "0x600204E")]
			[Address(RVA = "0x576BE20", Offset = "0x576AA20", VA = "0x18576BE20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x0600204F RID: 8271 RVA: 0x0002BB48 File Offset: 0x00029D48
		[Token(Token = "0x170009E3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyxz
		{
			[Token(Token = "0x600204F")]
			[Address(RVA = "0x576BE40", Offset = "0x576AA40", VA = "0x18576BE40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x0002BB60 File Offset: 0x00029D60
		[Token(Token = "0x170009E4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyx
		{
			[Token(Token = "0x6002050")]
			[Address(RVA = "0x576BE90", Offset = "0x576AA90", VA = "0x18576BE90")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002051 RID: 8273 RVA: 0x0002BB78 File Offset: 0x00029D78
		[Token(Token = "0x170009E5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyy
		{
			[Token(Token = "0x6002051")]
			[Address(RVA = "0x576BEB0", Offset = "0x576AAB0", VA = "0x18576BEB0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x0002BB90 File Offset: 0x00029D90
		[Token(Token = "0x170009E6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyyz
		{
			[Token(Token = "0x6002052")]
			[Address(RVA = "0x576BED0", Offset = "0x576AAD0", VA = "0x18576BED0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002053 RID: 8275 RVA: 0x0002BBA8 File Offset: 0x00029DA8
		[Token(Token = "0x170009E7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyzx
		{
			[Token(Token = "0x6002053")]
			[Address(RVA = "0x576BF30", Offset = "0x576AB30", VA = "0x18576BF30")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x0002BBC0 File Offset: 0x00029DC0
		[Token(Token = "0x170009E8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyzy
		{
			[Token(Token = "0x6002054")]
			[Address(RVA = "0x576BF50", Offset = "0x576AB50", VA = "0x18576BF50")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002055 RID: 8277 RVA: 0x0002BBD8 File Offset: 0x00029DD8
		[Token(Token = "0x170009E9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yyzz
		{
			[Token(Token = "0x6002055")]
			[Address(RVA = "0x576BF70", Offset = "0x576AB70", VA = "0x18576BF70")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x0002BBF0 File Offset: 0x00029DF0
		[Token(Token = "0x170009EA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzxx
		{
			[Token(Token = "0x6002056")]
			[Address(RVA = "0x576C090", Offset = "0x576AC90", VA = "0x18576C090")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x0002BC08 File Offset: 0x00029E08
		[Token(Token = "0x170009EB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzxy
		{
			[Token(Token = "0x6002057")]
			[Address(RVA = "0x576C0B0", Offset = "0x576ACB0", VA = "0x18576C0B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x0002BC20 File Offset: 0x00029E20
		[Token(Token = "0x170009EC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzxz
		{
			[Token(Token = "0x6002058")]
			[Address(RVA = "0x576C0D0", Offset = "0x576ACD0", VA = "0x18576C0D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x0002BC38 File Offset: 0x00029E38
		[Token(Token = "0x170009ED")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzyx
		{
			[Token(Token = "0x6002059")]
			[Address(RVA = "0x576C130", Offset = "0x576AD30", VA = "0x18576C130")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x0002BC50 File Offset: 0x00029E50
		[Token(Token = "0x170009EE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzyy
		{
			[Token(Token = "0x600205A")]
			[Address(RVA = "0x576C150", Offset = "0x576AD50", VA = "0x18576C150")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x0002BC68 File Offset: 0x00029E68
		[Token(Token = "0x170009EF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzyz
		{
			[Token(Token = "0x600205B")]
			[Address(RVA = "0x576C170", Offset = "0x576AD70", VA = "0x18576C170")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x0002BC80 File Offset: 0x00029E80
		[Token(Token = "0x170009F0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzzx
		{
			[Token(Token = "0x600205C")]
			[Address(RVA = "0x576C1D0", Offset = "0x576ADD0", VA = "0x18576C1D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x0600205D RID: 8285 RVA: 0x0002BC98 File Offset: 0x00029E98
		[Token(Token = "0x170009F1")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzzy
		{
			[Token(Token = "0x600205D")]
			[Address(RVA = "0x576C1F0", Offset = "0x576ADF0", VA = "0x18576C1F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x0002BCB0 File Offset: 0x00029EB0
		[Token(Token = "0x170009F2")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 yzzz
		{
			[Token(Token = "0x600205E")]
			[Address(RVA = "0x576C210", Offset = "0x576AE10", VA = "0x18576C210")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x0600205F RID: 8287 RVA: 0x0002BCC8 File Offset: 0x00029EC8
		[Token(Token = "0x170009F3")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxxx
		{
			[Token(Token = "0x600205F")]
			[Address(RVA = "0x576C5B0", Offset = "0x576B1B0", VA = "0x18576C5B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x0002BCE0 File Offset: 0x00029EE0
		[Token(Token = "0x170009F4")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxxy
		{
			[Token(Token = "0x6002060")]
			[Address(RVA = "0x576C5D0", Offset = "0x576B1D0", VA = "0x18576C5D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06002061 RID: 8289 RVA: 0x0002BCF8 File Offset: 0x00029EF8
		[Token(Token = "0x170009F5")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxxz
		{
			[Token(Token = "0x6002061")]
			[Address(RVA = "0x576C5F0", Offset = "0x576B1F0", VA = "0x18576C5F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x0002BD10 File Offset: 0x00029F10
		[Token(Token = "0x170009F6")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxyx
		{
			[Token(Token = "0x6002062")]
			[Address(RVA = "0x576C650", Offset = "0x576B250", VA = "0x18576C650")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002063 RID: 8291 RVA: 0x0002BD28 File Offset: 0x00029F28
		[Token(Token = "0x170009F7")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxyy
		{
			[Token(Token = "0x6002063")]
			[Address(RVA = "0x576C670", Offset = "0x576B270", VA = "0x18576C670")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x0002BD40 File Offset: 0x00029F40
		[Token(Token = "0x170009F8")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxyz
		{
			[Token(Token = "0x6002064")]
			[Address(RVA = "0x576C690", Offset = "0x576B290", VA = "0x18576C690")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06002065 RID: 8293 RVA: 0x0002BD58 File Offset: 0x00029F58
		[Token(Token = "0x170009F9")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxzx
		{
			[Token(Token = "0x6002065")]
			[Address(RVA = "0x576C6F0", Offset = "0x576B2F0", VA = "0x18576C6F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06002066 RID: 8294 RVA: 0x0002BD70 File Offset: 0x00029F70
		[Token(Token = "0x170009FA")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxzy
		{
			[Token(Token = "0x6002066")]
			[Address(RVA = "0x576C710", Offset = "0x576B310", VA = "0x18576C710")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06002067 RID: 8295 RVA: 0x0002BD88 File Offset: 0x00029F88
		[Token(Token = "0x170009FB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zxzz
		{
			[Token(Token = "0x6002067")]
			[Address(RVA = "0x576C730", Offset = "0x576B330", VA = "0x18576C730")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06002068 RID: 8296 RVA: 0x0002BDA0 File Offset: 0x00029FA0
		[Token(Token = "0x170009FC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyxx
		{
			[Token(Token = "0x6002068")]
			[Address(RVA = "0x576C850", Offset = "0x576B450", VA = "0x18576C850")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06002069 RID: 8297 RVA: 0x0002BDB8 File Offset: 0x00029FB8
		[Token(Token = "0x170009FD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyxy
		{
			[Token(Token = "0x6002069")]
			[Address(RVA = "0x576C870", Offset = "0x576B470", VA = "0x18576C870")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x0600206A RID: 8298 RVA: 0x0002BDD0 File Offset: 0x00029FD0
		[Token(Token = "0x170009FE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyxz
		{
			[Token(Token = "0x600206A")]
			[Address(RVA = "0x576C890", Offset = "0x576B490", VA = "0x18576C890")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x0600206B RID: 8299 RVA: 0x0002BDE8 File Offset: 0x00029FE8
		[Token(Token = "0x170009FF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyyx
		{
			[Token(Token = "0x600206B")]
			[Address(RVA = "0x576C8F0", Offset = "0x576B4F0", VA = "0x18576C8F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x0600206C RID: 8300 RVA: 0x0002BE00 File Offset: 0x0002A000
		[Token(Token = "0x17000A00")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyyy
		{
			[Token(Token = "0x600206C")]
			[Address(RVA = "0x576C910", Offset = "0x576B510", VA = "0x18576C910")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x0600206D RID: 8301 RVA: 0x0002BE18 File Offset: 0x0002A018
		[Token(Token = "0x17000A01")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyyz
		{
			[Token(Token = "0x600206D")]
			[Address(RVA = "0x576C930", Offset = "0x576B530", VA = "0x18576C930")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x0600206E RID: 8302 RVA: 0x0002BE30 File Offset: 0x0002A030
		[Token(Token = "0x17000A02")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyzx
		{
			[Token(Token = "0x600206E")]
			[Address(RVA = "0x576C990", Offset = "0x576B590", VA = "0x18576C990")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x0600206F RID: 8303 RVA: 0x0002BE48 File Offset: 0x0002A048
		[Token(Token = "0x17000A03")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyzy
		{
			[Token(Token = "0x600206F")]
			[Address(RVA = "0x576C9B0", Offset = "0x576B5B0", VA = "0x18576C9B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06002070 RID: 8304 RVA: 0x0002BE60 File Offset: 0x0002A060
		[Token(Token = "0x17000A04")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zyzz
		{
			[Token(Token = "0x6002070")]
			[Address(RVA = "0x576C9D0", Offset = "0x576B5D0", VA = "0x18576C9D0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06002071 RID: 8305 RVA: 0x0002BE78 File Offset: 0x0002A078
		[Token(Token = "0x17000A05")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzxx
		{
			[Token(Token = "0x6002071")]
			[Address(RVA = "0x576CAF0", Offset = "0x576B6F0", VA = "0x18576CAF0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002072 RID: 8306 RVA: 0x0002BE90 File Offset: 0x0002A090
		[Token(Token = "0x17000A06")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzxy
		{
			[Token(Token = "0x6002072")]
			[Address(RVA = "0x576CB10", Offset = "0x576B710", VA = "0x18576CB10")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002073 RID: 8307 RVA: 0x0002BEA8 File Offset: 0x0002A0A8
		[Token(Token = "0x17000A07")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzxz
		{
			[Token(Token = "0x6002073")]
			[Address(RVA = "0x576CB30", Offset = "0x576B730", VA = "0x18576CB30")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x0002BEC0 File Offset: 0x0002A0C0
		[Token(Token = "0x17000A08")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzyx
		{
			[Token(Token = "0x6002074")]
			[Address(RVA = "0x576CB90", Offset = "0x576B790", VA = "0x18576CB90")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0002BED8 File Offset: 0x0002A0D8
		[Token(Token = "0x17000A09")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzyy
		{
			[Token(Token = "0x6002075")]
			[Address(RVA = "0x576CBB0", Offset = "0x576B7B0", VA = "0x18576CBB0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x0002BEF0 File Offset: 0x0002A0F0
		[Token(Token = "0x17000A0A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzyz
		{
			[Token(Token = "0x6002076")]
			[Address(RVA = "0x576CBD0", Offset = "0x576B7D0", VA = "0x18576CBD0")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0002BF08 File Offset: 0x0002A108
		[Token(Token = "0x17000A0B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzzx
		{
			[Token(Token = "0x6002077")]
			[Address(RVA = "0x576CC20", Offset = "0x576B820", VA = "0x18576CC20")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x0002BF20 File Offset: 0x0002A120
		[Token(Token = "0x17000A0C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzzy
		{
			[Token(Token = "0x6002078")]
			[Address(RVA = "0x576CC40", Offset = "0x576B840", VA = "0x18576CC40")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x0002BF38 File Offset: 0x0002A138
		[Token(Token = "0x17000A0D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint4 zzzz
		{
			[Token(Token = "0x6002079")]
			[Address(RVA = "0x576CC60", Offset = "0x576B860", VA = "0x18576CC60")]
			[MethodImpl(256)]
			get
			{
				return default(uint4);
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x0002BF50 File Offset: 0x0002A150
		[Token(Token = "0x17000A0E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxx
		{
			[Token(Token = "0x600207A")]
			[Address(RVA = "0x576B0B0", Offset = "0x5769CB0", VA = "0x18576B0B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x0600207B RID: 8315 RVA: 0x0002BF68 File Offset: 0x0002A168
		[Token(Token = "0x17000A0F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxy
		{
			[Token(Token = "0x600207B")]
			[Address(RVA = "0x576B140", Offset = "0x5769D40", VA = "0x18576B140")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x0600207C RID: 8316 RVA: 0x0002BF80 File Offset: 0x0002A180
		[Token(Token = "0x17000A10")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xxz
		{
			[Token(Token = "0x600207C")]
			[Address(RVA = "0x576B1E0", Offset = "0x5769DE0", VA = "0x18576B1E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x0600207D RID: 8317 RVA: 0x0002BF98 File Offset: 0x0002A198
		[Token(Token = "0x17000A11")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyx
		{
			[Token(Token = "0x600207D")]
			[Address(RVA = "0x576B340", Offset = "0x5769F40", VA = "0x18576B340")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x0600207E RID: 8318 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		[Token(Token = "0x17000A12")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyy
		{
			[Token(Token = "0x600207E")]
			[Address(RVA = "0x576B3E0", Offset = "0x5769FE0", VA = "0x18576B3E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x0002BFC8 File Offset: 0x0002A1C8
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A13")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xyz
		{
			[Token(Token = "0x600207F")]
			[Address(RVA = "0x576B480", Offset = "0x576A080", VA = "0x18576B480")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002080")]
			[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0002BFE0 File Offset: 0x0002A1E0
		[Token(Token = "0x17000A14")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xzx
		{
			[Token(Token = "0x6002081")]
			[Address(RVA = "0x576B5E0", Offset = "0x576A1E0", VA = "0x18576B5E0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002082 RID: 8322 RVA: 0x0002BFF8 File Offset: 0x0002A1F8
		// (set) Token: 0x06002083 RID: 8323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A15")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xzy
		{
			[Token(Token = "0x6002082")]
			[Address(RVA = "0x576B680", Offset = "0x576A280", VA = "0x18576B680")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002083")]
			[Address(RVA = "0x576D8C0", Offset = "0x576C4C0", VA = "0x18576D8C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002084 RID: 8324 RVA: 0x0002C010 File Offset: 0x0002A210
		[Token(Token = "0x17000A16")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 xzz
		{
			[Token(Token = "0x6002084")]
			[Address(RVA = "0x576B720", Offset = "0x576A320", VA = "0x18576B720")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0002C028 File Offset: 0x0002A228
		[Token(Token = "0x17000A17")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxx
		{
			[Token(Token = "0x6002085")]
			[Address(RVA = "0x576BB20", Offset = "0x576A720", VA = "0x18576BB20")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002086 RID: 8326 RVA: 0x0002C040 File Offset: 0x0002A240
		[Token(Token = "0x17000A18")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxy
		{
			[Token(Token = "0x6002086")]
			[Address(RVA = "0x576BBC0", Offset = "0x576A7C0", VA = "0x18576BBC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0002C058 File Offset: 0x0002A258
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A19")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yxz
		{
			[Token(Token = "0x6002087")]
			[Address(RVA = "0x576BC60", Offset = "0x576A860", VA = "0x18576BC60")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002088")]
			[Address(RVA = "0x576D9E0", Offset = "0x576C5E0", VA = "0x18576D9E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0002C070 File Offset: 0x0002A270
		[Token(Token = "0x17000A1A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyx
		{
			[Token(Token = "0x6002089")]
			[Address(RVA = "0x576BDC0", Offset = "0x576A9C0", VA = "0x18576BDC0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x0600208A RID: 8330 RVA: 0x0002C088 File Offset: 0x0002A288
		[Token(Token = "0x17000A1B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyy
		{
			[Token(Token = "0x600208A")]
			[Address(RVA = "0x576BE60", Offset = "0x576AA60", VA = "0x18576BE60")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0002C0A0 File Offset: 0x0002A2A0
		[Token(Token = "0x17000A1C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yyz
		{
			[Token(Token = "0x600208B")]
			[Address(RVA = "0x576BEF0", Offset = "0x576AAF0", VA = "0x18576BEF0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x0600208C RID: 8332 RVA: 0x0002C0B8 File Offset: 0x0002A2B8
		// (set) Token: 0x0600208D RID: 8333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A1D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yzx
		{
			[Token(Token = "0x600208C")]
			[Address(RVA = "0x576C050", Offset = "0x576AC50", VA = "0x18576C050")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x600208D")]
			[Address(RVA = "0x576DA70", Offset = "0x576C670", VA = "0x18576DA70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x0600208E RID: 8334 RVA: 0x0002C0D0 File Offset: 0x0002A2D0
		[Token(Token = "0x17000A1E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yzy
		{
			[Token(Token = "0x600208E")]
			[Address(RVA = "0x576C0F0", Offset = "0x576ACF0", VA = "0x18576C0F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0002C0E8 File Offset: 0x0002A2E8
		[Token(Token = "0x17000A1F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 yzz
		{
			[Token(Token = "0x600208F")]
			[Address(RVA = "0x576C190", Offset = "0x576AD90", VA = "0x18576C190")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06002090 RID: 8336 RVA: 0x0002C100 File Offset: 0x0002A300
		[Token(Token = "0x17000A20")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zxx
		{
			[Token(Token = "0x6002090")]
			[Address(RVA = "0x576C570", Offset = "0x576B170", VA = "0x18576C570")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0002C118 File Offset: 0x0002A318
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A21")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zxy
		{
			[Token(Token = "0x6002091")]
			[Address(RVA = "0x576C610", Offset = "0x576B210", VA = "0x18576C610")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002092")]
			[Address(RVA = "0x576DB90", Offset = "0x576C790", VA = "0x18576DB90")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x0002C130 File Offset: 0x0002A330
		[Token(Token = "0x17000A22")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zxz
		{
			[Token(Token = "0x6002093")]
			[Address(RVA = "0x576C6B0", Offset = "0x576B2B0", VA = "0x18576C6B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06002094 RID: 8340 RVA: 0x0002C148 File Offset: 0x0002A348
		// (set) Token: 0x06002095 RID: 8341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A23")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zyx
		{
			[Token(Token = "0x6002094")]
			[Address(RVA = "0x576C810", Offset = "0x576B410", VA = "0x18576C810")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
			[Token(Token = "0x6002095")]
			[Address(RVA = "0x576DC20", Offset = "0x576C820", VA = "0x18576DC20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06002096 RID: 8342 RVA: 0x0002C160 File Offset: 0x0002A360
		[Token(Token = "0x17000A24")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zyy
		{
			[Token(Token = "0x6002096")]
			[Address(RVA = "0x576C8B0", Offset = "0x576B4B0", VA = "0x18576C8B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x0002C178 File Offset: 0x0002A378
		[Token(Token = "0x17000A25")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zyz
		{
			[Token(Token = "0x6002097")]
			[Address(RVA = "0x576C950", Offset = "0x576B550", VA = "0x18576C950")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06002098 RID: 8344 RVA: 0x0002C190 File Offset: 0x0002A390
		[Token(Token = "0x17000A26")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zzx
		{
			[Token(Token = "0x6002098")]
			[Address(RVA = "0x576CAB0", Offset = "0x576B6B0", VA = "0x18576CAB0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x0002C1A8 File Offset: 0x0002A3A8
		[Token(Token = "0x17000A27")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zzy
		{
			[Token(Token = "0x6002099")]
			[Address(RVA = "0x576CB50", Offset = "0x576B750", VA = "0x18576CB50")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x0600209A RID: 8346 RVA: 0x0002C1C0 File Offset: 0x0002A3C0
		[Token(Token = "0x17000A28")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint3 zzz
		{
			[Token(Token = "0x600209A")]
			[Address(RVA = "0x576CBF0", Offset = "0x576B7F0", VA = "0x18576CBF0")]
			[MethodImpl(256)]
			get
			{
				return default(uint3);
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x0002C1D8 File Offset: 0x0002A3D8
		[Token(Token = "0x17000A29")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xx
		{
			[Token(Token = "0x600209B")]
			[Address(RVA = "0x576B000", Offset = "0x5769C00", VA = "0x18576B000")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x0600209C RID: 8348 RVA: 0x0002C1F0 File Offset: 0x0002A3F0
		// (set) Token: 0x0600209D RID: 8349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xy
		{
			[Token(Token = "0x600209C")]
			[Address(RVA = "0x576B280", Offset = "0x5769E80", VA = "0x18576B280")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x600209D")]
			[Address(RVA = "0x576D820", Offset = "0x576C420", VA = "0x18576D820")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x0600209E RID: 8350 RVA: 0x0002C208 File Offset: 0x0002A408
		// (set) Token: 0x0600209F RID: 8351 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 xz
		{
			[Token(Token = "0x600209E")]
			[Address(RVA = "0x576B520", Offset = "0x576A120", VA = "0x18576B520")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x600209F")]
			[Address(RVA = "0x576D870", Offset = "0x576C470", VA = "0x18576D870")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x060020A0 RID: 8352 RVA: 0x0002C220 File Offset: 0x0002A420
		// (set) Token: 0x060020A1 RID: 8353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yx
		{
			[Token(Token = "0x60020A0")]
			[Address(RVA = "0x576BA60", Offset = "0x576A660", VA = "0x18576BA60")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x60020A1")]
			[Address(RVA = "0x576D990", Offset = "0x576C590", VA = "0x18576D990")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x060020A2 RID: 8354 RVA: 0x0002C238 File Offset: 0x0002A438
		[Token(Token = "0x17000A2D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yy
		{
			[Token(Token = "0x60020A2")]
			[Address(RVA = "0x576BD00", Offset = "0x576A900", VA = "0x18576BD00")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x0002C250 File Offset: 0x0002A450
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 yz
		{
			[Token(Token = "0x60020A3")]
			[Address(RVA = "0x576BF90", Offset = "0x576AB90", VA = "0x18576BF90")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x60020A4")]
			[Address(RVA = "0x576DA20", Offset = "0x576C620", VA = "0x18576DA20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x0002C268 File Offset: 0x0002A468
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A2F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 zx
		{
			[Token(Token = "0x60020A5")]
			[Address(RVA = "0x576C4B0", Offset = "0x576B0B0", VA = "0x18576C4B0")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x60020A6")]
			[Address(RVA = "0x576DB40", Offset = "0x576C740", VA = "0x18576DB40")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x0002C280 File Offset: 0x0002A480
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000A30")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 zy
		{
			[Token(Token = "0x60020A7")]
			[Address(RVA = "0x576C750", Offset = "0x576B350", VA = "0x18576C750")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
			[Token(Token = "0x60020A8")]
			[Address(RVA = "0x576DBD0", Offset = "0x576C7D0", VA = "0x18576DBD0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x0002C298 File Offset: 0x0002A498
		[Token(Token = "0x17000A31")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public uint2 zz
		{
			[Token(Token = "0x60020A9")]
			[Address(RVA = "0x576C9F0", Offset = "0x576B5F0", VA = "0x18576C9F0")]
			[MethodImpl(256)]
			get
			{
				return default(uint2);
			}
		}

		// Token: 0x17000A32 RID: 2610
		[Token(Token = "0x17000A32")]
		public uint this[int index]
		{
			[Token(Token = "0x60020AA")]
			[Address(RVA = "0x3D284D0", Offset = "0x3D270D0", VA = "0x183D284D0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60020AB")]
			[Address(RVA = "0x3D288C0", Offset = "0x3D274C0", VA = "0x183D288C0")]
			set
			{
			}
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0002C2C8 File Offset: 0x0002A4C8
		[Token(Token = "0x60020AC")]
		[Address(RVA = "0x57DFAC0", Offset = "0x57DE6C0", VA = "0x1857DFAC0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(uint3 rhs)
		{
			return default(bool);
		}

		// Token: 0x060020AD RID: 8365 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
		[Token(Token = "0x60020AD")]
		[Address(RVA = "0x5814970", Offset = "0x5813570", VA = "0x185814970", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x060020AE RID: 8366 RVA: 0x0002C2F8 File Offset: 0x0002A4F8
		[Token(Token = "0x60020AE")]
		[Address(RVA = "0x571CE30", Offset = "0x571BA30", VA = "0x18571CE30", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060020AF RID: 8367 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60020AF")]
		[Address(RVA = "0x5814AE0", Offset = "0x58136E0", VA = "0x185814AE0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x60020B0")]
		[Address(RVA = "0x5814A20", Offset = "0x5813620", VA = "0x185814A20", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0x0")]
		public uint x;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0x4")]
		public uint y;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x8")]
		public uint z;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly uint3 zero;

		// Token: 0x02000057 RID: 87
		[Token(Token = "0x2000057")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x060020B1 RID: 8369 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60020B1")]
			[Address(RVA = "0x57A9750", Offset = "0x57A8350", VA = "0x1857A9750")]
			public DebuggerProxy(uint3 v)
			{
			}

			// Token: 0x04000140 RID: 320
			[Token(Token = "0x4000140")]
			[FieldOffset(Offset = "0x10")]
			public uint x;

			// Token: 0x04000141 RID: 321
			[Token(Token = "0x4000141")]
			[FieldOffset(Offset = "0x14")]
			public uint y;

			// Token: 0x04000142 RID: 322
			[Token(Token = "0x4000142")]
			[FieldOffset(Offset = "0x18")]
			public uint z;
		}
	}
}
