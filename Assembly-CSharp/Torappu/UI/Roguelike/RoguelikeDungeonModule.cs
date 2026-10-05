using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005368 RID: 21352
	[Token(Token = "0x2005368")]
	public abstract class RoguelikeDungeonModule : MonoBehaviour, IHotfixable
	{
		// Token: 0x170049D5 RID: 18901
		// (get) Token: 0x0601F79B RID: 128923 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F79C RID: 128924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049D5")]
		private protected IRoguelikeModuleHost host
		{
			[Token(Token = "0x601F79B")]
			[Address(RVA = "0x1922FB0", Offset = "0x1921BB0", VA = "0x181922FB0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601F79C")]
			[Address(RVA = "0x1923070", Offset = "0x1921C70", VA = "0x181923070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170049D6 RID: 18902
		// (get) Token: 0x0601F79D RID: 128925 RVA: 0x000B2158 File Offset: 0x000B0358
		// (set) Token: 0x0601F79E RID: 128926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170049D6")]
		public bool isRunning
		{
			[Token(Token = "0x601F79D")]
			[Address(RVA = "0x1923010", Offset = "0x1921C10", VA = "0x181923010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601F79E")]
			[Address(RVA = "0x19230F0", Offset = "0x1921CF0", VA = "0x1819230F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0601F79F RID: 128927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F79F")]
		[Address(RVA = "0x1922B70", Offset = "0x1921770", VA = "0x181922B70")]
		public void Init(IRoguelikeModuleHost moduleHost)
		{
		}

		// Token: 0x0601F7A0 RID: 128928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7A0")]
		[Address(RVA = "0x1922DD0", Offset = "0x19219D0", VA = "0x181922DD0")]
		public void TriggerCreate()
		{
		}

		// Token: 0x0601F7A1 RID: 128929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7A1")]
		[Address(RVA = "0x1922ED0", Offset = "0x1921AD0", VA = "0x181922ED0")]
		public void TriggerReloadDungeon()
		{
		}

		// Token: 0x0601F7A2 RID: 128930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7A2")]
		[Address(RVA = "0x1922E50", Offset = "0x1921A50", VA = "0x181922E50")]
		public void TriggerDestroy()
		{
		}

		// Token: 0x0601F7A3 RID: 128931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F7A3")]
		[Address(RVA = "0x19229C0", Offset = "0x19215C0", VA = "0x1819229C0")]
		public RoguelikeDungeonController FindController()
		{
			return null;
		}

		// Token: 0x0601F7A4 RID: 128932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7A4")]
		[Address(RVA = "0x1922CE0", Offset = "0x19218E0", VA = "0x181922CE0")]
		public void SetState(bool running)
		{
		}

		// Token: 0x0601F7A5 RID: 128933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7A5")]
		[Address(RVA = "0x1922090", Offset = "0x1920C90", VA = "0x181922090", Slot = "4")]
		protected virtual void OnCreate()
		{
		}

		// Token: 0x0601F7A6 RID: 128934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7A6")]
		[Address(RVA = "0x1922150", Offset = "0x1920D50", VA = "0x181922150", Slot = "5")]
		protected virtual void OnReloadDungeon()
		{
		}

		// Token: 0x0601F7A7 RID: 128935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7A7")]
		[Address(RVA = "0x19220F0", Offset = "0x1920CF0", VA = "0x1819220F0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0601F7A8 RID: 128936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7A8")]
		[Address(RVA = "0x1922C80", Offset = "0x1921880", VA = "0x181922C80", Slot = "7")]
		protected virtual void OnStateChanged()
		{
		}

		// Token: 0x0601F7A9 RID: 128937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F7A9")]
		[Address(RVA = "0x1922F50", Offset = "0x1921B50", VA = "0x181922F50")]
		protected RoguelikeDungeonModule()
		{
		}

		// Token: 0x0402A577 RID: 173431
		[Token(Token = "0x402A577")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_host;

		// Token: 0x0402A578 RID: 173432
		[Token(Token = "0x402A578")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_host;

		// Token: 0x0402A579 RID: 173433
		[Token(Token = "0x402A579")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_isRunning;

		// Token: 0x0402A57A RID: 173434
		[Token(Token = "0x402A57A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_isRunning;

		// Token: 0x0402A57B RID: 173435
		[Token(Token = "0x402A57B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402A57C RID: 173436
		[Token(Token = "0x402A57C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TriggerCreate;

		// Token: 0x0402A57D RID: 173437
		[Token(Token = "0x402A57D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TriggerReloadDungeon;

		// Token: 0x0402A57E RID: 173438
		[Token(Token = "0x402A57E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TriggerDestroy;

		// Token: 0x0402A57F RID: 173439
		[Token(Token = "0x402A57F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FindController;

		// Token: 0x0402A580 RID: 173440
		[Token(Token = "0x402A580")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetState;

		// Token: 0x0402A581 RID: 173441
		[Token(Token = "0x402A581")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x0402A582 RID: 173442
		[Token(Token = "0x402A582")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnReloadDungeon;

		// Token: 0x0402A583 RID: 173443
		[Token(Token = "0x402A583")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402A584 RID: 173444
		[Token(Token = "0x402A584")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnStateChanged;

		// Token: 0x0402A585 RID: 173445
		[Token(Token = "0x402A585")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
