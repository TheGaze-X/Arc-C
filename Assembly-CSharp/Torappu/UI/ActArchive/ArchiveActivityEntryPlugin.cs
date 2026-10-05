using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006B03 RID: 27395
	[Token(Token = "0x2006B03")]
	public abstract class ArchiveActivityEntryPlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x060272BA RID: 160442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272BA")]
		[Address(RVA = "0x22537E0", Offset = "0x22523E0", VA = "0x1822537E0", Slot = "4")]
		public virtual void OnEnter()
		{
		}

		// Token: 0x060272BB RID: 160443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272BB")]
		[Address(RVA = "0x22538A0", Offset = "0x22524A0", VA = "0x1822538A0", Slot = "5")]
		public virtual void OnInit()
		{
		}

		// Token: 0x060272BC RID: 160444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272BC")]
		[Address(RVA = "0x2253840", Offset = "0x2252440", VA = "0x182253840", Slot = "6")]
		public virtual void OnExit()
		{
		}

		// Token: 0x060272BD RID: 160445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60272BD")]
		[Address(RVA = "0x2253900", Offset = "0x2252500", VA = "0x182253900")]
		protected ArchiveActivityEntryPlugin()
		{
		}

		// Token: 0x0403768A RID: 226954
		[Token(Token = "0x403768A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403768B RID: 226955
		[Token(Token = "0x403768B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403768C RID: 226956
		[Token(Token = "0x403768C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403768D RID: 226957
		[Token(Token = "0x403768D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
