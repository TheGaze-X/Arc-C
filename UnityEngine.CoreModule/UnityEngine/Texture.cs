using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BB RID: 187
	[Token(Token = "0x20000BB")]
	[NativeHeader("Runtime/Streaming/TextureStreamingManager.h")]
	[NativeHeader("Runtime/Graphics/Texture.h")]
	[UsedByNativeCode]
	public class Texture : Object
	{
		// Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x59461D0", Offset = "0x5944DD0", VA = "0x1859461D0")]
		protected Texture()
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x17000150")]
		public virtual GraphicsFormat graphicsFormat
		{
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x59462E0", Offset = "0x5944EE0", VA = "0x1859462E0", Slot = "4")]
			get
			{
				return GraphicsFormat.None;
			}
		}

		// Token: 0x06000583 RID: 1411
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x5945CD0", Offset = "0x59448D0", VA = "0x185945CD0")]
		[MethodImpl(4096)]
		private extern int GetDataWidth();

		// Token: 0x06000584 RID: 1412
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x5945C90", Offset = "0x5944890", VA = "0x185945C90")]
		[MethodImpl(4096)]
		private extern int GetDataHeight();

		// Token: 0x06000585 RID: 1413
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x5945D10", Offset = "0x5944910", VA = "0x185945D10")]
		[MethodImpl(4096)]
		private extern TextureDimension GetDimension();

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x00003540 File Offset: 0x00001740
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000151")]
		public virtual int width
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x5945CD0", Offset = "0x59448D0", VA = "0x185945CD0", Slot = "5")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x5946680", Offset = "0x5945280", VA = "0x185946680", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00003558 File Offset: 0x00001758
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000152")]
		public virtual int height
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x5945C90", Offset = "0x5944890", VA = "0x185945C90", Slot = "7")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x59465E0", Offset = "0x59451E0", VA = "0x1859465E0", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x00003570 File Offset: 0x00001770
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000153")]
		public virtual TextureDimension dimension
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x5945D10", Offset = "0x5944910", VA = "0x185945D10", Slot = "9")]
			get
			{
				return TextureDimension.None;
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x5946550", Offset = "0x5945150", VA = "0x185946550", Slot = "10")]
			set
			{
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600058C RID: 1420
		[Token(Token = "0x17000154")]
		public virtual extern bool isReadable { [Token(Token = "0x600058C")] [Address(RVA = "0x5946330", Offset = "0x5944F30", VA = "0x185946330", Slot = "11")] [MethodImpl(4096)] get; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600058D RID: 1421
		// (set) Token: 0x0600058E RID: 1422
		[Token(Token = "0x17000155")]
		public extern TextureWrapMode wrapMode { [Token(Token = "0x600058D")] [Address(RVA = "0x59464D0", Offset = "0x59450D0", VA = "0x1859464D0")] [NativeName("GetWrapModeU")] [MethodImpl(4096)] get; [Token(Token = "0x600058E")] [Address(RVA = "0x5946790", Offset = "0x5945390", VA = "0x185946790")] [MethodImpl(4096)] set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600058F RID: 1423
		// (set) Token: 0x06000590 RID: 1424
		[Token(Token = "0x17000156")]
		public extern TextureWrapMode wrapModeU { [Token(Token = "0x600058F")] [Address(RVA = "0x5946410", Offset = "0x5945010", VA = "0x185946410")] [MethodImpl(4096)] get; [Token(Token = "0x6000590")] [Address(RVA = "0x59466D0", Offset = "0x59452D0", VA = "0x1859466D0")] [MethodImpl(4096)] set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000591 RID: 1425
		// (set) Token: 0x06000592 RID: 1426
		[Token(Token = "0x17000157")]
		public extern TextureWrapMode wrapModeV { [Token(Token = "0x6000591")] [Address(RVA = "0x5946450", Offset = "0x5945050", VA = "0x185946450")] [MethodImpl(4096)] get; [Token(Token = "0x6000592")] [Address(RVA = "0x5946710", Offset = "0x5945310", VA = "0x185946710")] [MethodImpl(4096)] set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000593 RID: 1427
		// (set) Token: 0x06000594 RID: 1428
		[Token(Token = "0x17000158")]
		public extern TextureWrapMode wrapModeW { [Token(Token = "0x6000593")] [Address(RVA = "0x5946490", Offset = "0x5945090", VA = "0x185946490")] [MethodImpl(4096)] get; [Token(Token = "0x6000594")] [Address(RVA = "0x5946750", Offset = "0x5945350", VA = "0x185946750")] [MethodImpl(4096)] set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000595 RID: 1429
		// (set) Token: 0x06000596 RID: 1430
		[Token(Token = "0x17000159")]
		public extern FilterMode filterMode { [Token(Token = "0x6000595")] [Address(RVA = "0x59462A0", Offset = "0x5944EA0", VA = "0x1859462A0")] [MethodImpl(4096)] get; [Token(Token = "0x6000596")] [Address(RVA = "0x59465A0", Offset = "0x59451A0", VA = "0x1859465A0")] [MethodImpl(4096)] set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000597 RID: 1431
		// (set) Token: 0x06000598 RID: 1432
		[Token(Token = "0x1700015A")]
		public extern int anisoLevel { [Token(Token = "0x6000597")] [Address(RVA = "0x5946260", Offset = "0x5944E60", VA = "0x185946260")] [MethodImpl(4096)] get; [Token(Token = "0x6000598")] [Address(RVA = "0x5946510", Offset = "0x5945110", VA = "0x185946510")] [MethodImpl(4096)] set; }

		// Token: 0x1700015B RID: 347
		// (set) Token: 0x06000599 RID: 1433
		[Token(Token = "0x1700015B")]
		public extern float mipMapBias { [Token(Token = "0x6000599")] [Address(RVA = "0x5946630", Offset = "0x5945230", VA = "0x185946630")] [MethodImpl(4096)] set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00003588 File Offset: 0x00001788
		[Token(Token = "0x1700015C")]
		public Vector2 texelSize
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x59463C0", Offset = "0x5944FC0", VA = "0x1859463C0")]
			[NativeName("GetTexelSize")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600059B RID: 1435
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x5945D50", Offset = "0x5944950", VA = "0x185945D50")]
		[MethodImpl(4096)]
		public extern IntPtr GetNativeTexturePtr();

		// Token: 0x0600059C RID: 1436
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x5945E00", Offset = "0x5944A00", VA = "0x185945E00")]
		[NativeMethod("GetActiveTextureColorSpace")]
		[MethodImpl(4096)]
		private extern int Internal_GetActiveTextureColorSpace();

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600059D RID: 1437 RVA: 0x000035A0 File Offset: 0x000017A0
		[Token(Token = "0x1700015D")]
		internal ColorSpace activeTextureColorSpace
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x5946220", Offset = "0x5944E20", VA = "0x185946220")]
			[VisibleToOtherModules(new string[]
			{
				"UnityEngine.UIElementsModule",
				"Unity.UIElements"
			})]
			get
			{
				return ColorSpace.Gamma;
			}
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x000035B8 File Offset: 0x000017B8
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x5945DF0", Offset = "0x59449F0", VA = "0x185945DF0")]
		internal TextureColorSpace GetTextureColorSpace(bool linear)
		{
			return TextureColorSpace.Linear;
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x000035D0 File Offset: 0x000017D0
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x5945D90", Offset = "0x5944990", VA = "0x185945D90")]
		internal TextureColorSpace GetTextureColorSpace(GraphicsFormat format)
		{
			return TextureColorSpace.Linear;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x000035E8 File Offset: 0x000017E8
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x5945FF0", Offset = "0x5944BF0", VA = "0x185945FF0")]
		internal bool ValidateFormat(TextureFormat format)
		{
			return default(bool);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00003600 File Offset: 0x00001800
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x5945E40", Offset = "0x5944A40", VA = "0x185945E40")]
		internal bool ValidateFormat(GraphicsFormat format, FormatUsage usage)
		{
			return default(bool);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x5945C00", Offset = "0x5944800", VA = "0x185945C00")]
		internal UnityException CreateNonReadableException(Texture t)
		{
			return null;
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x5945B90", Offset = "0x5944790", VA = "0x185945B90")]
		internal UnityException CreateNativeArrayLengthOverflowException()
		{
			return null;
		}

		// Token: 0x060005A5 RID: 1445
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x5946370", Offset = "0x5944F70", VA = "0x185946370")]
		[MethodImpl(4096)]
		private extern void get_texelSize_Injected(out Vector2 ret);

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int GenerateAllMips;
	}
}
