using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.FunLive
{
	// Token: 0x0200268C RID: 9868
	[Token(Token = "0x200268C")]
	public class FunLiveUIBattlePhotoItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060101E0 RID: 66016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101E0")]
		[Address(RVA = "0x7C5810", Offset = "0x7C4410", VA = "0x1807C5810")]
		private void Awake()
		{
		}

		// Token: 0x060101E1 RID: 66017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101E1")]
		[Address(RVA = "0x7C5000", Offset = "0x7C3C00", VA = "0x1807C5000")]
		public void ApplyData(string ev)
		{
		}

		// Token: 0x060101E2 RID: 66018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101E2")]
		[Address(RVA = "0x7C5A20", Offset = "0x7C4620", VA = "0x1807C5A20")]
		public FunLiveUIBattlePhotoItem()
		{
		}

		// Token: 0x04011F3C RID: 73532
		[Token(Token = "0x4011F3C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _contentPicture;

		// Token: 0x04011F3D RID: 73533
		[Token(Token = "0x4011F3D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _emojiIcon;

		// Token: 0x04011F3E RID: 73534
		[Token(Token = "0x4011F3E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _normalEventCntTransform;

		// Token: 0x04011F3F RID: 73535
		[Token(Token = "0x4011F3F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _normalEventCnt;

		// Token: 0x04011F40 RID: 73536
		[Token(Token = "0x4011F40")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _photoDescription;

		// Token: 0x04011F41 RID: 73537
		[Token(Token = "0x4011F41")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _tagDescription;

		// Token: 0x04011F42 RID: 73538
		[Token(Token = "0x4011F42")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("iconGroup")]
		private FunLiveUIBattlePhotoItemAttributeIcon _pinkIconGroup;

		// Token: 0x04011F43 RID: 73539
		[Token(Token = "0x4011F43")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("iconGroup")]
		private FunLiveUIBattlePhotoItemAttributeIcon _yellowIconGroup;

		// Token: 0x04011F44 RID: 73540
		[Token(Token = "0x4011F44")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("iconGroup")]
		private FunLiveUIBattlePhotoItemAttributeIcon _blueIconGroup;

		// Token: 0x04011F45 RID: 73541
		[Token(Token = "0x4011F45")]
		[FieldOffset(Offset = "0x60")]
		private Dictionary<string, Act4funLiveMatInfoData> m_normalDataList;

		// Token: 0x04011F46 RID: 73542
		[Token(Token = "0x4011F46")]
		[FieldOffset(Offset = "0x68")]
		private Dictionary<string, Act4funSpLiveMatInfoData> m_rareDataList;

		// Token: 0x04011F47 RID: 73543
		[Token(Token = "0x4011F47")]
		[FieldOffset(Offset = "0x70")]
		private Dictionary<string, Act4funValueEffectInfoData> m_rareValueDataList;

		// Token: 0x04011F48 RID: 73544
		[Token(Token = "0x4011F48")]
		[FieldOffset(Offset = "0x78")]
		private GameModeFactory.FunLiveGameMode m_gameMode;

		// Token: 0x04011F49 RID: 73545
		[Token(Token = "0x4011F49")]
		[FieldOffset(Offset = "0x80")]
		private int m_levelIndex;

		// Token: 0x04011F4A RID: 73546
		[Token(Token = "0x4011F4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04011F4B RID: 73547
		[Token(Token = "0x4011F4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x04011F4C RID: 73548
		[Token(Token = "0x4011F4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
