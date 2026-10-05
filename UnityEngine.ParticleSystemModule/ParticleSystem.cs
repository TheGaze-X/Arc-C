using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.ParticleSystemJobs;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[UsedByNativeCode]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystemGeometryJob.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemScriptBindings.h")]
	[NativeHeader("Modules/ParticleSystem/ParticleSystem.h")]
	[NativeHeader("ParticleSystemScriptingClasses.h")]
	[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemModulesScriptBindings.h")]
	public sealed class ParticleSystem : Component
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x59BE570", Offset = "0x59BD170", VA = "0x1859BE570")]
		[Obsolete("Emit with specific parameters is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(Vector3 position, Vector3 velocity, float size, float lifetime, Color32 color)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x59BE730", Offset = "0x59BD330", VA = "0x1859BE730")]
		[Obsolete("Emit with a single particle structure is deprecated. Pass a ParticleSystem.EmitParams parameter instead, which allows you to override some/all of the emission properties", false)]
		public void Emit(ParticleSystem.Particle particle)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002054 File Offset: 0x00000254
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		[Obsolete("startDelay property is deprecated. Use main.startDelay or main.startDelayMultiplier instead.", false)]
		public float startDelay
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x59C0380", Offset = "0x59BEF80", VA = "0x1859C0380")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x59C0BA0", Offset = "0x59BF7A0", VA = "0x1859C0BA0")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x0000206C File Offset: 0x0000026C
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		[Obsolete("loop property is deprecated. Use main.loop instead.", false)]
		public bool loop
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x59C00A0", Offset = "0x59BECA0", VA = "0x1859C00A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x59C0840", Offset = "0x59BF440", VA = "0x1859C0840")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002084 File Offset: 0x00000284
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		[Obsolete("playOnAwake property is deprecated. Use main.playOnAwake instead.", false)]
		public bool playOnAwake
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x59C0180", Offset = "0x59BED80", VA = "0x1859C0180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x59C0900", Offset = "0x59BF500", VA = "0x1859C0900")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000009 RID: 9 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x17000004")]
		[Obsolete("duration property is deprecated. Use main.duration instead.", false)]
		public float duration
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x59BFE60", Offset = "0x59BEA60", VA = "0x1859BFE60")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000020B4 File Offset: 0x000002B4
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		[Obsolete("playbackSpeed property is deprecated. Use main.simulationSpeed instead.", false)]
		public float playbackSpeed
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x59C01D0", Offset = "0x59BEDD0", VA = "0x1859C01D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x59C0960", Offset = "0x59BF560", VA = "0x1859C0960")]
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020CC File Offset: 0x000002CC
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000006")]
		[Obsolete("enableEmission property is deprecated. Use emission.enabled instead.", false)]
		public bool enableEmission
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x59BFF00", Offset = "0x59BEB00", VA = "0x1859BFF00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x59C0780", Offset = "0x59BF380", VA = "0x1859C0780")]
			set
			{
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000020E4 File Offset: 0x000002E4
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		[Obsolete("emissionRate property is deprecated. Use emission.rateOverTime, emission.rateOverDistance, emission.rateOverTimeMultiplier or emission.rateOverDistanceMultiplier instead.", false)]
		public float emissionRate
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x59BFEB0", Offset = "0x59BEAB0", VA = "0x1859BFEB0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x59C06B0", Offset = "0x59BF2B0", VA = "0x1859C06B0")]
			set
			{
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000020FC File Offset: 0x000002FC
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		[Obsolete("startSpeed property is deprecated. Use main.startSpeed or main.startSpeedMultiplier instead.", false)]
		public float startSpeed
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x59C05E0", Offset = "0x59BF1E0", VA = "0x1859C05E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x59C0DD0", Offset = "0x59BF9D0", VA = "0x1859C0DD0")]
			set
			{
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002114 File Offset: 0x00000314
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000009")]
		[Obsolete("startSize property is deprecated. Use main.startSize or main.startSizeMultiplier instead.", false)]
		public float startSize
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x59C0590", Offset = "0x59BF190", VA = "0x1859C0590")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x59C0D70", Offset = "0x59BF970", VA = "0x1859C0D70")]
			set
			{
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000212C File Offset: 0x0000032C
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		[Obsolete("startColor property is deprecated. Use main.startColor instead.", false)]
		public Color startColor
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x59C0300", Offset = "0x59BEF00", VA = "0x1859C0300")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x59C0AC0", Offset = "0x59BF6C0", VA = "0x1859C0AC0")]
			set
			{
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002144 File Offset: 0x00000344
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		[Obsolete("startRotation property is deprecated. Use main.startRotation or main.startRotationMultiplier instead.", false)]
		public float startRotation
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x59C0540", Offset = "0x59BF140", VA = "0x1859C0540")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x59C0D10", Offset = "0x59BF910", VA = "0x1859C0D10")]
			set
			{
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000215C File Offset: 0x0000035C
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000C")]
		[Obsolete("startRotation3D property is deprecated. Use main.startRotationX, main.startRotationY and main.startRotationZ instead. (Or main.startRotationXMultiplier, main.startRotationYMultiplier and main.startRotationZMultiplier).", false)]
		public Vector3 startRotation3D
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x59C0420", Offset = "0x59BF020", VA = "0x1859C0420")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x59C0C60", Offset = "0x59BF860", VA = "0x1859C0C60")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002174 File Offset: 0x00000374
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000D")]
		[Obsolete("startLifetime property is deprecated. Use main.startLifetime or main.startLifetimeMultiplier instead.", false)]
		public float startLifetime
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x59C03D0", Offset = "0x59BEFD0", VA = "0x1859C03D0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x59C0C00", Offset = "0x59BF800", VA = "0x1859C0C00")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600001C RID: 28 RVA: 0x0000218C File Offset: 0x0000038C
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000E")]
		[Obsolete("gravityModifier property is deprecated. Use main.gravityModifier or main.gravityModifierMultiplier instead.", false)]
		public float gravityModifier
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x59BFF50", Offset = "0x59BEB50", VA = "0x1859BFF50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x59C07E0", Offset = "0x59BF3E0", VA = "0x1859C07E0")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000021A4 File Offset: 0x000003A4
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		[Obsolete("maxParticles property is deprecated. Use main.maxParticles instead.", false)]
		public int maxParticles
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x59C00F0", Offset = "0x59BECF0", VA = "0x1859C00F0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x59C08A0", Offset = "0x59BF4A0", VA = "0x1859C08A0")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000021BC File Offset: 0x000003BC
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000010")]
		[Obsolete("simulationSpace property is deprecated. Use main.simulationSpace instead.", false)]
		public ParticleSystemSimulationSpace simulationSpace
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x59C02B0", Offset = "0x59BEEB0", VA = "0x1859C02B0")]
			get
			{
				return ParticleSystemSimulationSpace.Local;
			}
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x59C0A60", Offset = "0x59BF660", VA = "0x1859C0A60")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000021D4 File Offset: 0x000003D4
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		[Obsolete("scalingMode property is deprecated. Use main.scalingMode instead.", false)]
		public ParticleSystemScalingMode scalingMode
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x59C0260", Offset = "0x59BEE60", VA = "0x1859C0260")]
			get
			{
				return ParticleSystemScalingMode.Hierarchy;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x59C0A00", Offset = "0x59BF600", VA = "0x1859C0A00")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x17000012")]
		[Obsolete("automaticCullingEnabled property is deprecated. Use proceduralSimulationSupported instead (UnityUpgradable) -> proceduralSimulationSupported", true)]
		public bool automaticCullingEnabled
		{
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x59BFE20", Offset = "0x59BEA20", VA = "0x1859BFE20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000025 RID: 37
		[Token(Token = "0x17000013")]
		public extern bool isPlaying { [Token(Token = "0x6000025")] [Address(RVA = "0x59C0020", Offset = "0x59BEC20", VA = "0x1859C0020")] [NativeName("SyncJobs(false)->IsPlaying")] [MethodImpl(4096)] get; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000026 RID: 38
		[Token(Token = "0x17000014")]
		public extern bool isEmitting { [Token(Token = "0x6000026")] [Address(RVA = "0x59BFFA0", Offset = "0x59BEBA0", VA = "0x1859BFFA0")] [NativeName("SyncJobs(false)->IsEmitting")] [MethodImpl(4096)] get; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000027 RID: 39
		[Token(Token = "0x17000015")]
		public extern bool isStopped { [Token(Token = "0x6000027")] [Address(RVA = "0x59C0060", Offset = "0x59BEC60", VA = "0x1859C0060")] [NativeName("SyncJobs(false)->IsStopped")] [MethodImpl(4096)] get; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000028 RID: 40
		[Token(Token = "0x17000016")]
		public extern bool isPaused { [Token(Token = "0x6000028")] [Address(RVA = "0x59BFFE0", Offset = "0x59BEBE0", VA = "0x1859BFFE0")] [NativeName("SyncJobs(false)->IsPaused")] [MethodImpl(4096)] get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000029 RID: 41
		[Token(Token = "0x17000017")]
		public extern int particleCount { [Token(Token = "0x6000029")] [Address(RVA = "0x59C0140", Offset = "0x59BED40", VA = "0x1859C0140")] [NativeName("SyncJobs(false)->GetParticleCount")] [MethodImpl(4096)] get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600002A RID: 42
		// (set) Token: 0x0600002B RID: 43
		[Token(Token = "0x17000018")]
		public extern float time { [Token(Token = "0x600002A")] [Address(RVA = "0x59C0630", Offset = "0x59BF230", VA = "0x1859C0630")] [NativeName("SyncJobs(false)->GetSecPosition")] [MethodImpl(4096)] get; [Token(Token = "0x600002B")] [Address(RVA = "0x59C0E30", Offset = "0x59BFA30", VA = "0x1859C0E30")] [NativeName("SyncJobs(false)->SetSecPosition")] [MethodImpl(4096)] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002C RID: 44
		// (set) Token: 0x0600002D RID: 45
		[Token(Token = "0x17000019")]
		public extern uint randomSeed { [Token(Token = "0x600002C")] [Address(RVA = "0x59C0220", Offset = "0x59BEE20", VA = "0x1859C0220")] [NativeName("GetRandomSeed")] [MethodImpl(4096)] get; [Token(Token = "0x600002D")] [Address(RVA = "0x59C09C0", Offset = "0x59BF5C0", VA = "0x1859C09C0")] [NativeName("SyncJobs(false)->SetRandomSeed")] [MethodImpl(4096)] set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600002E RID: 46
		// (set) Token: 0x0600002F RID: 47
		[Token(Token = "0x1700001A")]
		public extern bool useAutoRandomSeed { [Token(Token = "0x600002E")] [Address(RVA = "0x59C0670", Offset = "0x59BF270", VA = "0x1859C0670")] [NativeName("GetAutoRandomSeed")] [MethodImpl(4096)] get; [Token(Token = "0x600002F")] [Address(RVA = "0x59C0E80", Offset = "0x59BFA80", VA = "0x1859C0E80")] [NativeName("SyncJobs(false)->SetAutoRandomSeed")] [MethodImpl(4096)] set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000030 RID: 48
		[Token(Token = "0x1700001B")]
		public extern bool proceduralSimulationSupported { [Token(Token = "0x6000030")] [Address(RVA = "0x59BFE20", Offset = "0x59BEA20", VA = "0x1859BFE20")] [MethodImpl(4096)] get; }

		// Token: 0x06000031 RID: 49
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x59BEAA0", Offset = "0x59BD6A0", VA = "0x1859BEAA0")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize", HasExplicitThis = true)]
		[MethodImpl(4096)]
		internal extern float GetParticleCurrentSize(ref ParticleSystem.Particle particle);

		// Token: 0x06000032 RID: 50 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x59BEA40", Offset = "0x59BD640", VA = "0x1859BEA40")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentSize3D", HasExplicitThis = true)]
		internal Vector3 GetParticleCurrentSize3D(ref ParticleSystem.Particle particle)
		{
			return default(Vector3);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x59BE980", Offset = "0x59BD580", VA = "0x1859BE980")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleCurrentColor", HasExplicitThis = true)]
		internal Color32 GetParticleCurrentColor(ref ParticleSystem.Particle particle)
		{
			return default(Color32);
		}

		// Token: 0x06000034 RID: 52
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x59BEAF0", Offset = "0x59BD6F0", VA = "0x1859BEAF0")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticleMeshIndex", HasExplicitThis = true)]
		[MethodImpl(4096)]
		internal extern int GetParticleMeshIndex(ref ParticleSystem.Particle particle);

		// Token: 0x06000035 RID: 53
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x59BF740", Offset = "0x59BE340", VA = "0x1859BF740")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticles", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern void SetParticles([Out] ParticleSystem.Particle[] particles, int size, int offset);

		// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x59BF6E0", Offset = "0x59BE2E0", VA = "0x1859BF6E0")]
		public void SetParticles([Out] ParticleSystem.Particle[] particles, int size)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x59BF540", Offset = "0x59BE140", VA = "0x1859BF540")]
		public void SetParticles([Out] ParticleSystem.Particle[] particles)
		{
		}

		// Token: 0x06000038 RID: 56
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x59BF4D0", Offset = "0x59BE0D0", VA = "0x1859BF4D0")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetParticlesWithNativeArray", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern void SetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset);

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x59BF7B0", Offset = "0x59BE3B0", VA = "0x1859BF7B0")]
		public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x59BF630", Offset = "0x59BE230", VA = "0x1859BF630")]
		public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x59BF590", Offset = "0x59BE190", VA = "0x1859BF590")]
		public void SetParticles([Out] NativeArray<ParticleSystem.Particle> particles)
		{
		}

		// Token: 0x0600003C RID: 60
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x59BEE10", Offset = "0x59BDA10", VA = "0x1859BEE10")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticles", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern int GetParticles([NotNull("ArgumentNullException")] [Out] ParticleSystem.Particle[] particles, int size, int offset);

		// Token: 0x0600003D RID: 61 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x600003D")]
		[Address(RVA = "0x59BEE80", Offset = "0x59BDA80", VA = "0x1859BEE80")]
		public int GetParticles([Out] ParticleSystem.Particle[] particles, int size)
		{
			return 0;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x59BEBB0", Offset = "0x59BD7B0", VA = "0x1859BEBB0")]
		public int GetParticles([Out] ParticleSystem.Particle[] particles)
		{
			return 0;
		}

		// Token: 0x0600003F RID: 63
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x59BEB40", Offset = "0x59BD740", VA = "0x1859BEB40")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetParticlesWithNativeArray", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern int GetParticlesWithNativeArray(IntPtr particles, int particlesLength, int size, int offset);

		// Token: 0x06000040 RID: 64 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x59BED50", Offset = "0x59BD950", VA = "0x1859BED50")]
		public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size, int offset)
		{
			return 0;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x59BECA0", Offset = "0x59BD8A0", VA = "0x1859BECA0")]
		public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles, int size)
		{
			return 0;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x59BEC00", Offset = "0x59BD800", VA = "0x1859BEC00")]
		public int GetParticles([Out] NativeArray<ParticleSystem.Particle> particles)
		{
			return 0;
		}

		// Token: 0x06000043 RID: 67
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x59BF390", Offset = "0x59BDF90", VA = "0x1859BF390")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern void SetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex);

		// Token: 0x06000044 RID: 68
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x59BE7E0", Offset = "0x59BD3E0", VA = "0x1859BE7E0")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetCustomParticleData", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern int GetCustomParticleData([NotNull("ArgumentNullException")] List<Vector4> customData, ParticleSystemCustomData streamIndex);

		// Token: 0x06000045 RID: 69 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x59BEF30", Offset = "0x59BDB30", VA = "0x1859BEF30")]
		public ParticleSystem.PlaybackState GetPlaybackState()
		{
			return default(ParticleSystem.PlaybackState);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x59BF8C0", Offset = "0x59BE4C0", VA = "0x1859BF8C0")]
		public void SetPlaybackState(ParticleSystem.PlaybackState playbackState)
		{
		}

		// Token: 0x06000047 RID: 71
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x59BEF90", Offset = "0x59BDB90", VA = "0x1859BEF90")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::GetTrailData", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void GetTrailDataInternal(ref ParticleSystem.Trails trailData);

		// Token: 0x06000048 RID: 72 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x59BEFE0", Offset = "0x59BDBE0", VA = "0x1859BEFE0")]
		public ParticleSystem.Trails GetTrails()
		{
			return default(ParticleSystem.Trails);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x59BF070", Offset = "0x59BDC70", VA = "0x1859BF070")]
		public int GetTrails(ref ParticleSystem.Trails trailData)
		{
			return 0;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004A")]
		[Address(RVA = "0x59BF960", Offset = "0x59BE560", VA = "0x1859BF960")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::SetTrailData", HasExplicitThis = true)]
		public void SetTrails(ParticleSystem.Trails trailData)
		{
		}

		// Token: 0x0600004B RID: 75
		[Token(Token = "0x600004B")]
		[Address(RVA = "0x59BF9B0", Offset = "0x59BE5B0", VA = "0x1859BF9B0")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::Simulate", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart, [DefaultValue("true")] bool fixedTimeStep);

		// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x59BFAD0", Offset = "0x59BE6D0", VA = "0x1859BFAD0")]
		public void Simulate(float t, [DefaultValue("true")] bool withChildren, [DefaultValue("true")] bool restart)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x59BFA70", Offset = "0x59BE670", VA = "0x1859BFA70")]
		public void Simulate(float t, [DefaultValue("true")] bool withChildren)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x59BFA20", Offset = "0x59BE620", VA = "0x1859BFA20")]
		public void Simulate(float t)
		{
		}

		// Token: 0x0600004F RID: 79
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x59BF210", Offset = "0x59BDE10", VA = "0x1859BF210")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::Play", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void Play([DefaultValue("true")] bool withChildren);

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x59BF260", Offset = "0x59BDE60", VA = "0x1859BF260")]
		public void Play()
		{
		}

		// Token: 0x06000051 RID: 81
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x59BF1C0", Offset = "0x59BDDC0", VA = "0x1859BF1C0")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::Pause", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void Pause([DefaultValue("true")] bool withChildren);

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x59BF180", Offset = "0x59BDD80", VA = "0x1859BF180")]
		public void Pause()
		{
		}

		// Token: 0x06000053 RID: 83
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x59BFBD0", Offset = "0x59BE7D0", VA = "0x1859BFBD0")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::Stop", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void Stop([DefaultValue("true")] bool withChildren, [DefaultValue("ParticleSystemStopBehavior.StopEmitting")] ParticleSystemStopBehavior stopBehavior);

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x59BFB80", Offset = "0x59BE780", VA = "0x1859BFB80")]
		public void Stop([DefaultValue("true")] bool withChildren)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x59BFB40", Offset = "0x59BE740", VA = "0x1859BFB40")]
		public void Stop()
		{
		}

		// Token: 0x06000056 RID: 86
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x59BE3A0", Offset = "0x59BCFA0", VA = "0x1859BE3A0")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::Clear", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void Clear([DefaultValue("true")] bool withChildren);

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x59BE3F0", Offset = "0x59BCFF0", VA = "0x1859BE3F0")]
		public void Clear()
		{
		}

		// Token: 0x06000058 RID: 88
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x59BF0F0", Offset = "0x59BDCF0", VA = "0x1859BF0F0")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::IsAlive", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern bool IsAlive([DefaultValue("true")] bool withChildren);

		// Token: 0x06000059 RID: 89 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x59BF140", Offset = "0x59BDD40", VA = "0x1859BF140")]
		public bool IsAlive()
		{
			return default(bool);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x59BE530", Offset = "0x59BD130", VA = "0x1859BE530")]
		[RequiredByNativeCode]
		public void Emit(int count)
		{
		}

		// Token: 0x0600005B RID: 91
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x59BE530", Offset = "0x59BD130", VA = "0x1859BE530")]
		[NativeName("SyncJobs()->Emit")]
		[MethodImpl(4096)]
		private extern void Emit_Internal(int count);

		// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x59BE780", Offset = "0x59BD380", VA = "0x1859BE780")]
		[NativeName("SyncJobs()->EmitParticlesExternal")]
		public void Emit(ParticleSystem.EmitParams emitParams, int count)
		{
		}

		// Token: 0x0600005D RID: 93
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x59BE480", Offset = "0x59BD080", VA = "0x1859BE480")]
		[NativeName("SyncJobs()->EmitParticleExternal")]
		[MethodImpl(4096)]
		private extern void EmitOld_Internal(ref ParticleSystem.Particle particle);

		// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x59BFCD0", Offset = "0x59BE8D0", VA = "0x1859BFCD0")]
		public void TriggerSubEmitter(int subEmitterIndex)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x59BFD70", Offset = "0x59BE970", VA = "0x1859BFD70")]
		public void TriggerSubEmitter(int subEmitterIndex, ref ParticleSystem.Particle particle)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x59BFC80", Offset = "0x59BE880", VA = "0x1859BFC80")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitterForParticle", HasExplicitThis = true)]
		internal void TriggerSubEmitterForParticle(int subEmitterIndex, ParticleSystem.Particle particle)
		{
		}

		// Token: 0x06000061 RID: 97
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x59BFD20", Offset = "0x59BE920", VA = "0x1859BFD20")]
		[FreeFunction(Name = "ParticleSystemScriptBindings::TriggerSubEmitter", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void TriggerSubEmitter(int subEmitterIndex, List<ParticleSystem.Particle> particles);

		// Token: 0x06000062 RID: 98
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x59BF2A0", Offset = "0x59BDEA0", VA = "0x1859BF2A0")]
		[FreeFunction(Name = "ParticleSystemGeometryJob::ResetPreMappedBufferMemory")]
		[MethodImpl(4096)]
		public static extern void ResetPreMappedBufferMemory();

		// Token: 0x06000063 RID: 99
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x59BF490", Offset = "0x59BE090", VA = "0x1859BF490")]
		[FreeFunction(Name = "ParticleSystemGeometryJob::SetMaximumPreMappedBufferCounts")]
		[MethodImpl(4096)]
		public static extern void SetMaximumPreMappedBufferCounts(int vertexBuffersCount, int indexBuffersCount);

		// Token: 0x06000064 RID: 100
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x59BE2E0", Offset = "0x59BCEE0", VA = "0x1859BE2E0")]
		[NativeName("SetUsesAxisOfRotation")]
		[MethodImpl(4096)]
		public extern void AllocateAxisOfRotationAttribute();

		// Token: 0x06000065 RID: 101
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x59BE360", Offset = "0x59BCF60", VA = "0x1859BE360")]
		[NativeName("SetUsesMeshIndex")]
		[MethodImpl(4096)]
		public extern void AllocateMeshIndexAttribute();

		// Token: 0x06000066 RID: 102
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x59BE320", Offset = "0x59BCF20", VA = "0x1859BE320")]
		[NativeName("SetUsesCustomData")]
		[MethodImpl(4096)]
		public extern void AllocateCustomDataAttribute(ParticleSystemCustomData stream);

		// Token: 0x06000067 RID: 103
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x59BE840", Offset = "0x59BD440", VA = "0x1859BE840")]
		[MethodImpl(4096)]
		internal unsafe extern void* GetManagedJobData();

		// Token: 0x06000068 RID: 104 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x59BE8D0", Offset = "0x59BD4D0", VA = "0x1859BE8D0")]
		internal JobHandle GetManagedJobHandle()
		{
			return default(JobHandle);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x59BF440", Offset = "0x59BE040", VA = "0x1859BF440")]
		internal void SetManagedJobHandle(JobHandle handle)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x59BF330", Offset = "0x59BDF30", VA = "0x1859BF330")]
		[FreeFunction("ScheduleManagedJob", ThrowsException = true)]
		internal unsafe static JobHandle ScheduleManagedJob(ref JobsUtility.JobScheduleParameters parameters, void* additionalData)
		{
			return default(JobHandle);
		}

		// Token: 0x0600006B RID: 107
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x59BE430", Offset = "0x59BD030", VA = "0x1859BE430")]
		[ThreadSafe]
		[MethodImpl(4096)]
		internal unsafe static extern void CopyManagedJobData(void* systemPtr, out NativeParticleData particleData);

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006C RID: 108 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x1700001C")]
		public ParticleSystem.MainModule main
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.MainModule);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x1700001D")]
		public ParticleSystem.EmissionModule emission
		{
			[Token(Token = "0x600006D")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.EmissionModule);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x1700001E")]
		public ParticleSystem.ShapeModule shape
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.ShapeModule);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x1700001F")]
		public ParticleSystem.VelocityOverLifetimeModule velocityOverLifetime
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.VelocityOverLifetimeModule);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x17000020")]
		public ParticleSystem.LimitVelocityOverLifetimeModule limitVelocityOverLifetime
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.LimitVelocityOverLifetimeModule);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x17000021")]
		public ParticleSystem.InheritVelocityModule inheritVelocity
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.InheritVelocityModule);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x17000022")]
		public ParticleSystem.LifetimeByEmitterSpeedModule lifetimeByEmitterSpeed
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.LifetimeByEmitterSpeedModule);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x17000023")]
		public ParticleSystem.ForceOverLifetimeModule forceOverLifetime
		{
			[Token(Token = "0x6000073")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.ForceOverLifetimeModule);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000023FC File Offset: 0x000005FC
		[Token(Token = "0x17000024")]
		public ParticleSystem.ColorOverLifetimeModule colorOverLifetime
		{
			[Token(Token = "0x6000074")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.ColorOverLifetimeModule);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002414 File Offset: 0x00000614
		[Token(Token = "0x17000025")]
		public ParticleSystem.ColorBySpeedModule colorBySpeed
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.ColorBySpeedModule);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x17000026")]
		public ParticleSystem.SizeOverLifetimeModule sizeOverLifetime
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.SizeOverLifetimeModule);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002444 File Offset: 0x00000644
		[Token(Token = "0x17000027")]
		public ParticleSystem.SizeBySpeedModule sizeBySpeed
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.SizeBySpeedModule);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000245C File Offset: 0x0000065C
		[Token(Token = "0x17000028")]
		public ParticleSystem.RotationOverLifetimeModule rotationOverLifetime
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.RotationOverLifetimeModule);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002474 File Offset: 0x00000674
		[Token(Token = "0x17000029")]
		public ParticleSystem.RotationBySpeedModule rotationBySpeed
		{
			[Token(Token = "0x6000079")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.RotationBySpeedModule);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000248C File Offset: 0x0000068C
		[Token(Token = "0x1700002A")]
		public ParticleSystem.ExternalForcesModule externalForces
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.ExternalForcesModule);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000024A4 File Offset: 0x000006A4
		[Token(Token = "0x1700002B")]
		public ParticleSystem.NoiseModule noise
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.NoiseModule);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000024BC File Offset: 0x000006BC
		[Token(Token = "0x1700002C")]
		public ParticleSystem.CollisionModule collision
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.CollisionModule);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000024D4 File Offset: 0x000006D4
		[Token(Token = "0x1700002D")]
		public ParticleSystem.TriggerModule trigger
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.TriggerModule);
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x1700002E")]
		public ParticleSystem.SubEmittersModule subEmitters
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.SubEmittersModule);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002504 File Offset: 0x00000704
		[Token(Token = "0x1700002F")]
		public ParticleSystem.TextureSheetAnimationModule textureSheetAnimation
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.TextureSheetAnimationModule);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000080 RID: 128 RVA: 0x0000251C File Offset: 0x0000071C
		[Token(Token = "0x17000030")]
		public ParticleSystem.LightsModule lights
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.LightsModule);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x17000031")]
		public ParticleSystem.TrailModule trails
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.TrailModule);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000082 RID: 130 RVA: 0x0000254C File Offset: 0x0000074C
		[Token(Token = "0x17000032")]
		public ParticleSystem.CustomDataModule customData
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xE7C290", Offset = "0xE7AE90", VA = "0x180E7C290")]
			get
			{
				return default(ParticleSystem.CustomDataModule);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public ParticleSystem()
		{
		}

		// Token: 0x06000084 RID: 132
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x59BE9E0", Offset = "0x59BD5E0", VA = "0x1859BE9E0")]
		[MethodImpl(4096)]
		private extern void GetParticleCurrentSize3D_Injected(ref ParticleSystem.Particle particle, out Vector3 ret);

		// Token: 0x06000085 RID: 133
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x59BE920", Offset = "0x59BD520", VA = "0x1859BE920")]
		[MethodImpl(4096)]
		private extern void GetParticleCurrentColor_Injected(ref ParticleSystem.Particle particle, out Color32 ret);

		// Token: 0x06000086 RID: 134
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x59BEEE0", Offset = "0x59BDAE0", VA = "0x1859BEEE0")]
		[MethodImpl(4096)]
		private extern void GetPlaybackState_Injected(out ParticleSystem.PlaybackState ret);

		// Token: 0x06000087 RID: 135
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x59BF870", Offset = "0x59BE470", VA = "0x1859BF870")]
		[MethodImpl(4096)]
		private extern void SetPlaybackState_Injected(ref ParticleSystem.PlaybackState playbackState);

		// Token: 0x06000088 RID: 136
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x59BF910", Offset = "0x59BE510", VA = "0x1859BF910")]
		[MethodImpl(4096)]
		private extern void SetTrails_Injected(ref ParticleSystem.Trails trailData);

		// Token: 0x06000089 RID: 137
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x59BE4D0", Offset = "0x59BD0D0", VA = "0x1859BE4D0")]
		[MethodImpl(4096)]
		private extern void Emit_Injected(ref ParticleSystem.EmitParams emitParams, int count);

		// Token: 0x0600008A RID: 138
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x59BFC30", Offset = "0x59BE830", VA = "0x1859BFC30")]
		[MethodImpl(4096)]
		private extern void TriggerSubEmitterForParticle_Injected(int subEmitterIndex, ref ParticleSystem.Particle particle);

		// Token: 0x0600008B RID: 139
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x59BE880", Offset = "0x59BD480", VA = "0x1859BE880")]
		[MethodImpl(4096)]
		private extern void GetManagedJobHandle_Injected(out JobHandle ret);

		// Token: 0x0600008C RID: 140
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x59BF3F0", Offset = "0x59BDFF0", VA = "0x1859BF3F0")]
		[MethodImpl(4096)]
		private extern void SetManagedJobHandle_Injected(ref JobHandle handle);

		// Token: 0x0600008D RID: 141
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x59BF2D0", Offset = "0x59BDED0", VA = "0x1859BF2D0")]
		[MethodImpl(4096)]
		private unsafe static extern void ScheduleManagedJob_Injected(ref JobsUtility.JobScheduleParameters parameters, void* additionalData, out JobHandle ret);

		// Token: 0x02000003 RID: 3
		[Token(Token = "0x2000003")]
		public struct MainModule
		{
			// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal MainModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600008F RID: 143 RVA: 0x00002564 File Offset: 0x00000764
			[Token(Token = "0x17000033")]
			public float duration
			{
				[Token(Token = "0x600008F")]
				[Address(RVA = "0x59BB740", Offset = "0x59BA340", VA = "0x1859BB740")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000090 RID: 144 RVA: 0x0000257C File Offset: 0x0000077C
			// (set) Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000034")]
			public bool loop
			{
				[Token(Token = "0x6000090")]
				[Address(RVA = "0x59BB7C0", Offset = "0x59BA3C0", VA = "0x1859BB7C0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000091")]
				[Address(RVA = "0x59BBD40", Offset = "0x59BA940", VA = "0x1859BBD40")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000092 RID: 146 RVA: 0x00002594 File Offset: 0x00000794
			[Token(Token = "0x17000035")]
			public bool prewarm
			{
				[Token(Token = "0x6000092")]
				[Address(RVA = "0x59BB880", Offset = "0x59BA480", VA = "0x1859BB880")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000093 RID: 147 RVA: 0x000025AC File Offset: 0x000007AC
			// (set) Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000036")]
			public float startDelayMultiplier
			{
				[Token(Token = "0x6000093")]
				[Address(RVA = "0x59BBA30", Offset = "0x59BA630", VA = "0x1859BBA30")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000094")]
				[Address(RVA = "0x59BBF90", Offset = "0x59BAB90", VA = "0x1859BBF90")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000095 RID: 149 RVA: 0x000025C4 File Offset: 0x000007C4
			// (set) Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000037")]
			public float startLifetimeMultiplier
			{
				[Token(Token = "0x6000095")]
				[Address(RVA = "0x59BBA70", Offset = "0x59BA670", VA = "0x1859BBA70")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000096")]
				[Address(RVA = "0x59BBFE0", Offset = "0x59BABE0", VA = "0x1859BBFE0")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x06000097 RID: 151 RVA: 0x000025DC File Offset: 0x000007DC
			// (set) Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000038")]
			public float startSpeedMultiplier
			{
				[Token(Token = "0x6000097")]
				[Address(RVA = "0x59BBC70", Offset = "0x59BA870", VA = "0x1859BBC70")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000098")]
				[Address(RVA = "0x59BC1C0", Offset = "0x59BADC0", VA = "0x1859BC1C0")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x06000099 RID: 153 RVA: 0x000025F4 File Offset: 0x000007F4
			[Token(Token = "0x17000039")]
			public bool startSize3D
			{
				[Token(Token = "0x6000099")]
				[Address(RVA = "0x59BBBF0", Offset = "0x59BA7F0", VA = "0x1859BBBF0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x0600009A RID: 154 RVA: 0x0000260C File Offset: 0x0000080C
			// (set) Token: 0x0600009B RID: 155 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700003A")]
			[NativeName("StartSizeXMultiplier")]
			public float startSizeMultiplier
			{
				[Token(Token = "0x600009A")]
				[Address(RVA = "0x59BBC30", Offset = "0x59BA830", VA = "0x1859BBC30")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600009B")]
				[Address(RVA = "0x59BC170", Offset = "0x59BAD70", VA = "0x1859BC170")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x0600009C RID: 156 RVA: 0x00002624 File Offset: 0x00000824
			[Token(Token = "0x1700003B")]
			public bool startRotation3D
			{
				[Token(Token = "0x600009C")]
				[Address(RVA = "0x59BBAB0", Offset = "0x59BA6B0", VA = "0x1859BBAB0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x0600009D RID: 157 RVA: 0x0000263C File Offset: 0x0000083C
			// (set) Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700003C")]
			[NativeName("StartRotationZMultiplier")]
			public float startRotationMultiplier
			{
				[Token(Token = "0x600009D")]
				[Address(RVA = "0x59BBAF0", Offset = "0x59BA6F0", VA = "0x1859BBAF0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600009E")]
				[Address(RVA = "0x59BC030", Offset = "0x59BAC30", VA = "0x1859BC030")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x0600009F RID: 159 RVA: 0x00002654 File Offset: 0x00000854
			// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700003D")]
			public float startRotationXMultiplier
			{
				[Token(Token = "0x600009F")]
				[Address(RVA = "0x59BBB30", Offset = "0x59BA730", VA = "0x1859BBB30")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000A0")]
				[Address(RVA = "0x59BC080", Offset = "0x59BAC80", VA = "0x1859BC080")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000266C File Offset: 0x0000086C
			// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700003E")]
			public float startRotationYMultiplier
			{
				[Token(Token = "0x60000A1")]
				[Address(RVA = "0x59BBB70", Offset = "0x59BA770", VA = "0x1859BBB70")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000A2")]
				[Address(RVA = "0x59BC0D0", Offset = "0x59BACD0", VA = "0x1859BC0D0")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002684 File Offset: 0x00000884
			// (set) Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700003F")]
			public float startRotationZMultiplier
			{
				[Token(Token = "0x60000A3")]
				[Address(RVA = "0x59BBBB0", Offset = "0x59BA7B0", VA = "0x1859BBBB0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000A4")]
				[Address(RVA = "0x59BC120", Offset = "0x59BAD20", VA = "0x1859BC120")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000269C File Offset: 0x0000089C
			// (set) Token: 0x060000A6 RID: 166 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000040")]
			public ParticleSystem.MinMaxGradient startColor
			{
				[Token(Token = "0x60000A5")]
				[Address(RVA = "0x59BB9D0", Offset = "0x59BA5D0", VA = "0x1859BB9D0")]
				get
				{
					return default(ParticleSystem.MinMaxGradient);
				}
				[Token(Token = "0x60000A6")]
				[Address(RVA = "0x59BBF40", Offset = "0x59BAB40", VA = "0x1859BBF40")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x060000A7 RID: 167 RVA: 0x000026B4 File Offset: 0x000008B4
			// (set) Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000041")]
			public float gravityModifierMultiplier
			{
				[Token(Token = "0x60000A7")]
				[Address(RVA = "0x59BB780", Offset = "0x59BA380", VA = "0x1859BB780")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000A8")]
				[Address(RVA = "0x59BBCF0", Offset = "0x59BA8F0", VA = "0x1859BBCF0")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x060000A9 RID: 169 RVA: 0x000026CC File Offset: 0x000008CC
			// (set) Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000042")]
			public ParticleSystemSimulationSpace simulationSpace
			{
				[Token(Token = "0x60000A9")]
				[Address(RVA = "0x59BB900", Offset = "0x59BA500", VA = "0x1859BB900")]
				get
				{
					return ParticleSystemSimulationSpace.Local;
				}
				[Token(Token = "0x60000AA")]
				[Address(RVA = "0x59BBE60", Offset = "0x59BAA60", VA = "0x1859BBE60")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x060000AB RID: 171 RVA: 0x000026E2 File Offset: 0x000008E2
			[Token(Token = "0x17000043")]
			public Transform customSimulationSpace
			{
				[Token(Token = "0x60000AB")]
				[Address(RVA = "0x59BB700", Offset = "0x59BA300", VA = "0x1859BB700")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x060000AC RID: 172 RVA: 0x000026E8 File Offset: 0x000008E8
			// (set) Token: 0x060000AD RID: 173 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000044")]
			public float simulationSpeed
			{
				[Token(Token = "0x60000AC")]
				[Address(RVA = "0x59BB940", Offset = "0x59BA540", VA = "0x1859BB940")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60000AD")]
				[Address(RVA = "0x59BBEA0", Offset = "0x59BAAA0", VA = "0x1859BBEA0")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x060000AE RID: 174 RVA: 0x00002700 File Offset: 0x00000900
			// (set) Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000045")]
			public bool useUnscaledTime
			{
				[Token(Token = "0x60000AE")]
				[Address(RVA = "0x59BBCB0", Offset = "0x59BA8B0", VA = "0x1859BBCB0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60000AF")]
				[Address(RVA = "0x59BC210", Offset = "0x59BAE10", VA = "0x1859BC210")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002718 File Offset: 0x00000918
			// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000046")]
			public ParticleSystemScalingMode scalingMode
			{
				[Token(Token = "0x60000B0")]
				[Address(RVA = "0x59BB8C0", Offset = "0x59BA4C0", VA = "0x1859BB8C0")]
				get
				{
					return ParticleSystemScalingMode.Hierarchy;
				}
				[Token(Token = "0x60000B1")]
				[Address(RVA = "0x59BBE20", Offset = "0x59BAA20", VA = "0x1859BBE20")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002730 File Offset: 0x00000930
			// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000047")]
			public bool playOnAwake
			{
				[Token(Token = "0x60000B2")]
				[Address(RVA = "0x59BB840", Offset = "0x59BA440", VA = "0x1859BB840")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60000B3")]
				[Address(RVA = "0x59BBDD0", Offset = "0x59BA9D0", VA = "0x1859BBDD0")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002748 File Offset: 0x00000948
			// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000048")]
			public int maxParticles
			{
				[Token(Token = "0x60000B4")]
				[Address(RVA = "0x59BB800", Offset = "0x59BA400", VA = "0x1859BB800")]
				get
				{
					return 0;
				}
				[Token(Token = "0x60000B5")]
				[Address(RVA = "0x59BBD90", Offset = "0x59BA990", VA = "0x1859BBD90")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x060000B6 RID: 182
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x59BB740", Offset = "0x59BA340", VA = "0x1859BB740")]
			[MethodImpl(4096)]
			private static extern float get_duration_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000B7 RID: 183
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x59BB7C0", Offset = "0x59BA3C0", VA = "0x1859BB7C0")]
			[MethodImpl(4096)]
			private static extern bool get_loop_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000B8 RID: 184
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x59BBD40", Offset = "0x59BA940", VA = "0x1859BBD40")]
			[MethodImpl(4096)]
			private static extern void set_loop_Injected(ref ParticleSystem.MainModule _unity_self, bool value);

			// Token: 0x060000B9 RID: 185
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x59BB880", Offset = "0x59BA480", VA = "0x1859BB880")]
			[MethodImpl(4096)]
			private static extern bool get_prewarm_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000BA RID: 186
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x59BBA30", Offset = "0x59BA630", VA = "0x1859BBA30")]
			[MethodImpl(4096)]
			private static extern float get_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000BB RID: 187
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x59BBF90", Offset = "0x59BAB90", VA = "0x1859BBF90")]
			[MethodImpl(4096)]
			private static extern void set_startDelayMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value);

			// Token: 0x060000BC RID: 188
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x59BBA70", Offset = "0x59BA670", VA = "0x1859BBA70")]
			[MethodImpl(4096)]
			private static extern float get_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000BD RID: 189
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x59BBFE0", Offset = "0x59BABE0", VA = "0x1859BBFE0")]
			[MethodImpl(4096)]
			private static extern void set_startLifetimeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value);

			// Token: 0x060000BE RID: 190
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x59BBC70", Offset = "0x59BA870", VA = "0x1859BBC70")]
			[MethodImpl(4096)]
			private static extern float get_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000BF RID: 191
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x59BC1C0", Offset = "0x59BADC0", VA = "0x1859BC1C0")]
			[MethodImpl(4096)]
			private static extern void set_startSpeedMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value);

			// Token: 0x060000C0 RID: 192
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x59BBBF0", Offset = "0x59BA7F0", VA = "0x1859BBBF0")]
			[MethodImpl(4096)]
			private static extern bool get_startSize3D_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000C1 RID: 193
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x59BBC30", Offset = "0x59BA830", VA = "0x1859BBC30")]
			[MethodImpl(4096)]
			private static extern float get_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000C2 RID: 194
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x59BC170", Offset = "0x59BAD70", VA = "0x1859BC170")]
			[MethodImpl(4096)]
			private static extern void set_startSizeMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value);

			// Token: 0x060000C3 RID: 195
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x59BBAB0", Offset = "0x59BA6B0", VA = "0x1859BBAB0")]
			[MethodImpl(4096)]
			private static extern bool get_startRotation3D_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000C4 RID: 196
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x59BBAF0", Offset = "0x59BA6F0", VA = "0x1859BBAF0")]
			[MethodImpl(4096)]
			private static extern float get_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000C5 RID: 197
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x59BC030", Offset = "0x59BAC30", VA = "0x1859BC030")]
			[MethodImpl(4096)]
			private static extern void set_startRotationMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value);

			// Token: 0x060000C6 RID: 198
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x59BBB30", Offset = "0x59BA730", VA = "0x1859BBB30")]
			[MethodImpl(4096)]
			private static extern float get_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000C7 RID: 199
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0x59BC080", Offset = "0x59BAC80", VA = "0x1859BC080")]
			[MethodImpl(4096)]
			private static extern void set_startRotationXMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value);

			// Token: 0x060000C8 RID: 200
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x59BBB70", Offset = "0x59BA770", VA = "0x1859BBB70")]
			[MethodImpl(4096)]
			private static extern float get_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000C9 RID: 201
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x59BC0D0", Offset = "0x59BACD0", VA = "0x1859BC0D0")]
			[MethodImpl(4096)]
			private static extern void set_startRotationYMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value);

			// Token: 0x060000CA RID: 202
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x59BBBB0", Offset = "0x59BA7B0", VA = "0x1859BBBB0")]
			[MethodImpl(4096)]
			private static extern float get_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000CB RID: 203
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0x59BC120", Offset = "0x59BAD20", VA = "0x1859BC120")]
			[MethodImpl(4096)]
			private static extern void set_startRotationZMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value);

			// Token: 0x060000CC RID: 204
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x59BB980", Offset = "0x59BA580", VA = "0x1859BB980")]
			[MethodImpl(4096)]
			private static extern void get_startColor_Injected(ref ParticleSystem.MainModule _unity_self, out ParticleSystem.MinMaxGradient ret);

			// Token: 0x060000CD RID: 205
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x59BBEF0", Offset = "0x59BAAF0", VA = "0x1859BBEF0")]
			[MethodImpl(4096)]
			private static extern void set_startColor_Injected(ref ParticleSystem.MainModule _unity_self, ref ParticleSystem.MinMaxGradient value);

			// Token: 0x060000CE RID: 206
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x59BB780", Offset = "0x59BA380", VA = "0x1859BB780")]
			[MethodImpl(4096)]
			private static extern float get_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000CF RID: 207
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x59BBCF0", Offset = "0x59BA8F0", VA = "0x1859BBCF0")]
			[MethodImpl(4096)]
			private static extern void set_gravityModifierMultiplier_Injected(ref ParticleSystem.MainModule _unity_self, float value);

			// Token: 0x060000D0 RID: 208
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x59BB900", Offset = "0x59BA500", VA = "0x1859BB900")]
			[MethodImpl(4096)]
			private static extern ParticleSystemSimulationSpace get_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000D1 RID: 209
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x59BBE60", Offset = "0x59BAA60", VA = "0x1859BBE60")]
			[MethodImpl(4096)]
			private static extern void set_simulationSpace_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemSimulationSpace value);

			// Token: 0x060000D2 RID: 210
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x59BB700", Offset = "0x59BA300", VA = "0x1859BB700")]
			[MethodImpl(4096)]
			private static extern Transform get_customSimulationSpace_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000D3 RID: 211
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x59BB940", Offset = "0x59BA540", VA = "0x1859BB940")]
			[MethodImpl(4096)]
			private static extern float get_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000D4 RID: 212
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x59BBEA0", Offset = "0x59BAAA0", VA = "0x1859BBEA0")]
			[MethodImpl(4096)]
			private static extern void set_simulationSpeed_Injected(ref ParticleSystem.MainModule _unity_self, float value);

			// Token: 0x060000D5 RID: 213
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x59BBCB0", Offset = "0x59BA8B0", VA = "0x1859BBCB0")]
			[MethodImpl(4096)]
			private static extern bool get_useUnscaledTime_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000D6 RID: 214
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x59BC210", Offset = "0x59BAE10", VA = "0x1859BC210")]
			[MethodImpl(4096)]
			private static extern void set_useUnscaledTime_Injected(ref ParticleSystem.MainModule _unity_self, bool value);

			// Token: 0x060000D7 RID: 215
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x59BB8C0", Offset = "0x59BA4C0", VA = "0x1859BB8C0")]
			[MethodImpl(4096)]
			private static extern ParticleSystemScalingMode get_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000D8 RID: 216
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x59BBE20", Offset = "0x59BAA20", VA = "0x1859BBE20")]
			[MethodImpl(4096)]
			private static extern void set_scalingMode_Injected(ref ParticleSystem.MainModule _unity_self, ParticleSystemScalingMode value);

			// Token: 0x060000D9 RID: 217
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x59BB840", Offset = "0x59BA440", VA = "0x1859BB840")]
			[MethodImpl(4096)]
			private static extern bool get_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000DA RID: 218
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x59BBDD0", Offset = "0x59BA9D0", VA = "0x1859BBDD0")]
			[MethodImpl(4096)]
			private static extern void set_playOnAwake_Injected(ref ParticleSystem.MainModule _unity_self, bool value);

			// Token: 0x060000DB RID: 219
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x59BB800", Offset = "0x59BA400", VA = "0x1859BB800")]
			[MethodImpl(4096)]
			private static extern int get_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self);

			// Token: 0x060000DC RID: 220
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x59BBD90", Offset = "0x59BA990", VA = "0x1859BBD90")]
			[MethodImpl(4096)]
			private static extern void set_maxParticles_Injected(ref ParticleSystem.MainModule _unity_self, int value);

			// Token: 0x04000001 RID: 1
			[Token(Token = "0x4000001")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000004 RID: 4
		[Token(Token = "0x2000004")]
		public struct EmissionModule
		{
			// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal EmissionModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x060000DE RID: 222 RVA: 0x00002760 File Offset: 0x00000960
			// (set) Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000049")]
			public bool enabled
			{
				[Token(Token = "0x60000DE")]
				[Address(RVA = "0x59BB410", Offset = "0x59BA010", VA = "0x1859BB410")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60000DF")]
				[Address(RVA = "0x59BB610", Offset = "0x59BA210", VA = "0x1859BB610")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002778 File Offset: 0x00000978
			// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700004A")]
			public ParticleSystem.MinMaxCurve rateOverTime
			{
				[Token(Token = "0x60000E0")]
				[Address(RVA = "0x59BB5C0", Offset = "0x59BA1C0", VA = "0x1859BB5C0")]
				get
				{
					return default(ParticleSystem.MinMaxCurve);
				}
				[Token(Token = "0x60000E1")]
				[Address(RVA = "0x59BB6B0", Offset = "0x59BA2B0", VA = "0x1859BB6B0")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002790 File Offset: 0x00000990
			[Token(Token = "0x1700004B")]
			public float rateOverTimeMultiplier
			{
				[Token(Token = "0x60000E2")]
				[Address(RVA = "0x59BB530", Offset = "0x59BA130", VA = "0x1859BB530")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x000027A8 File Offset: 0x000009A8
			[Token(Token = "0x1700004C")]
			public ParticleSystem.MinMaxCurve rateOverDistance
			{
				[Token(Token = "0x60000E3")]
				[Address(RVA = "0x59BB4E0", Offset = "0x59BA0E0", VA = "0x1859BB4E0")]
				get
				{
					return default(ParticleSystem.MinMaxCurve);
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x000027C0 File Offset: 0x000009C0
			[Token(Token = "0x1700004D")]
			public float rateOverDistanceMultiplier
			{
				[Token(Token = "0x60000E4")]
				[Address(RVA = "0x59BB450", Offset = "0x59BA050", VA = "0x1859BB450")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060000E5 RID: 229 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x59BB380", Offset = "0x59B9F80", VA = "0x1859BB380")]
			[NativeThrows]
			public void SetBurst(int index, ParticleSystem.Burst burst)
			{
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x000027D8 File Offset: 0x000009D8
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x59BB2C0", Offset = "0x59B9EC0", VA = "0x1859BB2C0")]
			[NativeThrows]
			public ParticleSystem.Burst GetBurst(int index)
			{
				return default(ParticleSystem.Burst);
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x060000E7 RID: 231 RVA: 0x000027F0 File Offset: 0x000009F0
			[Token(Token = "0x1700004E")]
			public int burstCount
			{
				[Token(Token = "0x60000E7")]
				[Address(RVA = "0x59BB3D0", Offset = "0x59B9FD0", VA = "0x1859BB3D0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060000E8 RID: 232
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x59BB410", Offset = "0x59BA010", VA = "0x1859BB410")]
			[MethodImpl(4096)]
			private static extern bool get_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self);

			// Token: 0x060000E9 RID: 233
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x59BB610", Offset = "0x59BA210", VA = "0x1859BB610")]
			[MethodImpl(4096)]
			private static extern void set_enabled_Injected(ref ParticleSystem.EmissionModule _unity_self, bool value);

			// Token: 0x060000EA RID: 234
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x59BB570", Offset = "0x59BA170", VA = "0x1859BB570")]
			[MethodImpl(4096)]
			private static extern void get_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurve ret);

			// Token: 0x060000EB RID: 235
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x59BB660", Offset = "0x59BA260", VA = "0x1859BB660")]
			[MethodImpl(4096)]
			private static extern void set_rateOverTime_Injected(ref ParticleSystem.EmissionModule _unity_self, ref ParticleSystem.MinMaxCurve value);

			// Token: 0x060000EC RID: 236
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x59BB530", Offset = "0x59BA130", VA = "0x1859BB530")]
			[MethodImpl(4096)]
			private static extern float get_rateOverTimeMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self);

			// Token: 0x060000ED RID: 237
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x59BB490", Offset = "0x59BA090", VA = "0x1859BB490")]
			[MethodImpl(4096)]
			private static extern void get_rateOverDistance_Injected(ref ParticleSystem.EmissionModule _unity_self, out ParticleSystem.MinMaxCurve ret);

			// Token: 0x060000EE RID: 238
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x59BB450", Offset = "0x59BA050", VA = "0x1859BB450")]
			[MethodImpl(4096)]
			private static extern float get_rateOverDistanceMultiplier_Injected(ref ParticleSystem.EmissionModule _unity_self);

			// Token: 0x060000EF RID: 239
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x59BB330", Offset = "0x59B9F30", VA = "0x1859BB330")]
			[MethodImpl(4096)]
			private static extern void SetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, ref ParticleSystem.Burst burst);

			// Token: 0x060000F0 RID: 240
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x59BB270", Offset = "0x59B9E70", VA = "0x1859BB270")]
			[MethodImpl(4096)]
			private static extern void GetBurst_Injected(ref ParticleSystem.EmissionModule _unity_self, int index, out ParticleSystem.Burst ret);

			// Token: 0x060000F1 RID: 241
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x59BB3D0", Offset = "0x59B9FD0", VA = "0x1859BB3D0")]
			[MethodImpl(4096)]
			private static extern int get_burstCount_Injected(ref ParticleSystem.EmissionModule _unity_self);

			// Token: 0x04000002 RID: 2
			[Token(Token = "0x4000002")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		public struct ShapeModule
		{
			// Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal ShapeModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002808 File Offset: 0x00000A08
			// (set) Token: 0x060000F4 RID: 244 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700004F")]
			public bool enabled
			{
				[Token(Token = "0x60000F3")]
				[Address(RVA = "0x59C1320", Offset = "0x59BFF20", VA = "0x1859C1320")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60000F4")]
				[Address(RVA = "0x59C1560", Offset = "0x59C0160", VA = "0x1859C1560")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002820 File Offset: 0x00000A20
			// (set) Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000050")]
			public ParticleSystemShapeType shapeType
			{
				[Token(Token = "0x60000F5")]
				[Address(RVA = "0x59C14E0", Offset = "0x59C00E0", VA = "0x1859C14E0")]
				get
				{
					return ParticleSystemShapeType.Sphere;
				}
				[Token(Token = "0x60000F6")]
				[Address(RVA = "0x59C1820", Offset = "0x59C0420", VA = "0x1859C1820")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002838 File Offset: 0x00000A38
			[Token(Token = "0x17000051")]
			public bool alignToDirection
			{
				[Token(Token = "0x60000F7")]
				[Address(RVA = "0x59C12E0", Offset = "0x59BFEE0", VA = "0x1859C12E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000052 RID: 82
			// (set) Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000052")]
			public ParticleSystemMeshShapeType meshShapeType
			{
				[Token(Token = "0x60000F8")]
				[Address(RVA = "0x59C15B0", Offset = "0x59C01B0", VA = "0x1859C15B0")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000053 RID: 83
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000053")]
			public Mesh mesh
			{
				[Token(Token = "0x60000F9")]
				[Address(RVA = "0x59C15F0", Offset = "0x59C01F0", VA = "0x1859C15F0")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060000FA RID: 250 RVA: 0x000026E2 File Offset: 0x000008E2
			[Token(Token = "0x17000054")]
			public MeshRenderer meshRenderer
			{
				[Token(Token = "0x60000FA")]
				[Address(RVA = "0x59C1360", Offset = "0x59BFF60", VA = "0x1859C1360")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060000FB RID: 251 RVA: 0x000026E2 File Offset: 0x000008E2
			[Token(Token = "0x17000055")]
			public SkinnedMeshRenderer skinnedMeshRenderer
			{
				[Token(Token = "0x60000FB")]
				[Address(RVA = "0x59C1520", Offset = "0x59C0120", VA = "0x1859C1520")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060000FC RID: 252 RVA: 0x00002850 File Offset: 0x00000A50
			// (set) Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000056")]
			public Vector3 position
			{
				[Token(Token = "0x60000FC")]
				[Address(RVA = "0x59C13F0", Offset = "0x59BFFF0", VA = "0x1859C13F0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60000FD")]
				[Address(RVA = "0x59C1690", Offset = "0x59C0290", VA = "0x1859C1690")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000057 RID: 87
			// (set) Token: 0x060000FE RID: 254 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000057")]
			public Vector3 rotation
			{
				[Token(Token = "0x60000FE")]
				[Address(RVA = "0x59C1730", Offset = "0x59C0330", VA = "0x1859C1730")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000058 RID: 88
			// (get) Token: 0x060000FF RID: 255 RVA: 0x00002868 File Offset: 0x00000A68
			// (set) Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000058")]
			public Vector3 scale
			{
				[Token(Token = "0x60000FF")]
				[Address(RVA = "0x59C1490", Offset = "0x59C0090", VA = "0x1859C1490")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000100")]
				[Address(RVA = "0x59C17D0", Offset = "0x59C03D0", VA = "0x1859C17D0")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x06000101 RID: 257
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x59C1320", Offset = "0x59BFF20", VA = "0x1859C1320")]
			[MethodImpl(4096)]
			private static extern bool get_enabled_Injected(ref ParticleSystem.ShapeModule _unity_self);

			// Token: 0x06000102 RID: 258
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x59C1560", Offset = "0x59C0160", VA = "0x1859C1560")]
			[MethodImpl(4096)]
			private static extern void set_enabled_Injected(ref ParticleSystem.ShapeModule _unity_self, bool value);

			// Token: 0x06000103 RID: 259
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x59C14E0", Offset = "0x59C00E0", VA = "0x1859C14E0")]
			[MethodImpl(4096)]
			private static extern ParticleSystemShapeType get_shapeType_Injected(ref ParticleSystem.ShapeModule _unity_self);

			// Token: 0x06000104 RID: 260
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x59C1820", Offset = "0x59C0420", VA = "0x1859C1820")]
			[MethodImpl(4096)]
			private static extern void set_shapeType_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemShapeType value);

			// Token: 0x06000105 RID: 261
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x59C12E0", Offset = "0x59BFEE0", VA = "0x1859C12E0")]
			[MethodImpl(4096)]
			private static extern bool get_alignToDirection_Injected(ref ParticleSystem.ShapeModule _unity_self);

			// Token: 0x06000106 RID: 262
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x59C15B0", Offset = "0x59C01B0", VA = "0x1859C15B0")]
			[MethodImpl(4096)]
			private static extern void set_meshShapeType_Injected(ref ParticleSystem.ShapeModule _unity_self, ParticleSystemMeshShapeType value);

			// Token: 0x06000107 RID: 263
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x59C15F0", Offset = "0x59C01F0", VA = "0x1859C15F0")]
			[MethodImpl(4096)]
			private static extern void set_mesh_Injected(ref ParticleSystem.ShapeModule _unity_self, Mesh value);

			// Token: 0x06000108 RID: 264
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x59C1360", Offset = "0x59BFF60", VA = "0x1859C1360")]
			[MethodImpl(4096)]
			private static extern MeshRenderer get_meshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self);

			// Token: 0x06000109 RID: 265
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x59C1520", Offset = "0x59C0120", VA = "0x1859C1520")]
			[MethodImpl(4096)]
			private static extern SkinnedMeshRenderer get_skinnedMeshRenderer_Injected(ref ParticleSystem.ShapeModule _unity_self);

			// Token: 0x0600010A RID: 266
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x59C13A0", Offset = "0x59BFFA0", VA = "0x1859C13A0")]
			[MethodImpl(4096)]
			private static extern void get_position_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret);

			// Token: 0x0600010B RID: 267
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x59C1640", Offset = "0x59C0240", VA = "0x1859C1640")]
			[MethodImpl(4096)]
			private static extern void set_position_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value);

			// Token: 0x0600010C RID: 268
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x59C16E0", Offset = "0x59C02E0", VA = "0x1859C16E0")]
			[MethodImpl(4096)]
			private static extern void set_rotation_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value);

			// Token: 0x0600010D RID: 269
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x59C1440", Offset = "0x59C0040", VA = "0x1859C1440")]
			[MethodImpl(4096)]
			private static extern void get_scale_Injected(ref ParticleSystem.ShapeModule _unity_self, out Vector3 ret);

			// Token: 0x0600010E RID: 270
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x59C1780", Offset = "0x59C0380", VA = "0x1859C1780")]
			[MethodImpl(4096)]
			private static extern void set_scale_Injected(ref ParticleSystem.ShapeModule _unity_self, ref Vector3 value);

			// Token: 0x04000003 RID: 3
			[Token(Token = "0x4000003")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		public struct CollisionModule
		{
			// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600010F")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal CollisionModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x04000004 RID: 4
			[Token(Token = "0x4000004")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		public struct TriggerModule
		{
			// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000110")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal TriggerModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x04000005 RID: 5
			[Token(Token = "0x4000005")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		public struct SubEmittersModule
		{
			// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000111")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal SubEmittersModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000112 RID: 274 RVA: 0x00002880 File Offset: 0x00000A80
			[Token(Token = "0x17000059")]
			public int subEmittersCount
			{
				[Token(Token = "0x6000112")]
				[Address(RVA = "0x59C19A0", Offset = "0x59C05A0", VA = "0x1859C19A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000113 RID: 275 RVA: 0x000026E2 File Offset: 0x000008E2
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x59C1960", Offset = "0x59C0560", VA = "0x1859C1960")]
			[NativeThrows]
			public ParticleSystem GetSubEmitterSystem(int index)
			{
				return null;
			}

			// Token: 0x06000114 RID: 276
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x59C19A0", Offset = "0x59C05A0", VA = "0x1859C19A0")]
			[MethodImpl(4096)]
			private static extern int get_subEmittersCount_Injected(ref ParticleSystem.SubEmittersModule _unity_self);

			// Token: 0x06000115 RID: 277
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x59C1960", Offset = "0x59C0560", VA = "0x1859C1960")]
			[MethodImpl(4096)]
			private static extern ParticleSystem GetSubEmitterSystem_Injected(ref ParticleSystem.SubEmittersModule _unity_self, int index);

			// Token: 0x04000006 RID: 6
			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public struct TextureSheetAnimationModule
		{
			// Token: 0x1700005A RID: 90
			// (get) Token: 0x06000116 RID: 278 RVA: 0x00002898 File Offset: 0x00000A98
			[Token(Token = "0x1700005A")]
			[Obsolete("flipU property is deprecated. Use ParticleSystemRenderer.flip.x instead.", false)]
			public float flipU
			{
				[Token(Token = "0x6000116")]
				[Address(RVA = "0x59C1AE0", Offset = "0x59C06E0", VA = "0x1859C1AE0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000117 RID: 279 RVA: 0x000028B0 File Offset: 0x00000AB0
			[Token(Token = "0x1700005B")]
			[Obsolete("flipV property is deprecated. Use ParticleSystemRenderer.flip.y instead.", false)]
			public float flipV
			{
				[Token(Token = "0x6000117")]
				[Address(RVA = "0x59C1B70", Offset = "0x59C0770", VA = "0x1859C1B70")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000118 RID: 280 RVA: 0x000028C8 File Offset: 0x00000AC8
			[Token(Token = "0x1700005C")]
			[Obsolete("useRandomRow property is deprecated. Use rowMode instead.", false)]
			public bool useRandomRow
			{
				[Token(Token = "0x6000118")]
				[Address(RVA = "0x59C1EC0", Offset = "0x59C0AC0", VA = "0x1859C1EC0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000119")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal TextureSheetAnimationModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x0600011A RID: 282 RVA: 0x000028E0 File Offset: 0x00000AE0
			[Token(Token = "0x1700005D")]
			public bool enabled
			{
				[Token(Token = "0x600011A")]
				[Address(RVA = "0x59C1AA0", Offset = "0x59C06A0", VA = "0x1859C1AA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600011B RID: 283 RVA: 0x000028F8 File Offset: 0x00000AF8
			[Token(Token = "0x1700005E")]
			public ParticleSystemAnimationMode mode
			{
				[Token(Token = "0x600011B")]
				[Address(RVA = "0x59C1CA0", Offset = "0x59C08A0", VA = "0x1859C1CA0")]
				get
				{
					return ParticleSystemAnimationMode.Grid;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600011C RID: 284 RVA: 0x00002910 File Offset: 0x00000B10
			[Token(Token = "0x1700005F")]
			public int numTilesX
			{
				[Token(Token = "0x600011C")]
				[Address(RVA = "0x59C1CE0", Offset = "0x59C08E0", VA = "0x1859C1CE0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x0600011D RID: 285 RVA: 0x00002928 File Offset: 0x00000B28
			[Token(Token = "0x17000060")]
			public int numTilesY
			{
				[Token(Token = "0x600011D")]
				[Address(RVA = "0x59C1D20", Offset = "0x59C0920", VA = "0x1859C1D20")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x0600011E RID: 286 RVA: 0x00002940 File Offset: 0x00000B40
			[Token(Token = "0x17000061")]
			public ParticleSystemAnimationType animation
			{
				[Token(Token = "0x600011E")]
				[Address(RVA = "0x59C1A20", Offset = "0x59C0620", VA = "0x1859C1A20")]
				get
				{
					return ParticleSystemAnimationType.WholeSheet;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x0600011F RID: 287 RVA: 0x00002958 File Offset: 0x00000B58
			[Token(Token = "0x17000062")]
			public ParticleSystemAnimationRowMode rowMode
			{
				[Token(Token = "0x600011F")]
				[Address(RVA = "0x59C1DA0", Offset = "0x59C09A0", VA = "0x1859C1DA0")]
				get
				{
					return ParticleSystemAnimationRowMode.Custom;
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000120 RID: 288 RVA: 0x00002970 File Offset: 0x00000B70
			[Token(Token = "0x17000063")]
			public ParticleSystem.MinMaxCurve frameOverTime
			{
				[Token(Token = "0x6000120")]
				[Address(RVA = "0x59C1C50", Offset = "0x59C0850", VA = "0x1859C1C50")]
				get
				{
					return default(ParticleSystem.MinMaxCurve);
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000121 RID: 289 RVA: 0x00002988 File Offset: 0x00000B88
			[Token(Token = "0x17000064")]
			public ParticleSystem.MinMaxCurve startFrame
			{
				[Token(Token = "0x6000121")]
				[Address(RVA = "0x59C1E70", Offset = "0x59C0A70", VA = "0x1859C1E70")]
				get
				{
					return default(ParticleSystem.MinMaxCurve);
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x06000122 RID: 290 RVA: 0x000029A0 File Offset: 0x00000BA0
			[Token(Token = "0x17000065")]
			public int cycleCount
			{
				[Token(Token = "0x6000122")]
				[Address(RVA = "0x59C1A60", Offset = "0x59C0660", VA = "0x1859C1A60")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000123 RID: 291 RVA: 0x000029B8 File Offset: 0x00000BB8
			[Token(Token = "0x17000066")]
			public int rowIndex
			{
				[Token(Token = "0x6000123")]
				[Address(RVA = "0x59C1D60", Offset = "0x59C0960", VA = "0x1859C1D60")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000067 RID: 103
			// (get) Token: 0x06000124 RID: 292 RVA: 0x000029D0 File Offset: 0x00000BD0
			// (set) Token: 0x06000125 RID: 293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000067")]
			public UVChannelFlags uvChannelMask
			{
				[Token(Token = "0x6000124")]
				[Address(RVA = "0x59C1F00", Offset = "0x59C0B00", VA = "0x1859C1F00")]
				get
				{
					return (UVChannelFlags)0;
				}
				[Token(Token = "0x6000125")]
				[Address(RVA = "0x59C1F40", Offset = "0x59C0B40", VA = "0x1859C1F40")]
				[NativeThrows]
				set
				{
				}
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000126 RID: 294 RVA: 0x000029E8 File Offset: 0x00000BE8
			[Token(Token = "0x17000068")]
			public int spriteCount
			{
				[Token(Token = "0x6000126")]
				[Address(RVA = "0x59C1DE0", Offset = "0x59C09E0", VA = "0x1859C1DE0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000127 RID: 295 RVA: 0x000026E2 File Offset: 0x000008E2
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x59C19E0", Offset = "0x59C05E0", VA = "0x1859C19E0")]
			[NativeThrows]
			public Sprite GetSprite(int index)
			{
				return null;
			}

			// Token: 0x06000128 RID: 296
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x59C1AA0", Offset = "0x59C06A0", VA = "0x1859C1AA0")]
			[MethodImpl(4096)]
			private static extern bool get_enabled_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self);

			// Token: 0x06000129 RID: 297
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x59C1CA0", Offset = "0x59C08A0", VA = "0x1859C1CA0")]
			[MethodImpl(4096)]
			private static extern ParticleSystemAnimationMode get_mode_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self);

			// Token: 0x0600012A RID: 298
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x59C1CE0", Offset = "0x59C08E0", VA = "0x1859C1CE0")]
			[MethodImpl(4096)]
			private static extern int get_numTilesX_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self);

			// Token: 0x0600012B RID: 299
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x59C1D20", Offset = "0x59C0920", VA = "0x1859C1D20")]
			[MethodImpl(4096)]
			private static extern int get_numTilesY_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self);

			// Token: 0x0600012C RID: 300
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x59C1A20", Offset = "0x59C0620", VA = "0x1859C1A20")]
			[MethodImpl(4096)]
			private static extern ParticleSystemAnimationType get_animation_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self);

			// Token: 0x0600012D RID: 301
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x59C1DA0", Offset = "0x59C09A0", VA = "0x1859C1DA0")]
			[MethodImpl(4096)]
			private static extern ParticleSystemAnimationRowMode get_rowMode_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self);

			// Token: 0x0600012E RID: 302
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x59C1C00", Offset = "0x59C0800", VA = "0x1859C1C00")]
			[MethodImpl(4096)]
			private static extern void get_frameOverTime_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self, out ParticleSystem.MinMaxCurve ret);

			// Token: 0x0600012F RID: 303
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x59C1E20", Offset = "0x59C0A20", VA = "0x1859C1E20")]
			[MethodImpl(4096)]
			private static extern void get_startFrame_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self, out ParticleSystem.MinMaxCurve ret);

			// Token: 0x06000130 RID: 304
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x59C1A60", Offset = "0x59C0660", VA = "0x1859C1A60")]
			[MethodImpl(4096)]
			private static extern int get_cycleCount_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self);

			// Token: 0x06000131 RID: 305
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x59C1D60", Offset = "0x59C0960", VA = "0x1859C1D60")]
			[MethodImpl(4096)]
			private static extern int get_rowIndex_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self);

			// Token: 0x06000132 RID: 306
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x59C1F00", Offset = "0x59C0B00", VA = "0x1859C1F00")]
			[MethodImpl(4096)]
			private static extern UVChannelFlags get_uvChannelMask_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self);

			// Token: 0x06000133 RID: 307
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x59C1F40", Offset = "0x59C0B40", VA = "0x1859C1F40")]
			[MethodImpl(4096)]
			private static extern void set_uvChannelMask_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self, UVChannelFlags value);

			// Token: 0x06000134 RID: 308
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x59C1DE0", Offset = "0x59C09E0", VA = "0x1859C1DE0")]
			[MethodImpl(4096)]
			private static extern int get_spriteCount_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self);

			// Token: 0x06000135 RID: 309
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x59C19E0", Offset = "0x59C05E0", VA = "0x1859C19E0")]
			[MethodImpl(4096)]
			private static extern Sprite GetSprite_Injected(ref ParticleSystem.TextureSheetAnimationModule _unity_self, int index);

			// Token: 0x04000007 RID: 7
			[Token(Token = "0x4000007")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		[RequiredByNativeCode("particleSystemParticle", Optional = true)]
		public struct Particle
		{
			// Token: 0x17000069 RID: 105
			// (set) Token: 0x06000136 RID: 310 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000069")]
			[Obsolete("Please use Particle.remainingLifetime instead. (UnityUpgradable) -> UnityEngine.ParticleSystem/Particle.remainingLifetime", false)]
			public float lifetime
			{
				[Token(Token = "0x6000136")]
				[Address(RVA = "0x4E407D0", Offset = "0x4E3F3D0", VA = "0x184E407D0")]
				set
				{
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000137 RID: 311 RVA: 0x00002A00 File Offset: 0x00000C00
			// (set) Token: 0x06000138 RID: 312 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700006A")]
			public Vector3 position
			{
				[Token(Token = "0x6000137")]
				[Address(RVA = "0x5920CC0", Offset = "0x591F8C0", VA = "0x185920CC0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000138")]
				[Address(RVA = "0x361F830", Offset = "0x361E430", VA = "0x18361F830")]
				set
				{
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00002A18 File Offset: 0x00000C18
			// (set) Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700006B")]
			public Vector3 velocity
			{
				[Token(Token = "0x6000139")]
				[Address(RVA = "0x5920CE0", Offset = "0x591F8E0", VA = "0x185920CE0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600013A")]
				[Address(RVA = "0x361F840", Offset = "0x361E440", VA = "0x18361F840")]
				set
				{
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x0600013B RID: 315 RVA: 0x00002A30 File Offset: 0x00000C30
			[Token(Token = "0x1700006C")]
			public Vector3 animatedVelocity
			{
				[Token(Token = "0x600013B")]
				[Address(RVA = "0x59C1010", Offset = "0x59BFC10", VA = "0x1859C1010")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x0600013C RID: 316 RVA: 0x00002A48 File Offset: 0x00000C48
			// (set) Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700006D")]
			public float remainingLifetime
			{
				[Token(Token = "0x600013C")]
				[Address(RVA = "0x59C1060", Offset = "0x59BFC60", VA = "0x1859C1060")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600013D")]
				[Address(RVA = "0x4E407D0", Offset = "0x4E3F3D0", VA = "0x184E407D0")]
				set
				{
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x0600013E RID: 318 RVA: 0x00002A60 File Offset: 0x00000C60
			// (set) Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700006E")]
			public float startLifetime
			{
				[Token(Token = "0x600013E")]
				[Address(RVA = "0x59C10E0", Offset = "0x59BFCE0", VA = "0x1859C10E0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x600013F")]
				[Address(RVA = "0x157D080", Offset = "0x157BC80", VA = "0x18157D080")]
				set
				{
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x06000140 RID: 320 RVA: 0x00002A78 File Offset: 0x00000C78
			// (set) Token: 0x06000141 RID: 321 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700006F")]
			public Color32 startColor
			{
				[Token(Token = "0x6000140")]
				[Address(RVA = "0x59C10D0", Offset = "0x59BFCD0", VA = "0x1859C10D0")]
				get
				{
					return default(Color32);
				}
				[Token(Token = "0x6000141")]
				[Address(RVA = "0x4D1D360", Offset = "0x4D1BF60", VA = "0x184D1D360")]
				set
				{
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x06000142 RID: 322 RVA: 0x00002A90 File Offset: 0x00000C90
			// (set) Token: 0x06000143 RID: 323 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000070")]
			public uint randomSeed
			{
				[Token(Token = "0x6000142")]
				[Address(RVA = "0x59C1050", Offset = "0x59BFC50", VA = "0x1859C1050")]
				get
				{
					return 0U;
				}
				[Token(Token = "0x6000143")]
				[Address(RVA = "0x4A6CF70", Offset = "0x4A6BB70", VA = "0x184A6CF70")]
				set
				{
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x06000144 RID: 324 RVA: 0x00002AA8 File Offset: 0x00000CA8
			[Token(Token = "0x17000071")]
			public Vector3 axisOfRotation
			{
				[Token(Token = "0x6000144")]
				[Address(RVA = "0x59C1030", Offset = "0x59BFC30", VA = "0x1859C1030")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x17000072 RID: 114
			// (set) Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000072")]
			public float startSize
			{
				[Token(Token = "0x6000145")]
				[Address(RVA = "0x59C11B0", Offset = "0x59BFDB0", VA = "0x1859C11B0")]
				set
				{
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x06000146 RID: 326 RVA: 0x00002AC0 File Offset: 0x00000CC0
			[Token(Token = "0x17000073")]
			public float rotation
			{
				[Token(Token = "0x6000146")]
				[Address(RVA = "0x59C10C0", Offset = "0x59BFCC0", VA = "0x1859C10C0")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x06000147 RID: 327 RVA: 0x00002AD8 File Offset: 0x00000CD8
			// (set) Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000074")]
			public Vector3 rotation3D
			{
				[Token(Token = "0x6000147")]
				[Address(RVA = "0x59C1070", Offset = "0x59BFC70", VA = "0x1859C1070")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000148")]
				[Address(RVA = "0x59C1150", Offset = "0x59BFD50", VA = "0x1859C1150")]
				set
				{
				}
			}

			// Token: 0x17000075 RID: 117
			// (set) Token: 0x06000149 RID: 329 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000075")]
			public Vector3 angularVelocity3D
			{
				[Token(Token = "0x6000149")]
				[Address(RVA = "0x59C10F0", Offset = "0x59BFCF0", VA = "0x1859C10F0")]
				set
				{
				}
			}

			// Token: 0x0600014A RID: 330 RVA: 0x00002AF0 File Offset: 0x00000CF0
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x59C0FC0", Offset = "0x59BFBC0", VA = "0x1859C0FC0")]
			public float GetCurrentSize(ParticleSystem system)
			{
				return 0f;
			}

			// Token: 0x0600014B RID: 331 RVA: 0x00002B08 File Offset: 0x00000D08
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x59C0F30", Offset = "0x59BFB30", VA = "0x1859C0F30")]
			public Vector3 GetCurrentSize3D(ParticleSystem system)
			{
				return default(Vector3);
			}

			// Token: 0x0600014C RID: 332 RVA: 0x00002B20 File Offset: 0x00000D20
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x59C0ED0", Offset = "0x59BFAD0", VA = "0x1859C0ED0")]
			public Color32 GetCurrentColor(ParticleSystem system)
			{
				return default(Color32);
			}

			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000008")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Vector3 m_Position;

			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000009")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private Vector3 m_Velocity;

			// Token: 0x0400000A RID: 10
			[Token(Token = "0x400000A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 m_AnimatedVelocity;

			// Token: 0x0400000B RID: 11
			[Token(Token = "0x400000B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Vector3 m_InitialVelocity;

			// Token: 0x0400000C RID: 12
			[Token(Token = "0x400000C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 m_AxisOfRotation;

			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400000D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 m_Rotation;

			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 m_AngularVelocity;

			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 m_StartSize;

			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Color32 m_StartColor;

			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private uint m_RandomSeed;

			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private uint m_ParentRandomSeed;

			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			private float m_Lifetime;

			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private float m_StartLifetime;

			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private int m_MeshIndex;

			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private float m_EmitAccumulator0;

			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private float m_EmitAccumulator1;

			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private uint m_Flags;
		}

		// Token: 0x0200000B RID: 11
		[Token(Token = "0x200000B")]
		[NativeType(CodegenOptions.Custom, "MonoBurst", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		public struct Burst
		{
			// Token: 0x17000076 RID: 118
			// (get) Token: 0x0600014D RID: 333 RVA: 0x00002B38 File Offset: 0x00000D38
			// (set) Token: 0x0600014E RID: 334 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000076")]
			public ParticleSystem.MinMaxCurve count
			{
				[Token(Token = "0x600014D")]
				[Address(RVA = "0x59BB050", Offset = "0x59B9C50", VA = "0x1859BB050")]
				get
				{
					return default(ParticleSystem.MinMaxCurve);
				}
				[Token(Token = "0x600014E")]
				[Address(RVA = "0x59BB070", Offset = "0x59B9C70", VA = "0x1859BB070")]
				set
				{
				}
			}

			// Token: 0x04000019 RID: 25
			[Token(Token = "0x4000019")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float m_Time;

			// Token: 0x0400001A RID: 26
			[Token(Token = "0x400001A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private ParticleSystem.MinMaxCurve m_Count;

			// Token: 0x0400001B RID: 27
			[Token(Token = "0x400001B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int m_RepeatCount;

			// Token: 0x0400001C RID: 28
			[Token(Token = "0x400001C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float m_RepeatInterval;

			// Token: 0x0400001D RID: 29
			[Token(Token = "0x400001D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float m_InvProbability;
		}

		// Token: 0x0200000C RID: 12
		[Token(Token = "0x200000C")]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxCurve", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		[Serializable]
		public struct MinMaxCurve
		{
			// Token: 0x0600014F RID: 335 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x59BC380", Offset = "0x59BAF80", VA = "0x1859BC380")]
			public MinMaxCurve(float constant)
			{
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x06000150 RID: 336 RVA: 0x00002B50 File Offset: 0x00000D50
			[Token(Token = "0x17000077")]
			public ParticleSystemCurveMode mode
			{
				[Token(Token = "0x6000150")]
				[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200")]
				get
				{
					return ParticleSystemCurveMode.Constant;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x06000151 RID: 337 RVA: 0x00002B68 File Offset: 0x00000D68
			// (set) Token: 0x06000152 RID: 338 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000078")]
			public float curveMultiplier
			{
				[Token(Token = "0x6000151")]
				[Address(RVA = "0x5916B50", Offset = "0x5915750", VA = "0x185916B50")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000152")]
				[Address(RVA = "0x8772B0", Offset = "0x875EB0", VA = "0x1808772B0")]
				set
				{
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x06000153 RID: 339 RVA: 0x00002B80 File Offset: 0x00000D80
			// (set) Token: 0x06000154 RID: 340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000079")]
			public float constantMax
			{
				[Token(Token = "0x6000153")]
				[Address(RVA = "0x59BA3A0", Offset = "0x59B8FA0", VA = "0x1859BA3A0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000154")]
				[Address(RVA = "0x168B900", Offset = "0x168A500", VA = "0x18168B900")]
				set
				{
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x06000155 RID: 341 RVA: 0x00002B98 File Offset: 0x00000D98
			// (set) Token: 0x06000156 RID: 342 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700007A")]
			public float constantMin
			{
				[Token(Token = "0x6000155")]
				[Address(RVA = "0x5917F60", Offset = "0x5916B60", VA = "0x185917F60")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000156")]
				[Address(RVA = "0x5B4660", Offset = "0x5B3260", VA = "0x1805B4660")]
				set
				{
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x06000157 RID: 343 RVA: 0x00002BB0 File Offset: 0x00000DB0
			// (set) Token: 0x06000158 RID: 344 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700007B")]
			public float constant
			{
				[Token(Token = "0x6000157")]
				[Address(RVA = "0x59BA3A0", Offset = "0x59B8FA0", VA = "0x1859BA3A0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000158")]
				[Address(RVA = "0x168B900", Offset = "0x168A500", VA = "0x18168B900")]
				set
				{
				}
			}

			// Token: 0x06000159 RID: 345 RVA: 0x00002BC8 File Offset: 0x00000DC8
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x59BC260", Offset = "0x59BAE60", VA = "0x1859BC260")]
			public float Evaluate(float time, float lerpFactor)
			{
				return 0f;
			}

			// Token: 0x0600015A RID: 346 RVA: 0x00002BE0 File Offset: 0x00000DE0
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x59BC3D0", Offset = "0x59BAFD0", VA = "0x1859BC3D0")]
			public static implicit operator ParticleSystem.MinMaxCurve(float constant)
			{
				return default(ParticleSystem.MinMaxCurve);
			}

			// Token: 0x0400001E RID: 30
			[Token(Token = "0x400001E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private ParticleSystemCurveMode m_Mode;

			// Token: 0x0400001F RID: 31
			[Token(Token = "0x400001F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			[SerializeField]
			private float m_CurveMultiplier;

			// Token: 0x04000020 RID: 32
			[Token(Token = "0x4000020")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			private AnimationCurve m_CurveMin;

			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private AnimationCurve m_CurveMax;

			// Token: 0x04000022 RID: 34
			[Token(Token = "0x4000022")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float m_ConstantMin;

			// Token: 0x04000023 RID: 35
			[Token(Token = "0x4000023")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private float m_ConstantMax;
		}

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		[NativeType(CodegenOptions.Custom, "MonoMinMaxGradient", Header = "Runtime/Scripting/ScriptingCommonStructDefinitions.h")]
		[Serializable]
		public struct MinMaxGradient
		{
			// Token: 0x0600015B RID: 347 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x59BC6A0", Offset = "0x59BB2A0", VA = "0x1859BC6A0")]
			public MinMaxGradient(Color color)
			{
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x0600015C RID: 348 RVA: 0x00002BF8 File Offset: 0x00000DF8
			[Token(Token = "0x1700007C")]
			public Color color
			{
				[Token(Token = "0x600015C")]
				[Address(RVA = "0x59957A0", Offset = "0x59943A0", VA = "0x1859957A0")]
				get
				{
					return default(Color);
				}
			}

			// Token: 0x0600015D RID: 349 RVA: 0x00002C10 File Offset: 0x00000E10
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x59BC460", Offset = "0x59BB060", VA = "0x1859BC460")]
			public Color Evaluate(float time, float lerpFactor)
			{
				return default(Color);
			}

			// Token: 0x0600015E RID: 350 RVA: 0x00002C28 File Offset: 0x00000E28
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x59BC700", Offset = "0x59BB300", VA = "0x1859BC700")]
			public static implicit operator ParticleSystem.MinMaxGradient(Color color)
			{
				return default(ParticleSystem.MinMaxGradient);
			}

			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[SerializeField]
			private ParticleSystemGradientMode m_Mode;

			// Token: 0x04000025 RID: 37
			[Token(Token = "0x4000025")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[SerializeField]
			private Gradient m_GradientMin;

			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Gradient m_GradientMax;

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Color m_ColorMin;

			// Token: 0x04000028 RID: 40
			[Token(Token = "0x4000028")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[SerializeField]
			private Color m_ColorMax;
		}

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		public struct EmitParams
		{
			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[NativeName("particle")]
			private ParticleSystem.Particle m_Particle;

			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[NativeName("positionSet")]
			private bool m_PositionSet;

			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
			[NativeName("velocitySet")]
			private bool m_VelocitySet;

			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
			[NativeName("axisOfRotationSet")]
			private bool m_AxisOfRotationSet;

			// Token: 0x0400002D RID: 45
			[Token(Token = "0x400002D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x87")]
			[NativeName("rotationSet")]
			private bool m_RotationSet;

			// Token: 0x0400002E RID: 46
			[Token(Token = "0x400002E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[NativeName("rotationalSpeedSet")]
			private bool m_AngularVelocitySet;

			// Token: 0x0400002F RID: 47
			[Token(Token = "0x400002F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
			[NativeName("startSizeSet")]
			private bool m_StartSizeSet;

			// Token: 0x04000030 RID: 48
			[Token(Token = "0x4000030")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
			[NativeName("startColorSet")]
			private bool m_StartColorSet;

			// Token: 0x04000031 RID: 49
			[Token(Token = "0x4000031")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8B")]
			[NativeName("randomSeedSet")]
			private bool m_RandomSeedSet;

			// Token: 0x04000032 RID: 50
			[Token(Token = "0x4000032")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[NativeName("startLifetimeSet")]
			private bool m_StartLifetimeSet;

			// Token: 0x04000033 RID: 51
			[Token(Token = "0x4000033")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
			[NativeName("meshIndexSet")]
			private bool m_MeshIndexSet;

			// Token: 0x04000034 RID: 52
			[Token(Token = "0x4000034")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8E")]
			[NativeName("applyShapeToPosition")]
			private bool m_ApplyShapeToPosition;
		}

		// Token: 0x0200000F RID: 15
		[Token(Token = "0x200000F")]
		public struct PlaybackState
		{
			// Token: 0x04000035 RID: 53
			[Token(Token = "0x4000035")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal float m_AccumulatedDt;

			// Token: 0x04000036 RID: 54
			[Token(Token = "0x4000036")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			internal float m_StartDelay;

			// Token: 0x04000037 RID: 55
			[Token(Token = "0x4000037")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal float m_PlaybackTime;

			// Token: 0x04000038 RID: 56
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			internal int m_RingBufferIndex;

			// Token: 0x04000039 RID: 57
			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal ParticleSystem.PlaybackState.Emission m_Emission;

			// Token: 0x0400003A RID: 58
			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal ParticleSystem.PlaybackState.Initial m_Initial;

			// Token: 0x0400003B RID: 59
			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal ParticleSystem.PlaybackState.Shape m_Shape;

			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			internal ParticleSystem.PlaybackState.Force m_Force;

			// Token: 0x0400003D RID: 61
			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			internal ParticleSystem.PlaybackState.Collision m_Collision;

			// Token: 0x0400003E RID: 62
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			internal ParticleSystem.PlaybackState.Noise m_Noise;

			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			internal ParticleSystem.PlaybackState.Lights m_Lights;

			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			internal ParticleSystem.PlaybackState.Trail m_Trail;

			// Token: 0x02000010 RID: 16
			[Token(Token = "0x2000010")]
			internal struct Seed
			{
				// Token: 0x04000041 RID: 65
				[Token(Token = "0x4000041")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public uint x;

				// Token: 0x04000042 RID: 66
				[Token(Token = "0x4000042")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public uint y;

				// Token: 0x04000043 RID: 67
				[Token(Token = "0x4000043")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public uint z;

				// Token: 0x04000044 RID: 68
				[Token(Token = "0x4000044")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public uint w;
			}

			// Token: 0x02000011 RID: 17
			[Token(Token = "0x2000011")]
			internal struct Seed4
			{
				// Token: 0x04000045 RID: 69
				[Token(Token = "0x4000045")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public ParticleSystem.PlaybackState.Seed x;

				// Token: 0x04000046 RID: 70
				[Token(Token = "0x4000046")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public ParticleSystem.PlaybackState.Seed y;

				// Token: 0x04000047 RID: 71
				[Token(Token = "0x4000047")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public ParticleSystem.PlaybackState.Seed z;

				// Token: 0x04000048 RID: 72
				[Token(Token = "0x4000048")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public ParticleSystem.PlaybackState.Seed w;
			}

			// Token: 0x02000012 RID: 18
			[Token(Token = "0x2000012")]
			internal struct Emission
			{
				// Token: 0x04000049 RID: 73
				[Token(Token = "0x4000049")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float m_ParticleSpacing;

				// Token: 0x0400004A RID: 74
				[Token(Token = "0x400004A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float m_ToEmitAccumulator;

				// Token: 0x0400004B RID: 75
				[Token(Token = "0x400004B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public ParticleSystem.PlaybackState.Seed m_Random;
			}

			// Token: 0x02000013 RID: 19
			[Token(Token = "0x2000013")]
			internal struct Initial
			{
				// Token: 0x0400004C RID: 76
				[Token(Token = "0x400004C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public ParticleSystem.PlaybackState.Seed4 m_Random;
			}

			// Token: 0x02000014 RID: 20
			[Token(Token = "0x2000014")]
			internal struct Shape
			{
				// Token: 0x0400004D RID: 77
				[Token(Token = "0x400004D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public ParticleSystem.PlaybackState.Seed4 m_Random;

				// Token: 0x0400004E RID: 78
				[Token(Token = "0x400004E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public float m_RadiusTimer;

				// Token: 0x0400004F RID: 79
				[Token(Token = "0x400004F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
				public float m_RadiusTimerPrev;

				// Token: 0x04000050 RID: 80
				[Token(Token = "0x4000050")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public float m_ArcTimer;

				// Token: 0x04000051 RID: 81
				[Token(Token = "0x4000051")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
				public float m_ArcTimerPrev;

				// Token: 0x04000052 RID: 82
				[Token(Token = "0x4000052")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public float m_MeshSpawnTimer;

				// Token: 0x04000053 RID: 83
				[Token(Token = "0x4000053")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
				public float m_MeshSpawnTimerPrev;

				// Token: 0x04000054 RID: 84
				[Token(Token = "0x4000054")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public int m_OrderedMeshVertexIndex;
			}

			// Token: 0x02000015 RID: 21
			[Token(Token = "0x2000015")]
			internal struct Force
			{
				// Token: 0x04000055 RID: 85
				[Token(Token = "0x4000055")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public ParticleSystem.PlaybackState.Seed4 m_Random;
			}

			// Token: 0x02000016 RID: 22
			[Token(Token = "0x2000016")]
			internal struct Collision
			{
				// Token: 0x04000056 RID: 86
				[Token(Token = "0x4000056")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public ParticleSystem.PlaybackState.Seed4 m_Random;
			}

			// Token: 0x02000017 RID: 23
			[Token(Token = "0x2000017")]
			internal struct Noise
			{
				// Token: 0x04000057 RID: 87
				[Token(Token = "0x4000057")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float m_ScrollOffset;
			}

			// Token: 0x02000018 RID: 24
			[Token(Token = "0x2000018")]
			internal struct Lights
			{
				// Token: 0x04000058 RID: 88
				[Token(Token = "0x4000058")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public ParticleSystem.PlaybackState.Seed m_Random;

				// Token: 0x04000059 RID: 89
				[Token(Token = "0x4000059")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public float m_ParticleEmissionCounter;
			}

			// Token: 0x02000019 RID: 25
			[Token(Token = "0x2000019")]
			internal struct Trail
			{
				// Token: 0x0400005A RID: 90
				[Token(Token = "0x400005A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float m_Timer;
			}
		}

		// Token: 0x0200001A RID: 26
		[Token(Token = "0x200001A")]
		[NativeType(CodegenOptions.Custom, "MonoParticleTrails")]
		public struct Trails
		{
			// Token: 0x0600015F RID: 351 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x59C24A0", Offset = "0x59C10A0", VA = "0x1859C24A0")]
			internal void Allocate()
			{
			}

			// Token: 0x0400005B RID: 91
			[Token(Token = "0x400005B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal List<Vector4> positions;

			// Token: 0x0400005C RID: 92
			[Token(Token = "0x400005C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal List<int> frontPositions;

			// Token: 0x0400005D RID: 93
			[Token(Token = "0x400005D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal List<int> backPositions;

			// Token: 0x0400005E RID: 94
			[Token(Token = "0x400005E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal List<int> positionCounts;

			// Token: 0x0400005F RID: 95
			[Token(Token = "0x400005F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int maxTrailCount;

			// Token: 0x04000060 RID: 96
			[Token(Token = "0x4000060")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal int maxPositionsPerTrailCount;
		}

		// Token: 0x0200001B RID: 27
		[Token(Token = "0x200001B")]
		public struct VelocityOverLifetimeModule
		{
			// Token: 0x06000160 RID: 352 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000160")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal VelocityOverLifetimeModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x04000061 RID: 97
			[Token(Token = "0x4000061")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200001C RID: 28
		[Token(Token = "0x200001C")]
		public struct LimitVelocityOverLifetimeModule
		{
			// Token: 0x06000161 RID: 353 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000161")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal LimitVelocityOverLifetimeModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x04000062 RID: 98
			[Token(Token = "0x4000062")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200001D RID: 29
		[Token(Token = "0x200001D")]
		public struct InheritVelocityModule
		{
			// Token: 0x06000162 RID: 354 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal InheritVelocityModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x04000063 RID: 99
			[Token(Token = "0x4000063")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		public struct LifetimeByEmitterSpeedModule
		{
			// Token: 0x06000163 RID: 355 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000163")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal LifetimeByEmitterSpeedModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x04000064 RID: 100
			[Token(Token = "0x4000064")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200001F RID: 31
		[Token(Token = "0x200001F")]
		public struct ForceOverLifetimeModule
		{
			// Token: 0x06000164 RID: 356 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000164")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal ForceOverLifetimeModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x04000065 RID: 101
			[Token(Token = "0x4000065")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		public struct ColorOverLifetimeModule
		{
			// Token: 0x06000165 RID: 357 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000165")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal ColorOverLifetimeModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000166 RID: 358 RVA: 0x00002C40 File Offset: 0x00000E40
			[Token(Token = "0x1700007D")]
			public bool enabled
			{
				[Token(Token = "0x6000166")]
				[Address(RVA = "0x59BB230", Offset = "0x59B9E30", VA = "0x1859BB230")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000167 RID: 359 RVA: 0x00002C58 File Offset: 0x00000E58
			[Token(Token = "0x1700007E")]
			public ParticleSystem.MinMaxGradient color
			{
				[Token(Token = "0x6000167")]
				[Address(RVA = "0x59BB1D0", Offset = "0x59B9DD0", VA = "0x1859BB1D0")]
				get
				{
					return default(ParticleSystem.MinMaxGradient);
				}
			}

			// Token: 0x06000168 RID: 360
			[Token(Token = "0x6000168")]
			[Address(RVA = "0x59BB230", Offset = "0x59B9E30", VA = "0x1859BB230")]
			[MethodImpl(4096)]
			private static extern bool get_enabled_Injected(ref ParticleSystem.ColorOverLifetimeModule _unity_self);

			// Token: 0x06000169 RID: 361
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x59BB180", Offset = "0x59B9D80", VA = "0x1859BB180")]
			[MethodImpl(4096)]
			private static extern void get_color_Injected(ref ParticleSystem.ColorOverLifetimeModule _unity_self, out ParticleSystem.MinMaxGradient ret);

			// Token: 0x04000066 RID: 102
			[Token(Token = "0x4000066")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000021 RID: 33
		[Token(Token = "0x2000021")]
		public struct ColorBySpeedModule
		{
			// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600016A")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal ColorBySpeedModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x0600016B RID: 363 RVA: 0x00002C70 File Offset: 0x00000E70
			[Token(Token = "0x1700007F")]
			public bool enabled
			{
				[Token(Token = "0x600016B")]
				[Address(RVA = "0x59BB140", Offset = "0x59B9D40", VA = "0x1859BB140")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x0600016C RID: 364 RVA: 0x00002C88 File Offset: 0x00000E88
			[Token(Token = "0x17000080")]
			public ParticleSystem.MinMaxGradient color
			{
				[Token(Token = "0x600016C")]
				[Address(RVA = "0x59BB0E0", Offset = "0x59B9CE0", VA = "0x1859BB0E0")]
				get
				{
					return default(ParticleSystem.MinMaxGradient);
				}
			}

			// Token: 0x0600016D RID: 365
			[Token(Token = "0x600016D")]
			[Address(RVA = "0x59BB140", Offset = "0x59B9D40", VA = "0x1859BB140")]
			[MethodImpl(4096)]
			private static extern bool get_enabled_Injected(ref ParticleSystem.ColorBySpeedModule _unity_self);

			// Token: 0x0600016E RID: 366
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x59BB090", Offset = "0x59B9C90", VA = "0x1859BB090")]
			[MethodImpl(4096)]
			private static extern void get_color_Injected(ref ParticleSystem.ColorBySpeedModule _unity_self, out ParticleSystem.MinMaxGradient ret);

			// Token: 0x04000067 RID: 103
			[Token(Token = "0x4000067")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000022 RID: 34
		[Token(Token = "0x2000022")]
		public struct SizeOverLifetimeModule
		{
			// Token: 0x0600016F RID: 367 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600016F")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal SizeOverLifetimeModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x06000170 RID: 368 RVA: 0x00002CA0 File Offset: 0x00000EA0
			[Token(Token = "0x17000081")]
			public bool enabled
			{
				[Token(Token = "0x6000170")]
				[Address(RVA = "0x59C18E0", Offset = "0x59C04E0", VA = "0x1859C18E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x06000171 RID: 369 RVA: 0x00002CB8 File Offset: 0x00000EB8
			[Token(Token = "0x17000082")]
			public bool separateAxes
			{
				[Token(Token = "0x6000171")]
				[Address(RVA = "0x59C1920", Offset = "0x59C0520", VA = "0x1859C1920")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000172 RID: 370
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x59C18E0", Offset = "0x59C04E0", VA = "0x1859C18E0")]
			[MethodImpl(4096)]
			private static extern bool get_enabled_Injected(ref ParticleSystem.SizeOverLifetimeModule _unity_self);

			// Token: 0x06000173 RID: 371
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x59C1920", Offset = "0x59C0520", VA = "0x1859C1920")]
			[MethodImpl(4096)]
			private static extern bool get_separateAxes_Injected(ref ParticleSystem.SizeOverLifetimeModule _unity_self);

			// Token: 0x04000068 RID: 104
			[Token(Token = "0x4000068")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000023 RID: 35
		[Token(Token = "0x2000023")]
		public struct SizeBySpeedModule
		{
			// Token: 0x06000174 RID: 372 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000174")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal SizeBySpeedModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x06000175 RID: 373 RVA: 0x00002CD0 File Offset: 0x00000ED0
			[Token(Token = "0x17000083")]
			public bool enabled
			{
				[Token(Token = "0x6000175")]
				[Address(RVA = "0x59C1860", Offset = "0x59C0460", VA = "0x1859C1860")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x06000176 RID: 374 RVA: 0x00002CE8 File Offset: 0x00000EE8
			[Token(Token = "0x17000084")]
			public bool separateAxes
			{
				[Token(Token = "0x6000176")]
				[Address(RVA = "0x59C18A0", Offset = "0x59C04A0", VA = "0x1859C18A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000177 RID: 375
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x59C1860", Offset = "0x59C0460", VA = "0x1859C1860")]
			[MethodImpl(4096)]
			private static extern bool get_enabled_Injected(ref ParticleSystem.SizeBySpeedModule _unity_self);

			// Token: 0x06000178 RID: 376
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x59C18A0", Offset = "0x59C04A0", VA = "0x1859C18A0")]
			[MethodImpl(4096)]
			private static extern bool get_separateAxes_Injected(ref ParticleSystem.SizeBySpeedModule _unity_self);

			// Token: 0x04000069 RID: 105
			[Token(Token = "0x4000069")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		public struct RotationOverLifetimeModule
		{
			// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000179")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal RotationOverLifetimeModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x0600017A RID: 378 RVA: 0x00002D00 File Offset: 0x00000F00
			[Token(Token = "0x17000085")]
			public bool enabled
			{
				[Token(Token = "0x600017A")]
				[Address(RVA = "0x59C1260", Offset = "0x59BFE60", VA = "0x1859C1260")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x0600017B RID: 379 RVA: 0x00002D18 File Offset: 0x00000F18
			[Token(Token = "0x17000086")]
			public bool separateAxes
			{
				[Token(Token = "0x600017B")]
				[Address(RVA = "0x59C12A0", Offset = "0x59BFEA0", VA = "0x1859C12A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600017C RID: 380
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x59C1260", Offset = "0x59BFE60", VA = "0x1859C1260")]
			[MethodImpl(4096)]
			private static extern bool get_enabled_Injected(ref ParticleSystem.RotationOverLifetimeModule _unity_self);

			// Token: 0x0600017D RID: 381
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x59C12A0", Offset = "0x59BFEA0", VA = "0x1859C12A0")]
			[MethodImpl(4096)]
			private static extern bool get_separateAxes_Injected(ref ParticleSystem.RotationOverLifetimeModule _unity_self);

			// Token: 0x0400006A RID: 106
			[Token(Token = "0x400006A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000025 RID: 37
		[Token(Token = "0x2000025")]
		public struct RotationBySpeedModule
		{
			// Token: 0x0600017E RID: 382 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600017E")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal RotationBySpeedModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x0600017F RID: 383 RVA: 0x00002D30 File Offset: 0x00000F30
			[Token(Token = "0x17000087")]
			public bool enabled
			{
				[Token(Token = "0x600017F")]
				[Address(RVA = "0x59C11E0", Offset = "0x59BFDE0", VA = "0x1859C11E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x06000180 RID: 384 RVA: 0x00002D48 File Offset: 0x00000F48
			[Token(Token = "0x17000088")]
			public bool separateAxes
			{
				[Token(Token = "0x6000180")]
				[Address(RVA = "0x59C1220", Offset = "0x59BFE20", VA = "0x1859C1220")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000181 RID: 385
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x59C11E0", Offset = "0x59BFDE0", VA = "0x1859C11E0")]
			[MethodImpl(4096)]
			private static extern bool get_enabled_Injected(ref ParticleSystem.RotationBySpeedModule _unity_self);

			// Token: 0x06000182 RID: 386
			[Token(Token = "0x6000182")]
			[Address(RVA = "0x59C1220", Offset = "0x59BFE20", VA = "0x1859C1220")]
			[MethodImpl(4096)]
			private static extern bool get_separateAxes_Injected(ref ParticleSystem.RotationBySpeedModule _unity_self);

			// Token: 0x0400006B RID: 107
			[Token(Token = "0x400006B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x2000026")]
		public struct ExternalForcesModule
		{
			// Token: 0x06000183 RID: 387 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal ExternalForcesModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x0400006C RID: 108
			[Token(Token = "0x400006C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		public struct NoiseModule
		{
			// Token: 0x06000184 RID: 388 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000184")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal NoiseModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x0400006D RID: 109
			[Token(Token = "0x400006D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		public struct LightsModule
		{
			// Token: 0x06000185 RID: 389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000185")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal LightsModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x0400006E RID: 110
			[Token(Token = "0x400006E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x02000029 RID: 41
		[Token(Token = "0x2000029")]
		public struct TrailModule
		{
			// Token: 0x06000186 RID: 390 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000186")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal TrailModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x06000187 RID: 391 RVA: 0x00002D60 File Offset: 0x00000F60
			[Token(Token = "0x17000089")]
			public bool enabled
			{
				[Token(Token = "0x6000187")]
				[Address(RVA = "0x59C20E0", Offset = "0x59C0CE0", VA = "0x1859C20E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000188 RID: 392 RVA: 0x00002D78 File Offset: 0x00000F78
			[Token(Token = "0x1700008A")]
			public ParticleSystemTrailMode mode
			{
				[Token(Token = "0x6000188")]
				[Address(RVA = "0x59C2240", Offset = "0x59C0E40", VA = "0x1859C2240")]
				get
				{
					return ParticleSystemTrailMode.PerParticle;
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000189 RID: 393 RVA: 0x00002D90 File Offset: 0x00000F90
			[Token(Token = "0x1700008B")]
			public float ratio
			{
				[Token(Token = "0x6000189")]
				[Address(RVA = "0x59C2280", Offset = "0x59C0E80", VA = "0x1859C2280")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x0600018A RID: 394 RVA: 0x00002DA8 File Offset: 0x00000FA8
			[Token(Token = "0x1700008C")]
			public ParticleSystem.MinMaxCurve lifetime
			{
				[Token(Token = "0x600018A")]
				[Address(RVA = "0x59C21B0", Offset = "0x59C0DB0", VA = "0x1859C21B0")]
				get
				{
					return default(ParticleSystem.MinMaxCurve);
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x0600018B RID: 395 RVA: 0x00002DC0 File Offset: 0x00000FC0
			[Token(Token = "0x1700008D")]
			public float minVertexDistance
			{
				[Token(Token = "0x600018B")]
				[Address(RVA = "0x59C2200", Offset = "0x59C0E00", VA = "0x1859C2200")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x0600018C RID: 396 RVA: 0x00002DD8 File Offset: 0x00000FD8
			[Token(Token = "0x1700008E")]
			public ParticleSystemTrailTextureMode textureMode
			{
				[Token(Token = "0x600018C")]
				[Address(RVA = "0x59C2380", Offset = "0x59C0F80", VA = "0x1859C2380")]
				get
				{
					return ParticleSystemTrailTextureMode.Stretch;
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x0600018D RID: 397 RVA: 0x00002DF0 File Offset: 0x00000FF0
			[Token(Token = "0x1700008F")]
			public bool worldSpace
			{
				[Token(Token = "0x600018D")]
				[Address(RVA = "0x59C2460", Offset = "0x59C1060", VA = "0x1859C2460")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x0600018E RID: 398 RVA: 0x00002E08 File Offset: 0x00001008
			[Token(Token = "0x17000090")]
			public bool sizeAffectsWidth
			{
				[Token(Token = "0x600018E")]
				[Address(RVA = "0x59C2340", Offset = "0x59C0F40", VA = "0x1859C2340")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x0600018F RID: 399 RVA: 0x00002E20 File Offset: 0x00001020
			[Token(Token = "0x17000091")]
			public bool sizeAffectsLifetime
			{
				[Token(Token = "0x600018F")]
				[Address(RVA = "0x59C2300", Offset = "0x59C0F00", VA = "0x1859C2300")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000190 RID: 400 RVA: 0x00002E38 File Offset: 0x00001038
			[Token(Token = "0x17000092")]
			public bool inheritParticleColor
			{
				[Token(Token = "0x6000190")]
				[Address(RVA = "0x59C2120", Offset = "0x59C0D20", VA = "0x1859C2120")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000191 RID: 401 RVA: 0x00002E50 File Offset: 0x00001050
			[Token(Token = "0x17000093")]
			public ParticleSystem.MinMaxGradient colorOverLifetime
			{
				[Token(Token = "0x6000191")]
				[Address(RVA = "0x59C1FD0", Offset = "0x59C0BD0", VA = "0x1859C1FD0")]
				get
				{
					return default(ParticleSystem.MinMaxGradient);
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000192 RID: 402 RVA: 0x00002E68 File Offset: 0x00001068
			[Token(Token = "0x17000094")]
			public ParticleSystem.MinMaxCurve widthOverTrail
			{
				[Token(Token = "0x6000192")]
				[Address(RVA = "0x59C2410", Offset = "0x59C1010", VA = "0x1859C2410")]
				get
				{
					return default(ParticleSystem.MinMaxCurve);
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000193 RID: 403 RVA: 0x00002E80 File Offset: 0x00001080
			[Token(Token = "0x17000095")]
			public ParticleSystem.MinMaxGradient colorOverTrail
			{
				[Token(Token = "0x6000193")]
				[Address(RVA = "0x59C2080", Offset = "0x59C0C80", VA = "0x1859C2080")]
				get
				{
					return default(ParticleSystem.MinMaxGradient);
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000194 RID: 404 RVA: 0x00002E98 File Offset: 0x00001098
			[Token(Token = "0x17000096")]
			public int ribbonCount
			{
				[Token(Token = "0x6000194")]
				[Address(RVA = "0x59C22C0", Offset = "0x59C0EC0", VA = "0x1859C22C0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000195 RID: 405
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x59C20E0", Offset = "0x59C0CE0", VA = "0x1859C20E0")]
			[MethodImpl(4096)]
			private static extern bool get_enabled_Injected(ref ParticleSystem.TrailModule _unity_self);

			// Token: 0x06000196 RID: 406
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x59C2240", Offset = "0x59C0E40", VA = "0x1859C2240")]
			[MethodImpl(4096)]
			private static extern ParticleSystemTrailMode get_mode_Injected(ref ParticleSystem.TrailModule _unity_self);

			// Token: 0x06000197 RID: 407
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x59C2280", Offset = "0x59C0E80", VA = "0x1859C2280")]
			[MethodImpl(4096)]
			private static extern float get_ratio_Injected(ref ParticleSystem.TrailModule _unity_self);

			// Token: 0x06000198 RID: 408
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x59C2160", Offset = "0x59C0D60", VA = "0x1859C2160")]
			[MethodImpl(4096)]
			private static extern void get_lifetime_Injected(ref ParticleSystem.TrailModule _unity_self, out ParticleSystem.MinMaxCurve ret);

			// Token: 0x06000199 RID: 409
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x59C2200", Offset = "0x59C0E00", VA = "0x1859C2200")]
			[MethodImpl(4096)]
			private static extern float get_minVertexDistance_Injected(ref ParticleSystem.TrailModule _unity_self);

			// Token: 0x0600019A RID: 410
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x59C2380", Offset = "0x59C0F80", VA = "0x1859C2380")]
			[MethodImpl(4096)]
			private static extern ParticleSystemTrailTextureMode get_textureMode_Injected(ref ParticleSystem.TrailModule _unity_self);

			// Token: 0x0600019B RID: 411
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x59C2460", Offset = "0x59C1060", VA = "0x1859C2460")]
			[MethodImpl(4096)]
			private static extern bool get_worldSpace_Injected(ref ParticleSystem.TrailModule _unity_self);

			// Token: 0x0600019C RID: 412
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x59C2340", Offset = "0x59C0F40", VA = "0x1859C2340")]
			[MethodImpl(4096)]
			private static extern bool get_sizeAffectsWidth_Injected(ref ParticleSystem.TrailModule _unity_self);

			// Token: 0x0600019D RID: 413
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x59C2300", Offset = "0x59C0F00", VA = "0x1859C2300")]
			[MethodImpl(4096)]
			private static extern bool get_sizeAffectsLifetime_Injected(ref ParticleSystem.TrailModule _unity_self);

			// Token: 0x0600019E RID: 414
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x59C2120", Offset = "0x59C0D20", VA = "0x1859C2120")]
			[MethodImpl(4096)]
			private static extern bool get_inheritParticleColor_Injected(ref ParticleSystem.TrailModule _unity_self);

			// Token: 0x0600019F RID: 415
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x59C1F80", Offset = "0x59C0B80", VA = "0x1859C1F80")]
			[MethodImpl(4096)]
			private static extern void get_colorOverLifetime_Injected(ref ParticleSystem.TrailModule _unity_self, out ParticleSystem.MinMaxGradient ret);

			// Token: 0x060001A0 RID: 416
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x59C23C0", Offset = "0x59C0FC0", VA = "0x1859C23C0")]
			[MethodImpl(4096)]
			private static extern void get_widthOverTrail_Injected(ref ParticleSystem.TrailModule _unity_self, out ParticleSystem.MinMaxCurve ret);

			// Token: 0x060001A1 RID: 417
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x59C2030", Offset = "0x59C0C30", VA = "0x1859C2030")]
			[MethodImpl(4096)]
			private static extern void get_colorOverTrail_Injected(ref ParticleSystem.TrailModule _unity_self, out ParticleSystem.MinMaxGradient ret);

			// Token: 0x060001A2 RID: 418
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x59C22C0", Offset = "0x59C0EC0", VA = "0x1859C22C0")]
			[MethodImpl(4096)]
			private static extern int get_ribbonCount_Injected(ref ParticleSystem.TrailModule _unity_self);

			// Token: 0x0400006F RID: 111
			[Token(Token = "0x400006F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		public struct CustomDataModule
		{
			// Token: 0x060001A3 RID: 419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			internal CustomDataModule(ParticleSystem particleSystem)
			{
			}

			// Token: 0x04000070 RID: 112
			[Token(Token = "0x4000070")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal ParticleSystem m_ParticleSystem;
		}
	}
}
