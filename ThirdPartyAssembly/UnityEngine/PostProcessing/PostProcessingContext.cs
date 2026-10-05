using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000E9 RID: 233
	[Token(Token = "0x20000E9")]
	public class PostProcessingContext
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00003648 File Offset: 0x00001848
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000079")]
		public bool interrupted
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xAE5EF0", Offset = "0xAE4AF0", VA = "0x180AE5EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x17F30F0", Offset = "0x17F1CF0", VA = "0x1817F30F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1B023C0", Offset = "0x1B00FC0", VA = "0x181B023C0")]
		public void Interrupt()
		{
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x542D870", Offset = "0x542C470", VA = "0x18542D870")]
		public PostProcessingContext Reset()
		{
			return null;
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00003660 File Offset: 0x00001860
		[Token(Token = "0x1700007A")]
		public bool isGBufferAvailable
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x542D8F0", Offset = "0x542C4F0", VA = "0x18542D8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060003D9 RID: 985 RVA: 0x00003678 File Offset: 0x00001878
		[Token(Token = "0x1700007B")]
		public bool isHdr
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x542D920", Offset = "0x542C520", VA = "0x18542D920")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00003690 File Offset: 0x00001890
		[Token(Token = "0x1700007C")]
		public int width
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x542D980", Offset = "0x542C580", VA = "0x18542D980")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060003DB RID: 987 RVA: 0x000036A8 File Offset: 0x000018A8
		[Token(Token = "0x1700007D")]
		public int height
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x542D8D0", Offset = "0x542C4D0", VA = "0x18542D8D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x1700007E")]
		public Rect viewport
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x542D940", Offset = "0x542C540", VA = "0x18542D940")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PostProcessingContext()
		{
		}

		// Token: 0x0400052B RID: 1323
		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x10")]
		public PostProcessingProfile profile;

		// Token: 0x0400052C RID: 1324
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x18")]
		public Camera camera;

		// Token: 0x0400052D RID: 1325
		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x20")]
		public MaterialFactory materialFactory;

		// Token: 0x0400052E RID: 1326
		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x28")]
		public RenderTextureFactory renderTextureFactory;
	}
}
