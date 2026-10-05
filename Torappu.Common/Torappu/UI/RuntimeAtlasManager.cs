using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HG.Rendering.Runtime;
using Hypergryph.ToolKits;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Rendering;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	public class RuntimeAtlasManager : SingletonMonoBehaviour<RuntimeAtlasManager>
	{
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x00007004 File Offset: 0x00005204
		[Token(Token = "0x170000D1")]
		public static bool releaseImageSpriteAfterInsert
		{
			[Token(Token = "0x6000896")]
			[Address(RVA = "0x55348E0", Offset = "0x55334E0", VA = "0x1855348E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x55325E0", Offset = "0x55311E0", VA = "0x1855325E0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000898")]
		[Address(RVA = "0x5532540", Offset = "0x5531140", VA = "0x185532540")]
		public static void NotifyConfigReady()
		{
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000899")]
		[Address(RVA = "0x5533080", Offset = "0x5531C80", VA = "0x185533080")]
		private void _InitImpl()
		{
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0000701C File Offset: 0x0000521C
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x5532FF0", Offset = "0x5531BF0", VA = "0x185532FF0")]
		private static bool _EnableRuntimeAtlasByDefault()
		{
			return default(bool);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600089B RID: 2203 RVA: 0x00007034 File Offset: 0x00005234
		[Token(Token = "0x170000D2")]
		public static bool enableRuntimeAtlas
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0x5534780", Offset = "0x5533380", VA = "0x185534780")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x0000704C File Offset: 0x0000524C
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000D3")]
		public static bool enableRuntimeAtlasFromScript
		{
			[Token(Token = "0x600089C")]
			[Address(RVA = "0x55346F0", Offset = "0x55332F0", VA = "0x1855346F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600089D")]
			[Address(RVA = "0x5534950", Offset = "0x5533550", VA = "0x185534950")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600089E RID: 2206 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600089E")]
		[Address(RVA = "0x5532280", Offset = "0x5530E80", VA = "0x185532280")]
		public static void AddUIImageToManager(Image image)
		{
		}

		// Token: 0x0600089F RID: 2207 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600089F")]
		[Address(RVA = "0x5532710", Offset = "0x5531310", VA = "0x185532710")]
		public static void ReProcessInsertForUIImage(Image image)
		{
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x5532970", Offset = "0x5531570", VA = "0x185532970")]
		public static void RemoveUIImageFromManager(Image image)
		{
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x55321B0", Offset = "0x5530DB0", VA = "0x1855321B0")]
		public static void AddUIImageToManagerOnInstantiate(Image image)
		{
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x5532470", Offset = "0x5531070", VA = "0x185532470")]
		protected void LateUpdate()
		{
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x5532EC0", Offset = "0x5531AC0", VA = "0x185532EC0")]
		private void _AddUIImageToManager(Image image)
		{
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x5534250", Offset = "0x5532E50", VA = "0x185534250")]
		private void _ReProcessInsertForUIImage(Image image)
		{
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x5534400", Offset = "0x5533000", VA = "0x185534400")]
		private void _RemoveUIImageFromManager(Image image)
		{
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x5532BE0", Offset = "0x55317E0", VA = "0x185532BE0")]
		private void _AddUIImageToManagerOnInstantiate(Image image)
		{
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x00007064 File Offset: 0x00005264
		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x5533480", Offset = "0x5532080", VA = "0x185533480")]
		private bool _IsRuntimeAtlasCompatible(Image image, out RuntimeAtlas.ProcessFailureCause failureCause)
		{
			return default(bool);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0000707C File Offset: 0x0000527C
		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x55333C0", Offset = "0x5531FC0", VA = "0x1855333C0")]
		private static bool _IsAtlasRectValid(in RectInt rect)
		{
			return default(bool);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x55336F0", Offset = "0x55322F0", VA = "0x1855336F0")]
		private void _ProcessInsertQueue()
		{
		}

		// Token: 0x060008AA RID: 2218 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x5533EF0", Offset = "0x5532AF0", VA = "0x185533EF0")]
		private void _ProcessRemoveQueue()
		{
		}

		// Token: 0x060008AB RID: 2219 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x5534660", Offset = "0x5533260", VA = "0x185534660")]
		public RuntimeAtlasManager()
		{
		}

		// Token: 0x040007BF RID: 1983
		[Token(Token = "0x40007BF")]
		public const int ATLAS_PAGE_WIDTH = 2048;

		// Token: 0x040007C0 RID: 1984
		[Token(Token = "0x40007C0")]
		public const int ATLAS_PAGE_HEIGHT = 1024;

		// Token: 0x040007C1 RID: 1985
		[Token(Token = "0x40007C1")]
		public const int IMAGE_USING_ATLAS_MAX_SIZE = 1024;

		// Token: 0x040007C2 RID: 1986
		[Token(Token = "0x40007C2")]
		public const int PANEL_LEVEL_COUNT = 4;

		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		public const int MAX_ATLAS_PER_PANEL_LEVEL = 4;

		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		public const int PROCESS_COUNT_PER_FRAME = 3;

		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		public const GraphicsFormat ATLAS_PAGE_FORMAT = GraphicsFormat.RGBA_BC7_UNorm;

		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _enableRuntimeAtlas;

		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, Image> m_imageDict;

		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		[FieldOffset(Offset = "0x28")]
		private RuntimeAtlasManager.AtlasSheet[,] m_atlasSheetPool;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0x30")]
		private Queue<Image> m_insertQueue;

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0x38")]
		private Queue<RuntimeAtlas.AtlasHandle> m_freeQueue;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0x40")]
		private CommandBuffer m_commandBuffer;

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0x48")]
		private GraphicsFormat m_atlasSheetFormat;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0x0")]
		private static LatchUtils.InvokeWhenUnlock s_initLock;

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate8 __Hotfix0_get_releaseImageSpriteAfterInsert;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate1 __Hotfix0_OnInit;

		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate14 __Hotfix0_NotifyConfigReady;

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0__InitImpl;

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate8 __Hotfix0__EnableRuntimeAtlasByDefault;

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate8 __Hotfix0_get_enableRuntimeAtlas;

		// Token: 0x040007D5 RID: 2005
		[Token(Token = "0x40007D5")]
		[FieldOffset(Offset = "0x40")]
		private static __XLua_Gen_Delegate8 __Hotfix0_get_enableRuntimeAtlasFromScript;

		// Token: 0x040007D6 RID: 2006
		[Token(Token = "0x40007D6")]
		[FieldOffset(Offset = "0x48")]
		private static __XLua_Gen_Delegate86 __Hotfix0_set_enableRuntimeAtlasFromScript;

		// Token: 0x040007D7 RID: 2007
		[Token(Token = "0x40007D7")]
		[FieldOffset(Offset = "0x50")]
		private static __XLua_Gen_Delegate1 __Hotfix0_AddUIImageToManager;

		// Token: 0x040007D8 RID: 2008
		[Token(Token = "0x40007D8")]
		[FieldOffset(Offset = "0x58")]
		private static __XLua_Gen_Delegate1 __Hotfix0_ReProcessInsertForUIImage;

		// Token: 0x040007D9 RID: 2009
		[Token(Token = "0x40007D9")]
		[FieldOffset(Offset = "0x60")]
		private static __XLua_Gen_Delegate1 __Hotfix0_RemoveUIImageFromManager;

		// Token: 0x040007DA RID: 2010
		[Token(Token = "0x40007DA")]
		[FieldOffset(Offset = "0x68")]
		private static __XLua_Gen_Delegate1 __Hotfix0_AddUIImageToManagerOnInstantiate;

		// Token: 0x040007DB RID: 2011
		[Token(Token = "0x40007DB")]
		[FieldOffset(Offset = "0x70")]
		private static __XLua_Gen_Delegate1 __Hotfix0_LateUpdate;

		// Token: 0x040007DC RID: 2012
		[Token(Token = "0x40007DC")]
		[FieldOffset(Offset = "0x78")]
		private static __XLua_Gen_Delegate0 __Hotfix0__AddUIImageToManager;

		// Token: 0x040007DD RID: 2013
		[Token(Token = "0x40007DD")]
		[FieldOffset(Offset = "0x80")]
		private static __XLua_Gen_Delegate0 __Hotfix0__ReProcessInsertForUIImage;

		// Token: 0x040007DE RID: 2014
		[Token(Token = "0x40007DE")]
		[FieldOffset(Offset = "0x88")]
		private static __XLua_Gen_Delegate0 __Hotfix0__RemoveUIImageFromManager;

		// Token: 0x040007DF RID: 2015
		[Token(Token = "0x40007DF")]
		[FieldOffset(Offset = "0x90")]
		private static __XLua_Gen_Delegate0 __Hotfix0__AddUIImageToManagerOnInstantiate;

		// Token: 0x040007E0 RID: 2016
		[Token(Token = "0x40007E0")]
		[FieldOffset(Offset = "0x98")]
		private static __XLua_Gen_Delegate169 __Hotfix0__IsRuntimeAtlasCompatible;

		// Token: 0x040007E1 RID: 2017
		[Token(Token = "0x40007E1")]
		[FieldOffset(Offset = "0xA0")]
		private static __XLua_Gen_Delegate170 __Hotfix0__IsAtlasRectValid;

		// Token: 0x040007E2 RID: 2018
		[Token(Token = "0x40007E2")]
		[FieldOffset(Offset = "0xA8")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ProcessInsertQueue;

		// Token: 0x040007E3 RID: 2019
		[Token(Token = "0x40007E3")]
		[FieldOffset(Offset = "0xB0")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ProcessRemoveQueue;

		// Token: 0x040007E4 RID: 2020
		[Token(Token = "0x40007E4")]
		[FieldOffset(Offset = "0xB8")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;

		// Token: 0x02000168 RID: 360
		[Token(Token = "0x2000168")]
		public class TextureRefHandle
		{
			// Token: 0x060008AD RID: 2221 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x5535D90", Offset = "0x5534990", VA = "0x185535D90")]
			private static void _PoolOnly_Reset(RuntimeAtlasManager.TextureRefHandle inst)
			{
			}

			// Token: 0x060008AE RID: 2222 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x5535C70", Offset = "0x5534870", VA = "0x185535C70")]
			public static RuntimeAtlasManager.TextureRefHandle Alloc(int refCount, in RectInt rect)
			{
				return null;
			}

			// Token: 0x060008AF RID: 2223 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x5535D10", Offset = "0x5534910", VA = "0x185535D10")]
			public static void Release(RuntimeAtlasManager.TextureRefHandle inst)
			{
			}

			// Token: 0x060008B0 RID: 2224 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TextureRefHandle()
			{
			}

			// Token: 0x040007E5 RID: 2021
			[Token(Token = "0x40007E5")]
			[FieldOffset(Offset = "0x0")]
			private static readonly LocalGenericPool<RuntimeAtlasManager.TextureRefHandle> s_textureRefHandlePool;

			// Token: 0x040007E6 RID: 2022
			[Token(Token = "0x40007E6")]
			[FieldOffset(Offset = "0x10")]
			public int refCount;

			// Token: 0x040007E7 RID: 2023
			[Token(Token = "0x40007E7")]
			[FieldOffset(Offset = "0x14")]
			public RectInt rect;
		}

		// Token: 0x02000169 RID: 361
		[Token(Token = "0x2000169")]
		public class AtlasSheet : IHotfixable
		{
			// Token: 0x170000D4 RID: 212
			// (get) Token: 0x060008B2 RID: 2226 RVA: 0x00007094 File Offset: 0x00005294
			[Token(Token = "0x170000D4")]
			public int maxFreeRectWidth
			{
				[Token(Token = "0x60008B2")]
				[Address(RVA = "0x552EAB0", Offset = "0x552D6B0", VA = "0x18552EAB0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000D5 RID: 213
			// (get) Token: 0x060008B3 RID: 2227 RVA: 0x000070AC File Offset: 0x000052AC
			[Token(Token = "0x170000D5")]
			public int maxFreeRectHeight
			{
				[Token(Token = "0x60008B3")]
				[Address(RVA = "0x552EA00", Offset = "0x552D600", VA = "0x18552EA00")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170000D6 RID: 214
			// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000D6")]
			public Texture2D pageTexture
			{
				[Token(Token = "0x60008B4")]
				[Address(RVA = "0x552EB60", Offset = "0x552D760", VA = "0x18552EB60")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170000D7 RID: 215
			// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000D7")]
			public Dictionary<int, RuntimeAtlasManager.TextureRefHandle> textureRefDict
			{
				[Token(Token = "0x60008B5")]
				[Address(RVA = "0x552EC20", Offset = "0x552D820", VA = "0x18552EC20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170000D8 RID: 216
			// (get) Token: 0x060008B6 RID: 2230 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x170000D8")]
			public AtlasMaxRect rectBinPack
			{
				[Token(Token = "0x60008B6")]
				[Address(RVA = "0x552EBC0", Offset = "0x552D7C0", VA = "0x18552EBC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x060008B7 RID: 2231 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x552E7A0", Offset = "0x552D3A0", VA = "0x18552E7A0")]
			public AtlasSheet(int panelDepth, int index, GraphicsFormat atlasFormat)
			{
			}

			// Token: 0x060008B8 RID: 2232 RVA: 0x000070C4 File Offset: 0x000052C4
			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x552E470", Offset = "0x552D070", VA = "0x18552E470")]
			public RectInt InsertRect(int width, int height)
			{
				return default(RectInt);
			}

			// Token: 0x060008B9 RID: 2233 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x552E010", Offset = "0x552CC10", VA = "0x18552E010")]
			public void CopyIntoAtlas(CommandBuffer cmd, Texture texture, in RectInt rect)
			{
			}

			// Token: 0x060008BA RID: 2234 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x552E6A0", Offset = "0x552D2A0", VA = "0x18552E6A0")]
			public void InsertRects(List<RectInt> rects, List<RectInt> dst)
			{
			}

			// Token: 0x060008BB RID: 2235 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x552E2C0", Offset = "0x552CEC0", VA = "0x18552E2C0")]
			public void FreeRect(in RectInt rect)
			{
			}

			// Token: 0x060008BC RID: 2236 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x552E3A0", Offset = "0x552CFA0", VA = "0x18552E3A0")]
			public void FreeRects(in List<RectInt> rects)
			{
			}

			// Token: 0x040007EB RID: 2027
			[Token(Token = "0x40007EB")]
			[FieldOffset(Offset = "0x0")]
			private static __XLua_Gen_Delegate25 __Hotfix0_get_maxFreeRectWidth;

			// Token: 0x040007EC RID: 2028
			[Token(Token = "0x40007EC")]
			[FieldOffset(Offset = "0x8")]
			private static __XLua_Gen_Delegate25 __Hotfix0_get_maxFreeRectHeight;

			// Token: 0x040007ED RID: 2029
			[Token(Token = "0x40007ED")]
			[FieldOffset(Offset = "0x10")]
			private static __XLua_Gen_Delegate161 __Hotfix0_get_pageTexture;

			// Token: 0x040007EE RID: 2030
			[Token(Token = "0x40007EE")]
			[FieldOffset(Offset = "0x18")]
			private static __XLua_Gen_Delegate162 __Hotfix0_get_textureRefDict;

			// Token: 0x040007EF RID: 2031
			[Token(Token = "0x40007EF")]
			[FieldOffset(Offset = "0x20")]
			private static __XLua_Gen_Delegate163 __Hotfix0_get_rectBinPack;

			// Token: 0x040007F0 RID: 2032
			[Token(Token = "0x40007F0")]
			[FieldOffset(Offset = "0x28")]
			private static __XLua_Gen_Delegate164 _c__Hotfix0_ctor;

			// Token: 0x040007F1 RID: 2033
			[Token(Token = "0x40007F1")]
			[FieldOffset(Offset = "0x30")]
			private static __XLua_Gen_Delegate165 __Hotfix0_InsertRect;

			// Token: 0x040007F2 RID: 2034
			[Token(Token = "0x40007F2")]
			[FieldOffset(Offset = "0x38")]
			private static __XLua_Gen_Delegate166 __Hotfix0_CopyIntoAtlas;

			// Token: 0x040007F3 RID: 2035
			[Token(Token = "0x40007F3")]
			[FieldOffset(Offset = "0x40")]
			private static __XLua_Gen_Delegate5 __Hotfix0_InsertRects;

			// Token: 0x040007F4 RID: 2036
			[Token(Token = "0x40007F4")]
			[FieldOffset(Offset = "0x48")]
			private static __XLua_Gen_Delegate167 __Hotfix0_FreeRect;

			// Token: 0x040007F5 RID: 2037
			[Token(Token = "0x40007F5")]
			[FieldOffset(Offset = "0x50")]
			private static __XLua_Gen_Delegate168 __Hotfix0_FreeRects;
		}
	}
}
