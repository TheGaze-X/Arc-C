using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle.Tiles
{
	// Token: 0x020029F5 RID: 10741
	[Token(Token = "0x20029F5")]
	public class UniformRandomTrigger : Tile.Behaviour
	{
		// Token: 0x06011D17 RID: 72983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D17")]
		[Address(RVA = "0x9BF320", Offset = "0x9BDF20", VA = "0x1809BF320", Slot = "4")]
		public override void Init(Tile tile)
		{
		}

		// Token: 0x06011D18 RID: 72984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D18")]
		[Address(RVA = "0x9BF490", Offset = "0x9BE090", VA = "0x1809BF490", Slot = "9")]
		public override void OnGameStart()
		{
		}

		// Token: 0x06011D19 RID: 72985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D19")]
		[Address(RVA = "0x9BF420", Offset = "0x9BE020", VA = "0x1809BF420", Slot = "10")]
		public override void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x06011D1A RID: 72986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D1A")]
		[Address(RVA = "0x9BF550", Offset = "0x9BE150", VA = "0x1809BF550", Slot = "11")]
		public override void PreloadAssets()
		{
		}

		// Token: 0x06011D1B RID: 72987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011D1B")]
		[Address(RVA = "0x9BF5D0", Offset = "0x9BE1D0", VA = "0x1809BF5D0")]
		private IEnumerator _DoTrigProcess()
		{
			return null;
		}

		// Token: 0x06011D1C RID: 72988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011D1C")]
		[Address(RVA = "0x9BF650", Offset = "0x9BE250", VA = "0x1809BF650")]
		public UniformRandomTrigger()
		{
		}

		// Token: 0x0401403D RID: 81981
		[Token(Token = "0x401403D")]
		private const string BLACKBOARD_KEY_CD_MIN = "cd_min";

		// Token: 0x0401403E RID: 81982
		[Token(Token = "0x401403E")]
		private const string BLACKBOARD_KEY_CD_MAX = "cd_max";

		// Token: 0x0401403F RID: 81983
		[Token(Token = "0x401403F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _preDelay;

		// Token: 0x04014040 RID: 81984
		[Token(Token = "0x4014040")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _preDelayEffect;

		// Token: 0x04014041 RID: 81985
		[Token(Token = "0x4014041")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _defaultInterval;

		// Token: 0x04014042 RID: 81986
		[Token(Token = "0x4014042")]
		[FieldOffset(Offset = "0x34")]
		private float m_minCd;

		// Token: 0x04014043 RID: 81987
		[Token(Token = "0x4014043")]
		[FieldOffset(Offset = "0x38")]
		private float m_maxCd;
	}
}
