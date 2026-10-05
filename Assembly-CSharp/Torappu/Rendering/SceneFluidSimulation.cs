using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x0200204E RID: 8270
	[Token(Token = "0x200204E")]
	public class SceneFluidSimulation : MonoBehaviour
	{
		// Token: 0x0600CBDD RID: 52189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBDD")]
		[Address(RVA = "0x34CD560", Offset = "0x34CC160", VA = "0x1834CD560")]
		private void Start()
		{
		}

		// Token: 0x0600CBDE RID: 52190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBDE")]
		[Address(RVA = "0x34CD3E0", Offset = "0x34CBFE0", VA = "0x1834CD3E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600CBDF RID: 52191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBDF")]
		[Address(RVA = "0x34CD830", Offset = "0x34CC430", VA = "0x1834CD830")]
		private void UpdateFluid()
		{
		}

		// Token: 0x0600CBE0 RID: 52192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBE0")]
		[Address(RVA = "0x34CDCC0", Offset = "0x34CC8C0", VA = "0x1834CDCC0")]
		private void Update()
		{
		}

		// Token: 0x0600CBE1 RID: 52193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBE1")]
		[Address(RVA = "0x34CE0B0", Offset = "0x34CCCB0", VA = "0x1834CE0B0")]
		public SceneFluidSimulation()
		{
		}

		// Token: 0x0400D640 RID: 54848
		[Token(Token = "0x400D640")]
		[FieldOffset(Offset = "0x18")]
		public Shader simulation;

		// Token: 0x0400D641 RID: 54849
		[Token(Token = "0x400D641")]
		[FieldOffset(Offset = "0x20")]
		private RenderTexture velocityRT;

		// Token: 0x0400D642 RID: 54850
		[Token(Token = "0x400D642")]
		[FieldOffset(Offset = "0x28")]
		private RenderTexture colorRT;

		// Token: 0x0400D643 RID: 54851
		[Token(Token = "0x400D643")]
		[FieldOffset(Offset = "0x30")]
		private RenderTexture velocityTempRT;

		// Token: 0x0400D644 RID: 54852
		[Token(Token = "0x400D644")]
		[FieldOffset(Offset = "0x38")]
		private RenderTexture colorTempRT;

		// Token: 0x0400D645 RID: 54853
		[Token(Token = "0x400D645")]
		[FieldOffset(Offset = "0x40")]
		private Material simulationMat;

		// Token: 0x0400D646 RID: 54854
		[Token(Token = "0x400D646")]
		[FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float fluidSpeed;

		// Token: 0x0400D647 RID: 54855
		[Token(Token = "0x400D647")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0.03f, 0.2f)]
		public float fluidVorticity;

		// Token: 0x0400D648 RID: 54856
		[Token(Token = "0x400D648")]
		[FieldOffset(Offset = "0x50")]
		public int rtSize;

		// Token: 0x0400D649 RID: 54857
		[Token(Token = "0x400D649")]
		[FieldOffset(Offset = "0x58")]
		public Texture flowMap;

		// Token: 0x0400D64A RID: 54858
		[Token(Token = "0x400D64A")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 5f)]
		public float flowMapIntensity;

		// Token: 0x0400D64B RID: 54859
		[Token(Token = "0x400D64B")]
		[FieldOffset(Offset = "0x64")]
		public bool isUpdate;

		// Token: 0x0400D64C RID: 54860
		[Token(Token = "0x400D64C")]
		[FieldOffset(Offset = "0x65")]
		private bool pinpong;

		// Token: 0x0400D64D RID: 54861
		[Token(Token = "0x400D64D")]
		[FieldOffset(Offset = "0x68")]
		public List<SceneFluidSimulation.Emitter> emitterList;

		// Token: 0x0400D64E RID: 54862
		[Token(Token = "0x400D64E")]
		[FieldOffset(Offset = "0x70")]
		private Vector4[] positionsArray;

		// Token: 0x0400D64F RID: 54863
		[Token(Token = "0x400D64F")]
		[FieldOffset(Offset = "0x78")]
		private float[] rangesArray;

		// Token: 0x0400D650 RID: 54864
		[Token(Token = "0x400D650")]
		[FieldOffset(Offset = "0x80")]
		private float[] forceIntensityArray;

		// Token: 0x0400D651 RID: 54865
		[Token(Token = "0x400D651")]
		[FieldOffset(Offset = "0x88")]
		private Vector4[] forceDirectionArray;

		// Token: 0x0400D652 RID: 54866
		[Token(Token = "0x400D652")]
		[FieldOffset(Offset = "0x90")]
		private Vector4[] colorArray;

		// Token: 0x0400D653 RID: 54867
		[Token(Token = "0x400D653")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int fluidPosition;

		// Token: 0x0400D654 RID: 54868
		[Token(Token = "0x400D654")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int fluidRange;

		// Token: 0x0400D655 RID: 54869
		[Token(Token = "0x400D655")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int forceIntensity;

		// Token: 0x0400D656 RID: 54870
		[Token(Token = "0x400D656")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int forceDirection;

		// Token: 0x0400D657 RID: 54871
		[Token(Token = "0x400D657")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int fluidCol;

		// Token: 0x0400D658 RID: 54872
		[Token(Token = "0x400D658")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int emitterCount;

		// Token: 0x0400D659 RID: 54873
		[Token(Token = "0x400D659")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int _FluidSpeed;

		// Token: 0x0400D65A RID: 54874
		[Token(Token = "0x400D65A")]
		[FieldOffset(Offset = "0x1C")]
		private static readonly int _FluidFlowMap;

		// Token: 0x0400D65B RID: 54875
		[Token(Token = "0x400D65B")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int _FluidFlowMapIntensity;

		// Token: 0x0400D65C RID: 54876
		[Token(Token = "0x400D65C")]
		[FieldOffset(Offset = "0x24")]
		private static readonly int _FluidVorticity;

		// Token: 0x0200204F RID: 8271
		[Token(Token = "0x200204F")]
		[Serializable]
		public class Emitter
		{
			// Token: 0x0600CBE3 RID: 52195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600CBE3")]
			[Address(RVA = "0x34BF5F0", Offset = "0x34BE1F0", VA = "0x1834BF5F0")]
			public Emitter()
			{
			}

			// Token: 0x0400D65D RID: 54877
			[Token(Token = "0x400D65D")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 position;

			// Token: 0x0400D65E RID: 54878
			[Token(Token = "0x400D65E")]
			[FieldOffset(Offset = "0x18")]
			public float range;

			// Token: 0x0400D65F RID: 54879
			[Token(Token = "0x400D65F")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 direction;

			// Token: 0x0400D660 RID: 54880
			[Token(Token = "0x400D660")]
			[FieldOffset(Offset = "0x24")]
			public Color flowCol;

			// Token: 0x0400D661 RID: 54881
			[Token(Token = "0x400D661")]
			[FieldOffset(Offset = "0x34")]
			[Range(0f, 1f)]
			public float forceIntensity;
		}
	}
}
