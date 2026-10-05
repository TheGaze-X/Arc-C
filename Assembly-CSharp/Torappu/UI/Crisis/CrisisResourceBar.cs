using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Crisis
{
	// Token: 0x02005A05 RID: 23045
	[Token(Token = "0x2005A05")]
	public class CrisisResourceBar : MonoBehaviour, IPlayerDataListener, IHotfixable
	{
		// Token: 0x06021940 RID: 137536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021940")]
		[Address(RVA = "0x1C04160", Offset = "0x1C02D60", VA = "0x181C04160")]
		public void InitAndBind(CrisisResourceBar.Option option)
		{
		}

		// Token: 0x06021941 RID: 137537 RVA: 0x000BAD20 File Offset: 0x000B8F20
		[Token(Token = "0x6021941")]
		[Address(RVA = "0x1C04010", Offset = "0x1C02C10", VA = "0x181C04010", Slot = "4")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x06021942 RID: 137538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021942")]
		[Address(RVA = "0x1C042C0", Offset = "0x1C02EC0", VA = "0x181C042C0", Slot = "5")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x06021943 RID: 137539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021943")]
		[Address(RVA = "0x1C04450", Offset = "0x1C03050", VA = "0x181C04450")]
		public void UnBind()
		{
		}

		// Token: 0x06021944 RID: 137540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021944")]
		[Address(RVA = "0x1C04260", Offset = "0x1C02E60", VA = "0x181C04260")]
		private void OnDestroy()
		{
		}

		// Token: 0x06021945 RID: 137541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021945")]
		[Address(RVA = "0x1C044B0", Offset = "0x1C030B0", VA = "0x181C044B0")]
		public CrisisResourceBar()
		{
		}

		// Token: 0x0402DE27 RID: 187943
		[Token(Token = "0x402DE27")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _shopCoinResourceBar;

		// Token: 0x0402DE28 RID: 187944
		[Token(Token = "0x402DE28")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _unlockCoinResourceBar;

		// Token: 0x0402DE29 RID: 187945
		[Token(Token = "0x402DE29")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _shopCoinCount;

		// Token: 0x0402DE2A RID: 187946
		[Token(Token = "0x402DE2A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _unlockCoinCount;

		// Token: 0x0402DE2B RID: 187947
		[Token(Token = "0x402DE2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitAndBind;

		// Token: 0x0402DE2C RID: 187948
		[Token(Token = "0x402DE2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0402DE2D RID: 187949
		[Token(Token = "0x402DE2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0402DE2E RID: 187950
		[Token(Token = "0x402DE2E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UnBind;

		// Token: 0x0402DE2F RID: 187951
		[Token(Token = "0x402DE2F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402DE30 RID: 187952
		[Token(Token = "0x402DE30")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005A06 RID: 23046
		[Token(Token = "0x2005A06")]
		[Serializable]
		public class Option
		{
			// Token: 0x06021946 RID: 137542 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021946")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Option()
			{
			}

			// Token: 0x0402DE31 RID: 187953
			[Token(Token = "0x402DE31")]
			[FieldOffset(Offset = "0x10")]
			public bool shopCoinAvail;

			// Token: 0x0402DE32 RID: 187954
			[Token(Token = "0x402DE32")]
			[FieldOffset(Offset = "0x11")]
			public bool unlockCoinAvail;
		}
	}
}
