using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1Lock
{
	// Token: 0x02007873 RID: 30835
	[Token(Token = "0x2007873")]
	public class Act1LockPointView : MonoBehaviour, IPlayerDataListener, IHotfixable
	{
		// Token: 0x0602B379 RID: 177017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B379")]
		[Address(RVA = "0x270E740", Offset = "0x270D340", VA = "0x18270E740")]
		public void Init()
		{
		}

		// Token: 0x0602B37A RID: 177018 RVA: 0x000DB300 File Offset: 0x000D9500
		[Token(Token = "0x602B37A")]
		[Address(RVA = "0x270E5D0", Offset = "0x270D1D0", VA = "0x18270E5D0", Slot = "4")]
		public bool CheckIfDataChanged(PlayerDataModel prevData, PlayerDataModel curData, PlayerDataDelta delta)
		{
			return default(bool);
		}

		// Token: 0x0602B37B RID: 177019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B37B")]
		[Address(RVA = "0x270E8C0", Offset = "0x270D4C0", VA = "0x18270E8C0", Slot = "5")]
		public void OnPlayerDataChanged()
		{
		}

		// Token: 0x0602B37C RID: 177020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B37C")]
		[Address(RVA = "0x270E920", Offset = "0x270D520", VA = "0x18270E920")]
		private void _TryUpdatePoints()
		{
		}

		// Token: 0x0602B37D RID: 177021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B37D")]
		[Address(RVA = "0x270E860", Offset = "0x270D460", VA = "0x18270E860")]
		private void OnEnable()
		{
		}

		// Token: 0x0602B37E RID: 177022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B37E")]
		[Address(RVA = "0x270E800", Offset = "0x270D400", VA = "0x18270E800")]
		private void OnDisable()
		{
		}

		// Token: 0x0602B37F RID: 177023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B37F")]
		[Address(RVA = "0x270E7A0", Offset = "0x270D3A0", VA = "0x18270E7A0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602B380 RID: 177024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B380")]
		[Address(RVA = "0x270EA40", Offset = "0x270D640", VA = "0x18270EA40")]
		public Act1LockPointView()
		{
		}

		// Token: 0x0403E7AD RID: 255917
		[Token(Token = "0x403E7AD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textPoint;

		// Token: 0x0403E7AE RID: 255918
		[Token(Token = "0x403E7AE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0403E7AF RID: 255919
		[Token(Token = "0x403E7AF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckIfDataChanged;

		// Token: 0x0403E7B0 RID: 255920
		[Token(Token = "0x403E7B0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0403E7B1 RID: 255921
		[Token(Token = "0x403E7B1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryUpdatePoints;

		// Token: 0x0403E7B2 RID: 255922
		[Token(Token = "0x403E7B2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0403E7B3 RID: 255923
		[Token(Token = "0x403E7B3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0403E7B4 RID: 255924
		[Token(Token = "0x403E7B4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403E7B5 RID: 255925
		[Token(Token = "0x403E7B5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
