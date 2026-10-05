using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu.Audio.Engine
{
	// Token: 0x0200025C RID: 604
	[Token(Token = "0x200025C")]
	public struct AudioAsset
	{
		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00008E7C File Offset: 0x0000707C
		// (set) Token: 0x06000DCC RID: 3532 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170001A0")]
		public bool isEmpty
		{
			[Token(Token = "0x6000DCB")]
			[Address(RVA = "0xDF9A30", Offset = "0xDF8630", VA = "0x180DF9A30")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DCC")]
			[Address(RVA = "0xFEDED0", Offset = "0xFECAD0", VA = "0x180FEDED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000DCE RID: 3534 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170001A1")]
		public string key1
		{
			[Token(Token = "0x6000DCD")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000DCE")]
			[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000DCF RID: 3535 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000DD0 RID: 3536 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170001A2")]
		public object asset1
		{
			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000DD0")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000DD1 RID: 3537 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000DD2 RID: 3538 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170001A3")]
		public string key2
		{
			[Token(Token = "0x6000DD1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000DD2")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170001A4")]
		public object asset2
		{
			[Token(Token = "0x6000DD3")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6000DD4")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00008E94 File Offset: 0x00007094
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x557D6A0", Offset = "0x557C2A0", VA = "0x18557D6A0")]
		public static AudioAsset Create(string single, object asset)
		{
			return default(AudioAsset);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00008EAC File Offset: 0x000070AC
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x557D5E0", Offset = "0x557C1E0", VA = "0x18557D5E0")]
		public static AudioAsset Create(string introKey, object introAsset, string loopKey, object loopAsset)
		{
			return default(AudioAsset);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00008EC4 File Offset: 0x000070C4
		[Token(Token = "0x6000DD7")]
		public int ReadAssetInfo<TAsset>(ref string[] keys, ref TAsset[] assets) where TAsset : class
		{
			return 0;
		}

		// Token: 0x04000E75 RID: 3701
		[Token(Token = "0x4000E75")]
		public const int MAX_CLIP_COUNT = 2;

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AudioAsset EMPTY;
	}
}
