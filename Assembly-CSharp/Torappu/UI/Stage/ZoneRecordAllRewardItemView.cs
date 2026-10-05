using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020069D9 RID: 27097
	[Token(Token = "0x20069D9")]
	public class ZoneRecordAllRewardItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026C31 RID: 158769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C31")]
		[Address(RVA = "0x21DBB90", Offset = "0x21DA790", VA = "0x1821DBB90")]
		public void Render(ZoneRecordViewModel viewModel, int idx)
		{
		}

		// Token: 0x06026C32 RID: 158770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C32")]
		[Address(RVA = "0x21DBE60", Offset = "0x21DAA60", VA = "0x1821DBE60")]
		private void _RenderReward(ZoneRecordRewardViewModel rewardViewModel)
		{
		}

		// Token: 0x06026C33 RID: 158771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6026C33")]
		[Address(RVA = "0x21DBCF0", Offset = "0x21DA8F0", VA = "0x1821DBCF0")]
		private List<UIItemViewModel> _GenRewardViewModel(ItemBundle[] items)
		{
			return null;
		}

		// Token: 0x06026C34 RID: 158772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026C34")]
		[Address(RVA = "0x21DC0F0", Offset = "0x21DACF0", VA = "0x1821DC0F0")]
		public ZoneRecordAllRewardItemView()
		{
		}

		// Token: 0x04036BFF RID: 224255
		[Token(Token = "0x4036BFF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _easyRewards;

		// Token: 0x04036C00 RID: 224256
		[Token(Token = "0x4036C00")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _normalRewards;

		// Token: 0x04036C01 RID: 224257
		[Token(Token = "0x4036C01")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _toughRewards;

		// Token: 0x04036C02 RID: 224258
		[Token(Token = "0x4036C02")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _recordName;

		// Token: 0x04036C03 RID: 224259
		[Token(Token = "0x4036C03")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _lightBg;

		// Token: 0x04036C04 RID: 224260
		[Token(Token = "0x4036C04")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _darkBg;

		// Token: 0x04036C05 RID: 224261
		[Token(Token = "0x4036C05")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _itemCardScaler;

		// Token: 0x04036C06 RID: 224262
		[Token(Token = "0x4036C06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036C07 RID: 224263
		[Token(Token = "0x4036C07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderReward;

		// Token: 0x04036C08 RID: 224264
		[Token(Token = "0x4036C08")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenRewardViewModel;

		// Token: 0x04036C09 RID: 224265
		[Token(Token = "0x4036C09")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
