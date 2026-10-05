using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.Events;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D42 RID: 27970
	[Token(Token = "0x2006D42")]
	public abstract class ActivityCommonEntry : MonoBehaviour, IHotfixable
	{
		// Token: 0x06027DD9 RID: 163289
		[Token(Token = "0x6027DD9")]
		public abstract void OnEnter(string activityId);

		// Token: 0x06027DDA RID: 163290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DDA")]
		[Address(RVA = "0x22EFEA0", Offset = "0x22EEAA0", VA = "0x1822EFEA0", Slot = "5")]
		public virtual void OnResume()
		{
		}

		// Token: 0x06027DDB RID: 163291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DDB")]
		[Address(RVA = "0x22EFE40", Offset = "0x22EEA40", VA = "0x1822EFE40", Slot = "6")]
		public virtual void OnExit()
		{
		}

		// Token: 0x06027DDC RID: 163292 RVA: 0x000CFB88 File Offset: 0x000CDD88
		[Token(Token = "0x6027DDC")]
		[Address(RVA = "0x22EFF00", Offset = "0x22EEB00", VA = "0x1822EFF00", Slot = "7")]
		public virtual bool TryDismissBackPress()
		{
			return default(bool);
		}

		// Token: 0x06027DDD RID: 163293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DDD")]
		[Address(RVA = "0x22EFDB0", Offset = "0x22EE9B0", VA = "0x1822EFDB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06027DDE RID: 163294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DDE")]
		[Address(RVA = "0x22EF950", Offset = "0x22EE550", VA = "0x1822EF950", Slot = "8")]
		protected virtual void Destroy()
		{
		}

		// Token: 0x17005E4C RID: 24140
		// (get) Token: 0x06027DDF RID: 163295 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027DE0 RID: 163296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E4C")]
		private protected UIPage page
		{
			[Token(Token = "0x6027DDF")]
			[Address(RVA = "0x22F0060", Offset = "0x22EEC60", VA = "0x1822F0060")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6027DE0")]
			[Address(RVA = "0x22F01A0", Offset = "0x22EEDA0", VA = "0x1822F01A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E4D RID: 24141
		// (get) Token: 0x06027DE1 RID: 163297 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027DE2 RID: 163298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E4D")]
		private protected State state
		{
			[Token(Token = "0x6027DE1")]
			[Address(RVA = "0x22F00C0", Offset = "0x22EECC0", VA = "0x1822F00C0")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6027DE2")]
			[Address(RVA = "0x22F0220", Offset = "0x22EEE20", VA = "0x1822F0220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005E4E RID: 24142
		// (get) Token: 0x06027DE3 RID: 163299 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06027DE4 RID: 163300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005E4E")]
		private protected DataBundle actMetaBundle
		{
			[Token(Token = "0x6027DE3")]
			[Address(RVA = "0x22F0000", Offset = "0x22EEC00", VA = "0x1822F0000")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6027DE4")]
			[Address(RVA = "0x22F0120", Offset = "0x22EED20", VA = "0x1822F0120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06027DE5 RID: 163301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DE5")]
		[Address(RVA = "0x22EF9B0", Offset = "0x22EE5B0", VA = "0x1822EF9B0")]
		public void Dismiss()
		{
		}

		// Token: 0x06027DE6 RID: 163302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DE6")]
		[Address(RVA = "0x22EFAD0", Offset = "0x22EE6D0", VA = "0x1822EFAD0")]
		public void InjectHosts(State pState)
		{
		}

		// Token: 0x06027DE7 RID: 163303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DE7")]
		[Address(RVA = "0x22EFA20", Offset = "0x22EE620", VA = "0x1822EFA20")]
		public void InjectActMetaBundle(DataBundle actMeta)
		{
		}

		// Token: 0x06027DE8 RID: 163304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027DE8")]
		[Address(RVA = "0x22EFC40", Offset = "0x22EE840", VA = "0x1822EFC40")]
		protected Sprite LoadSpriteFromAutoPackHub(string spriteId, string hubPath)
		{
			return null;
		}

		// Token: 0x06027DE9 RID: 163305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027DE9")]
		[Address(RVA = "0x22EFF60", Offset = "0x22EEB60", VA = "0x1822EFF60")]
		protected ActivityCommonEntry()
		{
		}

		// Token: 0x0403883C RID: 231484
		[Token(Token = "0x403883C")]
		[FieldOffset(Offset = "0x18")]
		private UIAssetLoader.Assets m_assets;

		// Token: 0x0403883D RID: 231485
		[Token(Token = "0x403883D")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public UnityEvent DismissFunc;

		// Token: 0x04038841 RID: 231489
		[Token(Token = "0x4038841")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04038842 RID: 231490
		[Token(Token = "0x4038842")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04038843 RID: 231491
		[Token(Token = "0x4038843")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TryDismissBackPress;

		// Token: 0x04038844 RID: 231492
		[Token(Token = "0x4038844")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04038845 RID: 231493
		[Token(Token = "0x4038845")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Destroy;

		// Token: 0x04038846 RID: 231494
		[Token(Token = "0x4038846")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x04038847 RID: 231495
		[Token(Token = "0x4038847")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x04038848 RID: 231496
		[Token(Token = "0x4038848")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x04038849 RID: 231497
		[Token(Token = "0x4038849")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x0403884A RID: 231498
		[Token(Token = "0x403884A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_actMetaBundle;

		// Token: 0x0403884B RID: 231499
		[Token(Token = "0x403884B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_actMetaBundle;

		// Token: 0x0403884C RID: 231500
		[Token(Token = "0x403884C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_Dismiss;

		// Token: 0x0403884D RID: 231501
		[Token(Token = "0x403884D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_InjectHosts;

		// Token: 0x0403884E RID: 231502
		[Token(Token = "0x403884E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_InjectActMetaBundle;

		// Token: 0x0403884F RID: 231503
		[Token(Token = "0x403884F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_LoadSpriteFromAutoPackHub;

		// Token: 0x04038850 RID: 231504
		[Token(Token = "0x4038850")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
