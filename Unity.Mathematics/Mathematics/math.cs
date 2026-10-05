using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;

namespace Unity.Mathematics
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[Il2CppEagerStaticClassConstruction]
	public static class math
	{
		// Token: 0x0600003B RID: 59 RVA: 0x000024F0 File Offset: 0x000006F0
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x5708900", Offset = "0x5707500", VA = "0x185708900")]
		[MethodImpl(256)]
		public static bool2 bool2(bool x, bool y)
		{
			return default(bool2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x5708920", Offset = "0x5707520", VA = "0x185708920")]
		[MethodImpl(256)]
		public static bool2 bool2(bool2 xy)
		{
			return default(bool2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002520 File Offset: 0x00000720
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x5708910", Offset = "0x5707510", VA = "0x185708910")]
		[MethodImpl(256)]
		public static bool2 bool2(bool v)
		{
			return default(bool2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x571EFD0", Offset = "0x571DBD0", VA = "0x18571EFD0")]
		[MethodImpl(256)]
		public static uint hash(bool2 v)
		{
			return 0U;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x5723A90", Offset = "0x5722690", VA = "0x185723A90")]
		[MethodImpl(256)]
		public static uint2 hashwide(bool2 v)
		{
			return default(uint2);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x574A730", Offset = "0x5749330", VA = "0x18574A730")]
		[MethodImpl(256)]
		public static bool shuffle(bool2 left, bool2 right, math.ShuffleComponent x)
		{
			return default(bool);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x574C560", Offset = "0x574B160", VA = "0x18574C560")]
		[MethodImpl(256)]
		public static bool2 shuffle(bool2 left, bool2 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(bool2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x574A950", Offset = "0x5749550", VA = "0x18574A950")]
		[MethodImpl(256)]
		public static bool3 shuffle(bool2 left, bool2 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(bool3);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x574AFE0", Offset = "0x5749BE0", VA = "0x18574AFE0")]
		[MethodImpl(256)]
		public static bool4 shuffle(bool2 left, bool2 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(bool4);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x57024D0", Offset = "0x57010D0", VA = "0x1857024D0")]
		[MethodImpl(256)]
		internal static bool select_shuffle_component(bool2 a, bool2 b, math.ShuffleComponent component)
		{
			return default(bool);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x5708940", Offset = "0x5707540", VA = "0x185708940")]
		[MethodImpl(256)]
		public static bool2x2 bool2x2(bool2 c0, bool2 c1)
		{
			return default(bool2x2);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x5708980", Offset = "0x5707580", VA = "0x185708980")]
		[MethodImpl(256)]
		public static bool2x2 bool2x2(bool m00, bool m01, bool m10, bool m11)
		{
			return default(bool2x2);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x5708950", Offset = "0x5707550", VA = "0x185708950")]
		[MethodImpl(256)]
		public static bool2x2 bool2x2(bool v)
		{
			return default(bool2x2);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x5751B90", Offset = "0x5750790", VA = "0x185751B90")]
		[MethodImpl(256)]
		public static bool2x2 transpose(bool2x2 v)
		{
			return default(bool2x2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x571EBE0", Offset = "0x571D7E0", VA = "0x18571EBE0")]
		[MethodImpl(256)]
		public static uint hash(bool2x2 v)
		{
			return 0U;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x5726D20", Offset = "0x5725920", VA = "0x185726D20")]
		[MethodImpl(256)]
		public static uint2 hashwide(bool2x2 v)
		{
			return default(uint2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x57089B0", Offset = "0x57075B0", VA = "0x1857089B0")]
		[MethodImpl(256)]
		public static bool2x3 bool2x3(bool2 c0, bool2 c1, bool2 c2)
		{
			return default(bool2x3);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x57089D0", Offset = "0x57075D0", VA = "0x1857089D0")]
		[MethodImpl(256)]
		public static bool2x3 bool2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12)
		{
			return default(bool2x3);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x5708A20", Offset = "0x5707620", VA = "0x185708A20")]
		[MethodImpl(256)]
		public static bool2x3 bool2x3(bool v)
		{
			return default(bool2x3);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x5751870", Offset = "0x5750470", VA = "0x185751870")]
		[MethodImpl(256)]
		public static bool3x2 transpose(bool2x3 v)
		{
			return default(bool3x2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x5721040", Offset = "0x571FC40", VA = "0x185721040")]
		[MethodImpl(256)]
		public static uint hash(bool2x3 v)
		{
			return 0U;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x57241D0", Offset = "0x5722DD0", VA = "0x1857241D0")]
		[MethodImpl(256)]
		public static uint2 hashwide(bool2x3 v)
		{
			return default(uint2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x5708A60", Offset = "0x5707660", VA = "0x185708A60")]
		[MethodImpl(256)]
		public static bool2x4 bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3)
		{
			return default(bool2x4);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x5708A90", Offset = "0x5707690", VA = "0x185708A90")]
		[MethodImpl(256)]
		public static bool2x4 bool2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13)
		{
			return default(bool2x4);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x5708B00", Offset = "0x5707700", VA = "0x185708B00")]
		[MethodImpl(256)]
		public static bool2x4 bool2x4(bool v)
		{
			return default(bool2x4);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x5752290", Offset = "0x5750E90", VA = "0x185752290")]
		[MethodImpl(256)]
		public static bool4x2 transpose(bool2x4 v)
		{
			return default(bool4x2);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x571FB30", Offset = "0x571E730", VA = "0x18571FB30")]
		[MethodImpl(256)]
		public static uint hash(bool2x4 v)
		{
			return 0U;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x5727FA0", Offset = "0x5726BA0", VA = "0x185727FA0")]
		[MethodImpl(256)]
		public static uint2 hashwide(bool2x4 v)
		{
			return default(uint2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x5708B50", Offset = "0x5707750", VA = "0x185708B50")]
		[MethodImpl(256)]
		public static bool3 bool3(bool x, bool y, bool z)
		{
			return default(bool3);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x5708B90", Offset = "0x5707790", VA = "0x185708B90")]
		[MethodImpl(256)]
		public static bool3 bool3(bool x, bool2 yz)
		{
			return default(bool3);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x5708B70", Offset = "0x5707770", VA = "0x185708B70")]
		[MethodImpl(256)]
		public static bool3 bool3(bool2 xy, bool z)
		{
			return default(bool3);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x5708BB0", Offset = "0x57077B0", VA = "0x185708BB0")]
		[MethodImpl(256)]
		public static bool3 bool3(bool3 xyz)
		{
			return default(bool3);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x5708B60", Offset = "0x5707760", VA = "0x185708B60")]
		[MethodImpl(256)]
		public static bool3 bool3(bool v)
		{
			return default(bool3);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x571CDB0", Offset = "0x571B9B0", VA = "0x18571CDB0")]
		[MethodImpl(256)]
		public static uint hash(bool3 v)
		{
			return 0U;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x5725880", Offset = "0x5724480", VA = "0x185725880")]
		[MethodImpl(256)]
		public static uint3 hashwide(bool3 v)
		{
			return default(uint3);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x574B440", Offset = "0x574A040", VA = "0x18574B440")]
		[MethodImpl(256)]
		public static bool shuffle(bool3 left, bool3 right, math.ShuffleComponent x)
		{
			return default(bool);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x574C210", Offset = "0x574AE10", VA = "0x18574C210")]
		[MethodImpl(256)]
		public static bool2 shuffle(bool3 left, bool3 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(bool2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x574B640", Offset = "0x574A240", VA = "0x18574B640")]
		[MethodImpl(256)]
		public static bool3 shuffle(bool3 left, bool3 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(bool3);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x574A740", Offset = "0x5749340", VA = "0x18574A740")]
		[MethodImpl(256)]
		public static bool4 shuffle(bool3 left, bool3 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(bool4);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x5702960", Offset = "0x5701560", VA = "0x185702960")]
		[MethodImpl(256)]
		internal static bool select_shuffle_component(bool3 a, bool3 b, math.ShuffleComponent component)
		{
			return default(bool);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x5708C20", Offset = "0x5707820", VA = "0x185708C20")]
		[MethodImpl(256)]
		public static bool3x2 bool3x2(bool3 c0, bool3 c1)
		{
			return default(bool3x2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x5708BE0", Offset = "0x57077E0", VA = "0x185708BE0")]
		[MethodImpl(256)]
		public static bool3x2 bool3x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21)
		{
			return default(bool3x2);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x5708C50", Offset = "0x5707850", VA = "0x185708C50")]
		[MethodImpl(256)]
		public static bool3x2 bool3x2(bool v)
		{
			return default(bool3x2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x57525F0", Offset = "0x57511F0", VA = "0x1857525F0")]
		[MethodImpl(256)]
		public static bool2x3 transpose(bool3x2 v)
		{
			return default(bool2x3);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x5720330", Offset = "0x571EF30", VA = "0x185720330")]
		[MethodImpl(256)]
		public static uint hash(bool3x2 v)
		{
			return 0U;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002928 File Offset: 0x00000B28
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x57270B0", Offset = "0x5725CB0", VA = "0x1857270B0")]
		[MethodImpl(256)]
		public static uint3 hashwide(bool3x2 v)
		{
			return default(uint3);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x5708D30", Offset = "0x5707930", VA = "0x185708D30")]
		[MethodImpl(256)]
		public static bool3x3 bool3x3(bool3 c0, bool3 c1, bool3 c2)
		{
			return default(bool3x3);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002958 File Offset: 0x00000B58
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x5708C80", Offset = "0x5707880", VA = "0x185708C80")]
		[MethodImpl(256)]
		public static bool3x3 bool3x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22)
		{
			return default(bool3x3);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002970 File Offset: 0x00000B70
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x5708CF0", Offset = "0x57078F0", VA = "0x185708CF0")]
		[MethodImpl(256)]
		public static bool3x3 bool3x3(bool v)
		{
			return default(bool3x3);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002988 File Offset: 0x00000B88
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x5752220", Offset = "0x5750E20", VA = "0x185752220")]
		[MethodImpl(256)]
		public static bool3x3 transpose(bool3x3 v)
		{
			return default(bool3x3);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x57218B0", Offset = "0x57204B0", VA = "0x1857218B0")]
		[MethodImpl(256)]
		public static uint hash(bool3x3 v)
		{
			return 0U;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x57271D0", Offset = "0x5725DD0", VA = "0x1857271D0")]
		[MethodImpl(256)]
		public static uint3 hashwide(bool3x3 v)
		{
			return default(uint3);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x5708E00", Offset = "0x5707A00", VA = "0x185708E00")]
		[MethodImpl(256)]
		public static bool3x4 bool3x4(bool3 c0, bool3 c1, bool3 c2, bool3 c3)
		{
			return default(bool3x4);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x5708D70", Offset = "0x5707970", VA = "0x185708D70")]
		[MethodImpl(256)]
		public static bool3x4 bool3x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23)
		{
			return default(bool3x4);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x5708E50", Offset = "0x5707A50", VA = "0x185708E50")]
		[MethodImpl(256)]
		public static bool3x4 bool3x4(bool v)
		{
			return default(bool3x4);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x5752650", Offset = "0x5751250", VA = "0x185752650")]
		[MethodImpl(256)]
		public static bool4x3 transpose(bool3x4 v)
		{
			return default(bool4x3);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x571E750", Offset = "0x571D350", VA = "0x18571E750")]
		[MethodImpl(256)]
		public static uint hash(bool3x4 v)
		{
			return 0U;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x5724EA0", Offset = "0x5723AA0", VA = "0x185724EA0")]
		[MethodImpl(256)]
		public static uint3 hashwide(bool3x4 v)
		{
			return default(uint3);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x5708EF0", Offset = "0x5707AF0", VA = "0x185708EF0")]
		[MethodImpl(256)]
		public static bool4 bool4(bool x, bool y, bool z, bool w)
		{
			return default(bool4);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x5708F80", Offset = "0x5707B80", VA = "0x185708F80")]
		[MethodImpl(256)]
		public static bool4 bool4(bool x, bool y, bool2 zw)
		{
			return default(bool4);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x5708ED0", Offset = "0x5707AD0", VA = "0x185708ED0")]
		[MethodImpl(256)]
		public static bool4 bool4(bool x, bool2 yz, bool w)
		{
			return default(bool4);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x5708FD0", Offset = "0x5707BD0", VA = "0x185708FD0")]
		[MethodImpl(256)]
		public static bool4 bool4(bool x, bool3 yzw)
		{
			return default(bool4);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x5708EB0", Offset = "0x5707AB0", VA = "0x185708EB0")]
		[MethodImpl(256)]
		public static bool4 bool4(bool2 xy, bool z, bool w)
		{
			return default(bool4);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x5708F30", Offset = "0x5707B30", VA = "0x185708F30")]
		[MethodImpl(256)]
		public static bool4 bool4(bool2 xy, bool2 zw)
		{
			return default(bool4);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x5708FA0", Offset = "0x5707BA0", VA = "0x185708FA0")]
		[MethodImpl(256)]
		public static bool4 bool4(bool3 xyz, bool w)
		{
			return default(bool4);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x5708F50", Offset = "0x5707B50", VA = "0x185708F50")]
		[MethodImpl(256)]
		public static bool4 bool4(bool4 xyzw)
		{
			return default(bool4);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x5708F10", Offset = "0x5707B10", VA = "0x185708F10")]
		[MethodImpl(256)]
		public static bool4 bool4(bool v)
		{
			return default(bool4);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002B38 File Offset: 0x00000D38
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x571F460", Offset = "0x571E060", VA = "0x18571F460")]
		[MethodImpl(256)]
		public static uint hash(bool4 v)
		{
			return 0U;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x57279E0", Offset = "0x57265E0", VA = "0x1857279E0")]
		[MethodImpl(256)]
		public static uint4 hashwide(bool4 v)
		{
			return default(uint4);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002B68 File Offset: 0x00000D68
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x574A720", Offset = "0x5749320", VA = "0x18574A720")]
		[MethodImpl(256)]
		public static bool shuffle(bool4 left, bool4 right, math.ShuffleComponent x)
		{
			return default(bool);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x574C9A0", Offset = "0x574B5A0", VA = "0x18574C9A0")]
		[MethodImpl(256)]
		public static bool2 shuffle(bool4 left, bool4 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(bool2);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x574C3A0", Offset = "0x574AFA0", VA = "0x18574C3A0")]
		[MethodImpl(256)]
		public static bool3 shuffle(bool4 left, bool4 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(bool3);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x574B8F0", Offset = "0x574A4F0", VA = "0x18574B8F0")]
		[MethodImpl(256)]
		public static bool4 shuffle(bool4 left, bool4 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(bool4);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002BC8 File Offset: 0x00000DC8
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x57023A0", Offset = "0x5700FA0", VA = "0x1857023A0")]
		[MethodImpl(256)]
		internal static bool select_shuffle_component(bool4 a, bool4 b, math.ShuffleComponent component)
		{
			return default(bool);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x57090A0", Offset = "0x5707CA0", VA = "0x1857090A0")]
		[MethodImpl(256)]
		public static bool4x2 bool4x2(bool4 c0, bool4 c1)
		{
			return default(bool4x2);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x5709000", Offset = "0x5707C00", VA = "0x185709000")]
		[MethodImpl(256)]
		public static bool4x2 bool4x2(bool m00, bool m01, bool m10, bool m11, bool m20, bool m21, bool m30, bool m31)
		{
			return default(bool4x2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002C10 File Offset: 0x00000E10
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x5709060", Offset = "0x5707C60", VA = "0x185709060")]
		[MethodImpl(256)]
		public static bool4x2 bool4x2(bool v)
		{
			return default(bool4x2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002C28 File Offset: 0x00000E28
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x5751670", Offset = "0x5750270", VA = "0x185751670")]
		[MethodImpl(256)]
		public static bool2x4 transpose(bool4x2 v)
		{
			return default(bool2x4);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002C40 File Offset: 0x00000E40
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x571DEB0", Offset = "0x571CAB0", VA = "0x18571DEB0")]
		[MethodImpl(256)]
		public static uint hash(bool4x2 v)
		{
			return 0U;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002C58 File Offset: 0x00000E58
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x57264F0", Offset = "0x57250F0", VA = "0x1857264F0")]
		[MethodImpl(256)]
		public static uint4 hashwide(bool4x2 v)
		{
			return default(uint4);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002C70 File Offset: 0x00000E70
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x5709100", Offset = "0x5707D00", VA = "0x185709100")]
		[MethodImpl(256)]
		public static bool4x3 bool4x3(bool4 c0, bool4 c1, bool4 c2)
		{
			return default(bool4x3);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x5709110", Offset = "0x5707D10", VA = "0x185709110")]
		[MethodImpl(256)]
		public static bool4x3 bool4x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12, bool m20, bool m21, bool m22, bool m30, bool m31, bool m32)
		{
			return default(bool4x3);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x57090B0", Offset = "0x5707CB0", VA = "0x1857090B0")]
		[MethodImpl(256)]
		public static bool4x3 bool4x3(bool v)
		{
			return default(bool4x3);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x5752720", Offset = "0x5751320", VA = "0x185752720")]
		[MethodImpl(256)]
		public static bool3x4 transpose(bool4x3 v)
		{
			return default(bool3x4);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x571F520", Offset = "0x571E120", VA = "0x18571F520")]
		[MethodImpl(256)]
		public static uint hash(bool4x3 v)
		{
			return 0U;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x5725910", Offset = "0x5724510", VA = "0x185725910")]
		[MethodImpl(256)]
		public static uint4 hashwide(bool4x3 v)
		{
			return default(uint4);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002D00 File Offset: 0x00000F00
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x5709240", Offset = "0x5707E40", VA = "0x185709240")]
		[MethodImpl(256)]
		public static bool4x4 bool4x4(bool4 c0, bool4 c1, bool4 c2, bool4 c3)
		{
			return default(bool4x4);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002D18 File Offset: 0x00000F18
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x5709190", Offset = "0x5707D90", VA = "0x185709190")]
		[MethodImpl(256)]
		public static bool4x4 bool4x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33)
		{
			return default(bool4x4);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002D30 File Offset: 0x00000F30
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x5709260", Offset = "0x5707E60", VA = "0x185709260")]
		[MethodImpl(256)]
		public static bool4x4 bool4x4(bool v)
		{
			return default(bool4x4);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x57515B0", Offset = "0x57501B0", VA = "0x1857515B0")]
		[MethodImpl(256)]
		public static bool4x4 transpose(bool4x4 v)
		{
			return default(bool4x4);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x5721550", Offset = "0x5720150", VA = "0x185721550")]
		[MethodImpl(256)]
		public static uint hash(bool4x4 v)
		{
			return 0U;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x57284C0", Offset = "0x57270C0", VA = "0x1857284C0")]
		[MethodImpl(256)]
		public static uint4 hashwide(bool4x4 v)
		{
			return default(uint4);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x570DFF0", Offset = "0x570CBF0", VA = "0x18570DFF0")]
		[MethodImpl(256)]
		public static double2 double2(double x, double y)
		{
			return default(double2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x570E130", Offset = "0x570CD30", VA = "0x18570E130")]
		[MethodImpl(256)]
		public static double2 double2(double2 xy)
		{
			return default(double2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x570E290", Offset = "0x570CE90", VA = "0x18570E290")]
		[MethodImpl(256)]
		public static double2 double2(double v)
		{
			return default(double2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x570E250", Offset = "0x570CE50", VA = "0x18570E250")]
		[MethodImpl(256)]
		public static double2 double2(bool v)
		{
			return default(double2);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x570E050", Offset = "0x570CC50", VA = "0x18570E050")]
		[MethodImpl(256)]
		public static double2 double2(bool2 v)
		{
			return default(double2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x570E0F0", Offset = "0x570CCF0", VA = "0x18570E0F0")]
		[MethodImpl(256)]
		public static double2 double2(int v)
		{
			return default(double2);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x570E090", Offset = "0x570CC90", VA = "0x18570E090")]
		[MethodImpl(256)]
		public static double2 double2(int2 v)
		{
			return default(double2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x570E000", Offset = "0x570CC00", VA = "0x18570E000")]
		[MethodImpl(256)]
		public static double2 double2(uint v)
		{
			return default(double2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x570E0C0", Offset = "0x570CCC0", VA = "0x18570E0C0")]
		[MethodImpl(256)]
		public static double2 double2(uint2 v)
		{
			return default(double2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x570DF00", Offset = "0x570CB00", VA = "0x18570DF00")]
		[MethodImpl(256)]
		public static double2 double2(half v)
		{
			return default(double2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x570E150", Offset = "0x570CD50", VA = "0x18570E150")]
		[MethodImpl(256)]
		public static double2 double2(half2 v)
		{
			return default(double2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x570E110", Offset = "0x570CD10", VA = "0x18570E110")]
		[MethodImpl(256)]
		public static double2 double2(float v)
		{
			return default(double2);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x570E020", Offset = "0x570CC20", VA = "0x18570E020")]
		[MethodImpl(256)]
		public static double2 double2(float2 v)
		{
			return default(double2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002EC8 File Offset: 0x000010C8
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x571E6C0", Offset = "0x571D2C0", VA = "0x18571E6C0")]
		[MethodImpl(256)]
		public static uint hash(double2 v)
		{
			return 0U;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x5725F90", Offset = "0x5724B90", VA = "0x185725F90")]
		[MethodImpl(256)]
		public static uint2 hashwide(double2 v)
		{
			return default(uint2);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x574BE30", Offset = "0x574AA30", VA = "0x18574BE30")]
		[MethodImpl(256)]
		public static double shuffle(double2 left, double2 right, math.ShuffleComponent x)
		{
			return 0.0;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x574ADE0", Offset = "0x57499E0", VA = "0x18574ADE0")]
		[MethodImpl(256)]
		public static double2 shuffle(double2 left, double2 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(double2);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x574BA70", Offset = "0x574A670", VA = "0x18574BA70")]
		[MethodImpl(256)]
		public static double3 shuffle(double2 left, double2 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(double3);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x574BFB0", Offset = "0x574ABB0", VA = "0x18574BFB0")]
		[MethodImpl(256)]
		public static double4 shuffle(double2 left, double2 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(double4);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x5702290", Offset = "0x5700E90", VA = "0x185702290")]
		[MethodImpl(256)]
		internal static double select_shuffle_component(double2 a, double2 b, math.ShuffleComponent component)
		{
			return 0.0;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x570E2E0", Offset = "0x570CEE0", VA = "0x18570E2E0")]
		[MethodImpl(256)]
		public static double2x2 double2x2(double2 c0, double2 c1)
		{
			return default(double2x2);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x570E3C0", Offset = "0x570CFC0", VA = "0x18570E3C0")]
		[MethodImpl(256)]
		public static double2x2 double2x2(double m00, double m01, double m10, double m11)
		{
			return default(double2x2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x570E310", Offset = "0x570CF10", VA = "0x18570E310")]
		[MethodImpl(256)]
		public static double2x2 double2x2(double v)
		{
			return default(double2x2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x570E540", Offset = "0x570D140", VA = "0x18570E540")]
		[MethodImpl(256)]
		public static double2x2 double2x2(bool v)
		{
			return default(double2x2);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x570E330", Offset = "0x570CF30", VA = "0x18570E330")]
		[MethodImpl(256)]
		public static double2x2 double2x2(bool2x2 v)
		{
			return default(double2x2);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x570E440", Offset = "0x570D040", VA = "0x18570E440")]
		[MethodImpl(256)]
		public static double2x2 double2x2(int v)
		{
			return default(double2x2);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x570E460", Offset = "0x570D060", VA = "0x18570E460")]
		[MethodImpl(256)]
		public static double2x2 double2x2(int2x2 v)
		{
			return default(double2x2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x570E390", Offset = "0x570CF90", VA = "0x18570E390")]
		[MethodImpl(256)]
		public static double2x2 double2x2(uint v)
		{
			return default(double2x2);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x570E4D0", Offset = "0x570D0D0", VA = "0x18570E4D0")]
		[MethodImpl(256)]
		public static double2x2 double2x2(uint2x2 v)
		{
			return default(double2x2);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x570E2A0", Offset = "0x570CEA0", VA = "0x18570E2A0")]
		[MethodImpl(256)]
		public static double2x2 double2x2(float v)
		{
			return default(double2x2);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x570E3F0", Offset = "0x570CFF0", VA = "0x18570E3F0")]
		[MethodImpl(256)]
		public static double2x2 double2x2(float2x2 v)
		{
			return default(double2x2);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00003078 File Offset: 0x00001278
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x5751BD0", Offset = "0x57507D0", VA = "0x185751BD0")]
		[MethodImpl(256)]
		public static double2x2 transpose(double2x2 v)
		{
			return default(double2x2);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00003090 File Offset: 0x00001290
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x572B430", Offset = "0x572A030", VA = "0x18572B430")]
		[MethodImpl(256)]
		public static double2x2 inverse(double2x2 m)
		{
			return default(double2x2);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x570D7B0", Offset = "0x570C3B0", VA = "0x18570D7B0")]
		[MethodImpl(256)]
		public static double determinant(double2x2 m)
		{
			return 0.0;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000030C0 File Offset: 0x000012C0
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x571E950", Offset = "0x571D550", VA = "0x18571E950")]
		[MethodImpl(256)]
		public static uint hash(double2x2 v)
		{
			return 0U;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000030D8 File Offset: 0x000012D8
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x57278A0", Offset = "0x57264A0", VA = "0x1857278A0")]
		[MethodImpl(256)]
		public static uint2 hashwide(double2x2 v)
		{
			return default(uint2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000030F0 File Offset: 0x000012F0
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x570E970", Offset = "0x570D570", VA = "0x18570E970")]
		[MethodImpl(256)]
		public static double2x3 double2x3(double2 c0, double2 c1, double2 c2)
		{
			return default(double2x3);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x570E930", Offset = "0x570D530", VA = "0x18570E930")]
		[MethodImpl(256)]
		public static double2x3 double2x3(double m00, double m01, double m02, double m10, double m11, double m12)
		{
			return default(double2x3);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x570E5E0", Offset = "0x570D1E0", VA = "0x18570E5E0")]
		[MethodImpl(256)]
		public static double2x3 double2x3(double v)
		{
			return default(double2x3);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x570E680", Offset = "0x570D280", VA = "0x18570E680")]
		[MethodImpl(256)]
		public static double2x3 double2x3(bool v)
		{
			return default(double2x3);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00003150 File Offset: 0x00001350
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x570E7B0", Offset = "0x570D3B0", VA = "0x18570E7B0")]
		[MethodImpl(256)]
		public static double2x3 double2x3(bool2x3 v)
		{
			return default(double2x3);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00003168 File Offset: 0x00001368
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x570E6C0", Offset = "0x570D2C0", VA = "0x18570E6C0")]
		[MethodImpl(256)]
		public static double2x3 double2x3(int v)
		{
			return default(double2x3);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00003180 File Offset: 0x00001380
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x570E870", Offset = "0x570D470", VA = "0x18570E870")]
		[MethodImpl(256)]
		public static double2x3 double2x3(int2x3 v)
		{
			return default(double2x3);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00003198 File Offset: 0x00001398
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x570E570", Offset = "0x570D170", VA = "0x18570E570")]
		[MethodImpl(256)]
		public static double2x3 double2x3(uint v)
		{
			return default(double2x3);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000031B0 File Offset: 0x000013B0
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x570E6E0", Offset = "0x570D2E0", VA = "0x18570E6E0")]
		[MethodImpl(256)]
		public static double2x3 double2x3(uint2x3 v)
		{
			return default(double2x3);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x000031C8 File Offset: 0x000013C8
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x570E590", Offset = "0x570D190", VA = "0x18570E590")]
		[MethodImpl(256)]
		public static double2x3 double2x3(float v)
		{
			return default(double2x3);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000031E0 File Offset: 0x000013E0
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x570E600", Offset = "0x570D200", VA = "0x18570E600")]
		[MethodImpl(256)]
		public static double2x3 double2x3(float2x3 v)
		{
			return default(double2x3);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000031F8 File Offset: 0x000013F8
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x57526E0", Offset = "0x57512E0", VA = "0x1857526E0")]
		[MethodImpl(256)]
		public static double3x2 transpose(double2x3 v)
		{
			return default(double3x2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00003210 File Offset: 0x00001410
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x571CEA0", Offset = "0x571BAA0", VA = "0x18571CEA0")]
		[MethodImpl(256)]
		public static uint hash(double2x3 v)
		{
			return 0U;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x5727360", Offset = "0x5725F60", VA = "0x185727360")]
		[MethodImpl(256)]
		public static uint2 hashwide(double2x3 v)
		{
			return default(uint2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x570E9C0", Offset = "0x570D5C0", VA = "0x18570E9C0")]
		[MethodImpl(256)]
		public static double2x4 double2x4(double2 c0, double2 c1, double2 c2, double2 c3)
		{
			return default(double2x4);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x570EE80", Offset = "0x570DA80", VA = "0x18570EE80")]
		[MethodImpl(256)]
		public static double2x4 double2x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13)
		{
			return default(double2x4);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x570ECF0", Offset = "0x570D8F0", VA = "0x18570ECF0")]
		[MethodImpl(256)]
		public static double2x4 double2x4(double v)
		{
			return default(double2x4);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x570EA20", Offset = "0x570D620", VA = "0x18570EA20")]
		[MethodImpl(256)]
		public static double2x4 double2x4(bool v)
		{
			return default(double2x4);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x570EB50", Offset = "0x570D750", VA = "0x18570EB50")]
		[MethodImpl(256)]
		public static double2x4 double2x4(bool2x4 v)
		{
			return default(double2x4);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x570EE60", Offset = "0x570DA60", VA = "0x18570EE60")]
		[MethodImpl(256)]
		public static double2x4 double2x4(int v)
		{
			return default(double2x4);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x570EC20", Offset = "0x570D820", VA = "0x18570EC20")]
		[MethodImpl(256)]
		public static double2x4 double2x4(int2x4 v)
		{
			return default(double2x4);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x570ED80", Offset = "0x570D980", VA = "0x18570ED80")]
		[MethodImpl(256)]
		public static double2x4 double2x4(uint v)
		{
			return default(double2x4);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x570EA60", Offset = "0x570D660", VA = "0x18570EA60")]
		[MethodImpl(256)]
		public static double2x4 double2x4(uint2x4 v)
		{
			return default(double2x4);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x570ED10", Offset = "0x570D910", VA = "0x18570ED10")]
		[MethodImpl(256)]
		public static double2x4 double2x4(float v)
		{
			return default(double2x4);
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x570EDB0", Offset = "0x570D9B0", VA = "0x18570EDB0")]
		[MethodImpl(256)]
		public static double2x4 double2x4(float2x4 v)
		{
			return default(double2x4);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x5751950", Offset = "0x5750550", VA = "0x185751950")]
		[MethodImpl(256)]
		public static double4x2 transpose(double2x4 v)
		{
			return default(double4x2);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00003360 File Offset: 0x00001560
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x571D910", Offset = "0x571C510", VA = "0x18571D910")]
		[MethodImpl(256)]
		public static uint hash(double2x4 v)
		{
			return 0U;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00003378 File Offset: 0x00001578
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x5728240", Offset = "0x5726E40", VA = "0x185728240")]
		[MethodImpl(256)]
		public static uint2 hashwide(double2x4 v)
		{
			return default(uint2);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00003390 File Offset: 0x00001590
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x570F100", Offset = "0x570DD00", VA = "0x18570F100")]
		[MethodImpl(256)]
		public static double3 double3(double x, double y, double z)
		{
			return default(double3);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000033A8 File Offset: 0x000015A8
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x570F260", Offset = "0x570DE60", VA = "0x18570F260")]
		[MethodImpl(256)]
		public static double3 double3(double x, double2 yz)
		{
			return default(double3);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000033C0 File Offset: 0x000015C0
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x570F190", Offset = "0x570DD90", VA = "0x18570F190")]
		[MethodImpl(256)]
		public static double3 double3(double2 xy, double z)
		{
			return default(double3);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000033D8 File Offset: 0x000015D8
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x570F210", Offset = "0x570DE10", VA = "0x18570F210")]
		[MethodImpl(256)]
		public static double3 double3(double3 xyz)
		{
			return default(double3);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000033F0 File Offset: 0x000015F0
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x570F120", Offset = "0x570DD20", VA = "0x18570F120")]
		[MethodImpl(256)]
		public static double3 double3(double v)
		{
			return default(double3);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x570F280", Offset = "0x570DE80", VA = "0x18570F280")]
		[MethodImpl(256)]
		public static double3 double3(bool v)
		{
			return default(double3);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00003420 File Offset: 0x00001620
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x570F130", Offset = "0x570DD30", VA = "0x18570F130")]
		[MethodImpl(256)]
		public static double3 double3(bool3 v)
		{
			return default(double3);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00003438 File Offset: 0x00001638
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x570F240", Offset = "0x570DE40", VA = "0x18570F240")]
		[MethodImpl(256)]
		public static double3 double3(int v)
		{
			return default(double3);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x570EF10", Offset = "0x570DB10", VA = "0x18570EF10")]
		[MethodImpl(256)]
		public static double3 double3(int3 v)
		{
			return default(double3);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x570F0E0", Offset = "0x570DCE0", VA = "0x18570F0E0")]
		[MethodImpl(256)]
		public static double3 double3(uint v)
		{
			return default(double3);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00003480 File Offset: 0x00001680
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x570F1B0", Offset = "0x570DDB0", VA = "0x18570F1B0")]
		[MethodImpl(256)]
		public static double3 double3(uint3 v)
		{
			return default(double3);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x570F2C0", Offset = "0x570DEC0", VA = "0x18570F2C0")]
		[MethodImpl(256)]
		public static double3 double3(half v)
		{
			return default(double3);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x570EF60", Offset = "0x570DB60", VA = "0x18570EF60")]
		[MethodImpl(256)]
		public static double3 double3(half3 v)
		{
			return default(double3);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x570EEE0", Offset = "0x570DAE0", VA = "0x18570EEE0")]
		[MethodImpl(256)]
		public static double3 double3(float v)
		{
			return default(double3);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x570F410", Offset = "0x570E010", VA = "0x18570F410")]
		[MethodImpl(256)]
		public static double3 double3(float3 v)
		{
			return default(double3);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x571F030", Offset = "0x571DC30", VA = "0x18571F030")]
		[MethodImpl(256)]
		public static uint hash(double3 v)
		{
			return 0U;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x57245B0", Offset = "0x57231B0", VA = "0x1857245B0")]
		[MethodImpl(256)]
		public static uint3 hashwide(double3 v)
		{
			return default(uint3);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x574C5B0", Offset = "0x574B1B0", VA = "0x18574C5B0")]
		[MethodImpl(256)]
		public static double shuffle(double3 left, double3 right, math.ShuffleComponent x)
		{
			return 0.0;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x574A890", Offset = "0x5749490", VA = "0x18574A890")]
		[MethodImpl(256)]
		public static double2 shuffle(double3 left, double3 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(double2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00003558 File Offset: 0x00001758
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x574C710", Offset = "0x574B310", VA = "0x18574C710")]
		[MethodImpl(256)]
		public static double3 shuffle(double3 left, double3 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(double3);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003570 File Offset: 0x00001770
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x574AB00", Offset = "0x5749700", VA = "0x18574AB00")]
		[MethodImpl(256)]
		public static double4 shuffle(double3 left, double3 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(double4);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x5702CA0", Offset = "0x57018A0", VA = "0x185702CA0")]
		[MethodImpl(256)]
		internal static double select_shuffle_component(double3 a, double3 b, math.ShuffleComponent component)
		{
			return 0.0;
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x570F890", Offset = "0x570E490", VA = "0x18570F890")]
		[MethodImpl(256)]
		public static double3x2 double3x2(double3 c0, double3 c1)
		{
			return default(double3x2);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x570F7B0", Offset = "0x570E3B0", VA = "0x18570F7B0")]
		[MethodImpl(256)]
		public static double3x2 double3x2(double m00, double m01, double m10, double m11, double m20, double m21)
		{
			return default(double3x2);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x570F510", Offset = "0x570E110", VA = "0x18570F510")]
		[MethodImpl(256)]
		public static double3x2 double3x2(double v)
		{
			return default(double3x2);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x570F5F0", Offset = "0x570E1F0", VA = "0x18570F5F0")]
		[MethodImpl(256)]
		public static double3x2 double3x2(bool v)
		{
			return default(double3x2);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x570F660", Offset = "0x570E260", VA = "0x18570F660")]
		[MethodImpl(256)]
		public static double3x2 double3x2(bool3x2 v)
		{
			return default(double3x2);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x570F850", Offset = "0x570E450", VA = "0x18570F850")]
		[MethodImpl(256)]
		public static double3x2 double3x2(int v)
		{
			return default(double3x2);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x570F700", Offset = "0x570E300", VA = "0x18570F700")]
		[MethodImpl(256)]
		public static double3x2 double3x2(int3x2 v)
		{
			return default(double3x2);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x570F460", Offset = "0x570E060", VA = "0x18570F460")]
		[MethodImpl(256)]
		public static double3x2 double3x2(uint v)
		{
			return default(double3x2);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x570F540", Offset = "0x570E140", VA = "0x18570F540")]
		[MethodImpl(256)]
		public static double3x2 double3x2(uint3x2 v)
		{
			return default(double3x2);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x570F7F0", Offset = "0x570E3F0", VA = "0x18570F7F0")]
		[MethodImpl(256)]
		public static double3x2 double3x2(float v)
		{
			return default(double3x2);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x570F4A0", Offset = "0x570E0A0", VA = "0x18570F4A0")]
		[MethodImpl(256)]
		public static double3x2 double3x2(float3x2 v)
		{
			return default(double3x2);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x5751B00", Offset = "0x5750700", VA = "0x185751B00")]
		[MethodImpl(256)]
		public static double2x3 transpose(double3x2 v)
		{
			return default(double2x3);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x571BB40", Offset = "0x571A740", VA = "0x18571BB40")]
		[MethodImpl(256)]
		public static uint hash(double3x2 v)
		{
			return 0U;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x57220D0", Offset = "0x5720CD0", VA = "0x1857220D0")]
		[MethodImpl(256)]
		public static uint3 hashwide(double3x2 v)
		{
			return default(uint3);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x570FD50", Offset = "0x570E950", VA = "0x18570FD50")]
		[MethodImpl(256)]
		public static double3x3 double3x3(double3 c0, double3 c1, double3 c2)
		{
			return default(double3x3);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x570FAD0", Offset = "0x570E6D0", VA = "0x18570FAD0")]
		[MethodImpl(256)]
		public static double3x3 double3x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22)
		{
			return default(double3x3);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00003720 File Offset: 0x00001920
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x570FE90", Offset = "0x570EA90", VA = "0x18570FE90")]
		[MethodImpl(256)]
		public static double3x3 double3x3(double v)
		{
			return default(double3x3);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00003738 File Offset: 0x00001938
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x570FCC0", Offset = "0x570E8C0", VA = "0x18570FCC0")]
		[MethodImpl(256)]
		public static double3x3 double3x3(bool v)
		{
			return default(double3x3);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x570F940", Offset = "0x570E540", VA = "0x18570F940")]
		[MethodImpl(256)]
		public static double3x3 double3x3(bool3x3 v)
		{
			return default(double3x3);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x570FC70", Offset = "0x570E870", VA = "0x18570FC70")]
		[MethodImpl(256)]
		public static double3x3 double3x3(int v)
		{
			return default(double3x3);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x570FB80", Offset = "0x570E780", VA = "0x18570FB80")]
		[MethodImpl(256)]
		public static double3x3 double3x3(int3x3 v)
		{
			return default(double3x3);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x570FB30", Offset = "0x570E730", VA = "0x18570FB30")]
		[MethodImpl(256)]
		public static double3x3 double3x3(uint v)
		{
			return default(double3x3);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x570FD90", Offset = "0x570E990", VA = "0x18570FD90")]
		[MethodImpl(256)]
		public static double3x3 double3x3(uint3x3 v)
		{
			return default(double3x3);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x570F8C0", Offset = "0x570E4C0", VA = "0x18570F8C0")]
		[MethodImpl(256)]
		public static double3x3 double3x3(float v)
		{
			return default(double3x3);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x570FA20", Offset = "0x570E620", VA = "0x18570FA20")]
		[MethodImpl(256)]
		public static double3x3 double3x3(float3x3 v)
		{
			return default(double3x3);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x5751C90", Offset = "0x5750890", VA = "0x185751C90")]
		[MethodImpl(256)]
		public static double3x3 transpose(double3x3 v)
		{
			return default(double3x3);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x572CD20", Offset = "0x572B920", VA = "0x18572CD20")]
		public static double3x3 inverse(double3x3 m)
		{
			return default(double3x3);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x570D1E0", Offset = "0x570BDE0", VA = "0x18570D1E0")]
		[MethodImpl(256)]
		public static double determinant(double3x3 m)
		{
			return 0.0;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x571E230", Offset = "0x571CE30", VA = "0x18571E230")]
		[MethodImpl(256)]
		public static uint hash(double3x3 v)
		{
			return 0U;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x5726DE0", Offset = "0x57259E0", VA = "0x185726DE0")]
		[MethodImpl(256)]
		public static uint3 hashwide(double3x3 v)
		{
			return default(uint3);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x5710220", Offset = "0x570EE20", VA = "0x185710220")]
		[MethodImpl(256)]
		public static double3x4 double3x4(double3 c0, double3 c1, double3 c2, double3 c3)
		{
			return default(double3x4);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x570FF20", Offset = "0x570EB20", VA = "0x18570FF20")]
		[MethodImpl(256)]
		public static double3x4 double3x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23)
		{
			return default(double3x4);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000038A0 File Offset: 0x00001AA0
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x570FED0", Offset = "0x570EAD0", VA = "0x18570FED0")]
		[MethodImpl(256)]
		public static double3x4 double3x4(double v)
		{
			return default(double3x4);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x57104B0", Offset = "0x570F0B0", VA = "0x1857104B0")]
		[MethodImpl(256)]
		public static double3x4 double3x4(bool v)
		{
			return default(double3x4);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x5710550", Offset = "0x570F150", VA = "0x185710550")]
		[MethodImpl(256)]
		public static double3x4 double3x4(bool3x4 v)
		{
			return default(double3x4);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000038E8 File Offset: 0x00001AE8
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x570FFB0", Offset = "0x570EBB0", VA = "0x18570FFB0")]
		[MethodImpl(256)]
		public static double3x4 double3x4(int v)
		{
			return default(double3x4);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00003900 File Offset: 0x00001B00
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x57100F0", Offset = "0x570ECF0", VA = "0x1857100F0")]
		[MethodImpl(256)]
		public static double3x4 double3x4(int3x4 v)
		{
			return default(double3x4);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00003918 File Offset: 0x00001B18
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x5710310", Offset = "0x570EF10", VA = "0x185710310")]
		[MethodImpl(256)]
		public static double3x4 double3x4(uint v)
		{
			return default(double3x4);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00003930 File Offset: 0x00001B30
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x5710370", Offset = "0x570EF70", VA = "0x185710370")]
		[MethodImpl(256)]
		public static double3x4 double3x4(uint3x4 v)
		{
			return default(double3x4);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00003948 File Offset: 0x00001B48
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x5710270", Offset = "0x570EE70", VA = "0x185710270")]
		[MethodImpl(256)]
		public static double3x4 double3x4(float v)
		{
			return default(double3x4);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00003960 File Offset: 0x00001B60
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x5710010", Offset = "0x570EC10", VA = "0x185710010")]
		[MethodImpl(256)]
		public static double3x4 double3x4(float3x4 v)
		{
			return default(double3x4);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00003978 File Offset: 0x00001B78
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x5752520", Offset = "0x5751120", VA = "0x185752520")]
		[MethodImpl(256)]
		public static double4x3 transpose(double3x4 v)
		{
			return default(double4x3);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00003990 File Offset: 0x00001B90
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x5715AF0", Offset = "0x57146F0", VA = "0x185715AF0")]
		public static double3x4 fastinverse(double3x4 m)
		{
			return default(double3x4);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000039A8 File Offset: 0x00001BA8
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x571BCA0", Offset = "0x571A8A0", VA = "0x18571BCA0")]
		[MethodImpl(256)]
		public static uint hash(double3x4 v)
		{
			return 0U;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x000039C0 File Offset: 0x00001BC0
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x5726030", Offset = "0x5724C30", VA = "0x185726030")]
		[MethodImpl(256)]
		public static uint3 hashwide(double3x4 v)
		{
			return default(uint3);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000039D8 File Offset: 0x00001BD8
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x57107D0", Offset = "0x570F3D0", VA = "0x1857107D0")]
		[MethodImpl(256)]
		public static double4 double4(double x, double y, double z, double w)
		{
			return default(double4);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000039F0 File Offset: 0x00001BF0
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x5710730", Offset = "0x570F330", VA = "0x185710730")]
		[MethodImpl(256)]
		public static double4 double4(double x, double y, double2 zw)
		{
			return default(double4);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00003A08 File Offset: 0x00001C08
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x5710750", Offset = "0x570F350", VA = "0x185710750")]
		[MethodImpl(256)]
		public static double4 double4(double x, double2 yz, double w)
		{
			return default(double4);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00003A20 File Offset: 0x00001C20
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x5710850", Offset = "0x570F450", VA = "0x185710850")]
		[MethodImpl(256)]
		public static double4 double4(double x, double3 yzw)
		{
			return default(double4);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00003A38 File Offset: 0x00001C38
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x57109F0", Offset = "0x570F5F0", VA = "0x1857109F0")]
		[MethodImpl(256)]
		public static double4 double4(double2 xy, double z, double w)
		{
			return default(double4);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x5710820", Offset = "0x570F420", VA = "0x185710820")]
		[MethodImpl(256)]
		public static double4 double4(double2 xy, double2 zw)
		{
			return default(double4);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00003A68 File Offset: 0x00001C68
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x5710780", Offset = "0x570F380", VA = "0x185710780")]
		[MethodImpl(256)]
		public static double4 double4(double3 xyz, double w)
		{
			return default(double4);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x5710700", Offset = "0x570F300", VA = "0x185710700")]
		[MethodImpl(256)]
		public static double4 double4(double4 xyzw)
		{
			return default(double4);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00003A98 File Offset: 0x00001C98
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x5710770", Offset = "0x570F370", VA = "0x185710770")]
		[MethodImpl(256)]
		public static double4 double4(double v)
		{
			return default(double4);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00003AB0 File Offset: 0x00001CB0
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x57108D0", Offset = "0x570F4D0", VA = "0x1857108D0")]
		[MethodImpl(256)]
		public static double4 double4(bool v)
		{
			return default(double4);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00003AC8 File Offset: 0x00001CC8
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x57106A0", Offset = "0x570F2A0", VA = "0x1857106A0")]
		[MethodImpl(256)]
		public static double4 double4(bool4 v)
		{
			return default(double4);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x57107B0", Offset = "0x570F3B0", VA = "0x1857107B0")]
		[MethodImpl(256)]
		public static double4 double4(int v)
		{
			return default(double4);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x5710920", Offset = "0x570F520", VA = "0x185710920")]
		[MethodImpl(256)]
		public static double4 double4(int4 v)
		{
			return default(double4);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00003B10 File Offset: 0x00001D10
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x56FC1E0", Offset = "0x56FADE0", VA = "0x1856FC1E0")]
		[MethodImpl(256)]
		public static double4 double4(uint v)
		{
			return default(double4);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00003B28 File Offset: 0x00001D28
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x5710980", Offset = "0x570F580", VA = "0x185710980")]
		[MethodImpl(256)]
		public static double4 double4(uint4 v)
		{
			return default(double4);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00003B40 File Offset: 0x00001D40
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x57107F0", Offset = "0x570F3F0", VA = "0x1857107F0")]
		[MethodImpl(256)]
		public static double4 double4(half v)
		{
			return default(double4);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00003B58 File Offset: 0x00001D58
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x5710670", Offset = "0x570F270", VA = "0x185710670")]
		[MethodImpl(256)]
		public static double4 double4(half4 v)
		{
			return default(double4);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00003B70 File Offset: 0x00001D70
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x56FC1A0", Offset = "0x56FADA0", VA = "0x1856FC1A0")]
		[MethodImpl(256)]
		public static double4 double4(float v)
		{
			return default(double4);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00003B88 File Offset: 0x00001D88
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x5710880", Offset = "0x570F480", VA = "0x185710880")]
		[MethodImpl(256)]
		public static double4 double4(float4 v)
		{
			return default(double4);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00003BA0 File Offset: 0x00001DA0
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x571CB40", Offset = "0x571B740", VA = "0x18571CB40")]
		[MethodImpl(256)]
		public static uint hash(double4 v)
		{
			return 0U;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00003BB8 File Offset: 0x00001DB8
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x5723380", Offset = "0x5721F80", VA = "0x185723380")]
		[MethodImpl(256)]
		public static uint4 hashwide(double4 v)
		{
			return default(uint4);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00003BD0 File Offset: 0x00001DD0
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x574C0D0", Offset = "0x574ACD0", VA = "0x18574C0D0")]
		[MethodImpl(256)]
		public static double shuffle(double4 left, double4 right, math.ShuffleComponent x)
		{
			return 0.0;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x574AF20", Offset = "0x5749B20", VA = "0x18574AF20")]
		[MethodImpl(256)]
		public static double2 shuffle(double4 left, double4 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(double2);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00003C00 File Offset: 0x00001E00
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x574B130", Offset = "0x5749D30", VA = "0x18574B130")]
		[MethodImpl(256)]
		public static double3 shuffle(double4 left, double4 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(double3);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00003C18 File Offset: 0x00001E18
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x574AC90", Offset = "0x5749890", VA = "0x18574AC90")]
		[MethodImpl(256)]
		public static double4 shuffle(double4 left, double4 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(double4);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00003C30 File Offset: 0x00001E30
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x5702700", Offset = "0x5701300", VA = "0x185702700")]
		[MethodImpl(256)]
		internal static double select_shuffle_component(double4 a, double4 b, math.ShuffleComponent component)
		{
			return 0.0;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00003C48 File Offset: 0x00001E48
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x5710A70", Offset = "0x570F670", VA = "0x185710A70")]
		[MethodImpl(256)]
		public static double4x2 double4x2(double4 c0, double4 c1)
		{
			return default(double4x2);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00003C60 File Offset: 0x00001E60
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x5710D00", Offset = "0x570F900", VA = "0x185710D00")]
		[MethodImpl(256)]
		public static double4x2 double4x2(double m00, double m01, double m10, double m11, double m20, double m21, double m30, double m31)
		{
			return default(double4x2);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00003C78 File Offset: 0x00001E78
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x5710B50", Offset = "0x570F750", VA = "0x185710B50")]
		[MethodImpl(256)]
		public static double4x2 double4x2(double v)
		{
			return default(double4x2);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00003C90 File Offset: 0x00001E90
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x5710BC0", Offset = "0x570F7C0", VA = "0x185710BC0")]
		[MethodImpl(256)]
		public static double4x2 double4x2(bool v)
		{
			return default(double4x2);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x5710D50", Offset = "0x570F950", VA = "0x185710D50")]
		[MethodImpl(256)]
		public static double4x2 double4x2(bool4x2 v)
		{
			return default(double4x2);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00003CC0 File Offset: 0x00001EC0
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x5710B80", Offset = "0x570F780", VA = "0x185710B80")]
		[MethodImpl(256)]
		public static double4x2 double4x2(int v)
		{
			return default(double4x2);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00003CD8 File Offset: 0x00001ED8
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x5710AA0", Offset = "0x570F6A0", VA = "0x185710AA0")]
		[MethodImpl(256)]
		public static double4x2 double4x2(int4x2 v)
		{
			return default(double4x2);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00003CF0 File Offset: 0x00001EF0
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x5710C00", Offset = "0x570F800", VA = "0x185710C00")]
		[MethodImpl(256)]
		public static double4x2 double4x2(uint v)
		{
			return default(double4x2);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00003D08 File Offset: 0x00001F08
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x5710E00", Offset = "0x570FA00", VA = "0x185710E00")]
		[MethodImpl(256)]
		public static double4x2 double4x2(uint4x2 v)
		{
			return default(double4x2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00003D20 File Offset: 0x00001F20
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x5710A10", Offset = "0x570F610", VA = "0x185710A10")]
		[MethodImpl(256)]
		public static double4x2 double4x2(float v)
		{
			return default(double4x2);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00003D38 File Offset: 0x00001F38
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x5710C60", Offset = "0x570F860", VA = "0x185710C60")]
		[MethodImpl(256)]
		public static double4x2 double4x2(float4x2 v)
		{
			return default(double4x2);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00003D50 File Offset: 0x00001F50
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x5751B40", Offset = "0x5750740", VA = "0x185751B40")]
		[MethodImpl(256)]
		public static double2x4 transpose(double4x2 v)
		{
			return default(double2x4);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00003D68 File Offset: 0x00001F68
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x5720110", Offset = "0x571ED10", VA = "0x185720110")]
		[MethodImpl(256)]
		public static uint hash(double4x2 v)
		{
			return 0U;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00003D80 File Offset: 0x00001F80
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x5724680", Offset = "0x5723280", VA = "0x185724680")]
		[MethodImpl(256)]
		public static uint4 hashwide(double4x2 v)
		{
			return default(uint4);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00003D98 File Offset: 0x00001F98
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x5711240", Offset = "0x570FE40", VA = "0x185711240")]
		[MethodImpl(256)]
		public static double4x3 double4x3(double4 c0, double4 c1, double4 c2)
		{
			return default(double4x3);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00003DB0 File Offset: 0x00001FB0
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x5711150", Offset = "0x570FD50", VA = "0x185711150")]
		[MethodImpl(256)]
		public static double4x3 double4x3(double m00, double m01, double m02, double m10, double m11, double m12, double m20, double m21, double m22, double m30, double m31, double m32)
		{
			return default(double4x3);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x5710FC0", Offset = "0x570FBC0", VA = "0x185710FC0")]
		[MethodImpl(256)]
		public static double4x3 double4x3(double v)
		{
			return default(double4x3);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x5711400", Offset = "0x5710000", VA = "0x185711400")]
		[MethodImpl(256)]
		public static double4x3 double4x3(bool v)
		{
			return default(double4x3);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x5711010", Offset = "0x570FC10", VA = "0x185711010")]
		[MethodImpl(256)]
		public static double4x3 double4x3(bool4x3 v)
		{
			return default(double4x3);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00003E10 File Offset: 0x00002010
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x57111F0", Offset = "0x570FDF0", VA = "0x1857111F0")]
		[MethodImpl(256)]
		public static double4x3 double4x3(int v)
		{
			return default(double4x3);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00003E28 File Offset: 0x00002028
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x5711300", Offset = "0x570FF00", VA = "0x185711300")]
		[MethodImpl(256)]
		public static double4x3 double4x3(int4x3 v)
		{
			return default(double4x3);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00003E40 File Offset: 0x00002040
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x5711280", Offset = "0x570FE80", VA = "0x185711280")]
		[MethodImpl(256)]
		public static double4x3 double4x3(uint v)
		{
			return default(double4x3);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00003E58 File Offset: 0x00002058
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x5710EB0", Offset = "0x570FAB0", VA = "0x185710EB0")]
		[MethodImpl(256)]
		public static double4x3 double4x3(uint4x3 v)
		{
			return default(double4x3);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00003E70 File Offset: 0x00002070
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x5711460", Offset = "0x5710060", VA = "0x185711460")]
		[MethodImpl(256)]
		public static double4x3 double4x3(float v)
		{
			return default(double4x3);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00003E88 File Offset: 0x00002088
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x57114E0", Offset = "0x57100E0", VA = "0x1857114E0")]
		[MethodImpl(256)]
		public static double4x3 double4x3(float4x3 v)
		{
			return default(double4x3);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x57521A0", Offset = "0x5750DA0", VA = "0x1857521A0")]
		[MethodImpl(256)]
		public static double3x4 transpose(double4x3 v)
		{
			return default(double3x4);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00003EB8 File Offset: 0x000020B8
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x571FCF0", Offset = "0x571E8F0", VA = "0x18571FCF0")]
		[MethodImpl(256)]
		public static uint hash(double4x3 v)
		{
			return 0U;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00003ED0 File Offset: 0x000020D0
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x5723E60", Offset = "0x5722A60", VA = "0x185723E60")]
		[MethodImpl(256)]
		public static uint4 hashwide(double4x3 v)
		{
			return default(uint4);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00003EE8 File Offset: 0x000020E8
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x5711880", Offset = "0x5710480", VA = "0x185711880")]
		[MethodImpl(256)]
		public static double4x4 double4x4(double4 c0, double4 c1, double4 c2, double4 c3)
		{
			return default(double4x4);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00003F00 File Offset: 0x00002100
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x5711CB0", Offset = "0x57108B0", VA = "0x185711CB0")]
		[MethodImpl(256)]
		public static double4x4 double4x4(double m00, double m01, double m02, double m03, double m10, double m11, double m12, double m13, double m20, double m21, double m22, double m23, double m30, double m31, double m32, double m33)
		{
			return default(double4x4);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00003F18 File Offset: 0x00002118
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x5711660", Offset = "0x5710260", VA = "0x185711660")]
		[MethodImpl(256)]
		public static double4x4 double4x4(double v)
		{
			return default(double4x4);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00003F30 File Offset: 0x00002130
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x57116C0", Offset = "0x57102C0", VA = "0x1857116C0")]
		[MethodImpl(256)]
		public static double4x4 double4x4(bool v)
		{
			return default(double4x4);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00003F48 File Offset: 0x00002148
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x5711BF0", Offset = "0x57107F0", VA = "0x185711BF0")]
		[MethodImpl(256)]
		public static double4x4 double4x4(bool4x4 v)
		{
			return default(double4x4);
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x6000155")]
		[Address(RVA = "0x5711C40", Offset = "0x5710840", VA = "0x185711C40")]
		[MethodImpl(256)]
		public static double4x4 double4x4(int v)
		{
			return default(double4x4);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x6000156")]
		[Address(RVA = "0x5711740", Offset = "0x5710340", VA = "0x185711740")]
		[MethodImpl(256)]
		public static double4x4 double4x4(int4x4 v)
		{
			return default(double4x4);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00003F90 File Offset: 0x00002190
		[Token(Token = "0x6000157")]
		[Address(RVA = "0x57115C0", Offset = "0x57101C0", VA = "0x1857115C0")]
		[MethodImpl(256)]
		public static double4x4 double4x4(uint v)
		{
			return default(double4x4);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x6000158")]
		[Address(RVA = "0x57118D0", Offset = "0x57104D0", VA = "0x1857118D0")]
		[MethodImpl(256)]
		public static double4x4 double4x4(uint4x4 v)
		{
			return default(double4x4);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x6000159")]
		[Address(RVA = "0x5711B50", Offset = "0x5710750", VA = "0x185711B50")]
		[MethodImpl(256)]
		public static double4x4 double4x4(float v)
		{
			return default(double4x4);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x600015A")]
		[Address(RVA = "0x5711A30", Offset = "0x5710630", VA = "0x185711A30")]
		[MethodImpl(256)]
		public static double4x4 double4x4(float4x4 v)
		{
			return default(double4x4);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x5748F90", Offset = "0x5747B90", VA = "0x185748F90")]
		[MethodImpl(256)]
		public static double3 rotate(double4x4 a, double3 b)
		{
			return default(double3);
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x600015C")]
		[Address(RVA = "0x57513F0", Offset = "0x574FFF0", VA = "0x1857513F0")]
		[MethodImpl(256)]
		public static double3 transform(double4x4 a, double3 b)
		{
			return default(double3);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x600015D")]
		[Address(RVA = "0x5751DF0", Offset = "0x57509F0", VA = "0x185751DF0")]
		[MethodImpl(256)]
		public static double4x4 transpose(double4x4 v)
		{
			return default(double4x4);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00004038 File Offset: 0x00002238
		[Token(Token = "0x600015E")]
		[Address(RVA = "0x572B7A0", Offset = "0x572A3A0", VA = "0x18572B7A0")]
		public static double4x4 inverse(double4x4 m)
		{
			return default(double4x4);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00004050 File Offset: 0x00002250
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x5715610", Offset = "0x5714210", VA = "0x185715610")]
		public static double4x4 fastinverse(double4x4 m)
		{
			return default(double4x4);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00004068 File Offset: 0x00002268
		[Token(Token = "0x6000160")]
		[Address(RVA = "0x570CFD0", Offset = "0x570BBD0", VA = "0x18570CFD0")]
		public static double determinant(double4x4 m)
		{
			return 0.0;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00004080 File Offset: 0x00002280
		[Token(Token = "0x6000161")]
		[Address(RVA = "0x571C6F0", Offset = "0x571B2F0", VA = "0x18571C6F0")]
		[MethodImpl(256)]
		public static uint hash(double4x4 v)
		{
			return 0U;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00004098 File Offset: 0x00002298
		[Token(Token = "0x6000162")]
		[Address(RVA = "0x5722260", Offset = "0x5720E60", VA = "0x185722260")]
		[MethodImpl(256)]
		public static uint4 hashwide(double4x4 v)
		{
			return default(uint4);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000040B0 File Offset: 0x000022B0
		[Token(Token = "0x6000163")]
		[Address(RVA = "0x5715D70", Offset = "0x5714970", VA = "0x185715D70")]
		[MethodImpl(256)]
		public static float2 float2(float x, float y)
		{
			return default(float2);
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000040C8 File Offset: 0x000022C8
		[Token(Token = "0x6000164")]
		[Address(RVA = "0x5715EF0", Offset = "0x5714AF0", VA = "0x185715EF0")]
		[MethodImpl(256)]
		public static float2 float2(float2 xy)
		{
			return default(float2);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000040E0 File Offset: 0x000022E0
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x5716000", Offset = "0x5714C00", VA = "0x185716000")]
		[MethodImpl(256)]
		public static float2 float2(float v)
		{
			return default(float2);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000040F8 File Offset: 0x000022F8
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x5715CE0", Offset = "0x57148E0", VA = "0x185715CE0")]
		[MethodImpl(256)]
		public static float2 float2(bool v)
		{
			return default(float2);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00004110 File Offset: 0x00002310
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x5715D30", Offset = "0x5714930", VA = "0x185715D30")]
		[MethodImpl(256)]
		public static float2 float2(bool2 v)
		{
			return default(float2);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00004128 File Offset: 0x00002328
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x5715D80", Offset = "0x5714980", VA = "0x185715D80")]
		[MethodImpl(256)]
		public static float2 float2(int v)
		{
			return default(float2);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00004140 File Offset: 0x00002340
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x5715DA0", Offset = "0x57149A0", VA = "0x185715DA0")]
		[MethodImpl(256)]
		public static float2 float2(int2 v)
		{
			return default(float2);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00004158 File Offset: 0x00002358
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x5715ED0", Offset = "0x5714AD0", VA = "0x185715ED0")]
		[MethodImpl(256)]
		public static float2 float2(uint v)
		{
			return default(float2);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00004170 File Offset: 0x00002370
		[Token(Token = "0x600016B")]
		[Address(RVA = "0x5715DC0", Offset = "0x57149C0", VA = "0x185715DC0")]
		[MethodImpl(256)]
		public static float2 float2(uint2 v)
		{
			return default(float2);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00004188 File Offset: 0x00002388
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x5715F10", Offset = "0x5714B10", VA = "0x185715F10")]
		[MethodImpl(256)]
		public static float2 float2(half v)
		{
			return default(float2);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000041A0 File Offset: 0x000023A0
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x5715DF0", Offset = "0x57149F0", VA = "0x185715DF0")]
		[MethodImpl(256)]
		public static float2 float2(half2 v)
		{
			return default(float2);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000041B8 File Offset: 0x000023B8
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x5715FE0", Offset = "0x5714BE0", VA = "0x185715FE0")]
		[MethodImpl(256)]
		public static float2 float2(double v)
		{
			return default(float2);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x5715D10", Offset = "0x5714910", VA = "0x185715D10")]
		[MethodImpl(256)]
		public static float2 float2(double2 v)
		{
			return default(float2);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x571BAC0", Offset = "0x571A6C0", VA = "0x18571BAC0")]
		[MethodImpl(256)]
		public static uint hash(float2 v)
		{
			return 0U;
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x5727800", Offset = "0x5726400", VA = "0x185727800")]
		[MethodImpl(256)]
		public static uint2 hashwide(float2 v)
		{
			return default(uint2);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x574B120", Offset = "0x5749D20", VA = "0x18574B120")]
		[MethodImpl(256)]
		public static float shuffle(float2 left, float2 right, math.ShuffleComponent x)
		{
			return 0f;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x6000173")]
		[Address(RVA = "0x574BB50", Offset = "0x574A750", VA = "0x18574BB50")]
		[MethodImpl(256)]
		public static float2 shuffle(float2 left, float2 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(float2);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x574BD70", Offset = "0x574A970", VA = "0x18574BD70")]
		[MethodImpl(256)]
		public static float3 shuffle(float2 left, float2 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(float3);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x574B480", Offset = "0x574A080", VA = "0x18574B480")]
		[MethodImpl(256)]
		public static float4 shuffle(float2 left, float2 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(float4);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x5702A80", Offset = "0x5701680", VA = "0x185702A80")]
		[MethodImpl(256)]
		internal static float select_shuffle_component(float2 a, float2 b, math.ShuffleComponent component)
		{
			return 0f;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x5067AF0", Offset = "0x50666F0", VA = "0x185067AF0")]
		[MethodImpl(256)]
		public static float2x2 float2x2(float2 c0, float2 c1)
		{
			return default(float2x2);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x5716030", Offset = "0x5714C30", VA = "0x185716030")]
		[MethodImpl(256)]
		public static float2x2 float2x2(float m00, float m01, float m10, float m11)
		{
			return default(float2x2);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x5716010", Offset = "0x5714C10", VA = "0x185716010")]
		[MethodImpl(256)]
		public static float2x2 float2x2(float v)
		{
			return default(float2x2);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000042D8 File Offset: 0x000024D8
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x5716210", Offset = "0x5714E10", VA = "0x185716210")]
		[MethodImpl(256)]
		public static float2x2 float2x2(bool v)
		{
			return default(float2x2);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000042F0 File Offset: 0x000024F0
		[Token(Token = "0x600017B")]
		[Address(RVA = "0x5716270", Offset = "0x5714E70", VA = "0x185716270")]
		[MethodImpl(256)]
		public static float2x2 float2x2(bool2x2 v)
		{
			return default(float2x2);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00004308 File Offset: 0x00002508
		[Token(Token = "0x600017C")]
		[Address(RVA = "0x57160E0", Offset = "0x5714CE0", VA = "0x1857160E0")]
		[MethodImpl(256)]
		public static float2x2 float2x2(int v)
		{
			return default(float2x2);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00004320 File Offset: 0x00002520
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x57161A0", Offset = "0x5714DA0", VA = "0x1857161A0")]
		[MethodImpl(256)]
		public static float2x2 float2x2(int2x2 v)
		{
			return default(float2x2);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00004338 File Offset: 0x00002538
		[Token(Token = "0x600017E")]
		[Address(RVA = "0x5716160", Offset = "0x5714D60", VA = "0x185716160")]
		[MethodImpl(256)]
		public static float2x2 float2x2(uint v)
		{
			return default(float2x2);
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00004350 File Offset: 0x00002550
		[Token(Token = "0x600017F")]
		[Address(RVA = "0x5716060", Offset = "0x5714C60", VA = "0x185716060")]
		[MethodImpl(256)]
		public static float2x2 float2x2(uint2x2 v)
		{
			return default(float2x2);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00004368 File Offset: 0x00002568
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x5716180", Offset = "0x5714D80", VA = "0x185716180")]
		[MethodImpl(256)]
		public static float2x2 float2x2(double v)
		{
			return default(float2x2);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00004380 File Offset: 0x00002580
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x5716100", Offset = "0x5714D00", VA = "0x185716100")]
		[MethodImpl(256)]
		public static float2x2 float2x2(double2x2 v)
		{
			return default(float2x2);
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00004398 File Offset: 0x00002598
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x57516F0", Offset = "0x57502F0", VA = "0x1857516F0")]
		[MethodImpl(256)]
		public static float2x2 transpose(float2x2 v)
		{
			return default(float2x2);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000043B0 File Offset: 0x000025B0
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x572B710", Offset = "0x572A310", VA = "0x18572B710")]
		[MethodImpl(256)]
		public static float2x2 inverse(float2x2 m)
		{
			return default(float2x2);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000043C8 File Offset: 0x000025C8
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x570D7E0", Offset = "0x570C3E0", VA = "0x18570D7E0")]
		[MethodImpl(256)]
		public static float determinant(float2x2 m)
		{
			return 0f;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000043E0 File Offset: 0x000025E0
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x5720B00", Offset = "0x571F700", VA = "0x185720B00")]
		[MethodImpl(256)]
		public static uint hash(float2x2 v)
		{
			return 0U;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000043F8 File Offset: 0x000025F8
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x5727D60", Offset = "0x5726960", VA = "0x185727D60")]
		[MethodImpl(256)]
		public static uint2 hashwide(float2x2 v)
		{
			return default(uint2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00004410 File Offset: 0x00002610
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x509C000", Offset = "0x509AC00", VA = "0x18509C000")]
		[MethodImpl(256)]
		public static float2x3 float2x3(float2 c0, float2 c1, float2 c2)
		{
			return default(float2x3);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00004428 File Offset: 0x00002628
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x5716420", Offset = "0x5715020", VA = "0x185716420")]
		[MethodImpl(256)]
		public static float2x3 float2x3(float m00, float m01, float m02, float m10, float m11, float m12)
		{
			return default(float2x3);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00004440 File Offset: 0x00002640
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x57162D0", Offset = "0x5714ED0", VA = "0x1857162D0")]
		[MethodImpl(256)]
		public static float2x3 float2x3(float v)
		{
			return default(float2x3);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00004458 File Offset: 0x00002658
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x5716340", Offset = "0x5714F40", VA = "0x185716340")]
		[MethodImpl(256)]
		public static float2x3 float2x3(bool v)
		{
			return default(float2x3);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00004470 File Offset: 0x00002670
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x5716460", Offset = "0x5715060", VA = "0x185716460")]
		[MethodImpl(256)]
		public static float2x3 float2x3(bool2x3 v)
		{
			return default(float2x3);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x5716600", Offset = "0x5715200", VA = "0x185716600")]
		[MethodImpl(256)]
		public static float2x3 float2x3(int v)
		{
			return default(float2x3);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000044A0 File Offset: 0x000026A0
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x5716620", Offset = "0x5715220", VA = "0x185716620")]
		[MethodImpl(256)]
		public static float2x3 float2x3(int2x3 v)
		{
			return default(float2x3);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000044B8 File Offset: 0x000026B8
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x5716310", Offset = "0x5714F10", VA = "0x185716310")]
		[MethodImpl(256)]
		public static float2x3 float2x3(uint v)
		{
			return default(float2x3);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000044D0 File Offset: 0x000026D0
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x5716520", Offset = "0x5715120", VA = "0x185716520")]
		[MethodImpl(256)]
		public static float2x3 float2x3(uint2x3 v)
		{
			return default(float2x3);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000044E8 File Offset: 0x000026E8
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x57162F0", Offset = "0x5714EF0", VA = "0x1857162F0")]
		[MethodImpl(256)]
		public static float2x3 float2x3(double v)
		{
			return default(float2x3);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00004500 File Offset: 0x00002700
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x57163B0", Offset = "0x5714FB0", VA = "0x1857163B0")]
		[MethodImpl(256)]
		public static float2x3 float2x3(double2x3 v)
		{
			return default(float2x3);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00004518 File Offset: 0x00002718
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x5751FB0", Offset = "0x5750BB0", VA = "0x185751FB0")]
		[MethodImpl(256)]
		public static float3x2 transpose(float2x3 v)
		{
			return default(float3x2);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00004530 File Offset: 0x00002730
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x571D270", Offset = "0x571BE70", VA = "0x18571D270")]
		[MethodImpl(256)]
		public static uint hash(float2x3 v)
		{
			return 0U;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00004548 File Offset: 0x00002748
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x5722EE0", Offset = "0x5721AE0", VA = "0x185722EE0")]
		[MethodImpl(256)]
		public static uint2 hashwide(float2x3 v)
		{
			return default(uint2);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00004560 File Offset: 0x00002760
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x57166E0", Offset = "0x57152E0", VA = "0x1857166E0")]
		[MethodImpl(256)]
		public static float2x4 float2x4(float2 c0, float2 c1, float2 c2, float2 c3)
		{
			return default(float2x4);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00004578 File Offset: 0x00002778
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x5716910", Offset = "0x5715510", VA = "0x185716910")]
		[MethodImpl(256)]
		public static float2x4 float2x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13)
		{
			return default(float2x4);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00004590 File Offset: 0x00002790
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x5716990", Offset = "0x5715590", VA = "0x185716990")]
		[MethodImpl(256)]
		public static float2x4 float2x4(float v)
		{
			return default(float2x4);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000045A8 File Offset: 0x000027A8
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x5716700", Offset = "0x5715300", VA = "0x185716700")]
		[MethodImpl(256)]
		public static float2x4 float2x4(bool v)
		{
			return default(float2x4);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000045C0 File Offset: 0x000027C0
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x5716830", Offset = "0x5715430", VA = "0x185716830")]
		[MethodImpl(256)]
		public static float2x4 float2x4(bool2x4 v)
		{
			return default(float2x4);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000045D8 File Offset: 0x000027D8
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x5716970", Offset = "0x5715570", VA = "0x185716970")]
		[MethodImpl(256)]
		public static float2x4 float2x4(int v)
		{
			return default(float2x4);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x000045F0 File Offset: 0x000027F0
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x5716AD0", Offset = "0x57156D0", VA = "0x185716AD0")]
		[MethodImpl(256)]
		public static float2x4 float2x4(int2x4 v)
		{
			return default(float2x4);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00004608 File Offset: 0x00002808
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x57168F0", Offset = "0x57154F0", VA = "0x1857168F0")]
		[MethodImpl(256)]
		public static float2x4 float2x4(uint v)
		{
			return default(float2x4);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00004620 File Offset: 0x00002820
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x57169C0", Offset = "0x57155C0", VA = "0x1857169C0")]
		[MethodImpl(256)]
		public static float2x4 float2x4(uint2x4 v)
		{
			return default(float2x4);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00004638 File Offset: 0x00002838
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x57169A0", Offset = "0x57155A0", VA = "0x1857169A0")]
		[MethodImpl(256)]
		public static float2x4 float2x4(double v)
		{
			return default(float2x4);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00004650 File Offset: 0x00002850
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x5716790", Offset = "0x5715390", VA = "0x185716790")]
		[MethodImpl(256)]
		public static float2x4 float2x4(double2x4 v)
		{
			return default(float2x4);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00004668 File Offset: 0x00002868
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x5751CF0", Offset = "0x57508F0", VA = "0x185751CF0")]
		[MethodImpl(256)]
		public static float4x2 transpose(float2x4 v)
		{
			return default(float4x2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00004680 File Offset: 0x00002880
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x571ECB0", Offset = "0x571D8B0", VA = "0x18571ECB0")]
		[MethodImpl(256)]
		public static uint hash(float2x4 v)
		{
			return 0U;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00004698 File Offset: 0x00002898
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x5725430", Offset = "0x5724030", VA = "0x185725430")]
		[MethodImpl(256)]
		public static uint2 hashwide(float2x4 v)
		{
			return default(uint2);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000046B0 File Offset: 0x000028B0
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x5716D90", Offset = "0x5715990", VA = "0x185716D90")]
		[MethodImpl(256)]
		public static float3 float3(float x, float y, float z)
		{
			return default(float3);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000046C8 File Offset: 0x000028C8
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x5716FE0", Offset = "0x5715BE0", VA = "0x185716FE0")]
		[MethodImpl(256)]
		public static float3 float3(float x, float2 yz)
		{
			return default(float3);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000046E0 File Offset: 0x000028E0
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x5716F10", Offset = "0x5715B10", VA = "0x185716F10")]
		[MethodImpl(256)]
		public static float3 float3(float2 xy, float z)
		{
			return default(float3);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x000046F8 File Offset: 0x000028F8
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x5716F40", Offset = "0x5715B40", VA = "0x185716F40")]
		[MethodImpl(256)]
		public static float3 float3(float3 xyz)
		{
			return default(float3);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00004710 File Offset: 0x00002910
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x57170E0", Offset = "0x5715CE0", VA = "0x1857170E0")]
		[MethodImpl(256)]
		public static float3 float3(float v)
		{
			return default(float3);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00004728 File Offset: 0x00002928
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x5716B90", Offset = "0x5715790", VA = "0x185716B90")]
		[MethodImpl(256)]
		public static float3 float3(bool v)
		{
			return default(float3);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00004740 File Offset: 0x00002940
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x5717080", Offset = "0x5715C80", VA = "0x185717080")]
		[MethodImpl(256)]
		public static float3 float3(bool3 v)
		{
			return default(float3);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00004758 File Offset: 0x00002958
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x5716C10", Offset = "0x5715810", VA = "0x185716C10")]
		[MethodImpl(256)]
		public static float3 float3(int v)
		{
			return default(float3);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00004770 File Offset: 0x00002970
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x5717030", Offset = "0x5715C30", VA = "0x185717030")]
		[MethodImpl(256)]
		public static float3 float3(int3 v)
		{
			return default(float3);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00004788 File Offset: 0x00002988
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x5717010", Offset = "0x5715C10", VA = "0x185717010")]
		[MethodImpl(256)]
		public static float3 float3(uint v)
		{
			return default(float3);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000047A0 File Offset: 0x000029A0
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x5716F80", Offset = "0x5715B80", VA = "0x185716F80")]
		[MethodImpl(256)]
		public static float3 float3(uint3 v)
		{
			return default(float3);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000047B8 File Offset: 0x000029B8
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x5716C30", Offset = "0x5715830", VA = "0x185716C30")]
		[MethodImpl(256)]
		public static float3 float3(half v)
		{
			return default(float3);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000047D0 File Offset: 0x000029D0
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x5716DB0", Offset = "0x57159B0", VA = "0x185716DB0")]
		[MethodImpl(256)]
		public static float3 float3(half3 v)
		{
			return default(float3);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000047E8 File Offset: 0x000029E8
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x5716D70", Offset = "0x5715970", VA = "0x185716D70")]
		[MethodImpl(256)]
		public static float3 float3(double v)
		{
			return default(float3);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00004800 File Offset: 0x00002A00
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x5716BD0", Offset = "0x57157D0", VA = "0x185716BD0")]
		[MethodImpl(256)]
		public static float3 float3(double3 v)
		{
			return default(float3);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00004818 File Offset: 0x00002A18
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x571FA90", Offset = "0x571E690", VA = "0x18571FA90")]
		[MethodImpl(256)]
		public static uint hash(float3 v)
		{
			return 0U;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00004830 File Offset: 0x00002A30
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x5724310", Offset = "0x5722F10", VA = "0x185724310")]
		[MethodImpl(256)]
		public static uint3 hashwide(float3 v)
		{
			return default(uint3);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00004848 File Offset: 0x00002A48
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x574BE60", Offset = "0x574AA60", VA = "0x18574BE60")]
		[MethodImpl(256)]
		public static float shuffle(float3 left, float3 right, math.ShuffleComponent x)
		{
			return 0f;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00004860 File Offset: 0x00002A60
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x574C670", Offset = "0x574B270", VA = "0x18574C670")]
		[MethodImpl(256)]
		public static float2 shuffle(float3 left, float3 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(float2);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00004878 File Offset: 0x00002A78
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x574CAB0", Offset = "0x574B6B0", VA = "0x18574CAB0")]
		[MethodImpl(256)]
		public static float3 shuffle(float3 left, float3 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(float3);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x574C840", Offset = "0x574B440", VA = "0x18574C840")]
		[MethodImpl(256)]
		public static float4 shuffle(float3 left, float3 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(float4);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x5702170", Offset = "0x5700D70", VA = "0x185702170")]
		[MethodImpl(256)]
		internal static float select_shuffle_component(float3 a, float3 b, math.ShuffleComponent component)
		{
			return 0f;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x5717440", Offset = "0x5716040", VA = "0x185717440")]
		[MethodImpl(256)]
		public static float3x2 float3x2(float3 c0, float3 c1)
		{
			return default(float3x2);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x5717470", Offset = "0x5716070", VA = "0x185717470")]
		[MethodImpl(256)]
		public static float3x2 float3x2(float m00, float m01, float m10, float m11, float m20, float m21)
		{
			return default(float3x2);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x57175D0", Offset = "0x57161D0", VA = "0x1857175D0")]
		[MethodImpl(256)]
		public static float3x2 float3x2(float v)
		{
			return default(float3x2);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00004908 File Offset: 0x00002B08
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x5717260", Offset = "0x5715E60", VA = "0x185717260")]
		[MethodImpl(256)]
		public static float3x2 float3x2(bool v)
		{
			return default(float3x2);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x5717510", Offset = "0x5716110", VA = "0x185717510")]
		[MethodImpl(256)]
		public static float3x2 float3x2(bool3x2 v)
		{
			return default(float3x2);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x57172F0", Offset = "0x5715EF0", VA = "0x1857172F0")]
		[MethodImpl(256)]
		public static float3x2 float3x2(int v)
		{
			return default(float3x2);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x5717390", Offset = "0x5715F90", VA = "0x185717390")]
		[MethodImpl(256)]
		public static float3x2 float3x2(int3x2 v)
		{
			return default(float3x2);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00004968 File Offset: 0x00002B68
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x57174C0", Offset = "0x57160C0", VA = "0x1857174C0")]
		[MethodImpl(256)]
		public static float3x2 float3x2(uint v)
		{
			return default(float3x2);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x5717180", Offset = "0x5715D80", VA = "0x185717180")]
		[MethodImpl(256)]
		public static float3x2 float3x2(uint3x2 v)
		{
			return default(float3x2);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x5717340", Offset = "0x5715F40", VA = "0x185717340")]
		[MethodImpl(256)]
		public static float3x2 float3x2(double v)
		{
			return default(float3x2);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x5717100", Offset = "0x5715D00", VA = "0x185717100")]
		[MethodImpl(256)]
		public static float3x2 float3x2(double3x2 v)
		{
			return default(float3x2);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x57520C0", Offset = "0x5750CC0", VA = "0x1857520C0")]
		[MethodImpl(256)]
		public static float2x3 transpose(float3x2 v)
		{
			return default(float2x3);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x5721C80", Offset = "0x5720880", VA = "0x185721C80")]
		[MethodImpl(256)]
		public static uint hash(float3x2 v)
		{
			return 0U;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x57236C0", Offset = "0x57222C0", VA = "0x1857236C0")]
		[MethodImpl(256)]
		public static uint3 hashwide(float3x2 v)
		{
			return default(uint3);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x5717C20", Offset = "0x5716820", VA = "0x185717C20")]
		[MethodImpl(256)]
		public static float3x3 float3x3(float3 c0, float3 c1, float3 c2)
		{
			return default(float3x3);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x5717950", Offset = "0x5716550", VA = "0x185717950")]
		[MethodImpl(256)]
		public static float3x3 float3x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
		{
			return default(float3x3);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x57176E0", Offset = "0x57162E0", VA = "0x1857176E0")]
		[MethodImpl(256)]
		public static float3x3 float3x3(float v)
		{
			return default(float3x3);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x5717610", Offset = "0x5716210", VA = "0x185717610")]
		[MethodImpl(256)]
		public static float3x3 float3x3(bool v)
		{
			return default(float3x3);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x5717CC0", Offset = "0x57168C0", VA = "0x185717CC0")]
		[MethodImpl(256)]
		public static float3x3 float3x3(bool3x3 v)
		{
			return default(float3x3);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x57179D0", Offset = "0x57165D0", VA = "0x1857179D0")]
		[MethodImpl(256)]
		public static float3x3 float3x3(int v)
		{
			return default(float3x3);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x57177F0", Offset = "0x57163F0", VA = "0x1857177F0")]
		[MethodImpl(256)]
		public static float3x3 float3x3(int3x3 v)
		{
			return default(float3x3);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x5717BB0", Offset = "0x57167B0", VA = "0x185717BB0")]
		[MethodImpl(256)]
		public static float3x3 float3x3(uint v)
		{
			return default(float3x3);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x5717A70", Offset = "0x5716670", VA = "0x185717A70")]
		[MethodImpl(256)]
		public static float3x3 float3x3(uint3x3 v)
		{
			return default(float3x3);
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x5717C60", Offset = "0x5716860", VA = "0x185717C60")]
		[MethodImpl(256)]
		public static float3x3 float3x3(double v)
		{
			return default(float3x3);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x5717740", Offset = "0x5716340", VA = "0x185717740")]
		[MethodImpl(256)]
		public static float3x3 float3x3(double3x3 v)
		{
			return default(float3x3);
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x5752470", Offset = "0x5751070", VA = "0x185752470")]
		[MethodImpl(256)]
		public static float3x3 transpose(float3x3 v)
		{
			return default(float3x3);
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x572B4C0", Offset = "0x572A0C0", VA = "0x18572B4C0")]
		public static float3x3 inverse(float3x3 m)
		{
			return default(float3x3);
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x570D630", Offset = "0x570C230", VA = "0x18570D630")]
		[MethodImpl(256)]
		public static float determinant(float3x3 m)
		{
			return 0f;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x5721370", Offset = "0x571FF70", VA = "0x185721370")]
		[MethodImpl(256)]
		public static uint hash(float3x3 v)
		{
			return 0U;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x57234B0", Offset = "0x57220B0", VA = "0x1857234B0")]
		[MethodImpl(256)]
		public static uint3 hashwide(float3x3 v)
		{
			return default(uint3);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x5718550", Offset = "0x5717150", VA = "0x185718550")]
		[MethodImpl(256)]
		public static float3x4 float3x4(float3 c0, float3 c1, float3 c2, float3 c3)
		{
			return default(float3x4);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x5718620", Offset = "0x5717220", VA = "0x185718620")]
		[MethodImpl(256)]
		public static float3x4 float3x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23)
		{
			return default(float3x4);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x5718260", Offset = "0x5716E60", VA = "0x185718260")]
		[MethodImpl(256)]
		public static float3x4 float3x4(float v)
		{
			return default(float3x4);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x5717FA0", Offset = "0x5716BA0", VA = "0x185717FA0")]
		[MethodImpl(256)]
		public static float3x4 float3x4(bool v)
		{
			return default(float3x4);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x5717E50", Offset = "0x5716A50", VA = "0x185717E50")]
		[MethodImpl(256)]
		public static float3x4 float3x4(bool3x4 v)
		{
			return default(float3x4);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x57180A0", Offset = "0x5716CA0", VA = "0x1857180A0")]
		[MethodImpl(256)]
		public static float3x4 float3x4(int v)
		{
			return default(float3x4);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x5718120", Offset = "0x5716D20", VA = "0x185718120")]
		[MethodImpl(256)]
		public static float3x4 float3x4(int3x4 v)
		{
			return default(float3x4);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x57185A0", Offset = "0x57171A0", VA = "0x1857185A0")]
		[MethodImpl(256)]
		public static float3x4 float3x4(uint v)
		{
			return default(float3x4);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x57183B0", Offset = "0x5716FB0", VA = "0x1857183B0")]
		[MethodImpl(256)]
		public static float3x4 float3x4(uint3x4 v)
		{
			return default(float3x4);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x5717DD0", Offset = "0x57169D0", VA = "0x185717DD0")]
		[MethodImpl(256)]
		public static float3x4 float3x4(double v)
		{
			return default(float3x4);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x57182D0", Offset = "0x5716ED0", VA = "0x1857182D0")]
		[MethodImpl(256)]
		public static float3x4 float3x4(double3x4 v)
		{
			return default(float3x4);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x5751EB0", Offset = "0x5750AB0", VA = "0x185751EB0")]
		[MethodImpl(256)]
		public static float4x3 transpose(float3x4 v)
		{
			return default(float4x3);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x5715920", Offset = "0x5714520", VA = "0x185715920")]
		public static float3x4 fastinverse(float3x4 m)
		{
			return default(float3x4);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x571C070", Offset = "0x571AC70", VA = "0x18571C070")]
		[MethodImpl(256)]
		public static uint hash(float3x4 v)
		{
			return 0U;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x5722970", Offset = "0x5721570", VA = "0x185722970")]
		[MethodImpl(256)]
		public static uint3 hashwide(float3x4 v)
		{
			return default(uint3);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x5700690", Offset = "0x56FF290", VA = "0x185700690")]
		[MethodImpl(256)]
		public static float4 float4(float x, float y, float z, float w)
		{
			return default(float4);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x57187B0", Offset = "0x57173B0", VA = "0x1857187B0")]
		[MethodImpl(256)]
		public static float4 float4(float x, float y, float2 zw)
		{
			return default(float4);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x57189D0", Offset = "0x57175D0", VA = "0x1857189D0")]
		[MethodImpl(256)]
		public static float4 float4(float x, float2 yz, float w)
		{
			return default(float4);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x5718AC0", Offset = "0x57176C0", VA = "0x185718AC0")]
		[MethodImpl(256)]
		public static float4 float4(float x, float3 yzw)
		{
			return default(float4);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x5718980", Offset = "0x5717580", VA = "0x185718980")]
		[MethodImpl(256)]
		public static float4 float4(float2 xy, float z, float w)
		{
			return default(float4);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x5718B00", Offset = "0x5717700", VA = "0x185718B00")]
		[MethodImpl(256)]
		public static float4 float4(float2 xy, float2 zw)
		{
			return default(float4);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x57006B0", Offset = "0x56FF2B0", VA = "0x1857006B0")]
		[MethodImpl(256)]
		public static float4 float4(float3 xyz, float w)
		{
			return default(float4);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x5718BC0", Offset = "0x57177C0", VA = "0x185718BC0")]
		[MethodImpl(256)]
		public static float4 float4(float4 xyzw)
		{
			return default(float4);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x5718780", Offset = "0x5717380", VA = "0x185718780")]
		[MethodImpl(256)]
		public static float4 float4(float v)
		{
			return default(float4);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x5718A80", Offset = "0x5717680", VA = "0x185718A80")]
		[MethodImpl(256)]
		public static float4 float4(bool v)
		{
			return default(float4);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x5718720", Offset = "0x5717320", VA = "0x185718720")]
		[MethodImpl(256)]
		public static float4 float4(bool4 v)
		{
			return default(float4);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x57189B0", Offset = "0x57175B0", VA = "0x1857189B0")]
		[MethodImpl(256)]
		public static float4 float4(int v)
		{
			return default(float4);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x5718A20", Offset = "0x5717620", VA = "0x185718A20")]
		[MethodImpl(256)]
		public static float4 float4(int4 v)
		{
			return default(float4);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x5718A00", Offset = "0x5717600", VA = "0x185718A00")]
		[MethodImpl(256)]
		public static float4 float4(uint v)
		{
			return default(float4);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x5718B40", Offset = "0x5717740", VA = "0x185718B40")]
		[MethodImpl(256)]
		public static float4 float4(uint4 v)
		{
			return default(float4);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x57187E0", Offset = "0x57173E0", VA = "0x1857187E0")]
		[MethodImpl(256)]
		public static float4 float4(half v)
		{
			return default(float4);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x5718790", Offset = "0x5717390", VA = "0x185718790")]
		[MethodImpl(256)]
		public static float4 float4(half4 v)
		{
			return default(float4);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x56FE1A0", Offset = "0x56FCDA0", VA = "0x1856FE1A0")]
		[MethodImpl(256)]
		public static float4 float4(double v)
		{
			return default(float4);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x57186D0", Offset = "0x57172D0", VA = "0x1857186D0")]
		[MethodImpl(256)]
		public static float4 float4(double4 v)
		{
			return default(float4);
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x571D580", Offset = "0x571C180", VA = "0x18571D580")]
		[MethodImpl(256)]
		public static uint hash(float4 v)
		{
			return 0U;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x5723210", Offset = "0x5721E10", VA = "0x185723210")]
		[MethodImpl(256)]
		public static uint4 hashwide(float4 v)
		{
			return default(uint4);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x574AAD0", Offset = "0x57496D0", VA = "0x18574AAD0")]
		[MethodImpl(256)]
		public static float shuffle(float4 left, float4 right, math.ShuffleComponent x)
		{
			return 0f;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00004F08 File Offset: 0x00003108
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x574C600", Offset = "0x574B200", VA = "0x18574C600")]
		[MethodImpl(256)]
		public static float2 shuffle(float4 left, float4 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(float2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00004F20 File Offset: 0x00003120
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x574B990", Offset = "0x574A590", VA = "0x18574B990")]
		[MethodImpl(256)]
		public static float3 shuffle(float4 left, float4 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(float3);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00004F38 File Offset: 0x00003138
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x574B250", Offset = "0x5749E50", VA = "0x18574B250")]
		[MethodImpl(256)]
		public static float4 shuffle(float4 left, float4 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(float4);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00004F50 File Offset: 0x00003150
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x5702EF0", Offset = "0x5701AF0", VA = "0x185702EF0")]
		[MethodImpl(256)]
		internal static float select_shuffle_component(float4 a, float4 b, math.ShuffleComponent component)
		{
			return 0f;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00004F68 File Offset: 0x00003168
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x5718C40", Offset = "0x5717840", VA = "0x185718C40")]
		[MethodImpl(256)]
		public static float4x2 float4x2(float4 c0, float4 c1)
		{
			return default(float4x2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x5718EF0", Offset = "0x5717AF0", VA = "0x185718EF0")]
		[MethodImpl(256)]
		public static float4x2 float4x2(float m00, float m01, float m10, float m11, float m20, float m21, float m30, float m31)
		{
			return default(float4x2);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00004F98 File Offset: 0x00003198
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x5718D50", Offset = "0x5717950", VA = "0x185718D50")]
		[MethodImpl(256)]
		public static float4x2 float4x2(float v)
		{
			return default(float4x2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x5718FD0", Offset = "0x5717BD0", VA = "0x185718FD0")]
		[MethodImpl(256)]
		public static float4x2 float4x2(bool v)
		{
			return default(float4x2);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00004FC8 File Offset: 0x000031C8
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x5719000", Offset = "0x5717C00", VA = "0x185719000")]
		[MethodImpl(256)]
		public static float4x2 float4x2(bool4x2 v)
		{
			return default(float4x2);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00004FE0 File Offset: 0x000031E0
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x5718F70", Offset = "0x5717B70", VA = "0x185718F70")]
		[MethodImpl(256)]
		public static float4x2 float4x2(int v)
		{
			return default(float4x2);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00004FF8 File Offset: 0x000031F8
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x5718E30", Offset = "0x5717A30", VA = "0x185718E30")]
		[MethodImpl(256)]
		public static float4x2 float4x2(int4x2 v)
		{
			return default(float4x2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00005010 File Offset: 0x00003210
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x5718FA0", Offset = "0x5717BA0", VA = "0x185718FA0")]
		[MethodImpl(256)]
		public static float4x2 float4x2(uint v)
		{
			return default(float4x2);
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00005028 File Offset: 0x00003228
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x5718C60", Offset = "0x5717860", VA = "0x185718C60")]
		[MethodImpl(256)]
		public static float4x2 float4x2(uint4x2 v)
		{
			return default(float4x2);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00005040 File Offset: 0x00003240
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x5718BF0", Offset = "0x57177F0", VA = "0x185718BF0")]
		[MethodImpl(256)]
		public static float4x2 float4x2(double v)
		{
			return default(float4x2);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00005058 File Offset: 0x00003258
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x5718D80", Offset = "0x5717980", VA = "0x185718D80")]
		[MethodImpl(256)]
		public static float4x2 float4x2(double4x2 v)
		{
			return default(float4x2);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x5752110", Offset = "0x5750D10", VA = "0x185752110")]
		[MethodImpl(256)]
		public static float2x4 transpose(float4x2 v)
		{
			return default(float2x4);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x571E050", Offset = "0x571CC50", VA = "0x18571E050")]
		[MethodImpl(256)]
		public static uint hash(float4x2 v)
		{
			return 0U;
		}

		// Token: 0x0600020D RID: 525 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x57275F0", Offset = "0x57261F0", VA = "0x1857275F0")]
		[MethodImpl(256)]
		public static uint4 hashwide(float4x2 v)
		{
			return default(uint4);
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000050B8 File Offset: 0x000032B8
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x57197C0", Offset = "0x57183C0", VA = "0x1857197C0")]
		[MethodImpl(256)]
		public static float4x3 float4x3(float4 c0, float4 c1, float4 c2)
		{
			return default(float4x3);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000050D0 File Offset: 0x000032D0
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x5719540", Offset = "0x5718140", VA = "0x185719540")]
		[MethodImpl(256)]
		public static float4x3 float4x3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22, float m30, float m31, float m32)
		{
			return default(float4x3);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000050E8 File Offset: 0x000032E8
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x5719600", Offset = "0x5718200", VA = "0x185719600")]
		[MethodImpl(256)]
		public static float4x3 float4x3(float v)
		{
			return default(float4x3);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00005100 File Offset: 0x00003300
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x5719630", Offset = "0x5718230", VA = "0x185719630")]
		[MethodImpl(256)]
		public static float4x3 float4x3(bool v)
		{
			return default(float4x3);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00005118 File Offset: 0x00003318
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x5719280", Offset = "0x5717E80", VA = "0x185719280")]
		[MethodImpl(256)]
		public static float4x3 float4x3(bool4x3 v)
		{
			return default(float4x3);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00005130 File Offset: 0x00003330
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x5719670", Offset = "0x5718270", VA = "0x185719670")]
		[MethodImpl(256)]
		public static float4x3 float4x3(int v)
		{
			return default(float4x3);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00005148 File Offset: 0x00003348
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x57196B0", Offset = "0x57182B0", VA = "0x1857196B0")]
		[MethodImpl(256)]
		public static float4x3 float4x3(int4x3 v)
		{
			return default(float4x3);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00005160 File Offset: 0x00003360
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x5719240", Offset = "0x5717E40", VA = "0x185719240")]
		[MethodImpl(256)]
		public static float4x3 float4x3(uint v)
		{
			return default(float4x3);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00005178 File Offset: 0x00003378
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x57193E0", Offset = "0x5717FE0", VA = "0x1857193E0")]
		[MethodImpl(256)]
		public static float4x3 float4x3(uint4x3 v)
		{
			return default(float4x3);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00005190 File Offset: 0x00003390
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x57191E0", Offset = "0x5717DE0", VA = "0x1857191E0")]
		[MethodImpl(256)]
		public static float4x3 float4x3(double v)
		{
			return default(float4x3);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x000051A8 File Offset: 0x000033A8
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x57190E0", Offset = "0x5717CE0", VA = "0x1857190E0")]
		[MethodImpl(256)]
		public static float4x3 float4x3(double4x3 v)
		{
			return default(float4x3);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000051C0 File Offset: 0x000033C0
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x5751A00", Offset = "0x5750600", VA = "0x185751A00")]
		[MethodImpl(256)]
		public static float3x4 transpose(float4x3 v)
		{
			return default(float3x4);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000051D8 File Offset: 0x000033D8
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x5720C10", Offset = "0x571F810", VA = "0x185720C10")]
		[MethodImpl(256)]
		public static uint hash(float4x3 v)
		{
			return 0U;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x000051F0 File Offset: 0x000033F0
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x5722670", Offset = "0x5721270", VA = "0x185722670")]
		[MethodImpl(256)]
		public static uint4 hashwide(float4x3 v)
		{
			return default(uint4);
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00005208 File Offset: 0x00003408
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x5719BA0", Offset = "0x57187A0", VA = "0x185719BA0")]
		[MethodImpl(256)]
		public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
		{
			return default(float4x4);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00005220 File Offset: 0x00003420
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x57197E0", Offset = "0x57183E0", VA = "0x1857197E0")]
		[MethodImpl(256)]
		public static float4x4 float4x4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
		{
			return default(float4x4);
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00005238 File Offset: 0x00003438
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x5719B10", Offset = "0x5718710", VA = "0x185719B10")]
		[MethodImpl(256)]
		public static float4x4 float4x4(float v)
		{
			return default(float4x4);
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00005250 File Offset: 0x00003450
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x5719DF0", Offset = "0x57189F0", VA = "0x185719DF0")]
		[MethodImpl(256)]
		public static float4x4 float4x4(bool v)
		{
			return default(float4x4);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00005268 File Offset: 0x00003468
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x5719EE0", Offset = "0x5718AE0", VA = "0x185719EE0")]
		[MethodImpl(256)]
		public static float4x4 float4x4(bool4x4 v)
		{
			return default(float4x4);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00005280 File Offset: 0x00003480
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x5719E40", Offset = "0x5718A40", VA = "0x185719E40")]
		[MethodImpl(256)]
		public static float4x4 float4x4(int v)
		{
			return default(float4x4);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00005298 File Offset: 0x00003498
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x5719920", Offset = "0x5718520", VA = "0x185719920")]
		[MethodImpl(256)]
		public static float4x4 float4x4(int4x4 v)
		{
			return default(float4x4);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000052B0 File Offset: 0x000034B0
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x57198E0", Offset = "0x57184E0", VA = "0x1857198E0")]
		[MethodImpl(256)]
		public static float4x4 float4x4(uint v)
		{
			return default(float4x4);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000052C8 File Offset: 0x000034C8
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x5719D20", Offset = "0x5718920", VA = "0x185719D20")]
		[MethodImpl(256)]
		public static float4x4 float4x4(uint4x4 v)
		{
			return default(float4x4);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000052E0 File Offset: 0x000034E0
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x5719A90", Offset = "0x5718690", VA = "0x185719A90")]
		[MethodImpl(256)]
		public static float4x4 float4x4(double v)
		{
			return default(float4x4);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000052F8 File Offset: 0x000034F8
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x5719BD0", Offset = "0x57187D0", VA = "0x185719BD0")]
		[MethodImpl(256)]
		public static float4x4 float4x4(double4x4 v)
		{
			return default(float4x4);
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00005310 File Offset: 0x00003510
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x5748D50", Offset = "0x5747950", VA = "0x185748D50")]
		[MethodImpl(256)]
		public static float3 rotate(float4x4 a, float3 b)
		{
			return default(float3);
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00005328 File Offset: 0x00003528
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x57514D0", Offset = "0x57500D0", VA = "0x1857514D0")]
		[MethodImpl(256)]
		public static float3 transform(float4x4 a, float3 b)
		{
			return default(float3);
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x5752300", Offset = "0x5750F00", VA = "0x185752300")]
		[MethodImpl(256)]
		public static float4x4 transpose(float4x4 v)
		{
			return default(float4x4);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00005358 File Offset: 0x00003558
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x572D000", Offset = "0x572BC00", VA = "0x18572D000")]
		public static float4x4 inverse(float4x4 m)
		{
			return default(float4x4);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00005370 File Offset: 0x00003570
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x5714F40", Offset = "0x5713B40", VA = "0x185714F40")]
		public static float4x4 fastinverse(float4x4 m)
		{
			return default(float4x4);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00005388 File Offset: 0x00003588
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x570D2A0", Offset = "0x570BEA0", VA = "0x18570D2A0")]
		public static float determinant(float4x4 m)
		{
			return 0f;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000053A0 File Offset: 0x000035A0
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x571C2F0", Offset = "0x571AEF0", VA = "0x18571C2F0")]
		[MethodImpl(256)]
		public static uint hash(float4x4 v)
		{
			return 0U;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000053B8 File Offset: 0x000035B8
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x57250B0", Offset = "0x5723CB0", VA = "0x1857250B0")]
		[MethodImpl(256)]
		public static uint4 hashwide(float4x4 v)
		{
			return default(uint4);
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000053D0 File Offset: 0x000035D0
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x4AE96C0", Offset = "0x4AE82C0", VA = "0x184AE96C0")]
		[MethodImpl(256)]
		public static half half(half x)
		{
			return default(half);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000053E8 File Offset: 0x000035E8
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x571B980", Offset = "0x571A580", VA = "0x18571B980")]
		[MethodImpl(256)]
		public static half half(float v)
		{
			return default(half);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00005400 File Offset: 0x00003600
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x571B970", Offset = "0x571A570", VA = "0x18571B970")]
		[MethodImpl(256)]
		public static half half(double v)
		{
			return default(half);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00005418 File Offset: 0x00003618
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x571C060", Offset = "0x571AC60", VA = "0x18571C060")]
		[MethodImpl(256)]
		public static uint hash(half v)
		{
			return 0U;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00005430 File Offset: 0x00003630
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x5708940", Offset = "0x5707540", VA = "0x185708940")]
		[MethodImpl(256)]
		public static half2 half2(half x, half y)
		{
			return default(half2);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00005448 File Offset: 0x00003648
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x571B3C0", Offset = "0x5719FC0", VA = "0x18571B3C0")]
		[MethodImpl(256)]
		public static half2 half2(half2 xy)
		{
			return default(half2);
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00005460 File Offset: 0x00003660
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x571B3B0", Offset = "0x5719FB0", VA = "0x18571B3B0")]
		[MethodImpl(256)]
		public static half2 half2(half v)
		{
			return default(half2);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00005478 File Offset: 0x00003678
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x571B3E0", Offset = "0x5719FE0", VA = "0x18571B3E0")]
		[MethodImpl(256)]
		public static half2 half2(float v)
		{
			return default(half2);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00005490 File Offset: 0x00003690
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x571B420", Offset = "0x571A020", VA = "0x18571B420")]
		[MethodImpl(256)]
		public static half2 half2(float2 v)
		{
			return default(half2);
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000054A8 File Offset: 0x000036A8
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x571B320", Offset = "0x5719F20", VA = "0x18571B320")]
		[MethodImpl(256)]
		public static half2 half2(double v)
		{
			return default(half2);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000054C0 File Offset: 0x000036C0
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x571B360", Offset = "0x5719F60", VA = "0x18571B360")]
		[MethodImpl(256)]
		public static half2 half2(double2 v)
		{
			return default(half2);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000054D8 File Offset: 0x000036D8
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x5721A30", Offset = "0x5720630", VA = "0x185721A30")]
		[MethodImpl(256)]
		public static uint hash(half2 v)
		{
			return 0U;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000054F0 File Offset: 0x000036F0
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x57267F0", Offset = "0x57253F0", VA = "0x1857267F0")]
		[MethodImpl(256)]
		public static uint2 hashwide(half2 v)
		{
			return default(uint2);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00005508 File Offset: 0x00003708
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x57089B0", Offset = "0x57075B0", VA = "0x1857089B0")]
		[MethodImpl(256)]
		public static half3 half3(half x, half y, half z)
		{
			return default(half3);
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00005520 File Offset: 0x00003720
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x571B620", Offset = "0x571A220", VA = "0x18571B620")]
		[MethodImpl(256)]
		public static half3 half3(half x, half2 yz)
		{
			return default(half3);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00005538 File Offset: 0x00003738
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x571B640", Offset = "0x571A240", VA = "0x18571B640")]
		[MethodImpl(256)]
		public static half3 half3(half2 xy, half z)
		{
			return default(half3);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00005550 File Offset: 0x00003750
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x571B4C0", Offset = "0x571A0C0", VA = "0x18571B4C0")]
		[MethodImpl(256)]
		public static half3 half3(half3 xyz)
		{
			return default(half3);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00005568 File Offset: 0x00003768
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x571B5C0", Offset = "0x571A1C0", VA = "0x18571B5C0")]
		[MethodImpl(256)]
		public static half3 half3(half v)
		{
			return default(half3);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00005580 File Offset: 0x00003780
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x571B5D0", Offset = "0x571A1D0", VA = "0x18571B5D0")]
		[MethodImpl(256)]
		public static half3 half3(float v)
		{
			return default(half3);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00005598 File Offset: 0x00003798
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x571B560", Offset = "0x571A160", VA = "0x18571B560")]
		[MethodImpl(256)]
		public static half3 half3(float3 v)
		{
			return default(half3);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000055B0 File Offset: 0x000037B0
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x571B460", Offset = "0x571A060", VA = "0x18571B460")]
		[MethodImpl(256)]
		public static half3 half3(double v)
		{
			return default(half3);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000055C8 File Offset: 0x000037C8
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x571B4F0", Offset = "0x571A0F0", VA = "0x18571B4F0")]
		[MethodImpl(256)]
		public static half3 half3(double3 v)
		{
			return default(half3);
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000055E0 File Offset: 0x000037E0
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x571BA50", Offset = "0x571A650", VA = "0x18571BA50")]
		[MethodImpl(256)]
		public static uint hash(half3 v)
		{
			return 0U;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000055F8 File Offset: 0x000037F8
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x5725B90", Offset = "0x5724790", VA = "0x185725B90")]
		[MethodImpl(256)]
		public static uint3 hashwide(half3 v)
		{
			return default(uint3);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00005610 File Offset: 0x00003810
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x5708A60", Offset = "0x5707660", VA = "0x185708A60")]
		[MethodImpl(256)]
		public static half4 half4(half x, half y, half z, half w)
		{
			return default(half4);
		}

		// Token: 0x06000248 RID: 584 RVA: 0x00005628 File Offset: 0x00003828
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x571B810", Offset = "0x571A410", VA = "0x18571B810")]
		[MethodImpl(256)]
		public static half4 half4(half x, half y, half2 zw)
		{
			return default(half4);
		}

		// Token: 0x06000249 RID: 585 RVA: 0x00005640 File Offset: 0x00003840
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x571B6B0", Offset = "0x571A2B0", VA = "0x18571B6B0")]
		[MethodImpl(256)]
		public static half4 half4(half x, half2 yz, half w)
		{
			return default(half4);
		}

		// Token: 0x0600024A RID: 586 RVA: 0x00005658 File Offset: 0x00003858
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x571B8D0", Offset = "0x571A4D0", VA = "0x18571B8D0")]
		[MethodImpl(256)]
		public static half4 half4(half x, half3 yzw)
		{
			return default(half4);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x00005670 File Offset: 0x00003870
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x571B660", Offset = "0x571A260", VA = "0x18571B660")]
		[MethodImpl(256)]
		public static half4 half4(half2 xy, half z, half w)
		{
			return default(half4);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x00005688 File Offset: 0x00003888
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x571B760", Offset = "0x571A360", VA = "0x18571B760")]
		[MethodImpl(256)]
		public static half4 half4(half2 xy, half2 zw)
		{
			return default(half4);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000056A0 File Offset: 0x000038A0
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x571B7E0", Offset = "0x571A3E0", VA = "0x18571B7E0")]
		[MethodImpl(256)]
		public static half4 half4(half3 xyz, half w)
		{
			return default(half4);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000056B8 File Offset: 0x000038B8
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x571B8A0", Offset = "0x571A4A0", VA = "0x18571B8A0")]
		[MethodImpl(256)]
		public static half4 half4(half4 xyzw)
		{
			return default(half4);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x000056D0 File Offset: 0x000038D0
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x571B690", Offset = "0x571A290", VA = "0x18571B690")]
		[MethodImpl(256)]
		public static half4 half4(half v)
		{
			return default(half4);
		}

		// Token: 0x06000250 RID: 592 RVA: 0x000056E8 File Offset: 0x000038E8
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x571B780", Offset = "0x571A380", VA = "0x18571B780")]
		[MethodImpl(256)]
		public static half4 half4(float v)
		{
			return default(half4);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00005700 File Offset: 0x00003900
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x571B900", Offset = "0x571A500", VA = "0x18571B900")]
		[MethodImpl(256)]
		public static half4 half4(float4 v)
		{
			return default(half4);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00005718 File Offset: 0x00003918
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x571B840", Offset = "0x571A440", VA = "0x18571B840")]
		[MethodImpl(256)]
		public static half4 half4(double v)
		{
			return default(half4);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00005730 File Offset: 0x00003930
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x571B6E0", Offset = "0x571A2E0", VA = "0x18571B6E0")]
		[MethodImpl(256)]
		public static half4 half4(double4 v)
		{
			return default(half4);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00005748 File Offset: 0x00003948
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x571B990", Offset = "0x571A590", VA = "0x18571B990")]
		[MethodImpl(256)]
		public static uint hash(half4 v)
		{
			return 0U;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00005760 File Offset: 0x00003960
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x5728150", Offset = "0x5726D50", VA = "0x185728150")]
		[MethodImpl(256)]
		public static uint4 hashwide(half4 v)
		{
			return default(uint4);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x57090A0", Offset = "0x5707CA0", VA = "0x1857090A0")]
		[MethodImpl(256)]
		public static int2 int2(int x, int y)
		{
			return default(int2);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x5707920", Offset = "0x5706520", VA = "0x185707920")]
		[MethodImpl(256)]
		public static int2 int2(int2 xy)
		{
			return default(int2);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x57288C0", Offset = "0x57274C0", VA = "0x1857288C0")]
		[MethodImpl(256)]
		public static int2 int2(int v)
		{
			return default(int2);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x5728860", Offset = "0x5727460", VA = "0x185728860")]
		[MethodImpl(256)]
		public static int2 int2(bool v)
		{
			return default(int2);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x57288A0", Offset = "0x57274A0", VA = "0x1857288A0")]
		[MethodImpl(256)]
		public static int2 int2(bool2 v)
		{
			return default(int2);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x57288C0", Offset = "0x57274C0", VA = "0x1857288C0")]
		[MethodImpl(256)]
		public static int2 int2(uint v)
		{
			return default(int2);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00005808 File Offset: 0x00003A08
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x5707920", Offset = "0x5706520", VA = "0x185707920")]
		[MethodImpl(256)]
		public static int2 int2(uint2 v)
		{
			return default(int2);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x5728880", Offset = "0x5727480", VA = "0x185728880")]
		[MethodImpl(256)]
		public static int2 int2(float v)
		{
			return default(int2);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00005838 File Offset: 0x00003A38
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x5728820", Offset = "0x5727420", VA = "0x185728820")]
		[MethodImpl(256)]
		public static int2 int2(float2 v)
		{
			return default(int2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00005850 File Offset: 0x00003A50
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x5728840", Offset = "0x5727440", VA = "0x185728840")]
		[MethodImpl(256)]
		public static int2 int2(double v)
		{
			return default(int2);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x57288D0", Offset = "0x57274D0", VA = "0x1857288D0")]
		[MethodImpl(256)]
		public static int2 int2(double2 v)
		{
			return default(int2);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x571E440", Offset = "0x571D040", VA = "0x18571E440")]
		[MethodImpl(256)]
		public static uint hash(int2 v)
		{
			return 0U;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00005898 File Offset: 0x00003A98
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x57269E0", Offset = "0x57255E0", VA = "0x1857269E0")]
		[MethodImpl(256)]
		public static uint2 hashwide(int2 v)
		{
			return default(uint2);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000058B0 File Offset: 0x00003AB0
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x574BEA0", Offset = "0x574AAA0", VA = "0x18574BEA0")]
		[MethodImpl(256)]
		public static int shuffle(int2 left, int2 right, math.ShuffleComponent x)
		{
			return 0;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000058C8 File Offset: 0x00003AC8
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x574C350", Offset = "0x574AF50", VA = "0x18574C350")]
		[MethodImpl(256)]
		public static int2 shuffle(int2 left, int2 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(int2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x000058E0 File Offset: 0x00003AE0
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x574BCF0", Offset = "0x574A8F0", VA = "0x18574BCF0")]
		[MethodImpl(256)]
		public static int3 shuffle(int2 left, int2 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(int3);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x000058F8 File Offset: 0x00003AF8
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x574B070", Offset = "0x5749C70", VA = "0x18574B070")]
		[MethodImpl(256)]
		public static int4 shuffle(int2 left, int2 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(int4);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00005910 File Offset: 0x00003B10
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x5702BA0", Offset = "0x57017A0", VA = "0x185702BA0")]
		[MethodImpl(256)]
		internal static int select_shuffle_component(int2 a, int2 b, math.ShuffleComponent component)
		{
			return 0;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00005928 File Offset: 0x00003B28
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x5067AF0", Offset = "0x50666F0", VA = "0x185067AF0")]
		[MethodImpl(256)]
		public static int2x2 int2x2(int2 c0, int2 c1)
		{
			return default(int2x2);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00005940 File Offset: 0x00003B40
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x5728A10", Offset = "0x5727610", VA = "0x185728A10")]
		[MethodImpl(256)]
		public static int2x2 int2x2(int m00, int m01, int m10, int m11)
		{
			return default(int2x2);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00005958 File Offset: 0x00003B58
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x57289E0", Offset = "0x57275E0", VA = "0x1857289E0")]
		[MethodImpl(256)]
		public static int2x2 int2x2(int v)
		{
			return default(int2x2);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00005970 File Offset: 0x00003B70
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x5728B40", Offset = "0x5727740", VA = "0x185728B40")]
		[MethodImpl(256)]
		public static int2x2 int2x2(bool v)
		{
			return default(int2x2);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00005988 File Offset: 0x00003B88
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x57288F0", Offset = "0x57274F0", VA = "0x1857288F0")]
		[MethodImpl(256)]
		public static int2x2 int2x2(bool2x2 v)
		{
			return default(int2x2);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000059A0 File Offset: 0x00003BA0
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x57289E0", Offset = "0x57275E0", VA = "0x1857289E0")]
		[MethodImpl(256)]
		public static int2x2 int2x2(uint v)
		{
			return default(int2x2);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x000059B8 File Offset: 0x00003BB8
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x5728AC0", Offset = "0x57276C0", VA = "0x185728AC0")]
		[MethodImpl(256)]
		public static int2x2 int2x2(uint2x2 v)
		{
			return default(int2x2);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000059D0 File Offset: 0x00003BD0
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x5728A90", Offset = "0x5727690", VA = "0x185728A90")]
		[MethodImpl(256)]
		public static int2x2 int2x2(float v)
		{
			return default(int2x2);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000059E8 File Offset: 0x00003BE8
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x5728990", Offset = "0x5727590", VA = "0x185728990")]
		[MethodImpl(256)]
		public static int2x2 int2x2(float2x2 v)
		{
			return default(int2x2);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00005A00 File Offset: 0x00003C00
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x5728B10", Offset = "0x5727710", VA = "0x185728B10")]
		[MethodImpl(256)]
		public static int2x2 int2x2(double v)
		{
			return default(int2x2);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00005A18 File Offset: 0x00003C18
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x5728A40", Offset = "0x5727640", VA = "0x185728A40")]
		[MethodImpl(256)]
		public static int2x2 int2x2(double2x2 v)
		{
			return default(int2x2);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00005A30 File Offset: 0x00003C30
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x5751730", Offset = "0x5750330", VA = "0x185751730")]
		[MethodImpl(256)]
		public static int2x2 transpose(int2x2 v)
		{
			return default(int2x2);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00005A48 File Offset: 0x00003C48
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x570D1D0", Offset = "0x570BDD0", VA = "0x18570D1D0")]
		[MethodImpl(256)]
		public static int determinant(int2x2 m)
		{
			return 0;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00005A60 File Offset: 0x00003C60
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x5720030", Offset = "0x571EC30", VA = "0x185720030")]
		[MethodImpl(256)]
		public static uint hash(int2x2 v)
		{
			return 0U;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00005A78 File Offset: 0x00003C78
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x5724A00", Offset = "0x5723600", VA = "0x185724A00")]
		[MethodImpl(256)]
		public static uint2 hashwide(int2x2 v)
		{
			return default(uint2);
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00005A90 File Offset: 0x00003C90
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x509C000", Offset = "0x509AC00", VA = "0x18509C000")]
		[MethodImpl(256)]
		public static int2x3 int2x3(int2 c0, int2 c1, int2 c2)
		{
			return default(int2x3);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x5728BE0", Offset = "0x57277E0", VA = "0x185728BE0")]
		[MethodImpl(256)]
		public static int2x3 int2x3(int m00, int m01, int m02, int m10, int m11, int m12)
		{
			return default(int2x3);
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00005AC0 File Offset: 0x00003CC0
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x5728CC0", Offset = "0x57278C0", VA = "0x185728CC0")]
		[MethodImpl(256)]
		public static int2x3 int2x3(int v)
		{
			return default(int2x3);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00005AD8 File Offset: 0x00003CD8
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x5728ED0", Offset = "0x5727AD0", VA = "0x185728ED0")]
		[MethodImpl(256)]
		public static int2x3 int2x3(bool v)
		{
			return default(int2x3);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00005AF0 File Offset: 0x00003CF0
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x5728D40", Offset = "0x5727940", VA = "0x185728D40")]
		[MethodImpl(256)]
		public static int2x3 int2x3(bool2x3 v)
		{
			return default(int2x3);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00005B08 File Offset: 0x00003D08
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x5728CC0", Offset = "0x57278C0", VA = "0x185728CC0")]
		[MethodImpl(256)]
		public static int2x3 int2x3(uint v)
		{
			return default(int2x3);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00005B20 File Offset: 0x00003D20
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x5728C30", Offset = "0x5727830", VA = "0x185728C30")]
		[MethodImpl(256)]
		public static int2x3 int2x3(uint2x3 v)
		{
			return default(int2x3);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00005B38 File Offset: 0x00003D38
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x5728BA0", Offset = "0x57277A0", VA = "0x185728BA0")]
		[MethodImpl(256)]
		public static int2x3 int2x3(float v)
		{
			return default(int2x3);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00005B50 File Offset: 0x00003D50
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x5728F50", Offset = "0x5727B50", VA = "0x185728F50")]
		[MethodImpl(256)]
		public static int2x3 int2x3(float2x3 v)
		{
			return default(int2x3);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00005B68 File Offset: 0x00003D68
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x5728D00", Offset = "0x5727900", VA = "0x185728D00")]
		[MethodImpl(256)]
		public static int2x3 int2x3(double v)
		{
			return default(int2x3);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00005B80 File Offset: 0x00003D80
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x5728E60", Offset = "0x5727A60", VA = "0x185728E60")]
		[MethodImpl(256)]
		public static int2x3 int2x3(double2x3 v)
		{
			return default(int2x3);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00005B98 File Offset: 0x00003D98
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x57525A0", Offset = "0x57511A0", VA = "0x1857525A0")]
		[MethodImpl(256)]
		public static int3x2 transpose(int2x3 v)
		{
			return default(int3x2);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00005BB0 File Offset: 0x00003DB0
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x571EA90", Offset = "0x571D690", VA = "0x18571EA90")]
		[MethodImpl(256)]
		public static uint hash(int2x3 v)
		{
			return 0U;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00005BC8 File Offset: 0x00003DC8
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x5726690", Offset = "0x5725290", VA = "0x185726690")]
		[MethodImpl(256)]
		public static uint2 hashwide(int2x3 v)
		{
			return default(uint2);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00005BE0 File Offset: 0x00003DE0
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x5729110", Offset = "0x5727D10", VA = "0x185729110")]
		[MethodImpl(256)]
		public static int2x4 int2x4(int2 c0, int2 c1, int2 c2, int2 c3)
		{
			return default(int2x4);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00005BF8 File Offset: 0x00003DF8
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x5729220", Offset = "0x5727E20", VA = "0x185729220")]
		[MethodImpl(256)]
		public static int2x4 int2x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13)
		{
			return default(int2x4);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00005C10 File Offset: 0x00003E10
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x5729130", Offset = "0x5727D30", VA = "0x185729130")]
		[MethodImpl(256)]
		public static int2x4 int2x4(int v)
		{
			return default(int2x4);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00005C28 File Offset: 0x00003E28
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x5729280", Offset = "0x5727E80", VA = "0x185729280")]
		[MethodImpl(256)]
		public static int2x4 int2x4(bool v)
		{
			return default(int2x4);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00005C40 File Offset: 0x00003E40
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x5728FE0", Offset = "0x5727BE0", VA = "0x185728FE0")]
		[MethodImpl(256)]
		public static int2x4 int2x4(bool2x4 v)
		{
			return default(int2x4);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00005C58 File Offset: 0x00003E58
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x5729130", Offset = "0x5727D30", VA = "0x185729130")]
		[MethodImpl(256)]
		public static int2x4 int2x4(uint v)
		{
			return default(int2x4);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00005C70 File Offset: 0x00003E70
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x5729180", Offset = "0x5727D80", VA = "0x185729180")]
		[MethodImpl(256)]
		public static int2x4 int2x4(uint2x4 v)
		{
			return default(int2x4);
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00005C88 File Offset: 0x00003E88
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x5729410", Offset = "0x5728010", VA = "0x185729410")]
		[MethodImpl(256)]
		public static int2x4 int2x4(float v)
		{
			return default(int2x4);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00005CA0 File Offset: 0x00003EA0
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x5729370", Offset = "0x5727F70", VA = "0x185729370")]
		[MethodImpl(256)]
		public static int2x4 int2x4(float2x4 v)
		{
			return default(int2x4);
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00005CB8 File Offset: 0x00003EB8
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x5729320", Offset = "0x5727F20", VA = "0x185729320")]
		[MethodImpl(256)]
		public static int2x4 int2x4(double v)
		{
			return default(int2x4);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00005CD0 File Offset: 0x00003ED0
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x5729460", Offset = "0x5728060", VA = "0x185729460")]
		[MethodImpl(256)]
		public static int2x4 int2x4(double2x4 v)
		{
			return default(int2x4);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00005CE8 File Offset: 0x00003EE8
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x57519A0", Offset = "0x57505A0", VA = "0x1857519A0")]
		[MethodImpl(256)]
		public static int4x2 transpose(int2x4 v)
		{
			return default(int4x2);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00005D00 File Offset: 0x00003F00
		[Token(Token = "0x6000291")]
		[Address(RVA = "0x571D750", Offset = "0x571C350", VA = "0x18571D750")]
		[MethodImpl(256)]
		public static uint hash(int2x4 v)
		{
			return 0U;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00005D18 File Offset: 0x00003F18
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x5723C90", Offset = "0x5722890", VA = "0x185723C90")]
		[MethodImpl(256)]
		public static uint2 hashwide(int2x4 v)
		{
			return default(uint2);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00005D30 File Offset: 0x00003F30
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x5709100", Offset = "0x5707D00", VA = "0x185709100")]
		[MethodImpl(256)]
		public static int3 int3(int x, int y, int z)
		{
			return default(int3);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00005D48 File Offset: 0x00003F48
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x5729560", Offset = "0x5728160", VA = "0x185729560")]
		[MethodImpl(256)]
		public static int3 int3(int x, int2 yz)
		{
			return default(int3);
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00005D60 File Offset: 0x00003F60
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x5729580", Offset = "0x5728180", VA = "0x185729580")]
		[MethodImpl(256)]
		public static int3 int3(int2 xy, int z)
		{
			return default(int3);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00005D78 File Offset: 0x00003F78
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x57295A0", Offset = "0x57281A0", VA = "0x1857295A0")]
		[MethodImpl(256)]
		public static int3 int3(int3 xyz)
		{
			return default(int3);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00005D90 File Offset: 0x00003F90
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x5729510", Offset = "0x5728110", VA = "0x185729510")]
		[MethodImpl(256)]
		public static int3 int3(int v)
		{
			return default(int3);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00005DA8 File Offset: 0x00003FA8
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x57294F0", Offset = "0x57280F0", VA = "0x1857294F0")]
		[MethodImpl(256)]
		public static int3 int3(bool v)
		{
			return default(int3);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00005DC0 File Offset: 0x00003FC0
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x57295F0", Offset = "0x57281F0", VA = "0x1857295F0")]
		[MethodImpl(256)]
		public static int3 int3(bool3 v)
		{
			return default(int3);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00005DD8 File Offset: 0x00003FD8
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x5729510", Offset = "0x5728110", VA = "0x185729510")]
		[MethodImpl(256)]
		public static int3 int3(uint v)
		{
			return default(int3);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00005DF0 File Offset: 0x00003FF0
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x57295A0", Offset = "0x57281A0", VA = "0x1857295A0")]
		[MethodImpl(256)]
		public static int3 int3(uint3 v)
		{
			return default(int3);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00005E08 File Offset: 0x00004008
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x57295E0", Offset = "0x57281E0", VA = "0x1857295E0")]
		[MethodImpl(256)]
		public static int3 int3(float v)
		{
			return default(int3);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00005E20 File Offset: 0x00004020
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x5729520", Offset = "0x5728120", VA = "0x185729520")]
		[MethodImpl(256)]
		public static int3 int3(float3 v)
		{
			return default(int3);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00005E38 File Offset: 0x00004038
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x57295D0", Offset = "0x57281D0", VA = "0x1857295D0")]
		[MethodImpl(256)]
		public static int3 int3(double v)
		{
			return default(int3);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00005E50 File Offset: 0x00004050
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x5729630", Offset = "0x5728230", VA = "0x185729630")]
		[MethodImpl(256)]
		public static int3 int3(double3 v)
		{
			return default(int3);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00005E68 File Offset: 0x00004068
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x57212E0", Offset = "0x571FEE0", VA = "0x1857212E0")]
		[MethodImpl(256)]
		public static uint hash(int3 v)
		{
			return 0U;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00005E80 File Offset: 0x00004080
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x5727540", Offset = "0x5726140", VA = "0x185727540")]
		[MethodImpl(256)]
		public static uint3 hashwide(int3 v)
		{
			return default(uint3);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00005E98 File Offset: 0x00004098
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x574AEE0", Offset = "0x5749AE0", VA = "0x18574AEE0")]
		[MethodImpl(256)]
		public static int shuffle(int3 left, int3 right, math.ShuffleComponent x)
		{
			return 0;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00005EB0 File Offset: 0x000040B0
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x574B5B0", Offset = "0x574A1B0", VA = "0x18574B5B0")]
		[MethodImpl(256)]
		public static int2 shuffle(int3 left, int3 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(int2);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00005EC8 File Offset: 0x000040C8
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x574C110", Offset = "0x574AD10", VA = "0x18574C110")]
		[MethodImpl(256)]
		public static int3 shuffle(int3 left, int3 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(int3);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00005EE0 File Offset: 0x000040E0
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x574B730", Offset = "0x574A330", VA = "0x18574B730")]
		[MethodImpl(256)]
		public static int4 shuffle(int3 left, int3 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(int4);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00005EF8 File Offset: 0x000040F8
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x5701F50", Offset = "0x5700B50", VA = "0x185701F50")]
		[MethodImpl(256)]
		internal static int select_shuffle_component(int3 a, int3 b, math.ShuffleComponent component)
		{
			return 0;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00005F10 File Offset: 0x00004110
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x5717440", Offset = "0x5716040", VA = "0x185717440")]
		[MethodImpl(256)]
		public static int3x2 int3x2(int3 c0, int3 c1)
		{
			return default(int3x2);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00005F28 File Offset: 0x00004128
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x57297D0", Offset = "0x57283D0", VA = "0x1857297D0")]
		[MethodImpl(256)]
		public static int3x2 int3x2(int m00, int m01, int m10, int m11, int m20, int m21)
		{
			return default(int3x2);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00005F40 File Offset: 0x00004140
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x5729820", Offset = "0x5728420", VA = "0x185729820")]
		[MethodImpl(256)]
		public static int3x2 int3x2(int v)
		{
			return default(int3x2);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00005F58 File Offset: 0x00004158
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x5729860", Offset = "0x5728460", VA = "0x185729860")]
		[MethodImpl(256)]
		public static int3x2 int3x2(bool v)
		{
			return default(int3x2);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00005F70 File Offset: 0x00004170
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x57298D0", Offset = "0x57284D0", VA = "0x1857298D0")]
		[MethodImpl(256)]
		public static int3x2 int3x2(bool3x2 v)
		{
			return default(int3x2);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00005F88 File Offset: 0x00004188
		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x5729820", Offset = "0x5728420", VA = "0x185729820")]
		[MethodImpl(256)]
		public static int3x2 int3x2(uint v)
		{
			return default(int3x2);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00005FA0 File Offset: 0x000041A0
		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x57296D0", Offset = "0x57282D0", VA = "0x1857296D0")]
		[MethodImpl(256)]
		public static int3x2 int3x2(uint3x2 v)
		{
			return default(int3x2);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00005FB8 File Offset: 0x000041B8
		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x57299B0", Offset = "0x57285B0", VA = "0x1857299B0")]
		[MethodImpl(256)]
		public static int3x2 int3x2(float v)
		{
			return default(int3x2);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00005FD0 File Offset: 0x000041D0
		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x5729750", Offset = "0x5728350", VA = "0x185729750")]
		[MethodImpl(256)]
		public static int3x2 int3x2(float3x2 v)
		{
			return default(int3x2);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00005FE8 File Offset: 0x000041E8
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x57299F0", Offset = "0x57285F0", VA = "0x1857299F0")]
		[MethodImpl(256)]
		public static int3x2 int3x2(double v)
		{
			return default(int3x2);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00006000 File Offset: 0x00004200
		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x5729670", Offset = "0x5728270", VA = "0x185729670")]
		[MethodImpl(256)]
		public static int3x2 int3x2(double3x2 v)
		{
			return default(int3x2);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00006018 File Offset: 0x00004218
		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x5751780", Offset = "0x5750380", VA = "0x185751780")]
		[MethodImpl(256)]
		public static int2x3 transpose(int3x2 v)
		{
			return default(int2x3);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00006030 File Offset: 0x00004230
		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x5721AA0", Offset = "0x57206A0", VA = "0x185721AA0")]
		[MethodImpl(256)]
		public static uint hash(int3x2 v)
		{
			return 0U;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00006048 File Offset: 0x00004248
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x57248D0", Offset = "0x57234D0", VA = "0x1857248D0")]
		[MethodImpl(256)]
		public static uint3 hashwide(int3x2 v)
		{
			return default(uint3);
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00006060 File Offset: 0x00004260
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x5717C20", Offset = "0x5716820", VA = "0x185717C20")]
		[MethodImpl(256)]
		public static int3x3 int3x3(int3 c0, int3 c1, int3 c2)
		{
			return default(int3x3);
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00006078 File Offset: 0x00004278
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x5729CF0", Offset = "0x57288F0", VA = "0x185729CF0")]
		[MethodImpl(256)]
		public static int3x3 int3x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22)
		{
			return default(int3x3);
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00006090 File Offset: 0x00004290
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x5729A30", Offset = "0x5728630", VA = "0x185729A30")]
		[MethodImpl(256)]
		public static int3x3 int3x3(int v)
		{
			return default(int3x3);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000060A8 File Offset: 0x000042A8
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x5729ED0", Offset = "0x5728AD0", VA = "0x185729ED0")]
		[MethodImpl(256)]
		public static int3x3 int3x3(bool v)
		{
			return default(int3x3);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000060C0 File Offset: 0x000042C0
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x5729DB0", Offset = "0x57289B0", VA = "0x185729DB0")]
		[MethodImpl(256)]
		public static int3x3 int3x3(bool3x3 v)
		{
			return default(int3x3);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000060D8 File Offset: 0x000042D8
		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x5729A30", Offset = "0x5728630", VA = "0x185729A30")]
		[MethodImpl(256)]
		public static int3x3 int3x3(uint v)
		{
			return default(int3x3);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000060F0 File Offset: 0x000042F0
		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x5729AD0", Offset = "0x57286D0", VA = "0x185729AD0")]
		[MethodImpl(256)]
		public static int3x3 int3x3(uint3x3 v)
		{
			return default(int3x3);
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00006108 File Offset: 0x00004308
		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x5729A80", Offset = "0x5728680", VA = "0x185729A80")]
		[MethodImpl(256)]
		public static int3x3 int3x3(float v)
		{
			return default(int3x3);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00006120 File Offset: 0x00004320
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x5729C40", Offset = "0x5728840", VA = "0x185729C40")]
		[MethodImpl(256)]
		public static int3x3 int3x3(float3x3 v)
		{
			return default(int3x3);
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00006138 File Offset: 0x00004338
		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x5729D60", Offset = "0x5728960", VA = "0x185729D60")]
		[MethodImpl(256)]
		public static int3x3 int3x3(double v)
		{
			return default(int3x3);
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00006150 File Offset: 0x00004350
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x5729B90", Offset = "0x5728790", VA = "0x185729B90")]
		[MethodImpl(256)]
		public static int3x3 int3x3(double3x3 v)
		{
			return default(int3x3);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00006168 File Offset: 0x00004368
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x5751D80", Offset = "0x5750980", VA = "0x185751D80")]
		[MethodImpl(256)]
		public static int3x3 transpose(int3x3 v)
		{
			return default(int3x3);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00006180 File Offset: 0x00004380
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x570D6F0", Offset = "0x570C2F0", VA = "0x18570D6F0")]
		[MethodImpl(256)]
		public static int determinant(int3x3 m)
		{
			return 0;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00006198 File Offset: 0x00004398
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x571D400", Offset = "0x571C000", VA = "0x18571D400")]
		[MethodImpl(256)]
		public static uint hash(int3x3 v)
		{
			return 0U;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000061B0 File Offset: 0x000043B0
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x5723AE0", Offset = "0x57226E0", VA = "0x185723AE0")]
		[MethodImpl(256)]
		public static uint3 hashwide(int3x3 v)
		{
			return default(uint3);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000061C8 File Offset: 0x000043C8
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x5718550", Offset = "0x5717150", VA = "0x185718550")]
		[MethodImpl(256)]
		public static int3x4 int3x4(int3 c0, int3 c1, int3 c2, int3 c3)
		{
			return default(int3x4);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000061E0 File Offset: 0x000043E0
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x572A310", Offset = "0x5728F10", VA = "0x18572A310")]
		[MethodImpl(256)]
		public static int3x4 int3x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23)
		{
			return default(int3x4);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000061F8 File Offset: 0x000043F8
		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x572A120", Offset = "0x5728D20", VA = "0x18572A120")]
		[MethodImpl(256)]
		public static int3x4 int3x4(int v)
		{
			return default(int3x4);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00006210 File Offset: 0x00004410
		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x5729F70", Offset = "0x5728B70", VA = "0x185729F70")]
		[MethodImpl(256)]
		public static int3x4 int3x4(bool v)
		{
			return default(int3x4);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00006228 File Offset: 0x00004428
		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x572A0E0", Offset = "0x5728CE0", VA = "0x18572A0E0")]
		[MethodImpl(256)]
		public static int3x4 int3x4(bool3x4 v)
		{
			return default(int3x4);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00006240 File Offset: 0x00004440
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x572A120", Offset = "0x5728D20", VA = "0x18572A120")]
		[MethodImpl(256)]
		public static int3x4 int3x4(uint v)
		{
			return default(int3x4);
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00006258 File Offset: 0x00004458
		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x572A3A0", Offset = "0x5728FA0", VA = "0x18572A3A0")]
		[MethodImpl(256)]
		public static int3x4 int3x4(uint3x4 v)
		{
			return default(int3x4);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00006270 File Offset: 0x00004470
		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x572A2B0", Offset = "0x5728EB0", VA = "0x18572A2B0")]
		[MethodImpl(256)]
		public static int3x4 int3x4(float v)
		{
			return default(int3x4);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00006288 File Offset: 0x00004488
		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x572A180", Offset = "0x5728D80", VA = "0x18572A180")]
		[MethodImpl(256)]
		public static int3x4 int3x4(float3x4 v)
		{
			return default(int3x4);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000062A0 File Offset: 0x000044A0
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x572A250", Offset = "0x5728E50", VA = "0x18572A250")]
		[MethodImpl(256)]
		public static int3x4 int3x4(double v)
		{
			return default(int3x4);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000062B8 File Offset: 0x000044B8
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x572A030", Offset = "0x5728C30", VA = "0x18572A030")]
		[MethodImpl(256)]
		public static int3x4 int3x4(double3x4 v)
		{
			return default(int3x4);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000062D0 File Offset: 0x000044D0
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x57518C0", Offset = "0x57504C0", VA = "0x1857518C0")]
		[MethodImpl(256)]
		public static int4x3 transpose(int3x4 v)
		{
			return default(int4x3);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000062E8 File Offset: 0x000044E8
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x571D070", Offset = "0x571BC70", VA = "0x18571D070")]
		[MethodImpl(256)]
		public static uint hash(int3x4 v)
		{
			return 0U;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00006300 File Offset: 0x00004500
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x5725650", Offset = "0x5724250", VA = "0x185725650")]
		[MethodImpl(256)]
		public static uint3 hashwide(int3x4 v)
		{
			return default(uint3);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00006318 File Offset: 0x00004518
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x5709240", Offset = "0x5707E40", VA = "0x185709240")]
		[MethodImpl(256)]
		public static int4 int4(int x, int y, int z, int w)
		{
			return default(int4);
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00006330 File Offset: 0x00004530
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x572A610", Offset = "0x5729210", VA = "0x18572A610")]
		[MethodImpl(256)]
		public static int4 int4(int x, int y, int2 zw)
		{
			return default(int4);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00006348 File Offset: 0x00004548
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x572A690", Offset = "0x5729290", VA = "0x18572A690")]
		[MethodImpl(256)]
		public static int4 int4(int x, int2 yz, int w)
		{
			return default(int4);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00006360 File Offset: 0x00004560
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x572A4F0", Offset = "0x57290F0", VA = "0x18572A4F0")]
		[MethodImpl(256)]
		public static int4 int4(int x, int3 yzw)
		{
			return default(int4);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00006378 File Offset: 0x00004578
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x572A630", Offset = "0x5729230", VA = "0x18572A630")]
		[MethodImpl(256)]
		public static int4 int4(int2 xy, int z, int w)
		{
			return default(int4);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00006390 File Offset: 0x00004590
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x572A5F0", Offset = "0x57291F0", VA = "0x18572A5F0")]
		[MethodImpl(256)]
		public static int4 int4(int2 xy, int2 zw)
		{
			return default(int4);
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000063A8 File Offset: 0x000045A8
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x572A650", Offset = "0x5729250", VA = "0x18572A650")]
		[MethodImpl(256)]
		public static int4 int4(int3 xyz, int w)
		{
			return default(int4);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000063C0 File Offset: 0x000045C0
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x572A480", Offset = "0x5729080", VA = "0x18572A480")]
		[MethodImpl(256)]
		public static int4 int4(int4 xyzw)
		{
			return default(int4);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000063D8 File Offset: 0x000045D8
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x572A4C0", Offset = "0x57290C0", VA = "0x18572A4C0")]
		[MethodImpl(256)]
		public static int4 int4(int v)
		{
			return default(int4);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000063F0 File Offset: 0x000045F0
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x572A4D0", Offset = "0x57290D0", VA = "0x18572A4D0")]
		[MethodImpl(256)]
		public static int4 int4(bool v)
		{
			return default(int4);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00006408 File Offset: 0x00004608
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x572A530", Offset = "0x5729130", VA = "0x18572A530")]
		[MethodImpl(256)]
		public static int4 int4(bool4 v)
		{
			return default(int4);
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00006420 File Offset: 0x00004620
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x572A4C0", Offset = "0x57290C0", VA = "0x18572A4C0")]
		[MethodImpl(256)]
		public static int4 int4(uint v)
		{
			return default(int4);
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00006438 File Offset: 0x00004638
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x572A480", Offset = "0x5729080", VA = "0x18572A480")]
		[MethodImpl(256)]
		public static int4 int4(uint4 v)
		{
			return default(int4);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00006450 File Offset: 0x00004650
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x572A5D0", Offset = "0x57291D0", VA = "0x18572A5D0")]
		[MethodImpl(256)]
		public static int4 int4(float v)
		{
			return default(int4);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00006468 File Offset: 0x00004668
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x572A6B0", Offset = "0x57292B0", VA = "0x18572A6B0")]
		[MethodImpl(256)]
		public static int4 int4(float4 v)
		{
			return default(int4);
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x00006480 File Offset: 0x00004680
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x572A5B0", Offset = "0x57291B0", VA = "0x18572A5B0")]
		[MethodImpl(256)]
		public static int4 int4(double v)
		{
			return default(int4);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x00006498 File Offset: 0x00004698
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x572A580", Offset = "0x5729180", VA = "0x18572A580")]
		[MethodImpl(256)]
		public static int4 int4(double4 v)
		{
			return default(int4);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000064B0 File Offset: 0x000046B0
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x5721BB0", Offset = "0x57207B0", VA = "0x185721BB0")]
		[MethodImpl(256)]
		public static uint hash(int4 v)
		{
			return 0U;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000064C8 File Offset: 0x000046C8
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x5727C70", Offset = "0x5726870", VA = "0x185727C70")]
		[MethodImpl(256)]
		public static uint4 hashwide(int4 v)
		{
			return default(uint4);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000064E0 File Offset: 0x000046E0
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x574B580", Offset = "0x574A180", VA = "0x18574B580")]
		[MethodImpl(256)]
		public static int shuffle(int4 left, int4 right, math.ShuffleComponent x)
		{
			return 0;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000064F8 File Offset: 0x000046F8
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x574A6C0", Offset = "0x57492C0", VA = "0x18574A6C0")]
		[MethodImpl(256)]
		public static int2 shuffle(int4 left, int4 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(int2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00006510 File Offset: 0x00004710
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x574C9F0", Offset = "0x574B5F0", VA = "0x18574C9F0")]
		[MethodImpl(256)]
		public static int3 shuffle(int4 left, int4 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(int3);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00006528 File Offset: 0x00004728
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x574A9D0", Offset = "0x57495D0", VA = "0x18574A9D0")]
		[MethodImpl(256)]
		public static int4 shuffle(int4 left, int4 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(int4);
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00006540 File Offset: 0x00004740
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x57025D0", Offset = "0x57011D0", VA = "0x1857025D0")]
		[MethodImpl(256)]
		internal static int select_shuffle_component(int4 a, int4 b, math.ShuffleComponent component)
		{
			return 0;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00006558 File Offset: 0x00004758
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x5718C40", Offset = "0x5717840", VA = "0x185718C40")]
		[MethodImpl(256)]
		public static int4x2 int4x2(int4 c0, int4 c1)
		{
			return default(int4x2);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00006570 File Offset: 0x00004770
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x572AA70", Offset = "0x5729670", VA = "0x18572AA70")]
		[MethodImpl(256)]
		public static int4x2 int4x2(int m00, int m01, int m10, int m11, int m20, int m21, int m30, int m31)
		{
			return default(int4x2);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00006588 File Offset: 0x00004788
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x572A7B0", Offset = "0x57293B0", VA = "0x18572A7B0")]
		[MethodImpl(256)]
		public static int4x2 int4x2(int v)
		{
			return default(int4x2);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000065A0 File Offset: 0x000047A0
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x572A8B0", Offset = "0x57294B0", VA = "0x18572A8B0")]
		[MethodImpl(256)]
		public static int4x2 int4x2(bool v)
		{
			return default(int4x2);
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000065B8 File Offset: 0x000047B8
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x572A970", Offset = "0x5729570", VA = "0x18572A970")]
		[MethodImpl(256)]
		public static int4x2 int4x2(bool4x2 v)
		{
			return default(int4x2);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000065D0 File Offset: 0x000047D0
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x572A7B0", Offset = "0x57293B0", VA = "0x18572A7B0")]
		[MethodImpl(256)]
		public static int4x2 int4x2(uint v)
		{
			return default(int4x2);
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000065E8 File Offset: 0x000047E8
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x572A7F0", Offset = "0x57293F0", VA = "0x18572A7F0")]
		[MethodImpl(256)]
		public static int4x2 int4x2(uint4x2 v)
		{
			return default(int4x2);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00006600 File Offset: 0x00004800
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x572A870", Offset = "0x5729470", VA = "0x18572A870")]
		[MethodImpl(256)]
		public static int4x2 int4x2(float v)
		{
			return default(int4x2);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x572A8E0", Offset = "0x57294E0", VA = "0x18572A8E0")]
		[MethodImpl(256)]
		public static int4x2 int4x2(float4x2 v)
		{
			return default(int4x2);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00006630 File Offset: 0x00004830
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x572A6F0", Offset = "0x57292F0", VA = "0x18572A6F0")]
		[MethodImpl(256)]
		public static int4x2 int4x2(double v)
		{
			return default(int4x2);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00006648 File Offset: 0x00004848
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x572A730", Offset = "0x5729330", VA = "0x18572A730")]
		[MethodImpl(256)]
		public static int4x2 int4x2(double4x2 v)
		{
			return default(int4x2);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x00006660 File Offset: 0x00004860
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x57517F0", Offset = "0x57503F0", VA = "0x1857517F0")]
		[MethodImpl(256)]
		public static int2x4 transpose(int4x2 v)
		{
			return default(int2x4);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00006678 File Offset: 0x00004878
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x5720440", Offset = "0x571F040", VA = "0x185720440")]
		[MethodImpl(256)]
		public static uint hash(int4x2 v)
		{
			return 0U;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00006690 File Offset: 0x00004890
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x57243D0", Offset = "0x5722FD0", VA = "0x1857243D0")]
		[MethodImpl(256)]
		public static uint4 hashwide(int4x2 v)
		{
			return default(uint4);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x57197C0", Offset = "0x57183C0", VA = "0x1857197C0")]
		[MethodImpl(256)]
		public static int4x3 int4x3(int4 c0, int4 c1, int4 c2)
		{
			return default(int4x3);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x572ACC0", Offset = "0x57298C0", VA = "0x18572ACC0")]
		[MethodImpl(256)]
		public static int4x3 int4x3(int m00, int m01, int m02, int m10, int m11, int m12, int m20, int m21, int m22, int m30, int m31, int m32)
		{
			return default(int4x3);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x000066D8 File Offset: 0x000048D8
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x572AB20", Offset = "0x5729720", VA = "0x18572AB20")]
		[MethodImpl(256)]
		public static int4x3 int4x3(int v)
		{
			return default(int4x3);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x000066F0 File Offset: 0x000048F0
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x572ADE0", Offset = "0x57299E0", VA = "0x18572ADE0")]
		[MethodImpl(256)]
		public static int4x3 int4x3(bool v)
		{
			return default(int4x3);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00006708 File Offset: 0x00004908
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x572AC80", Offset = "0x5729880", VA = "0x18572AC80")]
		[MethodImpl(256)]
		public static int4x3 int4x3(bool4x3 v)
		{
			return default(int4x3);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x572AB20", Offset = "0x5729720", VA = "0x18572AB20")]
		[MethodImpl(256)]
		public static int4x3 int4x3(uint v)
		{
			return default(int4x3);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x572AD40", Offset = "0x5729940", VA = "0x18572AD40")]
		[MethodImpl(256)]
		public static int4x3 int4x3(uint4x3 v)
		{
			return default(int4x3);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00006750 File Offset: 0x00004950
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x572AC20", Offset = "0x5729820", VA = "0x18572AC20")]
		[MethodImpl(256)]
		public static int4x3 int4x3(float v)
		{
			return default(int4x3);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00006768 File Offset: 0x00004968
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x572AE20", Offset = "0x5729A20", VA = "0x18572AE20")]
		[MethodImpl(256)]
		public static int4x3 int4x3(float4x3 v)
		{
			return default(int4x3);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00006780 File Offset: 0x00004980
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x572AAC0", Offset = "0x57296C0", VA = "0x18572AAC0")]
		[MethodImpl(256)]
		public static int4x3 int4x3(double v)
		{
			return default(int4x3);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x572AB70", Offset = "0x5729770", VA = "0x18572AB70")]
		[MethodImpl(256)]
		public static int4x3 int4x3(double4x3 v)
		{
			return default(int4x3);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x000067B0 File Offset: 0x000049B0
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x5751C00", Offset = "0x5750800", VA = "0x185751C00")]
		[MethodImpl(256)]
		public static int3x4 transpose(int4x3 v)
		{
			return default(int3x4);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x57205F0", Offset = "0x571F1F0", VA = "0x1857205F0")]
		[MethodImpl(256)]
		public static uint hash(int4x3 v)
		{
			return 0U;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x5726A50", Offset = "0x5725650", VA = "0x185726A50")]
		[MethodImpl(256)]
		public static uint4 hashwide(int4x3 v)
		{
			return default(uint4);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x5719BA0", Offset = "0x57187A0", VA = "0x185719BA0")]
		[MethodImpl(256)]
		public static int4x4 int4x4(int4 c0, int4 c1, int4 c2, int4 c3)
		{
			return default(int4x4);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00006810 File Offset: 0x00004A10
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x572B380", Offset = "0x5729F80", VA = "0x18572B380")]
		[MethodImpl(256)]
		public static int4x4 int4x4(int m00, int m01, int m02, int m03, int m10, int m11, int m12, int m13, int m20, int m21, int m22, int m23, int m30, int m31, int m32, int m33)
		{
			return default(int4x4);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x00006828 File Offset: 0x00004A28
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x572B040", Offset = "0x5729C40", VA = "0x18572B040")]
		[MethodImpl(256)]
		public static int4x4 int4x4(int v)
		{
			return default(int4x4);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00006840 File Offset: 0x00004A40
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x572AEF0", Offset = "0x5729AF0", VA = "0x18572AEF0")]
		[MethodImpl(256)]
		public static int4x4 int4x4(bool v)
		{
			return default(int4x4);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00006858 File Offset: 0x00004A58
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x572B110", Offset = "0x5729D10", VA = "0x18572B110")]
		[MethodImpl(256)]
		public static int4x4 int4x4(bool4x4 v)
		{
			return default(int4x4);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00006870 File Offset: 0x00004A70
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x572B040", Offset = "0x5729C40", VA = "0x18572B040")]
		[MethodImpl(256)]
		public static int4x4 int4x4(uint v)
		{
			return default(int4x4);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00006888 File Offset: 0x00004A88
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x572B150", Offset = "0x5729D50", VA = "0x18572B150")]
		[MethodImpl(256)]
		public static int4x4 int4x4(uint4x4 v)
		{
			return default(int4x4);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x000068A0 File Offset: 0x00004AA0
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x572B0A0", Offset = "0x5729CA0", VA = "0x18572B0A0")]
		[MethodImpl(256)]
		public static int4x4 int4x4(float v)
		{
			return default(int4x4);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x000068B8 File Offset: 0x00004AB8
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x572AF40", Offset = "0x5729B40", VA = "0x18572AF40")]
		[MethodImpl(256)]
		public static int4x4 int4x4(float4x4 v)
		{
			return default(int4x4);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x000068D0 File Offset: 0x00004AD0
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x572B310", Offset = "0x5729F10", VA = "0x18572B310")]
		[MethodImpl(256)]
		public static int4x4 int4x4(double v)
		{
			return default(int4x4);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x000068E8 File Offset: 0x00004AE8
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x572B220", Offset = "0x5729E20", VA = "0x18572B220")]
		[MethodImpl(256)]
		public static int4x4 int4x4(double4x4 v)
		{
			return default(int4x4);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00006900 File Offset: 0x00004B00
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x5752000", Offset = "0x5750C00", VA = "0x185752000")]
		[MethodImpl(256)]
		public static int4x4 transpose(int4x4 v)
		{
			return default(int4x4);
		}

		// Token: 0x06000312 RID: 786 RVA: 0x00006918 File Offset: 0x00004B18
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x570D490", Offset = "0x570C090", VA = "0x18570D490")]
		public static int determinant(int4x4 m)
		{
			return 0;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x00006930 File Offset: 0x00004B30
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x571F0E0", Offset = "0x571DCE0", VA = "0x18571F0E0")]
		[MethodImpl(256)]
		public static uint hash(int4x4 v)
		{
			return 0U;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00006948 File Offset: 0x00004B48
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x5724AF0", Offset = "0x57236F0", VA = "0x185724AF0")]
		[MethodImpl(256)]
		public static uint4 hashwide(int4x4 v)
		{
			return default(uint4);
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00006960 File Offset: 0x00004B60
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		[MethodImpl(256)]
		public static int asint(uint x)
		{
			return 0;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x00006978 File Offset: 0x00004B78
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x5707920", Offset = "0x5706520", VA = "0x185707920")]
		[MethodImpl(256)]
		public static int2 asint(uint2 x)
		{
			return default(int2);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x00006990 File Offset: 0x00004B90
		[Token(Token = "0x6000317")]
		[Address(RVA = "0x57077D0", Offset = "0x57063D0", VA = "0x1857077D0")]
		[MethodImpl(256)]
		public static int3 asint(uint3 x)
		{
			return default(int3);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x5707800", Offset = "0x5706400", VA = "0x185707800")]
		[MethodImpl(256)]
		public static int4 asint(uint4 x)
		{
			return default(int4);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x000069C0 File Offset: 0x00004BC0
		[Token(Token = "0x6000319")]
		[Address(RVA = "0x4CA5DA0", Offset = "0x4CA49A0", VA = "0x184CA5DA0")]
		[MethodImpl(256)]
		public static int asint(float x)
		{
			return 0;
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000069D8 File Offset: 0x00004BD8
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x57078E0", Offset = "0x57064E0", VA = "0x1857078E0")]
		[MethodImpl(256)]
		public static int2 asint(float2 x)
		{
			return default(int2);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x000069F0 File Offset: 0x00004BF0
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x5707890", Offset = "0x5706490", VA = "0x185707890")]
		[MethodImpl(256)]
		public static int3 asint(float3 x)
		{
			return default(int3);
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x5707830", Offset = "0x5706430", VA = "0x185707830")]
		[MethodImpl(256)]
		public static int4 asint(float4 x)
		{
			return default(int4);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00006A20 File Offset: 0x00004C20
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x263CB20", Offset = "0x263B720", VA = "0x18263CB20")]
		[MethodImpl(256)]
		public static uint asuint(int x)
		{
			return 0U;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00006A38 File Offset: 0x00004C38
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x5707920", Offset = "0x5706520", VA = "0x185707920")]
		[MethodImpl(256)]
		public static uint2 asuint(int2 x)
		{
			return default(uint2);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00006A50 File Offset: 0x00004C50
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x57077D0", Offset = "0x57063D0", VA = "0x1857077D0")]
		[MethodImpl(256)]
		public static uint3 asuint(int3 x)
		{
			return default(uint3);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00006A68 File Offset: 0x00004C68
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x5707800", Offset = "0x5706400", VA = "0x185707800")]
		[MethodImpl(256)]
		public static uint4 asuint(int4 x)
		{
			return default(uint4);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00006A80 File Offset: 0x00004C80
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x4CA5DA0", Offset = "0x4CA49A0", VA = "0x184CA5DA0")]
		[MethodImpl(256)]
		public static uint asuint(float x)
		{
			return 0U;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00006A98 File Offset: 0x00004C98
		[Token(Token = "0x6000322")]
		[Address(RVA = "0x57078E0", Offset = "0x57064E0", VA = "0x1857078E0")]
		[MethodImpl(256)]
		public static uint2 asuint(float2 x)
		{
			return default(uint2);
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x5707890", Offset = "0x5706490", VA = "0x185707890")]
		[MethodImpl(256)]
		public static uint3 asuint(float3 x)
		{
			return default(uint3);
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00006AC8 File Offset: 0x00004CC8
		[Token(Token = "0x6000324")]
		[Address(RVA = "0x5707830", Offset = "0x5706430", VA = "0x185707830")]
		[MethodImpl(256)]
		public static uint4 asuint(float4 x)
		{
			return default(uint4);
		}

		// Token: 0x06000325 RID: 805 RVA: 0x00006AE0 File Offset: 0x00004CE0
		[Token(Token = "0x6000325")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		[MethodImpl(256)]
		public static long aslong(ulong x)
		{
			return 0L;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00006AF8 File Offset: 0x00004CF8
		[Token(Token = "0x6000326")]
		[Address(RVA = "0x4CA5A70", Offset = "0x4CA4670", VA = "0x184CA5A70")]
		[MethodImpl(256)]
		public static long aslong(double x)
		{
			return 0L;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x00006B10 File Offset: 0x00004D10
		[Token(Token = "0x6000327")]
		[Address(RVA = "0xEB5120", Offset = "0xEB3D20", VA = "0x180EB5120")]
		[MethodImpl(256)]
		public static ulong asulong(long x)
		{
			return 0UL;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x00006B28 File Offset: 0x00004D28
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x4CA5A70", Offset = "0x4CA4670", VA = "0x184CA5A70")]
		[MethodImpl(256)]
		public static ulong asulong(double x)
		{
			return 0UL;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x00006B40 File Offset: 0x00004D40
		[Token(Token = "0x6000329")]
		[Address(RVA = "0x4CA5D80", Offset = "0x4CA4980", VA = "0x184CA5D80")]
		[MethodImpl(256)]
		public static float asfloat(int x)
		{
			return 0f;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x00006B58 File Offset: 0x00004D58
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x5707060", Offset = "0x5705C60", VA = "0x185707060")]
		[MethodImpl(256)]
		public static float2 asfloat(int2 x)
		{
			return default(float2);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00006B70 File Offset: 0x00004D70
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x5706FB0", Offset = "0x5705BB0", VA = "0x185706FB0")]
		[MethodImpl(256)]
		public static float3 asfloat(int3 x)
		{
			return default(float3);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x00006B88 File Offset: 0x00004D88
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x5707000", Offset = "0x5705C00", VA = "0x185707000")]
		[MethodImpl(256)]
		public static float4 asfloat(int4 x)
		{
			return default(float4);
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00006BA0 File Offset: 0x00004DA0
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x4CA5D80", Offset = "0x4CA4980", VA = "0x184CA5D80")]
		[MethodImpl(256)]
		public static float asfloat(uint x)
		{
			return 0f;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00006BB8 File Offset: 0x00004DB8
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x5707060", Offset = "0x5705C60", VA = "0x185707060")]
		[MethodImpl(256)]
		public static float2 asfloat(uint2 x)
		{
			return default(float2);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00006BD0 File Offset: 0x00004DD0
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x5706FB0", Offset = "0x5705BB0", VA = "0x185706FB0")]
		[MethodImpl(256)]
		public static float3 asfloat(uint3 x)
		{
			return default(float3);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00006BE8 File Offset: 0x00004DE8
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x5707000", Offset = "0x5705C00", VA = "0x185707000")]
		[MethodImpl(256)]
		public static float4 asfloat(uint4 x)
		{
			return default(float4);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00006C00 File Offset: 0x00004E00
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x57088B0", Offset = "0x57074B0", VA = "0x1857088B0")]
		public static int bitmask(bool4 value)
		{
			return 0;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00006C18 File Offset: 0x00004E18
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x4CA5D90", Offset = "0x4CA4990", VA = "0x184CA5D90")]
		[MethodImpl(256)]
		public static double asdouble(long x)
		{
			return 0.0;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00006C30 File Offset: 0x00004E30
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x4CA5D90", Offset = "0x4CA4990", VA = "0x184CA5D90")]
		[MethodImpl(256)]
		public static double asdouble(ulong x)
		{
			return 0.0;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00006C48 File Offset: 0x00004E48
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x572EA80", Offset = "0x572D680", VA = "0x18572EA80")]
		[MethodImpl(256)]
		public static bool isfinite(float x)
		{
			return default(bool);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x00006C60 File Offset: 0x00004E60
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x572E990", Offset = "0x572D590", VA = "0x18572E990")]
		[MethodImpl(256)]
		public static bool2 isfinite(float2 x)
		{
			return default(bool2);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00006C78 File Offset: 0x00004E78
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x572E750", Offset = "0x572D350", VA = "0x18572E750")]
		[MethodImpl(256)]
		public static bool3 isfinite(float3 x)
		{
			return default(bool3);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00006C90 File Offset: 0x00004E90
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x572E800", Offset = "0x572D400", VA = "0x18572E800")]
		[MethodImpl(256)]
		public static bool4 isfinite(float4 x)
		{
			return default(bool4);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00006CA8 File Offset: 0x00004EA8
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x572E720", Offset = "0x572D320", VA = "0x18572E720")]
		[MethodImpl(256)]
		public static bool isfinite(double x)
		{
			return default(bool);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00006CC0 File Offset: 0x00004EC0
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x572EA20", Offset = "0x572D620", VA = "0x18572EA20")]
		[MethodImpl(256)]
		public static bool2 isfinite(double2 x)
		{
			return default(bool2);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00006CD8 File Offset: 0x00004ED8
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x572EAA0", Offset = "0x572D6A0", VA = "0x18572EAA0")]
		[MethodImpl(256)]
		public static bool3 isfinite(double3 x)
		{
			return default(bool3);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x572E8E0", Offset = "0x572D4E0", VA = "0x18572E8E0")]
		[MethodImpl(256)]
		public static bool4 isfinite(double4 x)
		{
			return default(bool4);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00006D08 File Offset: 0x00004F08
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x572EB30", Offset = "0x572D730", VA = "0x18572EB30")]
		[MethodImpl(256)]
		public static bool isinf(float x)
		{
			return default(bool);
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00006D20 File Offset: 0x00004F20
		[Token(Token = "0x600033D")]
		[Address(RVA = "0x572ED20", Offset = "0x572D920", VA = "0x18572ED20")]
		[MethodImpl(256)]
		public static bool2 isinf(float2 x)
		{
			return default(bool2);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00006D38 File Offset: 0x00004F38
		[Token(Token = "0x600033E")]
		[Address(RVA = "0x572EF80", Offset = "0x572DB80", VA = "0x18572EF80")]
		[MethodImpl(256)]
		public static bool3 isinf(float3 x)
		{
			return default(bool3);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00006D50 File Offset: 0x00004F50
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x572EE60", Offset = "0x572DA60", VA = "0x18572EE60")]
		[MethodImpl(256)]
		public static bool4 isinf(float4 x)
		{
			return default(bool4);
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00006D68 File Offset: 0x00004F68
		[Token(Token = "0x6000340")]
		[Address(RVA = "0x572EC10", Offset = "0x572D810", VA = "0x18572EC10")]
		[MethodImpl(256)]
		public static bool isinf(double x)
		{
			return default(bool);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00006D80 File Offset: 0x00004F80
		[Token(Token = "0x6000341")]
		[Address(RVA = "0x572EDE0", Offset = "0x572D9E0", VA = "0x18572EDE0")]
		[MethodImpl(256)]
		public static bool2 isinf(double2 x)
		{
			return default(bool2);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x00006D98 File Offset: 0x00004F98
		[Token(Token = "0x6000342")]
		[Address(RVA = "0x572EB60", Offset = "0x572D760", VA = "0x18572EB60")]
		[MethodImpl(256)]
		public static bool3 isinf(double3 x)
		{
			return default(bool3);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[Token(Token = "0x6000343")]
		[Address(RVA = "0x572EC40", Offset = "0x572D840", VA = "0x18572EC40")]
		[MethodImpl(256)]
		public static bool4 isinf(double4 x)
		{
			return default(bool4);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x00006DC8 File Offset: 0x00004FC8
		[Token(Token = "0x6000344")]
		[Address(RVA = "0x572F160", Offset = "0x572DD60", VA = "0x18572F160")]
		[MethodImpl(256)]
		public static bool isnan(float x)
		{
			return default(bool);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[Token(Token = "0x6000345")]
		[Address(RVA = "0x572F0E0", Offset = "0x572DCE0", VA = "0x18572F0E0")]
		[MethodImpl(256)]
		public static bool2 isnan(float2 x)
		{
			return default(bool2);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x572F360", Offset = "0x572DF60", VA = "0x18572F360")]
		[MethodImpl(256)]
		public static bool3 isnan(float3 x)
		{
			return default(bool3);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00006E10 File Offset: 0x00005010
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x572F290", Offset = "0x572DE90", VA = "0x18572F290")]
		[MethodImpl(256)]
		public static bool4 isnan(float4 x)
		{
			return default(bool4);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x00006E28 File Offset: 0x00005028
		[Token(Token = "0x6000348")]
		[Address(RVA = "0x572F210", Offset = "0x572DE10", VA = "0x18572F210")]
		[MethodImpl(256)]
		public static bool isnan(double x)
		{
			return default(bool);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x00006E40 File Offset: 0x00005040
		[Token(Token = "0x6000349")]
		[Address(RVA = "0x572F240", Offset = "0x572DE40", VA = "0x18572F240")]
		[MethodImpl(256)]
		public static bool2 isnan(double2 x)
		{
			return default(bool2);
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00006E58 File Offset: 0x00005058
		[Token(Token = "0x600034A")]
		[Address(RVA = "0x572F060", Offset = "0x572DC60", VA = "0x18572F060")]
		[MethodImpl(256)]
		public static bool3 isnan(double3 x)
		{
			return default(bool3);
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x600034B")]
		[Address(RVA = "0x572F180", Offset = "0x572DD80", VA = "0x18572F180")]
		[MethodImpl(256)]
		public static bool4 isnan(double4 x)
		{
			return default(bool4);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x600034C")]
		[Address(RVA = "0x572F470", Offset = "0x572E070", VA = "0x18572F470")]
		[MethodImpl(256)]
		public static bool ispow2(int x)
		{
			return default(bool);
		}

		// Token: 0x0600034D RID: 845 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x600034D")]
		[Address(RVA = "0x572F480", Offset = "0x572E080", VA = "0x18572F480")]
		[MethodImpl(256)]
		public static bool2 ispow2(int2 x)
		{
			return default(bool2);
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00006EB8 File Offset: 0x000050B8
		[Token(Token = "0x600034E")]
		[Address(RVA = "0x572F410", Offset = "0x572E010", VA = "0x18572F410")]
		[MethodImpl(256)]
		public static bool3 ispow2(int3 x)
		{
			return default(bool3);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x600034F")]
		[Address(RVA = "0x572F5E0", Offset = "0x572E1E0", VA = "0x18572F5E0")]
		[MethodImpl(256)]
		public static bool4 ispow2(int4 x)
		{
			return default(bool4);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x6000350")]
		[Address(RVA = "0x572F530", Offset = "0x572E130", VA = "0x18572F530")]
		[MethodImpl(256)]
		public static bool ispow2(uint x)
		{
			return default(bool);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x572F540", Offset = "0x572E140", VA = "0x18572F540")]
		[MethodImpl(256)]
		public static bool2 ispow2(uint2 x)
		{
			return default(bool2);
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x572F580", Offset = "0x572E180", VA = "0x18572F580")]
		[MethodImpl(256)]
		public static bool3 ispow2(uint3 x)
		{
			return default(bool3);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00006F30 File Offset: 0x00005130
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x572F4C0", Offset = "0x572E0C0", VA = "0x18572F4C0")]
		[MethodImpl(256)]
		public static bool4 ispow2(uint4 x)
		{
			return default(bool4);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00006F48 File Offset: 0x00005148
		[Token(Token = "0x6000354")]
		[Address(RVA = "0x57325A0", Offset = "0x57311A0", VA = "0x1857325A0")]
		[MethodImpl(256)]
		public static int min(int x, int y)
		{
			return 0;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00006F60 File Offset: 0x00005160
		[Token(Token = "0x6000355")]
		[Address(RVA = "0x57329E0", Offset = "0x57315E0", VA = "0x1857329E0")]
		[MethodImpl(256)]
		public static int2 min(int2 x, int2 y)
		{
			return default(int2);
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00006F78 File Offset: 0x00005178
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x5732A30", Offset = "0x5731630", VA = "0x185732A30")]
		[MethodImpl(256)]
		public static int3 min(int3 x, int3 y)
		{
			return default(int3);
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00006F90 File Offset: 0x00005190
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x5732740", Offset = "0x5731340", VA = "0x185732740")]
		[MethodImpl(256)]
		public static int4 min(int4 x, int4 y)
		{
			return default(int4);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00006FA8 File Offset: 0x000051A8
		[Token(Token = "0x6000358")]
		[Address(RVA = "0x5732A20", Offset = "0x5731620", VA = "0x185732A20")]
		[MethodImpl(256)]
		public static uint min(uint x, uint y)
		{
			return 0U;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00006FC0 File Offset: 0x000051C0
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x5732850", Offset = "0x5731450", VA = "0x185732850")]
		[MethodImpl(256)]
		public static uint2 min(uint2 x, uint2 y)
		{
			return default(uint2);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00006FD8 File Offset: 0x000051D8
		[Token(Token = "0x600035A")]
		[Address(RVA = "0x5732880", Offset = "0x5731480", VA = "0x185732880")]
		[MethodImpl(256)]
		public static uint3 min(uint3 x, uint3 y)
		{
			return default(uint3);
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x600035B")]
		[Address(RVA = "0x5732970", Offset = "0x5731570", VA = "0x185732970")]
		[MethodImpl(256)]
		public static uint4 min(uint4 x, uint4 y)
		{
			return default(uint4);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00007008 File Offset: 0x00005208
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x57329D0", Offset = "0x57315D0", VA = "0x1857329D0")]
		[MethodImpl(256)]
		public static long min(long x, long y)
		{
			return 0L;
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00007020 File Offset: 0x00005220
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x5732A10", Offset = "0x5731610", VA = "0x185732A10")]
		[MethodImpl(256)]
		public static ulong min(ulong x, ulong y)
		{
			return 0UL;
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00007038 File Offset: 0x00005238
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x5700CF0", Offset = "0x56FF8F0", VA = "0x185700CF0")]
		[MethodImpl(256)]
		public static float min(float x, float y)
		{
			return 0f;
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00007050 File Offset: 0x00005250
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x5700D80", Offset = "0x56FF980", VA = "0x185700D80")]
		[MethodImpl(256)]
		public static float2 min(float2 x, float2 y)
		{
			return default(float2);
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00007068 File Offset: 0x00005268
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x5732640", Offset = "0x5731240", VA = "0x185732640")]
		[MethodImpl(256)]
		public static float3 min(float3 x, float3 y)
		{
			return default(float3);
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00007080 File Offset: 0x00005280
		[Token(Token = "0x6000361")]
		[Address(RVA = "0x57328C0", Offset = "0x57314C0", VA = "0x1857328C0")]
		[MethodImpl(256)]
		public static float4 min(float4 x, float4 y)
		{
			return default(float4);
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00007098 File Offset: 0x00005298
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x5700C50", Offset = "0x56FF850", VA = "0x185700C50")]
		[MethodImpl(256)]
		public static double min(double x, double y)
		{
			return 0.0;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000070B0 File Offset: 0x000052B0
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x57326D0", Offset = "0x57312D0", VA = "0x1857326D0")]
		[MethodImpl(256)]
		public static double2 min(double2 x, double2 y)
		{
			return default(double2);
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000070C8 File Offset: 0x000052C8
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x57325B0", Offset = "0x57311B0", VA = "0x1857325B0")]
		[MethodImpl(256)]
		public static double3 min(double3 x, double3 y)
		{
			return default(double3);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x000070E0 File Offset: 0x000052E0
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x57327A0", Offset = "0x57313A0", VA = "0x1857327A0")]
		[MethodImpl(256)]
		public static double4 min(double4 x, double4 y)
		{
			return default(double4);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x5732230", Offset = "0x5730E30", VA = "0x185732230")]
		[MethodImpl(256)]
		public static int max(int x, int y)
		{
			return 0;
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x5732160", Offset = "0x5730D60", VA = "0x185732160")]
		[MethodImpl(256)]
		public static int2 max(int2 x, int2 y)
		{
			return default(int2);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00007128 File Offset: 0x00005328
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x5732120", Offset = "0x5730D20", VA = "0x185732120")]
		[MethodImpl(256)]
		public static int3 max(int3 x, int3 y)
		{
			return default(int3);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00007140 File Offset: 0x00005340
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x5732330", Offset = "0x5730F30", VA = "0x185732330")]
		[MethodImpl(256)]
		public static int4 max(int4 x, int4 y)
		{
			return default(int4);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x57324B0", Offset = "0x57310B0", VA = "0x1857324B0")]
		[MethodImpl(256)]
		public static uint max(uint x, uint y)
		{
			return 0U;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00007170 File Offset: 0x00005370
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x57324C0", Offset = "0x57310C0", VA = "0x1857324C0")]
		[MethodImpl(256)]
		public static uint2 max(uint2 x, uint2 y)
		{
			return default(uint2);
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00007188 File Offset: 0x00005388
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x5732500", Offset = "0x5731100", VA = "0x185732500")]
		[MethodImpl(256)]
		public static uint3 max(uint3 x, uint3 y)
		{
			return default(uint3);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000071A0 File Offset: 0x000053A0
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x57322D0", Offset = "0x5730ED0", VA = "0x1857322D0")]
		[MethodImpl(256)]
		public static uint4 max(uint4 x, uint4 y)
		{
			return default(uint4);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000071B8 File Offset: 0x000053B8
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x57324F0", Offset = "0x57310F0", VA = "0x1857324F0")]
		[MethodImpl(256)]
		public static long max(long x, long y)
		{
			return 0L;
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000071D0 File Offset: 0x000053D0
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x5732220", Offset = "0x5730E20", VA = "0x185732220")]
		[MethodImpl(256)]
		public static ulong max(ulong x, ulong y)
		{
			return 0UL;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x000071E8 File Offset: 0x000053E8
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x5700B20", Offset = "0x56FF720", VA = "0x185700B20")]
		[MethodImpl(256)]
		public static float max(float x, float y)
		{
			return 0f;
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00007200 File Offset: 0x00005400
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x5732540", Offset = "0x5731140", VA = "0x185732540")]
		[MethodImpl(256)]
		public static float2 max(float2 x, float2 y)
		{
			return default(float2);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00007218 File Offset: 0x00005418
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x5732190", Offset = "0x5730D90", VA = "0x185732190")]
		[MethodImpl(256)]
		public static float3 max(float3 x, float3 y)
		{
			return default(float3);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00007230 File Offset: 0x00005430
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x5732070", Offset = "0x5730C70", VA = "0x185732070")]
		[MethodImpl(256)]
		public static float4 max(float4 x, float4 y)
		{
			return default(float4);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00007248 File Offset: 0x00005448
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x5700BB0", Offset = "0x56FF7B0", VA = "0x185700BB0")]
		[MethodImpl(256)]
		public static double max(double x, double y)
		{
			return 0.0;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00007260 File Offset: 0x00005460
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x5732390", Offset = "0x5730F90", VA = "0x185732390")]
		[MethodImpl(256)]
		public static double2 max(double2 x, double2 y)
		{
			return default(double2);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00007278 File Offset: 0x00005478
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x5732240", Offset = "0x5730E40", VA = "0x185732240")]
		[MethodImpl(256)]
		public static double3 max(double3 x, double3 y)
		{
			return default(double3);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00007290 File Offset: 0x00005490
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x5732400", Offset = "0x5731000", VA = "0x185732400")]
		[MethodImpl(256)]
		public static double4 max(double4 x, double4 y)
		{
			return default(double4);
		}

		// Token: 0x06000378 RID: 888 RVA: 0x000072A8 File Offset: 0x000054A8
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x5700A50", Offset = "0x56FF650", VA = "0x185700A50")]
		[MethodImpl(256)]
		public static float lerp(float x, float y, float s)
		{
			return 0f;
		}

		// Token: 0x06000379 RID: 889 RVA: 0x000072C0 File Offset: 0x000054C0
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x572FFC0", Offset = "0x572EBC0", VA = "0x18572FFC0")]
		[MethodImpl(256)]
		public static float2 lerp(float2 x, float2 y, float s)
		{
			return default(float2);
		}

		// Token: 0x0600037A RID: 890 RVA: 0x000072D8 File Offset: 0x000054D8
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x572FE70", Offset = "0x572EA70", VA = "0x18572FE70")]
		[MethodImpl(256)]
		public static float3 lerp(float3 x, float3 y, float s)
		{
			return default(float3);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000072F0 File Offset: 0x000054F0
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x5700A60", Offset = "0x56FF660", VA = "0x185700A60")]
		[MethodImpl(256)]
		public static float4 lerp(float4 x, float4 y, float s)
		{
			return default(float4);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00007308 File Offset: 0x00005508
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x572FC40", Offset = "0x572E840", VA = "0x18572FC40")]
		[MethodImpl(256)]
		public static float2 lerp(float2 x, float2 y, float2 s)
		{
			return default(float2);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00007320 File Offset: 0x00005520
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x572FA80", Offset = "0x572E680", VA = "0x18572FA80")]
		[MethodImpl(256)]
		public static float3 lerp(float3 x, float3 y, float3 s)
		{
			return default(float3);
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00007338 File Offset: 0x00005538
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x572FB70", Offset = "0x572E770", VA = "0x18572FB70")]
		[MethodImpl(256)]
		public static float4 lerp(float4 x, float4 y, float4 s)
		{
			return default(float4);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00007350 File Offset: 0x00005550
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x5730010", Offset = "0x572EC10", VA = "0x185730010")]
		[MethodImpl(256)]
		public static double lerp(double x, double y, double s)
		{
			return 0.0;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00007368 File Offset: 0x00005568
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x572FB30", Offset = "0x572E730", VA = "0x18572FB30")]
		[MethodImpl(256)]
		public static double2 lerp(double2 x, double2 y, double s)
		{
			return default(double2);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00007380 File Offset: 0x00005580
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x572FF50", Offset = "0x572EB50", VA = "0x18572FF50")]
		[MethodImpl(256)]
		public static double3 lerp(double3 x, double3 y, double s)
		{
			return default(double3);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00007398 File Offset: 0x00005598
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x572FDD0", Offset = "0x572E9D0", VA = "0x18572FDD0")]
		[MethodImpl(256)]
		public static double4 lerp(double4 x, double4 y, double s)
		{
			return default(double4);
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000073B0 File Offset: 0x000055B0
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x572FF00", Offset = "0x572EB00", VA = "0x18572FF00")]
		[MethodImpl(256)]
		public static double2 lerp(double2 x, double2 y, double2 s)
		{
			return default(double2);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000073C8 File Offset: 0x000055C8
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x572FD50", Offset = "0x572E950", VA = "0x18572FD50")]
		[MethodImpl(256)]
		public static double3 lerp(double3 x, double3 y, double3 s)
		{
			return default(double3);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x000073E0 File Offset: 0x000055E0
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x572FCA0", Offset = "0x572E8A0", VA = "0x18572FCA0")]
		[MethodImpl(256)]
		public static double4 lerp(double4 x, double4 y, double4 s)
		{
			return default(double4);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000073F8 File Offset: 0x000055F8
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x4EA2B90", Offset = "0x4EA1790", VA = "0x184EA2B90")]
		[MethodImpl(256)]
		public static float unlerp(float a, float b, float x)
		{
			return 0f;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00007410 File Offset: 0x00005610
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x5755B10", Offset = "0x5754710", VA = "0x185755B10")]
		[MethodImpl(256)]
		public static float2 unlerp(float2 a, float2 b, float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00007428 File Offset: 0x00005628
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x5755B70", Offset = "0x5754770", VA = "0x185755B70")]
		[MethodImpl(256)]
		public static float3 unlerp(float3 a, float3 b, float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00007440 File Offset: 0x00005640
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x5755A10", Offset = "0x5754610", VA = "0x185755A10")]
		[MethodImpl(256)]
		public static float4 unlerp(float4 a, float4 b, float4 x)
		{
			return default(float4);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00007458 File Offset: 0x00005658
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x5755CE0", Offset = "0x57548E0", VA = "0x185755CE0")]
		[MethodImpl(256)]
		public static double unlerp(double a, double b, double x)
		{
			return 0.0;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00007470 File Offset: 0x00005670
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x57559C0", Offset = "0x57545C0", VA = "0x1857559C0")]
		[MethodImpl(256)]
		public static double2 unlerp(double2 a, double2 b, double2 x)
		{
			return default(double2);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00007488 File Offset: 0x00005688
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x5755930", Offset = "0x5754530", VA = "0x185755930")]
		[MethodImpl(256)]
		public static double3 unlerp(double3 a, double3 b, double3 x)
		{
			return default(double3);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000074A0 File Offset: 0x000056A0
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x5755C20", Offset = "0x5754820", VA = "0x185755C20")]
		[MethodImpl(256)]
		public static double4 unlerp(double4 a, double4 b, double4 x)
		{
			return default(double4);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x000074B8 File Offset: 0x000056B8
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x5747D20", Offset = "0x5746920", VA = "0x185747D20")]
		[MethodImpl(256)]
		public static float remap(float a, float b, float c, float d, float x)
		{
			return 0f;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000074D0 File Offset: 0x000056D0
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x5747C90", Offset = "0x5746890", VA = "0x185747C90")]
		[MethodImpl(256)]
		public static float2 remap(float2 a, float2 b, float2 c, float2 d, float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000074E8 File Offset: 0x000056E8
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x5747FF0", Offset = "0x5746BF0", VA = "0x185747FF0")]
		[MethodImpl(256)]
		public static float3 remap(float3 a, float3 b, float3 c, float3 d, float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00007500 File Offset: 0x00005700
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x5747AE0", Offset = "0x57466E0", VA = "0x185747AE0")]
		[MethodImpl(256)]
		public static float4 remap(float4 a, float4 b, float4 c, float4 d, float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00007518 File Offset: 0x00005718
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x5747C60", Offset = "0x5746860", VA = "0x185747C60")]
		[MethodImpl(256)]
		public static double remap(double a, double b, double c, double d, double x)
		{
			return 0.0;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00007530 File Offset: 0x00005730
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x5747E30", Offset = "0x5746A30", VA = "0x185747E30")]
		[MethodImpl(256)]
		public static double2 remap(double2 a, double2 b, double2 c, double2 d, double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00007548 File Offset: 0x00005748
		[Token(Token = "0x6000394")]
		[Address(RVA = "0x5747D50", Offset = "0x5746950", VA = "0x185747D50")]
		[MethodImpl(256)]
		public static double3 remap(double3 a, double3 b, double3 c, double3 d, double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00007560 File Offset: 0x00005760
		[Token(Token = "0x6000395")]
		[Address(RVA = "0x5747EB0", Offset = "0x5746AB0", VA = "0x185747EB0")]
		[MethodImpl(256)]
		public static double4 remap(double4 a, double4 b, double4 c, double4 d, double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00007578 File Offset: 0x00005778
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x5731FE0", Offset = "0x5730BE0", VA = "0x185731FE0")]
		[MethodImpl(256)]
		public static int mad(int a, int b, int c)
		{
			return 0;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00007590 File Offset: 0x00005790
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x5731C80", Offset = "0x5730880", VA = "0x185731C80")]
		[MethodImpl(256)]
		public static int2 mad(int2 a, int2 b, int2 c)
		{
			return default(int2);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x000075A8 File Offset: 0x000057A8
		[Token(Token = "0x6000398")]
		[Address(RVA = "0x5731CD0", Offset = "0x57308D0", VA = "0x185731CD0")]
		[MethodImpl(256)]
		public static int3 mad(int3 a, int3 b, int3 c)
		{
			return default(int3);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x000075C0 File Offset: 0x000057C0
		[Token(Token = "0x6000399")]
		[Address(RVA = "0x5731B90", Offset = "0x5730790", VA = "0x185731B90")]
		[MethodImpl(256)]
		public static int4 mad(int4 a, int4 b, int4 c)
		{
			return default(int4);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000075D8 File Offset: 0x000057D8
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x5731FE0", Offset = "0x5730BE0", VA = "0x185731FE0")]
		[MethodImpl(256)]
		public static uint mad(uint a, uint b, uint c)
		{
			return 0U;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000075F0 File Offset: 0x000057F0
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x5731C80", Offset = "0x5730880", VA = "0x185731C80")]
		[MethodImpl(256)]
		public static uint2 mad(uint2 a, uint2 b, uint2 c)
		{
			return default(uint2);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00007608 File Offset: 0x00005808
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x5731CD0", Offset = "0x57308D0", VA = "0x185731CD0")]
		[MethodImpl(256)]
		public static uint3 mad(uint3 a, uint3 b, uint3 c)
		{
			return default(uint3);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00007620 File Offset: 0x00005820
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x5731B90", Offset = "0x5730790", VA = "0x185731B90")]
		[MethodImpl(256)]
		public static uint4 mad(uint4 a, uint4 b, uint4 c)
		{
			return default(uint4);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00007638 File Offset: 0x00005838
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x5731E30", Offset = "0x5730A30", VA = "0x185731E30")]
		[MethodImpl(256)]
		public static long mad(long a, long b, long c)
		{
			return 0L;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00007650 File Offset: 0x00005850
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x5731E30", Offset = "0x5730A30", VA = "0x185731E30")]
		[MethodImpl(256)]
		public static ulong mad(ulong a, ulong b, ulong c)
		{
			return 0UL;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00007668 File Offset: 0x00005868
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x5731E40", Offset = "0x5730A40", VA = "0x185731E40")]
		[MethodImpl(256)]
		public static float mad(float a, float b, float c)
		{
			return 0f;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00007680 File Offset: 0x00005880
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x5731DE0", Offset = "0x57309E0", VA = "0x185731DE0")]
		[MethodImpl(256)]
		public static float2 mad(float2 a, float2 b, float2 c)
		{
			return default(float2);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00007698 File Offset: 0x00005898
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x5731FF0", Offset = "0x5730BF0", VA = "0x185731FF0")]
		[MethodImpl(256)]
		public static float3 mad(float3 a, float3 b, float3 c)
		{
			return default(float3);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000076B0 File Offset: 0x000058B0
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x5731EA0", Offset = "0x5730AA0", VA = "0x185731EA0")]
		[MethodImpl(256)]
		public static float4 mad(float4 a, float4 b, float4 c)
		{
			return default(float4);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x000076C8 File Offset: 0x000058C8
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x5731E50", Offset = "0x5730A50", VA = "0x185731E50")]
		[MethodImpl(256)]
		public static double mad(double a, double b, double c)
		{
			return 0.0;
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000076E0 File Offset: 0x000058E0
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x5731E60", Offset = "0x5730A60", VA = "0x185731E60")]
		[MethodImpl(256)]
		public static double2 mad(double2 a, double2 b, double2 c)
		{
			return default(double2);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000076F8 File Offset: 0x000058F8
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x5731D80", Offset = "0x5730980", VA = "0x185731D80")]
		[MethodImpl(256)]
		public static double3 mad(double3 a, double3 b, double3 c)
		{
			return default(double3);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00007710 File Offset: 0x00005910
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x5731F50", Offset = "0x5730B50", VA = "0x185731F50")]
		[MethodImpl(256)]
		public static double4 mad(double4 a, double4 b, double4 c)
		{
			return default(double4);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00007728 File Offset: 0x00005928
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x570B040", Offset = "0x5709C40", VA = "0x18570B040")]
		[MethodImpl(256)]
		public static int clamp(int x, int a, int b)
		{
			return 0;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00007740 File Offset: 0x00005940
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x570B1C0", Offset = "0x5709DC0", VA = "0x18570B1C0")]
		[MethodImpl(256)]
		public static int2 clamp(int2 x, int2 a, int2 b)
		{
			return default(int2);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00007758 File Offset: 0x00005958
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x570AE10", Offset = "0x5709A10", VA = "0x18570AE10")]
		[MethodImpl(256)]
		public static int3 clamp(int3 x, int3 a, int3 b)
		{
			return default(int3);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00007770 File Offset: 0x00005970
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x570AF30", Offset = "0x5709B30", VA = "0x18570AF30")]
		[MethodImpl(256)]
		public static int4 clamp(int4 x, int4 a, int4 b)
		{
			return default(int4);
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00007788 File Offset: 0x00005988
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x570AF10", Offset = "0x5709B10", VA = "0x18570AF10")]
		[MethodImpl(256)]
		public static uint clamp(uint x, uint a, uint b)
		{
			return 0U;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x000077A0 File Offset: 0x000059A0
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x570AC80", Offset = "0x5709880", VA = "0x18570AC80")]
		[MethodImpl(256)]
		public static uint2 clamp(uint2 x, uint2 a, uint2 b)
		{
			return default(uint2);
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000077B8 File Offset: 0x000059B8
		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x570B0A0", Offset = "0x5709CA0", VA = "0x18570B0A0")]
		[MethodImpl(256)]
		public static uint3 clamp(uint3 x, uint3 a, uint3 b)
		{
			return default(uint3);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x000077D0 File Offset: 0x000059D0
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x570A8C0", Offset = "0x57094C0", VA = "0x18570A8C0")]
		[MethodImpl(256)]
		public static uint4 clamp(uint4 x, uint4 a, uint4 b)
		{
			return default(uint4);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000077E8 File Offset: 0x000059E8
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x570ACE0", Offset = "0x57098E0", VA = "0x18570ACE0")]
		[MethodImpl(256)]
		public static long clamp(long x, long a, long b)
		{
			return 0L;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00007800 File Offset: 0x00005A00
		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x570B1A0", Offset = "0x5709DA0", VA = "0x18570B1A0")]
		[MethodImpl(256)]
		public static ulong clamp(ulong x, ulong a, ulong b)
		{
			return 0UL;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00007818 File Offset: 0x00005A18
		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x570B060", Offset = "0x5709C60", VA = "0x18570B060")]
		[MethodImpl(256)]
		public static float clamp(float x, float a, float b)
		{
			return 0f;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00007830 File Offset: 0x00005A30
		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x5700050", Offset = "0x56FEC50", VA = "0x185700050")]
		[MethodImpl(256)]
		public static float2 clamp(float2 x, float2 a, float2 b)
		{
			return default(float2);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00007848 File Offset: 0x00005A48
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x570AD00", Offset = "0x5709900", VA = "0x18570AD00")]
		[MethodImpl(256)]
		public static float3 clamp(float3 x, float3 a, float3 b)
		{
			return default(float3);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00007860 File Offset: 0x00005A60
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x570AA10", Offset = "0x5709610", VA = "0x18570AA10")]
		[MethodImpl(256)]
		public static float4 clamp(float4 x, float4 a, float4 b)
		{
			return default(float4);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00007878 File Offset: 0x00005A78
		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x570A9D0", Offset = "0x57095D0", VA = "0x18570A9D0")]
		[MethodImpl(256)]
		public static double clamp(double x, double a, double b)
		{
			return 0.0;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00007890 File Offset: 0x00005A90
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x570B220", Offset = "0x5709E20", VA = "0x18570B220")]
		[MethodImpl(256)]
		public static double2 clamp(double2 x, double2 a, double2 b)
		{
			return default(double2);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000078A8 File Offset: 0x00005AA8
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x570AB70", Offset = "0x5709770", VA = "0x18570AB70")]
		[MethodImpl(256)]
		public static double3 clamp(double3 x, double3 a, double3 b)
		{
			return default(double3);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000078C0 File Offset: 0x00005AC0
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x570B2D0", Offset = "0x5709ED0", VA = "0x18570B2D0")]
		[MethodImpl(256)]
		public static double4 clamp(double4 x, double4 a, double4 b)
		{
			return default(double4);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000078D8 File Offset: 0x00005AD8
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x574A180", Offset = "0x5748D80", VA = "0x18574A180")]
		[MethodImpl(256)]
		public static float saturate(float x)
		{
			return 0f;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000078F0 File Offset: 0x00005AF0
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x574A080", Offset = "0x5748C80", VA = "0x18574A080")]
		[MethodImpl(256)]
		public static float2 saturate(float2 x)
		{
			return default(float2);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00007908 File Offset: 0x00005B08
		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x5749D30", Offset = "0x5748930", VA = "0x185749D30")]
		[MethodImpl(256)]
		public static float3 saturate(float3 x)
		{
			return default(float3);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00007920 File Offset: 0x00005B20
		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x5749F50", Offset = "0x5748B50", VA = "0x185749F50")]
		[MethodImpl(256)]
		public static float4 saturate(float4 x)
		{
			return default(float4);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00007938 File Offset: 0x00005B38
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x5749F20", Offset = "0x5748B20", VA = "0x185749F20")]
		[MethodImpl(256)]
		public static double saturate(double x)
		{
			return 0.0;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00007950 File Offset: 0x00005B50
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x574A1B0", Offset = "0x5748DB0", VA = "0x18574A1B0")]
		[MethodImpl(256)]
		public static double2 saturate(double2 x)
		{
			return default(double2);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00007968 File Offset: 0x00005B68
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x574A0B0", Offset = "0x5748CB0", VA = "0x18574A0B0")]
		[MethodImpl(256)]
		public static double3 saturate(double3 x)
		{
			return default(double3);
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00007980 File Offset: 0x00005B80
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x5749E10", Offset = "0x5748A10", VA = "0x185749E10")]
		[MethodImpl(256)]
		public static double4 saturate(double4 x)
		{
			return default(double4);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00007998 File Offset: 0x00005B98
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x5706440", Offset = "0x5705040", VA = "0x185706440")]
		[MethodImpl(256)]
		public static int abs(int x)
		{
			return 0;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000079B0 File Offset: 0x00005BB0
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x57060E0", Offset = "0x5704CE0", VA = "0x1857060E0")]
		[MethodImpl(256)]
		public static int2 abs(int2 x)
		{
			return default(int2);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000079C8 File Offset: 0x00005BC8
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x5706200", Offset = "0x5704E00", VA = "0x185706200")]
		[MethodImpl(256)]
		public static int3 abs(int3 x)
		{
			return default(int3);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000079E0 File Offset: 0x00005BE0
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x5706130", Offset = "0x5704D30", VA = "0x185706130")]
		[MethodImpl(256)]
		public static int4 abs(int4 x)
		{
			return default(int4);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x000079F8 File Offset: 0x00005BF8
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x5706010", Offset = "0x5704C10", VA = "0x185706010")]
		[MethodImpl(256)]
		public static long abs(long x)
		{
			return 0L;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00007A10 File Offset: 0x00005C10
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x5706020", Offset = "0x5704C20", VA = "0x185706020")]
		[MethodImpl(256)]
		public static float abs(float x)
		{
			return 0f;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00007A28 File Offset: 0x00005C28
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x57063C0", Offset = "0x5704FC0", VA = "0x1857063C0")]
		[MethodImpl(256)]
		public static float2 abs(float2 x)
		{
			return default(float2);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00007A40 File Offset: 0x00005C40
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x57062F0", Offset = "0x5704EF0", VA = "0x1857062F0")]
		[MethodImpl(256)]
		public static float3 abs(float3 x)
		{
			return default(float3);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00007A58 File Offset: 0x00005C58
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x56FFF60", Offset = "0x56FEB60", VA = "0x1856FFF60")]
		[MethodImpl(256)]
		public static float4 abs(float4 x)
		{
			return default(float4);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00007A70 File Offset: 0x00005C70
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x57063A0", Offset = "0x5704FA0", VA = "0x1857063A0")]
		[MethodImpl(256)]
		public static double abs(double x)
		{
			return 0.0;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00007A88 File Offset: 0x00005C88
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x57062A0", Offset = "0x5704EA0", VA = "0x1857062A0")]
		[MethodImpl(256)]
		public static double2 abs(double2 x)
		{
			return default(double2);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00007AA0 File Offset: 0x00005CA0
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x5705F90", Offset = "0x5704B90", VA = "0x185705F90")]
		[MethodImpl(256)]
		public static double3 abs(double3 x)
		{
			return default(double3);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x5706040", Offset = "0x5704C40", VA = "0x185706040")]
		[MethodImpl(256)]
		public static double4 abs(double4 x)
		{
			return default(double4);
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00007AD0 File Offset: 0x00005CD0
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x570DD40", Offset = "0x570C940", VA = "0x18570DD40")]
		[MethodImpl(256)]
		public static int dot(int x, int y)
		{
			return 0;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00007AE8 File Offset: 0x00005CE8
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1DECB30", Offset = "0x1DEB730", VA = "0x181DECB30")]
		[MethodImpl(256)]
		public static int dot(int2 x, int2 y)
		{
			return 0;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00007B00 File Offset: 0x00005D00
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x570DDC0", Offset = "0x570C9C0", VA = "0x18570DDC0")]
		[MethodImpl(256)]
		public static int dot(int3 x, int3 y)
		{
			return 0;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00007B18 File Offset: 0x00005D18
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x570DD90", Offset = "0x570C990", VA = "0x18570DD90")]
		[MethodImpl(256)]
		public static int dot(int4 x, int4 y)
		{
			return 0;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00007B30 File Offset: 0x00005D30
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x570DD40", Offset = "0x570C940", VA = "0x18570DD40")]
		[MethodImpl(256)]
		public static uint dot(uint x, uint y)
		{
			return 0U;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00007B48 File Offset: 0x00005D48
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1DECB30", Offset = "0x1DEB730", VA = "0x181DECB30")]
		[MethodImpl(256)]
		public static uint dot(uint2 x, uint2 y)
		{
			return 0U;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00007B60 File Offset: 0x00005D60
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x570DDC0", Offset = "0x570C9C0", VA = "0x18570DDC0")]
		[MethodImpl(256)]
		public static uint dot(uint3 x, uint3 y)
		{
			return 0U;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00007B78 File Offset: 0x00005D78
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x570DD90", Offset = "0x570C990", VA = "0x18570DD90")]
		[MethodImpl(256)]
		public static uint dot(uint4 x, uint4 y)
		{
			return 0U;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00007B90 File Offset: 0x00005D90
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x570DDF0", Offset = "0x570C9F0", VA = "0x18570DDF0")]
		[MethodImpl(256)]
		public static float dot(float x, float y)
		{
			return 0f;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00007BA8 File Offset: 0x00005DA8
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x570DED0", Offset = "0x570CAD0", VA = "0x18570DED0")]
		[MethodImpl(256)]
		public static float dot(float2 x, float2 y)
		{
			return 0f;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00007BC0 File Offset: 0x00005DC0
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x570DEA0", Offset = "0x570CAA0", VA = "0x18570DEA0")]
		[MethodImpl(256)]
		public static float dot(float3 x, float3 y)
		{
			return 0f;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00007BD8 File Offset: 0x00005DD8
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x57005D0", Offset = "0x56FF1D0", VA = "0x1857005D0")]
		[MethodImpl(256)]
		public static float dot(float4 x, float4 y)
		{
			return 0f;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00007BF0 File Offset: 0x00005DF0
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x570DDE0", Offset = "0x570C9E0", VA = "0x18570DDE0")]
		[MethodImpl(256)]
		public static double dot(double x, double y)
		{
			return 0.0;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00007C08 File Offset: 0x00005E08
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x570DE80", Offset = "0x570CA80", VA = "0x18570DE80")]
		[MethodImpl(256)]
		public static double dot(double2 x, double2 y)
		{
			return 0.0;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00007C20 File Offset: 0x00005E20
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x570DE00", Offset = "0x570CA00", VA = "0x18570DE00")]
		[MethodImpl(256)]
		public static double dot(double3 x, double3 y)
		{
			return 0.0;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00007C38 File Offset: 0x00005E38
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x570DD50", Offset = "0x570C950", VA = "0x18570DD50")]
		[MethodImpl(256)]
		public static double dot(double4 x, double4 y)
		{
			return 0.0;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00007C50 File Offset: 0x00005E50
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x5750810", Offset = "0x574F410", VA = "0x185750810")]
		[MethodImpl(256)]
		public static float tan(float x)
		{
			return 0f;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00007C68 File Offset: 0x00005E68
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x5750490", Offset = "0x574F090", VA = "0x185750490")]
		[MethodImpl(256)]
		public static float2 tan(float2 x)
		{
			return default(float2);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00007C80 File Offset: 0x00005E80
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x57509F0", Offset = "0x574F5F0", VA = "0x1857509F0")]
		[MethodImpl(256)]
		public static float3 tan(float3 x)
		{
			return default(float3);
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00007C98 File Offset: 0x00005E98
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x5750870", Offset = "0x574F470", VA = "0x185750870")]
		[MethodImpl(256)]
		public static float4 tan(float4 x)
		{
			return default(float4);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00007CB0 File Offset: 0x00005EB0
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x57507C0", Offset = "0x574F3C0", VA = "0x1857507C0")]
		[MethodImpl(256)]
		public static double tan(double x)
		{
			return 0.0;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00007CC8 File Offset: 0x00005EC8
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x57503D0", Offset = "0x574EFD0", VA = "0x1857503D0")]
		[MethodImpl(256)]
		public static double2 tan(double2 x)
		{
			return default(double2);
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00007CE0 File Offset: 0x00005EE0
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x57506B0", Offset = "0x574F2B0", VA = "0x1857506B0")]
		[MethodImpl(256)]
		public static double3 tan(double3 x)
		{
			return default(double3);
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00007CF8 File Offset: 0x00005EF8
		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x5750550", Offset = "0x574F150", VA = "0x185750550")]
		[MethodImpl(256)]
		public static double4 tan(double4 x)
		{
			return default(double4);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00007D10 File Offset: 0x00005F10
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x5751130", Offset = "0x574FD30", VA = "0x185751130")]
		[MethodImpl(256)]
		public static float tanh(float x)
		{
			return 0f;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00007D28 File Offset: 0x00005F28
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x5750F50", Offset = "0x574FB50", VA = "0x185750F50")]
		[MethodImpl(256)]
		public static float2 tanh(float2 x)
		{
			return default(float2);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00007D40 File Offset: 0x00005F40
		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x5751010", Offset = "0x574FC10", VA = "0x185751010")]
		[MethodImpl(256)]
		public static float3 tanh(float3 x)
		{
			return default(float3);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00007D58 File Offset: 0x00005F58
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x5750D80", Offset = "0x574F980", VA = "0x185750D80")]
		[MethodImpl(256)]
		public static float4 tanh(float4 x)
		{
			return default(float4);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00007D70 File Offset: 0x00005F70
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x5750F00", Offset = "0x574FB00", VA = "0x185750F00")]
		[MethodImpl(256)]
		public static double tanh(double x)
		{
			return 0.0;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00007D88 File Offset: 0x00005F88
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x5751190", Offset = "0x574FD90", VA = "0x185751190")]
		[MethodImpl(256)]
		public static double2 tanh(double2 x)
		{
			return default(double2);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00007DA0 File Offset: 0x00005FA0
		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x5750B10", Offset = "0x574F710", VA = "0x185750B10")]
		[MethodImpl(256)]
		public static double3 tanh(double3 x)
		{
			return default(double3);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00007DB8 File Offset: 0x00005FB8
		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x5750C20", Offset = "0x574F820", VA = "0x185750C20")]
		[MethodImpl(256)]
		public static double4 tanh(double4 x)
		{
			return default(double4);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00007DD0 File Offset: 0x00005FD0
		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x5708560", Offset = "0x5707160", VA = "0x185708560")]
		[MethodImpl(256)]
		public static float atan(float x)
		{
			return 0f;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x57087E0", Offset = "0x57073E0", VA = "0x1857087E0")]
		[MethodImpl(256)]
		public static float2 atan(float2 x)
		{
			return default(float2);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00007E00 File Offset: 0x00006000
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x57082E0", Offset = "0x5706EE0", VA = "0x1857082E0")]
		[MethodImpl(256)]
		public static float3 atan(float3 x)
		{
			return default(float3);
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00007E18 File Offset: 0x00006018
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x5708160", Offset = "0x5706D60", VA = "0x185708160")]
		[MethodImpl(256)]
		public static float4 atan(float4 x)
		{
			return default(float4);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00007E30 File Offset: 0x00006030
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x5708790", Offset = "0x5707390", VA = "0x185708790")]
		[MethodImpl(256)]
		public static double atan(double x)
		{
			return 0.0;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00007E48 File Offset: 0x00006048
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x57086D0", Offset = "0x57072D0", VA = "0x1857086D0")]
		[MethodImpl(256)]
		public static double2 atan(double2 x)
		{
			return default(double2);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00007E60 File Offset: 0x00006060
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x57085C0", Offset = "0x57071C0", VA = "0x1857085C0")]
		[MethodImpl(256)]
		public static double3 atan(double3 x)
		{
			return default(double3);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00007E78 File Offset: 0x00006078
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x5708400", Offset = "0x5707000", VA = "0x185708400")]
		[MethodImpl(256)]
		public static double4 atan(double4 x)
		{
			return default(double4);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00007E90 File Offset: 0x00006090
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x5707CF0", Offset = "0x57068F0", VA = "0x185707CF0")]
		[MethodImpl(256)]
		public static float atan2(float y, float x)
		{
			return 0f;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00007EA8 File Offset: 0x000060A8
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x5707C20", Offset = "0x5706820", VA = "0x185707C20")]
		[MethodImpl(256)]
		public static float2 atan2(float2 y, float2 x)
		{
			return default(float2);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00007EC0 File Offset: 0x000060C0
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x5707AD0", Offset = "0x57066D0", VA = "0x185707AD0")]
		[MethodImpl(256)]
		public static float3 atan2(float3 y, float3 x)
		{
			return default(float3);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00007ED8 File Offset: 0x000060D8
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x5707E30", Offset = "0x5706A30", VA = "0x185707E30")]
		[MethodImpl(256)]
		public static float4 atan2(float4 y, float4 x)
		{
			return default(float4);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00007EF0 File Offset: 0x000060F0
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x5707A70", Offset = "0x5706670", VA = "0x185707A70")]
		[MethodImpl(256)]
		public static double atan2(double y, double x)
		{
			return 0.0;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00007F08 File Offset: 0x00006108
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x5707D60", Offset = "0x5706960", VA = "0x185707D60")]
		[MethodImpl(256)]
		public static double2 atan2(double2 y, double2 x)
		{
			return default(double2);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00007F20 File Offset: 0x00006120
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x5707940", Offset = "0x5706540", VA = "0x185707940")]
		[MethodImpl(256)]
		public static double3 atan2(double3 y, double3 x)
		{
			return default(double3);
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00007F38 File Offset: 0x00006138
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x5707FE0", Offset = "0x5706BE0", VA = "0x185707FE0")]
		[MethodImpl(256)]
		public static double4 atan2(double4 y, double4 x)
		{
			return default(double4);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00007F50 File Offset: 0x00006150
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x570BAE0", Offset = "0x570A6E0", VA = "0x18570BAE0")]
		[MethodImpl(256)]
		public static float cos(float x)
		{
			return 0f;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00007F68 File Offset: 0x00006168
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x570B910", Offset = "0x570A510", VA = "0x18570B910")]
		[MethodImpl(256)]
		public static float2 cos(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00007F80 File Offset: 0x00006180
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x570BB40", Offset = "0x570A740", VA = "0x18570BB40")]
		[MethodImpl(256)]
		public static float3 cos(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00007F98 File Offset: 0x00006198
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x570BED0", Offset = "0x570AAD0", VA = "0x18570BED0")]
		[MethodImpl(256)]
		public static float4 cos(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00007FB0 File Offset: 0x000061B0
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x570BD20", Offset = "0x570A920", VA = "0x18570BD20")]
		[MethodImpl(256)]
		public static double cos(double x)
		{
			return 0.0;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00007FC8 File Offset: 0x000061C8
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x570BC60", Offset = "0x570A860", VA = "0x18570BC60")]
		[MethodImpl(256)]
		public static double2 cos(double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00007FE0 File Offset: 0x000061E0
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x570B9D0", Offset = "0x570A5D0", VA = "0x18570B9D0")]
		[MethodImpl(256)]
		public static double3 cos(double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00007FF8 File Offset: 0x000061F8
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x570BD70", Offset = "0x570A970", VA = "0x18570BD70")]
		[MethodImpl(256)]
		public static double4 cos(double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00008010 File Offset: 0x00006210
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x570C110", Offset = "0x570AD10", VA = "0x18570C110")]
		[MethodImpl(256)]
		public static float cosh(float x)
		{
			return 0f;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00008028 File Offset: 0x00006228
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x570C050", Offset = "0x570AC50", VA = "0x18570C050")]
		[MethodImpl(256)]
		public static float2 cosh(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00008040 File Offset: 0x00006240
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x570C280", Offset = "0x570AE80", VA = "0x18570C280")]
		[MethodImpl(256)]
		public static float3 cosh(float3 x)
		{
			return default(float3);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00008058 File Offset: 0x00006258
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x570C500", Offset = "0x570B100", VA = "0x18570C500")]
		[MethodImpl(256)]
		public static float4 cosh(float4 x)
		{
			return default(float4);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00008070 File Offset: 0x00006270
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x570C740", Offset = "0x570B340", VA = "0x18570C740")]
		[MethodImpl(256)]
		public static double cosh(double x)
		{
			return 0.0;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00008088 File Offset: 0x00006288
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x570C680", Offset = "0x570B280", VA = "0x18570C680")]
		[MethodImpl(256)]
		public static double2 cosh(double2 x)
		{
			return default(double2);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000080A0 File Offset: 0x000062A0
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x570C170", Offset = "0x570AD70", VA = "0x18570C170")]
		[MethodImpl(256)]
		public static double3 cosh(double3 x)
		{
			return default(double3);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000080B8 File Offset: 0x000062B8
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x570C3A0", Offset = "0x570AFA0", VA = "0x18570C3A0")]
		[MethodImpl(256)]
		public static double4 cosh(double4 x)
		{
			return default(double4);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000080D0 File Offset: 0x000062D0
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x5706A20", Offset = "0x5705620", VA = "0x185706A20")]
		[MethodImpl(256)]
		public static float acos(float x)
		{
			return 0f;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x000080E8 File Offset: 0x000062E8
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x5706450", Offset = "0x5705050", VA = "0x185706450")]
		[MethodImpl(256)]
		public static float2 acos(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00008100 File Offset: 0x00006300
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x5706510", Offset = "0x5705110", VA = "0x185706510")]
		[MethodImpl(256)]
		public static float3 acos(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00008118 File Offset: 0x00006318
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x5706790", Offset = "0x5705390", VA = "0x185706790")]
		[MethodImpl(256)]
		public static float4 acos(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00008130 File Offset: 0x00006330
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x5706910", Offset = "0x5705510", VA = "0x185706910")]
		[MethodImpl(256)]
		public static double acos(double x)
		{
			return 0.0;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00008148 File Offset: 0x00006348
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x5706960", Offset = "0x5705560", VA = "0x185706960")]
		[MethodImpl(256)]
		public static double2 acos(double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00008160 File Offset: 0x00006360
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x5706A80", Offset = "0x5705680", VA = "0x185706A80")]
		[MethodImpl(256)]
		public static double3 acos(double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00008178 File Offset: 0x00006378
		[Token(Token = "0x6000416")]
		[Address(RVA = "0x5706630", Offset = "0x5705230", VA = "0x185706630")]
		[MethodImpl(256)]
		public static double4 acos(double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00008190 File Offset: 0x00006390
		[Token(Token = "0x6000417")]
		[Address(RVA = "0x574D120", Offset = "0x574BD20", VA = "0x18574D120")]
		[MethodImpl(256)]
		public static float sin(float x)
		{
			return 0f;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x000081A8 File Offset: 0x000063A8
		[Token(Token = "0x6000418")]
		[Address(RVA = "0x574D580", Offset = "0x574C180", VA = "0x18574D580")]
		[MethodImpl(256)]
		public static float2 sin(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000081C0 File Offset: 0x000063C0
		[Token(Token = "0x6000419")]
		[Address(RVA = "0x574D180", Offset = "0x574BD80", VA = "0x18574D180")]
		[MethodImpl(256)]
		public static float3 sin(float3 x)
		{
			return default(float3);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000081D8 File Offset: 0x000063D8
		[Token(Token = "0x600041A")]
		[Address(RVA = "0x574D400", Offset = "0x574C000", VA = "0x18574D400")]
		[MethodImpl(256)]
		public static float4 sin(float4 x)
		{
			return default(float4);
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x000081F0 File Offset: 0x000063F0
		[Token(Token = "0x600041B")]
		[Address(RVA = "0x574D700", Offset = "0x574C300", VA = "0x18574D700")]
		[MethodImpl(256)]
		public static double sin(double x)
		{
			return 0.0;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00008208 File Offset: 0x00006408
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x574D640", Offset = "0x574C240", VA = "0x18574D640")]
		[MethodImpl(256)]
		public static double2 sin(double2 x)
		{
			return default(double2);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00008220 File Offset: 0x00006420
		[Token(Token = "0x600041D")]
		[Address(RVA = "0x574D010", Offset = "0x574BC10", VA = "0x18574D010")]
		[MethodImpl(256)]
		public static double3 sin(double3 x)
		{
			return default(double3);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00008238 File Offset: 0x00006438
		[Token(Token = "0x600041E")]
		[Address(RVA = "0x574D2A0", Offset = "0x574BEA0", VA = "0x18574D2A0")]
		[MethodImpl(256)]
		public static double4 sin(double4 x)
		{
			return default(double4);
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00008250 File Offset: 0x00006450
		[Token(Token = "0x600041F")]
		[Address(RVA = "0x574EA70", Offset = "0x574D670", VA = "0x18574EA70")]
		[MethodImpl(256)]
		public static float sinh(float x)
		{
			return 0f;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00008268 File Offset: 0x00006468
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x574EC50", Offset = "0x574D850", VA = "0x18574EC50")]
		[MethodImpl(256)]
		public static float2 sinh(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00008280 File Offset: 0x00006480
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x574E690", Offset = "0x574D290", VA = "0x18574E690")]
		[MethodImpl(256)]
		public static float3 sinh(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00008298 File Offset: 0x00006498
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x574EAD0", Offset = "0x574D6D0", VA = "0x18574EAD0")]
		[MethodImpl(256)]
		public static float4 sinh(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x000082B0 File Offset: 0x000064B0
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x574EA20", Offset = "0x574D620", VA = "0x18574EA20")]
		[MethodImpl(256)]
		public static double sinh(double x)
		{
			return 0.0;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000082C8 File Offset: 0x000064C8
		[Token(Token = "0x6000424")]
		[Address(RVA = "0x574E5D0", Offset = "0x574D1D0", VA = "0x18574E5D0")]
		[MethodImpl(256)]
		public static double2 sinh(double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000082E0 File Offset: 0x000064E0
		[Token(Token = "0x6000425")]
		[Address(RVA = "0x574E910", Offset = "0x574D510", VA = "0x18574E910")]
		[MethodImpl(256)]
		public static double3 sinh(double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000082F8 File Offset: 0x000064F8
		[Token(Token = "0x6000426")]
		[Address(RVA = "0x574E7B0", Offset = "0x574D3B0", VA = "0x18574E7B0")]
		[MethodImpl(256)]
		public static double4 sinh(double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00008310 File Offset: 0x00006510
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x5707770", Offset = "0x5706370", VA = "0x185707770")]
		[MethodImpl(256)]
		public static float asin(float x)
		{
			return 0f;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00008328 File Offset: 0x00006528
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x5707090", Offset = "0x5705C90", VA = "0x185707090")]
		[MethodImpl(256)]
		public static float2 asin(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00008340 File Offset: 0x00006540
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x57072B0", Offset = "0x5705EB0", VA = "0x1857072B0")]
		[MethodImpl(256)]
		public static float3 asin(float3 x)
		{
			return default(float3);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00008358 File Offset: 0x00006558
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x57075A0", Offset = "0x57061A0", VA = "0x1857075A0")]
		[MethodImpl(256)]
		public static float4 asin(float4 x)
		{
			return default(float4);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00008370 File Offset: 0x00006570
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x5707720", Offset = "0x5706320", VA = "0x185707720")]
		[MethodImpl(256)]
		public static double asin(double x)
		{
			return 0.0;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x57074E0", Offset = "0x57060E0", VA = "0x1857074E0")]
		[MethodImpl(256)]
		public static double2 asin(double2 x)
		{
			return default(double2);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000083A0 File Offset: 0x000065A0
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x57073D0", Offset = "0x5705FD0", VA = "0x1857073D0")]
		[MethodImpl(256)]
		public static double3 asin(double3 x)
		{
			return default(double3);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x5707150", Offset = "0x5705D50", VA = "0x185707150")]
		[MethodImpl(256)]
		public static double4 asin(double4 x)
		{
			return default(double4);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000083D0 File Offset: 0x000065D0
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x5719F20", Offset = "0x5718B20", VA = "0x185719F20")]
		[MethodImpl(256)]
		public static float floor(float x)
		{
			return 0f;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000083E8 File Offset: 0x000065E8
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x5700870", Offset = "0x56FF470", VA = "0x185700870")]
		[MethodImpl(256)]
		public static float2 floor(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00008400 File Offset: 0x00006600
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x5700930", Offset = "0x56FF530", VA = "0x185700930")]
		[MethodImpl(256)]
		public static float3 floor(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00008418 File Offset: 0x00006618
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x57006F0", Offset = "0x56FF2F0", VA = "0x1857006F0")]
		[MethodImpl(256)]
		public static float4 floor(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00008430 File Offset: 0x00006630
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x571A090", Offset = "0x5718C90", VA = "0x18571A090")]
		[MethodImpl(256)]
		public static double floor(double x)
		{
			return 0.0;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00008448 File Offset: 0x00006648
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x571A240", Offset = "0x5718E40", VA = "0x18571A240")]
		[MethodImpl(256)]
		public static double2 floor(double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00008460 File Offset: 0x00006660
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x5719F80", Offset = "0x5718B80", VA = "0x185719F80")]
		[MethodImpl(256)]
		public static double3 floor(double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00008478 File Offset: 0x00006678
		[Token(Token = "0x6000436")]
		[Address(RVA = "0x571A0E0", Offset = "0x5718CE0", VA = "0x18571A0E0")]
		[MethodImpl(256)]
		public static double4 floor(double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00008490 File Offset: 0x00006690
		[Token(Token = "0x6000437")]
		[Address(RVA = "0x57092C0", Offset = "0x5707EC0", VA = "0x1857092C0")]
		[MethodImpl(256)]
		public static float ceil(float x)
		{
			return 0f;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000084A8 File Offset: 0x000066A8
		[Token(Token = "0x6000438")]
		[Address(RVA = "0x5709430", Offset = "0x5708030", VA = "0x185709430")]
		[MethodImpl(256)]
		public static float2 ceil(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000084C0 File Offset: 0x000066C0
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x5709890", Offset = "0x5708490", VA = "0x185709890")]
		[MethodImpl(256)]
		public static float3 ceil(float3 x)
		{
			return default(float3);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x57095B0", Offset = "0x57081B0", VA = "0x1857095B0")]
		[MethodImpl(256)]
		public static float4 ceil(float4 x)
		{
			return default(float4);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000084F0 File Offset: 0x000066F0
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x57099B0", Offset = "0x57085B0", VA = "0x1857099B0")]
		[MethodImpl(256)]
		public static double ceil(double x)
		{
			return 0.0;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00008508 File Offset: 0x00006708
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x57094F0", Offset = "0x57080F0", VA = "0x1857094F0")]
		[MethodImpl(256)]
		public static double2 ceil(double2 x)
		{
			return default(double2);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00008520 File Offset: 0x00006720
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x5709320", Offset = "0x5707F20", VA = "0x185709320")]
		[MethodImpl(256)]
		public static double3 ceil(double3 x)
		{
			return default(double3);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00008538 File Offset: 0x00006738
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x5709730", Offset = "0x5708330", VA = "0x185709730")]
		[MethodImpl(256)]
		public static double4 ceil(double4 x)
		{
			return default(double4);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00008550 File Offset: 0x00006750
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x5749260", Offset = "0x5747E60", VA = "0x185749260")]
		[MethodImpl(256)]
		public static float round(float x)
		{
			return 0f;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00008568 File Offset: 0x00006768
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x5749680", Offset = "0x5748280", VA = "0x185749680")]
		[MethodImpl(256)]
		public static float2 round(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00008580 File Offset: 0x00006780
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x5749100", Offset = "0x5747D00", VA = "0x185749100")]
		[MethodImpl(256)]
		public static float3 round(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00008598 File Offset: 0x00006798
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x5749510", Offset = "0x5748110", VA = "0x185749510")]
		[MethodImpl(256)]
		public static float4 round(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000085B0 File Offset: 0x000067B0
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x5749210", Offset = "0x5747E10", VA = "0x185749210")]
		[MethodImpl(256)]
		public static double round(double x)
		{
			return 0.0;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x000085C8 File Offset: 0x000067C8
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x5749050", Offset = "0x5747C50", VA = "0x185749050")]
		[MethodImpl(256)]
		public static double2 round(double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000085E0 File Offset: 0x000067E0
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x57492C0", Offset = "0x5747EC0", VA = "0x1857492C0")]
		[MethodImpl(256)]
		public static double3 round(double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000085F8 File Offset: 0x000067F8
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x57493C0", Offset = "0x5747FC0", VA = "0x1857493C0")]
		[MethodImpl(256)]
		public static double4 round(double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00008610 File Offset: 0x00006810
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x5752E50", Offset = "0x5751A50", VA = "0x185752E50")]
		[MethodImpl(256)]
		public static float trunc(float x)
		{
			return 0f;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00008628 File Offset: 0x00006828
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x5752D90", Offset = "0x5751990", VA = "0x185752D90")]
		[MethodImpl(256)]
		public static float2 trunc(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00008640 File Offset: 0x00006840
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x5752A70", Offset = "0x5751670", VA = "0x185752A70")]
		[MethodImpl(256)]
		public static float3 trunc(float3 x)
		{
			return default(float3);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00008658 File Offset: 0x00006858
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x57527B0", Offset = "0x57513B0", VA = "0x1857527B0")]
		[MethodImpl(256)]
		public static float4 trunc(float4 x)
		{
			return default(float4);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00008670 File Offset: 0x00006870
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x5752920", Offset = "0x5751520", VA = "0x185752920")]
		[MethodImpl(256)]
		public static double trunc(double x)
		{
			return 0.0;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00008688 File Offset: 0x00006888
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x5752CE0", Offset = "0x57518E0", VA = "0x185752CE0")]
		[MethodImpl(256)]
		public static double2 trunc(double2 x)
		{
			return default(double2);
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000086A0 File Offset: 0x000068A0
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x5752970", Offset = "0x5751570", VA = "0x185752970")]
		[MethodImpl(256)]
		public static double3 trunc(double3 x)
		{
			return default(double3);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x000086B8 File Offset: 0x000068B8
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x5752B90", Offset = "0x5751790", VA = "0x185752B90")]
		[MethodImpl(256)]
		public static double4 trunc(double4 x)
		{
			return default(double4);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000086D0 File Offset: 0x000068D0
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x34CF700", Offset = "0x34CE300", VA = "0x1834CF700")]
		[MethodImpl(256)]
		public static float frac(float x)
		{
			return 0f;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000086E8 File Offset: 0x000068E8
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x571AD30", Offset = "0x5719930", VA = "0x18571AD30")]
		[MethodImpl(256)]
		public static float2 frac(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00008700 File Offset: 0x00006900
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x571AF50", Offset = "0x5719B50", VA = "0x18571AF50")]
		[MethodImpl(256)]
		public static float3 frac(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00008718 File Offset: 0x00006918
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x571AB70", Offset = "0x5719770", VA = "0x18571AB70")]
		[MethodImpl(256)]
		public static float4 frac(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00008730 File Offset: 0x00006930
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x571AB10", Offset = "0x5719710", VA = "0x18571AB10")]
		[MethodImpl(256)]
		public static double frac(double x)
		{
			return 0.0;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00008748 File Offset: 0x00006948
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x571B0B0", Offset = "0x5719CB0", VA = "0x18571B0B0")]
		[MethodImpl(256)]
		public static double2 frac(double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00008760 File Offset: 0x00006960
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x571AE10", Offset = "0x5719A10", VA = "0x18571AE10")]
		[MethodImpl(256)]
		public static double3 frac(double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00008778 File Offset: 0x00006978
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x571B180", Offset = "0x5719D80", VA = "0x18571B180")]
		[MethodImpl(256)]
		public static double4 frac(double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00008790 File Offset: 0x00006990
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x5746C50", Offset = "0x5745850", VA = "0x185746C50")]
		[MethodImpl(256)]
		public static float rcp(float x)
		{
			return 0f;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x000087A8 File Offset: 0x000069A8
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x5746AD0", Offset = "0x57456D0", VA = "0x185746AD0")]
		[MethodImpl(256)]
		public static float2 rcp(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x000087C0 File Offset: 0x000069C0
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x5746B50", Offset = "0x5745750", VA = "0x185746B50")]
		[MethodImpl(256)]
		public static float3 rcp(float3 x)
		{
			return default(float3);
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x000087D8 File Offset: 0x000069D8
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x5746BE0", Offset = "0x57457E0", VA = "0x185746BE0")]
		[MethodImpl(256)]
		public static float4 rcp(float4 x)
		{
			return default(float4);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x000087F0 File Offset: 0x000069F0
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x5746AC0", Offset = "0x57456C0", VA = "0x185746AC0")]
		[MethodImpl(256)]
		public static double rcp(double x)
		{
			return 0.0;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00008808 File Offset: 0x00006A08
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x5746BB0", Offset = "0x57457B0", VA = "0x185746BB0")]
		[MethodImpl(256)]
		public static double2 rcp(double2 x)
		{
			return default(double2);
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00008820 File Offset: 0x00006A20
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x5746A80", Offset = "0x5745680", VA = "0x185746A80")]
		[MethodImpl(256)]
		public static double3 rcp(double3 x)
		{
			return default(double3);
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00008838 File Offset: 0x00006A38
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x5746B00", Offset = "0x5745700", VA = "0x185746B00")]
		[MethodImpl(256)]
		public static double4 rcp(double4 x)
		{
			return default(double4);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00008850 File Offset: 0x00006A50
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x574CDA0", Offset = "0x574B9A0", VA = "0x18574CDA0")]
		[MethodImpl(256)]
		public static float sign(float x)
		{
			return 0f;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00008868 File Offset: 0x00006A68
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x574CCC0", Offset = "0x574B8C0", VA = "0x18574CCC0")]
		[MethodImpl(256)]
		public static float2 sign(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00008880 File Offset: 0x00006A80
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x574CF90", Offset = "0x574BB90", VA = "0x18574CF90")]
		[MethodImpl(256)]
		public static float3 sign(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00008898 File Offset: 0x00006A98
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x574CDD0", Offset = "0x574B9D0", VA = "0x18574CDD0")]
		[MethodImpl(256)]
		public static float4 sign(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x000088B0 File Offset: 0x00006AB0
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x574CC80", Offset = "0x574B880", VA = "0x18574CC80")]
		[MethodImpl(256)]
		public static double sign(double x)
		{
			return 0.0;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x000088C8 File Offset: 0x00006AC8
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x574CD20", Offset = "0x574B920", VA = "0x18574CD20")]
		[MethodImpl(256)]
		public static double2 sign(double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x000088E0 File Offset: 0x00006AE0
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x574CBD0", Offset = "0x574B7D0", VA = "0x18574CBD0")]
		[MethodImpl(256)]
		public static double3 sign(double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000088F8 File Offset: 0x00006AF8
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x574CE90", Offset = "0x574BA90", VA = "0x18574CE90")]
		[MethodImpl(256)]
		public static double4 sign(double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00008910 File Offset: 0x00006B10
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x5745430", Offset = "0x5744030", VA = "0x185745430")]
		[MethodImpl(256)]
		public static float pow(float x, float y)
		{
			return 0f;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00008928 File Offset: 0x00006B28
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x57454A0", Offset = "0x57440A0", VA = "0x1857454A0")]
		[MethodImpl(256)]
		public static float2 pow(float2 x, float2 y)
		{
			return default(float2);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00008940 File Offset: 0x00006B40
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x57451D0", Offset = "0x5743DD0", VA = "0x1857451D0")]
		[MethodImpl(256)]
		public static float3 pow(float3 x, float3 y)
		{
			return default(float3);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00008958 File Offset: 0x00006B58
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x5745830", Offset = "0x5744430", VA = "0x185745830")]
		[MethodImpl(256)]
		public static float4 pow(float4 x, float4 y)
		{
			return default(float4);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00008970 File Offset: 0x00006B70
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x5745570", Offset = "0x5744170", VA = "0x185745570")]
		[MethodImpl(256)]
		public static double pow(double x, double y)
		{
			return 0.0;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00008988 File Offset: 0x00006B88
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x5745760", Offset = "0x5744360", VA = "0x185745760")]
		[MethodImpl(256)]
		public static double2 pow(double2 x, double2 y)
		{
			return default(double2);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x000089A0 File Offset: 0x00006BA0
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x5745310", Offset = "0x5743F10", VA = "0x185745310")]
		[MethodImpl(256)]
		public static double3 pow(double3 x, double3 y)
		{
			return default(double3);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000089B8 File Offset: 0x00006BB8
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x57455E0", Offset = "0x57441E0", VA = "0x1857455E0")]
		[MethodImpl(256)]
		public static double4 pow(double4 x, double4 y)
		{
			return default(double4);
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000089D0 File Offset: 0x00006BD0
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x5713470", Offset = "0x5712070", VA = "0x185713470")]
		[MethodImpl(256)]
		public static float exp(float x)
		{
			return 0f;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000089E8 File Offset: 0x00006BE8
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x57131E0", Offset = "0x5711DE0", VA = "0x1857131E0")]
		[MethodImpl(256)]
		public static float2 exp(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00008A00 File Offset: 0x00006C00
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x5713630", Offset = "0x5712230", VA = "0x185713630")]
		[MethodImpl(256)]
		public static float3 exp(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x5713060", Offset = "0x5711C60", VA = "0x185713060")]
		[MethodImpl(256)]
		public static float4 exp(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00008A30 File Offset: 0x00006C30
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x5713010", Offset = "0x5711C10", VA = "0x185713010")]
		[MethodImpl(256)]
		public static double exp(double x)
		{
			return 0.0;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00008A48 File Offset: 0x00006C48
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x57132A0", Offset = "0x5711EA0", VA = "0x1857132A0")]
		[MethodImpl(256)]
		public static double2 exp(double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00008A60 File Offset: 0x00006C60
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x5713360", Offset = "0x5711F60", VA = "0x185713360")]
		[MethodImpl(256)]
		public static double3 exp(double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00008A78 File Offset: 0x00006C78
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x57134D0", Offset = "0x57120D0", VA = "0x1857134D0")]
		[MethodImpl(256)]
		public static double4 exp(double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00008A90 File Offset: 0x00006C90
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x5712740", Offset = "0x5711340", VA = "0x185712740")]
		[MethodImpl(256)]
		public static float exp2(float x)
		{
			return 0f;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00008AA8 File Offset: 0x00006CA8
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x5712BC0", Offset = "0x57117C0", VA = "0x185712BC0")]
		[MethodImpl(256)]
		public static float2 exp2(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00008AC0 File Offset: 0x00006CC0
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x57125F0", Offset = "0x57111F0", VA = "0x1857125F0")]
		[MethodImpl(256)]
		public static float3 exp2(float3 x)
		{
			return default(float3);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00008AD8 File Offset: 0x00006CD8
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x5712C90", Offset = "0x5711890", VA = "0x185712C90")]
		[MethodImpl(256)]
		public static float4 exp2(float4 x)
		{
			return default(float4);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x57127A0", Offset = "0x57113A0", VA = "0x1857127A0")]
		[MethodImpl(256)]
		public static double exp2(double x)
		{
			return 0.0;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00008B08 File Offset: 0x00006D08
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x5712800", Offset = "0x5711400", VA = "0x185712800")]
		[MethodImpl(256)]
		public static double2 exp2(double2 x)
		{
			return default(double2);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00008B20 File Offset: 0x00006D20
		[Token(Token = "0x600047D")]
		[Address(RVA = "0x57128E0", Offset = "0x57114E0", VA = "0x1857128E0")]
		[MethodImpl(256)]
		public static double3 exp2(double3 x)
		{
			return default(double3);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00008B38 File Offset: 0x00006D38
		[Token(Token = "0x600047E")]
		[Address(RVA = "0x5712A20", Offset = "0x5711620", VA = "0x185712A20")]
		[MethodImpl(256)]
		public static double4 exp2(double4 x)
		{
			return default(double4);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00008B50 File Offset: 0x00006D50
		[Token(Token = "0x600047F")]
		[Address(RVA = "0x5712590", Offset = "0x5711190", VA = "0x185712590")]
		[MethodImpl(256)]
		public static float exp10(float x)
		{
			return 0f;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00008B68 File Offset: 0x00006D68
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x5711EF0", Offset = "0x5710AF0", VA = "0x185711EF0")]
		[MethodImpl(256)]
		public static float2 exp10(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x6000481")]
		[Address(RVA = "0x5711DA0", Offset = "0x57109A0", VA = "0x185711DA0")]
		[MethodImpl(256)]
		public static float3 exp10(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00008B98 File Offset: 0x00006D98
		[Token(Token = "0x6000482")]
		[Address(RVA = "0x5712240", Offset = "0x5710E40", VA = "0x185712240")]
		[MethodImpl(256)]
		public static float4 exp10(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00008BB0 File Offset: 0x00006DB0
		[Token(Token = "0x6000483")]
		[Address(RVA = "0x57123F0", Offset = "0x5710FF0", VA = "0x1857123F0")]
		[MethodImpl(256)]
		public static double exp10(double x)
		{
			return 0.0;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00008BC8 File Offset: 0x00006DC8
		[Token(Token = "0x6000484")]
		[Address(RVA = "0x5711FC0", Offset = "0x5710BC0", VA = "0x185711FC0")]
		[MethodImpl(256)]
		public static double2 exp10(double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00008BE0 File Offset: 0x00006DE0
		[Token(Token = "0x6000485")]
		[Address(RVA = "0x5712450", Offset = "0x5711050", VA = "0x185712450")]
		[MethodImpl(256)]
		public static double3 exp10(double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00008BF8 File Offset: 0x00006DF8
		[Token(Token = "0x6000486")]
		[Address(RVA = "0x57120A0", Offset = "0x5710CA0", VA = "0x1857120A0")]
		[MethodImpl(256)]
		public static double4 exp10(double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00008C10 File Offset: 0x00006E10
		[Token(Token = "0x6000487")]
		[Address(RVA = "0x5731050", Offset = "0x572FC50", VA = "0x185731050")]
		[MethodImpl(256)]
		public static float log(float x)
		{
			return 0f;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00008C28 File Offset: 0x00006E28
		[Token(Token = "0x6000488")]
		[Address(RVA = "0x5731230", Offset = "0x572FE30", VA = "0x185731230")]
		[MethodImpl(256)]
		public static float2 log(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00008C40 File Offset: 0x00006E40
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x5731400", Offset = "0x5730000", VA = "0x185731400")]
		[MethodImpl(256)]
		public static float3 log(float3 x)
		{
			return default(float3);
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x600048A")]
		[Address(RVA = "0x57310B0", Offset = "0x572FCB0", VA = "0x1857310B0")]
		[MethodImpl(256)]
		public static float4 log(float4 x)
		{
			return default(float4);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x5731000", Offset = "0x572FC00", VA = "0x185731000")]
		[MethodImpl(256)]
		public static double log(double x)
		{
			return 0.0;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x5730F40", Offset = "0x572FB40", VA = "0x185730F40")]
		[MethodImpl(256)]
		public static double2 log(double2 x)
		{
			return default(double2);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00008CA0 File Offset: 0x00006EA0
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x57312F0", Offset = "0x572FEF0", VA = "0x1857312F0")]
		[MethodImpl(256)]
		public static double3 log(double3 x)
		{
			return default(double3);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00008CB8 File Offset: 0x00006EB8
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x5731520", Offset = "0x5730120", VA = "0x185731520")]
		[MethodImpl(256)]
		public static double4 log(double4 x)
		{
			return default(double4);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x5730760", Offset = "0x572F360", VA = "0x185730760")]
		[MethodImpl(256)]
		public static float log2(float x)
		{
			return 0f;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00008CE8 File Offset: 0x00006EE8
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x57307D0", Offset = "0x572F3D0", VA = "0x1857307D0")]
		[MethodImpl(256)]
		public static float2 log2(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00008D00 File Offset: 0x00006F00
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x57309C0", Offset = "0x572F5C0", VA = "0x1857309C0")]
		[MethodImpl(256)]
		public static float3 log2(float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00008D18 File Offset: 0x00006F18
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x5730B00", Offset = "0x572F700", VA = "0x185730B00")]
		[MethodImpl(256)]
		public static float4 log2(float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00008D30 File Offset: 0x00006F30
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x5730960", Offset = "0x572F560", VA = "0x185730960")]
		[MethodImpl(256)]
		public static double log2(double x)
		{
			return 0.0;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00008D48 File Offset: 0x00006F48
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x57308A0", Offset = "0x572F4A0", VA = "0x1857308A0")]
		[MethodImpl(256)]
		public static double2 log2(double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00008D60 File Offset: 0x00006F60
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x5730CA0", Offset = "0x572F8A0", VA = "0x185730CA0")]
		[MethodImpl(256)]
		public static double3 log2(double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00008D78 File Offset: 0x00006F78
		[Token(Token = "0x6000496")]
		[Address(RVA = "0x5730DC0", Offset = "0x572F9C0", VA = "0x185730DC0")]
		[MethodImpl(256)]
		public static double4 log2(double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00008D90 File Offset: 0x00006F90
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x57306B0", Offset = "0x572F2B0", VA = "0x1857306B0")]
		[MethodImpl(256)]
		public static float log10(float x)
		{
			return 0f;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00008DA8 File Offset: 0x00006FA8
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x57304D0", Offset = "0x572F0D0", VA = "0x1857304D0")]
		[MethodImpl(256)]
		public static float2 log10(float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00008DC0 File Offset: 0x00006FC0
		[Token(Token = "0x6000499")]
		[Address(RVA = "0x5730590", Offset = "0x572F190", VA = "0x185730590")]
		[MethodImpl(256)]
		public static float3 log10(float3 x)
		{
			return default(float3);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00008DD8 File Offset: 0x00006FD8
		[Token(Token = "0x600049A")]
		[Address(RVA = "0x5730240", Offset = "0x572EE40", VA = "0x185730240")]
		[MethodImpl(256)]
		public static float4 log10(float4 x)
		{
			return default(float4);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00008DF0 File Offset: 0x00006FF0
		[Token(Token = "0x600049B")]
		[Address(RVA = "0x5730710", Offset = "0x572F310", VA = "0x185730710")]
		[MethodImpl(256)]
		public static double log10(double x)
		{
			return 0.0;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00008E08 File Offset: 0x00007008
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x5730020", Offset = "0x572EC20", VA = "0x185730020")]
		[MethodImpl(256)]
		public static double2 log10(double2 x)
		{
			return default(double2);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00008E20 File Offset: 0x00007020
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x57303C0", Offset = "0x572EFC0", VA = "0x1857303C0")]
		[MethodImpl(256)]
		public static double3 log10(double3 x)
		{
			return default(double3);
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00008E38 File Offset: 0x00007038
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x57300E0", Offset = "0x572ECE0", VA = "0x1857300E0")]
		[MethodImpl(256)]
		public static double4 log10(double4 x)
		{
			return default(double4);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00008E50 File Offset: 0x00007050
		[Token(Token = "0x600049F")]
		[Address(RVA = "0x4CDBCA0", Offset = "0x4CDA8A0", VA = "0x184CDBCA0")]
		[MethodImpl(256)]
		public static float fmod(float x, float y)
		{
			return 0f;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00008E68 File Offset: 0x00007068
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x571A6B0", Offset = "0x57192B0", VA = "0x18571A6B0")]
		[MethodImpl(256)]
		public static float2 fmod(float2 x, float2 y)
		{
			return default(float2);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00008E80 File Offset: 0x00007080
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x571A5D0", Offset = "0x57191D0", VA = "0x18571A5D0")]
		[MethodImpl(256)]
		public static float3 fmod(float3 x, float3 y)
		{
			return default(float3);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00008E98 File Offset: 0x00007098
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x571A700", Offset = "0x5719300", VA = "0x18571A700")]
		[MethodImpl(256)]
		public static float4 fmod(float4 x, float4 y)
		{
			return default(float4);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00008EB0 File Offset: 0x000070B0
		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x571A860", Offset = "0x5719460", VA = "0x18571A860")]
		[MethodImpl(256)]
		public static double fmod(double x, double y)
		{
			return 0.0;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00008EC8 File Offset: 0x000070C8
		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x571A800", Offset = "0x5719400", VA = "0x18571A800")]
		[MethodImpl(256)]
		public static double2 fmod(double2 x, double2 y)
		{
			return default(double2);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00008EE0 File Offset: 0x000070E0
		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x571A640", Offset = "0x5719240", VA = "0x18571A640")]
		[MethodImpl(256)]
		public static double3 fmod(double3 x, double3 y)
		{
			return default(double3);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00008EF8 File Offset: 0x000070F8
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x571A780", Offset = "0x5719380", VA = "0x18571A780")]
		[MethodImpl(256)]
		public static double4 fmod(double4 x, double4 y)
		{
			return default(double4);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00008F10 File Offset: 0x00007110
		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x5733330", Offset = "0x5731F30", VA = "0x185733330")]
		[MethodImpl(256)]
		public static float modf(float x, out float i)
		{
			return 0f;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00008F28 File Offset: 0x00007128
		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x5732E10", Offset = "0x5731A10", VA = "0x185732E10")]
		[MethodImpl(256)]
		public static float2 modf(float2 x, out float2 i)
		{
			return default(float2);
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00008F40 File Offset: 0x00007140
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x5732F10", Offset = "0x5731B10", VA = "0x185732F10")]
		[MethodImpl(256)]
		public static float3 modf(float3 x, out float3 i)
		{
			return default(float3);
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00008F58 File Offset: 0x00007158
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x5732BC0", Offset = "0x57317C0", VA = "0x185732BC0")]
		[MethodImpl(256)]
		public static float4 modf(float4 x, out float4 i)
		{
			return default(float4);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00008F70 File Offset: 0x00007170
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x5732DA0", Offset = "0x57319A0", VA = "0x185732DA0")]
		[MethodImpl(256)]
		public static double modf(double x, out double i)
		{
			return 0.0;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00008F88 File Offset: 0x00007188
		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x5733240", Offset = "0x5731E40", VA = "0x185733240")]
		[MethodImpl(256)]
		public static double2 modf(double2 x, out double2 i)
		{
			return default(double2);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00008FA0 File Offset: 0x000071A0
		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x5732A70", Offset = "0x5731670", VA = "0x185732A70")]
		[MethodImpl(256)]
		public static double3 modf(double3 x, out double3 i)
		{
			return default(double3);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00008FB8 File Offset: 0x000071B8
		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x5733090", Offset = "0x5731C90", VA = "0x185733090")]
		[MethodImpl(256)]
		public static double4 modf(double4 x, out double4 i)
		{
			return default(double4);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00008FD0 File Offset: 0x000071D0
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x574FE20", Offset = "0x574EA20", VA = "0x18574FE20")]
		[MethodImpl(256)]
		public static float sqrt(float x)
		{
			return 0f;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00008FE8 File Offset: 0x000071E8
		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x5703030", Offset = "0x5701C30", VA = "0x185703030")]
		[MethodImpl(256)]
		public static float2 sqrt(float2 x)
		{
			return default(float2);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00009000 File Offset: 0x00007200
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x574FFF0", Offset = "0x574EBF0", VA = "0x18574FFF0")]
		[MethodImpl(256)]
		public static float3 sqrt(float3 x)
		{
			return default(float3);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00009018 File Offset: 0x00007218
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x574FA70", Offset = "0x574E670", VA = "0x18574FA70")]
		[MethodImpl(256)]
		public static float4 sqrt(float4 x)
		{
			return default(float4);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00009030 File Offset: 0x00007230
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x574FB00", Offset = "0x574E700", VA = "0x18574FB00")]
		[MethodImpl(256)]
		public static double sqrt(double x)
		{
			return 0.0;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00009048 File Offset: 0x00007248
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x574FB70", Offset = "0x574E770", VA = "0x18574FB70")]
		[MethodImpl(256)]
		public static double2 sqrt(double2 x)
		{
			return default(double2);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00009060 File Offset: 0x00007260
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x574FEA0", Offset = "0x574EAA0", VA = "0x18574FEA0")]
		[MethodImpl(256)]
		public static double3 sqrt(double3 x)
		{
			return default(double3);
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00009078 File Offset: 0x00007278
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x574FC60", Offset = "0x574E860", VA = "0x18574FC60")]
		[MethodImpl(256)]
		public static double4 sqrt(double4 x)
		{
			return default(double4);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00009090 File Offset: 0x00007290
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x5701EC0", Offset = "0x5700AC0", VA = "0x185701EC0")]
		[MethodImpl(256)]
		public static float rsqrt(float x)
		{
			return 0f;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000090A8 File Offset: 0x000072A8
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x5749BE0", Offset = "0x57487E0", VA = "0x185749BE0")]
		[MethodImpl(256)]
		public static float2 rsqrt(float2 x)
		{
			return default(float2);
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000090C0 File Offset: 0x000072C0
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x5749730", Offset = "0x5748330", VA = "0x185749730")]
		[MethodImpl(256)]
		public static float3 rsqrt(float3 x)
		{
			return default(float3);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000090D8 File Offset: 0x000072D8
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x5749B10", Offset = "0x5748710", VA = "0x185749B10")]
		[MethodImpl(256)]
		public static float4 rsqrt(float4 x)
		{
			return default(float4);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x000090F0 File Offset: 0x000072F0
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x5701EE0", Offset = "0x5700AE0", VA = "0x185701EE0")]
		[MethodImpl(256)]
		public static double rsqrt(double x)
		{
			return 0.0;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00009108 File Offset: 0x00007308
		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x5749C40", Offset = "0x5748840", VA = "0x185749C40")]
		[MethodImpl(256)]
		public static double2 rsqrt(double2 x)
		{
			return default(double2);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00009120 File Offset: 0x00007320
		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x57497C0", Offset = "0x57483C0", VA = "0x1857497C0")]
		[MethodImpl(256)]
		public static double3 rsqrt(double3 x)
		{
			return default(double3);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00009138 File Offset: 0x00007338
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x5749930", Offset = "0x5748530", VA = "0x185749930")]
		[MethodImpl(256)]
		public static double4 rsqrt(double4 x)
		{
			return default(double4);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00009150 File Offset: 0x00007350
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x57445B0", Offset = "0x57431B0", VA = "0x1857445B0")]
		[MethodImpl(256)]
		public static float2 normalize(float2 x)
		{
			return default(float2);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00009168 File Offset: 0x00007368
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x5744760", Offset = "0x5743360", VA = "0x185744760")]
		[MethodImpl(256)]
		public static float3 normalize(float3 x)
		{
			return default(float3);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00009180 File Offset: 0x00007380
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x5744440", Offset = "0x5743040", VA = "0x185744440")]
		[MethodImpl(256)]
		public static float4 normalize(float4 x)
		{
			return default(float4);
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00009198 File Offset: 0x00007398
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x5744700", Offset = "0x5743300", VA = "0x185744700")]
		[MethodImpl(256)]
		public static double2 normalize(double2 x)
		{
			return default(double2);
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000091B0 File Offset: 0x000073B0
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x57443C0", Offset = "0x5742FC0", VA = "0x1857443C0")]
		[MethodImpl(256)]
		public static double3 normalize(double3 x)
		{
			return default(double3);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000091C8 File Offset: 0x000073C8
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x5744510", Offset = "0x5743110", VA = "0x185744510")]
		[MethodImpl(256)]
		public static double4 normalize(double4 x)
		{
			return default(double4);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000091E0 File Offset: 0x000073E0
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x57448F0", Offset = "0x57434F0", VA = "0x1857448F0")]
		[MethodImpl(256)]
		public static float2 normalizesafe(float2 x, [Optional] float2 defaultvalue)
		{
			return default(float2);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000091F8 File Offset: 0x000073F8
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x5744CF0", Offset = "0x57438F0", VA = "0x185744CF0")]
		[MethodImpl(256)]
		public static float3 normalizesafe(float3 x, [Optional] float3 defaultvalue)
		{
			return default(float3);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00009210 File Offset: 0x00007410
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x57449B0", Offset = "0x57435B0", VA = "0x1857449B0")]
		[MethodImpl(256)]
		public static float4 normalizesafe(float4 x, [Optional] float4 defaultvalue)
		{
			return default(float4);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00009228 File Offset: 0x00007428
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x5744DE0", Offset = "0x57439E0", VA = "0x185744DE0")]
		[MethodImpl(256)]
		public static double2 normalizesafe(double2 x, [Optional] double2 defaultvalue)
		{
			return default(double2);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00009240 File Offset: 0x00007440
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x5744E80", Offset = "0x5743A80", VA = "0x185744E80")]
		[MethodImpl(256)]
		public static double3 normalizesafe(double3 x, [Optional] double3 defaultvalue)
		{
			return default(double3);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00009258 File Offset: 0x00007458
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x5744800", Offset = "0x5743400", VA = "0x185744800")]
		[MethodImpl(256)]
		public static double4 normalizesafe(double4 x, [Optional] double4 defaultvalue)
		{
			return default(double4);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00009270 File Offset: 0x00007470
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x5706020", Offset = "0x5704C20", VA = "0x185706020")]
		[MethodImpl(256)]
		public static float length(float x)
		{
			return 0f;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00009288 File Offset: 0x00007488
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x572F660", Offset = "0x572E260", VA = "0x18572F660")]
		[MethodImpl(256)]
		public static float length(float2 x)
		{
			return 0f;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x000092A0 File Offset: 0x000074A0
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x572F690", Offset = "0x572E290", VA = "0x18572F690")]
		[MethodImpl(256)]
		public static float length(float3 x)
		{
			return 0f;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x000092B8 File Offset: 0x000074B8
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x572F8B0", Offset = "0x572E4B0", VA = "0x18572F8B0")]
		[MethodImpl(256)]
		public static float length(float4 x)
		{
			return 0f;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000092D0 File Offset: 0x000074D0
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x57063A0", Offset = "0x5704FA0", VA = "0x1857063A0")]
		[MethodImpl(256)]
		public static double length(double x)
		{
			return 0.0;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x000092E8 File Offset: 0x000074E8
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x572F820", Offset = "0x572E420", VA = "0x18572F820")]
		[MethodImpl(256)]
		public static double length(double2 x)
		{
			return 0.0;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00009300 File Offset: 0x00007500
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x572F790", Offset = "0x572E390", VA = "0x18572F790")]
		[MethodImpl(256)]
		public static double length(double3 x)
		{
			return 0.0;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00009318 File Offset: 0x00007518
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x572F6E0", Offset = "0x572E2E0", VA = "0x18572F6E0")]
		[MethodImpl(256)]
		public static double length(double4 x)
		{
			return 0.0;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00009330 File Offset: 0x00007530
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x54E8690", Offset = "0x54E7290", VA = "0x1854E8690")]
		[MethodImpl(256)]
		public static float lengthsq(float x)
		{
			return 0f;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00009348 File Offset: 0x00007548
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x572FA60", Offset = "0x572E660", VA = "0x18572FA60")]
		[MethodImpl(256)]
		public static float lengthsq(float2 x)
		{
			return 0f;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00009360 File Offset: 0x00007560
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x572F9D0", Offset = "0x572E5D0", VA = "0x18572F9D0")]
		[MethodImpl(256)]
		public static float lengthsq(float3 x)
		{
			return 0f;
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00009378 File Offset: 0x00007578
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x572F910", Offset = "0x572E510", VA = "0x18572F910")]
		[MethodImpl(256)]
		public static float lengthsq(float4 x)
		{
			return 0f;
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00009390 File Offset: 0x00007590
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x572F9C0", Offset = "0x572E5C0", VA = "0x18572F9C0")]
		[MethodImpl(256)]
		public static double lengthsq(double x)
		{
			return 0.0;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x000093A8 File Offset: 0x000075A8
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x572F960", Offset = "0x572E560", VA = "0x18572F960")]
		[MethodImpl(256)]
		public static double lengthsq(double2 x)
		{
			return 0.0;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x000093C0 File Offset: 0x000075C0
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x572F980", Offset = "0x572E580", VA = "0x18572F980")]
		[MethodImpl(256)]
		public static double lengthsq(double3 x)
		{
			return 0.0;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x000093D8 File Offset: 0x000075D8
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x572FA20", Offset = "0x572E620", VA = "0x18572FA20")]
		[MethodImpl(256)]
		public static double lengthsq(double4 x)
		{
			return 0.0;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000093F0 File Offset: 0x000075F0
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x570DAC0", Offset = "0x570C6C0", VA = "0x18570DAC0")]
		[MethodImpl(256)]
		public static float distance(float x, float y)
		{
			return 0f;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00009408 File Offset: 0x00007608
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x570DB00", Offset = "0x570C700", VA = "0x18570DB00")]
		[MethodImpl(256)]
		public static float distance(float2 x, float2 y)
		{
			return 0f;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00009420 File Offset: 0x00007620
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x570D8A0", Offset = "0x570C4A0", VA = "0x18570D8A0")]
		[MethodImpl(256)]
		public static float distance(float3 x, float3 y)
		{
			return 0f;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00009438 File Offset: 0x00007638
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x570D9C0", Offset = "0x570C5C0", VA = "0x18570D9C0")]
		[MethodImpl(256)]
		public static float distance(float4 x, float4 y)
		{
			return 0f;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00009450 File Offset: 0x00007650
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x570DAE0", Offset = "0x570C6E0", VA = "0x18570DAE0")]
		[MethodImpl(256)]
		public static double distance(double x, double y)
		{
			return 0.0;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00009468 File Offset: 0x00007668
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x570DA30", Offset = "0x570C630", VA = "0x18570DA30")]
		[MethodImpl(256)]
		public static double distance(double2 x, double2 y)
		{
			return 0.0;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00009480 File Offset: 0x00007680
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x570D800", Offset = "0x570C400", VA = "0x18570D800")]
		[MethodImpl(256)]
		public static double distance(double3 x, double3 y)
		{
			return 0.0;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00009498 File Offset: 0x00007698
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x570D900", Offset = "0x570C500", VA = "0x18570D900")]
		[MethodImpl(256)]
		public static double distance(double4 x, double4 y)
		{
			return 0.0;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x000094B0 File Offset: 0x000076B0
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x570DC90", Offset = "0x570C890", VA = "0x18570DC90")]
		[MethodImpl(256)]
		public static float distancesq(float x, float y)
		{
			return 0f;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x000094C8 File Offset: 0x000076C8
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x570DB40", Offset = "0x570C740", VA = "0x18570DB40")]
		[MethodImpl(256)]
		public static float distancesq(float2 x, float2 y)
		{
			return 0f;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x000094E0 File Offset: 0x000076E0
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x570DCA0", Offset = "0x570C8A0", VA = "0x18570DCA0")]
		[MethodImpl(256)]
		public static float distancesq(float3 x, float3 y)
		{
			return 0f;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x000094F8 File Offset: 0x000076F8
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x570DB80", Offset = "0x570C780", VA = "0x18570DB80")]
		[MethodImpl(256)]
		public static float distancesq(float4 x, float4 y)
		{
			return 0f;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00009510 File Offset: 0x00007710
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x570DD00", Offset = "0x570C900", VA = "0x18570DD00")]
		[MethodImpl(256)]
		public static double distancesq(double x, double y)
		{
			return 0.0;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00009528 File Offset: 0x00007728
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x570DD10", Offset = "0x570C910", VA = "0x18570DD10")]
		[MethodImpl(256)]
		public static double distancesq(double2 x, double2 y)
		{
			return 0.0;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x570DC40", Offset = "0x570C840", VA = "0x18570DC40")]
		[MethodImpl(256)]
		public static double distancesq(double3 x, double3 y)
		{
			return 0.0;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x570DBE0", Offset = "0x570C7E0", VA = "0x18570DBE0")]
		[MethodImpl(256)]
		public static double distancesq(double4 x, double4 y)
		{
			return 0.0;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00009570 File Offset: 0x00007770
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x570CC70", Offset = "0x570B870", VA = "0x18570CC70")]
		[MethodImpl(256)]
		public static float3 cross(float3 x, float3 y)
		{
			return default(float3);
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00009588 File Offset: 0x00007788
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x570CD00", Offset = "0x570B900", VA = "0x18570CD00")]
		[MethodImpl(256)]
		public static double3 cross(double3 x, double3 y)
		{
			return default(double3);
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x000095A0 File Offset: 0x000077A0
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x574F6A0", Offset = "0x574E2A0", VA = "0x18574F6A0")]
		[MethodImpl(256)]
		public static float smoothstep(float a, float b, float x)
		{
			return 0f;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000095B8 File Offset: 0x000077B8
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x574F700", Offset = "0x574E300", VA = "0x18574F700")]
		[MethodImpl(256)]
		public static float2 smoothstep(float2 a, float2 b, float2 x)
		{
			return default(float2);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x000095D0 File Offset: 0x000077D0
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x574F160", Offset = "0x574DD60", VA = "0x18574F160")]
		[MethodImpl(256)]
		public static float3 smoothstep(float3 a, float3 b, float3 x)
		{
			return default(float3);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000095E8 File Offset: 0x000077E8
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x574F840", Offset = "0x574E440", VA = "0x18574F840")]
		[MethodImpl(256)]
		public static float4 smoothstep(float4 a, float4 b, float4 x)
		{
			return default(float4);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00009600 File Offset: 0x00007800
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x574F7E0", Offset = "0x574E3E0", VA = "0x18574F7E0")]
		[MethodImpl(256)]
		public static double smoothstep(double a, double b, double x)
		{
			return 0.0;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00009618 File Offset: 0x00007818
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x574F050", Offset = "0x574DC50", VA = "0x18574F050")]
		[MethodImpl(256)]
		public static double2 smoothstep(double2 a, double2 b, double2 x)
		{
			return default(double2);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00009630 File Offset: 0x00007830
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x574F520", Offset = "0x574E120", VA = "0x18574F520")]
		[MethodImpl(256)]
		public static double3 smoothstep(double3 a, double3 b, double3 x)
		{
			return default(double3);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00009648 File Offset: 0x00007848
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x574F310", Offset = "0x574DF10", VA = "0x18574F310")]
		[MethodImpl(256)]
		public static double4 smoothstep(double4 a, double4 b, double4 x)
		{
			return default(double4);
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00009660 File Offset: 0x00007860
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x5706DE0", Offset = "0x57059E0", VA = "0x185706DE0")]
		[MethodImpl(256)]
		public static bool any(bool2 x)
		{
			return default(bool);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00009678 File Offset: 0x00007878
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x5706EC0", Offset = "0x5705AC0", VA = "0x185706EC0")]
		[MethodImpl(256)]
		public static bool any(bool3 x)
		{
			return default(bool);
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00009690 File Offset: 0x00007890
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x5706F90", Offset = "0x5705B90", VA = "0x185706F90")]
		[MethodImpl(256)]
		public static bool any(bool4 x)
		{
			return default(bool);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x000096A8 File Offset: 0x000078A8
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x5706DC0", Offset = "0x57059C0", VA = "0x185706DC0")]
		[MethodImpl(256)]
		public static bool any(int2 x)
		{
			return default(bool);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000096C0 File Offset: 0x000078C0
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x5706DF0", Offset = "0x57059F0", VA = "0x185706DF0")]
		[MethodImpl(256)]
		public static bool any(int3 x)
		{
			return default(bool);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000096D8 File Offset: 0x000078D8
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x5706DA0", Offset = "0x57059A0", VA = "0x185706DA0")]
		[MethodImpl(256)]
		public static bool any(int4 x)
		{
			return default(bool);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000096F0 File Offset: 0x000078F0
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x5706DC0", Offset = "0x57059C0", VA = "0x185706DC0")]
		[MethodImpl(256)]
		public static bool any(uint2 x)
		{
			return default(bool);
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00009708 File Offset: 0x00007908
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x5706DF0", Offset = "0x57059F0", VA = "0x185706DF0")]
		[MethodImpl(256)]
		public static bool any(uint3 x)
		{
			return default(bool);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00009720 File Offset: 0x00007920
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x5706DA0", Offset = "0x57059A0", VA = "0x185706DA0")]
		[MethodImpl(256)]
		public static bool any(uint4 x)
		{
			return default(bool);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00009738 File Offset: 0x00007938
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x5706EE0", Offset = "0x5705AE0", VA = "0x185706EE0")]
		[MethodImpl(256)]
		public static bool any(float2 x)
		{
			return default(bool);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00009750 File Offset: 0x00007950
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x5706E40", Offset = "0x5705A40", VA = "0x185706E40")]
		[MethodImpl(256)]
		public static bool any(float3 x)
		{
			return default(bool);
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00009768 File Offset: 0x00007968
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x5706F10", Offset = "0x5705B10", VA = "0x185706F10")]
		[MethodImpl(256)]
		public static bool any(float4 x)
		{
			return default(bool);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00009780 File Offset: 0x00007980
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x5706E10", Offset = "0x5705A10", VA = "0x185706E10")]
		[MethodImpl(256)]
		public static bool any(double2 x)
		{
			return default(bool);
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00009798 File Offset: 0x00007998
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x5706F50", Offset = "0x5705B50", VA = "0x185706F50")]
		[MethodImpl(256)]
		public static bool any(double3 x)
		{
			return default(bool);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000097B0 File Offset: 0x000079B0
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x5706E70", Offset = "0x5705A70", VA = "0x185706E70")]
		[MethodImpl(256)]
		public static bool any(double4 x)
		{
			return default(bool);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000097C8 File Offset: 0x000079C8
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x5706B90", Offset = "0x5705790", VA = "0x185706B90")]
		[MethodImpl(256)]
		public static bool all(bool2 x)
		{
			return default(bool);
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x000097E0 File Offset: 0x000079E0
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x5706D20", Offset = "0x5705920", VA = "0x185706D20")]
		[MethodImpl(256)]
		public static bool all(bool3 x)
		{
			return default(bool);
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x000097F8 File Offset: 0x000079F8
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x5706CC0", Offset = "0x57058C0", VA = "0x185706CC0")]
		[MethodImpl(256)]
		public static bool all(bool4 x)
		{
			return default(bool);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00009810 File Offset: 0x00007A10
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x5706BC0", Offset = "0x57057C0", VA = "0x185706BC0")]
		[MethodImpl(256)]
		public static bool all(int2 x)
		{
			return default(bool);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00009828 File Offset: 0x00007A28
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x5706BA0", Offset = "0x57057A0", VA = "0x185706BA0")]
		[MethodImpl(256)]
		public static bool all(int3 x)
		{
			return default(bool);
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00009840 File Offset: 0x00007A40
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x5706C70", Offset = "0x5705870", VA = "0x185706C70")]
		[MethodImpl(256)]
		public static bool all(int4 x)
		{
			return default(bool);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x5706BC0", Offset = "0x57057C0", VA = "0x185706BC0")]
		[MethodImpl(256)]
		public static bool all(uint2 x)
		{
			return default(bool);
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00009870 File Offset: 0x00007A70
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x5706BA0", Offset = "0x57057A0", VA = "0x185706BA0")]
		[MethodImpl(256)]
		public static bool all(uint3 x)
		{
			return default(bool);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00009888 File Offset: 0x00007A88
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x5706C70", Offset = "0x5705870", VA = "0x185706C70")]
		[MethodImpl(256)]
		public static bool all(uint4 x)
		{
			return default(bool);
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000098A0 File Offset: 0x00007AA0
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x5706C90", Offset = "0x5705890", VA = "0x185706C90")]
		[MethodImpl(256)]
		public static bool all(float2 x)
		{
			return default(bool);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x000098B8 File Offset: 0x00007AB8
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x5706D40", Offset = "0x5705940", VA = "0x185706D40")]
		[MethodImpl(256)]
		public static bool all(float3 x)
		{
			return default(bool);
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x000098D0 File Offset: 0x00007AD0
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x5706CE0", Offset = "0x57058E0", VA = "0x185706CE0")]
		[MethodImpl(256)]
		public static bool all(float4 x)
		{
			return default(bool);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x000098E8 File Offset: 0x00007AE8
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x5706D70", Offset = "0x5705970", VA = "0x185706D70")]
		[MethodImpl(256)]
		public static bool all(double2 x)
		{
			return default(bool);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00009900 File Offset: 0x00007B00
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x5706C30", Offset = "0x5705830", VA = "0x185706C30")]
		[MethodImpl(256)]
		public static bool all(double3 x)
		{
			return default(bool);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00009918 File Offset: 0x00007B18
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x5706BE0", Offset = "0x57057E0", VA = "0x185706BE0")]
		[MethodImpl(256)]
		public static bool all(double4 x)
		{
			return default(bool);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00009930 File Offset: 0x00007B30
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x574A290", Offset = "0x5748E90", VA = "0x18574A290")]
		[MethodImpl(256)]
		public static int select(int a, int b, bool c)
		{
			return 0;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00009948 File Offset: 0x00007B48
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x574A300", Offset = "0x5748F00", VA = "0x18574A300")]
		[MethodImpl(256)]
		public static int2 select(int2 a, int2 b, bool c)
		{
			return default(int2);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00009960 File Offset: 0x00007B60
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x574A3E0", Offset = "0x5748FE0", VA = "0x18574A3E0")]
		[MethodImpl(256)]
		public static int3 select(int3 a, int3 b, bool c)
		{
			return default(int3);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00009978 File Offset: 0x00007B78
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x574A360", Offset = "0x5748F60", VA = "0x18574A360")]
		[MethodImpl(256)]
		public static int4 select(int4 a, int4 b, bool c)
		{
			return default(int4);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00009990 File Offset: 0x00007B90
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x574A410", Offset = "0x5749010", VA = "0x18574A410")]
		[MethodImpl(256)]
		public static int2 select(int2 a, int2 b, bool2 c)
		{
			return default(int2);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000099A8 File Offset: 0x00007BA8
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x574A2A0", Offset = "0x5748EA0", VA = "0x18574A2A0")]
		[MethodImpl(256)]
		public static int3 select(int3 a, int3 b, bool3 c)
		{
			return default(int3);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000099C0 File Offset: 0x00007BC0
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x574A4B0", Offset = "0x57490B0", VA = "0x18574A4B0")]
		[MethodImpl(256)]
		public static int4 select(int4 a, int4 b, bool4 c)
		{
			return default(int4);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000099D8 File Offset: 0x00007BD8
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x574A290", Offset = "0x5748E90", VA = "0x18574A290")]
		[MethodImpl(256)]
		public static uint select(uint a, uint b, bool c)
		{
			return 0U;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x000099F0 File Offset: 0x00007BF0
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x574A300", Offset = "0x5748F00", VA = "0x18574A300")]
		[MethodImpl(256)]
		public static uint2 select(uint2 a, uint2 b, bool c)
		{
			return default(uint2);
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00009A08 File Offset: 0x00007C08
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x574A3E0", Offset = "0x5748FE0", VA = "0x18574A3E0")]
		[MethodImpl(256)]
		public static uint3 select(uint3 a, uint3 b, bool c)
		{
			return default(uint3);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00009A20 File Offset: 0x00007C20
		[Token(Token = "0x600051D")]
		[Address(RVA = "0x574A360", Offset = "0x5748F60", VA = "0x18574A360")]
		[MethodImpl(256)]
		public static uint4 select(uint4 a, uint4 b, bool c)
		{
			return default(uint4);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00009A38 File Offset: 0x00007C38
		[Token(Token = "0x600051E")]
		[Address(RVA = "0x574A410", Offset = "0x5749010", VA = "0x18574A410")]
		[MethodImpl(256)]
		public static uint2 select(uint2 a, uint2 b, bool2 c)
		{
			return default(uint2);
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00009A50 File Offset: 0x00007C50
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x574A2A0", Offset = "0x5748EA0", VA = "0x18574A2A0")]
		[MethodImpl(256)]
		public static uint3 select(uint3 a, uint3 b, bool3 c)
		{
			return default(uint3);
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00009A68 File Offset: 0x00007C68
		[Token(Token = "0x6000520")]
		[Address(RVA = "0x574A4B0", Offset = "0x57490B0", VA = "0x18574A4B0")]
		[MethodImpl(256)]
		public static uint4 select(uint4 a, uint4 b, bool4 c)
		{
			return default(uint4);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00009A80 File Offset: 0x00007C80
		[Token(Token = "0x6000521")]
		[Address(RVA = "0x574A240", Offset = "0x5748E40", VA = "0x18574A240")]
		[MethodImpl(256)]
		public static long select(long a, long b, bool c)
		{
			return 0L;
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00009A98 File Offset: 0x00007C98
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x574A240", Offset = "0x5748E40", VA = "0x18574A240")]
		[MethodImpl(256)]
		public static ulong select(ulong a, ulong b, bool c)
		{
			return 0UL;
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00009AB0 File Offset: 0x00007CB0
		[Token(Token = "0x6000523")]
		[Address(RVA = "0x574A2F0", Offset = "0x5748EF0", VA = "0x18574A2F0")]
		[MethodImpl(256)]
		public static float select(float a, float b, bool c)
		{
			return 0f;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00009AC8 File Offset: 0x00007CC8
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x574A300", Offset = "0x5748F00", VA = "0x18574A300")]
		[MethodImpl(256)]
		public static float2 select(float2 a, float2 b, bool c)
		{
			return default(float2);
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00009AE0 File Offset: 0x00007CE0
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x574A3E0", Offset = "0x5748FE0", VA = "0x18574A3E0")]
		[MethodImpl(256)]
		public static float3 select(float3 a, float3 b, bool c)
		{
			return default(float3);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00009AF8 File Offset: 0x00007CF8
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x574A360", Offset = "0x5748F60", VA = "0x18574A360")]
		[MethodImpl(256)]
		public static float4 select(float4 a, float4 b, bool c)
		{
			return default(float4);
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00009B10 File Offset: 0x00007D10
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x574A310", Offset = "0x5748F10", VA = "0x18574A310")]
		[MethodImpl(256)]
		public static float2 select(float2 a, float2 b, bool2 c)
		{
			return default(float2);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00009B28 File Offset: 0x00007D28
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x574A380", Offset = "0x5748F80", VA = "0x18574A380")]
		[MethodImpl(256)]
		public static float3 select(float3 a, float3 b, bool3 c)
		{
			return default(float3);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00009B40 File Offset: 0x00007D40
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x574A440", Offset = "0x5749040", VA = "0x18574A440")]
		[MethodImpl(256)]
		public static float4 select(float4 a, float4 b, bool4 c)
		{
			return default(float4);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00009B58 File Offset: 0x00007D58
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x574A2F0", Offset = "0x5748EF0", VA = "0x18574A2F0")]
		[MethodImpl(256)]
		public static double select(double a, double b, bool c)
		{
			return 0.0;
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00009B70 File Offset: 0x00007D70
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x574A360", Offset = "0x5748F60", VA = "0x18574A360")]
		[MethodImpl(256)]
		public static double2 select(double2 a, double2 b, bool c)
		{
			return default(double2);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00009B88 File Offset: 0x00007D88
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x574A600", Offset = "0x5749200", VA = "0x18574A600")]
		[MethodImpl(256)]
		public static double3 select(double3 a, double3 b, bool c)
		{
			return default(double3);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00009BA0 File Offset: 0x00007DA0
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x574A630", Offset = "0x5749230", VA = "0x18574A630")]
		[MethodImpl(256)]
		public static double4 select(double4 a, double4 b, bool c)
		{
			return default(double4);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00009BB8 File Offset: 0x00007DB8
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x574A250", Offset = "0x5748E50", VA = "0x18574A250")]
		[MethodImpl(256)]
		public static double2 select(double2 a, double2 b, bool2 c)
		{
			return default(double2);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00009BD0 File Offset: 0x00007DD0
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x574A5A0", Offset = "0x57491A0", VA = "0x18574A5A0")]
		[MethodImpl(256)]
		public static double3 select(double3 a, double3 b, bool3 c)
		{
			return default(double3);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00009BE8 File Offset: 0x00007DE8
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x574A520", Offset = "0x5749120", VA = "0x18574A520")]
		[MethodImpl(256)]
		public static double4 select(double4 a, double4 b, bool4 c)
		{
			return default(double4);
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00009C00 File Offset: 0x00007E00
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x5750060", Offset = "0x574EC60", VA = "0x185750060")]
		[MethodImpl(256)]
		public static float step(float y, float x)
		{
			return 0f;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00009C18 File Offset: 0x00007E18
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x5750360", Offset = "0x574EF60", VA = "0x185750360")]
		[MethodImpl(256)]
		public static float2 step(float2 y, float2 x)
		{
			return default(float2);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00009C30 File Offset: 0x00007E30
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x5750220", Offset = "0x574EE20", VA = "0x185750220")]
		[MethodImpl(256)]
		public static float3 step(float3 y, float3 x)
		{
			return default(float3);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00009C48 File Offset: 0x00007E48
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x57500A0", Offset = "0x574ECA0", VA = "0x1857500A0")]
		[MethodImpl(256)]
		public static float4 step(float4 y, float4 x)
		{
			return default(float4);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00009C60 File Offset: 0x00007E60
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x5750080", Offset = "0x574EC80", VA = "0x185750080")]
		[MethodImpl(256)]
		public static double step(double y, double x)
		{
			return 0.0;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00009C78 File Offset: 0x00007E78
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x57501C0", Offset = "0x574EDC0", VA = "0x1857501C0")]
		[MethodImpl(256)]
		public static double2 step(double2 y, double2 x)
		{
			return default(double2);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00009C90 File Offset: 0x00007E90
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x5750150", Offset = "0x574ED50", VA = "0x185750150")]
		[MethodImpl(256)]
		public static double3 step(double3 y, double3 x)
		{
			return default(double3);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00009CA8 File Offset: 0x00007EA8
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x57502B0", Offset = "0x574EEB0", VA = "0x1857502B0")]
		[MethodImpl(256)]
		public static double4 step(double4 y, double4 x)
		{
			return default(double4);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00009CC0 File Offset: 0x00007EC0
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x5746C60", Offset = "0x5745860", VA = "0x185746C60")]
		[MethodImpl(256)]
		public static float2 reflect(float2 i, float2 n)
		{
			return default(float2);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00009CD8 File Offset: 0x00007ED8
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x5746EE0", Offset = "0x5745AE0", VA = "0x185746EE0")]
		[MethodImpl(256)]
		public static float3 reflect(float3 i, float3 n)
		{
			return default(float3);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00009CF0 File Offset: 0x00007EF0
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x5746FB0", Offset = "0x5745BB0", VA = "0x185746FB0")]
		[MethodImpl(256)]
		public static float4 reflect(float4 i, float4 n)
		{
			return default(float4);
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00009D08 File Offset: 0x00007F08
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x5746E80", Offset = "0x5745A80", VA = "0x185746E80")]
		[MethodImpl(256)]
		public static double2 reflect(double2 i, double2 n)
		{
			return default(double2);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00009D20 File Offset: 0x00007F20
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x5746DC0", Offset = "0x57459C0", VA = "0x185746DC0")]
		[MethodImpl(256)]
		public static double3 reflect(double3 i, double3 n)
		{
			return default(double3);
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00009D38 File Offset: 0x00007F38
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x5746CC0", Offset = "0x57458C0", VA = "0x185746CC0")]
		[MethodImpl(256)]
		public static double4 reflect(double4 i, double4 n)
		{
			return default(double4);
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00009D50 File Offset: 0x00007F50
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x57472E0", Offset = "0x5745EE0", VA = "0x1857472E0")]
		[MethodImpl(256)]
		public static float2 refract(float2 i, float2 n, float eta)
		{
			return default(float2);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00009D68 File Offset: 0x00007F68
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x5747570", Offset = "0x5746170", VA = "0x185747570")]
		[MethodImpl(256)]
		public static float3 refract(float3 i, float3 n, float eta)
		{
			return default(float3);
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00009D80 File Offset: 0x00007F80
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x5747920", Offset = "0x5746520", VA = "0x185747920")]
		[MethodImpl(256)]
		public static float4 refract(float4 i, float4 n, float eta)
		{
			return default(float4);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00009D98 File Offset: 0x00007F98
		[Token(Token = "0x6000542")]
		[Address(RVA = "0x5747410", Offset = "0x5746010", VA = "0x185747410")]
		[MethodImpl(256)]
		public static double2 refract(double2 i, double2 n, double eta)
		{
			return default(double2);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00009DB0 File Offset: 0x00007FB0
		[Token(Token = "0x6000543")]
		[Address(RVA = "0x5747730", Offset = "0x5746330", VA = "0x185747730")]
		[MethodImpl(256)]
		public static double3 refract(double3 i, double3 n, double eta)
		{
			return default(double3);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00009DC8 File Offset: 0x00007FC8
		[Token(Token = "0x6000544")]
		[Address(RVA = "0x57470C0", Offset = "0x5745CC0", VA = "0x1857470C0")]
		[MethodImpl(256)]
		public static double4 refract(double4 i, double4 n, double eta)
		{
			return default(double4);
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00009DE0 File Offset: 0x00007FE0
		[Token(Token = "0x6000545")]
		[Address(RVA = "0x57459D0", Offset = "0x57445D0", VA = "0x1857459D0")]
		[MethodImpl(256)]
		public static float2 project(float2 a, float2 b)
		{
			return default(float2);
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00009DF8 File Offset: 0x00007FF8
		[Token(Token = "0x6000546")]
		[Address(RVA = "0x5745BE0", Offset = "0x57447E0", VA = "0x185745BE0")]
		[MethodImpl(256)]
		public static float3 project(float3 a, float3 b)
		{
			return default(float3);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00009E10 File Offset: 0x00008010
		[Token(Token = "0x6000547")]
		[Address(RVA = "0x5745DA0", Offset = "0x57449A0", VA = "0x185745DA0")]
		[MethodImpl(256)]
		public static float4 project(float4 a, float4 b)
		{
			return default(float4);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00009E28 File Offset: 0x00008028
		[Token(Token = "0x6000548")]
		[Address(RVA = "0x57460C0", Offset = "0x5744CC0", VA = "0x1857460C0")]
		[MethodImpl(256)]
		public static float2 projectsafe(float2 a, float2 b, [Optional] float2 defaultValue)
		{
			return default(float2);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00009E40 File Offset: 0x00008040
		[Token(Token = "0x6000549")]
		[Address(RVA = "0x57461B0", Offset = "0x5744DB0", VA = "0x1857461B0")]
		[MethodImpl(256)]
		public static float3 projectsafe(float3 a, float3 b, [Optional] float3 defaultValue)
		{
			return default(float3);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00009E58 File Offset: 0x00008058
		[Token(Token = "0x600054A")]
		[Address(RVA = "0x5745EA0", Offset = "0x5744AA0", VA = "0x185745EA0")]
		[MethodImpl(256)]
		public static float4 projectsafe(float4 a, float4 b, [Optional] float4 defaultValue)
		{
			return default(float4);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00009E70 File Offset: 0x00008070
		[Token(Token = "0x600054B")]
		[Address(RVA = "0x5745B60", Offset = "0x5744760", VA = "0x185745B60")]
		[MethodImpl(256)]
		public static double2 project(double2 a, double2 b)
		{
			return default(double2);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00009E88 File Offset: 0x00008088
		[Token(Token = "0x600054C")]
		[Address(RVA = "0x5745CB0", Offset = "0x57448B0", VA = "0x185745CB0")]
		[MethodImpl(256)]
		public static double3 project(double3 a, double3 b)
		{
			return default(double3);
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00009EA0 File Offset: 0x000080A0
		[Token(Token = "0x600054D")]
		[Address(RVA = "0x5745A30", Offset = "0x5744630", VA = "0x185745A30")]
		[MethodImpl(256)]
		public static double4 project(double4 a, double4 b)
		{
			return default(double4);
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00009EB8 File Offset: 0x000080B8
		[Token(Token = "0x600054E")]
		[Address(RVA = "0x5746590", Offset = "0x5745190", VA = "0x185746590")]
		[MethodImpl(256)]
		public static double2 projectsafe(double2 a, double2 b, [Optional] double2 defaultValue)
		{
			return default(double2);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00009ED0 File Offset: 0x000080D0
		[Token(Token = "0x600054F")]
		[Address(RVA = "0x5746670", Offset = "0x5745270", VA = "0x185746670")]
		[MethodImpl(256)]
		public static double3 projectsafe(double3 a, double3 b, [Optional] double3 defaultValue)
		{
			return default(double3);
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00009EE8 File Offset: 0x000080E8
		[Token(Token = "0x6000550")]
		[Address(RVA = "0x5746340", Offset = "0x5744F40", VA = "0x185746340")]
		[MethodImpl(256)]
		public static double4 projectsafe(double4 a, double4 b, [Optional] double4 defaultValue)
		{
			return default(double4);
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00009F00 File Offset: 0x00008100
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x5714C90", Offset = "0x5713890", VA = "0x185714C90")]
		[MethodImpl(256)]
		public static float2 faceforward(float2 n, float2 i, float2 ng)
		{
			return default(float2);
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00009F18 File Offset: 0x00008118
		[Token(Token = "0x6000552")]
		[Address(RVA = "0x5714DB0", Offset = "0x57139B0", VA = "0x185714DB0")]
		[MethodImpl(256)]
		public static float3 faceforward(float3 n, float3 i, float3 ng)
		{
			return default(float3);
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00009F30 File Offset: 0x00008130
		[Token(Token = "0x6000553")]
		[Address(RVA = "0x5714B60", Offset = "0x5713760", VA = "0x185714B60")]
		[MethodImpl(256)]
		public static float4 faceforward(float4 n, float4 i, float4 ng)
		{
			return default(float4);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00009F48 File Offset: 0x00008148
		[Token(Token = "0x6000554")]
		[Address(RVA = "0x5714C20", Offset = "0x5713820", VA = "0x185714C20")]
		[MethodImpl(256)]
		public static double2 faceforward(double2 n, double2 i, double2 ng)
		{
			return default(double2);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00009F60 File Offset: 0x00008160
		[Token(Token = "0x6000555")]
		[Address(RVA = "0x5714D00", Offset = "0x5713900", VA = "0x185714D00")]
		[MethodImpl(256)]
		public static double3 faceforward(double3 n, double3 i, double3 ng)
		{
			return default(double3);
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00009F78 File Offset: 0x00008178
		[Token(Token = "0x6000556")]
		[Address(RVA = "0x5714E70", Offset = "0x5713A70", VA = "0x185714E70")]
		[MethodImpl(256)]
		public static double4 faceforward(double4 n, double4 i, double4 ng)
		{
			return default(double4);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000557")]
		[Address(RVA = "0x574E390", Offset = "0x574CF90", VA = "0x18574E390")]
		[MethodImpl(256)]
		public static void sincos(float x, out float s, out float c)
		{
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000558")]
		[Address(RVA = "0x574E450", Offset = "0x574D050", VA = "0x18574E450")]
		[MethodImpl(256)]
		public static void sincos(float2 x, out float2 s, out float2 c)
		{
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000559")]
		[Address(RVA = "0x574DA00", Offset = "0x574C600", VA = "0x18574DA00")]
		[MethodImpl(256)]
		public static void sincos(float3 x, out float3 s, out float3 c)
		{
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055A")]
		[Address(RVA = "0x574DC50", Offset = "0x574C850", VA = "0x18574DC50")]
		[MethodImpl(256)]
		public static void sincos(float4 x, out float4 s, out float4 c)
		{
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055B")]
		[Address(RVA = "0x574DF50", Offset = "0x574CB50", VA = "0x18574DF50")]
		[MethodImpl(256)]
		public static void sincos(double x, out double s, out double c)
		{
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055C")]
		[Address(RVA = "0x574E000", Offset = "0x574CC00", VA = "0x18574E000")]
		[MethodImpl(256)]
		public static void sincos(double2 x, out double2 s, out double2 c)
		{
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055D")]
		[Address(RVA = "0x574E170", Offset = "0x574CD70", VA = "0x18574E170")]
		[MethodImpl(256)]
		public static void sincos(double3 x, out double3 s, out double3 c)
		{
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600055E")]
		[Address(RVA = "0x574D750", Offset = "0x574C350", VA = "0x18574D750")]
		[MethodImpl(256)]
		public static void sincos(double4 x, out double4 s, out double4 c)
		{
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00009F90 File Offset: 0x00008190
		[Token(Token = "0x600055F")]
		[Address(RVA = "0x570CC30", Offset = "0x570B830", VA = "0x18570CC30")]
		[MethodImpl(256)]
		public static int countbits(int x)
		{
			return 0;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00009FA8 File Offset: 0x000081A8
		[Token(Token = "0x6000560")]
		[Address(RVA = "0x570C7F0", Offset = "0x570B3F0", VA = "0x18570C7F0")]
		[MethodImpl(256)]
		public static int2 countbits(int2 x)
		{
			return default(int2);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00009FC0 File Offset: 0x000081C0
		[Token(Token = "0x6000561")]
		[Address(RVA = "0x570CBB0", Offset = "0x570B7B0", VA = "0x18570CBB0")]
		[MethodImpl(256)]
		public static int3 countbits(int3 x)
		{
			return default(int3);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00009FD8 File Offset: 0x000081D8
		[Token(Token = "0x6000562")]
		[Address(RVA = "0x570CB40", Offset = "0x570B740", VA = "0x18570CB40")]
		[MethodImpl(256)]
		public static int4 countbits(int4 x)
		{
			return default(int4);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00009FF0 File Offset: 0x000081F0
		[Token(Token = "0x6000563")]
		[Address(RVA = "0x570CC30", Offset = "0x570B830", VA = "0x18570CC30")]
		[MethodImpl(256)]
		public static int countbits(uint x)
		{
			return 0;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0000A008 File Offset: 0x00008208
		[Token(Token = "0x6000564")]
		[Address(RVA = "0x570C9A0", Offset = "0x570B5A0", VA = "0x18570C9A0")]
		[MethodImpl(256)]
		public static int2 countbits(uint2 x)
		{
			return default(int2);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000A020 File Offset: 0x00008220
		[Token(Token = "0x6000565")]
		[Address(RVA = "0x57000E0", Offset = "0x56FECE0", VA = "0x1857000E0")]
		[MethodImpl(256)]
		public static int3 countbits(uint3 x)
		{
			return default(int3);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000A038 File Offset: 0x00008238
		[Token(Token = "0x6000566")]
		[Address(RVA = "0x57002D0", Offset = "0x56FEED0", VA = "0x1857002D0")]
		[MethodImpl(256)]
		public static int4 countbits(uint4 x)
		{
			return default(int4);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0000A050 File Offset: 0x00008250
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x570C790", Offset = "0x570B390", VA = "0x18570C790")]
		[MethodImpl(256)]
		public static int countbits(ulong x)
		{
			return 0;
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0000A068 File Offset: 0x00008268
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x570C790", Offset = "0x570B390", VA = "0x18570C790")]
		[MethodImpl(256)]
		public static int countbits(long x)
		{
			return 0;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0000A080 File Offset: 0x00008280
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x5731920", Offset = "0x5730520", VA = "0x185731920")]
		[MethodImpl(256)]
		public static int lzcnt(int x)
		{
			return 0;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000A098 File Offset: 0x00008298
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x5731A90", Offset = "0x5730690", VA = "0x185731A90")]
		[MethodImpl(256)]
		public static int2 lzcnt(int2 x)
		{
			return default(int2);
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000A0B0 File Offset: 0x000082B0
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x5731840", Offset = "0x5730440", VA = "0x185731840")]
		[MethodImpl(256)]
		public static int3 lzcnt(int3 x)
		{
			return default(int3);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x0000A0C8 File Offset: 0x000082C8
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x5731970", Offset = "0x5730570", VA = "0x185731970")]
		[MethodImpl(256)]
		public static int4 lzcnt(int4 x)
		{
			return default(int4);
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000A0E0 File Offset: 0x000082E0
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x5731920", Offset = "0x5730520", VA = "0x185731920")]
		[MethodImpl(256)]
		public static int lzcnt(uint x)
		{
			return 0;
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000A0F8 File Offset: 0x000082F8
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x5731A90", Offset = "0x5730690", VA = "0x185731A90")]
		[MethodImpl(256)]
		public static int2 lzcnt(uint2 x)
		{
			return default(int2);
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x0000A110 File Offset: 0x00008310
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x5731840", Offset = "0x5730440", VA = "0x185731840")]
		[MethodImpl(256)]
		public static int3 lzcnt(uint3 x)
		{
			return default(int3);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x0000A128 File Offset: 0x00008328
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x5731970", Offset = "0x5730570", VA = "0x185731970")]
		[MethodImpl(256)]
		public static int4 lzcnt(uint4 x)
		{
			return default(int4);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0000A140 File Offset: 0x00008340
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x5731B30", Offset = "0x5730730", VA = "0x185731B30")]
		[MethodImpl(256)]
		public static int lzcnt(long x)
		{
			return 0;
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x0000A158 File Offset: 0x00008358
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x5731B30", Offset = "0x5730730", VA = "0x185731B30")]
		[MethodImpl(256)]
		public static int lzcnt(ulong x)
		{
			return 0;
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x0000A170 File Offset: 0x00008370
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x5752EB0", Offset = "0x5751AB0", VA = "0x185752EB0")]
		[MethodImpl(256)]
		public static int tzcnt(int x)
		{
			return 0;
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x0000A188 File Offset: 0x00008388
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x5753000", Offset = "0x5751C00", VA = "0x185753000")]
		[MethodImpl(256)]
		public static int2 tzcnt(int2 x)
		{
			return default(int2);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x0000A1A0 File Offset: 0x000083A0
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x5752F00", Offset = "0x5751B00", VA = "0x185752F00")]
		[MethodImpl(256)]
		public static int3 tzcnt(int3 x)
		{
			return default(int3);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0000A1B8 File Offset: 0x000083B8
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x57530B0", Offset = "0x5751CB0", VA = "0x1857530B0")]
		[MethodImpl(256)]
		public static int4 tzcnt(int4 x)
		{
			return default(int4);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x0000A1D0 File Offset: 0x000083D0
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x5752EB0", Offset = "0x5751AB0", VA = "0x185752EB0")]
		[MethodImpl(256)]
		public static int tzcnt(uint x)
		{
			return 0;
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x0000A1E8 File Offset: 0x000083E8
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x5753000", Offset = "0x5751C00", VA = "0x185753000")]
		[MethodImpl(256)]
		public static int2 tzcnt(uint2 x)
		{
			return default(int2);
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x0000A200 File Offset: 0x00008400
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x5752F00", Offset = "0x5751B00", VA = "0x185752F00")]
		[MethodImpl(256)]
		public static int3 tzcnt(uint3 x)
		{
			return default(int3);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0000A218 File Offset: 0x00008418
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x57530B0", Offset = "0x5751CB0", VA = "0x1857530B0")]
		[MethodImpl(256)]
		public static int4 tzcnt(uint4 x)
		{
			return default(int4);
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0000A230 File Offset: 0x00008430
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x5753200", Offset = "0x5751E00", VA = "0x185753200")]
		[MethodImpl(256)]
		public static int tzcnt(long x)
		{
			return 0;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0000A248 File Offset: 0x00008448
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x5753270", Offset = "0x5751E70", VA = "0x185753270")]
		[MethodImpl(256)]
		public static int tzcnt(ulong x)
		{
			return 0;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0000A260 File Offset: 0x00008460
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x5748110", Offset = "0x5746D10", VA = "0x185748110")]
		[MethodImpl(256)]
		public static int reversebits(int x)
		{
			return 0;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0000A278 File Offset: 0x00008478
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x57482F0", Offset = "0x5746EF0", VA = "0x1857482F0")]
		[MethodImpl(256)]
		public static int2 reversebits(int2 x)
		{
			return default(int2);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0000A290 File Offset: 0x00008490
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x5748330", Offset = "0x5746F30", VA = "0x185748330")]
		[MethodImpl(256)]
		public static int3 reversebits(int3 x)
		{
			return default(int3);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0000A2A8 File Offset: 0x000084A8
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x5748180", Offset = "0x5746D80", VA = "0x185748180")]
		[MethodImpl(256)]
		public static int4 reversebits(int4 x)
		{
			return default(int4);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0000A2C0 File Offset: 0x000084C0
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x5748110", Offset = "0x5746D10", VA = "0x185748110")]
		[MethodImpl(256)]
		public static uint reversebits(uint x)
		{
			return 0U;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x5701BE0", Offset = "0x57007E0", VA = "0x185701BE0")]
		[MethodImpl(256)]
		public static uint2 reversebits(uint2 x)
		{
			return default(uint2);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000A2F0 File Offset: 0x000084F0
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x57018E0", Offset = "0x57004E0", VA = "0x1857018E0")]
		[MethodImpl(256)]
		public static uint3 reversebits(uint3 x)
		{
			return default(uint3);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000A308 File Offset: 0x00008508
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x5701410", Offset = "0x5700010", VA = "0x185701410")]
		[MethodImpl(256)]
		public static uint4 reversebits(uint4 x)
		{
			return default(uint4);
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000A320 File Offset: 0x00008520
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x5748220", Offset = "0x5746E20", VA = "0x185748220")]
		[MethodImpl(256)]
		public static long reversebits(long x)
		{
			return 0L;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000A338 File Offset: 0x00008538
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x5748220", Offset = "0x5746E20", VA = "0x185748220")]
		[MethodImpl(256)]
		public static ulong reversebits(ulong x)
		{
			return 0UL;
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000A350 File Offset: 0x00008550
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x4CD7DD0", Offset = "0x4CD69D0", VA = "0x184CD7DD0")]
		[MethodImpl(256)]
		public static int rol(int x, int n)
		{
			return 0;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000A368 File Offset: 0x00008568
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x5748740", Offset = "0x5747340", VA = "0x185748740")]
		[MethodImpl(256)]
		public static int2 rol(int2 x, int n)
		{
			return default(int2);
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000A380 File Offset: 0x00008580
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x5748450", Offset = "0x5747050", VA = "0x185748450")]
		[MethodImpl(256)]
		public static int3 rol(int3 x, int n)
		{
			return default(int3);
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000A398 File Offset: 0x00008598
		[Token(Token = "0x600058A")]
		[Address(RVA = "0x5748520", Offset = "0x5747120", VA = "0x185748520")]
		[MethodImpl(256)]
		public static int4 rol(int4 x, int n)
		{
			return default(int4);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000A3B0 File Offset: 0x000085B0
		[Token(Token = "0x600058B")]
		[Address(RVA = "0x4CD7DD0", Offset = "0x4CD69D0", VA = "0x184CD7DD0")]
		[MethodImpl(256)]
		public static uint rol(uint x, int n)
		{
			return 0U;
		}

		// Token: 0x0600058C RID: 1420 RVA: 0x0000A3C8 File Offset: 0x000085C8
		[Token(Token = "0x600058C")]
		[Address(RVA = "0x57483D0", Offset = "0x5746FD0", VA = "0x1857483D0")]
		[MethodImpl(256)]
		public static uint2 rol(uint2 x, int n)
		{
			return default(uint2);
		}

		// Token: 0x0600058D RID: 1421 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[Token(Token = "0x600058D")]
		[Address(RVA = "0x57487E0", Offset = "0x57473E0", VA = "0x1857487E0")]
		[MethodImpl(256)]
		public static uint3 rol(uint3 x, int n)
		{
			return default(uint3);
		}

		// Token: 0x0600058E RID: 1422 RVA: 0x0000A3F8 File Offset: 0x000085F8
		[Token(Token = "0x600058E")]
		[Address(RVA = "0x5748650", Offset = "0x5747250", VA = "0x185748650")]
		[MethodImpl(256)]
		public static uint4 rol(uint4 x, int n)
		{
			return default(uint4);
		}

		// Token: 0x0600058F RID: 1423 RVA: 0x0000A410 File Offset: 0x00008610
		[Token(Token = "0x600058F")]
		[Address(RVA = "0x52ACA60", Offset = "0x52AB660", VA = "0x1852ACA60")]
		[MethodImpl(256)]
		public static long rol(long x, int n)
		{
			return 0L;
		}

		// Token: 0x06000590 RID: 1424 RVA: 0x0000A428 File Offset: 0x00008628
		[Token(Token = "0x6000590")]
		[Address(RVA = "0x52ACA60", Offset = "0x52AB660", VA = "0x1852ACA60")]
		[MethodImpl(256)]
		public static ulong rol(ulong x, int n)
		{
			return 0UL;
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x0000A440 File Offset: 0x00008640
		[Token(Token = "0x6000591")]
		[Address(RVA = "0x4B4A670", Offset = "0x4B49270", VA = "0x184B4A670")]
		[MethodImpl(256)]
		public static int ror(int x, int n)
		{
			return 0;
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x0000A458 File Offset: 0x00008658
		[Token(Token = "0x6000592")]
		[Address(RVA = "0x5748AF0", Offset = "0x57476F0", VA = "0x185748AF0")]
		[MethodImpl(256)]
		public static int2 ror(int2 x, int n)
		{
			return default(int2);
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x0000A470 File Offset: 0x00008670
		[Token(Token = "0x6000593")]
		[Address(RVA = "0x5748B90", Offset = "0x5747790", VA = "0x185748B90")]
		[MethodImpl(256)]
		public static int3 ror(int3 x, int n)
		{
			return default(int3);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x0000A488 File Offset: 0x00008688
		[Token(Token = "0x6000594")]
		[Address(RVA = "0x5748910", Offset = "0x5747510", VA = "0x185748910")]
		[MethodImpl(256)]
		public static int4 ror(int4 x, int n)
		{
			return default(int4);
		}

		// Token: 0x06000595 RID: 1429 RVA: 0x0000A4A0 File Offset: 0x000086A0
		[Token(Token = "0x6000595")]
		[Address(RVA = "0x4B4A670", Offset = "0x4B49270", VA = "0x184B4A670")]
		[MethodImpl(256)]
		public static uint ror(uint x, int n)
		{
			return 0U;
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0000A4B8 File Offset: 0x000086B8
		[Token(Token = "0x6000596")]
		[Address(RVA = "0x5748890", Offset = "0x5747490", VA = "0x185748890")]
		[MethodImpl(256)]
		public static uint2 ror(uint2 x, int n)
		{
			return default(uint2);
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0000A4D0 File Offset: 0x000086D0
		[Token(Token = "0x6000597")]
		[Address(RVA = "0x5748A40", Offset = "0x5747640", VA = "0x185748A40")]
		[MethodImpl(256)]
		public static uint3 ror(uint3 x, int n)
		{
			return default(uint3);
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0000A4E8 File Offset: 0x000086E8
		[Token(Token = "0x6000598")]
		[Address(RVA = "0x5748C60", Offset = "0x5747860", VA = "0x185748C60")]
		[MethodImpl(256)]
		public static uint4 ror(uint4 x, int n)
		{
			return default(uint4);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0000A500 File Offset: 0x00008700
		[Token(Token = "0x6000599")]
		[Address(RVA = "0x4B4BE20", Offset = "0x4B4AA20", VA = "0x184B4BE20")]
		[MethodImpl(256)]
		public static long ror(long x, int n)
		{
			return 0L;
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0000A518 File Offset: 0x00008718
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x4B4BE20", Offset = "0x4B4AA20", VA = "0x184B4BE20")]
		[MethodImpl(256)]
		public static ulong ror(ulong x, int n)
		{
			return 0UL;
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0000A530 File Offset: 0x00008730
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x45BC150", Offset = "0x45BAD50", VA = "0x1845BC150")]
		[MethodImpl(256)]
		public static int ceilpow2(int x)
		{
			return 0;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0000A548 File Offset: 0x00008748
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x5709E60", Offset = "0x5708A60", VA = "0x185709E60")]
		[MethodImpl(256)]
		public static int2 ceilpow2(int2 x)
		{
			return default(int2);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0000A560 File Offset: 0x00008760
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x5709FD0", Offset = "0x5708BD0", VA = "0x185709FD0")]
		[MethodImpl(256)]
		public static int3 ceilpow2(int3 x)
		{
			return default(int3);
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0000A578 File Offset: 0x00008778
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x570A620", Offset = "0x5709220", VA = "0x18570A620")]
		[MethodImpl(256)]
		public static int4 ceilpow2(int4 x)
		{
			return default(int4);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0000A590 File Offset: 0x00008790
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x371D3F0", Offset = "0x371BFF0", VA = "0x18371D3F0")]
		[MethodImpl(256)]
		public static uint ceilpow2(uint x)
		{
			return 0U;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0000A5A8 File Offset: 0x000087A8
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x570A4B0", Offset = "0x57090B0", VA = "0x18570A4B0")]
		[MethodImpl(256)]
		public static uint2 ceilpow2(uint2 x)
		{
			return default(uint2);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0000A5C0 File Offset: 0x000087C0
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x5709CC0", Offset = "0x57088C0", VA = "0x185709CC0")]
		[MethodImpl(256)]
		public static uint3 ceilpow2(uint3 x)
		{
			return default(uint3);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0000A5D8 File Offset: 0x000087D8
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x570A210", Offset = "0x5708E10", VA = "0x18570A210")]
		[MethodImpl(256)]
		public static uint4 ceilpow2(uint4 x)
		{
			return default(uint4);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0000A5F0 File Offset: 0x000087F0
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x570A1C0", Offset = "0x5708DC0", VA = "0x18570A1C0")]
		[MethodImpl(256)]
		public static long ceilpow2(long x)
		{
			return 0L;
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0000A608 File Offset: 0x00008808
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x570A170", Offset = "0x5708D70", VA = "0x18570A170")]
		[MethodImpl(256)]
		public static ulong ceilpow2(ulong x)
		{
			return 0UL;
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0000A620 File Offset: 0x00008820
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x5709A00", Offset = "0x5708600", VA = "0x185709A00")]
		[MethodImpl(256)]
		public static int ceillog2(int x)
		{
			return 0;
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0000A638 File Offset: 0x00008838
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x5709C20", Offset = "0x5708820", VA = "0x185709C20")]
		[MethodImpl(256)]
		public static int2 ceillog2(int2 x)
		{
			return default(int2);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0000A650 File Offset: 0x00008850
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x5709A40", Offset = "0x5708640", VA = "0x185709A40")]
		[MethodImpl(256)]
		public static int3 ceillog2(int3 x)
		{
			return default(int3);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0000A668 File Offset: 0x00008868
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x5709B10", Offset = "0x5708710", VA = "0x185709B10")]
		[MethodImpl(256)]
		public static int4 ceillog2(int4 x)
		{
			return default(int4);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0000A680 File Offset: 0x00008880
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x5709A00", Offset = "0x5708600", VA = "0x185709A00")]
		[MethodImpl(256)]
		public static int ceillog2(uint x)
		{
			return 0;
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0000A698 File Offset: 0x00008898
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x5709C20", Offset = "0x5708820", VA = "0x185709C20")]
		[MethodImpl(256)]
		public static int2 ceillog2(uint2 x)
		{
			return default(int2);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0000A6B0 File Offset: 0x000088B0
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x5709A40", Offset = "0x5708640", VA = "0x185709A40")]
		[MethodImpl(256)]
		public static int3 ceillog2(uint3 x)
		{
			return default(int3);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x5709B10", Offset = "0x5708710", VA = "0x185709B10")]
		[MethodImpl(256)]
		public static int4 ceillog2(uint4 x)
		{
			return default(int4);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x571A300", Offset = "0x5718F00", VA = "0x18571A300")]
		[MethodImpl(256)]
		public static int floorlog2(int x)
		{
			return 0;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0000A6F8 File Offset: 0x000088F8
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x571A530", Offset = "0x5719130", VA = "0x18571A530")]
		[MethodImpl(256)]
		public static int2 floorlog2(int2 x)
		{
			return default(int2);
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0000A710 File Offset: 0x00008910
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x571A460", Offset = "0x5719060", VA = "0x18571A460")]
		[MethodImpl(256)]
		public static int3 floorlog2(int3 x)
		{
			return default(int3);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0000A728 File Offset: 0x00008928
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x571A350", Offset = "0x5718F50", VA = "0x18571A350")]
		[MethodImpl(256)]
		public static int4 floorlog2(int4 x)
		{
			return default(int4);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x571A300", Offset = "0x5718F00", VA = "0x18571A300")]
		[MethodImpl(256)]
		public static int floorlog2(uint x)
		{
			return 0;
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x0000A758 File Offset: 0x00008958
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x571A530", Offset = "0x5719130", VA = "0x18571A530")]
		[MethodImpl(256)]
		public static int2 floorlog2(uint2 x)
		{
			return default(int2);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x571A460", Offset = "0x5719060", VA = "0x18571A460")]
		[MethodImpl(256)]
		public static int3 floorlog2(uint3 x)
		{
			return default(int3);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0000A788 File Offset: 0x00008988
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x571A350", Offset = "0x5718F50", VA = "0x18571A350")]
		[MethodImpl(256)]
		public static int4 floorlog2(uint4 x)
		{
			return default(int4);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0000A7A0 File Offset: 0x000089A0
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x57468C0", Offset = "0x57454C0", VA = "0x1857468C0")]
		[MethodImpl(256)]
		public static float radians(float x)
		{
			return 0f;
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000A7B8 File Offset: 0x000089B8
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x5746980", Offset = "0x5745580", VA = "0x185746980")]
		[MethodImpl(256)]
		public static float2 radians(float2 x)
		{
			return default(float2);
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x0000A7D0 File Offset: 0x000089D0
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x5746930", Offset = "0x5745530", VA = "0x185746930")]
		[MethodImpl(256)]
		public static float3 radians(float3 x)
		{
			return default(float3);
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x0000A7E8 File Offset: 0x000089E8
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x57468D0", Offset = "0x57454D0", VA = "0x1857468D0")]
		[MethodImpl(256)]
		public static float4 radians(float4 x)
		{
			return default(float4);
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x0000A800 File Offset: 0x00008A00
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x5746A20", Offset = "0x5745620", VA = "0x185746A20")]
		[MethodImpl(256)]
		public static double radians(double x)
		{
			return 0.0;
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x57469B0", Offset = "0x57455B0", VA = "0x1857469B0")]
		[MethodImpl(256)]
		public static double2 radians(double2 x)
		{
			return default(double2);
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x0000A830 File Offset: 0x00008A30
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x57469E0", Offset = "0x57455E0", VA = "0x1857469E0")]
		[MethodImpl(256)]
		public static double3 radians(double3 x)
		{
			return default(double3);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0000A848 File Offset: 0x00008A48
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x5746A30", Offset = "0x5745630", VA = "0x185746A30")]
		[MethodImpl(256)]
		public static double4 radians(double4 x)
		{
			return default(double4);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0000A860 File Offset: 0x00008A60
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x570CE10", Offset = "0x570BA10", VA = "0x18570CE10")]
		[MethodImpl(256)]
		public static float degrees(float x)
		{
			return 0f;
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0000A878 File Offset: 0x00008A78
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x570CEC0", Offset = "0x570BAC0", VA = "0x18570CEC0")]
		[MethodImpl(256)]
		public static float2 degrees(float2 x)
		{
			return default(float2);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0000A890 File Offset: 0x00008A90
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x570CF50", Offset = "0x570BB50", VA = "0x18570CF50")]
		[MethodImpl(256)]
		public static float3 degrees(float3 x)
		{
			return default(float3);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x570CEF0", Offset = "0x570BAF0", VA = "0x18570CEF0")]
		[MethodImpl(256)]
		public static float4 degrees(float4 x)
		{
			return default(float4);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x570CEB0", Offset = "0x570BAB0", VA = "0x18570CEB0")]
		[MethodImpl(256)]
		public static double degrees(double x)
		{
			return 0.0;
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x570CFA0", Offset = "0x570BBA0", VA = "0x18570CFA0")]
		[MethodImpl(256)]
		public static double2 degrees(double2 x)
		{
			return default(double2);
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x570CE20", Offset = "0x570BA20", VA = "0x18570CE20")]
		[MethodImpl(256)]
		public static double3 degrees(double3 x)
		{
			return default(double3);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x0000A908 File Offset: 0x00008B08
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x570CE60", Offset = "0x570BA60", VA = "0x18570CE60")]
		[MethodImpl(256)]
		public static double4 degrees(double4 x)
		{
			return default(double4);
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x570B770", Offset = "0x570A370", VA = "0x18570B770")]
		[MethodImpl(256)]
		public static int cmin(int2 x)
		{
			return 0;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x0000A938 File Offset: 0x00008B38
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x570B5F0", Offset = "0x570A1F0", VA = "0x18570B5F0")]
		[MethodImpl(256)]
		public static int cmin(int3 x)
		{
			return 0;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x0000A950 File Offset: 0x00008B50
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x570B680", Offset = "0x570A280", VA = "0x18570B680")]
		[MethodImpl(256)]
		public static int cmin(int4 x)
		{
			return 0;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x0000A968 File Offset: 0x00008B68
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x570B6C0", Offset = "0x570A2C0", VA = "0x18570B6C0")]
		[MethodImpl(256)]
		public static uint cmin(uint2 x)
		{
			return 0U;
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x0000A980 File Offset: 0x00008B80
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x570B7B0", Offset = "0x570A3B0", VA = "0x18570B7B0")]
		[MethodImpl(256)]
		public static uint cmin(uint3 x)
		{
			return 0U;
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x0000A998 File Offset: 0x00008B98
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x570B610", Offset = "0x570A210", VA = "0x18570B610")]
		[MethodImpl(256)]
		public static uint cmin(uint4 x)
		{
			return 0U;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x570B750", Offset = "0x570A350", VA = "0x18570B750")]
		[MethodImpl(256)]
		public static float cmin(float2 x)
		{
			return 0f;
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x0000A9C8 File Offset: 0x00008BC8
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x570B6D0", Offset = "0x570A2D0", VA = "0x18570B6D0")]
		[MethodImpl(256)]
		public static float cmin(float3 x)
		{
			return 0f;
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x0000A9E0 File Offset: 0x00008BE0
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x570B700", Offset = "0x570A300", VA = "0x18570B700")]
		[MethodImpl(256)]
		public static float cmin(float4 x)
		{
			return 0f;
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x570B6A0", Offset = "0x570A2A0", VA = "0x18570B6A0")]
		[MethodImpl(256)]
		public static double cmin(double2 x)
		{
			return 0.0;
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0000AA10 File Offset: 0x00008C10
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x570B780", Offset = "0x570A380", VA = "0x18570B780")]
		[MethodImpl(256)]
		public static double cmin(double3 x)
		{
			return 0.0;
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0000AA28 File Offset: 0x00008C28
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x570B630", Offset = "0x570A230", VA = "0x18570B630")]
		[MethodImpl(256)]
		public static double cmin(double4 x)
		{
			return 0.0;
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000AA40 File Offset: 0x00008C40
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x570B570", Offset = "0x570A170", VA = "0x18570B570")]
		[MethodImpl(256)]
		public static int cmax(int2 x)
		{
			return 0;
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x0000AA58 File Offset: 0x00008C58
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x570B5A0", Offset = "0x570A1A0", VA = "0x18570B5A0")]
		[MethodImpl(256)]
		public static int cmax(int3 x)
		{
			return 0;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x0000AA70 File Offset: 0x00008C70
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x570B4C0", Offset = "0x570A0C0", VA = "0x18570B4C0")]
		[MethodImpl(256)]
		public static int cmax(int4 x)
		{
			return 0;
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x0000AA88 File Offset: 0x00008C88
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x570B440", Offset = "0x570A040", VA = "0x18570B440")]
		[MethodImpl(256)]
		public static uint cmax(uint2 x)
		{
			return 0U;
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x570B550", Offset = "0x570A150", VA = "0x18570B550")]
		[MethodImpl(256)]
		public static uint cmax(uint3 x)
		{
			return 0U;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000AAB8 File Offset: 0x00008CB8
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x570B4E0", Offset = "0x570A0E0", VA = "0x18570B4E0")]
		[MethodImpl(256)]
		public static uint cmax(uint4 x)
		{
			return 0U;
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0000AAD0 File Offset: 0x00008CD0
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x570B4A0", Offset = "0x570A0A0", VA = "0x18570B4A0")]
		[MethodImpl(256)]
		public static float cmax(float2 x)
		{
			return 0f;
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000AAE8 File Offset: 0x00008CE8
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x570B410", Offset = "0x570A010", VA = "0x18570B410")]
		[MethodImpl(256)]
		public static float cmax(float3 x)
		{
			return 0f;
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000AB00 File Offset: 0x00008D00
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x570B450", Offset = "0x570A050", VA = "0x18570B450")]
		[MethodImpl(256)]
		public static float cmax(float4 x)
		{
			return 0f;
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0000AB18 File Offset: 0x00008D18
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x570B580", Offset = "0x570A180", VA = "0x18570B580")]
		[MethodImpl(256)]
		public static double cmax(double2 x)
		{
			return 0.0;
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000AB30 File Offset: 0x00008D30
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x570B5C0", Offset = "0x570A1C0", VA = "0x18570B5C0")]
		[MethodImpl(256)]
		public static double cmax(double3 x)
		{
			return 0.0;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000AB48 File Offset: 0x00008D48
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x570B500", Offset = "0x570A100", VA = "0x18570B500")]
		[MethodImpl(256)]
		public static double cmax(double4 x)
		{
			return 0.0;
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000AB60 File Offset: 0x00008D60
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x570CD90", Offset = "0x570B990", VA = "0x18570CD90")]
		[MethodImpl(256)]
		public static int csum(int2 x)
		{
			return 0;
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000AB78 File Offset: 0x00008D78
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1BB7E20", Offset = "0x1BB6A20", VA = "0x181BB7E20")]
		[MethodImpl(256)]
		public static int csum(int3 x)
		{
			return 0;
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000AB90 File Offset: 0x00008D90
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x375DB00", Offset = "0x375C700", VA = "0x18375DB00")]
		[MethodImpl(256)]
		public static int csum(int4 x)
		{
			return 0;
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0000ABA8 File Offset: 0x00008DA8
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x570CD90", Offset = "0x570B990", VA = "0x18570CD90")]
		[MethodImpl(256)]
		public static uint csum(uint2 x)
		{
			return 0U;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1BB7E20", Offset = "0x1BB6A20", VA = "0x181BB7E20")]
		[MethodImpl(256)]
		public static uint csum(uint3 x)
		{
			return 0U;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x375DB00", Offset = "0x375C700", VA = "0x18375DB00")]
		[MethodImpl(256)]
		public static uint csum(uint4 x)
		{
			return 0U;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000ABF0 File Offset: 0x00008DF0
		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x570CDE0", Offset = "0x570B9E0", VA = "0x18570CDE0")]
		[MethodImpl(256)]
		public static float csum(float2 x)
		{
			return 0f;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000AC08 File Offset: 0x00008E08
		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x570CE00", Offset = "0x570BA00", VA = "0x18570CE00")]
		[MethodImpl(256)]
		public static float csum(float3 x)
		{
			return 0f;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0000AC20 File Offset: 0x00008E20
		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x570CD70", Offset = "0x570B970", VA = "0x18570CD70")]
		[MethodImpl(256)]
		public static float csum(float4 x)
		{
			return 0f;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0000AC38 File Offset: 0x00008E38
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x570CDB0", Offset = "0x570B9B0", VA = "0x18570CDB0")]
		[MethodImpl(256)]
		public static double csum(double2 x)
		{
			return 0.0;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0000AC50 File Offset: 0x00008E50
		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x570CDA0", Offset = "0x570B9A0", VA = "0x18570CDA0")]
		[MethodImpl(256)]
		public static double csum(double3 x)
		{
			return 0.0;
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0000AC68 File Offset: 0x00008E68
		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x570CDC0", Offset = "0x570B9C0", VA = "0x18570CDC0")]
		[MethodImpl(256)]
		public static double csum(double4 x)
		{
			return 0.0;
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000AC80 File Offset: 0x00008E80
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x570B850", Offset = "0x570A450", VA = "0x18570B850")]
		[MethodImpl(256)]
		public unsafe static int compress(int* output, int index, int4 val, bool4 mask)
		{
			return 0;
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0000AC98 File Offset: 0x00008E98
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x570B7D0", Offset = "0x570A3D0", VA = "0x18570B7D0")]
		[MethodImpl(256)]
		public unsafe static int compress(uint* output, int index, uint4 val, bool4 mask)
		{
			return 0;
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0000ACB0 File Offset: 0x00008EB0
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x570B7D0", Offset = "0x570A3D0", VA = "0x18570B7D0")]
		[MethodImpl(256)]
		public unsafe static int compress(float* output, int index, float4 val, bool4 mask)
		{
			return 0;
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0000ACC8 File Offset: 0x00008EC8
		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x5713750", Offset = "0x5712350", VA = "0x185713750")]
		[MethodImpl(256)]
		public static float f16tof32(uint x)
		{
			return 0f;
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0000ACE0 File Offset: 0x00008EE0
		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x5713A40", Offset = "0x5712640", VA = "0x185713A40")]
		[MethodImpl(256)]
		public static float2 f16tof32(uint2 x)
		{
			return default(float2);
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000ACF8 File Offset: 0x00008EF8
		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x57137C0", Offset = "0x57123C0", VA = "0x1857137C0")]
		[MethodImpl(256)]
		public static float3 f16tof32(uint3 x)
		{
			return default(float3);
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0000AD10 File Offset: 0x00008F10
		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x5713CA0", Offset = "0x57128A0", VA = "0x185713CA0")]
		[MethodImpl(256)]
		public static float4 f16tof32(uint4 x)
		{
			return default(float4);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000AD28 File Offset: 0x00008F28
		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x5700610", Offset = "0x56FF210", VA = "0x185700610")]
		[MethodImpl(256)]
		public static uint f32tof16(float x)
		{
			return 0U;
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0000AD40 File Offset: 0x00008F40
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x57140D0", Offset = "0x5712CD0", VA = "0x1857140D0")]
		[MethodImpl(256)]
		public static uint2 f32tof16(float2 x)
		{
			return default(uint2);
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000AD58 File Offset: 0x00008F58
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x57143E0", Offset = "0x5712FE0", VA = "0x1857143E0")]
		[MethodImpl(256)]
		public static uint3 f32tof16(float3 x)
		{
			return default(uint3);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0000AD70 File Offset: 0x00008F70
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x57146F0", Offset = "0x57132F0", VA = "0x1857146F0")]
		[MethodImpl(256)]
		public static uint4 f32tof16(float4 x)
		{
			return default(uint4);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0000AD88 File Offset: 0x00008F88
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x571F7A0", Offset = "0x571E3A0", VA = "0x18571F7A0")]
		public unsafe static uint hash(void* pBuffer, int numBytes, uint seed = 0U)
		{
			return 0U;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x5755F10", Offset = "0x5754B10", VA = "0x185755F10")]
		[MethodImpl(256)]
		public static float3 up()
		{
			return default(float3);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000ADB8 File Offset: 0x00008FB8
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x5711D80", Offset = "0x5710980", VA = "0x185711D80")]
		[MethodImpl(256)]
		public static float3 down()
		{
			return default(float3);
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0000ADD0 File Offset: 0x00008FD0
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x571AB00", Offset = "0x5719700", VA = "0x18571AB00")]
		[MethodImpl(256)]
		public static float3 forward()
		{
			return default(float3);
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0000ADE8 File Offset: 0x00008FE8
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x57088A0", Offset = "0x57074A0", VA = "0x1857088A0")]
		[MethodImpl(256)]
		public static float3 back()
		{
			return default(float3);
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000AE00 File Offset: 0x00009000
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x572F650", Offset = "0x572E250", VA = "0x18572F650")]
		[MethodImpl(256)]
		public static float3 left()
		{
			return default(float3);
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0000AE18 File Offset: 0x00009018
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x57483C0", Offset = "0x5746FC0", VA = "0x1857483C0")]
		[MethodImpl(256)]
		public static float3 right()
		{
			return default(float3);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000AE30 File Offset: 0x00009030
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x5755E00", Offset = "0x5754A00", VA = "0x185755E00")]
		[MethodImpl(256)]
		internal static float4 unpacklo(float4 a, float4 b)
		{
			return default(float4);
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000AE48 File Offset: 0x00009048
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x5703240", Offset = "0x5701E40", VA = "0x185703240")]
		[MethodImpl(256)]
		internal static double4 unpacklo(double4 a, double4 b)
		{
			return default(double4);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0000AE60 File Offset: 0x00009060
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x5755CF0", Offset = "0x57548F0", VA = "0x185755CF0")]
		[MethodImpl(256)]
		internal static float4 unpackhi(float4 a, float4 b)
		{
			return default(float4);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0000AE78 File Offset: 0x00009078
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x57030F0", Offset = "0x5701CF0", VA = "0x1857030F0")]
		[MethodImpl(256)]
		internal static double4 unpackhi(double4 a, double4 b)
		{
			return default(double4);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0000AE90 File Offset: 0x00009090
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x57334B0", Offset = "0x57320B0", VA = "0x1857334B0")]
		[MethodImpl(256)]
		internal static float4 movelh(float4 a, float4 b)
		{
			return default(float4);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0000AEA8 File Offset: 0x000090A8
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x5700F30", Offset = "0x56FFB30", VA = "0x185700F30")]
		[MethodImpl(256)]
		internal static double4 movelh(double4 a, double4 b)
		{
			return default(double4);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0000AEC0 File Offset: 0x000090C0
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x57333A0", Offset = "0x5731FA0", VA = "0x1857333A0")]
		[MethodImpl(256)]
		internal static float4 movehl(float4 a, float4 b)
		{
			return default(float4);
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0000AED8 File Offset: 0x000090D8
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x5700DE0", Offset = "0x56FF9E0", VA = "0x185700DE0")]
		[MethodImpl(256)]
		internal static double4 movehl(double4 a, double4 b)
		{
			return default(double4);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x571A9B0", Offset = "0x57195B0", VA = "0x18571A9B0")]
		[MethodImpl(256)]
		internal static uint fold_to_uint(double x)
		{
			return 0U;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0000AF08 File Offset: 0x00009108
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x571A870", Offset = "0x5719470", VA = "0x18571A870")]
		[MethodImpl(256)]
		internal static uint2 fold_to_uint(double2 x)
		{
			return default(uint2);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0000AF20 File Offset: 0x00009120
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x571A940", Offset = "0x5719540", VA = "0x18571A940")]
		[MethodImpl(256)]
		internal static uint3 fold_to_uint(double3 x)
		{
			return default(uint3);
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000AF38 File Offset: 0x00009138
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x571A8B0", Offset = "0x57194B0", VA = "0x18571A8B0")]
		[MethodImpl(256)]
		internal static uint4 fold_to_uint(double4 x)
		{
			return default(uint4);
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x57178F0", Offset = "0x57164F0", VA = "0x1857178F0")]
		[MethodImpl(256)]
		public static float3x3 float3x3(float4x4 f4x4)
		{
			return default(float3x3);
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0000AF68 File Offset: 0x00009168
		[Token(Token = "0x6000608")]
		[Address(RVA = "0x5717A30", Offset = "0x5716630", VA = "0x185717A30")]
		[MethodImpl(256)]
		public static float3x3 float3x3(quaternion rotation)
		{
			return default(float3x3);
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000AF80 File Offset: 0x00009180
		[Token(Token = "0x6000609")]
		[Address(RVA = "0x5719D80", Offset = "0x5718980", VA = "0x185719D80")]
		[MethodImpl(256)]
		public static float4x4 float4x4(float3x3 rotation, float3 translation)
		{
			return default(float4x4);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000AF98 File Offset: 0x00009198
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x5719E80", Offset = "0x5718A80", VA = "0x185719E80")]
		[MethodImpl(256)]
		public static float4x4 float4x4(quaternion rotation, float3 translation)
		{
			return default(float4x4);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000AFB0 File Offset: 0x000091B0
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x5719B50", Offset = "0x5718750", VA = "0x185719B50")]
		[MethodImpl(256)]
		public static float4x4 float4x4(RigidTransform transform)
		{
			return default(float4x4);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x5744F50", Offset = "0x5743B50", VA = "0x185744F50")]
		[MethodImpl(256)]
		public static float3x3 orthonormalize(float3x3 i)
		{
			return default(float3x3);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x570DDF0", Offset = "0x570C9F0", VA = "0x18570DDF0")]
		[MethodImpl(256)]
		public static float mul(float a, float b)
		{
			return 0f;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000AFF8 File Offset: 0x000091F8
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x570DED0", Offset = "0x570CAD0", VA = "0x18570DED0")]
		[MethodImpl(256)]
		public static float mul(float2 a, float2 b)
		{
			return 0f;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0000B010 File Offset: 0x00009210
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x5736590", Offset = "0x5735190", VA = "0x185736590")]
		[MethodImpl(256)]
		public static float2 mul(float2 a, float2x2 b)
		{
			return default(float2);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0000B028 File Offset: 0x00009228
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x573F980", Offset = "0x573E580", VA = "0x18573F980")]
		[MethodImpl(256)]
		public static float3 mul(float2 a, float2x3 b)
		{
			return default(float3);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0000B040 File Offset: 0x00009240
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x5742C60", Offset = "0x5741860", VA = "0x185742C60")]
		[MethodImpl(256)]
		public static float4 mul(float2 a, float2x4 b)
		{
			return default(float4);
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0000B058 File Offset: 0x00009258
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x570DEA0", Offset = "0x570CAA0", VA = "0x18570DEA0")]
		[MethodImpl(256)]
		public static float mul(float3 a, float3 b)
		{
			return 0f;
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0000B070 File Offset: 0x00009270
		[Token(Token = "0x6000613")]
		[Address(RVA = "0x57378A0", Offset = "0x57364A0", VA = "0x1857378A0")]
		[MethodImpl(256)]
		public static float2 mul(float3 a, float3x2 b)
		{
			return default(float2);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0000B088 File Offset: 0x00009288
		[Token(Token = "0x6000614")]
		[Address(RVA = "0x5737660", Offset = "0x5736260", VA = "0x185737660")]
		[MethodImpl(256)]
		public static float3 mul(float3 a, float3x3 b)
		{
			return default(float3);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0000B0A0 File Offset: 0x000092A0
		[Token(Token = "0x6000615")]
		[Address(RVA = "0x573AA70", Offset = "0x5739670", VA = "0x18573AA70")]
		[MethodImpl(256)]
		public static float4 mul(float3 a, float3x4 b)
		{
			return default(float4);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000B0B8 File Offset: 0x000092B8
		[Token(Token = "0x6000616")]
		[Address(RVA = "0x57005D0", Offset = "0x56FF1D0", VA = "0x1857005D0")]
		[MethodImpl(256)]
		public static float mul(float4 a, float4 b)
		{
			return 0f;
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0000B0D0 File Offset: 0x000092D0
		[Token(Token = "0x6000617")]
		[Address(RVA = "0x573F850", Offset = "0x573E450", VA = "0x18573F850")]
		[MethodImpl(256)]
		public static float2 mul(float4 a, float4x2 b)
		{
			return default(float2);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0000B0E8 File Offset: 0x000092E8
		[Token(Token = "0x6000618")]
		[Address(RVA = "0x5733BB0", Offset = "0x57327B0", VA = "0x185733BB0")]
		[MethodImpl(256)]
		public static float3 mul(float4 a, float4x3 b)
		{
			return default(float3);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000B100 File Offset: 0x00009300
		[Token(Token = "0x6000619")]
		[Address(RVA = "0x5743550", Offset = "0x5742150", VA = "0x185743550")]
		[MethodImpl(256)]
		public static float4 mul(float4 a, float4x4 b)
		{
			return default(float4);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0000B118 File Offset: 0x00009318
		[Token(Token = "0x600061A")]
		[Address(RVA = "0x5735330", Offset = "0x5733F30", VA = "0x185735330")]
		[MethodImpl(256)]
		public static float2 mul(float2x2 a, float2 b)
		{
			return default(float2);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0000B130 File Offset: 0x00009330
		[Token(Token = "0x600061B")]
		[Address(RVA = "0x573F8D0", Offset = "0x573E4D0", VA = "0x18573F8D0")]
		[MethodImpl(256)]
		public static float2x2 mul(float2x2 a, float2x2 b)
		{
			return default(float2x2);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0000B148 File Offset: 0x00009348
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x57410B0", Offset = "0x573FCB0", VA = "0x1857410B0")]
		[MethodImpl(256)]
		public static float2x3 mul(float2x2 a, float2x3 b)
		{
			return default(float2x3);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0000B160 File Offset: 0x00009360
		[Token(Token = "0x600061D")]
		[Address(RVA = "0x57335C0", Offset = "0x57321C0", VA = "0x1857335C0")]
		[MethodImpl(256)]
		public static float2x4 mul(float2x2 a, float2x4 b)
		{
			return default(float2x4);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0000B178 File Offset: 0x00009378
		[Token(Token = "0x600061E")]
		[Address(RVA = "0x5735F80", Offset = "0x5734B80", VA = "0x185735F80")]
		[MethodImpl(256)]
		public static float2 mul(float2x3 a, float3 b)
		{
			return default(float2);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0000B190 File Offset: 0x00009390
		[Token(Token = "0x600061F")]
		[Address(RVA = "0x57365D0", Offset = "0x57351D0", VA = "0x1857365D0")]
		[MethodImpl(256)]
		public static float2x2 mul(float2x3 a, float3x2 b)
		{
			return default(float2x2);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0000B1A8 File Offset: 0x000093A8
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x573D460", Offset = "0x573C060", VA = "0x18573D460")]
		[MethodImpl(256)]
		public static float2x3 mul(float2x3 a, float3x3 b)
		{
			return default(float2x3);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0000B1C0 File Offset: 0x000093C0
		[Token(Token = "0x6000621")]
		[Address(RVA = "0x5734F00", Offset = "0x5733B00", VA = "0x185734F00")]
		[MethodImpl(256)]
		public static float2x4 mul(float2x3 a, float3x4 b)
		{
			return default(float2x4);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0000B1D8 File Offset: 0x000093D8
		[Token(Token = "0x6000622")]
		[Address(RVA = "0x573ED60", Offset = "0x573D960", VA = "0x18573ED60")]
		[MethodImpl(256)]
		public static float2 mul(float2x4 a, float4 b)
		{
			return default(float2);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000B1F0 File Offset: 0x000093F0
		[Token(Token = "0x6000623")]
		[Address(RVA = "0x5733810", Offset = "0x5732410", VA = "0x185733810")]
		[MethodImpl(256)]
		public static float2x2 mul(float2x4 a, float4x2 b)
		{
			return default(float2x2);
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000B208 File Offset: 0x00009408
		[Token(Token = "0x6000624")]
		[Address(RVA = "0x573D0F0", Offset = "0x573BCF0", VA = "0x18573D0F0")]
		[MethodImpl(256)]
		public static float2x3 mul(float2x4 a, float4x3 b)
		{
			return default(float2x3);
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0000B220 File Offset: 0x00009420
		[Token(Token = "0x6000625")]
		[Address(RVA = "0x573DA40", Offset = "0x573C640", VA = "0x18573DA40")]
		[MethodImpl(256)]
		public static float2x4 mul(float2x4 a, float4x4 b)
		{
			return default(float2x4);
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0000B238 File Offset: 0x00009438
		[Token(Token = "0x6000626")]
		[Address(RVA = "0x57378F0", Offset = "0x57364F0", VA = "0x1857378F0")]
		[MethodImpl(256)]
		public static float3 mul(float3x2 a, float2 b)
		{
			return default(float3);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000B250 File Offset: 0x00009450
		[Token(Token = "0x6000627")]
		[Address(RVA = "0x573F0B0", Offset = "0x573DCB0", VA = "0x18573F0B0")]
		[MethodImpl(256)]
		public static float3x2 mul(float3x2 a, float2x2 b)
		{
			return default(float3x2);
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0000B268 File Offset: 0x00009468
		[Token(Token = "0x6000628")]
		[Address(RVA = "0x5743670", Offset = "0x5742270", VA = "0x185743670")]
		[MethodImpl(256)]
		public static float3x3 mul(float3x2 a, float2x3 b)
		{
			return default(float3x3);
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000B280 File Offset: 0x00009480
		[Token(Token = "0x6000629")]
		[Address(RVA = "0x5733950", Offset = "0x5732550", VA = "0x185733950")]
		[MethodImpl(256)]
		public static float3x4 mul(float3x2 a, float2x4 b)
		{
			return default(float3x4);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0000B298 File Offset: 0x00009498
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x57384F0", Offset = "0x57370F0", VA = "0x1857384F0")]
		[MethodImpl(256)]
		public static float3 mul(float3x3 a, float3 b)
		{
			return default(float3);
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000B2B0 File Offset: 0x000094B0
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x5741ED0", Offset = "0x5740AD0", VA = "0x185741ED0")]
		[MethodImpl(256)]
		public static float3x2 mul(float3x3 a, float3x2 b)
		{
			return default(float3x2);
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0000B2C8 File Offset: 0x000094C8
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x5734290", Offset = "0x5732E90", VA = "0x185734290")]
		[MethodImpl(256)]
		public static float3x3 mul(float3x3 a, float3x3 b)
		{
			return default(float3x3);
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0000B2E0 File Offset: 0x000094E0
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x573BB50", Offset = "0x573A750", VA = "0x18573BB50")]
		[MethodImpl(256)]
		public static float3x4 mul(float3x3 a, float3x4 b)
		{
			return default(float3x4);
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0000B2F8 File Offset: 0x000094F8
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x573B2B0", Offset = "0x5739EB0", VA = "0x18573B2B0")]
		[MethodImpl(256)]
		public static float3 mul(float3x4 a, float4 b)
		{
			return default(float3);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0000B310 File Offset: 0x00009510
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x5743230", Offset = "0x5741E30", VA = "0x185743230")]
		[MethodImpl(256)]
		public static float3x2 mul(float3x4 a, float4x2 b)
		{
			return default(float3x2);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0000B328 File Offset: 0x00009528
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x573AB40", Offset = "0x5739740", VA = "0x18573AB40")]
		[MethodImpl(256)]
		public static float3x3 mul(float3x4 a, float4x3 b)
		{
			return default(float3x3);
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0000B340 File Offset: 0x00009540
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x57356C0", Offset = "0x57342C0", VA = "0x1857356C0")]
		[MethodImpl(256)]
		public static float3x4 mul(float3x4 a, float4x4 b)
		{
			return default(float3x4);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x0000B358 File Offset: 0x00009558
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x573C8A0", Offset = "0x573B4A0", VA = "0x18573C8A0")]
		[MethodImpl(256)]
		public static float4 mul(float4x2 a, float2 b)
		{
			return default(float4);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0000B370 File Offset: 0x00009570
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x573D2C0", Offset = "0x573BEC0", VA = "0x18573D2C0")]
		[MethodImpl(256)]
		public static float4x2 mul(float4x2 a, float2x2 b)
		{
			return default(float4x2);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x0000B388 File Offset: 0x00009588
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x57398D0", Offset = "0x57384D0", VA = "0x1857398D0")]
		[MethodImpl(256)]
		public static float4x3 mul(float4x2 a, float2x3 b)
		{
			return default(float4x3);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x573BF60", Offset = "0x573AB60", VA = "0x18573BF60")]
		[MethodImpl(256)]
		public static float4x4 mul(float4x2 a, float2x4 b)
		{
			return default(float4x4);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x573FDE0", Offset = "0x573E9E0", VA = "0x18573FDE0")]
		[MethodImpl(256)]
		public static float4 mul(float4x3 a, float3 b)
		{
			return default(float4);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x0000B3D0 File Offset: 0x000095D0
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x5740440", Offset = "0x573F040", VA = "0x185740440")]
		[MethodImpl(256)]
		public static float4x2 mul(float4x3 a, float3x2 b)
		{
			return default(float4x2);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0000B3E8 File Offset: 0x000095E8
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x573E5D0", Offset = "0x573D1D0", VA = "0x18573E5D0")]
		[MethodImpl(256)]
		public static float4x3 mul(float4x3 a, float3x3 b)
		{
			return default(float4x3);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x0000B400 File Offset: 0x00009600
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x5740C40", Offset = "0x573F840", VA = "0x185740C40")]
		[MethodImpl(256)]
		public static float4x4 mul(float4x3 a, float3x4 b)
		{
			return default(float4x4);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x0000B418 File Offset: 0x00009618
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x5733C80", Offset = "0x5732880", VA = "0x185733C80")]
		[MethodImpl(256)]
		public static float4 mul(float4x4 a, float4 b)
		{
			return default(float4);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x0000B430 File Offset: 0x00009630
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x5736FB0", Offset = "0x5735BB0", VA = "0x185736FB0")]
		[MethodImpl(256)]
		public static float4x2 mul(float4x4 a, float4x2 b)
		{
			return default(float4x2);
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x0000B448 File Offset: 0x00009648
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x573E920", Offset = "0x573D520", VA = "0x18573E920")]
		[MethodImpl(256)]
		public static float4x3 mul(float4x4 a, float4x3 b)
		{
			return default(float4x3);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x0000B460 File Offset: 0x00009660
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x5743830", Offset = "0x5742430", VA = "0x185743830")]
		[MethodImpl(256)]
		public static float4x4 mul(float4x4 a, float4x4 b)
		{
			return default(float4x4);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x0000B478 File Offset: 0x00009678
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x570DDE0", Offset = "0x570C9E0", VA = "0x18570DDE0")]
		[MethodImpl(256)]
		public static double mul(double a, double b)
		{
			return 0.0;
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x0000B490 File Offset: 0x00009690
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x570DE80", Offset = "0x570CA80", VA = "0x18570DE80")]
		[MethodImpl(256)]
		public static double mul(double2 a, double2 b)
		{
			return 0.0;
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0000B4A8 File Offset: 0x000096A8
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x5741AC0", Offset = "0x57406C0", VA = "0x185741AC0")]
		[MethodImpl(256)]
		public static double2 mul(double2 a, double2x2 b)
		{
			return default(double2);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x0000B4C0 File Offset: 0x000096C0
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x5737F90", Offset = "0x5736B90", VA = "0x185737F90")]
		[MethodImpl(256)]
		public static double3 mul(double2 a, double2x3 b)
		{
			return default(double3);
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x0000B4D8 File Offset: 0x000096D8
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x5738630", Offset = "0x5737230", VA = "0x185738630")]
		[MethodImpl(256)]
		public static double4 mul(double2 a, double2x4 b)
		{
			return default(double4);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x570DE00", Offset = "0x570CA00", VA = "0x18570DE00")]
		[MethodImpl(256)]
		public static double mul(double3 a, double3 b)
		{
			return 0.0;
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0000B508 File Offset: 0x00009708
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x57383D0", Offset = "0x5736FD0", VA = "0x1857383D0")]
		[MethodImpl(256)]
		public static double2 mul(double3 a, double3x2 b)
		{
			return default(double2);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000B520 File Offset: 0x00009720
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x5739010", Offset = "0x5737C10", VA = "0x185739010")]
		[MethodImpl(256)]
		public static double3 mul(double3 a, double3x3 b)
		{
			return default(double3);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0000B538 File Offset: 0x00009738
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x5737590", Offset = "0x5736190", VA = "0x185737590")]
		[MethodImpl(256)]
		public static double4 mul(double3 a, double3x4 b)
		{
			return default(double4);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0000B550 File Offset: 0x00009750
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x570DD50", Offset = "0x570C950", VA = "0x18570DD50")]
		[MethodImpl(256)]
		public static double mul(double4 a, double4 b)
		{
			return 0.0;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0000B568 File Offset: 0x00009768
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x573A900", Offset = "0x5739500", VA = "0x18573A900")]
		[MethodImpl(256)]
		public static double2 mul(double4 a, double4x2 b)
		{
			return default(double2);
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000B580 File Offset: 0x00009780
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x5734DB0", Offset = "0x57339B0", VA = "0x185734DB0")]
		[MethodImpl(256)]
		public static double3 mul(double4 a, double4x3 b)
		{
			return default(double3);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0000B598 File Offset: 0x00009798
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x5743FD0", Offset = "0x5742BD0", VA = "0x185743FD0")]
		[MethodImpl(256)]
		public static double4 mul(double4 a, double4x4 b)
		{
			return default(double4);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000B5B0 File Offset: 0x000097B0
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x573CB10", Offset = "0x573B710", VA = "0x18573CB10")]
		[MethodImpl(256)]
		public static double2 mul(double2x2 a, double2 b)
		{
			return default(double2);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0000B5C8 File Offset: 0x000097C8
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x573B3F0", Offset = "0x5739FF0", VA = "0x18573B3F0")]
		[MethodImpl(256)]
		public static double2x2 mul(double2x2 a, double2x2 b)
		{
			return default(double2x2);
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000B5E0 File Offset: 0x000097E0
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x573D5D0", Offset = "0x573C1D0", VA = "0x18573D5D0")]
		[MethodImpl(256)]
		public static double2x3 mul(double2x2 a, double2x3 b)
		{
			return default(double2x3);
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0000B5F8 File Offset: 0x000097F8
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x573CDB0", Offset = "0x573B9B0", VA = "0x18573CDB0")]
		[MethodImpl(256)]
		public static double2x4 mul(double2x2 a, double2x4 b)
		{
			return default(double2x4);
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x0000B610 File Offset: 0x00009810
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x5733E00", Offset = "0x5732A00", VA = "0x185733E00")]
		[MethodImpl(256)]
		public static double2 mul(double2x3 a, double3 b)
		{
			return default(double2);
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0000B628 File Offset: 0x00009828
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x573BE80", Offset = "0x573AA80", VA = "0x18573BE80")]
		[MethodImpl(256)]
		public static double2x2 mul(double2x3 a, double3x2 b)
		{
			return default(double2x2);
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x0000B640 File Offset: 0x00009840
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x5741950", Offset = "0x5740550", VA = "0x185741950")]
		[MethodImpl(256)]
		public static double2x3 mul(double2x3 a, double3x3 b)
		{
			return default(double2x3);
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0000B658 File Offset: 0x00009858
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x573E010", Offset = "0x573CC10", VA = "0x18573E010")]
		[MethodImpl(256)]
		public static double2x4 mul(double2x3 a, double3x4 b)
		{
			return default(double2x4);
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x0000B670 File Offset: 0x00009870
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x5742BE0", Offset = "0x57417E0", VA = "0x185742BE0")]
		[MethodImpl(256)]
		public static double2 mul(double2x4 a, double4 b)
		{
			return default(double2);
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000B688 File Offset: 0x00009888
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x5735E40", Offset = "0x5734A40", VA = "0x185735E40")]
		[MethodImpl(256)]
		public static double2x2 mul(double2x4 a, double4x2 b)
		{
			return default(double2x2);
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x5741CF0", Offset = "0x57408F0", VA = "0x185741CF0")]
		[MethodImpl(256)]
		public static double2x3 mul(double2x4 a, double4x3 b)
		{
			return default(double2x3);
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0000B6B8 File Offset: 0x000098B8
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x57362C0", Offset = "0x5734EC0", VA = "0x1857362C0")]
		[MethodImpl(256)]
		public static double2x4 mul(double2x4 a, double4x4 b)
		{
			return default(double2x4);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0000B6D0 File Offset: 0x000098D0
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x573B6C0", Offset = "0x573A2C0", VA = "0x18573B6C0")]
		[MethodImpl(256)]
		public static double3 mul(double3x2 a, double2 b)
		{
			return default(double3);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0000B6E8 File Offset: 0x000098E8
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x5743430", Offset = "0x5742030", VA = "0x185743430")]
		[MethodImpl(256)]
		public static double3x2 mul(double3x2 a, double2x2 b)
		{
			return default(double3x2);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0000B700 File Offset: 0x00009900
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x5737700", Offset = "0x5736300", VA = "0x185737700")]
		[MethodImpl(256)]
		public static double3x3 mul(double3x2 a, double2x3 b)
		{
			return default(double3x3);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0000B718 File Offset: 0x00009918
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x5743D80", Offset = "0x5742980", VA = "0x185743D80")]
		[MethodImpl(256)]
		public static double3x4 mul(double3x2 a, double2x4 b)
		{
			return default(double3x4);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0000B730 File Offset: 0x00009930
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x573FD30", Offset = "0x573E930", VA = "0x18573FD30")]
		[MethodImpl(256)]
		public static double3 mul(double3x3 a, double3 b)
		{
			return default(double3);
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x0000B748 File Offset: 0x00009948
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x5737980", Offset = "0x5736580", VA = "0x185737980")]
		[MethodImpl(256)]
		public static double3x2 mul(double3x3 a, double3x2 b)
		{
			return default(double3x2);
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x0000B760 File Offset: 0x00009960
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x573B490", Offset = "0x573A090", VA = "0x18573B490")]
		[MethodImpl(256)]
		public static double3x3 mul(double3x3 a, double3x3 b)
		{
			return default(double3x3);
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0000B778 File Offset: 0x00009978
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x5737280", Offset = "0x5735E80", VA = "0x185737280")]
		[MethodImpl(256)]
		public static double3x4 mul(double3x3 a, double3x4 b)
		{
			return default(double3x4);
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x0000B790 File Offset: 0x00009990
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x5739220", Offset = "0x5737E20", VA = "0x185739220")]
		[MethodImpl(256)]
		public static double3 mul(double3x4 a, double4 b)
		{
			return default(double3);
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x0000B7A8 File Offset: 0x000099A8
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x573C280", Offset = "0x573AE80", VA = "0x18573C280")]
		[MethodImpl(256)]
		public static double3x2 mul(double3x4 a, double4x2 b)
		{
			return default(double3x2);
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x0000B7C0 File Offset: 0x000099C0
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x57421D0", Offset = "0x5740DD0", VA = "0x1857421D0")]
		[MethodImpl(256)]
		public static double3x3 mul(double3x4 a, double4x3 b)
		{
			return default(double3x3);
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x5742E60", Offset = "0x5741A60", VA = "0x185742E60")]
		[MethodImpl(256)]
		public static double3x4 mul(double3x4 a, double4x4 b)
		{
			return default(double3x4);
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x573DF10", Offset = "0x573CB10", VA = "0x18573DF10")]
		[MethodImpl(256)]
		public static double4 mul(double4x2 a, double2 b)
		{
			return default(double4);
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0000B808 File Offset: 0x00009A08
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x5742060", Offset = "0x5740C60", VA = "0x185742060")]
		[MethodImpl(256)]
		public static double4x2 mul(double4x2 a, double2x2 b)
		{
			return default(double4x2);
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x0000B820 File Offset: 0x00009A20
		[Token(Token = "0x6000665")]
		[Address(RVA = "0x573F1E0", Offset = "0x573DDE0", VA = "0x18573F1E0")]
		[MethodImpl(256)]
		public static double4x3 mul(double4x2 a, double2x3 b)
		{
			return default(double4x3);
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x0000B838 File Offset: 0x00009A38
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x57440E0", Offset = "0x5742CE0", VA = "0x1857440E0")]
		[MethodImpl(256)]
		public static double4x4 mul(double4x2 a, double2x4 b)
		{
			return default(double4x4);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x0000B850 File Offset: 0x00009A50
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x573AE30", Offset = "0x5739A30", VA = "0x18573AE30")]
		[MethodImpl(256)]
		public static double4 mul(double4x3 a, double3 b)
		{
			return default(double4);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x0000B868 File Offset: 0x00009A68
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x573CF00", Offset = "0x573BB00", VA = "0x18573CF00")]
		[MethodImpl(256)]
		public static double4x2 mul(double4x3 a, double3x2 b)
		{
			return default(double4x2);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x0000B880 File Offset: 0x00009A80
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x573EDD0", Offset = "0x573D9D0", VA = "0x18573EDD0")]
		[MethodImpl(256)]
		public static double4x3 mul(double4x3 a, double3x3 b)
		{
			return default(double4x3);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x0000B898 File Offset: 0x00009A98
		[Token(Token = "0x600066A")]
		[Address(RVA = "0x5737FF0", Offset = "0x5736BF0", VA = "0x185737FF0")]
		[MethodImpl(256)]
		public static double4x4 mul(double4x3 a, double3x4 b)
		{
			return default(double4x4);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x5735110", Offset = "0x5733D10", VA = "0x185735110")]
		[MethodImpl(256)]
		public static double4 mul(double4x4 a, double4 b)
		{
			return default(double4);
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x0000B8C8 File Offset: 0x00009AC8
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x573CB50", Offset = "0x573B750", VA = "0x18573CB50")]
		[MethodImpl(256)]
		public static double4x2 mul(double4x4 a, double4x2 b)
		{
			return default(double4x2);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0000B8E0 File Offset: 0x00009AE0
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x57392F0", Offset = "0x5737EF0", VA = "0x1857392F0")]
		[MethodImpl(256)]
		public static double4x3 mul(double4x4 a, double4x3 b)
		{
			return default(double4x3);
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x0000B8F8 File Offset: 0x00009AF8
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x5738B30", Offset = "0x5737730", VA = "0x185738B30")]
		[MethodImpl(256)]
		public static double4x4 mul(double4x4 a, double4x4 b)
		{
			return default(double4x4);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x0000B910 File Offset: 0x00009B10
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x570DD40", Offset = "0x570C940", VA = "0x18570DD40")]
		[MethodImpl(256)]
		public static int mul(int a, int b)
		{
			return 0;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x0000B928 File Offset: 0x00009B28
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x1DECB30", Offset = "0x1DEB730", VA = "0x181DECB30")]
		[MethodImpl(256)]
		public static int mul(int2 a, int2 b)
		{
			return 0;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x0000B940 File Offset: 0x00009B40
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x573B3B0", Offset = "0x5739FB0", VA = "0x18573B3B0")]
		[MethodImpl(256)]
		public static int2 mul(int2 a, int2x2 b)
		{
			return default(int2);
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x0000B958 File Offset: 0x00009B58
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x5736530", Offset = "0x5735130", VA = "0x185736530")]
		[MethodImpl(256)]
		public static int3 mul(int2 a, int2x3 b)
		{
			return default(int3);
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x0000B970 File Offset: 0x00009B70
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x573A990", Offset = "0x5739590", VA = "0x18573A990")]
		[MethodImpl(256)]
		public static int4 mul(int2 a, int2x4 b)
		{
			return default(int4);
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x570DDC0", Offset = "0x570C9C0", VA = "0x18570DDC0")]
		[MethodImpl(256)]
		public static int mul(int3 a, int3 b)
		{
			return 0;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x573DFC0", Offset = "0x573CBC0", VA = "0x18573DFC0")]
		[MethodImpl(256)]
		public static int2 mul(int3 a, int3x2 b)
		{
			return default(int2);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x5734E80", Offset = "0x5733A80", VA = "0x185734E80")]
		[MethodImpl(256)]
		public static int3 mul(int3 a, int3x3 b)
		{
			return default(int3);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x5735FE0", Offset = "0x5734BE0", VA = "0x185735FE0")]
		[MethodImpl(256)]
		public static int4 mul(int3 a, int3x4 b)
		{
			return default(int4);
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x570DD90", Offset = "0x570C990", VA = "0x18570DD90")]
		[MethodImpl(256)]
		public static int mul(int4 a, int4 b)
		{
			return 0;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x0000BA00 File Offset: 0x00009C00
		[Token(Token = "0x6000679")]
		[Address(RVA = "0x573AA10", Offset = "0x5739610", VA = "0x18573AA10")]
		[MethodImpl(256)]
		public static int2 mul(int4 a, int4x2 b)
		{
			return default(int2);
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0000BA18 File Offset: 0x00009C18
		[Token(Token = "0x600067A")]
		[Address(RVA = "0x57344E0", Offset = "0x57330E0", VA = "0x1857344E0")]
		[MethodImpl(256)]
		public static int3 mul(int4 a, int4x3 b)
		{
			return default(int3);
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0000BA30 File Offset: 0x00009C30
		[Token(Token = "0x600067B")]
		[Address(RVA = "0x5733740", Offset = "0x5732340", VA = "0x185733740")]
		[MethodImpl(256)]
		public static int4 mul(int4 a, int4x4 b)
		{
			return default(int4);
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0000BA48 File Offset: 0x00009C48
		[Token(Token = "0x600067C")]
		[Address(RVA = "0x57385C0", Offset = "0x57371C0", VA = "0x1857385C0")]
		[MethodImpl(256)]
		public static int2 mul(int2x2 a, int2 b)
		{
			return default(int2);
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0000BA60 File Offset: 0x00009C60
		[Token(Token = "0x600067D")]
		[Address(RVA = "0x573FF00", Offset = "0x573EB00", VA = "0x18573FF00")]
		[MethodImpl(256)]
		public static int2x2 mul(int2x2 a, int2x2 b)
		{
			return default(int2x2);
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0000BA78 File Offset: 0x00009C78
		[Token(Token = "0x600067E")]
		[Address(RVA = "0x57390B0", Offset = "0x5737CB0", VA = "0x1857390B0")]
		[MethodImpl(256)]
		public static int2x3 mul(int2x2 a, int2x3 b)
		{
			return default(int2x3);
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0000BA90 File Offset: 0x00009C90
		[Token(Token = "0x600067F")]
		[Address(RVA = "0x5734590", Offset = "0x5733190", VA = "0x185734590")]
		[MethodImpl(256)]
		public static int2x4 mul(int2x2 a, int2x4 b)
		{
			return default(int2x4);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x573AF20", Offset = "0x5739B20", VA = "0x18573AF20")]
		[MethodImpl(256)]
		public static int2 mul(int2x3 a, int3 b)
		{
			return default(int2);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0000BAC0 File Offset: 0x00009CC0
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x573C970", Offset = "0x573B570", VA = "0x18573C970")]
		[MethodImpl(256)]
		public static int2x2 mul(int2x3 a, int3x2 b)
		{
			return default(int2x2);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0000BAD8 File Offset: 0x00009CD8
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x57386A0", Offset = "0x57372A0", VA = "0x1857386A0")]
		[MethodImpl(256)]
		public static int2x3 mul(int2x3 a, int3x3 b)
		{
			return default(int2x3);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0000BAF0 File Offset: 0x00009CF0
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x5735B30", Offset = "0x5734730", VA = "0x185735B30")]
		[MethodImpl(256)]
		public static int2x4 mul(int2x3 a, int3x4 b)
		{
			return default(int2x4);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0000BB08 File Offset: 0x00009D08
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x5737B00", Offset = "0x5736700", VA = "0x185737B00")]
		[MethodImpl(256)]
		public static int2 mul(int2x4 a, int4 b)
		{
			return default(int2);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0000BB20 File Offset: 0x00009D20
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x5738900", Offset = "0x5737500", VA = "0x185738900")]
		[MethodImpl(256)]
		public static int2x2 mul(int2x4 a, int4x2 b)
		{
			return default(int2x2);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0000BB38 File Offset: 0x00009D38
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x5735380", Offset = "0x5733F80", VA = "0x185735380")]
		[MethodImpl(256)]
		public static int2x3 mul(int2x4 a, int4x3 b)
		{
			return default(int2x3);
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0000BB50 File Offset: 0x00009D50
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x573E1F0", Offset = "0x573CDF0", VA = "0x18573E1F0")]
		[MethodImpl(256)]
		public static int2x4 mul(int2x4 a, int4x4 b)
		{
			return default(int2x4);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0000BB68 File Offset: 0x00009D68
		[Token(Token = "0x6000688")]
		[Address(RVA = "0x5738430", Offset = "0x5737030", VA = "0x185738430")]
		[MethodImpl(256)]
		public static int3 mul(int3x2 a, int2 b)
		{
			return default(int3);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0000BB80 File Offset: 0x00009D80
		[Token(Token = "0x6000689")]
		[Address(RVA = "0x5742A50", Offset = "0x5741650", VA = "0x185742A50")]
		[MethodImpl(256)]
		public static int3x2 mul(int3x2 a, int2x2 b)
		{
			return default(int3x2);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0000BB98 File Offset: 0x00009D98
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x57396A0", Offset = "0x57382A0", VA = "0x1857396A0")]
		[MethodImpl(256)]
		public static int3x3 mul(int3x2 a, int2x3 b)
		{
			return default(int3x3);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0000BBB0 File Offset: 0x00009DB0
		[Token(Token = "0x600068B")]
		[Address(RVA = "0x573A630", Offset = "0x5739230", VA = "0x18573A630")]
		[MethodImpl(256)]
		public static int3x4 mul(int3x2 a, int2x4 b)
		{
			return default(int3x4);
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0000BBC8 File Offset: 0x00009DC8
		[Token(Token = "0x600068C")]
		[Address(RVA = "0x573A500", Offset = "0x5739100", VA = "0x18573A500")]
		[MethodImpl(256)]
		public static int3 mul(int3x3 a, int3 b)
		{
			return default(int3);
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0000BBE0 File Offset: 0x00009DE0
		[Token(Token = "0x600068D")]
		[Address(RVA = "0x5736080", Offset = "0x5734C80", VA = "0x185736080")]
		[MethodImpl(256)]
		public static int3x2 mul(int3x3 a, int3x2 b)
		{
			return default(int3x2);
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0000BBF8 File Offset: 0x00009DF8
		[Token(Token = "0x600068E")]
		[Address(RVA = "0x573F9F0", Offset = "0x573E5F0", VA = "0x18573F9F0")]
		[MethodImpl(256)]
		public static int3x3 mul(int3x3 a, int3x3 b)
		{
			return default(int3x3);
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0000BC10 File Offset: 0x00009E10
		[Token(Token = "0x600068F")]
		[Address(RVA = "0x573A0C0", Offset = "0x5738CC0", VA = "0x18573A0C0")]
		[MethodImpl(256)]
		public static int3x4 mul(int3x3 a, int3x4 b)
		{
			return default(int3x4);
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0000BC28 File Offset: 0x00009E28
		[Token(Token = "0x6000690")]
		[Address(RVA = "0x5737C10", Offset = "0x5736810", VA = "0x185737C10")]
		[MethodImpl(256)]
		public static int3 mul(int3x4 a, int4 b)
		{
			return default(int3);
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0000BC40 File Offset: 0x00009E40
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x5734770", Offset = "0x5733370", VA = "0x185734770")]
		[MethodImpl(256)]
		public static int3x2 mul(int3x4 a, int4x2 b)
		{
			return default(int3x2);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0000BC58 File Offset: 0x00009E58
		[Token(Token = "0x6000692")]
		[Address(RVA = "0x573C450", Offset = "0x573B050", VA = "0x18573C450")]
		[MethodImpl(256)]
		public static int3x3 mul(int3x4 a, int4x3 b)
		{
			return default(int3x3);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0000BC70 File Offset: 0x00009E70
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x57369F0", Offset = "0x57355F0", VA = "0x1857369F0")]
		[MethodImpl(256)]
		public static int3x4 mul(int3x4 a, int4x4 b)
		{
			return default(int3x4);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000BC88 File Offset: 0x00009E88
		[Token(Token = "0x6000694")]
		[Address(RVA = "0x5735240", Offset = "0x5733E40", VA = "0x185735240")]
		[MethodImpl(256)]
		public static int4 mul(int4x2 a, int2 b)
		{
			return default(int4);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0000BCA0 File Offset: 0x00009EA0
		[Token(Token = "0x6000695")]
		[Address(RVA = "0x5737DA0", Offset = "0x57369A0", VA = "0x185737DA0")]
		[MethodImpl(256)]
		public static int4x2 mul(int4x2 a, int2x2 b)
		{
			return default(int4x2);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		[Token(Token = "0x6000696")]
		[Address(RVA = "0x573AFE0", Offset = "0x5739BE0", VA = "0x18573AFE0")]
		[MethodImpl(256)]
		public static int4x3 mul(int4x2 a, int2x3 b)
		{
			return default(int4x3);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0000BCD0 File Offset: 0x00009ED0
		[Token(Token = "0x6000697")]
		[Address(RVA = "0x573D6C0", Offset = "0x573C2C0", VA = "0x18573D6C0")]
		[MethodImpl(256)]
		public static int4x4 mul(int4x2 a, int2x4 b)
		{
			return default(int4x4);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[Token(Token = "0x6000698")]
		[Address(RVA = "0x5734C10", Offset = "0x5733810", VA = "0x185734C10")]
		[MethodImpl(256)]
		public static int4 mul(int4x3 a, int3 b)
		{
			return default(int4);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0000BD00 File Offset: 0x00009F00
		[Token(Token = "0x6000699")]
		[Address(RVA = "0x57366E0", Offset = "0x57352E0", VA = "0x1857366E0")]
		[MethodImpl(256)]
		public static int4x2 mul(int4x3 a, int3x2 b)
		{
			return default(int4x2);
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0000BD18 File Offset: 0x00009F18
		[Token(Token = "0x600069A")]
		[Address(RVA = "0x5733E60", Offset = "0x5732A60", VA = "0x185733E60")]
		[MethodImpl(256)]
		public static int4x3 mul(int4x3 a, int3x3 b)
		{
			return default(int4x3);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0000BD30 File Offset: 0x00009F30
		[Token(Token = "0x600069B")]
		[Address(RVA = "0x5739B30", Offset = "0x5738730", VA = "0x185739B30")]
		[MethodImpl(256)]
		public static int4x4 mul(int4x3 a, int3x4 b)
		{
			return default(int4x4);
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0000BD48 File Offset: 0x00009F48
		[Token(Token = "0x600069C")]
		[Address(RVA = "0x573DCE0", Offset = "0x573C8E0", VA = "0x18573DCE0")]
		[MethodImpl(256)]
		public static int4 mul(int4x4 a, int4 b)
		{
			return default(int4);
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0000BD60 File Offset: 0x00009F60
		[Token(Token = "0x600069D")]
		[Address(RVA = "0x573B730", Offset = "0x573A330", VA = "0x18573B730")]
		[MethodImpl(256)]
		public static int4x2 mul(int4x4 a, int4x2 b)
		{
			return default(int4x2);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0000BD78 File Offset: 0x00009F78
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x5742490", Offset = "0x5741090", VA = "0x185742490")]
		[MethodImpl(256)]
		public static int4x3 mul(int4x4 a, int4x3 b)
		{
			return default(int4x3);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x0000BD90 File Offset: 0x00009F90
		[Token(Token = "0x600069F")]
		[Address(RVA = "0x57411C0", Offset = "0x573FDC0", VA = "0x1857411C0")]
		[MethodImpl(256)]
		public static int4x4 mul(int4x4 a, int4x4 b)
		{
			return default(int4x4);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0000BDA8 File Offset: 0x00009FA8
		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x570DD40", Offset = "0x570C940", VA = "0x18570DD40")]
		[MethodImpl(256)]
		public static uint mul(uint a, uint b)
		{
			return 0U;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1DECB30", Offset = "0x1DEB730", VA = "0x181DECB30")]
		[MethodImpl(256)]
		public static uint mul(uint2 a, uint2 b)
		{
			return 0U;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x573B3B0", Offset = "0x5739FB0", VA = "0x18573B3B0")]
		[MethodImpl(256)]
		public static uint2 mul(uint2 a, uint2x2 b)
		{
			return default(uint2);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x5736530", Offset = "0x5735130", VA = "0x185736530")]
		[MethodImpl(256)]
		public static uint3 mul(uint2 a, uint2x3 b)
		{
			return default(uint3);
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000BE08 File Offset: 0x0000A008
		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x573A990", Offset = "0x5739590", VA = "0x18573A990")]
		[MethodImpl(256)]
		public static uint4 mul(uint2 a, uint2x4 b)
		{
			return default(uint4);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0000BE20 File Offset: 0x0000A020
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x570DDC0", Offset = "0x570C9C0", VA = "0x18570DDC0")]
		[MethodImpl(256)]
		public static uint mul(uint3 a, uint3 b)
		{
			return 0U;
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0000BE38 File Offset: 0x0000A038
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x573DFC0", Offset = "0x573CBC0", VA = "0x18573DFC0")]
		[MethodImpl(256)]
		public static uint2 mul(uint3 a, uint3x2 b)
		{
			return default(uint2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0000BE50 File Offset: 0x0000A050
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x5734E80", Offset = "0x5733A80", VA = "0x185734E80")]
		[MethodImpl(256)]
		public static uint3 mul(uint3 a, uint3x3 b)
		{
			return default(uint3);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0000BE68 File Offset: 0x0000A068
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x5735FE0", Offset = "0x5734BE0", VA = "0x185735FE0")]
		[MethodImpl(256)]
		public static uint4 mul(uint3 a, uint3x4 b)
		{
			return default(uint4);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0000BE80 File Offset: 0x0000A080
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x570DD90", Offset = "0x570C990", VA = "0x18570DD90")]
		[MethodImpl(256)]
		public static uint mul(uint4 a, uint4 b)
		{
			return 0U;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0000BE98 File Offset: 0x0000A098
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x573AA10", Offset = "0x5739610", VA = "0x18573AA10")]
		[MethodImpl(256)]
		public static uint2 mul(uint4 a, uint4x2 b)
		{
			return default(uint2);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x57344E0", Offset = "0x57330E0", VA = "0x1857344E0")]
		[MethodImpl(256)]
		public static uint3 mul(uint4 a, uint4x3 b)
		{
			return default(uint3);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0000BEC8 File Offset: 0x0000A0C8
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x5733740", Offset = "0x5732340", VA = "0x185733740")]
		[MethodImpl(256)]
		public static uint4 mul(uint4 a, uint4x4 b)
		{
			return default(uint4);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0000BEE0 File Offset: 0x0000A0E0
		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x57385C0", Offset = "0x57371C0", VA = "0x1857385C0")]
		[MethodImpl(256)]
		public static uint2 mul(uint2x2 a, uint2 b)
		{
			return default(uint2);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x573FF00", Offset = "0x573EB00", VA = "0x18573FF00")]
		[MethodImpl(256)]
		public static uint2x2 mul(uint2x2 a, uint2x2 b)
		{
			return default(uint2x2);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0000BF10 File Offset: 0x0000A110
		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x57390B0", Offset = "0x5737CB0", VA = "0x1857390B0")]
		[MethodImpl(256)]
		public static uint2x3 mul(uint2x2 a, uint2x3 b)
		{
			return default(uint2x3);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0000BF28 File Offset: 0x0000A128
		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x5734590", Offset = "0x5733190", VA = "0x185734590")]
		[MethodImpl(256)]
		public static uint2x4 mul(uint2x2 a, uint2x4 b)
		{
			return default(uint2x4);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0000BF40 File Offset: 0x0000A140
		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x573AF20", Offset = "0x5739B20", VA = "0x18573AF20")]
		[MethodImpl(256)]
		public static uint2 mul(uint2x3 a, uint3 b)
		{
			return default(uint2);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0000BF58 File Offset: 0x0000A158
		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x573C970", Offset = "0x573B570", VA = "0x18573C970")]
		[MethodImpl(256)]
		public static uint2x2 mul(uint2x3 a, uint3x2 b)
		{
			return default(uint2x2);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000BF70 File Offset: 0x0000A170
		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x57386A0", Offset = "0x57372A0", VA = "0x1857386A0")]
		[MethodImpl(256)]
		public static uint2x3 mul(uint2x3 a, uint3x3 b)
		{
			return default(uint2x3);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0000BF88 File Offset: 0x0000A188
		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x5735B30", Offset = "0x5734730", VA = "0x185735B30")]
		[MethodImpl(256)]
		public static uint2x4 mul(uint2x3 a, uint3x4 b)
		{
			return default(uint2x4);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0000BFA0 File Offset: 0x0000A1A0
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x5737B00", Offset = "0x5736700", VA = "0x185737B00")]
		[MethodImpl(256)]
		public static uint2 mul(uint2x4 a, uint4 b)
		{
			return default(uint2);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0000BFB8 File Offset: 0x0000A1B8
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x5738900", Offset = "0x5737500", VA = "0x185738900")]
		[MethodImpl(256)]
		public static uint2x2 mul(uint2x4 a, uint4x2 b)
		{
			return default(uint2x2);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x5735380", Offset = "0x5733F80", VA = "0x185735380")]
		[MethodImpl(256)]
		public static uint2x3 mul(uint2x4 a, uint4x3 b)
		{
			return default(uint2x3);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x573E1F0", Offset = "0x573CDF0", VA = "0x18573E1F0")]
		[MethodImpl(256)]
		public static uint2x4 mul(uint2x4 a, uint4x4 b)
		{
			return default(uint2x4);
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0000C000 File Offset: 0x0000A200
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x5738430", Offset = "0x5737030", VA = "0x185738430")]
		[MethodImpl(256)]
		public static uint3 mul(uint3x2 a, uint2 b)
		{
			return default(uint3);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0000C018 File Offset: 0x0000A218
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x5742A50", Offset = "0x5741650", VA = "0x185742A50")]
		[MethodImpl(256)]
		public static uint3x2 mul(uint3x2 a, uint2x2 b)
		{
			return default(uint3x2);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0000C030 File Offset: 0x0000A230
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x57396A0", Offset = "0x57382A0", VA = "0x1857396A0")]
		[MethodImpl(256)]
		public static uint3x3 mul(uint3x2 a, uint2x3 b)
		{
			return default(uint3x3);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0000C048 File Offset: 0x0000A248
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x573A630", Offset = "0x5739230", VA = "0x18573A630")]
		[MethodImpl(256)]
		public static uint3x4 mul(uint3x2 a, uint2x4 b)
		{
			return default(uint3x4);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0000C060 File Offset: 0x0000A260
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x573A500", Offset = "0x5739100", VA = "0x18573A500")]
		[MethodImpl(256)]
		public static uint3 mul(uint3x3 a, uint3 b)
		{
			return default(uint3);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0000C078 File Offset: 0x0000A278
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x5736080", Offset = "0x5734C80", VA = "0x185736080")]
		[MethodImpl(256)]
		public static uint3x2 mul(uint3x3 a, uint3x2 b)
		{
			return default(uint3x2);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0000C090 File Offset: 0x0000A290
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x573F9F0", Offset = "0x573E5F0", VA = "0x18573F9F0")]
		[MethodImpl(256)]
		public static uint3x3 mul(uint3x3 a, uint3x3 b)
		{
			return default(uint3x3);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x5740000", Offset = "0x573EC00", VA = "0x185740000")]
		[MethodImpl(256)]
		public static uint3x4 mul(uint3x3 a, uint3x4 b)
		{
			return default(uint3x4);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x5737C10", Offset = "0x5736810", VA = "0x185737C10")]
		[MethodImpl(256)]
		public static uint3 mul(uint3x4 a, uint4 b)
		{
			return default(uint3);
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x5734770", Offset = "0x5733370", VA = "0x185734770")]
		[MethodImpl(256)]
		public static uint3x2 mul(uint3x4 a, uint4x2 b)
		{
			return default(uint3x2);
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x573F400", Offset = "0x573E000", VA = "0x18573F400")]
		[MethodImpl(256)]
		public static uint3x3 mul(uint3x4 a, uint4x3 b)
		{
			return default(uint3x3);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0000C108 File Offset: 0x0000A308
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x57369F0", Offset = "0x57355F0", VA = "0x1857369F0")]
		[MethodImpl(256)]
		public static uint3x4 mul(uint3x4 a, uint4x4 b)
		{
			return default(uint3x4);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0000C120 File Offset: 0x0000A320
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x5735240", Offset = "0x5733E40", VA = "0x185735240")]
		[MethodImpl(256)]
		public static uint4 mul(uint4x2 a, uint2 b)
		{
			return default(uint4);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0000C138 File Offset: 0x0000A338
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x5737DA0", Offset = "0x57369A0", VA = "0x185737DA0")]
		[MethodImpl(256)]
		public static uint4x2 mul(uint4x2 a, uint2x2 b)
		{
			return default(uint4x2);
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0000C150 File Offset: 0x0000A350
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x573AFE0", Offset = "0x5739BE0", VA = "0x18573AFE0")]
		[MethodImpl(256)]
		public static uint4x3 mul(uint4x2 a, uint2x3 b)
		{
			return default(uint4x3);
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x0000C168 File Offset: 0x0000A368
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x573D6C0", Offset = "0x573C2C0", VA = "0x18573D6C0")]
		[MethodImpl(256)]
		public static uint4x4 mul(uint4x2 a, uint2x4 b)
		{
			return default(uint4x4);
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0000C180 File Offset: 0x0000A380
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x5734C10", Offset = "0x5733810", VA = "0x185734C10")]
		[MethodImpl(256)]
		public static uint4 mul(uint4x3 a, uint3 b)
		{
			return default(uint4);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0000C198 File Offset: 0x0000A398
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x57366E0", Offset = "0x57352E0", VA = "0x1857366E0")]
		[MethodImpl(256)]
		public static uint4x2 mul(uint4x3 a, uint3x2 b)
		{
			return default(uint4x2);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x5733E60", Offset = "0x5732A60", VA = "0x185733E60")]
		[MethodImpl(256)]
		public static uint4x3 mul(uint4x3 a, uint3x3 b)
		{
			return default(uint4x3);
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0000C1C8 File Offset: 0x0000A3C8
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x5739B30", Offset = "0x5738730", VA = "0x185739B30")]
		[MethodImpl(256)]
		public static uint4x4 mul(uint4x3 a, uint3x4 b)
		{
			return default(uint4x4);
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x573DCE0", Offset = "0x573C8E0", VA = "0x18573DCE0")]
		[MethodImpl(256)]
		public static uint4 mul(uint4x4 a, uint4 b)
		{
			return default(uint4);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0000C1F8 File Offset: 0x0000A3F8
		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x573B730", Offset = "0x573A330", VA = "0x18573B730")]
		[MethodImpl(256)]
		public static uint4x2 mul(uint4x4 a, uint4x2 b)
		{
			return default(uint4x2);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0000C210 File Offset: 0x0000A410
		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x5740680", Offset = "0x573F280", VA = "0x185740680")]
		[MethodImpl(256)]
		public static uint4x3 mul(uint4x4 a, uint4x3 b)
		{
			return default(uint4x3);
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0000C228 File Offset: 0x0000A428
		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x57411C0", Offset = "0x573FDC0", VA = "0x1857411C0")]
		[MethodImpl(256)]
		public static uint4x4 mul(uint4x4 a, uint4x4 b)
		{
			return default(uint4x4);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0000C240 File Offset: 0x0000A440
		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x5700690", Offset = "0x56FF290", VA = "0x185700690")]
		[MethodImpl(256)]
		public static quaternion quaternion(float x, float y, float z, float w)
		{
			return default(quaternion);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0000C258 File Offset: 0x0000A458
		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x253ECA0", Offset = "0x253D8A0", VA = "0x18253ECA0")]
		[MethodImpl(256)]
		public static quaternion quaternion(float4 value)
		{
			return default(quaternion);
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0000C270 File Offset: 0x0000A470
		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x5746880", Offset = "0x5745480", VA = "0x185746880")]
		[MethodImpl(256)]
		public static quaternion quaternion(float3x3 m)
		{
			return default(quaternion);
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000C288 File Offset: 0x0000A488
		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x5746830", Offset = "0x5745430", VA = "0x185746830")]
		[MethodImpl(256)]
		public static quaternion quaternion(float4x4 m)
		{
			return default(quaternion);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0000C2A0 File Offset: 0x0000A4A0
		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x570B8B0", Offset = "0x570A4B0", VA = "0x18570B8B0")]
		[MethodImpl(256)]
		public static quaternion conjugate(quaternion q)
		{
			return default(quaternion);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x572CF50", Offset = "0x572BB50", VA = "0x18572CF50")]
		[MethodImpl(256)]
		public static quaternion inverse(quaternion q)
		{
			return default(quaternion);
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0000C2D0 File Offset: 0x0000A4D0
		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x570DE30", Offset = "0x570CA30", VA = "0x18570DE30")]
		[MethodImpl(256)]
		public static float dot(quaternion a, quaternion b)
		{
			return 0f;
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0000C2E8 File Offset: 0x0000A4E8
		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x572F8B0", Offset = "0x572E4B0", VA = "0x18572F8B0")]
		[MethodImpl(256)]
		public static float length(quaternion q)
		{
			return 0f;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0000C300 File Offset: 0x0000A500
		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x572F910", Offset = "0x572E510", VA = "0x18572F910")]
		[MethodImpl(256)]
		public static float lengthsq(quaternion q)
		{
			return 0f;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0000C318 File Offset: 0x0000A518
		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x5744620", Offset = "0x5743220", VA = "0x185744620")]
		[MethodImpl(256)]
		public static quaternion normalize(quaternion q)
		{
			return default(quaternion);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0000C330 File Offset: 0x0000A530
		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x5744AA0", Offset = "0x57436A0", VA = "0x185744AA0")]
		[MethodImpl(256)]
		public static quaternion normalizesafe(quaternion q)
		{
			return default(quaternion);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x5744BE0", Offset = "0x57437E0", VA = "0x185744BE0")]
		[MethodImpl(256)]
		public static quaternion normalizesafe(quaternion q, quaternion defaultvalue)
		{
			return default(quaternion);
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0000C360 File Offset: 0x0000A560
		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x5755680", Offset = "0x5754280", VA = "0x185755680")]
		[MethodImpl(256)]
		public static quaternion unitexp(quaternion q)
		{
			return default(quaternion);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0000C378 File Offset: 0x0000A578
		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x5712E40", Offset = "0x5711A40", VA = "0x185712E40")]
		[MethodImpl(256)]
		public static quaternion exp(quaternion q)
		{
			return default(quaternion);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0000C390 File Offset: 0x0000A590
		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x57557F0", Offset = "0x57543F0", VA = "0x1857557F0")]
		[MethodImpl(256)]
		public static quaternion unitlog(quaternion q)
		{
			return default(quaternion);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x5731680", Offset = "0x5730280", VA = "0x185731680")]
		[MethodImpl(256)]
		public static quaternion log(quaternion q)
		{
			return default(quaternion);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0000C3C0 File Offset: 0x0000A5C0
		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x5701080", Offset = "0x56FFC80", VA = "0x185701080")]
		[MethodImpl(256)]
		public static quaternion mul(quaternion a, quaternion b)
		{
			return default(quaternion);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x5742CF0", Offset = "0x57418F0", VA = "0x185742CF0")]
		[MethodImpl(256)]
		public static float3 mul(quaternion q, float3 v)
		{
			return default(float3);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0000C3F0 File Offset: 0x0000A5F0
		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x5742CF0", Offset = "0x57418F0", VA = "0x185742CF0")]
		[MethodImpl(256)]
		public static float3 rotate(quaternion q, float3 v)
		{
			return default(float3);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0000C408 File Offset: 0x0000A608
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x5701230", Offset = "0x56FFE30", VA = "0x185701230")]
		[MethodImpl(256)]
		public static quaternion nlerp(quaternion q1, quaternion q2, float t)
		{
			return default(quaternion);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0000C420 File Offset: 0x0000A620
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x574ED10", Offset = "0x574D910", VA = "0x18574ED10")]
		[MethodImpl(256)]
		public static quaternion slerp(quaternion q1, quaternion q2, float t)
		{
			return default(quaternion);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0000C438 File Offset: 0x0000A638
		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x571D580", Offset = "0x571C180", VA = "0x18571D580")]
		[MethodImpl(256)]
		public static uint hash(quaternion q)
		{
			return 0U;
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0000C450 File Offset: 0x0000A650
		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x5723210", Offset = "0x5721E10", VA = "0x185723210")]
		[MethodImpl(256)]
		public static uint4 hashwide(quaternion q)
		{
			return default(uint4);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0000C468 File Offset: 0x0000A668
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x571A9D0", Offset = "0x57195D0", VA = "0x18571A9D0")]
		[MethodImpl(256)]
		public static float3 forward(quaternion q)
		{
			return default(float3);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0000C480 File Offset: 0x0000A680
		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x5705E30", Offset = "0x5704A30", VA = "0x185705E30")]
		[MethodImpl(256)]
		public static RigidTransform RigidTransform(quaternion rot, float3 pos)
		{
			return default(RigidTransform);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0000C498 File Offset: 0x0000A698
		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x5705E50", Offset = "0x5704A50", VA = "0x185705E50")]
		[MethodImpl(256)]
		public static RigidTransform RigidTransform(float3x3 rotation, float3 translation)
		{
			return default(RigidTransform);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0000C4B0 File Offset: 0x0000A6B0
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x5705ED0", Offset = "0x5704AD0", VA = "0x185705ED0")]
		[MethodImpl(256)]
		public static RigidTransform RigidTransform(float4x4 transform)
		{
			return default(RigidTransform);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x572E4D0", Offset = "0x572D0D0", VA = "0x18572E4D0")]
		[MethodImpl(256)]
		public static RigidTransform inverse(RigidTransform t)
		{
			return default(RigidTransform);
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0000C4E0 File Offset: 0x0000A6E0
		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x5741B00", Offset = "0x5740700", VA = "0x185741B00")]
		[MethodImpl(256)]
		public static RigidTransform mul(RigidTransform a, RigidTransform b)
		{
			return default(RigidTransform);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0000C4F8 File Offset: 0x0000A6F8
		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x5734A60", Offset = "0x5733660", VA = "0x185734A60")]
		[MethodImpl(256)]
		public static float4 mul(RigidTransform a, float4 pos)
		{
			return default(float4);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0000C510 File Offset: 0x0000A710
		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x5748E10", Offset = "0x5747A10", VA = "0x185748E10")]
		[MethodImpl(256)]
		public static float3 rotate(RigidTransform a, float3 dir)
		{
			return default(float3);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0000C528 File Offset: 0x0000A728
		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x5751250", Offset = "0x574FE50", VA = "0x185751250")]
		[MethodImpl(256)]
		public static float3 transform(RigidTransform a, float3 pos)
		{
			return default(float3);
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0000C540 File Offset: 0x0000A740
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x5721DC0", Offset = "0x57209C0", VA = "0x185721DC0")]
		[MethodImpl(256)]
		public static uint hash(RigidTransform t)
		{
			return 0U;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0000C558 File Offset: 0x0000A758
		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x5723820", Offset = "0x5722420", VA = "0x185723820")]
		[MethodImpl(256)]
		public static uint4 hashwide(RigidTransform t)
		{
			return default(uint4);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0000C570 File Offset: 0x0000A770
		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x57090A0", Offset = "0x5707CA0", VA = "0x1857090A0")]
		[MethodImpl(256)]
		public static uint2 uint2(uint x, uint y)
		{
			return default(uint2);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0000C588 File Offset: 0x0000A788
		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x5707920", Offset = "0x5706520", VA = "0x185707920")]
		[MethodImpl(256)]
		public static uint2 uint2(uint2 xy)
		{
			return default(uint2);
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x57288C0", Offset = "0x57274C0", VA = "0x1857288C0")]
		[MethodImpl(256)]
		public static uint2 uint2(uint v)
		{
			return default(uint2);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x5728860", Offset = "0x5727460", VA = "0x185728860")]
		[MethodImpl(256)]
		public static uint2 uint2(bool v)
		{
			return default(uint2);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x57288A0", Offset = "0x57274A0", VA = "0x1857288A0")]
		[MethodImpl(256)]
		public static uint2 uint2(bool2 v)
		{
			return default(uint2);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x57288C0", Offset = "0x57274C0", VA = "0x1857288C0")]
		[MethodImpl(256)]
		public static uint2 uint2(int v)
		{
			return default(uint2);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0000C600 File Offset: 0x0000A800
		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x5707920", Offset = "0x5706520", VA = "0x185707920")]
		[MethodImpl(256)]
		public static uint2 uint2(int2 v)
		{
			return default(uint2);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0000C618 File Offset: 0x0000A818
		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x5753380", Offset = "0x5751F80", VA = "0x185753380")]
		[MethodImpl(256)]
		public static uint2 uint2(float v)
		{
			return default(uint2);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0000C630 File Offset: 0x0000A830
		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x57533C0", Offset = "0x5751FC0", VA = "0x1857533C0")]
		[MethodImpl(256)]
		public static uint2 uint2(float2 v)
		{
			return default(uint2);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0000C648 File Offset: 0x0000A848
		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x5753340", Offset = "0x5751F40", VA = "0x185753340")]
		[MethodImpl(256)]
		public static uint2 uint2(double v)
		{
			return default(uint2);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0000C660 File Offset: 0x0000A860
		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x57532E0", Offset = "0x5751EE0", VA = "0x1857532E0")]
		[MethodImpl(256)]
		public static uint2 uint2(double2 v)
		{
			return default(uint2);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0000C678 File Offset: 0x0000A878
		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x571DB80", Offset = "0x571C780", VA = "0x18571DB80")]
		[MethodImpl(256)]
		public static uint hash(uint2 v)
		{
			return 0U;
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0000C690 File Offset: 0x0000A890
		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x5723320", Offset = "0x5721F20", VA = "0x185723320")]
		[MethodImpl(256)]
		public static uint2 hashwide(uint2 v)
		{
			return default(uint2);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x574B980", Offset = "0x574A580", VA = "0x18574B980")]
		[MethodImpl(256)]
		public static uint shuffle(uint2 left, uint2 right, math.ShuffleComponent x)
		{
			return 0U;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0000C6C0 File Offset: 0x0000A8C0
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x574A840", Offset = "0x5749440", VA = "0x18574A840")]
		[MethodImpl(256)]
		public static uint2 shuffle(uint2 left, uint2 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(uint2);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0000C6D8 File Offset: 0x0000A8D8
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x574AE60", Offset = "0x5749A60", VA = "0x18574AE60")]
		[MethodImpl(256)]
		public static uint3 shuffle(uint2 left, uint2 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(uint3);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0000C6F0 File Offset: 0x0000A8F0
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x574C2A0", Offset = "0x574AEA0", VA = "0x18574C2A0")]
		[MethodImpl(256)]
		public static uint4 shuffle(uint2 left, uint2 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(uint4);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0000C708 File Offset: 0x0000A908
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x5702070", Offset = "0x5700C70", VA = "0x185702070")]
		[MethodImpl(256)]
		internal static uint select_shuffle_component(uint2 a, uint2 b, math.ShuffleComponent component)
		{
			return 0U;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0000C720 File Offset: 0x0000A920
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x5067AF0", Offset = "0x50666F0", VA = "0x185067AF0")]
		[MethodImpl(256)]
		public static uint2x2 uint2x2(uint2 c0, uint2 c1)
		{
			return default(uint2x2);
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0000C738 File Offset: 0x0000A938
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x5728A10", Offset = "0x5727610", VA = "0x185728A10")]
		[MethodImpl(256)]
		public static uint2x2 uint2x2(uint m00, uint m01, uint m10, uint m11)
		{
			return default(uint2x2);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0000C750 File Offset: 0x0000A950
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x57289E0", Offset = "0x57275E0", VA = "0x1857289E0")]
		[MethodImpl(256)]
		public static uint2x2 uint2x2(uint v)
		{
			return default(uint2x2);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0000C768 File Offset: 0x0000A968
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x5728B40", Offset = "0x5727740", VA = "0x185728B40")]
		[MethodImpl(256)]
		public static uint2x2 uint2x2(bool v)
		{
			return default(uint2x2);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0000C780 File Offset: 0x0000A980
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x57288F0", Offset = "0x57274F0", VA = "0x1857288F0")]
		[MethodImpl(256)]
		public static uint2x2 uint2x2(bool2x2 v)
		{
			return default(uint2x2);
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0000C798 File Offset: 0x0000A998
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x57289E0", Offset = "0x57275E0", VA = "0x1857289E0")]
		[MethodImpl(256)]
		public static uint2x2 uint2x2(int v)
		{
			return default(uint2x2);
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x5728AC0", Offset = "0x57276C0", VA = "0x185728AC0")]
		[MethodImpl(256)]
		public static uint2x2 uint2x2(int2x2 v)
		{
			return default(uint2x2);
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0000C7C8 File Offset: 0x0000A9C8
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x5753410", Offset = "0x5752010", VA = "0x185753410")]
		[MethodImpl(256)]
		public static uint2x2 uint2x2(float v)
		{
			return default(uint2x2);
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0000C7E0 File Offset: 0x0000A9E0
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x57535A0", Offset = "0x57521A0", VA = "0x1857535A0")]
		[MethodImpl(256)]
		public static uint2x2 uint2x2(float2x2 v)
		{
			return default(uint2x2);
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x5753480", Offset = "0x5752080", VA = "0x185753480")]
		[MethodImpl(256)]
		public static uint2x2 uint2x2(double v)
		{
			return default(uint2x2);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0000C810 File Offset: 0x0000AA10
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x57534F0", Offset = "0x57520F0", VA = "0x1857534F0")]
		[MethodImpl(256)]
		public static uint2x2 uint2x2(double2x2 v)
		{
			return default(uint2x2);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0000C828 File Offset: 0x0000AA28
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x5751730", Offset = "0x5750330", VA = "0x185751730")]
		[MethodImpl(256)]
		public static uint2x2 transpose(uint2x2 v)
		{
			return default(uint2x2);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0000C840 File Offset: 0x0000AA40
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x5720A50", Offset = "0x571F650", VA = "0x185720A50")]
		[MethodImpl(256)]
		public static uint hash(uint2x2 v)
		{
			return 0U;
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0000C858 File Offset: 0x0000AA58
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x5723150", Offset = "0x5721D50", VA = "0x185723150")]
		[MethodImpl(256)]
		public static uint2 hashwide(uint2x2 v)
		{
			return default(uint2);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0000C870 File Offset: 0x0000AA70
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x509C000", Offset = "0x509AC00", VA = "0x18509C000")]
		[MethodImpl(256)]
		public static uint2x3 uint2x3(uint2 c0, uint2 c1, uint2 c2)
		{
			return default(uint2x3);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0000C888 File Offset: 0x0000AA88
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x5728BE0", Offset = "0x57277E0", VA = "0x185728BE0")]
		[MethodImpl(256)]
		public static uint2x3 uint2x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12)
		{
			return default(uint2x3);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0000C8A0 File Offset: 0x0000AAA0
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x5728CC0", Offset = "0x57278C0", VA = "0x185728CC0")]
		[MethodImpl(256)]
		public static uint2x3 uint2x3(uint v)
		{
			return default(uint2x3);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0000C8B8 File Offset: 0x0000AAB8
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x5728ED0", Offset = "0x5727AD0", VA = "0x185728ED0")]
		[MethodImpl(256)]
		public static uint2x3 uint2x3(bool v)
		{
			return default(uint2x3);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0000C8D0 File Offset: 0x0000AAD0
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x5728D40", Offset = "0x5727940", VA = "0x185728D40")]
		[MethodImpl(256)]
		public static uint2x3 uint2x3(bool2x3 v)
		{
			return default(uint2x3);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x5728CC0", Offset = "0x57278C0", VA = "0x185728CC0")]
		[MethodImpl(256)]
		public static uint2x3 uint2x3(int v)
		{
			return default(uint2x3);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0000C900 File Offset: 0x0000AB00
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x5728C30", Offset = "0x5727830", VA = "0x185728C30")]
		[MethodImpl(256)]
		public static uint2x3 uint2x3(int2x3 v)
		{
			return default(uint2x3);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0000C918 File Offset: 0x0000AB18
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x57537E0", Offset = "0x57523E0", VA = "0x1857537E0")]
		[MethodImpl(256)]
		public static uint2x3 uint2x3(float v)
		{
			return default(uint2x3);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0000C930 File Offset: 0x0000AB30
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x57536E0", Offset = "0x57522E0", VA = "0x1857536E0")]
		[MethodImpl(256)]
		public static uint2x3 uint2x3(float2x3 v)
		{
			return default(uint2x3);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0000C948 File Offset: 0x0000AB48
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x5753640", Offset = "0x5752240", VA = "0x185753640")]
		[MethodImpl(256)]
		public static uint2x3 uint2x3(double v)
		{
			return default(uint2x3);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0000C960 File Offset: 0x0000AB60
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x5753880", Offset = "0x5752480", VA = "0x185753880")]
		[MethodImpl(256)]
		public static uint2x3 uint2x3(double2x3 v)
		{
			return default(uint2x3);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0000C978 File Offset: 0x0000AB78
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x57525A0", Offset = "0x57511A0", VA = "0x1857525A0")]
		[MethodImpl(256)]
		public static uint3x2 transpose(uint2x3 v)
		{
			return default(uint3x2);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0000C990 File Offset: 0x0000AB90
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x571EEC0", Offset = "0x571DAC0", VA = "0x18571EEC0")]
		[MethodImpl(256)]
		public static uint hash(uint2x3 v)
		{
			return 0U;
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x5727E80", Offset = "0x5726A80", VA = "0x185727E80")]
		[MethodImpl(256)]
		public static uint2 hashwide(uint2x3 v)
		{
			return default(uint2);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0000C9C0 File Offset: 0x0000ABC0
		[Token(Token = "0x6000721")]
		[Address(RVA = "0x5729110", Offset = "0x5727D10", VA = "0x185729110")]
		[MethodImpl(256)]
		public static uint2x4 uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3)
		{
			return default(uint2x4);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0000C9D8 File Offset: 0x0000ABD8
		[Token(Token = "0x6000722")]
		[Address(RVA = "0x5729220", Offset = "0x5727E20", VA = "0x185729220")]
		[MethodImpl(256)]
		public static uint2x4 uint2x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13)
		{
			return default(uint2x4);
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0000C9F0 File Offset: 0x0000ABF0
		[Token(Token = "0x6000723")]
		[Address(RVA = "0x5729130", Offset = "0x5727D30", VA = "0x185729130")]
		[MethodImpl(256)]
		public static uint2x4 uint2x4(uint v)
		{
			return default(uint2x4);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0000CA08 File Offset: 0x0000AC08
		[Token(Token = "0x6000724")]
		[Address(RVA = "0x5729280", Offset = "0x5727E80", VA = "0x185729280")]
		[MethodImpl(256)]
		public static uint2x4 uint2x4(bool v)
		{
			return default(uint2x4);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x0000CA20 File Offset: 0x0000AC20
		[Token(Token = "0x6000725")]
		[Address(RVA = "0x5728FE0", Offset = "0x5727BE0", VA = "0x185728FE0")]
		[MethodImpl(256)]
		public static uint2x4 uint2x4(bool2x4 v)
		{
			return default(uint2x4);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x0000CA38 File Offset: 0x0000AC38
		[Token(Token = "0x6000726")]
		[Address(RVA = "0x5729130", Offset = "0x5727D30", VA = "0x185729130")]
		[MethodImpl(256)]
		public static uint2x4 uint2x4(int v)
		{
			return default(uint2x4);
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0000CA50 File Offset: 0x0000AC50
		[Token(Token = "0x6000727")]
		[Address(RVA = "0x5729180", Offset = "0x5727D80", VA = "0x185729180")]
		[MethodImpl(256)]
		public static uint2x4 uint2x4(int2x4 v)
		{
			return default(uint2x4);
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0000CA68 File Offset: 0x0000AC68
		[Token(Token = "0x6000728")]
		[Address(RVA = "0x5753AB0", Offset = "0x57526B0", VA = "0x185753AB0")]
		[MethodImpl(256)]
		public static uint2x4 uint2x4(float v)
		{
			return default(uint2x4);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0000CA80 File Offset: 0x0000AC80
		[Token(Token = "0x6000729")]
		[Address(RVA = "0x5753980", Offset = "0x5752580", VA = "0x185753980")]
		[MethodImpl(256)]
		public static uint2x4 uint2x4(float2x4 v)
		{
			return default(uint2x4);
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0000CA98 File Offset: 0x0000AC98
		[Token(Token = "0x600072A")]
		[Address(RVA = "0x5753B80", Offset = "0x5752780", VA = "0x185753B80")]
		[MethodImpl(256)]
		public static uint2x4 uint2x4(double v)
		{
			return default(uint2x4);
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0000CAB0 File Offset: 0x0000ACB0
		[Token(Token = "0x600072B")]
		[Address(RVA = "0x5753C50", Offset = "0x5752850", VA = "0x185753C50")]
		[MethodImpl(256)]
		public static uint2x4 uint2x4(double2x4 v)
		{
			return default(uint2x4);
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		[Token(Token = "0x600072C")]
		[Address(RVA = "0x57519A0", Offset = "0x57505A0", VA = "0x1857519A0")]
		[MethodImpl(256)]
		public static uint4x2 transpose(uint2x4 v)
		{
			return default(uint4x2);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x0000CAE0 File Offset: 0x0000ACE0
		[Token(Token = "0x600072D")]
		[Address(RVA = "0x571CC40", Offset = "0x571B840", VA = "0x18571CC40")]
		[MethodImpl(256)]
		public static uint hash(uint2x4 v)
		{
			return 0U;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x0000CAF8 File Offset: 0x0000ACF8
		[Token(Token = "0x600072E")]
		[Address(RVA = "0x5726370", Offset = "0x5724F70", VA = "0x185726370")]
		[MethodImpl(256)]
		public static uint2 hashwide(uint2x4 v)
		{
			return default(uint2);
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0000CB10 File Offset: 0x0000AD10
		[Token(Token = "0x600072F")]
		[Address(RVA = "0x5709100", Offset = "0x5707D00", VA = "0x185709100")]
		[MethodImpl(256)]
		public static uint3 uint3(uint x, uint y, uint z)
		{
			return default(uint3);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x0000CB28 File Offset: 0x0000AD28
		[Token(Token = "0x6000730")]
		[Address(RVA = "0x5729560", Offset = "0x5728160", VA = "0x185729560")]
		[MethodImpl(256)]
		public static uint3 uint3(uint x, uint2 yz)
		{
			return default(uint3);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0000CB40 File Offset: 0x0000AD40
		[Token(Token = "0x6000731")]
		[Address(RVA = "0x5729580", Offset = "0x5728180", VA = "0x185729580")]
		[MethodImpl(256)]
		public static uint3 uint3(uint2 xy, uint z)
		{
			return default(uint3);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x0000CB58 File Offset: 0x0000AD58
		[Token(Token = "0x6000732")]
		[Address(RVA = "0x57295A0", Offset = "0x57281A0", VA = "0x1857295A0")]
		[MethodImpl(256)]
		public static uint3 uint3(uint3 xyz)
		{
			return default(uint3);
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x0000CB70 File Offset: 0x0000AD70
		[Token(Token = "0x6000733")]
		[Address(RVA = "0x5729510", Offset = "0x5728110", VA = "0x185729510")]
		[MethodImpl(256)]
		public static uint3 uint3(uint v)
		{
			return default(uint3);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x0000CB88 File Offset: 0x0000AD88
		[Token(Token = "0x6000734")]
		[Address(RVA = "0x57294F0", Offset = "0x57280F0", VA = "0x1857294F0")]
		[MethodImpl(256)]
		public static uint3 uint3(bool v)
		{
			return default(uint3);
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x0000CBA0 File Offset: 0x0000ADA0
		[Token(Token = "0x6000735")]
		[Address(RVA = "0x57295F0", Offset = "0x57281F0", VA = "0x1857295F0")]
		[MethodImpl(256)]
		public static uint3 uint3(bool3 v)
		{
			return default(uint3);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		[Token(Token = "0x6000736")]
		[Address(RVA = "0x5729510", Offset = "0x5728110", VA = "0x185729510")]
		[MethodImpl(256)]
		public static uint3 uint3(int v)
		{
			return default(uint3);
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		[Token(Token = "0x6000737")]
		[Address(RVA = "0x57295A0", Offset = "0x57281A0", VA = "0x1857295A0")]
		[MethodImpl(256)]
		public static uint3 uint3(int3 v)
		{
			return default(uint3);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		[Token(Token = "0x6000738")]
		[Address(RVA = "0x5753EE0", Offset = "0x5752AE0", VA = "0x185753EE0")]
		[MethodImpl(256)]
		public static uint3 uint3(float v)
		{
			return default(uint3);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x0000CC00 File Offset: 0x0000AE00
		[Token(Token = "0x6000739")]
		[Address(RVA = "0x5753DB0", Offset = "0x57529B0", VA = "0x185753DB0")]
		[MethodImpl(256)]
		public static uint3 uint3(float3 v)
		{
			return default(uint3);
		}

		// Token: 0x0600073A RID: 1850 RVA: 0x0000CC18 File Offset: 0x0000AE18
		[Token(Token = "0x600073A")]
		[Address(RVA = "0x5753EA0", Offset = "0x5752AA0", VA = "0x185753EA0")]
		[MethodImpl(256)]
		public static uint3 uint3(double v)
		{
			return default(uint3);
		}

		// Token: 0x0600073B RID: 1851 RVA: 0x0000CC30 File Offset: 0x0000AE30
		[Token(Token = "0x600073B")]
		[Address(RVA = "0x5753E20", Offset = "0x5752A20", VA = "0x185753E20")]
		[MethodImpl(256)]
		public static uint3 uint3(double3 v)
		{
			return default(uint3);
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0000CC48 File Offset: 0x0000AE48
		[Token(Token = "0x600073C")]
		[Address(RVA = "0x571CE30", Offset = "0x571BA30", VA = "0x18571CE30")]
		[MethodImpl(256)]
		public static uint hash(uint3 v)
		{
			return 0U;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0000CC60 File Offset: 0x0000AE60
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x5727020", Offset = "0x5725C20", VA = "0x185727020")]
		[MethodImpl(256)]
		public static uint3 hashwide(uint3 v)
		{
			return default(uint3);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0000CC78 File Offset: 0x0000AE78
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x574C520", Offset = "0x574B120", VA = "0x18574C520")]
		[MethodImpl(256)]
		public static uint shuffle(uint3 left, uint3 right, math.ShuffleComponent x)
		{
			return 0U;
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0000CC90 File Offset: 0x0000AE90
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x574B860", Offset = "0x574A460", VA = "0x18574B860")]
		[MethodImpl(256)]
		public static uint2 shuffle(uint3 left, uint3 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(uint2);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0000CCA8 File Offset: 0x0000AEA8
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x574C420", Offset = "0x574B020", VA = "0x18574C420")]
		[MethodImpl(256)]
		public static uint3 shuffle(uint3 left, uint3 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(uint3);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x574BBC0", Offset = "0x574A7C0", VA = "0x18574BBC0")]
		[MethodImpl(256)]
		public static uint4 shuffle(uint3 left, uint3 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(uint4);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0000CCD8 File Offset: 0x0000AED8
		[Token(Token = "0x6000742")]
		[Address(RVA = "0x5702840", Offset = "0x5701440", VA = "0x185702840")]
		[MethodImpl(256)]
		internal static uint select_shuffle_component(uint3 a, uint3 b, math.ShuffleComponent component)
		{
			return 0U;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0000CCF0 File Offset: 0x0000AEF0
		[Token(Token = "0x6000743")]
		[Address(RVA = "0x5717440", Offset = "0x5716040", VA = "0x185717440")]
		[MethodImpl(256)]
		public static uint3x2 uint3x2(uint3 c0, uint3 c1)
		{
			return default(uint3x2);
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0000CD08 File Offset: 0x0000AF08
		[Token(Token = "0x6000744")]
		[Address(RVA = "0x57297D0", Offset = "0x57283D0", VA = "0x1857297D0")]
		[MethodImpl(256)]
		public static uint3x2 uint3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21)
		{
			return default(uint3x2);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0000CD20 File Offset: 0x0000AF20
		[Token(Token = "0x6000745")]
		[Address(RVA = "0x5729820", Offset = "0x5728420", VA = "0x185729820")]
		[MethodImpl(256)]
		public static uint3x2 uint3x2(uint v)
		{
			return default(uint3x2);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0000CD38 File Offset: 0x0000AF38
		[Token(Token = "0x6000746")]
		[Address(RVA = "0x5729860", Offset = "0x5728460", VA = "0x185729860")]
		[MethodImpl(256)]
		public static uint3x2 uint3x2(bool v)
		{
			return default(uint3x2);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0000CD50 File Offset: 0x0000AF50
		[Token(Token = "0x6000747")]
		[Address(RVA = "0x57298D0", Offset = "0x57284D0", VA = "0x1857298D0")]
		[MethodImpl(256)]
		public static uint3x2 uint3x2(bool3x2 v)
		{
			return default(uint3x2);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0000CD68 File Offset: 0x0000AF68
		[Token(Token = "0x6000748")]
		[Address(RVA = "0x5729820", Offset = "0x5728420", VA = "0x185729820")]
		[MethodImpl(256)]
		public static uint3x2 uint3x2(int v)
		{
			return default(uint3x2);
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0000CD80 File Offset: 0x0000AF80
		[Token(Token = "0x6000749")]
		[Address(RVA = "0x57296D0", Offset = "0x57282D0", VA = "0x1857296D0")]
		[MethodImpl(256)]
		public static uint3x2 uint3x2(int3x2 v)
		{
			return default(uint3x2);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0000CD98 File Offset: 0x0000AF98
		[Token(Token = "0x600074A")]
		[Address(RVA = "0x5754170", Offset = "0x5752D70", VA = "0x185754170")]
		[MethodImpl(256)]
		public static uint3x2 uint3x2(float v)
		{
			return default(uint3x2);
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		[Token(Token = "0x600074B")]
		[Address(RVA = "0x5754090", Offset = "0x5752C90", VA = "0x185754090")]
		[MethodImpl(256)]
		public static uint3x2 uint3x2(float3x2 v)
		{
			return default(uint3x2);
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		[Token(Token = "0x600074C")]
		[Address(RVA = "0x5753F20", Offset = "0x5752B20", VA = "0x185753F20")]
		[MethodImpl(256)]
		public static uint3x2 uint3x2(double v)
		{
			return default(uint3x2);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		[Token(Token = "0x600074D")]
		[Address(RVA = "0x5753FB0", Offset = "0x5752BB0", VA = "0x185753FB0")]
		[MethodImpl(256)]
		public static uint3x2 uint3x2(double3x2 v)
		{
			return default(uint3x2);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		[Token(Token = "0x600074E")]
		[Address(RVA = "0x5751780", Offset = "0x5750380", VA = "0x185751780")]
		[MethodImpl(256)]
		public static uint2x3 transpose(uint3x2 v)
		{
			return default(uint2x3);
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x0000CE10 File Offset: 0x0000B010
		[Token(Token = "0x600074F")]
		[Address(RVA = "0x571D660", Offset = "0x571C260", VA = "0x18571D660")]
		[MethodImpl(256)]
		public static uint hash(uint3x2 v)
		{
			return 0U;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0000CE28 File Offset: 0x0000B028
		[Token(Token = "0x6000750")]
		[Address(RVA = "0x5725C30", Offset = "0x5724830", VA = "0x185725C30")]
		[MethodImpl(256)]
		public static uint3 hashwide(uint3x2 v)
		{
			return default(uint3);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0000CE40 File Offset: 0x0000B040
		[Token(Token = "0x6000751")]
		[Address(RVA = "0x5717C20", Offset = "0x5716820", VA = "0x185717C20")]
		[MethodImpl(256)]
		public static uint3x3 uint3x3(uint3 c0, uint3 c1, uint3 c2)
		{
			return default(uint3x3);
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0000CE58 File Offset: 0x0000B058
		[Token(Token = "0x6000752")]
		[Address(RVA = "0x5729CF0", Offset = "0x57288F0", VA = "0x185729CF0")]
		[MethodImpl(256)]
		public static uint3x3 uint3x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22)
		{
			return default(uint3x3);
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x0000CE70 File Offset: 0x0000B070
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x5729A30", Offset = "0x5728630", VA = "0x185729A30")]
		[MethodImpl(256)]
		public static uint3x3 uint3x3(uint v)
		{
			return default(uint3x3);
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x0000CE88 File Offset: 0x0000B088
		[Token(Token = "0x6000754")]
		[Address(RVA = "0x5729ED0", Offset = "0x5728AD0", VA = "0x185729ED0")]
		[MethodImpl(256)]
		public static uint3x3 uint3x3(bool v)
		{
			return default(uint3x3);
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x0000CEA0 File Offset: 0x0000B0A0
		[Token(Token = "0x6000755")]
		[Address(RVA = "0x5729DB0", Offset = "0x57289B0", VA = "0x185729DB0")]
		[MethodImpl(256)]
		public static uint3x3 uint3x3(bool3x3 v)
		{
			return default(uint3x3);
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0000CEB8 File Offset: 0x0000B0B8
		[Token(Token = "0x6000756")]
		[Address(RVA = "0x5729A30", Offset = "0x5728630", VA = "0x185729A30")]
		[MethodImpl(256)]
		public static uint3x3 uint3x3(int v)
		{
			return default(uint3x3);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x5729AD0", Offset = "0x57286D0", VA = "0x185729AD0")]
		[MethodImpl(256)]
		public static uint3x3 uint3x3(int3x3 v)
		{
			return default(uint3x3);
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0000CEE8 File Offset: 0x0000B0E8
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x5754410", Offset = "0x5753010", VA = "0x185754410")]
		[MethodImpl(256)]
		public static uint3x3 uint3x3(float v)
		{
			return default(uint3x3);
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0000CF00 File Offset: 0x0000B100
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x57542D0", Offset = "0x5752ED0", VA = "0x1857542D0")]
		[MethodImpl(256)]
		public static uint3x3 uint3x3(float3x3 v)
		{
			return default(uint3x3);
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0000CF18 File Offset: 0x0000B118
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x5754200", Offset = "0x5752E00", VA = "0x185754200")]
		[MethodImpl(256)]
		public static uint3x3 uint3x3(double v)
		{
			return default(uint3x3);
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0000CF30 File Offset: 0x0000B130
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x57544E0", Offset = "0x57530E0", VA = "0x1857544E0")]
		[MethodImpl(256)]
		public static uint3x3 uint3x3(double3x3 v)
		{
			return default(uint3x3);
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0000CF48 File Offset: 0x0000B148
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x5751D80", Offset = "0x5750980", VA = "0x185751D80")]
		[MethodImpl(256)]
		public static uint3x3 transpose(uint3x3 v)
		{
			return default(uint3x3);
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0000CF60 File Offset: 0x0000B160
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x5720EF0", Offset = "0x571FAF0", VA = "0x185720EF0")]
		[MethodImpl(256)]
		public static uint hash(uint3x3 v)
		{
			return 0U;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0000CF78 File Offset: 0x0000B178
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x5726870", Offset = "0x5725470", VA = "0x185726870")]
		[MethodImpl(256)]
		public static uint3 hashwide(uint3x3 v)
		{
			return default(uint3);
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0000CF90 File Offset: 0x0000B190
		[Token(Token = "0x600075F")]
		[Address(RVA = "0x5718550", Offset = "0x5717150", VA = "0x185718550")]
		[MethodImpl(256)]
		public static uint3x4 uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3)
		{
			return default(uint3x4);
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x572A310", Offset = "0x5728F10", VA = "0x18572A310")]
		[MethodImpl(256)]
		public static uint3x4 uint3x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23)
		{
			return default(uint3x4);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0000CFC0 File Offset: 0x0000B1C0
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x572A120", Offset = "0x5728D20", VA = "0x18572A120")]
		[MethodImpl(256)]
		public static uint3x4 uint3x4(uint v)
		{
			return default(uint3x4);
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0000CFD8 File Offset: 0x0000B1D8
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x5729F70", Offset = "0x5728B70", VA = "0x185729F70")]
		[MethodImpl(256)]
		public static uint3x4 uint3x4(bool v)
		{
			return default(uint3x4);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0000CFF0 File Offset: 0x0000B1F0
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x572A0E0", Offset = "0x5728CE0", VA = "0x18572A0E0")]
		[MethodImpl(256)]
		public static uint3x4 uint3x4(bool3x4 v)
		{
			return default(uint3x4);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0000D008 File Offset: 0x0000B208
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x572A120", Offset = "0x5728D20", VA = "0x18572A120")]
		[MethodImpl(256)]
		public static uint3x4 uint3x4(int v)
		{
			return default(uint3x4);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0000D020 File Offset: 0x0000B220
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x572A3A0", Offset = "0x5728FA0", VA = "0x18572A3A0")]
		[MethodImpl(256)]
		public static uint3x4 uint3x4(int3x4 v)
		{
			return default(uint3x4);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0000D038 File Offset: 0x0000B238
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x5754800", Offset = "0x5753400", VA = "0x185754800")]
		[MethodImpl(256)]
		public static uint3x4 uint3x4(float v)
		{
			return default(uint3x4);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0000D050 File Offset: 0x0000B250
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x57547B0", Offset = "0x57533B0", VA = "0x1857547B0")]
		[MethodImpl(256)]
		public static uint3x4 uint3x4(float3x4 v)
		{
			return default(uint3x4);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0000D068 File Offset: 0x0000B268
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x5754640", Offset = "0x5753240", VA = "0x185754640")]
		[MethodImpl(256)]
		public static uint3x4 uint3x4(double v)
		{
			return default(uint3x4);
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0000D080 File Offset: 0x0000B280
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x5754740", Offset = "0x5753340", VA = "0x185754740")]
		[MethodImpl(256)]
		public static uint3x4 uint3x4(double3x4 v)
		{
			return default(uint3x4);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0000D098 File Offset: 0x0000B298
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x57518C0", Offset = "0x57504C0", VA = "0x1857518C0")]
		[MethodImpl(256)]
		public static uint4x3 transpose(uint3x4 v)
		{
			return default(uint4x3);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0000D0B0 File Offset: 0x0000B2B0
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x5720890", Offset = "0x571F490", VA = "0x185720890")]
		[MethodImpl(256)]
		public static uint hash(uint3x4 v)
		{
			return 0U;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0000D0C8 File Offset: 0x0000B2C8
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x5727A90", Offset = "0x5726690", VA = "0x185727A90")]
		[MethodImpl(256)]
		public static uint3 hashwide(uint3x4 v)
		{
			return default(uint3);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0000D0E0 File Offset: 0x0000B2E0
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x5709240", Offset = "0x5707E40", VA = "0x185709240")]
		[MethodImpl(256)]
		public static uint4 uint4(uint x, uint y, uint z, uint w)
		{
			return default(uint4);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0000D0F8 File Offset: 0x0000B2F8
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x572A610", Offset = "0x5729210", VA = "0x18572A610")]
		[MethodImpl(256)]
		public static uint4 uint4(uint x, uint y, uint2 zw)
		{
			return default(uint4);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0000D110 File Offset: 0x0000B310
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x572A690", Offset = "0x5729290", VA = "0x18572A690")]
		[MethodImpl(256)]
		public static uint4 uint4(uint x, uint2 yz, uint w)
		{
			return default(uint4);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0000D128 File Offset: 0x0000B328
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x572A4F0", Offset = "0x57290F0", VA = "0x18572A4F0")]
		[MethodImpl(256)]
		public static uint4 uint4(uint x, uint3 yzw)
		{
			return default(uint4);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0000D140 File Offset: 0x0000B340
		[Token(Token = "0x6000771")]
		[Address(RVA = "0x572A630", Offset = "0x5729230", VA = "0x18572A630")]
		[MethodImpl(256)]
		public static uint4 uint4(uint2 xy, uint z, uint w)
		{
			return default(uint4);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0000D158 File Offset: 0x0000B358
		[Token(Token = "0x6000772")]
		[Address(RVA = "0x572A5F0", Offset = "0x57291F0", VA = "0x18572A5F0")]
		[MethodImpl(256)]
		public static uint4 uint4(uint2 xy, uint2 zw)
		{
			return default(uint4);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0000D170 File Offset: 0x0000B370
		[Token(Token = "0x6000773")]
		[Address(RVA = "0x572A650", Offset = "0x5729250", VA = "0x18572A650")]
		[MethodImpl(256)]
		public static uint4 uint4(uint3 xyz, uint w)
		{
			return default(uint4);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0000D188 File Offset: 0x0000B388
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x572A480", Offset = "0x5729080", VA = "0x18572A480")]
		[MethodImpl(256)]
		public static uint4 uint4(uint4 xyzw)
		{
			return default(uint4);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x572A4C0", Offset = "0x57290C0", VA = "0x18572A4C0")]
		[MethodImpl(256)]
		public static uint4 uint4(uint v)
		{
			return default(uint4);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x572A4D0", Offset = "0x57290D0", VA = "0x18572A4D0")]
		[MethodImpl(256)]
		public static uint4 uint4(bool v)
		{
			return default(uint4);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0000D1D0 File Offset: 0x0000B3D0
		[Token(Token = "0x6000777")]
		[Address(RVA = "0x572A530", Offset = "0x5729130", VA = "0x18572A530")]
		[MethodImpl(256)]
		public static uint4 uint4(bool4 v)
		{
			return default(uint4);
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0000D1E8 File Offset: 0x0000B3E8
		[Token(Token = "0x6000778")]
		[Address(RVA = "0x572A4C0", Offset = "0x57290C0", VA = "0x18572A4C0")]
		[MethodImpl(256)]
		public static uint4 uint4(int v)
		{
			return default(uint4);
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0000D200 File Offset: 0x0000B400
		[Token(Token = "0x6000779")]
		[Address(RVA = "0x572A480", Offset = "0x5729080", VA = "0x18572A480")]
		[MethodImpl(256)]
		public static uint4 uint4(int4 v)
		{
			return default(uint4);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0000D218 File Offset: 0x0000B418
		[Token(Token = "0x600077A")]
		[Address(RVA = "0x5754990", Offset = "0x5753590", VA = "0x185754990")]
		[MethodImpl(256)]
		public static uint4 uint4(float v)
		{
			return default(uint4);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0000D230 File Offset: 0x0000B430
		[Token(Token = "0x600077B")]
		[Address(RVA = "0x5754A30", Offset = "0x5753630", VA = "0x185754A30")]
		[MethodImpl(256)]
		public static uint4 uint4(float4 v)
		{
			return default(uint4);
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0000D248 File Offset: 0x0000B448
		[Token(Token = "0x600077C")]
		[Address(RVA = "0x57549E0", Offset = "0x57535E0", VA = "0x1857549E0")]
		[MethodImpl(256)]
		public static uint4 uint4(double v)
		{
			return default(uint4);
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0000D260 File Offset: 0x0000B460
		[Token(Token = "0x600077D")]
		[Address(RVA = "0x5754900", Offset = "0x5753500", VA = "0x185754900")]
		[MethodImpl(256)]
		public static uint4 uint4(double4 v)
		{
			return default(uint4);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0000D278 File Offset: 0x0000B478
		[Token(Token = "0x600077E")]
		[Address(RVA = "0x571BFB0", Offset = "0x571ABB0", VA = "0x18571BFB0")]
		[MethodImpl(256)]
		public static uint hash(uint4 v)
		{
			return 0U;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0000D290 File Offset: 0x0000B490
		[Token(Token = "0x600077F")]
		[Address(RVA = "0x5723080", Offset = "0x5721C80", VA = "0x185723080")]
		[MethodImpl(256)]
		public static uint4 hashwide(uint4 v)
		{
			return default(uint4);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0000D2A8 File Offset: 0x0000B4A8
		[Token(Token = "0x6000780")]
		[Address(RVA = "0x574AC60", Offset = "0x5749860", VA = "0x18574AC60")]
		[MethodImpl(256)]
		public static uint shuffle(uint4 left, uint4 right, math.ShuffleComponent x)
		{
			return 0U;
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		[Token(Token = "0x6000781")]
		[Address(RVA = "0x574A660", Offset = "0x5749260", VA = "0x18574A660")]
		[MethodImpl(256)]
		public static uint2 shuffle(uint4 left, uint4 right, math.ShuffleComponent x, math.ShuffleComponent y)
		{
			return default(uint2);
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		[Token(Token = "0x6000782")]
		[Address(RVA = "0x574B380", Offset = "0x5749F80", VA = "0x18574B380")]
		[MethodImpl(256)]
		public static uint3 shuffle(uint4 left, uint4 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z)
		{
			return default(uint3);
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0000D2F0 File Offset: 0x0000B4F0
		[Token(Token = "0x6000783")]
		[Address(RVA = "0x574BEB0", Offset = "0x574AAB0", VA = "0x18574BEB0")]
		[MethodImpl(256)]
		public static uint4 shuffle(uint4 left, uint4 right, math.ShuffleComponent x, math.ShuffleComponent y, math.ShuffleComponent z, math.ShuffleComponent w)
		{
			return default(uint4);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0000D308 File Offset: 0x0000B508
		[Token(Token = "0x6000784")]
		[Address(RVA = "0x5702DC0", Offset = "0x57019C0", VA = "0x185702DC0")]
		[MethodImpl(256)]
		internal static uint select_shuffle_component(uint4 a, uint4 b, math.ShuffleComponent component)
		{
			return 0U;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0000D320 File Offset: 0x0000B520
		[Token(Token = "0x6000785")]
		[Address(RVA = "0x5718C40", Offset = "0x5717840", VA = "0x185718C40")]
		[MethodImpl(256)]
		public static uint4x2 uint4x2(uint4 c0, uint4 c1)
		{
			return default(uint4x2);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0000D338 File Offset: 0x0000B538
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x572AA70", Offset = "0x5729670", VA = "0x18572AA70")]
		[MethodImpl(256)]
		public static uint4x2 uint4x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21, uint m30, uint m31)
		{
			return default(uint4x2);
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0000D350 File Offset: 0x0000B550
		[Token(Token = "0x6000787")]
		[Address(RVA = "0x572A7B0", Offset = "0x57293B0", VA = "0x18572A7B0")]
		[MethodImpl(256)]
		public static uint4x2 uint4x2(uint v)
		{
			return default(uint4x2);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0000D368 File Offset: 0x0000B568
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x5754BD0", Offset = "0x57537D0", VA = "0x185754BD0")]
		[MethodImpl(256)]
		public static uint4x2 uint4x2(bool v)
		{
			return default(uint4x2);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x0000D380 File Offset: 0x0000B580
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x5754AB0", Offset = "0x57536B0", VA = "0x185754AB0")]
		[MethodImpl(256)]
		public static uint4x2 uint4x2(bool4x2 v)
		{
			return default(uint4x2);
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x0000D398 File Offset: 0x0000B598
		[Token(Token = "0x600078A")]
		[Address(RVA = "0x572A7B0", Offset = "0x57293B0", VA = "0x18572A7B0")]
		[MethodImpl(256)]
		public static uint4x2 uint4x2(int v)
		{
			return default(uint4x2);
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0000D3B0 File Offset: 0x0000B5B0
		[Token(Token = "0x600078B")]
		[Address(RVA = "0x572A7F0", Offset = "0x57293F0", VA = "0x18572A7F0")]
		[MethodImpl(256)]
		public static uint4x2 uint4x2(int4x2 v)
		{
			return default(uint4x2);
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0000D3C8 File Offset: 0x0000B5C8
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x5754C60", Offset = "0x5753860", VA = "0x185754C60")]
		[MethodImpl(256)]
		public static uint4x2 uint4x2(float v)
		{
			return default(uint4x2);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x5754E30", Offset = "0x5753A30", VA = "0x185754E30")]
		[MethodImpl(256)]
		public static uint4x2 uint4x2(float4x2 v)
		{
			return default(uint4x2);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0000D3F8 File Offset: 0x0000B5F8
		[Token(Token = "0x600078E")]
		[Address(RVA = "0x5754F40", Offset = "0x5753B40", VA = "0x185754F40")]
		[MethodImpl(256)]
		public static uint4x2 uint4x2(double v)
		{
			return default(uint4x2);
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0000D410 File Offset: 0x0000B610
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x5754D20", Offset = "0x5753920", VA = "0x185754D20")]
		[MethodImpl(256)]
		public static uint4x2 uint4x2(double4x2 v)
		{
			return default(uint4x2);
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0000D428 File Offset: 0x0000B628
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x57517F0", Offset = "0x57503F0", VA = "0x1857517F0")]
		[MethodImpl(256)]
		public static uint2x4 transpose(uint4x2 v)
		{
			return default(uint2x4);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0000D440 File Offset: 0x0000B640
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x5721180", Offset = "0x571FD80", VA = "0x185721180")]
		[MethodImpl(256)]
		public static uint hash(uint4x2 v)
		{
			return 0U;
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0000D458 File Offset: 0x0000B658
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x5721F40", Offset = "0x5720B40", VA = "0x185721F40")]
		[MethodImpl(256)]
		public static uint4 hashwide(uint4x2 v)
		{
			return default(uint4);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0000D470 File Offset: 0x0000B670
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x57197C0", Offset = "0x57183C0", VA = "0x1857197C0")]
		[MethodImpl(256)]
		public static uint4x3 uint4x3(uint4 c0, uint4 c1, uint4 c2)
		{
			return default(uint4x3);
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0000D488 File Offset: 0x0000B688
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x572ACC0", Offset = "0x57298C0", VA = "0x18572ACC0")]
		[MethodImpl(256)]
		public static uint4x3 uint4x3(uint m00, uint m01, uint m02, uint m10, uint m11, uint m12, uint m20, uint m21, uint m22, uint m30, uint m31, uint m32)
		{
			return default(uint4x3);
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		[Token(Token = "0x6000795")]
		[Address(RVA = "0x572AB20", Offset = "0x5729720", VA = "0x18572AB20")]
		[MethodImpl(256)]
		public static uint4x3 uint4x3(uint v)
		{
			return default(uint4x3);
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0000D4B8 File Offset: 0x0000B6B8
		[Token(Token = "0x6000796")]
		[Address(RVA = "0x5755320", Offset = "0x5753F20", VA = "0x185755320")]
		[MethodImpl(256)]
		public static uint4x3 uint4x3(bool v)
		{
			return default(uint4x3);
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		[Token(Token = "0x6000797")]
		[Address(RVA = "0x57552E0", Offset = "0x5753EE0", VA = "0x1857552E0")]
		[MethodImpl(256)]
		public static uint4x3 uint4x3(bool4x3 v)
		{
			return default(uint4x3);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		[Token(Token = "0x6000798")]
		[Address(RVA = "0x572AB20", Offset = "0x5729720", VA = "0x18572AB20")]
		[MethodImpl(256)]
		public static uint4x3 uint4x3(int v)
		{
			return default(uint4x3);
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0000D500 File Offset: 0x0000B700
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x572AD40", Offset = "0x5729940", VA = "0x18572AD40")]
		[MethodImpl(256)]
		public static uint4x3 uint4x3(int4x3 v)
		{
			return default(uint4x3);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0000D518 File Offset: 0x0000B718
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x57550C0", Offset = "0x5753CC0", VA = "0x1857550C0")]
		[MethodImpl(256)]
		public static uint4x3 uint4x3(float v)
		{
			return default(uint4x3);
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0000D530 File Offset: 0x0000B730
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x5755000", Offset = "0x5753C00", VA = "0x185755000")]
		[MethodImpl(256)]
		public static uint4x3 uint4x3(float4x3 v)
		{
			return default(uint4x3);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x0000D548 File Offset: 0x0000B748
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x57551D0", Offset = "0x5753DD0", VA = "0x1857551D0")]
		[MethodImpl(256)]
		public static uint4x3 uint4x3(double v)
		{
			return default(uint4x3);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0000D560 File Offset: 0x0000B760
		[Token(Token = "0x600079D")]
		[Address(RVA = "0x5755050", Offset = "0x5753C50", VA = "0x185755050")]
		[MethodImpl(256)]
		public static uint4x3 uint4x3(double4x3 v)
		{
			return default(uint4x3);
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0000D578 File Offset: 0x0000B778
		[Token(Token = "0x600079E")]
		[Address(RVA = "0x5751C00", Offset = "0x5750800", VA = "0x185751C00")]
		[MethodImpl(256)]
		public static uint3x4 transpose(uint4x3 v)
		{
			return default(uint3x4);
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x0000D590 File Offset: 0x0000B790
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x571E4A0", Offset = "0x571D0A0", VA = "0x18571E4A0")]
		[MethodImpl(256)]
		public static uint hash(uint4x3 v)
		{
			return 0U;
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x0000D5A8 File Offset: 0x0000B7A8
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x5725D40", Offset = "0x5724940", VA = "0x185725D40")]
		[MethodImpl(256)]
		public static uint4 hashwide(uint4x3 v)
		{
			return default(uint4);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x5719BA0", Offset = "0x57187A0", VA = "0x185719BA0")]
		[MethodImpl(256)]
		public static uint4x4 uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3)
		{
			return default(uint4x4);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x572B380", Offset = "0x5729F80", VA = "0x18572B380")]
		[MethodImpl(256)]
		public static uint4x4 uint4x4(uint m00, uint m01, uint m02, uint m03, uint m10, uint m11, uint m12, uint m13, uint m20, uint m21, uint m22, uint m23, uint m30, uint m31, uint m32, uint m33)
		{
			return default(uint4x4);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x0000D5F0 File Offset: 0x0000B7F0
		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x572B040", Offset = "0x5729C40", VA = "0x18572B040")]
		[MethodImpl(256)]
		public static uint4x4 uint4x4(uint v)
		{
			return default(uint4x4);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0000D608 File Offset: 0x0000B808
		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x57553F0", Offset = "0x5753FF0", VA = "0x1857553F0")]
		[MethodImpl(256)]
		public static uint4x4 uint4x4(bool v)
		{
			return default(uint4x4);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x0000D620 File Offset: 0x0000B820
		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x5755560", Offset = "0x5754160", VA = "0x185755560")]
		[MethodImpl(256)]
		public static uint4x4 uint4x4(bool4x4 v)
		{
			return default(uint4x4);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x0000D638 File Offset: 0x0000B838
		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x572B040", Offset = "0x5729C40", VA = "0x18572B040")]
		[MethodImpl(256)]
		public static uint4x4 uint4x4(int v)
		{
			return default(uint4x4);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0000D650 File Offset: 0x0000B850
		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x572B150", Offset = "0x5729D50", VA = "0x18572B150")]
		[MethodImpl(256)]
		public static uint4x4 uint4x4(int4x4 v)
		{
			return default(uint4x4);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x0000D668 File Offset: 0x0000B868
		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x5755620", Offset = "0x5754220", VA = "0x185755620")]
		[MethodImpl(256)]
		public static uint4x4 uint4x4(float v)
		{
			return default(uint4x4);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x0000D680 File Offset: 0x0000B880
		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x5755500", Offset = "0x5754100", VA = "0x185755500")]
		[MethodImpl(256)]
		public static uint4x4 uint4x4(float4x4 v)
		{
			return default(uint4x4);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x0000D698 File Offset: 0x0000B898
		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x5755650", Offset = "0x5754250", VA = "0x185755650")]
		[MethodImpl(256)]
		public static uint4x4 uint4x4(double v)
		{
			return default(uint4x4);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x57555A0", Offset = "0x57541A0", VA = "0x1857555A0")]
		[MethodImpl(256)]
		public static uint4x4 uint4x4(double4x4 v)
		{
			return default(uint4x4);
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x0000D6C8 File Offset: 0x0000B8C8
		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x5752000", Offset = "0x5750C00", VA = "0x185752000")]
		[MethodImpl(256)]
		public static uint4x4 transpose(uint4x4 v)
		{
			return default(uint4x4);
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0000D6E0 File Offset: 0x0000B8E0
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x571DBD0", Offset = "0x571C7D0", VA = "0x18571DBD0")]
		[MethodImpl(256)]
		public static uint hash(uint4x4 v)
		{
			return 0U;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x5722BD0", Offset = "0x57217D0", VA = "0x185722BD0")]
		[MethodImpl(256)]
		public static uint4 hashwide(uint4x4 v)
		{
			return default(uint4);
		}

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		public const double E_DBL = 2.718281828459045;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		public const double LOG2E_DBL = 1.4426950408889634;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		public const double LOG10E_DBL = 0.4342944819032518;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		public const double LN2_DBL = 0.6931471805599453;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		public const double LN10_DBL = 2.302585092994046;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		public const double PI_DBL = 3.141592653589793;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		public const double SQRT2_DBL = 1.4142135623730951;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		public const double EPSILON_DBL = 2.220446049250313E-16;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		public const double INFINITY_DBL = double.PositiveInfinity;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		public const double NAN_DBL = double.NaN;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		public const float FLT_MIN_NORMAL = 1.1754944E-38f;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		public const double DBL_MIN_NORMAL = 2.2250738585072014E-308;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		public const float E = 2.7182817f;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		public const float LOG2E = 1.442695f;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		public const float LOG10E = 0.4342945f;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		public const float LN2 = 0.6931472f;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		public const float LN10 = 2.3025851f;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		public const float PI = 3.1415927f;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		public const float SQRT2 = 1.4142135f;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		public const float EPSILON = 1.1920929E-07f;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		public const float INFINITY = float.PositiveInfinity;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		public const float NAN = float.NaN;

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		public enum RotationOrder : byte
		{
			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			XYZ,
			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400001D")]
			XZY,
			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			YXZ,
			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			YZX,
			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			ZXY,
			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			ZYX,
			// Token: 0x04000022 RID: 34
			[Token(Token = "0x4000022")]
			Default = 4
		}

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		public enum ShuffleComponent : byte
		{
			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			LeftX,
			// Token: 0x04000025 RID: 37
			[Token(Token = "0x4000025")]
			LeftY,
			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			LeftZ,
			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			LeftW,
			// Token: 0x04000028 RID: 40
			[Token(Token = "0x4000028")]
			RightX,
			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			RightY,
			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			RightZ,
			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			RightW
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		[StructLayout(2)]
		internal struct IntFloatUnion
		{
			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int intValue;

			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float floatValue;
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		[StructLayout(2)]
		internal struct LongDoubleUnion
		{
			// Token: 0x0400002E RID: 46
			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public long longValue;

			// Token: 0x0400002F RID: 47
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public double doubleValue;
		}
	}
}
