using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Audio.Middleware.Data
{
	// Token: 0x02001FB9 RID: 8121
	[Token(Token = "0x2001FB9")]
	[Serializable]
	public abstract class Bank : IHotfixable
	{
		// Token: 0x170017E4 RID: 6116
		// (get) Token: 0x0600C9B2 RID: 51634 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600C9B3 RID: 51635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170017E4")]
		public string bankName
		{
			[Token(Token = "0x600C9B2")]
			[Address(RVA = "0x34A6C20", Offset = "0x34A5820", VA = "0x1834A6C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600C9B3")]
			[Address(RVA = "0x34A6C80", Offset = "0x34A5880", VA = "0x1834A6C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170017E5 RID: 6117
		// (get) Token: 0x0600C9B4 RID: 51636 RVA: 0x00049380 File Offset: 0x00047580
		[Token(Token = "0x170017E5")]
		public int atomCount
		{
			[Token(Token = "0x600C9B4")]
			[Address(RVA = "0x34A6BB0", Offset = "0x34A57B0", VA = "0x1834A6BB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600C9B5 RID: 51637
		[Token(Token = "0x600C9B5")]
		public abstract AudioAtom Play(Vector3 position);

		// Token: 0x0600C9B6 RID: 51638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9B6")]
		[Address(RVA = "0x34A5FE0", Offset = "0x34A4BE0", VA = "0x1834A5FE0", Slot = "5")]
		public virtual void Preload(string persistTag)
		{
		}

		// Token: 0x0600C9B7 RID: 51639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9B7")]
		[Address(RVA = "0x34A6730", Offset = "0x34A5330", VA = "0x1834A6730")]
		public void Init(TorappuAudioMiddleware middleware, string bankName)
		{
		}

		// Token: 0x0600C9B8 RID: 51640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9B8")]
		[Address(RVA = "0x34A6890", Offset = "0x34A5490", VA = "0x1834A6890", Slot = "6")]
		protected virtual void OnInit()
		{
		}

		// Token: 0x0600C9B9 RID: 51641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9B9")]
		[Address(RVA = "0x34A6A00", Offset = "0x34A5600", VA = "0x1834A6A00", Slot = "7")]
		public virtual void Update(float deltaTime)
		{
		}

		// Token: 0x0600C9BA RID: 51642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9BA")]
		[Address(RVA = "0x34A68F0", Offset = "0x34A54F0", VA = "0x1834A68F0")]
		public void StopAtoms(float fadetime)
		{
		}

		// Token: 0x0600C9BB RID: 51643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C9BB")]
		[Address(RVA = "0x34A6B50", Offset = "0x34A5750", VA = "0x1834A6B50")]
		protected Bank()
		{
		}

		// Token: 0x0400D213 RID: 53779
		[Token(Token = "0x400D213")]
		[FieldOffset(Offset = "0x10")]
		protected TorappuAudioMiddleware middleware;

		// Token: 0x0400D214 RID: 53780
		[Token(Token = "0x400D214")]
		[FieldOffset(Offset = "0x18")]
		protected List<AudioAtom> m_activeAtoms;

		// Token: 0x0400D216 RID: 53782
		[Token(Token = "0x400D216")]
		[FieldOffset(Offset = "0x28")]
		public string name;

		// Token: 0x0400D217 RID: 53783
		[Token(Token = "0x400D217")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bankName;

		// Token: 0x0400D218 RID: 53784
		[Token(Token = "0x400D218")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bankName;

		// Token: 0x0400D219 RID: 53785
		[Token(Token = "0x400D219")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_atomCount;

		// Token: 0x0400D21A RID: 53786
		[Token(Token = "0x400D21A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Preload;

		// Token: 0x0400D21B RID: 53787
		[Token(Token = "0x400D21B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400D21C RID: 53788
		[Token(Token = "0x400D21C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D21D RID: 53789
		[Token(Token = "0x400D21D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D21E RID: 53790
		[Token(Token = "0x400D21E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_StopAtoms;

		// Token: 0x0400D21F RID: 53791
		[Token(Token = "0x400D21F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
