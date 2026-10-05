using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine
{
	// Token: 0x02000086 RID: 134
	[Token(Token = "0x2000086")]
	[NativeHeader("Runtime/Graphics/LineRenderer.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public sealed class LineRenderer : Renderer
	{
		// Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035C")]
		[Address(RVA = "0x592E9F0", Offset = "0x592D5F0", VA = "0x18592E9F0")]
		[Obsolete("Use startWidth, endWidth or widthCurve instead.", false)]
		public void SetWidth(float start, float end)
		{
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035D")]
		[Address(RVA = "0x592E880", Offset = "0x592D480", VA = "0x18592E880")]
		[Obsolete("Use startColor, endColor or colorGradient instead.", false)]
		public void SetColors(Color start, Color end)
		{
		}

		// Token: 0x170000CE RID: 206
		// (set) Token: 0x0600035E RID: 862
		[Token(Token = "0x170000CE")]
		public extern float startWidth { [Token(Token = "0x600035E")] [Address(RVA = "0x592ECD0", Offset = "0x592D8D0", VA = "0x18592ECD0")] [MethodImpl(4096)] set; }

		// Token: 0x170000CF RID: 207
		// (set) Token: 0x0600035F RID: 863
		[Token(Token = "0x170000CF")]
		public extern float endWidth { [Token(Token = "0x600035F")] [Address(RVA = "0x592EB50", Offset = "0x592D750", VA = "0x18592EB50")] [MethodImpl(4096)] set; }

		// Token: 0x170000D0 RID: 208
		// (set) Token: 0x06000360 RID: 864
		[Token(Token = "0x170000D0")]
		public extern bool useWorldSpace { [Token(Token = "0x6000360")] [Address(RVA = "0x592ED20", Offset = "0x592D920", VA = "0x18592ED20")] [MethodImpl(4096)] set; }

		// Token: 0x170000D1 RID: 209
		// (set) Token: 0x06000361 RID: 865
		[Token(Token = "0x170000D1")]
		public extern bool loop { [Token(Token = "0x6000361")] [Address(RVA = "0x592EBA0", Offset = "0x592D7A0", VA = "0x18592EBA0")] [MethodImpl(4096)] set; }

		// Token: 0x170000D2 RID: 210
		// (set) Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D2")]
		public Color startColor
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x592EC80", Offset = "0x592D880", VA = "0x18592EC80")]
			set
			{
			}
		}

		// Token: 0x170000D3 RID: 211
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D3")]
		public Color endColor
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x592EB00", Offset = "0x592D700", VA = "0x18592EB00")]
			set
			{
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000364 RID: 868
		// (set) Token: 0x06000365 RID: 869
		[Token(Token = "0x170000D4")]
		[NativeProperty("PositionsCount")]
		public extern int positionCount { [Token(Token = "0x6000364")] [Address(RVA = "0x592EA70", Offset = "0x592D670", VA = "0x18592EA70")] [MethodImpl(4096)] get; [Token(Token = "0x6000365")] [Address(RVA = "0x592EBF0", Offset = "0x592D7F0", VA = "0x18592EBF0")] [MethodImpl(4096)] set; }

		// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x592E950", Offset = "0x592D550", VA = "0x18592E950")]
		public void SetPosition(int index, Vector3 position)
		{
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00003018 File Offset: 0x00001218
		[Token(Token = "0x6000367")]
		[Address(RVA = "0x592E820", Offset = "0x592D420", VA = "0x18592E820")]
		public Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06000368 RID: 872
		[Token(Token = "0x6000368")]
		[Address(RVA = "0x592E9A0", Offset = "0x592D5A0", VA = "0x18592E9A0")]
		[FreeFunction(Name = "LineRendererScripting::SetPositions", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void SetPositions([NotNull("ArgumentNullException")] Vector3[] positions);

		// Token: 0x06000369 RID: 873
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x592EC30", Offset = "0x592D830", VA = "0x18592EC30")]
		[MethodImpl(4096)]
		private extern void set_startColor_Injected(ref Color value);

		// Token: 0x0600036A RID: 874
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x592EAB0", Offset = "0x592D6B0", VA = "0x18592EAB0")]
		[MethodImpl(4096)]
		private extern void set_endColor_Injected(ref Color value);

		// Token: 0x0600036B RID: 875
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x592E900", Offset = "0x592D500", VA = "0x18592E900")]
		[MethodImpl(4096)]
		private extern void SetPosition_Injected(int index, ref Vector3 position);

		// Token: 0x0600036C RID: 876
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x592E7D0", Offset = "0x592D3D0", VA = "0x18592E7D0")]
		[MethodImpl(4096)]
		private extern void GetPosition_Injected(int index, out Vector3 ret);
	}
}
