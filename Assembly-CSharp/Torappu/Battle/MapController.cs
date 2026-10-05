using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002261 RID: 8801
	[Token(Token = "0x2002261")]
	public class MapController : IHotfixable
	{
		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x0600DD48 RID: 56648 RVA: 0x00050C70 File Offset: 0x0004EE70
		[Token(Token = "0x17001BDF")]
		public virtual MapTags tag
		{
			[Token(Token = "0x600DD48")]
			[Address(RVA = "0x363C230", Offset = "0x363AE30", VA = "0x18363C230", Slot = "4")]
			get
			{
				return MapTags.DEFAULT;
			}
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x0600DD49 RID: 56649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001BE0")]
		public Map map
		{
			[Token(Token = "0x600DD49")]
			[Address(RVA = "0x363C1D0", Offset = "0x363ADD0", VA = "0x18363C1D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DD4A RID: 56650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD4A")]
		[Address(RVA = "0x363C170", Offset = "0x363AD70", VA = "0x18363C170")]
		public MapController()
		{
		}

		// Token: 0x0600DD4B RID: 56651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD4B")]
		[Address(RVA = "0x363C090", Offset = "0x363AC90", VA = "0x18363C090", Slot = "5")]
		public virtual void Init(Map battleMap)
		{
		}

		// Token: 0x0600DD4C RID: 56652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DD4C")]
		[Address(RVA = "0x363C110", Offset = "0x363AD10", VA = "0x18363C110", Slot = "6")]
		public virtual void Reset()
		{
		}

		// Token: 0x0400EFB9 RID: 61369
		[Token(Token = "0x400EFB9")]
		[FieldOffset(Offset = "0x10")]
		private Map m_map;

		// Token: 0x0400EFBA RID: 61370
		[Token(Token = "0x400EFBA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_tag;

		// Token: 0x0400EFBB RID: 61371
		[Token(Token = "0x400EFBB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_map;

		// Token: 0x0400EFBC RID: 61372
		[Token(Token = "0x400EFBC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400EFBD RID: 61373
		[Token(Token = "0x400EFBD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400EFBE RID: 61374
		[Token(Token = "0x400EFBE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Reset;
	}
}
