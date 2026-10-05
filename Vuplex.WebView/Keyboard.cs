using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class Keyboard : BaseKeyboard
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000175 RID: 373 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000025")]
		public WebViewPrefab WebViewPrefab
		{
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x5BB5B70", Offset = "0x5BB4770", VA = "0x185BB5B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000176")]
		[Address(RVA = "0x5BB5550", Offset = "0x5BB4150", VA = "0x185BB5550")]
		public static Keyboard Instantiate()
		{
			return null;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000177")]
		[Address(RVA = "0x5BB5690", Offset = "0x5BB4290", VA = "0x185BB5690")]
		public static Keyboard Instantiate(float width, float height)
		{
			return null;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x5BB5840", Offset = "0x5BB4440", VA = "0x185BB5840")]
		private void _initKeyboard()
		{
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x5BB57E0", Offset = "0x5BB43E0", VA = "0x185BB57E0")]
		private void Start()
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		[Obsolete("Keyboard.Init() has been removed. The Keyboard script now initializes itself automatically, so Init() no longer needs to be called.", true)]
		public void Init(float width, float height)
		{
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00002328 File Offset: 0x00000528
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000026")]
		[Obsolete("Keyboard.InitialResolution is now deprecated. Please use Keyboard.Resolution instead.")]
		public float InitialResolution
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x17DB8C0", Offset = "0x17DA4C0", VA = "0x1817DB8C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x17DB8D0", Offset = "0x17DA4D0", VA = "0x1817DB8D0")]
			set
			{
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017D")]
		[Address(RVA = "0x5BB57F0", Offset = "0x5BB43F0", VA = "0x185BB57F0")]
		public Keyboard()
		{
		}

		// Token: 0x0400009A RID: 154
		[Token(Token = "0x400009A")]
		[FieldOffset(Offset = "0x48")]
		[Label("Resolution (px / Unity unit)")]
		[FormerlySerializedAs("InitialResolution")]
		[Tooltip("You can change this to make web content appear larger or smaller.")]
		public float Resolution;

		// Token: 0x0400009B RID: 155
		[Token(Token = "0x400009B")]
		private const float DEFAULT_KEYBOARD_WIDTH = 0.5f;

		// Token: 0x0400009C RID: 156
		[Token(Token = "0x400009C")]
		private const float DEFAULT_KEYBOARD_HEIGHT = 0.125f;
	}
}
