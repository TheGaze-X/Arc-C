using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[Il2CppEagerStaticClassConstruction]
	[DebuggerTypeProxy(typeof(float3.DebuggerProxy))]
	[Serializable]
	public struct float3 : IEquatable<float3>, IFormattable
	{
		// Token: 0x0600113E RID: 4414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113E")]
		[Address(RVA = "0x36DB840", Offset = "0x36DA440", VA = "0x1836DB840")]
		[MethodImpl(256)]
		public float3(float x, float y, float z)
		{
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600113F")]
		[Address(RVA = "0x57B06C0", Offset = "0x57AF2C0", VA = "0x1857B06C0")]
		[MethodImpl(256)]
		public float3(float x, float2 yz)
		{
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001140")]
		[Address(RVA = "0x57B05A0", Offset = "0x57AF1A0", VA = "0x1857B05A0")]
		[MethodImpl(256)]
		public float3(float2 xy, float z)
		{
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001141")]
		[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
		[MethodImpl(256)]
		public float3(float3 xyz)
		{
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001142")]
		[Address(RVA = "0x57B0680", Offset = "0x57AF280", VA = "0x1857B0680")]
		[MethodImpl(256)]
		public float3(float v)
		{
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001143")]
		[Address(RVA = "0x57B05C0", Offset = "0x57AF1C0", VA = "0x1857B05C0")]
		[MethodImpl(256)]
		public float3(bool v)
		{
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001144")]
		[Address(RVA = "0x57B0610", Offset = "0x57AF210", VA = "0x1857B0610")]
		[MethodImpl(256)]
		public float3(bool3 v)
		{
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001145")]
		[Address(RVA = "0x57B0540", Offset = "0x57AF140", VA = "0x1857B0540")]
		[MethodImpl(256)]
		public float3(int v)
		{
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001146")]
		[Address(RVA = "0x57B0690", Offset = "0x57AF290", VA = "0x1857B0690")]
		[MethodImpl(256)]
		public float3(int3 v)
		{
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001147")]
		[Address(RVA = "0x57B05F0", Offset = "0x57AF1F0", VA = "0x1857B05F0")]
		[MethodImpl(256)]
		public float3(uint v)
		{
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001148")]
		[Address(RVA = "0x57B0560", Offset = "0x57AF160", VA = "0x1857B0560")]
		[MethodImpl(256)]
		public float3(uint3 v)
		{
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001149")]
		[Address(RVA = "0x56FD250", Offset = "0x56FBE50", VA = "0x1856FD250")]
		[MethodImpl(256)]
		public float3(half v)
		{
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114A")]
		[Address(RVA = "0x56FD100", Offset = "0x56FBD00", VA = "0x1856FD100")]
		[MethodImpl(256)]
		public float3(half3 v)
		{
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114B")]
		[Address(RVA = "0x57B0660", Offset = "0x57AF260", VA = "0x1857B0660")]
		[MethodImpl(256)]
		public float3(double v)
		{
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600114C")]
		[Address(RVA = "0x57B06E0", Offset = "0x57AF2E0", VA = "0x1857B06E0")]
		[MethodImpl(256)]
		public float3(double3 v)
		{
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00019140 File Offset: 0x00017340
		[Token(Token = "0x600114D")]
		[Address(RVA = "0x57170E0", Offset = "0x5715CE0", VA = "0x1857170E0")]
		[MethodImpl(256)]
		public static implicit operator float3(float v)
		{
			return default(float3);
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00019158 File Offset: 0x00017358
		[Token(Token = "0x600114E")]
		[Address(RVA = "0x5716B90", Offset = "0x5715790", VA = "0x185716B90")]
		[MethodImpl(256)]
		public static explicit operator float3(bool v)
		{
			return default(float3);
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00019170 File Offset: 0x00017370
		[Token(Token = "0x600114F")]
		[Address(RVA = "0x5717080", Offset = "0x5715C80", VA = "0x185717080")]
		[MethodImpl(256)]
		public static explicit operator float3(bool3 v)
		{
			return default(float3);
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x00019188 File Offset: 0x00017388
		[Token(Token = "0x6001150")]
		[Address(RVA = "0x5716C10", Offset = "0x5715810", VA = "0x185716C10")]
		[MethodImpl(256)]
		public static implicit operator float3(int v)
		{
			return default(float3);
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x000191A0 File Offset: 0x000173A0
		[Token(Token = "0x6001151")]
		[Address(RVA = "0x5717030", Offset = "0x5715C30", VA = "0x185717030")]
		[MethodImpl(256)]
		public static implicit operator float3(int3 v)
		{
			return default(float3);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x000191B8 File Offset: 0x000173B8
		[Token(Token = "0x6001152")]
		[Address(RVA = "0x5717010", Offset = "0x5715C10", VA = "0x185717010")]
		[MethodImpl(256)]
		public static implicit operator float3(uint v)
		{
			return default(float3);
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x000191D0 File Offset: 0x000173D0
		[Token(Token = "0x6001153")]
		[Address(RVA = "0x5716F80", Offset = "0x5715B80", VA = "0x185716F80")]
		[MethodImpl(256)]
		public static implicit operator float3(uint3 v)
		{
			return default(float3);
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x000191E8 File Offset: 0x000173E8
		[Token(Token = "0x6001154")]
		[Address(RVA = "0x57B1520", Offset = "0x57B0120", VA = "0x1857B1520")]
		[MethodImpl(256)]
		public static implicit operator float3(half v)
		{
			return default(float3);
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x00019200 File Offset: 0x00017400
		[Token(Token = "0x6001155")]
		[Address(RVA = "0x57B1550", Offset = "0x57B0150", VA = "0x1857B1550")]
		[MethodImpl(256)]
		public static implicit operator float3(half3 v)
		{
			return default(float3);
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x00019218 File Offset: 0x00017418
		[Token(Token = "0x6001156")]
		[Address(RVA = "0x5716D70", Offset = "0x5715970", VA = "0x185716D70")]
		[MethodImpl(256)]
		public static explicit operator float3(double v)
		{
			return default(float3);
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x00019230 File Offset: 0x00017430
		[Token(Token = "0x6001157")]
		[Address(RVA = "0x5716BD0", Offset = "0x57157D0", VA = "0x185716BD0")]
		[MethodImpl(256)]
		public static explicit operator float3(double3 v)
		{
			return default(float3);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00019248 File Offset: 0x00017448
		[Token(Token = "0x6001158")]
		[Address(RVA = "0x54E7600", Offset = "0x54E6200", VA = "0x1854E7600")]
		[MethodImpl(256)]
		public static float3 operator *(float3 lhs, float3 rhs)
		{
			return default(float3);
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x00019260 File Offset: 0x00017460
		[Token(Token = "0x6001159")]
		[Address(RVA = "0x57B18E0", Offset = "0x57B04E0", VA = "0x1857B18E0")]
		[MethodImpl(256)]
		public static float3 operator *(float3 lhs, float rhs)
		{
			return default(float3);
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00019278 File Offset: 0x00017478
		[Token(Token = "0x600115A")]
		[Address(RVA = "0x57B18B0", Offset = "0x57B04B0", VA = "0x1857B18B0")]
		[MethodImpl(256)]
		public static float3 operator *(float lhs, float3 rhs)
		{
			return default(float3);
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00019290 File Offset: 0x00017490
		[Token(Token = "0x600115B")]
		[Address(RVA = "0x57B1200", Offset = "0x57AFE00", VA = "0x1857B1200")]
		[MethodImpl(256)]
		public static float3 operator +(float3 lhs, float3 rhs)
		{
			return default(float3);
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x000192A8 File Offset: 0x000174A8
		[Token(Token = "0x600115C")]
		[Address(RVA = "0x57B11A0", Offset = "0x57AFDA0", VA = "0x1857B11A0")]
		[MethodImpl(256)]
		public static float3 operator +(float3 lhs, float rhs)
		{
			return default(float3);
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x000192C0 File Offset: 0x000174C0
		[Token(Token = "0x600115D")]
		[Address(RVA = "0x57B11D0", Offset = "0x57AFDD0", VA = "0x1857B11D0")]
		[MethodImpl(256)]
		public static float3 operator +(float lhs, float3 rhs)
		{
			return default(float3);
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x000192D8 File Offset: 0x000174D8
		[Token(Token = "0x600115E")]
		[Address(RVA = "0x57B1940", Offset = "0x57B0540", VA = "0x1857B1940")]
		[MethodImpl(256)]
		public static float3 operator -(float3 lhs, float3 rhs)
		{
			return default(float3);
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x000192F0 File Offset: 0x000174F0
		[Token(Token = "0x600115F")]
		[Address(RVA = "0x57B1910", Offset = "0x57B0510", VA = "0x1857B1910")]
		[MethodImpl(256)]
		public static float3 operator -(float3 lhs, float rhs)
		{
			return default(float3);
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00019308 File Offset: 0x00017508
		[Token(Token = "0x6001160")]
		[Address(RVA = "0x57B1980", Offset = "0x57B0580", VA = "0x1857B1980")]
		[MethodImpl(256)]
		public static float3 operator -(float lhs, float3 rhs)
		{
			return default(float3);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x00019320 File Offset: 0x00017520
		[Token(Token = "0x6001161")]
		[Address(RVA = "0x54E5F00", Offset = "0x54E4B00", VA = "0x1854E5F00")]
		[MethodImpl(256)]
		public static float3 operator /(float3 lhs, float3 rhs)
		{
			return default(float3);
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00019338 File Offset: 0x00017538
		[Token(Token = "0x6001162")]
		[Address(RVA = "0x57B12B0", Offset = "0x57AFEB0", VA = "0x1857B12B0")]
		[MethodImpl(256)]
		public static float3 operator /(float3 lhs, float rhs)
		{
			return default(float3);
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00019350 File Offset: 0x00017550
		[Token(Token = "0x6001163")]
		[Address(RVA = "0x57B1280", Offset = "0x57AFE80", VA = "0x1857B1280")]
		[MethodImpl(256)]
		public static float3 operator /(float lhs, float3 rhs)
		{
			return default(float3);
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00019368 File Offset: 0x00017568
		[Token(Token = "0x6001164")]
		[Address(RVA = "0x571A5D0", Offset = "0x57191D0", VA = "0x18571A5D0")]
		[MethodImpl(256)]
		public static float3 operator %(float3 lhs, float3 rhs)
		{
			return default(float3);
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00019380 File Offset: 0x00017580
		[Token(Token = "0x6001165")]
		[Address(RVA = "0x57B1850", Offset = "0x57B0450", VA = "0x1857B1850")]
		[MethodImpl(256)]
		public static float3 operator %(float3 lhs, float rhs)
		{
			return default(float3);
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00019398 File Offset: 0x00017598
		[Token(Token = "0x6001166")]
		[Address(RVA = "0x57B17F0", Offset = "0x57B03F0", VA = "0x1857B17F0")]
		[MethodImpl(256)]
		public static float3 operator %(float lhs, float3 rhs)
		{
			return default(float3);
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x000193B0 File Offset: 0x000175B0
		[Token(Token = "0x6001167")]
		[Address(RVA = "0x57B1590", Offset = "0x57B0190", VA = "0x1857B1590")]
		[MethodImpl(256)]
		public static float3 operator ++(float3 val)
		{
			return default(float3);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x000193C8 File Offset: 0x000175C8
		[Token(Token = "0x6001168")]
		[Address(RVA = "0x57B1240", Offset = "0x57AFE40", VA = "0x1857B1240")]
		[MethodImpl(256)]
		public static float3 operator --(float3 val)
		{
			return default(float3);
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x000193E0 File Offset: 0x000175E0
		[Token(Token = "0x6001169")]
		[Address(RVA = "0x57B1790", Offset = "0x57B0390", VA = "0x1857B1790")]
		[MethodImpl(256)]
		public static bool3 operator <(float3 lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x000193F8 File Offset: 0x000175F8
		[Token(Token = "0x600116A")]
		[Address(RVA = "0x57B17D0", Offset = "0x57B03D0", VA = "0x1857B17D0")]
		[MethodImpl(256)]
		public static bool3 operator <(float3 lhs, float rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00019410 File Offset: 0x00017610
		[Token(Token = "0x600116B")]
		[Address(RVA = "0x57B1760", Offset = "0x57B0360", VA = "0x1857B1760")]
		[MethodImpl(256)]
		public static bool3 operator <(float lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00019428 File Offset: 0x00017628
		[Token(Token = "0x600116C")]
		[Address(RVA = "0x57B16D0", Offset = "0x57B02D0", VA = "0x1857B16D0")]
		[MethodImpl(256)]
		public static bool3 operator <=(float3 lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00019440 File Offset: 0x00017640
		[Token(Token = "0x600116D")]
		[Address(RVA = "0x57B1740", Offset = "0x57B0340", VA = "0x1857B1740")]
		[MethodImpl(256)]
		public static bool3 operator <=(float3 lhs, float rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00019458 File Offset: 0x00017658
		[Token(Token = "0x600116E")]
		[Address(RVA = "0x57B1710", Offset = "0x57B0310", VA = "0x1857B1710")]
		[MethodImpl(256)]
		public static bool3 operator <=(float lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00019470 File Offset: 0x00017670
		[Token(Token = "0x600116F")]
		[Address(RVA = "0x57B1480", Offset = "0x57B0080", VA = "0x1857B1480")]
		[MethodImpl(256)]
		public static bool3 operator >(float3 lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00019488 File Offset: 0x00017688
		[Token(Token = "0x6001170")]
		[Address(RVA = "0x57B14F0", Offset = "0x57B00F0", VA = "0x1857B14F0")]
		[MethodImpl(256)]
		public static bool3 operator >(float3 lhs, float rhs)
		{
			return default(bool3);
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x000194A0 File Offset: 0x000176A0
		[Token(Token = "0x6001171")]
		[Address(RVA = "0x57B14C0", Offset = "0x57B00C0", VA = "0x1857B14C0")]
		[MethodImpl(256)]
		public static bool3 operator >(float lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x000194B8 File Offset: 0x000176B8
		[Token(Token = "0x6001172")]
		[Address(RVA = "0x57B13E0", Offset = "0x57AFFE0", VA = "0x1857B13E0")]
		[MethodImpl(256)]
		public static bool3 operator >=(float3 lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x000194D0 File Offset: 0x000176D0
		[Token(Token = "0x6001173")]
		[Address(RVA = "0x57B1420", Offset = "0x57B0020", VA = "0x1857B1420")]
		[MethodImpl(256)]
		public static bool3 operator >=(float3 lhs, float rhs)
		{
			return default(bool3);
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x000194E8 File Offset: 0x000176E8
		[Token(Token = "0x6001174")]
		[Address(RVA = "0x57B1450", Offset = "0x57B0050", VA = "0x1857B1450")]
		[MethodImpl(256)]
		public static bool3 operator >=(float lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00019500 File Offset: 0x00017700
		[Token(Token = "0x6001175")]
		[Address(RVA = "0x57B19B0", Offset = "0x57B05B0", VA = "0x1857B19B0")]
		[MethodImpl(256)]
		public static float3 operator -(float3 val)
		{
			return default(float3);
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00019518 File Offset: 0x00017718
		[Token(Token = "0x6001176")]
		[Address(RVA = "0x576B480", Offset = "0x576A080", VA = "0x18576B480")]
		[MethodImpl(256)]
		public static float3 operator +(float3 val)
		{
			return default(float3);
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00019530 File Offset: 0x00017730
		[Token(Token = "0x6001177")]
		[Address(RVA = "0x57B12E0", Offset = "0x57AFEE0", VA = "0x1857B12E0")]
		[MethodImpl(256)]
		public static bool3 operator ==(float3 lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00019548 File Offset: 0x00017748
		[Token(Token = "0x6001178")]
		[Address(RVA = "0x57B1340", Offset = "0x57AFF40", VA = "0x1857B1340")]
		[MethodImpl(256)]
		public static bool3 operator ==(float3 lhs, float rhs)
		{
			return default(bool3);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00019560 File Offset: 0x00017760
		[Token(Token = "0x6001179")]
		[Address(RVA = "0x57B1390", Offset = "0x57AFF90", VA = "0x1857B1390")]
		[MethodImpl(256)]
		public static bool3 operator ==(float lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00019578 File Offset: 0x00017778
		[Token(Token = "0x600117A")]
		[Address(RVA = "0x57B1620", Offset = "0x57B0220", VA = "0x1857B1620")]
		[MethodImpl(256)]
		public static bool3 operator !=(float3 lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00019590 File Offset: 0x00017790
		[Token(Token = "0x600117B")]
		[Address(RVA = "0x57B1680", Offset = "0x57B0280", VA = "0x1857B1680")]
		[MethodImpl(256)]
		public static bool3 operator !=(float3 lhs, float rhs)
		{
			return default(bool3);
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x000195A8 File Offset: 0x000177A8
		[Token(Token = "0x600117C")]
		[Address(RVA = "0x57B15D0", Offset = "0x57B01D0", VA = "0x1857B15D0")]
		[MethodImpl(256)]
		public static bool3 operator !=(float lhs, float3 rhs)
		{
			return default(bool3);
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x000195C0 File Offset: 0x000177C0
		[Token(Token = "0x170003FB")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxx
		{
			[Token(Token = "0x600117D")]
			[Address(RVA = "0x57A9BA0", Offset = "0x57A87A0", VA = "0x1857A9BA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x000195D8 File Offset: 0x000177D8
		[Token(Token = "0x170003FC")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxy
		{
			[Token(Token = "0x600117E")]
			[Address(RVA = "0x57A9BB0", Offset = "0x57A87B0", VA = "0x1857A9BB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x000195F0 File Offset: 0x000177F0
		[Token(Token = "0x170003FD")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxxz
		{
			[Token(Token = "0x600117F")]
			[Address(RVA = "0x57B0710", Offset = "0x57AF310", VA = "0x1857B0710")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x00019608 File Offset: 0x00017808
		[Token(Token = "0x170003FE")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyx
		{
			[Token(Token = "0x6001180")]
			[Address(RVA = "0x57A9BF0", Offset = "0x57A87F0", VA = "0x1857A9BF0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00019620 File Offset: 0x00017820
		[Token(Token = "0x170003FF")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyy
		{
			[Token(Token = "0x6001181")]
			[Address(RVA = "0x57A9C10", Offset = "0x57A8810", VA = "0x1857A9C10")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x00019638 File Offset: 0x00017838
		[Token(Token = "0x17000400")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxyz
		{
			[Token(Token = "0x6001182")]
			[Address(RVA = "0x57B0730", Offset = "0x57AF330", VA = "0x1857B0730")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x00019650 File Offset: 0x00017850
		[Token(Token = "0x17000401")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzx
		{
			[Token(Token = "0x6001183")]
			[Address(RVA = "0x57B0770", Offset = "0x57AF370", VA = "0x1857B0770")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x00019668 File Offset: 0x00017868
		[Token(Token = "0x17000402")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzy
		{
			[Token(Token = "0x6001184")]
			[Address(RVA = "0x57B0790", Offset = "0x57AF390", VA = "0x1857B0790")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00019680 File Offset: 0x00017880
		[Token(Token = "0x17000403")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xxzz
		{
			[Token(Token = "0x6001185")]
			[Address(RVA = "0x57B07B0", Offset = "0x57AF3B0", VA = "0x1857B07B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x00019698 File Offset: 0x00017898
		[Token(Token = "0x17000404")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxx
		{
			[Token(Token = "0x6001186")]
			[Address(RVA = "0x57A9C50", Offset = "0x57A8850", VA = "0x1857A9C50")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x000196B0 File Offset: 0x000178B0
		[Token(Token = "0x17000405")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxy
		{
			[Token(Token = "0x6001187")]
			[Address(RVA = "0x57A9C70", Offset = "0x57A8870", VA = "0x1857A9C70")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001188 RID: 4488 RVA: 0x000196C8 File Offset: 0x000178C8
		[Token(Token = "0x17000406")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyxz
		{
			[Token(Token = "0x6001188")]
			[Address(RVA = "0x57B07D0", Offset = "0x57AF3D0", VA = "0x1857B07D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x000196E0 File Offset: 0x000178E0
		[Token(Token = "0x17000407")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyx
		{
			[Token(Token = "0x6001189")]
			[Address(RVA = "0x57A9CB0", Offset = "0x57A88B0", VA = "0x1857A9CB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x0600118A RID: 4490 RVA: 0x000196F8 File Offset: 0x000178F8
		[Token(Token = "0x17000408")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyy
		{
			[Token(Token = "0x600118A")]
			[Address(RVA = "0x57A9CD0", Offset = "0x57A88D0", VA = "0x1857A9CD0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x0600118B RID: 4491 RVA: 0x00019710 File Offset: 0x00017910
		[Token(Token = "0x17000409")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyyz
		{
			[Token(Token = "0x600118B")]
			[Address(RVA = "0x57B07F0", Offset = "0x57AF3F0", VA = "0x1857B07F0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x0600118C RID: 4492 RVA: 0x00019728 File Offset: 0x00017928
		[Token(Token = "0x1700040A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzx
		{
			[Token(Token = "0x600118C")]
			[Address(RVA = "0x57B0810", Offset = "0x57AF410", VA = "0x1857B0810")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x0600118D RID: 4493 RVA: 0x00019740 File Offset: 0x00017940
		[Token(Token = "0x1700040B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzy
		{
			[Token(Token = "0x600118D")]
			[Address(RVA = "0x57B0830", Offset = "0x57AF430", VA = "0x1857B0830")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x0600118E RID: 4494 RVA: 0x00019758 File Offset: 0x00017958
		[Token(Token = "0x1700040C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xyzz
		{
			[Token(Token = "0x600118E")]
			[Address(RVA = "0x57B0850", Offset = "0x57AF450", VA = "0x1857B0850")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x0600118F RID: 4495 RVA: 0x00019770 File Offset: 0x00017970
		[Token(Token = "0x1700040D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxx
		{
			[Token(Token = "0x600118F")]
			[Address(RVA = "0x57B08B0", Offset = "0x57AF4B0", VA = "0x1857B08B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001190 RID: 4496 RVA: 0x00019788 File Offset: 0x00017988
		[Token(Token = "0x1700040E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxy
		{
			[Token(Token = "0x6001190")]
			[Address(RVA = "0x57B08D0", Offset = "0x57AF4D0", VA = "0x1857B08D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001191 RID: 4497 RVA: 0x000197A0 File Offset: 0x000179A0
		[Token(Token = "0x1700040F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzxz
		{
			[Token(Token = "0x6001191")]
			[Address(RVA = "0x57B08F0", Offset = "0x57AF4F0", VA = "0x1857B08F0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001192 RID: 4498 RVA: 0x000197B8 File Offset: 0x000179B8
		[Token(Token = "0x17000410")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyx
		{
			[Token(Token = "0x6001192")]
			[Address(RVA = "0x57B0910", Offset = "0x57AF510", VA = "0x1857B0910")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001193 RID: 4499 RVA: 0x000197D0 File Offset: 0x000179D0
		[Token(Token = "0x17000411")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyy
		{
			[Token(Token = "0x6001193")]
			[Address(RVA = "0x57B0930", Offset = "0x57AF530", VA = "0x1857B0930")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001194 RID: 4500 RVA: 0x000197E8 File Offset: 0x000179E8
		[Token(Token = "0x17000412")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzyz
		{
			[Token(Token = "0x6001194")]
			[Address(RVA = "0x57B0950", Offset = "0x57AF550", VA = "0x1857B0950")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x00019800 File Offset: 0x00017A00
		[Token(Token = "0x17000413")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzx
		{
			[Token(Token = "0x6001195")]
			[Address(RVA = "0x57B0990", Offset = "0x57AF590", VA = "0x1857B0990")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x00019818 File Offset: 0x00017A18
		[Token(Token = "0x17000414")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzy
		{
			[Token(Token = "0x6001196")]
			[Address(RVA = "0x57B09B0", Offset = "0x57AF5B0", VA = "0x1857B09B0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x00019830 File Offset: 0x00017A30
		[Token(Token = "0x17000415")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 xzzz
		{
			[Token(Token = "0x6001197")]
			[Address(RVA = "0x57B09D0", Offset = "0x57AF5D0", VA = "0x1857B09D0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001198 RID: 4504 RVA: 0x00019848 File Offset: 0x00017A48
		[Token(Token = "0x17000416")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxx
		{
			[Token(Token = "0x6001198")]
			[Address(RVA = "0x57A9D30", Offset = "0x57A8930", VA = "0x1857A9D30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x00019860 File Offset: 0x00017A60
		[Token(Token = "0x17000417")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxy
		{
			[Token(Token = "0x6001199")]
			[Address(RVA = "0x57A9D50", Offset = "0x57A8950", VA = "0x1857A9D50")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x00019878 File Offset: 0x00017A78
		[Token(Token = "0x17000418")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxxz
		{
			[Token(Token = "0x600119A")]
			[Address(RVA = "0x57B09F0", Offset = "0x57AF5F0", VA = "0x1857B09F0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x00019890 File Offset: 0x00017A90
		[Token(Token = "0x17000419")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyx
		{
			[Token(Token = "0x600119B")]
			[Address(RVA = "0x57A9D90", Offset = "0x57A8990", VA = "0x1857A9D90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x000198A8 File Offset: 0x00017AA8
		[Token(Token = "0x1700041A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyy
		{
			[Token(Token = "0x600119C")]
			[Address(RVA = "0x57A9DB0", Offset = "0x57A89B0", VA = "0x1857A9DB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x000198C0 File Offset: 0x00017AC0
		[Token(Token = "0x1700041B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxyz
		{
			[Token(Token = "0x600119D")]
			[Address(RVA = "0x57B0A10", Offset = "0x57AF610", VA = "0x1857B0A10")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x000198D8 File Offset: 0x00017AD8
		[Token(Token = "0x1700041C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzx
		{
			[Token(Token = "0x600119E")]
			[Address(RVA = "0x57B0A30", Offset = "0x57AF630", VA = "0x1857B0A30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x000198F0 File Offset: 0x00017AF0
		[Token(Token = "0x1700041D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzy
		{
			[Token(Token = "0x600119F")]
			[Address(RVA = "0x57B0A50", Offset = "0x57AF650", VA = "0x1857B0A50")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060011A0 RID: 4512 RVA: 0x00019908 File Offset: 0x00017B08
		[Token(Token = "0x1700041E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yxzz
		{
			[Token(Token = "0x60011A0")]
			[Address(RVA = "0x57B0A70", Offset = "0x57AF670", VA = "0x1857B0A70")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x00019920 File Offset: 0x00017B20
		[Token(Token = "0x1700041F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxx
		{
			[Token(Token = "0x60011A1")]
			[Address(RVA = "0x57A9E10", Offset = "0x57A8A10", VA = "0x1857A9E10")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x00019938 File Offset: 0x00017B38
		[Token(Token = "0x17000420")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxy
		{
			[Token(Token = "0x60011A2")]
			[Address(RVA = "0x57A9E30", Offset = "0x57A8A30", VA = "0x1857A9E30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x00019950 File Offset: 0x00017B50
		[Token(Token = "0x17000421")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyxz
		{
			[Token(Token = "0x60011A3")]
			[Address(RVA = "0x57B0A90", Offset = "0x57AF690", VA = "0x1857B0A90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x00019968 File Offset: 0x00017B68
		[Token(Token = "0x17000422")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyx
		{
			[Token(Token = "0x60011A4")]
			[Address(RVA = "0x57A9E70", Offset = "0x57A8A70", VA = "0x1857A9E70")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x00019980 File Offset: 0x00017B80
		[Token(Token = "0x17000423")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyy
		{
			[Token(Token = "0x60011A5")]
			[Address(RVA = "0x57A9E90", Offset = "0x57A8A90", VA = "0x1857A9E90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x00019998 File Offset: 0x00017B98
		[Token(Token = "0x17000424")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyyz
		{
			[Token(Token = "0x60011A6")]
			[Address(RVA = "0x57B0AB0", Offset = "0x57AF6B0", VA = "0x1857B0AB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x000199B0 File Offset: 0x00017BB0
		[Token(Token = "0x17000425")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzx
		{
			[Token(Token = "0x60011A7")]
			[Address(RVA = "0x57B0AF0", Offset = "0x57AF6F0", VA = "0x1857B0AF0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x000199C8 File Offset: 0x00017BC8
		[Token(Token = "0x17000426")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzy
		{
			[Token(Token = "0x60011A8")]
			[Address(RVA = "0x57B0B10", Offset = "0x57AF710", VA = "0x1857B0B10")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060011A9 RID: 4521 RVA: 0x000199E0 File Offset: 0x00017BE0
		[Token(Token = "0x17000427")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yyzz
		{
			[Token(Token = "0x60011A9")]
			[Address(RVA = "0x57B0B30", Offset = "0x57AF730", VA = "0x1857B0B30")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x000199F8 File Offset: 0x00017BF8
		[Token(Token = "0x17000428")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxx
		{
			[Token(Token = "0x60011AA")]
			[Address(RVA = "0x57B0B60", Offset = "0x57AF760", VA = "0x1857B0B60")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060011AB RID: 4523 RVA: 0x00019A10 File Offset: 0x00017C10
		[Token(Token = "0x17000429")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxy
		{
			[Token(Token = "0x60011AB")]
			[Address(RVA = "0x57B0B80", Offset = "0x57AF780", VA = "0x1857B0B80")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x00019A28 File Offset: 0x00017C28
		[Token(Token = "0x1700042A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzxz
		{
			[Token(Token = "0x60011AC")]
			[Address(RVA = "0x57B0BA0", Offset = "0x57AF7A0", VA = "0x1857B0BA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x00019A40 File Offset: 0x00017C40
		[Token(Token = "0x1700042B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyx
		{
			[Token(Token = "0x60011AD")]
			[Address(RVA = "0x57B0BE0", Offset = "0x57AF7E0", VA = "0x1857B0BE0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060011AE RID: 4526 RVA: 0x00019A58 File Offset: 0x00017C58
		[Token(Token = "0x1700042C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyy
		{
			[Token(Token = "0x60011AE")]
			[Address(RVA = "0x57B0C00", Offset = "0x57AF800", VA = "0x1857B0C00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x00019A70 File Offset: 0x00017C70
		[Token(Token = "0x1700042D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzyz
		{
			[Token(Token = "0x60011AF")]
			[Address(RVA = "0x57B0C20", Offset = "0x57AF820", VA = "0x1857B0C20")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060011B0 RID: 4528 RVA: 0x00019A88 File Offset: 0x00017C88
		[Token(Token = "0x1700042E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzx
		{
			[Token(Token = "0x60011B0")]
			[Address(RVA = "0x57B0C70", Offset = "0x57AF870", VA = "0x1857B0C70")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x00019AA0 File Offset: 0x00017CA0
		[Token(Token = "0x1700042F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzy
		{
			[Token(Token = "0x60011B1")]
			[Address(RVA = "0x57B0C90", Offset = "0x57AF890", VA = "0x1857B0C90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060011B2 RID: 4530 RVA: 0x00019AB8 File Offset: 0x00017CB8
		[Token(Token = "0x17000430")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 yzzz
		{
			[Token(Token = "0x60011B2")]
			[Address(RVA = "0x57B0CC0", Offset = "0x57AF8C0", VA = "0x1857B0CC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x00019AD0 File Offset: 0x00017CD0
		[Token(Token = "0x17000431")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxx
		{
			[Token(Token = "0x60011B3")]
			[Address(RVA = "0x57B0D20", Offset = "0x57AF920", VA = "0x1857B0D20")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x00019AE8 File Offset: 0x00017CE8
		[Token(Token = "0x17000432")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxy
		{
			[Token(Token = "0x60011B4")]
			[Address(RVA = "0x57B0D40", Offset = "0x57AF940", VA = "0x1857B0D40")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x00019B00 File Offset: 0x00017D00
		[Token(Token = "0x17000433")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxxz
		{
			[Token(Token = "0x60011B5")]
			[Address(RVA = "0x57B0D60", Offset = "0x57AF960", VA = "0x1857B0D60")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x00019B18 File Offset: 0x00017D18
		[Token(Token = "0x17000434")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyx
		{
			[Token(Token = "0x60011B6")]
			[Address(RVA = "0x57B0D80", Offset = "0x57AF980", VA = "0x1857B0D80")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060011B7 RID: 4535 RVA: 0x00019B30 File Offset: 0x00017D30
		[Token(Token = "0x17000435")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyy
		{
			[Token(Token = "0x60011B7")]
			[Address(RVA = "0x57B0DA0", Offset = "0x57AF9A0", VA = "0x1857B0DA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x00019B48 File Offset: 0x00017D48
		[Token(Token = "0x17000436")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxyz
		{
			[Token(Token = "0x60011B8")]
			[Address(RVA = "0x57B0DC0", Offset = "0x57AF9C0", VA = "0x1857B0DC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060011B9 RID: 4537 RVA: 0x00019B60 File Offset: 0x00017D60
		[Token(Token = "0x17000437")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzx
		{
			[Token(Token = "0x60011B9")]
			[Address(RVA = "0x57B0E00", Offset = "0x57AFA00", VA = "0x1857B0E00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x00019B78 File Offset: 0x00017D78
		[Token(Token = "0x17000438")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzy
		{
			[Token(Token = "0x60011BA")]
			[Address(RVA = "0x57B0E20", Offset = "0x57AFA20", VA = "0x1857B0E20")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x00019B90 File Offset: 0x00017D90
		[Token(Token = "0x17000439")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zxzz
		{
			[Token(Token = "0x60011BB")]
			[Address(RVA = "0x57B0E40", Offset = "0x57AFA40", VA = "0x1857B0E40")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060011BC RID: 4540 RVA: 0x00019BA8 File Offset: 0x00017DA8
		[Token(Token = "0x1700043A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxx
		{
			[Token(Token = "0x60011BC")]
			[Address(RVA = "0x57B0E80", Offset = "0x57AFA80", VA = "0x1857B0E80")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x00019BC0 File Offset: 0x00017DC0
		[Token(Token = "0x1700043B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxy
		{
			[Token(Token = "0x60011BD")]
			[Address(RVA = "0x57B0EA0", Offset = "0x57AFAA0", VA = "0x1857B0EA0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x00019BD8 File Offset: 0x00017DD8
		[Token(Token = "0x1700043C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyxz
		{
			[Token(Token = "0x60011BE")]
			[Address(RVA = "0x57B0EC0", Offset = "0x57AFAC0", VA = "0x1857B0EC0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x00019BF0 File Offset: 0x00017DF0
		[Token(Token = "0x1700043D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyx
		{
			[Token(Token = "0x60011BF")]
			[Address(RVA = "0x57B0F00", Offset = "0x57AFB00", VA = "0x1857B0F00")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x00019C08 File Offset: 0x00017E08
		[Token(Token = "0x1700043E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyy
		{
			[Token(Token = "0x60011C0")]
			[Address(RVA = "0x57B0F20", Offset = "0x57AFB20", VA = "0x1857B0F20")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060011C1 RID: 4545 RVA: 0x00019C20 File Offset: 0x00017E20
		[Token(Token = "0x1700043F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyyz
		{
			[Token(Token = "0x60011C1")]
			[Address(RVA = "0x57B0F40", Offset = "0x57AFB40", VA = "0x1857B0F40")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x00019C38 File Offset: 0x00017E38
		[Token(Token = "0x17000440")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzx
		{
			[Token(Token = "0x60011C2")]
			[Address(RVA = "0x57B0F90", Offset = "0x57AFB90", VA = "0x1857B0F90")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x00019C50 File Offset: 0x00017E50
		[Token(Token = "0x17000441")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzy
		{
			[Token(Token = "0x60011C3")]
			[Address(RVA = "0x57B0FB0", Offset = "0x57AFBB0", VA = "0x1857B0FB0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x00019C68 File Offset: 0x00017E68
		[Token(Token = "0x17000442")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zyzz
		{
			[Token(Token = "0x60011C4")]
			[Address(RVA = "0x57B0FE0", Offset = "0x57AFBE0", VA = "0x1857B0FE0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x00019C80 File Offset: 0x00017E80
		[Token(Token = "0x17000443")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxx
		{
			[Token(Token = "0x60011C5")]
			[Address(RVA = "0x57B1040", Offset = "0x57AFC40", VA = "0x1857B1040")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x00019C98 File Offset: 0x00017E98
		[Token(Token = "0x17000444")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxy
		{
			[Token(Token = "0x60011C6")]
			[Address(RVA = "0x57B1060", Offset = "0x57AFC60", VA = "0x1857B1060")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060011C7 RID: 4551 RVA: 0x00019CB0 File Offset: 0x00017EB0
		[Token(Token = "0x17000445")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzxz
		{
			[Token(Token = "0x60011C7")]
			[Address(RVA = "0x57B1080", Offset = "0x57AFC80", VA = "0x1857B1080")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x00019CC8 File Offset: 0x00017EC8
		[Token(Token = "0x17000446")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyx
		{
			[Token(Token = "0x60011C8")]
			[Address(RVA = "0x57B10C0", Offset = "0x57AFCC0", VA = "0x1857B10C0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x00019CE0 File Offset: 0x00017EE0
		[Token(Token = "0x17000447")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyy
		{
			[Token(Token = "0x60011C9")]
			[Address(RVA = "0x57B10E0", Offset = "0x57AFCE0", VA = "0x1857B10E0")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x00019CF8 File Offset: 0x00017EF8
		[Token(Token = "0x17000448")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzyz
		{
			[Token(Token = "0x60011CA")]
			[Address(RVA = "0x57B1110", Offset = "0x57AFD10", VA = "0x1857B1110")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x00019D10 File Offset: 0x00017F10
		[Token(Token = "0x17000449")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzx
		{
			[Token(Token = "0x60011CB")]
			[Address(RVA = "0x57B1150", Offset = "0x57AFD50", VA = "0x1857B1150")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x00019D28 File Offset: 0x00017F28
		[Token(Token = "0x1700044A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzy
		{
			[Token(Token = "0x60011CC")]
			[Address(RVA = "0x57B1170", Offset = "0x57AFD70", VA = "0x1857B1170")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x060011CD RID: 4557 RVA: 0x00019D40 File Offset: 0x00017F40
		[Token(Token = "0x1700044B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float4 zzzz
		{
			[Token(Token = "0x60011CD")]
			[Address(RVA = "0x57B1190", Offset = "0x57AFD90", VA = "0x1857B1190")]
			[MethodImpl(256)]
			get
			{
				return default(float4);
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x00019D58 File Offset: 0x00017F58
		[Token(Token = "0x1700044C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxx
		{
			[Token(Token = "0x60011CE")]
			[Address(RVA = "0x57A9B80", Offset = "0x57A8780", VA = "0x1857A9B80")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x00019D70 File Offset: 0x00017F70
		[Token(Token = "0x1700044D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxy
		{
			[Token(Token = "0x60011CF")]
			[Address(RVA = "0x57A9BD0", Offset = "0x57A87D0", VA = "0x1857A9BD0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00019D88 File Offset: 0x00017F88
		[Token(Token = "0x1700044E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xxz
		{
			[Token(Token = "0x60011D0")]
			[Address(RVA = "0x57B0750", Offset = "0x57AF350", VA = "0x1857B0750")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x060011D1 RID: 4561 RVA: 0x00019DA0 File Offset: 0x00017FA0
		[Token(Token = "0x1700044F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyx
		{
			[Token(Token = "0x60011D1")]
			[Address(RVA = "0x57A9C30", Offset = "0x57A8830", VA = "0x1857A9C30")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x00019DB8 File Offset: 0x00017FB8
		[Token(Token = "0x17000450")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyy
		{
			[Token(Token = "0x60011D2")]
			[Address(RVA = "0x57A9C90", Offset = "0x57A8890", VA = "0x1857A9C90")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x00019DD0 File Offset: 0x00017FD0
		// (set) Token: 0x060011D4 RID: 4564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000451")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xyz
		{
			[Token(Token = "0x60011D3")]
			[Address(RVA = "0x576B480", Offset = "0x576A080", VA = "0x18576B480")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x60011D4")]
			[Address(RVA = "0x36DB850", Offset = "0x36DA450", VA = "0x1836DB850")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00019DE8 File Offset: 0x00017FE8
		[Token(Token = "0x17000452")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzx
		{
			[Token(Token = "0x60011D5")]
			[Address(RVA = "0x57B0890", Offset = "0x57AF490", VA = "0x1857B0890")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00019E00 File Offset: 0x00018000
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000453")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzy
		{
			[Token(Token = "0x60011D6")]
			[Address(RVA = "0x576B680", Offset = "0x576A280", VA = "0x18576B680")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x60011D7")]
			[Address(RVA = "0x576D8C0", Offset = "0x576C4C0", VA = "0x18576D8C0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x00019E18 File Offset: 0x00018018
		[Token(Token = "0x17000454")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 xzz
		{
			[Token(Token = "0x60011D8")]
			[Address(RVA = "0x57B0970", Offset = "0x57AF570", VA = "0x1857B0970")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x00019E30 File Offset: 0x00018030
		[Token(Token = "0x17000455")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxx
		{
			[Token(Token = "0x60011D9")]
			[Address(RVA = "0x57A9D10", Offset = "0x57A8910", VA = "0x1857A9D10")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x00019E48 File Offset: 0x00018048
		[Token(Token = "0x17000456")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxy
		{
			[Token(Token = "0x60011DA")]
			[Address(RVA = "0x57A9D70", Offset = "0x57A8970", VA = "0x1857A9D70")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x00019E60 File Offset: 0x00018060
		// (set) Token: 0x060011DC RID: 4572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000457")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yxz
		{
			[Token(Token = "0x60011DB")]
			[Address(RVA = "0x576BC60", Offset = "0x576A860", VA = "0x18576BC60")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x60011DC")]
			[Address(RVA = "0x576D9E0", Offset = "0x576C5E0", VA = "0x18576D9E0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x00019E78 File Offset: 0x00018078
		[Token(Token = "0x17000458")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyx
		{
			[Token(Token = "0x60011DD")]
			[Address(RVA = "0x57A9DF0", Offset = "0x57A89F0", VA = "0x1857A9DF0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x00019E90 File Offset: 0x00018090
		[Token(Token = "0x17000459")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyy
		{
			[Token(Token = "0x60011DE")]
			[Address(RVA = "0x57A9E50", Offset = "0x57A8A50", VA = "0x1857A9E50")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x00019EA8 File Offset: 0x000180A8
		[Token(Token = "0x1700045A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yyz
		{
			[Token(Token = "0x60011DF")]
			[Address(RVA = "0x57B0AD0", Offset = "0x57AF6D0", VA = "0x1857B0AD0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x00019EC0 File Offset: 0x000180C0
		// (set) Token: 0x060011E1 RID: 4577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzx
		{
			[Token(Token = "0x60011E0")]
			[Address(RVA = "0x576C050", Offset = "0x576AC50", VA = "0x18576C050")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x60011E1")]
			[Address(RVA = "0x576DA70", Offset = "0x576C670", VA = "0x18576DA70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x00019ED8 File Offset: 0x000180D8
		[Token(Token = "0x1700045C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzy
		{
			[Token(Token = "0x60011E2")]
			[Address(RVA = "0x57B0BC0", Offset = "0x57AF7C0", VA = "0x1857B0BC0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x00019EF0 File Offset: 0x000180F0
		[Token(Token = "0x1700045D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 yzz
		{
			[Token(Token = "0x60011E3")]
			[Address(RVA = "0x57B0C50", Offset = "0x57AF850", VA = "0x1857B0C50")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x00019F08 File Offset: 0x00018108
		[Token(Token = "0x1700045E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxx
		{
			[Token(Token = "0x60011E4")]
			[Address(RVA = "0x57B0D00", Offset = "0x57AF900", VA = "0x1857B0D00")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x00019F20 File Offset: 0x00018120
		// (set) Token: 0x060011E6 RID: 4582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700045F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxy
		{
			[Token(Token = "0x60011E5")]
			[Address(RVA = "0x576C610", Offset = "0x576B210", VA = "0x18576C610")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x60011E6")]
			[Address(RVA = "0x576DB90", Offset = "0x576C790", VA = "0x18576DB90")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x00019F38 File Offset: 0x00018138
		[Token(Token = "0x17000460")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zxz
		{
			[Token(Token = "0x60011E7")]
			[Address(RVA = "0x57B0DE0", Offset = "0x57AF9E0", VA = "0x1857B0DE0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00019F50 File Offset: 0x00018150
		// (set) Token: 0x060011E9 RID: 4585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000461")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyx
		{
			[Token(Token = "0x60011E8")]
			[Address(RVA = "0x576C810", Offset = "0x576B410", VA = "0x18576C810")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
			[Token(Token = "0x60011E9")]
			[Address(RVA = "0x576DC20", Offset = "0x576C820", VA = "0x18576DC20")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x00019F68 File Offset: 0x00018168
		[Token(Token = "0x17000462")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyy
		{
			[Token(Token = "0x60011EA")]
			[Address(RVA = "0x57B0EE0", Offset = "0x57AFAE0", VA = "0x1857B0EE0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x00019F80 File Offset: 0x00018180
		[Token(Token = "0x17000463")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zyz
		{
			[Token(Token = "0x60011EB")]
			[Address(RVA = "0x57B0F70", Offset = "0x57AFB70", VA = "0x1857B0F70")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x00019F98 File Offset: 0x00018198
		[Token(Token = "0x17000464")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzx
		{
			[Token(Token = "0x60011EC")]
			[Address(RVA = "0x57B1020", Offset = "0x57AFC20", VA = "0x1857B1020")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x00019FB0 File Offset: 0x000181B0
		[Token(Token = "0x17000465")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzy
		{
			[Token(Token = "0x60011ED")]
			[Address(RVA = "0x57B10A0", Offset = "0x57AFCA0", VA = "0x1857B10A0")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x00019FC8 File Offset: 0x000181C8
		[Token(Token = "0x17000466")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float3 zzz
		{
			[Token(Token = "0x60011EE")]
			[Address(RVA = "0x57B1130", Offset = "0x57AFD30", VA = "0x1857B1130")]
			[MethodImpl(256)]
			get
			{
				return default(float3);
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x060011EF RID: 4591 RVA: 0x00019FE0 File Offset: 0x000181E0
		[Token(Token = "0x17000467")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xx
		{
			[Token(Token = "0x60011EF")]
			[Address(RVA = "0x57A9B70", Offset = "0x57A8770", VA = "0x1857A9B70")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x00019FF8 File Offset: 0x000181F8
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000468")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xy
		{
			[Token(Token = "0x60011F0")]
			[Address(RVA = "0x15795C0", Offset = "0x15781C0", VA = "0x1815795C0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60011F1")]
			[Address(RVA = "0x57A9A70", Offset = "0x57A8670", VA = "0x1857A9A70")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0001A010 File Offset: 0x00018210
		// (set) Token: 0x060011F3 RID: 4595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000469")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 xz
		{
			[Token(Token = "0x60011F2")]
			[Address(RVA = "0x57B0870", Offset = "0x57AF470", VA = "0x1857B0870")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60011F3")]
			[Address(RVA = "0x57B19F0", Offset = "0x57B05F0", VA = "0x1857B19F0")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0001A028 File Offset: 0x00018228
		// (set) Token: 0x060011F5 RID: 4597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046A")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yx
		{
			[Token(Token = "0x60011F4")]
			[Address(RVA = "0x57A9CF0", Offset = "0x57A88F0", VA = "0x1857A9CF0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60011F5")]
			[Address(RVA = "0x57AA620", Offset = "0x57A9220", VA = "0x1857AA620")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x0001A040 File Offset: 0x00018240
		[Token(Token = "0x1700046B")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yy
		{
			[Token(Token = "0x60011F6")]
			[Address(RVA = "0x57A9DD0", Offset = "0x57A89D0", VA = "0x1857A9DD0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x0001A058 File Offset: 0x00018258
		// (set) Token: 0x060011F8 RID: 4600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046C")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 yz
		{
			[Token(Token = "0x60011F7")]
			[Address(RVA = "0x15ABE60", Offset = "0x15AAA60", VA = "0x1815ABE60")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60011F8")]
			[Address(RVA = "0x57B1A10", Offset = "0x57B0610", VA = "0x1857B1A10")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x0001A070 File Offset: 0x00018270
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046D")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zx
		{
			[Token(Token = "0x60011F9")]
			[Address(RVA = "0x57B0CE0", Offset = "0x57AF8E0", VA = "0x1857B0CE0")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60011FA")]
			[Address(RVA = "0x57B1A30", Offset = "0x57B0630", VA = "0x1857B1A30")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x0001A088 File Offset: 0x00018288
		// (set) Token: 0x060011FC RID: 4604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700046E")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zy
		{
			[Token(Token = "0x60011FB")]
			[Address(RVA = "0x57B0E60", Offset = "0x57AFA60", VA = "0x1857B0E60")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
			[Token(Token = "0x60011FC")]
			[Address(RVA = "0x57B1A50", Offset = "0x57B0650", VA = "0x1857B1A50")]
			[MethodImpl(256)]
			set
			{
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x0001A0A0 File Offset: 0x000182A0
		[Token(Token = "0x1700046F")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float2 zz
		{
			[Token(Token = "0x60011FD")]
			[Address(RVA = "0x57B1000", Offset = "0x57AFC00", VA = "0x1857B1000")]
			[MethodImpl(256)]
			get
			{
				return default(float2);
			}
		}

		// Token: 0x17000470 RID: 1136
		[Token(Token = "0x17000470")]
		public float this[int index]
		{
			[Token(Token = "0x60011FE")]
			[Address(RVA = "0x57A9B60", Offset = "0x57A8760", VA = "0x1857A9B60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60011FF")]
			[Address(RVA = "0x57AA610", Offset = "0x57A9210", VA = "0x1857AA610")]
			set
			{
			}
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0001A0D0 File Offset: 0x000182D0
		[Token(Token = "0x6001200")]
		[Address(RVA = "0x57B02D0", Offset = "0x57AEED0", VA = "0x1857B02D0", Slot = "4")]
		[MethodImpl(256)]
		public bool Equals(float3 rhs)
		{
			return default(bool);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0001A0E8 File Offset: 0x000182E8
		[Token(Token = "0x6001201")]
		[Address(RVA = "0x57B0300", Offset = "0x57AEF00", VA = "0x1857B0300", Slot = "0")]
		public override bool Equals(object o)
		{
			return default(bool);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0001A100 File Offset: 0x00018300
		[Token(Token = "0x6001202")]
		[Address(RVA = "0x571FA90", Offset = "0x571E690", VA = "0x18571FA90", Slot = "2")]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001203")]
		[Address(RVA = "0x57B03C0", Offset = "0x57AEFC0", VA = "0x1857B03C0", Slot = "3")]
		[MethodImpl(256)]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x000024EA File Offset: 0x000006EA
		[Token(Token = "0x6001204")]
		[Address(RVA = "0x57B0480", Offset = "0x57AF080", VA = "0x1857B0480", Slot = "5")]
		[MethodImpl(256)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			return null;
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0001A118 File Offset: 0x00018318
		[Token(Token = "0x6001205")]
		[Address(RVA = "0x576B480", Offset = "0x576A080", VA = "0x18576B480")]
		public static implicit operator Vector3(float3 v)
		{
			return default(Vector3);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0001A130 File Offset: 0x00018330
		[Token(Token = "0x6001206")]
		[Address(RVA = "0x576B480", Offset = "0x576A080", VA = "0x18576B480")]
		public static implicit operator float3(Vector3 v)
		{
			return default(float3);
		}

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float3 zero;

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		internal sealed class DebuggerProxy
		{
			// Token: 0x06001207 RID: 4615 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001207")]
			[Address(RVA = "0x57A9750", Offset = "0x57A8350", VA = "0x1857A9750")]
			public DebuggerProxy(float3 v)
			{
			}

			// Token: 0x040000AB RID: 171
			[Token(Token = "0x40000AB")]
			[FieldOffset(Offset = "0x10")]
			public float x;

			// Token: 0x040000AC RID: 172
			[Token(Token = "0x40000AC")]
			[FieldOffset(Offset = "0x14")]
			public float y;

			// Token: 0x040000AD RID: 173
			[Token(Token = "0x40000AD")]
			[FieldOffset(Offset = "0x18")]
			public float z;
		}
	}
}
