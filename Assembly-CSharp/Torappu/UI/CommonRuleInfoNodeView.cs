using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200374D RID: 14157
	[Token(Token = "0x200374D")]
	public abstract class CommonRuleInfoNodeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x060167EA RID: 92138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035E1")]
		public RectTransform childNodeRoot
		{
			[Token(Token = "0x60167EA")]
			[Address(RVA = "0xED8B20", Offset = "0xED7720", VA = "0x180ED8B20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x060167EB RID: 92139
		[Token(Token = "0x170035E2")]
		public abstract ICommonRuleInfoNodeViewModel.NodeType nodeType { [Token(Token = "0x60167EB")] get; }

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x060167EC RID: 92140 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060167ED RID: 92141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170035E3")]
		public List<CommonRuleInfoNodeView> childNodes
		{
			[Token(Token = "0x60167EC")]
			[Address(RVA = "0xED8C10", Offset = "0xED7810", VA = "0x180ED8C10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60167ED")]
			[Address(RVA = "0xED8C70", Offset = "0xED7870", VA = "0x180ED8C70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x060167EE RID: 92142
		[Token(Token = "0x60167EE")]
		public abstract void Render(ICommonRuleInfoNodeViewModel nodeInfoViewModel);

		// Token: 0x060167EF RID: 92143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167EF")]
		[Address(RVA = "0xED88D0", Offset = "0xED74D0", VA = "0x180ED88D0", Slot = "6")]
		public virtual void SetChildNode(CommonRuleInfoNodeView childNodeView)
		{
		}

		// Token: 0x060167F0 RID: 92144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60167F0")]
		[Address(RVA = "0xED8AC0", Offset = "0xED76C0", VA = "0x180ED8AC0")]
		protected CommonRuleInfoNodeView()
		{
		}

		// Token: 0x0401B18C RID: 110988
		[Token(Token = "0x401B18C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _childNodeRoot;

		// Token: 0x0401B18D RID: 110989
		[Token(Token = "0x401B18D")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_childNodeRoot;

		// Token: 0x0401B18F RID: 110991
		[Token(Token = "0x401B18F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_childNodeRoot;

		// Token: 0x0401B190 RID: 110992
		[Token(Token = "0x401B190")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_childNodes;

		// Token: 0x0401B191 RID: 110993
		[Token(Token = "0x401B191")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_childNodes;

		// Token: 0x0401B192 RID: 110994
		[Token(Token = "0x401B192")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetChildNode;

		// Token: 0x0401B193 RID: 110995
		[Token(Token = "0x401B193")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
