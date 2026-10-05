using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Scripting;

namespace CriWare.CriMana.Detail
{
	// Token: 0x02000141 RID: 321
	[Token(Token = "0x2000141")]
	public static class AutoResisterRendererResourceFactories
	{
		// Token: 0x060009B0 RID: 2480 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x3708E50", Offset = "0x3707A50", VA = "0x183708E50")]
		public static void InvokeAutoRegister()
		{
		}

		// Token: 0x02000142 RID: 322
		[Token(Token = "0x2000142")]
		[RendererResourceFactoryPriority(7050)]
		[Preserve]
		public class RendererResourceFactoryH264Yuv : RendererResourceFactory
		{
			// Token: 0x060009B1 RID: 2481 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x371A9F0", Offset = "0x37195F0", VA = "0x18371A9F0", Slot = "7")]
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
			{
				return null;
			}

			// Token: 0x060009B2 RID: 2482 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			protected override void OnDisposeManaged()
			{
			}

			// Token: 0x060009B3 RID: 2483 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
			protected override void OnDisposeUnmanaged()
			{
			}

			// Token: 0x060009B4 RID: 2484 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x371AA90", Offset = "0x3719690", VA = "0x18371AA90")]
			public RendererResourceFactoryH264Yuv()
			{
			}
		}

		// Token: 0x02000143 RID: 323
		[Token(Token = "0x2000143")]
		[Preserve]
		[RendererResourceFactoryPriority(10000)]
		public class RendererResourceFactorySofdecPrimeYuvRawData : RendererResourceFactory
		{
			// Token: 0x060009B5 RID: 2485 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x371AAE0", Offset = "0x37196E0", VA = "0x18371AAE0", Slot = "7")]
			public override RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
			{
				return null;
			}

			// Token: 0x060009B6 RID: 2486 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
			protected override void OnDisposeManaged()
			{
			}

			// Token: 0x060009B7 RID: 2487 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
			protected override void OnDisposeUnmanaged()
			{
			}

			// Token: 0x060009B8 RID: 2488 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x371ABA0", Offset = "0x37197A0", VA = "0x18371ABA0")]
			public RendererResourceFactorySofdecPrimeYuvRawData()
			{
			}
		}
	}
}
