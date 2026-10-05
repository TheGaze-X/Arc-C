using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200212C RID: 8492
	[Token(Token = "0x200212C")]
	public class MeshChangeableAnimator : MeshAnimator
	{
		// Token: 0x0600D099 RID: 53401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D099")]
		[Address(RVA = "0x35155A0", Offset = "0x35141A0", VA = "0x1835155A0")]
		public void EnableAllRenderers(bool enable)
		{
		}

		// Token: 0x0600D09A RID: 53402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D09A")]
		[Address(RVA = "0x3515850", Offset = "0x3514450", VA = "0x183515850")]
		public void EnableRenderer(int index, bool enable)
		{
		}

		// Token: 0x0600D09B RID: 53403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D09B")]
		[Address(RVA = "0x35156E0", Offset = "0x35142E0", VA = "0x1835156E0")]
		public void EnableRendererByName(string name, bool enable)
		{
		}

		// Token: 0x0600D09C RID: 53404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D09C")]
		[Address(RVA = "0x3515990", Offset = "0x3514590", VA = "0x183515990")]
		public MeshChangeableAnimator()
		{
		}

		// Token: 0x0400DF00 RID: 57088
		[Token(Token = "0x400DF00")]
		[FieldOffset(Offset = "0x170")]
		[SerializeField]
		private Renderer[] _changeableRenders;

		// Token: 0x0400DF01 RID: 57089
		[Token(Token = "0x400DF01")]
		[FieldOffset(Offset = "0x178")]
		[SerializeField]
		private bool activeObjInsteadEnableRender;

		// Token: 0x0400DF02 RID: 57090
		[Token(Token = "0x400DF02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EnableAllRenderers;

		// Token: 0x0400DF03 RID: 57091
		[Token(Token = "0x400DF03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EnableRenderer;

		// Token: 0x0400DF04 RID: 57092
		[Token(Token = "0x400DF04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EnableRendererByName;

		// Token: 0x0400DF05 RID: 57093
		[Token(Token = "0x400DF05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
