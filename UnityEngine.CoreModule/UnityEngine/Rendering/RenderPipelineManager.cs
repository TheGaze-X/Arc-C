using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x02000276 RID: 630
	[Token(Token = "0x2000276")]
	public static class RenderPipelineManager
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000E2A RID: 3626 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000E2B RID: 3627 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002CC")]
		public static RenderPipeline currentPipeline
		{
			[Token(Token = "0x6000E2A")]
			[Address(RVA = "0x5986000", Offset = "0x5984C00", VA = "0x185986000")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E2B")]
			[Address(RVA = "0x5986050", Offset = "0x5984C50", VA = "0x185986050")]
			private set
			{
			}
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x5985C20", Offset = "0x5984820", VA = "0x185985C20")]
		[RequiredByNativeCode]
		internal static void OnActiveRenderPipelineTypeChanged()
		{
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0x5985A10", Offset = "0x5984610", VA = "0x185985A10")]
		[RequiredByNativeCode]
		internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset)
		{
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x5985190", Offset = "0x5983D90", VA = "0x185985190")]
		[RequiredByNativeCode]
		internal static void CleanupRenderPipeline()
		{
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x59859C0", Offset = "0x59845C0", VA = "0x1859859C0")]
		[RequiredByNativeCode]
		private static string GetCurrentPipelineAssetType()
		{
			return null;
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x59854F0", Offset = "0x59840F0", VA = "0x1859854F0")]
		[RequiredByNativeCode]
		private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, List<Camera.RenderRequest> renderRequests)
		{
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x5985C90", Offset = "0x5984890", VA = "0x185985C90")]
		internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
		{
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00006F90 File Offset: 0x00005190
		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x5985AB0", Offset = "0x59846B0", VA = "0x185985AB0")]
		private static bool IsPipelineRequireCreation()
		{
			return default(bool);
		}

		// Token: 0x04000788 RID: 1928
		[Token(Token = "0x4000788")]
		[FieldOffset(Offset = "0x0")]
		internal static RenderPipelineAsset s_CurrentPipelineAsset;

		// Token: 0x04000789 RID: 1929
		[Token(Token = "0x4000789")]
		[FieldOffset(Offset = "0x8")]
		private static List<Camera> s_Cameras;

		// Token: 0x0400078A RID: 1930
		[Token(Token = "0x400078A")]
		[FieldOffset(Offset = "0x10")]
		private static string s_currentPipelineType;

		// Token: 0x0400078B RID: 1931
		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x18")]
		private static RenderPipeline s_currentPipeline;

		// Token: 0x0400078C RID: 1932
		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x20")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action activeRenderPipelineTypeChanged;

		// Token: 0x0400078D RID: 1933
		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action activeRenderPipelineCreated;

		// Token: 0x0400078E RID: 1934
		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x30")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action activeRenderPipelineDisposed;
	}
}
