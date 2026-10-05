using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007232 RID: 29234
	[Token(Token = "0x2007232")]
	public class Act5D1RuneShowSelectObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x060296DF RID: 169695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296DF")]
		[Address(RVA = "0x24CB2D0", Offset = "0x24C9ED0", VA = "0x1824CB2D0")]
		public void Click()
		{
		}

		// Token: 0x060296E0 RID: 169696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296E0")]
		[Address(RVA = "0x24CAEE0", Offset = "0x24C9AE0", VA = "0x1824CAEE0")]
		public void ApplyData(RuneInfo runeInput)
		{
		}

		// Token: 0x060296E1 RID: 169697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296E1")]
		[Address(RVA = "0x24CB380", Offset = "0x24C9F80", VA = "0x1824CB380")]
		public Act5D1RuneShowSelectObj()
		{
		}

		// Token: 0x0403B2DD RID: 242397
		[Token(Token = "0x403B2DD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _runeName;

		// Token: 0x0403B2DE RID: 242398
		[Token(Token = "0x403B2DE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _runeIcon;

		// Token: 0x0403B2DF RID: 242399
		[Token(Token = "0x403B2DF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _runePoint;

		// Token: 0x0403B2E0 RID: 242400
		[Token(Token = "0x403B2E0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _runeDetail;

		// Token: 0x0403B2E1 RID: 242401
		[Token(Token = "0x403B2E1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _runeDescription;

		// Token: 0x0403B2E2 RID: 242402
		[Token(Token = "0x403B2E2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _runeLockedInfo;

		// Token: 0x0403B2E3 RID: 242403
		[Token(Token = "0x403B2E3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _runeLocked;

		// Token: 0x0403B2E4 RID: 242404
		[Token(Token = "0x403B2E4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pointPart;

		// Token: 0x0403B2E5 RID: 242405
		[Token(Token = "0x403B2E5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _newHandPoint;

		// Token: 0x0403B2E6 RID: 242406
		[Token(Token = "0x403B2E6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _isSelectedPart;

		// Token: 0x0403B2E7 RID: 242407
		[Token(Token = "0x403B2E7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _isBanned;

		// Token: 0x0403B2E8 RID: 242408
		[Token(Token = "0x403B2E8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _isNotAvailable;

		// Token: 0x0403B2E9 RID: 242409
		[Token(Token = "0x403B2E9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _isAbleToUnlock;

		// Token: 0x0403B2EA RID: 242410
		[Token(Token = "0x403B2EA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button _clickBtn;

		// Token: 0x0403B2EB RID: 242411
		[Token(Token = "0x403B2EB")]
		[FieldOffset(Offset = "0x88")]
		[NonSerialized]
		public UIStringEvent clickEvent;

		// Token: 0x0403B2EC RID: 242412
		[Token(Token = "0x403B2EC")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0403B2ED RID: 242413
		[Token(Token = "0x403B2ED")]
		[FieldOffset(Offset = "0x98")]
		private string m_cacheRuneId;

		// Token: 0x0403B2EE RID: 242414
		[Token(Token = "0x403B2EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Click;

		// Token: 0x0403B2EF RID: 242415
		[Token(Token = "0x403B2EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0403B2F0 RID: 242416
		[Token(Token = "0x403B2F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
