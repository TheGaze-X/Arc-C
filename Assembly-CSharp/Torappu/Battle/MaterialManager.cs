using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002663 RID: 9827
	[Token(Token = "0x2002663")]
	public class MaterialManager : SingletonMonoBehaviour<MaterialManager>
	{
		// Token: 0x0601011E RID: 65822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601011E")]
		[Address(RVA = "0x7CCC40", Offset = "0x7CB840", VA = "0x1807CCC40")]
		public Material GetMaterial(Material source, string instanceKey)
		{
			return null;
		}

		// Token: 0x0601011F RID: 65823 RVA: 0x000621F0 File Offset: 0x000603F0
		[Token(Token = "0x601011F")]
		[Address(RVA = "0x7CD3A0", Offset = "0x7CBFA0", VA = "0x1807CD3A0")]
		public bool TryGetMaterialOrNewFromShader(Shader shader, MaterialManager.MaterialKey key, out Material result)
		{
			return default(bool);
		}

		// Token: 0x06010120 RID: 65824 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010120")]
		[Address(RVA = "0x7CD1D0", Offset = "0x7CBDD0", VA = "0x1807CD1D0")]
		public Tween StartExclusiveTween(Func<Material, Tween> factory, Material source, string instanceKey)
		{
			return null;
		}

		// Token: 0x06010121 RID: 65825 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010121")]
		[Address(RVA = "0x7CD070", Offset = "0x7CBC70", VA = "0x1807CD070")]
		public Tween StartExclusiveTween(Func<Material, Tween> factory, Material material)
		{
			return null;
		}

		// Token: 0x06010122 RID: 65826 RVA: 0x00062208 File Offset: 0x00060408
		[Token(Token = "0x6010122")]
		[Address(RVA = "0x7CC9E0", Offset = "0x7CB5E0", VA = "0x1807CC9E0")]
		public bool FinishExclusiveTween(Material source, string instanceKey)
		{
			return default(bool);
		}

		// Token: 0x06010123 RID: 65827 RVA: 0x00062220 File Offset: 0x00060420
		[Token(Token = "0x6010123")]
		[Address(RVA = "0x7CCB50", Offset = "0x7CB750", VA = "0x1807CCB50")]
		public bool FinishExclusiveTween(Material material)
		{
			return default(bool);
		}

		// Token: 0x06010124 RID: 65828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010124")]
		[Address(RVA = "0x7CCDE0", Offset = "0x7CB9E0", VA = "0x1807CCDE0", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06010125 RID: 65829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010125")]
		[Address(RVA = "0x7CD510", Offset = "0x7CC110", VA = "0x1807CD510")]
		public MaterialManager()
		{
		}

		// Token: 0x04011E00 RID: 73216
		[Token(Token = "0x4011E00")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<MaterialManager.MaterialKey, Material> m_materialMap;

		// Token: 0x04011E01 RID: 73217
		[Token(Token = "0x4011E01")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<Material, Tween> m_tweenMap;

		// Token: 0x04011E02 RID: 73218
		[Token(Token = "0x4011E02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMaterial;

		// Token: 0x04011E03 RID: 73219
		[Token(Token = "0x4011E03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryGetMaterialOrNewFromShader;

		// Token: 0x04011E04 RID: 73220
		[Token(Token = "0x4011E04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StartExclusiveTween;

		// Token: 0x04011E05 RID: 73221
		[Token(Token = "0x4011E05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix1_StartExclusiveTween;

		// Token: 0x04011E06 RID: 73222
		[Token(Token = "0x4011E06")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FinishExclusiveTween;

		// Token: 0x04011E07 RID: 73223
		[Token(Token = "0x4011E07")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_FinishExclusiveTween;

		// Token: 0x04011E08 RID: 73224
		[Token(Token = "0x4011E08")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04011E09 RID: 73225
		[Token(Token = "0x4011E09")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002664 RID: 9828
		[Token(Token = "0x2002664")]
		public struct MaterialKey
		{
			// Token: 0x06010126 RID: 65830 RVA: 0x00062238 File Offset: 0x00060438
			[Token(Token = "0x6010126")]
			[Address(RVA = "0x7CC9A0", Offset = "0x7CB5A0", VA = "0x1807CC9A0")]
			public static MaterialManager.MaterialKey Of(Material prototype, string instanceKey)
			{
				return default(MaterialManager.MaterialKey);
			}

			// Token: 0x04011E0A RID: 73226
			[Token(Token = "0x4011E0A")]
			[FieldOffset(Offset = "0x0")]
			public Material prototype;

			// Token: 0x04011E0B RID: 73227
			[Token(Token = "0x4011E0B")]
			[FieldOffset(Offset = "0x8")]
			public string instanceKey;
		}
	}
}
