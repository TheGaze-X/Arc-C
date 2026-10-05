using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SiracusaMap
{
	// Token: 0x02003F8D RID: 16269
	[Token(Token = "0x2003F8D")]
	public abstract class SiracusaMapNodeViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x060193D6 RID: 103382 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060193D7 RID: 103383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003C42")]
		public Action<SiracusaMapMapNodeViewModel> onNodeViewClick
		{
			[Token(Token = "0x60193D6")]
			[Address(RVA = "0x11EE940", Offset = "0x11ED540", VA = "0x1811EE940")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x60193D7")]
			[Address(RVA = "0x11EE9A0", Offset = "0x11ED5A0", VA = "0x1811EE9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060193D8 RID: 103384
		[Token(Token = "0x60193D8")]
		public abstract SiracusaMapNodeViewBase.ViewType GetViewType();

		// Token: 0x060193D9 RID: 103385
		[Token(Token = "0x60193D9")]
		public abstract void Render(SiracusaMapMapNodeViewModel viewModel);

		// Token: 0x060193DA RID: 103386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193DA")]
		[Address(RVA = "0x11EE860", Offset = "0x11ED460", VA = "0x1811EE860", Slot = "6")]
		public virtual void Show(bool isFastMode)
		{
		}

		// Token: 0x060193DB RID: 103387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193DB")]
		[Address(RVA = "0x11EE760", Offset = "0x11ED360", VA = "0x1811EE760", Slot = "7")]
		public virtual void Hide(bool isFastMode)
		{
		}

		// Token: 0x060193DC RID: 103388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193DC")]
		[Address(RVA = "0x11EE7E0", Offset = "0x11ED3E0", VA = "0x1811EE7E0")]
		public void SetAreaIconSpriteHub(AutoPackSpriteHub spriteHub)
		{
		}

		// Token: 0x060193DD RID: 103389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60193DD")]
		[Address(RVA = "0x11EE8E0", Offset = "0x11ED4E0", VA = "0x1811EE8E0")]
		protected SiracusaMapNodeViewBase()
		{
		}

		// Token: 0x0401F51A RID: 128282
		[Token(Token = "0x401F51A")]
		[FieldOffset(Offset = "0x18")]
		protected AutoPackSpriteHub areaIconSpriteHub;

		// Token: 0x0401F51C RID: 128284
		[Token(Token = "0x401F51C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onNodeViewClick;

		// Token: 0x0401F51D RID: 128285
		[Token(Token = "0x401F51D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onNodeViewClick;

		// Token: 0x0401F51E RID: 128286
		[Token(Token = "0x401F51E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Show;

		// Token: 0x0401F51F RID: 128287
		[Token(Token = "0x401F51F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Hide;

		// Token: 0x0401F520 RID: 128288
		[Token(Token = "0x401F520")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetAreaIconSpriteHub;

		// Token: 0x0401F521 RID: 128289
		[Token(Token = "0x401F521")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003F8E RID: 16270
		[Token(Token = "0x2003F8E")]
		public enum ViewType
		{
			// Token: 0x0401F523 RID: 128291
			[Token(Token = "0x401F523")]
			NORMAL,
			// Token: 0x0401F524 RID: 128292
			[Token(Token = "0x401F524")]
			TASK,
			// Token: 0x0401F525 RID: 128293
			[Token(Token = "0x401F525")]
			SELECTED
		}
	}
}
