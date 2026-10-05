using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020039BF RID: 14783
	[Token(Token = "0x20039BF")]
	public abstract class SimpleLayoutAdapter<ViewType> : SimpleLayoutAdapter where ViewType : Component
	{
		// Token: 0x060175B8 RID: 95672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60175B8")]
		public sealed override GameObject RenderView(int position, GameObject prefab, Transform parent)
		{
			return null;
		}

		// Token: 0x060175B9 RID: 95673
		[Token(Token = "0x60175B9")]
		protected abstract void OnRender(int position, ViewType view, bool isNewlyCreated);

		// Token: 0x060175BA RID: 95674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60175BA")]
		protected SimpleLayoutAdapter()
		{
		}

		// Token: 0x0401C340 RID: 115520
		[Token(Token = "0x401C340")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401C341 RID: 115521
		[Token(Token = "0x401C341")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
