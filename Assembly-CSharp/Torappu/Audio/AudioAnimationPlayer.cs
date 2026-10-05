using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001F99 RID: 8089
	[Token(Token = "0x2001F99")]
	public class AudioAnimationPlayer : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C8F4 RID: 51444 RVA: 0x00048FC0 File Offset: 0x000471C0
		[Token(Token = "0x600C8F4")]
		[Address(RVA = "0x3496290", Offset = "0x3494E90", VA = "0x183496290")]
		private bool _TryGetCondition(string signal)
		{
			return default(bool);
		}

		// Token: 0x0600C8F5 RID: 51445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8F5")]
		[Address(RVA = "0x34961E0", Offset = "0x3494DE0", VA = "0x1834961E0")]
		public void EventPlayUI(string signal)
		{
		}

		// Token: 0x0600C8F6 RID: 51446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8F6")]
		[Address(RVA = "0x3496080", Offset = "0x3494C80", VA = "0x183496080")]
		public void EventPlayBattle(string signal)
		{
		}

		// Token: 0x0600C8F7 RID: 51447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8F7")]
		[Address(RVA = "0x3496130", Offset = "0x3494D30", VA = "0x183496130")]
		public void EventPlaySystem(string signal)
		{
		}

		// Token: 0x0600C8F8 RID: 51448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C8F8")]
		[Address(RVA = "0x3496460", Offset = "0x3495060", VA = "0x183496460")]
		public AudioAnimationPlayer()
		{
		}

		// Token: 0x0400CF82 RID: 53122
		[Token(Token = "0x400CF82")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<AudioAnimationPlayer.ProviderConfig> _providerConfigs;

		// Token: 0x0400CF83 RID: 53123
		[Token(Token = "0x400CF83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__TryGetCondition;

		// Token: 0x0400CF84 RID: 53124
		[Token(Token = "0x400CF84")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventPlayUI;

		// Token: 0x0400CF85 RID: 53125
		[Token(Token = "0x400CF85")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventPlayBattle;

		// Token: 0x0400CF86 RID: 53126
		[Token(Token = "0x400CF86")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventPlaySystem;

		// Token: 0x0400CF87 RID: 53127
		[Token(Token = "0x400CF87")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001F9A RID: 8090
		[Token(Token = "0x2001F9A")]
		[Serializable]
		public struct ProviderConfig
		{
			// Token: 0x0400CF88 RID: 53128
			[Token(Token = "0x400CF88")]
			[FieldOffset(Offset = "0x0")]
			public string signal;

			// Token: 0x0400CF89 RID: 53129
			[Token(Token = "0x400CF89")]
			[FieldOffset(Offset = "0x8")]
			public GameObject provider;
		}
	}
}
