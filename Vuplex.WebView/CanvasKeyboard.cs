using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using Vuplex.WebView.Internal;

namespace Vuplex.WebView
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public class CanvasKeyboard : BaseKeyboard
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000A")]
		public CanvasWebViewPrefab WebViewPrefab
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x5BB0AC0", Offset = "0x5BAF6C0", VA = "0x185BB0AC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x5BB0670", Offset = "0x5BAF270", VA = "0x185BB0670")]
		public static CanvasKeyboard Instantiate()
		{
			return null;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x5BB07A0", Offset = "0x5BAF3A0", VA = "0x185BB07A0")]
		private void _initCanvasKeyboard()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x5BB0740", Offset = "0x5BAF340", VA = "0x185BB0740")]
		private void Start()
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		[Obsolete("CanvasKeyboard.InitialResolution is now deprecated. Please use CanvasKeyboard.Resolution instead.")]
		public float InitialResolution
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x17DB8C0", Offset = "0x17DA4C0", VA = "0x1817DB8C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x17DB8D0", Offset = "0x17DA4D0", VA = "0x1817DB8D0")]
			set
			{
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x5BB0750", Offset = "0x5BAF350", VA = "0x185BB0750")]
		public CanvasKeyboard()
		{
		}

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x48")]
		[Tooltip("You can change this to make web content appear larger or smaller.")]
		[Label("Resolution (px / Unity unit)")]
		[FormerlySerializedAs("InitialResolution")]
		public float Resolution;
	}
}
