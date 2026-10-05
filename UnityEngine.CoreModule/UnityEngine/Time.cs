using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000140 RID: 320
	[Token(Token = "0x2000140")]
	[StaticAccessor("GetTimeManager()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Input/TimeManager.h")]
	public class Time
	{
		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000AE7 RID: 2791
		[Token(Token = "0x1700022F")]
		[NativeProperty("CurTime")]
		public static extern float time { [Token(Token = "0x6000AE7")] [Address(RVA = "0x5971500", Offset = "0x5970100", VA = "0x185971500")] [MethodImpl(4096)] get; }

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000AE8 RID: 2792
		[Token(Token = "0x17000230")]
		[NativeProperty("CurTime")]
		public static extern double timeAsDouble { [Token(Token = "0x6000AE8")] [Address(RVA = "0x5971440", Offset = "0x5970040", VA = "0x185971440")] [MethodImpl(4096)] get; }

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000AE9 RID: 2793
		[Token(Token = "0x17000231")]
		[NativeProperty("TimeSinceSceneLoad")]
		public static extern float timeSinceLevelLoad { [Token(Token = "0x6000AE9")] [Address(RVA = "0x59714D0", Offset = "0x59700D0", VA = "0x1859714D0")] [MethodImpl(4096)] get; }

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000AEA RID: 2794
		[Token(Token = "0x17000232")]
		[NativeProperty("TimeSinceSceneLoad")]
		public static extern double timeSinceLevelLoadAsDouble { [Token(Token = "0x6000AEA")] [Address(RVA = "0x59714A0", Offset = "0x59700A0", VA = "0x1859714A0")] [MethodImpl(4096)] get; }

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000AEB RID: 2795
		[Token(Token = "0x17000233")]
		public static extern float deltaTime { [Token(Token = "0x6000AEB")] [Address(RVA = "0x5971170", Offset = "0x596FD70", VA = "0x185971170")] [MethodImpl(4096)] get; }

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000AEC RID: 2796
		[Token(Token = "0x17000234")]
		public static extern float fixedTime { [Token(Token = "0x6000AEC")] [Address(RVA = "0x5971200", Offset = "0x596FE00", VA = "0x185971200")] [MethodImpl(4096)] get; }

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000AED RID: 2797
		[Token(Token = "0x17000235")]
		[NativeProperty("FixedTime")]
		public static extern double fixedTimeAsDouble { [Token(Token = "0x6000AED")] [Address(RVA = "0x59711D0", Offset = "0x596FDD0", VA = "0x1859711D0")] [MethodImpl(4096)] get; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000AEE RID: 2798
		[Token(Token = "0x17000236")]
		public static extern float unscaledTime { [Token(Token = "0x6000AEE")] [Address(RVA = "0x5971590", Offset = "0x5970190", VA = "0x185971590")] [MethodImpl(4096)] get; }

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000AEF RID: 2799
		[Token(Token = "0x17000237")]
		[NativeProperty("UnscaledTime")]
		public static extern double unscaledTimeAsDouble { [Token(Token = "0x6000AEF")] [Address(RVA = "0x5971560", Offset = "0x5970160", VA = "0x185971560")] [MethodImpl(4096)] get; }

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000AF0 RID: 2800
		[Token(Token = "0x17000238")]
		public static extern float fixedUnscaledTime { [Token(Token = "0x6000AF0")] [Address(RVA = "0x5971290", Offset = "0x596FE90", VA = "0x185971290")] [MethodImpl(4096)] get; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000AF1 RID: 2801
		[Token(Token = "0x17000239")]
		[NativeProperty("FixedUnscaledTime")]
		public static extern double fixedUnscaledTimeAsDouble { [Token(Token = "0x6000AF1")] [Address(RVA = "0x5971260", Offset = "0x596FE60", VA = "0x185971260")] [MethodImpl(4096)] get; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000AF2 RID: 2802
		[Token(Token = "0x1700023A")]
		public static extern float unscaledDeltaTime { [Token(Token = "0x6000AF2")] [Address(RVA = "0x5971530", Offset = "0x5970130", VA = "0x185971530")] [MethodImpl(4096)] get; }

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000AF3 RID: 2803
		[Token(Token = "0x1700023B")]
		public static extern float fixedUnscaledDeltaTime { [Token(Token = "0x6000AF3")] [Address(RVA = "0x5971230", Offset = "0x596FE30", VA = "0x185971230")] [MethodImpl(4096)] get; }

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000AF4 RID: 2804
		// (set) Token: 0x06000AF5 RID: 2805
		[Token(Token = "0x1700023C")]
		public static extern float fixedDeltaTime { [Token(Token = "0x6000AF4")] [Address(RVA = "0x59711A0", Offset = "0x596FDA0", VA = "0x1859711A0")] [MethodImpl(4096)] get; [Token(Token = "0x6000AF5")] [Address(RVA = "0x5971660", Offset = "0x5970260", VA = "0x185971660")] [MethodImpl(4096)] set; }

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000AF6 RID: 2806
		// (set) Token: 0x06000AF7 RID: 2807
		[Token(Token = "0x1700023D")]
		public static extern float maximumDeltaTime { [Token(Token = "0x6000AF6")] [Address(RVA = "0x5971320", Offset = "0x596FF20", VA = "0x185971320")] [MethodImpl(4096)] get; [Token(Token = "0x6000AF7")] [Address(RVA = "0x59716A0", Offset = "0x59702A0", VA = "0x1859716A0")] [MethodImpl(4096)] set; }

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000AF8 RID: 2808
		[Token(Token = "0x1700023E")]
		public static extern float smoothDeltaTime { [Token(Token = "0x6000AF8")] [Address(RVA = "0x5971410", Offset = "0x5970010", VA = "0x185971410")] [MethodImpl(4096)] get; }

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000AF9 RID: 2809
		// (set) Token: 0x06000AFA RID: 2810
		[Token(Token = "0x1700023F")]
		public static extern float maximumParticleDeltaTime { [Token(Token = "0x6000AF9")] [Address(RVA = "0x5971350", Offset = "0x596FF50", VA = "0x185971350")] [MethodImpl(4096)] get; [Token(Token = "0x6000AFA")] [Address(RVA = "0x59716E0", Offset = "0x59702E0", VA = "0x1859716E0")] [MethodImpl(4096)] set; }

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000AFB RID: 2811
		// (set) Token: 0x06000AFC RID: 2812
		[Token(Token = "0x17000240")]
		public static extern float timeScale { [Token(Token = "0x6000AFB")] [Address(RVA = "0x5971470", Offset = "0x5970070", VA = "0x185971470")] [MethodImpl(4096)] get; [Token(Token = "0x6000AFC")] [Address(RVA = "0x5971720", Offset = "0x5970320", VA = "0x185971720")] [MethodImpl(4096)] set; }

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000AFD RID: 2813
		[Token(Token = "0x17000241")]
		public static extern int frameCount { [Token(Token = "0x6000AFD")] [Address(RVA = "0x59712C0", Offset = "0x596FEC0", VA = "0x1859712C0")] [MethodImpl(4096)] get; }

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000AFE RID: 2814
		[Token(Token = "0x17000242")]
		[NativeProperty("RenderFrameCount")]
		public static extern int renderedFrameCount { [Token(Token = "0x6000AFE")] [Address(RVA = "0x59713E0", Offset = "0x596FFE0", VA = "0x1859713E0")] [MethodImpl(4096)] get; }

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000AFF RID: 2815
		[Token(Token = "0x17000243")]
		[NativeProperty("Realtime")]
		public static extern float realtimeSinceStartup { [Token(Token = "0x6000AFF")] [Address(RVA = "0x59713B0", Offset = "0x596FFB0", VA = "0x1859713B0")] [MethodImpl(4096)] get; }

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000B00 RID: 2816
		[Token(Token = "0x17000244")]
		[NativeProperty("Realtime")]
		public static extern double realtimeSinceStartupAsDouble { [Token(Token = "0x6000B00")] [Address(RVA = "0x5971380", Offset = "0x596FF80", VA = "0x185971380")] [MethodImpl(4096)] get; }

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000B01 RID: 2817
		// (set) Token: 0x06000B02 RID: 2818
		[Token(Token = "0x17000245")]
		public static extern float captureDeltaTime { [Token(Token = "0x6000B01")] [Address(RVA = "0x5970FF0", Offset = "0x596FBF0", VA = "0x185970FF0")] [MethodImpl(4096)] get; [Token(Token = "0x6000B02")] [Address(RVA = "0x59715C0", Offset = "0x59701C0", VA = "0x1859715C0")] [MethodImpl(4096)] set; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00006270 File Offset: 0x00004470
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000246")]
		public static int captureFramerate
		{
			[Token(Token = "0x6000B03")]
			[Address(RVA = "0x5971020", Offset = "0x596FC20", VA = "0x185971020")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x5971600", Offset = "0x5970200", VA = "0x185971600")]
			set
			{
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000B05 RID: 2821
		[Token(Token = "0x17000247")]
		public static extern bool inFixedTimeStep { [Token(Token = "0x6000B05")] [Address(RVA = "0x59712F0", Offset = "0x596FEF0", VA = "0x1859712F0")] [NativeName("IsUsingFixedTimeStep")] [MethodImpl(4096)] get; }

		// Token: 0x06000B06 RID: 2822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B06")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Time()
		{
		}
	}
}
