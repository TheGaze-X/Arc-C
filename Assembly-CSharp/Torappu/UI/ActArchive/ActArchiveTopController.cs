using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006AF4 RID: 27380
	[Token(Token = "0x2006AF4")]
	public class ActArchiveTopController : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005C8A RID: 23690
		// (get) Token: 0x06027266 RID: 160358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005C8A")]
		public ActArchiveResHolder resHolder
		{
			[Token(Token = "0x6027266")]
			[Address(RVA = "0x224E500", Offset = "0x224D100", VA = "0x18224E500")]
			get
			{
				return null;
			}
		}

		// Token: 0x06027267 RID: 160359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027267")]
		[Address(RVA = "0x224E2E0", Offset = "0x224CEE0", VA = "0x18224E2E0", Slot = "4")]
		public virtual void Init(ActArchiveProxy proxy)
		{
		}

		// Token: 0x06027268 RID: 160360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027268")]
		[Address(RVA = "0x224E360", Offset = "0x224CF60", VA = "0x18224E360")]
		public void SetGlobalActive(bool active)
		{
		}

		// Token: 0x06027269 RID: 160361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027269")]
		[Address(RVA = "0x224E400", Offset = "0x224D000", VA = "0x18224E400")]
		public void SetLocalActive(bool active)
		{
		}

		// Token: 0x0602726A RID: 160362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602726A")]
		[Address(RVA = "0x224E4A0", Offset = "0x224D0A0", VA = "0x18224E4A0")]
		public ActArchiveTopController()
		{
		}

		// Token: 0x0403761E RID: 226846
		[Token(Token = "0x403761E")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public ActArchiveProxy proxy;

		// Token: 0x0403761F RID: 226847
		[Token(Token = "0x403761F")]
		[FieldOffset(Offset = "0x20")]
		private bool m_globalActive;

		// Token: 0x04037620 RID: 226848
		[Token(Token = "0x4037620")]
		[FieldOffset(Offset = "0x21")]
		private bool m_localActive;

		// Token: 0x04037621 RID: 226849
		[Token(Token = "0x4037621")]
		[FieldOffset(Offset = "0x28")]
		private ActArchiveResHolder m_resHolder;

		// Token: 0x04037622 RID: 226850
		[Token(Token = "0x4037622")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_resHolder;

		// Token: 0x04037623 RID: 226851
		[Token(Token = "0x4037623")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04037624 RID: 226852
		[Token(Token = "0x4037624")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetGlobalActive;

		// Token: 0x04037625 RID: 226853
		[Token(Token = "0x4037625")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetLocalActive;

		// Token: 0x04037626 RID: 226854
		[Token(Token = "0x4037626")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
