using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Experimental.Rendering;
using UnityEngine.Internal;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000C3 RID: 195
	[Token(Token = "0x20000C3")]
	public struct RenderTextureDescriptor
	{
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x000038A0 File Offset: 0x00001AA0
		// (set) Token: 0x06000666 RID: 1638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017A")]
		public int width
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x849260", Offset = "0x847E60", VA = "0x180849260")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000666")]
			[Address(RVA = "0x8493B0", Offset = "0x847FB0", VA = "0x1808493B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x000038B8 File Offset: 0x00001AB8
		// (set) Token: 0x06000668 RID: 1640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017B")]
		public int height
		{
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x15EA010", Offset = "0x15E8C10", VA = "0x1815EA010")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x15EA030", Offset = "0x15E8C30", VA = "0x1815EA030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x000038D0 File Offset: 0x00001AD0
		// (set) Token: 0x0600066A RID: 1642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017C")]
		public int msaaSamples
		{
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x116A510", Offset = "0x1169110", VA = "0x18116A510")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x15EA020", Offset = "0x15E8C20", VA = "0x1815EA020")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x000038E8 File Offset: 0x00001AE8
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017D")]
		public int volumeDepth
		{
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x319ED80", Offset = "0x319D980", VA = "0x18319ED80")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x375DB10", Offset = "0x375C710", VA = "0x18375DB10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017E RID: 382
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017E")]
		public int mipCount
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00003900 File Offset: 0x00001B00
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700017F")]
		public GraphicsFormat graphicsFormat
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x4889940", Offset = "0x4888540", VA = "0x184889940")]
			get
			{
				return GraphicsFormat.None;
			}
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x593AC90", Offset = "0x5939890", VA = "0x18593AC90")]
			set
			{
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00003918 File Offset: 0x00001B18
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000180")]
		public GraphicsFormat depthStencilFormat
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			[CompilerGenerated]
			readonly get
			{
				return GraphicsFormat.None;
			}
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00003930 File Offset: 0x00001B30
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000181")]
		public RenderTextureFormat colorFormat
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x593A9E0", Offset = "0x59395E0", VA = "0x18593A9E0")]
			get
			{
				return RenderTextureFormat.ARGB32;
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x593AB60", Offset = "0x5939760", VA = "0x18593AB60")]
			set
			{
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00003948 File Offset: 0x00001B48
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000182")]
		public bool sRGB
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x593AAC0", Offset = "0x59396C0", VA = "0x18593AAC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x593AD50", Offset = "0x5939950", VA = "0x18593AD50")]
			set
			{
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000183")]
		public int depthBufferBits
		{
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x593AA60", Offset = "0x5939660", VA = "0x18593AA60")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x593AC40", Offset = "0x5939840", VA = "0x18593AC40")]
			set
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00003978 File Offset: 0x00001B78
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000184")]
		public TextureDimension dimension
		{
			[Token(Token = "0x6000678")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			[CompilerGenerated]
			readonly get
			{
				return TextureDimension.None;
			}
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x4EAC20", Offset = "0x4E9820", VA = "0x1804EAC20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x00003990 File Offset: 0x00001B90
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000185")]
		public ShadowSamplingMode shadowSamplingMode
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			[CompilerGenerated]
			readonly get
			{
				return ShadowSamplingMode.CompareDepths;
			}
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x000039A8 File Offset: 0x00001BA8
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000186")]
		public VRTextureUsage vrUsage
		{
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			[CompilerGenerated]
			readonly get
			{
				return VRTextureUsage.None;
			}
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000039C0 File Offset: 0x00001BC0
		// (set) Token: 0x0600067F RID: 1663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000187")]
		public RenderTextureMemoryless memoryless
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			[CompilerGenerated]
			readonly get
			{
				return RenderTextureMemoryless.None;
			}
			[Token(Token = "0x600067F")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000680")]
		[Address(RVA = "0x593A630", Offset = "0x5939230", VA = "0x18593A630")]
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height)
		{
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000681")]
		[Address(RVA = "0x593A7D0", Offset = "0x59393D0", VA = "0x18593A7D0")]
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat)
		{
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000682")]
		[Address(RVA = "0x593A920", Offset = "0x5939520", VA = "0x18593A920")]
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits)
		{
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000683")]
		[Address(RVA = "0x593A730", Offset = "0x5939330", VA = "0x18593A730")]
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, RenderTextureFormat colorFormat, int depthBufferBits, int mipCount)
		{
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000684")]
		[Address(RVA = "0x593A7F0", Offset = "0x59393F0", VA = "0x18593A7F0")]
		public RenderTextureDescriptor(int width, int height, [DefaultValue("RenderTextureFormat.Default")] RenderTextureFormat colorFormat, [DefaultValue("0")] int depthBufferBits, [DefaultValue("Texture.GenerateAllMips")] int mipCount, [DefaultValue("RenderTextureReadWrite.Linear")] RenderTextureReadWrite readWrite)
		{
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x593A650", Offset = "0x5939250", VA = "0x18593A650")]
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat)
		{
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x593A760", Offset = "0x5939360", VA = "0x18593A760")]
		[ExcludeFromDocs]
		public RenderTextureDescriptor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount)
		{
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000687")]
		[Address(RVA = "0x593A610", Offset = "0x5939210", VA = "0x18593A610")]
		private void SetOrClearRenderTextureCreationFlag(bool value, RenderTextureCreationFlags flag)
		{
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000688 RID: 1672 RVA: 0x000039D8 File Offset: 0x00001BD8
		// (set) Token: 0x06000689 RID: 1673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000188")]
		public bool useMipMap
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x593AB10", Offset = "0x5939710", VA = "0x18593AB10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x593AE40", Offset = "0x5939A40", VA = "0x18593AE40")]
			set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x000039F0 File Offset: 0x00001BF0
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000189")]
		public bool autoGenerateMips
		{
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x593A9D0", Offset = "0x59395D0", VA = "0x18593A9D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600068B")]
			[Address(RVA = "0x593AB20", Offset = "0x5939720", VA = "0x18593AB20")]
			set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x00003A08 File Offset: 0x00001C08
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018A")]
		public bool enableRandomWrite
		{
			[Token(Token = "0x600068C")]
			[Address(RVA = "0x593AAB0", Offset = "0x59396B0", VA = "0x18593AAB0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x593AC70", Offset = "0x5939870", VA = "0x18593AC70")]
			set
			{
			}
		}

		// Token: 0x1700018B RID: 395
		// (set) Token: 0x0600068E RID: 1678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018B")]
		public bool bindMS
		{
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x593AB40", Offset = "0x5939740", VA = "0x18593AB40")]
			set
			{
			}
		}

		// Token: 0x1700018C RID: 396
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018C")]
		internal bool createdFromScript
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x593AC20", Offset = "0x5939820", VA = "0x18593AC20")]
			set
			{
			}
		}

		// Token: 0x1700018D RID: 397
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700018D")]
		public bool useDynamicScale
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x593AE20", Offset = "0x5939A20", VA = "0x18593AE20")]
			set
			{
			}
		}

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x14")]
		private GraphicsFormat _graphicsFormat;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x2C")]
		private RenderTextureCreationFlags _flags;
	}
}
