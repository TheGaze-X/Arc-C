using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Torappu.UI.Stencil
{
	// Token: 0x02005A4D RID: 23117
	[Token(Token = "0x2005A4D")]
	public static class StencilUtils
	{
		// Token: 0x06021A60 RID: 137824 RVA: 0x000BB020 File Offset: 0x000B9220
		[Token(Token = "0x6021A60")]
		[Address(RVA = "0x1C2B3B0", Offset = "0x1C29FB0", VA = "0x181C2B3B0")]
		public static bool CheckMatIsDefaultCanvasMaterial(Material baseMat)
		{
			return default(bool);
		}

		// Token: 0x06021A61 RID: 137825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A61")]
		[Address(RVA = "0x1C2B950", Offset = "0x1C2A550", VA = "0x181C2B950")]
		public static void InitMatCheckerIfNot(UIStencilComponent host, ref IMatChecker checker)
		{
		}

		// Token: 0x06021A62 RID: 137826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A62")]
		[Address(RVA = "0x1C2B930", Offset = "0x1C2A530", VA = "0x181C2B930")]
		public static IMatChecker GetCheckerComponent(UIStencilComponent host)
		{
			return null;
		}

		// Token: 0x06021A63 RID: 137827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A63")]
		[Address(RVA = "0x1C2BA10", Offset = "0x1C2A610", VA = "0x181C2BA10")]
		public static void ReplaceMaterial(Material baseMaterial, ReplaceMatParam param, ref UIStencilMaterialWrapper outWrapper)
		{
		}

		// Token: 0x06021A64 RID: 137828 RVA: 0x000BB038 File Offset: 0x000B9238
		[Token(Token = "0x6021A64")]
		[Address(RVA = "0x1C2B5D0", Offset = "0x1C2A1D0", VA = "0x181C2B5D0")]
		public static StencilOp ConvertStencilOp(Operation opt)
		{
			return StencilOp.Keep;
		}

		// Token: 0x06021A65 RID: 137829 RVA: 0x000BB050 File Offset: 0x000B9250
		[Token(Token = "0x6021A65")]
		[Address(RVA = "0x1C2B600", Offset = "0x1C2A200", VA = "0x181C2B600")]
		public static CompareFunction ConvertStenilComp(Comparison comp)
		{
			return CompareFunction.Disabled;
		}

		// Token: 0x06021A66 RID: 137830 RVA: 0x000BB068 File Offset: 0x000B9268
		[Token(Token = "0x6021A66")]
		[Address(RVA = "0x1C2BA00", Offset = "0x1C2A600", VA = "0x181C2BA00")]
		public static bool IsStencilConfigNoUse(Comparison comp, Operation opt, StencilChannel channel)
		{
			return default(bool);
		}

		// Token: 0x06021A67 RID: 137831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A67")]
		[Address(RVA = "0x1C2B1A0", Offset = "0x1C29DA0", VA = "0x181C2B1A0")]
		public static void BindStencilNeedClean(UIStencilCleaner.INeedClean needClean, Transform transform, ref UIStencilCleaner cleaner)
		{
		}

		// Token: 0x06021A68 RID: 137832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021A68")]
		[Address(RVA = "0x1C2BBD0", Offset = "0x1C2A7D0", VA = "0x181C2BBD0")]
		public static void UnbindStencilNeedClean(UIStencilCleaner cleaner, UIStencilCleaner.INeedClean needClean)
		{
		}

		// Token: 0x06021A69 RID: 137833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021A69")]
		[Address(RVA = "0x1C2B630", Offset = "0x1C2A230", VA = "0x181C2B630")]
		public static UIStencilCleaner FindHostStencilCleaner(Transform from)
		{
			return null;
		}

		// Token: 0x06021A6A RID: 137834 RVA: 0x000BB080 File Offset: 0x000B9280
		[Token(Token = "0x6021A6A")]
		[Address(RVA = "0x1C2BC50", Offset = "0x1C2A850", VA = "0x181C2BC50")]
		private static bool _IsOverrideSortCanvas(Behaviour component)
		{
			return default(bool);
		}

		// Token: 0x0402E03D RID: 188477
		[Token(Token = "0x402E03D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly StencilUtils.EmptyMatChecker EMPTY_MAT_CHECKER;

		// Token: 0x0402E03E RID: 188478
		[Token(Token = "0x402E03E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material s_defaultMat;

		// Token: 0x0402E03F RID: 188479
		[Token(Token = "0x402E03F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material s_defaultETC1Mat;

		// Token: 0x0402E040 RID: 188480
		[Token(Token = "0x402E040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static int MASK_ALL;

		// Token: 0x02005A4E RID: 23118
		[Token(Token = "0x2005A4E")]
		private class EmptyMatChecker : IMatChecker
		{
			// Token: 0x06021A6C RID: 137836 RVA: 0x000BB098 File Offset: 0x000B9298
			[Token(Token = "0x6021A6C")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			public bool CheckMaterialExclusive(Material mat, [Optional] List<Material> whiteList)
			{
				return default(bool);
			}

			// Token: 0x06021A6D RID: 137837 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021A6D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EmptyMatChecker()
			{
			}
		}
	}
}
