using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	[Il2CppEagerStaticClassConstruction]
	[Serializable]
	public struct Random
	{
		// Token: 0x06001E35 RID: 7733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E35")]
		[Address(RVA = "0x580D640", Offset = "0x580C240", VA = "0x18580D640")]
		[MethodImpl(256)]
		public Random(uint seed)
		{
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x00029100 File Offset: 0x00027300
		[Token(Token = "0x6001E36")]
		[Address(RVA = "0x580D600", Offset = "0x580C200", VA = "0x18580D600")]
		[MethodImpl(256)]
		public static Random CreateFromIndex(uint index)
		{
			return default(Random);
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x00029118 File Offset: 0x00027318
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x580F5B0", Offset = "0x580E1B0", VA = "0x18580F5B0")]
		[MethodImpl(256)]
		internal static uint WangHash(uint n)
		{
			return 0U;
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x580D640", Offset = "0x580C240", VA = "0x18580D640")]
		[MethodImpl(256)]
		public void InitState(uint seed = 1851936439U)
		{
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00029130 File Offset: 0x00027330
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x580D850", Offset = "0x580C450", VA = "0x18580D850")]
		[MethodImpl(256)]
		public bool NextBool()
		{
			return default(bool);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00029148 File Offset: 0x00027348
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0x580D660", Offset = "0x580C260", VA = "0x18580D660")]
		[MethodImpl(256)]
		public bool2 NextBool2()
		{
			return default(bool2);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00029160 File Offset: 0x00027360
		[Token(Token = "0x6001E3B")]
		[Address(RVA = "0x580D6E0", Offset = "0x580C2E0", VA = "0x18580D6E0")]
		[MethodImpl(256)]
		public bool3 NextBool3()
		{
			return default(bool3);
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00029178 File Offset: 0x00027378
		[Token(Token = "0x6001E3C")]
		[Address(RVA = "0x580D780", Offset = "0x580C380", VA = "0x18580D780")]
		[MethodImpl(256)]
		public bool4 NextBool4()
		{
			return default(bool4);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00029190 File Offset: 0x00027390
		[Token(Token = "0x6001E3D")]
		[Address(RVA = "0x580ED90", Offset = "0x580D990", VA = "0x18580ED90")]
		[MethodImpl(256)]
		public int NextInt()
		{
			return 0;
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x000291A8 File Offset: 0x000273A8
		[Token(Token = "0x6001E3E")]
		[Address(RVA = "0x580E750", Offset = "0x580D350", VA = "0x18580E750")]
		[MethodImpl(256)]
		public int2 NextInt2()
		{
			return default(int2);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x000291C0 File Offset: 0x000273C0
		[Token(Token = "0x6001E3F")]
		[Address(RVA = "0x580E950", Offset = "0x580D550", VA = "0x18580E950")]
		[MethodImpl(256)]
		public int3 NextInt3()
		{
			return default(int3);
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x000291D8 File Offset: 0x000273D8
		[Token(Token = "0x6001E40")]
		[Address(RVA = "0x580EC30", Offset = "0x580D830", VA = "0x18580EC30")]
		[MethodImpl(256)]
		public int4 NextInt4()
		{
			return default(int4);
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x000291F0 File Offset: 0x000273F0
		[Token(Token = "0x6001E41")]
		[Address(RVA = "0x580ED60", Offset = "0x580D960", VA = "0x18580ED60")]
		[MethodImpl(256)]
		public int NextInt(int max)
		{
			return 0;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x00029208 File Offset: 0x00027408
		[Token(Token = "0x6001E42")]
		[Address(RVA = "0x580E6E0", Offset = "0x580D2E0", VA = "0x18580E6E0")]
		[MethodImpl(256)]
		public int2 NextInt2(int2 max)
		{
			return default(int2);
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00029220 File Offset: 0x00027420
		[Token(Token = "0x6001E43")]
		[Address(RVA = "0x580E890", Offset = "0x580D490", VA = "0x18580E890")]
		[MethodImpl(256)]
		public int3 NextInt3(int3 max)
		{
			return default(int3);
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00029238 File Offset: 0x00027438
		[Token(Token = "0x6001E44")]
		[Address(RVA = "0x580EB40", Offset = "0x580D740", VA = "0x18580EB40")]
		[MethodImpl(256)]
		public int4 NextInt4(int4 max)
		{
			return default(int4);
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00029250 File Offset: 0x00027450
		[Token(Token = "0x6001E45")]
		[Address(RVA = "0x580ED20", Offset = "0x580D920", VA = "0x18580ED20")]
		[MethodImpl(256)]
		public int NextInt(int min, int max)
		{
			return 0;
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00029268 File Offset: 0x00027468
		[Token(Token = "0x6001E46")]
		[Address(RVA = "0x580E7C0", Offset = "0x580D3C0", VA = "0x18580E7C0")]
		[MethodImpl(256)]
		public int2 NextInt2(int2 min, int2 max)
		{
			return default(int2);
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x00029280 File Offset: 0x00027480
		[Token(Token = "0x6001E47")]
		[Address(RVA = "0x580EA00", Offset = "0x580D600", VA = "0x18580EA00")]
		[MethodImpl(256)]
		public int3 NextInt3(int3 min, int3 max)
		{
			return default(int3);
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x00029298 File Offset: 0x00027498
		[Token(Token = "0x6001E48")]
		[Address(RVA = "0x580AAB0", Offset = "0x58096B0", VA = "0x18580AAB0")]
		[MethodImpl(256)]
		public int4 NextInt4(int4 min, int4 max)
		{
			return default(int4);
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000292B0 File Offset: 0x000274B0
		[Token(Token = "0x6001E49")]
		[Address(RVA = "0x580F580", Offset = "0x580E180", VA = "0x18580F580")]
		[MethodImpl(256)]
		public uint NextUInt()
		{
			return 0U;
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000292C8 File Offset: 0x000274C8
		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0x580F090", Offset = "0x580DC90", VA = "0x18580F090")]
		[MethodImpl(256)]
		public uint2 NextUInt2()
		{
			return default(uint2);
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000292E0 File Offset: 0x000274E0
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0x580F2E0", Offset = "0x580DEE0", VA = "0x18580F2E0")]
		[MethodImpl(256)]
		public uint3 NextUInt3()
		{
			return default(uint3);
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x000292F8 File Offset: 0x000274F8
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x580F380", Offset = "0x580DF80", VA = "0x18580F380")]
		[MethodImpl(256)]
		public uint4 NextUInt4()
		{
			return default(uint4);
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00029310 File Offset: 0x00027510
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x580F550", Offset = "0x580E150", VA = "0x18580F550")]
		[MethodImpl(256)]
		public uint NextUInt(uint max)
		{
			return 0U;
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x00029328 File Offset: 0x00027528
		[Token(Token = "0x6001E4E")]
		[Address(RVA = "0x580EF60", Offset = "0x580DB60", VA = "0x18580EF60")]
		[MethodImpl(256)]
		public uint2 NextUInt2(uint2 max)
		{
			return default(uint2);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x00029340 File Offset: 0x00027540
		[Token(Token = "0x6001E4F")]
		[Address(RVA = "0x580F220", Offset = "0x580DE20", VA = "0x18580F220")]
		[MethodImpl(256)]
		public uint3 NextUInt3(uint3 max)
		{
			return default(uint3);
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x00029358 File Offset: 0x00027558
		[Token(Token = "0x6001E50")]
		[Address(RVA = "0x580F460", Offset = "0x580E060", VA = "0x18580F460")]
		[MethodImpl(256)]
		public uint4 NextUInt4(uint4 max)
		{
			return default(uint4);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00029370 File Offset: 0x00027570
		[Token(Token = "0x6001E51")]
		[Address(RVA = "0x580ED20", Offset = "0x580D920", VA = "0x18580ED20")]
		[MethodImpl(256)]
		public uint NextUInt(uint min, uint max)
		{
			return 0U;
		}

		// Token: 0x06001E52 RID: 7762 RVA: 0x00029388 File Offset: 0x00027588
		[Token(Token = "0x6001E52")]
		[Address(RVA = "0x580EFD0", Offset = "0x580DBD0", VA = "0x18580EFD0")]
		[MethodImpl(256)]
		public uint2 NextUInt2(uint2 min, uint2 max)
		{
			return default(uint2);
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x000293A0 File Offset: 0x000275A0
		[Token(Token = "0x6001E53")]
		[Address(RVA = "0x580F0F0", Offset = "0x580DCF0", VA = "0x18580F0F0")]
		[MethodImpl(256)]
		public uint3 NextUInt3(uint3 min, uint3 max)
		{
			return default(uint3);
		}

		// Token: 0x06001E54 RID: 7764 RVA: 0x000293B8 File Offset: 0x000275B8
		[Token(Token = "0x6001E54")]
		[Address(RVA = "0x580AC70", Offset = "0x5809870", VA = "0x18580AC70")]
		[MethodImpl(256)]
		public uint4 NextUInt4(uint4 min, uint4 max)
		{
			return default(uint4);
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x000293D0 File Offset: 0x000275D0
		[Token(Token = "0x6001E55")]
		[Address(RVA = "0x580E6A0", Offset = "0x580D2A0", VA = "0x18580E6A0")]
		[MethodImpl(256)]
		public float NextFloat()
		{
			return 0f;
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x000293E8 File Offset: 0x000275E8
		[Token(Token = "0x6001E56")]
		[Address(RVA = "0x580A750", Offset = "0x5809350", VA = "0x18580A750")]
		[MethodImpl(256)]
		public float2 NextFloat2()
		{
			return default(float2);
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x00029400 File Offset: 0x00027600
		[Token(Token = "0x6001E57")]
		[Address(RVA = "0x580A810", Offset = "0x5809410", VA = "0x18580A810")]
		[MethodImpl(256)]
		public float3 NextFloat3()
		{
			return default(float3);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x00029418 File Offset: 0x00027618
		[Token(Token = "0x6001E58")]
		[Address(RVA = "0x580A920", Offset = "0x5809520", VA = "0x18580A920")]
		[MethodImpl(256)]
		public float4 NextFloat4()
		{
			return default(float4);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x00029430 File Offset: 0x00027630
		[Token(Token = "0x6001E59")]
		[Address(RVA = "0x580E610", Offset = "0x580D210", VA = "0x18580E610")]
		[MethodImpl(256)]
		public float NextFloat(float max)
		{
			return 0f;
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00029448 File Offset: 0x00027648
		[Token(Token = "0x6001E5A")]
		[Address(RVA = "0x580E160", Offset = "0x580CD60", VA = "0x18580E160")]
		[MethodImpl(256)]
		public float2 NextFloat2(float2 max)
		{
			return default(float2);
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x00029460 File Offset: 0x00027660
		[Token(Token = "0x6001E5B")]
		[Address(RVA = "0x580E2F0", Offset = "0x580CEF0", VA = "0x18580E2F0")]
		[MethodImpl(256)]
		public float3 NextFloat3(float3 max)
		{
			return default(float3);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00029478 File Offset: 0x00027678
		[Token(Token = "0x6001E5C")]
		[Address(RVA = "0x580E580", Offset = "0x580D180", VA = "0x18580E580")]
		[MethodImpl(256)]
		public float4 NextFloat4(float4 max)
		{
			return default(float4);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x00029490 File Offset: 0x00027690
		[Token(Token = "0x6001E5D")]
		[Address(RVA = "0x580E650", Offset = "0x580D250", VA = "0x18580E650")]
		[MethodImpl(256)]
		public float NextFloat(float min, float max)
		{
			return 0f;
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x000294A8 File Offset: 0x000276A8
		[Token(Token = "0x6001E5E")]
		[Address(RVA = "0x580E0F0", Offset = "0x580CCF0", VA = "0x18580E0F0")]
		[MethodImpl(256)]
		public float2 NextFloat2(float2 min, float2 max)
		{
			return default(float2);
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x000294C0 File Offset: 0x000276C0
		[Token(Token = "0x6001E5F")]
		[Address(RVA = "0x580E370", Offset = "0x580CF70", VA = "0x18580E370")]
		[MethodImpl(256)]
		public float3 NextFloat3(float3 min, float3 max)
		{
			return default(float3);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x000294D8 File Offset: 0x000276D8
		[Token(Token = "0x6001E60")]
		[Address(RVA = "0x580E460", Offset = "0x580D060", VA = "0x18580E460")]
		[MethodImpl(256)]
		public float4 NextFloat4(float4 min, float4 max)
		{
			return default(float4);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x000294F0 File Offset: 0x000276F0
		[Token(Token = "0x6001E61")]
		[Address(RVA = "0x580DF20", Offset = "0x580CB20", VA = "0x18580DF20")]
		[MethodImpl(256)]
		public double NextDouble()
		{
			return 0.0;
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x00029508 File Offset: 0x00027708
		[Token(Token = "0x6001E62")]
		[Address(RVA = "0x580A180", Offset = "0x5808D80", VA = "0x18580A180")]
		[MethodImpl(256)]
		public double2 NextDouble2()
		{
			return default(double2);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x00029520 File Offset: 0x00027720
		[Token(Token = "0x6001E63")]
		[Address(RVA = "0x580A4A0", Offset = "0x58090A0", VA = "0x18580A4A0")]
		[MethodImpl(256)]
		public double3 NextDouble3()
		{
			return default(double3);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00029538 File Offset: 0x00027738
		[Token(Token = "0x6001E64")]
		[Address(RVA = "0x580A5D0", Offset = "0x58091D0", VA = "0x18580A5D0")]
		[MethodImpl(256)]
		public double4 NextDouble4()
		{
			return default(double4);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x00029550 File Offset: 0x00027750
		[Token(Token = "0x6001E65")]
		[Address(RVA = "0x580DF90", Offset = "0x580CB90", VA = "0x18580DF90")]
		[MethodImpl(256)]
		public double NextDouble(double max)
		{
			return 0.0;
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x00029568 File Offset: 0x00027768
		[Token(Token = "0x6001E66")]
		[Address(RVA = "0x580D9A0", Offset = "0x580C5A0", VA = "0x18580D9A0")]
		[MethodImpl(256)]
		public double2 NextDouble2(double2 max)
		{
			return default(double2);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x00029580 File Offset: 0x00027780
		[Token(Token = "0x6001E67")]
		[Address(RVA = "0x580DBE0", Offset = "0x580C7E0", VA = "0x18580DBE0")]
		[MethodImpl(256)]
		public double3 NextDouble3(double3 max)
		{
			return default(double3);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x00029598 File Offset: 0x00027798
		[Token(Token = "0x6001E68")]
		[Address(RVA = "0x580DE20", Offset = "0x580CA20", VA = "0x18580DE20")]
		[MethodImpl(256)]
		public double4 NextDouble4(double4 max)
		{
			return default(double4);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x000295B0 File Offset: 0x000277B0
		[Token(Token = "0x6001E69")]
		[Address(RVA = "0x580DEA0", Offset = "0x580CAA0", VA = "0x18580DEA0")]
		[MethodImpl(256)]
		public double NextDouble(double min, double max)
		{
			return 0.0;
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x000295C8 File Offset: 0x000277C8
		[Token(Token = "0x6001E6A")]
		[Address(RVA = "0x580DAB0", Offset = "0x580C6B0", VA = "0x18580DAB0")]
		[MethodImpl(256)]
		public double2 NextDouble2(double2 min, double2 max)
		{
			return default(double2);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x000295E0 File Offset: 0x000277E0
		[Token(Token = "0x6001E6B")]
		[Address(RVA = "0x580DC50", Offset = "0x580C850", VA = "0x18580DC50")]
		[MethodImpl(256)]
		public double3 NextDouble3(double3 min, double3 max)
		{
			return default(double3);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x000295F8 File Offset: 0x000277F8
		[Token(Token = "0x6001E6C")]
		[Address(RVA = "0x580DD20", Offset = "0x580C920", VA = "0x18580DD20")]
		[MethodImpl(256)]
		public double4 NextDouble4(double4 min, double4 max)
		{
			return default(double4);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x00029610 File Offset: 0x00027810
		[Token(Token = "0x6001E6D")]
		[Address(RVA = "0x580E000", Offset = "0x580CC00", VA = "0x18580E000")]
		[MethodImpl(256)]
		public float2 NextFloat2Direction()
		{
			return default(float2);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x00029628 File Offset: 0x00027828
		[Token(Token = "0x6001E6E")]
		[Address(RVA = "0x580D880", Offset = "0x580C480", VA = "0x18580D880")]
		[MethodImpl(256)]
		public double2 NextDouble2Direction()
		{
			return default(double2);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x00029640 File Offset: 0x00027840
		[Token(Token = "0x6001E6F")]
		[Address(RVA = "0x580E1A0", Offset = "0x580CDA0", VA = "0x18580E1A0")]
		[MethodImpl(256)]
		public float3 NextFloat3Direction()
		{
			return default(float3);
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x00029658 File Offset: 0x00027858
		[Token(Token = "0x6001E70")]
		[Address(RVA = "0x580A270", Offset = "0x5808E70", VA = "0x18580A270")]
		[MethodImpl(256)]
		public double3 NextDouble3Direction()
		{
			return default(double3);
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x00029670 File Offset: 0x00027870
		[Token(Token = "0x6001E71")]
		[Address(RVA = "0x580EDC0", Offset = "0x580D9C0", VA = "0x18580EDC0")]
		[MethodImpl(256)]
		public quaternion NextQuaternionRotation()
		{
			return default(quaternion);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x00029688 File Offset: 0x00027888
		[Token(Token = "0x6001E72")]
		[Address(RVA = "0x580EF40", Offset = "0x580DB40", VA = "0x18580EF40")]
		[MethodImpl(256)]
		private uint NextState()
		{
			return 0U;
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E73")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckInitState()
		{
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E74")]
		[Address(RVA = "0x580D590", Offset = "0x580C190", VA = "0x18580D590")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private static void CheckIndexForHash(uint index)
		{
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E75")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckState()
		{
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E76")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckNextIntMax(int max)
		{
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E77")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckNextIntMinMax(int min, int max)
		{
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001E78")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
		private void CheckNextUIntMinMax(uint min, uint max)
		{
		}

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x0")]
		public uint state;
	}
}
