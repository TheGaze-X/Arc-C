using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.AVG;
using Torappu.UI;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x02002652 RID: 9810
	[Token(Token = "0x2002652")]
	public class AVGBattleTutorialPlugin : AVGTutorialPanel.IAVGTutorialPanelPlugin
	{
		// Token: 0x0601007F RID: 65663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601007F")]
		[Address(RVA = "0x7BC390", Offset = "0x7BAF90", VA = "0x1807BC390")]
		public AVGBattleTutorialPlugin()
		{
		}

		// Token: 0x06010080 RID: 65664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010080")]
		[Address(RVA = "0x7BB610", Offset = "0x7BA210", VA = "0x1807BB610")]
		public void RegisterExtraTarget(string name, GameObject target)
		{
		}

		// Token: 0x06010081 RID: 65665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010081")]
		[Address(RVA = "0x7BB5C0", Offset = "0x7BA1C0", VA = "0x1807BB5C0", Slot = "7")]
		public void OnReset()
		{
		}

		// Token: 0x06010082 RID: 65666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010082")]
		[Address(RVA = "0x7BBB10", Offset = "0x7BA710", VA = "0x1807BBB10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06010083 RID: 65667 RVA: 0x000619C8 File Offset: 0x0005FBC8
		[Token(Token = "0x6010083")]
		[Address(RVA = "0x7BB900", Offset = "0x7BA500", VA = "0x1807BB900", Slot = "4")]
		public bool TryGetInputBlockerPos(Command command, ref Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x06010084 RID: 65668 RVA: 0x000619E0 File Offset: 0x0005FBE0
		[Token(Token = "0x6010084")]
		[Address(RVA = "0x7BB840", Offset = "0x7BA440", VA = "0x1807BB840", Slot = "5")]
		public bool TryGetFocusPos(Command command, ref Vector3 pos, ref AVGTutorialPanel.AnchorType ancher)
		{
			return default(bool);
		}

		// Token: 0x06010085 RID: 65669 RVA: 0x000619F8 File Offset: 0x0005FBF8
		[Token(Token = "0x6010085")]
		[Address(RVA = "0x7BB9D0", Offset = "0x7BA5D0", VA = "0x1807BB9D0")]
		private bool TryGetPos(Command command, ref Vector3 pos)
		{
			return default(bool);
		}

		// Token: 0x06010086 RID: 65670 RVA: 0x00061A10 File Offset: 0x0005FC10
		[Token(Token = "0x6010086")]
		[Address(RVA = "0x7BB680", Offset = "0x7BA280", VA = "0x1807BB680", Slot = "6")]
		public bool TryGetDragPos(Command command, ref Vector2 pos, bool isStartPos)
		{
			return default(bool);
		}

		// Token: 0x06010087 RID: 65671 RVA: 0x00061A28 File Offset: 0x0005FC28
		[Token(Token = "0x6010087")]
		[Address(RVA = "0x7BBC20", Offset = "0x7BA820", VA = "0x1807BBC20")]
		private bool _TryGetCardListPos(Command command, string cardIndexFlag, string cardStartDirectionFlag, ref Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x06010088 RID: 65672 RVA: 0x00061A40 File Offset: 0x0005FC40
		[Token(Token = "0x6010088")]
		[Address(RVA = "0x7BC130", Offset = "0x7BAD30", VA = "0x1807BC130")]
		private bool _TryGetTilePos(Command command, string tilePosX, string tilePosY, ref Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x06010089 RID: 65673 RVA: 0x00061A58 File Offset: 0x0005FC58
		[Token(Token = "0x6010089")]
		[Address(RVA = "0x7BBEE0", Offset = "0x7BAAE0", VA = "0x1807BBEE0")]
		private bool _TryGetTargetPos(Command command, string targetKey, ref Vector2 pos)
		{
			return default(bool);
		}

		// Token: 0x04011D49 RID: 73033
		[Token(Token = "0x4011D49")]
		private const string CARD_INDEX = "cardIndex";

		// Token: 0x04011D4A RID: 73034
		[Token(Token = "0x4011D4A")]
		private const string CARD_START_ANCHOR = "rightStart";

		// Token: 0x04011D4B RID: 73035
		[Token(Token = "0x4011D4B")]
		private const string CARD_INDEX_START = "startCardIndex";

		// Token: 0x04011D4C RID: 73036
		[Token(Token = "0x4011D4C")]
		private const string CARD_START_ANCHOR_START = "startRightStart";

		// Token: 0x04011D4D RID: 73037
		[Token(Token = "0x4011D4D")]
		private const string CARD_INDEX_END = "endCardIndex";

		// Token: 0x04011D4E RID: 73038
		[Token(Token = "0x4011D4E")]
		private const string CARD_START_ANCHOR_END = "endRightStart";

		// Token: 0x04011D4F RID: 73039
		[Token(Token = "0x4011D4F")]
		private const string TILE_X = "tileX";

		// Token: 0x04011D50 RID: 73040
		[Token(Token = "0x4011D50")]
		private const string TILE_Y = "tileY";

		// Token: 0x04011D51 RID: 73041
		[Token(Token = "0x4011D51")]
		private const string START_TILE_X = "startTileX";

		// Token: 0x04011D52 RID: 73042
		[Token(Token = "0x4011D52")]
		private const string START_TILE_Y = "startTileY";

		// Token: 0x04011D53 RID: 73043
		[Token(Token = "0x4011D53")]
		private const string END_TILE_X = "endTileX";

		// Token: 0x04011D54 RID: 73044
		[Token(Token = "0x4011D54")]
		private const string END_TILE_Y = "endTileY";

		// Token: 0x04011D55 RID: 73045
		[Token(Token = "0x4011D55")]
		private const string BATTLE_TARGET = "battleTarget";

		// Token: 0x04011D56 RID: 73046
		[Token(Token = "0x4011D56")]
		private const string START_BATTLE_TARGET = "startBattleTarget";

		// Token: 0x04011D57 RID: 73047
		[Token(Token = "0x4011D57")]
		private const string END_BATTLE_TARGET = "endBattleTarget";

		// Token: 0x04011D58 RID: 73048
		[Token(Token = "0x4011D58")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, GameObject> m_targetPool;

		// Token: 0x04011D59 RID: 73049
		[Token(Token = "0x4011D59")]
		[FieldOffset(Offset = "0x18")]
		private UICanvasScalerHelper m_helper;
	}
}
