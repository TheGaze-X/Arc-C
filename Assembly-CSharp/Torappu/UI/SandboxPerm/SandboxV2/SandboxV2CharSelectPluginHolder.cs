using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004033 RID: 16435
	[Token(Token = "0x2004033")]
	public class SandboxV2CharSelectPluginHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x060196F6 RID: 104182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60196F6")]
		[Address(RVA = "0x121FBF0", Offset = "0x121E7F0", VA = "0x18121FBF0")]
		public SandboxV2AdminCharSelectAbstractLeftView GetLeftView()
		{
			return null;
		}

		// Token: 0x060196F7 RID: 104183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60196F7")]
		[Address(RVA = "0x121FCB0", Offset = "0x121E8B0", VA = "0x18121FCB0")]
		public SandboxV2AdminCharAbstractShuffleView GetShuffleView()
		{
			return null;
		}

		// Token: 0x060196F8 RID: 104184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60196F8")]
		[Address(RVA = "0x121FB90", Offset = "0x121E790", VA = "0x18121FB90")]
		public SandboxV2AdminCharAbstractEnsureView GetEnsureView()
		{
			return null;
		}

		// Token: 0x060196F9 RID: 104185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60196F9")]
		[Address(RVA = "0x121FC50", Offset = "0x121E850", VA = "0x18121FC50")]
		public SandboxV2AdminCharSelectAbstractPopView GetPopView()
		{
			return null;
		}

		// Token: 0x060196FA RID: 104186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60196FA")]
		[Address(RVA = "0x121FD10", Offset = "0x121E910", VA = "0x18121FD10")]
		public SandboxV2CharSelectPluginHolder()
		{
		}

		// Token: 0x0401FAD6 RID: 129750
		[Token(Token = "0x401FAD6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2AdminCharSelectAbstractLeftView _leftView;

		// Token: 0x0401FAD7 RID: 129751
		[Token(Token = "0x401FAD7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2AdminCharAbstractShuffleView _shuffleView;

		// Token: 0x0401FAD8 RID: 129752
		[Token(Token = "0x401FAD8")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2AdminCharAbstractEnsureView _ensureView;

		// Token: 0x0401FAD9 RID: 129753
		[Token(Token = "0x401FAD9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SandboxV2AdminCharSelectAbstractPopView _popView;

		// Token: 0x0401FADA RID: 129754
		[Token(Token = "0x401FADA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetLeftView;

		// Token: 0x0401FADB RID: 129755
		[Token(Token = "0x401FADB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetShuffleView;

		// Token: 0x0401FADC RID: 129756
		[Token(Token = "0x401FADC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEnsureView;

		// Token: 0x0401FADD RID: 129757
		[Token(Token = "0x401FADD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetPopView;

		// Token: 0x0401FADE RID: 129758
		[Token(Token = "0x401FADE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
