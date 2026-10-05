using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	[NativeHeader("Runtime/Export/Graphics/Graphics.bindings.h")]
	[StructLayout(0)]
	public sealed class LightProbes : Object
	{
		// Token: 0x06000328 RID: 808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000328")]
		[Address(RVA = "0x592CB40", Offset = "0x592B740", VA = "0x18592CB40")]
		private LightProbes()
		{
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x06000329 RID: 809 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600032A RID: 810 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000009")]
		public static event Action tetrahedralizationCompleted
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x592CC50", Offset = "0x592B850", VA = "0x18592CC50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600032A")]
			[Address(RVA = "0x592CF10", Offset = "0x592BB10", VA = "0x18592CF10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600032B RID: 811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x592CA90", Offset = "0x592B690", VA = "0x18592CA90")]
		[RequiredByNativeCode]
		private static void Internal_CallTetrahedralizationCompletedFunction()
		{
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600032C RID: 812 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600032D RID: 813 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000A")]
		public static event Action needsRetetrahedralization
		{
			[Token(Token = "0x600032C")]
			[Address(RVA = "0x592CB90", Offset = "0x592B790", VA = "0x18592CB90")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600032D")]
			[Address(RVA = "0x592CE50", Offset = "0x592BA50", VA = "0x18592CE50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x592CA40", Offset = "0x592B640", VA = "0x18592CA40")]
		[RequiredByNativeCode]
		private static void Internal_CallNeedsRetetrahedralizationFunction()
		{
		}

		// Token: 0x0600032F RID: 815
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x592CB10", Offset = "0x592B710", VA = "0x18592CB10")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void Tetrahedralize();

		// Token: 0x06000330 RID: 816
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x592CAE0", Offset = "0x592B6E0", VA = "0x18592CAE0")]
		[FreeFunction]
		[MethodImpl(4096)]
		public static extern void TetrahedralizeAsync();

		// Token: 0x06000331 RID: 817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x592C9E0", Offset = "0x592B5E0", VA = "0x18592C9E0")]
		[FreeFunction]
		public static void GetInterpolatedProbe(Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe)
		{
		}

		// Token: 0x06000332 RID: 818
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x592C460", Offset = "0x592B060", VA = "0x18592C460")]
		[FreeFunction]
		[MethodImpl(4096)]
		internal static extern bool AreLightProbesAllowed(Renderer renderer);

		// Token: 0x06000333 RID: 819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x592C500", Offset = "0x592B100", VA = "0x18592C500")]
		public static void CalculateInterpolatedLightAndOcclusionProbes(Vector3[] positions, SphericalHarmonicsL2[] lightProbes, Vector4[] occlusionProbes)
		{
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x592C6D0", Offset = "0x592B2D0", VA = "0x18592C6D0")]
		public static void CalculateInterpolatedLightAndOcclusionProbes(List<Vector3> positions, List<SphericalHarmonicsL2> lightProbes, List<Vector4> occlusionProbes)
		{
		}

		// Token: 0x06000335 RID: 821
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x592C4A0", Offset = "0x592B0A0", VA = "0x18592C4A0")]
		[FreeFunction]
		[NativeName("CalculateInterpolatedLightAndOcclusionProbes")]
		[MethodImpl(4096)]
		internal static extern void CalculateInterpolatedLightAndOcclusionProbes_Internal([Unmarshalled] Vector3[] positions, int positionsCount, [Unmarshalled] SphericalHarmonicsL2[] lightProbes, [Unmarshalled] Vector4[] occlusionProbes);

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000336 RID: 822
		[Token(Token = "0x170000BC")]
		public extern Vector3[] positions { [Token(Token = "0x6000336")] [Address(RVA = "0x592CE10", Offset = "0x592BA10", VA = "0x18592CE10")] [FreeFunction(HasExplicitThis = true)] [NativeName("GetLightProbePositions")] [MethodImpl(4096)] get; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000337 RID: 823
		// (set) Token: 0x06000338 RID: 824
		[Token(Token = "0x170000BD")]
		public extern SphericalHarmonicsL2[] bakedProbes { [Token(Token = "0x6000337")] [Address(RVA = "0x592CD10", Offset = "0x592B910", VA = "0x18592CD10")] [NativeName("GetBakedCoefficients")] [FreeFunction(HasExplicitThis = true)] [MethodImpl(4096)] get; [Token(Token = "0x6000338")] [Address(RVA = "0x592CFD0", Offset = "0x592BBD0", VA = "0x18592CFD0")] [FreeFunction(HasExplicitThis = true)] [NativeName("SetBakedCoefficients")] [MethodImpl(4096)] set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000339 RID: 825
		[Token(Token = "0x170000BE")]
		public extern int count { [Token(Token = "0x6000339")] [Address(RVA = "0x592CDD0", Offset = "0x592B9D0", VA = "0x18592CDD0")] [NativeName("GetLightProbeCount")] [FreeFunction(HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600033A RID: 826
		[Token(Token = "0x170000BF")]
		public extern int cellCount { [Token(Token = "0x600033A")] [Address(RVA = "0x592CD50", Offset = "0x592B950", VA = "0x18592CD50")] [NativeName("GetTetrahedraSize")] [FreeFunction(HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x0600033B RID: 827
		[Token(Token = "0x600033B")]
		[Address(RVA = "0x592C950", Offset = "0x592B550", VA = "0x18592C950")]
		[NativeName("GetLightProbeCount")]
		[FreeFunction]
		[MethodImpl(4096)]
		internal static extern int GetCount();

		// Token: 0x0600033C RID: 828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600033C")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use GetInterpolatedProbe instead.", true)]
		public void GetInterpolatedLightProbe(Vector3 position, Renderer renderer, float[] coefficients)
		{
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use bakedProbes instead.", true)]
		public float[] coefficients
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x592CD90", Offset = "0x592B990", VA = "0x18592CD90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x0600033F RID: 831
		[Token(Token = "0x600033F")]
		[Address(RVA = "0x592C980", Offset = "0x592B580", VA = "0x18592C980")]
		[MethodImpl(4096)]
		private static extern void GetInterpolatedProbe_Injected(ref Vector3 position, Renderer renderer, out SphericalHarmonicsL2 probe);
	}
}
