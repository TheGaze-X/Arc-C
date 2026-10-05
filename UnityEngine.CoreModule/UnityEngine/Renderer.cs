using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000088 RID: 136
	[Token(Token = "0x2000088")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	[NativeHeader("Runtime/Graphics/Renderer.h")]
	[RequireComponent(typeof(Transform))]
	[UsedByNativeCode]
	public class Renderer : Component
	{
		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00003078 File Offset: 0x00001278
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D5")]
		[Obsolete("Use shadowCastingMode instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool castShadows
		{
			[Token(Token = "0x6000390")]
			[Address(RVA = "0x593EBF0", Offset = "0x593D7F0", VA = "0x18593EBF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000391")]
			[Address(RVA = "0x593F630", Offset = "0x593E230", VA = "0x18593F630")]
			set
			{
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00003090 File Offset: 0x00001290
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D6")]
		[Obsolete("Use motionVectorGenerationMode instead.", false)]
		public bool motionVectors
		{
			[Token(Token = "0x6000392")]
			[Address(RVA = "0x593EFF0", Offset = "0x593DBF0", VA = "0x18593EFF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x593F920", Offset = "0x593E520", VA = "0x18593F920")]
			set
			{
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000394 RID: 916 RVA: 0x000030A8 File Offset: 0x000012A8
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D7")]
		[Obsolete("Use lightProbeUsage instead.", false)]
		public bool useLightProbes
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x593F450", Offset = "0x593E050", VA = "0x18593F450")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x593FD90", Offset = "0x593E990", VA = "0x18593FD90")]
			set
			{
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000396 RID: 918 RVA: 0x000030C0 File Offset: 0x000012C0
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D8")]
		public Bounds bounds
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x593EB90", Offset = "0x593D790", VA = "0x18593EB90")]
			[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = true)]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x593F5E0", Offset = "0x593E1E0", VA = "0x18593F5E0")]
			[NativeName("SetWorldAABB")]
			set
			{
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000398 RID: 920 RVA: 0x000030D8 File Offset: 0x000012D8
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D9")]
		public Bounds localBounds
		{
			[Token(Token = "0x6000398")]
			[Address(RVA = "0x593EEA0", Offset = "0x593DAA0", VA = "0x18593EEA0")]
			[FreeFunction(Name = "RendererScripting::GetLocalBounds", HasExplicitThis = true)]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x593F890", Offset = "0x593E490", VA = "0x18593F890")]
			[NativeName("SetLocalAABB")]
			set
			{
			}
		}

		// Token: 0x0600039A RID: 922
		[Token(Token = "0x600039A")]
		[Address(RVA = "0x593E790", Offset = "0x593D390", VA = "0x18593E790")]
		[NativeName("ResetWorldAABB")]
		[MethodImpl(4096)]
		public extern void ResetBounds();

		// Token: 0x0600039B RID: 923
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x593E7D0", Offset = "0x593D3D0", VA = "0x18593E7D0")]
		[NativeName("ResetLocalAABB")]
		[MethodImpl(4096)]
		public extern void ResetLocalBounds();

		// Token: 0x0600039C RID: 924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x593EAB0", Offset = "0x593D6B0", VA = "0x18593EAB0")]
		[FreeFunction(Name = "RendererScripting::SetStaticLightmapST", HasExplicitThis = true)]
		private void SetStaticLightmapST(Vector4 st)
		{
		}

		// Token: 0x0600039D RID: 925
		[Token(Token = "0x600039D")]
		[Address(RVA = "0x593E2F0", Offset = "0x593CEF0", VA = "0x18593E2F0")]
		[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern Material GetMaterial();

		// Token: 0x0600039E RID: 926
		[Token(Token = "0x600039E")]
		[Address(RVA = "0x593E540", Offset = "0x593D140", VA = "0x18593E540")]
		[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern Material GetSharedMaterial();

		// Token: 0x0600039F RID: 927
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x593E9C0", Offset = "0x593D5C0", VA = "0x18593E9C0")]
		[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetMaterial(Material m);

		// Token: 0x060003A0 RID: 928
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x593E270", Offset = "0x593CE70", VA = "0x18593E270")]
		[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern Material[] GetMaterialArray();

		// Token: 0x060003A1 RID: 929
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x593E050", Offset = "0x593CC50", VA = "0x18593E050")]
		[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void CopyMaterialArray([Out] Material[] m);

		// Token: 0x060003A2 RID: 930
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x593E0A0", Offset = "0x593CCA0", VA = "0x18593E0A0")]
		[FreeFunction(Name = "RendererScripting::GetSharedMaterialArray", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void CopySharedMaterialArray([Out] Material[] m);

		// Token: 0x060003A3 RID: 931
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x593E970", Offset = "0x593D570", VA = "0x18593E970")]
		[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetMaterialArray([NotNull("ArgumentNullException")] Material[] m);

		// Token: 0x060003A4 RID: 932
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x593E740", Offset = "0x593D340", VA = "0x18593E740")]
		[FreeFunction(Name = "RendererScripting::SetPropertyBlock", HasExplicitThis = true)]
		[MethodImpl(4096)]
		internal extern void Internal_SetPropertyBlock(MaterialPropertyBlock properties);

		// Token: 0x060003A5 RID: 933
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x593E4B0", Offset = "0x593D0B0", VA = "0x18593E4B0")]
		[FreeFunction(Name = "RendererScripting::GetPropertyBlock", HasExplicitThis = true)]
		[MethodImpl(4096)]
		internal extern void Internal_GetPropertyBlock([NotNull("ArgumentNullException")] MaterialPropertyBlock dest);

		// Token: 0x060003A6 RID: 934
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x593E6E0", Offset = "0x593D2E0", VA = "0x18593E6E0")]
		[FreeFunction(Name = "RendererScripting::SetPropertyBlockMaterialIndex", HasExplicitThis = true)]
		[MethodImpl(4096)]
		internal extern void Internal_SetPropertyBlockMaterialIndex(MaterialPropertyBlock properties, int materialIndex);

		// Token: 0x060003A7 RID: 935
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x593E450", Offset = "0x593D050", VA = "0x18593E450")]
		[FreeFunction(Name = "RendererScripting::GetPropertyBlockMaterialIndex", HasExplicitThis = true)]
		[MethodImpl(4096)]
		internal extern void Internal_GetPropertyBlockMaterialIndex([NotNull("ArgumentNullException")] MaterialPropertyBlock dest, int materialIndex);

		// Token: 0x060003A8 RID: 936
		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x593E6A0", Offset = "0x593D2A0", VA = "0x18593E6A0")]
		[FreeFunction(Name = "RendererScripting::HasPropertyBlock", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern bool HasPropertyBlock();

		// Token: 0x060003A9 RID: 937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x593E740", Offset = "0x593D340", VA = "0x18593E740")]
		public void SetPropertyBlock(MaterialPropertyBlock properties)
		{
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x593E6E0", Offset = "0x593D2E0", VA = "0x18593E6E0")]
		public void SetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x593E4B0", Offset = "0x593D0B0", VA = "0x18593E4B0")]
		public void GetPropertyBlock(MaterialPropertyBlock properties)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x593E450", Offset = "0x593D050", VA = "0x18593E450")]
		public void GetPropertyBlock(MaterialPropertyBlock properties, int materialIndex)
		{
		}

		// Token: 0x060003AD RID: 941
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x593E0F0", Offset = "0x593CCF0", VA = "0x18593E0F0")]
		[FreeFunction(Name = "RendererScripting::GetClosestReflectionProbes", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void GetClosestReflectionProbesInternal(object result);

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003AE RID: 942
		// (set) Token: 0x060003AF RID: 943
		[Token(Token = "0x170000DA")]
		public extern bool enabled { [Token(Token = "0x60003AE")] [Address(RVA = "0x593EC30", Offset = "0x593D830", VA = "0x18593EC30")] [MethodImpl(4096)] get; [Token(Token = "0x60003AF")] [Address(RVA = "0x593F680", Offset = "0x593E280", VA = "0x18593F680")] [MethodImpl(4096)] set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003B0 RID: 944
		[Token(Token = "0x170000DB")]
		public extern bool isVisible { [Token(Token = "0x60003B0")] [Address(RVA = "0x593ECF0", Offset = "0x593D8F0", VA = "0x18593ECF0")] [NativeName("IsVisibleInScene")] [MethodImpl(4096)] get; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003B1 RID: 945
		// (set) Token: 0x060003B2 RID: 946
		[Token(Token = "0x170000DC")]
		public extern ShadowCastingMode shadowCastingMode { [Token(Token = "0x60003B1")] [Address(RVA = "0x593F250", Offset = "0x593DE50", VA = "0x18593F250")] [MethodImpl(4096)] get; [Token(Token = "0x60003B2")] [Address(RVA = "0x593FBB0", Offset = "0x593E7B0", VA = "0x18593FBB0")] [MethodImpl(4096)] set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003B3 RID: 947
		// (set) Token: 0x060003B4 RID: 948
		[Token(Token = "0x170000DD")]
		public extern bool receiveShadows { [Token(Token = "0x60003B3")] [Address(RVA = "0x593F150", Offset = "0x593DD50", VA = "0x18593F150")] [MethodImpl(4096)] get; [Token(Token = "0x60003B4")] [Address(RVA = "0x593FAA0", Offset = "0x593E6A0", VA = "0x18593FAA0")] [MethodImpl(4096)] set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003B5 RID: 949
		// (set) Token: 0x060003B6 RID: 950
		[Token(Token = "0x170000DE")]
		public extern bool forceRenderingOff { [Token(Token = "0x60003B5")] [Address(RVA = "0x593EC70", Offset = "0x593D870", VA = "0x18593EC70")] [MethodImpl(4096)] get; [Token(Token = "0x60003B6")] [Address(RVA = "0x593F6D0", Offset = "0x593E2D0", VA = "0x18593F6D0")] [MethodImpl(4096)] set; }

		// Token: 0x060003B7 RID: 951
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x593E140", Offset = "0x593CD40", VA = "0x18593E140")]
		[NativeName("GetIsStaticShadowCaster")]
		[MethodImpl(4096)]
		private extern bool GetIsStaticShadowCaster();

		// Token: 0x060003B8 RID: 952
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x593E810", Offset = "0x593D410", VA = "0x18593E810")]
		[NativeName("SetIsStaticShadowCaster")]
		[MethodImpl(4096)]
		private extern void SetIsStaticShadowCaster(bool value);

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x000030F0 File Offset: 0x000012F0
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000DF")]
		public bool staticShadowCaster
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x593E140", Offset = "0x593CD40", VA = "0x18593E140")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x593E810", Offset = "0x593D410", VA = "0x18593E810")]
			set
			{
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003BB RID: 955
		// (set) Token: 0x060003BC RID: 956
		[Token(Token = "0x170000E0")]
		public extern MotionVectorGenerationMode motionVectorGenerationMode { [Token(Token = "0x60003BB")] [Address(RVA = "0x593EFB0", Offset = "0x593DBB0", VA = "0x18593EFB0")] [MethodImpl(4096)] get; [Token(Token = "0x60003BC")] [Address(RVA = "0x593F8E0", Offset = "0x593E4E0", VA = "0x18593F8E0")] [MethodImpl(4096)] set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003BD RID: 957
		// (set) Token: 0x060003BE RID: 958
		[Token(Token = "0x170000E1")]
		public extern LightProbeUsage lightProbeUsage { [Token(Token = "0x60003BD")] [Address(RVA = "0x593ED70", Offset = "0x593D970", VA = "0x18593ED70")] [MethodImpl(4096)] get; [Token(Token = "0x60003BE")] [Address(RVA = "0x593F770", Offset = "0x593E370", VA = "0x18593F770")] [MethodImpl(4096)] set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003BF RID: 959
		// (set) Token: 0x060003C0 RID: 960
		[Token(Token = "0x170000E2")]
		public extern ReflectionProbeUsage reflectionProbeUsage { [Token(Token = "0x60003BF")] [Address(RVA = "0x593F190", Offset = "0x593DD90", VA = "0x18593F190")] [MethodImpl(4096)] get; [Token(Token = "0x60003C0")] [Address(RVA = "0x593FAF0", Offset = "0x593E6F0", VA = "0x18593FAF0")] [MethodImpl(4096)] set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060003C1 RID: 961
		// (set) Token: 0x060003C2 RID: 962
		[Token(Token = "0x170000E3")]
		public extern uint renderingLayerMask { [Token(Token = "0x60003C1")] [Address(RVA = "0x593F210", Offset = "0x593DE10", VA = "0x18593F210")] [MethodImpl(4096)] get; [Token(Token = "0x60003C2")] [Address(RVA = "0x593FB70", Offset = "0x593E770", VA = "0x18593FB70")] [MethodImpl(4096)] set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060003C3 RID: 963
		// (set) Token: 0x060003C4 RID: 964
		[Token(Token = "0x170000E4")]
		public extern int rendererPriority { [Token(Token = "0x60003C3")] [Address(RVA = "0x593F1D0", Offset = "0x593DDD0", VA = "0x18593F1D0")] [MethodImpl(4096)] get; [Token(Token = "0x60003C4")] [Address(RVA = "0x593FB30", Offset = "0x593E730", VA = "0x18593FB30")] [MethodImpl(4096)] set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003C5 RID: 965
		// (set) Token: 0x060003C6 RID: 966
		[Token(Token = "0x170000E5")]
		public extern RayTracingMode rayTracingMode { [Token(Token = "0x60003C5")] [Address(RVA = "0x593F070", Offset = "0x593DC70", VA = "0x18593F070")] [MethodImpl(4096)] get; [Token(Token = "0x60003C6")] [Address(RVA = "0x593F9C0", Offset = "0x593E5C0", VA = "0x18593F9C0")] [MethodImpl(4096)] set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003C7 RID: 967
		// (set) Token: 0x060003C8 RID: 968
		[Token(Token = "0x170000E6")]
		public extern string sortingLayerName { [Token(Token = "0x60003C7")] [Address(RVA = "0x593F350", Offset = "0x593DF50", VA = "0x18593F350")] [MethodImpl(4096)] get; [Token(Token = "0x60003C8")] [Address(RVA = "0x593FCB0", Offset = "0x593E8B0", VA = "0x18593FCB0")] [MethodImpl(4096)] set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003C9 RID: 969
		// (set) Token: 0x060003CA RID: 970
		[Token(Token = "0x170000E7")]
		public extern int sortingLayerID { [Token(Token = "0x60003C9")] [Address(RVA = "0x593F310", Offset = "0x593DF10", VA = "0x18593F310")] [MethodImpl(4096)] get; [Token(Token = "0x60003CA")] [Address(RVA = "0x593FC70", Offset = "0x593E870", VA = "0x18593FC70")] [MethodImpl(4096)] set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003CB RID: 971
		// (set) Token: 0x060003CC RID: 972
		[Token(Token = "0x170000E8")]
		public extern int sortingOrder { [Token(Token = "0x60003CB")] [Address(RVA = "0x593F390", Offset = "0x593DF90", VA = "0x18593F390")] [MethodImpl(4096)] get; [Token(Token = "0x60003CC")] [Address(RVA = "0x593FD00", Offset = "0x593E900", VA = "0x18593FD00")] [MethodImpl(4096)] set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003CD RID: 973
		// (set) Token: 0x060003CE RID: 974
		[Token(Token = "0x170000E9")]
		internal extern int sortingGroupID { [Token(Token = "0x60003CD")] [Address(RVA = "0x593F290", Offset = "0x593DE90", VA = "0x18593F290")] [MethodImpl(4096)] get; [Token(Token = "0x60003CE")] [Address(RVA = "0x593FBF0", Offset = "0x593E7F0", VA = "0x18593FBF0")] [MethodImpl(4096)] set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003CF RID: 975
		// (set) Token: 0x060003D0 RID: 976
		[Token(Token = "0x170000EA")]
		internal extern int sortingGroupOrder { [Token(Token = "0x60003CF")] [Address(RVA = "0x593F2D0", Offset = "0x593DED0", VA = "0x18593F2D0")] [MethodImpl(4096)] get; [Token(Token = "0x60003D0")] [Address(RVA = "0x593FC30", Offset = "0x593E830", VA = "0x18593FC30")] [MethodImpl(4096)] set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003D1 RID: 977
		// (set) Token: 0x060003D2 RID: 978
		[Token(Token = "0x170000EB")]
		[NativeProperty("IsDynamicOccludee")]
		public extern bool allowOcclusionWhenDynamic { [Token(Token = "0x60003D1")] [Address(RVA = "0x593EB00", Offset = "0x593D700", VA = "0x18593EB00")] [MethodImpl(4096)] get; [Token(Token = "0x60003D2")] [Address(RVA = "0x593F540", Offset = "0x593E140", VA = "0x18593F540")] [MethodImpl(4096)] set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003D3 RID: 979
		// (set) Token: 0x060003D4 RID: 980
		[Token(Token = "0x170000EC")]
		[NativeProperty("StaticBatchRoot")]
		internal extern Transform staticBatchRootTransform { [Token(Token = "0x60003D3")] [Address(RVA = "0x593F410", Offset = "0x593E010", VA = "0x18593F410")] [MethodImpl(4096)] get; [Token(Token = "0x60003D4")] [Address(RVA = "0x593FD40", Offset = "0x593E940", VA = "0x18593FD40")] [MethodImpl(4096)] set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003D5 RID: 981
		[Token(Token = "0x170000ED")]
		internal extern int staticBatchIndex { [Token(Token = "0x60003D5")] [Address(RVA = "0x593F3D0", Offset = "0x593DFD0", VA = "0x18593F3D0")] [MethodImpl(4096)] get; }

		// Token: 0x060003D6 RID: 982
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x593EA10", Offset = "0x593D610", VA = "0x18593EA10")]
		[MethodImpl(4096)]
		internal extern void SetStaticBatchInfo(int firstSubMesh, int subMeshCount);

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003D7 RID: 983
		[Token(Token = "0x170000EE")]
		public extern bool isPartOfStaticBatch { [Token(Token = "0x60003D7")] [Address(RVA = "0x593ECB0", Offset = "0x593D8B0", VA = "0x18593ECB0")] [NativeName("IsPartOfStaticBatch")] [MethodImpl(4096)] get; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00003108 File Offset: 0x00001308
		[Token(Token = "0x170000EF")]
		public Matrix4x4 worldToLocalMatrix
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x593F4E0", Offset = "0x593E0E0", VA = "0x18593F4E0")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00003120 File Offset: 0x00001320
		[Token(Token = "0x170000F0")]
		public Matrix4x4 localToWorldMatrix
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x593EF50", Offset = "0x593DB50", VA = "0x18593EF50")]
			get
			{
				return default(Matrix4x4);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003DA RID: 986
		// (set) Token: 0x060003DB RID: 987
		[Token(Token = "0x170000F1")]
		public extern GameObject lightProbeProxyVolumeOverride { [Token(Token = "0x60003DA")] [Address(RVA = "0x593ED30", Offset = "0x593D930", VA = "0x18593ED30")] [MethodImpl(4096)] get; [Token(Token = "0x60003DB")] [Address(RVA = "0x593F720", Offset = "0x593E320", VA = "0x18593F720")] [MethodImpl(4096)] set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003DC RID: 988
		// (set) Token: 0x060003DD RID: 989
		[Token(Token = "0x170000F2")]
		public extern Transform probeAnchor { [Token(Token = "0x60003DC")] [Address(RVA = "0x593F030", Offset = "0x593DC30", VA = "0x18593F030")] [MethodImpl(4096)] get; [Token(Token = "0x60003DD")] [Address(RVA = "0x593F970", Offset = "0x593E570", VA = "0x18593F970")] [MethodImpl(4096)] set; }

		// Token: 0x060003DE RID: 990
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x593E180", Offset = "0x593CD80", VA = "0x18593E180")]
		[NativeName("GetLightmapIndexInt")]
		[MethodImpl(4096)]
		private extern int GetLightmapIndex(LightmapType lt);

		// Token: 0x060003DF RID: 991
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x593E860", Offset = "0x593D460", VA = "0x18593E860")]
		[NativeName("SetLightmapIndexInt")]
		[MethodImpl(4096)]
		private extern void SetLightmapIndex(int index, LightmapType lt);

		// Token: 0x060003E0 RID: 992 RVA: 0x00003138 File Offset: 0x00001338
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x593E210", Offset = "0x593CE10", VA = "0x18593E210")]
		[NativeName("GetLightmapST")]
		private Vector4 GetLightmapST(LightmapType lt)
		{
			return default(Vector4);
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x593E910", Offset = "0x593D510", VA = "0x18593E910")]
		[NativeName("SetLightmapST")]
		private void SetLightmapST(Vector4 st, LightmapType lt)
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x00003150 File Offset: 0x00001350
		// (set) Token: 0x060003E3 RID: 995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F3")]
		public int lightmapIndex
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x593EDB0", Offset = "0x593D9B0", VA = "0x18593EDB0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x593F7B0", Offset = "0x593E3B0", VA = "0x18593F7B0")]
			set
			{
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003E4 RID: 996 RVA: 0x00003168 File Offset: 0x00001368
		// (set) Token: 0x060003E5 RID: 997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F4")]
		public int realtimeLightmapIndex
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x593F0B0", Offset = "0x593DCB0", VA = "0x18593F0B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x593FA00", Offset = "0x593E600", VA = "0x18593FA00")]
			set
			{
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003E6 RID: 998 RVA: 0x00003180 File Offset: 0x00001380
		// (set) Token: 0x060003E7 RID: 999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F5")]
		public Vector4 lightmapScaleOffset
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x593EDF0", Offset = "0x593D9F0", VA = "0x18593EDF0")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x593F800", Offset = "0x593E400", VA = "0x18593F800")]
			set
			{
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00003198 File Offset: 0x00001398
		// (set) Token: 0x060003E9 RID: 1001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F6")]
		public Vector4 realtimeLightmapScaleOffset
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x593F0F0", Offset = "0x593DCF0", VA = "0x18593F0F0")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x593FA50", Offset = "0x593E650", VA = "0x18593FA50")]
			set
			{
			}
		}

		// Token: 0x060003EA RID: 1002
		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x593E2B0", Offset = "0x593CEB0", VA = "0x18593E2B0")]
		[MethodImpl(4096)]
		private extern int GetMaterialCount();

		// Token: 0x060003EB RID: 1003
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x593E500", Offset = "0x593D100", VA = "0x18593E500")]
		[NativeName("GetMaterialArray")]
		[MethodImpl(4096)]
		private extern Material[] GetSharedMaterialArray();

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F7")]
		public Material[] materials
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x593E270", Offset = "0x593CE70", VA = "0x18593E270")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x593E970", Offset = "0x593D570", VA = "0x18593E970")]
			set
			{
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F8")]
		public Material material
		{
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x593E2F0", Offset = "0x593CEF0", VA = "0x18593E2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x593E9C0", Offset = "0x593D5C0", VA = "0x18593E9C0")]
			set
			{
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000F9")]
		public Material sharedMaterial
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x593E540", Offset = "0x593D140", VA = "0x18593E540")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x593E9C0", Offset = "0x593D5C0", VA = "0x18593E9C0")]
			set
			{
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FA")]
		public Material[] sharedMaterials
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x593E500", Offset = "0x593D100", VA = "0x18593E500")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x593E970", Offset = "0x593D570", VA = "0x18593E970")]
			set
			{
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x593E330", Offset = "0x593CF30", VA = "0x18593E330")]
		public void GetMaterials(List<Material> m)
		{
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x593E580", Offset = "0x593D180", VA = "0x18593E580")]
		public void GetSharedMaterials(List<Material> m)
		{
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x593E0F0", Offset = "0x593CCF0", VA = "0x18593E0F0")]
		public void GetClosestReflectionProbes(List<ReflectionProbeBlendInfo> result)
		{
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public Renderer()
		{
		}

		// Token: 0x060003F8 RID: 1016
		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x593EB40", Offset = "0x593D740", VA = "0x18593EB40")]
		[MethodImpl(4096)]
		private extern void get_bounds_Injected(out Bounds ret);

		// Token: 0x060003F9 RID: 1017
		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x593F590", Offset = "0x593E190", VA = "0x18593F590")]
		[MethodImpl(4096)]
		private extern void set_bounds_Injected(ref Bounds value);

		// Token: 0x060003FA RID: 1018
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x593EE50", Offset = "0x593DA50", VA = "0x18593EE50")]
		[MethodImpl(4096)]
		private extern void get_localBounds_Injected(out Bounds ret);

		// Token: 0x060003FB RID: 1019
		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x593F840", Offset = "0x593E440", VA = "0x18593F840")]
		[MethodImpl(4096)]
		private extern void set_localBounds_Injected(ref Bounds value);

		// Token: 0x060003FC RID: 1020
		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x593EA60", Offset = "0x593D660", VA = "0x18593EA60")]
		[MethodImpl(4096)]
		private extern void SetStaticLightmapST_Injected(ref Vector4 st);

		// Token: 0x060003FD RID: 1021
		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x593F490", Offset = "0x593E090", VA = "0x18593F490")]
		[MethodImpl(4096)]
		private extern void get_worldToLocalMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x060003FE RID: 1022
		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x593EF00", Offset = "0x593DB00", VA = "0x18593EF00")]
		[MethodImpl(4096)]
		private extern void get_localToWorldMatrix_Injected(out Matrix4x4 ret);

		// Token: 0x060003FF RID: 1023
		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x593E1C0", Offset = "0x593CDC0", VA = "0x18593E1C0")]
		[MethodImpl(4096)]
		private extern void GetLightmapST_Injected(LightmapType lt, out Vector4 ret);

		// Token: 0x06000400 RID: 1024
		[Token(Token = "0x6000400")]
		[Address(RVA = "0x593E8B0", Offset = "0x593D4B0", VA = "0x18593E8B0")]
		[MethodImpl(4096)]
		private extern void SetLightmapST_Injected(ref Vector4 st, LightmapType lt);
	}
}
