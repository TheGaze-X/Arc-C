using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001FB1 RID: 8113
	[Token(Token = "0x2001FB1")]
	public class UIAudioPreloader : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C978 RID: 51576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C978")]
		[Address(RVA = "0x34B5F10", Offset = "0x34B4B10", VA = "0x1834B5F10")]
		private void Start()
		{
		}

		// Token: 0x0600C979 RID: 51577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C979")]
		[Address(RVA = "0x34B6380", Offset = "0x34B4F80", VA = "0x1834B6380")]
		public UIAudioPreloader()
		{
		}

		// Token: 0x0400D1D8 RID: 53720
		[Token(Token = "0x400D1D8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _preloadInternalSounds;

		// Token: 0x0400D1D9 RID: 53721
		[Token(Token = "0x400D1D9")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _preloadBuildingSounds;

		// Token: 0x0400D1DA RID: 53722
		[Token(Token = "0x400D1DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] _extraSignals;

		// Token: 0x0400D1DB RID: 53723
		[Token(Token = "0x400D1DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400D1DC RID: 53724
		[Token(Token = "0x400D1DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
