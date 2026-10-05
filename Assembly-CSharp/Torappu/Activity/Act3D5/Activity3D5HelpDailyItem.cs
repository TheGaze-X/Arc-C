using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D5
{
	// Token: 0x020073C5 RID: 29637
	[Token(Token = "0x20073C5")]
	public class Activity3D5HelpDailyItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029DED RID: 171501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DED")]
		[Address(RVA = "0x257C640", Offset = "0x257B240", VA = "0x18257C640")]
		public void Refresh(string actId)
		{
		}

		// Token: 0x06029DEE RID: 171502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DEE")]
		[Address(RVA = "0x257CDB0", Offset = "0x257B9B0", VA = "0x18257CDB0")]
		public Activity3D5HelpDailyItem()
		{
		}

		// Token: 0x0403C016 RID: 245782
		[Token(Token = "0x403C016")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _complete;

		// Token: 0x0403C017 RID: 245783
		[Token(Token = "0x403C017")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _requirement;

		// Token: 0x0403C018 RID: 245784
		[Token(Token = "0x403C018")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _flagIcon;

		// Token: 0x0403C019 RID: 245785
		[Token(Token = "0x403C019")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _descLabel;

		// Token: 0x0403C01A RID: 245786
		[Token(Token = "0x403C01A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _itemDescLabel;

		// Token: 0x0403C01B RID: 245787
		[Token(Token = "0x403C01B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _prgLabel;

		// Token: 0x0403C01C RID: 245788
		[Token(Token = "0x403C01C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _itemIconRoot;

		// Token: 0x0403C01D RID: 245789
		[Token(Token = "0x403C01D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Refresh;

		// Token: 0x0403C01E RID: 245790
		[Token(Token = "0x403C01E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
