using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AA4 RID: 31396
	[Token(Token = "0x2007AA4")]
	public class Act12sideCoinView : MonoBehaviour, IHotfixable, IPlayerDataListener
	{
		// Token: 0x0602BFB6 RID: 180150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFB6")]
		[Address(RVA = "0x27D7E80", Offset = "0x27D6A80", VA = "0x1827D7E80")]
		public void Init(string actId)
		{
		}

		// Token: 0x0602BFB7 RID: 180151 RVA: 0x000DDD90 File Offset: 0x000DBF90
		[Token(Token = "0x602BFB7")]
		[Address(RVA = "0x27D7D20", Offset = "0x27D6920", VA = "0x1827D7D20", Slot = "4")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0602BFB8 RID: 180152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFB8")]
		[Address(RVA = "0x27D8020", Offset = "0x27D6C20", VA = "0x1827D8020", Slot = "5")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0602BFB9 RID: 180153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFB9")]
		[Address(RVA = "0x27D8080", Offset = "0x27D6C80", VA = "0x1827D8080")]
		private void _TryUpdateCoin()
		{
		}

		// Token: 0x0602BFBA RID: 180154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFBA")]
		[Address(RVA = "0x27D7FC0", Offset = "0x27D6BC0", VA = "0x1827D7FC0")]
		private void OnEnable()
		{
		}

		// Token: 0x0602BFBB RID: 180155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFBB")]
		[Address(RVA = "0x27D7F60", Offset = "0x27D6B60", VA = "0x1827D7F60")]
		private void OnDisable()
		{
		}

		// Token: 0x0602BFBC RID: 180156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFBC")]
		[Address(RVA = "0x27D7F00", Offset = "0x27D6B00", VA = "0x1827D7F00")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602BFBD RID: 180157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFBD")]
		[Address(RVA = "0x27D81E0", Offset = "0x27D6DE0", VA = "0x1827D81E0")]
		public Act12sideCoinView()
		{
		}

		// Token: 0x0403FB48 RID: 260936
		[Token(Token = "0x403FB48")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text[] _coinTextList;

		// Token: 0x0403FB49 RID: 260937
		[Token(Token = "0x403FB49")]
		[FieldOffset(Offset = "0x20")]
		private string m_actId;

		// Token: 0x0403FB4A RID: 260938
		[Token(Token = "0x403FB4A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403FB4B RID: 260939
		[Token(Token = "0x403FB4B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0403FB4C RID: 260940
		[Token(Token = "0x403FB4C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0403FB4D RID: 260941
		[Token(Token = "0x403FB4D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryUpdateCoin;

		// Token: 0x0403FB4E RID: 260942
		[Token(Token = "0x403FB4E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403FB4F RID: 260943
		[Token(Token = "0x403FB4F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0403FB50 RID: 260944
		[Token(Token = "0x403FB50")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403FB51 RID: 260945
		[Token(Token = "0x403FB51")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
