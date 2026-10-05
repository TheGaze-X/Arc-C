using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Battle.DevelopTools.Tester
{
	// Token: 0x020028A3 RID: 10403
	[Token(Token = "0x20028A3")]
	public class BattleReplaySettings : MonoBehaviour
	{
		// Token: 0x060114E4 RID: 70884 RVA: 0x0006A920 File Offset: 0x00068B20
		[Token(Token = "0x60114E4")]
		[Address(RVA = "0x91CC00", Offset = "0x91B800", VA = "0x18091CC00")]
		public bool TryGetBattlelog(string replayFile, out AutoBattleConvertUtil.BattleLog battleLog)
		{
			return default(bool);
		}

		// Token: 0x060114E5 RID: 70885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60114E5")]
		[Address(RVA = "0x91CB60", Offset = "0x91B760", VA = "0x18091CB60")]
		public List<AdvancedCharacterInst> ConvertToCharacterInst(AutoBattleConvertUtil.BattleLog battleLog, out AdvancedCharacterInst assistChar)
		{
			return null;
		}

		// Token: 0x060114E6 RID: 70886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60114E6")]
		[Address(RVA = "0x91CBB0", Offset = "0x91B7B0", VA = "0x18091CBB0")]
		public List<AdvancedCharacterInst> ConvertToCharacterInst(BattleLogger.Journal journal, out AdvancedCharacterInst assistChar)
		{
			return null;
		}

		// Token: 0x060114E7 RID: 70887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60114E7")]
		[Address(RVA = "0x91CF80", Offset = "0x91BB80", VA = "0x18091CF80")]
		private List<AdvancedCharacterInst> _DoConvertToCharacterInst(BattleLogger.Journal journal, out AdvancedCharacterInst assistChar)
		{
			return null;
		}

		// Token: 0x060114E8 RID: 70888 RVA: 0x0006A938 File Offset: 0x00068B38
		[Token(Token = "0x60114E8")]
		[Address(RVA = "0x91CC60", Offset = "0x91B860", VA = "0x18091CC60")]
		public bool TryGetRuneList(AutoBattleConvertUtil.BattleLog battleLog, out List<RuneTable.PackedRuneData> runeList)
		{
			return default(bool);
		}

		// Token: 0x060114E9 RID: 70889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60114E9")]
		[Address(RVA = "0x91D2A0", Offset = "0x91BEA0", VA = "0x18091D2A0")]
		private static string _GetCharIdFromPossbileSkinId(string skinOrCharId, string tmplId)
		{
			return null;
		}

		// Token: 0x060114EA RID: 70890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60114EA")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BattleReplaySettings()
		{
		}

		// Token: 0x0401354B RID: 79179
		[Token(Token = "0x401354B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextAsset _runeTableJson;
	}
}
