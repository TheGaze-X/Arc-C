using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200535D RID: 21341
	[Token(Token = "0x200535D")]
	public class RoguelikeModuleDialogController : PageSingleComponent
	{
		// Token: 0x170049C1 RID: 18881
		// (get) Token: 0x0601F751 RID: 128849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170049C1")]
		public RoguelikeModuleDialogController.IRoguelikeModuleDialogHandler dialogHandler
		{
			[Token(Token = "0x601F751")]
			[Address(RVA = "0x192D9F0", Offset = "0x192C5F0", VA = "0x18192D9F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F752 RID: 128850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F752")]
		public void OpenModuleDialog<TDialog, TInput>(string resPath, TInput options, RoguelikeModuleDialogController.MenuConfig menuConfig, float showTweenDuration = 0.16f) where TDialog : UICompDialog<TInput> where TInput : class
		{
		}

		// Token: 0x0601F753 RID: 128851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F753")]
		[Address(RVA = "0x192D990", Offset = "0x192C590", VA = "0x18192D990")]
		public RoguelikeModuleDialogController()
		{
		}

		// Token: 0x0402A53E RID: 173374
		[Token(Token = "0x402A53E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private StateEngine _stateEngine;

		// Token: 0x0402A53F RID: 173375
		[Token(Token = "0x402A53F")]
		[FieldOffset(Offset = "0x28")]
		private RoguelikeModuleDialogController.IRoguelikeModuleDialogHandler m_dialogHandler;

		// Token: 0x0402A540 RID: 173376
		[Token(Token = "0x402A540")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dialogHandler;

		// Token: 0x0402A541 RID: 173377
		[Token(Token = "0x402A541")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OpenModuleDialog;

		// Token: 0x0402A542 RID: 173378
		[Token(Token = "0x402A542")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200535E RID: 21342
		[Token(Token = "0x200535E")]
		public struct MenuConfig
		{
			// Token: 0x0402A543 RID: 173379
			[Token(Token = "0x402A543")]
			[FieldOffset(Offset = "0x0")]
			public bool showBottomBar;

			// Token: 0x0402A544 RID: 173380
			[Token(Token = "0x402A544")]
			[FieldOffset(Offset = "0x1")]
			public bool showStatusBar;
		}

		// Token: 0x0200535F RID: 21343
		[Token(Token = "0x200535F")]
		public interface IRoguelikeModuleDialogHandler
		{
			// Token: 0x170049C2 RID: 18882
			// (get) Token: 0x0601F754 RID: 128852
			[Token(Token = "0x170049C2")]
			Type dialogType { [Token(Token = "0x601F754")] get; }

			// Token: 0x170049C3 RID: 18883
			// (get) Token: 0x0601F755 RID: 128853
			[Token(Token = "0x170049C3")]
			int instId { [Token(Token = "0x601F755")] get; }

			// Token: 0x170049C4 RID: 18884
			// (get) Token: 0x0601F756 RID: 128854
			// (set) Token: 0x0601F757 RID: 128855
			[Token(Token = "0x170049C4")]
			RoguelikeModuleDialogController.MenuConfig menuConfig { [Token(Token = "0x601F756")] get; [Token(Token = "0x601F757")] set; }

			// Token: 0x170049C5 RID: 18885
			// (get) Token: 0x0601F758 RID: 128856
			// (set) Token: 0x0601F759 RID: 128857
			[Token(Token = "0x170049C5")]
			float showTweenDuration { [Token(Token = "0x601F758")] get; [Token(Token = "0x601F759")] set; }

			// Token: 0x0601F75A RID: 128858
			[Token(Token = "0x601F75A")]
			bool OpenModuleDialog(UICompDialogMgr dialogMgr);
		}

		// Token: 0x02005360 RID: 21344
		[Token(Token = "0x2005360")]
		public class RoguelikeModuleDialogHandler<TDialog, TInput> : RoguelikeModuleDialogController.IRoguelikeModuleDialogHandler where TDialog : UICompDialog<TInput> where TInput : class
		{
			// Token: 0x170049C6 RID: 18886
			// (get) Token: 0x0601F75B RID: 128859 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170049C6")]
			public Type dialogType
			{
				[Token(Token = "0x601F75B")]
				get
				{
					return null;
				}
			}

			// Token: 0x170049C7 RID: 18887
			// (get) Token: 0x0601F75C RID: 128860 RVA: 0x000B1FF0 File Offset: 0x000B01F0
			[Token(Token = "0x170049C7")]
			public int instId
			{
				[Token(Token = "0x601F75C")]
				get
				{
					return 0;
				}
			}

			// Token: 0x170049C8 RID: 18888
			// (get) Token: 0x0601F75D RID: 128861 RVA: 0x000B2008 File Offset: 0x000B0208
			// (set) Token: 0x0601F75E RID: 128862 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170049C8")]
			public RoguelikeModuleDialogController.MenuConfig menuConfig
			{
				[Token(Token = "0x601F75D")]
				[CompilerGenerated]
				get
				{
					return default(RoguelikeModuleDialogController.MenuConfig);
				}
				[Token(Token = "0x601F75E")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x170049C9 RID: 18889
			// (get) Token: 0x0601F75F RID: 128863 RVA: 0x000B2020 File Offset: 0x000B0220
			// (set) Token: 0x0601F760 RID: 128864 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170049C9")]
			public float showTweenDuration
			{
				[Token(Token = "0x601F75F")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x601F760")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601F761 RID: 128865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F761")]
			public RoguelikeModuleDialogHandler(string resPath, TInput options)
			{
			}

			// Token: 0x0601F762 RID: 128866 RVA: 0x000B2038 File Offset: 0x000B0238
			[Token(Token = "0x601F762")]
			public bool OpenModuleDialog(UICompDialogMgr dialogMgr)
			{
				return default(bool);
			}

			// Token: 0x0402A545 RID: 173381
			[Token(Token = "0x402A545")]
			[FieldOffset(Offset = "0x0")]
			private string m_resPath;

			// Token: 0x0402A546 RID: 173382
			[Token(Token = "0x402A546")]
			[FieldOffset(Offset = "0x0")]
			private TInput m_input;

			// Token: 0x0402A547 RID: 173383
			[Token(Token = "0x402A547")]
			[FieldOffset(Offset = "0x0")]
			private int m_instId;
		}
	}
}
