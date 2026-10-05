using System;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005CA2 RID: 23714
	[Token(Token = "0x2005CA2")]
	public class ClimbTowerPanelPreviewBoss : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022540 RID: 140608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022540")]
		[Address(RVA = "0x1CC0480", Offset = "0x1CBF080", VA = "0x181CC0480")]
		public void Render(ClimbTowerLevelModel levelModel, ClimbTowerLevelPreviewViewModel model)
		{
		}

		// Token: 0x06022541 RID: 140609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022541")]
		[Address(RVA = "0x1CC06E0", Offset = "0x1CBF2E0", VA = "0x181CC06E0")]
		public ClimbTowerPanelPreviewBoss()
		{
		}

		// Token: 0x0402F24A RID: 193098
		[Token(Token = "0x402F24A")]
		private const string MAX_LAYER_FORMAT = "/{0}";

		// Token: 0x0402F24B RID: 193099
		[Token(Token = "0x402F24B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textLevelNum;

		// Token: 0x0402F24C RID: 193100
		[Token(Token = "0x402F24C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textLevelTotalNum;

		// Token: 0x0402F24D RID: 193101
		[Token(Token = "0x402F24D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private EnemyHandBookDetailView _bossDetailView;

		// Token: 0x0402F24E RID: 193102
		[Token(Token = "0x402F24E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _imgBossInfo;

		// Token: 0x0402F24F RID: 193103
		[Token(Token = "0x402F24F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasObject _atlas;

		// Token: 0x0402F250 RID: 193104
		[Token(Token = "0x402F250")]
		private const string BOSS_INFO_PREFIX = "img_boss_info{0}";

		// Token: 0x0402F251 RID: 193105
		[Token(Token = "0x402F251")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F252 RID: 193106
		[Token(Token = "0x402F252")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
