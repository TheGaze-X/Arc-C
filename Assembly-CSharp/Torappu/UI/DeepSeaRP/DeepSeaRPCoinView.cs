using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200512A RID: 20778
	[Token(Token = "0x200512A")]
	public class DeepSeaRPCoinView : MonoBehaviour, IPlayerDataListener, IHotfixable
	{
		// Token: 0x0601EAFD RID: 125693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAFD")]
		[Address(RVA = "0x1854580", Offset = "0x1853180", VA = "0x181854580")]
		public void Init()
		{
		}

		// Token: 0x0601EAFE RID: 125694 RVA: 0x000AF3C8 File Offset: 0x000AD5C8
		[Token(Token = "0x601EAFE")]
		[Address(RVA = "0x1854410", Offset = "0x1853010", VA = "0x181854410", Slot = "4")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0601EAFF RID: 125695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EAFF")]
		[Address(RVA = "0x1854700", Offset = "0x1853300", VA = "0x181854700", Slot = "5")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x17004783 RID: 18307
		// (get) Token: 0x0601EB00 RID: 125696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004783")]
		public static string activityId
		{
			[Token(Token = "0x601EB00")]
			[Address(RVA = "0x18548E0", Offset = "0x18534E0", VA = "0x1818548E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601EB01 RID: 125697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB01")]
		[Address(RVA = "0x1854760", Offset = "0x1853360", VA = "0x181854760")]
		private void _TryUpdateCoin()
		{
		}

		// Token: 0x0601EB02 RID: 125698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB02")]
		[Address(RVA = "0x18546A0", Offset = "0x18532A0", VA = "0x1818546A0")]
		private void OnEnable()
		{
		}

		// Token: 0x0601EB03 RID: 125699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB03")]
		[Address(RVA = "0x1854640", Offset = "0x1853240", VA = "0x181854640")]
		private void OnDisable()
		{
		}

		// Token: 0x0601EB04 RID: 125700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB04")]
		[Address(RVA = "0x18545E0", Offset = "0x18531E0", VA = "0x1818545E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601EB05 RID: 125701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB05")]
		[Address(RVA = "0x1854880", Offset = "0x1853480", VA = "0x181854880")]
		public DeepSeaRPCoinView()
		{
		}

		// Token: 0x04029252 RID: 168530
		[Token(Token = "0x4029252")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCoin;

		// Token: 0x04029253 RID: 168531
		[Token(Token = "0x4029253")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04029254 RID: 168532
		[Token(Token = "0x4029254")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x04029255 RID: 168533
		[Token(Token = "0x4029255")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x04029256 RID: 168534
		[Token(Token = "0x4029256")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_activityId;

		// Token: 0x04029257 RID: 168535
		[Token(Token = "0x4029257")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryUpdateCoin;

		// Token: 0x04029258 RID: 168536
		[Token(Token = "0x4029258")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04029259 RID: 168537
		[Token(Token = "0x4029259")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0402925A RID: 168538
		[Token(Token = "0x402925A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0402925B RID: 168539
		[Token(Token = "0x402925B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
