using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B2C RID: 31532
	[Token(Token = "0x2007B2C")]
	public class Act10D5CoinView : MonoBehaviour, IPlayerDataListener, IHotfixable
	{
		// Token: 0x0602C257 RID: 180823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C257")]
		[Address(RVA = "0x2803CD0", Offset = "0x28028D0", VA = "0x182803CD0")]
		public void Init()
		{
		}

		// Token: 0x0602C258 RID: 180824 RVA: 0x000DE408 File Offset: 0x000DC608
		[Token(Token = "0x602C258")]
		[Address(RVA = "0x2803BF0", Offset = "0x28027F0", VA = "0x182803BF0", Slot = "4")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0602C259 RID: 180825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C259")]
		[Address(RVA = "0x2803E50", Offset = "0x2802A50", VA = "0x182803E50", Slot = "5")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0602C25A RID: 180826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C25A")]
		[Address(RVA = "0x2803F90", Offset = "0x2802B90", VA = "0x182803F90")]
		private void _TryUpdateCoin()
		{
		}

		// Token: 0x0602C25B RID: 180827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602C25B")]
		[Address(RVA = "0x2803EB0", Offset = "0x2802AB0", VA = "0x182803EB0")]
		private static PlayerActivity.PlayerMiniStoryActivity _GetMiniStoryAct(string actId, PlayerDataModel data)
		{
			return null;
		}

		// Token: 0x0602C25C RID: 180828 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C25C")]
		[Address(RVA = "0x2803DF0", Offset = "0x28029F0", VA = "0x182803DF0")]
		private void OnEnable()
		{
		}

		// Token: 0x0602C25D RID: 180829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C25D")]
		[Address(RVA = "0x2803D90", Offset = "0x2802990", VA = "0x182803D90")]
		private void OnDisable()
		{
		}

		// Token: 0x0602C25E RID: 180830 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C25E")]
		[Address(RVA = "0x2803D30", Offset = "0x2802930", VA = "0x182803D30")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602C25F RID: 180831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C25F")]
		[Address(RVA = "0x2804050", Offset = "0x2802C50", VA = "0x182804050")]
		public Act10D5CoinView()
		{
		}

		// Token: 0x0403FFD0 RID: 262096
		[Token(Token = "0x403FFD0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCoin;

		// Token: 0x0403FFD1 RID: 262097
		[Token(Token = "0x403FFD1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403FFD2 RID: 262098
		[Token(Token = "0x403FFD2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0403FFD3 RID: 262099
		[Token(Token = "0x403FFD3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0403FFD4 RID: 262100
		[Token(Token = "0x403FFD4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryUpdateCoin;

		// Token: 0x0403FFD5 RID: 262101
		[Token(Token = "0x403FFD5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetMiniStoryAct;

		// Token: 0x0403FFD6 RID: 262102
		[Token(Token = "0x403FFD6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403FFD7 RID: 262103
		[Token(Token = "0x403FFD7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0403FFD8 RID: 262104
		[Token(Token = "0x403FFD8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403FFD9 RID: 262105
		[Token(Token = "0x403FFD9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
