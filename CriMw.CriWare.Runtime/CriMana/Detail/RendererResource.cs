using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace CriWare.CriMana.Detail
{
	// Token: 0x02000145 RID: 325
	[Token(Token = "0x2000145")]
	public abstract class RendererResource : IDisposable
	{
		// Token: 0x060009BA RID: 2490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x371D290", Offset = "0x371BE90", VA = "0x18371D290", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x371D180", Offset = "0x371BD80", VA = "0x18371D180", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x371D220", Offset = "0x371BE20", VA = "0x18371D220")]
		private void Dispose(bool disposing)
		{
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00004AFC File Offset: 0x00002CFC
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x371D370", Offset = "0x371BF70", VA = "0x18371D370")]
		public int GetNumberOfFrameBeforeDestroy(int playerId)
		{
			return 0;
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x371D440", Offset = "0x371C040", VA = "0x18371D440")]
		protected void SetupStaticMaterialProperties()
		{
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x371D320", Offset = "0x371BF20", VA = "0x18371D320")]
		private void GetBlendModes(out int srcBlendMode, out int dstBlendMode)
		{
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C0")]
		[Address(RVA = "0x371D420", Offset = "0x371C020", VA = "0x18371D420", Slot = "5")]
		public virtual void SetApplyTargetAlpha(bool flag)
		{
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x371D430", Offset = "0x371C030", VA = "0x18371D430", Slot = "6")]
		public virtual void SetUiRenderMode(bool flag)
		{
		}

		// Token: 0x060009C2 RID: 2498
		[Token(Token = "0x60009C2")]
		protected abstract void OnDisposeManaged();

		// Token: 0x060009C3 RID: 2499
		[Token(Token = "0x60009C3")]
		protected abstract void OnDisposeUnmanaged();

		// Token: 0x060009C4 RID: 2500
		[Token(Token = "0x60009C4")]
		public abstract bool IsPrepared();

		// Token: 0x060009C5 RID: 2501
		[Token(Token = "0x60009C5")]
		public abstract bool ContinuePreparing();

		// Token: 0x060009C6 RID: 2502
		[Token(Token = "0x60009C6")]
		public abstract void AttachToPlayer(int playerId);

		// Token: 0x060009C7 RID: 2503
		[Token(Token = "0x60009C7")]
		public abstract bool UpdateFrame(int playerId, FrameInfo frameInfo, ref bool frameDrop);

		// Token: 0x060009C8 RID: 2504
		[Token(Token = "0x60009C8")]
		public abstract bool UpdateMaterial(Material material);

		// Token: 0x060009C9 RID: 2505
		[Token(Token = "0x60009C9")]
		public abstract void UpdateTextures();

		// Token: 0x060009CA RID: 2506
		[Token(Token = "0x60009CA")]
		public abstract bool IsSuitable(int playerId, MovieInfo movieInfo, bool additive, Shader userShader);

		// Token: 0x060009CB RID: 2507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "16")]
		public virtual void OnPlayerPause(bool pauseStatus, bool triggredFromApplciationPause)
		{
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "17")]
		public virtual void OnPlayerStop()
		{
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00004B14 File Offset: 0x00002D14
		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "18")]
		public virtual bool OnPlayerStopForSeek()
		{
			return default(bool);
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "19")]
		public virtual void OnPlayerStart()
		{
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00004B2C File Offset: 0x00002D2C
		[Token(Token = "0x60009CF")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "20")]
		public virtual bool ShouldSkipDestroyOnStopForSeek()
		{
			return default(bool);
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00004B44 File Offset: 0x00002D44
		[Token(Token = "0x60009D0")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "21")]
		public virtual bool HasRenderedNewFrame()
		{
			return default(bool);
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00004B5C File Offset: 0x00002D5C
		[Token(Token = "0x60009D1")]
		[Address(RVA = "0x371D360", Offset = "0x371BF60", VA = "0x18371D360", Slot = "22")]
		public virtual int GetDisplayedFrameNo()
		{
			return 0;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00004B74 File Offset: 0x00002D74
		[Token(Token = "0x60009D2")]
		[Address(RVA = "0x371D3F0", Offset = "0x371BFF0", VA = "0x18371D3F0")]
		public static uint NextPowerOfTwo(uint x)
		{
			return 0U;
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00004B8C File Offset: 0x00002D8C
		[Token(Token = "0x60009D3")]
		[Address(RVA = "0x371D3F0", Offset = "0x371BFF0", VA = "0x18371D3F0")]
		public static int NextPowerOfTwo(int x)
		{
			return 0;
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[Token(Token = "0x60009D4")]
		[Address(RVA = "0x371D070", Offset = "0x371BC70", VA = "0x18371D070")]
		public static int CeilingWith(int x, int ceilingValue)
		{
			return 0;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00004BBC File Offset: 0x00002DBC
		[Token(Token = "0x60009D5")]
		[Address(RVA = "0x371D030", Offset = "0x371BC30", VA = "0x18371D030")]
		public static int Ceiling16(int x)
		{
			return 0;
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00004BD4 File Offset: 0x00002DD4
		[Token(Token = "0x60009D6")]
		[Address(RVA = "0x371D050", Offset = "0x371BC50", VA = "0x18371D050")]
		public static int Ceiling32(int x)
		{
			return 0;
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00004BEC File Offset: 0x00002DEC
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0x371D060", Offset = "0x371BC60", VA = "0x18371D060")]
		public static int Ceiling64(int x)
		{
			return 0;
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00004C04 File Offset: 0x00002E04
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0x371D040", Offset = "0x371BC40", VA = "0x18371D040")]
		public static int Ceiling256(int x)
		{
			return 0;
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0x371D080", Offset = "0x371BC80", VA = "0x18371D080")]
		protected static void DisposeTextures(Texture[] textures)
		{
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0x1687310", Offset = "0x1685F10", VA = "0x181687310")]
		protected static void SetKeyword(Material material, string keyword, bool flag)
		{
		}

		// Token: 0x060009DB RID: 2523
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0x371CCE0", Offset = "0x371B8E0", VA = "0x18371CCE0")]
		[PreserveSig]
		protected static extern bool CRIWARE09829167(int player_id, int num_textures, IntPtr[] tex_ptrs, [In] [Out] FrameInfo frame_info, ref bool frame_drop);

		// Token: 0x060009DC RID: 2524
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0x371CE70", Offset = "0x371BA70", VA = "0x18371CE70")]
		[PreserveSig]
		protected static extern bool CRIWARE913A0F8B(int player_id, int num_textures, [In] [Out] IntPtr[] tex_ptrs);

		// Token: 0x060009DD RID: 2525
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0x371CDD0", Offset = "0x371B9D0", VA = "0x18371CDD0")]
		[PreserveSig]
		protected static extern bool CRIWARE3A25993F(int player_id, int num_textures, [In] [Out] IntPtr[] tex_ptrs);

		// Token: 0x060009DE RID: 2526
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0x371CF90", Offset = "0x371BB90", VA = "0x18371CF90")]
		[PreserveSig]
		protected static extern bool CRIWAREB34EE65D(int player_id, int num_textures, [In] [Out] IntPtr[] tex_ptrs);

		// Token: 0x060009DF RID: 2527
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0x371CF10", Offset = "0x371BB10", VA = "0x18371CF10")]
		[PreserveSig]
		protected static extern sbyte CRIWAREAE5A50FA(int player_id);

		// Token: 0x060009E0 RID: 2528 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected RendererResource()
		{
		}

		// Token: 0x04000602 RID: 1538
		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool disposed;

		// Token: 0x04000603 RID: 1539
		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Shader shader;

		// Token: 0x04000604 RID: 1540
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Material currentMaterial;

		// Token: 0x04000605 RID: 1541
		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected bool hasAlpha;

		// Token: 0x04000606 RID: 1542
		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		protected bool additive;

		// Token: 0x04000607 RID: 1543
		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		protected bool applyTargetAlpha;

		// Token: 0x04000608 RID: 1544
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		protected bool ui;
	}
}
