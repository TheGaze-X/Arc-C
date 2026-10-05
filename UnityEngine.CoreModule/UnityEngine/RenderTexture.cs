using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	[NativeHeader("Runtime/Camera/Camera.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
	[NativeHeader("Runtime/Graphics/RenderTexture.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public class RenderTexture : Texture
	{
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000616 RID: 1558
		// (set) Token: 0x06000617 RID: 1559
		[Token(Token = "0x17000168")]
		public override extern int width { [Token(Token = "0x6000616")] [Address(RVA = "0x593DD50", Offset = "0x593C950", VA = "0x18593DD50", Slot = "5")] [MethodImpl(4096)] get; [Token(Token = "0x6000617")] [Address(RVA = "0x593E010", Offset = "0x593CC10", VA = "0x18593E010", Slot = "6")] [MethodImpl(4096)] set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000618 RID: 1560
		// (set) Token: 0x06000619 RID: 1561
		[Token(Token = "0x17000169")]
		public override extern int height { [Token(Token = "0x6000618")] [Address(RVA = "0x593DC50", Offset = "0x593C850", VA = "0x18593DC50", Slot = "7")] [MethodImpl(4096)] get; [Token(Token = "0x6000619")] [Address(RVA = "0x593DEF0", Offset = "0x593CAF0", VA = "0x18593DEF0", Slot = "8")] [MethodImpl(4096)] set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600061A RID: 1562
		// (set) Token: 0x0600061B RID: 1563
		[Token(Token = "0x1700016A")]
		public override extern TextureDimension dimension { [Token(Token = "0x600061A")] [Address(RVA = "0x593DAA0", Offset = "0x593C6A0", VA = "0x18593DAA0", Slot = "9")] [MethodImpl(4096)] get; [Token(Token = "0x600061B")] [Address(RVA = "0x593DE20", Offset = "0x593CA20", VA = "0x18593DE20", Slot = "10")] [MethodImpl(4096)] set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600061C RID: 1564
		// (set) Token: 0x0600061D RID: 1565
		[Token(Token = "0x1700016B")]
		[NativeProperty("ColorFormat")]
		public new extern GraphicsFormat graphicsFormat { [Token(Token = "0x600061C")] [Address(RVA = "0x593DC10", Offset = "0x593C810", VA = "0x18593DC10")] [MethodImpl(4096)] get; [Token(Token = "0x600061D")] [Address(RVA = "0x593DEB0", Offset = "0x593CAB0", VA = "0x18593DEB0")] [MethodImpl(4096)] set; }

		// Token: 0x1700016C RID: 364
		// (set) Token: 0x0600061E RID: 1566
		[Token(Token = "0x1700016C")]
		[NativeProperty("MipMap")]
		public extern bool useMipMap { [Token(Token = "0x600061E")] [Address(RVA = "0x593DF80", Offset = "0x593CB80", VA = "0x18593DF80")] [MethodImpl(4096)] set; }

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600061F RID: 1567
		[Token(Token = "0x1700016D")]
		[NativeProperty("SRGBReadWrite")]
		public extern bool sRGB { [Token(Token = "0x600061F")] [Address(RVA = "0x593DC90", Offset = "0x593C890", VA = "0x18593DC90")] [MethodImpl(4096)] get; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00003750 File Offset: 0x00001950
		[Token(Token = "0x1700016E")]
		public RenderTextureFormat format
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x593DB20", Offset = "0x593C720", VA = "0x18593DB20")]
			get
			{
				return RenderTextureFormat.ARGB32;
			}
		}

		// Token: 0x1700016F RID: 367
		// (set) Token: 0x06000621 RID: 1569
		[Token(Token = "0x1700016F")]
		public extern GraphicsFormat depthStencilFormat { [Token(Token = "0x6000621")] [Address(RVA = "0x593DDE0", Offset = "0x593C9E0", VA = "0x18593DDE0")] [MethodImpl(4096)] set; }

		// Token: 0x17000170 RID: 368
		// (set) Token: 0x06000622 RID: 1570
		[Token(Token = "0x17000170")]
		public extern bool autoGenerateMips { [Token(Token = "0x6000622")] [Address(RVA = "0x593DD90", Offset = "0x593C990", VA = "0x18593DD90")] [MethodImpl(4096)] set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000623 RID: 1571
		// (set) Token: 0x06000624 RID: 1572
		[Token(Token = "0x17000171")]
		public extern int volumeDepth { [Token(Token = "0x6000623")] [Address(RVA = "0x593DD10", Offset = "0x593C910", VA = "0x18593DD10")] [MethodImpl(4096)] get; [Token(Token = "0x6000624")] [Address(RVA = "0x593DFD0", Offset = "0x593CBD0", VA = "0x18593DFD0")] [MethodImpl(4096)] set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000625 RID: 1573
		// (set) Token: 0x06000626 RID: 1574
		[Token(Token = "0x17000172")]
		public extern bool enableRandomWrite { [Token(Token = "0x6000625")] [Address(RVA = "0x593DAE0", Offset = "0x593C6E0", VA = "0x18593DAE0")] [MethodImpl(4096)] get; [Token(Token = "0x6000626")] [Address(RVA = "0x593DE60", Offset = "0x593CA60", VA = "0x18593DE60")] [MethodImpl(4096)] set; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000627 RID: 1575
		// (set) Token: 0x06000628 RID: 1576
		[Token(Token = "0x17000173")]
		public extern bool useDynamicScale { [Token(Token = "0x6000627")] [Address(RVA = "0x593DCD0", Offset = "0x593C8D0", VA = "0x18593DCD0")] [MethodImpl(4096)] get; [Token(Token = "0x6000628")] [Address(RVA = "0x593DF30", Offset = "0x593CB30", VA = "0x18593DF30")] [MethodImpl(4096)] set; }

		// Token: 0x17000174 RID: 372
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000174")]
		public bool isPowerOfTwo
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x0600062A RID: 1578
		[Token(Token = "0x600062A")]
		[Address(RVA = "0x593AF40", Offset = "0x5939B40", VA = "0x18593AF40")]
		[FreeFunction("RenderTexture::GetActive")]
		[MethodImpl(4096)]
		private static extern RenderTexture GetActive();

		// Token: 0x0600062B RID: 1579
		[Token(Token = "0x600062B")]
		[Address(RVA = "0x593C330", Offset = "0x593AF30", VA = "0x18593C330")]
		[FreeFunction("RenderTextureScripting::SetActive")]
		[MethodImpl(4096)]
		private static extern void SetActive(RenderTexture rt);

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000175")]
		public static RenderTexture active
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x593AF40", Offset = "0x5939B40", VA = "0x18593AF40")]
			get
			{
				return null;
			}
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x593C330", Offset = "0x593AF30", VA = "0x18593C330")]
			set
			{
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00003768 File Offset: 0x00001968
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x593AFC0", Offset = "0x5939BC0", VA = "0x18593AFC0")]
		[FreeFunction(Name = "RenderTextureScripting::GetColorBuffer", HasExplicitThis = true)]
		private RenderBuffer GetColorBuffer()
		{
			return default(RenderBuffer);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00003780 File Offset: 0x00001980
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x593B290", Offset = "0x5939E90", VA = "0x18593B290")]
		[FreeFunction(Name = "RenderTextureScripting::GetDepthBuffer", HasExplicitThis = true)]
		private RenderBuffer GetDepthBuffer()
		{
			return default(RenderBuffer);
		}

		// Token: 0x06000630 RID: 1584
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x593C370", Offset = "0x593AF70", VA = "0x18593C370")]
		[MethodImpl(4096)]
		private extern void SetMipMapCount(int count);

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000631 RID: 1585 RVA: 0x00003798 File Offset: 0x00001998
		[Token(Token = "0x17000176")]
		public RenderBuffer colorBuffer
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x593D910", Offset = "0x593C510", VA = "0x18593D910")]
			get
			{
				return default(RenderBuffer);
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x000037B0 File Offset: 0x000019B0
		[Token(Token = "0x17000177")]
		public RenderBuffer depthBuffer
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x593D970", Offset = "0x593C570", VA = "0x18593D970")]
			get
			{
				return default(RenderBuffer);
			}
		}

		// Token: 0x06000633 RID: 1587
		[Token(Token = "0x6000633")]
		[Address(RVA = "0x593AEE0", Offset = "0x5939AE0", VA = "0x18593AEE0")]
		[MethodImpl(4096)]
		public extern void DiscardContents(bool discardColor, bool discardDepth);

		// Token: 0x06000634 RID: 1588
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x593C270", Offset = "0x593AE70", VA = "0x18593C270")]
		[Obsolete("This function has no effect.", false)]
		[MethodImpl(4096)]
		public extern void MarkRestoreExpected();

		// Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000635")]
		[Address(RVA = "0x593AEA0", Offset = "0x5939AA0", VA = "0x18593AEA0")]
		public void DiscardContents()
		{
		}

		// Token: 0x06000636 RID: 1590
		[Token(Token = "0x6000636")]
		[Address(RVA = "0x593AE60", Offset = "0x5939A60", VA = "0x18593AE60")]
		[MethodImpl(4096)]
		public extern bool Create();

		// Token: 0x06000637 RID: 1591
		[Token(Token = "0x6000637")]
		[Address(RVA = "0x593C2F0", Offset = "0x593AEF0", VA = "0x18593C2F0")]
		[MethodImpl(4096)]
		public extern void Release();

		// Token: 0x06000638 RID: 1592
		[Token(Token = "0x6000638")]
		[Address(RVA = "0x593C230", Offset = "0x593AE30", VA = "0x18593C230")]
		[MethodImpl(4096)]
		public extern bool IsCreated();

		// Token: 0x06000639 RID: 1593
		[Token(Token = "0x6000639")]
		[Address(RVA = "0x593C450", Offset = "0x593B050", VA = "0x18593C450")]
		[MethodImpl(4096)]
		internal extern void SetSRGBReadWrite(bool srgb);

		// Token: 0x0600063A RID: 1594
		[Token(Token = "0x600063A")]
		[Address(RVA = "0x593C1F0", Offset = "0x593ADF0", VA = "0x18593C1F0")]
		[FreeFunction("RenderTextureScripting::Create")]
		[MethodImpl(4096)]
		private static extern void Internal_Create([Writable] RenderTexture rt);

		// Token: 0x0600063B RID: 1595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x593C400", Offset = "0x593B000", VA = "0x18593C400")]
		[NativeName("SetRenderTextureDescFromScript")]
		private void SetRenderTextureDescriptor(RenderTextureDescriptor desc)
		{
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x000037C8 File Offset: 0x000019C8
		[Token(Token = "0x600063C")]
		[Address(RVA = "0x593B440", Offset = "0x593A040", VA = "0x18593B440")]
		[NativeName("GetRenderTextureDesc")]
		private RenderTextureDescriptor GetDescriptor()
		{
			return default(RenderTextureDescriptor);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x593B5E0", Offset = "0x593A1E0", VA = "0x18593B5E0")]
		[FreeFunction("GetRenderBufferManager().GetTextures().GetTempBuffer")]
		private static RenderTexture GetTemporary_Internal(RenderTextureDescriptor desc)
		{
			return null;
		}

		// Token: 0x0600063E RID: 1598
		[Token(Token = "0x600063E")]
		[Address(RVA = "0x593C2B0", Offset = "0x593AEB0", VA = "0x18593C2B0")]
		[FreeFunction("GetRenderBufferManager().GetTextures().ReleaseTempBuffer")]
		[MethodImpl(4096)]
		public static extern void ReleaseTemporary(RenderTexture temp);

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600063F RID: 1599
		[Token(Token = "0x17000178")]
		public extern int depth { [Token(Token = "0x600063F")] [Address(RVA = "0x593D9D0", Offset = "0x593C5D0", VA = "0x18593D9D0")] [FreeFunction("RenderTextureScripting::GetDepth", HasExplicitThis = true)] [MethodImpl(4096)] get; }

		// Token: 0x06000640 RID: 1600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000640")]
		[Address(RVA = "0x593D4E0", Offset = "0x593C0E0", VA = "0x18593D4E0")]
		[RequiredByNativeCode]
		protected internal RenderTexture()
		{
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000641")]
		[Address(RVA = "0x593CD50", Offset = "0x593B950", VA = "0x18593CD50")]
		public RenderTexture(RenderTextureDescriptor desc)
		{
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000642")]
		[Address(RVA = "0x593D6D0", Offset = "0x593C2D0", VA = "0x18593D6D0")]
		public RenderTexture(RenderTexture textureToCopy)
		{
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000643")]
		[Address(RVA = "0x593D3E0", Offset = "0x593BFE0", VA = "0x18593D3E0")]
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, DefaultFormat format)
		{
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000644")]
		[Address(RVA = "0x593CA80", Offset = "0x593B680", VA = "0x18593CA80")]
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, GraphicsFormat format)
		{
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x593D0C0", Offset = "0x593BCC0", VA = "0x18593D0C0")]
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, GraphicsFormat format, int mipCount)
		{
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000646")]
		[Address(RVA = "0x593CB20", Offset = "0x593B720", VA = "0x18593CB20")]
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
		{
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000647")]
		[Address(RVA = "0x593D630", Offset = "0x593C230", VA = "0x18593D630")]
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
		{
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000648")]
		[Address(RVA = "0x593D300", Offset = "0x593BF00", VA = "0x18593D300")]
		public RenderTexture(int width, int height, int depth, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite)
		{
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000649")]
		[Address(RVA = "0x593CFA0", Offset = "0x593BBA0", VA = "0x18593CFA0")]
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format)
		{
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x593CE80", Offset = "0x593BA80", VA = "0x18593CE80")]
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth)
		{
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064B")]
		[Address(RVA = "0x593D560", Offset = "0x593C160", VA = "0x18593D560")]
		[ExcludeFromDocs]
		public RenderTexture(int width, int height, int depth, RenderTextureFormat format, int mipCount)
		{
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600064C")]
		[Address(RVA = "0x593C020", Offset = "0x593AC20", VA = "0x18593C020")]
		private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount)
		{
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000037E0 File Offset: 0x000019E0
		[Token(Token = "0x600064D")]
		[Address(RVA = "0x593B370", Offset = "0x5939F70", VA = "0x18593B370")]
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x000037F8 File Offset: 0x000019F8
		[Token(Token = "0x600064E")]
		[Address(RVA = "0x593B360", Offset = "0x5939F60", VA = "0x18593B360")]
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x0600064F RID: 1615 RVA: 0x00003810 File Offset: 0x00001A10
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x593B360", Offset = "0x5939F60", VA = "0x18593B360")]
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x00003828 File Offset: 0x00001A28
		[Token(Token = "0x6000650")]
		[Address(RVA = "0x593B2E0", Offset = "0x5939EE0", VA = "0x18593B2E0")]
		internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x00003840 File Offset: 0x00001A40
		[Token(Token = "0x17000179")]
		public RenderTextureDescriptor descriptor
		{
			[Token(Token = "0x6000651")]
			[Address(RVA = "0x593DA10", Offset = "0x593C610", VA = "0x18593DA10")]
			get
			{
				return default(RenderTextureDescriptor);
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000652")]
		[Address(RVA = "0x593C4A0", Offset = "0x593B0A0", VA = "0x18593C4A0")]
		private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc)
		{
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00003858 File Offset: 0x00001A58
		[Token(Token = "0x6000653")]
		[Address(RVA = "0x593B1E0", Offset = "0x5939DE0", VA = "0x18593B1E0")]
		internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00003870 File Offset: 0x00001A70
		[Token(Token = "0x6000654")]
		[Address(RVA = "0x593B210", Offset = "0x5939E10", VA = "0x18593B210")]
		internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00003888 File Offset: 0x00001A88
		[Token(Token = "0x6000655")]
		[Address(RVA = "0x593B010", Offset = "0x5939C10", VA = "0x18593B010")]
		internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite)
		{
			return GraphicsFormat.None;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x593BD20", Offset = "0x593A920", VA = "0x18593BD20")]
		public static RenderTexture GetTemporary(RenderTextureDescriptor desc)
		{
			return null;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x593B4A0", Offset = "0x593A0A0", VA = "0x18593B4A0")]
		private static RenderTexture GetTemporaryImpl(int width, int height, GraphicsFormat depthStencilFormat, GraphicsFormat colorFormat, int antiAliasing = 1, RenderTextureMemoryless memorylessMode = RenderTextureMemoryless.None, VRTextureUsage vrUsage = VRTextureUsage.None, bool useDynamicScale = false)
		{
			return null;
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000658")]
		[Address(RVA = "0x593BEE0", Offset = "0x593AAE0", VA = "0x18593BEE0")]
		public static RenderTexture GetTemporary(int width, int height, [DefaultValue("0")] int depthBuffer, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat format, [DefaultValue("RenderTextureReadWrite.Default")] RenderTextureReadWrite readWrite, [DefaultValue("1")] int antiAliasing, [DefaultValue("RenderTextureMemoryless.None")] RenderTextureMemoryless memorylessMode, [DefaultValue("VRTextureUsage.None")] VRTextureUsage vrUsage, [DefaultValue("false")] bool useDynamicScale)
		{
			return null;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000659")]
		[Address(RVA = "0x593B990", Offset = "0x593A590", VA = "0x18593B990")]
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode, VRTextureUsage vrUsage)
		{
			return null;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600065A")]
		[Address(RVA = "0x593B740", Offset = "0x593A340", VA = "0x18593B740")]
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing, RenderTextureMemoryless memorylessMode)
		{
			return null;
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600065B")]
		[Address(RVA = "0x593BAC0", Offset = "0x593A6C0", VA = "0x18593BAC0")]
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite, int antiAliasing)
		{
			return null;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600065C")]
		[Address(RVA = "0x593BBF0", Offset = "0x593A7F0", VA = "0x18593BBF0")]
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format, RenderTextureReadWrite readWrite)
		{
			return null;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x593BDB0", Offset = "0x593A9B0", VA = "0x18593BDB0")]
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer, RenderTextureFormat format)
		{
			return null;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x593B620", Offset = "0x593A220", VA = "0x18593B620")]
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height, int depthBuffer)
		{
			return null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x593B870", Offset = "0x593A470", VA = "0x18593B870")]
		[ExcludeFromDocs]
		public static RenderTexture GetTemporary(int width, int height)
		{
			return null;
		}

		// Token: 0x06000660 RID: 1632
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x593AF70", Offset = "0x5939B70", VA = "0x18593AF70")]
		[MethodImpl(4096)]
		private extern void GetColorBuffer_Injected(out RenderBuffer ret);

		// Token: 0x06000661 RID: 1633
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x593B240", Offset = "0x5939E40", VA = "0x18593B240")]
		[MethodImpl(4096)]
		private extern void GetDepthBuffer_Injected(out RenderBuffer ret);

		// Token: 0x06000662 RID: 1634
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x593C3B0", Offset = "0x593AFB0", VA = "0x18593C3B0")]
		[MethodImpl(4096)]
		private extern void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc);

		// Token: 0x06000663 RID: 1635
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x593B3F0", Offset = "0x5939FF0", VA = "0x18593B3F0")]
		[MethodImpl(4096)]
		private extern void GetDescriptor_Injected(out RenderTextureDescriptor ret);

		// Token: 0x06000664 RID: 1636
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x593B5A0", Offset = "0x593A1A0", VA = "0x18593B5A0")]
		[MethodImpl(4096)]
		private static extern RenderTexture GetTemporary_Internal_Injected(ref RenderTextureDescriptor desc);
	}
}
