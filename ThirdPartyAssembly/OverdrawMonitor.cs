using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001A RID: 26
[Token(Token = "0x200001A")]
[ExecuteInEditMode]
public class OverdrawMonitor : MonoBehaviour
{
	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000017")]
	public static OverdrawMonitor Instance
	{
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x51BF110", Offset = "0x51BDD10", VA = "0x1851BF110")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x060000E9 RID: 233 RVA: 0x00002220 File Offset: 0x00000420
	// (set) Token: 0x060000EA RID: 234 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000018")]
	public long TotalShadedFragments
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x5EC460", Offset = "0x5EB060", VA = "0x1805EC460")]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x35378C0", Offset = "0x35364C0", VA = "0x1835378C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060000EB RID: 235 RVA: 0x00002238 File Offset: 0x00000438
	// (set) Token: 0x060000EC RID: 236 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000019")]
	public float OverdrawRatio
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1692360", Offset = "0x1690F60", VA = "0x181692360")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1692840", Offset = "0x1691440", VA = "0x181692840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060000ED RID: 237 RVA: 0x00002250 File Offset: 0x00000450
	// (set) Token: 0x060000EE RID: 238 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700001A")]
	public long IntervalShadedFragments
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x51C280", Offset = "0x51AE80", VA = "0x18051C280")]
		[CompilerGenerated]
		get
		{
			return 0L;
		}
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x35378D0", Offset = "0x35364D0", VA = "0x1835378D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060000EF RID: 239 RVA: 0x00002268 File Offset: 0x00000468
	// (set) Token: 0x060000F0 RID: 240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700001B")]
	public float IntervalAverageShadedFragments
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1692630", Offset = "0x1691230", VA = "0x181692630")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1692B20", Offset = "0x1691720", VA = "0x181692B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002280 File Offset: 0x00000480
	// (set) Token: 0x060000F2 RID: 242 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700001C")]
	public float IntervalAverageOverdraw
	{
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x4E40370", Offset = "0x4E3EF70", VA = "0x184E40370")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x4E407D0", Offset = "0x4E3F3D0", VA = "0x184E407D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002298 File Offset: 0x00000498
	[Token(Token = "0x1700001D")]
	public float AccumulatedAverageOverdraw
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x51BF080", Offset = "0x51BDC80", VA = "0x1851BF080")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x060000F4 RID: 244 RVA: 0x000022B0 File Offset: 0x000004B0
	// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700001E")]
	public float MaxOverdraw
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x157CF40", Offset = "0x157BB40", VA = "0x18157CF40")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x157D080", Offset = "0x157BC80", VA = "0x18157D080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x000022C8 File Offset: 0x000004C8
	[Token(Token = "0x1700001F")]
	public static bool HasInstance
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x51BF0A0", Offset = "0x51BDCA0", VA = "0x1851BF0A0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
	public void Touch()
	{
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x51BE350", Offset = "0x51BCF50", VA = "0x1851BE350")]
	public void Awake()
	{
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x51BE920", Offset = "0x51BD520", VA = "0x1851BE920")]
	public void OnEnable()
	{
	}

	// Token: 0x060000FA RID: 250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x51BE890", Offset = "0x51BD490", VA = "0x1851BE890")]
	public void OnDisable()
	{
	}

	// Token: 0x060000FB RID: 251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x51BE5C0", Offset = "0x51BD1C0", VA = "0x1851BE5C0")]
	public void LateUpdate()
	{
	}

	// Token: 0x060000FC RID: 252 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x51BEC10", Offset = "0x51BD810", VA = "0x1851BEC10")]
	private void RecreateTexture(Camera main)
	{
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x51BEB80", Offset = "0x51BD780", VA = "0x1851BEB80")]
	private void RecreateComputeBuffer()
	{
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x51BE800", Offset = "0x51BD400", VA = "0x1851BE800")]
	public void OnDestroy()
	{
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x51BE930", Offset = "0x51BD530", VA = "0x1851BE930")]
	public void OnPostRender()
	{
	}

	// Token: 0x06000100 RID: 256 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000100")]
	[Address(RVA = "0x51BEEA0", Offset = "0x51BDAA0", VA = "0x1851BEEA0")]
	public void StartMeasurement()
	{
	}

	// Token: 0x06000101 RID: 257 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000101")]
	[Address(RVA = "0x51BEEE0", Offset = "0x51BDAE0", VA = "0x1851BEEE0")]
	public void Start()
	{
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000102")]
	[Address(RVA = "0x51BEF30", Offset = "0x51BDB30", VA = "0x1851BEF30")]
	public void Stop()
	{
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x4E4AF00", Offset = "0x4E49B00", VA = "0x184E4AF00")]
	public void SetSampleTime(float time)
	{
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x51BEE80", Offset = "0x51BDA80", VA = "0x1851BEE80")]
	public void ResetSampling()
	{
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000105")]
	[Address(RVA = "0x51BEE70", Offset = "0x51BDA70", VA = "0x1851BEE70")]
	public void ResetExtreemes()
	{
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x51BEFF0", Offset = "0x51BDBF0", VA = "0x1851BEFF0")]
	public OverdrawMonitor()
	{
	}

	// Token: 0x0400007C RID: 124
	[Token(Token = "0x400007C")]
	[FieldOffset(Offset = "0x0")]
	private static OverdrawMonitor instance;

	// Token: 0x0400007D RID: 125
	[Token(Token = "0x400007D")]
	[FieldOffset(Offset = "0x8")]
	public static Camera targetCamera;

	// Token: 0x0400007E RID: 126
	[Token(Token = "0x400007E")]
	[FieldOffset(Offset = "0x18")]
	private Camera camera;

	// Token: 0x0400007F RID: 127
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x20")]
	private RenderTexture overdrawTexture;

	// Token: 0x04000080 RID: 128
	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x28")]
	private ComputeShader computeShader;

	// Token: 0x04000081 RID: 129
	[Token(Token = "0x4000081")]
	private const int dataSize = 16384;

	// Token: 0x04000082 RID: 130
	[Token(Token = "0x4000082")]
	[FieldOffset(Offset = "0x30")]
	private int[] inputData;

	// Token: 0x04000083 RID: 131
	[Token(Token = "0x4000083")]
	[FieldOffset(Offset = "0x38")]
	private int[] resultData;

	// Token: 0x04000084 RID: 132
	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x40")]
	private ComputeBuffer resultBuffer;

	// Token: 0x04000085 RID: 133
	[Token(Token = "0x4000085")]
	[FieldOffset(Offset = "0x48")]
	private Shader replacementShader;

	// Token: 0x0400008C RID: 140
	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x78")]
	private long accumulatedIntervalFragments;

	// Token: 0x0400008D RID: 141
	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x80")]
	private float accumulatedIntervalOverdraw;

	// Token: 0x0400008E RID: 142
	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x88")]
	private long intervalFrames;

	// Token: 0x0400008F RID: 143
	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x90")]
	private float intervalTime;

	// Token: 0x04000090 RID: 144
	[Token(Token = "0x4000090")]
	[FieldOffset(Offset = "0x94")]
	public float SampleTime;

	// Token: 0x04000091 RID: 145
	[Token(Token = "0x4000091")]
	[FieldOffset(Offset = "0x98")]
	private bool disabled;
}
