using System;
using Il2CppDummyDll;
using Torappu.CharWord;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003397 RID: 13207
	[Token(Token = "0x2003397")]
	public class AutoChessGameModeVoicePlugin : VoicePlayer.DefaultGamePlugin
	{
		// Token: 0x06015101 RID: 86273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015101")]
		[Address(RVA = "0xD67930", Offset = "0xD66530", VA = "0x180D67930", Slot = "4")]
		public override void Init(VoicePlayer voicePlayer)
		{
		}

		// Token: 0x06015102 RID: 86274 RVA: 0x0008A390 File Offset: 0x00088590
		[Token(Token = "0x6015102")]
		[Address(RVA = "0xD67830", Offset = "0xD66430", VA = "0x180D67830", Slot = "5")]
		public override bool HookPlayVoice(ref BattleVoiceOption.BattleVoiceType voiceType, ref VoiceQuery vq, ref MapLayer mapLayer, out VoiceManager.PlayResult result)
		{
			return default(bool);
		}

		// Token: 0x06015103 RID: 86275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015103")]
		[Address(RVA = "0xD67B80", Offset = "0xD66780", VA = "0x180D67B80")]
		private void _OnBattleStarted(object arg)
		{
		}

		// Token: 0x06015104 RID: 86276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015104")]
		[Address(RVA = "0xD67F70", Offset = "0xD66B70", VA = "0x180D67F70")]
		private void _OnCharacterPlacedAtBattle(object arg)
		{
		}

		// Token: 0x06015105 RID: 86277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015105")]
		[Address(RVA = "0xD67DA0", Offset = "0xD669A0", VA = "0x180D67DA0")]
		private void _OnCharacterHighlighted(object arg)
		{
		}

		// Token: 0x06015106 RID: 86278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015106")]
		[Address(RVA = "0xD68170", Offset = "0xD66D70", VA = "0x180D68170")]
		public AutoChessGameModeVoicePlugin()
		{
		}

		// Token: 0x06015107 RID: 86279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015107")]
		[Address(RVA = "0xD67B70", Offset = "0xD66770", VA = "0x180D67B70")]
		private void <>xLuaBaseProxy_Init(VoicePlayer P0)
		{
		}

		// Token: 0x06015108 RID: 86280 RVA: 0x0008A3A8 File Offset: 0x000885A8
		[Token(Token = "0x6015108")]
		[Address(RVA = "0xD67A90", Offset = "0xD66690", VA = "0x180D67A90")]
		private bool <>xLuaBaseProxy_HookPlayVoice(ref BattleVoiceOption.BattleVoiceType P0, ref VoiceQuery P1, ref MapLayer P2, out VoiceManager.PlayResult P3)
		{
			return default(bool);
		}

		// Token: 0x04019135 RID: 102709
		[Token(Token = "0x4019135")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04019136 RID: 102710
		[Token(Token = "0x4019136")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HookPlayVoice;

		// Token: 0x04019137 RID: 102711
		[Token(Token = "0x4019137")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnBattleStarted;

		// Token: 0x04019138 RID: 102712
		[Token(Token = "0x4019138")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnCharacterPlacedAtBattle;

		// Token: 0x04019139 RID: 102713
		[Token(Token = "0x4019139")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnCharacterHighlighted;

		// Token: 0x0401913A RID: 102714
		[Token(Token = "0x401913A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
