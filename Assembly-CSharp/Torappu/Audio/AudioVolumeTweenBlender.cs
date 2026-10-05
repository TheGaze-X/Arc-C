using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001FAD RID: 8109
	[Token(Token = "0x2001FAD")]
	public class AudioVolumeTweenBlender : IAudioTweenValueBlender, IHotfixable
	{
		// Token: 0x0600C966 RID: 51558 RVA: 0x00049290 File Offset: 0x00047490
		[Token(Token = "0x600C966")]
		[Address(RVA = "0x34A4C10", Offset = "0x34A3810", VA = "0x1834A4C10", Slot = "4")]
		public float GetValue()
		{
			return 0f;
		}

		// Token: 0x0600C967 RID: 51559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C967")]
		[Address(RVA = "0x34A4730", Offset = "0x34A3330", VA = "0x1834A4730", Slot = "5")]
		public void AddBlenderItem(string channelName, AudioChannelEffect channelEffect)
		{
		}

		// Token: 0x0600C968 RID: 51560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C968")]
		[Address(RVA = "0x34A4F40", Offset = "0x34A3B40", VA = "0x1834A4F40", Slot = "6")]
		public void RefreshItems()
		{
		}

		// Token: 0x0600C969 RID: 51561 RVA: 0x000492A8 File Offset: 0x000474A8
		[Token(Token = "0x600C969")]
		[Address(RVA = "0x34A4DC0", Offset = "0x34A39C0", VA = "0x1834A4DC0", Slot = "7")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x0600C96A RID: 51562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C96A")]
		[Address(RVA = "0x34A51F0", Offset = "0x34A3DF0", VA = "0x1834A51F0", Slot = "8")]
		public void RemoveBlenderItem(AudioChannelEffect channelEffect)
		{
		}

		// Token: 0x0600C96B RID: 51563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C96B")]
		[Address(RVA = "0x34A4B90", Offset = "0x34A3790", VA = "0x1834A4B90", Slot = "9")]
		public void Clear()
		{
		}

		// Token: 0x0600C96C RID: 51564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C96C")]
		[Address(RVA = "0x34A53F0", Offset = "0x34A3FF0", VA = "0x1834A53F0")]
		public AudioVolumeTweenBlender()
		{
		}

		// Token: 0x0400D03B RID: 53307
		[Token(Token = "0x400D03B")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<long, AudioTweenBlenderItem> m_activeBlenderItems;

		// Token: 0x0400D03C RID: 53308
		[Token(Token = "0x400D03C")]
		[FieldOffset(Offset = "0x18")]
		private List<long> m_pendingRemoveKeys;

		// Token: 0x0400D03D RID: 53309
		[Token(Token = "0x400D03D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetValue;

		// Token: 0x0400D03E RID: 53310
		[Token(Token = "0x400D03E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddBlenderItem;

		// Token: 0x0400D03F RID: 53311
		[Token(Token = "0x400D03F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshItems;

		// Token: 0x0400D040 RID: 53312
		[Token(Token = "0x400D040")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsActive;

		// Token: 0x0400D041 RID: 53313
		[Token(Token = "0x400D041")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RemoveBlenderItem;

		// Token: 0x0400D042 RID: 53314
		[Token(Token = "0x400D042")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x0400D043 RID: 53315
		[Token(Token = "0x400D043")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
