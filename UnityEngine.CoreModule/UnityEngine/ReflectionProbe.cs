using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[NativeHeader("Runtime/Camera/ReflectionProbes.h")]
	public sealed class ReflectionProbe : Behaviour
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600017C RID: 380
		// (set) Token: 0x0600017D RID: 381
		[Token(Token = "0x1700005F")]
		[NativeName("ProbeType")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("type property has been deprecated. Starting with Unity 5.4, the only supported reflection probe type is Cube.", true)]
		public extern ReflectionProbeType type { [Token(Token = "0x600017C")] [Address(RVA = "0x5939A70", Offset = "0x5938670", VA = "0x185939A70")] [MethodImpl(4096)] get; [Token(Token = "0x600017D")] [Address(RVA = "0x593A460", Offset = "0x5939060", VA = "0x18593A460")] [MethodImpl(4096)] set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000027D8 File Offset: 0x000009D8
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000060")]
		[NativeName("BoxSize")]
		public Vector3 size
		{
			[Token(Token = "0x600017E")]
			[Address(RVA = "0x5939900", Offset = "0x5938500", VA = "0x185939900")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600017F")]
			[Address(RVA = "0x593A3D0", Offset = "0x5938FD0", VA = "0x18593A3D0")]
			set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000027F0 File Offset: 0x000009F0
		// (set) Token: 0x06000181 RID: 385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000061")]
		[NativeName("BoxOffset")]
		public Vector3 center
		{
			[Token(Token = "0x6000180")]
			[Address(RVA = "0x59393D0", Offset = "0x5937FD0", VA = "0x1859393D0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000181")]
			[Address(RVA = "0x5939F30", Offset = "0x5938B30", VA = "0x185939F30")]
			set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000182 RID: 386
		// (set) Token: 0x06000183 RID: 387
		[Token(Token = "0x17000062")]
		[NativeName("Near")]
		public extern float nearClipPlane { [Token(Token = "0x6000182")] [Address(RVA = "0x5939730", Offset = "0x5938330", VA = "0x185939730")] [MethodImpl(4096)] get; [Token(Token = "0x6000183")] [Address(RVA = "0x593A1C0", Offset = "0x5938DC0", VA = "0x18593A1C0")] [MethodImpl(4096)] set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000184 RID: 388
		// (set) Token: 0x06000185 RID: 389
		[Token(Token = "0x17000063")]
		[NativeName("Far")]
		public extern float farClipPlane { [Token(Token = "0x6000184")] [Address(RVA = "0x5939590", Offset = "0x5938190", VA = "0x185939590")] [MethodImpl(4096)] get; [Token(Token = "0x6000185")] [Address(RVA = "0x593A050", Offset = "0x5938C50", VA = "0x18593A050")] [MethodImpl(4096)] set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000186 RID: 390
		// (set) Token: 0x06000187 RID: 391
		[Token(Token = "0x17000064")]
		[NativeName("IntensityMultiplier")]
		public extern float intensity { [Token(Token = "0x6000186")] [Address(RVA = "0x5939650", Offset = "0x5938250", VA = "0x185939650")] [MethodImpl(4096)] get; [Token(Token = "0x6000187")] [Address(RVA = "0x593A130", Offset = "0x5938D30", VA = "0x18593A130")] [MethodImpl(4096)] set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x17000065")]
		[NativeName("GlobalAABB")]
		public Bounds bounds
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x59392E0", Offset = "0x5937EE0", VA = "0x1859392E0")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000189 RID: 393
		// (set) Token: 0x0600018A RID: 394
		[Token(Token = "0x17000066")]
		[NativeName("HDR")]
		public extern bool hdr { [Token(Token = "0x6000189")] [Address(RVA = "0x59395D0", Offset = "0x59381D0", VA = "0x1859395D0")] [MethodImpl(4096)] get; [Token(Token = "0x600018A")] [Address(RVA = "0x593A0A0", Offset = "0x5938CA0", VA = "0x18593A0A0")] [MethodImpl(4096)] set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600018B RID: 395
		// (set) Token: 0x0600018C RID: 396
		[Token(Token = "0x17000067")]
		[NativeName("RenderDynamicObjects")]
		public extern bool renderDynamicObjects { [Token(Token = "0x600018B")] [Address(RVA = "0x59397F0", Offset = "0x59383F0", VA = "0x1859397F0")] [MethodImpl(4096)] get; [Token(Token = "0x600018C")] [Address(RVA = "0x593A2A0", Offset = "0x5938EA0", VA = "0x18593A2A0")] [MethodImpl(4096)] set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600018D RID: 397
		// (set) Token: 0x0600018E RID: 398
		[Token(Token = "0x17000068")]
		public extern float shadowDistance { [Token(Token = "0x600018D")] [Address(RVA = "0x5939870", Offset = "0x5938470", VA = "0x185939870")] [MethodImpl(4096)] get; [Token(Token = "0x600018E")] [Address(RVA = "0x593A330", Offset = "0x5938F30", VA = "0x18593A330")] [MethodImpl(4096)] set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600018F RID: 399
		// (set) Token: 0x06000190 RID: 400
		[Token(Token = "0x17000069")]
		public extern int resolution { [Token(Token = "0x600018F")] [Address(RVA = "0x5939830", Offset = "0x5938430", VA = "0x185939830")] [MethodImpl(4096)] get; [Token(Token = "0x6000190")] [Address(RVA = "0x593A2F0", Offset = "0x5938EF0", VA = "0x18593A2F0")] [MethodImpl(4096)] set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000191 RID: 401
		// (set) Token: 0x06000192 RID: 402
		[Token(Token = "0x1700006A")]
		public extern int cullingMask { [Token(Token = "0x6000191")] [Address(RVA = "0x5939460", Offset = "0x5938060", VA = "0x185939460")] [MethodImpl(4096)] get; [Token(Token = "0x6000192")] [Address(RVA = "0x5939FC0", Offset = "0x5938BC0", VA = "0x185939FC0")] [MethodImpl(4096)] set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000193 RID: 403
		// (set) Token: 0x06000194 RID: 404
		[Token(Token = "0x1700006B")]
		public extern ReflectionProbeClearFlags clearFlags { [Token(Token = "0x6000193")] [Address(RVA = "0x5939420", Offset = "0x5938020", VA = "0x185939420")] [MethodImpl(4096)] get; [Token(Token = "0x6000194")] [Address(RVA = "0x5939F80", Offset = "0x5938B80", VA = "0x185939F80")] [MethodImpl(4096)] set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x06000196 RID: 406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		public Color backgroundColor
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x59391C0", Offset = "0x5937DC0", VA = "0x1859391C0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x5939DA0", Offset = "0x59389A0", VA = "0x185939DA0")]
			set
			{
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000197 RID: 407
		// (set) Token: 0x06000198 RID: 408
		[Token(Token = "0x1700006D")]
		public extern float blendDistance { [Token(Token = "0x6000197")] [Address(RVA = "0x5939250", Offset = "0x5937E50", VA = "0x185939250")] [MethodImpl(4096)] get; [Token(Token = "0x6000198")] [Address(RVA = "0x5939E40", Offset = "0x5938A40", VA = "0x185939E40")] [MethodImpl(4096)] set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000199 RID: 409
		// (set) Token: 0x0600019A RID: 410
		[Token(Token = "0x1700006E")]
		public extern bool boxProjection { [Token(Token = "0x6000199")] [Address(RVA = "0x5939340", Offset = "0x5937F40", VA = "0x185939340")] [MethodImpl(4096)] get; [Token(Token = "0x600019A")] [Address(RVA = "0x5939E90", Offset = "0x5938A90", VA = "0x185939E90")] [MethodImpl(4096)] set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600019B RID: 411
		// (set) Token: 0x0600019C RID: 412
		[Token(Token = "0x1700006F")]
		public extern ReflectionProbeMode mode { [Token(Token = "0x600019B")] [Address(RVA = "0x59396F0", Offset = "0x59382F0", VA = "0x1859396F0")] [MethodImpl(4096)] get; [Token(Token = "0x600019C")] [Address(RVA = "0x593A180", Offset = "0x5938D80", VA = "0x18593A180")] [MethodImpl(4096)] set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600019D RID: 413
		// (set) Token: 0x0600019E RID: 414
		[Token(Token = "0x17000070")]
		public extern int importance { [Token(Token = "0x600019D")] [Address(RVA = "0x5939610", Offset = "0x5938210", VA = "0x185939610")] [MethodImpl(4096)] get; [Token(Token = "0x600019E")] [Address(RVA = "0x593A0F0", Offset = "0x5938CF0", VA = "0x18593A0F0")] [MethodImpl(4096)] set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600019F RID: 415
		// (set) Token: 0x060001A0 RID: 416
		[Token(Token = "0x17000071")]
		public extern ReflectionProbeRefreshMode refreshMode { [Token(Token = "0x600019F")] [Address(RVA = "0x59397B0", Offset = "0x59383B0", VA = "0x1859397B0")] [MethodImpl(4096)] get; [Token(Token = "0x60001A0")] [Address(RVA = "0x593A260", Offset = "0x5938E60", VA = "0x18593A260")] [MethodImpl(4096)] set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001A1 RID: 417
		// (set) Token: 0x060001A2 RID: 418
		[Token(Token = "0x17000072")]
		public extern ReflectionProbeTimeSlicingMode timeSlicingMode { [Token(Token = "0x60001A1")] [Address(RVA = "0x5939A30", Offset = "0x5938630", VA = "0x185939A30")] [MethodImpl(4096)] get; [Token(Token = "0x60001A2")] [Address(RVA = "0x593A420", Offset = "0x5939020", VA = "0x18593A420")] [MethodImpl(4096)] set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001A3 RID: 419
		// (set) Token: 0x060001A4 RID: 420
		[Token(Token = "0x17000073")]
		public extern Texture bakedTexture { [Token(Token = "0x60001A3")] [Address(RVA = "0x5939210", Offset = "0x5937E10", VA = "0x185939210")] [MethodImpl(4096)] get; [Token(Token = "0x60001A4")] [Address(RVA = "0x5939DF0", Offset = "0x59389F0", VA = "0x185939DF0")] [MethodImpl(4096)] set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001A5 RID: 421
		// (set) Token: 0x060001A6 RID: 422
		[Token(Token = "0x17000074")]
		public extern Texture customBakedTexture { [Token(Token = "0x60001A5")] [Address(RVA = "0x59394A0", Offset = "0x59380A0", VA = "0x1859394A0")] [MethodImpl(4096)] get; [Token(Token = "0x60001A6")] [Address(RVA = "0x593A000", Offset = "0x5938C00", VA = "0x18593A000")] [MethodImpl(4096)] set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001A7 RID: 423
		// (set) Token: 0x060001A8 RID: 424
		[Token(Token = "0x17000075")]
		public extern RenderTexture realtimeTexture { [Token(Token = "0x60001A7")] [Address(RVA = "0x5939770", Offset = "0x5938370", VA = "0x185939770")] [MethodImpl(4096)] get; [Token(Token = "0x60001A8")] [Address(RVA = "0x593A210", Offset = "0x5938E10", VA = "0x18593A210")] [MethodImpl(4096)] set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001A9 RID: 425
		[Token(Token = "0x17000076")]
		public extern Texture texture { [Token(Token = "0x60001A9")] [Address(RVA = "0x59399F0", Offset = "0x59385F0", VA = "0x1859399F0")] [MethodImpl(4096)] get; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x17000077")]
		public Vector4 textureHDRDecodeValues
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x59399A0", Offset = "0x59385A0", VA = "0x1859399A0")]
			[NativeName("CalculateHDRDecodeValues")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x060001AB RID: 427
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x5938E10", Offset = "0x5937A10", VA = "0x185938E10")]
		[MethodImpl(4096)]
		public extern void Reset();

		// Token: 0x060001AC RID: 428 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x5938D20", Offset = "0x5937920", VA = "0x185938D20")]
		public int RenderProbe()
		{
			return 0;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x5938D90", Offset = "0x5937990", VA = "0x185938D90")]
		public int RenderProbe([UnityEngine.Internal.DefaultValue("null")] RenderTexture targetTexture)
		{
			return 0;
		}

		// Token: 0x060001AE RID: 430
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x5938CE0", Offset = "0x59378E0", VA = "0x185938CE0")]
		[MethodImpl(4096)]
		public extern bool IsFinishedRendering(int renderId);

		// Token: 0x060001AF RID: 431
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x5938E50", Offset = "0x5937A50", VA = "0x185938E50")]
		[MethodImpl(4096)]
		private extern int ScheduleRender(ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture);

		// Token: 0x060001B0 RID: 432
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x5938BB0", Offset = "0x59377B0", VA = "0x185938BB0")]
		[FreeFunction("CubemapGPUBlend")]
		[NativeHeader("Runtime/Camera/CubemapGPUUtility.h")]
		[MethodImpl(4096)]
		public static extern bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target);

		// Token: 0x060001B1 RID: 433
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x5938EA0", Offset = "0x5937AA0", VA = "0x185938EA0")]
		[NativeMethod("UpdateSampleData")]
		[StaticAccessor("GetReflectionProbes()")]
		[MethodImpl(4096)]
		public static extern void UpdateCachedState();

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001B2 RID: 434
		[Token(Token = "0x17000078")]
		[StaticAccessor("GetReflectionProbes()")]
		public static extern int minBakedCubemapResolution { [Token(Token = "0x60001B2")] [Address(RVA = "0x59396C0", Offset = "0x59382C0", VA = "0x1859396C0")] [MethodImpl(4096)] get; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B3 RID: 435
		[Token(Token = "0x17000079")]
		[StaticAccessor("GetReflectionProbes()")]
		public static extern int maxBakedCubemapResolution { [Token(Token = "0x60001B3")] [Address(RVA = "0x5939690", Offset = "0x5938290", VA = "0x185939690")] [MethodImpl(4096)] get; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x1700007A")]
		[StaticAccessor("GetReflectionProbes()")]
		public static Vector4 defaultTextureHDRDecodeValues
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x5939520", Offset = "0x5938120", VA = "0x185939520")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B5 RID: 437
		[Token(Token = "0x1700007B")]
		[StaticAccessor("GetReflectionProbes()")]
		public static extern Texture defaultTexture { [Token(Token = "0x60001B5")] [Address(RVA = "0x5939560", Offset = "0x5938160", VA = "0x185939560")] [MethodImpl(4096)] get; }

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060001B6 RID: 438 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001B7 RID: 439 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000006")]
		public static event Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x5939090", Offset = "0x5937C90", VA = "0x185939090")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x5939C70", Offset = "0x5938870", VA = "0x185939C70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001B9 RID: 441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000007")]
		[Obsolete("ReflectionProbe.defaultReflectionSet has been deprecated. Use ReflectionProbe.defaultReflectionTexture. (UnityUpgradable) -> UnityEngine.ReflectionProbe.defaultReflectionTexture", true)]
		public static event Action<Cubemap> defaultReflectionSet
		{
			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x5938ED0", Offset = "0x5937AD0", VA = "0x185938ED0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x5939AB0", Offset = "0x59386B0", VA = "0x185939AB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000008")]
		public static event Action<Texture> defaultReflectionTexture
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x5938FB0", Offset = "0x5937BB0", VA = "0x185938FB0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x5939B90", Offset = "0x5938790", VA = "0x185939B90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x5938C20", Offset = "0x5937820", VA = "0x185938C20")]
		[RequiredByNativeCode]
		private static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x5938C80", Offset = "0x5937880", VA = "0x185938C80")]
		[RequiredByNativeCode]
		private static void CallSetDefaultReflection(Texture defaultReflectionCubemap)
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public ReflectionProbe()
		{
		}

		// Token: 0x060001BF RID: 447
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x59398B0", Offset = "0x59384B0", VA = "0x1859398B0")]
		[MethodImpl(4096)]
		private extern void get_size_Injected(out Vector3 ret);

		// Token: 0x060001C0 RID: 448
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x593A380", Offset = "0x5938F80", VA = "0x18593A380")]
		[MethodImpl(4096)]
		private extern void set_size_Injected(ref Vector3 value);

		// Token: 0x060001C1 RID: 449
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x5939380", Offset = "0x5937F80", VA = "0x185939380")]
		[MethodImpl(4096)]
		private extern void get_center_Injected(out Vector3 ret);

		// Token: 0x060001C2 RID: 450
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x5939EE0", Offset = "0x5938AE0", VA = "0x185939EE0")]
		[MethodImpl(4096)]
		private extern void set_center_Injected(ref Vector3 value);

		// Token: 0x060001C3 RID: 451
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x5939290", Offset = "0x5937E90", VA = "0x185939290")]
		[MethodImpl(4096)]
		private extern void get_bounds_Injected(out Bounds ret);

		// Token: 0x060001C4 RID: 452
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x5939170", Offset = "0x5937D70", VA = "0x185939170")]
		[MethodImpl(4096)]
		private extern void get_backgroundColor_Injected(out Color ret);

		// Token: 0x060001C5 RID: 453
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x5939D50", Offset = "0x5938950", VA = "0x185939D50")]
		[MethodImpl(4096)]
		private extern void set_backgroundColor_Injected(ref Color value);

		// Token: 0x060001C6 RID: 454
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x5939950", Offset = "0x5938550", VA = "0x185939950")]
		[MethodImpl(4096)]
		private extern void get_textureHDRDecodeValues_Injected(out Vector4 ret);

		// Token: 0x060001C7 RID: 455
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x59394E0", Offset = "0x59380E0", VA = "0x1859394E0")]
		[MethodImpl(4096)]
		private static extern void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret);

		// Token: 0x02000060 RID: 96
		[Token(Token = "0x2000060")]
		public enum ReflectionProbeEvent
		{
			// Token: 0x04000142 RID: 322
			[Token(Token = "0x4000142")]
			ReflectionProbeAdded,
			// Token: 0x04000143 RID: 323
			[Token(Token = "0x4000143")]
			ReflectionProbeRemoved
		}
	}
}
