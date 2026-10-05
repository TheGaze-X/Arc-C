using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x0200382C RID: 14380
	[Token(Token = "0x200382C")]
	public class UIRenderTextureImage : Image
	{
		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x06016CC6 RID: 93382 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016CC7 RID: 93383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003687")]
		public new Sprite overrideSprite
		{
			[Token(Token = "0x6016CC6")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780")]
			get
			{
				return null;
			}
			[Token(Token = "0x6016CC7")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x06016CC8 RID: 93384 RVA: 0x00092FD0 File Offset: 0x000911D0
		// (set) Token: 0x06016CC9 RID: 93385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003688")]
		[Inspect]
		public Color tintColor
		{
			[Token(Token = "0x6016CC8")]
			[Address(RVA = "0xF4CE90", Offset = "0xF4BA90", VA = "0x180F4CE90")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6016CC9")]
			[Address(RVA = "0xF4CFA0", Offset = "0xF4BBA0", VA = "0x180F4CFA0")]
			set
			{
			}
		}

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x06016CCA RID: 93386 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016CCB RID: 93387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003689")]
		public new Sprite sprite
		{
			[Token(Token = "0x6016CCA")]
			[Address(RVA = "0xF4CE80", Offset = "0xF4BA80", VA = "0x180F4CE80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6016CCB")]
			[Address(RVA = "0xF4CED0", Offset = "0xF4BAD0", VA = "0x180F4CED0")]
			set
			{
			}
		}

		// Token: 0x06016CCC RID: 93388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CCC")]
		[Address(RVA = "0xF4CDA0", Offset = "0xF4B9A0", VA = "0x180F4CDA0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06016CCD RID: 93389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016CCD")]
		[Address(RVA = "0xF4CE30", Offset = "0xF4BA30", VA = "0x180F4CE30")]
		public UIRenderTextureImage()
		{
		}

		// Token: 0x0401B7E3 RID: 112611
		[Token(Token = "0x401B7E3")]
		[FieldOffset(Offset = "0x190")]
		private Sprite m_cacheRT;
	}
}
