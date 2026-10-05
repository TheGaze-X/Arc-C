using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Il2CppDummyDll;
using Moments.Encoder;
using UnityEngine;

namespace Moments
{
	// Token: 0x020000F2 RID: 242
	[Token(Token = "0x20000F2")]
	[AddComponentMenu("Miscellaneous/Moments Recorder")]
	[RequireComponent(typeof(Camera))]
	[DisallowMultipleComponent]
	public sealed class Recorder : MonoBehaviour
	{
		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00003738 File Offset: 0x00001938
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000084")]
		public RecorderState State
		{
			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			[CompilerGenerated]
			get
			{
				return RecorderState.Recording;
			}
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x4A83F60", Offset = "0x4A82B60", VA = "0x184A83F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000085")]
		public string SaveFolder
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x17000086")]
		public float EstimatedMemoryUse
		{
			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x5430400", Offset = "0x542F000", VA = "0x185430400")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x542FAB0", Offset = "0x542E6B0", VA = "0x18542FAB0")]
		public void Setup(bool autoAspect, int width, int height, int fps, float bufferSize, int repeat, int quality)
		{
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x542F630", Offset = "0x542E230", VA = "0x18542F630")]
		public void Pause()
		{
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x542F730", Offset = "0x542E330", VA = "0x18542F730")]
		public void Record()
		{
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000401")]
		[Address(RVA = "0x542EFE0", Offset = "0x542DBE0", VA = "0x18542EFE0")]
		public void FlushMemory()
		{
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000402")]
		[Address(RVA = "0x542F920", Offset = "0x542E520", VA = "0x18542F920")]
		public void Save()
		{
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000403")]
		[Address(RVA = "0x542F7A0", Offset = "0x542E3A0", VA = "0x18542F7A0")]
		public void Save(string filename)
		{
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x542EE80", Offset = "0x542DA80", VA = "0x18542EE80")]
		private void Awake()
		{
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x542F410", Offset = "0x542E010", VA = "0x18542F410")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000406")]
		[Address(RVA = "0x542F420", Offset = "0x542E020", VA = "0x18542F420")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000407")]
		[Address(RVA = "0x542F320", Offset = "0x542DF20", VA = "0x18542F320")]
		private void Init()
		{
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000408")]
		[Address(RVA = "0x542EF60", Offset = "0x542DB60", VA = "0x18542EF60")]
		public void ComputeHeight()
		{
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x542F240", Offset = "0x542DE40", VA = "0x18542F240")]
		private void Flush(UnityEngine.Object obj)
		{
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040A")]
		[Address(RVA = "0x542F290", Offset = "0x542DE90", VA = "0x18542F290")]
		private string GenerateFileName()
		{
			return null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x542F6A0", Offset = "0x542E2A0", VA = "0x18542F6A0")]
		private IEnumerator PreProcess(string filename)
		{
			return null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x5430210", Offset = "0x542EE10", VA = "0x185430210")]
		private GifFrame ToGifFrame(RenderTexture source, Texture2D target)
		{
			return null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x54303C0", Offset = "0x542EFC0", VA = "0x1854303C0")]
		public Recorder()
		{
		}

		// Token: 0x0400054E RID: 1358
		[Token(Token = "0x400054E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[MomentMin(8f)]
		private int m_Width;

		// Token: 0x0400054F RID: 1359
		[Token(Token = "0x400054F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[MomentMin(8f)]
		private int m_Height;

		// Token: 0x04000550 RID: 1360
		[Token(Token = "0x4000550")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoAspect;

		// Token: 0x04000551 RID: 1361
		[Token(Token = "0x4000551")]
		[FieldOffset(Offset = "0x24")]
		[Range(1f, 30f)]
		[SerializeField]
		private int m_FramePerSecond;

		// Token: 0x04000552 RID: 1362
		[Token(Token = "0x4000552")]
		[FieldOffset(Offset = "0x28")]
		[MomentMin(-1f)]
		[SerializeField]
		private int m_Repeat;

		// Token: 0x04000553 RID: 1363
		[Token(Token = "0x4000553")]
		[FieldOffset(Offset = "0x2C")]
		[Range(1f, 100f)]
		[SerializeField]
		private int m_Quality;

		// Token: 0x04000554 RID: 1364
		[Token(Token = "0x4000554")]
		[FieldOffset(Offset = "0x30")]
		[MomentMin(0.1f)]
		[SerializeField]
		private float m_BufferSize;

		// Token: 0x04000557 RID: 1367
		[Token(Token = "0x4000557")]
		[FieldOffset(Offset = "0x40")]
		public ThreadPriority WorkerPriority;

		// Token: 0x04000558 RID: 1368
		[Token(Token = "0x4000558")]
		[FieldOffset(Offset = "0x48")]
		public Action OnPreProcessingDone;

		// Token: 0x04000559 RID: 1369
		[Token(Token = "0x4000559")]
		[FieldOffset(Offset = "0x50")]
		public Action<int, float> OnFileSaveProgress;

		// Token: 0x0400055A RID: 1370
		[Token(Token = "0x400055A")]
		[FieldOffset(Offset = "0x58")]
		public Action<int, string> OnFileSaved;

		// Token: 0x0400055B RID: 1371
		[Token(Token = "0x400055B")]
		[FieldOffset(Offset = "0x60")]
		private int m_MaxFrameCount;

		// Token: 0x0400055C RID: 1372
		[Token(Token = "0x400055C")]
		[FieldOffset(Offset = "0x64")]
		private float m_Time;

		// Token: 0x0400055D RID: 1373
		[Token(Token = "0x400055D")]
		[FieldOffset(Offset = "0x68")]
		private float m_TimePerFrame;

		// Token: 0x0400055E RID: 1374
		[Token(Token = "0x400055E")]
		[FieldOffset(Offset = "0x70")]
		private Queue<RenderTexture> m_Frames;

		// Token: 0x0400055F RID: 1375
		[Token(Token = "0x400055F")]
		[FieldOffset(Offset = "0x78")]
		private RenderTexture m_RecycledRenderTexture;

		// Token: 0x04000560 RID: 1376
		[Token(Token = "0x4000560")]
		[FieldOffset(Offset = "0x80")]
		private ReflectionUtils<Recorder> m_ReflectionUtils;
	}
}
