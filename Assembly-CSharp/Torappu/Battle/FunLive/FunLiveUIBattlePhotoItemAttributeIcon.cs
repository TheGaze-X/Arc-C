using System;
using Il2CppDummyDll;
using Torappu.Battle.GameMode;
using UnityEngine;
using XLua;

namespace Torappu.Battle.FunLive
{
	// Token: 0x0200268D RID: 9869
	[Token(Token = "0x200268D")]
	public class FunLiveUIBattlePhotoItemAttributeIcon : MonoBehaviour, IHotfixable
	{
		// Token: 0x060101E3 RID: 66019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101E3")]
		[Address(RVA = "0x7C4BF0", Offset = "0x7C37F0", VA = "0x1807C4BF0")]
		private void Awake()
		{
		}

		// Token: 0x060101E4 RID: 66020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101E4")]
		[Address(RVA = "0x7C4F20", Offset = "0x7C3B20", VA = "0x1807C4F20")]
		public void SetIconEnable(bool enable)
		{
		}

		// Token: 0x060101E5 RID: 66021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101E5")]
		[Address(RVA = "0x7C4D80", Offset = "0x7C3980", VA = "0x1807C4D80")]
		public void SetIconAttributeLevel(int value)
		{
		}

		// Token: 0x060101E6 RID: 66022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60101E6")]
		[Address(RVA = "0x7C4FA0", Offset = "0x7C3BA0", VA = "0x1807C4FA0")]
		public FunLiveUIBattlePhotoItemAttributeIcon()
		{
		}

		// Token: 0x04011F4D RID: 73549
		[Token(Token = "0x4011F4D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _questionMark;

		// Token: 0x04011F4E RID: 73550
		[Token(Token = "0x4011F4E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _firstLevel;

		// Token: 0x04011F4F RID: 73551
		[Token(Token = "0x4011F4F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _firstLevelDown;

		// Token: 0x04011F50 RID: 73552
		[Token(Token = "0x4011F50")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _secondLevel;

		// Token: 0x04011F51 RID: 73553
		[Token(Token = "0x4011F51")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _secondLevelDown;

		// Token: 0x04011F52 RID: 73554
		[Token(Token = "0x4011F52")]
		[FieldOffset(Offset = "0x40")]
		private int m_attributeDiffNum;

		// Token: 0x04011F53 RID: 73555
		[Token(Token = "0x4011F53")]
		[FieldOffset(Offset = "0x48")]
		private GameModeFactory.FunLiveGameMode m_gameMode;

		// Token: 0x04011F54 RID: 73556
		[Token(Token = "0x4011F54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04011F55 RID: 73557
		[Token(Token = "0x4011F55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetIconEnable;

		// Token: 0x04011F56 RID: 73558
		[Token(Token = "0x4011F56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetIconAttributeLevel;

		// Token: 0x04011F57 RID: 73559
		[Token(Token = "0x4011F57")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
