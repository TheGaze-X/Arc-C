using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.AVG
{
	// Token: 0x02001EFE RID: 7934
	[Token(Token = "0x2001EFE")]
	public abstract class PostDisplayItem : IDisposable
	{
		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x0600C50B RID: 50443 RVA: 0x000483A8 File Offset: 0x000465A8
		// (set) Token: 0x0600C50C RID: 50444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001779")]
		public bool isDisposed
		{
			[Token(Token = "0x600C50B")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600C50C")]
			[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x0600C50D RID: 50445 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C50E RID: 50446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700177A")]
		private protected PostDisplayGroup group
		{
			[Token(Token = "0x600C50D")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600C50E")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x0600C50F RID: 50447 RVA: 0x000483C0 File Offset: 0x000465C0
		// (set) Token: 0x0600C510 RID: 50448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700177B")]
		public PostDisplayKey key
		{
			[Token(Token = "0x600C50F")]
			[Address(RVA = "0x1195F40", Offset = "0x1194B40", VA = "0x181195F40")]
			[CompilerGenerated]
			get
			{
				return default(PostDisplayKey);
			}
			[Token(Token = "0x600C510")]
			[Address(RVA = "0x3430CC0", Offset = "0x342F8C0", VA = "0x183430CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600C511 RID: 50449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C511")]
		[Address(RVA = "0x342E120", Offset = "0x342CD20", VA = "0x18342E120")]
		protected PostDisplayItem()
		{
		}

		// Token: 0x0600C512 RID: 50450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C512")]
		public static PostDisplayItem Create<TItem>(PostDisplayKey key, PostDisplayGroup group) where TItem : PostDisplayItem, new()
		{
			return null;
		}

		// Token: 0x0600C513 RID: 50451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C513")]
		[Address(RVA = "0x3430B70", Offset = "0x342F770", VA = "0x183430B70")]
		public void TryRegisterToProcessor(PostDisplayItem.IProcessor processor)
		{
		}

		// Token: 0x0600C514 RID: 50452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C514")]
		[Address(RVA = "0x3430B10", Offset = "0x342F710", VA = "0x183430B10")]
		public void SetTextures(PostDisplayItem.Textures texs)
		{
		}

		// Token: 0x0600C515 RID: 50453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C515")]
		[Address(RVA = "0x3430800", Offset = "0x342F400", VA = "0x183430800", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x0600C516 RID: 50454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C516")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		protected virtual void OnDispose()
		{
		}

		// Token: 0x0600C517 RID: 50455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C517")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x0600C518 RID: 50456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C518")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "7")]
		protected virtual void OnTexturesChanged(PostDisplayItem.Textures texs)
		{
		}

		// Token: 0x0400C994 RID: 51604
		[Token(Token = "0x400C994")]
		[FieldOffset(Offset = "0x38")]
		private List<PostDisplayItem.IProcessor> m_processors;

		// Token: 0x02001EFF RID: 7935
		[Token(Token = "0x2001EFF")]
		public interface IProcessor
		{
			// Token: 0x0600C519 RID: 50457
			[Token(Token = "0x600C519")]
			bool TryRegister(PostDisplayItem item);

			// Token: 0x0600C51A RID: 50458
			[Token(Token = "0x600C51A")]
			void BeforeItemDisposed(PostDisplayItem item);
		}

		// Token: 0x02001F00 RID: 7936
		[Token(Token = "0x2001F00")]
		public struct Textures
		{
			// Token: 0x0400C995 RID: 51605
			[Token(Token = "0x400C995")]
			[FieldOffset(Offset = "0x0")]
			public Sprite sprite;

			// Token: 0x0400C996 RID: 51606
			[Token(Token = "0x400C996")]
			[FieldOffset(Offset = "0x8")]
			public Texture alphaTex;

			// Token: 0x0400C997 RID: 51607
			[Token(Token = "0x400C997")]
			[FieldOffset(Offset = "0x10")]
			public Texture dynTex;

			// Token: 0x0400C998 RID: 51608
			[Token(Token = "0x400C998")]
			[FieldOffset(Offset = "0x18")]
			public Texture alphaDynTex;

			// Token: 0x0400C999 RID: 51609
			[Token(Token = "0x400C999")]
			[FieldOffset(Offset = "0x20")]
			public Vector2 dynScale;

			// Token: 0x0400C99A RID: 51610
			[Token(Token = "0x400C99A")]
			[FieldOffset(Offset = "0x28")]
			public Vector2 dynOffset;
		}
	}
}
