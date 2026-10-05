using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare.CriMana.Detail
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	public abstract class RendererResourceFactory : IDisposable
	{
		// Token: 0x060009E1 RID: 2529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E1")]
		[Address(RVA = "0x371B2E0", Offset = "0x3719EE0", VA = "0x18371B2E0")]
		public static void RegisterFactory(RendererResourceFactory factory, int priority)
		{
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E2")]
		[Address(RVA = "0x371AE40", Offset = "0x3719A40", VA = "0x18371AE40")]
		public static void DisposeAllFactories()
		{
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x60009E3")]
		[Address(RVA = "0x371ABF0", Offset = "0x37197F0", VA = "0x18371ABF0")]
		public static RendererResource DispatchAndCreate(int playerId, MovieInfo movieInfo, bool additive, Shader userShader)
		{
			return null;
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E4")]
		[Address(RVA = "0x371B250", Offset = "0x3719E50", VA = "0x18371B250", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E5")]
		[Address(RVA = "0x371B1B0", Offset = "0x3719DB0", VA = "0x18371B1B0", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E6")]
		[Address(RVA = "0x371B140", Offset = "0x3719D40", VA = "0x18371B140")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x060009E7 RID: 2535
		[Token(Token = "0x60009E7")]
		protected abstract void OnDisposeManaged();

		// Token: 0x060009E8 RID: 2536
		[Token(Token = "0x60009E8")]
		protected abstract void OnDisposeUnmanaged();

		// Token: 0x060009E9 RID: 2537
		[Token(Token = "0x60009E9")]
		public abstract RendererResource CreateRendererResource(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);

		// Token: 0x060009EA RID: 2538 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected RendererResourceFactory()
		{
		}

		// Token: 0x04000609 RID: 1545
		[Token(Token = "0x4000609")]
		[FieldOffset(Offset = "0x0")]
		private static SortedList<int, RendererResourceFactory> factoryList;

		// Token: 0x0400060A RID: 1546
		[Token(Token = "0x400060A")]
		[FieldOffset(Offset = "0x10")]
		private bool disposed;
	}
}
