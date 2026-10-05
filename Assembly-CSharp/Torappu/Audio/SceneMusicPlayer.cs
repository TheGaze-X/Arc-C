using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Audio
{
	// Token: 0x02001FAF RID: 8111
	[Token(Token = "0x2001FAF")]
	public class SceneMusicPlayer : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600C96E RID: 51566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C96E")]
		[Address(RVA = "0x34B0920", Offset = "0x34AF520", VA = "0x1834B0920")]
		private void Start()
		{
		}

		// Token: 0x0600C96F RID: 51567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C96F")]
		[Address(RVA = "0x34B0C80", Offset = "0x34AF880", VA = "0x1834B0C80")]
		private void _StartImpl()
		{
		}

		// Token: 0x0600C970 RID: 51568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C970")]
		[Address(RVA = "0x34B07E0", Offset = "0x34AF3E0", VA = "0x1834B07E0")]
		public static void GameFlowController_AutoTrigger(string sceneName)
		{
		}

		// Token: 0x0600C971 RID: 51569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C971")]
		[Address(RVA = "0x34B0890", Offset = "0x34AF490", VA = "0x1834B0890")]
		public static void ManuallyTrigger()
		{
		}

		// Token: 0x0600C972 RID: 51570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C972")]
		[Address(RVA = "0x34B0A20", Offset = "0x34AF620", VA = "0x1834B0A20")]
		public static void StopAll()
		{
		}

		// Token: 0x0600C973 RID: 51571 RVA: 0x000492C0 File Offset: 0x000474C0
		[Token(Token = "0x600C973")]
		[Address(RVA = "0x34B0AC0", Offset = "0x34AF6C0", VA = "0x1834B0AC0")]
		private static bool _IsAutoTriggerDisabled(string sceneName)
		{
			return default(bool);
		}

		// Token: 0x0600C974 RID: 51572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C974")]
		[Address(RVA = "0x34B0BD0", Offset = "0x34AF7D0", VA = "0x1834B0BD0")]
		private static void _PlayBGM(string sceneName)
		{
		}

		// Token: 0x0600C975 RID: 51573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C975")]
		[Address(RVA = "0x34B0EB0", Offset = "0x34AFAB0", VA = "0x1834B0EB0")]
		public SceneMusicPlayer()
		{
		}

		// Token: 0x0400D044 RID: 53316
		[Token(Token = "0x400D044")]
		[FieldOffset(Offset = "0x0")]
		private static readonly string[] SCENES_DISABLE_AUTO_PLAY;

		// Token: 0x0400D045 RID: 53317
		[Token(Token = "0x400D045")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400D046 RID: 53318
		[Token(Token = "0x400D046")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__StartImpl;

		// Token: 0x0400D047 RID: 53319
		[Token(Token = "0x400D047")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GameFlowController_AutoTrigger;

		// Token: 0x0400D048 RID: 53320
		[Token(Token = "0x400D048")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ManuallyTrigger;

		// Token: 0x0400D049 RID: 53321
		[Token(Token = "0x400D049")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StopAll;

		// Token: 0x0400D04A RID: 53322
		[Token(Token = "0x400D04A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsAutoTriggerDisabled;

		// Token: 0x0400D04B RID: 53323
		[Token(Token = "0x400D04B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayBGM;

		// Token: 0x0400D04C RID: 53324
		[Token(Token = "0x400D04C")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
