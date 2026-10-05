using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001E26 RID: 7718
	[Token(Token = "0x2001E26")]
	public abstract class AVGComponent : MonoBehaviour, IHotfixable
	{
		// Token: 0x170016FE RID: 5886
		// (get) Token: 0x0600BEAD RID: 48813 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600BEAE RID: 48814 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170016FE")]
		private protected AVGController controller
		{
			[Token(Token = "0x600BEAD")]
			[Address(RVA = "0x33B33D0", Offset = "0x33B1FD0", VA = "0x1833B33D0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600BEAE")]
			[Address(RVA = "0x33B35A0", Offset = "0x33B21A0", VA = "0x1833B35A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016FF RID: 5887
		// (get) Token: 0x0600BEAF RID: 48815 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016FF")]
		protected ILoadAsset assetLoader
		{
			[Token(Token = "0x600BEAF")]
			[Address(RVA = "0x33B3280", Offset = "0x33B1E80", VA = "0x1833B3280")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001700 RID: 5888
		// (get) Token: 0x0600BEB0 RID: 48816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001700")]
		protected ResourceRouter router
		{
			[Token(Token = "0x600BEB0")]
			[Address(RVA = "0x33B3430", Offset = "0x33B2030", VA = "0x1833B3430")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001701 RID: 5889
		// (get) Token: 0x0600BEB1 RID: 48817 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600BEB2 RID: 48818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001701")]
		private protected AVGController.AVGCompBridge controllerBridge
		{
			[Token(Token = "0x600BEB1")]
			[Address(RVA = "0x33B3370", Offset = "0x33B1F70", VA = "0x1833B3370")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x600BEB2")]
			[Address(RVA = "0x33B3520", Offset = "0x33B2120", VA = "0x1833B3520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600BEB3 RID: 48819
		[Token(Token = "0x600BEB3")]
		public abstract IList<ICommandExecutor> GetCommandExecutors();

		// Token: 0x0600BEB4 RID: 48820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB4")]
		[Address(RVA = "0x33B30E0", Offset = "0x33B1CE0", VA = "0x1833B30E0")]
		public void SetController(AVGController controller, AVGController.AVGCompBridge bridge)
		{
		}

		// Token: 0x0600BEB5 RID: 48821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB5")]
		[Address(RVA = "0x33B3020", Offset = "0x33B1C20", VA = "0x1833B3020", Slot = "5")]
		public virtual void OnStoryBegin(Story story)
		{
		}

		// Token: 0x0600BEB6 RID: 48822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB6")]
		[Address(RVA = "0x33B3080", Offset = "0x33B1C80", VA = "0x1833B3080", Slot = "6")]
		public virtual void OnStoryEnd(Story story)
		{
		}

		// Token: 0x0600BEB7 RID: 48823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB7")]
		[Address(RVA = "0x33B2FC0", Offset = "0x33B1BC0", VA = "0x1833B2FC0", Slot = "7")]
		public virtual void OnReset()
		{
		}

		// Token: 0x0600BEB8 RID: 48824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BEB8")]
		[Address(RVA = "0x33B3220", Offset = "0x33B1E20", VA = "0x1833B3220")]
		protected AVGComponent()
		{
		}

		// Token: 0x0400BF9D RID: 49053
		[Token(Token = "0x400BF9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x0400BF9E RID: 49054
		[Token(Token = "0x400BF9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_controller;

		// Token: 0x0400BF9F RID: 49055
		[Token(Token = "0x400BF9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x0400BFA0 RID: 49056
		[Token(Token = "0x400BFA0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_router;

		// Token: 0x0400BFA1 RID: 49057
		[Token(Token = "0x400BFA1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_controllerBridge;

		// Token: 0x0400BFA2 RID: 49058
		[Token(Token = "0x400BFA2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_controllerBridge;

		// Token: 0x0400BFA3 RID: 49059
		[Token(Token = "0x400BFA3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetController;

		// Token: 0x0400BFA4 RID: 49060
		[Token(Token = "0x400BFA4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnStoryBegin;

		// Token: 0x0400BFA5 RID: 49061
		[Token(Token = "0x400BFA5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnStoryEnd;

		// Token: 0x0400BFA6 RID: 49062
		[Token(Token = "0x400BFA6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400BFA7 RID: 49063
		[Token(Token = "0x400BFA7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
