using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[ExecuteAlways]
	[AddComponentMenu("Rendering/Post-process Debug", 1002)]
	public sealed class PostProcessDebug : MonoBehaviour
	{
		// Token: 0x06000104 RID: 260 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x58337E0", Offset = "0x58323E0", VA = "0x1858337E0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x5833730", Offset = "0x5832330", VA = "0x185833730")]
		private void OnDisable()
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x5833D90", Offset = "0x5832990", VA = "0x185833D90")]
		private void Update()
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x5833AD0", Offset = "0x58326D0", VA = "0x185833AD0")]
		private void Reset()
		{
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x5833B20", Offset = "0x5832720", VA = "0x185833B20")]
		private void UpdateStates()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x58339C0", Offset = "0x58325C0", VA = "0x1858339C0")]
		private void OnPostRender()
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x5833870", Offset = "0x5832470", VA = "0x185833870")]
		private void OnGUI()
		{
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x5833570", Offset = "0x5832170", VA = "0x185833570")]
		private void DrawMonitor(ref Rect rect, Monitor monitor, bool enabled)
		{
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public PostProcessDebug()
		{
		}

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0x18")]
		public PostProcessLayer postProcessLayer;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0x20")]
		private PostProcessLayer m_PreviousPostProcessLayer;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0x28")]
		public bool lightMeter;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x29")]
		public bool histogram;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x2A")]
		public bool waveform;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x2B")]
		public bool vectorscope;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x2C")]
		public DebugOverlay debugOverlay;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x30")]
		private Camera m_CurrentCamera;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x38")]
		private CommandBuffer m_CmdAfterEverything;
	}
}
