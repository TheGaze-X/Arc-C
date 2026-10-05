using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BC RID: 188
	[Token(Token = "0x20000BC")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/Texture2D.h")]
	[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
	public sealed class Texture2D : Texture
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060005A6 RID: 1446
		[Token(Token = "0x1700015E")]
		public extern TextureFormat format { [Token(Token = "0x60005A6")] [Address(RVA = "0x5944A60", Offset = "0x5943660", VA = "0x185944A60")] [NativeName("GetTextureFormat")] [MethodImpl(4096)] get; }

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060005A7 RID: 1447
		[Token(Token = "0x1700015F")]
		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static extern Texture2D whiteTexture { [Token(Token = "0x60005A7")] [Address(RVA = "0x5944AE0", Offset = "0x59436E0", VA = "0x185944AE0")] [MethodImpl(4096)] get; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060005A8 RID: 1448
		[Token(Token = "0x17000160")]
		[StaticAccessor("builtintex", StaticAccessorType.DoubleColon)]
		public static extern Texture2D blackTexture { [Token(Token = "0x60005A8")] [Address(RVA = "0x5944A30", Offset = "0x5943630", VA = "0x185944A30")] [MethodImpl(4096)] get; }

		// Token: 0x060005A9 RID: 1449
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x5943130", Offset = "0x5941D30", VA = "0x185943130")]
		[FreeFunction("Texture2DScripting::Create")]
		[MethodImpl(4096)]
		private static extern bool Internal_CreateImpl([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex);

		// Token: 0x060005AA RID: 1450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x5943190", Offset = "0x5941D90", VA = "0x185943190")]
		private static void Internal_Create([Writable] Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex)
		{
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060005AB RID: 1451
		[Token(Token = "0x17000161")]
		public override extern bool isReadable { [Token(Token = "0x60005AB")] [Address(RVA = "0x5944AA0", Offset = "0x59436A0", VA = "0x185944AA0", Slot = "11")] [MethodImpl(4096)] get; }

		// Token: 0x060005AC RID: 1452
		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x5942700", Offset = "0x5941300", VA = "0x185942700")]
		[NativeName("Apply")]
		[MethodImpl(4096)]
		private extern void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable);

		// Token: 0x060005AD RID: 1453
		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x59437B0", Offset = "0x59423B0", VA = "0x1859437B0")]
		[NativeName("Reinitialize")]
		[MethodImpl(4096)]
		private extern bool ReinitializeImpl(int width, int height);

		// Token: 0x060005AE RID: 1454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x5943AD0", Offset = "0x59426D0", VA = "0x185943AD0")]
		[NativeName("SetPixel")]
		private void SetPixelImpl(int image, int mip, int x, int y, Color color)
		{
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00003618 File Offset: 0x00001818
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x5942C00", Offset = "0x5941800", VA = "0x185942C00")]
		[NativeName("GetPixel")]
		private Color GetPixelImpl(int image, int mip, int x, int y)
		{
			return default(Color);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x5942A40", Offset = "0x5941640", VA = "0x185942A40")]
		[NativeName("GetPixelBilinear")]
		private Color GetPixelBilinearImpl(int image, int mip, float u, float v)
		{
			return default(Color);
		}

		// Token: 0x060005B1 RID: 1457
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x5943800", Offset = "0x5942400", VA = "0x185943800")]
		[FreeFunction(Name = "Texture2DScripting::ReinitializeWithFormat", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern bool ReinitializeWithFormatImpl(int width, int height, GraphicsFormat format, bool hasMipMap);

		// Token: 0x060005B2 RID: 1458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x59435A0", Offset = "0x59421A0", VA = "0x1859435A0")]
		[FreeFunction(Name = "Texture2DScripting::ReadPixels", HasExplicitThis = true)]
		private void ReadPixelsImpl(Rect source, int destX, int destY, bool recalculateMipMaps)
		{
		}

		// Token: 0x060005B3 RID: 1459
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x5943C70", Offset = "0x5942870", VA = "0x185943C70")]
		[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame);

		// Token: 0x060005B4 RID: 1460
		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x5943270", Offset = "0x5941E70", VA = "0x185943270")]
		[FreeFunction(Name = "Texture2DScripting::LoadRawData", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern bool LoadRawTextureDataImpl(IntPtr data, ulong size);

		// Token: 0x060005B5 RID: 1461
		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x59430F0", Offset = "0x5941CF0", VA = "0x1859430F0")]
		[MethodImpl(4096)]
		private extern IntPtr GetWritableImageData(int frame);

		// Token: 0x060005B6 RID: 1462
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x5943070", Offset = "0x5941C70", VA = "0x185943070")]
		[MethodImpl(4096)]
		private extern ulong GetRawImageDataSize();

		// Token: 0x060005B7 RID: 1463
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x5943F10", Offset = "0x5942B10", VA = "0x185943F10")]
		[FreeFunction("Texture2DScripting::UpdateExternalTexture", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void UpdateExternalTexture(IntPtr nativeTex);

		// Token: 0x060005B8 RID: 1464
		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x5943A10", Offset = "0x5942610", VA = "0x185943A10")]
		[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		private extern void SetAllPixels32([Unmarshalled] Color32[] colors, int miplevel);

		// Token: 0x060005B9 RID: 1465
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x59430B0", Offset = "0x5941CB0", VA = "0x1859430B0")]
		[FreeFunction("Texture2DScripting::GetRawTextureData", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern byte[] GetRawTextureData();

		// Token: 0x060005BA RID: 1466
		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x5943010", Offset = "0x5941C10", VA = "0x185943010")]
		[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, [DefaultValue("0")] int miplevel);

		// Token: 0x060005BB RID: 1467 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x5942DE0", Offset = "0x59419E0", VA = "0x185942DE0")]
		[ExcludeFromDocs]
		public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight)
		{
			return null;
		}

		// Token: 0x060005BC RID: 1468
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x5942D60", Offset = "0x5941960", VA = "0x185942D60")]
		[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = true, ThrowsException = true)]
		[MethodImpl(4096)]
		public extern Color32[] GetPixels32([DefaultValue("0")] int miplevel);

		// Token: 0x060005BD RID: 1469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x5942DA0", Offset = "0x59419A0", VA = "0x185942DA0")]
		[ExcludeFromDocs]
		public Color32[] GetPixels32()
		{
			return null;
		}

		// Token: 0x060005BE RID: 1470
		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x59434C0", Offset = "0x59420C0", VA = "0x1859434C0")]
		[FreeFunction("Texture2DScripting::PackTextures", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable);

		// Token: 0x060005BF RID: 1471 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x5943450", Offset = "0x5942050", VA = "0x185943450")]
		public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize)
		{
			return null;
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00003648 File Offset: 0x00001848
		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x59440A0", Offset = "0x5942CA0", VA = "0x1859440A0")]
		internal bool ValidateFormat(TextureFormat format, int width, int height)
		{
			return default(bool);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x5943F60", Offset = "0x5942B60", VA = "0x185943F60")]
		internal bool ValidateFormat(GraphicsFormat format, int width, int height)
		{
			return default(bool);
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x5944190", Offset = "0x5942D90", VA = "0x185944190")]
		internal Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags, int mipCount, IntPtr nativeTex)
		{
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x5944820", Offset = "0x5943420", VA = "0x185944820")]
		[ExcludeFromDocs]
		public Texture2D(int width, int height, DefaultFormat format, TextureCreationFlags flags)
		{
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x5944620", Offset = "0x5943220", VA = "0x185944620")]
		[ExcludeFromDocs]
		public Texture2D(int width, int height, GraphicsFormat format, TextureCreationFlags flags)
		{
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x59443D0", Offset = "0x5942FD0", VA = "0x1859443D0")]
		internal Texture2D(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex)
		{
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x5944790", Offset = "0x5943390", VA = "0x185944790")]
		public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("-1")] int mipCount, [DefaultValue("false")] bool linear)
		{
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x59448F0", Offset = "0x59434F0", VA = "0x1859448F0")]
		public Texture2D(int width, int height, [DefaultValue("TextureFormat.RGBA32")] TextureFormat textureFormat, [DefaultValue("true")] bool mipChain, [DefaultValue("false")] bool linear)
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x5944990", Offset = "0x5943590", VA = "0x185944990")]
		[ExcludeFromDocs]
		public Texture2D(int width, int height, TextureFormat textureFormat, bool mipChain)
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x59446E0", Offset = "0x59432E0", VA = "0x1859446E0")]
		[ExcludeFromDocs]
		public Texture2D(int width, int height)
		{
		}

		// Token: 0x060005CA RID: 1482 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x59428A0", Offset = "0x59414A0", VA = "0x1859428A0")]
		public static Texture2D CreateExternalTexture(int width, int height, TextureFormat format, bool mipChain, bool linear, IntPtr nativeTex)
		{
			return null;
		}

		// Token: 0x060005CB RID: 1483 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x5943B50", Offset = "0x5942750", VA = "0x185943B50")]
		[ExcludeFromDocs]
		public void SetPixel(int x, int y, Color color)
		{
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x5943CD0", Offset = "0x59428D0", VA = "0x185943CD0")]
		public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, [DefaultValue("0")] int miplevel)
		{
		}

		// Token: 0x060005CD RID: 1485 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x5943E30", Offset = "0x5942A30", VA = "0x185943E30")]
		public void SetPixels(Color[] colors, [DefaultValue("0")] int miplevel)
		{
		}

		// Token: 0x060005CE RID: 1486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x5943D90", Offset = "0x5942990", VA = "0x185943D90")]
		[ExcludeFromDocs]
		public void SetPixels(Color[] colors)
		{
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x5942C80", Offset = "0x5941880", VA = "0x185942C80")]
		[ExcludeFromDocs]
		public Color GetPixel(int x, int y)
		{
			return default(Color);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x5942AC0", Offset = "0x59416C0", VA = "0x185942AC0")]
		[ExcludeFromDocs]
		public Color GetPixelBilinear(float u, float v)
		{
			return default(Color);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x59432D0", Offset = "0x5941ED0", VA = "0x1859432D0")]
		public void LoadRawTextureData(IntPtr data, int size)
		{
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x60005D2")]
		public NativeArray<T> GetRawTextureData<T>() where T : struct
		{
			return default(NativeArray<T>);
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x5942760", Offset = "0x5941360", VA = "0x185942760")]
		public void Apply([DefaultValue("true")] bool updateMipmaps, [DefaultValue("false")] bool makeNoLongerReadable)
		{
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x5942810", Offset = "0x5941410", VA = "0x185942810")]
		[ExcludeFromDocs]
		public void Apply()
		{
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x5943870", Offset = "0x5942470", VA = "0x185943870")]
		public bool Reinitialize(int width, int height)
		{
			return default(bool);
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x000036D8 File Offset: 0x000018D8
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x5943920", Offset = "0x5942520", VA = "0x185943920")]
		public bool Reinitialize(int width, int height, TextureFormat format, bool hasMipMap)
		{
			return default(bool);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x59436E0", Offset = "0x59422E0", VA = "0x1859436E0")]
		public void ReadPixels(Rect source, int destX, int destY, [DefaultValue("true")] bool recalculateMipMaps)
		{
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x5943610", Offset = "0x5942210", VA = "0x185943610")]
		[ExcludeFromDocs]
		public void ReadPixels(Rect source, int destX, int destY)
		{
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x5943A10", Offset = "0x5942610", VA = "0x185943A10")]
		public void SetPixels32(Color32[] colors, [DefaultValue("0")] int miplevel)
		{
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x5943C20", Offset = "0x5942820", VA = "0x185943C20")]
		[ExcludeFromDocs]
		public void SetPixels32(Color32[] colors)
		{
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x5942E50", Offset = "0x5941A50", VA = "0x185942E50")]
		public Color[] GetPixels([DefaultValue("0")] int miplevel)
		{
			return null;
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x5942F40", Offset = "0x5941B40", VA = "0x185942F40")]
		[ExcludeFromDocs]
		public Color[] GetPixels()
		{
			return null;
		}

		// Token: 0x060005DD RID: 1501
		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x5943A70", Offset = "0x5942670", VA = "0x185943A70")]
		[MethodImpl(4096)]
		private extern void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color);

		// Token: 0x060005DE RID: 1502
		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x5942BA0", Offset = "0x59417A0", VA = "0x185942BA0")]
		[MethodImpl(4096)]
		private extern void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret);

		// Token: 0x060005DF RID: 1503
		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x59429E0", Offset = "0x59415E0", VA = "0x1859429E0")]
		[MethodImpl(4096)]
		private extern void GetPixelBilinearImpl_Injected(int image, int mip, float u, float v, out Color ret);

		// Token: 0x060005E0 RID: 1504
		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x5943530", Offset = "0x5942130", VA = "0x185943530")]
		[MethodImpl(4096)]
		private extern void ReadPixelsImpl_Injected(ref Rect source, int destX, int destY, bool recalculateMipMaps);

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		internal const int streamingMipmapsPriorityMin = -128;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		internal const int streamingMipmapsPriorityMax = 127;
	}
}
