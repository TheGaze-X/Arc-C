using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200402D RID: 16429
	[Token(Token = "0x200402D")]
	public class SandboxV2AdminCharDetailView : SandboxV2AdminCharSelectAbstractLeftView
	{
		// Token: 0x060196E3 RID: 104163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196E3")]
		[Address(RVA = "0x121C7D0", Offset = "0x121B3D0", VA = "0x18121C7D0", Slot = "4")]
		public override void RenderView(SandboxV2CharListViewModel charListViewModel, SandboxV2CharSelectTabEnum tabEnum)
		{
		}

		// Token: 0x060196E4 RID: 104164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196E4")]
		[Address(RVA = "0x121C880", Offset = "0x121B480", VA = "0x18121C880")]
		public SandboxV2AdminCharDetailView()
		{
		}

		// Token: 0x0401FAAB RID: 129707
		[Token(Token = "0x401FAAB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2AdminCharAttrController _attrController;

		// Token: 0x0401FAAC RID: 129708
		[Token(Token = "0x401FAAC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0401FAAD RID: 129709
		[Token(Token = "0x401FAAD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
